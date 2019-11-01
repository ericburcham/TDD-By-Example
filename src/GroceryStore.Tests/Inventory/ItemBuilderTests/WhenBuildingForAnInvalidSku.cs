﻿using System;
using FluentAssertions;
using GroceryStore.Inventory;
using NUnit.Framework;

namespace GroceryStore.Tests.Inventory.ItemBuilderTests
{
    [TestFixture]
    public class WhenBuildingForAnInvalidSku
    {
        private ItemBuilder _itemBuilder;

        [OneTimeSetUp]
        internal void OneTimeSetUp()
        {
            _itemBuilder = new ItemBuilder();
        }

        [Test]
        public void BuildItemShouldThrowAnArgumentException()
        {
            _itemBuilder.Invoking(ib => ib.BuildItem("I_AM_NOT_A_VALID_SKU"))
                .Should().Throw<ArgumentException>()
                .WithMessage($"The given SKU: I_AM_NOT_A_VALID_SKU is invalid.");
        }
    }
}