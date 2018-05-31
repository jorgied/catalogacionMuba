using System.Web;
using System.Web.Optimization;

namespace catalogacionMuba
{
    //public class BundleConfig
    //{
    //    // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
    //    public static void RegisterBundles(BundleCollection bundles)
    //    {
    //        bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
    //                    "~/Scripts/jquery-3.3.1.js",
    //                    "~/Scripts/select2.min.js"));

    //        bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
    //                    "~/Scripts/jquery.validate*"));

            

    //        // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
    //        // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
    //        bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
    //                    "~/Scripts/modernizr-*"));

    //        bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
    //                  "~/Scripts/bootstrap.js"));

    //        bundles.Add(new StyleBundle("~/Content/css").Include(
    //                  "~/Content/bootstrap.css",
    //                  "~/Content/site.css"));
    //    }
    //}
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true;
            ScriptBundle scriptBundle = new ScriptBundle("~/js");
            string[] scriptArray =
            {
             //"~/Scripts/jquery-1.12.4.js",
                       "~/Scripts/jquery-3.3.1.js",

                        "~/Scripts/jquery.unobtrusive-ajax.js",
                       "~/Scripts/bootstrap.js",
                         "~/Scripts/select2.min.js"

        };
            scriptBundle.Include(scriptArray);
            scriptBundle.IncludeDirectory("~/Scripts/", "*.js");
            bundles.Add(scriptBundle);

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));



            bundles.Add(new StyleBundle("~/Styles/css").Include(
                      "~/Content/bootstrap.min.css",
                    "~/Content/site.css"
                     ));
        }
    }
}
