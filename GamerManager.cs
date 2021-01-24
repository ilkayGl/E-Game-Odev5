using System;
using System.Collections.Generic;
using System.Text;

namespace E_Game
{
    class GamerManager
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı Eklendi => " + "Ad-Soyad = " + gamer.FirstName + " "+ gamer.LastName + " , " + "Doğum Yılı = " + gamer.YearOfBirth + " , " +"Tc No = " + gamer.TcNo);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı Silindi => " + "Ad-Soyad = " + gamer.FirstName + " " + gamer.LastName + " , " + "Doğum Yılı = " + gamer.YearOfBirth + " , " + "Tc No = " + gamer.TcNo);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı Güncellendi => " + "Ad-Soyad = " + gamer.FirstName + " " + gamer.LastName + " , " + "Doğum Yılı = " + gamer.YearOfBirth + " , " + "Tc No = " + gamer.TcNo);
        }
    }
}
