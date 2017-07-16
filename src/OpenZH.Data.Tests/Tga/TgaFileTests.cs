﻿using System.IO;
using System.Linq;
using OpenZH.Data.Big;
using OpenZH.Data.Tga;
using Xunit;
using Xunit.Abstractions;

namespace OpenZH.Data.Tests.Tga
{
    public class TgaFileTests
    {
        private readonly ITestOutputHelper _output;

        public TgaFileTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void CanReadTgaTextures()
        {
            InstalledFilesTestData.ReadFiles(".tga", _output, (fileName, openFileStream) =>
            {
                using (var fileStream = openFileStream())
                {
                    var tgaFile = TgaFile.FromStream(fileStream);
                    Assert.True(tgaFile.Header.ImagePixelSize == 24 || tgaFile.Header.ImagePixelSize == 32);
                }
            });
        }
    }
}
