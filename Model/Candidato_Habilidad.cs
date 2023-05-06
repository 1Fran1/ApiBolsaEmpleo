using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBolsaEmpleo.Model
{
    public class Candidato_Habilidad
    {
        public int CandidatoId { get; set; }
        public int HabilidadId { get; set; }
        public Candidato candidato { get; set; }
        public Habilidad habilidad { get; set; }


    }
}
