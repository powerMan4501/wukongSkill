using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using b1.EventDelDefine;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUS_ModularCtrlComp : UActorCompBaseCS
{
	private BUC_ModularCtrlData ModularCtrlData;

	private IBUC_PropMgrData PropMgrData;

	private bool bStartInstallationTick;

	private float Timer;

	private float TimeoutTimer;

	private float TimeoutTime = 8f;

	public override void OnAttach()
	{
		ModularCtrlData = RequireWritableData<BUC_ModularCtrlData>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		base.BUSEventCollection.Evt_SyncModularData += new Del_SyncModularData(OnSyncModularData);
		base.BUSEventCollection.Evt_SyncModularMgr += new Del_SyncModularMgr(OnSyncModularMgr);
		base.BUSEventCollection.Evt_BeginModularSimulation += new Del_BeginModularSimulation(OnBeginModularSimulation);
		base.BUSEventCollection.Evt_DetachModularParts += new Del_DetachModularParts(OnDetachModularParts);
		base.BUSEventCollection.Evt_DestroyModularParts += new Del_DestroyModularParts(OnDestroyModularParts);
		base.BUSEventCollection.Evt_RestoreModularParts += new Del_RestoreModularParts(OnRestoreModularParts);
		base.BUSEventCollection.Evt_TryToInterruptRestoreModularParts += new Del_Void(OnTryToInterruptRestoreModularParts);
		base.BUSEventCollection.Evt_ModularBreakDown += new Del_ModularBreakDown(OnModularBreakDown);
		base.BUSEventCollection.Evt_TryDestroyModularActors += new Del_Void(OnTryDestroyModularActors);
		base.BUSEventCollection.Evt_TryHideModularActors += new Del_Bool(OnTryHideModularActors);
		base.BUSEventCollection.Evt_ResetActorStatusPre += new Del_Void_ResetActorReason(OnResetActorStatusPre);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (bStartInstallationTick)
		{
			TimeoutTimer += DeltaTime;
			MoveModularActorsByPhysics(DeltaTime);
			MoveModularActorsByInterpolation(DeltaTime);
			TickForCompletion();
			ModularCtrlData.SwitchFrameBool();
		}
	}

	private void OnResetActorStatusPre(EResetActorReason ResetReason)
	{
		if (OwnerAsCharacterCS == null)
		{
			return;
		}
		foreach (KeyValuePair<List<string>, bool> item in ModularCtrlData.PABodiesResponseForRestore)
		{
			List<string> key = item.Key;
			bool value = item.Value;
			foreach (string item2 in key)
			{
				BGUFuncLibMeshCS.SetAllPABodiesBelowResponseToAllChannels(OwnerAsCharacterCS.Mesh, new FName(item2), (!value) ? ECollisionResponseType.ECR_Block : ECollisionResponseType.ECR_Ignore);
			}
		}
		ModularCtrlData.PABodiesResponseForRestore.Clear();
		if (!(ModularCtrlData.OwnerMgr == null))
		{
			BUS_EventCollectionCS.Get(ModularCtrlData.OwnerMgr)?.Evt_ResetModularActor.Invoke();
		}
	}

	private bool IsInDebugCamera()
	{
		return UGameplayStatics.GetPlayerPawn(GetOwner(), 0).GetController() as BGP_PlayerControllerB1 == null;
	}

	private void OnSyncModularData(List<AActor> ModularActors, bool bAutoAttachModularActors, bool bAutoSnapToGround, bool bDestroyAfterOwnerDeath, bool bNeedsCopyPose, Dictionary<FName, int> BreakDownProjectileMap)
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		ModularCtrlData.bAutoAttachModularActors = bAutoAttachModularActors;
		ModularCtrlData.bDestroyAfterOwnerDeath = bDestroyAfterOwnerDeath;
		ModularCtrlData.bNeedsCopyPose = bNeedsCopyPose;
		ModularCtrlData.ModularBreakDownProjectileMap = BreakDownProjectileMap;
		ModularCtrlData.ModularActors.Clear();
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(Owner);
		foreach (AActor ModularActor in ModularActors)
		{
			if (IsInDebugCamera() && ModularActor.IsNullOrDestroyed())
			{
				continue;
			}
			ModularCtrlData.ModularActors.Add(new TStrongObjectPtr_NoCollect<AActor>(ModularActor), BUC_ModularCtrlData.ModularActorState.InPhysicsSimulation);
			USkeletalMeshComponent componentByClass = ModularActor.GetComponentByClass<USkeletalMeshComponent>();
			if (componentByClass != null && bNeedsCopyPose)
			{
				componentByClass.SetMasterPoseComponent(aCharacter.Mesh, bForceUpdate: true);
			}
			bUS_DispLibEventCollection?.Evt_AddChildActorMeshCompsToManager?.Invoke(ModularActor);
			FName socketName = B1GlobalFNames.root;
			UMeshComponent meshComp = componentByClass;
			UStaticMeshComponent uStaticMeshComponent = null;
			if (!bNeedsCopyPose)
			{
				meshComp = (uStaticMeshComponent = ModularActor.GetComponentByClass<UStaticMeshComponent>());
				socketName = ModularActor.Tags[0];
			}
			UPrimitiveComponent uPrimitiveComponent = ModularActor.RootComponent as UPrimitiveComponent;
			if (uPrimitiveComponent != null)
			{
				uPrimitiveComponent.SetSimulatePhysics(bSimulate: false);
				uPrimitiveComponent.SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
			}
			if (bAutoAttachModularActors)
			{
				ModularActor.AttachToComponent(aCharacter.Mesh, socketName, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: false);
				bUS_DispLibEventCollection?.Evt_MeshCompAddNewTag(B1GlobalFNames.hasplaced, meshComp);
			}
			else
			{
				if (!bAutoSnapToGround)
				{
					continue;
				}
				FVector actorLocation = ModularActor.GetActorLocation();
				FVector lineTraceEnd = actorLocation + FVector.UpVector * -1000.0;
				if (BGUFuncLibSelectTargetsCS.LineTraceForHitWorldItem(aCharacter, actorLocation, lineTraceEnd, out var hitResultSimple))
				{
					float num = 0f;
					if (componentByClass != null)
					{
						num = componentByClass.SkeletalMesh.GetBounds().BoxExtent.Z;
					}
					else if (uStaticMeshComponent != null)
					{
						num = uStaticMeshComponent.StaticMesh.GetBounds().BoxExtent.Z;
					}
					ModularActor.SetActorLocation(new FVector(actorLocation.X, actorLocation.Y, hitResultSimple.HitLocation.Z + num), bSweep: false, out var _, bTeleport: false);
				}
			}
		}
		ToggleOwnerCollisions(bEnable: false);
		if (ModularCtrlData.bPendingHideModularActors)
		{
			HideModularActors(bShouldHide: true);
			ModularCtrlData.bPendingHideModularActors = false;
		}
	}

	private void OnSyncModularMgr(BGUModularMgrActor OwnerMgr)
	{
		ModularCtrlData.OwnerMgr = OwnerMgr;
	}

	private void OnBeginModularSimulation(string TigerWoodsDataAssetPath = "")
	{
		if (GetOwner() as BGUCharacterCS == null)
		{
			return;
		}
		if (TigerWoodsDataAssetPath != "")
		{
			BGWDataAsset_TigerWoodsConfig tigerWoodsConfig = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<BGWDataAsset_TigerWoodsConfig>(TigerWoodsDataAssetPath, ELoadResourceType.AsyncLoadAndCache);
			ModularCtrlData.CopyBPDataToData(tigerWoodsConfig);
		}
		foreach (KeyValuePair<TStrongObjectPtr<AActor>, BUC_ModularCtrlData.ModularActorState> modularActor in ModularCtrlData.ModularActors)
		{
			UPrimitiveComponent uPrimitiveComponent = modularActor.Key.Get().RootComponent as UPrimitiveComponent;
			if (uPrimitiveComponent != null)
			{
				uPrimitiveComponent.SetSimulatePhysics(bSimulate: true);
			}
		}
		bStartInstallationTick = true;
	}

	private void OnDetachModularParts(string BoneName, string ComponentTag, bool bDetachRecursively)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		USkeletalMeshComponent mesh = bGUCharacterCS.Mesh;
		FName fName = new FName(BoneName);
		ModularDetachData value = new ModularDetachData
		{
			ComponentTag = ComponentTag,
			bDetachRecursively = bDetachRecursively
		};
		if (ModularCtrlData.ModularDetachDatas.ContainsKey(BoneName))
		{
			ModularCtrlData.ModularDetachDatas[BoneName] = value;
		}
		else
		{
			ModularCtrlData.ModularDetachDatas.Add(BoneName, value);
		}
		if (bDetachRecursively)
		{
			SortedDictionary<int, TStrongObjectPtr<AActor>> FoundModularActors = new SortedDictionary<int, TStrongObjectPtr<AActor>>();
			GetModularActorsFromBone(mesh, fName, ref FoundModularActors);
			if (ModularCtrlData.DetachedModularActors.ContainsKey(BoneName))
			{
				ModularCtrlData.DetachedModularActors[BoneName].Clear();
			}
			foreach (KeyValuePair<int, TStrongObjectPtr<AActor>> item in FoundModularActors)
			{
				TStrongObjectPtr<AActor> value2 = item.Value;
				AActor aActor = value2.Get();
				aActor.SetActorEnableCollision(bNewActorEnableCollision: true);
				aActor.DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
				UpdateModularActorState(value2, BUC_ModularCtrlData.ModularActorState.Detached);
				(aActor.RootComponent as UPrimitiveComponent).SetSimulatePhysics(bSimulate: true);
				USkeletalMeshComponent componentByClass = aActor.GetComponentByClass<USkeletalMeshComponent>();
				if (componentByClass != null)
				{
					if (ModularCtrlData.bNeedsCopyPose)
					{
						componentByClass.SetMasterPoseComponent(null, bForceUpdate: true);
					}
					BUS_DispLibEventCollection.Get(Owner)?.Evt_RemoveChildActorMeshCompsFromManager?.Invoke(aActor);
				}
				if (!ModularCtrlData.DetachedModularActors.ContainsKey(BoneName))
				{
					ModularCtrlData.DetachedModularActors.Add(BoneName, new List<TStrongObjectPtr<AActor>>());
				}
				ModularCtrlData.DetachedModularActors[BoneName].Add(value2);
			}
		}
		else
		{
			mesh.SetAllBodiesBelowSimulatePhysics(fName, bNewSimulate: true);
		}
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list.Add(BoneName);
		list2.Add(ComponentTag);
		TogglePartCollisions(bEnable: false, list, list2);
	}

	private void OnDestroyModularParts(string BoneName, string ComponentTag)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		SortedDictionary<int, TStrongObjectPtr<AActor>> FoundModularActors = new SortedDictionary<int, TStrongObjectPtr<AActor>>();
		GetModularActorsFromBone(bGUCharacterCS.Mesh, new FName(BoneName), ref FoundModularActors);
		foreach (KeyValuePair<int, TStrongObjectPtr<AActor>> item in FoundModularActors)
		{
			TStrongObjectPtr<AActor> value = item.Value;
			AActor aActor = value.Get();
			if (!aActor.IsNullOrDestroyed())
			{
				ModularCtrlData.ModularActors.Remove(value);
				BUS_DispLibEventCollection.Get(Owner)?.Evt_RemoveChildActorMeshCompsFromManager?.Invoke(aActor);
				BGU_UnrealWorldUtil.DestroyActor(aActor);
			}
		}
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list.Add(BoneName);
		list2.Add(ComponentTag);
		TogglePartCollisions(bEnable: false, list, list2);
	}

	private void OnRestoreModularParts(string BoneName, string TigerWoodsDataAssetPath)
	{
		if (GetOwner() as BGUCharacterCS == null)
		{
			return;
		}
		if (!ModularCtrlData.RestoredModularActors.ContainsKey(BoneName))
		{
			ModularCtrlData.RestoredModularActors.Add(BoneName, new List<TStrongObjectPtr<AActor>>());
		}
		ModularCtrlData.RestoredModularActors[BoneName] = ModularCtrlData.DetachedModularActors[BoneName];
		if (ModularCtrlData.RestoredModularActors[BoneName].Count <= 0)
		{
			return;
		}
		if (TigerWoodsDataAssetPath != "")
		{
			BGWDataAsset_TigerWoodsConfig tigerWoodsConfig = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<BGWDataAsset_TigerWoodsConfig>(TigerWoodsDataAssetPath, ELoadResourceType.AsyncLoadAndCache);
			ModularCtrlData.CopyBPDataToData(tigerWoodsConfig);
		}
		foreach (TStrongObjectPtr<AActor> item in ModularCtrlData.RestoredModularActors[BoneName])
		{
			UpdateModularActorState(item, BUC_ModularCtrlData.ModularActorState.InPhysicsSimulation);
		}
		ToggleOwnerCollisions(bEnable: false);
		bStartInstallationTick = true;
	}

	private void OnTryToInterruptRestoreModularParts()
	{
		if (ModularCtrlData.RestoredModularActors.Count <= 0)
		{
			return;
		}
		List<string> list = new List<string>();
		foreach (KeyValuePair<string, List<TStrongObjectPtr<AActor>>> restoredModularActor in ModularCtrlData.RestoredModularActors)
		{
			foreach (KeyValuePair<TStrongObjectPtr<AActor>, BUC_ModularCtrlData.ModularActorState> modularActor in ModularCtrlData.ModularActors)
			{
				TStrongObjectPtr<AActor> key = modularActor.Key;
				BUC_ModularCtrlData.ModularActorState value = modularActor.Value;
				if (restoredModularActor.Value.Contains(key) && value != BUC_ModularCtrlData.ModularActorState.Finished)
				{
					list.Add(restoredModularActor.Key);
					break;
				}
			}
		}
		foreach (string item in list)
		{
			ModularDetachData modularDetachData = ModularCtrlData.ModularDetachDatas[item];
			OnDetachModularParts(item, modularDetachData.ComponentTag, modularDetachData.bDetachRecursively);
		}
		List<string> list2 = ModularCtrlData.RestoredModularActors.Keys.Except(list).ToList();
		ModularCtrlData.GetDetachedComponentTags(list2, out var ComponentTags);
		OnInstallationComplete(list2, ComponentTags);
	}

	private void OnModularBreakDown(float BreakStrength)
	{
		if (GetOwner() as BGUCharacterCS == null)
		{
			return;
		}
		ToggleOwnerCollisions(bEnable: false);
		foreach (KeyValuePair<TStrongObjectPtr<AActor>, BUC_ModularCtrlData.ModularActorState> modularActor in ModularCtrlData.ModularActors)
		{
			if (modularActor.Value != BUC_ModularCtrlData.ModularActorState.Finished && modularActor.Value != BUC_ModularCtrlData.ModularActorState.Detached)
			{
				return;
			}
		}
		List<TStrongObjectPtr<AActor>> list = new List<TStrongObjectPtr<AActor>>();
		foreach (KeyValuePair<TStrongObjectPtr<AActor>, BUC_ModularCtrlData.ModularActorState> modularActor2 in ModularCtrlData.ModularActors)
		{
			TStrongObjectPtr<AActor> key = modularActor2.Key;
			AActor aActor = key.Get();
			if (!(aActor == null))
			{
				aActor.SetActorEnableCollision(bNewActorEnableCollision: true);
				aActor.DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
				UPrimitiveComponent obj = aActor.RootComponent as UPrimitiveComponent;
				obj.SetSimulatePhysics(bSimulate: true);
				FVector impulse = (BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor) - BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner())).GetSafeNormal() * BreakStrength;
				impulse.Z = 0f;
				obj.AddImpulse(impulse, FName.None, bVelChange: true);
				list.Add(key);
				FName key2 = aActor.Tags[0];
				if (ModularCtrlData.ModularBreakDownProjectileMap.ContainsKey(key2))
				{
					int projectileID = ModularCtrlData.ModularBreakDownProjectileMap[key2];
					FGSProjecttileObjSpawnNSInfo ProjectileSpawnNSInfo = new FGSProjecttileObjSpawnNSInfo();
					ProjectileSpawnNSInfo.ProjectileType = EProjectileType.Bullet;
					ProjectileSpawnNSInfo.SpawnWave = 1;
					ProjectileSpawnNSInfo.SpawnNumPerWave = 1;
					ProjectileSpawnNSInfo.ProjectileID = projectileID;
					ProjectileSpawnNSInfo.ModularActor = aActor;
					ProjectileSpawnNSInfo.SpawnBase.BaseType = ProjectileBaseType.ProjectileSpawner;
					ProjectileSpawnNSInfo.SpawnBase.BaseActor = new TStrongObjectPtr_NoCollect<AActor>();
					ProjectileSpawnNSInfo.SpawnPosOffsetInfo = default(ProjectilePosOffsetStruct);
					ProjectileSpawnNSInfo.SpawnPosOffsetInfo.BaseActor = new TStrongObjectPtr_NoCollect<AActor>();
					ProjectileSpawnNSInfo.TargetBase.BaseType = ProjectileBaseType.None;
					ProjectileSpawnNSInfo.TargetBase.BaseActor = new TStrongObjectPtr_NoCollect<AActor>();
					ProjectileSpawnNSInfo.TargetPosOffsetInfo = default(ProjectilePosOffsetStruct);
					ProjectileSpawnNSInfo.TargetPosOffsetInfo.BaseActor = new TStrongObjectPtr_NoCollect<AActor>();
					base.BUSEventCollection?.Evt_OnNotifyStateSpawnProjectileObj.Invoke(ref ProjectileSpawnNSInfo);
				}
			}
		}
		foreach (TStrongObjectPtr<AActor> item in list)
		{
			UpdateModularActorState(item, BUC_ModularCtrlData.ModularActorState.InPhysicsSimulation);
		}
	}

	private void GetModularActorsFromBone(USkeletalMeshComponent OwnerMesh, FName BoneFName, ref SortedDictionary<int, TStrongObjectPtr<AActor>> FoundModularActors)
	{
		List<FName> ChildBoneNames = new List<FName>();
		BGUFuncLibMeshCS.GetChildBones(OwnerMesh, BoneFName, ref ChildBoneNames);
		UGSE_AnimFuncLib.GetChildSockets(OwnerMesh, BoneFName, out var ChildSocketNames);
		int num = -1;
		foreach (KeyValuePair<TStrongObjectPtr<AActor>, BUC_ModularCtrlData.ModularActorState> modularActor in ModularCtrlData.ModularActors)
		{
			if (modularActor.Value == BUC_ModularCtrlData.ModularActorState.Detached)
			{
				continue;
			}
			TStrongObjectPtr<AActor> key = modularActor.Key;
			AActor aActor = key.Get();
			if (aActor == null)
			{
				continue;
			}
			FName fName = aActor.Tags[0];
			for (int i = 0; i < ChildBoneNames.Count; i++)
			{
				if (ChildBoneNames[i] == fName)
				{
					FoundModularActors.Add(i, key);
				}
			}
			for (int j = 0; j < ChildSocketNames.Count; j++)
			{
				if (ChildSocketNames[j] == fName && !FoundModularActors.ContainsValue(key))
				{
					FoundModularActors.Add(num--, key);
				}
			}
		}
	}

	private void ToggleOwnerCollisions(bool bEnable)
	{
		Dictionary<ECollisionChannel, ECollisionResponseType> value = new Dictionary<ECollisionChannel, ECollisionResponseType> { 
		{
			ECollisionChannel.ECC_Pawn,
			bEnable ? ECollisionResponseType.ECR_Block : ECollisionResponseType.ECR_Ignore
		} };
		Dictionary<ECollisionChannel, ECollisionResponseType> value2 = new Dictionary<ECollisionChannel, ECollisionResponseType> { 
		{
			ECollisionChannel.ECC_PhysicsBody,
			bEnable ? ECollisionResponseType.ECR_Block : ECollisionResponseType.ECR_Ignore
		} };
		if (bEnable)
		{
			base.BUSEventCollection.Evt_ResetProperty.Invoke(ModularCtrlData.CapsuleCollisionResponseHandleID);
			ModularCtrlData.CapsuleCollisionResponseHandleID = 0u;
			base.BUSEventCollection.Evt_ResetProperty.Invoke(ModularCtrlData.MeshCollisionResponseHandleID);
			ModularCtrlData.MeshCollisionResponseHandleID = 0u;
		}
		else if (ModularCtrlData.CapsuleCollisionResponseHandleID == 0)
		{
			base.BUSEventCollection.Evt_SetCollisionResponseProperty.Invoke(EPropType.Capsule_CollisionResponseToChannels, value);
			ModularCtrlData.CapsuleCollisionResponseHandleID = PropMgrData.GetLastHandleID();
			base.BUSEventCollection.Evt_SetCollisionResponseProperty.Invoke(EPropType.Mesh_CollisionResponseToChannels, value2);
			ModularCtrlData.MeshCollisionResponseHandleID = PropMgrData.GetLastHandleID();
		}
		else
		{
			base.BUSEventCollection.Evt_SetCollisionResponseProperty.Invoke(EPropType.Capsule_CollisionResponseToChannels, value, ModularCtrlData.CapsuleCollisionResponseHandleID);
			base.BUSEventCollection.Evt_SetCollisionResponseProperty.Invoke(EPropType.Mesh_CollisionResponseToChannels, value2, ModularCtrlData.MeshCollisionResponseHandleID);
		}
	}

	private void TogglePartCollisions(bool bEnable, List<string> BoneNames, List<string> ComponentTags)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		foreach (string BoneName in BoneNames)
		{
			BGUFuncLibMeshCS.SetAllPABodiesBelowResponseToAllChannels(bGUCharacterCS.Mesh, new FName(BoneName), bEnable ? ECollisionResponseType.ECR_Block : ECollisionResponseType.ECR_Ignore);
		}
		ModularCtrlData.PABodiesResponseForRestore[BoneNames] = bEnable;
		foreach (string ComponentTag in ComponentTags)
		{
			if (!(ComponentTag != ""))
			{
				continue;
			}
			foreach (UActorComponent item in bGUCharacterCS.GetComponentsByTag(UClass.GetClass<USceneComponent>(), new FName(ComponentTag)))
			{
				FName autoLockPoint = B1GlobalFNames.AutoLockPoint;
				FName autoLockPointBackup = B1GlobalFNames.AutoLockPointBackup;
				if (bEnable)
				{
					if (item.ComponentHasTag(autoLockPointBackup))
					{
						item.ComponentTags.Remove(autoLockPointBackup);
						item.ComponentTags.Add(autoLockPoint);
					}
				}
				else if (item.ComponentHasTag(autoLockPoint))
				{
					item.ComponentTags.Remove(autoLockPoint);
					item.ComponentTags.Add(autoLockPointBackup);
				}
				UShapeComponent uShapeComponent = item as UShapeComponent;
				if (uShapeComponent != null)
				{
					uShapeComponent.SetCollisionEnabled(bEnable ? ECollisionEnabled.QueryAndPhysics : ECollisionEnabled.NoCollision);
				}
			}
		}
	}

	private void OnInstallationComplete(List<string> FinishedBoneNames, List<string> FinishedComponentTags)
	{
		ToggleOwnerCollisions(bEnable: true);
		TogglePartCollisions(bEnable: true, FinishedBoneNames, FinishedComponentTags);
		bStartInstallationTick = false;
		Timer = 0f;
		TimeoutTimer = 0f;
	}

	private void UpdateModularActorState(TStrongObjectPtr<AActor> ModularActor, BUC_ModularCtrlData.ModularActorState State)
	{
		ModularCtrlData.ModularActors[ModularActor] = State;
		if (State == BUC_ModularCtrlData.ModularActorState.Finished && !ModularCtrlData.bAutoAttachModularActors)
		{
			UMeshComponent componentByClass = ModularActor.Get().GetComponentByClass<UStaticMeshComponent>();
			if (componentByClass == null)
			{
				componentByClass = ModularActor.Get().GetComponentByClass<USkeletalMeshComponent>();
			}
			BUS_DispLibEventCollection.Get(Owner)?.Evt_MeshCompAddNewTag(B1GlobalFNames.hasplaced, componentByClass);
		}
	}

	private void MoveModularActorsByPhysics(float DeltaTime)
	{
		List<TStrongObjectPtr<AActor>> FinishedActors = new List<TStrongObjectPtr<AActor>>();
		foreach (KeyValuePair<TStrongObjectPtr<AActor>, BUC_ModularCtrlData.ModularActorState> modularActor in ModularCtrlData.ModularActors)
		{
			if (modularActor.Value != BUC_ModularCtrlData.ModularActorState.InPhysicsSimulation)
			{
				continue;
			}
			TStrongObjectPtr<AActor> key = modularActor.Key;
			AActor aActor = key.Get();
			if (!IsInDebugCamera() || !aActor.IsNullOrDestroyed())
			{
				WriteVectorsToSlots(DeltaTime, aActor);
				MoveModularActorByImpulse(key, ref FinishedActors);
				if (!FinishedActors.Contains(key))
				{
					MoveModularActorByForce(aActor);
				}
			}
		}
		foreach (TStrongObjectPtr<AActor> item in FinishedActors)
		{
			UpdateModularActorState(item, BUC_ModularCtrlData.ModularActorState.InInterpolation);
		}
	}

	private void WriteVectorsToSlots(float DeltaTime, AActor ModularActor)
	{
		WriteDirectionVectorToSlot0(ModularActor);
		WriteTimeAccumulatedDirectionVectorToSlot1(DeltaTime, ModularActor);
	}

	private void WriteDirectionVectorToSlot0(AActor ModularActor)
	{
		FName inSocketName = FName.None;
		if (ModularActor != null && ModularActor.Tags.Count > 0)
		{
			inSocketName = ModularActor.Tags[0];
		}
		FVector socketLocation = (GetOwner() as BGUCharacterCS).Mesh.GetSocketLocation(inSocketName);
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(ModularActor);
		FVector safeNormal = (socketLocation - fVector).GetSafeNormal();
		ModularCtrlData.PredefinedVectorSlots[0] = safeNormal;
	}

	private void WriteTimeAccumulatedDirectionVectorToSlot1(float DeltaTime, AActor ModularActor)
	{
		Timer += DeltaTime;
		FVector fVector = ModularCtrlData.PredefinedVectorSlots[0];
		ModularCtrlData.PredefinedVectorSlots[1] = fVector * Timer;
	}

	private void MoveModularActorByImpulse(TStrongObjectPtr<AActor> StrongModularActor, ref List<TStrongObjectPtr<AActor>> FinishedActors)
	{
		AActor aActor = StrongModularActor.Get();
		FName inSocketName = aActor.Tags[0];
		FVector socketLocation = (GetOwner() as BGUCharacterCS).Mesh.GetSocketLocation(inSocketName);
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
		float num = (socketLocation - fVector).Size();
		UStaticMeshComponent uStaticMeshComponent = aActor.RootComponent as UStaticMeshComponent;
		if (num <= ModularCtrlData.PhysicsDistanceThreshold)
		{
			uStaticMeshComponent.SetSimulatePhysics(bSimulate: false);
			uStaticMeshComponent.SetCollisionObjectType(ECollisionChannel.ECC_PhysicsBody);
			aActor.SetActorEnableCollision(bNewActorEnableCollision: false);
			FinishedActors.Add(StrongModularActor);
			return;
		}
		FVector fVector2 = default(FVector);
		foreach (FTWImpulseData tWImpulseData in ModularCtrlData.TWImpulseDataList)
		{
			FVector fVector3 = ModularCtrlData.PredefinedVectorSlots[(uint)tWImpulseData.VectorUseType];
			switch (tWImpulseData.VectorUseType)
			{
			case TWVectorUseType.UsePredefinedVectorSlot0:
			case TWVectorUseType.UsePredefinedVectorSlot1:
			case TWVectorUseType.UsePredefinedVectorSlot2:
			case TWVectorUseType.UsePredefinedVectorSlot3:
				fVector2 += fVector3 * tWImpulseData.CalculateAggregatedMultiplier(num, ModularCtrlData.GetSwitchFrameBool());
				break;
			case TWVectorUseType.UseVectorBase:
				fVector2 += tWImpulseData.GetBlendedVector(num, ModularCtrlData.GetSwitchFrameBool());
				break;
			}
		}
		float floatValue = ModularCtrlData.TWImpulseBlendCurve.GetFloatValue(num);
		FVector impulse = fVector2 * floatValue;
		uStaticMeshComponent.AddImpulse(impulse, FName.None, bVelChange: true);
	}

	private void MoveModularActorByForce(AActor ModularActor)
	{
		FName inSocketName = ModularActor.Tags[0];
		FVector socketLocation = (GetOwner() as BGUCharacterCS).Mesh.GetSocketLocation(inSocketName);
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(ModularActor);
		float num = (socketLocation - fVector).Size();
		FVector fVector2 = default(FVector);
		foreach (FTWForceData tWForceData in ModularCtrlData.TWForceDataList)
		{
			FVector fVector3 = ModularCtrlData.PredefinedVectorSlots[(uint)tWForceData.VectorUseType];
			switch (tWForceData.VectorUseType)
			{
			case TWVectorUseType.UsePredefinedVectorSlot0:
			case TWVectorUseType.UsePredefinedVectorSlot1:
			case TWVectorUseType.UsePredefinedVectorSlot2:
			case TWVectorUseType.UsePredefinedVectorSlot3:
				fVector2 += fVector3 * tWForceData.CalculateAggregatedMultiplier(num);
				break;
			case TWVectorUseType.UseVectorBase:
				fVector2 += tWForceData.GetBlendedVector(num);
				break;
			}
		}
		UStaticMeshComponent uStaticMeshComponent = ModularActor.RootComponent as UStaticMeshComponent;
		float floatValue = ModularCtrlData.TWForceBlendCurve.GetFloatValue(num);
		FVector force = fVector2 * floatValue * uStaticMeshComponent.GetMass();
		uStaticMeshComponent.AddForce(force, FName.None, bAccelChange: true);
	}

	private void MoveModularActorsByInterpolation(float DeltaTime)
	{
		List<TStrongObjectPtr<AActor>> list = new List<TStrongObjectPtr<AActor>>();
		foreach (KeyValuePair<TStrongObjectPtr<AActor>, BUC_ModularCtrlData.ModularActorState> modularActor in ModularCtrlData.ModularActors)
		{
			if (modularActor.Value != BUC_ModularCtrlData.ModularActorState.InInterpolation)
			{
				continue;
			}
			TStrongObjectPtr<AActor> key = modularActor.Key;
			AActor aActor = key.Get();
			if (!IsInDebugCamera() || !aActor.IsNullOrDestroyed())
			{
				FName fName = aActor.Tags[0];
				BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
				FVector socketLocation = bGUCharacterCS.Mesh.GetSocketLocation(fName);
				FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
				float num = (socketLocation - fVector).Size();
				if (num <= ModularCtrlData.InterpolationDistanceThreshold)
				{
					aActor.AttachToComponent(bGUCharacterCS.Mesh, fName, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: false);
					list.Add(key);
					continue;
				}
				float floatValue = ModularCtrlData.LocationInterpolationSpeedCurve.GetFloatValue(num);
				FVector newLocation = UMathLibrary.VInterpTo(fVector, socketLocation, DeltaTime, floatValue);
				BGUFuncLibActorTransformCS.BGUSetActorLocation(aActor, newLocation, bSweep: false, bTeleport: false);
				float floatValue2 = ModularCtrlData.RotationInterpolationSpeedCurve.GetFloatValue(num);
				FRotator socketRotation = bGUCharacterCS.Mesh.GetSocketRotation(fName);
				FRotator newRotation = UMathLibrary.RInterpTo(BGUFuncLibActorTransformCS.BGUGetActorRotation(aActor), socketRotation, DeltaTime, floatValue2);
				BGUFuncLibActorTransformCS.BGUSetActorRotation(aActor, newRotation, bTeleportPhysics: false);
			}
		}
		foreach (TStrongObjectPtr<AActor> item in list)
		{
			UpdateModularActorState(item, BUC_ModularCtrlData.ModularActorState.Finished);
		}
	}

	private void TickForCompletion()
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		bool flag = TimeoutTimer >= TimeoutTime;
		bool flag2 = true;
		List<TStrongObjectPtr<AActor>> list = new List<TStrongObjectPtr<AActor>>();
		foreach (KeyValuePair<TStrongObjectPtr<AActor>, BUC_ModularCtrlData.ModularActorState> modularActor in ModularCtrlData.ModularActors)
		{
			if (modularActor.Value != BUC_ModularCtrlData.ModularActorState.Finished && modularActor.Value != BUC_ModularCtrlData.ModularActorState.Detached)
			{
				if (!flag)
				{
					flag2 = false;
					break;
				}
				TStrongObjectPtr<AActor> key = modularActor.Key;
				AActor aActor = key.Get();
				if (!IsInDebugCamera() || !aActor.IsNullOrDestroyed())
				{
					FName socketName = aActor.Tags[0];
					UStaticMeshComponent obj = aActor.RootComponent as UStaticMeshComponent;
					obj.SetSimulatePhysics(bSimulate: false);
					obj.SetCollisionObjectType(ECollisionChannel.ECC_PhysicsBody);
					aActor.SetActorEnableCollision(bNewActorEnableCollision: false);
					aActor.AttachToComponent(bGUCharacterCS.Mesh, socketName, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: false);
					list.Add(key);
				}
			}
		}
		foreach (TStrongObjectPtr<AActor> item in list)
		{
			UpdateModularActorState(item, BUC_ModularCtrlData.ModularActorState.Finished);
		}
		if (flag2)
		{
			List<string> list2 = ModularCtrlData.RestoredModularActors.Keys.ToList();
			ModularCtrlData.GetDetachedComponentTags(list2, out var ComponentTags);
			OnInstallationComplete(list2, ComponentTags);
		}
	}

	private void OnTryDestroyModularActors()
	{
		if (!ModularCtrlData.bDestroyAfterOwnerDeath)
		{
			return;
		}
		foreach (KeyValuePair<TStrongObjectPtr<AActor>, BUC_ModularCtrlData.ModularActorState> modularActor in ModularCtrlData.ModularActors)
		{
			AActor aActor = modularActor.Key.Get();
			if (aActor != null)
			{
				BGU_UnrealWorldUtil.DestroyActor(aActor);
			}
		}
	}

	private void OnTryHideModularActors(bool bShouldHide)
	{
		if (ModularCtrlData.ModularActors.Count == 0)
		{
			ModularCtrlData.bPendingHideModularActors = true;
		}
		else
		{
			HideModularActors(bShouldHide);
		}
	}

	private void HideModularActors(bool bShouldHide)
	{
		foreach (KeyValuePair<TStrongObjectPtr<AActor>, BUC_ModularCtrlData.ModularActorState> modularActor in ModularCtrlData.ModularActors)
		{
			AActor aActor = modularActor.Key.Get();
			if (aActor != null)
			{
				aActor.SetActorHiddenInGame(bShouldHide);
			}
		}
	}

	private void CheckModularActorDistance()
	{
		foreach (KeyValuePair<TStrongObjectPtr<AActor>, BUC_ModularCtrlData.ModularActorState> modularActor in ModularCtrlData.ModularActors)
		{
			AActor aActor = modularActor.Key.Get();
			if ((!IsInDebugCamera() || !aActor.IsNullOrDestroyed()) && aActor.GetDistanceTo(GetOwner()) > 100000f)
			{
				BGUFuncLibActorTransformCS.BGUSetActorLocation(aActor, BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner()) + new FVector(0.0, 0.0, 650.0), bSweep: false, bTeleport: false);
			}
		}
	}
}
