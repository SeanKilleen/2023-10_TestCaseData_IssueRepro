using System.Collections;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestCaseSourceStuff
{
	public class Tests
	{
		[TestFixture]
		public class MyTests
		{
			[TestCaseSource(nameof(TestCaseSource_FindBestCategory))]
			public void DivideTest(string title, Level expectedLevel, Area expectedArea)
			{
				var message = "Title: " + title;

				var categoryList = (Level: Level.Employee, Area: Area.Administration);
				Assert.AreEqual(expectedLevel, categoryList.Level, message);
				Assert.AreEqual(expectedArea, categoryList.Area, message);
			}

			public enum Area
			{
				Undefined = 0,
				Administration = 1,
				Finance = 2,
				Operations = 3,
				SalesAndMarketing = 4,
			}

			public enum Level
			{
				Leadership = 0,
				SeniorManagement = 1,
				Management = 2,
				Employee = 3,
			}

			static IEnumerable<TestCaseData> TestCaseSource_FindBestCategory()
			{
				// Managing Director - Abbreviation variants (handled by MD RegEx)
				yield return new TestCaseData("MD", Level.Leadership, Area.Undefined).SetName("DivideTest - Leadership (Undefined) - MD");
				yield return new TestCaseData("M D", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - M D");
				yield return new TestCaseData("M DIR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - M DIR");
				yield return new TestCaseData("MAN DIR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MAN DIR");
				yield return new TestCaseData("MANAGING DIR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MANAGING DIR");
				yield return new TestCaseData("MDIR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MDIR");
				yield return new TestCaseData("MANDIR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MANDIR");
				yield return new TestCaseData("MANAGINGDIR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MANAGINGDIR");
				yield return new TestCaseData("MNGDIR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MNGDIR");
				yield return new TestCaseData("M DIRECT", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - M DIRECT");
				yield return new TestCaseData("MAN DIRECT", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MAN DIRECT");
				yield return new TestCaseData("MANAGING DIRECT", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MANAGING DIRECT");
				yield return new TestCaseData("MDIRECT", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MDIRECT");
				yield return new TestCaseData("MANDIRECT", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MANDIRECT");
				yield return new TestCaseData("MANAGINGDIRECT", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MANAGINGDIRECT");
				yield return new TestCaseData("MNGDIRECT", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MNGDIRECT");
				yield return new TestCaseData("M DIRECTOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - M DIRECTOR");
				yield return new TestCaseData("MAN DIRECTOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MAN DIRECTOR");
				yield return new TestCaseData("MANAGING DIRECTOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MANAGING DIRECTOR");
				yield return new TestCaseData("MNG DIRECTOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MNG DIRECTOR");
				yield return new TestCaseData("MDIRECTOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MDIRECTOR");
				yield return new TestCaseData("MANDIRECTOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MANDIRECTOR");
				yield return new TestCaseData("MANAGINGDIRECTOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MANAGINGDIRECTOR");
				yield return new TestCaseData("MNGDIRECTOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MNGDIRECTOR");

				// Managing Director - Misspellings (handled by standardization)
				yield return new TestCaseData("MANAGING DIRCETOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MANAGING DIRCETOR");
				yield return new TestCaseData("MANAGING DIRECTO", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MANAGING DIRECTO");
				yield return new TestCaseData("MANAGING DIRETOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MANAGING DIRETOR");
				yield return new TestCaseData("MANAGING DIRECTTOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MANAGING DIRECTTOR");
				yield return new TestCaseData("MANAGING DIRESTOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MANAGING DIRESTOR");
				yield return new TestCaseData("MANAGING DIRECOTOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MANAGING DIRECOTOR");
				yield return new TestCaseData("MANAGING DIRECTIOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MANAGING DIRECTIOR");
				yield return new TestCaseData("MANAGING DIRCETOT", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MANAGING DIRCETOT");
				yield return new TestCaseData("MANAGING DIRECOPR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MANAGING DIRECOPR");
				yield return new TestCaseData("MANAGING DICTOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MANAGING DICTOR");
				yield return new TestCaseData("MANAGING DIREKTOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MANAGING DIREKTOR");
				yield return new TestCaseData("MANAGING DIREKTEUR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MANAGING DIREKTEUR");
				yield return new TestCaseData("MANAGING DIRECTEUR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MANAGING DIRECTEUR");

				// Client Data Employee Operations - Abbreviation variants
				yield return new TestCaseData("FWDG", Level.Employee, Area.Operations).SetName("Employee (Operations) - FWDG");
				yield return new TestCaseData("IMP", Level.Employee, Area.Operations).SetName("Employee (Operations) - IMP");
				yield return new TestCaseData("EXP", Level.Employee, Area.Operations).SetName("Employee (Operations) - EXP");

				// Client Data Management Other - Abbreviation variants
				yield return new TestCaseData("MANAGEMENT", Level.Management, Area.Undefined).SetName("Management (Undefined) - MANAGEMENT");

				// Client Data Leadership Other - Abbreviation variants
				yield return new TestCaseData("MANAGING PARTNER", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - MANAGING PARTNER");

				// Director - Abbreviation variants (handled by MD RegEx)
				yield return new TestCaseData("DIR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - DIR");
				yield return new TestCaseData("DIRECTOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - DIRECTOR");
				yield return new TestCaseData("DIRECTEUR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - DIRECTEUR");
				yield return new TestCaseData("DIREKTEUR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - DIREKTEUR");

				// TODO - GM
				// Director - Misspellings (handled by standardization)
				yield return new TestCaseData("DIRCETOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - DIRCETOR");
				yield return new TestCaseData("DIRECTO", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - DIRECTO");
				yield return new TestCaseData("DIRETOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - DIRETOR");
				yield return new TestCaseData("DIRECTTOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - DIRECTTOR");
				yield return new TestCaseData("DIRESTOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - DIRESTOR");
				yield return new TestCaseData("DIRECOTOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - DIRECOTOR");
				yield return new TestCaseData("DIRECTIOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - DIRECTIOR");
				yield return new TestCaseData("DIRCETOT", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - DIRCETOT");
				yield return new TestCaseData("DIRECOPR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - DIRECOPR");
				yield return new TestCaseData("DICTOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - DICTOR");
				yield return new TestCaseData("DIREKTOR", Level.Leadership, Area.Undefined).SetName("Leadership (Undefined) - DIREKTOR");

				// Client Data Employee Finance - Abbreviation variants (handled by MD RegEx)
				yield return new TestCaseData("AP", Level.Employee, Area.Finance).SetName("Employee (Finance) - AP");
				yield return new TestCaseData("AR", Level.Employee, Area.Finance).SetName("Employee (Finance) - AR");
				yield return new TestCaseData("A/P", Level.Employee, Area.Finance).SetName("Employee (Finance) - A/P");
				yield return new TestCaseData("A/R", Level.Employee, Area.Finance).SetName("Employee (Finance) - A/R");

				// Client Data Vice President - Abbreviation variants (handled by VICE PRESIDENT RegEx)
				yield return new TestCaseData("VP", Level.SeniorManagement, Area.Operations).SetName("Senior Management (Operations) - VP");
				yield return new TestCaseData("VPRES", Level.SeniorManagement, Area.Operations).SetName("Senior Management (Operations) - VPRES");
				yield return new TestCaseData("VPRESID", Level.SeniorManagement, Area.Operations).SetName("Senior Management (Operations) - VPRESID");
				yield return new TestCaseData("VPRESIDENT", Level.SeniorManagement, Area.Operations).SetName("Senior Management (Operations) - VPRESIDENT");
				yield return new TestCaseData("V P", Level.SeniorManagement, Area.Operations).SetName("Senior Management (Operations) - V P");
				yield return new TestCaseData("V PRES", Level.SeniorManagement, Area.Operations).SetName("Senior Management (Operations) - V PRES");
				yield return new TestCaseData("V PRESID", Level.SeniorManagement, Area.Operations).SetName("Senior Management (Operations) - V PRESID");
				yield return new TestCaseData("V PRESIDENT", Level.SeniorManagement, Area.Operations).SetName("Senior Management (Operations) - V PRESIDENT");
				yield return new TestCaseData("VICEPRES", Level.SeniorManagement, Area.Operations).SetName("Senior Management (Operations) - VICEPRES");
				yield return new TestCaseData("VICEPRESID", Level.SeniorManagement, Area.Operations).SetName("Senior Management (Operations) - VICEPRESID");
				yield return new TestCaseData("VICEPRESIDENT", Level.SeniorManagement, Area.Operations).SetName("Senior Management (Operations) - VICEPRESIDENT");
				yield return new TestCaseData("VICE PRES", Level.SeniorManagement, Area.Operations).SetName("Senior Management (Operations) - VICE PRES");
				yield return new TestCaseData("VICE PRESID", Level.SeniorManagement, Area.Operations).SetName("Senior Management (Operations) - VICE PRESID");
				yield return new TestCaseData("VICE PRESIDENT", Level.SeniorManagement, Area.Operations).SetName("Senior Management (Operations) - VICE PRESIDENT");

				// Client Data Vice President - Misspellings (handled by standardization)
				yield return new TestCaseData("VICE PRESEDENT", Level.SeniorManagement, Area.Operations).SetName("Senior Management (Operations) - VICE PRESEDENT");
				yield return new TestCaseData("VICE PRESIDEN", Level.SeniorManagement, Area.Operations).SetName("Senior Management (Operations) - VICE PRESIDEN");

				// Client Data President - Abbreviation variants (handled by PRESIDENT RegEx)
				yield return new TestCaseData("PRES", Level.SeniorManagement, Area.Undefined).SetName("Senior Management (Undefined) - PRES");
				yield return new TestCaseData("PRESID", Level.SeniorManagement, Area.Undefined).SetName("Senior Management (Undefined) - PRESID");
				yield return new TestCaseData("PRESIDENT", Level.SeniorManagement, Area.Undefined).SetName("Senior Management (Undefined) - PRESIDENT");

				// Client Data President - Misspellings (handled by standardization)
				yield return new TestCaseData("PRESEDENT", Level.SeniorManagement, Area.Undefined).SetName("Senior Management (Undefined) - PRESEDENT");
				yield return new TestCaseData("PRESIDEN", Level.SeniorManagement, Area.Undefined).SetName("Senior Management (Undefined) - PRESIDEN");

				// Client Data General Manager - Abbreviation variants (handled by GENERAL MANAGER RegEx)
				yield return new TestCaseData("GM", Level.Management, Area.Operations).SetName("Management (Operations) - GM");
				yield return new TestCaseData("GMAN", Level.Management, Area.Operations).SetName("Management (Operations) - GMAN");
				yield return new TestCaseData("GMANAGER", Level.Management, Area.Operations).SetName("Management (Operations) - GMANAGER");
				yield return new TestCaseData("G M", Level.Management, Area.Operations).SetName("Management (Operations) - G M");
				yield return new TestCaseData("G MAN", Level.Management, Area.Operations).SetName("Management (Operations) - G MAN");
				yield return new TestCaseData("G MANAGER", Level.Management, Area.Operations).SetName("Management (Operations) - G MANAGER");
				yield return new TestCaseData("GENMAN", Level.Management, Area.Operations).SetName("Management (Operations) - GENMAN");
				yield return new TestCaseData("GENMANAGER", Level.Management, Area.Operations).SetName("Management (Operations) - GENMANAGER");
				yield return new TestCaseData("GEN M", Level.Management, Area.Operations).SetName("Management (Operations) - GEN M");
				yield return new TestCaseData("GEN MAN", Level.Management, Area.Operations).SetName("Management (Operations) - GEN MAN");
				yield return new TestCaseData("GEN MANAGER", Level.Management, Area.Operations).SetName("Management (Operations) - GEN MANAGER");
				yield return new TestCaseData("GENERAL M", Level.Management, Area.Operations).SetName("Management (Operations) - GENERAL M");
				yield return new TestCaseData("GENERAL MAN", Level.Management, Area.Operations).SetName("Management (Operations) - GENERAL MAN");
				yield return new TestCaseData("GENERAL MANAGER", Level.Management, Area.Operations).SetName("Management (Operations) - GENERAL MANAGER");

				// CEO Returns Leadership
				yield return new TestCaseData("CEO", Level.Leadership, Area.Undefined).SetName("Leadership - CEO");

				// CTO Returns Senior Management Operational
				yield return new TestCaseData("CTO", Level.SeniorManagement, Area.Operations).SetName("Senior Management (Operations) - CTO");

				// Dual Title Returns Senior Managment Other
				yield return new TestCaseData("Head of Sales / Accounts Recievable", Level.SeniorManagement, Area.Finance).SetName("Senior Management (Finance) - Head of Sales / Accounts Recievable");

				// Multiple Keywords Returns Leadership
				yield return new TestCaseData("Chairman of the Joint Chiefs - administration", Level.Leadership, Area.Undefined).SetName("Leadership - Chairman of the Joint Chiefs - administration");

				// Not A Title Random Characters Returns Employee Other
				yield return new TestCaseData("!@#$%^&*()),,..Nonsense...()_---..", Level.Employee, Area.Undefined).SetName("Employee (Undefined) - !@#$%^&*()),,..Nonsense...()_---..");

				// Senior Manager Sales Returns Senior Manager Sales
				yield return new TestCaseData("Head of Sales - ASPAC Region", Level.SeniorManagement, Area.SalesAndMarketing).SetName("Senior Management (Sales & Marketing) - Head of Sales - ASPAC Region");

				// Executive Assistant To CEO Returns Employee Administration
				yield return new TestCaseData("EA to CEO", Level.Employee, Area.Administration).SetName("Employee (Administration) - EA to CEO");
				yield return new TestCaseData("Executive Assistant to CEO", Level.Employee, Area.Administration).SetName("Employee (Administration) - Executive Assistant to CEO");
				yield return new TestCaseData("EA to Chief Executive Officer", Level.Employee, Area.Administration).SetName("Employee (Administration) - EA to Chief Executive Officer");

				// Manager From EA Returns Management Undefined
				yield return new TestCaseData("Manager - SOUTH EA", Level.Management, Area.Undefined).SetName("Management (Undefined) - Manager - SOUTH EA");
				yield return new TestCaseData("Manager - SOUTH   EA", Level.Management, Area.Undefined).SetName("Management (Undefined) - Manager - SOUTH   EA");
				yield return new TestCaseData("Manager - NORTH EA", Level.Management, Area.Undefined).SetName("Management (Undefined) - Manager - NORTH EA");
				yield return new TestCaseData("Manager - EAST EA", Level.Management, Area.Undefined).SetName("Management (Undefined) - Manager - EAST EA");
				yield return new TestCaseData("Manager - WEST EA", Level.Management, Area.Undefined).SetName("Management (Undefined) - Manager - WEST EA");
				yield return new TestCaseData("Manager - W. EA", Level.Management, Area.Undefined).SetName("Management (Undefined) - Manager - W. EA");
				yield return new TestCaseData("Manager - W.    EA", Level.Management, Area.Undefined).SetName("Management (Undefined) - Manager - W.    EA");
				yield return new TestCaseData("Manager - N. EA", Level.Management, Area.Undefined).SetName("Management (Undefined) - Manager - N. EA");
				yield return new TestCaseData("Manager - E. EA", Level.Management, Area.Undefined).SetName("Management (Undefined) - Manager - E. EA");
				yield return new TestCaseData("Manager - S. EA", Level.Management, Area.Undefined).SetName("Management (Undefined) - Manager - S. EA");
				yield return new TestCaseData("Manager - SOUTHEA", Level.Management, Area.Undefined).SetName("Management (Undefined) - Manager - SOUTHEA");
				yield return new TestCaseData("Manager - NORTHEA", Level.Management, Area.Undefined).SetName("Management (Undefined) - Manager - NORTHEA");
				yield return new TestCaseData("Manager - EASTEA", Level.Management, Area.Undefined).SetName("Management (Undefined) - Manager - EASTEA");
				yield return new TestCaseData("Manager - WESTEA", Level.Management, Area.Undefined).SetName("Management (Undefined) - Manager - WESTEA");
				yield return new TestCaseData("Manager - W.EA", Level.Management, Area.Undefined).SetName("Management (Undefined) - Manager - W.EA");
				yield return new TestCaseData("Manager - N.EA", Level.Management, Area.Undefined).SetName("Management (Undefined) - Manager - N.EA");
				yield return new TestCaseData("Manager - E.EA", Level.Management, Area.Undefined).SetName("Management (Undefined) - Manager - E.EA");
				yield return new TestCaseData("Manager - S.EA", Level.Management, Area.Undefined).SetName("Management (Undefined) - Manager - S.EA");
				yield return new TestCaseData("Manager - W EA", Level.Management, Area.Undefined).SetName("Management (Undefined) - Manager - W EA");
				yield return new TestCaseData("Manager - N EA", Level.Management, Area.Undefined).SetName("Management (Undefined) - Manager - N EA");
				yield return new TestCaseData("Manager - N     EA", Level.Management, Area.Undefined).SetName("Management (Undefined) - Manager - N     EA");
				yield return new TestCaseData("Manager - E EA", Level.Management, Area.Undefined).SetName("Management (Undefined) - Manager - E EA");
				yield return new TestCaseData("Manager - S EA", Level.Management, Area.Undefined).SetName("Management (Undefined) - Manager - S EA");

				// Unicode Returns Leadership Undefined
				yield return new TestCaseData("DIREKTØR", Level.Leadership, Area.Undefined).SetName("Leadership - DIREKTØR");

				// Real Data From Client
				yield return new TestCaseData("Admin Secretary", Level.Employee, Area.Administration).SetName("Employee (Administration) - Admin Secretary");
				yield return new TestCaseData("Reception Temp", Level.Employee, Area.Administration).SetName("Employee (Administration) - Reception Temp");
				yield return new TestCaseData("Senior Accounts & Admin Executive", Level.Employee, Area.Administration).SetName("Employee (Administration) - Senior Accounts & Admin Executive");
				yield return new TestCaseData("Backoffice Sales", Level.Employee, Area.Administration).SetName("Employee (Administration) - Backoffice Sales");
				yield return new TestCaseData("Reception / Airfreight Operations", Level.Employee, Area.Administration).SetName("Employee (Administration) - Reception / Airfreight Operations");
				yield return new TestCaseData("Admin Asst 1", Level.Employee, Area.Administration).SetName("Employee (Administration) - Admin Asst 1");

				yield return new TestCaseData("NIN Commercial Invoice Import", Level.Employee, Area.Finance).SetName("Employee (Finance) - NIN Commercial Invoice Import");
				yield return new TestCaseData("Operations Finance Coordinator", Level.Employee, Area.Finance).SetName("Employee (Finance) - Operations Finance Coordinator");
				yield return new TestCaseData("Invoice ref:UKSTC", Level.Employee, Area.Finance).SetName("Employee (Finance) - Invoice ref:UKSTC");
				yield return new TestCaseData("SNM - SOLICITED ACCOUNT", Level.Employee, Area.Finance).SetName("Employee (Finance) - SNM - SOLICITED ACCOUNT");
				yield return new TestCaseData("Account Service Executive", Level.Employee, Area.Finance).SetName("Employee (Finance) - Account Service Executive");
				yield return new TestCaseData("Accts. Payable", Level.Employee, Area.Finance).SetName("Employee (Finance) - Accts. Payable");

				yield return new TestCaseData("AU Operations Trainee", Level.Employee, Area.Operations).SetName("Employee (Operations) - AU Operations Trainee");
				yield return new TestCaseData("Forwarder Traffic Coordinator FTL N", Level.Employee, Area.Operations).SetName("Employee (Operations) - Forwarder Traffic Coordinator FTL N");
				yield return new TestCaseData("MX Industrial Projects Assistant", Level.Employee, Area.Operations).SetName("Employee (Operations) - MX Industrial Projects Assistant");
				yield return new TestCaseData("ZA Import Customs Clerk", Level.Employee, Area.Operations).SetName("Employee (Operations) - ZA Import Customs Clerk");
				yield return new TestCaseData("Custome Broker", Level.Employee, Area.Operations).SetName("Employee (Operations) - Custome Broker");
				yield return new TestCaseData("Air Import - Sr.Customer Service", Level.Employee, Area.Operations).SetName("Employee (Operations) - Air Import - Sr.Customer Service");

				yield return new TestCaseData("External Sales", Level.Employee, Area.SalesAndMarketing).SetName("Employee (Sales & Marketing) - External Sales");
				yield return new TestCaseData("Executive – Sales", Level.Employee, Area.SalesAndMarketing).SetName("Employee (Sales & Marketing) - Executive – Sales");
				yield return new TestCaseData("Sales Respresentative", Level.Employee, Area.SalesAndMarketing).SetName("Employee (Sales & Marketing) - Sales Respresentative");
				yield return new TestCaseData("inside sales (AFF)", Level.Employee, Area.SalesAndMarketing).SetName("Employee (Sales & Marketing) - inside sales (AFF)");
				yield return new TestCaseData("TN Sales NSM", Level.Employee, Area.SalesAndMarketing).SetName("Employee (Sales & Marketing) - TN Sales NSM");
				yield return new TestCaseData("CST (Calling Sales Rep)", Level.Employee, Area.SalesAndMarketing).SetName("Employee (Sales & Marketing) - CST (Calling Sales Rep)");

				yield return new TestCaseData("CNHKACT", Level.Employee, Area.Undefined).SetName("Employee (Undefined) - CNHKACT");
				yield return new TestCaseData("Non-TOC", Level.Employee, Area.Undefined).SetName("Employee (Undefined) - Non-TOC");
				yield return new TestCaseData("NDK WebTracker Notifications", Level.Employee, Area.Undefined).SetName("Employee (Undefined) - NDK WebTracker Notifications");
				yield return new TestCaseData("厦门分公司空运部经理", Level.Employee, Area.Undefined).SetName("Employee (Undefined) - 厦门分公司空运部经理");
				yield return new TestCaseData("Clasquin Group", Level.Employee, Area.Undefined).SetName("Employee (Undefined) - Clasquin Group");
				yield return new TestCaseData("L2F Support Notifications", Level.Employee, Area.Undefined).SetName("Employee (Undefined) - L2F Support Notifications");

				yield return new TestCaseData("Director, Educational Department", Level.Leadership, Area.Undefined).SetName("Leadership - Director, Educational Department");
				yield return new TestCaseData("Directeur Général BU Overseas", Level.Leadership, Area.Undefined).SetName("Leadership - Directeur Général BU Overseas");
				yield return new TestCaseData("Director of Security and Logistics", Level.Leadership, Area.Undefined).SetName("Leadership - Director of Security and Logistics");
				yield return new TestCaseData("Director Supply Chain Development", Level.Leadership, Area.Undefined).SetName("Leadership - Director Supply Chain Development");
				yield return new TestCaseData("Cad director (TRIEAGMIS)", Level.Leadership, Area.Undefined).SetName("Leadership - Cad director (TRIEAGMIS)");
				yield return new TestCaseData("Director of Operation", Level.Leadership, Area.Undefined).SetName("Leadership - Director of Operation");

				yield return new TestCaseData("HR & Admin. Supervisor", Level.Management, Area.Administration).SetName("Management (Administration) - HR & Admin. Supervisor");
				yield return new TestCaseData("Manager Finance and Administration", Level.Management, Area.Administration).SetName("Management (Administration) - Manager Finance and Administration");
				yield return new TestCaseData("Import Docs Team Leader", Level.Management, Area.Administration).SetName("Management (Administration) - Import Docs Team Leader");
				yield return new TestCaseData("ASST.MANAGER/SALES ADM&DEVELOPMENT", Level.Management, Area.Administration).SetName("Management (Administration) - ASST.MANAGER/SALES ADM&DEVELOPMENT");
				yield return new TestCaseData("Operations Supervisor (Document)", Level.Management, Area.Administration).SetName("Management (Administration) - Operations Supervisor (Document)");
				yield return new TestCaseData("Manager Oceanfreight Procurement", Level.Management, Area.Administration).SetName("Management (Administration) - Manager Oceanfreight Procurement");

				yield return new TestCaseData("NAD Accounts Manager", Level.Management, Area.Finance).SetName("Management (Finance) - NAD Accounts Manager");
				yield return new TestCaseData("Deputy Manager. - Key Accounts", Level.Management, Area.Finance).SetName("Management (Finance) - Deputy Manager. - Key Accounts");
				yield return new TestCaseData("DSV Account Manager", Level.Management, Area.Finance).SetName("Management (Finance) - DSV Account Manager");
				yield return new TestCaseData("JKM Japan Key Account Manager", Level.Management, Area.Finance).SetName("Management (Finance) - JKM Japan Key Account Manager");
				yield return new TestCaseData("CN Finance Supervisor", Level.Management, Area.Finance).SetName("Management (Finance) - CN Finance Supervisor");
				yield return new TestCaseData("Accounting Manager - MCO", Level.Management, Area.Finance).SetName("Management (Finance) - Accounting Manager - MCO");

				yield return new TestCaseData("Operational Supervisor", Level.Management, Area.Operations).SetName("Management (Operations) - Operational Supervisor");
				yield return new TestCaseData("Manager - Sea Imports", Level.Management, Area.Operations).SetName("Management (Operations) - Manager - Sea Imports");
				yield return new TestCaseData("CN Team Leader-Air", Level.Management, Area.Operations).SetName("Management (Operations) - CN Team Leader-Air");
				yield return new TestCaseData("Customs Supervisor - Customs Broker", Level.Management, Area.Operations).SetName("Management (Operations) - Customs Supervisor - Customs Broker");
				yield return new TestCaseData("OP Supervisor", Level.Management, Area.Operations).SetName("Management (Operations) - OP Supervisor");
				yield return new TestCaseData("Export Warehouse & Logistics MGR", Level.Management, Area.Operations).SetName("Management (Operations) - Export Warehouse & Logistics MGR");

				yield return new TestCaseData("BE National Sales Manager", Level.Management, Area.SalesAndMarketing).SetName("Management (Sales & Marketing) - BE National Sales Manager");
				yield return new TestCaseData("Assistant Sales Manager - JHB", Level.Management, Area.SalesAndMarketing).SetName("Management (Sales & Marketing) - Assistant Sales Manager - JHB");
				yield return new TestCaseData("Senior Sales (Team Leader)", Level.Management, Area.SalesAndMarketing).SetName("Management (Sales & Marketing) - Senior Sales (Team Leader)");
				yield return new TestCaseData("Sales & Mktg Manager", Level.Management, Area.SalesAndMarketing).SetName("Management (Sales & Marketing) - Sales & Mktg Manager");
				yield return new TestCaseData("SE National After Sales Manager", Level.Management, Area.SalesAndMarketing).SetName("Management (Sales & Marketing) - SE National After Sales Manager");
				yield return new TestCaseData("AFF - Sales Asst Division Manager", Level.Management, Area.SalesAndMarketing).SetName("Management (Sales & Marketing) - AFF - Sales Asst Division Manager");

				yield return new TestCaseData("Nadi Branch Manager", Level.Management, Area.Undefined).SetName("Management (Undefined) - Nadi Branch Manager");
				yield return new TestCaseData("SNM - SALES MANAGEMENT", Level.Management, Area.Undefined).SetName("Management (Undefined) - SNM - SALES MANAGEMENT");
				yield return new TestCaseData("Truckloads Manager", Level.Management, Area.Undefined).SetName("Management (Undefined) - Truckloads Manager");
				yield return new TestCaseData(" Develpoment Manager", Level.Management, Area.Undefined).SetName("Management (Undefined) -  Develpoment Manager");
				yield return new TestCaseData("Assistant Manager ITM", Level.Management, Area.Undefined).SetName("Management (Undefined) - Assistant Manager ITM");
				yield return new TestCaseData("NL Supervisor Retail", Level.Management, Area.Undefined).SetName("Management (Undefined) - NL Supervisor Retail");

				yield return new TestCaseData("Client Liaison Officer - Seafreight", Level.SeniorManagement, Area.Administration).SetName("Senior Management (Administration) - Client Liaison Officer - Seafreight");
				yield return new TestCaseData("EM CS Officer (Kuching)", Level.SeniorManagement, Area.Administration).SetName("Senior Management (Administration) - EM CS Officer (Kuching)");
				yield return new TestCaseData("T&W - Warehouse / Officer", Level.SeniorManagement, Area.Administration).SetName("Senior Management (Administration) - T&W - Warehouse / Officer");
				yield return new TestCaseData("South East Admin Officer", Level.SeniorManagement, Area.Administration).SetName("Senior Management (Administration) - South East Admin Officer");
				yield return new TestCaseData("Operations Officer-Air Frt", Level.SeniorManagement, Area.Administration).SetName("Senior Management (Administration) - Operations Officer-Air Frt");
				yield return new TestCaseData("Detention Officer", Level.SeniorManagement, Area.Administration).SetName("Senior Management (Administration) - Detention Officer");

				yield return new TestCaseData("Account Credit Controller SYD", Level.SeniorManagement, Area.Finance).SetName("Senior Management (Finance) - Account Credit Controller SYD");
				yield return new TestCaseData("HQ IP Finance Controller", Level.SeniorManagement, Area.Finance).SetName("Senior Management (Finance) - HQ IP Finance Controller");
				yield return new TestCaseData("Assistant Financial Controller", Level.SeniorManagement, Area.Finance).SetName("Senior Management (Finance) - Assistant Financial Controller");
				yield return new TestCaseData("Finance Manager/Controller", Level.SeniorManagement, Area.Finance).SetName("Senior Management (Finance) - Finance Manager/Controller");
				yield return new TestCaseData("Creditor Controller (Temp)", Level.SeniorManagement, Area.Finance).SetName("Senior Management (Finance) - Creditor Controller (Temp)");
				yield return new TestCaseData("Regional Financial Controller", Level.SeniorManagement, Area.Finance).SetName("Senior Management (Finance) - Regional Financial Controller");

				yield return new TestCaseData("VP & Controller", Level.SeniorManagement, Area.Operations).SetName("Senior Management (Operations) - VP & Controller");
				yield return new TestCaseData("Air Imports Forwarding Controller", Level.SeniorManagement, Area.Operations).SetName("Senior Management (Operations) - Air Imports Forwarding Controller");
				yield return new TestCaseData("Chief Advisor & V/P", Level.SeniorManagement, Area.Operations).SetName("Senior Management (Operations) - Chief Advisor & V/P");
				yield return new TestCaseData("Regional Head of IT", Level.SeniorManagement, Area.Operations).SetName("Senior Management (Operations) - Regional Head of IT");
				yield return new TestCaseData("V.P. IMPORTS", Level.SeniorManagement, Area.Operations).SetName("Senior Management (Operations) - V.P. IMPORTS");
				yield return new TestCaseData("Airfreight Import Controller / Oper", Level.SeniorManagement, Area.Operations).SetName("Senior Management (Operations) - Airfreight Import Controller / Oper");

				yield return new TestCaseData("VP of Sales & Business Development", Level.SeniorManagement, Area.SalesAndMarketing).SetName("Senior Management (Sales & Marketing) - VP of Sales & Business Development");
				yield return new TestCaseData("Head Of Sales Malaysia", Level.SeniorManagement, Area.SalesAndMarketing).SetName("Senior Management (Sales & Marketing) - Head Of Sales Malaysia");
				yield return new TestCaseData("Head of Marketing & Sales, Greater", Level.SeniorManagement, Area.SalesAndMarketing).SetName("Senior Management (Sales & Marketing) - Head of Marketing & Sales, Greater");
				yield return new TestCaseData("Executive VP of Sales", Level.SeniorManagement, Area.SalesAndMarketing).SetName("Senior Management (Sales & Marketing) - Executive VP of Sales");

				yield return new TestCaseData("Acting Head Teacher", Level.SeniorManagement, Area.Undefined).SetName("Senior Management (Undefined) - Acting Head Teacher");
				yield return new TestCaseData("Sr.Branch Manager/Branch Head(Mumba", Level.SeniorManagement, Area.Undefined).SetName("Senior Management (Undefined) - Sr.Branch Manager/Branch Head(Mumba");
				yield return new TestCaseData("Head", Level.SeniorManagement, Area.Undefined).SetName("Senior Management (Undefined) - Head");
				yield return new TestCaseData("Aeroparts Controller", Level.SeniorManagement, Area.Undefined).SetName("Senior Management (Undefined) - Aeroparts Controller");
				yield return new TestCaseData("Chief Representative", Level.SeniorManagement, Area.Undefined).SetName("Senior Management (Undefined) - Chief Representative");
				yield return new TestCaseData("Station Manager, President Containe", Level.SeniorManagement, Area.Undefined).SetName("Senior Management (Undefined) - Station Manager, President Containe");
			}

		}

		public class MyDataClass
		{
			public static IEnumerable TestCases
			{
				get
				{
					yield return new TestCaseData(12, 3).SetName("12 divided by 3").Returns(4);
					yield return new TestCaseData(12, 2).SetName("12/2").Returns(6);
					yield return new TestCaseData(12, 4).SetName("12 divided by (4)").Returns(3);
				}
			}
		}
	}
}