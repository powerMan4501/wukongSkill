using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUGateStateMachineActor")]
public class BGUGateStateMachineActor : BGUActorBaseCS
{
	private static bool GateStateMachineConfigComp_IsValid;

	private static int GateStateMachineConfigComp_Offset;

	private static bool OnGateOpen_IsValid;

	private static IntPtr OnGateOpen_FunctionAddress;

	private static int OnGateOpen_ParamsSize;

	private IntPtr OnGateOpen_InstanceFunctionAddressInstance;

	private static bool OnGateClose_IsValid;

	private static IntPtr OnGateClose_FunctionAddress;

	private static int OnGateClose_ParamsSize;

	private IntPtr OnGateClose_InstanceFunctionAddressInstance;

	private static bool OnResetToGateOpen_IsValid;

	private static IntPtr OnResetToGateOpen_FunctionAddress;

	private static int OnResetToGateOpen_ParamsSize;

	private IntPtr OnResetToGateOpen_InstanceFunctionAddressInstance;

	private static bool OnResetToGateClose_IsValid;

	private static IntPtr OnResetToGateClose_FunctionAddress;

	private static int OnResetToGateClose_ParamsSize;

	private IntPtr OnResetToGateClose_InstanceFunctionAddressInstance;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUGateStateMachineActor:GateStateMachineConfigComp")]
	public BUS_GateStateMachineConfigComp GateStateMachineConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!GateStateMachineConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUGateStateMachineActor:GateStateMachineConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_GateStateMachineConfigComp>.FromNative(IntPtr.Add(base.Address, GateStateMachineConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GateStateMachineConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUGateStateMachineActor:GateStateMachineConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_GateStateMachineConfigComp>.ToNative(IntPtr.Add(base.Address, GateStateMachineConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		GateStateMachineConfigComp = initializer.CreateDefaultSubobject<BUS_GateStateMachineConfigComp>(this, B1GlobalFNames.GateStateMachineConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		EGateStateMachineType gateStateMachineType = GateStateMachineConfigComp.GateStateMachineType;
		if (gateStateMachineType != EGateStateMachineType.None && gateStateMachineType == EGateStateMachineType.Destructible)
		{
			base.ActorCompContainerCS.AddComp(new b1.BUS_DestructibleGateComp());
		}
		base.ActorCompContainerCS.AddComp(new b1.BUS_GateStateMachineComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_GateStateMachineDataComp>(this, B1GlobalFNames.GateStateMachineDataComp);
	}

	[BlueprintCallable]
	[UFunction]
	[BlueprintImplementedEvent]
	[USharpPath("/Script/b1-Managed.BGUGateStateMachineActor:OnGateOpen")]
	public unsafe void OnGateOpen()
	{
		CheckDestroyed();
		if (!OnGateOpen_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUGateStateMachineActor:OnGateOpen");
			return;
		}
		if (OnGateOpen_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnGateOpen_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnGateOpen");
		}
		byte* value = stackalloc byte[(int)(uint)OnGateOpen_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnGateOpen_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, OnGateOpen_InstanceFunctionAddressInstance, intPtr, OnGateOpen_ParamsSize);
	}

	[BlueprintCallable]
	[UFunction]
	[BlueprintImplementedEvent]
	[USharpPath("/Script/b1-Managed.BGUGateStateMachineActor:OnGateClose")]
	public unsafe void OnGateClose()
	{
		CheckDestroyed();
		if (!OnGateClose_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUGateStateMachineActor:OnGateClose");
			return;
		}
		if (OnGateClose_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnGateClose_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnGateClose");
		}
		byte* value = stackalloc byte[(int)(uint)OnGateClose_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnGateClose_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, OnGateClose_InstanceFunctionAddressInstance, intPtr, OnGateClose_ParamsSize);
	}

	[BlueprintCallable]
	[BlueprintImplementedEvent]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUGateStateMachineActor:OnResetToGateOpen")]
	public unsafe void OnResetToGateOpen()
	{
		CheckDestroyed();
		if (!OnResetToGateOpen_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUGateStateMachineActor:OnResetToGateOpen");
			return;
		}
		if (OnResetToGateOpen_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnResetToGateOpen_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnResetToGateOpen");
		}
		byte* value = stackalloc byte[(int)(uint)OnResetToGateOpen_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnResetToGateOpen_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, OnResetToGateOpen_InstanceFunctionAddressInstance, intPtr, OnResetToGateOpen_ParamsSize);
	}

	[BlueprintCallable]
	[BlueprintImplementedEvent]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUGateStateMachineActor:OnResetToGateClose")]
	public unsafe void OnResetToGateClose()
	{
		CheckDestroyed();
		if (!OnResetToGateClose_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUGateStateMachineActor:OnResetToGateClose");
			return;
		}
		if (OnResetToGateClose_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnResetToGateClose_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnResetToGateClose");
		}
		byte* value = stackalloc byte[(int)(uint)OnResetToGateClose_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnResetToGateClose_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, OnResetToGateClose_InstanceFunctionAddressInstance, intPtr, OnResetToGateClose_ParamsSize);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUGateStateMachineActor");
		GateStateMachineConfigComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "GateStateMachineConfigComp");
		GateStateMachineConfigComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GateStateMachineConfigComp", Classes.FObjectProperty);
		OnGateOpen_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnGateOpen");
		OnGateOpen_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGateOpen_FunctionAddress);
		OnGateOpen_IsValid = OnGateOpen_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUGateStateMachineActor:OnGateOpen", OnGateOpen_IsValid);
		OnGateClose_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnGateClose");
		OnGateClose_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGateClose_FunctionAddress);
		OnGateClose_IsValid = OnGateClose_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUGateStateMachineActor:OnGateClose", OnGateClose_IsValid);
		OnResetToGateOpen_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnResetToGateOpen");
		OnResetToGateOpen_ParamsSize = NativeReflection.GetFunctionParamsSize(OnResetToGateOpen_FunctionAddress);
		OnResetToGateOpen_IsValid = OnResetToGateOpen_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUGateStateMachineActor:OnResetToGateOpen", OnResetToGateOpen_IsValid);
		OnResetToGateClose_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnResetToGateClose");
		OnResetToGateClose_ParamsSize = NativeReflection.GetFunctionParamsSize(OnResetToGateClose_FunctionAddress);
		OnResetToGateClose_IsValid = OnResetToGateClose_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUGateStateMachineActor:OnResetToGateClose", OnResetToGateClose_IsValid);
	}

	static BGUGateStateMachineActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUGateStateMachineActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUGateStateMachineActor));
	}
}
