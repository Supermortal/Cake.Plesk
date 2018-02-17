using Cake.Core;
using Cake.Core.Annotations;

namespace Cake.Plesk
{
    public static class PleskRunnerAliases
    {
        [CakeMethodAlias]
        public static void FtpDeploy(this ICakeContext context, PleskSettings settings)
        {
            var runner = new PleskRunner<PleskSettings>(context.FileSystem, context.Environment,
                context.ProcessRunner, context.Tools);
            runner.Execute(settings);
        }
    }
}
