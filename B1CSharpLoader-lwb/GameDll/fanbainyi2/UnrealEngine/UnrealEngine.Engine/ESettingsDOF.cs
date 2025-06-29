using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ESettingsDOF", "Engine", UnrealModuleType.Engine)]
public enum ESettingsDOF
{
	Full3D,
	YZPlane,
	XZPlane,
	XYPlane
}
