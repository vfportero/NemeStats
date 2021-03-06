// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
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
namespace UI.Controllers
{
    public partial class GamingGroupController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected GamingGroupController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Index()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Details()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Details);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult GetCurrentUserGamingGroupGameDefinitions()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetCurrentUserGamingGroupGameDefinitions);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult GrantAccess()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GrantAccess);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult SwitchGamingGroups()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SwitchGamingGroups);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult CreateNewGamingGroup()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CreateNewGamingGroup);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Edit()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public GamingGroupController Actions { get { return MVC.GamingGroup; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "GamingGroup";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "GamingGroup";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string Details = "Details";
            public readonly string GetTopGamingGroups = "GetTopGamingGroups";
            public readonly string GetCurrentUserGamingGroupGameDefinitions = "GetCurrentUserGamingGroupGameDefinitions";
            public readonly string GrantAccess = "GrantAccess";
            public readonly string SwitchGamingGroups = "SwitchGamingGroups";
            public readonly string CreateNewGamingGroup = "CreateNewGamingGroup";
            public readonly string Edit = "Edit";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string Details = "Details";
            public const string GetTopGamingGroups = "GetTopGamingGroups";
            public const string GetCurrentUserGamingGroupGameDefinitions = "GetCurrentUserGamingGroupGameDefinitions";
            public const string GrantAccess = "GrantAccess";
            public const string SwitchGamingGroups = "SwitchGamingGroups";
            public const string CreateNewGamingGroup = "CreateNewGamingGroup";
            public const string Edit = "Edit";
        }


        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string currentUser = "currentUser";
        }
        static readonly ActionParamsClass_Details s_params_Details = new ActionParamsClass_Details();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Details DetailsParams { get { return s_params_Details; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Details
        {
            public readonly string id = "id";
            public readonly string currentUser = "currentUser";
        }
        static readonly ActionParamsClass_GetCurrentUserGamingGroupGameDefinitions s_params_GetCurrentUserGamingGroupGameDefinitions = new ActionParamsClass_GetCurrentUserGamingGroupGameDefinitions();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetCurrentUserGamingGroupGameDefinitions GetCurrentUserGamingGroupGameDefinitionsParams { get { return s_params_GetCurrentUserGamingGroupGameDefinitions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetCurrentUserGamingGroupGameDefinitions
        {
            public readonly string id = "id";
            public readonly string currentUser = "currentUser";
        }
        static readonly ActionParamsClass_GrantAccess s_params_GrantAccess = new ActionParamsClass_GrantAccess();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GrantAccess GrantAccessParams { get { return s_params_GrantAccess; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GrantAccess
        {
            public readonly string model = "model";
            public readonly string currentUser = "currentUser";
        }
        static readonly ActionParamsClass_SwitchGamingGroups s_params_SwitchGamingGroups = new ActionParamsClass_SwitchGamingGroups();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SwitchGamingGroups SwitchGamingGroupsParams { get { return s_params_SwitchGamingGroups; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SwitchGamingGroups
        {
            public readonly string gamingGroupId = "gamingGroupId";
            public readonly string currentUser = "currentUser";
        }
        static readonly ActionParamsClass_CreateNewGamingGroup s_params_CreateNewGamingGroup = new ActionParamsClass_CreateNewGamingGroup();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CreateNewGamingGroup CreateNewGamingGroupParams { get { return s_params_CreateNewGamingGroup; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CreateNewGamingGroup
        {
            public readonly string gamingGroupName = "gamingGroupName";
            public readonly string currentUser = "currentUser";
        }
        static readonly ActionParamsClass_Edit s_params_Edit = new ActionParamsClass_Edit();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Edit EditParams { get { return s_params_Edit; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Edit
        {
            public readonly string id = "id";
            public readonly string request = "request";
            public readonly string currentUser = "currentUser";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _GamingGroupPublicDetailsPartial = "_GamingGroupPublicDetailsPartial";
                public readonly string _TopGamingGroupsPartial = "_TopGamingGroupsPartial";
                public readonly string Details = "Details";
                public readonly string Edit = "Edit";
                public readonly string Index = "Index";
                public readonly string TopGamingGroups = "TopGamingGroups";
                public readonly string UpdateGamingGroupName = "UpdateGamingGroupName";
            }
            public readonly string _GamingGroupPublicDetailsPartial = "~/Views/GamingGroup/_GamingGroupPublicDetailsPartial.cshtml";
            public readonly string _TopGamingGroupsPartial = "~/Views/GamingGroup/_TopGamingGroupsPartial.cshtml";
            public readonly string Details = "~/Views/GamingGroup/Details.cshtml";
            public readonly string Edit = "~/Views/GamingGroup/Edit.cshtml";
            public readonly string Index = "~/Views/GamingGroup/Index.cshtml";
            public readonly string TopGamingGroups = "~/Views/GamingGroup/TopGamingGroups.cshtml";
            public readonly string UpdateGamingGroupName = "~/Views/GamingGroup/UpdateGamingGroupName.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_GamingGroupController : UI.Controllers.GamingGroupController
    {
        public T4MVC_GamingGroupController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, BusinessLogic.Models.User.ApplicationUser currentUser);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index(BusinessLogic.Models.User.ApplicationUser currentUser)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "currentUser", currentUser);
            IndexOverride(callInfo, currentUser);
            return callInfo;
        }

        [NonAction]
        partial void DetailsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, BusinessLogic.Models.User.ApplicationUser currentUser);

        [NonAction]
        public override System.Web.Mvc.ActionResult Details(int id, BusinessLogic.Models.User.ApplicationUser currentUser)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Details);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "currentUser", currentUser);
            DetailsOverride(callInfo, id, currentUser);
            return callInfo;
        }

        [NonAction]
        partial void GetTopGamingGroupsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult GetTopGamingGroups()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetTopGamingGroups);
            GetTopGamingGroupsOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void GetCurrentUserGamingGroupGameDefinitionsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, BusinessLogic.Models.User.ApplicationUser currentUser);

        [NonAction]
        public override System.Web.Mvc.ActionResult GetCurrentUserGamingGroupGameDefinitions(int id, BusinessLogic.Models.User.ApplicationUser currentUser)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetCurrentUserGamingGroupGameDefinitions);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "currentUser", currentUser);
            GetCurrentUserGamingGroupGameDefinitionsOverride(callInfo, id, currentUser);
            return callInfo;
        }

        [NonAction]
        partial void GrantAccessOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, UI.Models.GamingGroup.GamingGroupViewModel model, BusinessLogic.Models.User.ApplicationUser currentUser);

        [NonAction]
        public override System.Web.Mvc.ActionResult GrantAccess(UI.Models.GamingGroup.GamingGroupViewModel model, BusinessLogic.Models.User.ApplicationUser currentUser)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GrantAccess);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "currentUser", currentUser);
            GrantAccessOverride(callInfo, model, currentUser);
            return callInfo;
        }

        [NonAction]
        partial void SwitchGamingGroupsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int gamingGroupId, BusinessLogic.Models.User.ApplicationUser currentUser);

        [NonAction]
        public override System.Web.Mvc.ActionResult SwitchGamingGroups(int gamingGroupId, BusinessLogic.Models.User.ApplicationUser currentUser)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SwitchGamingGroups);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "gamingGroupId", gamingGroupId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "currentUser", currentUser);
            SwitchGamingGroupsOverride(callInfo, gamingGroupId, currentUser);
            return callInfo;
        }

        [NonAction]
        partial void CreateNewGamingGroupOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string gamingGroupName, BusinessLogic.Models.User.ApplicationUser currentUser);

        [NonAction]
        public override System.Web.Mvc.ActionResult CreateNewGamingGroup(string gamingGroupName, BusinessLogic.Models.User.ApplicationUser currentUser)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CreateNewGamingGroup);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "gamingGroupName", gamingGroupName);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "currentUser", currentUser);
            CreateNewGamingGroupOverride(callInfo, gamingGroupName, currentUser);
            return callInfo;
        }

        [NonAction]
        partial void EditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

        [NonAction]
        public override System.Web.Mvc.ActionResult Edit(int id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            EditOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void EditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, BusinessLogic.Models.GamingGroups.GamingGroupEditRequest request, BusinessLogic.Models.User.ApplicationUser currentUser);

        [NonAction]
        public override System.Web.Mvc.ActionResult Edit(BusinessLogic.Models.GamingGroups.GamingGroupEditRequest request, BusinessLogic.Models.User.ApplicationUser currentUser)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "request", request);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "currentUser", currentUser);
            EditOverride(callInfo, request, currentUser);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
