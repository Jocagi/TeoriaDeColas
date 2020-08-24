using ModeloDeColas.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloDeColas
{
    public partial class Formulas1 : Form
    {
        public Formulas1()
        {
            InitializeComponent();
            InitializeTips();
        }
        private void InitializeTips() 
        {
            //Labels
            toolTip1.SetToolTip(servidores, "Cantidad de servidores");
            toolTip1.SetToolTip(lambda, "Tasa media de llegadas (numero de llegadas por unidad de tiempo)");
            toolTip1.SetToolTip(mu, "Tasa media de servicio (numero de llegadas por unidad de tiempo cuando el servidor esta ocupado)");

            toolTip1.SetToolTip(servidores, "Cantidad de servidores");
            toolTip1.SetToolTip(unidades, "Cantidad de unidades");
 
            //Servidor unico
            toolTip1.SetToolTip(getRoMM1, "Factor de utilizacion del sistema (Proporcion de tiempo que el servidor esta ocupado)");
            toolTip1.SetToolTip(getP0MM1, "Probabilidad de 0 elementos en la cola");
            toolTip1.SetToolTip(getPnMM1, "Probabilidad de n elementos en la cola");
            toolTip1.SetToolTip(getLqMM1, "Numero medio de unidades en la cola (longitud de cola)");
            toolTip1.SetToolTip(getLsMM1, "Numero medio de unidades en el sistema");
            toolTip1.SetToolTip(getWqMM1, "Tiempo medio de espera en la cola");
            toolTip1.SetToolTip(getWsMM1, "Tiempo medio de espera en el sistema");


            toolTip1.SetToolTip(getRoMMS, "Factor de utilizacion del sistema (Proporcion de tiempo que el servidor esta ocupado)");
            toolTip1.SetToolTip(getP0MMS, "Probabilidad de 0 elementos en la cola");
            toolTip1.SetToolTip(getPnMMS, "Probabilidad de n elementos en la cola");
            toolTip1.SetToolTip(getLqMMS, "Numero medio de unidades en la cola (longitud de cola)");
            toolTip1.SetToolTip(getLsMMS, "Numero medio de unidades en el sistema");
            toolTip1.SetToolTip(getWqMMS, "Tiempo medio de espera en la cola");
            toolTip1.SetToolTip(getWsMMS, "Tiempo medio de espera en el sistema");

        }

        private void setVariables() 
        {
            lambda_value = lambdaBox.Text == ""? 0.0 : Convert.ToDouble(lambdaBox.Text);
            mu_value = muBox.Text == "" ? 0.0 : Convert.ToDouble(muBox.Text);
            servers_value = serversBox.Text == "" ? 0 : Convert.ToInt32(serversBox.Text);
            items_value = nBox.Text == "" ? 0 : Convert.ToInt32(nBox.Text);
        }

        double lambda_value;
        double mu_value;
        int servers_value;
        int items_value;

        //Servidor unico

        private void getRoMM1_Click(object sender, EventArgs e)
        {
            setVariables();
            MessageBox.Show("=" + ModeloServidorUnico.p(lambda_value, mu_value).ToString());
        }

        private void getP0MM1_Click(object sender, EventArgs e)
        {
            setVariables();
            MessageBox.Show("=" + ModeloServidorUnico.P0(lambda_value, mu_value).ToString());
        }

        private void getPnMM1_Click(object sender, EventArgs e)
        {
            setVariables();
            MessageBox.Show("=" + ModeloServidorUnico.Pn(lambda_value, mu_value, items_value).ToString());
        }

        private void getLsMM1_Click(object sender, EventArgs e)
        {
            setVariables();
            MessageBox.Show("=" + ModeloServidorUnico.Ls(lambda_value, mu_value).ToString());
        }

        private void getLqMM1_Click(object sender, EventArgs e)
        {
            setVariables();
            MessageBox.Show("=" + ModeloServidorUnico.Lq(lambda_value, mu_value).ToString());
        }

        private void getWsMM1_Click(object sender, EventArgs e)
        {
            setVariables();
            MessageBox.Show("=" + ModeloServidorUnico.Ws(lambda_value, mu_value).ToString());
        }

        private void getWqMM1_Click(object sender, EventArgs e)
        {
            setVariables();
            MessageBox.Show("=" + ModeloServidorUnico.Wq(lambda_value, mu_value).ToString());
        }


        //Multiples servidores

        private void getRoMMS_Click(object sender, EventArgs e)
        {
            setVariables();
            MessageBox.Show("=" + ModeloServidorMultiple.p(lambda_value, mu_value, servers_value).ToString());
        }

        private void getP0MMS_Click(object sender, EventArgs e)
        {
            setVariables();
            MessageBox.Show("=" + ModeloServidorMultiple.P0(lambda_value, mu_value, servers_value).ToString());
        }

        private void getLsMMS_Click(object sender, EventArgs e)
        {
            setVariables();
            MessageBox.Show("=" + ModeloServidorMultiple.Ls(lambda_value, mu_value, servers_value).ToString());
        }

        private void getWsMMS_Click(object sender, EventArgs e)
        {
            setVariables();
            MessageBox.Show("=" + ModeloServidorMultiple.Ws(lambda_value, mu_value, servers_value).ToString());
        }

        private void getLqMMS_Click(object sender, EventArgs e)
        {
            setVariables();
            MessageBox.Show("=" + ModeloServidorMultiple.Lq(lambda_value, mu_value, servers_value).ToString());
        }

        private void getWqMMS_Click(object sender, EventArgs e)
        {
            setVariables();
            MessageBox.Show("=" + ModeloServidorMultiple.Wq(lambda_value, mu_value, servers_value).ToString());
        }

        private void getPnMMS_Click(object sender, EventArgs e)
        {
            setVariables();
            MessageBox.Show("=" + ModeloServidorMultiple.Wq(lambda_value, mu_value, servers_value).ToString());
        }
    }
}
