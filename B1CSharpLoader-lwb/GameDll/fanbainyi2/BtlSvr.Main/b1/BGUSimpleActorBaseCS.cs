using System;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUSimpleActorBaseCS")]
public abstract class BGUSimpleActorBaseCS : ABGUActorBase, IECSWorldObj
{
	protected Entity mECSEntity;

	protected Chunk mECSChunk;

	protected int mECSIndexInChunk;

	private static bool DataComp_IsValid;

	private static int DataComp_Offset;

	private static bool ActorCompContainerCS_IsValid;

	private static int ActorCompContainerCS_Offset;

	private static bool BeginPlayCS_IsValid;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

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

	public bool bIsNoMoveActor { get; protected set; } = true;

	public int ECSArcheType { get; protected set; }

	private BUS_GSEventCollection RPCEventCollection { get; set; }

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGUSimpleActorBaseCS:DataComp")]
	public UActorDataContainer DataComp
	{
		get
		{
			CheckDestroyed();
			if (!DataComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSimpleActorBaseCS:DataComp");
				return null;
			}
			return UObjectMarshaler<UActorDataContainer>.FromNative(IntPtr.Add(base.Address, DataComp_Offset));
		}
		protected set
		{
			CheckDestroyed();
			if (!DataComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSimpleActorBaseCS:DataComp");
			}
			else
			{
				UObjectMarshaler<UActorDataContainer>.ToNative(IntPtr.Add(base.Address, DataComp_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGUSimpleActorBaseCS:ActorCompContainerCS")]
	public UActorCompContainerCS ActorCompContainerCS
	{
		get
		{
			CheckDestroyed();
			if (!ActorCompContainerCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSimpleActorBaseCS:ActorCompContainerCS");
				return null;
			}
			return UObjectMarshaler<UActorCompContainerCS>.FromNative(IntPtr.Add(base.Address, ActorCompContainerCS_Offset));
		}
		protected set
		{
			CheckDestroyed();
			if (!ActorCompContainerCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSimpleActorBaseCS:ActorCompContainerCS");
			}
			else
			{
				UObjectMarshaler<UActorCompContainerCS>.ToNative(IntPtr.Add(base.Address, ActorCompContainerCS_Offset), value);
			}
		}
	}

	public override void GetLifetimeReplicatedProps(FLifetimePropertyCollection lifetimeProps)
	{
		base.GetLifetimeReplicatedProps(lifetimeProps);
		lifetimeProps.Add("RPCEventCollection");
	}

	public object GetDataByChunk(int TypeIndex)
	{
		return BGU_DataUtil.GetDataByEntityChunk(TypeIndex, mECSEntity, mECSChunk, mECSIndexInChunk);
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		RPCEventCollection = initializer.CreateDefaultSubobject<BUS_GSEventCollection>(this, B1GlobalFNames.RPCEventCollection);
		ECSArcheType = 7;
		CreateDataContainer(initializer);
		base.ActorCompContainer = initializer.CreateDefaultSubobject<UActorCompContainer>(this, B1GlobalFNames.ActorCompContainer);
		ActorCompContainerCS = initializer.CreateDefaultSubobject<UActorCompContainerCS>(this, B1GlobalFNames.ActorCompContainerCS);
	}

	[USharpPath("/Script/b1-Managed.BGUSimpleActorBaseCS:PostInitializeComponentsCS")]
	protected sealed override void PostInitializeComponentsCS_Implementation()
	{
		base.PostInitializeComponentsCS_Implementation();
		BGW_ECSWorld.RegisterDataComp(DataComp);
	}

	[USharpPath("/Script/b1-Managed.BGUSimpleActorBaseCS:ReceiveEndPlay")]
	protected override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		base.ReceiveEndPlay_Implementation(EndPlayReason);
		BGW_ECSWorld.UnRegisterDataComp(DataComp);
	}

	[USharpPath("/Script/b1-Managed.BGUSimpleActorBaseCS:ReceiveDestroyed")]
	protected override void ReceiveDestroyed_Implementation()
	{
		base.ReceiveDestroyed_Implementation();
		BGW_ECSWorld.UnRegisterDataComp(DataComp);
	}

	public object GetEventCollection()
	{
		return RPCEventCollection;
	}

	public virtual void InitAllComp()
	{
		if (UBGUFunctionLibraryForCS.BGUGetIsInGameWorld(this))
		{
			base.ActorCompContainer.FillDataContainer(DataComp);
			base.ActorCompContainer.FillEventCollection(base.EventCollection);
		}
	}

	public void AfterInitAllComp()
	{
		if (bIsNoMoveActor)
		{
			ActorCompContainerCS.AddComp(new b1.BUS_ActorTransformInfoCompNoMove());
		}
		else
		{
			ActorCompContainerCS.AddComp(new b1.BUS_ActorTransformInfoComp());
		}
	}

	[USharpPath("/Script/b1-Managed.BGUSimpleActorBaseCS:BeginPlayCS")]
	protected override void BeginPlayCS_Implementation()
	{
		FullyInit();
		base.BeginPlayCS_Implementation();
		CacheTeamIDFromMaster();
	}

	protected abstract void CreateDataContainer(FObjectInitializer initializer);

	private void CacheTeamIDFromMaster()
	{
		int teamID = 0;
		BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(this);
		if (readOnlyData != null)
		{
			AActor masterActor = readOnlyData.GetMasterActor();
			if (masterActor != null)
			{
				BGUCharacterCS bGUCharacterCS = masterActor as BGUCharacterCS;
				if (bGUCharacterCS != null)
				{
					teamID = bGUCharacterCS.GetTeamIDInCS();
				}
			}
		}
		SetTeamID(teamID);
	}

	public bool IsBeginPlayFinished()
	{
		return ActorCompContainerCS.HasLateBeginPlay;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSimpleActorBaseCS:BeginPlayCS")]
	private static void BeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSimpleActorBaseCS bGUSimpleActorBaseCS = GCHelper.Find<BGUSimpleActorBaseCS>(obj);
		bGUSimpleActorBaseCS.BeginPlayCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSimpleActorBaseCS:ReceiveEndPlay")]
	private static void ReceiveEndPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSimpleActorBaseCS bGUSimpleActorBaseCS = GCHelper.Find<BGUSimpleActorBaseCS>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address);
		bGUSimpleActorBaseCS.ReceiveEndPlay_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSimpleActorBaseCS:ReceiveDestroyed")]
	private static void ReceiveDestroyed__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSimpleActorBaseCS bGUSimpleActorBaseCS = GCHelper.Find<BGUSimpleActorBaseCS>(obj);
		bGUSimpleActorBaseCS.ReceiveDestroyed_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSimpleActorBaseCS:PostInitializeComponentsCS")]
	private static void PostInitializeComponentsCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSimpleActorBaseCS bGUSimpleActorBaseCS = GCHelper.Find<BGUSimpleActorBaseCS>(obj);
		bGUSimpleActorBaseCS.PostInitializeComponentsCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUSimpleActorBaseCS");
		DataComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "DataComp");
		DataComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DataComp", Classes.FObjectProperty);
		ActorCompContainerCS_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorCompContainerCS");
		ActorCompContainerCS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorCompContainerCS", Classes.FObjectProperty);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSimpleActorBaseCS:BeginPlayCS", BeginPlayCS_IsValid);
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSimpleActorBaseCS:ReceiveEndPlay", ReceiveEndPlay_IsValid);
		ReceiveDestroyed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveDestroyed");
		ReceiveDestroyed_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveDestroyed_FunctionAddress);
		ReceiveDestroyed_IsValid = ReceiveDestroyed_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSimpleActorBaseCS:ReceiveDestroyed", ReceiveDestroyed_IsValid);
		PostInitializeComponentsCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostInitializeComponentsCS");
		PostInitializeComponentsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostInitializeComponentsCS_FunctionAddress);
		PostInitializeComponentsCS_IsValid = PostInitializeComponentsCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSimpleActorBaseCS:PostInitializeComponentsCS", PostInitializeComponentsCS_IsValid);
	}

	static BGUSimpleActorBaseCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUSimpleActorBaseCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUSimpleActorBaseCS));
	}
}
