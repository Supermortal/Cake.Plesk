using Cake.Core.Diagnostics;
using Cake.Testing.Fixtures;
using NSubstitute;

namespace Cake.Plesk.Tests
{
    public class PleskFixture<TSettings> : ToolFixture<TSettings> where TSettings : PleskSettings, new()
    {

        private readonly ICakeLog _log;

        public PleskFixture()
            : base("plesk")
        {
            _log = Substitute.For<ICakeLog>();
        }

        protected override void RunTool()
        {
            var tool = new PleskRunner<TSettings>(FileSystem, Environment, ProcessRunner, Tools);
            tool.Execute(Settings);
        }
    }
}
