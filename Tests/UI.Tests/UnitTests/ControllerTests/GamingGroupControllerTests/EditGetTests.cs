﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using UI.Models.GamingGroup;

namespace UI.Tests.UnitTests.ControllerTests.GamingGroupControllerTests
{
	public class EditGetTests : GamingGroupControllerTestBase
	{
		[Test]
		public void ItReturnsTheGamingGroupEditViewModel()
		{
			const int GAMING_GROUP_ID = 1;

			var viewResult = autoMocker.ClassUnderTest.Edit(GAMING_GROUP_ID) as ViewResult;

			Assert.AreEqual(MVC.GamingGroup.Views.Edit, viewResult.ViewName);
		}

		//[Test]
		//public void ItReturnsTopGamingGroupsView()
		//{
		//    var viewResult = gamingGroupControllerPartialMock.GetTopGamingGroups() as ViewResult;

		//    Assert.AreEqual(MVC.GamingGroup.Views.TopGamingGroups, viewResult.ViewName);
		//}

		//[Test]
		//public void ItReturnsSpecifiedTopGamingGroupsModelToTheView()
		//{
		//    var viewResult = gamingGroupControllerPartialMock.GetTopGamingGroups() as ViewResult;

		//    var actualViewModel = viewResult.ViewData.Model;

		//    Assert.AreEqual(expectedViewModel, actualViewModel);
		//}
	}
}