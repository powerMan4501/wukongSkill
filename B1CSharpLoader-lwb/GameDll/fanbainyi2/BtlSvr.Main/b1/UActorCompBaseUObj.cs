using System;
using System.Collections.Generic;
using b1.BGW;
using b1.ECS;
using b1.GameState;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.ActorCompBaseUObj")]
public class UActorCompBaseUObj : UObject, IEntityComponent, IActorCompBase, ICallbackValidator
{
	private UActorCompContainerCS OwnerContainer;

	protected AActor Owner;

	public IECSWorldObj CachedOwnerECS;

	public int NetRoleFilter;

	public int OwnerNetRole;

	public int RejectNetRoleFilter;

	private Entity Ent;

	private BGW_ECSWorld ECSWorld;

	protected BGW_PauseGameMgr PauseGameMgr;

	public BGW_PreloadAssetMgr PreloadAssetMgr;

	protected BGGGameStateB1 GameState;

	protected float CustomTimeDilation = 1f;

	private IBUC_TickRateData TickRateData;

	private IBUC_TickRateData TickRateDataForAccumlateDeltaTime;

	private bool IsCanTickVal = true;

	protected List<GSEventCollectionBase> RelativeEventCollection = new List<GSEventCollectionBase>();

	protected BUS_GSEventCollection BUSEventCollection { get; private set; }

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
		BUS_EventCollectionCS.Get(this)?.RefreshEntityComponentEventReg(this);
		foreach (GSEventCollectionBase item in RelativeEventCollection)
		{
			item.RefreshEntityComponentEventReg(this);
		}
	}

	public void RecalculateCanTick()
	{
		b1.ActorCompBaseShareUtil.RecalculateCanTick(OwnerContainer.HasLateBeginPlay, this, TickRateData, PauseGameMgr, out TickRateDataForAccumlateDeltaTime);
	}

	public virtual void OnNetActive()
	{
		FreshEventRegs();
	}

	public virtual void OnNetDeActive()
	{
		FreshEventRegs();
	}

	public void Init(UActorCompContainerCS Container)
	{
		OwnerContainer = Container;
		CachedOwnerECS = (Owner = Container.Owner) as IECSWorldObj;
		Ent = Container.Entity;
		ECSWorld = Container.ECSWorld;
		PauseGameMgr = Container.PauseGameMgr;
		PreloadAssetMgr = Container.PreloadAssetMgr;
		GameState = Container.GameState;
		TickRateData = Container.TickRateData;
		TickRateDataForAccumlateDeltaTime = BUC_TickRateData.TickDisabledVersion;
		BUSEventCollection = Container.BUSEventCollection;
		BGSEventCollection = Container.BGSEventCollection;
		BGWEventCollection = Container.BGWEventCollection;
	}

	public int GetActorResID()
	{
		return BGU_DataUtil.GetActorResID(Owner);
	}

	public int GetFinalBattleInfoExtendID()
	{
		return BGU_DataUtil.GetFinalBattleInfoExtendID(Owner);
	}

	protected IT RequireReadOnlyGameStateData<IT, T>() where IT : class where T : class, IPersistentECSData, new()
	{
		return BGU_DataUtil.GetReadOnlyData<T>(GameState) as IT;
	}

	protected IT RequireReadOnlyData<IT, T>() where IT : class where T : class, new()
	{
		return (IT)CachedOwnerECS.GetDataByChunk(TypeManager.GetTypeIndex<T>());
	}

	protected IT RequireReadonlyGameInstanceData<IT, T>() where IT : class where T : class, IT
	{
		return BGU_DataUtil.GetGameInstanceReadonlyData<IT, T>(Owner);
	}

	protected T RequireWritableControledPlayerStateData<T>() where T : class, IPersistentECSData, new()
	{
		APawn aPawn = Owner as APawn;
		AController aController = Owner as AController;
		if (aPawn != null && aPawn.PlayerState != null)
		{
			return BGU_DataUtil.GetReadOnlyData<T>(aPawn.PlayerState);
		}
		if (aController != null && aController.PlayerState != null)
		{
			return BGU_DataUtil.GetReadOnlyData<T>(aController.PlayerState);
		}
		return null;
	}

	protected IT RequireReadOnlyControledPlayerStateData<IT, T>() where IT : class where T : class, IPersistentECSData, new()
	{
		return RequireWritableControledPlayerStateData<T>() as IT;
	}

	protected IT RequireReadOnlyLocalPlayerStateData<IT, T>() where IT : class where T : class, IT, IPersistentECSData, new()
	{
		APlayerState playerState = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner).PlayerState;
		if (playerState == null)
		{
			return null;
		}
		return (IT)BGU_DataUtil.GetReadOnlyData<T>(playerState);
	}

	protected T RequireWritableData<T>() where T : class, new()
	{
		return (T)CachedOwnerECS.GetDataByChunk(TypeManager.GetTypeIndex<T>());
	}

	public IECSWorldObj GetOwnerAsECS()
	{
		return CachedOwnerECS;
	}

	public AActor GetOwner()
	{
		return Owner;
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

	protected void SetCanTick(bool Val)
	{
		if (IsCanTickVal != Val)
		{
			IsCanTickVal = Val;
			RecalculateCanTick();
		}
	}

	public virtual bool CanTick()
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

	public int GetOwnerNetRole()
	{
		return OwnerNetRole;
	}

	public int GetRejectNetRoleFilter()
	{
		return RejectNetRoleFilter;
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

	public float GetCustomTimeDilation()
	{
		return CustomTimeDilation;
	}

	public void SetCustomTimeDilation(float NewCustomTimeDilation)
	{
		CustomTimeDilation = NewCustomTimeDilation;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.ActorCompBaseUObj");
	}

	static UActorCompBaseUObj()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UActorCompBaseUObj)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UActorCompBaseUObj));
	}
}
