using UnrealBuildTool;

public class ClownkantoorEditorTarget : TargetRules
{
	public ClownkantoorEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Clownkantoor");
	}
}
