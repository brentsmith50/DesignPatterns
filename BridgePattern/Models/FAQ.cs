using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class FAQ : Manuscript
    {
        public FAQ(IFormatter formatter) 
            : base(formatter)
        {
        }

        public string Title { get; set; }
        public Dictionary<string, string> Questions { get; set; } = new Dictionary<string, string>();

        public override void Print()
        {
            Console.WriteLine(formatter.Format("Title", Title));

            foreach (var question in this.Questions)
            {
                Console.WriteLine(formatter.Format("   Question", question.Key));
                Console.WriteLine(formatter.Format("    Answer", question.Value));
            }
            Console.WriteLine();
        }
    }
}
