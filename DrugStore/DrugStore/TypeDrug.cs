using System;
using System.Collections.Generic;
using System.Text;

namespace DrugStore
{
    class TypeDrug
    {
        public TypeDrug()
        {
            _id++;
            UnikalId = _id;
        }

        private int _id;
        public static int UnikalId { get ; set; }
        public string TypeName { get; set; }

        public override string ToString()
        {
            return $"TypeName: {TypeName}";
        }
    }
}
