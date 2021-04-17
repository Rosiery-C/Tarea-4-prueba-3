using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_4_prueba_3
{
    public partial class Form1 : Form
    {
        Datos datoUsuario = new Datos();
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxedad.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //variables a utilizar
            double seguro, impuesto, gastos, descuento, salario_N, salario_B;
            
            //ingreso usuario y operaciones
            salario_B = double.Parse(ttsalario.Text);
            seguro = salario_B * 0.03;
            impuesto = salario_B * 0.05;
            gastos = salario_B * 0.10;
            descuento = seguro + impuesto + gastos;
            salario_N = salario_B - descuento;

            //mostrar los datos en pantalla
            ttdescuento.Text = descuento.ToString();
            txsalario.Text = salario_N.ToString();

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            ttsalario.Clear();
            txsalario.Clear();
            ttdescuento.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtnivel.Clear();
            txtcarrera.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           //no se cambia el contenido del combobox
            cboxlugar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnalmacenar_Click(object sender, EventArgs e)
        {
            datoUsuario.Nombre = txtnombre.Text;
            datoUsuario.Apellido = txtapellido.Text;
            datoUsuario.Carrera = txtcarrera.Text;
            datoUsuario.Nivel = txtnivel.Text;
            

            MessageBox.Show("Usuario registrado correctamente");
        }
    }
}
