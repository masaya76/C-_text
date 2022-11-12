using System;
using System.Collections.Generic; //List等ののコレクションを使用する際に必要なパッケージ
using System.Linq;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            //練習問題
            int[] num = { -1, -10, -5, -40, -15 };

            var newNum = num.Select(n => n + 10);
            var mus = newNum.Where(n => n >= 0).Count();
            Console.WriteLine(mus);


            /*練習問題の回答
            int[] array = { -1, -10, -5, -40, -15 };

            // LINQを使ってすべての要素に「10」足して
            // 結果が「0以上」となる要素の個数を求める
            int num = array.Select(n => n + 10).Where(n => n >= 0).Count();

            Console.WriteLine(num);

            */

             

            /*Linqを使用した場合
            int[] hp = { 550, 0, 600, 0, 220 };

            int num = hp.Where(n => n == 0).Count();

            Console.WriteLine(num);
            */

            /*Linqを使用しない場合
            int[] hp = { 550, 0, 600, 0, 220 };
            int num = 0;

            for(int i = 0; i < hp.Length; i++)
            {
                if (hp[i] == 0)
                {
                    num++;
                }
            }

            Console .WriteLine(num);
            */

            /*
            int[] hp = { 550, 420, 600, 800, 220 };
            var newHP = hp.Select(n => n - 100);

            foreach(int n in newHP)
            {
                Console.WriteLine(n);
            }
            */

            /*Linqとラムダ式を用いた場合
            int[] hp = {420, 600, 120, 1200, 0};

            var nweHP = hp.Where(n => n >= 500); 

            foreach(int n in nweHP)
            {
                Console.WriteLine(n);
            }
            */

            /*
           //Linq、ラムダ式を用いる前
            List<int> NewHp = new List<int>();

            for(int i = 0; i < hp.Length; i++)
            {
                if (hp[i] >= 500)
                {
                    NewHp.Add(hp[i]);
                }
            }

            foreach(int n in NewHp)
            {
                Console.WriteLine(n);
            }
            */

            /*
            //Dictionary型を作成
            Dictionary<string, int> tellphone = new Dictionary<string, int>();
            //要素を追加する
            tellphone.Add("山田", 00001);
            tellphone.Add("青木", 00002);
            tellphone.Add("村上", 00003);
            //キーに関連づいてる値を表示する
            Console.WriteLine(tellphone["山田"]);
            */

            /*List型の変数を作成する
            List<float> weights = new List<float>();

            //Listの要素を追加
            weights.Add(41.2f);
            weights.Add(42.5f);
            weights.Add(3.2f);
            weights.Add(44.9f);
            weights.Add(43.2f);
            weights.Add(43.2f);
            weights.Add(42.7f);
            weights.Add(41.7f);

            //Listの要素を削除
            weights.RemoveAt(2);

            //List内のインデックス軽い順変更
           weights.Sort();

            for(int i = 0; i < weights.Count; i++)
            {
                Console.WriteLine(weights[i]);
            }
            */


            /*Listコレクションを使用する前
            float[] weights = { 41.2f, 42.5f, 44.9f, 43.2f, 45.1f, 43.2f, 42.7f};

            float sum = 0.0f;

            for(int i = 0; i < weights.Length; i++)
            {
                sum += weights[i];
            }
            float average = sum/weights.Length;
            Console.WriteLine(average);
            */
        }
    }
}