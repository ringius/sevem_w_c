using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SevenW.Models;

namespace SevenW.Repository
{
    interface IRepository
    {
        List<Playcard> GetPlaycards();        
    }
}
