using static 加密通话姬.RSAKeyConverter;

namespace 加密通话姬
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void genKey_Click(object sender, EventArgs e)
        {
            RSASecretKey key = GenerateRSASecretKey(4096);
            myPub.Text = key.PublicKey_NoXml();
            myPri.Text = key.PrivateKey_NoXml();
        }

        private void dec_Click(object sender, EventArgs e)
        {
            try
            {
                textDeced.Text = RSADecrypt(ToXmlPrivateKey(myPri.Text), eText.Text);
            }
            catch (Exception)
            {
                textDeced.Text = "";
                MessageBox.Show("解密错误");
            }
        }

        private void enc_Click(object sender, EventArgs e)
        {
            try
            {
                textEnced.Text = RSAEncrypt(ToXmlPublicKey(herPub.Text), pText.Text);
            }
            catch (Exception)
            {
                textEnced.Text = "";
                MessageBox.Show("加密错误");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            genKey_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            myPri.Visible = !myPri.Visible;
        }
    }
}