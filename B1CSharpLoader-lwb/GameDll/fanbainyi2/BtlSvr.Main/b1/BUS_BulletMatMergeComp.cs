using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_BulletMatMergeComp : UActorCompBaseCS
{
	private BUC_BulletMatMergeData BulletMatMgrData;

	public override void OnAttach()
	{
		BulletMatMgrData = RequireWritableData<BUC_BulletMatMergeData>();
		base.BUSEventCollection.Evt_SetBulletMatMgrData += new Del_Void_IntInt(SetBulletMatMgrData);
		base.BUSEventCollection.Evt_OnProjectileDead += new Del_OnBulletDead(OnBulletDead);
	}

	private void SetBulletMatMgrData(int BulletCommID, int SwitchIdx)
	{
		FUStBulletExpandDesc bulletExpandDesc = BGW_GameDB.GetBulletExpandDesc(BulletCommID);
		if (bulletExpandDesc != null)
		{
			bool flag = bulletExpandDesc.BulletIsMergeChild == EGSYesNo.Yes;
			string tag = bulletExpandDesc.BulletMergeTag;
			if (flag)
			{
				tag = bulletExpandDesc.BulletMergeTag + SwitchIdx;
			}
			SetIsMerge(bulletExpandDesc.BulletIsForMerge == EGSYesNo.Yes, flag, tag);
		}
	}

	private void SetIsMerge(bool isForMerge, bool isChild, string tag)
	{
		BulletMatMgrData.OpenMatDataTrans = isForMerge;
		BulletMatMgrData.IsMergeChild = isChild;
		if (BulletMatMgrData.OpenMatDataTrans)
		{
			string text = "PL_";
			string text2 = "PS_";
			if (BulletMatMgrData.IsMergeChild)
			{
				text = "CL_";
				text2 = "CS_";
			}
			text += tag;
			text2 += tag;
			BulletMatMgrData.MPCLocationVName = new FName(text);
			BulletMatMgrData.MPCScaleVName = new FName(text2);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		MPCTick();
	}

	public void MPCTick()
	{
		if (!BulletMatMgrData.OpenMatDataTrans || BulletMatMgrData.MPC == null || BulletMatMgrData.MPCLocationVName == FName.None || BulletMatMgrData.MPCScaleVName == FName.None)
		{
			return;
		}
		AActor owner = GetOwner();
		if (!(owner == null))
		{
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(owner);
			FVector actorScale3D = owner.GetActorScale3D();
			UMaterialLibrary.SetVectorParameterValue(ParameterValue: new FLinearColor
			{
				R = fVector.X,
				G = fVector.Y,
				B = fVector.Z,
				A = 0f
			}, WorldContextObject: GetOwner().World, Collection: BulletMatMgrData.MPC, ParameterName: BulletMatMgrData.MPCLocationVName);
			if (!BulletMatMgrData.IsMergeChild)
			{
				UMaterialLibrary.SetVectorParameterValue(ParameterValue: new FLinearColor
				{
					R = actorScale3D.X,
					G = actorScale3D.Y,
					B = actorScale3D.Z
				}, WorldContextObject: GetOwner().World, Collection: BulletMatMgrData.MPC, ParameterName: BulletMatMgrData.MPCScaleVName);
			}
		}
	}

	public void RemoveDataFromMPC()
	{
		if (!(BulletMatMgrData.MPC == null) && BulletMatMgrData.OpenMatDataTrans)
		{
			UMaterialLibrary.SetVectorParameterValue(ParameterValue: new FLinearColor
			{
				R = float.PositiveInfinity,
				G = float.PositiveInfinity,
				B = float.PositiveInfinity,
				A = 0f
			}, WorldContextObject: GetOwner().World, Collection: BulletMatMgrData.MPC, ParameterName: BulletMatMgrData.MPCLocationVName);
			if (!BulletMatMgrData.IsMergeChild)
			{
				UMaterialLibrary.SetVectorParameterValue(GetOwner().World, BulletMatMgrData.MPC, BulletMatMgrData.MPCScaleVName, default(FLinearColor));
			}
		}
	}

	private void OnBulletDead(EBGUBulletDestroyReason DestroyReason)
	{
		RemoveDataFromMPC();
	}
}
