using System;
using System.Collections.Generic;
using System.Text;

namespace DrugStore
{
    class Drug
    {
        public string Name { get; set; }
        public Drug()
        {
            _id++;
            UnikalId = _id;
        }

        private int _id;
        public static int UnikalId { get; set; }
        public TypeDrug Type { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return $"Id: {_id}, Name: {Name}, Price: {Price}, Count: {Count}";
        }

    }
}
