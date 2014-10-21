using System.Web;
using System.Web.Optimization;

namespace EATurner.Web
{
    public class BundleConfig
    {

        /// <summary>
        /// Registers the Scipts and CSS bundles.
        /// </summary>
        /// <param name="bundles">The bundles.</param>
        public static void RegisterBundles(BundleCollection bundles)
        {

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
                    "~/app/EATurnerApp/controllers/TitlesController.js",
                    "~/app/EATurnerApp/controllers/viewTitlesController.js"
                     ));



            BundleTable.EnableOptimizations = true;
#if (DEBUG)
            BundleTable.EnableOptimizations = false;
#endif
        }
    }
}
