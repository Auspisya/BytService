using MenshakovaBytService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenshakovaBytService.Classes
{
    public static class DBConnection
    {
        public static MenshakovaDBBytServiceEntities DBConnect = new MenshakovaDBBytServiceEntities();
    }
}
