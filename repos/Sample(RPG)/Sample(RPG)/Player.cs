using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_RPG_
{
    class Player
    {
        private string name;
        private int hp;

        public Player(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
        }

        //プロパティ機能
        public int Hp
        {
            set
            {
                this.hp = value;
                if(this.hp < 0)
                {
                    this.hp = 0;
                }
            }
            get
            {
                return this.hp;
            }
        }

        /*
        public void Sethp(int hp)
        {
            this.hp = hp;
            if(this.hp < 0)
            {
                this.hp = 0;
            }
        }

        public int Gethp()
        {
            return this.hp;
        }

        public void Setname()
        {
            this.name = name;
            if(this.name.Length <= 8)
            {
                this.name = name;
            }
        }
        */
        
        public void Attack()
        {
            Console.WriteLine(this.name + "攻撃した");
        }

        public void Defense()
        {
            Console.WriteLine(this.hp + "防御した");
        }

    }
}
