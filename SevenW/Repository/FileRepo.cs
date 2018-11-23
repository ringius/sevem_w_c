using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
using SevenW.Models;

namespace SevenW.Repository
{
    class FileRepo : IRepository
    {
        public List<Playcard> GetPlaycards()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\WriteText.txt");
            throw new NotImplementedException();
        }
    }
}
