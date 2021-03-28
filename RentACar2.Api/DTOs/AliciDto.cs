﻿using System.ComponentModel.DataAnnotations;

namespace RentACar2.API.DTOs
{
    public class AliciDto
    {
        public int AliciID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        [Required]
        public string TCKimlikNo { get; set; }
        [Required]
        public string CepTel { get; set; }
        [Required]
        public string Mail { get; set; }
        public string Adres { get; set; }
    }
}
