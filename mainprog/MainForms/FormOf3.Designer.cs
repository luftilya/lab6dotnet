namespace mainprog
{
    partial class FormOf3
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
            nick_mainlabel = new Label();
            adress_mainlabel = new Label();
            listBox = new ListBox();
            listBox_label = new Label();
            nick_label = new Label();
            adress_label = new Label();
            contextMenuStrip = new ContextMenuStrip(components);
            add_ToolStripMenuItem = new ToolStripMenuItem();
            change_ToolStripMenuItem = new ToolStripMenuItem();
            delete_ToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // history_label
            // 
            history_label.AutoSize = true;
            history_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            history_label.Location = new Point(12, 9);
            history_label.Name = "history_label";
            history_label.Size = new Size(721, 82);
            history_label.TabIndex = 0;
            history_label.Text = "Жители города Глупова живут по разным адресам.\r\nВам предстоит провести перепись населения.";
            // 
            // nick_mainlabel
            // 
            nick_mainlabel.AutoSize = true;
            nick_mainlabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nick_mainlabel.Location = new Point(40, 184);
            nick_mainlabel.Name = "nick_mainlabel";
            nick_mainlabel.Size = new Size(162, 41);
            nick_mainlabel.TabIndex = 1;
            nick_mainlabel.Text = "Прозвище";
            // 
            // adress_mainlabel
            // 
            adress_mainlabel.AutoSize = true;
            adress_mainlabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            adress_mainlabel.Location = new Point(101, 269);
            adress_mainlabel.Name = "adress_mainlabel";
            adress_mainlabel.Size = new Size(101, 41);
            adress_mainlabel.TabIndex = 2;
            adress_mainlabel.Text = "Адрес";
            // 
            // listBox
            // 
            listBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(739, 64);
            listBox.Name = "listBox";
            listBox.Size = new Size(357, 373);
            listBox.TabIndex = 3;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // listBox_label
            // 
            listBox_label.AutoSize = true;
            listBox_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox_label.Location = new Point(777, 20);
            listBox_label.Name = "listBox_label";
            listBox_label.Size = new Size(277, 41);
            listBox_label.TabIndex = 4;
            listBox_label.Text = "Картотека адресов";
            // 
            // nick_label
            // 
            nick_label.AutoSize = true;
            nick_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nick_label.Location = new Point(243, 184);
            nick_label.Name = "nick_label";
            nick_label.Size = new Size(0, 41);
            nick_label.TabIndex = 5;
            // 
            // adress_label
            // 
            adress_label.AutoSize = true;
            adress_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            adress_label.Location = new Point(243, 269);
            adress_label.Name = "adress_label";
            adress_label.Size = new Size(0, 41);
            adress_label.TabIndex = 6;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { add_ToolStripMenuItem, change_ToolStripMenuItem, delete_ToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(148, 76);
            // 
            // add_ToolStripMenuItem
            // 
            add_ToolStripMenuItem.Name = "add_ToolStripMenuItem";
            add_ToolStripMenuItem.Size = new Size(147, 24);
            add_ToolStripMenuItem.Text = "Добавить";
            add_ToolStripMenuItem.Click += add_ToolStripMenuItem_Click;
            // 
            // change_ToolStripMenuItem
            // 
            change_ToolStripMenuItem.Name = "change_ToolStripMenuItem";
            change_ToolStripMenuItem.Size = new Size(147, 24);
            change_ToolStripMenuItem.Text = "Изменить";
            change_ToolStripMenuItem.Click += change_ToolStripMenuItem_Click;
            // 
            // delete_ToolStripMenuItem
            // 
            delete_ToolStripMenuItem.Name = "delete_ToolStripMenuItem";
            delete_ToolStripMenuItem.Size = new Size(147, 24);
            delete_ToolStripMenuItem.Text = "Удалить";
            delete_ToolStripMenuItem.Click += delete_ToolStripMenuItem_Click;
            // 
            // FormOf3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 467);
            Controls.Add(adress_label);
            Controls.Add(nick_label);
            Controls.Add(listBox_label);
            Controls.Add(listBox);
            Controls.Add(adress_mainlabel);
            Controls.Add(nick_mainlabel);
            Controls.Add(history_label);
            Name = "FormOf3";
            Text = "Хэш-таблица по теме \"человек\"";
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label history_label;
        private Label nick_mainlabel;
        private Label adress_mainlabel;
        private ListBox listBox;
        private Label listBox_label;
        private Label nick_label;
        private Label adress_label;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem add_ToolStripMenuItem;
        private ToolStripMenuItem delete_ToolStripMenuItem;
        private ToolStripMenuItem change_ToolStripMenuItem;
    }
}