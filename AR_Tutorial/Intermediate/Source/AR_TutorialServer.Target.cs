using UnrealBuildTool;

public class AR_TutorialServerTarget : TargetRules
{
	public AR_TutorialServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("AR_Tutorial");
	}
}
