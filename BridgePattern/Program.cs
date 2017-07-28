using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Manuscript> documents = new List<Manuscript>();
            StandardFormatter formatter = new StandardFormatter();
            FancyFormatter fancyFormatter = new FancyFormatter();
            BackwardsFormatter alternateFormatter = new BackwardsFormatter();

            Initizalize(documents, formatter);
            Initizalize(documents, alternateFormatter);
            Initizalize(documents, fancyFormatter);

            foreach (var doc in documents)
            {
                doc.Print();
            }

            Console.ReadKey();
        }

        private static void Initizalize(List<Manuscript> documents, IFormatter formatter)
        {
            FAQ faq = new FAQ(formatter);
            faq.Title = "The Bridge Pattern FAQ";
            faq.Questions.Add("What is it?", "A design pattern");
            faq.Questions.Add("When do we use it?", "When you need to separate an abstraction from an implementation.");
            documents.Add(faq);

            var book = new Book(formatter)
            {
                Title = "Lots of Patterns",
                Author = "Blockhead Fuckhead",
                Text = "Pimping the Wooorrld!"
            };
            documents.Add(book);

            var paper = new TermPaper(formatter)
            {
                Class = "Design Patterns",
                Student = "Fred Flintstone",
                Text = "What up cousin?",
                References = "Eat dogshit!"
            };
            documents.Add(paper);
        }
    }
}
