using HT.Martian.Robots.Core.Interfaces.Services;
using HT.Martian.Robots.Services;
using System;
using System.IO;
using System.Reflection;
using Xunit;

namespace HT.Martian.Robots.xUnit
{
    public class FileDataUnitTest
    {
        [Fact]
        public void FileNotFoundException()
        {
            var path = Path.Join(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Input1\data.txt");
            IFileService fileService = new TextFileService();
            Assert.Throws<FileNotFoundException>(() => fileService.ReadFile(path));
        }

        [Fact]
        public void FileDataShouldExists()
        {
            var path = Path.Join(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Input\data.txt");
            IFileService fileService = new TextFileService();
            var fileViewModel = fileService.ReadFile(path);

            Assert.NotNull(fileViewModel);
        }
    }
}
