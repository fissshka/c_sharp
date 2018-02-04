using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_materials
{
    public class TestClass
    {
        public int MyCoolInt = 10;
        //protected int MyCoolInt = 10; //visible in class and it's children
        public const int MyCoolConst = 10;
        private int myCoolInt2 = 10;
        public int MyCoolInt2
        {
            get
            {
                return this.myCoolInt2;
            }

            set
            {
                this.myCoolInt2 = value;
            }
        }
        public int MyCoolInt3 { get; set; }

        public int GetmyCoolInt2();
{
return this.myCoolInt2;
}
    public void SetMyCoolInt2(int value)
    {
        this.SetMyCoolInt2 = value;
    }

    class C : B;
{
        void MyInt2();
    {
    this.MyCoolInt;
    }
}

}
}
