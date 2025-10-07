using quidgest.uitests.pages.forms.core;

#nullable enable

namespace quidgest.uitests.pages.forms;

[System.CodeDom.Compiler.GeneratedCode("Genio", "")]
public class Fr_006Form : Form
{
	/// <summary>
	/// Date
	/// </summary>
	public DateInputControl T_005F_001 => new DateInputControl(driver, ContainerLocator, "#FR_006__T_005F_001___");

	/// <summary>
	/// Client Name
	/// </summary>
	public BaseInputControl T_005F_002 => new BaseInputControl(driver, ContainerLocator, "container-FR_006__T_005F_002___", "#FR_006__T_005F_002___");

	/// <summary>
	/// Email Contact
	/// </summary>
	public BaseInputControl T_005F_003 => new BaseInputControl(driver, ContainerLocator, "container-FR_006__T_005F_003___", "#FR_006__T_005F_003___");

	/// <summary>
	/// Phone Contact
	/// </summary>
	public BaseInputControl T_005F_004 => new BaseInputControl(driver, ContainerLocator, "container-FR_006__T_005F_004___", "#FR_006__T_005F_004___");

	/// <summary>
	/// Description
	/// </summary>
	public BaseInputControl T_005F_005 => new BaseInputControl(driver, ContainerLocator, "container-FR_006__T_005F_005___", "#FR_006__T_005F_005___");

	/// <summary>
	/// Property Title
	/// </summary>
	public LookupControl T_002F_002 => new LookupControl(driver, ContainerLocator, "container-FR_006__T_002F_002___");
	public SeeMorePage T_002F_002SeeMorePage => new SeeMorePage(driver, "FR_006", "FR_006__T_002F_002___");

	public Fr_006Form(IWebDriver driver, FORM_MODE mode, By? containerLocator = null)
		: base(driver, mode, "FR_006", containerLocator: containerLocator) { }
}
