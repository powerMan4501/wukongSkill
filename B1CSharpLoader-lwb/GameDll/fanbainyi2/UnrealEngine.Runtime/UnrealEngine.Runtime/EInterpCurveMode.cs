namespace UnrealEngine.Runtime;

[UEnum]
[UMetaPath("/Script/CoreUObject.EInterpCurveMode", "CoreUObject", UnrealModuleType.Engine)]
public enum EInterpCurveMode : byte
{
	Linear,
	CurveAuto,
	Constant,
	CurveUser,
	CurveBreak,
	CurveAutoClamped,
	Unknown
}
