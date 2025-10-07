using quidgest.uitests.pages.forms.core;

#nullable enable

namespace quidgest.uitests.pages.forms;

[System.CodeDom.Compiler.GeneratedCode("Genio", "")]
public class Fr_001Form : Form
{
	/// <summary>
	/// Profile Photo
	/// </summary>
	public BaseInputControl T_001F_004 => new BaseInputControl(driver, ContainerLocator, "container-FR_001__T_001F_004___", "#FR_001__T_001F_004___");

	/// <summary>
	/// Name
	/// </summary>
	public BaseInputControl T_001F_001 => new BaseInputControl(driver, ContainerLocator, "container-FR_001__T_001F_001___", "#FR_001__T_001F_001___");

	/// <summary>
	/// Email
	/// </summary>
	public BaseInputControl T_001F_002 => new BaseInputControl(driver, ContainerLocator, "container-FR_001__T_001F_002___", "#FR_001__T_001F_002___");

	/// <summary>
	/// Date of Birth
	/// </summary>
	public DateInputControl T_001F_003 => new DateInputControl(driver, ContainerLocator, "#FR_001__T_001F_003___");

	/// <summary>
	/// Telephone
	/// </summary>
	public BaseInputControl T_001F_005 => new BaseInputControl(driver, ContainerLocator, "container-FR_001__T_001F_005___", "#FR_001__T_001F_005___");

	public Fr_001Form(IWebDriver driver, FORM_MODE mode, By? containerLocator = null)
		: base(driver, mode, "FR_001", containerLocator: containerLocator) { }
}
