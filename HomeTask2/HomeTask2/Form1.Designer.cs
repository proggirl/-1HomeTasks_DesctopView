namespace HomeTask2
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
            this.lblText = new System.Windows.Forms.Label();
            this.lblWeek = new System.Windows.Forms.Label();
            this.lblMonths = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.txtWeek = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblOuptut = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText.ForeColor = System.Drawing.Color.Indigo;
            this.lblText.Location = new System.Drawing.Point(57, 18);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(159, 22);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Enter the count of:";
            this.lblText.Click += new System.EventHandler(this.lblText_Click);
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWeek.ForeColor = System.Drawing.Color.Purple;
            this.lblWeek.Location = new System.Drawing.Point(23, 58);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(51, 18);
            this.lblWeek.TabIndex = 1;
            this.lblWeek.Text = "Weeks";
            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMonths.ForeColor = System.Drawing.Color.Purple;
            this.lblMonths.Location = new System.Drawing.Point(23, 95);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(57, 18);
            this.lblMonths.TabIndex = 2;
            this.lblMonths.Text = "Months";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYears.ForeColor = System.Drawing.Color.Purple;
            this.lblYears.Location = new System.Drawing.Point(23, 128);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(44, 18);
            this.lblYears.TabIndex = 3;
            this.lblYears.Text = "Years";
            // 
            // txtWeek
            // 
            this.txtWeek.Location = new System.Drawing.Point(118, 58);
            this.txtWeek.Name = "txtWeek";
            this.txtWeek.Size = new System.Drawing.Size(100, 20);
            this.txtWeek.TabIndex = 4;
            this.txtWeek.Text = "0";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(118, 93);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(100, 20);
            this.txtMonth.TabIndex = 5;
            this.txtMonth.Text = "0";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(118, 126);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 6;
            this.txtYear.Text = "0";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOk.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Location = new System.Drawing.Point(12, 173);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(206, 27);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblOuptut
            // 
            this.lblOuptut.BackColor = System.Drawing.Color.White;
            this.lblOuptut.Location = new System.Drawing.Point(128, 214);
            this.lblOuptut.Name = "lblOuptut";
            this.lblOuptut.Size = new System.Drawing.Size(100, 23);
            this.lblOuptut.TabIndex = 8;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDays.ForeColor = System.Drawing.Color.Purple;
            this.lblDays.Location = new System.Drawing.Point(30, 214);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(46, 18);
            this.lblDays.TabIndex = 9;
            this.lblDays.Text = "Days:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(310, 278);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblOuptut);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtWeek);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.lblMonths);
            this.Controls.Add(this.lblWeek);
            this.Controls.Add(this.lblText);
            this.Name = "Form1";
            this.Text = "HomeTask2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.TextBox txtWeek;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblOuptut;
        private System.Windows.Forms.Label lblDays;
    }
}

