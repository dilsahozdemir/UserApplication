namespace UserApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            kullaniciAdi = new DataGridViewTextBoxColumn();
            parola = new DataGridViewTextBoxColumn();
            hesapOlusturmaTarihi = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            kullaniciAdiTextBox = new TextBox();
            parolaTextBox = new TextBox();
            addUserButton = new Button();
            goToTestFormButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { kullaniciAdi, parola, hesapOlusturmaTarihi });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(744, 150);
            dataGridView1.TabIndex = 0;
            // 
            // kullaniciAdi
            // 
            kullaniciAdi.HeaderText = "Kullanıcı Adı";
            kullaniciAdi.Name = "kullaniciAdi";
            kullaniciAdi.Width = 200;
            // 
            // parola
            // 
            parola.HeaderText = "Parola";
            parola.Name = "parola";
            parola.Width = 200;
            // 
            // hesapOlusturmaTarihi
            // 
            hesapOlusturmaTarihi.HeaderText = "Hesap Oluşturma Tarihi";
            hesapOlusturmaTarihi.Name = "hesapOlusturmaTarihi";
            hesapOlusturmaTarihi.Width = 300;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 163);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 224);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Parola";
            // 
            // kullaniciAdiTextBox
            // 
            kullaniciAdiTextBox.Location = new Point(12, 181);
            kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            kullaniciAdiTextBox.Size = new Size(732, 23);
            kullaniciAdiTextBox.TabIndex = 4;
            // 
            // parolaTextBox
            // 
            parolaTextBox.Location = new Point(12, 251);
            parolaTextBox.Name = "parolaTextBox";
            parolaTextBox.Size = new Size(732, 23);
            parolaTextBox.TabIndex = 5;
            // 
            // addUserButton
            // 
            addUserButton.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            addUserButton.Location = new Point(12, 304);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(732, 49);
            addUserButton.TabIndex = 6;
            addUserButton.Text = "Kullanıcı Ekle";
            addUserButton.UseVisualStyleBackColor = true;
            addUserButton.Click += addUserButton_Click;
            // 
            // goToTestFormButton
            // 
            goToTestFormButton.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            goToTestFormButton.Location = new Point(12, 372);
            goToTestFormButton.Name = "goToTestFormButton";
            goToTestFormButton.Size = new Size(732, 49);
            goToTestFormButton.TabIndex = 7;
            goToTestFormButton.Text = "Kullanıcıyı Test Formuna Git";
            goToTestFormButton.UseVisualStyleBackColor = true;
            goToTestFormButton.Click += goToTestFormButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 442);
            Controls.Add(goToTestFormButton);
            Controls.Add(addUserButton);
            Controls.Add(parolaTextBox);
            Controls.Add(kullaniciAdiTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Ekleme Formu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn kullaniciAdi;
        private DataGridViewTextBoxColumn parola;
        private DataGridViewTextBoxColumn hesapOlusturmaTarihi;
        private Label label1;
        private Label label2;
        private TextBox kullaniciAdiTextBox;
        private TextBox parolaTextBox;
        private Button addUserButton;
        private Button goToTestFormButton;
    }
}
