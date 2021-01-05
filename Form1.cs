using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qr_creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngera_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QR = new QRCoder.QRCodeGenerator();

            var DADO = QR.CreateQrCode(txtqr.Text, QRCoder.QRCodeGenerator.ECCLevel.H);

            var GERA = new QRCoder.QRCode(DADO);

            pictureBox1.Image = GERA.GetGraphic(50);
        }
    }
}
