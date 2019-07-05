using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Domain.Entities
{
    public class Card : BaseEntity
    {

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string Link { get; set; }

        public string Imagem { get; set; }
    }
}
