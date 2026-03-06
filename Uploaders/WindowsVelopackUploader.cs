// Copyright (c) 2026 2026 BoomboxRapsody <boomboxrapsody@gmail.com>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

namespace NekoPlayer.Desktop.Deploy.Uploaders
{
    public class WindowsVelopackUploader : VelopackUploader
    {
        private readonly string channel;

        public WindowsVelopackUploader(string applicationName, string operatingSystemName, string runtimeIdentifier, string channel, string? extraArgs = null, string? stagingPath = null)
            : base(applicationName, operatingSystemName, runtimeIdentifier, channel, extraArgs, stagingPath)
        {
            this.channel = channel;
        }

        public override void PublishBuild(string version)
        {
            base.PublishBuild(version);
            RenameAsset($"{Program.PackageName}-{channel}-Setup.exe", "install.exe");
        }
    }
}
