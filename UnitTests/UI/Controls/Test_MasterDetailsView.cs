﻿using Microsoft.Toolkit.Uwp.UI.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.AppContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.UI.Controls
{
    [TestClass]
    public class Test_MasterDetailsView
    {
        [TestCategory("MasterDetailsView")]
        [UITestMethod]
        public void Test_SelectedIndex_Default()
        {
            var items = Enumerable.Range(1, 10).ToArray();
            var masterDetailsView = new MasterDetailsView();
            masterDetailsView.ItemsSource = items;
            Assert.AreEqual(-1, masterDetailsView.SelectedIndex);
        }

        [TestCategory("MasterDetailsView")]
        [UITestMethod]
        public void Test_SelectedItem_Default()
        {
            var items = Enumerable.Range(1, 10).ToArray();
            var masterDetailsView = new MasterDetailsView();
            masterDetailsView.ItemsSource = items;
            Assert.IsNull(masterDetailsView.SelectedItem);
        }

        [TestCategory("MasterDetailsView")]
        [UITestMethod]
        public void Test_SelectedIndex_Syncs_SelectedItem()
        {
            var items = Enumerable.Range(1, 10).ToArray();
            var masterDetailsView = new MasterDetailsView();
            masterDetailsView.ItemsSource = items;
            masterDetailsView.SelectedIndex = 6;
            Assert.AreEqual(items[6], masterDetailsView.SelectedItem);
        }

        [TestCategory("MasterDetailsView")]
        [UITestMethod]
        public void Test_SelectedItem_Syncs_SelectedIndex()
        {
            var items = Enumerable.Range(0, 10).ToArray();
            var masterDetailsView = new MasterDetailsView();
            masterDetailsView.ItemsSource = items;
            masterDetailsView.SelectedItem = items[3];
            Assert.AreEqual(3, masterDetailsView.SelectedIndex);
        }
    }
}