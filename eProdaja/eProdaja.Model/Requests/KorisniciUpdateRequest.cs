﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model.Requests
{
    public class KorisniciUpdateRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public bool? Status { get; set; }

        public List<int> Uloge { get; set; } = new List<int>();
    }
}
