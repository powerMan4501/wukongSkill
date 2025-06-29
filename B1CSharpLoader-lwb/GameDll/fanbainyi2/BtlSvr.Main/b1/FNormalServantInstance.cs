using b1.BGW;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FNormalServantInstance : FServantInstanceBase
{
	public EServantSearchTargetType SearchTargetType { get; set; }

	public FNormalServantInstance(FServantReq InReq)
		: base(InReq)
	{
		SearchTargetType = InReq.SearchTargetType;
	}

	protected override void AfterUnitBeginPlay()
	{
		base.AfterUnitBeginPlay();
		BGUCharacterCS bGUCharacterCS = base.ServantTamerRef.MonsterInstancePtr.Get();
		if (bGUCharacterCS == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
		if (!(bUS_GSEventCollection == null))
		{
			ETargetSourceType sourceType = ETargetSourceType.None;
			switch (SearchTargetType)
			{
			case EServantSearchTargetType.CatchPlayer:
				sourceType = ETargetSourceType.Target_BirthCatchPlayer;
				break;
			case EServantSearchTargetType.SyncMaster:
				sourceType = ETargetSourceType.Target_BirthCatchMasterTarget;
				break;
			case EServantSearchTargetType.SyncSummoner:
				sourceType = ETargetSourceType.Target_BirthCatchMasterTarget;
				break;
			}
			if (ServantReq.CatchTarget != null)
			{
				base.ServantEventCollection.Evt_AICatchTarget.Invoke(ServantReq.CatchTarget, sourceType);
			}
			bool p = false;
			if (ServantReq.BornMontage != null)
			{
				BGUFuncLibAnim.BGUActorTryPlayMontage(bGUCharacterCS, ServantReq.BornMontage, FName.None, EMontageBindReason.Born);
				base.AliveTime = ((base.AliveTime < 0f) ? base.AliveTime : (base.AliveTime + UBGUFunctionLibrary.BGUGetMontageSectionLengthByIndex(bGUCharacterCS, ServantReq.BornMontage, 0)));
				p = true;
			}
			else if (ServantReq.BornSkill > 0)
			{
				base.ServantEventCollection.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(ServantReq.BornSkill, ECastSkillSourceType.SummonBorn)
				{
					Reason = EMontageBindReason.Born,
					NeedCheckSkillCanCast = false
				});
				FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(ServantReq.BornSkill, base.ServantUnitPtr.Get());
				UAnimMontage animMontage = BGW_PreloadAssetMgr.Get(base.Owner).TryGetCachedResourceObj<UAnimMontage>(skillSDesc.TemplatePath, ELoadResourceType.SyncLoadAndCache);
				base.AliveTime = ((base.AliveTime < 0f) ? base.AliveTime : (base.AliveTime + UBGUFunctionLibrary.BGUGetMontageSectionLengthByIndex(bGUCharacterCS, animMontage, 0)));
				p = true;
			}
			bUS_GSEventCollection.Evt_NotifyPlayBornAnim.Invoke(p);
			if (!string.IsNullOrEmpty(ServantReq.CooperativeSCGuid))
			{
				bUS_GSEventCollection.Evt_RegisterBattleSC.Invoke(ServantReq.CooperativeSCGuid);
			}
			if (ServantReq.AttrSnapShot != null && ServantReq.AttrSnapShot.Count > 0)
			{
				FAttrSnapShot attrSnapShot = new FAttrSnapShot(ServantReq.AttrSnapShot)
				{
					AttrCopyConfigDesc = FUStAttrCopyConfigDesc.Parser.ParseFrom(ServantReq.AttrCopyConfigDesc.ToArray())
				};
				base.ServantEventCollection.Evt_RequestCopyAttrFromSnapshot.Invoke(attrSnapShot);
			}
		}
	}
}
