using UnrealBuildTool;

public class Capstone_UserShipEditorTarget : TargetRules
{
	public Capstone_UserShipEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Capstone_UserShip");
	}
}
