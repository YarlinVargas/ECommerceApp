using ECommerceApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }
        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}
