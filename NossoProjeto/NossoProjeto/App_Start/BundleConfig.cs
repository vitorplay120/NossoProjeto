﻿using System.Web;
using System.Web.Optimization;

namespace NossoProjeto
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"                      
                        ));

            bundles.Add(new ScriptBundle("~/bundles/inputmask").Include(
            //~/Scripts/inputmask/dependencyLibs/inputmask.dependencyLib.js",  //if not using jquery
            "~/Scripts/inputmask/inputmask.js",
            "~/Scripts/inputmask/jquery.inputmask.js",
            "~/Scripts/inputmask/inputmask.extensions.js",
            "~/Scripts/inputmask/inputmask.date.extensions.js",
            //and other extensions you want to include
            "~/Scripts/inputmask/inputmask.numeric.extensions.js"));

            bundles.Add(new ScriptBundle("~/Scripts/funcionalidades.js").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery.unobtrusive-ajax.js",
                "~/Scripts/jquery.unobtrusive-ajax.min.js",
                "~/Scripts/funcionalidades.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
            // pronto para a produção, utilize a ferramenta de build em https://modernizr.com para escolher somente os testes que precisa.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(                     
                      "~/Content/site.css"));
        }
    }
}
