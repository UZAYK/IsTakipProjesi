using IsTakip.Entities.Concrete;
using System;

namespace IsTakip.DTO.DTOs.GorevDtos
{
    public class GorevListDto
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public bool Durum { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }

        public int AciliyetId { get; set; }
        public Aciliyet Aciliyet { get; set; }
    }
}
