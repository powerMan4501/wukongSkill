using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public static class BGU_DispLibDataUtil
{
	public static FVector GetDispRootBoneVelocity(USceneComponent SourceDispOwnerComp)
	{
		FVector result = FVector.ZeroVector;
		IBUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(SourceDispOwnerComp.GetOwner());
		if (readOnlyData != null && readOnlyData.HasSimpleState(EBGUSimpleState.PhysicsSimulationMoveMode))
		{
			b1.IBUC_PhysicalMoveData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_PhysicalMoveData, b1.BUC_PhysicalMoveData>(SourceDispOwnerComp.GetOwner());
			if (unPersistentReadOnlyData != null)
			{
				result = unPersistentReadOnlyData.PhysicalMoveVelocity;
			}
		}
		else
		{
			result = SourceDispOwnerComp.GetOwner().GetVelocity();
		}
		return result;
	}

	public static float GSTimeAfterBeginPlay(AActor WorldCtx)
	{
		if (WorldCtx.IsNullOrDestroyed())
		{
			return 0f;
		}
		BGWGameInstanceCS bGWGameInstanceCS = BGWGameInstanceCS.Get(WorldCtx);
		if (bGWGameInstanceCS == null)
		{
			if (!WorldCtx.World.IsNullOrDestroyed())
			{
				return WorldCtx.World.GetTimeSeconds();
			}
			return 0f;
		}
		return bGWGameInstanceCS.GetObject<BGW_ECSWorld>()?.GSTimeAfterBeginPlay ?? 0f;
	}

	public static USkeletalMeshComponent FindRealTargetSkeletalMeshComp(USkeletalMeshComponent SourceDispOwnerComp, FName OverrideSKMTagName)
	{
		if (OverrideSKMTagName == FName.None)
		{
			return SourceDispOwnerComp;
		}
		BUC_DispLibUnitRendererBaseData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_DispLibUnitRendererBaseData>(SourceDispOwnerComp.GetOwner());
		if (readOnlyData == null || readOnlyData.Tag2MeshCompList == null)
		{
			return null;
		}
		if (readOnlyData.Tag2MeshCompList.TryGetValue(OverrideSKMTagName, out var value))
		{
			if (value.Count == 0)
			{
				return null;
			}
			foreach (UPrimitiveComponent item in value)
			{
				USkeletalMeshComponent uSkeletalMeshComponent = item as USkeletalMeshComponent;
				if (uSkeletalMeshComponent != null)
				{
					return uSkeletalMeshComponent;
				}
			}
		}
		return null;
	}

	public static UPrimitiveComponent FindRealTargetPrimitiveComponent(USceneComponent SourceDispOwnerComp, FName OverrideTargetMeshCompTagName)
	{
		if (OverrideTargetMeshCompTagName == FName.None)
		{
			return SourceDispOwnerComp as UPrimitiveComponent;
		}
		BUC_DispLibUnitRendererBaseData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_DispLibUnitRendererBaseData>(SourceDispOwnerComp.GetOwner());
		if (readOnlyData == null || readOnlyData.Tag2MeshCompList == null)
		{
			return null;
		}
		if (readOnlyData.Tag2MeshCompList.TryGetValue(OverrideTargetMeshCompTagName, out var value))
		{
			if (value.Count == 0)
			{
				return null;
			}
			foreach (UPrimitiveComponent item in value)
			{
				if (item != null)
				{
					return item;
				}
			}
		}
		return null;
	}

	public static bool GetCurActiveMontageeUniqueID(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, out uint MontageeUniqueID)
	{
		MontageeUniqueID = 0u;
		UAnimInstance animInstance = MeshComp.GetAnimInstance();
		if (animInstance.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("DispLib Notify GetCurActiveMontageeUniqueID GetAnimInstance() is NULL, Actor Name = " + MeshComp.GetOwner().GetName() + " at POS(" + MeshComp.GetWorldLocation().ToString() + ")");
			return false;
		}
		if (animInstance.GetCurrentActiveMontage().IsNullOrDestroyed())
		{
			if (Animation.IsNullOrDestroyed())
			{
				BGW_LogUtil.LogError("DispLib Notify GetCurActiveMontageeUniqueID Animation is NULL, Actor Name = " + MeshComp.GetOwner().GetName() + " at POS(" + MeshComp.GetWorldLocation().ToString() + ")");
				return false;
			}
			MontageeUniqueID = Animation.GetUniqueID();
			return true;
		}
		MontageeUniqueID = Animation.GetUniqueID();
		return true;
	}

	public static bool FLinearColorIsNearlyEqual(FLinearColor A, FLinearColor B)
	{
		if (Math.Abs(A.R - B.R) < 1E-05f && Math.Abs(A.G - B.G) < 1E-05f && Math.Abs(A.B - B.B) < 1E-05f)
		{
			return Math.Abs(A.A - B.A) < 1E-05f;
		}
		return false;
	}
}
