using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDTool.ViewModel.Dialogs
{
    public class QueryDialogViewModel
    {
        public string Info { get; set; }

        public string AcceptButtonText { get; set; } = "Accept";

        public string CancelButtonText { get; set; } = "Cancel";

        public string Query { get; set; }
    }
}
