using System.Diagnostics;
using System.Text.RegularExpressions;

namespace YTD
{
    public partial class Form1 : Form
    {
        private string savePath;
        private Process proc;
        private readonly Regex regex = new(@"(\d+)\%");
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

            // получаем и проверяем путь к утилите для скачивания
            var ytdlpPath = Path.Combine(Directory.GetCurrentDirectory(), "yt-dlp.exe");
            if (!File.Exists(ytdlpPath))
            {
                LogRichTextBox.AppendText("В директории отсутствует yt-dlp.exe");
                return;
            }

            // получаем и проверяем путь к альтернативному загрузчику (для повышения скорости скачивания)
            var aria2cPath = Path.Combine(Directory.GetCurrentDirectory(), "aria2c.exe");
            if (!File.Exists(aria2cPath))
            {
                LogRichTextBox.AppendText("В директории отсутствует aria2c.exe");
                return;
            }

            // проверяем корректность введенного адреса
            var urlLink = UrlLinkTextBox.Text;
            if (!Uri.IsWellFormedUriString(urlLink, UriKind.Absolute))
            {
                LogRichTextBox.AppendText("Введенная ссылка не является рабочей");
                return;
            }

            var paramList = new List<string>()
            {
                @$"-f 'bv[height<={QualityComboBox.Text}][ext=mp4]+ba[ext=m4a]/bv[height<={QualityComboBox.Text}]+ba",
                $"--external-downloader {aria2cPath}",
                "--merge-output-format mp4",
                urlLink,
                "-o %(title)s",
                $"-P {savePath}"
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
            AddData("Программа запущена, ожидайте");
            proc.BeginOutputReadLine();
            proc.BeginErrorReadLine();
            await proc.WaitForExitAsync();
            proc.Close();
        }
        private void ExitHandler(object sender, EventArgs e)
        {
            isFirstComplite = false;
            AddData("\nВсе готово!");
            BeginInvoke(() => ProgressBar.Value = 0);
        }
        private void DataHandler(object sender, DataReceivedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Data) || e.Data.StartsWith(' ') || e.Data.StartsWith("[info]")
                || e.Data.StartsWith("[youtube]") || e.Data.StartsWith("Deleting"))
            { 
                return; 
            }

            if (regex.IsMatch(e.Data) && !e.Data.Contains("100%"))
            {
                BeginInvoke(() => ProgressBar.Value = int.Parse(regex.Match(e.Data).Groups[1].Value));
            }
            else if (e.Data.StartsWith("[#")) return;
            else if (e.Data.StartsWith("[download] Destination"))
            {
                BeginInvoke(() => ProgressBar.Value = 0);
                if (!isFirstComplite) AddData("Начата загрузка видео");
                else AddData("Начата загрузка аудио");
            }
            else if (e.Data.StartsWith("[download] 100%"))
            {
                BeginInvoke(() => ProgressBar.Value = 100);
                if (!isFirstComplite)
                {
                    AddData("Видео скачано");
                    isFirstComplite = true;
                }
                else AddData("Аудио скачано");
            }

            else if (e.Data.StartsWith("[Merger]"))
            {
                AddData("Начато слияние видео с аудио");
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
                AddData($"Путь до файла: {savePath}");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            proc?.Close();
        }
    }
}