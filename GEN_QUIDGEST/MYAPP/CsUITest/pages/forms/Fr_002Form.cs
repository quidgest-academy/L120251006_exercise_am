using quidgest.uitests.pages.forms.core;

#nullable enable

namespace quidgest.uitests.pages.forms;

[System.CodeDom.Compiler.GeneratedCode("Genio", "")]
public class Fr_002Form : Form
{
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

	public Fr_002Form(IWebDriver driver, FORM_MODE mode, By? containerLocator = null)
		: base(driver, mode, "FR_002", containerLocator: containerLocator) { }
}
