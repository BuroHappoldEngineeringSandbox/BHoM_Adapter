/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2026, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *
 * The BHoM is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation, either version 3.0 of the License, or
 * (at your option) any later version.
 *
 * The BHoM is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.
 */

using BH.Engine.Adapter;
using BH.oM.Adapter;
using NUnit.Framework;

namespace BH.Tests.Engine.Adapter.Query
{
    [TestFixture]
    public class GetFullFileNameTests
    {
        /***************************************************/
        /****       GetFullFileName(FileSettings)        ****/
        /***************************************************/

        [Test]
        public void GetFullFileName_ValidSettings_ReturnsCombinedPath()
        {
            var settings = new FileSettings { Directory = @"C:\Data\Files", FileName = "model.json" };
            string result = settings.GetFullFileName();
            Assert.That(result, Is.EqualTo(@"C:\Data\Files\model.json"));
        }

        [Test]
        public void GetFullFileName_NullSettings_ReturnsEmptyString()
        {
            FileSettings settings = null;
            string result = settings.GetFullFileName();
            Assert.That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public void GetFullFileName_EmptyDirectory_ReturnsFileName()
        {
            var settings = new FileSettings { Directory = "", FileName = "output.json" };
            string result = settings.GetFullFileName();
            Assert.That(result, Is.EqualTo("output.json"));
        }

        [Test]
        public void GetFullFileName_EmptyFileName_ReturnsDirectory()
        {
            var settings = new FileSettings { Directory = @"C:\Data", FileName = "" };
            string result = settings.GetFullFileName();
            Assert.That(result, Is.EqualTo(@"C:\Data"));
        }
    }
}
