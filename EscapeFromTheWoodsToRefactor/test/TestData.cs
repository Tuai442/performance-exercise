using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class TestData
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public TestData(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
