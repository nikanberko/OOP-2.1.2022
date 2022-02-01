using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp30
{
    class Document
    {

        public string Title { get; protected set; }
        public string Content { get; protected set; }

        public Document(string title, string content)
        {
            Title = title;
            Content = content;
        }
        public static bool operator >(Document lhs, Document rhs)
        {

            return lhs.Content.Length > rhs.Content.Length;
        }


        public static bool operator <(Document lhs, Document rhs)
        {
            return lhs.Content.Length < rhs.Content.Length;
        }

        public virtual void ToFile()
        {

            using (StreamWriter sw = new StreamWriter(Title))
            {
                sw.WriteLine(Content);
            }

                

        }

  


  



    }
}


