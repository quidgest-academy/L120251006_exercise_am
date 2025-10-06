using quidgest.uitests.pages.forms.core;

#nullable enable

namespace quidgest.uitests.pages.forms;

[System.CodeDom.Compiler.GeneratedCode("Genio", "")]
public class F_001Form : Form
{
	/// <summary>
	/// Username
	/// </summary>
	public BaseInputControl U_prfUsername => new BaseInputControl(driver, ContainerLocator, "container-F_001___U_PRFUSERNAME", "#F_001___U_PRFUSERNAME");

	/// <summary>
	/// Date of Birth
	/// </summary>
	public DateInputControl U_prfBday => new DateInputControl(driver, ContainerLocator, "#F_001___U_PRFBDAY____");

	/// <summary>
	/// Image
	/// </summary>
	public BaseInputControl U_prfU_img => new BaseInputControl(driver, ContainerLocator, "container-F_001___U_PRFU_IMG___", "#F_001___U_PRFU_IMG___");

	/// <summary>
	/// Email
	/// </summary>
	public BaseInputControl U_prfU_email => new BaseInputControl(driver, ContainerLocator, "container-F_001___U_PRFU_EMAIL_", "#F_001___U_PRFU_EMAIL_");

	public F_001Form(IWebDriver driver, FORM_MODE mode, By? containerLocator = null)
		: base(driver, mode, "F_001", containerLocator: containerLocator) { }
}
