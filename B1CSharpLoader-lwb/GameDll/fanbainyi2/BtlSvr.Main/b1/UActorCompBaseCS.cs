using System.Collections.Generic;
using b1.BGW;
using b1.ECS;
using b1.GameState;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class UActorCompBaseCS : IEntityComponent, IActorCompBase, ICallbackValidator
{
	protected AActor Owner;

	protected BGUCharacterCS OwnerAsCharacterCS;

	public IECSWorldObj CachedOwnerECS;

	private Entity Ent;

	private BGW_ECSWorld ECSWorld;

	protected BGW_PauseGameMgr PauseGameMgr;

	public BGW_PreloadAssetMgr PreloadAssetMgr;

	protected BGGGameStateB1 GameState;

	private UActorCompContainerCS OwnerContainer;

	protected float CustomTimeDilation = 1f;

	private bool IsCanTickVal = true;

	private IBUC_TickRateData TickRateData;

	private IBUC_TickRateData TickRateDataForAccumlateDeltaTime;

	public int NetRoleFilter;

	public int RejectNetRoleFilter;

	public int OwnerNetRole;

	protected List<GSEventCollectionBase> RelativeEventCollection = new List<GSEventCollectionBase>();

	protected BUS_GSEventCollection BUSEventCollection { get; set; }

	protected BGS_GSEventCollection BGSEventCollection { get; private set; }

	protected BGW_EventCollection BGWEventCollection { get; private set; }

	public bool IsValidAcceptCallback()
	{
		if (!Owner.IsNullOrDestroyed())
		{
			return CachedOwnerECS.ActorCompContainerCS.HasBeginPlay;
		}
		return false;
	}

	protected void FreshEventRegs()
	{
		BUSEventCollection?.RefreshEntityComponentEventReg(this);
		foreach (GSEventCollectionBase item in RelativeEventCollection)
		{
			item.RefreshEntityComponentEventReg(this);
		}
	}

	public virtual void OnNetActive()
	{
		FreshEventRegs();
	}

	public virtual void OnNetDeActive()
	{
		FreshEventRegs();
	}

	protected void SetCanTick(bool Val)
	{
		if (IsCanTickVal != Val)
		{
			IsCanTickVal = Val;
			RecalculateCanTick();
		}
	}

	public void Init(UActorCompContainerCS Container)
	{
		OwnerContainer = Container;
		ECSWorld = Container.ECSWorld;
		PauseGameMgr = Container.PauseGameMgr;
		PreloadAssetMgr = Container.PreloadAssetMgr;
		GameState = Container.GameState;
		Ent = Container.Entity;
		AActor aActor = (Owner = Container.Owner);
		OwnerAsCharacterCS = aActor as BGUCharacterCS;
		CachedOwnerECS = aActor as IECSWorldObj;
		TickRateData = Container.TickRateData;
		TickRateDataForAccumlateDeltaTime = BUC_TickRateData.TickDisabledVersion;
		BUSEventCollection = Container.BUSEventCollection;
		BGSEventCollection = Container.BGSEventCollection;
		BGWEventCollection = Container.BGWEventCollection;
	}

	public int GetActorResID()
	{
		if (OwnerAsCharacterCS != null)
		{
			return OwnerAsCharacterCS.GetResID();
		}
		return 0;
	}

	public int GetFinalBattleInfoExtendID()
	{
		if (OwnerAsCharacterCS != null)
		{
			return OwnerAsCharacterCS.GetFinalBattleInfoExtendID();
		}
		return 0;
	}

	public bool IsOnline()
	{
		if ((OwnerNetRole & 4) > 0)
		{
			return true;
		}
		if ((OwnerNetRole & 8) > 0)
		{
			return true;
		}
		return false;
	}

	protected IT RequireReadOnlyGameStateData<IT, T>() where IT : class where T : class, IPersistentECSData, new()
	{
		return BGU_DataUtil.GetReadOnlyData(GameState, TypeManager.GetTypeIndex<T>()) as IT;
	}

	protected IT RequireReadonlyGameInstanceData<IT, T>() where IT : class where T : class, IT
	{
		return BGU_DataUtil.GetGameInstanceReadonlyData<IT, T>(Owner);
	}

	protected IT RequireReadOnlyData<IT, T>() where IT : class where T : class, IT, new()
	{
		return (IT)CachedOwnerECS.GetDataByChunk(TypeManager.GetTypeIndex<T>());
	}

	protected T RequireWritableData<T>() where T : class, new()
	{
		return (T)CachedOwnerECS.GetDataByChunk(TypeManager.GetTypeIndex<T>());
	}

	protected T RequireWritableControledPlayerStateData<T>() where T : class, IPersistentECSData, new()
	{
		return RequireWritableControlledPlayerStateData(TypeManager.GetTypeIndex<T>()) as T;
	}

	protected IT RequireReadOnlyControledPlayerStateData<IT, T>() where IT : class where T : class, IPersistentECSData, IT, new()
	{
		return RequireWritableControlledPlayerStateData(TypeManager.GetTypeIndex<T>()) as IT;
	}

	private object RequireWritableControlledPlayerStateData(int TypeIndex)
	{
		if (Owner is APawn aPawn)
		{
			return BGU_DataUtil.GetReadOnlyData(aPawn.PlayerState, TypeIndex);
		}
		if (Owner is AController aController)
		{
			return BGU_DataUtil.GetReadOnlyData(aController.PlayerState, TypeIndex);
		}
		BGW_LogUtil.LogError($"RequireWritableControledPlayerStateData {Owner.GetType()} has no playerstate");
		return null;
	}

	protected IT RequireReadOnlyControlledPlayerControlData<IT, T>() where IT : class where T : class, IPersistentECSData, IT, new()
	{
		return (IT)RequireReadOnlyControlledPlayerControlData(TypeManager.GetTypeIndex<T>());
	}

	private object RequireReadOnlyControlledPlayerControlData(int TypeIndex)
	{
		if (Owner is APawn aPawn)
		{
			return BGU_DataUtil.GetReadOnlyData(aPawn.GetController(), TypeIndex);
		}
		if (Owner is AController actor)
		{
			return BGU_DataUtil.GetReadOnlyData(actor, TypeIndex);
		}
		BGW_LogUtil.LogError($"RequireReadOnlyControlledPlayerControlData {Owner.GetType()} has no player controller");
		return null;
	}

	private object RequireReadOnlyLocalPlayerStateData(int TypeIndex)
	{
		APlayerState playerState = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner).PlayerState;
		if (playerState == null)
		{
			return null;
		}
		return BGU_DataUtil.GetReadOnlyData(playerState, TypeIndex);
	}

	private object RequireReadOnlyLocalPlayerControllerData(int TypeIndex)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner);
		if (firstLocalPlayerController == null)
		{
			return null;
		}
		return BGU_DataUtil.GetReadOnlyData(firstLocalPlayerController, TypeIndex);
	}

	protected IT RequireReadOnlyLocalPlayerStateData<IT, T>() where IT : class where T : class, IPersistentECSData, IT, new()
	{
		return (IT)(T)RequireReadOnlyLocalPlayerStateData(TypeManager.GetTypeIndex<T>());
	}

	protected IT RequireReadOnlyLocalPlayerControlData<IT, T>() where IT : class where T : class, IPersistentECSData, IT, new()
	{
		return (IT)(T)RequireReadOnlyLocalPlayerControllerData(TypeManager.GetTypeIndex<T>());
	}

	protected T RequireWritableLocalPlayerStateData<T>() where T : class, IPersistentECSData, new()
	{
		return (T)RequireReadOnlyLocalPlayerStateData(TypeManager.GetTypeIndex<T>());
	}

	protected T RequireWritableLocalPlayerControlData<T>() where T : class, IPersistentECSData, new()
	{
		return (T)RequireReadOnlyLocalPlayerControllerData(TypeManager.GetTypeIndex<T>());
	}

	public AActor GetOwner()
	{
		return Owner;
	}

	public IECSWorldObj GetOwnerAsECS()
	{
		return CachedOwnerECS;
	}

	public virtual void OnAttach()
	{
	}

	public virtual void PreBeginPlay()
	{
	}

	public virtual void OnBeginPlay()
	{
	}

	public virtual void LateBeginPlay()
	{
	}

	public void RecalculateCanTick()
	{
		b1.ActorCompBaseShareUtil.RecalculateCanTick(OwnerContainer.HasLateBeginPlay, this, TickRateData, PauseGameMgr, out TickRateDataForAccumlateDeltaTime);
	}

	public bool CanTick()
	{
		return IsCanTickVal;
	}

	public virtual bool CanTickForDebug()
	{
		return false;
	}

	public virtual bool AllowTRO()
	{
		return true;
	}

	protected bool HasBegunPlay()
	{
		return OwnerContainer.HasLateBeginPlay;
	}

	public virtual float GetAccumulatedDeltaTime()
	{
		return TickRateDataForAccumlateDeltaTime.AccumulatedDeltaTime;
	}

	public virtual int GetTickGroupMask()
	{
		return 0;
	}

	public virtual void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
	}

	public virtual void OnEndPlay(EEndPlayReason EndPlayReason)
	{
	}

	public virtual void ApplyWorldOffset(FVector InOffset, bool bWorldShift)
	{
	}

	public int GetNetRoleFilter()
	{
		return NetRoleFilter;
	}

	public int GetRejectNetRoleFilter()
	{
		return RejectNetRoleFilter;
	}

	public int GetOwnerNetRole()
	{
		return OwnerNetRole;
	}

	public bool IsNetActive()
	{
		if ((OwnerNetRole & NetRoleFilter) != 0)
		{
			return (OwnerNetRole & RejectNetRoleFilter) == 0;
		}
		return false;
	}

	public Entity GetOwnerEntity()
	{
		return Ent;
	}

	public void AddRelativeEventCollection(object EventCollection)
	{
		if (EventCollection is GSEventCollectionBase)
		{
			RelativeEventCollection.Add((GSEventCollectionBase)EventCollection);
		}
		else
		{
			BGW_LogUtil.LogError($"AddRelativeEventCollection Type {EventCollection?.GetType()} Invalid");
		}
	}

	public void RemoveRelativeEventCollection(object EventCollection)
	{
		if (EventCollection is GSEventCollectionBase)
		{
			RelativeEventCollection.Remove((GSEventCollectionBase)EventCollection);
		}
		else
		{
			BGW_LogUtil.LogError($"RemoveRelativeEventCollection Type {EventCollection?.GetType()} Invalid");
		}
	}

	public virtual float GetCustomTimeDilation()
	{
		return CustomTimeDilation;
	}

	public void SetCustomTimeDilation(float NewCustomTimeDilation)
	{
		CustomTimeDilation = NewCustomTimeDilation;
	}
}
