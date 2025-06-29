using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class QuestNodeInstance_PlayerUseItem : QuestNodeInstance
{
	private int ItemID;

	protected override void PostCreate()
	{
		QuestCustom_PlayerUseItem questCustom_PlayerUseItem = new QuestCustom_PlayerUseItem();
		questCustom_PlayerUseItem.MergeFrom(base.Node.NodeData);
		ItemID = questCustom_PlayerUseItem.ItemId;
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
	}

	public override void Tick(float DeltaTime)
	{
		base.Tick(DeltaTime);
		PlayerTryUseItem();
	}

	private bool OnCheckHasItem(ACharacter Player, int ItemID)
	{
		IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(Player.GetController());
		if (readOnlyData == null && readOnlyData.RoleData != null)
		{
			return false;
		}
		return RoleDataHelper.GetBagItemNum(readOnlyData, ItemID) > 0;
	}

	private void PlayerTryUseItem()
	{
		BGU_CommonUtil.GetCurrentPlayer(base.Owner, out var Player);
		if (!(Player == null))
		{
			if (!OnCheckHasItem(Player, ItemID))
			{
				TriggerOutput(BGW_FlowUtils.PinName.Failed.ToString(), bFinish: true);
			}
			if (!BGUFunctionLibraryCS.BGUHasUnitState(Player, EBGUUnitState.Attacking))
			{
				BUS_EventCollectionCS.Get(Player).Evt_TriggerItemSkillAction_UseItem.Invoke(ItemID);
				TriggerOutput(BGW_FlowUtils.PinName.Success.ToString(), bFinish: true);
			}
		}
	}

	public override byte[] GetNodeCustomData()
	{
		return new byte[0];
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
		TriggerFirstOutput(bFinish: true);
	}
}
