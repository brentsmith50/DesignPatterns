using System.Collections.Generic;

namespace IteratorPattern
{
    public class SuperCollection : List<string>
    {
        public string Get(int index)
        {
            return this[index];
        }
    }
}
