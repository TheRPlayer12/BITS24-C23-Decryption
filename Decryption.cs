using System.Security.Cryptography;
using System.Text;

namespace BITS24_C23
{
    public partial class Decryption : Form
    {
        public Decryption()
        {
            InitializeComponent();
        }

        private void decrypt()
        {
            try
            {

                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString(RsaKeyTxt.Text);

                    string ciphertext = InputTxt.Text;

                    byte[] encrypted = Convert.FromBase64String(ciphertext);
                    byte[] decrypted = rsa.Decrypt(encrypted, false);

                    OutputTxt.Text = (Encoding.UTF8.GetString(decrypted));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Decryption error: " + ex.Message);
            }
        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            decrypt();
        }
    }
}
