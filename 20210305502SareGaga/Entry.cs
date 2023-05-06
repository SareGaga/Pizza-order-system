using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210305502SareGaga
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

      
        private void Entry_Load(object sender, EventArgs e)
        {

        }

      

        private void Button1_Click(object sender, EventArgs e)
        {
            // Diğer formu oluştur
            order order = new order();

            // Diğer formu göster
            order.Show();

            // Mevcut formu gizle
            this.Hide();

        }
    }
}
