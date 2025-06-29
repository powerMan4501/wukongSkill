using System.Collections.Generic;
using b1.ECS;
using GurGsPersistent;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class BGU_DataUtil
{
	public const string ReplayGuidDotEscapeStr = "___";

	public static T GetReadOnlyData<T>(EntitySharedRef Ref) where T : class, IPersistentECSData, new()
	{
		return (T)GetReadOnlyData(Ref, TypeManager.GetTypeIndex<T>());
	}

	public static object GetReadOnlyData(EntitySharedRef Ref, int TypeIndex)
	{
		BGW_ECSWorld bGW_ECSWorld = BGW_ECSWorld.Get(EntitySharedRefFuncLib.Entity(Ref));
		if (bGW_ECSWorld == null)
		{
			return null;
		}
		object obj = bGW_ECSWorld.GetObject(EntitySharedRefFuncLib.Entity(Ref), TypeIndex);
		if (obj != null)
		{
			return obj;
		}
		obj = bGW_ECSWorld.GetDataSafe(EntitySharedRefFuncLib.Entity(Ref), TypeIndex);
		if (obj != null)
		{
			return obj;
		}
		return null;
	}

	public static T GetReadOnlyData<T>(AActor Actor) where T : class, IPersistentECSData, new()
	{
		return (T)GetReadOnlyData(Actor, TypeManager.GetTypeIndex<T>());
	}

	public static object GetReadOnlyData(AActor Actor, int TypeIndex)
	{
		return GetUnPersistentReadOnlyData(Actor, TypeIndex);
	}

	public static T GetReadOnlyData<T>(Entity Ent) where T : class, IPersistentECSData, new()
	{
		return (T)GetUnPersistentReadOnlyData(Ent, TypeManager.GetTypeIndex<T>());
	}

	public static object GetUnPersistentReadOnlyData(AActor Actor, int TypeIndex)
	{
		if (!(Actor is IECSWorldObj iECSWorldObj))
		{
			return null;
		}
		return iECSWorldObj.GetDataByChunk(TypeIndex);
	}

	public static object GetUnPersistentReadOnlyData(Entity Ent, int TypeIndex)
	{
		return GetUnPersistentReadOnlyData(BGW_ECSWorld.Get(Ent), Ent, TypeIndex);
	}

	public static IT GetUnPersistentReadOnlyData<IT, T>(BGW_ECSWorld ECSWorld, Entity Ent) where T : class, IT, new()
	{
		return (IT)GetUnPersistentReadOnlyData(ECSWorld, Ent, TypeManager.GetTypeIndex<T>());
	}

	public static T GetUnPersistentReadOnlyData<T>(BGW_ECSWorld ECSWorld, Entity Ent) where T : class, new()
	{
		return (T)GetUnPersistentReadOnlyData(ECSWorld, Ent, TypeManager.GetTypeIndex<T>());
	}

	public static object GetUnPersistentReadOnlyData(BGW_ECSWorld ECSWorld, Entity Ent, int TypeIndex)
	{
		if (ECSWorld == null)
		{
			return null;
		}
		object obj = ECSWorld.GetObject(Ent, TypeIndex);
		if (obj != null)
		{
			return obj;
		}
		return ECSWorld.GetDataSafe(Ent, TypeIndex);
	}

	public static T GetGameStateReadonlyData<T>(AActor Actor) where T : class, IPersistentECSData, new()
	{
		if (Actor == null)
		{
			return null;
		}
		BGGGameStateCS bGGGameStateCS = UGameplayStatics.GetGameState(Actor.World) as BGGGameStateCS;
		if (bGGGameStateCS != null)
		{
			return (T)GetReadOnlyData(bGGGameStateCS, TypeManager.GetTypeIndex<T>());
		}
		return null;
	}

	public static T GetGameModeReadonlyData<T>(AActor Actor) where T : class, IPersistentECSData, new()
	{
		if (Actor == null)
		{
			return null;
		}
		BGG_GameMode bGG_GameMode = UGameplayStatics.GetGameMode(Actor.World) as BGG_GameMode;
		if (bGG_GameMode != null)
		{
			return (T)GetReadOnlyData(bGG_GameMode, TypeManager.GetTypeIndex<T>());
		}
		return null;
	}

	public static T GetGameStateReadonlyData<T>(UObject Obj) where T : class, IPersistentECSData, new()
	{
		BGGGameStateCS bGGGameStateCS = UGameplayStatics.GetGameState(Obj) as BGGGameStateCS;
		if (bGGGameStateCS != null)
		{
			return (T)GetReadOnlyData(bGGGameStateCS, TypeManager.GetTypeIndex<T>());
		}
		return null;
	}

	public static IT GetGameStateReadonlyData<IT, T>(UObject Obj) where IT : class where T : class, IPersistentECSData, IT, new()
	{
		BGGGameStateCS bGGGameStateCS = UGameplayStatics.GetGameState(Obj) as BGGGameStateCS;
		if (bGGGameStateCS != null)
		{
			return (IT)(T)GetReadOnlyData(bGGGameStateCS, TypeManager.GetTypeIndex<T>());
		}
		return null;
	}

	public static IT GetPlayerControlReadonlyData<IT, T>(APlayerController PlayerController) where IT : class where T : class, IPersistentECSData, IT, new()
	{
		return (IT)GetUnPersistentReadOnlyData(PlayerController, TypeManager.GetTypeIndex<T>());
	}

	public static IT GetPlayerStateReadonlyData<IT, T>(APlayerController PlayerController) where IT : class where T : class, IPersistentECSData, IT, new()
	{
		return (IT)GetUnPersistentReadOnlyData(PlayerController?.PlayerState, TypeManager.GetTypeIndex<T>());
	}

	public static IT GetPlayerStateReadonlyData<IT, T>(APlayerState PlayerState) where IT : class where T : class, IPersistentECSData, IT, new()
	{
		return (IT)GetUnPersistentReadOnlyData(PlayerState, TypeManager.GetTypeIndex<T>());
	}

	public static IT GetGameInstanceReadonlyData<IT, T>(UObject WorldContext) where IT : class where T : class, IT
	{
		BGW_GameDataMgr bGW_GameDataMgr = BGW_GameDataMgr.Get(WorldContext);
		if ((object)bGW_GameDataMgr == null)
		{
			return null;
		}
		return bGW_GameDataMgr.GetGameInstanceReadonlyData<IT, T>();
	}

	public static int GetFinalBattleInfoExtendID(AActor Unit)
	{
		if (Unit != null && Unit is BGUCharacterCS bGUCharacterCS)
		{
			return bGUCharacterCS.GetFinalBattleInfoExtendID();
		}
		return 0;
	}

	public static int GetActorTeamID(AActor Unit)
	{
		BGUCharacterCS bGUCharacterCS = Unit as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			return bGUCharacterCS.GetTeamIDInCS();
		}
		return 0;
	}

	public static int GetActorResID(AActor Unit)
	{
		BGUCharacterCS bGUCharacterCS = Unit as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			return bGUCharacterCS.GetResID();
		}
		return 0;
	}

	public static int GetActorResID(EntitySharedRef entity)
	{
		return ((IBUC_ConfigInfoData)GetReadOnlyData<BUC_ConfigInfoData>(entity))?.ResID ?? 0;
	}

	public static int GetActorResIDInEditor(AActor Unit)
	{
		BUS_ConfigInfoComp componentByClass = Unit.GetComponentByClass<BUS_ConfigInfoComp>();
		if (componentByClass != null)
		{
			return componentByClass.UnitCDesc.ResID;
		}
		return 0;
	}

	public static object GetDataByEntityChunk(int TypeIndex, Entity Ent, Chunk EntityChunk, int EntityIndexInChunk)
	{
		if (EntityChunk == null)
		{
			if (Ent.IsNull())
			{
				return null;
			}
			return GetUnPersistentReadOnlyData(Ent, TypeIndex);
		}
		return EntityChunk.GetObjectOrDataSafe(TypeIndex, EntityIndexInChunk);
	}

	public static BGU_ActorType GetActorType(AActor Actor)
	{
		return GetReadOnlyData<BUC_ActorBasicData>(Actor)?.ActorType ?? BGU_ActorType.None;
	}

	public static bool GetIsFriendlyTeam(AActor Caster, AActor Target)
	{
		return !BGUFunctionLibraryCS.BGUIsEnemyTeam(Caster, Target);
	}

	public static bool GetIsTrap(AActor Target)
	{
		BGW_GameDB.GetUnitCommDesc(GetActorResID(Target));
		return false;
	}

	public static bool GetIsInPlayerTeam(AActor Unit)
	{
		APawn aPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Unit)?.GetControlledPawn();
		if (aPawn != null)
		{
			BGUCharacterCS bGUCharacterCS = aPawn as BGUCharacterCS;
			BGUCharacterCS bGUCharacterCS2 = Unit as BGUCharacterCS;
			if (!bGUCharacterCS.IsNullOrDestroyed() && !bGUCharacterCS2.IsNullOrDestroyed() && !BGUFunctionLibraryCS.BGUIsEnemyTeam(bGUCharacterCS2, bGUCharacterCS))
			{
				return true;
			}
		}
		return false;
	}

	public static bool GetIsPlayer(AActor Unit)
	{
		APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Unit).GetControlledPawn();
		if (controlledPawn != null)
		{
			BGUCharacterCS bGUCharacterCS = controlledPawn as BGUCharacterCS;
			BGUCharacterCS bGUCharacterCS2 = Unit as BGUCharacterCS;
			if (!bGUCharacterCS.IsNullOrDestroyed() && !bGUCharacterCS2.IsNullOrDestroyed() && bGUCharacterCS2 == bGUCharacterCS)
			{
				return true;
			}
		}
		return false;
	}

	public static AActor GetActorByGuid(UObject WorldContext, string UnitGuid)
	{
		if (GetGameInstanceReadonlyData<IBIC_GlobalActorData, BIC_GlobalActorData>(WorldContext).GetActorEntity(UnitGuid, out var Entity))
		{
			return ECSUtil.ToActor(Entity);
		}
		return null;
	}

	public static bool GetEntityByGuid(UObject WorldContext, string UnitGuid, out Entity _Entity)
	{
		if (GetGameInstanceReadonlyData<IBIC_GlobalActorData, BIC_GlobalActorData>(WorldContext).GetActorEntity(UnitGuid, out _Entity))
		{
			return true;
		}
		return false;
	}

	public static List<AActor> GetGroupUnitsByGroupGuid(UObject WorldContext, string GroupUnitGuid)
	{
		List<AActor> list = new List<AActor>();
		IBGC_TamerData gameStateReadonlyData = GetGameStateReadonlyData<BGC_TamerData>(WorldContext);
		if (gameStateReadonlyData != null && gameStateReadonlyData.GetAllMonsterGuidByGroupGuid(GroupUnitGuid, out var OutResult))
		{
			foreach (KeyValuePair<string, FTamerRef> item in OutResult)
			{
				if (item.Value.MonsterInstancePtr.IsValid())
				{
					list.Add(item.Value.MonsterInstancePtr.Get());
				}
			}
		}
		return list;
	}

	public static string GetActorGuid(AActor Unit, bool bFindFromComponent = false)
	{
		if (Unit == null)
		{
			return "";
		}
		if (Unit is BUTamerActor bUTamerActor)
		{
			return bUTamerActor.GetFinalGuid();
		}
		IBUC_GuidData readOnlyData = GetReadOnlyData<IBUC_GuidData, BUC_GuidData>(Unit);
		if (readOnlyData == null)
		{
			if (!bFindFromComponent)
			{
				return "";
			}
			return BGUFuncLibSceneObj.BGUGetFinalGuidByComponent(Unit);
		}
		return readOnlyData.GetFinalGuid();
	}

	public static IT GetReadOnlyData<IT, T>(AActor actor) where IT : class where T : class, IT, IPersistentECSData, new()
	{
		return (IT)GetReadOnlyData<T>(actor);
	}

	public static IT GetUnPersistentReadOnlyData<IT, T>(AActor actor) where IT : class where T : class, IT, new()
	{
		if (!(actor is IECSWorldObj))
		{
			return null;
		}
		return (IT)(actor as IECSWorldObj).GetDataByChunk(TypeManager.GetTypeIndex<T>());
	}

	public static T GetUnPersistentReadOnlyData<T>(AActor actor) where T : class, new()
	{
		if (!(actor is IECSWorldObj))
		{
			return null;
		}
		return (T)(actor as IECSWorldObj).GetDataByChunk(TypeManager.GetTypeIndex<T>());
	}

	public static void OnDisPlayerShowTime(AActor PlayerChr, bool IsReMove)
	{
	}

	public static void OnTriggerSeqHiddenPlayer(AActor PlayerChr, bool IsReMove)
	{
	}

	public static PersistentBPCData GenNewPersistentBPCData()
	{
		return new PersistentBPCData
		{
			BPCPlayerAttrData = new GurGsPersistent.BPC_PlayerAttrData(),
			BPCPlayerRoleData = new GurGsPersistent.BPC_PlayerRoleData(),
			BPCRebirthPointData = new GurGsPersistent.BPC_RebirthPointData()
		};
	}

	public static PersistentBGCData GenNewPersistentBGCData()
	{
		return new PersistentBGCData
		{
			BGCCollectionGroupData = new GurGsPersistent.BGC_CollectionGroupData(),
			BGCGameStateTestData = new GurGsPersistent.BGC_GameStateTestData()
		};
	}

	public static PersistentECSData GenNewPersistentECSData()
	{
		return new PersistentECSData
		{
			BPCData = GenNewPersistentBPCData(),
			BGCData = GenNewPersistentBGCData()
		};
	}

	public static TamerCharacterNameAllocator GetOrAllocTamerCharacterNameAllocator(UObject WorldContext, string TamerGUID)
	{
		return GetGameStateReadonlyData<BGC_TamerData>(WorldContext)?.GetOrAllocTamerCharacterNameAllocator(TamerGUID);
	}
}
