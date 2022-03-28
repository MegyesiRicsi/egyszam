using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EgyszamjatekGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Txt_tipp_TextChanged(object sender, EventArgs e)
        {
            var s = txt_tipp.Text.Trim().Split(' ');
            lbl_db.Text = s.Count().ToString() ;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var sr = new StreamReader("egyszamjatek1.txt");
            var lista = new List<string>();
            
            var s = txt_tipp.Text.Trim().Split(' ');
            lbl_db.Text = s.Count().ToString();
            var asd = sr.ReadLine().Split(' ');
            while (!sr.EndOfStream)
            {
                var tomb = sr.ReadLine().Split(' ');
                lista.Add(tomb[0]);                
                
            }
            sr.Close();
            if (lista.Contains( txt_nev.Text))
            {
                MessageBox.Show("Van már ilyen nevü játékos!");
            }
            else if (s.Count()!=asd.Count()-1)
            {
                MessageBox.Show($"A tippek száma nem megfelelő!");
            }
            else
            {
                File.AppendAllText("egyszamjatek1.txt", "\n"+txt_nev.Text+" "+txt_tipp.Text);
                MessageBox.Show("Az állomány bővitése sikeres");
            }
        }
    }
}
