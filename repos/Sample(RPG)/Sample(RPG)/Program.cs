using Sample_RPG_;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Sample_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("ひろし", 100);
            //playerのHPのプロパティに代入
            player.Hp -= 70;
            Console.WriteLine("HPは" + player.Hp);
            /*
            int hp = player.Gethp();
            int newHP = hp - 2000;
            player.Sethp(newHP);
            Console.WriteLine("HPは" + player.Gethp());
            */
        }
    }
}