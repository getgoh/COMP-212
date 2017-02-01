using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300910584_goh__ASS_2
{
    class MenuItem
    {
        private int id;
        private string category;
        private double price;
        private string name;

        public MenuItem(int id, string name, string cat, double price)
        {
            this.id = id;
            this.category = cat;
            this.price = price;
            this.name = name;
        }

        public string DisplayItem
        {
            get
            {
                return this.name + " - $" + price;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Id {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Category {
            get
            {
                return this.category;
            }
            set
            {
                this.category = value;
            }
        }
        public double Price {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }


    }
}
