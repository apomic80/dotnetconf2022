using System;

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
