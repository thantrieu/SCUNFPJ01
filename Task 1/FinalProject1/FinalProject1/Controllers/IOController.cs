using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class IOController : IIOController
    {
        public List<T> ReadData<T>(string fileName)
        {
            throw new NotImplementedException();
        }

        public void WriteData<T>(LinkedList<T> data, string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
