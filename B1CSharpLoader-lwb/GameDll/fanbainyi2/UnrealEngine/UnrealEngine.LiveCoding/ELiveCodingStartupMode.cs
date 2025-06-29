using UnrealEngine.Runtime;

namespace UnrealEngine.LiveCoding;

[UEnum]
[UMetaPath("/Script/LiveCoding.ELiveCodingStartupMode", "LiveCoding", UnrealModuleType.Engine)]
public enum ELiveCodingStartupMode
{
	Automatic,
	AutomaticButHidden,
	Manual
}
