﻿using System;

namespace WPCSharp.BehavioralPatterns.TemplateMethod
{
    public class Client
    {
        public static void Execute()
        {
            var fileLogger = new FileLogger();
            fileLogger.Log("Message to Log in File.");
            Console.WriteLine();
            var emailLogger = new EmailLogger();
            emailLogger.Log("Message to Log via Email.");
            Console.WriteLine();
            var databaseLogger = new DatabaseLogger();
            databaseLogger.Log("Message to Log in DB.");
        }
    }
}
