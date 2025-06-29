using System.Collections.Generic;
using CsB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUITStrangeBox : BUInteractTypeTemplate
{
	public BUITStrangeBox()
	{
		PreCheckBehaviorArr = new EPreCheckBehavior[2]
		{
			EPreCheckBehavior.NotInBattle,
			EPreCheckBehavior.NotInTransforming
		};
	}

	public override bool TriggerInteractInput(int InteractiveActorID, AActor User, AActor InteractiveActor)
	{
		BTF_EventCollectionCS bTF_EventCollectionCS = BTF_EventCollectionCS.Get((User as BGUPlayerCharacterCS).PlayerState);
		if (bTF_EventCollectionCS != null)
		{
			CSMsgBagMultiplayerDropReq cSMsgBagMultiplayerDropReq = new CSMsgBagMultiplayerDropReq();
			List<APlayerController> allPlayerControllers = BGU_UnrealWorldUtil.GetAllPlayerControllers(User.World);
			int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.OnelineLotteryDistance);
			foreach (APlayerController item in allPlayerControllers)
			{
				if (item.GetControlledPawn() != null && FVector.Distance(InteractiveActor.GetActorLocation(), item.GetControlledPawn().GetActorLocation()) < (float)commLogicCfgValue)
				{
					BPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(item);
					if (readOnlyData != null)
					{
						ulong roleid = readOnlyData.RoleData.RoleCs.Base.Roleid;
						cSMsgBagMultiplayerDropReq.NearbyPlayers.Add(roleid);
					}
				}
			}
			cSMsgBagMultiplayerDropReq.MultiplayerDropId = 1;
			bTF_EventCollectionCS.Evt_BagMultiplayerDropReq(cSMsgBagMultiplayerDropReq, delegate(MsgErrCode ErrCode, CSMsgBagMultiplayerDropReq Req, CSMsgBagMultiplayerDropRes Res)
			{
				if (ErrCode == MsgErrCode.ErrSuccess)
				{
					BGW_LogUtil.LogError($"[interactcomp] BUITStrangeBox IsSpecialDrop = {Res.IsSpecialDrop == YesNoType.Yes}");
					BPC_PlayerInteractData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BPC_PlayerInteractData>((User as APawn).PlayerState);
					if (readOnlyData2 != null)
					{
						readOnlyData2.TmpIsSpDrop = Res.IsSpecialDrop == YesNoType.Yes;
					}
				}
			});
		}
		return true;
	}

	public override bool BreakInteractInput(int InteractiveActorID, AActor User, AActor InteractiveActor)
	{
		return true;
	}

	public override bool FinishInteractInput(int InteractiveActorID, AActor User, AActor InteractiveActor)
	{
		return true;
	}

	public override bool BreakInteract(int InteractiveActorID, AActor User, AActor InteractiveActor)
	{
		FinishInteract(InteractiveActorID, User, InteractiveActor);
		return true;
	}
}
