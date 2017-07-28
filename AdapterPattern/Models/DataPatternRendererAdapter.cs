using System.Collections.Generic;
using System.IO;

namespace AdapterPattern.Models
{
    public class DataPatternRendererAdapter : IDataPatternRendererAdapter
    {
        private DataRenderer dataRenderer;

        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            var adapter = new PatternCollectionDbAdapter(patterns);
            this.dataRenderer = new DataRenderer(adapter);

            var writer = new StringWriter();
            this.dataRenderer.Render(writer);
            return writer.ToString();
        }
    }
}
