using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUTriggerObjBase")]
public class BGUTriggerObjBase : BGUInteractiveActorBase
{
	private static bool TriggerComp_IsValid;

	private static int TriggerComp_Offset;

	private static bool OnConstructionCS_IsValid;

	private static IntPtr OnConstructionCS_FunctionAddress;

	private static int OnConstructionCS_ParamsSize;

	private static bool OnConstructionCS_Transform_IsValid;

	private static int OnConstructionCS_Transform_Offset;

	private static FFieldAddress OnConstructionCS_Transform_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUTriggerObjBase:TriggerComp")]
	private b1.BUS_TriggerComp TriggerComp
	{
		get
		{
			CheckDestroyed();
			if (!TriggerComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTriggerObjBase:TriggerComp");
				return null;
			}
			return UObjectMarshaler<b1.BUS_TriggerComp>.FromNative(IntPtr.Add(base.Address, TriggerComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTriggerObjBase:TriggerComp");
			}
			else
			{
				UObjectMarshaler<b1.BUS_TriggerComp>.ToNative(IntPtr.Add(base.Address, TriggerComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		TriggerComp = initializer.CreateDefaultSubobject<b1.BUS_TriggerComp>(this, B1GlobalFNames.TriggerSystem);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_TriggerCompImpl());
	}

	[USharpPath("/Script/b1-Managed.BGUTriggerObjBase:OnConstructionCS")]
	protected override void OnConstructionCS_Implementation(FTransform Transform)
	{
		base.OnConstructionCS_Implementation(Transform);
		TriggerComp.InitDebugCircleRange();
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_TriggerObjDataComp>(this, B1GlobalFNames.TriggerObjDataComp);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUTriggerObjBase:OnConstructionCS")]
	private static void OnConstructionCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUTriggerObjBase bGUTriggerObjBase = GCHelper.Find<BGUTriggerObjBase>(obj);
		FTransform transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, OnConstructionCS_Transform_Offset));
		bGUTriggerObjBase.OnConstructionCS_Implementation(transform);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUTriggerObjBase");
		TriggerComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerComp");
		TriggerComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerComp", Classes.FObjectProperty);
		OnConstructionCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnConstructionCS");
		OnConstructionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructionCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnConstructionCS_Transform_PropertyAddress, OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_Offset = NativeReflection.GetPropertyOffset(OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_IsValid = NativeReflection.ValidatePropertyClass(OnConstructionCS_FunctionAddress, "Transform", Classes.FStructProperty);
		OnConstructionCS_IsValid = OnConstructionCS_FunctionAddress != IntPtr.Zero && OnConstructionCS_Transform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUTriggerObjBase:OnConstructionCS", OnConstructionCS_IsValid);
	}

	static BGUTriggerObjBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUTriggerObjBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUTriggerObjBase));
	}
}
