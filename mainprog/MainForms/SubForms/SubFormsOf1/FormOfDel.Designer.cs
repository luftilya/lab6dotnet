namespace mainprog.MainForms.SubForms.SubFormsOf1
{
    partial class FormOfDel
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
            no_button = new Button();
            label1 = new Label();
            yes_button = new Button();
            SuspendLayout();
            // 
            // no_button
            // 
            no_button.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            no_button.Location = new Point(12, 191);
            no_button.Name = "no_button";
            no_button.Size = new Size(150, 80);
            no_button.TabIndex = 0;
            no_button.Text = "Нет";
            no_button.UseVisualStyleBackColor = true;
            no_button.Click += no_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(321, 162);
            label1.TabIndex = 1;
            label1.Text = "Вы точно-точно\r\nхотите выкинуть\r\nкорзинку?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // yes_button
            // 
            yes_button.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            yes_button.Location = new Point(168, 191);
            yes_button.Name = "yes_button";
            yes_button.Size = new Size(150, 80);
            yes_button.TabIndex = 2;
            yes_button.Text = "Да";
            yes_button.UseVisualStyleBackColor = true;
            yes_button.Click += yes_button_Click;
            // 
            // FormOfDel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 282);
            Controls.Add(yes_button);
            Controls.Add(label1);
            Controls.Add(no_button);
            Name = "FormOfDel";
            Text = "Выкинуть корзинку";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button no_button;
        private Label label1;
        private Button yes_button;
    }
}