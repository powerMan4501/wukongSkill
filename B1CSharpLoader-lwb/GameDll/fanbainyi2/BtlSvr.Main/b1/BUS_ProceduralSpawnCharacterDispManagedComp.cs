using b1.EventDelDefine;
using GSDispLib;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUS_ProceduralSpawnCharacterDispManagedComp : UActorCompBaseCS
{
	public override void OnBeginPlay()
	{
		base.BUSEventCollection.Evt_AttemptApplyDAEffect += new Del_AttemptApplyDAEffect(OnAttemptApplySpawnEfffect);
	}

	private void OnAttemptApplySpawnEfffect(UBGWDataAsset InDataAsset, FTransform InTransform)
	{
		GetOwner();
		BUC_DispLibDispBaseConfigDataAsset bUC_DispLibDispBaseConfigDataAsset = InDataAsset as BUC_DispLibDispBaseConfigDataAsset;
		if (!bUC_DispLibDispBaseConfigDataAsset.IsNullOrDestroyed())
		{
			_ = GetOwner().World;
			BWS_DispLibEventCollection.Get(DispLibDispWorld.GetInstance(GetOwner()))?.Evt_DLDWorld_RequestApplyOneDBCDataAsset(bUC_DispLibDispBaseConfigDataAsset, out var _, new DBCTransformParam(InTransform));
		}
	}
}
