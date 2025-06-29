using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[UEnum]
[UMetaPath("/Script/LiveLinkInterface.ELiveLinkSourceMode", "LiveLinkInterface", UnrealModuleType.Engine)]
public enum ELiveLinkSourceMode
{
	Latest,
	EngineTime,
	Timecode
}
