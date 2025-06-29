using System.Collections.Generic;
using b1.EventDelDefine;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_UnitSceneItemComp : UActorCompBaseCS
{
	private BUC_SceneItemData SceneItemData;

	private IBGC_LevelActorData LevelActorData { get; set; }

	public override void OnAttach()
	{
		SceneItemData = RequireWritableData<BUC_SceneItemData>();
		LevelActorData = RequireReadOnlyGameStateData<IBGC_LevelActorData, BGC_LevelActorData>();
		base.BUSEventCollection.Evt_TryCatchSceneItemByTag += new Del_TryCatchSceneItemByTag(OnTryCatchSceneItemByTag);
		base.BUSEventCollection.Evt_TryCatchSceneItemByCondition += new Del_TryCatchSceneItemByCondition(OnTryCatchSceneItemByCondition);
		base.BUSEventCollection.Evt_TryAttachSceneItem += new Del_TryAttachSceneItem(OnTryAttachSceneItem);
		base.BUSEventCollection.Evt_DetachSceneItemAndAttachByProjectileActor += new Del_DetachSceneItemAndAttachByProjectileActor(OnDetachSceneItemAndAttachByProjectileActor);
		base.BUSEventCollection.Evt_RemoveCatchedSceneItemAndReset += new Del_Void(OnRemoveCatchedSceneItemAndReset);
		base.BUSEventCollection.Evt_ResetSceneItemsByTag += new Del_ResetSceneItemsByTag(OnResetSceneItemsByTag);
		base.BUSEventCollection.Evt_OverlapSceneItems += new Del_OverlapSceneItems(OverlapSceneItems);
		base.BUSEventCollection.Evt_ResetActorStatus += new Del_Void_ResetActorReason(OnResetSceneItems);
	}

	private void OnResetSceneItems(EResetActorReason ResetReason)
	{
		OnRemoveCatchedSceneItemAndReset();
	}

	public override void PreBeginPlay()
	{
		SceneItemData.Init();
	}

	private void OnTryCatchSceneItemByCondition(List<FName> SceneActorTags, QueryBestLocationCondition Condition, bool bNeedRemoveCurrentCatch = true)
	{
		LevelActorData.GetSceneItemsByTags(SceneActorTags, out var OutSceneItems);
		List<FVector> Locations = new List<FVector>();
		List<FRotator> Rotations = new List<FRotator>();
		foreach (BGUSceneItemBase item in OutSceneItems)
		{
			Locations.Add(BGUFuncLibActorTransformCS.BGUGetActorLocation(item));
			Rotations.Add(BGUFuncLibActorTransformCS.BGUGetActorRotation(item));
		}
		if (!BGU_SelectTargetUtil.QueryBestLocationByCondition(GetOwner(), in Locations, in Rotations, bUseCompositeV2: false, Condition, out var BestIndex))
		{
			return;
		}
		BGUSceneItemBase bGUSceneItemBase = OutSceneItems[BestIndex] as BGUSceneItemBase;
		if (!(bGUSceneItemBase == null))
		{
			if (bNeedRemoveCurrentCatch)
			{
				OnRemoveCatchedSceneItemAndReset();
			}
			SceneItemData.TryAddSceneItemForCatch(bGUSceneItemBase);
		}
	}

	private void OnTryCatchSceneItemByTag(List<FName> ActorTags, EFindSceneItemWay FindSceneItemWay, bool NeedRemoveCurrentCatch, float MinDistance, float MaxDistance, int FromAMInstanceID, float RequiredMaxAngle, float Angle, bool EnableDrawDebug)
	{
		if (FromAMInstanceID >= 0)
		{
			SceneItemData.CatchedSceneItemByAM.Clear();
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.TryFindSceneItem, "<character>" + Owner?.GetName() + "</><action>=============================TryFindSceneItem流程开始=============================</>");
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.TryFindSceneItem, $"<character>{Owner?.GetName()}</><action>FindSceneItemWay = {FindSceneItemWay}, NeedRemoveCurrentCatch = {NeedRemoveCurrentCatch}, MinDistance = {MinDistance}, MaxDistance = {MaxDistance}, RequiredMaxAngle = {RequiredMaxAngle}, Angle = {Angle}</>");
		}
		if (NeedRemoveCurrentCatch)
		{
			OnRemoveCatchedSceneItemAndReset();
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.TryFindSceneItem, "<character>" + Owner?.GetName() + "</><action>清空当前已经缓存的SceneItem【下面如果没找到那就是真没有SceneItem了】</>");
			}
		}
		else if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.TryFindSceneItem, "<character>" + Owner?.GetName() + "</><action>保留当前已经缓存的SceneItem【哪怕下面没找到还是有能返回的】</>");
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			string text = "";
			foreach (FName ActorTag in ActorTags)
			{
				text += $"{ActorTag};";
			}
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.TryFindSceneItem, "<character>" + Owner?.GetName() + "</><action>开始尝试查找Tag，有：" + text + "</>");
		}
		LevelActorData.GetSceneItemsByTags(ActorTags, out var OutSceneItems);
		AActor owner = GetOwner();
		int SelectIdx = -1;
		if (OutSceneItems.Count > 0)
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.TryFindSceneItem, $"<character>{Owner?.GetName()}</><action>按照Tag查找，满足Tag条件的有：{OutSceneItems.Count} 个</>");
			}
			switch (FindSceneItemWay)
			{
			case EFindSceneItemWay.FindMinTotalAngle:
			{
				float num = -1f;
				for (int i = 0; i < OutSceneItems.Count; i++)
				{
					AActor aActor = OutSceneItems[i];
					if (BGU_DataUtil.GetReadOnlyData<BUC_SceneItemCommData>(aActor) != null)
					{
						FVector2D safeNormal = owner.GetActorForwardVector().Conv_VectorToVector2D().GetSafeNormal();
						FVector2D safeNormal2 = (BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor) - BGUFuncLibActorTransformCS.BGUGetActorLocation(owner)).Conv_VectorToVector2D().GetSafeNormal();
						float num2 = MathLib.DegAcos(MathLib.DotProduct2D(safeNormal, safeNormal2));
						FVector2D v = safeNormal2;
						safeNormal2 = BGUFuncLibActorTransformCS.BGUGetActorRotation(aActor).Vector().Conv_VectorToVector2D()
							.GetSafeNormal();
						float num3 = MathLib.DegAcos(MathLib.DotProduct2D(v, safeNormal2));
						float num4 = num2 + num3;
						if ((num == -1f || num4 < num) && (!(RequiredMaxAngle > 0f) || (!(num2 > RequiredMaxAngle) && !(num3 > RequiredMaxAngle))))
						{
							SelectIdx = i;
							num = num4;
						}
					}
				}
				break;
			}
			case EFindSceneItemWay.FindNearest:
			{
				FVector actorLocation3 = Owner.GetActorLocation();
				FindIdxNearestTo(in OutSceneItems, MinDistance, MaxDistance, bNearest: true, actorLocation3, out SelectIdx);
				break;
			}
			case EFindSceneItemWay.FindFurthest:
			{
				FVector actorLocation = Owner.GetActorLocation();
				FindIdxNearestTo(in OutSceneItems, MinDistance, MaxDistance, bNearest: false, actorLocation, out SelectIdx);
				break;
			}
			case EFindSceneItemWay.FindNearestToTarget:
			{
				AActor aActor3 = BGUFunctionLibraryCS.BGUGetTarget(Owner);
				if (aActor3 != null)
				{
					FVector actorLocation4 = aActor3.GetActorLocation();
					FindIdxNearestTo(in OutSceneItems, MinDistance, MaxDistance, bNearest: true, actorLocation4, out SelectIdx);
				}
				break;
			}
			case EFindSceneItemWay.FindFurthestToTarget:
			{
				AActor aActor2 = BGUFunctionLibraryCS.BGUGetTarget(Owner);
				if (aActor2 != null)
				{
					FVector actorLocation2 = aActor2.GetActorLocation();
					FindIdxNearestTo(in OutSceneItems, MinDistance, MaxDistance, bNearest: false, actorLocation2, out SelectIdx);
				}
				break;
			}
			case EFindSceneItemWay.ClosestOutsideTheAngle:
				if (BGUFunctionLibraryCS.BGUGetTarget(Owner) != null)
				{
					FindIdx_SP_FSC(in OutSceneItems, MinDistance, MaxDistance, bNearest: true, Angle, out SelectIdx);
				}
				break;
			case EFindSceneItemWay.FarthestOutsideTheAngle:
				if (BGUFunctionLibraryCS.BGUGetTarget(Owner) != null)
				{
					FindIdx_SP_FSC(in OutSceneItems, MinDistance, MaxDistance, bNearest: false, Angle, out SelectIdx);
				}
				break;
			}
			bool flag = false;
			if (SelectIdx >= 0)
			{
				BGUSceneItemBase bGUSceneItemBase = OutSceneItems[SelectIdx] as BGUSceneItemBase;
				if (bGUSceneItemBase != null)
				{
					if (EnableDrawDebug)
					{
						FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUSceneItemBase);
						USystemLibrary.DrawDebugSphere(Owner, fVector, 100f, 20, FLinearColor.Yellow, 20f, 10f);
						USystemLibrary.DrawDebugArrow(Owner, fVector, fVector + new FVector(0.0, 0.0, 500.0), 30f, FLinearColor.Blue, 20f, 20f);
					}
					if (DebugConfig.IsOpenBattleInfoTool)
					{
						BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.TryFindSceneItem, "<character>" + Owner?.GetName() + "</><action>找到了完全满足条件的SceneItem：" + bGUSceneItemBase.GetName() + "</>");
					}
					flag = true;
					SceneItemData.TryAddSceneItemForCatch(bGUSceneItemBase);
					if (FromAMInstanceID >= 0)
					{
						SceneItemData.CatchedSceneItemByAM.Add(FromAMInstanceID, bGUSceneItemBase);
					}
				}
			}
			if (!flag && DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.TryFindSceneItem, "<character>" + Owner?.GetName() + "</><action>没有一个SceneItem能完全满足条件</>");
			}
		}
		else if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.TryFindSceneItem, "<character>" + Owner?.GetName() + "</><action>按照Tag查找，没有一个满足Tag条件</>");
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.TryFindSceneItem, (SceneItemData.SceneItemCatch != null) ? ("<character>" + Owner?.GetName() + "</><action>最后缓存的SceneItem是：" + SceneItemData.SceneItemCatch.GetName() + "</>") : ("<character>" + Owner?.GetName() + "</><action>最后没有能缓存到SceneItem，且也没有SceneItem缓存记录</>"));
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.TryFindSceneItem, "<character>" + Owner?.GetName() + "</><action>=============================TryFindSceneItem流程结束=============================</>");
		}
	}

	private void FindIdxNearestTo(in List<AActor> SceneItemList, float MinDistance, float MaxDistance, bool bNearest, FVector DistanceToPos, out int SelectIdx)
	{
		SelectIdx = -1;
		float num = -1f;
		for (int i = 0; i < SceneItemList.Count; i++)
		{
			AActor aActor = SceneItemList[i];
			if (BGU_DataUtil.GetReadOnlyData<BUC_SceneItemCommData>(aActor) != null)
			{
				float num2 = FVector.Distance(BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor), DistanceToPos);
				bool flag = (bNearest ? (num2 <= num) : (num2 >= num));
				if ((num == -1f || flag) && (!(MinDistance > 0f) || !(MaxDistance > 0f) || (!(num2 < MinDistance) && !(num2 > MaxDistance))))
				{
					SelectIdx = i;
					num = num2;
				}
			}
		}
	}

	private void FindIdx_SP_FSC(in List<AActor> SceneItemList, float MinDistance, float MaxDistance, bool bNearest, float Angle, out int SelectIdx)
	{
		SelectIdx = -1;
		if (Angle < 0f)
		{
			return;
		}
		List<int> list = new List<int>();
		AActor needGetInfoActor = BGUFunctionLibraryCS.BGUGetTarget(Owner);
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		FVector safeNormal = (BGUFuncLibActorTransformCS.BGUGetActorLocation(needGetInfoActor) - fVector).GetSafeNormal();
		for (int i = 0; i < SceneItemList.Count; i++)
		{
			AActor aActor = SceneItemList[i];
			if (BGU_DataUtil.GetReadOnlyData<BUC_SceneItemCommData>(aActor) != null)
			{
				FVector safeNormal2 = (BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor) - fVector).GetSafeNormal();
				if (MathLib.DegAcos(FVector.DotProduct(safeNormal, safeNormal2)) >= Angle)
				{
					list.Add(i);
				}
			}
		}
		float num = -1f;
		foreach (int item in list)
		{
			float num2 = FVector.Distance(BGUFuncLibActorTransformCS.BGUGetActorLocation(SceneItemList[item]), fVector);
			bool flag = (bNearest ? (num2 <= num) : (num2 >= num));
			if ((num == -1f || flag) && (!(MinDistance > 0f) || !(MaxDistance > 0f) || (!(num2 < MinDistance) && !(num2 > MaxDistance))))
			{
				SelectIdx = item;
				num = num2;
			}
		}
	}

	private void OnTryAttachSceneItem(FName SocketName)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (SceneItemData.TryAttachSceneItem())
		{
			BUS_EventCollectionCS.Get(SceneItemData.SceneItemAttach).Evt_SceneItemAttach.Invoke(bGUCharacterCS.Mesh, SocketName);
		}
	}

	private void OnDetachSceneItemAndAttachByProjectileActor(BGUProjectileBaseActor NewProjectileForAttach, float DelayEnableeCollisionTime, FVector FinalImpulse, AActor InnerSceneItem = null)
	{
		BGUSceneItemBase bGUSceneItemBase = ((!(InnerSceneItem != null)) ? SceneItemData.RemoveAttachSceneItem() : (InnerSceneItem as BGUSceneItemBase));
		if (!(bGUSceneItemBase != null))
		{
			return;
		}
		bGUSceneItemBase.DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
		bGUSceneItemBase.StaticMeshComp.SetSimulatePhysics(bSimulate: true);
		bGUSceneItemBase.StaticMeshComp.SetAllPhysicsLinearVelocity(FVector.ZeroVector);
		if (NewProjectileForAttach != null)
		{
			BGUFuncLibActorTransformCS.BGUAttachToActor(NewProjectileForAttach, bGUSceneItemBase, FName.None, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: true);
			SycnProjectileToSceneItem(NewProjectileForAttach, bGUSceneItemBase);
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUSceneItemBase);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SceneItemAddImpulse.Invoke(FinalImpulse);
				bUS_GSEventCollection.Evt_SceneItemSetDelayEnableCollTime.Invoke(DelayEnableeCollisionTime);
				UBGUFunctionLibraryForCS.BGUDrawLineArrow(bGUSceneItemBase.World, bGUSceneItemBase.GetActorLocation(), bGUSceneItemBase.GetActorLocation() + FinalImpulse, 200f);
			}
		}
	}

	private void SycnProjectileToSceneItem(BGUProjectileBaseActor ProjectileForAttach, BGUSceneItemBase SceneItem)
	{
		FHitResult SweepHitResult;
		if (ProjectileForAttach.GetSphereCollisionComp() != null)
		{
			ProjectileForAttach.GetSphereCollisionComp().SetRelativeTransform(SceneItem.GetSphereCollisionComp().GetRelativeTransform(), bSweep: false, out SweepHitResult, bTeleport: true);
			ProjectileForAttach.GetSphereCollisionComp().SetSphereRadius(SceneItem.GetSphereCollisionComp().GetUnscaledSphereRadius());
		}
		if (ProjectileForAttach.GetBoxCollisionComp() != null)
		{
			ProjectileForAttach.GetBoxCollisionComp().SetRelativeTransform(SceneItem.GetBoxCollisionComp().GetRelativeTransform(), bSweep: false, out SweepHitResult, bTeleport: true);
			ProjectileForAttach.GetBoxCollisionComp().SetBoxExtent(SceneItem.GetBoxCollisionComp().GetUnscaledBoxExtent());
		}
		if (ProjectileForAttach.GetCapsuleCollisionComp() != null)
		{
			ProjectileForAttach.GetCapsuleCollisionComp().SetRelativeTransform(SceneItem.GetCapsuleCollisionComp().GetRelativeTransform(), bSweep: false, out SweepHitResult, bTeleport: true);
			ProjectileForAttach.GetCapsuleCollisionComp().SetCapsuleRadius(SceneItem.GetCapsuleCollisionComp().GetUnscaledCapsuleRadius());
			ProjectileForAttach.GetCapsuleCollisionComp().SetCapsuleHalfHeight(SceneItem.GetCapsuleCollisionComp().GetUnscaledCapsuleHalfHeight());
		}
	}

	private void OnRemoveCatchedSceneItemAndReset()
	{
		SceneItemData.RemoveSceneItemCatch();
	}

	private void OnResetSceneItemsByTag(List<FName> ActorTags)
	{
		LevelActorData.GetSceneItemsByTags(ActorTags, out var _);
	}

	private List<AActor> OverlapSceneItems(List<FUStCheckShape> SweepCheckShape)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS.IsNullOrDestroyed())
		{
			return null;
		}
		List<AActor> list = new List<AActor>();
		foreach (FUStCheckShape item in SweepCheckShape)
		{
			List<AActor> list2 = new List<AActor>();
			foreach (TStrongObjectPtr<AActor> item2 in SceneItemData.SceneItemInUse)
			{
				list2.Add(item2.Get());
			}
			FVector socketLocation = bGUCharacterCS.Mesh.GetSocketLocation(item.SocketName);
			if (!USystemLibrary.SphereOverlapActors(bGUCharacterCS, socketLocation, item.Radius, SceneItemData.GetDefaultSceneItemObjTypeList(), null, list2, out var OutActors))
			{
				continue;
			}
			foreach (AActor item3 in OutActors)
			{
				BGUSceneItemBase bGUSceneItemBase = item3 as BGUSceneItemBase;
				if (bGUSceneItemBase != null)
				{
					list.Add(bGUSceneItemBase);
					SceneItemData.SceneItemInUse.Add(new TStrongObjectPtr_NoCollect<AActor>(bGUSceneItemBase));
				}
			}
		}
		_ = list.Count;
		_ = 0;
		return list;
	}
}
