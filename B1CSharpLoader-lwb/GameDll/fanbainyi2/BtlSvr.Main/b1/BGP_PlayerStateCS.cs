using System;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGP_PlayerStateCS")]
public abstract class BGP_PlayerStateCS : ABGPPlayerState, IECSWorldObj
{
	protected Entity mECSEntity;

	protected Chunk mECSChunk;

	protected int mECSIndexInChunk;

	private static bool ActorCompContainerCS_IsValid;

	private static int ActorCompContainerCS_Offset;

	private static bool ReceiveEndPlay_IsValid;

	private static IntPtr ReceiveEndPlay_FunctionAddress;

	private static int ReceiveEndPlay_ParamsSize;

	private static bool ReceiveEndPlay_EndPlayReason_IsValid;

	private static int ReceiveEndPlay_EndPlayReason_Offset;

	private static FFieldAddress ReceiveEndPlay_EndPlayReason_PropertyAddress;

	private static bool ReceiveDestroyed_IsValid;

	private static IntPtr ReceiveDestroyed_FunctionAddress;

	private static int ReceiveDestroyed_ParamsSize;

	private static bool PostInitializeComponentsCS_IsValid;

	private static IntPtr PostInitializeComponentsCS_FunctionAddress;

	private static int PostInitializeComponentsCS_ParamsSize;

	public Entity ECSEntity
	{
		get
		{
			return mECSEntity;
		}
		set
		{
			mECSEntity = value;
		}
	}

	public Chunk ECSChunk
	{
		get
		{
			return mECSChunk;
		}
		set
		{
			mECSChunk = value;
		}
	}

	public int ECSIndexInChunk
	{
		get
		{
			return mECSIndexInChunk;
		}
		set
		{
			mECSIndexInChunk = value;
		}
	}

	public UActorDataContainer DataComp => base.BGPDataComp;

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGP_PlayerStateCS:ActorCompContainerCS")]
	public UActorCompContainerCS ActorCompContainerCS
	{
		get
		{
			CheckDestroyed();
			if (!ActorCompContainerCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGP_PlayerStateCS:ActorCompContainerCS");
				return null;
			}
			return UObjectMarshaler<UActorCompContainerCS>.FromNative(IntPtr.Add(base.Address, ActorCompContainerCS_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorCompContainerCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGP_PlayerStateCS:ActorCompContainerCS");
			}
			else
			{
				UObjectMarshaler<UActorCompContainerCS>.ToNative(IntPtr.Add(base.Address, ActorCompContainerCS_Offset), value);
			}
		}
	}

	public BTF_EventCollectionCS BattleToFluxSvcCollection { get; set; } = new BTF_EventCollectionCS();

	public BPS_GSEventCollection PlayerEventCollection { get; set; }

	public UPlayerTransactionEventCollection PlayerTransactionEventCollection { get; set; }

	public int ECSArcheType => 4;

	public object GetDataByChunk(int TypeIndex)
	{
		return BGU_DataUtil.GetDataByEntityChunk(TypeIndex, mECSEntity, mECSChunk, mECSIndexInChunk);
	}

	public sealed override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		ActorCompContainerCS = initializer.CreateDefaultSubobject<UActorCompContainerCS>(this, B1GlobalFNames.ActorCompContainerCS);
		CreateDataContainer(initializer);
	}

	public Entity GetECSEntity()
	{
		return ECSEntity;
	}

	protected virtual void CreateDataContainer(FObjectInitializer initializer)
	{
		PlayerEventCollection = initializer.CreateDefaultSubobject<BPS_GSEventCollection>(this, B1GlobalFNames.PlayerEventCollection);
		PlayerTransactionEventCollection = initializer.CreateDefaultSubobject<UPlayerTransactionEventCollection>(this, B1GlobalFNames.PlayerTransactionEventCollection);
	}

	public object GetEventCollection()
	{
		return PlayerEventCollection;
	}

	public UPlayerTransactionEventCollection GetPlayerTransactionEventCollection()
	{
		return PlayerTransactionEventCollection;
	}

	public virtual void InitAllComp()
	{
		ActorCompContainerCS.AddComp(new BPS_DataReplicationSystemClient(), 8);
		ActorCompContainerCS.AddComp(new BPS_DataReplicationSystemSvr(), 2);
		ActorCompContainerCS.AddComp(new BPS_ClientRoleStateDataMgrSystem(), 16);
		ActorCompContainerCS.AddComp(new b1.BPS_SummonSystemSvr(), 2);
		ActorCompContainerCS.AddComp(new BPS_SummonSystemClient(), 10);
	}

	public virtual void AfterInitAllComp()
	{
	}

	[USharpPath("/Script/b1-Managed.BGP_PlayerStateCS:PostInitializeComponentsCS")]
	protected override void PostInitializeComponentsCS_Implementation()
	{
		base.PostInitializeComponentsCS_Implementation();
		BGW_ECSWorld.RegisterDataComp(DataComp);
	}

	[USharpPath("/Script/b1-Managed.BGP_PlayerStateCS:ReceiveEndPlay")]
	protected override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		base.ReceiveEndPlay_Implementation(EndPlayReason);
		BGW_ECSWorld.UnRegisterDataComp(DataComp);
	}

	[USharpPath("/Script/b1-Managed.BGP_PlayerStateCS:ReceiveDestroyed")]
	protected override void ReceiveDestroyed_Implementation()
	{
		base.ReceiveDestroyed_Implementation();
		BGW_ECSWorld.UnRegisterDataComp(DataComp);
	}

	public bool IsBeginPlayFinished()
	{
		return ActorCompContainerCS.HasLateBeginPlay;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGP_PlayerStateCS:ReceiveEndPlay")]
	private static void ReceiveEndPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGP_PlayerStateCS bGP_PlayerStateCS = GCHelper.Find<BGP_PlayerStateCS>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address);
		bGP_PlayerStateCS.ReceiveEndPlay_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGP_PlayerStateCS:ReceiveDestroyed")]
	private static void ReceiveDestroyed__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGP_PlayerStateCS bGP_PlayerStateCS = GCHelper.Find<BGP_PlayerStateCS>(obj);
		bGP_PlayerStateCS.ReceiveDestroyed_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGP_PlayerStateCS:PostInitializeComponentsCS")]
	private static void PostInitializeComponentsCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGP_PlayerStateCS bGP_PlayerStateCS = GCHelper.Find<BGP_PlayerStateCS>(obj);
		bGP_PlayerStateCS.PostInitializeComponentsCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGP_PlayerStateCS");
		ActorCompContainerCS_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorCompContainerCS");
		ActorCompContainerCS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorCompContainerCS", Classes.FObjectProperty);
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGP_PlayerStateCS:ReceiveEndPlay", ReceiveEndPlay_IsValid);
		ReceiveDestroyed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveDestroyed");
		ReceiveDestroyed_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveDestroyed_FunctionAddress);
		ReceiveDestroyed_IsValid = ReceiveDestroyed_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGP_PlayerStateCS:ReceiveDestroyed", ReceiveDestroyed_IsValid);
		PostInitializeComponentsCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostInitializeComponentsCS");
		PostInitializeComponentsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostInitializeComponentsCS_FunctionAddress);
		PostInitializeComponentsCS_IsValid = PostInitializeComponentsCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGP_PlayerStateCS:PostInitializeComponentsCS", PostInitializeComponentsCS_IsValid);
	}

	static BGP_PlayerStateCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGP_PlayerStateCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGP_PlayerStateCS));
	}
}
