namespace mainprog.MainForms.SubForms.SubFormsOf1
{
    partial class FormOfPull
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
            label1 = new Label();
            button = new Button();
            textBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(411, 108);
            label1.TabIndex = 0;
            label1.Text = "Сколько яблочек \r\nвы хотите выложить?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button.Location = new Point(86, 187);
            button.Name = "button";
            button.Size = new Size(260, 60);
            button.TabIndex = 1;
            button.Text = "Выложить";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // textBox
            // 
            textBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox.Location = new Point(12, 120);
            textBox.Name = "textBox";
            textBox.Size = new Size(411, 61);
            textBox.TabIndex = 2;
            // 
            // FormOfPull
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 274);
            Controls.Add(textBox);
            Controls.Add(button);
            Controls.Add(label1);
            Name = "FormOfPull";
            Text = "Выложить яблочки из корзинки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button;
        private TextBox textBox;
    }
}