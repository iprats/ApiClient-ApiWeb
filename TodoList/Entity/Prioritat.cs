using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList.Entity
{
    public class Prioritat
    {
        //Declaració de variables
        private int id { get; set; }
        private string nom { get; set; }

        //Constructor 
        public Prioritat()
        {
            id = 0;
            nom = "";
        }
        public Prioritat(int id_, string nom_)
        {
            id = id_;
            nom = nom_;
        }
    }
}
