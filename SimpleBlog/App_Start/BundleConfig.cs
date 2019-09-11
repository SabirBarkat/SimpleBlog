using System.Web.Optimization;

namespace SimpleBlog
{
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/admin/styles")
                .Include("~/Scripts/modernizr-2.6.2.js")
                .Include("~/Content/bootstrap.css")
                .Include("~/Content/admin.css"));

            bundles.Add(new StyleBundle("~/styles")
                .Include("~/Scripts/modernizr-2.6.2.js")
                .Include("~/Content/bootstrap.css")
                .Include("~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/admin/scripts")
	            .Include("~/scripts/jquery-3.4.1.js")
                .Include("~/scripts/jquery.validate.js")
                .Include("~/scripts/jquery.validate.unobtrusive.js")
                .Include("~/scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/scripts")
                .Include("~/scripts/jquery-3.4.1.js")
                .Include("~/scripts/jquery.validate.js")
                .Include("~/scripts/jquery.validate.unobtrusive.js")
                .Include("~/scripts/bootstrap.js"));

            #if DEBUG
                BundleTable.EnableOptimizations = false;
            #else
                BundleTable.EnableOptimizations = true;
            #endif
        }
    } // class
}