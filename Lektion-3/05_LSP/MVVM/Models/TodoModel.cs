using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LSP.MVVM.Models
{
    public class TodoModel
    {
        public string Text { get; set; } = null!;
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
