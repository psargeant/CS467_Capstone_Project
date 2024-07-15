using UnrealBuildTool;

public class AR_TutorialClientTarget : TargetRules
{
	public AR_TutorialClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("AR_Tutorial");
	}
}
