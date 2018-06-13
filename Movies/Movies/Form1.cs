using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;


namespace Movies
{
    public partial class Inicio : Form
    {
        Controlador control = new Controlador();
        public BaseDeDatos datos = new BaseDeDatos();
        BindingList<string> listaBusqueda = new BindingList<string>();
        BindingList<Object> listaMostrar = new BindingList<Object>();
        BindingList<Critica> criticas = new BindingList<Critica>();


        public Inicio()
        {
            InitializeComponent();
            panelBusqueda.Location = new Point(0, 0);
            panelCriticas.Location = new Point(0, 0);
            timerMensaje.Start();
            lbResultados.Hide();
            panelBievenida.Show();
            panelBusqueda.Hide();
            panelCriticas.Hide();
            panelVer.Hide();
            panelVer.Location = new Point(0, 0);
            lbBusqueda.Text = "";
            lbBusqueda.ForeColor = Color.Red;
            tbBusqueda.ForeColor = Color.Gray;

            #region Datos
            try
            {
                BinaryFormatter formateador = new BinaryFormatter();
                Stream miStream = new FileStream("BDD.bin", FileMode.Open, FileAccess.Read, FileShare.None);
                datos = (BaseDeDatos)formateador.Deserialize(miStream);
                miStream.Close();
            }
            catch
            {
                Actor Homero = new Actor("Homero", "Simpson", "Ebrio", DateTime.Now);
                Productor P = new Productor("El productor de Los Simpsons", "Perez", "Nacio en EEUU...", DateTime.Now);
                Director D = new Director("Director", "Generico", "Nacio en Chile...", DateTime.Now);
                Estudio E = new Estudio("Joliwud", "Los unaited steits", DateTime.Now);
                Pelicula LS = new Pelicula("Los Simpsons", D, "Comedia en monitos", 1000000, DateTime.Now, E);
                Pelicula LTLM = new Pelicula("Los tuyos, los mios y los nuestros", D, "Comedia de personas", 230000, DateTime.Now, E);
                Actor Homero1 = new Actor("Juan", "Soto", "Bla bla", DateTime.Now);
                Productor P1 = new Productor("Fernando", "Daly", "Nacio en Peru...", DateTime.Now);
                Director D1 = new Director("Alfredo", "Soto", "Nacio en Chile...", DateTime.Now);
                Estudio E1 = new Estudio("Peru", "Peru", DateTime.Now);
                Pelicula LS1 = new Pelicula("Los Samsung", D1, "Ciencia ficcion etc etc", 1000000, DateTime.Now, E);
                Pelicula LTLM1 = new Pelicula("Otra Pelicula", D, "Comedia bla bla bla", 230000, DateTime.Now, E1);
                Critica critica = new Critica("Pelicula muy buena", LS, Homero);
                Critica critica1 = new Critica("Pelicula muy mala", LS, Homero1);
                Critica critica2 = new Critica("Pelicula muy bacan", LS, P1);
                Critica critica3 = new Critica("Pelicula muy guena", LTLM, Homero);
                Critica critica4 = new Critica("Pelicula muy wena", LS1, P);
                Critica critica5 = new Critica("Pesima", LTLM1, D);
                Critica critica6 = new Critica("Buena", LTLM, D1);
                Critica critica7 = new Critica("BUUUUU", LS1, Homero1);

                datos.estudios.Add(E);
                datos.peliculas.Add(LS);
                datos.peliculas.Add(LTLM);
                datos.peliculasActor.Add(new PeliculaActor(LS, Homero));
                datos.peliculasProductor.Add(new PeliculaProductor(LS, P));
                datos.personas.Add(D);
                datos.personas.Add(P);
                datos.personas.Add(Homero);
                datos.estudios.Add(E1);
                datos.peliculas.Add(LS1);
                datos.peliculas.Add(LTLM1);
                datos.peliculasActor.Add(new PeliculaActor(LS1, Homero1));
                datos.peliculasProductor.Add(new PeliculaProductor(LS1, P1));
                datos.personas.Add(D1);
                datos.personas.Add(P1);
                datos.personas.Add(Homero1);
                datos.criticas.Add(critica);
                datos.criticas.Add(critica1);
                datos.criticas.Add(critica2);
                datos.criticas.Add(critica3);
                datos.criticas.Add(critica4);
                datos.criticas.Add(critica5);
                datos.criticas.Add(critica6);
                datos.criticas.Add(critica7);
            }
            #endregion
        }

        private void timerMensaje_Tick(object sender, EventArgs e)
        {
            panelBievenida.Hide();
            panelBusqueda.Show();
            timerMensaje.Stop();
        }

        private void tbBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (tbBusqueda.Text.Length < 3)
            {
                lbResultados.Hide();
                lbBusqueda.Text = "Ingrese un minimo de 3 caracteres";
            }
            else
            {
                listaBusqueda = control.buscar(tbBusqueda.Text, datos);
                lbResultados.DataSource = listaBusqueda;
                lbResultados.Refresh();
                if (listaBusqueda.Count > 0)
                {
                    lbResultados.Show();
                }
                else
                {
                    lbResultados.Hide();
                }
                lbBusqueda.Text = "";

            }
        }

        private void tbBusqueda_Click(object sender, EventArgs e)
        {
            if (tbBusqueda.Text == "🔎 Busqueda...")
            {
                tbBusqueda.ForeColor = Color.Black;

                tbBusqueda.Text = "";
            }
            else
            {
                if (tbBusqueda.Text.Length < 3)
                {
                    lbResultados.Hide();
                    lbBusqueda.Text = "Ingrese un minimo de 3 caracteres";
                }
                else
                {
                    listaBusqueda = control.buscar(tbBusqueda.Text, datos);
                    lbResultados.DataSource = listaBusqueda;
                    lbResultados.Refresh();
                    if (listaBusqueda.Count > 0)
                    {
                        lbResultados.Show();
                    }
                    lbBusqueda.Text = "";
                }
            }
        }

        private void panelBusqueda_Click(object sender, EventArgs e)
        {
            lbResultados.Hide();
            if (tbBusqueda.Text.Length == 0)
            {
                tbBusqueda.ForeColor = Color.Gray;

                tbBusqueda.Text = "🔎 Busqueda...";
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            panelVer.Hide();
            panelBusqueda.Show();
            dgvBotones.DataSource = null;
            lbBotones.Items.Clear();

        }

        private void mostrarMenu()
        {
            panelBusqueda.Hide();
            panelVer.Show();
        }

        #region BOTONES
        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            foreach (Pelicula pelicula in datos.peliculas)
            {
                lbBotones.DisplayMember = "nombre";
                lbBotones.Items.Add(pelicula);
            }
            mostrarMenu();

        }
        private void btnActores_Click(object sender, EventArgs e)
        {
            foreach (PeliculaActor pelAct in datos.peliculasActor)
            {
                lbBotones.DisplayMember = "nombre";
                lbBotones.Items.Add(pelAct.Actor);
            }
            mostrarMenu();
        }

        private void btnDirectores_Click_1(object sender, EventArgs e)
        {
            foreach (Persona persona in datos.personas)
            {
                if (persona.Tipo == "director")
                {
                    lbBotones.DisplayMember = "nombre";
                    lbBotones.Items.Add(persona);
                }
            }
            mostrarMenu();
        }

        private void btnProductores_Click_1(object sender, EventArgs e)
        {
            foreach (PeliculaProductor pelProd in datos.peliculasProductor)
            {
                lbBotones.DisplayMember = "nombre";
                lbBotones.Items.Add(pelProd.Persona);
            }
            mostrarMenu();
        }

        private void btnEstudios_Click_1(object sender, EventArgs e)
        {
            foreach (Estudio estudio in datos.estudios)
            {
                lbBotones.DisplayMember = "nombre";
                lbBotones.Items.Add(estudio);
            }
            mostrarMenu();
        }
        #endregion

        private void lbBotones_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listaMostrar.Clear();
                listaMostrar.Add(lbBotones.SelectedItem);
                dgvBotones.DataSource = listaMostrar;
                lbBotones.SelectedItem = "";
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Inicio_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter formateador = new BinaryFormatter();
            Stream miStream = new FileStream("BDD.bin", FileMode.Create, FileAccess.Write);
            formateador.Serialize(miStream, datos);
            miStream.Close();
            MessageBox.Show("Todos los datos modificados han sido guardados con exito.\nGracias por preferirnos");
        }

        private void lbBusqueda_Click(object sender, EventArgs e)
        {
            if (tbBusqueda.Text == "")
            {
                tbBusqueda.ForeColor = Color.Gray;

                tbBusqueda.Text = "🔎 Busqueda...";
            }
        }

        private void btnVolverCriticas_Click(object sender, EventArgs e)
        {
            panelCriticas.Hide();
            panelBusqueda.Show();
        }

        private void btnCriticas_Click(object sender, EventArgs e)
        {
            foreach (Pelicula pelicula in datos.peliculas)
            {
                cbPeliculas.DisplayMember = "nombre";
                cbPeliculas.Items.Add(pelicula);
            }
            criticas.Clear();
            dgvCriticas.DataSource = criticas;
            panelBusqueda.Hide();
            panelCriticas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                criticas = control.devolverCriticas(datos, cbPeliculas.Text);
            }
            catch { }
            dgvCriticas.DataSource = criticas;
            dgvCriticas.Refresh();

        }
    }
}
