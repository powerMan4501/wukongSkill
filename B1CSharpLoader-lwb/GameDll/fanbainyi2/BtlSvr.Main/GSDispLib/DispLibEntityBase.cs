using System;
using b1;
using b1.ECS;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[USharpPath("/Script/b1-Managed.DispLibEntityBase")]
public abstract class DispLibEntityBase : ABGUActorBase, IECSWorldObj
{
	protected Entity mECSEntity;

	protected Chunk mECSChunk;

	protected int mECSIndexInChunk;

	private static bool ActorCompContainerCS_IsValid;

	private static int ActorCompContainerCS_Offset;

	private static bool DataComp_IsValid;

	private static int DataComp_Offset;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	private static bool ApplyWorldOffsetCS_IsValid;

	private static IntPtr ApplyWorldOffsetCS_FunctionAddress;

	private static int ApplyWorldOffsetCS_ParamsSize;

	private static bool ApplyWorldOffsetCS_InOffset_IsValid;

	private static int ApplyWorldOffsetCS_InOffset_Offset;

	private static FFieldAddress ApplyWorldOffsetCS_InOffset_PropertyAddress;

	private static bool ApplyWorldOffsetCS_bWorldShift_IsValid;

	private static int ApplyWorldOffsetCS_bWorldShift_Offset;

	private static FFieldAddress ApplyWorldOffsetCS_bWorldShift_PropertyAddress;

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

	public virtual int ECSArcheType => 7;

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.DispLibEntityBase:ActorCompContainerCS")]
	public UActorCompContainerCS ActorCompContainerCS
	{
		get
		{
			CheckDestroyed();
			if (!ActorCompContainerCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLibEntityBase:ActorCompContainerCS");
				return null;
			}
			return UObjectMarshaler<UActorCompContainerCS>.FromNative(IntPtr.Add(base.Address, ActorCompContainerCS_Offset));
		}
		protected set
		{
			CheckDestroyed();
			if (!ActorCompContainerCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLibEntityBase:ActorCompContainerCS");
			}
			else
			{
				UObjectMarshaler<UActorCompContainerCS>.ToNative(IntPtr.Add(base.Address, ActorCompContainerCS_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.DispLibEntityBase:DataComp")]
	public UActorDataContainer DataComp
	{
		get
		{
			CheckDestroyed();
			if (!DataComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLibEntityBase:DataComp");
				return null;
			}
			return UObjectMarshaler<UActorDataContainer>.FromNative(IntPtr.Add(base.Address, DataComp_Offset));
		}
		protected set
		{
			CheckDestroyed();
			if (!DataComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLibEntityBase:DataComp");
			}
			else
			{
				UObjectMarshaler<UActorDataContainer>.ToNative(IntPtr.Add(base.Address, DataComp_Offset), value);
			}
		}
	}

	public Entity GetECSEntity()
	{
		return ECSEntity;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		CreateDataContainer(initializer);
		base.ActorCompContainer = initializer.CreateDefaultSubobject<UActorCompContainer>(this, B1GlobalFNames.ActorCompContainer);
		ActorCompContainerCS = initializer.CreateDefaultSubobject<UActorCompContainerCS>(this, B1GlobalFNames.ActorCompContainerCS);
	}

	[USharpPath("/Script/b1-Managed.DispLibEntityBase:PostInitializeComponentsCS")]
	protected sealed override void PostInitializeComponentsCS_Implementation()
	{
		base.PostInitializeComponentsCS_Implementation();
	}

	public object GetEventCollection()
	{
		return base.EventCollection;
	}

	public virtual void InitAllComp()
	{
		base.ActorCompContainer.FillDataContainer(DataComp);
		base.ActorCompContainer.FillEventCollection(base.EventCollection);
	}

	public virtual void AfterInitAllComp()
	{
	}

	[USharpPath("/Script/b1-Managed.DispLibEntityBase:ReceiveBeginPlay")]
	protected override void ReceiveBeginPlay_Implementation()
	{
		FullyInit();
		base.ReceiveBeginPlay_Implementation();
	}

	[USharpPath("/Script/b1-Managed.DispLibEntityBase:ApplyWorldOffsetCS")]
	protected override void ApplyWorldOffsetCS_Implementation(FVector InOffset, bool bWorldShift)
	{
	}

	protected abstract void CreateDataContainer(FObjectInitializer initializer);

	public bool IsBeginPlayFinished()
	{
		return ActorCompContainerCS.HasLateBeginPlay;
	}

	public object GetDataByChunk(int TypeIndex)
	{
		return BGU_DataUtil.GetDataByEntityChunk(TypeIndex, mECSEntity, mECSChunk, mECSIndexInChunk);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLibEntityBase:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLibEntityBase dispLibEntityBase = GCHelper.Find<DispLibEntityBase>(obj);
		dispLibEntityBase.ReceiveBeginPlay_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLibEntityBase:ApplyWorldOffsetCS")]
	private static void ApplyWorldOffsetCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLibEntityBase dispLibEntityBase = GCHelper.Find<DispLibEntityBase>(obj);
		FVector inOffset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, ApplyWorldOffsetCS_InOffset_Offset));
		bool bWorldShift = BoolMarshaler.FromNative(IntPtr.Add(buffer, ApplyWorldOffsetCS_bWorldShift_Offset), 0, ApplyWorldOffsetCS_bWorldShift_PropertyAddress.Address);
		dispLibEntityBase.ApplyWorldOffsetCS_Implementation(inOffset, bWorldShift);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLibEntityBase:PostInitializeComponentsCS")]
	private static void PostInitializeComponentsCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLibEntityBase dispLibEntityBase = GCHelper.Find<DispLibEntityBase>(obj);
		dispLibEntityBase.PostInitializeComponentsCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.DispLibEntityBase");
		ActorCompContainerCS_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorCompContainerCS");
		ActorCompContainerCS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorCompContainerCS", Classes.FObjectProperty);
		DataComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "DataComp");
		DataComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DataComp", Classes.FObjectProperty);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLibEntityBase:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
		ApplyWorldOffsetCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ApplyWorldOffsetCS");
		ApplyWorldOffsetCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyWorldOffsetCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ApplyWorldOffsetCS_InOffset_PropertyAddress, ApplyWorldOffsetCS_FunctionAddress, "InOffset");
		ApplyWorldOffsetCS_InOffset_Offset = NativeReflection.GetPropertyOffset(ApplyWorldOffsetCS_FunctionAddress, "InOffset");
		ApplyWorldOffsetCS_InOffset_IsValid = NativeReflection.ValidatePropertyClass(ApplyWorldOffsetCS_FunctionAddress, "InOffset", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref ApplyWorldOffsetCS_bWorldShift_PropertyAddress, ApplyWorldOffsetCS_FunctionAddress, "bWorldShift");
		ApplyWorldOffsetCS_bWorldShift_Offset = NativeReflection.GetPropertyOffset(ApplyWorldOffsetCS_FunctionAddress, "bWorldShift");
		ApplyWorldOffsetCS_bWorldShift_IsValid = NativeReflection.ValidatePropertyClass(ApplyWorldOffsetCS_FunctionAddress, "bWorldShift", Classes.FBoolProperty);
		ApplyWorldOffsetCS_IsValid = ApplyWorldOffsetCS_FunctionAddress != IntPtr.Zero && ApplyWorldOffsetCS_InOffset_IsValid && ApplyWorldOffsetCS_bWorldShift_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLibEntityBase:ApplyWorldOffsetCS", ApplyWorldOffsetCS_IsValid);
		PostInitializeComponentsCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostInitializeComponentsCS");
		PostInitializeComponentsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostInitializeComponentsCS_FunctionAddress);
		PostInitializeComponentsCS_IsValid = PostInitializeComponentsCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLibEntityBase:PostInitializeComponentsCS", PostInitializeComponentsCS_IsValid);
	}

	static DispLibEntityBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DispLibEntityBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DispLibEntityBase));
	}
}
