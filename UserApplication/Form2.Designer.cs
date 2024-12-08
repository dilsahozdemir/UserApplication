namespace UserApplication
{
    partial class Form2
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
            parolaTextBox = new TextBox();
            kullaniciAdiTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            testUserButton = new Button();
            goToUserCreationFormButton = new Button();
            richTextBox2 = new RichTextBox();
            SuspendLayout();
            // 
            // parolaTextBox
            // 
            parolaTextBox.Location = new Point(1, 225);
            parolaTextBox.Name = "parolaTextBox";
            parolaTextBox.Size = new Size(412, 23);
            parolaTextBox.TabIndex = 9;
            // 
            // kullaniciAdiTextBox
            // 
            kullaniciAdiTextBox.Location = new Point(1, 172);
            kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            kullaniciAdiTextBox.Size = new Size(412, 23);
            kullaniciAdiTextBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 207);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Parola";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 154);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 6;
            label1.Text = "Kullanıcı Adı";
            // 
            // testUserButton
            // 
            testUserButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            testUserButton.Location = new Point(0, 264);
            testUserButton.Name = "testUserButton";
            testUserButton.Size = new Size(413, 40);
            testUserButton.TabIndex = 10;
            testUserButton.Text = "Kullanıcıyı Test Et";
            testUserButton.UseVisualStyleBackColor = true;
            testUserButton.Click += testUserButton_Click;
            // 
            // goToUserCreationFormButton
            // 
            goToUserCreationFormButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            goToUserCreationFormButton.Location = new Point(1, 310);
            goToUserCreationFormButton.Name = "goToUserCreationFormButton";
            goToUserCreationFormButton.Size = new Size(413, 40);
            goToUserCreationFormButton.TabIndex = 11;
            goToUserCreationFormButton.Text = "Kullanıcı Oluşturma Formuna Git";
            goToUserCreationFormButton.UseVisualStyleBackColor = true;
            goToUserCreationFormButton.Click += goToUserCreationFormButton_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Dock = DockStyle.Top;
            richTextBox2.Location = new Point(0, 0);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(413, 123);
            richTextBox2.TabIndex = 12;
            richTextBox2.Text = "";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 416);
            Controls.Add(richTextBox2);
            Controls.Add(goToUserCreationFormButton);
            Controls.Add(testUserButton);
            Controls.Add(parolaTextBox);
            Controls.Add(kullaniciAdiTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Test Etme Formu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox parolaTextBox;
        private TextBox kullaniciAdiTextBox;
        private Label label2;
        private Label label1;
        private Button testUserButton;
        private Button goToUserCreationFormButton;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
    }
}