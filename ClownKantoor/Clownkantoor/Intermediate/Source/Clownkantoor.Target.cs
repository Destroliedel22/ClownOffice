using UnrealBuildTool;

public class ClownkantoorTarget : TargetRules
{
	public ClownkantoorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Clownkantoor");
	}
}
