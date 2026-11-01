namespace mainprog.MainForms.SubForms.SubFormsOf2
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
            button = new Button();
            descriptions_textBox = new TextBox();
            adress_textBox = new TextBox();
            age_textBox = new TextBox();
            name_textBox = new TextBox();
            adress_label = new Label();
            descriptions_label = new Label();
            age_label = new Label();
            name_label = new Label();
            SuspendLayout();
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button.Location = new Point(270, 256);
            button.Name = "button";
            button.Size = new Size(250, 90);
            button.TabIndex = 17;
            button.Text = "Изменить\r\nжертву";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // descriptions_textBox
            // 
            descriptions_textBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            descriptions_textBox.Location = new Point(199, 190);
            descriptions_textBox.Name = "descriptions_textBox";
            descriptions_textBox.Size = new Size(589, 47);
            descriptions_textBox.TabIndex = 16;
            // 
            // adress_textBox
            // 
            adress_textBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            adress_textBox.Location = new Point(127, 118);
            adress_textBox.Name = "adress_textBox";
            adress_textBox.Size = new Size(661, 47);
            adress_textBox.TabIndex = 15;
            // 
            // age_textBox
            // 
            age_textBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            age_textBox.Location = new Point(163, 65);
            age_textBox.Name = "age_textBox";
            age_textBox.Size = new Size(625, 47);
            age_textBox.TabIndex = 14;
            // 
            // name_textBox
            // 
            name_textBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            name_textBox.Location = new Point(105, 12);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new Size(683, 47);
            name_textBox.TabIndex = 13;
            // 
            // adress_label
            // 
            adress_label.AutoSize = true;
            adress_label.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            adress_label.Location = new Point(12, 119);
            adress_label.Name = "adress_label";
            adress_label.Size = new Size(109, 41);
            adress_label.TabIndex = 12;
            adress_label.Text = "АДРЕС";
            // 
            // descriptions_label
            // 
            descriptions_label.AutoSize = true;
            descriptions_label.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            descriptions_label.Location = new Point(12, 169);
            descriptions_label.Name = "descriptions_label";
            descriptions_label.Size = new Size(181, 82);
            descriptions_label.TabIndex = 11;
            descriptions_label.Text = "ОПИСАНИЕ\r\nСАНКЦИИ";
            // 
            // age_label
            // 
            age_label.AutoSize = true;
            age_label.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            age_label.Location = new Point(12, 62);
            age_label.Name = "age_label";
            age_label.Size = new Size(145, 41);
            age_label.TabIndex = 10;
            age_label.Text = "ВОЗРАСТ";
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            name_label.Location = new Point(12, 15);
            name_label.Name = "name_label";
            name_label.Size = new Size(87, 41);
            name_label.TabIndex = 9;
            name_label.Text = "ФИО";
            // 
            // FormOfChange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 359);
            Controls.Add(button);
            Controls.Add(descriptions_textBox);
            Controls.Add(adress_textBox);
            Controls.Add(age_textBox);
            Controls.Add(name_textBox);
            Controls.Add(adress_label);
            Controls.Add(descriptions_label);
            Controls.Add(age_label);
            Controls.Add(name_label);
            Name = "FormOfChange";
            Text = "Изменить сведения о жертве";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button;
        private TextBox descriptions_textBox;
        private TextBox adress_textBox;
        private TextBox age_textBox;
        private TextBox name_textBox;
        private Label adress_label;
        private Label descriptions_label;
        private Label age_label;
        private Label name_label;
    }
}