using System.Collections.Generic;
using System.Text;

namespace Interface.Gaz
{
    public interface ILogger
    {
        void LogError(string message);

        void LogInfo(string message);
    }
}
