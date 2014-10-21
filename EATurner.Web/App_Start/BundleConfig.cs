using System.Web;
using System.Web.Optimization;

namespace EATurner.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/bundles/bootstrap").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/animations.css",
                      "~/Content/styles.css"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                     "~/app/wc.directives/directives/wcOverlay.js",
                    "~/app/wc.directives/directives/menuHighlighter.js",
                    "~/app/EATurnerApp/app.js",
                    "~/app/EATurnerApp/animations/listAnimations.js",
                    "~/app/EATurnerApp/directives/wcUnique.js",
                    "~/app/EATurnerApp/services/config.js",
                    "~/app/EATurnerApp/services/authService.js",
                    "~/app/EATurnerApp/services/httpInterceptors.js",
                    "~/app/EATurnerApp/services/titleService.js",
                    "~/app/EATurnerApp/controllers/aboutController.js",
                    "~/app/EATurnerApp/controllers/navbarController.js",
                    "~/app/EATurnerApp/controllers/loginController.js",
                    "~/app/EATurnerApp/controllers/TitlesController.js",
                    "~/app/EATurnerApp/controllers/viewTitlesController.js"
                     ));



            BundleTable.EnableOptimizations = true;
            #region (DEBUG)
            BundleTable.EnableOptimizations = false;
            #endregion
        }
    }
}
