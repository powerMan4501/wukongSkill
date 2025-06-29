using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EPlayOnBuildMode", "UnrealEd", UnrealModuleType.Engine)]
public enum EPlayOnBuildMode
{
	PlayOnBuild_Always,
	PlayOnBuild_Never,
	PlayOnBuild_Default,
	PlayOnBuild_IfEditorBuiltLocally
}
