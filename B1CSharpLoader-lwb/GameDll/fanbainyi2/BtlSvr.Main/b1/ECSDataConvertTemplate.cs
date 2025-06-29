using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class ECSDataConvertTemplate : ECSDataInitTemplate
{
	public ECSDataConvertTemplate(Entity InitEntity, int NetRoleFilter)
		: base(InitEntity, NetRoleFilter)
	{
	}

	public override void InitDataLateBeginPlay()
	{
		DoDataConvert(EActorEditCompDataConvertTiming.LateBeginPlay);
	}

	public void NotifyActorGuid2EntityOnDataConvert()
	{
		IBUC_GuidData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_GuidData, BUC_GuidData>(Owner);
		if (readOnlyData != null)
		{
			string finalGuid = readOnlyData.GetFinalGuid();
			if (!string.IsNullOrEmpty(finalGuid))
			{
				BGW_EventCollection.Get(Owner).Evt_NotifyActorGuid2EntityOnDataConvert(Owner, finalGuid);
			}
			else if (!(Owner as BGUNeutralAnimalSpawnArea != null) && (!FGlobals.IsEditor || BGUFuncLibMap.GetCurLevelId(Owner) != 0))
			{
				GSEUtil.Ensure(!(Owner is BGUCharacterCS) && !(Owner is BGUActorBaseCS), Owner.GetName() + " Guid Invalid!!!", DebugOpenDialog: false);
			}
		}
	}

	public void DoDataConvert(EActorEditCompDataConvertTiming Timing)
	{
		UActorEditCompBase.DoDataConvert(Owner, Timing);
		if (Owner is BGUCharacterCS bGUCharacterCS)
		{
			BUTamerActor bUTamerActor = bGUCharacterCS.GetTamerOwner() as BUTamerActor;
			if (bUTamerActor != null)
			{
				UActorEditCompBase.DoDataConvertFromTamer(bUTamerActor, bGUCharacterCS, Timing);
			}
		}
	}

	public override void InitDataOnNew()
	{
		DoDataConvert(EActorEditCompDataConvertTiming.Init);
		NotifyActorGuid2EntityOnDataConvert();
	}

	public override void InitDataPreBeginPlay()
	{
		DoDataConvert(EActorEditCompDataConvertTiming.PreBeginPlay);
	}
}
