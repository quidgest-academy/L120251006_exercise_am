using quidgest.uitests.pages.forms.core;

#nullable enable

namespace quidgest.uitests.pages.forms;

[System.CodeDom.Compiler.GeneratedCode("Genio", "")]
public class Fr_003Form : Form
{
	/// <summary>
	/// Country Name
	/// </summary>
	public BaseInputControl T_003F_001 => new BaseInputControl(driver, ContainerLocator, "container-FR_003__T_003F_001___", "#FR_003__T_003F_001___");

	public Fr_003Form(IWebDriver driver, FORM_MODE mode, By? containerLocator = null)
		: base(driver, mode, "FR_003", containerLocator: containerLocator) { }
}
