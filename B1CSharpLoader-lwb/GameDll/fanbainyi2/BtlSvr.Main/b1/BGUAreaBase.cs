using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUAreaBase")]
public class BGUAreaBase : BGUActorBaseCS
{
	private List<UPrimitiveComponent> EnterAreaList = new List<UPrimitiveComponent>();

	private List<UPrimitiveComponent> ExitAreaList = new List<UPrimitiveComponent>();

	private List<UPrimitiveComponent> AllArea = new List<UPrimitiveComponent>();

	private static bool Root_IsValid;

	private static int Root_Offset;

	private static bool AreaType_ForView_IsValid;

	private static int AreaType_ForView_Offset;

	private static FFieldAddress AreaType_ForView_PropertyAddress;

	private static bool ExtAbilityMask_IsValid;

	private static int ExtAbilityMask_Offset;

	private static bool BasicConfigInfoComp_IsValid;

	private static int BasicConfigInfoComp_Offset;

	private static bool bAutoEnableOverlap_IsValid;

	private static int bAutoEnableOverlap_Offset;

	private static FFieldAddress bAutoEnableOverlap_PropertyAddress;

	private static bool BeginPlayCS_IsValid;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	private static bool ReceiveEndPlay_IsValid;

	private static IntPtr ReceiveEndPlay_FunctionAddress;

	private static int ReceiveEndPlay_ParamsSize;

	private static bool ReceiveEndPlay_EndPlayReason_IsValid;

	private static int ReceiveEndPlay_EndPlayReason_Offset;

	private static FFieldAddress ReceiveEndPlay_EndPlayReason_PropertyAddress;

	private static bool OnConstructionCS_IsValid;

	private static IntPtr OnConstructionCS_FunctionAddress;

	private static int OnConstructionCS_ParamsSize;

	private static bool OnConstructionCS_Transform_IsValid;

	private static int OnConstructionCS_Transform_Offset;

	private static FFieldAddress OnConstructionCS_Transform_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUAreaBase:Root")]
	public USceneComponent Root
	{
		get
		{
			CheckDestroyed();
			if (!Root_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAreaBase:Root");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, Root_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Root_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAreaBase:Root");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, Root_Offset), value);
			}
		}
	}

	[DisplayName("区域类型_仅展示")]
	[UProperty]
	[BlueprintReadWrite]
	[VisibleInstanceOnly]
	[USharpPath("/Script/b1-Managed.BGUAreaBase:AreaType_ForView")]
	public EAreaType AreaType_ForView
	{
		get
		{
			CheckDestroyed();
			if (!AreaType_ForView_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAreaBase:AreaType_ForView");
				return EAreaType.SimpleTrigger;
			}
			return EnumMarshaler<EAreaType>.FromNative(IntPtr.Add(base.Address, AreaType_ForView_Offset), 0, AreaType_ForView_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AreaType_ForView_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAreaBase:AreaType_ForView");
			}
			else
			{
				EnumMarshaler<EAreaType>.ToNative(IntPtr.Add(base.Address, AreaType_ForView_Offset), 0, AreaType_ForView_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Optimize")]
	[DisplayName("附加功能Mask")]
	[USharpPath("/Script/b1-Managed.BGUAreaBase:ExtAbilityMask")]
	public FAreaAbilityMask ExtAbilityMask
	{
		get
		{
			CheckDestroyed();
			if (!ExtAbilityMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAreaBase:ExtAbilityMask");
				return default(FAreaAbilityMask);
			}
			return BlittableTypeMarshaler<FAreaAbilityMask>.FromNative(IntPtr.Add(base.Address, ExtAbilityMask_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExtAbilityMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAreaBase:ExtAbilityMask");
			}
			else
			{
				BlittableTypeMarshaler<FAreaAbilityMask>.ToNative(IntPtr.Add(base.Address, ExtAbilityMask_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUAreaBase:BasicConfigInfoComp")]
	public BUS_AreaConfigInfoComp BasicConfigInfoComp
	{
		get
		{
			CheckDestroyed();
			if (!BasicConfigInfoComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAreaBase:BasicConfigInfoComp");
				return null;
			}
			return UObjectMarshaler<BUS_AreaConfigInfoComp>.FromNative(IntPtr.Add(base.Address, BasicConfigInfoComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BasicConfigInfoComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAreaBase:BasicConfigInfoComp");
			}
			else
			{
				UObjectMarshaler<BUS_AreaConfigInfoComp>.ToNative(IntPtr.Add(base.Address, BasicConfigInfoComp_Offset), value);
			}
		}
	}

	[Category("Quest|Overlap")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUAreaBase:bAutoEnableOverlap")]
	public bool bAutoEnableOverlap
	{
		get
		{
			CheckDestroyed();
			if (!bAutoEnableOverlap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAreaBase:bAutoEnableOverlap");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAutoEnableOverlap_Offset), 0, bAutoEnableOverlap_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAutoEnableOverlap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAreaBase:bAutoEnableOverlap");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAutoEnableOverlap_Offset), 0, bAutoEnableOverlap_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		Root = initializer.CreateDefaultSubobject<USceneComponent>(this, GetRootCompName());
		SetRootComponentCS(Root);
		BasicConfigInfoComp = initializer.CreateDefaultSubobject<BUS_AreaConfigInfoComp>(this, B1GlobalFNames.BasicConfigInfoComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddCompUObj<BUS_AreaOverlapComp>();
		base.ActorCompContainerCS.AddComp(new BUS_AreaStateMachineComp());
		RegisterCompUObjByMask<b1.BUS_AKMgrComp>(EAreaAbilityType.PlayDialogue);
		RegisterCompUObjByMask<b1.BUS_UIControlSystemV2>(EAreaAbilityType.PlayDialogue);
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_AreaBaseDataContainer>(this, B1GlobalFNames.DataComp);
	}

	protected virtual FName GetRootCompName()
	{
		return B1GlobalFNames.Root;
	}

	public List<UPrimitiveComponent> GetAllAreaComp()
	{
		return AllArea;
	}

	public List<UPrimitiveComponent> GetAllEnterPrimitiveComps()
	{
		return EnterAreaList;
	}

	public List<UPrimitiveComponent> GetAllExitPrimitiveComps()
	{
		return ExitAreaList;
	}

	[USharpPath("/Script/b1-Managed.BGUAreaBase:BeginPlayCS")]
	protected override void BeginPlayCS_Implementation()
	{
		base.BeginPlayCS_Implementation();
		BeforeInitAreaComp();
		InitAllAreaComp();
	}

	[USharpPath("/Script/b1-Managed.BGUAreaBase:ReceiveEndPlay")]
	protected override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		ClearAllAreaTemp();
	}

	protected virtual void BeforeInitAreaComp()
	{
	}

	private void ClearAllAreaTemp()
	{
		EnterAreaList.Clear();
		ExitAreaList.Clear();
		AllArea.Clear();
	}

	private void InitAllAreaComp()
	{
		ClearAllAreaTemp();
		foreach (UActorComponent item in GetComponentsByClass(UClass.GetClass<UPrimitiveComponent>()))
		{
			if (!(item is UShapeComponent) && (!(item is UStaticMeshComponent) || !item.ComponentHasTag(B1GlobalFNames.CustomShape)))
			{
				continue;
			}
			UPrimitiveComponent uPrimitiveComponent = item as UPrimitiveComponent;
			if (!(uPrimitiveComponent.GetCollisionProfileName() == B1GlobalFNames.NoCollision))
			{
				uPrimitiveComponent.SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
				uPrimitiveComponent.SetCollisionEnabled(ECollisionEnabled.NoCollision);
				AllArea.Add(uPrimitiveComponent);
				if (!item.ComponentHasTag(B1GlobalFNames.OutsideVolume) && !item.ComponentHasTag(B1GlobalFNames.Exit))
				{
					EnterAreaList.Add(uPrimitiveComponent);
				}
				else
				{
					ExitAreaList.Add(uPrimitiveComponent);
				}
			}
		}
	}

	public T RegisterCompByMask<T>(EAreaAbilityType AbilityType = EAreaAbilityType.Default) where T : UActorCompBaseCS, new()
	{
		if (AbilityType == EAreaAbilityType.Default || ((uint)AbilityType & (uint)ExtAbilityMask.Mask) != 0)
		{
			T newComp = new T();
			return base.ActorCompContainerCS.AddComp(newComp);
		}
		return null;
	}

	public T RegisterCompUObjByMask<T>(EAreaAbilityType AbilityType = EAreaAbilityType.Default) where T : UActorCompBaseUObj
	{
		if (AbilityType == EAreaAbilityType.Default || ((uint)AbilityType & (uint)ExtAbilityMask.Mask) != 0)
		{
			return base.ActorCompContainerCS.AddCompUObj<T>();
		}
		return null;
	}

	[USharpPath("/Script/b1-Managed.BGUAreaBase:OnConstructionCS")]
	protected override void OnConstructionCS_Implementation(FTransform Transform)
	{
		base.OnConstructionCS_Implementation(Transform);
	}

	private void UpdateAreaType_ForView()
	{
		AreaType_ForView = BasicConfigInfoComp.AreaType;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUAreaBase:BeginPlayCS")]
	private static void BeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUAreaBase bGUAreaBase = GCHelper.Find<BGUAreaBase>(obj);
		bGUAreaBase.BeginPlayCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUAreaBase:ReceiveEndPlay")]
	private static void ReceiveEndPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUAreaBase bGUAreaBase = GCHelper.Find<BGUAreaBase>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address);
		bGUAreaBase.ReceiveEndPlay_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUAreaBase:OnConstructionCS")]
	private static void OnConstructionCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUAreaBase bGUAreaBase = GCHelper.Find<BGUAreaBase>(obj);
		FTransform transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, OnConstructionCS_Transform_Offset));
		bGUAreaBase.OnConstructionCS_Implementation(transform);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUAreaBase");
		Root_Offset = NativeReflection.GetPropertyOffset(intPtr, "Root");
		Root_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Root", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref AreaType_ForView_PropertyAddress, intPtr, "AreaType_ForView");
		AreaType_ForView_Offset = NativeReflection.GetPropertyOffset(intPtr, "AreaType_ForView");
		AreaType_ForView_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AreaType_ForView", Classes.FEnumProperty);
		ExtAbilityMask_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExtAbilityMask");
		ExtAbilityMask_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExtAbilityMask", Classes.FStructProperty);
		BasicConfigInfoComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "BasicConfigInfoComp");
		BasicConfigInfoComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BasicConfigInfoComp", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bAutoEnableOverlap_PropertyAddress, intPtr, "bAutoEnableOverlap");
		bAutoEnableOverlap_Offset = NativeReflection.GetPropertyOffset(intPtr, "bAutoEnableOverlap");
		bAutoEnableOverlap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bAutoEnableOverlap", Classes.FBoolProperty);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUAreaBase:BeginPlayCS", BeginPlayCS_IsValid);
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUAreaBase:ReceiveEndPlay", ReceiveEndPlay_IsValid);
		OnConstructionCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnConstructionCS");
		OnConstructionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructionCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnConstructionCS_Transform_PropertyAddress, OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_Offset = NativeReflection.GetPropertyOffset(OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_IsValid = NativeReflection.ValidatePropertyClass(OnConstructionCS_FunctionAddress, "Transform", Classes.FStructProperty);
		OnConstructionCS_IsValid = OnConstructionCS_FunctionAddress != IntPtr.Zero && OnConstructionCS_Transform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUAreaBase:OnConstructionCS", OnConstructionCS_IsValid);
	}

	static BGUAreaBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUAreaBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUAreaBase));
	}
}
