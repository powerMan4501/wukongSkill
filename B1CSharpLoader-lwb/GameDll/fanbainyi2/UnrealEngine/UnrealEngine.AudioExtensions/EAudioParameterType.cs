using UnrealEngine.Runtime;

namespace UnrealEngine.AudioExtensions;

[UEnum]
[UMetaPath("/Script/AudioExtensions.EAudioParameterType", "AudioExtensions", UnrealModuleType.Engine)]
public enum EAudioParameterType
{
	None,
	Boolean,
	Integer,
	Float,
	String,
	Object,
	NoneArray,
	BooleanArray,
	IntegerArray,
	FloatArray,
	StringArray,
	ObjectArray,
	COUNT
}
