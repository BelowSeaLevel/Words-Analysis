namespace DataAnalysisWordsInDatabaseMultithread
{
    partial class Form1
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
            this.TextBoxWordsToDatabase = new System.Windows.Forms.TextBox();
            this.ButtonToDatabase = new System.Windows.Forms.Button();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelMostUsedWord = new System.Windows.Forms.Label();
            this.LabelAverageLength = new System.Windows.Forms.Label();
            this.LabelLongestWord = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonClearAllData = new System.Windows.Forms.Button();
            this.ButtonRun = new System.Windows.Forms.Button();
            this.ButtonPeekDatabase = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxWordsToDatabase
            // 
            this.TextBoxWordsToDatabase.Location = new System.Drawing.Point(13, 189);
            this.TextBoxWordsToDatabase.Multiline = true;
            this.TextBoxWordsToDatabase.Name = "TextBoxWordsToDatabase";
            this.TextBoxWordsToDatabase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxWordsToDatabase.Size = new System.Drawing.Size(775, 249);
            this.TextBoxWordsToDatabase.TabIndex = 0;
            this.TextBoxWordsToDatabase.TextChanged += new System.EventHandler(this.TextBoxWordsToDatabase_TextChanged);
            // 
            // ButtonToDatabase
            // 
            this.ButtonToDatabase.Location = new System.Drawing.Point(526, 160);
            this.ButtonToDatabase.Name = "ButtonToDatabase";
            this.ButtonToDatabase.Size = new System.Drawing.Size(108, 23);
            this.ButtonToDatabase.TabIndex = 1;
            this.ButtonToDatabase.Text = "To Database";
            this.ButtonToDatabase.UseVisualStyleBackColor = true;
            this.ButtonToDatabase.Click += new System.EventHandler(this.ButtonToDatabase_Click);
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Location = new System.Drawing.Point(3, 0);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(39, 17);
            this.LabelTime.TabIndex = 2;
            this.LabelTime.Text = "Time";
            this.LabelTime.Click += new System.EventHandler(this.LabelTime_Click);
            // 
            // LabelMostUsedWord
            // 
            this.LabelMostUsedWord.AutoSize = true;
            this.LabelMostUsedWord.Location = new System.Drawing.Point(3, 36);
            this.LabelMostUsedWord.Name = "LabelMostUsedWord";
            this.LabelMostUsedWord.Size = new System.Drawing.Size(111, 17);
            this.LabelMostUsedWord.TabIndex = 3;
            this.LabelMostUsedWord.Text = "Most used word:";
            this.LabelMostUsedWord.Click += new System.EventHandler(this.LabelMostUsedWord_Click);
            // 
            // LabelAverageLength
            // 
            this.LabelAverageLength.AutoSize = true;
            this.LabelAverageLength.Location = new System.Drawing.Point(3, 72);
            this.LabelAverageLength.Name = "LabelAverageLength";
            this.LabelAverageLength.Size = new System.Drawing.Size(165, 17);
            this.LabelAverageLength.TabIndex = 4;
            this.LabelAverageLength.Text = "Average length of words:";
            this.LabelAverageLength.Click += new System.EventHandler(this.LabelAverageLength_Click);
            // 
            // LabelLongestWord
            // 
            this.LabelLongestWord.AutoSize = true;
            this.LabelLongestWord.Location = new System.Drawing.Point(3, 108);
            this.LabelLongestWord.Name = "LabelLongestWord";
            this.LabelLongestWord.Size = new System.Drawing.Size(97, 17);
            this.LabelLongestWord.TabIndex = 5;
            this.LabelLongestWord.Text = "Longest word:";
            this.LabelLongestWord.Click += new System.EventHandler(this.LabelLongestWord_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LabelTime, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelLongestWord, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LabelMostUsedWord, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelAverageLength, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(332, 147);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // ButtonClearAllData
            // 
            this.ButtonClearAllData.Location = new System.Drawing.Point(94, 160);
            this.ButtonClearAllData.Name = "ButtonClearAllData";
            this.ButtonClearAllData.Size = new System.Drawing.Size(114, 23);
            this.ButtonClearAllData.TabIndex = 7;
            this.ButtonClearAllData.Text = "Clear All Data";
            this.ButtonClearAllData.UseVisualStyleBackColor = true;
            this.ButtonClearAllData.Click += new System.EventHandler(this.ButtonClearAllData_Click);
            // 
            // ButtonRun
            // 
            this.ButtonRun.Location = new System.Drawing.Point(13, 160);
            this.ButtonRun.Name = "ButtonRun";
            this.ButtonRun.Size = new System.Drawing.Size(75, 23);
            this.ButtonRun.TabIndex = 8;
            this.ButtonRun.Text = "Run";
            this.ButtonRun.UseVisualStyleBackColor = true;
            this.ButtonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // ButtonPeekDatabase
            // 
            this.ButtonPeekDatabase.Location = new System.Drawing.Point(640, 160);
            this.ButtonPeekDatabase.Name = "ButtonPeekDatabase";
            this.ButtonPeekDatabase.Size = new System.Drawing.Size(123, 23);
            this.ButtonPeekDatabase.TabIndex = 9;
            this.ButtonPeekDatabase.Text = "Peek Database";
            this.ButtonPeekDatabase.UseVisualStyleBackColor = true;
            this.ButtonPeekDatabase.Click += new System.EventHandler(this.ButtonPeekDatabase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonPeekDatabase);
            this.Controls.Add(this.ButtonRun);
            this.Controls.Add(this.ButtonClearAllData);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ButtonToDatabase);
            this.Controls.Add(this.TextBoxWordsToDatabase);
            this.Name = "Form1";
            this.Text = "AnalyzeTextData";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxWordsToDatabase;
        private System.Windows.Forms.Button ButtonToDatabase;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label LabelMostUsedWord;
        private System.Windows.Forms.Label LabelAverageLength;
        private System.Windows.Forms.Label LabelLongestWord;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ButtonClearAllData;
        private System.Windows.Forms.Button ButtonRun;
        private System.Windows.Forms.Button ButtonPeekDatabase;
    }
}

