namespace mainprog.MainForms.SubForms.SubFormsOf1
{
    partial class FormOfPut
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
            textBox = new TextBox();
            button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(580, 120);
            label1.TabIndex = 0;
            label1.Text = "Сколько яблочек вы хотите\r\nположить в корзинку?";
            // 
            // textBox
            // 
            textBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox.Location = new Point(22, 132);
            textBox.Name = "textBox";
            textBox.Size = new Size(550, 61);
            textBox.TabIndex = 1;
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button.Location = new Point(185, 210);
            button.Name = "button";
            button.Size = new Size(210, 60);
            button.TabIndex = 2;
            button.Text = "Положить";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // FormOfPut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 292);
            Controls.Add(button);
            Controls.Add(textBox);
            Controls.Add(label1);
            Name = "FormOfPut";
            Text = "Положить яблочки в корзинку";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox;
        private Button button;
    }
}