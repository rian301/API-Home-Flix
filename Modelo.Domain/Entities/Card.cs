using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Domain.Entities
{
    public class Card : BaseEntity
    {
        public string titulo { get; set; }

        public string descricao { get; set; }

        public string link { get; set; }

        public string imagem { get; set; }
    }
}
