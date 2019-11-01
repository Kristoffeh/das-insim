using System;
using InSimDotNet.Packets;
using InSimDotNet;

namespace LFS_External_Client
{

    public partial class Commands
    {
        public struct CommandList
        {
            public MethodInfo MethodInf;
            public CommandAttribute CommandArg;
        }
        public List<CommandList> Commands = new List<CommandList>();
        public class CommandAttribute : Attribute
        {
            public string Command;
            public string Syntax;
            public string Description;
            public CommandAttribute(string command, string syntax, string desc)
            {
                Command = command;
                Syntax = syntax;
                Description = desc;
            }
            public CommandAttribute(string command, string syntax)
            {
                Command = command;
                Syntax = syntax;
                Description = "";
            }
        }
        [Command("help", "help")]
        public void addvip(string Msg, string[] StrMsg, Packets.IS_MSO MSO)
        {

        }
    }
}