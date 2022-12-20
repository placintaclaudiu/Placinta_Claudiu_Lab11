﻿using Placinta_Claudiu_Lab11.Data;

namespace Placinta_Claudiu_Lab11
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            // InitializeComponent();

            // MainPage = new AppShell();

            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
        }
    }
}