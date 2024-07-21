using UnrealBuildTool;

public class Capstone_UserShipClientTarget : TargetRules
{
	public Capstone_UserShipClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Capstone_UserShip");
	}
}
