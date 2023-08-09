using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class KeyParams
    {
        public int Id { get; set; }

        public Product Product { get; set; }

        public Word KeyWords { get; set; }

    }
}
