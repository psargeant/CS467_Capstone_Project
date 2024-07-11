using UnrealBuildTool;

public class AR_TutorialEditorTarget : TargetRules
{
	public AR_TutorialEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("AR_Tutorial");
	}
}
