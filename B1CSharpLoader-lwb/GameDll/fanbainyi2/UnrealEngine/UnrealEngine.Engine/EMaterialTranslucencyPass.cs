using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMaterialTranslucencyPass", "Engine", UnrealModuleType.Engine)]
public enum EMaterialTranslucencyPass
{
	MTP_BeforeDOF,
	MTP_AfterDOF,
	MTP_AfterMotionBlur
}
