using System.Web;
using System.Web.Optimization;

namespace FiordilotoMVC
{
    public class BundleConfig
    {
        // Per altre informazioni sulla creazione di bundle, vedere https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilizzare la versione di sviluppo di Modernizr per eseguire attività di sviluppo e formazione. Successivamente, quando si è
            // pronti per passare alla produzione, usare lo strumento di compilazione disponibile all'indirizzo https://modernizr.com per selezionare solo i test necessari.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap-datepicker.js",
                      "~/Scripts/jquery.filtertable.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/font-awesome.css",
                      "~/Content/overlay-bootstrap.css",
                      "~/Content/lightbox.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/avatar").Include(
                      "~/Scripts/site.avatar.js"));

            bundles.Add(new ScriptBundle("~/bundles/slide").Include(
                     "~/Scripts/site.slide.js"));

            bundles.Add(new ScriptBundle("~/bundles/icona").Include(
                     "~/Scripts/site.icona.js"));

            bundles.Add(new ScriptBundle("~/bundles/jcrop").Include(
                      "~/Scripts/jquery.Jcrop.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryform").Include(
                      "~/Scripts/jquery.form.js"));

            bundles.Add(new StyleBundle("~/Content/jcrop").Include(
                      "~/Content/jquery.Jcrop.css"));

            bundles.Add(new StyleBundle("~/Content/avatar").Include(
                      "~/Content/site.avatar.css"));

            bundles.Add(new StyleBundle("~/Content/slide").Include(
                      "~/Content/site.slide.css"));

            bundles.Add(new StyleBundle("~/Content/icona").Include(
                      "~/Content/site.icona.css"));


        }
    }
}
