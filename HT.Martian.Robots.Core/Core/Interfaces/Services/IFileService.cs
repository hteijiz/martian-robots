using HT.Martian.Robots.Core.Interfaces.Models;

namespace HT.Martian.Robots.Core.Interfaces.Services
{
    public interface IFileService
    {
        FileConfig ReadFile(string file);
    }
}
