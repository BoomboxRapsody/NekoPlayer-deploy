using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubePlayerEX.Desktop.Deploy.Uploaders
{
    public class LinuxVelopackUploader : VelopackUploader
    {
        private readonly string channel;

        public LinuxVelopackUploader(string applicationName, string operatingSystemName, string runtimeIdentifier, string channel, string? extraArgs = null, string? stagingPath = null)
            : base(applicationName, operatingSystemName, runtimeIdentifier, channel, extraArgs, stagingPath)
        {
            this.channel = channel;
        }

        public override void PublishBuild(string version)
        {
            base.PublishBuild(version);
            RenameAsset($"{Program.PackageName}-{channel}.AppImage", "YouTubePlayerEX.AppImage");
        }
    }
}
