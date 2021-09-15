using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubicTest1
{
    class Planet
    {
        private void Main()
        {
            CreateCat();
            CreateCat();
            CreateCat();
            CreateMan();
            CreateMan();
        }

        private void CreateCat()
        {
            Cat cat1 = new Cat();
            cat1.name = "Стасян";
            cat1.age = 76;
            cat1.width = 45.1f;
            cat1.isAlive = false;
        }

        private void CreateMan()
        {
            Man man1 = new Man();
            man1.name = "Васёк";
            man1.surename = "Гаврилин";
            man1.age = 41;
            man1.width = 96.5f;
            man1.height = 270.8f;
            man1.isMale = true;
        }
    }
}