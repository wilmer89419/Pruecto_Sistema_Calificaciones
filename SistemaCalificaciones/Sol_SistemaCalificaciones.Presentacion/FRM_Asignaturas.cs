using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sol_SistemaCalificaciones.Entidades;
using Sol_SistemaCalificaciones.Negocio;

namespace Sol_SistemaCalificaciones.Presentacion
{
    public partial class FRM_Asignaturas : Form
    {
        public FRM_Asignaturas()
        {
            InitializeComponent();
        }

        #region "Mis variables"
        int ID_Asignatura = 0;//wilmer
        int EstadoGuardar = 0; //Sin ninguna acción

        private void Selecciona_Item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["ID_Asignatura"].Value)))

            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }




            else

                {
                this.ID_Asignatura = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["ID_Asignatura"].Value);
            Txt_Asignatura.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["Nombre"].Value);
            }


            




        }
        #endregion

        #region "Mis métodos"

        private void Formato_asg()
        {
            Dgv_principal.Columns[0].Width = 100;
            Dgv_principal.Columns[0].HeaderText = "ID_Asignatura";
            Dgv_principal.Columns[1].Width = 300;
            Dgv_principal.Columns[1].HeaderText = "Asignatura";

        }

        private void Listado_Asignaturas(string asgTexto)
        {
            try
            {
                Dgv_principal.DataSource = N_Asignaturas.Listado_Asignaturas(asgTexto);
                this.Formato_asg();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        #endregion

        private void FRM_Asignaturas_Load(object sender, EventArgs e)
        {
            this.Listado_Asignaturas("%"); //Buscar todos los registros al cargar el formulario
        }

        private void Btn_Guardar_Asg_Click(object sender, EventArgs e)
        {
            if (Txt_Asignatura.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Avisos del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                E_Asignaturas oAsg = new E_Asignaturas();
                string Respuesta = "";
                oAsg.ID_Asignatura = this.ID_Asignatura;
                oAsg.Nombre = Txt_Asignatura.Text.Trim();
                Respuesta = N_Asignaturas.Guardar_Asignatura(EstadoGuardar, oAsg);

                    if (Respuesta == "OK")
                    {
                        this.Listado_Asignaturas("%"); //Actualizar el DataGridView al guardar un nuevo registro

                        MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        EstadoGuardar = 0; //Sin ninguna acción

                        this.Estado_BotonesPrincipales(true);
                        this.Estado_BotonesProcesos(false);
                        Txt_Asignatura.ReadOnly = true;
                        Txt_Asignatura.Text = "";
                        Tbp_principal.SelectedIndex = 0;
                    this.ID_Asignatura = 0;//wilmer


                }
                    else
                    {
                        MessageBox.Show(Respuesta, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }

        private void Estado_BotonesPrincipales(bool lEstado)
        {
            this.Btn_Nuevo.Enabled = lEstado;
            this.Btn_Actualizar.Enabled = lEstado;
            this.Btn_Eliminar.Enabled = lEstado;
            this.Btn_Reporte.Enabled = lEstado;
            this.Btn_Salir.Enabled = lEstado;
        }

        private void Estado_BotonesProcesos(bool lEstado)
        {
            this.Btn_Guardar_Asg.Visible = lEstado;
            this.Btn_Cancelar_Asg.Visible = lEstado;
            this.Btn_Retomar_Asg.Visible = !lEstado;
        }


        /*boton nuevo evento click*/
        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            EstadoGuardar = 1; //Nuevo registro
            Txt_Asignatura.ReadOnly = false;
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProcesos(true);
            Txt_Asignatura.Text = "";
            Tbp_principal.SelectedIndex = 1;
            Txt_Asignatura.Focus();

        }

        /* boton actualizar evento click*/
        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            EstadoGuardar = 2; //Actualizar registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProcesos(true);
            this.Selecciona_Item();
            Tbp_principal.SelectedIndex = 1;
            Txt_Asignatura.ReadOnly = false;
            Txt_Asignatura.Focus();
        }

        /*boton cancelar evento click*/
        private void Btn_Cancelar_Asg_Click(object sender, EventArgs e)
        {
            this.ID_Asignatura = 0;//wilmer
            EstadoGuardar = 0;
            Txt_Asignatura.ReadOnly = true;
            Txt_Asignatura.Text = "";
            this.Estado_BotonesProcesos(false);
            this.Estado_BotonesPrincipales(true);
            Tbp_principal.SelectedIndex = 0;
        }


        /*boton eliminar evento click*/
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["ID_Asignatura"].Value)))

            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else

            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Estás seguro de eliminar el registro seleccionado?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if(Opcion==DialogResult.Yes)
                {

                    string Respuesta = "";
                    this.ID_Asignatura = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["ID_asignatura"].Value);
                    //Enviar a ejecutar la eliminacion de datos
                    Respuesta = N_Asignaturas.Eliminar_Asignatura(this.ID_Asignatura);
                
                if (Respuesta.Equals("OK"))

                    {
                       this.Listado_Asignaturas("%"); //Actualizar el DataGridView al Eliminar un registro
                        this.ID_Asignatura = 0;
                        MessageBox.Show("Registro Eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        
                    }
                
                
                
                }
                   
                
                
               
            }
        }
        //lo cree por accidente
        private void Dgv_principal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        /*boton retomar evento click*/
        private void Btn_Retomar_Asg_Click(object sender, EventArgs e)
        {

            this.Estado_BotonesProcesos(false);
            Tbp_principal.SelectedIndex = 0;
            this.ID_Asignatura = 0;

         
        }

       private void Dgv_principal_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_Item();
            this.Estado_BotonesProcesos(false);
            Tbp_principal.SelectedIndex = 1;

        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            this.Listado_Asignaturas(Txt_Buscar.Text.Trim());
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
