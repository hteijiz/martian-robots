using HT.Martian.Robots.Core.Interfaces.ViewModels;

namespace HT.Martian.Robots.Core.Interfaces.Services
{
    public interface IFileService
    {
        FileViewModel ReadFile(string file);
    }
}
