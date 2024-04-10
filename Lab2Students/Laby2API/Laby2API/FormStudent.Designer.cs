namespace Laby2API
{
    partial class FormStudent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxResponse = new TextBox();
            runApi = new Button();
            SuspendLayout();
            // 
            // textBoxResponse
            // 
            textBoxResponse.Location = new Point(263, 63);
            textBoxResponse.Multiline = true;
            textBoxResponse.Name = "textBoxResponse";
            textBoxResponse.Size = new Size(488, 295);
            textBoxResponse.TabIndex = 0;
            textBoxResponse.TextChanged += textBoxResponse_TextChanged;
            // 
            // runApi
            // 
            runApi.Location = new Point(463, 383);
            runApi.Name = "runApi";
            runApi.Size = new Size(94, 29);
            runApi.TabIndex = 1;
            runApi.Text = "runApi";
            runApi.UseVisualStyleBackColor = true;
            runApi.Click += buttonDownload_ClickAsync;
            // 
            // FormStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(runApi);
            Controls.Add(textBoxResponse);
            Name = "FormStudent";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxResponse;
        private Button runApi;
    }
}
