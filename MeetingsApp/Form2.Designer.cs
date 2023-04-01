namespace MeetingsApp
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Place_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cancel_add_butt = new System.Windows.Forms.Button();
            this.add_butt = new System.Windows.Forms.Button();
            this.Descr_TB = new System.Windows.Forms.TextBox();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Place_TB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cancel_add_butt);
            this.panel1.Controls.Add(this.add_butt);
            this.panel1.Controls.Add(this.Descr_TB);
            this.panel1.Controls.Add(this.TimePicker);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 480);
            this.panel1.TabIndex = 0;
            // 
            // Place_TB
            // 
            this.Place_TB.Location = new System.Drawing.Point(178, 200);
            this.Place_TB.Multiline = true;
            this.Place_TB.Name = "Place_TB";
            this.Place_TB.Size = new System.Drawing.Size(200, 35);
            this.Place_TB.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Место";
            // 
            // cancel_add_butt
            // 
            this.cancel_add_butt.Location = new System.Drawing.Point(206, 419);
            this.cancel_add_butt.Name = "cancel_add_butt";
            this.cancel_add_butt.Size = new System.Drawing.Size(154, 38);
            this.cancel_add_butt.TabIndex = 7;
            this.cancel_add_butt.Text = "Отмена";
            this.cancel_add_butt.UseVisualStyleBackColor = true;
            this.cancel_add_butt.Click += new System.EventHandler(this.cancel_add_butt_Click);
            // 
            // add_butt
            // 
            this.add_butt.Location = new System.Drawing.Point(37, 419);
            this.add_butt.Name = "add_butt";
            this.add_butt.Size = new System.Drawing.Size(154, 38);
            this.add_butt.TabIndex = 6;
            this.add_butt.Text = "Добавить встречу";
            this.add_butt.UseVisualStyleBackColor = true;
            this.add_butt.Click += new System.EventHandler(this.add_butt_Click);
            // 
            // Descr_TB
            // 
            this.Descr_TB.Location = new System.Drawing.Point(178, 255);
            this.Descr_TB.Multiline = true;
            this.Descr_TB.Name = "Descr_TB";
            this.Descr_TB.Size = new System.Drawing.Size(200, 127);
            this.Descr_TB.TabIndex = 5;
            // 
            // TimePicker
            // 
            this.TimePicker.Location = new System.Drawing.Point(178, 154);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(200, 22);
            this.TimePicker.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Описание";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(34, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Время и дата окончания встречи";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(178, 96);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 22);
            this.datePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Время и дата начала встречи";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 480);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Создание встречи";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button cancel_add_butt;
        private System.Windows.Forms.Button add_butt;
        private System.Windows.Forms.TextBox Descr_TB;
        private System.Windows.Forms.TextBox Place_TB;
        private System.Windows.Forms.Label label4;
    }
}