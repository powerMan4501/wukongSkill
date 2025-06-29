using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.ScreenMsgType")]
public enum EScreenMsgType : byte
{
	PlayerDead,
	DeadCountChange,
	TriggerLevelEvent,
	UseLevelItem,
	TeamerDisconnected,
	Connecting,
	TeamerConnecting,
	TeamerConnected,
	TeamerJoin
}
