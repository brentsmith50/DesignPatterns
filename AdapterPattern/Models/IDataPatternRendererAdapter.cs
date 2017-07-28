using System.Collections.Generic;

namespace AdapterPattern.Models
{
    public interface IDataPatternRendererAdapter
    {
        string ListPatterns(IEnumerable<Pattern> patterns);
    }
}
