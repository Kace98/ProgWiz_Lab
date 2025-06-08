namespace Lab10
{
    partial class DNAAnalysisForm
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
            listViewSequences = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderLength = new ColumnHeader();
            splitContainer1 = new SplitContainer();
            buttonExportJSON = new Button();
            buttonExportCSV = new Button();
            formsPlot1 = new ScottPlot.FormsPlot();
            groupBoxDetails = new GroupBox();
            labelBaseCounts = new Label();
            labelCodonCount = new Label();
            labelGCContent = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxDetails.SuspendLayout();
            SuspendLayout();
            // 
            // listViewSequences
            // 
            listViewSequences.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderLength });
            listViewSequences.Dock = DockStyle.Fill;
            listViewSequences.FullRowSelect = true;
            listViewSequences.GridLines = true;
            listViewSequences.Location = new Point(0, 0);
            listViewSequences.Name = "listViewSequences";
            listViewSequences.Size = new Size(800, 200);
            listViewSequences.TabIndex = 0;
            listViewSequences.UseCompatibleStateImageBehavior = false;
            listViewSequences.View = View.Details;
            listViewSequences.SelectedIndexChanged += listViewSequences_SelectedIndexChanged;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Nazwa sekwencji";
            columnHeaderName.Width = 400;
            // 
            // columnHeaderLength
            // 
            columnHeaderLength.Text = "Długość";
            columnHeaderLength.Width = 100;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listViewSequences);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(buttonExportJSON);
            splitContainer1.Panel2.Controls.Add(buttonExportCSV);
            splitContainer1.Panel2.Controls.Add(formsPlot1);
            splitContainer1.Panel2.Controls.Add(groupBoxDetails);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 200;
            splitContainer1.TabIndex = 1;
            // 
            // buttonExportJSON
            // 
            buttonExportJSON.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonExportJSON.Location = new Point(686, 212);
            buttonExportJSON.Name = "buttonExportJSON";
            buttonExportJSON.Size = new Size(102, 23);
            buttonExportJSON.TabIndex = 3;
            buttonExportJSON.Text = "Eksport JSON";
            buttonExportJSON.UseVisualStyleBackColor = true;
            buttonExportJSON.Click += buttonExportJSON_Click;
            // 
            // buttonExportCSV
            // 
            buttonExportCSV.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonExportCSV.Location = new Point(571, 211);
            buttonExportCSV.Name = "buttonExportCSV";
            buttonExportCSV.Size = new Size(99, 23);
            buttonExportCSV.TabIndex = 2;
            buttonExportCSV.Text = "Eksport CSV";
            buttonExportCSV.UseVisualStyleBackColor = true;
            buttonExportCSV.Click += buttonExportCSV_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(0, 120);
            formsPlot1.Margin = new Padding(4, 3, 4, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(800, 126);
            formsPlot1.TabIndex = 1;
            // 
            // groupBoxDetails
            // 
            groupBoxDetails.Controls.Add(labelBaseCounts);
            groupBoxDetails.Controls.Add(labelCodonCount);
            groupBoxDetails.Controls.Add(labelGCContent);
            groupBoxDetails.Dock = DockStyle.Top;
            groupBoxDetails.Location = new Point(0, 0);
            groupBoxDetails.Name = "groupBoxDetails";
            groupBoxDetails.Size = new Size(800, 120);
            groupBoxDetails.TabIndex = 0;
            groupBoxDetails.TabStop = false;
            groupBoxDetails.Text = "Szczegóły sekwencji";
            // 
            // labelBaseCounts
            // 
            labelBaseCounts.AutoSize = true;
            labelBaseCounts.Location = new Point(12, 80);
            labelBaseCounts.Name = "labelBaseCounts";
            labelBaseCounts.Size = new Size(78, 15);
            labelBaseCounts.TabIndex = 2;
            labelBaseCounts.Text = "Liczba zasad: ";
            // 
            // labelCodonCount
            // 
            labelCodonCount.AutoSize = true;
            labelCodonCount.Location = new Point(12, 55);
            labelCodonCount.Name = "labelCodonCount";
            labelCodonCount.Size = new Size(99, 15);
            labelCodonCount.TabIndex = 1;
            labelCodonCount.Text = "Liczba kodonów: ";
            // 
            // labelGCContent
            // 
            labelGCContent.AutoSize = true;
            labelGCContent.Location = new Point(12, 30);
            labelGCContent.Name = "labelGCContent";
            labelGCContent.Size = new Size(86, 15);
            labelGCContent.TabIndex = 0;
            labelGCContent.Text = "Zawartość GC: ";
            // 
            // DNAAnalysisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "DNAAnalysisForm";
            Text = "Analiza sekwencji DNA";
            Load += DNAAnalysisForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxDetails.ResumeLayout(false);
            groupBoxDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewSequences;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderLength;
        private SplitContainer splitContainer1;
        private GroupBox groupBoxDetails;
        private Label labelBaseCounts;
        private Label labelCodonCount;
        private Label labelGCContent;
        private ScottPlot.FormsPlot formsPlot1;
        private Button buttonExportCSV;
        private Button buttonExportJSON;
    }
} 