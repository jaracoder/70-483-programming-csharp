using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace async.exceptions
{
    class Program
    {
        private async Task<string> ObtenerPaginaWeb(string url)
        {
            HttpClient httpClient = new HttpClient();
            return await httpClient.GetStringAsync(url);
        }

        static void Main(string[] args)
        {


        }
    }
}
