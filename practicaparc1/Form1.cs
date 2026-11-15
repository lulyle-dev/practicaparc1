using Business;
using Identity;

namespace practicaparc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ReservaBusiness reservabusiness = new ReservaBusiness();
        TipoSalaBusiness tiposalabusiness = new TipoSalaBusiness();

        public void ActualizarDGV()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reservabusiness.ObtenerReservas();
        }

        public void actualizarCombobox()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = tiposalabusiness.ObtenerTipoSala();

            comboBox1.ValueMember = "idTipoSala";
            comboBox1.DisplayMember = "descripcion";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarDGV();
            actualizarCombobox();
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Reserva nuevareserva = retornarCampos();
                reservabusiness.AgregarReserva(nuevareserva);
                limpiarCampos();
                ActualizarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Reserva retornarCampos()
        {
            Reserva reserva = new Reserva();
            reserva.Dni = textBox_dni.Text;
            reserva.Importe = Convert.ToInt32(textBox_importe.Text);
            reserva.FechaReserva = dateTimePicker1.Value;
            reserva.FechaRegistro = DateTime.Now;
            TipoSala tiposala = new TipoSala();
            tiposala.IdTipoSala = Convert.ToInt32(comboBox1.SelectedValue);
            reserva.TipoSala = tiposala;
            return reserva;

        }

        public void limpiarCampos()
        {
            textBox_dni.Clear();
            textBox_eliminar.Clear();
            textBox_importe.Clear();
            comboBox1.SelectedIndex = -1;

        }

        private void button_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                reservabusiness.modificarReserva(Convert.ToInt32(textBox_eliminar.Text), Convert.ToInt32(textBox_importe.Text), dateTimePicker1.Value);
                MessageBox.Show("se han guardado las modificaciones");
                ActualizarDGV();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                reservabusiness.EliminarReserva(Convert.ToInt32(textBox_eliminar.Text));
                MessageBox.Show("se ha eliminado la reserva");
                ActualizarDGV();
                limpiarCampos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
