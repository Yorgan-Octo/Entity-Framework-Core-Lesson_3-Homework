using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Word
    {

        public int Id { get; set; }

        public string Header { get; set; }
        public string KeyWord { get; set; }

        public List<KeyParams> ProductLink { get; set; }

    }
}
