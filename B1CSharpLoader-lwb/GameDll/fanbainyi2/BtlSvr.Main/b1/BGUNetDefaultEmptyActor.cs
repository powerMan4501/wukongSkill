using System;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUNetDefaultEmptyActor")]
public class BGUNetDefaultEmptyActor : ABGUCharacter, IECSWorldObj
{
	protected Entity mECSEntity;

	protected Chunk mECSChunk;

	protected int mECSIndexInChunk;

	private static int sCSharpUIDAlloc;

	private static bool ActorCompContainerCS_IsValid;

	private static int ActorCompContainerCS_Offset;

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static int ReceiveTick_DeltaSeconds_Offset;

	private static bool OnPossessedCS_IsValid;

	private static IntPtr OnPossessedCS_FunctionAddress;

	private static int OnPossessedCS_ParamsSize;

	private static bool OnPossessedCS_NewController_IsValid;

	private static int OnPossessedCS_NewController_Offset;

	private static bool OnConstructionCS_IsValid;

	private static IntPtr OnConstructionCS_FunctionAddress;

	private static int OnConstructionCS_ParamsSize;

	private static bool OnConstructionCS_Transform_IsValid;

	private static int OnConstructionCS_Transform_Offset;

	private static FFieldAddress OnConstructionCS_Transform_PropertyAddress;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

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

	public int ECSArcheType { get; protected set; }

	private BUS_GSEventCollection RPCEventCollection { get; set; }

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGUNetDefaultEmptyActor:ActorCompContainerCS")]
	public UActorCompContainerCS ActorCompContainerCS
	{
		get
		{
			CheckDestroyed();
			if (!ActorCompContainerCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNetDefaultEmptyActor:ActorCompContainerCS");
				return null;
			}
			return UObjectMarshaler<UActorCompContainerCS>.FromNative(IntPtr.Add(base.Address, ActorCompContainerCS_Offset));
		}
		protected set
		{
			CheckDestroyed();
			if (!ActorCompContainerCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNetDefaultEmptyActor:ActorCompContainerCS");
			}
			else
			{
				UObjectMarshaler<UActorCompContainerCS>.ToNative(IntPtr.Add(base.Address, ActorCompContainerCS_Offset), value);
			}
		}
	}

	public UActorDataContainer DataComp => base.BGUDataComp;

	public Entity GetECSEntity()
	{
		return ECSEntity;
	}

	public object GetDataByChunk(int TypeIndex)
	{
		return BGU_DataUtil.GetDataByEntityChunk(TypeIndex, mECSEntity, mECSChunk, mECSIndexInChunk);
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		RPCEventCollection = initializer.CreateDefaultSubobject<BUS_GSEventCollection>(this, B1GlobalFNames.RPCEventCollection);
		ECSArcheType = 10;
		base.BGUDataComp = initializer.CreateDefaultSubobject<BUS_BGUDataComp>(this, B1GlobalFNames.UBGUDataComp);
		ActorCompContainerCS = initializer.CreateDefaultSubobject<UActorCompContainerCS>(this, B1GlobalFNames.ActorCompContainerCS);
	}

	[USharpPath("/Script/b1-Managed.BGUNetDefaultEmptyActor:PostInitializeComponentsCS")]
	protected sealed override void PostInitializeComponentsCS_Implementation()
	{
		base.PostInitializeComponentsCS_Implementation();
	}

	public object GetEventCollection()
	{
		return RPCEventCollection;
	}

	public virtual void InitAllComp()
	{
		base.TeamIDDeprecate = 1;
	}

	[USharpPath("/Script/b1-Managed.BGUNetDefaultEmptyActor:OnConstructionCS")]
	protected override void OnConstructionCS_Implementation(FTransform Transform)
	{
	}

	[USharpPath("/Script/b1-Managed.BGUNetDefaultEmptyActor:ReceiveBeginPlay")]
	protected sealed override void ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
		FullyInit();
	}

	[USharpPath("/Script/b1-Managed.BGUNetDefaultEmptyActor:OnPossessedCS")]
	protected override void OnPossessedCS_Implementation(AController NewController)
	{
		base.OnPossessedCS_Implementation(NewController);
	}

	[USharpPath("/Script/b1-Managed.BGUNetDefaultEmptyActor:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaSeconds)
	{
		base.ReceiveTick_Implementation(DeltaSeconds);
	}

	private void OnFirstTick()
	{
	}

	public virtual void AfterInitAllComp()
	{
	}

	public bool IsBeginPlayFinished()
	{
		return ActorCompContainerCS.HasLateBeginPlay;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUNetDefaultEmptyActor:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUNetDefaultEmptyActor bGUNetDefaultEmptyActor = GCHelper.Find<BGUNetDefaultEmptyActor>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset));
		bGUNetDefaultEmptyActor.ReceiveTick_Implementation(deltaSeconds);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUNetDefaultEmptyActor:OnPossessedCS")]
	private static void OnPossessedCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUNetDefaultEmptyActor bGUNetDefaultEmptyActor = GCHelper.Find<BGUNetDefaultEmptyActor>(obj);
		AController newController = UObjectMarshaler<AController>.FromNative(IntPtr.Add(buffer, OnPossessedCS_NewController_Offset));
		bGUNetDefaultEmptyActor.OnPossessedCS_Implementation(newController);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUNetDefaultEmptyActor:OnConstructionCS")]
	private static void OnConstructionCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUNetDefaultEmptyActor bGUNetDefaultEmptyActor = GCHelper.Find<BGUNetDefaultEmptyActor>(obj);
		FTransform transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, OnConstructionCS_Transform_Offset));
		bGUNetDefaultEmptyActor.OnConstructionCS_Implementation(transform);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUNetDefaultEmptyActor:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUNetDefaultEmptyActor bGUNetDefaultEmptyActor = GCHelper.Find<BGUNetDefaultEmptyActor>(obj);
		bGUNetDefaultEmptyActor.ReceiveBeginPlay_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUNetDefaultEmptyActor:PostInitializeComponentsCS")]
	private static void PostInitializeComponentsCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUNetDefaultEmptyActor bGUNetDefaultEmptyActor = GCHelper.Find<BGUNetDefaultEmptyActor>(obj);
		bGUNetDefaultEmptyActor.PostInitializeComponentsCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUNetDefaultEmptyActor");
		ActorCompContainerCS_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorCompContainerCS");
		ActorCompContainerCS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorCompContainerCS", Classes.FObjectProperty);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUNetDefaultEmptyActor:ReceiveTick", ReceiveTick_IsValid);
		OnPossessedCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPossessedCS");
		OnPossessedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPossessedCS_FunctionAddress);
		OnPossessedCS_NewController_Offset = NativeReflection.GetPropertyOffset(OnPossessedCS_FunctionAddress, "NewController");
		OnPossessedCS_NewController_IsValid = NativeReflection.ValidatePropertyClass(OnPossessedCS_FunctionAddress, "NewController", Classes.FObjectProperty);
		OnPossessedCS_IsValid = OnPossessedCS_FunctionAddress != IntPtr.Zero && OnPossessedCS_NewController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUNetDefaultEmptyActor:OnPossessedCS", OnPossessedCS_IsValid);
		OnConstructionCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnConstructionCS");
		OnConstructionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructionCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnConstructionCS_Transform_PropertyAddress, OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_Offset = NativeReflection.GetPropertyOffset(OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_IsValid = NativeReflection.ValidatePropertyClass(OnConstructionCS_FunctionAddress, "Transform", Classes.FStructProperty);
		OnConstructionCS_IsValid = OnConstructionCS_FunctionAddress != IntPtr.Zero && OnConstructionCS_Transform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUNetDefaultEmptyActor:OnConstructionCS", OnConstructionCS_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUNetDefaultEmptyActor:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
		PostInitializeComponentsCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostInitializeComponentsCS");
		PostInitializeComponentsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostInitializeComponentsCS_FunctionAddress);
		PostInitializeComponentsCS_IsValid = PostInitializeComponentsCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUNetDefaultEmptyActor:PostInitializeComponentsCS", PostInitializeComponentsCS_IsValid);
	}

	static BGUNetDefaultEmptyActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUNetDefaultEmptyActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUNetDefaultEmptyActor));
	}
}
