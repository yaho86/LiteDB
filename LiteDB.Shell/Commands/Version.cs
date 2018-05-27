﻿using LiteDB.Engine;
using System;

namespace LiteDB.Shell.Commands
{
    internal class Version : IShellCommand
    {
        public bool IsCommand(StringScanner s)
        {
            return s.Scan(@"ver(sion)?$").Length > 0;
        }

        public void Execute(StringScanner s, Env env)
        {
            var assembly = typeof(LiteEngine).Assembly.GetName();

            env.Display.WriteLine(assembly.FullName);
        }
    }
}