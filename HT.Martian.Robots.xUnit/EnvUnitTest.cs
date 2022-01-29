using HT.Martian.Robots.Core.Core.Models.Exceptions;
using HT.Martian.Robots.Core.Interfaces.Services;
using HT.Martian.Robots.Services;
using System;
using System.IO;
using System.Reflection;
using Xunit;


namespace HT.Martian.Robots.xUnit
{
    public class EnvUnitTest
    {
        [Fact]
        public void EnvInitOk()
        {
            IEnviromentService envService = new EnviromentService();
            envService.Init(6, 7);
        }

        [Fact]
        public void EnvInitSameSource()
        {
            IEnviromentService envService = new EnviromentService();
            Assert.Throws<FailInitEnvException>(() => envService.Init(0, 0));
        }

        [Fact]
        public void EnvInitWrongX()
        {
            IEnviromentService envService = new EnviromentService();
            Assert.Throws<FailInitEnvException>(() => envService.Init(0, 7));
        }

        [Fact]
        public void EnvInitWrongY()
        {
            IEnviromentService envService = new EnviromentService();
            Assert.Throws<FailInitEnvException>(() => envService.Init(6, 0));

        }
    }
}
