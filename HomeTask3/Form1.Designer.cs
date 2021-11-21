namespace HomeTask3
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
            this.lblSecond = new System.Windows.Forms.Label();
            this.txtInputSecond = new System.Windows.Forms.TextBox();
            this.lblMinutTxt = new System.Windows.Forms.Label();
            this.lblHourTxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSecTxt = new System.Windows.Forms.Label();
            this.lblHourOutput = new System.Windows.Forms.Label();
            this.lblMinutesOutput = new System.Windows.Forms.Label();
            this.lblSecondOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSecond.Location = new System.Drawing.Point(27, 43);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(98, 22);
            this.lblSecond.TabIndex = 0;
            this.lblSecond.Text = "N секунд = ";
            // 
            // txtInputSecond
            // 
            this.txtInputSecond.Location = new System.Drawing.Point(131, 46);
            this.txtInputSecond.Name = "txtInputSecond";
            this.txtInputSecond.Size = new System.Drawing.Size(100, 20);
            this.txtInputSecond.TabIndex = 1;
            // 
            // lblMinutTxt
            // 
            this.lblMinutTxt.AutoSize = true;
            this.lblMinutTxt.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutTxt.Location = new System.Drawing.Point(27, 127);
            this.lblMinutTxt.Name = "lblMinutTxt";
            this.lblMinutTxt.Size = new System.Drawing.Size(296, 17);
            this.lblMinutTxt.TabIndex = 2;
            this.lblMinutTxt.Text = "Полных минут прошло с начала очередного часа:";
            // 
            // lblHourTxt
            // 
            this.lblHourTxt.AutoSize = true;
            this.lblHourTxt.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourTxt.Location = new System.Drawing.Point(27, 96);
            this.lblHourTxt.Name = "lblHourTxt";
            this.lblHourTxt.Size = new System.Drawing.Size(231, 17);
            this.lblHourTxt.TabIndex = 3;
            this.lblHourTxt.Text = "Полных часов прошло с начала суток:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(302, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSecTxt
            // 
            this.lblSecTxt.AutoSize = true;
            this.lblSecTxt.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecTxt.Location = new System.Drawing.Point(27, 160);
            this.lblSecTxt.Name = "lblSecTxt";
            this.lblSecTxt.Size = new System.Drawing.Size(318, 17);
            this.lblSecTxt.TabIndex = 5;
            this.lblSecTxt.Text = "Полных секунд прошло с начала очередной минуты: ";
            // 
            // lblHourOutput
            // 
            this.lblHourOutput.BackColor = System.Drawing.Color.White;
            this.lblHourOutput.Location = new System.Drawing.Point(346, 96);
            this.lblHourOutput.Name = "lblHourOutput";
            this.lblHourOutput.Size = new System.Drawing.Size(100, 23);
            this.lblHourOutput.TabIndex = 6;
            // 
            // lblMinutesOutput
            // 
            this.lblMinutesOutput.BackColor = System.Drawing.Color.White;
            this.lblMinutesOutput.Location = new System.Drawing.Point(346, 127);
            this.lblMinutesOutput.Name = "lblMinutesOutput";
            this.lblMinutesOutput.Size = new System.Drawing.Size(100, 23);
            this.lblMinutesOutput.TabIndex = 7;
            // 
            // lblSecondOutput
            // 
            this.lblSecondOutput.BackColor = System.Drawing.Color.White;
            this.lblSecondOutput.Location = new System.Drawing.Point(346, 160);
            this.lblSecondOutput.Name = "lblSecondOutput";
            this.lblSecondOutput.Size = new System.Drawing.Size(100, 23);
            this.lblSecondOutput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(550, 262);
            this.Controls.Add(this.lblSecondOutput);
            this.Controls.Add(this.lblMinutesOutput);
            this.Controls.Add(this.lblHourOutput);
            this.Controls.Add(this.lblSecTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHourTxt);
            this.Controls.Add(this.lblMinutTxt);
            this.Controls.Add(this.txtInputSecond);
            this.Controls.Add(this.lblSecond);
            this.Name = "Form1";
            this.Text = "HomeTask#3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.TextBox txtInputSecond;
        private System.Windows.Forms.Label lblMinutTxt;
        private System.Windows.Forms.Label lblHourTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSecTxt;
        private System.Windows.Forms.Label lblHourOutput;
        private System.Windows.Forms.Label lblMinutesOutput;
        private System.Windows.Forms.Label lblSecondOutput;
    }
}

