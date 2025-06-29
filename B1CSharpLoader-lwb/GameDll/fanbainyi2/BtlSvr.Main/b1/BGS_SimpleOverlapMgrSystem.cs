using System;
using System.Collections.Generic;
using b1.ECS;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.ApexDestruction;
using UnrealEngine.Runtime;

namespace b1;

public class BGS_SimpleOverlapMgrSystem : GameStateSystemBase
{
	public static bool UseThread = true;

	public static bool BlockAndWait = true;

	private static GSBindProp<bool> IsUpdating = new GSBindProp<bool>();

	private List<AActor> NeedRemoveGridActor = new List<AActor>();

	private List<Entity> NeedDeregisterEntity = new List<Entity>();

	private List<EntityUpdateInfo> NeedRegisterEntityUpdateInfo = new List<EntityUpdateInfo>();

	private List<AActor> NeedRemoveGridActor_Thread = new List<AActor>();

	private List<Entity> NeedDeregisterEntity_Thread = new List<Entity>();

	private List<EntityUpdateInfo> NeedRegisterEntityUpdateInfo_Thread = new List<EntityUpdateInfo>();

	private List<FVector2D> CurIndexMappingList = new List<FVector2D>();

	private List<FVector2D> LastIndexListTemp = new List<FVector2D>();

	private BGC_SimpleOverlapMgrData BGSimpleOverlapMgrData { get; set; }

	private BGS_GSEventCollection EventCollection { get; set; }

	public override void OnAttach()
	{
		IsUpdating.SetValue(EChangeReason.Init, value: false);
		BGSimpleOverlapMgrData = RequireWritableData<BGC_SimpleOverlapMgrData>();
		EventCollection = BGS_GSEventCollection.Get(this);
		if (EventCollection != null)
		{
			EventCollection.Evt_BGS_RegisterBGUEntityInfo += new Del_ActorTransformInfoData(RegisterBGUEntityInfo);
			EventCollection.Evt_BGS_DeregisterBGUEntityInfo += new Del_Void_Entity(DeregisterBGUEntityInfo);
			EventCollection.Evt_BGS_RemoveGridInfo += new Del_Void_Actor(RemoveGridInfo);
		}
	}

	public override void OnBeginPlay()
	{
		PreloadAssetMgr = null;
	}

	private bool SwapNeedUpdateInfo()
	{
		if (IsUpdating.Value)
		{
			return false;
		}
		NeedRemoveGridActor_Thread.AddRange(NeedRemoveGridActor);
		NeedRemoveGridActor.Clear();
		NeedDeregisterEntity_Thread.AddRange(NeedDeregisterEntity);
		NeedDeregisterEntity.Clear();
		NeedRegisterEntityUpdateInfo_Thread.AddRange(NeedRegisterEntityUpdateInfo);
		NeedRegisterEntityUpdateInfo.Clear();
		return true;
	}

	private void ResolveNeedUpdateInfo_Thread()
	{
		foreach (AActor item in NeedRemoveGridActor_Thread)
		{
			OnRemoveGridInfo(item);
		}
		NeedRemoveGridActor_Thread.Clear();
		foreach (Entity item2 in NeedDeregisterEntity_Thread)
		{
			OnDeregisterEntity(item2);
		}
		NeedDeregisterEntity_Thread.Clear();
		foreach (EntityUpdateInfo item3 in NeedRegisterEntityUpdateInfo_Thread)
		{
			OnRegisterEntityUpdatenfo(item3);
		}
		NeedRegisterEntityUpdateInfo_Thread.Clear();
	}

	private void RemoveGridInfo(AActor OldActor)
	{
		if (IsUpdating.Value)
		{
			NeedRemoveGridActor.Add(OldActor);
		}
		else
		{
			OnRemoveGridInfo(OldActor);
		}
	}

	private void OnRemoveGridInfo(AActor OldActor)
	{
		BGSimpleOverlapMgrData.RemoveGridInfo(OldActor);
	}

	private void DeregisterBGUEntityInfo(Entity ActorEnt)
	{
		if (BGSimpleOverlapMgrData.EntityUpdateInfoDic.ContainsKey(ActorEnt))
		{
			if (IsUpdating.Value)
			{
				NeedDeregisterEntity.Add(ActorEnt);
			}
			else
			{
				OnDeregisterEntity(ActorEnt);
			}
		}
	}

	private void OnDeregisterEntity(Entity ActorEnt)
	{
		if (!BGSimpleOverlapMgrData.EntityUpdateInfoDic.ContainsKey(ActorEnt))
		{
			return;
		}
		BGSimpleOverlapMgrData.GridInfos.Remove(ActorEnt);
		if (BGSimpleOverlapMgrData.EntityUpdateInfoDic.ContainsKey(ActorEnt))
		{
			foreach (KeyValuePair<Entity, List<FVector2D>> item in BGSimpleOverlapMgrData.EntityUpdateInfoDic[ActorEnt].IndexMappingDic)
			{
				Entity key = item.Key;
				foreach (FVector2D item2 in item.Value)
				{
					BGSimpleOverlapMgrData.RemoveEntityInfoByIndex(item2, key, ActorEnt);
				}
			}
		}
		BGSimpleOverlapMgrData.EntityUpdateInfoDic.Remove(ActorEnt);
	}

	private bool RegisterBGUEntityInfo(AActor RegistedActor, IBUC_ActorTransformInfoData ActorTransformInfoData)
	{
		BGW_ECSWorld bGW_ECSWorld = BGW_ECSWorld.Get(Owner);
		Entity entity = ECSExtension.ToEntity(RegistedActor);
		EntityUpdateInfo entityUpdateInfo = new EntityUpdateInfo();
		entityUpdateInfo.Ent = entity;
		entityUpdateInfo.ActorTransformInfoData = ActorTransformInfoData;
		entityUpdateInfo.Actor = RegistedActor;
		if (RegistedActor is BGUCharacterCS bGUCharacterCS)
		{
			bGW_ECSWorld.AddMask(entity, 1);
			FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(bGUCharacterCS.GetResID());
			if (unitCommDesc != null && unitCommDesc.SimpleOverlapRadius != 0f)
			{
				entityUpdateInfo.Radius = unitCommDesc.SimpleOverlapRadius;
			}
			else
			{
				UBGUFunctionLibraryForCS.BGUGetBounds(bGUCharacterCS.Mesh, out var _, out var BoxExtent);
				entityUpdateInfo.Radius = (float)BoxExtent.GetMax() * 2.5f;
			}
			if (bGUCharacterCS is BGUPlayerCharacterCS)
			{
				ActorTransformInfoData.GetNextUpdateLocation(out var OutLocation);
				BGSimpleOverlapMgrData.AddGridInfo(RegistedActor, new FVector2D(OutLocation.X, OutLocation.Y));
				BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.GridSize, out var ConfigInfo);
				if (ConfigInfo != null)
				{
					BGSimpleOverlapMgrData.SetGridSize(ConfigInfo.FloatValue);
				}
				entityUpdateInfo.IsPlayer = true;
			}
		}
		else if (RegistedActor is BGUProjectileBaseActor bGUProjectileBaseActor)
		{
			if (bGUProjectileBaseActor as BGUBulletBaseCS != null)
			{
				bGW_ECSWorld.AddMask(entity, 2);
			}
			else
			{
				if (!(bGUProjectileBaseActor as BGUMagicFieldBaseCS != null))
				{
					return false;
				}
				bGW_ECSWorld.AddMask(entity, 4);
			}
			BUC_ProjectileBasicData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ProjectileBasicData>(bGUProjectileBaseActor);
			float num = 0f;
			switch (readOnlyData.CheckShapeType)
			{
			case EProjectileCheckShapeType.BoxShape:
			{
				UBoxComponent boxCollisionComp = bGUProjectileBaseActor.GetBoxCollisionComp();
				if (boxCollisionComp != null)
				{
					num += (float)(boxCollisionComp?.GetScaledBoxExtent().GetMax()).Value / 2f;
				}
				break;
			}
			case EProjectileCheckShapeType.SphereShape:
			{
				USphereComponent sphereCollisionComp = bGUProjectileBaseActor.GetSphereCollisionComp();
				if (sphereCollisionComp != null)
				{
					num += sphereCollisionComp.GetScaledSphereRadius() / 2f;
				}
				break;
			}
			case EProjectileCheckShapeType.CapsuleShape:
			{
				UCapsuleComponent capsuleCollisionComp = bGUProjectileBaseActor.GetCapsuleCollisionComp();
				if (capsuleCollisionComp != null)
				{
					num += capsuleCollisionComp.GetScaledCapsuleHalfHeight() + capsuleCollisionComp.GetScaledCapsuleRadius();
				}
				break;
			}
			case EProjectileCheckShapeType.CustomShape:
			{
				UStaticMeshComponent customCollisionComp = bGUProjectileBaseActor.GetCustomCollisionComp();
				if (customCollisionComp != null)
				{
					customCollisionComp.GetLocalBounds(out var _, out var Max);
					num += (float)Max.GetMax() / 2f;
				}
				break;
			}
			}
			entityUpdateInfo.Radius = num;
		}
		else
		{
			if (BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_DestructibleData, b1.BUC_DestructibleData>(RegistedActor) == null)
			{
				return false;
			}
			bGW_ECSWorld.AddMask(entity, 8);
			UDestructibleComponent componentByClass = RegistedActor.GetComponentByClass<UDestructibleComponent>();
			if (componentByClass != null)
			{
				componentByClass.GetChildrenComponents(bIncludeAllDescendants: false, out var Children);
				foreach (USceneComponent item in Children)
				{
					if (item as UStaticMeshComponent != null)
					{
						UBGUFunctionLibraryForCS.BGUGetBounds(item as UStaticMeshComponent, out var _, out var BoxExtent2);
						entityUpdateInfo.Radius = Math.Max((float)BoxExtent2.GetMax(), entityUpdateInfo.Radius);
					}
				}
			}
		}
		entityUpdateInfo.Mask = bGW_ECSWorld.GetMask(entity);
		if (IsUpdating.Value)
		{
			NeedRegisterEntityUpdateInfo.Add(entityUpdateInfo);
		}
		else
		{
			OnRegisterEntityUpdatenfo(entityUpdateInfo);
		}
		return true;
	}

	private void OnRegisterEntityUpdatenfo(EntityUpdateInfo ActorEntityUpdateInfo)
	{
		BGSimpleOverlapMgrData.EntityUpdateInfoDic[ActorEntityUpdateInfo.Ent] = ActorEntityUpdateInfo;
	}

	public override int GetTickGroupMask()
	{
		return 2048;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (DebugConfig.DrawSimpleOverlapDebug)
		{
			BGSimpleOverlapMgrData.DrawDebugGrid(Owner);
		}
		if (!UseThread)
		{
			UpdateAllEntityInfoInGrids();
		}
		else if (!IsUpdating.Value)
		{
			SwapNeedUpdateInfo();
			GSThreadPool.Instance.QueueFastTask(default(GSThreadPool.TaskData), ThreadFunc, this);
		}
	}

	private void ThreadFunc(object State)
	{
		IsUpdating.SetValue(EChangeReason.InnerOp, value: true);
		ResolveNeedUpdateInfo_Thread();
		UpdateAllEntityInfoInGrids();
		BGSimpleOverlapMgrData.ThreadEvent.Set();
		IsUpdating.SetValue(EChangeReason.InnerOp, value: false);
	}

	private void UpdateAllEntityInfoInGrids()
	{
		if (BGSimpleOverlapMgrData.EntityUpdateInfoDic == null)
		{
			return;
		}
		foreach (KeyValuePair<Entity, EntityUpdateInfo> item in BGSimpleOverlapMgrData.EntityUpdateInfoDic)
		{
			Entity key = item.Key;
			EntityUpdateInfo value = item.Value;
			if (value.ActorTransformInfoData == null)
			{
				continue;
			}
			value.ActorTransformInfoData.GetNextUpdateLocation(out var OutLocation);
			FVector2D fVector2D = new FVector2D(OutLocation.X, OutLocation.Y);
			if (value.IsPlayer)
			{
				BGSimpleOverlapMgrData.UpdateGridLocation(key, fVector2D);
			}
			foreach (KeyValuePair<Entity, BGUGridInfo> gridInfo in BGSimpleOverlapMgrData.GridInfos)
			{
				Entity key2 = gridInfo.Key;
				BGUGridInfo value2 = gridInfo.Value;
				UpdateEntityInfoInOneGrid(key2, value2, value, fVector2D);
			}
		}
	}

	private void UpdateEntityInfoInOneGrid(Entity GridEnt, BGUGridInfo GridInfo, EntityUpdateInfo EntUpdateInfo, FVector2D LocationTwoD)
	{
		CurIndexMappingList.Clear();
		bool flag = false;
		if (EntUpdateInfo.Radius == 0f)
		{
			FVector2D gridIndex = BGSimpleOverlapMgrData.GetGridIndex(LocationTwoD, GridInfo.CenterLocation);
			if (BGSimpleOverlapMgrData.CheckIndexValid(gridIndex))
			{
				flag = true;
				CurIndexMappingList.Add(gridIndex);
			}
		}
		else
		{
			flag = BGSimpleOverlapMgrData.GetOverlapGridIndexList(LocationTwoD, new FVector2D(EntUpdateInfo.Radius, EntUpdateInfo.Radius), GridInfo, out var OutIndexList);
			FVector2D item = default(FVector2D);
			for (int i = OutIndexList[0]; i <= OutIndexList[1]; i++)
			{
				for (int j = OutIndexList[2]; j <= OutIndexList[3]; j++)
				{
					item.Set(i, j);
					CurIndexMappingList.Add(item);
				}
			}
		}
		Entity ent = EntUpdateInfo.Ent;
		if (!flag)
		{
			if (!EntUpdateInfo.IndexMappingDic.ContainsKey(GridEnt))
			{
				return;
			}
			foreach (FVector2D item2 in EntUpdateInfo.IndexMappingDic[GridEnt])
			{
				BGSimpleOverlapMgrData.RemoveEntityInfoByIndex(item2, GridEnt, ent);
			}
			EntUpdateInfo.IndexMappingDic[GridEnt].Clear();
			return;
		}
		if (EntUpdateInfo.IndexMappingDic.TryGetValue(GridEnt, out var value))
		{
			GCFriendlyListCopyHelper.DoCopy(value, LastIndexListTemp);
			GCFriendlyListCopyHelper.DoCopy(CurIndexMappingList, EntUpdateInfo.IndexMappingDic[GridEnt]);
			for (int num = CurIndexMappingList.Count - 1; num >= 0; num--)
			{
				FVector2D fVector2D = CurIndexMappingList[num];
				if (LastIndexListTemp.Contains(fVector2D) && BGSimpleOverlapMgrData.CheckIndexValid(fVector2D))
				{
					List<BGUEntityInfo> entityInfoList = GridInfo.Grid[(int)fVector2D.X, (int)fVector2D.Y].EntityInfoList;
					if (entityInfoList == null || entityInfoList.Count == 0)
					{
						LastIndexListTemp.Remove(fVector2D);
					}
					else
					{
						foreach (BGUEntityInfo item3 in entityInfoList)
						{
							if (item3.Actor == EntUpdateInfo.Actor)
							{
								CurIndexMappingList.RemoveAt(num);
								LastIndexListTemp.Remove(fVector2D);
								break;
							}
						}
					}
				}
			}
			foreach (FVector2D item4 in LastIndexListTemp)
			{
				BGSimpleOverlapMgrData.RemoveEntityInfoByIndex(item4, GridEnt, ent);
			}
		}
		else
		{
			EntUpdateInfo.IndexMappingDic[GridEnt] = new List<FVector2D>(CurIndexMappingList);
		}
		foreach (FVector2D curIndexMapping in CurIndexMappingList)
		{
			BGSimpleOverlapMgrData.CreateNewEntityInfoInGridByIndex(curIndexMapping, GridEnt, EntUpdateInfo);
		}
		if (!DebugConfig.DrawSimpleOverlapDebug)
		{
			return;
		}
		FVector2D fVector2D2 = GridInfo.CenterLocation - new FVector2D(4.5f * BGSimpleOverlapMgrData.GetGridSize(), 4.5f * BGSimpleOverlapMgrData.GetGridSize());
		foreach (FVector2D item5 in EntUpdateInfo.IndexMappingDic[GridEnt])
		{
			int num2 = (int)item5.X;
			int num3 = (int)item5.Y;
			FVector2D fVector2D3 = new FVector2D(fVector2D2.X + (float)num2 * BGSimpleOverlapMgrData.GetGridSize(), fVector2D2.Y + (float)num3 * BGSimpleOverlapMgrData.GetGridSize());
			FVector2D fVector2D4 = new FVector2D(fVector2D3.X + BGSimpleOverlapMgrData.GetGridSize(), fVector2D3.Y);
			FVector2D fVector2D5 = new FVector2D(fVector2D3.X + BGSimpleOverlapMgrData.GetGridSize(), fVector2D3.Y + BGSimpleOverlapMgrData.GetGridSize());
			FVector2D fVector2D6 = new FVector2D(fVector2D3.X, fVector2D3.Y + BGSimpleOverlapMgrData.GetGridSize());
			EntUpdateInfo.ActorTransformInfoData.GetNextUpdateLocation(out var OutLocation);
			USystemLibrary.DrawDebugLine(Owner, new FVector(fVector2D3.X, fVector2D3.Y, OutLocation.Z), new FVector(fVector2D4.X, fVector2D4.Y, OutLocation.Z), FLinearColor.Red, 0.1f, 10f);
			USystemLibrary.DrawDebugLine(Owner, new FVector(fVector2D4.X, fVector2D4.Y, OutLocation.Z), new FVector(fVector2D5.X, fVector2D5.Y, OutLocation.Z), FLinearColor.Red, 0.1f, 10f);
			USystemLibrary.DrawDebugLine(Owner, new FVector(fVector2D5.X, fVector2D5.Y, OutLocation.Z), new FVector(fVector2D6.X, fVector2D6.Y, OutLocation.Z), FLinearColor.Red, 0.1f, 10f);
			USystemLibrary.DrawDebugLine(Owner, new FVector(fVector2D6.X, fVector2D6.Y, OutLocation.Z), new FVector(fVector2D3.X, fVector2D3.Y, OutLocation.Z), FLinearColor.Red, 0.1f, 10f);
			USystemLibrary.DrawDebugCircle(Owner, new FVector(LocationTwoD.X, LocationTwoD.Y, OutLocation.Z), EntUpdateInfo.Radius, 20, FLinearColor.Red, 0.1f, 10f, FVector.ForwardVector, FVector.RightVector, bDrawAxis: false);
		}
	}
}
