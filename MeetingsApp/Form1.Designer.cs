namespace MeetingsApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.view_meet_butt = new System.Windows.Forms.Button();
            this.delete_butt = new System.Windows.Forms.Button();
            this.edit_butt = new System.Windows.Forms.Button();
            this.create_butt = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.save_data_butt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 467);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(232, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(959, 461);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.save_data_butt);
            this.panel2.Controls.Add(this.view_meet_butt);
            this.panel2.Controls.Add(this.delete_butt);
            this.panel2.Controls.Add(this.edit_butt);
            this.panel2.Controls.Add(this.create_butt);
            this.panel2.Controls.Add(this.monthCalendar1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 504);
            this.panel2.TabIndex = 0;
            // 
            // view_meet_butt
            // 
            this.view_meet_butt.Location = new System.Drawing.Point(15, 364);
            this.view_meet_butt.Name = "view_meet_butt";
            this.view_meet_butt.Size = new System.Drawing.Size(192, 39);
            this.view_meet_butt.TabIndex = 4;
            this.view_meet_butt.Text = "Просмотр встреч";
            this.view_meet_butt.UseVisualStyleBackColor = true;
            this.view_meet_butt.Click += new System.EventHandler(this.view_meet_butt_Click);
            // 
            // delete_butt
            // 
            this.delete_butt.Location = new System.Drawing.Point(15, 319);
            this.delete_butt.Name = "delete_butt";
            this.delete_butt.Size = new System.Drawing.Size(192, 39);
            this.delete_butt.TabIndex = 3;
            this.delete_butt.Text = "Удалить встречу";
            this.delete_butt.UseVisualStyleBackColor = true;
            this.delete_butt.Click += new System.EventHandler(this.delete_butt_Click);
            // 
            // edit_butt
            // 
            this.edit_butt.Location = new System.Drawing.Point(15, 274);
            this.edit_butt.Name = "edit_butt";
            this.edit_butt.Size = new System.Drawing.Size(192, 39);
            this.edit_butt.TabIndex = 2;
            this.edit_butt.Text = "Редактировать встречу";
            this.edit_butt.UseVisualStyleBackColor = true;
            this.edit_butt.Click += new System.EventHandler(this.edit_butt_Click);
            // 
            // create_butt
            // 
            this.create_butt.Location = new System.Drawing.Point(15, 229);
            this.create_butt.Name = "create_butt";
            this.create_butt.Size = new System.Drawing.Size(192, 39);
            this.create_butt.TabIndex = 1;
            this.create_butt.Text = "Создать встречу";
            this.create_butt.UseVisualStyleBackColor = true;
            this.create_butt.Click += new System.EventHandler(this.create_butt_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(15, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // save_data_butt
            // 
            this.save_data_butt.Location = new System.Drawing.Point(15, 409);
            this.save_data_butt.Name = "save_data_butt";
            this.save_data_butt.Size = new System.Drawing.Size(192, 39);
            this.save_data_butt.TabIndex = 5;
            this.save_data_butt.Text = "Сохранить данные";
            this.save_data_butt.UseVisualStyleBackColor = true;
            this.save_data_butt.Click += new System.EventHandler(this.save_data_butt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 467);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Календарь";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button view_meet_butt;
        private System.Windows.Forms.Button delete_butt;
        private System.Windows.Forms.Button edit_butt;
        private System.Windows.Forms.Button create_butt;
        private System.Windows.Forms.Button save_data_butt;
    }
}

