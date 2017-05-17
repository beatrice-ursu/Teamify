using System.Web;
using System.Web.Optimization;

namespace Teamify
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/libs").Include(
                        "~/Scripts/libs/jquery.js",
                        "~/Scripts/libs/tether.js",
                        "~/Scripts/libs/bootstrap.js",
                        "~/Scripts/libs/tether.js",
                        "~/Scripts/libs/respond.js",
                        "~/Scripts/libs/Chart.js",
                        "~/Scripts/libs/jquery.dataTables.js",
                        "~/Scripts/libs/dataTables.bootstrap.js",
                        "~/Scripts/libs/select2.full.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/libs/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/font-awesome.css",
                      "~/Content/simple-line-icons.css",
                      "~/Content/coreui.css",
                      "~/Content/jquery.dataTables.css",
                      "~/Content/dataTables.bootstrap.css",
                      "~/Content/select2.css",
                      "~/Content/Site.css"));
        }
    }
}
