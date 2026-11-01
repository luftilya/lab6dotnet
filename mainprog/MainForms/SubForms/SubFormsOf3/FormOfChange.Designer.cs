namespace mainprog.MainForms.SubForms.SubFormsOf3
{
    partial class FormOfChange
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
            history_label = new Label();
            history_continue_label = new Label();
            textBox = new TextBox();
            nick_label = new Label();
            adress_label = new Label();
            button = new Button();
            SuspendLayout();
            // 
            // history_label
            // 
            history_label.AutoSize = true;
            history_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            history_label.Location = new Point(2, 26);
            history_label.Name = "history_label";
            history_label.Size = new Size(371, 82);
            history_label.TabIndex = 0;
            history_label.Text = "Вы собираетесь выселить\r\nживущего по адресу";
            history_label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // history_continue_label
            // 
            history_continue_label.AutoSize = true;
            history_continue_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            history_continue_label.Location = new Point(169, 119);
            history_continue_label.Name = "history_continue_label";
            history_continue_label.Size = new Size(156, 41);
            history_continue_label.TabIndex = 1;
            history_continue_label.Text = "и вселить:";
            // 
            // textBox
            // 
            textBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox.Location = new Point(331, 119);
            textBox.Name = "textBox";
            textBox.Size = new Size(416, 47);
            textBox.TabIndex = 2;
            // 
            // nick_label
            // 
            nick_label.AutoSize = true;
            nick_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nick_label.Location = new Point(379, 26);
            nick_label.Name = "nick_label";
            nick_label.Size = new Size(158, 41);
            nick_label.TabIndex = 3;
            nick_label.Text = "прозвище";
            // 
            // adress_label
            // 
            adress_label.AutoSize = true;
            adress_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            adress_label.Location = new Point(379, 67);
            adress_label.Name = "adress_label";
            adress_label.Size = new Size(201, 41);
            adress_label.TabIndex = 4;
            adress_label.Text = "пер. Делкина";
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button.Location = new Point(433, 172);
            button.Name = "button";
            button.Size = new Size(223, 54);
            button.TabIndex = 5;
            button.Text = "Вселить!";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // FormOfChange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 241);
            Controls.Add(button);
            Controls.Add(adress_label);
            Controls.Add(nick_label);
            Controls.Add(textBox);
            Controls.Add(history_continue_label);
            Controls.Add(history_label);
            Name = "FormOfChange";
            Text = "Сменить жителя по адресу...";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label history_label;
        private Label history_continue_label;
        private TextBox textBox;
        private Label nick_label;
        private Label adress_label;
        private Button button;
    }
}