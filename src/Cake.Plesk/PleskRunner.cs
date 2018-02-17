using System.Collections.Generic;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Plesk
{
    public class PleskRunner<TSettings> : Tool<TSettings> where TSettings : PleskSettings, new()
    {

        private readonly IFileSystem _fileSystem;
        private readonly ICakeEnvironment _environment;
        private readonly IProcessRunner _processRunner;
        private readonly IToolLocator _tools;

        public PleskRunner(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner, IToolLocator tools) : base(fileSystem, environment, processRunner, tools)
        {
            _fileSystem = fileSystem;
            _environment = environment;
            _processRunner = processRunner;
            _tools = tools;
        }

        protected override string GetToolName()
        {
            return "Cake.Plesk";
        }

        protected override IEnumerable<string> GetToolExecutableNames()
        {
            yield return "plesk";
        }

        public virtual void Execute(TSettings settings)
        {
            ValidateSettings(settings);
        }

        protected virtual void ValidateSettings(TSettings settings)
        {
            //if (settings.FtpUserName == null)
            //{
            //    throw new ArgumentNullException("settings.FtpUserName", "An ftp username must be specified.");
            //}
        }
    }
}
