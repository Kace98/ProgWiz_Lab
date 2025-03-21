namespace KalkulatorCen
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button_OK = new Button();
            button_Anuluj = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(200, 152);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 183);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "Cena";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 183);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 2;
            label2.Text = "zł";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.HighlightText;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(70, 182);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 3;
            label3.Click += label3_Click;
            // 
            // button_OK
            // 
            button_OK.Location = new Point(12, 217);
            button_OK.Name = "button_OK";
            button_OK.Size = new Size(96, 23);
            button_OK.TabIndex = 4;
            button_OK.Text = "OK";
            button_OK.UseVisualStyleBackColor = true;
            button_OK.Click += button_OK_Click;
            // 
            // button_Anuluj
            // 
            button_Anuluj.Location = new Point(114, 217);
            button_Anuluj.Name = "button_Anuluj";
            button_Anuluj.Size = new Size(96, 23);
            button_Anuluj.TabIndex = 5;
            button_Anuluj.Text = "Anuluj";
            button_Anuluj.UseVisualStyleBackColor = true;
            button_Anuluj.Click += button_Anuluj_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(226, 250);
            Controls.Add(button_Anuluj);
            Controls.Add(button_OK);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "Form3";
            Text = "Monitor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button_OK;
        private Button button_Anuluj;
    }
}