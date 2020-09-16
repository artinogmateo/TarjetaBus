using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using LogicaDeNegocio;

namespace Presentacion
{
    public partial class Persona : Form
    {
        E_Persona objE_Persona = new E_Persona();
        private string idPersona = null;
        private bool Editar = false;
        LN_Persona objLN_Persona = new LN_Persona();

        public Persona()
        {
            InitializeComponent();
            MostrarPersonass();
            dataGridView2.Visible = false;
            txtEdad.Enabled = false;
        }

        #region METODOS
        private void MostrarPersonass()
        {
            LN_Persona objeto = new LN_Persona();
            dataGridView1.DataSource = objeto.MostrarPersonass();
        }

        private void limpiarForm()
        {
            txtApellido.Clear();
            txtEdad.Clear();
            txtCUIL.Clear();
            txtNombre.Clear();
            txtCUIL.Clear();
            txtDocumento.Clear();
            cmbDocumento.Items.Clear();
            dtFecha.Value = DateTime.Now;
        }

        private int CalcularEdad(DateTime FechaNacimiento)
        {
            int edad = DateTime.Today.Year - FechaNacimiento.Year;
            if (DateTime.Today.Month < FechaNacimiento.Month)
                --edad;
            else if (DateTime.Today.Month == FechaNacimiento.Month && DateTime.Today.Day < FechaNacimiento.Day)
                --edad;
            return edad;
        }

        private void VerificarTarjetas()
        {
            MessageBox.Show("de las personas cargadas las tarjetas existentes son las siguientes: ");
            dataGridView2.DataSource = objLN_Persona.ExistenTarjetass();
        }
        
        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;

            if (Editar == false)
            {
                try
                {
                    string camposObligatorios = "";
                    if (txtNombre.Text == "")
                        camposObligatorios = camposObligatorios + " - Nombre";
                    if (txtApellido.Text == "")
                        camposObligatorios = camposObligatorios + " - Apellido";
                    if (cmbDocumento.Text == "")
                        camposObligatorios = camposObligatorios + " - Tipo de Documento";
                    if (txtDocumento.Text == "")
                        camposObligatorios = camposObligatorios + " - Numero de Documento";

                    string validarCampos = camposObligatorios;
                    if (validarCampos != "")
                    {
                        MessageBox.Show("Complete los siguientes campos: " + validarCampos);
                        return;
                    }
                    if (dtFecha.Value >= DateTime.Today)
                    {
                        MessageBox.Show("Debe establecer una fecha de nacimiento anterior a la de hoy");
                        return;
                    }

                    DateTime fechanacim;
                    fechanacim = Convert.ToDateTime(dtFecha.Text);
                    int edad = CalcularEdad(fechanacim);
                    txtEdad.Text = edad.ToString();

                    E_Persona persona = new E_Persona();

                    persona.nombresPersona = txtNombre.Text;
                    persona.apellidosPersona = txtApellido.Text;
                    persona.tipoDocumento = cmbDocumento.Text;
                    persona.documentoNumero = int.Parse(txtDocumento.Text);
                    bool existedoc = objLN_Persona.ExisteNroDocumento(persona.documentoNumero);
                    if (existedoc == true)
                    {
                        MessageBox.Show("Ya existe un usuario con ese numero de documento, verifique que sea el correcto.");
                        return;
                    }
                    persona.CUIL = long.Parse(txtCUIL.Text);
                    persona.fechaNacimiento = DateTime.Parse(dtFecha.Text);
                    persona.edadPersona = int.Parse(txtEdad.Text);

                    objLN_Persona.InsetarPersonass(persona);
                    MessageBox.Show("se insertó correctamente");
                    dataGridView2.Visible = false;
                    MostrarPersonass();
                    limpiarForm();

                    btnEditar.Enabled = true; btnEliminar.Enabled = true; btn_Tarjeta.Enabled = true; btnExisteTarjeta.Enabled = true;
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
                    if (txtNombre.Text == "")
                        camposObligatorios = camposObligatorios + " - Nombre";
                    if (txtApellido.Text == "")
                        camposObligatorios = camposObligatorios + " - Apellido";
                    if (cmbDocumento.Text == "")
                        camposObligatorios = camposObligatorios + " - Tipo de Documento";
                    if (txtDocumento.Text == "")
                        camposObligatorios = camposObligatorios + " - Numero de Documento";

                    string validarCampos = camposObligatorios;
                    if (validarCampos != "")
                    {
                        MessageBox.Show("Complete los siguientes campos: " + validarCampos);
                        return;
                    }
                    if (dtFecha.Value >= DateTime.Today)
                    {
                        MessageBox.Show("Debe establecer una fecha de nacimiento anterior a la de hoy");
                        return;
                    }

                    DateTime fechanacim;
                    fechanacim = Convert.ToDateTime(dtFecha.Text);
                    int edad = CalcularEdad(fechanacim);
                    txtEdad.Text = edad.ToString();

                    E_Persona persona = new E_Persona();

                    persona.nombresPersona = txtNombre.Text;
                    persona.apellidosPersona = txtApellido.Text;
                    persona.tipoDocumento = cmbDocumento.Text;
                    persona.documentoNumero = int.Parse(txtDocumento.Text);
                    persona.CUIL = long.Parse(txtCUIL.Text);
                    persona.fechaNacimiento = DateTime.Parse(dtFecha.Text);
                    persona.edadPersona = int.Parse(txtEdad.Text);

                    objLN_Persona.EditarPersonass(persona);
                    MessageBox.Show("se ha editado correctamente");
                    dataGridView2.Visible = false;
                    MostrarPersonass();
                    limpiarForm();
                    Editar = false;

                    btnEditar.Enabled = true; btnEliminar.Enabled = true; btn_Tarjeta.Enabled = true; btnExisteTarjeta.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtDocumento.Enabled = false;

                txtNombre.Text = dataGridView1.CurrentRow.Cells["NombrePersona"].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells["ApellidoPersona"].Value.ToString();
                cmbDocumento.Text = dataGridView1.CurrentRow.Cells["TipoDocumento"].Value.ToString();
                txtDocumento.Text = dataGridView1.CurrentRow.Cells["Ndocumento"].Value.ToString();
                txtCUIL.Text = dataGridView1.CurrentRow.Cells["CUIL"].Value.ToString();
                dtFecha.Text = dataGridView1.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
                txtEdad.Text = dataGridView1.CurrentRow.Cells["Edad"].Value.ToString();

                btnEditar.Enabled = false; btnEliminar.Enabled = false; btn_Tarjeta.Enabled = false; btnExisteTarjeta.Enabled = false;
            }
            else
                MessageBox.Show(" por favor seleccione una fila");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idPersona = int.Parse(dataGridView1.CurrentRow.Cells["Ndocumento"].Value.ToString());
                bool existeTarjeta = objLN_Persona.ExisteTarjetaAsociada(idPersona);
                if (existeTarjeta == true)
                {
                    MessageBox.Show("Esta persona tiene al menos una tarjeta asociada. Para eliminar una persona no debe contar con tarjetas asociadas a su número de documento.");
                    return;
                }
                objLN_Persona.EliminarPersonass(idPersona);
                MessageBox.Show("Eliminado correctamente");
                dataGridView2.Visible = false;
                MostrarPersonass();
            }
            else
                MessageBox.Show("por favor seleccione una fila");
        }

        private void btn_Tarjeta_Click(object sender, EventArgs e)
        {
            Form formulario = new Tarjeta();
            formulario.Show();
            this.Close();
        }

        private void btnExisteTarjeta_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            VerificarTarjetas();
        }

        /// <summary>
        /// Control de eventos de los textBox
        /// </summary>
        #region VALIDACIONES DE EVENTOS
        private void txtCUIL_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        #endregion


    }
}
