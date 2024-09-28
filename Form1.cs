using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAnalyzerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnAnalyze_Click(object sender, EventArgs e)
        {
            string text = txtInput.Text;

            var report = await Task.Run(() => AnalyzeText(text));

            if (rbtnShowOnScreen.Checked)
            {
                txtReport.Text = report;
            }
            else if (rbtnSaveToFile.Checked)
            {
                SaveReportToFile(report);
                MessageBox.Show("Отчет сохранен в файл.");
            }
        }

        private string AnalyzeText(string text)
        {
            int sentenceCount = Regex.Matches(text, @"[.!?]").Count; 
            int charCount = text.Length;                             
            int wordCount = Regex.Matches(text, @"\b\w+\b").Count;  
            int questionCount = Regex.Matches(text, @"\?").Count;    
            int exclamationCount = Regex.Matches(text, @"!").Count;  

            return $"Количество предложений: {sentenceCount}\r\n" +
                   $"Количество символов: {charCount}\r\n" +
                   $"Количество слов: {wordCount}\r\n" +
                   $"Количество вопросительных предложений: {questionCount}\r\n" +
                   $"Количество восклицательных предложений: {exclamationCount}\r\n";
        }

        private void SaveReportToFile(string report)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "TextReport.txt");
            File.WriteAllText(filePath, report);
        }
    }
}
