using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Models
{
    public class PatternRenderer
    {
        private IDataPatternRendererAdapter dataPatternRendererAdapter;

        public PatternRenderer() :
            this(new DataPatternRendererAdapter())
        {
        }

        public PatternRenderer(IDataPatternRendererAdapter dataPatternRendererAdapter)
        {
            this.dataPatternRendererAdapter = dataPatternRendererAdapter;
        }

        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            return this.dataPatternRendererAdapter.ListPatterns(patterns);
        }
    }
}
