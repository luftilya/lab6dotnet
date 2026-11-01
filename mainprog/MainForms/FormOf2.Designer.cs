namespace mainprog
{
    partial class FormOf2
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
            components = new System.ComponentModel.Container();
            history_label = new Label();
            listBox = new ListBox();
            contextMenuStrip = new ContextMenuStrip(components);
            добавитьЖертвуToolStripMenuItem = new ToolStripMenuItem();
            изменитьЗаписьОЖертвеToolStripMenuItem = new ToolStripMenuItem();
            удалитьЗаписьОЖертвеToolStripMenuItem = new ToolStripMenuItem();
            help_label = new Label();
            name_label = new Label();
            age_label = new Label();
            adress_label = new Label();
            descriptions_label = new Label();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // history_label
            // 
            history_label.AutoSize = true;
            history_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            history_label.Location = new Point(12, 9);
            history_label.Name = "history_label";
            history_label.Size = new Size(892, 164);
            history_label.TabIndex = 0;
            history_label.Text = "Вы являетесь архивариусом городского архива\r\nжертв политических репрессий. \r\nВам нужно внести сведения жертв: \r\nФИО, ВОЗРАСТ, АДРЕС РОЖДЕНИЯ, ПОДРОБНОСТИ САНКЦИИ";
            // 
            // listBox
            // 
            listBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(936, 39);
            listBox.Name = "listBox";
            listBox.Size = new Size(523, 448);
            listBox.TabIndex = 2;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            listBox.MouseDown += listBox_MouseDown;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { добавитьЖертвуToolStripMenuItem, изменитьЗаписьОЖертвеToolStripMenuItem, удалитьЗаписьОЖертвеToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(267, 76);
            // 
            // добавитьЖертвуToolStripMenuItem
            // 
            добавитьЖертвуToolStripMenuItem.Name = "добавитьЖертвуToolStripMenuItem";
            добавитьЖертвуToolStripMenuItem.Size = new Size(266, 24);
            добавитьЖертвуToolStripMenuItem.Text = "Добавить запись жертве";
            добавитьЖертвуToolStripMenuItem.Click += add_victim_Click;
            // 
            // изменитьЗаписьОЖертвеToolStripMenuItem
            // 
            изменитьЗаписьОЖертвеToolStripMenuItem.Name = "изменитьЗаписьОЖертвеToolStripMenuItem";
            изменитьЗаписьОЖертвеToolStripMenuItem.Size = new Size(266, 24);
            изменитьЗаписьОЖертвеToolStripMenuItem.Text = "Изменить запись о жертве";
            изменитьЗаписьОЖертвеToolStripMenuItem.Click += change_victim_Click;
            // 
            // удалитьЗаписьОЖертвеToolStripMenuItem
            // 
            удалитьЗаписьОЖертвеToolStripMenuItem.Name = "удалитьЗаписьОЖертвеToolStripMenuItem";
            удалитьЗаписьОЖертвеToolStripMenuItem.Size = new Size(266, 24);
            удалитьЗаписьОЖертвеToolStripMenuItem.Text = "Удалить запись о жертве";
            удалитьЗаписьОЖертвеToolStripMenuItem.Click += del_victim_Click;
            // 
            // help_label
            // 
            help_label.AutoSize = true;
            help_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            help_label.Location = new Point(12, 260);
            help_label.Name = "help_label";
            help_label.Size = new Size(784, 31);
            help_label.TabIndex = 3;
            help_label.Text = "Для работы с архивом нажмите правой кнопкой мыши по списку справа";
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Segoe UI", 16.2F);
            name_label.Location = new Point(78, 334);
            name_label.Name = "name_label";
            name_label.Size = new Size(79, 38);
            name_label.TabIndex = 4;
            name_label.Text = "ФИО";
            // 
            // age_label
            // 
            age_label.AutoSize = true;
            age_label.Font = new Font("Segoe UI", 16.2F);
            age_label.Location = new Point(78, 372);
            age_label.Name = "age_label";
            age_label.Size = new Size(135, 38);
            age_label.TabIndex = 5;
            age_label.Text = "ВОЗРАСТ";
            // 
            // adress_label
            // 
            adress_label.AutoSize = true;
            adress_label.Font = new Font("Segoe UI", 16.2F);
            adress_label.Location = new Point(78, 411);
            adress_label.Name = "adress_label";
            adress_label.Size = new Size(269, 38);
            adress_label.TabIndex = 6;
            adress_label.Text = "МЕСТО РОЖДЕНИЯ";
            // 
            // descriptions_label
            // 
            descriptions_label.AutoSize = true;
            descriptions_label.Font = new Font("Segoe UI", 16.2F);
            descriptions_label.Location = new Point(78, 449);
            descriptions_label.Name = "descriptions_label";
            descriptions_label.Size = new Size(366, 38);
            descriptions_label.TabIndex = 7;
            descriptions_label.Text = "ПОДРОБНОСТИ САНКЦИИ";
            // 
            // FormOf2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1480, 547);
            Controls.Add(descriptions_label);
            Controls.Add(adress_label);
            Controls.Add(age_label);
            Controls.Add(name_label);
            Controls.Add(help_label);
            Controls.Add(listBox);
            Controls.Add(history_label);
            Name = "FormOf2";
            Text = "Создать разнородную коллекцию List<T> по теме человек";
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label history_label;
        private ListBox listBox;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem добавитьЖертвуToolStripMenuItem;
        private ToolStripMenuItem изменитьЗаписьОЖертвеToolStripMenuItem;
        private ToolStripMenuItem удалитьЗаписьОЖертвеToolStripMenuItem;
        private Label help_label;
        private Label name_label;
        private Label age_label;
        private Label adress_label;
        private Label descriptions_label;
    }
}