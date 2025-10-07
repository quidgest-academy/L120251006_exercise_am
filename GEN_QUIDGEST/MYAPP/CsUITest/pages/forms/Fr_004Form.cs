using quidgest.uitests.pages.forms.core;

#nullable enable

namespace quidgest.uitests.pages.forms;

[System.CodeDom.Compiler.GeneratedCode("Genio", "")]
public class Fr_004Form : Form
{
	/// <summary>
	/// City
	/// </summary>
	public BaseInputControl T_004F_001 => new BaseInputControl(driver, ContainerLocator, "container-FR_004__T_004F_001___", "#FR_004__T_004F_001___");

	/// <summary>
	/// Country Name
	/// </summary>
	public LookupControl T_003F_001 => new LookupControl(driver, ContainerLocator, "container-FR_004__T_003F_001___");
	public SeeMorePage T_003F_001SeeMorePage => new SeeMorePage(driver, "FR_004", "FR_004__T_003F_001___");

	public Fr_004Form(IWebDriver driver, FORM_MODE mode, By? containerLocator = null)
		: base(driver, mode, "FR_004", containerLocator: containerLocator) { }
}
