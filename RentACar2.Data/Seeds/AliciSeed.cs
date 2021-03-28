using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar2.Core.Models;

namespace RentACar2.Data.Seeds
{
    public class AliciSeed : IEntityTypeConfiguration<Alici>
    {
        public void Configure(EntityTypeBuilder<Alici> builder)
        {
            builder.HasData(
            new Alici
            {
                AliciID = 1,
                Ad = "Ahmet",
                Soyad = "Yılmaz",
                TCKimlikNo = "11111111110",
                CepTel = "05556667788",
                Mail = "ahmet@gmail.com",
                Adres = "İzmir"
            },
            new Alici
            {
                AliciID = 2,
                Ad = "Mehmet",
                Soyad = "Yılmaz",
                TCKimlikNo = "11111111110",
                CepTel = "05556667788",
                Mail = "mehmet@gmail.com",
                Adres = "İzmir"
            },
            new Alici
            {
                AliciID = 3,
                Ad = "Ali",
                Soyad = "Yılmaz",
                TCKimlikNo = "11111111110",
                CepTel = "05556667788",
                Mail = "ali@gmail.com",
                Adres = "İzmir"
            }
            );
        }
    }
}
