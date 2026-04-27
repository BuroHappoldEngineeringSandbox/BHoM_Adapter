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
using BH.oM.Base;
using NUnit.Framework;

namespace BH.Tests.Engine.Adapter.Query
{
    [TestFixture]
    public class HasAdapterIdFragmentTests
    {
        /***************************************************/
        /*** HasAdapterIdFragment(IBHoMObject, Type)     ***/
        /***************************************************/

        private class TestFragment : IFragment { }
        private class OtherFragment : IFragment { }

        [Test]
        public void HasAdapterIdFragment_FragmentPresent_ReturnsTrue()
        {
            var obj = new CustomObject();
            obj.Fragments.Add(new TestFragment());

            bool result = obj.HasAdapterIdFragment(typeof(TestFragment));

            Assert.That(result, Is.True);
        }

        [Test]
        public void HasAdapterIdFragment_FragmentAbsent_ReturnsFalse()
        {
            var obj = new CustomObject();

            bool result = obj.HasAdapterIdFragment(typeof(TestFragment));

            Assert.That(result, Is.False);
        }

        [Test]
        public void HasAdapterIdFragment_NullObject_ReturnsFalse()
        {
            IBHoMObject obj = null;

            bool result = obj.HasAdapterIdFragment(typeof(TestFragment));

            Assert.That(result, Is.False);
        }

        [Test]
        public void HasAdapterIdFragment_NullFragmentType_ReturnsFalse()
        {
            var obj = new CustomObject();

            bool result = obj.HasAdapterIdFragment(null);

            Assert.That(result, Is.False);
        }

        [Test]
        public void HasAdapterIdFragment_DifferentFragmentType_ReturnsFalse()
        {
            var obj = new CustomObject();
            obj.Fragments.Add(new OtherFragment());

            bool result = obj.HasAdapterIdFragment(typeof(TestFragment));

            Assert.That(result, Is.False);
        }
    }
}
