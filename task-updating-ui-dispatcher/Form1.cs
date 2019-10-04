using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_updating_ui_dispatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double calcularMedias(long numValores)
        {
            double total = 0;
            Random rand = new Random();
            for (long valores = 0; valores < numValores; valores++)
            {
                total = total + rand.NextDouble();
            }
            return total / numValores;
        }

        private Task<double> asyncCalcularMedias(long numValores)
        {
            return Task.Run(() =>
            {
                return calcularMedias(numValores);
            });
        }

        private async void BtnEmpezar_Click(object sender, EventArgs e)
        {
            long numValores = long.Parse(txtResultado.Text);

            double resultado = await asyncCalcularMedias(numValores);
            lblResultado.Text = $"Resultado: {resultado}";

            // Ejecuta método en tarea para no bloquear la UI
            /*Dispatcher dispatcher = Dispatcher.CurrentDispatcher;
            Task.Run(() =>
            {
                double result = calcularMedias(numValores);

                // En Windows Forms podemos utilizar el dispatcher del hilo de la interfaz de usuario
                dispatcher.BeginInvoke(new Action(() => {
                    lblResultado.Text = $"Resultado: {result}";
                }));

                // En aplicaciones universales de Winodws o WPF sería así:
                /*lblResultado.Dispatcher.RunAsync(CoreDispatcherPriority.Normal
                {
                    lblResultado.Text = $"Resultado: {result}";
                });*/
            // });

            // Con valores altos bloquea la interfaz de usuario..
            //lblResultado.Text = $"Resultado: {calcularMedias(numValores)}";

        }
    }
}
