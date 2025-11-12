using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWebinarsData
{
    public class WorkingSettings
    {
        public void ChangeColor(System.Drawing.Color color)
        {
            Properties.Settings.Default.MoodColor = color;
            Properties.Settings.Default.Save();
        }
    }
}