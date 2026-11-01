namespace mainprog
{
    partial class FormOf1
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
            buckets_listBox = new ListBox();
            listBox_label = new Label();
            add_bucket_button = new Button();
            header_label = new Label();
            paragraph_label = new Label();
            info_label = new Label();
            contextMenuStrip = new ContextMenuStrip(components);
            положитьЯблочкиToolStripMenuItem = new ToolStripMenuItem();
            выложитьЯблочкиToolStripMenuItem = new ToolStripMenuItem();
            выкинутьКорзинкуToolStripMenuItem = new ToolStripMenuItem();
            help_label = new Label();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // history_label
            // 
            history_label.AutoSize = true;
            history_label.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            history_label.Location = new Point(12, 9);
            history_label.Name = "history_label";
            history_label.Size = new Size(687, 162);
            history_label.TabIndex = 0;
            history_label.Text = "Вы прибыли на центральный рынок\r\nза яблочками с корзинками\r\nи намерены приобрести яблоки";
            // 
            // buckets_listBox
            // 
            buckets_listBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buckets_listBox.FormattingEnabled = true;
            buckets_listBox.Location = new Point(750, 136);
            buckets_listBox.Name = "buckets_listBox";
            buckets_listBox.Size = new Size(200, 250);
            buckets_listBox.TabIndex = 1;
            buckets_listBox.SelectedIndexChanged += buckets_listBox_SelectedIndexChanged;
            buckets_listBox.MouseDown += listBox_MouseDown;
            // 
            // listBox_label
            // 
            listBox_label.AutoSize = true;
            listBox_label.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox_label.Location = new Point(750, 68);
            listBox_label.Name = "listBox_label";
            listBox_label.Size = new Size(200, 54);
            listBox_label.TabIndex = 2;
            listBox_label.Text = "Корзинки";
            listBox_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // add_bucket_button
            // 
            add_bucket_button.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            add_bucket_button.Location = new Point(750, 408);
            add_bucket_button.Name = "add_bucket_button";
            add_bucket_button.Size = new Size(200, 97);
            add_bucket_button.TabIndex = 3;
            add_bucket_button.Text = "Принести\r\nкорзинку";
            add_bucket_button.UseVisualStyleBackColor = true;
            add_bucket_button.Click += add_bucket_button_Click;
            // 
            // header_label
            // 
            header_label.AutoSize = true;
            header_label.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            header_label.Location = new Point(159, 274);
            header_label.Name = "header_label";
            header_label.Size = new Size(416, 54);
            header_label.TabIndex = 4;
            header_label.Text = "Сведения о корзинке";
            header_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // paragraph_label
            // 
            paragraph_label.AutoSize = true;
            paragraph_label.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            paragraph_label.Location = new Point(52, 369);
            paragraph_label.Name = "paragraph_label";
            paragraph_label.Size = new Size(358, 54);
            paragraph_label.TabIndex = 5;
            paragraph_label.Text = "Яблок в корзинке:";
            paragraph_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // info_label
            // 
            info_label.AutoSize = true;
            info_label.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            info_label.ImageAlign = ContentAlignment.MiddleRight;
            info_label.Location = new Point(416, 342);
            info_label.MaximumSize = new Size(290, 110);
            info_label.MinimumSize = new Size(290, 110);
            info_label.Name = "info_label";
            info_label.Size = new Size(290, 110);
            info_label.TabIndex = 6;
            info_label.Text = "А корзинка-то\r\nне выбрана!";
            info_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { положитьЯблочкиToolStripMenuItem, выложитьЯблочкиToolStripMenuItem, выкинутьКорзинкуToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip1";
            contextMenuStrip.Size = new Size(213, 76);
            // 
            // положитьЯблочкиToolStripMenuItem
            // 
            положитьЯблочкиToolStripMenuItem.Name = "положитьЯблочкиToolStripMenuItem";
            положитьЯблочкиToolStripMenuItem.Size = new Size(212, 24);
            положитьЯблочкиToolStripMenuItem.Text = "Положить яблочки";
            положитьЯблочкиToolStripMenuItem.Click += put_apples_click;
            // 
            // выложитьЯблочкиToolStripMenuItem
            // 
            выложитьЯблочкиToolStripMenuItem.Name = "выложитьЯблочкиToolStripMenuItem";
            выложитьЯблочкиToolStripMenuItem.Size = new Size(212, 24);
            выложитьЯблочкиToolStripMenuItem.Text = "Выложить яблочки";
            выложитьЯблочкиToolStripMenuItem.Click += pull_apples_click;
            // 
            // выкинутьКорзинкуToolStripMenuItem
            // 
            выкинутьКорзинкуToolStripMenuItem.Name = "выкинутьКорзинкуToolStripMenuItem";
            выкинутьКорзинкуToolStripMenuItem.Size = new Size(212, 24);
            выкинутьКорзинкуToolStripMenuItem.Text = "Выкинуть корзинку";
            выкинутьКорзинкуToolStripMenuItem.Click += kick_out_bucket_click;
            // 
            // help_label
            // 
            help_label.AutoSize = true;
            help_label.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            help_label.Location = new Point(21, 192);
            help_label.Name = "help_label";
            help_label.Size = new Size(623, 56);
            help_label.TabIndex = 7;
            help_label.Text = "Подсказка:\r\nдля управления корзинкой нажать правой кнопкой мыши по ней!";
            help_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormOf1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 529);
            Controls.Add(help_label);
            Controls.Add(info_label);
            Controls.Add(paragraph_label);
            Controls.Add(header_label);
            Controls.Add(add_bucket_button);
            Controls.Add(listBox_label);
            Controls.Add(buckets_listBox);
            Controls.Add(history_label);
            Name = "FormOf1";
            Text = "Создать однородную коллекцию List<T>";
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label history_label;
        private ListBox buckets_listBox;
        private Label listBox_label;
        private Button add_bucket_button;
        private Label header_label;
        private Label paragraph_label;
        private Label info_label;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem положитьЯблочкиToolStripMenuItem;
        private ToolStripMenuItem выложитьЯблочкиToolStripMenuItem;
        private ToolStripMenuItem выкинутьКорзинкуToolStripMenuItem;
        private Label help_label;
    }
}