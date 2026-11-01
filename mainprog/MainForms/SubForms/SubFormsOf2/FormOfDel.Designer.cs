namespace mainprog.MainForms.SubForms.SubFormsOf2
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
            yes_button = new Button();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label.Location = new Point(32, 9);
            label.Name = "label";
            label.Size = new Size(196, 41);
            label.TabIndex = 0;
            label.Text = "Вы уверены?";
            // 
            // no_button
            // 
            no_button.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            no_button.Location = new Point(12, 53);
            no_button.Name = "no_button";
            no_button.Size = new Size(117, 55);
            no_button.TabIndex = 1;
            no_button.Text = "Нет";
            no_button.UseVisualStyleBackColor = true;
            no_button.Click += no_button_Click;
            // 
            // yes_button
            // 
            yes_button.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            yes_button.Location = new Point(135, 53);
            yes_button.Name = "yes_button";
            yes_button.Size = new Size(117, 55);
            yes_button.TabIndex = 2;
            yes_button.Text = "Да";
            yes_button.UseVisualStyleBackColor = true;
            yes_button.Click += yes_button_Click;
            // 
            // FormOfDel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 122);
            Controls.Add(yes_button);
            Controls.Add(no_button);
            Controls.Add(label);
            Name = "FormOfDel";
            Text = "Удалить сведения о жертве";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Button no_button;
        private Button yes_button;
    }
}