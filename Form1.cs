using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bott
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbloqueia_Click(object sender, EventArgs e)
        {
            var botoes = new[] { button3, button4, button5 };
            foreach (var botao in botoes) 
            {
                botao.Enabled = false;
                botao.BackColor = Color.Red;
                botao.Text = "bloqueia";
            }
        }

        private void btndesbloqueia_Click(object sender, EventArgs e)
        {
            var botoes = new[] { button3, button4, button5 };
            foreach (var botao in botoes)
            {
                botao.Enabled = true;
                botao.BackColor = Color.BlueViolet;
                botao.Text = "desbloqueia";
            }
        }
    }
}
