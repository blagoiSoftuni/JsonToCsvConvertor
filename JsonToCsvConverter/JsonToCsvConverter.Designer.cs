using System.Windows.Forms;

namespace JsonToCsvConverter
{
    partial class JsonToCsvConverter
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxUserInput;
        private TextBox textBoxJson;
        private TextBox textBoxCsv;
        private Button buttonRequestApi;
        private Button buttonConvertToCsv;
        private Label labelUserInput;
        private Label labelJson;
        private Label labelCsv;
        private Label labelRequestApi;
        private Label labelConvertToCsv;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxUserInput = new TextBox();
            this.textBoxJson = new TextBox();
            this.textBoxCsv = new TextBox();
            this.buttonRequestApi = new Button();
            this.buttonConvertToCsv = new Button();
            this.labelUserInput = new Label();
            this.labelJson = new Label();
            this.labelCsv = new Label();
            this.labelRequestApi = new Label();
            this.labelConvertToCsv = new Label();
            this.SuspendLayout();
            // 
            // textBoxUserInput
            // 
            this.textBoxUserInput.Location = new System.Drawing.Point(12, 29);
            this.textBoxUserInput.Name = "textBoxUserInput";
            this.textBoxUserInput.Size = new System.Drawing.Size(776, 20);
            this.textBoxUserInput.TabIndex = 0;
            // 
            // textBoxJson
            // 
            this.textBoxJson.Location = new System.Drawing.Point(12, 89);
            this.textBoxJson.Multiline = true;
            this.textBoxJson.Name = "textBoxJson";
            this.textBoxJson.Size = new System.Drawing.Size(776, 150);
            this.textBoxJson.TabIndex = 1;
            this.textBoxJson.TextChanged += new System.EventHandler(this.JsonTextBoxTextChanged);
            // 
            // textBoxCsv
            // 
            this.textBoxCsv.Location = new System.Drawing.Point(12, 289);
            this.textBoxCsv.Multiline = true;
            this.textBoxCsv.Name = "textBoxCsv";
            this.textBoxCsv.Size = new System.Drawing.Size(776, 150);
            this.textBoxCsv.TabIndex = 2;
            this.textBoxCsv.TextChanged += new System.EventHandler(this.CsvTextBoxTextChanged);
            // 
            // buttonRequestApi
            // 
            this.buttonRequestApi.Location = new System.Drawing.Point(12, 245);
            this.buttonRequestApi.Name = "buttonRequestApi";
            this.buttonRequestApi.Size = new System.Drawing.Size(75, 23);
            this.buttonRequestApi.TabIndex = 3;
            this.buttonRequestApi.Text = "Request API";
            this.buttonRequestApi.UseVisualStyleBackColor = true;
            this.buttonRequestApi.Click += new System.EventHandler(this.RequestButtonClick);
            // 
            // buttonConvertToCsv
            // 
            this.buttonConvertToCsv.Location = new System.Drawing.Point(12, 445);
            this.buttonConvertToCsv.Name = "buttonConvertToCsv";
            this.buttonConvertToCsv.Size = new System.Drawing.Size(92, 23);
            this.buttonConvertToCsv.TabIndex = 4;
            this.buttonConvertToCsv.Text = "Convert to CSV";
            this.buttonConvertToCsv.UseVisualStyleBackColor = true;
            this.buttonConvertToCsv.Click += new System.EventHandler(this.ConvertButtonClick);
            // 
            // labelUserInput
            // 
            this.labelUserInput.AutoSize = true;
            this.labelUserInput.Location = new System.Drawing.Point(12, 13);
            this.labelUserInput.Name = "labelUserInput";
            this.labelUserInput.Size = new System.Drawing.Size(57, 13);
            this.labelUserInput.TabIndex = 5;
            this.labelUserInput.Text = "User Input:";
            // 
            // labelJson
            // 
            this.labelJson.AutoSize = true;
            this.labelJson.Location = new System.Drawing.Point(12, 73);
            this.labelJson.Name = "labelJson";
            this.labelJson.Size = new System.Drawing.Size(32, 13);
            this.labelJson.TabIndex = 6;
            this.labelJson.Text = "JSON";
            // 
            // labelCsv
            // 
            this.labelCsv.AutoSize = true;
            this.labelCsv.Location = new System.Drawing.Point(12, 273);
            this.labelCsv.Name = "labelCsv";
            this.labelCsv.Size = new System.Drawing.Size(28, 13);
            this.labelCsv.TabIndex = 7;
            this.labelCsv.Text = "CSV";
            // 
            // labelRequestApi
            // 
            this.labelRequestApi.AutoSize = true;
            this.labelRequestApi.Location = new System.Drawing.Point(12, 229);
            this.labelRequestApi.Name = "labelRequestApi";
            this.labelRequestApi.Size = new System.Drawing.Size(72, 13);
            this.labelRequestApi.TabIndex = 8;
            this.labelRequestApi.Text = "Request API:";
            // 
            // labelConvertToCsv
            // 
            this.labelConvertToCsv.AutoSize = true;
            this.labelConvertToCsv.Location = new System.Drawing.Point(12, 429);
            this.labelConvertToCsv.Name = "labelConvertToCsv";
            this.labelConvertToCsv.Size = new System.Drawing.Size(83, 13);
            this.labelConvertToCsv.TabIndex = 9;
            this.labelConvertToCsv.Text = "Convert to CSV:";
            // 
            // JsonToCsvForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.labelConvertToCsv);
            this.Controls.Add(this.labelRequestApi);
            this.Controls.Add(this.labelCsv);
            this.Controls.Add(this.labelJson);
            this.Controls.Add(this.labelUserInput);
            this.Controls.Add(this.buttonConvertToCsv);
            this.Controls.Add(this.buttonRequestApi);
            this.Controls.Add(this.textBoxCsv);
            this.Controls.Add(this.textBoxJson);
            this.Controls.Add(this.textBoxUserInput);
            this.Name = "JsonToCsvForm";
            this.Text = "JSON to CSV Converter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
    

