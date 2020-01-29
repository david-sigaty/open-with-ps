using UnityEditor;
using TeamCitrus.Editor;

public class OpenWithPs : OpenWithMenuItem
{
	public const string Name = "Photoshop";
	public const string Key = BaseKey + Name;
	private const string MenuItemPath = BasePath + Name;
	
	[MenuItem(MenuItemPath, false, BasePriority + 50)]
	public static void Open() { Execute<OpenWithPs>(); }

	[MenuItem(MenuItemPath, true)]
	public static bool OpenValidation() { return Validate<OpenWithPs>(); }
}
