using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCRequesterIdentity")]
public enum DispLibDBCRequesterIdentity : byte
{
	Notify,
	NotifyState,
	UENativeComp,
	GSECS_BUSComp,
	GSECS_BWSComp,
	DBCDataAsset
}
