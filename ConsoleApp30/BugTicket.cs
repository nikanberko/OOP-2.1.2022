using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    class BugTicket
    {
        public string Author{ get; set; }
        public int Level { get; set; }
        public DateTime TimeCreated { get; set; }
       
        public BugTicket(string name, int level)
        {
            Author = name;
            Level = level;
            TimeCreated = DateTime.Now;
        }

        public BugTicket(BugTicket bt)
        {
            Author = bt.Author;
            Level = bt.Level;
            TimeCreated = bt.TimeCreated;
        }

        public override string ToString()
        {
            return $"Ticket created at {TimeCreated} by {Author} - level {Level}";
        }

    }
