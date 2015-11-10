using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGit
{
    public class ComandoUtente
    {
        public ComandoUtente(string commandLine)
        {
            this.LineaInput = commandLine;
            string[] list = commandLine.ToUpper().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            this.Nome = list[0];
            this.Argomenti = GetArgomenti(list);
        }
        public string LineaInput { get; private set; }
        public string Nome { get; private set; }
        public string[] Argomenti { get; private set; }
        private string[] GetArgomenti(string[] list)
        {
            //!copia gli elementi di list tranne il primo
            string[] args = new string[list.Length - 1];
            Array.Copy(list, 1, args, 0, args.Length);
            return args;
        }
        
    }
}
