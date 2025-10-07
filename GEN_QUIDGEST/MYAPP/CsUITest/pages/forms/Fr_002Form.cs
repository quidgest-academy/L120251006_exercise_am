using quidgest.uitests.pages.forms.core;

#nullable enable

namespace quidgest.uitests.pages.forms;

[System.CodeDom.Compiler.GeneratedCode("Genio", "")]
public class Fr_002Form : Form
{
	/// <summary>
	/// Main Infos
	/// </summary>
	public CollapsibleZoneControl PseudNewgrp01 => new CollapsibleZoneControl(driver, ContainerLocator, "#FR_002__PSEUDNEWGRP01-container");

	/// <summary>
	/// Property Photo
	/// </summary>
	public BaseInputControl T_002F_001 => new BaseInputControl(driver, ContainerLocator, "container-FR_002__T_002F_001___", "#FR_002__T_002F_001___");

	/// <summary>
	/// Property Title
	/// </summary>
	public BaseInputControl T_002F_002 => new BaseInputControl(driver, ContainerLocator, "container-FR_002__T_002F_002___", "#FR_002__T_002F_002___");

	/// <summary>
	/// Property Price
	/// </summary>
	public BaseInputControl T_002F_003 => new BaseInputControl(driver, ContainerLocator, "container-FR_002__T_002F_003___", "#FR_002__T_002F_003___");

	/// <summary>
	/// New Group
	/// </summary>
	public IWebElement PseudNewgrp05 => throw new NotImplementedException();

	/// <summary>
	/// Localization
	/// </summary>
	public CollapsibleZoneControl PseudNewgrp02 => new CollapsibleZoneControl(driver, ContainerLocator, "#FR_002__PSEUDNEWGRP02-container");

	/// <summary>
	/// City
	/// </summary>
	public LookupControl T_004F_001 => new LookupControl(driver, ContainerLocator, "container-FR_002__T_004F_001___");
	public SeeMorePage T_004F_001SeeMorePage => new SeeMorePage(driver, "FR_002", "FR_002__T_004F_001___");

	/// <summary>
	/// Country Name
	/// </summary>
	public IWebElement T_003F_001 => throw new NotImplementedException();

	/// <summary>
	/// Details
	/// </summary>
	public CollapsibleZoneControl PseudNewgrp03 => new CollapsibleZoneControl(driver, ContainerLocator, "#FR_002__PSEUDNEWGRP03-container");

	/// <summary>
	/// Year Built
	/// </summary>
	public BaseInputControl T_002F_009 => new BaseInputControl(driver, ContainerLocator, "container-FR_002__T_002F_009___", "#FR_002__T_002F_009___");

	/// <summary>
	/// Size
	/// </summary>
	public BaseInputControl T_002F_007 => new BaseInputControl(driver, ContainerLocator, "container-FR_002__T_002F_007___", "#FR_002__T_002F_007___");

	/// <summary>
	/// Bathroums Number
	/// </summary>
	public BaseInputControl T_002F_008 => new BaseInputControl(driver, ContainerLocator, "container-FR_002__T_002F_008___", "#FR_002__T_002F_008___");

	/// <summary>
	/// Agent
	/// </summary>
	public CollapsibleZoneControl PseudNewgrp04 => new CollapsibleZoneControl(driver, ContainerLocator, "#FR_002__PSEUDNEWGRP04-container");

	/// <summary>
	/// Email
	/// </summary>
	public LookupControl T_001F_002 => new LookupControl(driver, ContainerLocator, "container-FR_002__T_001F_002___");
	public SeeMorePage T_001F_002SeeMorePage => new SeeMorePage(driver, "FR_002", "FR_002__T_001F_002___");

	/// <summary>
	/// Name
	/// </summary>
	public IWebElement T_001F_001 => throw new NotImplementedException();

	/// <summary>
	/// Profile Photo
	/// </summary>
	public IWebElement T_001F_004 => throw new NotImplementedException();

	public Fr_002Form(IWebDriver driver, FORM_MODE mode, By? containerLocator = null)
		: base(driver, mode, "FR_002", containerLocator: containerLocator) { }
}
