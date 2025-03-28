namespace ImageMod
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
            button_load = new Button();
            pictureBox1 = new PictureBox();
            button_rotate = new Button();
            radioButton_90 = new RadioButton();
            radioButton_180 = new RadioButton();
            radioButton_270 = new RadioButton();
            button_invertColors = new Button();
            button_UpsideDown = new Button();
            button_OnlyGreen = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_load
            // 
            button_load.Location = new Point(12, 396);
            button_load.Name = "button_load";
            button_load.Size = new Size(121, 36);
            button_load.TabIndex = 0;
            button_load.Text = "Load";
            button_load.UseVisualStyleBackColor = true;
            button_load.Click += button_load_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(149, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(420, 420);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button_rotate
            // 
            button_rotate.BackColor = Color.IndianRed;
            button_rotate.Location = new Point(12, 87);
            button_rotate.Name = "button_rotate";
            button_rotate.Size = new Size(121, 36);
            button_rotate.TabIndex = 5;
            button_rotate.Text = "Rotate";
            button_rotate.UseVisualStyleBackColor = false;
            button_rotate.Click += button_rotate_Click;
            // 
            // radioButton_90
            // 
            radioButton_90.AutoSize = true;
            radioButton_90.Location = new Point(12, 12);
            radioButton_90.Name = "radioButton_90";
            radioButton_90.Size = new Size(42, 19);
            radioButton_90.TabIndex = 6;
            radioButton_90.TabStop = true;
            radioButton_90.Text = "90°";
            radioButton_90.UseVisualStyleBackColor = true;
            // 
            // radioButton_180
            // 
            radioButton_180.AutoSize = true;
            radioButton_180.Location = new Point(12, 37);
            radioButton_180.Name = "radioButton_180";
            radioButton_180.Size = new Size(48, 19);
            radioButton_180.TabIndex = 7;
            radioButton_180.TabStop = true;
            radioButton_180.Text = "180°";
            radioButton_180.UseVisualStyleBackColor = true;
            // 
            // radioButton_270
            // 
            radioButton_270.AutoSize = true;
            radioButton_270.Location = new Point(12, 62);
            radioButton_270.Name = "radioButton_270";
            radioButton_270.Size = new Size(48, 19);
            radioButton_270.TabIndex = 8;
            radioButton_270.TabStop = true;
            radioButton_270.Text = "270°";
            radioButton_270.UseVisualStyleBackColor = true;
            // 
            // button_invertColors
            // 
            button_invertColors.BackColor = Color.LightSkyBlue;
            button_invertColors.Location = new Point(12, 129);
            button_invertColors.Name = "button_invertColors";
            button_invertColors.Size = new Size(121, 36);
            button_invertColors.TabIndex = 9;
            button_invertColors.Text = "Invert Colors";
            button_invertColors.UseVisualStyleBackColor = false;
            button_invertColors.Click += button_invertColors_Click;
            // 
            // button_UpsideDown
            // 
            button_UpsideDown.BackColor = Color.LightSkyBlue;
            button_UpsideDown.Location = new Point(12, 171);
            button_UpsideDown.Name = "button_UpsideDown";
            button_UpsideDown.Size = new Size(121, 36);
            button_UpsideDown.TabIndex = 10;
            button_UpsideDown.Text = "Upside Down";
            button_UpsideDown.UseVisualStyleBackColor = false;
            button_UpsideDown.Click += button_UpsideDown_Click;
            // 
            // button_OnlyGreen
            // 
            button_OnlyGreen.BackColor = Color.SpringGreen;
            button_OnlyGreen.Location = new Point(12, 213);
            button_OnlyGreen.Name = "button_OnlyGreen";
            button_OnlyGreen.Size = new Size(121, 36);
            button_OnlyGreen.TabIndex = 2;
            button_OnlyGreen.Text = "OnlyGreen";
            button_OnlyGreen.UseVisualStyleBackColor = false;
            button_OnlyGreen.Click += button_OnlyGreen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 450);
            Controls.Add(button_UpsideDown);
            Controls.Add(button_invertColors);
            Controls.Add(radioButton_270);
            Controls.Add(radioButton_180);
            Controls.Add(radioButton_90);
            Controls.Add(button_rotate);
            Controls.Add(button_OnlyGreen);
            Controls.Add(pictureBox1);
            Controls.Add(button_load);
            Name = "Form1";
            Text = "Edytor zdjęć";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_load;
        private PictureBox pictureBox1;
        private Button button_rotate;
        private RadioButton radioButton_90;
        private RadioButton radioButton_180;
        private RadioButton radioButton_270;
        private Button button_invertColors;
        private Button button_UpsideDown;
        private Button button_OnlyGreen;
    }
}
