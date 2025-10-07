using quidgest.uitests.pages.forms.core;

#nullable enable

namespace quidgest.uitests.pages.forms;

[System.CodeDom.Compiler.GeneratedCode("Genio", "")]
public class Fr_005Form : Form
{
	/// <summary>
	/// Photo
	/// </summary>
	public BaseInputControl T_006F_001 => new BaseInputControl(driver, ContainerLocator, "container-FR_005__T_006F_001___", "#FR_005__T_006F_001___");

	/// <summary>
	/// Description
	/// </summary>
	public BaseInputControl T_006F_002 => new BaseInputControl(driver, ContainerLocator, "container-FR_005__T_006F_002___", "#FR_005__T_006F_002___");

	/// <summary>
	/// Property Title
	/// </summary>
	public LookupControl T_002F_002 => new LookupControl(driver, ContainerLocator, "container-FR_005__T_002F_002___");
	public SeeMorePage T_002F_002SeeMorePage => new SeeMorePage(driver, "FR_005", "FR_005__T_002F_002___");

	public Fr_005Form(IWebDriver driver, FORM_MODE mode, By? containerLocator = null)
		: base(driver, mode, "FR_005", containerLocator: containerLocator) { }
}
