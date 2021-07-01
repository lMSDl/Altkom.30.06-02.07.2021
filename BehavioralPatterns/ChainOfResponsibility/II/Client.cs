using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.ChainOfResponsibility.II
{
    public class Client
    {
        public static void Execute()
        {
            var frame = new Frame();
            
            var textBox = new TextBox();
            frame.Add(textBox);

            var button = new Button();
            textBox.Add(button);

            button.Func = () =>
            {
                if (string.IsNullOrEmpty(textBox.InputText))
                    return false;
                textBox.InputText = string.Empty;
                Console.WriteLine("TextBox clear");
                return true;
            };


            frame.Click();

            button.Click();

            textBox.Click();

            textBox.InputText = "abc";
            button.Click();
            button.Click();

        }
    }
}