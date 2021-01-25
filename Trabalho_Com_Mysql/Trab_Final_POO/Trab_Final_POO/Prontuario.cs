using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Trab_Final_POO
{
    class Prontuario
    {
        //public string NumeroGuia { get; set; }
        public string DataPront { get; set; }
        public string IndicacaoClinica { get; set; }
        public string Prioridade { get; set; }
        public string Medicacao { get; set; }
        public string Diabetes { get; set; }
        public string Cardiaco { get; set; }
        public string Hipertenso { get; set; }
        public string Alergia { get; set; }
        public string Fumante { get; set; }
        public string Alcoolismo { get; set; }
        public string Observacao { get; set; }
        public string IdPaciente { get; set; }
        public string IdMedico { get; set; }

    }
}
