using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp30
{
    class TimedDocument:Document
    {
        DateTime timeCreated;
        TimeSpan expirationTime;

        public TimedDocument( TimeSpan expirationTime, string title, string content): base(title, content)
        {
            timeCreated = DateTime.Now;
            this.expirationTime = expirationTime;
        }


        // ako oduzmem dva datetimea dobijem: timespan

        public override void ToFile()
        {
            if (DateTime.Now - timeCreated > expirationTime)
            {
                using (StreamWriter sw = new StreamWriter(Title))
                {
                    for(int i=0; i<Content.Length;i++)
                        sw.WriteLine('*');

                }
            }
            else
            {
                base.ToFile();
            }
        }



    }
}
