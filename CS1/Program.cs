//Попрактикуйтесь в создании переменных, объявить 10 переменных разных типов.
//Напоминание: переменные именуются с маленькой буквы, если название состоит из нескольких слов, то комбинируем их следующим образом - названиеПеременной.
//Также имя всегда должно отражать суть того, что хранит переменная...
using System;

namespace CS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte health = 100;
            char stamina = Convert.ToChar(100); 
            bool willPower = Convert.ToBoolean(80);
            long mana = 90;
            sbyte attack = 25;
            short protection = 15;
            int intellect = 45;
            ulong agility = 60;  
            ushort speed = 75;   
            string flexibility = Convert.ToString(20);
        }
    }
}
