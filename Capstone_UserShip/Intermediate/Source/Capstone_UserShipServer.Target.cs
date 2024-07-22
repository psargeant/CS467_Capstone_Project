using UnrealBuildTool;

public class Capstone_UserShipServerTarget : TargetRules
{
	public Capstone_UserShipServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Capstone_UserShip");
	}
}
