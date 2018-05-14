using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Linq;



namespace Assignment11_DAL
{

    [Table]
    public class Person
    {
       

        [Column]
        public int Id { get; set; }

        [Column]
        public string Name { get; set; }

        [Column]
        public int Age { get; set; }


    }
}
