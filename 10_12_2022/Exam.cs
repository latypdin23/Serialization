using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_12_2022
{
    class Exam
    {
        public string Name; 
        private int rating; 
        public int Rating //объявление свойства
        {
            get 
            {
                if (rating < 5)
                {
                    return 2;
                }
                else
                {
                    return (rating + 1) / 2;
                }
            }
            set 
            {
                if (value < 0)
                {
                    rating = 0;
                }
                else if (value > 10)
                {
                    rating = 10;
                }
                else
                {
                    rating = value;
                }
            }
        }
        public Exam(string name)  // конструктор
        {
            Name = name;
        }
    }
}
