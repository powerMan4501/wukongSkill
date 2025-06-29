using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SlateCore.EGSSoftShadowType", "SlateCore", UnrealModuleType.Engine)]
public enum EGSSoftShadowType : byte
{
	EGSSoftShadowNone,
	EGSSoftShadowBlur,
	EGSSoftShadowDistanceField,
	EGSSoftShadowDistanceField_BySum,
	EGSSoftShadowShader,
	EGSSoftShadowHard
}
