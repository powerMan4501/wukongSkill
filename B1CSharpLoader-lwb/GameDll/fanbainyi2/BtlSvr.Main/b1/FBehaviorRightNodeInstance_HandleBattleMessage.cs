using CommB1;
using Diana.Common;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public class FBehaviorRightNodeInstance_HandleBattleMessage : FBehaviorRightNodeInstance
{
	public override string NodeName => B1CalliopeDef.BehaviorNode.HandleBattleMessage;

	public BehaviorCustom_HandleBattleMessage CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_HandleBattleMessage();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	protected override void TriggerInput(string InputPin)
	{
		FGameplayTag p = GameplayTagExtension.MakeGameplayTag(CustomData.MessageContent);
		base.BUSEventCollection.Evt_HandleBattleMessage.Invoke(p);
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(base.Owner, EBattleInfoType.CSGDebug, $"<character>{base.Owner.GetName().ConvertLongGuid2DisplayGuid()}</><effect>【CSGDEBUG】</><action> 通过CBG发起了BattleMessage </><effectnum>{p.TagName}</>");
		}
	}
}
