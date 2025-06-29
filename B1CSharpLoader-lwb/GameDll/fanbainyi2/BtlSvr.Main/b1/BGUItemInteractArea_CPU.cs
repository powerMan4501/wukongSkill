using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUItemInteractArea_CPU")]
public class BGUItemInteractArea_CPU : BGUActorBaseCS
{
	private static bool AreaBox_IsValid;

	private static int AreaBox_Offset;

	private static bool GridUnitLength_IsValid;

	private static int GridUnitLength_Offset;

	private static bool ItemList_IsValid;

	private static int ItemList_Offset;

	private static FFieldAddress ItemList_PropertyAddress;

	private TArrayReadWriteMarshaler<AActor> ItemList_Marshaler;

	private static bool BeginPlayCS_IsValid;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BGUItemInteractArea_CPU:AreaBox")]
	public UBoxComponent AreaBox
	{
		get
		{
			CheckDestroyed();
			if (!AreaBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUItemInteractArea_CPU:AreaBox");
				return null;
			}
			return UObjectMarshaler<UBoxComponent>.FromNative(IntPtr.Add(base.Address, AreaBox_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AreaBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUItemInteractArea_CPU:AreaBox");
			}
			else
			{
				UObjectMarshaler<UBoxComponent>.ToNative(IntPtr.Add(base.Address, AreaBox_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Default")]
	[DisplayName("矩阵单位边长")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUItemInteractArea_CPU:GridUnitLength")]
	public int GridUnitLength
	{
		get
		{
			CheckDestroyed();
			if (!GridUnitLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUItemInteractArea_CPU:GridUnitLength");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, GridUnitLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GridUnitLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUItemInteractArea_CPU:GridUnitLength");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, GridUnitLength_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("Default")]
	[USharpPath("/Script/b1-Managed.BGUItemInteractArea_CPU:ItemList")]
	public TArrayReadWrite<AActor> ItemList
	{
		get
		{
			CheckDestroyed();
			if (!ItemList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUItemInteractArea_CPU:ItemList");
				return null;
			}
			if (ItemList_Marshaler == null)
			{
				ItemList_Marshaler = new TArrayReadWriteMarshaler<AActor>(1, ItemList_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative);
			}
			return ItemList_Marshaler.FromNative(IntPtr.Add(base.Address, ItemList_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		AreaBox = initializer.CreateDefaultSubobject<UBoxComponent>(this, B1GlobalFNames.AreaBox);
		AreaBox.SetBoxExtent(new FVector(500.0, 500.0, 500.0));
		AreaBox.SetRelativeLocation(new FVector(500.0, 500.0, 500.0), bSweep: false, out var _, bTeleport: false);
		AreaBox.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		AreaBox.SetCollisionProfileName(B1GlobalFNames.DispInteractAreaVolume);
		GridUnitLength = 10000;
	}

	[USharpPath("/Script/b1-Managed.BGUItemInteractArea_CPU:BeginPlayCS")]
	protected override void BeginPlayCS_Implementation()
	{
		base.BeginPlayCS_Implementation();
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddCompUObj<BUS_ItemInteractAreaSystem_CPU>();
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_ActorBaseDataComp>(this, B1GlobalFNames.ItemInteractAreaSystem_CPUDataComp);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUItemInteractArea_CPU:BeginPlayCS")]
	private static void BeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUItemInteractArea_CPU bGUItemInteractArea_CPU = GCHelper.Find<BGUItemInteractArea_CPU>(obj);
		bGUItemInteractArea_CPU.BeginPlayCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUItemInteractArea_CPU");
		AreaBox_Offset = NativeReflection.GetPropertyOffset(intPtr, "AreaBox");
		AreaBox_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AreaBox", Classes.FObjectProperty);
		GridUnitLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "GridUnitLength");
		GridUnitLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GridUnitLength", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref ItemList_PropertyAddress, intPtr, "ItemList");
		ItemList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ItemList");
		ItemList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ItemList", Classes.FArrayProperty);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUItemInteractArea_CPU:BeginPlayCS", BeginPlayCS_IsValid);
	}

	static BGUItemInteractArea_CPU()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUItemInteractArea_CPU)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUItemInteractArea_CPU));
	}
}
