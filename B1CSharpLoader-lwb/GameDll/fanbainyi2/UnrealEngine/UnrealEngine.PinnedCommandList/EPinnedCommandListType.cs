using UnrealEngine.Runtime;

namespace UnrealEngine.PinnedCommandList;

[UEnum]
[UMetaPath("/Script/PinnedCommandList.EPinnedCommandListType", "PinnedCommandList", UnrealModuleType.Engine)]
public enum EPinnedCommandListType
{
	Command,
	CustomWidget
}
