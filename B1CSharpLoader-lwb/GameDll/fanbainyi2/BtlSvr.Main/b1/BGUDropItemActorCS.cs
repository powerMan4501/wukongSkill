using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUDropItemActorCS")]
public class BGUDropItemActorCS : BGUDropItemActor
{
	private static bool DropItemComp_IsValid;

	private static int DropItemComp_Offset;

	private static bool DropItemBPFunc_IsValid;

	private static IntPtr DropItemBPFunc_FunctionAddress;

	private static int DropItemBPFunc_ParamsSize;

	private static bool DropItemBPFunc_FloatParam_IsValid;

	private static int DropItemBPFunc_FloatParam_Offset;

	private IntPtr DropItemBPFunc_InstanceFunctionAddressInstance;

	private static bool OnPlayDropEffect_IsValid;

	private static IntPtr OnPlayDropEffect_FunctionAddress;

	private static int OnPlayDropEffect_ParamsSize;

	private IntPtr OnPlayDropEffect_InstanceFunctionAddressInstance;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUDropItemActorCS:DropItemComp")]
	public BUS_DropItemComp DropItemComp
	{
		get
		{
			CheckDestroyed();
			if (!DropItemComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDropItemActorCS:DropItemComp");
				return null;
			}
			return UObjectMarshaler<BUS_DropItemComp>.FromNative(IntPtr.Add(base.Address, DropItemComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropItemComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDropItemActorCS:DropItemComp");
			}
			else
			{
				UObjectMarshaler<BUS_DropItemComp>.ToNative(IntPtr.Add(base.Address, DropItemComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		DropItemComp = initializer.CreateDefaultSubobject<BUS_DropItemComp>(this, B1GlobalFNames.DropItemSystem);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_DropItemLogicComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_DropItemDataComp>(this, B1GlobalFNames.SimpleDropItemDataComp);
	}

	protected T CreateData<T>(BGW_ECSWorld ECSWorld) where T : UObject
	{
		T val = UObject.NewObject<T>(this);
		ECSWorld.SetObject(base.ECSEntity, val);
		return val;
	}

	public void SetDropItemScale(FVector NewScale)
	{
		SetActorScale3D(NewScale);
	}

	[BlueprintImplementedEvent]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUDropItemActorCS:DropItemBPFunc")]
	public unsafe void DropItemBPFunc(float FloatParam)
	{
		CheckDestroyed();
		if (!DropItemBPFunc_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUDropItemActorCS:DropItemBPFunc");
			return;
		}
		if (DropItemBPFunc_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			DropItemBPFunc_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "DropItemBPFunc");
		}
		byte* value = stackalloc byte[(int)(uint)DropItemBPFunc_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, DropItemBPFunc_ParamsSize);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DropItemBPFunc_FloatParam_Offset), FloatParam);
		NativeReflection.InvokeFunction(base.Address, DropItemBPFunc_InstanceFunctionAddressInstance, intPtr, DropItemBPFunc_ParamsSize);
	}

	[BlueprintImplementedEvent]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUDropItemActorCS:OnPlayDropEffect")]
	public unsafe void OnPlayDropEffect()
	{
		CheckDestroyed();
		if (!OnPlayDropEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUDropItemActorCS:OnPlayDropEffect");
			return;
		}
		if (OnPlayDropEffect_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnPlayDropEffect_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnPlayDropEffect");
		}
		byte* value = stackalloc byte[(int)(uint)OnPlayDropEffect_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnPlayDropEffect_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, OnPlayDropEffect_InstanceFunctionAddressInstance, intPtr, OnPlayDropEffect_ParamsSize);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUDropItemActorCS");
		DropItemComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "DropItemComp");
		DropItemComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DropItemComp", Classes.FObjectProperty);
		DropItemBPFunc_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DropItemBPFunc");
		DropItemBPFunc_ParamsSize = NativeReflection.GetFunctionParamsSize(DropItemBPFunc_FunctionAddress);
		DropItemBPFunc_FloatParam_Offset = NativeReflection.GetPropertyOffset(DropItemBPFunc_FunctionAddress, "FloatParam");
		DropItemBPFunc_FloatParam_IsValid = NativeReflection.ValidatePropertyClass(DropItemBPFunc_FunctionAddress, "FloatParam", Classes.FFloatProperty);
		DropItemBPFunc_IsValid = DropItemBPFunc_FunctionAddress != IntPtr.Zero && DropItemBPFunc_FloatParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUDropItemActorCS:DropItemBPFunc", DropItemBPFunc_IsValid);
		OnPlayDropEffect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPlayDropEffect");
		OnPlayDropEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPlayDropEffect_FunctionAddress);
		OnPlayDropEffect_IsValid = OnPlayDropEffect_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUDropItemActorCS:OnPlayDropEffect", OnPlayDropEffect_IsValid);
	}

	static BGUDropItemActorCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUDropItemActorCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUDropItemActorCS));
	}
}
