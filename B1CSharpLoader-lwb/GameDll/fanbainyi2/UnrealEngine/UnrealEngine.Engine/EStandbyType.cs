using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EStandbyType", "Engine", UnrealModuleType.Engine)]
public enum EStandbyType
{
	STDBY_Rx,
	STDBY_Tx,
	STDBY_BadPing
}
