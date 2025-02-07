using UnrealBuildTool;

public class ClownkantoorServerTarget : TargetRules
{
	public ClownkantoorServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Clownkantoor");
	}
}
