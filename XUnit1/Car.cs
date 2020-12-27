using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnit1
{
    class Car
    {
        private string id;
        Car(string id)
        {
            this.id = id;
        }
        string GetId()
        {
            return id;
        }
        void printId()
        {
            Console.WriteLine(id);
        }
    }
}
