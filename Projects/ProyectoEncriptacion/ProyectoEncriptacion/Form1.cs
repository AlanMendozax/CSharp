using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ProyectoEncriptacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
            //Metodo de descriptación 
            public static string SHA1Decryption(string value)
            {
                var shaSHA1 = System.Security.Cryptography.SHA1.Create();
                var inputEncodingBytes = Encoding.ASCII.GetBytes(value);
                var hashString = shaSHA1.ComputeHash(inputEncodingBytes);

                var stringBuilder = new StringBuilder();
                for (var x = 0; x < hashString.Length; x++)
                {
                    stringBuilder.Append(hashString[x].ToString("X2"));
                }
                return stringBuilder.ToString();
            }
        

        //Metodo para encriptar 
        public static string EncodePassword(string originalPassword)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] inputBytes = (new UnicodeEncoding()).GetBytes(originalPassword); byte[] hash = sha1.ComputeHash(inputBytes);
            return Convert.ToBase64String(hash);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
