using System.Web;
using System.Web.Optimization;

namespace MultiLangCV
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.11.3.min.js"));            


            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/styles.css",
                      "~/Content/languages.min.css",
                      "~/Content/font-awesome.css"));

            bundles.Add(new StyleBundle("~/Content/print-css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/styles-print.css",
                      "~/Content/languages.min.css",
                      "~/Content/font-awesome.css"));

        }
    }
}
