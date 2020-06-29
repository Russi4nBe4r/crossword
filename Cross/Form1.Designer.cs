namespace Cross
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
            this.wordsFileBox = new System.Windows.Forms.TextBox();
            this.wordsFileBtn = new System.Windows.Forms.Button();
            this.crosswordGridView = new System.Windows.Forms.DataGridView();
            this.selectFileBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.crosswordGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // wordsFileBox
            // 
            this.wordsFileBox.Location = new System.Drawing.Point(12, 12);
            this.wordsFileBox.Name = "wordsFileBox";
            this.wordsFileBox.Size = new System.Drawing.Size(100, 20);
            this.wordsFileBox.TabIndex = 0;
            this.wordsFileBox.Text = "C:\\Users\\terehov\\Desktop\\demo.txt";
            // 
            // wordsFileBtn
            // 
            this.wordsFileBtn.Location = new System.Drawing.Point(12, 67);
            this.wordsFileBtn.Name = "wordsFileBtn";
            this.wordsFileBtn.Size = new System.Drawing.Size(100, 23);
            this.wordsFileBtn.TabIndex = 1;
            this.wordsFileBtn.Text = "Загрузить";
            this.wordsFileBtn.UseVisualStyleBackColor = true;
            this.wordsFileBtn.Click += new System.EventHandler(this.wordsFileBtn_Click);
            // 
            // crosswordGridView
            // 
            this.crosswordGridView.AllowUserToAddRows = false;
            this.crosswordGridView.AllowUserToDeleteRows = false;
            this.crosswordGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crosswordGridView.ColumnHeadersVisible = false;
            this.crosswordGridView.Location = new System.Drawing.Point(118, 12);
            this.crosswordGridView.Name = "crosswordGridView";
            this.crosswordGridView.RowHeadersVisible = false;
            this.crosswordGridView.ShowCellToolTips = false;
            this.crosswordGridView.Size = new System.Drawing.Size(670, 426);
            this.crosswordGridView.TabIndex = 2;
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Location = new System.Drawing.Point(12, 38);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(100, 23);
            this.selectFileBtn.TabIndex = 3;
            this.selectFileBtn.Text = "Выбрать";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectFileBtn);
            this.Controls.Add(this.crosswordGridView);
            this.Controls.Add(this.wordsFileBtn);
            this.Controls.Add(this.wordsFileBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.crosswordGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wordsFileBox;
        private System.Windows.Forms.Button wordsFileBtn;
        private System.Windows.Forms.DataGridView crosswordGridView;
        private System.Windows.Forms.Button selectFileBtn;
    }
}

