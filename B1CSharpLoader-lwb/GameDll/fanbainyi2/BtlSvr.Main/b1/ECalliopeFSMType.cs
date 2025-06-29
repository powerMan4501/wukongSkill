using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.CalliopeFSMType")]
public enum ECalliopeFSMType : byte
{
	GI_Global,
	GI_Loading,
	PS_Transaction
}
