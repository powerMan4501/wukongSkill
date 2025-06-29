using BtlShare;
using CommB1;
using CsB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BUS_AttrRpcReportComp : UActorCompBaseCS
{
	private BUC_AttrContainer AttrContainerData;

	public override void OnAttach()
	{
		AttrContainerData = RequireWritableData<BUC_AttrContainer>();
		AttrContainerData.FloatAttrs.BindOnSetIdxValue(OnBindOnSetIdxValueChange);
	}

	private void OnBindOnSetIdxValueChange(int AttrId, float OldValue, float NewValue)
	{
		switch (AttrId)
		{
		case 198:
			SendRPC(EBGUAttrFloat.ExpDropAddition, NewValue);
			break;
		case 199:
			SendRPC(EBGUAttrFloat.SpiritDropAddition, NewValue);
			break;
		case 203:
			SendRPC(EBGUAttrFloat.CommDropAddition, NewValue);
			break;
		}
	}

	private void SendRPC(EBGUAttrFloat AttrFloat, float NewValue)
	{
		APlayerState aPlayerState = (GetOwner() as ABGUCharacter)?.PlayerState;
		if (!(aPlayerState == null))
		{
			BTF_EventCollectionCS bTF_EventCollectionCS = BTF_EventCollectionCS.Get(aPlayerState);
			if (bTF_EventCollectionCS != null)
			{
				CSMsgAttrChangeNotifyReq cSMsgAttrChangeNotifyReq = new CSMsgAttrChangeNotifyReq();
				EffectAttrFloat effectAttrFloat = new EffectAttrFloat();
				effectAttrFloat.Type = AttrFloat;
				effectAttrFloat.Value = NewValue;
				cSMsgAttrChangeNotifyReq.AttrList.Add(effectAttrFloat);
				bTF_EventCollectionCS.Evt_AttrChangeNotifyReq(cSMsgAttrChangeNotifyReq, null, aPlayerState, AllPlayer: false);
			}
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		AttrContainerData.FloatAttrs.UnBindOnSetIdxValue(OnBindOnSetIdxValueChange);
	}
}
