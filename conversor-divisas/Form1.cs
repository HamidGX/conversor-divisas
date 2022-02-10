using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Programmed on earth by humans.
//Hamid Cuevas Escalera.
namespace conversor_divisas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void cmbDivisas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          if (cmbDivisas.Text== "Pesos Mexicanos (MXN)")

            {
                switch (comboBox2.Text)

                {
                   
                    case "Pesos Mexicanos (MXN)":
                    MessageBox.Show("Error: No debes ingresar la misma moneda.");
                    break;

                    case  "Pesos Argentinos (ARS)":
                        double monedaArg = double.Parse(txtCantidad.Text);
                        monedaArg = monedaArg * 4.84;
                        textBox2.Text = monedaArg.ToString();
                        break;

                    case "Pesos Colombianos (COP)":
                        double monedaCop = double.Parse(txtCantidad.Text);
                        monedaCop = monedaCop * 189.25;
                        textBox2.Text = monedaCop.ToString();
                        break;

                    case "Dólar (USD)":
                        double monedaUsd = double.Parse(txtCantidad.Text);
                        monedaUsd = monedaUsd * 0.051;
                        textBox2.Text = "$" + monedaUsd.ToString(); 
                        break;

                    case "Dólar Canadiense (CAD)":
                        double monedaCad = double.Parse(txtCantidad.Text);
                        monedaCad = monedaCad * 0.062;
                        textBox2.Text = monedaCad.ToString();
                        break;

                    case "Dólar de Nueva Zelanda (NZD)":
                        double monedaNzd = double.Parse(txtCantidad.Text);
                        monedaNzd = monedaNzd * 0.072;
                        textBox2.Text = monedaNzd.ToString();
                        break;
                    
                    case "Euro (EUR)":
                        double monedaEur = double.Parse(txtCantidad.Text);
                        monedaEur = monedaEur * 0.043;
                        textBox2.Text = "€" + monedaEur.ToString();
                        break;


                }
            }
          if (cmbDivisas.Text == "Pesos Argentinos (ARS)")
            {
                switch (comboBox2.Text)

                {

                    case "Pesos Argentinos (ARS)":
                        MessageBox.Show("Error: No debes ingresar la misma moneda.");
                        break;

                    case "Pesos Mexicanos (MXN)":
                        double monedaMx = double.Parse(txtCantidad.Text);
                        monedaMx = monedaMx * 0.19447;
                        textBox2.Text = monedaMx.ToString();
                        break;

                    case "Pesos Colombianos (COP)":
                        double monedaCop = double.Parse(txtCantidad.Text);
                        monedaCop = monedaCop * 37.476;
                        textBox2.Text = monedaCop.ToString();
                        break;

                    case "Dólar (USD)":
                        double monedaUsd = double.Parse(txtCantidad.Text);
                        monedaUsd = monedaUsd * 0.0094500;
                        textBox2.Text = monedaUsd.ToString();
                        break;

                    case "Dólar Canadiense (CAD)":
                        double monedaCad = double.Parse(txtCantidad.Text);
                        monedaCad = monedaCad * 0.011990;
                        textBox2.Text = monedaCad.ToString();
                        break;

                    case "Dólar de Nueva Zelanda (NZD)":
                        double monedaNzd = double.Parse(txtCantidad.Text);
                        monedaNzd = monedaNzd * 0.014190;
                        textBox2.Text = monedaNzd.ToString();
                        break;

                    case "Euro (EUR)":
                        double monedaEur = double.Parse(txtCantidad.Text);
                        monedaEur = monedaEur * 0.0082700;
                        textBox2.Text = monedaEur.ToString();
                        break;


                }
            }
          if (cmbDivisas.Text == "Pesos Colombianos (COP)")
            {
                switch (comboBox2.Text)

                {

                    case "Pesos Colombianos (COP)":
                        MessageBox.Show("Error: No debes ingresar la misma moneda.");
                        break;

                    case "Pesos Mexicanos (MXN)":
                        double monedaMx = double.Parse(txtCantidad.Text);
                        monedaMx = monedaMx * 0.0051900;
                        textBox2.Text = monedaMx.ToString();
                        break;

                    case "Pesos Argentinos (ARS)":
                        double monedaArg = double.Parse(txtCantidad.Text);
                        monedaArg = monedaArg * 0.026680;
                        textBox2.Text = monedaArg.ToString();
                        break;

                    case "Dólar (USD)":
                        double monedaUsd = double.Parse(txtCantidad.Text);
                        monedaUsd = monedaUsd * 0.00025000;
                        textBox2.Text = monedaUsd.ToString();
                        break;

                    case "Dólar Canadiense (CAD)":
                        double monedaCad = double.Parse(txtCantidad.Text);
                        monedaCad = monedaCad * 0.00032000;
                        textBox2.Text = monedaCad.ToString();
                        break;

                    case "Dólar de Nueva Zelanda (NZD)":
                        double monedaNzd = double.Parse(txtCantidad.Text);
                        monedaNzd = monedaNzd * 0.00038000;
                        textBox2.Text = monedaNzd.ToString();
                        break;

                    case "Euro (EUR)":
                        double monedaEur = double.Parse(txtCantidad.Text);
                        monedaEur = monedaEur * 0.00022000;
                        textBox2.Text = monedaEur.ToString();
                        break;


                }
            }
          if (cmbDivisas.Text == "Dólar (USD)")
            {
                switch (comboBox2.Text)

                {

                    case "Dólar (USD)":
                        MessageBox.Show("Error: No debes ingresar la misma moneda.");
                        break;

                    case "Pesos Mexicanos (MXN)":
                        double monedaMx = double.Parse(txtCantidad.Text);
                        monedaMx = monedaMx * 20.577;
                        textBox2.Text = monedaMx.ToString();
                        break;

                    case "Pesos Argentinos (ARS)":
                        double monedaArg = double.Parse(txtCantidad.Text);
                        monedaArg = monedaArg * 105.82;
                        textBox2.Text = monedaArg.ToString();
                        break;

                    case "Pesos Colombianos (COP)":
                        double monedaCop = double.Parse(txtCantidad.Text);
                        monedaCop = monedaCop * 3.965;
                        textBox2.Text = monedaCop.ToString();
                        break;

                    case "Dólar Canadiense (CAD)":
                        double monedaCad = double.Parse(txtCantidad.Text);
                        monedaCad = monedaCad * 1.2692;
                        textBox2.Text = monedaCad.ToString();
                        break;

                    case "Dólar de Nueva Zelanda (NZD)":
                        double monedaNzd = double.Parse(txtCantidad.Text);
                        monedaNzd = monedaNzd * 1.5014;
                        textBox2.Text = monedaNzd.ToString();
                        break;

                    case "Euro (EUR)":
                        double monedaEur = double.Parse(txtCantidad.Text);
                        monedaEur = monedaEur * 0.87514;
                        textBox2.Text = monedaEur.ToString();
                        break;


                }
            }
          if (cmbDivisas.Text == "Dólar Canadiense (CAD)")
            {
                switch (comboBox2.Text)

                {

                    case "Dólar Canadiense (CAD)":
                        MessageBox.Show("Error: No debes ingresar la misma moneda.");
                        break;

                    case "Pesos Mexicanos (MXN)":
                        double monedaMx = double.Parse(txtCantidad.Text);
                        monedaMx = monedaMx * 16.2121;
                        textBox2.Text = monedaMx.ToString();
                        break;

                    case "Pesos Argentinos (ARS)":
                        double monedaArg = double.Parse(txtCantidad.Text);
                        monedaArg = monedaArg * 83.359;
                        textBox2.Text = monedaArg.ToString();
                        break;

                    case "Pesos Colombianos (COP)":
                        double monedaCop = double.Parse(txtCantidad.Text);
                        monedaCop = monedaCop * 3.124;
                        textBox2.Text = monedaCop.ToString();
                        break;

                    case "Dólar (USD)":
                        double monedaUsd = double.Parse(txtCantidad.Text);
                        monedaUsd = monedaUsd * 0.78776;
                        textBox2.Text = monedaUsd.ToString();
                        break;

                    case "Dólar de Nueva Zelanda (NZD)":
                        double monedaNzd = double.Parse(txtCantidad.Text);
                        monedaNzd = monedaNzd * 1.18328;
                        textBox2.Text = monedaNzd.ToString();
                        break;

                    case "Euro (EUR)":
                        double monedaEur = double.Parse(txtCantidad.Text);
                        monedaEur = monedaEur * 0.68962;
                        textBox2.Text = monedaEur.ToString();
                        break;


                }
            }
          if (cmbDivisas.Text == "Dólar de Nueva Zelanda (NZD)")
            {
                switch (comboBox2.Text)

                {

                    case "Dólar de Nueva Zelanda (NZD)":
                        MessageBox.Show("Error: No debes ingresar la misma moneda.");
                        break;

                    case "Pesos Mexicanos (MXN)":
                        double monedaMx = double.Parse(txtCantidad.Text);
                        monedaMx = monedaMx * 13.7010;
                        textBox2.Text = monedaMx.ToString();
                        break;

                    case "Pesos Argentinos (ARS)":
                        double monedaArg = double.Parse(txtCantidad.Text);
                        monedaArg = monedaArg * 70.447;
                        textBox2.Text = monedaArg.ToString();
                        break;

                    case "Pesos Colombianos (COP)":
                        double monedaCop = double.Parse(txtCantidad.Text);
                        monedaCop = monedaCop * 2.64079;
                        textBox2.Text = monedaCop.ToString();
                        break;

                    case "Dólar (USD)":
                        double monedaUsd = double.Parse(txtCantidad.Text);
                        monedaUsd = monedaUsd * 0.66575;
                        textBox2.Text = monedaUsd.ToString();
                        break;

                    case "Dólar Canadiense (CAD)":
                        double monedaCad = double.Parse(txtCantidad.Text);
                        monedaCad = monedaCad * 0.84511;
                        textBox2.Text = monedaCad.ToString();
                        break;

                    case "Euro (EUR)":
                        double monedaEur = double.Parse(txtCantidad.Text);
                        monedaEur = monedaEur * 0.84511;
                        textBox2.Text = monedaEur.ToString();
                        break;


                }
            }
          if (cmbDivisas.Text == "Euro (EUR)")
            {
                switch (comboBox2.Text)

                {

                    case "Euro (EUR)":
                        MessageBox.Show("Error: No debes ingresar la misma moneda.");
                        break;

                    case "Pesos Mexicanos (MXN)":
                        double monedaMx = double.Parse(txtCantidad.Text);
                        monedaMx = monedaMx * 23.5088;
                        textBox2.Text = monedaMx.ToString();
                        break;

                    case "Pesos Argentinos (ARS)":
                        double monedaArg = double.Parse(txtCantidad.Text);
                        monedaArg = monedaArg * 120.877;
                        textBox2.Text = monedaArg.ToString();
                        break;

                    case "Pesos Colombianos (COP)":
                        double monedaCop = double.Parse(txtCantidad.Text);
                        monedaCop = monedaCop * 4.5312;
                        textBox2.Text = monedaCop.ToString();
                        break;

                    case "Dólar (USD)":
                        double monedaUsd = double.Parse(txtCantidad.Text);
                        monedaUsd = monedaUsd * 1.14232;
                        textBox2.Text = monedaUsd.ToString();
                        break;

                    case "Dólar Canadiense (CAD)":
                        double monedaCad = double.Parse(txtCantidad.Text);
                        monedaCad = monedaCad * 1.45008;
                        textBox2.Text = monedaCad.ToString();
                        break;

                    case "Dólar de Nueva Zelanda (NZD)":
                        double monedaNzd = double.Parse(txtCantidad.Text);
                        monedaNzd = monedaNzd * 1.71585;
                        textBox2.Text = monedaNzd.ToString();
                        break;


                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
            cmbDivisas.Text = "";
            comboBox2.Text = "";
            textBox2.Text = "";
        }
    }
}
