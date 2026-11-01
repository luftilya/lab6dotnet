namespace mainprog.MainForms.SubForms.SubFormsOf3
{
    partial class FormOfAdd
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
            nick_input_label = new Label();
            nick_textBox = new TextBox();
            button = new Button();
            adress_input_label = new Label();
            adress_textBox = new TextBox();
            SuspendLayout();
            // 
            // nick_input_label
            // 
            nick_input_label.AutoSize = true;
            nick_input_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nick_input_label.Location = new Point(32, 9);
            nick_input_label.Name = "nick_input_label";
            nick_input_label.Size = new Size(189, 82);
            nick_input_label.TabIndex = 0;
            nick_input_label.Text = "Введите имя\r\nжителя:";
            nick_input_label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nick_textBox
            // 
            nick_textBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nick_textBox.Location = new Point(227, 17);
            nick_textBox.Name = "nick_textBox";
            nick_textBox.Size = new Size(391, 61);
            nick_textBox.TabIndex = 1;
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button.Location = new Point(299, 180);
            button.Name = "button";
            button.Size = new Size(251, 59);
            button.TabIndex = 2;
            button.Text = "Добавить";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // adress_input_label
            // 
            adress_input_label.AutoSize = true;
            adress_input_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            adress_input_label.Location = new Point(6, 91);
            adress_input_label.Name = "adress_input_label";
            adress_input_label.Size = new Size(215, 82);
            adress_input_label.TabIndex = 3;
            adress_input_label.Text = "Введите адрес\r\nжителя:";
            adress_input_label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // adress_textBox
            // 
            adress_textBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            adress_textBox.Location = new Point(227, 99);
            adress_textBox.Name = "adress_textBox";
            adress_textBox.Size = new Size(391, 61);
            adress_textBox.TabIndex = 4;
            // 
            // FormOfAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 251);
            Controls.Add(adress_textBox);
            Controls.Add(adress_input_label);
            Controls.Add(button);
            Controls.Add(nick_textBox);
            Controls.Add(nick_input_label);
            Name = "FormOfAdd";
            Text = "Добавить жителя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nick_input_label;
        private TextBox nick_textBox;
        private Button button;
        private Label adress_input_label;
        private TextBox adress_textBox;
    }
}