using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ENormalMode", "Engine", UnrealModuleType.Engine)]
public enum ENormalMode
{
	NM_PreserveSmoothingGroups,
	NM_RecalculateNormals,
	NM_RecalculateNormalsSmooth,
	NM_RecalculateNormalsHard,
	TEMP_BROKEN
}
