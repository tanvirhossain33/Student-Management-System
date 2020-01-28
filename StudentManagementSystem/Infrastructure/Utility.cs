using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Infrastructure
{
    public enum Department
    {
        Default = -1,
        ComputerEngineering,
        ElectricalEngineering,
        NaturalScience,
        BusinessEconomics,
    }

    public class MessageEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
}
