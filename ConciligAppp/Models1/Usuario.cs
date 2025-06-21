﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConciligAppp.Models1
{
    public class Usuario
    {
       
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Email { get; set; }
            public string SenhaHash { get; set; }
            public List<ArquivoImportado> ArquivosImportados { get; set; }
    }
}
