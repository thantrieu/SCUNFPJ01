using System.Collections.Generic;

namespace Controllers
{
    public interface IIOController
    {
        void WriteData<T>(LinkedList<T> data, string fileName);
        List<T> ReadData<T>(string fileName);
    }
}
