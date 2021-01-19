using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void ClearForm1()
        {
            this.tbox1Grau.Text = string.Empty;
            this.tbox1Minutos.Text = string.Empty;
            this.tbox1Segundos.Text = string.Empty;
            this.tbox1TotalSegundos.Text = string.Empty;

            this.tbox2Grau.Text = string.Empty;
            this.tbox2Minuto.Text = string.Empty;
            this.tbox2Segundos.Text = string.Empty;
            this.tbox2Total.Text = string.Empty;
        }

        private void limpar1_Click(object sender, EventArgs e)
            => ClearForm1();

        private void calcular1_Click(object sender, EventArgs e)
        {
            try
            {
                var numberTxt = this.tbox1TotalSegundos.Text;

                if(string.IsNullOrEmpty(numberTxt))
                {
                    ClearForm1();
                    this.tbox1TotalSegundos.Focus();
                    throw new Exception("Digite um número!");
                }

                if(numberTxt.Contains(","))
                {
                    numberTxt = numberTxt.Replace(",", ".");
                }

                bool hasConvert = Int32.TryParse(numberTxt, out int totalSegundos);
                if(!hasConvert)
                {
                    ClearForm1();
                    this.tbox1TotalSegundos.Focus();
                    throw new Exception("Digite um número inteiro!");
                }

                if(totalSegundos < 0)
                {
                    totalSegundos *= -1;
                }

                int minutos = totalSegundos / 60;
                int segundos = totalSegundos - (minutos * 60);

                int grau = minutos / 60;
                minutos -= (grau * 60);

                this.tbox1Grau.Text = grau.ToString();
                this.tbox1Minutos.Text = minutos.ToString();
                this.tbox1Segundos.Text = segundos.ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void calcular2_Click(object sender, EventArgs e)
        {
            try
            {
                var grauTxt = this.tbox2Grau.Text;
                var minutoTxt = this.tbox2Minuto.Text;
                var segundoTxt = this.tbox2Segundos.Text;

                if (string.IsNullOrEmpty(grauTxt) || string.IsNullOrEmpty(minutoTxt) || string.IsNullOrEmpty(segundoTxt))
                {
                    ClearForm1();
                    this.tbox2Grau.Focus();
                    throw new Exception("Verifique os Números Digitados!");
                }


                bool hasConvertGrau = int.TryParse(grauTxt, out int grau);
                bool hasConvertMinuto = int.TryParse(minutoTxt, out int minuto);
                bool hasConvertSegundo = int.TryParse(segundoTxt, out int segundo);

                if(!hasConvertGrau || !hasConvertMinuto || !hasConvertSegundo)
                {
                    ClearForm1();
                    this.tbox2Grau.Focus();
                    throw new Exception("Verifique os Números Digitados!");
                }


                if(segundo > 60)
                {
                    this.tbox2Segundos.Focus();
                    throw new Exception("O valor de Segundos deve ser menor ou igual a 60!");
                }

                if (minuto > 60)
                {
                    this.tbox2Minuto.Focus();
                    throw new Exception("O valor de Minutos deve ser menor ou igual a 60!");
                }


                int total = (grau * 3600) + (minuto * 60) + segundo;

                this.tbox2Total.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
