using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    class TicketTracker
    {
        List<BugTicket> bugTickets;

        public TicketTracker()
        {
            bugTickets = new List<BugTicket>();

        }
        
        public void AddBugTicket(BugTicket bugTicket)
        {
            bugTickets.Add(bugTicket);

        }

        public BugTicket FindOldestBugTicket()
        {
            BugTicket oldestBugTicket = bugTickets[0];

            foreach (BugTicket bugTicket in bugTickets)
            {
                if (bugTicket.TimeCreated < oldestBugTicket.TimeCreated)
                {
                    oldestBugTicket = bugTicket;

                }
                
            }
            return oldestBugTicket;

        }
      

        public Dictionary<string, int> getNumOfBugTicketsPerAuthor()
        {

            Dictionary<string, int> bugTicketsPerAuthor = new Dictionary<string, int>();

            int bugTicketsPerAuthorSum = 0;
            
            //pero dzuro mirna pero
            //                 pero


            foreach(BugTicket bugTicket in bugTickets)
            {
                foreach(BugTicket bugTicket1 in bugTickets)
                {
                    if (bugTicket.Author == bugTicket1.Author)
                        bugTicketsPerAuthorSum++;

                }

                if (!bugTicketsPerAuthor.ContainsKey(bugTicket.Author))
                {
                    bugTicketsPerAuthor.Add(bugTicket.Author, bugTicketsPerAuthorSum);

                    }
                bugTicketsPerAuthorSum = 0;
                
            }
            return bugTicketsPerAuthor;
        }
    }
}
