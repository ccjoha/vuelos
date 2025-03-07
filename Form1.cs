using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace vuelos
{
    public partial class Form1 : Form
    {
        List<Vuelos> lsvuelos = new List<Vuelos>();
        List<Reserva> listaReservas = new List<Reserva>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Vuelos_Load(object sender, EventArgs e)
        {
            listBoxVuelos.DataSource = lsvuelos;
        }

        private void ActualizarReservas()
        {
            ListReservas.DataSource = null;
            ListReservas.DataSource = listaReservas;
        }

        public bool CheckData(String Codigo, string Origen, string Destino, string FechaSalida, string AsientosDisponible)
        {
            return (Codigo != "" && Origen != "" && Destino != "" && FechaSalida != "" && AsientosDisponible != "");
        }

        public List<Vuelos> SearchVuelos(String Codigo)
        {
            List<Vuelos> listavuelosFound = new List<Vuelos>();
            Vuelos viajesFound = new Vuelos();
            
            // Buscar a través del método FindIndex()
            int indexFound = lsvuelos.FindIndex(viajes => viajes.Codigo == Codigo);
            if (indexFound != -1)
            {
                viajesFound.Codigo = lsvuelos[indexFound].Codigo;
                viajesFound.Origen = lsvuelos[indexFound].Origen;
                viajesFound.Destino = lsvuelos[indexFound].Destino;
                viajesFound.FechaSalida = lsvuelos[indexFound].FechaSalida;
                viajesFound.AsientosDisponibles = lsvuelos[indexFound].AsientosDisponibles;
                listavuelosFound.Add(viajesFound);
            }
            return listavuelosFound;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            VuelosRefresh();
        }

        private void VuelosRefresh()
        {
            listBoxVuelos.DataSource = null;
            listBoxVuelos.DataSource = lsvuelos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarVuelo_Click(object sender, EventArgs e)
        {
            Vuelos viajes = new Vuelos();
            string mCodigo = Codigo.Text;
            string mOrigen = Origen.Text;
            string mDestino = Destino.Text;
            string mFechaSalida = FechaSalida.Text;
            int mAsientosDisponibles;

            // Validar que el número de asientos sea un entero
            if (!int.TryParse(AsientosDisponibles.Text, out mAsientosDisponibles))
            {
                MessageBox.Show("El número de asientos disponibles debe ser un número entero.");
                return;
            }

            if (CheckData(mCodigo, mOrigen, mDestino, mFechaSalida, AsientosDisponibles.Text))
            {
                if (SearchVuelos(mCodigo).Count() == 0)
                {
                    viajes.Codigo = mCodigo;
                    viajes.Origen = mOrigen;
                    viajes.Destino = mDestino;
                    viajes.FechaSalida = mFechaSalida;  // Se guardará como string en la clase
                    viajes.AsientosDisponibles = mAsientosDisponibles.ToString();  // Convertir a string

                    lsvuelos.Add(viajes);
                    MessageBox.Show($"El vuelo {mCodigo} ha sido agregado correctamente");
                    VuelosRefresh();
                }
                else
                {
                    MessageBox.Show($"El vuelo con código {mCodigo} ya existe. Inténtelo con otro!");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }
        }


        private void BUSCAR_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Codigo.Text)) // No está vacío
            {
                List<Vuelos> found = SearchVuelos(Codigo.Text);
                if (found.Count > 0)
                {
                    Codigo.Text = found[0].Codigo;
                    Origen.Text = found[0].Origen;
                    Destino.Text = found[0].Destino;

                    // Convertir FechaSalida a DateTime si es posible
                    DateTime fecha;
                    if (DateTime.TryParse(found[0].FechaSalida, out fecha))
                    {
                        FechaSalida.Value = fecha; // Asigna a un DateTimePicker
                    }
                    else
                    {
                        MessageBox.Show("Error al convertir la fecha. Formato inválido.");
                    }

                    AsientosDisponibles.Text = found[0].AsientosDisponibles;
                }
                else
                {
                    MessageBox.Show($"El vuelo con código {Codigo.Text} NO existe. Inténtelo con otro!");
                }
            }
        }


        private void Reservar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Codigo.Text) || string.IsNullOrWhiteSpace(PReservas.Text))
            {
                MessageBox.Show("Debe ingresar el código del vuelo y la cantidad de asientos a reservar.");
                return;
            }

            int puestosReservar;
            if (!int.TryParse(PReservas.Text, out puestosReservar) || puestosReservar <= 0)
            {
                MessageBox.Show("Debe ingresar un número válido de asientos a reservar.");
                return;
            }

            // Buscar el vuelo
            var vuelo = lsvuelos.FirstOrDefault(v => v.Codigo == Codigo.Text);
            if (vuelo == null)
            {
                MessageBox.Show("El vuelo no existe.");
                return;
            }

            int asientosDisponibles;
            if (!int.TryParse(vuelo.AsientosDisponibles, out asientosDisponibles))
            {
                MessageBox.Show("Error en la información del vuelo.");
                return;
            }

            // Validar que haya asientos suficientes
            if (asientosDisponibles < puestosReservar)
            {
                MessageBox.Show("No hay suficientes asientos disponibles.");
                return;
            }

            // Restar los asientos disponibles
            asientosDisponibles -= puestosReservar;
            vuelo.AsientosDisponibles = asientosDisponibles.ToString();

            // Crear la reserva y agregarla a la lista
            Reserva nuevaReserva = new Reserva
            {
                CodigoVuelo = vuelo.Codigo,
                Origen = vuelo.Origen,
                Destino = vuelo.Destino,
                FechaSalida = DateTime.Parse(vuelo.FechaSalida),
                AsientosReservados = puestosReservar
            };
            listaReservas.Add(nuevaReserva);

            
            VuelosRefresh();

            
            ActualizarReservas();

            MessageBox.Show("Reserva realizada con éxito.");

        }
    }
}
