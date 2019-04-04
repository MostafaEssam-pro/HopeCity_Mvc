using System.Web;
using System.Web.Optimization;

namespace view_eye
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/popper.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/dataTables").Include(
                      //"~/Scripts/jquery.dataTables.min.js",

                      //"~/Scripts/dataTables.bootstrap4.min.js",
                      "~/Scripts/jquery-ui.min.js",
                      "~/Scripts/jquery.validate.min.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/charts").Include(
                   "~/Scripts/raphael-min.js",
                       "~/Scripts/morris.min.js",
                       "~/Scripts/custom-morris.js"
                    ));


            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
                      "~/Scripts/custom.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js"));



            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css"

                    ));



            bundles.Add(new StyleBundle("~/Content/cusr").Include(
                    "~/Content/themify-icons.css",
                    "~/Content/animate.css",
                     "~/Content/jquery-ui.min.css",
                    "~/Content/styles.css",
                    "~/Content/green.css",
                    "~/Content/morris.css",
                    "~/Content/responsive.css"
                    ));

            bundles.Add(new StyleBundle("~/Content/dataTables").Include(
                   "~/Content/dataTables.bootstrap4.min.css"
                   ));

        }
    }
}
