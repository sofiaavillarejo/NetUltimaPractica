using Microsoft.Data.SqlClient;
using NetUltimaPractica.Models;
using NetUltimaPractica.Repositories;

namespace NetUltimaPractica
{
    public partial class Form1 : Form
    {
        RepositoryCrud repo;
        public Form1()
        {
            InitializeComponent();
            this.repo = new RepositoryCrud();
            this.LoadDptos();
        }
        private async Task LoadDptos()
        {
            List<string> nombreDptos = await this.repo.GetDepartamentosAsync();
            this.cmbDptos.Items.Clear();
            foreach (string dpto in nombreDptos)
            {
                this.cmbDptos.Items.Add(dpto);
            }
        }

        private async Task RefrescarListaEmpleados(string nombreDpto)
        {
            List<Empleado> empleados = await this.repo.GetEmpleadosAsync(nombreDpto);
            this.lstEmpleados.Items.Clear();
            foreach (Empleado emp in empleados)
            {
                this.lstEmpleados.Items.Add(emp.Apellido + " - " + emp.Oficio + " - " + emp.Salario);
            }
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int idDpto = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string loc = this.txtLocalidad.Text;
            await this.repo.PostDepartamentoAsync(idDpto, nombre, loc);
            await this.LoadDptos();
        }

        private async void cmbDptos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbDptos.SelectedIndex != -1)
            {
                string nombre = this.cmbDptos.SelectedItem.ToString();
                Departamento dpto = await this.repo.GetDatosDptosAsync(nombre);
                this.txtId.Text = dpto.DptoNum.ToString();
                this.txtNombre.Text = dpto.Nombre;
                this.txtLocalidad.Text = dpto.Localidad;

                List<Empleado> empleados = await this.repo.GetEmpleadosAsync(nombre);
                this.lstEmpleados.Items.Clear();
                foreach (Empleado emp in empleados)
                {
                    this.lstEmpleados.Items.Add(emp.Apellido + " - " + emp.Oficio + " - " + emp.Salario); ;
                }
            }
        }

        private void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string empleado = this.lstEmpleados.SelectedItem.ToString();
            string[] datos = empleado.Split(" - ");
            if (datos.Length == 3)
            {
                // Asignamos cada parte a los TextBox correspondientes
                this.txtApellido.Text = datos[0]; // Apellido
                this.txtOficio.Text = datos[1];   // Oficio
                this.txtSalario.Text = datos[2];  // Salario
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.lstEmpleados.SelectedIndex != -1)
            {
                // Obtener datos del empleado seleccionado
                string empleado = this.lstEmpleados.SelectedItem.ToString();
                string[] datos = empleado.Split(" - ");
                if (datos.Length == 3)
                {
                    string apellidoOriginal = datos[0]; // Apellido actual del empleado

                    // Obtener nuevos valores desde los TextBox
                    string nuevoApellido = this.txtApellido.Text;
                    string oficio = this.txtOficio.Text;
                    int salario = int.Parse(this.txtSalario.Text);

                    // Llamar al método para actualizar
                    await this.repo.UpdateDataEmpleAsync(apellidoOriginal, nuevoApellido, oficio, salario);

                    // Refrescar la lista de empleados
                    string nombreDpto = this.cmbDptos.SelectedItem.ToString();
                    await this.RefrescarListaEmpleados(nombreDpto);
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string empleado = this.lstEmpleados.SelectedItem.ToString();
            string[] datosEmpleado = empleado.Split(" - ");
            string apellido = datosEmpleado[0];
            await this.repo.DeleteEmpleadoAsync(apellido);
            
            MessageBox.Show("Empleado borrado con éxito");
            string nombreDpto = this.cmbDptos.SelectedItem.ToString();
            await this.RefrescarListaEmpleados(nombreDpto);

            // Refrescar los departamentos en el ComboBox
            await this.LoadDptos();
        }
    }
}
