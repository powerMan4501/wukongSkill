using UnrealEngine.Runtime;

namespace UnrealEngine.DeveloperToolSettings;

[UEnum]
[UMetaPath("/Script/DeveloperToolSettings.EProjectPackagingBuild", "DeveloperToolSettings", UnrealModuleType.Engine)]
public enum EProjectPackagingBuild
{
	Always,
	Never,
	IfProjectHasCode,
	IfEditorWasBuiltLocally
}
