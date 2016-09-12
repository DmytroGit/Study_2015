namespace WindowsFormsApplication7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonScaning = new System.Windows.Forms.Button();
            this.pictureBoxCart1OnTable = new System.Windows.Forms.PictureBox();
            this.pictureBoxCart2OnTable = new System.Windows.Forms.PictureBox();
            this.pictureBoxCart4OnTable = new System.Windows.Forms.PictureBox();
            this.pictureBoxCart3OnTable = new System.Windows.Forms.PictureBox();
            this.pictureBoxCart5OnTable = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStopTimer = new System.Windows.Forms.Button();
            this.pictureBoxFold = new System.Windows.Forms.PictureBox();
            this.pictureBoxCallCheck = new System.Windows.Forms.PictureBox();
            this.pictureBoxUpper = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCart1OnTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCart2OnTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCart4OnTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCart3OnTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCart5OnTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCallCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpper)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonScaning
            // 
            this.buttonScaning.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonScaning.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonScaning.Location = new System.Drawing.Point(1, 313);
            this.buttonScaning.Name = "buttonScaning";
            this.buttonScaning.Size = new System.Drawing.Size(304, 29);
            this.buttonScaning.TabIndex = 0;
            this.buttonScaning.Text = "Запуск таймера";
            this.buttonScaning.UseVisualStyleBackColor = false;
            this.buttonScaning.Click += new System.EventHandler(this.buttonScaning_Click);
            // 
            // pictureBoxCart1OnTable
            // 
            this.pictureBoxCart1OnTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCart1OnTable.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxCart1OnTable.Name = "pictureBoxCart1OnTable";
            this.pictureBoxCart1OnTable.Size = new System.Drawing.Size(60, 85);
            this.pictureBoxCart1OnTable.TabIndex = 1;
            this.pictureBoxCart1OnTable.TabStop = false;
            // 
            // pictureBoxCart2OnTable
            // 
            this.pictureBoxCart2OnTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCart2OnTable.Location = new System.Drawing.Point(62, 1);
            this.pictureBoxCart2OnTable.Name = "pictureBoxCart2OnTable";
            this.pictureBoxCart2OnTable.Size = new System.Drawing.Size(60, 85);
            this.pictureBoxCart2OnTable.TabIndex = 2;
            this.pictureBoxCart2OnTable.TabStop = false;
            // 
            // pictureBoxCart4OnTable
            // 
            this.pictureBoxCart4OnTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCart4OnTable.Location = new System.Drawing.Point(184, 1);
            this.pictureBoxCart4OnTable.Name = "pictureBoxCart4OnTable";
            this.pictureBoxCart4OnTable.Size = new System.Drawing.Size(60, 85);
            this.pictureBoxCart4OnTable.TabIndex = 3;
            this.pictureBoxCart4OnTable.TabStop = false;
            // 
            // pictureBoxCart3OnTable
            // 
            this.pictureBoxCart3OnTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCart3OnTable.Location = new System.Drawing.Point(123, 1);
            this.pictureBoxCart3OnTable.Name = "pictureBoxCart3OnTable";
            this.pictureBoxCart3OnTable.Size = new System.Drawing.Size(60, 85);
            this.pictureBoxCart3OnTable.TabIndex = 4;
            this.pictureBoxCart3OnTable.TabStop = false;
            // 
            // pictureBoxCart5OnTable
            // 
            this.pictureBoxCart5OnTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCart5OnTable.Location = new System.Drawing.Point(245, 1);
            this.pictureBoxCart5OnTable.Name = "pictureBoxCart5OnTable";
            this.pictureBoxCart5OnTable.Size = new System.Drawing.Size(60, 85);
            this.pictureBoxCart5OnTable.TabIndex = 5;
            this.pictureBoxCart5OnTable.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStopTimer
            // 
            this.buttonStopTimer.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonStopTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStopTimer.Location = new System.Drawing.Point(1, 348);
            this.buttonStopTimer.Name = "buttonStopTimer";
            this.buttonStopTimer.Size = new System.Drawing.Size(304, 29);
            this.buttonStopTimer.TabIndex = 6;
            this.buttonStopTimer.Text = "Останов таймера";
            this.buttonStopTimer.UseVisualStyleBackColor = false;
            this.buttonStopTimer.Click += new System.EventHandler(this.buttonStopTimer_Click);
            // 
            // pictureBoxFold
            // 
            this.pictureBoxFold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFold.Location = new System.Drawing.Point(1, 131);
            this.pictureBoxFold.Name = "pictureBoxFold";
            this.pictureBoxFold.Size = new System.Drawing.Size(195, 45);
            this.pictureBoxFold.TabIndex = 7;
            this.pictureBoxFold.TabStop = false;
            // 
            // pictureBoxCallCheck
            // 
            this.pictureBoxCallCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCallCheck.Location = new System.Drawing.Point(1, 182);
            this.pictureBoxCallCheck.Name = "pictureBoxCallCheck";
            this.pictureBoxCallCheck.Size = new System.Drawing.Size(195, 45);
            this.pictureBoxCallCheck.TabIndex = 8;
            this.pictureBoxCallCheck.TabStop = false;
            // 
            // pictureBoxUpper
            // 
            this.pictureBoxUpper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUpper.Location = new System.Drawing.Point(1, 233);
            this.pictureBoxUpper.Name = "pictureBoxUpper";
            this.pictureBoxUpper.Size = new System.Drawing.Size(195, 45);
            this.pictureBoxUpper.TabIndex = 9;
            this.pictureBoxUpper.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 389);
            this.Controls.Add(this.pictureBoxUpper);
            this.Controls.Add(this.pictureBoxCallCheck);
            this.Controls.Add(this.pictureBoxFold);
            this.Controls.Add(this.buttonStopTimer);
            this.Controls.Add(this.pictureBoxCart5OnTable);
            this.Controls.Add(this.pictureBoxCart3OnTable);
            this.Controls.Add(this.pictureBoxCart4OnTable);
            this.Controls.Add(this.pictureBoxCart2OnTable);
            this.Controls.Add(this.pictureBoxCart1OnTable);
            this.Controls.Add(this.buttonScaning);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCart1OnTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCart2OnTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCart4OnTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCart3OnTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCart5OnTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCallCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonScaning;
        private System.Windows.Forms.PictureBox pictureBoxCart1OnTable;
        private System.Windows.Forms.PictureBox pictureBoxCart2OnTable;
        private System.Windows.Forms.PictureBox pictureBoxCart4OnTable;
        private System.Windows.Forms.PictureBox pictureBoxCart3OnTable;
        private System.Windows.Forms.PictureBox pictureBoxCart5OnTable;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStopTimer;
        private System.Windows.Forms.PictureBox pictureBoxFold;
        private System.Windows.Forms.PictureBox pictureBoxCallCheck;
        private System.Windows.Forms.PictureBox pictureBoxUpper;
    }
}

