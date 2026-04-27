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

using BH.oM.Adapter;
using NUnit.Framework;

namespace BH.Tests.Engine.Adapter.oM
{
    [TestFixture]
    public class AdapterSettingsTests
    {
        /***************************************************/
        /****       AdapterSettings defaults            ****/
        /***************************************************/

        [Test]
        public void AdapterSettings_DefaultPushType_IsFullPush()
        {
            var settings = new AdapterSettings();
            Assert.That(settings.DefaultPushType, Is.EqualTo(PushType.FullPush));
        }

        [Test]
        public void AdapterSettings_CloneBeforePush_DefaultsToTrue()
        {
            var settings = new AdapterSettings();
            Assert.That(settings.CloneBeforePush, Is.True);
        }

        [Test]
        public void AdapterSettings_HandleDependencies_DefaultsToTrue()
        {
            var settings = new AdapterSettings();
            Assert.That(settings.HandleDependencies, Is.True);
        }

        [Test]
        public void AdapterSettings_WrapNonBHoMObjects_DefaultsToFalse()
        {
            var settings = new AdapterSettings();
            Assert.That(settings.WrapNonBHoMObjects, Is.False);
        }
    }
}
