namespace mainprog.MainForms.SubForms.SubFormsOf3
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
            label = new Label();
            no_button = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label.ForeColor = Color.Black;
            label.Location = new Point(12, 9);
            label.Name = "label";
            label.Size = new Size(285, 60);
            label.TabIndex = 0;
            label.Text = "Вы уверены?";
            // 
            // no_button
            // 
            no_button.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            no_button.Location = new Point(12, 81);
            no_button.Name = "no_button";
            no_button.Size = new Size(125, 57);
            no_button.TabIndex = 1;
            no_button.Text = "Нет";
            no_button.UseVisualStyleBackColor = true;
            no_button.Click += no_button_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(172, 81);
            button1.Name = "button1";
            button1.Size = new Size(125, 57);
            button1.TabIndex = 2;
            button1.Text = "Да";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormOfDel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 150);
            Controls.Add(button1);
            Controls.Add(no_button);
            Controls.Add(label);
            Name = "FormOfDel";
            Text = "Удалить адрес";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Button no_button;
        private Button button1;
    }
}