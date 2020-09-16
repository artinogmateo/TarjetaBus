using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using LogicaDeNegocio;

namespace Presentacion
{
    public partial class Tarjeta : Form
    {
        private string idTarjeta = null;
        private bool Editar = false;
        LN_Tarjeta objLN_Tarjeta = new LN_Tarjeta();


        public Tarjeta()
        {
            InitializeComponent();
            MostrarTarjeta();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarTarjeta();
        }

        private void MostrarTarjeta()
        {
            LN_Tarjeta objeto = new LN_Tarjeta();
            dataGridView1.DataSource = objeto.MostrarTarjetass();
        }

        private void limpiarForm()
        {
            txtNroTarjeta.Clear();
            txtSaldo.Text = "0";
            txtViaje.Text = "0";
            txtDNI.Clear();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    string camposObligatorios = "";
                    if (txtDNI.Text == "")
                        camposObligatorios = camposObligatorios + " - Documento";
                    if (txtNroTarjeta.Text == "")
                        camposObligatorios = camposObligatorios + " - Número de Tarjeta";
                    if (txtSaldo.Text == "")
                        txtSaldo.Text = "0";
                    if (txtViaje.Text == "")
                        txtViaje.Text = "0";

                    string validarCampos = camposObligatorios;
                    if (validarCampos != "")
                    {
                        MessageBox.Show("Complete los siguientes campos: " + validarCampos);
                        return;
                    }

                    E_Tarjeta tarjeta = new E_Tarjeta();

                    tarjeta.documentoPersonaTarjeta = int.Parse(txtDNI.Text);
                    bool existedoc = objLN_Tarjeta.ExisteNroDocumento(tarjeta.documentoPersonaTarjeta);
                    if (existedoc == false)
                    {
                        MessageBox.Show("Ingresó mal el numero de documento o usted no tiene un usuario creado. Debe registrarse como usuario para registrar una tarjeta.");
                        return;
                    }
                    tarjeta.numeroTarjeta = int.Parse(txtNroTarjeta.Text);
                    bool existe = objLN_Tarjeta.ExisteNroTarjeta(tarjeta.numeroTarjeta);
                    if (existe == true)
                    {
                        MessageBox.Show("Ya existe una tarjeta registrada con ese numero de tarjeta, intente con otra combinacion.");
                        return;
                    }
                    tarjeta.saldoTarjeta = Convert.ToDouble(txtSaldo.Text);

                    objLN_Tarjeta.InsetarTarjetass(tarjeta);
                    MessageBox.Show("se insertó correctamente");
                    MostrarTarjeta();
                    limpiarForm();

                    btnCargarSaldo.Enabled = true; btnEliminar.Enabled = true; btnEditar.Enabled = true; btnPagarViaje.Enabled = true; bt_Persona.Enabled = true; txtViaje.Enabled = true; txtSaldo.Enabled = true; btnSeleccionarSaldo.Enabled = true; txtSaldo.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }

            if (Editar == true)
            {
                try
                {
                    string camposObligatorios = "";
                    if (txtDNI.Text == "")
                        camposObligatorios = camposObligatorios + " - Documento";
                    if (txtNroTarjeta.Text == "")
                        camposObligatorios = camposObligatorios + " - Número de Tarjeta";
                    if (txtSaldo.Text == "")
                        txtSaldo.Text = "0";
                    if (txtViaje.Text == "")
                        txtViaje.Text = "0";

                    string validarCampos = camposObligatorios;
                    if (validarCampos != "")
                    {
                        MessageBox.Show("Complete los siguientes campos: " + validarCampos);
                        return;
                    }

                    E_Tarjeta tarjeta = new E_Tarjeta();

                    tarjeta.documentoPersonaTarjeta = int.Parse(txtDNI.Text);
                    bool existedoc = objLN_Tarjeta.ExisteNroDocumento(tarjeta.documentoPersonaTarjeta);
                    if (existedoc == false)
                    {
                        MessageBox.Show("Ingresó mal el numero de documento o usted no tiene un usuario creado. Debe registrarse como usuario para registrar una tarjeta.");
                        return;
                    }
                    tarjeta.numeroTarjeta = int.Parse(txtNroTarjeta.Text);
                    tarjeta.saldoTarjeta = Convert.ToDouble(txtSaldo.Text);

                    objLN_Tarjeta.EditarTarjetass(tarjeta);
                    MessageBox.Show("se edito correctamente");
                    MostrarTarjeta();
                    limpiarForm();
                    Editar = false;

                    btnCargarSaldo.Enabled = true; btnEliminar.Enabled = true; btnEditar.Enabled = true; btnPagarViaje.Enabled = true; bt_Persona.Enabled = true; txtViaje.Enabled = true; txtSaldo.Enabled = true; btnSeleccionarSaldo.Enabled = true; txtSaldo.Enabled = true; txtNroTarjeta.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNroTarjeta.Enabled = false;

                txtDNI.Text = dataGridView1.CurrentRow.Cells["dniTarjeta"].Value.ToString();
                txtNroTarjeta.Text = dataGridView1.CurrentRow.Cells["NumeroTarjeta"].Value.ToString();
                txtSaldo.Text = dataGridView1.CurrentRow.Cells["Saldo"].Value.ToString();

                btnPasaje.Enabled = false; txtNroTarjeta.Enabled = false; btnCargarSaldo.Enabled = false; btnEliminar.Enabled = false; btnEditar.Enabled = false; btnPagarViaje.Enabled = false; bt_Persona.Enabled = false; txtViaje.Enabled = false; txtSaldo.Enabled = false; btnSeleccionarSaldo.Enabled = false; txtSaldo.Enabled = false;
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idTarjeta = dataGridView1.CurrentRow.Cells["NumeroTarjeta"].Value.ToString();
                objLN_Tarjeta.EliminarTarjetass(idTarjeta);
                MessageBox.Show("Eliminado correctamente");
                MostrarTarjeta();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void bt_Persona_Click(object sender, EventArgs e)
        {
            Form formulario = new Persona();
            formulario.Show();
            //this.Close();
        }

        private void SeleccionarSaldo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtDNI.Text = dataGridView1.CurrentRow.Cells["dniTarjeta"].Value.ToString();
                txtNroTarjeta.Text = dataGridView1.CurrentRow.Cells["NumeroTarjeta"].Value.ToString();
                txtSaldo.Text = dataGridView1.CurrentRow.Cells["Saldo"].Value.ToString();

                btnGuardar.Enabled = false; btnEliminar.Enabled = false; btnEditar.Enabled = false; btnPagarViaje.Enabled = false; bt_Persona.Enabled = false; txtNroTarjeta.Enabled = false; txtDNI.Enabled = false; txtViaje.Enabled = false; btnPasaje.Enabled = false;
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnCargarSaldo_Click(object sender, EventArgs e)
        {
            if (Editar == true)
            {
                try
                {
                    if (txtSaldo.Text == "")
                    {
                        MessageBox.Show("debe ingresar un valor");
                        return;
                    }

                    E_Tarjeta tarjeta = new E_Tarjeta();

                    tarjeta.documentoPersonaTarjeta = int.Parse(txtDNI.Text);
                    tarjeta.numeroTarjeta = int.Parse(txtNroTarjeta.Text);

                    double saldo = double.Parse(dataGridView1.CurrentRow.Cells["Saldo"].Value.ToString());
                    double nuevoSaldo = double.Parse(txtSaldo.Text);
                    txtSaldo.Text = nuevoSaldo.ToString("00000.00");
                    if (nuevoSaldo  < 0)
                    {
                        txtSaldo.Text = "0";
                        MessageBox.Show("debe ingresar un valor mayor o igual a cero");
                        return;
                    }
                    double saldoFinal = CargarSaldo(saldo, nuevoSaldo);

                    tarjeta.saldoTarjeta = saldoFinal;

                    objLN_Tarjeta.CargarSaldoTarjetass(tarjeta);
                    MessageBox.Show("se cargó correctamente su saldo");
                    MostrarTarjeta();
                    limpiarForm();

                    btnGuardar.Enabled = true; btnEliminar.Enabled = true; btnEditar.Enabled = true; btnPagarViaje.Enabled = true; bt_Persona.Enabled = true; txtNroTarjeta.Enabled = true; txtDNI.Enabled = true; txtSaldo.Enabled = true; txtViaje.Enabled = true; btnPasaje.Enabled = true;
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo cargar su saldo por: " + ex);
                }
            }
        }

        private void btnPasaje_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtDNI.Text = dataGridView1.CurrentRow.Cells["dniTarjeta"].Value.ToString();
                txtNroTarjeta.Text = dataGridView1.CurrentRow.Cells["NumeroTarjeta"].Value.ToString();
                //txtViaje.Text = dataGridView1.CurrentRow.Cells["Saldo"].Value.ToString();

                btnGuardar.Enabled = false; btnEliminar.Enabled = false; btnEditar.Enabled = false; btnPagarViaje.Enabled = true; bt_Persona.Enabled = false; txtNroTarjeta.Enabled = false; txtDNI.Enabled = false; txtViaje.Enabled = true; btnCargarSaldo.Enabled = false; btnSeleccionarSaldo.Enabled = false; txtSaldo.Enabled = false;
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnPagarViaje_Click(object sender, EventArgs e)
        {
            if (Editar == true)
            {
                try
                {
                    if (txtViaje.Text == "")
                    {
                        MessageBox.Show("debe ingresar un valor mayor a cero");
                        return;
                    }

                    E_Tarjeta tarjeta = new E_Tarjeta();

                    tarjeta.documentoPersonaTarjeta = int.Parse(txtDNI.Text);
                    tarjeta.numeroTarjeta = int.Parse(txtNroTarjeta.Text);

                    double saldo = double.Parse(dataGridView1.CurrentRow.Cells["Saldo"].Value.ToString());
                    if (saldo <= -45)
                    {
                        btnGuardar.Enabled = true; btnEliminar.Enabled = true; btnEditar.Enabled = true; btnPagarViaje.Enabled = true; bt_Persona.Enabled = true; txtNroTarjeta.Enabled = true; txtDNI.Enabled = true; txtSaldo.Enabled = true; txtViaje.Enabled = true; btnCargarSaldo.Enabled = true; btnSeleccionarSaldo.Enabled = true;
                        Editar = false; txtViaje.Text = "0";
                        MessageBox.Show("debe cargar saldo a su tarjeta");
                        return;
                    }
                    double costo = double.Parse(txtViaje.Text);
                    txtSaldo.Text = costo.ToString("00000.00");
                    double saldoFinal = PagarPasaje(saldo, costo);
                    tarjeta.saldoTarjeta = saldoFinal;

                    objLN_Tarjeta.PagarPasajeTarjetass(tarjeta);
                    MessageBox.Show("se pagó correctamente su pasaje");
                    MostrarTarjeta();
                    limpiarForm();

                    btnGuardar.Enabled = true; btnEliminar.Enabled = true; btnEditar.Enabled = true; btnPagarViaje.Enabled = true; bt_Persona.Enabled = true; txtNroTarjeta.Enabled = true; txtDNI.Enabled = true; txtSaldo.Enabled = true; txtViaje.Enabled = true; btnCargarSaldo.Enabled = true; btnSeleccionarSaldo.Enabled = true;
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo cargar su saldo por: " + ex);
                }
            }
            limpiarForm();
        }
               
        private double CargarSaldo(double saldo, double nSaldo)
        {
            double saldoFinal = 0.0;

            double saldoInicial = saldo;
            double nuevoSaldo = nSaldo;
            saldoFinal = saldoInicial + nuevoSaldo;

            return saldoFinal;
        }

        private double PagarPasaje(double saldo, double costo)
        {
            double saldoFinal = 0.0;

            double saldoInicial = saldo;
            double costoPasaje = costo;
            saldoFinal = saldoInicial - costoPasaje;

            return saldoFinal;
        }

        /// <summary>
        /// Control de eventos de los textBox
        /// </summary>
        #region VALIDACIONES DE EVENTOS
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtNroTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtViaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}

