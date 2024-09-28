namespace TextAnalyzerApp
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.RadioButton rbtnShowOnScreen;
        private System.Windows.Forms.RadioButton rbtnSaveToFile;
        private System.Windows.Forms.TextBox txtReport;

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.rbtnShowOnScreen = new System.Windows.Forms.RadioButton();
            this.rbtnSaveToFile = new System.Windows.Forms.RadioButton();
            this.txtReport = new System.Windows.Forms.TextBox();

            this.SuspendLayout();

            // TextBox для ввода текста
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Multiline = true;
            this.txtInput.Size = new System.Drawing.Size(400, 100);
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            // Кнопка "Анализировать"
            this.btnAnalyze.Location = new System.Drawing.Point(12, 120);
            this.btnAnalyze.Text = "Анализировать";
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);

            // Радиокнопка для вывода на экран
            this.rbtnShowOnScreen.Location = new System.Drawing.Point(12, 150);
            this.rbtnShowOnScreen.Text = "Вывод на экран";
            this.rbtnShowOnScreen.Checked = true;

            // Радиокнопка для сохранения в файл
            this.rbtnSaveToFile.Location = new System.Drawing.Point(150, 150);
            this.rbtnSaveToFile.Text = "Сохранить в файл";

            // TextBox для отображения отчета
            this.txtReport.Location = new System.Drawing.Point(12, 180);
            this.txtReport.Multiline = true;
            this.txtReport.Size = new System.Drawing.Size(400, 200);
            this.txtReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            // Настройки формы
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.rbtnShowOnScreen);
            this.Controls.Add(this.rbtnSaveToFile);
            this.Controls.Add(this.txtReport);
            this.Text = "Анализатор текста";
            this.ResumeLayout(false);
        }
    }
}
