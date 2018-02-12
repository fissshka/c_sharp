using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Class_lect
{
    class First_class
    {
        private string property = "";

        public string Property
        {
            get
            {
                return this.property;
            }

            set
            {
                this.property = value;
                
            }
        }

        public string AutoProperty { get; set; }

        public string hello_str = "Hello Class!";

        public void write_hello()
        {
            Console.WriteLine(hello_str);
        }

        public void write_property()
        {
            Console.WriteLine(this.Property);
        }

        public void write_autoproperty()
        {
            Console.WriteLine(this.AutoProperty);
        }

        public void SetFieldValue(string val)
        {
            this.hello_str = val;
        }
    }
}
