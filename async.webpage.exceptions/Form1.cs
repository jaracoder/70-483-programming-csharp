using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace async.webpage.exceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async Task<string> ObtenerPaginaWeb(string url)
        {
            HttpClient httpClient = new HttpClient();
            return await httpClient.GetStringAsync(url);
        }

        private async Task<IEnumerable<string>> ObtenerPaginasWeb(string[] urls)
        {
            var tareas = new List<Task<string>>();

            foreach (string url in urls)
            {
                tareas.Add(ObtenerPaginaWeb(url));
            }

            return await Task.WhenAll(tareas);
        }

        private async void btnNavegar_Click(object sender, EventArgs e)
        {
            try
            {
                txtCodigoFuente.Text = await ObtenerPaginaWeb(txtUrl.Text);
                lblResultado.Text = "Página cargada";
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
        }
    }
}
