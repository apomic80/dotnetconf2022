using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winforms.Services
{
    public class PropertyChangeNotifier
    {
        public event EventHandler<string> PropertyChanged;

        public void NotifyPropertyChange(string property)
        {
            PropertyChanged?.Invoke(this, property);
        }
    }
}
