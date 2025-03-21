﻿// Copyright (c) BruTile developers team. All rights reserved. See License.txt in the project root for license information.

using NUnit.Framework;

namespace BruTile.Tests;

[TestFixture]
public class TileIndexTests
{
    [Test]
    public void CompareToTest()
    {
        // Arrange
        var target = new TileIndex(2, 4, 2);
        var index = new TileIndex(2, 5, 2);
        const int expected = -1;

        // Act
        var actual = target.CompareTo(index);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
