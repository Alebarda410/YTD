using System.Diagnostics;
using System.Text.RegularExpressions;

namespace YTD
{
    public partial class Form1 : Form
    {
        private string savePath;
        private Process proc;
        private readonly Regex percentRegex = new(@"(\d+)\%");
        private readonly Regex speadRegex = new(@":\d+[\.\d][\.\d]*[A-Z]");
        private bool isFirstComplite = false;

        public Form1()
        {
            InitializeComponent();
            QualityComboBox.SelectedItem = "1080";
            savePath = Directory.GetCurrentDirectory();
        }

        private void AddData(string data)
        {
            BeginInvoke(() => LogRichTextBox.AppendText($"{data}\n"));
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            isFirstComplite = false;
            LogRichTextBox.Clear();
            ProgressBar.Value = 0;

            // �������� � ��������� ���� � ������� ��� ����������
            var ytdlpPath = Path.Combine(Directory.GetCurrentDirectory(), "yt-dlp.exe");
            if (!File.Exists(ytdlpPath))
            {
                LogRichTextBox.AppendText("� ���������� ����������� yt-dlp.exe");
                return;
            }

            // �������� � ��������� ���� � ��������������� ���������� (��� ��������� �������� ����������)
            var aria2cPath = Path.Combine(Directory.GetCurrentDirectory(), "aria2c.exe");
            if (!File.Exists(aria2cPath))
            {
                LogRichTextBox.AppendText("� ���������� ����������� aria2c.exe");
                return;
            }

            // ��������� ������������ ���������� ������
            var urlLink = UrlLinkTextBox.Text;
            if (!Uri.IsWellFormedUriString(urlLink, UriKind.Absolute))
            {
                LogRichTextBox.AppendText("��������� ������ �� �������� �������");
                return;
            }

            var paramList = new List<string>()
            {
                $"-f bv[height<={QualityComboBox.Text}][ext=mp4]+ba[ext=m4a]/bv[height<={QualityComboBox.Text}]+ba",
                $"--external-downloader {aria2cPath}",
                @"--external-downloader-args ""--min-split-size=1M --max-connection-per-server=16 --max-concurrent-downloads=16 --split=16""",
                "--merge-output-format mp4",
                "-o %(title)s",
                $"-P {savePath}",
                urlLink
            };
            var param = string.Join(' ', paramList);

            proc = new Process();
            proc.StartInfo.FileName = ytdlpPath;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.Arguments = param;

            proc.ErrorDataReceived += DataHandler;
            proc.OutputDataReceived += DataHandler;
            proc.Exited += ExitHandler;

            proc.Start();
            AddData("���������� ��������, ��������");
            proc.BeginOutputReadLine();
            proc.BeginErrorReadLine();
            await proc.WaitForExitAsync();
            proc.Close();
        }
        private void ExitHandler(object sender, EventArgs e)
        {
            isFirstComplite = false;
            AddData("\n��� ������!");
            BeginInvoke(() => ProgressBar.Value = 0);
        }
        private void DataHandler(object sender, DataReceivedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Data) || e.Data.StartsWith(' ') || e.Data.StartsWith("[info]")
                || e.Data.StartsWith("[youtube]") || e.Data.StartsWith("Deleting"))
            {
                return;
            }

            if (percentRegex.IsMatch(e.Data) && !e.Data.Contains("100%"))
            {
                BeginInvoke(() => ProgressBar.Value = int.Parse(percentRegex.Match(e.Data).Groups[1].Value));
                BeginInvoke(() =>
                {
                    if (!LogRichTextBox.Lines[^2].StartsWith("������"))
                    {
                        LogRichTextBox.Undo();
                        LogRichTextBox.ClearUndo();
                    }

                    LogRichTextBox.AppendText($"�������� ��������{speadRegex.Match(e.Data).Value.Replace(":", ": ")}�/���\n");
                });
            }
            else if (e.Data.StartsWith("[#")) return;
            else if (e.Data.StartsWith("[download] Destination"))
            {
                BeginInvoke(() => ProgressBar.Value = 0);
                if (!isFirstComplite) AddData("������ �������� �����");
                else AddData("������ �������� �����");
            }
            else if (e.Data.StartsWith("[download] 100%"))
            {
                BeginInvoke(() => ProgressBar.Value = 100);
                if (!isFirstComplite)
                {
                    BeginInvoke(() =>
                    {
                        LogRichTextBox.Undo();
                        LogRichTextBox.ClearUndo();
                    });
                    AddData("����� �������");
                    isFirstComplite = true;
                }
                else
                {
                    BeginInvoke(() =>
                    {
                        LogRichTextBox.Undo();
                        LogRichTextBox.ClearUndo();
                    });
                    AddData("����� �������");
                }
            }

            else if (e.Data.StartsWith("[Merger]"))
            {
                AddData("������ ������� ����� � �����");
            }
            else
            {
                AddData(e.Data);
            }

        }
        private void SetSaveFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                savePath = folderBrowserDialog1.SelectedPath;
                AddData($"���� �� �����: {savePath}");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            proc?.Close();
        }
    }
}