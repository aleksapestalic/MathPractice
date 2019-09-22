using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vežbanje_matematike
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b, aOduz, bOduz, aMnoz, bMnoz, rezTB;
        string Operator, aS, bS;
        bool sabiranje, oduzimanje, deljenje, mnozenje;
        private void sabiranjeOduzimanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int sumSab;
                //show/hide bEnter
                bEnter.Show();
                bEnterOduz.Hide();
                bEnterMnoz.Hide();
                int Od = Convert.ToInt32(tbOd.Text);
                int Do = Convert.ToInt32(tbDo.Text);
                //nasumicni integer a i b
                Random r = new Random();
                Od -= 1; Do += 1;
                a = r.Next(Od, Do);
                b = r.Next(Od, Do);

                //deklaracija rezultata
                sumSab = a + b;
                Operator = "+";
                //dodati string izlaz !!!
                string izlaz = a + " " + Operator + " " + b + " " + "=" + " " + "?";
                lZad.Text = izlaz;
                lNapomena.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Greška u radu aplikacije", "Greška");
            }
            
        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            try
            {
                int sumSab;
                sumSab = a + b;
                rezTB = Convert.ToInt32(tbOdgovor.Text);
                //za tacan rez
                if (rezTB == sumSab)
                {
                    int Od = Convert.ToInt32(tbOd.Text);
                    int Do = Convert.ToInt32(tbDo.Text);
                    Random r = new Random();
                    Od -= 1; Do += 1;
                    a = r.Next(Od, Do);
                    b = r.Next(Od, Do);
                    //deklaracija rezultata
                    sumSab = a + b;
                    Operator = "+";
                    //dodati string izlaz !!!
                    string izlaz = a + " " + Operator + " " + b + " " + "=" + " " + "?";
                    lZad.Text = izlaz;
                }
                else { MessageBox.Show("Pogrešan rezultat"); }
            }
            catch (Exception)
            {
                MessageBox.Show("Greška u radu aplikacije", "Greška");
            }
            

        }

        private void oduzimanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int sumOduz;
                //show/hide bEnter
                bEnterOduz.Show();
                bEnter.Hide();
                bEnterMnoz.Hide();
                int OdOduz = Convert.ToInt32(tbOd.Text);
                int DoOduz = Convert.ToInt32(tbDo.Text);
                //nasumicni integer a i sum
                Operator = "-";
                Random r = new Random();
                OdOduz -= 1; DoOduz += 1;
                aOduz = r.Next(OdOduz, DoOduz);
                bOduz = Math.Abs(r.Next(OdOduz, aOduz - 1));
                sumOduz = aOduz - bOduz;

                string izlaz = aOduz + " " + Operator + " " + bOduz + " " + "=" + " " + "?";
                lZad.Text = izlaz;
                lNapomena.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Greška u radu aplikacije", "Greška");
            }            
            
        }

        private void bEnterOduz_Click(object sender, EventArgs e)
        {
            try
            {
                int rezText = Convert.ToInt32(tbOdgovor.Text);
                int sumOduz;
                sumOduz = aOduz - bOduz;
                if (rezText == sumOduz)
                {

                    int OdOduz = Convert.ToInt32(tbOd.Text);
                    int DoOduz = Convert.ToInt32(tbDo.Text);
                    Random r = new Random();
                    OdOduz -= 1; DoOduz += 1;
                    aOduz = r.Next(OdOduz, DoOduz);
                    bOduz = r.Next(OdOduz, DoOduz);
                    Operator = "-";
                    //calculation
                    aOduz = r.Next(OdOduz, DoOduz);
                    bOduz = Math.Abs(r.Next(OdOduz, a - 1));

                    string izlaz = aOduz + " " + Operator + " " + bOduz + " " + "=" + " " + "?";
                    lZad.Text = izlaz;
                }
                else MessageBox.Show("Pogrešan rezultat", "Greska");
            }
            catch (Exception)
            {
                MessageBox.Show("Greška u radu aplikacije", "Greška");
            }
           
        }

        private void množenjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bEnterMnoz.Show();
                bEnter.Hide();
                bEnterOduz.Hide();
                Random r = new Random();
                int sumMnoz;
                Operator = "×";
                int OdMnoz = Convert.ToInt32(tbOd.Text);
                int DoMnoz = Convert.ToInt32(tbDo.Text);
                OdMnoz -= 1; DoMnoz += 1;
                aMnoz = r.Next(OdMnoz, DoMnoz);
                bMnoz = r.Next(OdMnoz, DoMnoz);
                sumMnoz = aMnoz * bMnoz;

                string izlaz = aMnoz + " " + Operator + " " + bMnoz + " " + "=" + " " + "?";
                lZad.Text = izlaz;
                lNapomena.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Greška u radu aplikacije", "Greška");
            }
            
        }

        private void bEnterMnoz_Click(object sender, EventArgs e)
        {
            try
            {
                Random r = new Random();
                int sumMnoz = aMnoz * bMnoz;
                int rezTb = Convert.ToInt32(tbOdgovor.Text);
                if (rezTb == sumMnoz)
                {
                    Operator = "×";
                    int OdMnoz = Convert.ToInt32(tbOd.Text);
                    int DoMnoz = Convert.ToInt32(tbDo.Text);
                    OdMnoz -= 1; DoMnoz += 1;
                    aMnoz = r.Next(OdMnoz, DoMnoz);
                    bMnoz = r.Next(OdMnoz, DoMnoz);
                    string izlaz = aMnoz + " " + Operator + " " + bMnoz + " " + "=" + " " + "?";
                    lZad.Text = izlaz;
                }
                else MessageBox.Show("Pogrešan rezultat", "Greška");
            }
            catch (Exception)
            {
                MessageBox.Show("Greška u radu aplikacije", "Greška");
            }
            
        }

    }
}
