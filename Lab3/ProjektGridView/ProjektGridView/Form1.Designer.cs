namespace ProjektGridView
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
            dataGridView1 = new DataGridView();
            button_Dodaj = new Button();
            button_Usun = new Button();
            button_zapisz = new Button();
            button_wczytaj = new Button();
            button_saveToJson = new Button();
            button_readFromJson = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(423, 239);
            dataGridView1.TabIndex = 0;
            // 
            // button_Dodaj
            // 
            button_Dodaj.Location = new Point(441, 12);
            button_Dodaj.Name = "button_Dodaj";
            button_Dodaj.Size = new Size(106, 23);
            button_Dodaj.TabIndex = 1;
            button_Dodaj.Text = "Dodaj";
            button_Dodaj.UseVisualStyleBackColor = true;
            button_Dodaj.Click += button_Dodaj_Click;
            // 
            // button_Usun
            // 
            button_Usun.Location = new Point(441, 41);
            button_Usun.Name = "button_Usun";
            button_Usun.Size = new Size(106, 23);
            button_Usun.TabIndex = 2;
            button_Usun.Text = "Usuń";
            button_Usun.UseVisualStyleBackColor = true;
            button_Usun.Click += button_Usun_Click;
            // 
            // button_zapisz
            // 
            button_zapisz.Location = new Point(12, 257);
            button_zapisz.Name = "button_zapisz";
            button_zapisz.Size = new Size(193, 23);
            button_zapisz.TabIndex = 3;
            button_zapisz.Text = "Zapisz odd .csv";
            button_zapisz.UseVisualStyleBackColor = true;
            button_zapisz.Click += button_zapisz_Click;
            // 
            // button_wczytaj
            // 
            button_wczytaj.Location = new Point(242, 257);
            button_wczytaj.Name = "button_wczytaj";
            button_wczytaj.Size = new Size(193, 23);
            button_wczytaj.TabIndex = 4;
            button_wczytaj.Text = "Wczytaj z .csv";
            button_wczytaj.UseVisualStyleBackColor = true;
            button_wczytaj.Click += button_wczytaj_Click;
            // 
            // button_saveToJson
            // 
            button_saveToJson.Location = new Point(441, 70);
            button_saveToJson.Name = "button_saveToJson";
            button_saveToJson.Size = new Size(106, 23);
            button_saveToJson.TabIndex = 5;
            button_saveToJson.Text = "Zapisz do JSON";
            button_saveToJson.UseVisualStyleBackColor = true;
            button_saveToJson.Click += button_saveToJson_Click;
            // 
            // button_readFromJson
            // 
            button_readFromJson.Location = new Point(441, 99);
            button_readFromJson.Name = "button_readFromJson";
            button_readFromJson.Size = new Size(106, 23);
            button_readFromJson.TabIndex = 6;
            button_readFromJson.Text = "Wczytaj z JSON";
            button_readFromJson.UseVisualStyleBackColor = true;
            button_readFromJson.Click += button_readFromJson_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 297);
            Controls.Add(button_readFromJson);
            Controls.Add(button_saveToJson);
            Controls.Add(button_wczytaj);
            Controls.Add(button_zapisz);
            Controls.Add(button_Usun);
            Controls.Add(button_Dodaj);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button_Dodaj;
        private Button button_Usun;
        private Button button_zapisz;
        private Button button_wczytaj;
        private Button button_saveToJson;
        private Button button_readFromJson;
    }
}
