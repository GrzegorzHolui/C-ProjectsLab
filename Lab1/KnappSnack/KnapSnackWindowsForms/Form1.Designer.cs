namespace KnapSnackWindowsForms
{
    partial class Form1
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
            numberOfItems = new TextBox();
            seed = new TextBox();
            capacity = new TextBox();
            button1 = new Button();
            instance = new ListBox();
            results = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // numberOfItems
            // 
            numberOfItems.Location = new Point(12, 31);
            numberOfItems.Name = "numberOfItems";
            numberOfItems.Size = new Size(125, 27);
            numberOfItems.TabIndex = 0;
            numberOfItems.TextChanged += numberOfItems_TextChanged;
            // 
            // seed
            // 
            seed.Location = new Point(12, 84);
            seed.Name = "seed";
            seed.Size = new Size(125, 27);
            seed.TabIndex = 1;
            // 
            // capacity
            // 
            capacity.Location = new Point(12, 140);
            capacity.Name = "capacity";
            capacity.Size = new Size(125, 27);
            capacity.TabIndex = 2;
            capacity.TextChanged += capacity_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 187);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 3;
            button1.Text = "run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // instance
            // 
            instance.FormattingEnabled = true;
            instance.Location = new Point(272, 12);
            instance.Name = "instance";
            instance.Size = new Size(516, 424);
            instance.TabIndex = 4;
            instance.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // results
            // 
            results.FormattingEnabled = true;
            results.Location = new Point(12, 257);
            results.Name = "results";
            results.Size = new Size(150, 104);
            results.TabIndex = 6;
            results.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 7;
            label1.Text = "number of items";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 8;
            label2.Text = "seed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 9;
            label3.Text = "capacity";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(results);
            Controls.Add(instance);
            Controls.Add(button1);
            Controls.Add(capacity);
            Controls.Add(seed);
            Controls.Add(numberOfItems);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numberOfItems;
        private TextBox seed;
        private TextBox capacity;
        private Button button1;
        private ListBox instance;
        private ListBox results;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
