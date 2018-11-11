using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    sealed partial class Tablet : Product
    {
        //переопределяем методы, определенный в Objects
        //переопределение методов от Objects
        public override bool Equals(object obj)
        {
            Tablet obj2 = (Tablet)obj;
            return (obj2.Brand == Brand);
        }
        public override int GetHashCode()
        {
            return (base.GetHashCode() + Brand.GetHashCode());
        }

        public override string ToString()
        {
            return "Планшет марки " + Brand;
        }
    }
}
