using UnrealBuildTool;

public class Capstone_UserShipTarget : TargetRules
{
	public Capstone_UserShipTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Capstone_UserShip");
	}
}
