using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Entites
{
    public class Categories
    {
        public string cg_Id { set; get; }
        public string cg_Name { set; get; }
        public string cg_Type { set; get; }
        public string cg_Sale { set; get; }
        public string cg_Sex { set; get; }
        public List<Products> products { get; set; }


    }
}
