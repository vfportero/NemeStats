﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
#pragma warning disable 1591, 3008, 3009
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
    public static UI.Controllers.AccountController Account = new UI.Controllers.T4MVC_AccountController();
    public static UI.Controllers.GameDefinitionController GameDefinition = new UI.Controllers.T4MVC_GameDefinitionController();
    public static UI.Controllers.GamingGroupController GamingGroup = new UI.Controllers.T4MVC_GamingGroupController();
    public static UI.Controllers.HomeController Home = new UI.Controllers.T4MVC_HomeController();
    public static UI.Controllers.PlayedGameController PlayedGame = new UI.Controllers.T4MVC_PlayedGameController();
    public static UI.Controllers.PlayerController Player = new UI.Controllers.T4MVC_PlayerController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string _references_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/_references.min.js") ? Url("_references.min.js") : Url("_references.js");
        public static readonly string bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.js") ? Url("bootstrap.min.js") : Url("bootstrap.js");
        public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class CreatePlayedGame {
            private const string URLPATH = "~/Scripts/CreatePlayedGame";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string createplayedgame_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/createplayedgame.min.js") ? Url("createplayedgame.min.js") : Url("createplayedgame.js");
        }
    
        public static readonly string jquery_1_10_2_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.10.2.intellisense.min.js") ? Url("jquery-1.10.2.intellisense.min.js") : Url("jquery-1.10.2.intellisense.js");
        public static readonly string jquery_1_10_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.10.2.min.js") ? Url("jquery-1.10.2.min.js") : Url("jquery-1.10.2.js");
        public static readonly string jquery_1_10_2_min_js = Url("jquery-1.10.2.min.js");
        public static readonly string jquery_ui_1_11_1_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-ui-1.11.1.min.js") ? Url("jquery-ui-1.11.1.min.js") : Url("jquery-ui-1.11.1.js");
        public static readonly string jquery_ui_min_1_11_1_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-ui.min-1.11.1.min.js") ? Url("jquery-ui.min-1.11.1.min.js") : Url("jquery-ui.min-1.11.1.js");
        public static readonly string jquery_validate_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate-vsdoc.min.js") ? Url("jquery.validate-vsdoc.min.js") : Url("jquery.validate-vsdoc.js");
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
        public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
        public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
        public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
        public static readonly string modernizr_2_6_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/modernizr-2.6.2.min.js") ? Url("modernizr-2.6.2.min.js") : Url("modernizr-2.6.2.js");
        public static readonly string modernizr_2_8_3_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/modernizr-2.8.3.min.js") ? Url("modernizr-2.8.3.min.js") : Url("modernizr-2.8.3.js");
        public static readonly string respond_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/respond.min.js") ? Url("respond.min.js") : Url("respond.js");
        public static readonly string respond_min_js = Url("respond.min.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string blog_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/blog.min.css") ? Url("blog.min.css") : Url("blog.css");
             
        public static readonly string bootstrap_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.css") ? Url("bootstrap.min.css") : Url("bootstrap.css");
             
        public static readonly string bootstrap_css_map = Url("bootstrap.css.map");
        public static readonly string bootstrap_min_css = Url("bootstrap.min.css");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class css {
            private const string URLPATH = "~/Content/css";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string font_awesome_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/font-awesome.min.css") ? Url("font-awesome.min.css") : Url("font-awesome.css");
                 
            public static readonly string font_awesome_min_css = Url("font-awesome.min.css");
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class fonts {
            private const string URLPATH = "~/Content/fonts";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string fontawesome_webfont_eot = Url("fontawesome-webfont.eot");
            public static readonly string fontawesome_webfont_svg = Url("fontawesome-webfont.svg");
            public static readonly string fontawesome_webfont_ttf = Url("fontawesome-webfont.ttf");
            public static readonly string fontawesome_webfont_woff = Url("fontawesome-webfont.woff");
            public static readonly string FontAwesome_otf = Url("FontAwesome.otf");
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Images {
            private const string URLPATH = "~/Content/Images";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string NemeStats_White_png = Url("NemeStats-White.png");
            public static readonly string NemeStats_png = Url("NemeStats.png");
        }
    
        public static readonly string Site_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Site.min.css") ? Url("Site.min.css") : Url("Site.css");
             
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class themes {
            private const string URLPATH = "~/Content/themes";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class @base {
                private const string URLPATH = "~/Content/themes/base";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string accordion_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/accordion.min.css") ? Url("accordion.min.css") : Url("accordion.css");
                     
                public static readonly string all_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/all.min.css") ? Url("all.min.css") : Url("all.css");
                     
                public static readonly string autocomplete_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/autocomplete.min.css") ? Url("autocomplete.min.css") : Url("autocomplete.css");
                     
                public static readonly string base_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/base.min.css") ? Url("base.min.css") : Url("base.css");
                     
                public static readonly string button_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/button.min.css") ? Url("button.min.css") : Url("button.css");
                     
                public static readonly string core_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/core.min.css") ? Url("core.min.css") : Url("core.css");
                     
                public static readonly string datepicker_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/datepicker.min.css") ? Url("datepicker.min.css") : Url("datepicker.css");
                     
                public static readonly string dialog_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/dialog.min.css") ? Url("dialog.min.css") : Url("dialog.css");
                     
                public static readonly string draggable_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/draggable.min.css") ? Url("draggable.min.css") : Url("draggable.css");
                     
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class images {
                    private const string URLPATH = "~/Content/themes/base/images";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string ui_bg_flat_0_aaaaaa_40x100_png = Url("ui-bg_flat_0_aaaaaa_40x100.png");
                    public static readonly string ui_bg_flat_75_ffffff_40x100_png = Url("ui-bg_flat_75_ffffff_40x100.png");
                    public static readonly string ui_bg_glass_55_fbf9ee_1x400_png = Url("ui-bg_glass_55_fbf9ee_1x400.png");
                    public static readonly string ui_bg_glass_65_ffffff_1x400_png = Url("ui-bg_glass_65_ffffff_1x400.png");
                    public static readonly string ui_bg_glass_75_dadada_1x400_png = Url("ui-bg_glass_75_dadada_1x400.png");
                    public static readonly string ui_bg_glass_75_e6e6e6_1x400_png = Url("ui-bg_glass_75_e6e6e6_1x400.png");
                    public static readonly string ui_bg_glass_95_fef1ec_1x400_png = Url("ui-bg_glass_95_fef1ec_1x400.png");
                    public static readonly string ui_bg_highlight_soft_75_cccccc_1x100_png = Url("ui-bg_highlight-soft_75_cccccc_1x100.png");
                    public static readonly string ui_icons_222222_256x240_png = Url("ui-icons_222222_256x240.png");
                    public static readonly string ui_icons_2e83ff_256x240_png = Url("ui-icons_2e83ff_256x240.png");
                    public static readonly string ui_icons_454545_256x240_png = Url("ui-icons_454545_256x240.png");
                    public static readonly string ui_icons_888888_256x240_png = Url("ui-icons_888888_256x240.png");
                    public static readonly string ui_icons_cd0a0a_256x240_png = Url("ui-icons_cd0a0a_256x240.png");
                }
            
                public static readonly string menu_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/menu.min.css") ? Url("menu.min.css") : Url("menu.css");
                     
                public static readonly string progressbar_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/progressbar.min.css") ? Url("progressbar.min.css") : Url("progressbar.css");
                     
                public static readonly string resizable_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/resizable.min.css") ? Url("resizable.min.css") : Url("resizable.css");
                     
                public static readonly string selectable_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/selectable.min.css") ? Url("selectable.min.css") : Url("selectable.css");
                     
                public static readonly string selectmenu_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/selectmenu.min.css") ? Url("selectmenu.min.css") : Url("selectmenu.css");
                     
                public static readonly string slider_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/slider.min.css") ? Url("slider.min.css") : Url("slider.css");
                     
                public static readonly string sortable_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/sortable.min.css") ? Url("sortable.min.css") : Url("sortable.css");
                     
                public static readonly string spinner_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/spinner.min.css") ? Url("spinner.min.css") : Url("spinner.css");
                     
                public static readonly string tabs_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/tabs.min.css") ? Url("tabs.min.css") : Url("tabs.css");
                     
                public static readonly string theme_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/theme.min.css") ? Url("theme.min.css") : Url("theme.css");
                     
                public static readonly string tooltip_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/tooltip.min.css") ? Url("tooltip.min.css") : Url("tooltip.css");
                     
            }
        
        }
    
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Scripts {}
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Styles {}
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591, 3008, 3009


