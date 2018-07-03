#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.Owin;
using Microsoft.Extensions.DependencyInjection;
using Owin;
using System.Web;

[assembly: OwinStartupAttribute(typeof(PicklistDemo.Startup))]
namespace PicklistDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

        // Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection service)
        {
        }
    }
}
