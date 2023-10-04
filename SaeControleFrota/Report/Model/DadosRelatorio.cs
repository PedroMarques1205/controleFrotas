using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaeControleFrota.Report.Model
{
    public class DadosRelatorio
    {
        public string Placa { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public string Mororista { get; set; }
        public string TipoDeAtividade { get; set; }
        public double ValorToal { get; set; }
        public DateTime Data { get; set; }
    }
}
