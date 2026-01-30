// Copyright (c) BoomboxRapsody <boomboxrapsody@gmail.com>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

namespace YouTubePlayerEX.Desktop.Deploy.Uploaders
{
    public abstract class Uploader
    {
        public abstract void RestoreBuild();

        public abstract void PublishBuild(string version);
    }
}
