using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Visitor.I
{
    public class Client
    {
        public static void Execute()
        {
            var collection = new IElement[] {
            new PlainText { Plain = "plain" },
            new PlainText { Plain = "\n" },
            new BoldText { Bold = "bold" },
            new PlainText { Plain = "\n" },
            new Hyperlink { Url = "http:\\some.url.com", Label="Some Url Company" }
            };

            //foreach(IElement element in collection)
            //{
            //    switch(element)
            //    {
            //        case PlainText text:
            //            Console.WriteLine(text.Plain);
            //            break;
            //        case BoldText bold:
            //            Console.WriteLine($"<b>{bold.Bold}</b>");
            //            break;
            //        case Hyperlink hyperlink:
            //            Console.WriteLine($"<a href=\"{hyperlink.Url}\">{hyperlink.Label}</a>");
            //            break;
            //    }
            //}

            var visitor = new HtmlVisitor();

            foreach (var item in collection)
            {
                item.Accept(visitor);
            }

            Console.WriteLine(visitor.Output);

        }
    }
}
