﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Cliente
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //generamos el gliente
            var cliente = new Cliente(txtNombre.Text, txtApellido.Text, Convert.ToInt64(txtDNI.Text), txtMail.Text, txtTelefono.Text,
            txtDireccion.Text, txtCodigoPostal.Text, Convert.ToDateTime(txtFechaNacimiento.Text));

            Boolean tieneNombre = cliente.validarNombre();

            Console.WriteLine(tieneNombre);
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            Conexion.startConexion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // var cliente = new Cliente();
            Int64 asd = 38425536;

            String apellido = Cliente.buscar(asd).apellido;

            MessageBox.Show("apellido: " + apellido);

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

/*
public Cliente(String nombre, String apellido, Int64 dni, String mail, String telefono,
            String direccion, String codigoPostal, DateTime fechaNacimiento)
 
 */