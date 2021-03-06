﻿#region License

// Copyright 2015 LoLAccountChecker
// 
// This file is part of LoLAccountChecker.
// 
// LoLAccountChecker is free software: you can redistribute it and/or modify 
// it under the terms of the GNU General Public License as published 
// by the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// LoLAccountChecker is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of 
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
// See the GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License 
// along with LoLAccountChecker. If not, see http://www.gnu.org/licenses/.

#endregion

#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using LoLAccountChecker.Classes;
using PVPNetConnect;

#endregion

namespace LoLAccountChecker.Views
{
    public partial class ImportWindow
    {
        private readonly List<Account> _accounts;

        public ImportWindow(List<Account> accounts)
        {
            InitializeComponent();

            _accounts = accounts;

            AccountsGrid.ItemsSource = _accounts;
            RegionBox.ItemsSource = Enum.GetValues(typeof(Region)).Cast<Region>();
            RegionBox.SelectedItem = Settings.Config.SelectedRegion;
        }

        private void OnChangeRegion(object sender, SelectionChangedEventArgs e)
        {
            Settings.Config.SelectedRegion = (Region) RegionBox.SelectedIndex;
        }

        private void BtnImportClick(object sender, RoutedEventArgs e)
        {
            foreach (var account in _accounts.Where(a => Checker.Accounts.All(aa => aa.Username != a.Username)))
            {
                account.Region = (Region)RegionBox.SelectedIndex;
                Checker.Accounts.Add(account);
            }
            
            MainWindow.Instance.UpdateControls();
            AccountsWindow.Instance.RefreshAccounts();
            
            Close();
        }
    }
}
