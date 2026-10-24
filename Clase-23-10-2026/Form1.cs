using BSS;
using ENTITIES;

namespace Clase_23_10_2026
{
    public partial class Form1 : Form
    {
        private TareaBussines bss = new TareaBussines();
        public Form1()
        {
            InitializeComponent();
            limpiarYrefrescar();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                TareaEntity tarea = new TareaEntity();
                tarea.DescripcionTarea = txtDescripcionAlta.Text;
                tarea.FechaTarea = fechaAlta.Value;
                bss.save(tarea);
                MessageBox.Show("Guardado!");
                limpiarYrefrescar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void limpiarYrefrescar()
        {
            txtDescripcionAlta.Text = "";
            txtIdTareaModificar.Text = "";
            dataGridView1.DataSource = null;

            try
            {
                dataGridView1.DataSource = bss.getAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                bss.modificar(Convert.ToInt32(txtIdTareaModificar.Text), txtDescripcionModificar.Text, fechaModificacion.Value);
                MessageBox.Show("Modificado!");
                limpiarYrefrescar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                bss.eliminarTarea(Convert.ToInt32(txtIdEliminar.Text));
                MessageBox.Show("Eliminado!");
                limpiarYrefrescar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
