using UnrealEngine.Runtime;

namespace UnrealEngine.InterchangeCore;

[UEnum]
[UMetaPath("/Script/InterchangeCore.EInterchangeResultType", "InterchangeCore", UnrealModuleType.Engine)]
public enum EInterchangeResultType
{
	Success,
	Warning,
	Error
}
