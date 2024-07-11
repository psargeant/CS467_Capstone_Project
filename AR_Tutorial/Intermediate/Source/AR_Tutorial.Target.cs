using UnrealBuildTool;

public class AR_TutorialTarget : TargetRules
{
	public AR_TutorialTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("AR_Tutorial");
	}
}
