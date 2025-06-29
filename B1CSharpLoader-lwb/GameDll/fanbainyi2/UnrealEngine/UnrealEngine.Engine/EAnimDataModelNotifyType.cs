using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EAnimDataModelNotifyType", "Engine", UnrealModuleType.Engine)]
public enum EAnimDataModelNotifyType : byte
{
	BracketOpened,
	BracketClosed,
	TrackAdded,
	TrackChanged,
	TrackRemoved,
	SequenceLengthChanged,
	FrameRateChanged,
	CurveAdded,
	CurveChanged,
	CurveRemoved,
	CurveFlagsChanged,
	CurveRenamed,
	CurveScaled,
	CurveColorChanged,
	AttributeAdded,
	AttributeRemoved,
	AttributeChanged,
	Populated,
	Reset,
	Invalid
}
