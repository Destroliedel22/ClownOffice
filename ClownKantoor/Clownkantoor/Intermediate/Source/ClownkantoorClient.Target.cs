using UnrealBuildTool;

public class ClownkantoorClientTarget : TargetRules
{
	public ClownkantoorClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Clownkantoor");
	}
}
