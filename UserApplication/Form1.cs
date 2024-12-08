namespace UserApplication
{
    public partial class Form1 : Form
    {
        //KULLANICILARI VE PAROLALARI BÝR YER KAYDETMEK ÝÇÝN KULANMAMAIZ LAZIM
        public static string[] kullaniciAdlari = new string[128];
        public static string[] parolalar = new string[128];
        public static int userIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = kullaniciAdiTextBox.Text;
            string parola = parolaTextBox.Text;

            dataGridView1.Rows.Add(kullaniciAdi, parola, DateTime.Now);

            kullaniciAdlari[userIndex] = kullaniciAdi;
            parolalar[userIndex] = parola;

            userIndex++;


            MessageBox.Show($"Kullanýcý sisteme baþarýyla eklendi[Kullanýcý No: {userIndex.ToString()}", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void goToTestFormButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            /* show form*/
            form2.Show();
            /*hide this form*/
            this.Hide();
        }
    }
}
