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
using System.IO;

namespace AsyncAwait
{
    public partial class Form1 : Form
    {
        //Escribo el Pathing del Usuario por tema de compatibilidad con diferentes nombres de usuario y demás...
        readonly String path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\prova";
       
        List<string> _lista;

        public Form1()
        {
            InitializeComponent();
            //Creo el archivo para que no pete, por si por casualidad no esta el archivo creado
            creaArchivo();
        }

        private async Task listaSequencial()
        {

            _lista = new List<string>();

            Stopwatch reloj = new Stopwatch();
            reloj.Restart();

            foreach (string d in Directory.GetDirectories(path))
            {
                foreach (string s in Directory.GetFiles(d))
                {
                    _lista.Add(s);
                    System.Threading.Thread.Sleep(1);
                }
            }

            listBoxSequencial.DataSource = _lista;
            reloj.Stop();
            textBoxSequencial.Text = reloj.Elapsed.TotalSeconds.ToString() + " segundos";

        }

        private async Task listaAsync()
        {
            _lista = new List<string>();
            Stopwatch reloj = new Stopwatch();
            reloj.Restart();

            Parallel.ForEach(Directory.GetDirectories(path), i =>
            {
                foreach (string s in Directory.GetFiles(i))
                {
                    _lista.Add(s);
                    System.Threading.Thread.Sleep(1);
                }
            });

            listBoxAsync.DataSource = _lista;

            reloj.Stop();
            textBoxAsync.Text = reloj.Elapsed.TotalSeconds.ToString() + " segundos";
        }

        public void creaArchivo()
        {
            if (!Directory.Exists(path))
            {
                DirectoryInfo di = Directory.CreateDirectory(path);
            }

            //EXTRA:Si el archivo no existe que lo cree y luego meta cosas dentro automaticamente...
        }

        private void btn_horaLocal_Click(object sender, EventArgs e)
        {
            textBoxHoraLocal.Text = "Son les " + DateTime.Now.ToString("HH:mm:ss");
        }

        private async void btn_sequencial_Click(object sender, EventArgs e)
        {
            await listaSequencial();
        }

        private async void btn_Async_Click(object sender, EventArgs e)
        { 
            await listaAsync();
        }
    }
}
