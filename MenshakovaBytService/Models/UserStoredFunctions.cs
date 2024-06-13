using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenshakovaBytService.Models
{
    public partial class User
    {
        public string FullName => $"{FirstName} {SecondName} {ThirdName}";
    }
}
