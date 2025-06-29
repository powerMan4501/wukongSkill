using System;
using b1.BGU.BUActor.BUFXActor.BGUFXActorS;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUDroppableDestructionActorBase")]
public class BGUDroppableDestructionActorBase : BGUInteractiveActorBase, IBGUDestructibleActor
{
	private static bool DestructibleConfigComp_IsValid;

	private static int DestructibleConfigComp_Offset;

	private static bool FXAudioEditComp_IsValid;

	private static int FXAudioEditComp_Offset;

	private static bool SetFloatValueToMaterialAdvect_IsValid;

	private static IntPtr SetFloatValueToMaterialAdvect_FunctionAddress;

	private static int SetFloatValueToMaterialAdvect_ParamsSize;

	private static bool SetFloatValueToMaterialAdvect_ParamName_IsValid;

	private static int SetFloatValueToMaterialAdvect_ParamName_Offset;

	private static bool SetFloatValueToMaterialAdvect_FloatValue_IsValid;

	private static int SetFloatValueToMaterialAdvect_FloatValue_Offset;

	private IntPtr SetFloatValueToMaterialAdvect_InstanceFunctionAddressInstance;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUDroppableDestructionActorBase:DestructibleConfigComp")]
	public BUS_DestructibleConfigComp DestructibleConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!DestructibleConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDroppableDestructionActorBase:DestructibleConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_DestructibleConfigComp>.FromNative(IntPtr.Add(base.Address, DestructibleConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestructibleConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDroppableDestructionActorBase:DestructibleConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_DestructibleConfigComp>.ToNative(IntPtr.Add(base.Address, DestructibleConfigComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUDroppableDestructionActorBase:FXAudioEditComp")]
	public BUS_FXAudioEditComp FXAudioEditComp
	{
		get
		{
			CheckDestroyed();
			if (!FXAudioEditComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDroppableDestructionActorBase:FXAudioEditComp");
				return null;
			}
			return UObjectMarshaler<BUS_FXAudioEditComp>.FromNative(IntPtr.Add(base.Address, FXAudioEditComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FXAudioEditComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDroppableDestructionActorBase:FXAudioEditComp");
			}
			else
			{
				UObjectMarshaler<BUS_FXAudioEditComp>.ToNative(IntPtr.Add(base.Address, FXAudioEditComp_Offset), value);
			}
		}
	}

	public override void GetLifetimeReplicatedProps(FLifetimePropertyCollection lifetimeProps)
	{
		base.GetLifetimeReplicatedProps(lifetimeProps);
		lifetimeProps.Add("RPCEventCollection");
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_DroppableDestructionDataComp>(this, B1GlobalFNames.DroppableDestructionDataComp);
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		FXAudioEditComp = initializer.CreateDefaultSubobject<BUS_FXAudioEditComp>(this, B1GlobalFNames.FXAudioEditComp);
		DestructibleConfigComp = initializer.CreateDefaultSubobject<BUS_DestructibleConfigComp>(this, B1GlobalFNames.DestructibleConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_DestructibleComp());
		base.ActorCompContainerCS.AddComp(new BUS_FXAkComp());
		base.ActorCompContainerCS.AddComp(new BUS_SimpleOverlapComp());
		base.ActorCompContainerCS.AddComp(new BUS_DestructionDropComp());
	}

	[UFunction]
	[BlueprintCallable]
	[BlueprintImplementedEvent]
	[USharpPath("/Script/b1-Managed.BGUDroppableDestructionActorBase:SetFloatValueToMaterialAdvect")]
	public unsafe void SetFloatValueToMaterialAdvect(FName ParamName, float FloatValue)
	{
		CheckDestroyed();
		if (!SetFloatValueToMaterialAdvect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUDroppableDestructionActorBase:SetFloatValueToMaterialAdvect");
			return;
		}
		if (SetFloatValueToMaterialAdvect_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			SetFloatValueToMaterialAdvect_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "SetFloatValueToMaterialAdvect");
		}
		byte* value = stackalloc byte[(int)(uint)SetFloatValueToMaterialAdvect_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, SetFloatValueToMaterialAdvect_ParamsSize);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetFloatValueToMaterialAdvect_ParamName_Offset), ParamName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFloatValueToMaterialAdvect_FloatValue_Offset), FloatValue);
		NativeReflection.InvokeFunction(base.Address, SetFloatValueToMaterialAdvect_InstanceFunctionAddressInstance, intPtr, SetFloatValueToMaterialAdvect_ParamsSize);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUDroppableDestructionActorBase");
		DestructibleConfigComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "DestructibleConfigComp");
		DestructibleConfigComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DestructibleConfigComp", Classes.FObjectProperty);
		FXAudioEditComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "FXAudioEditComp");
		FXAudioEditComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FXAudioEditComp", Classes.FObjectProperty);
		SetFloatValueToMaterialAdvect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFloatValueToMaterialAdvect");
		SetFloatValueToMaterialAdvect_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFloatValueToMaterialAdvect_FunctionAddress);
		SetFloatValueToMaterialAdvect_ParamName_Offset = NativeReflection.GetPropertyOffset(SetFloatValueToMaterialAdvect_FunctionAddress, "ParamName");
		SetFloatValueToMaterialAdvect_ParamName_IsValid = NativeReflection.ValidatePropertyClass(SetFloatValueToMaterialAdvect_FunctionAddress, "ParamName", Classes.FNameProperty);
		SetFloatValueToMaterialAdvect_FloatValue_Offset = NativeReflection.GetPropertyOffset(SetFloatValueToMaterialAdvect_FunctionAddress, "FloatValue");
		SetFloatValueToMaterialAdvect_FloatValue_IsValid = NativeReflection.ValidatePropertyClass(SetFloatValueToMaterialAdvect_FunctionAddress, "FloatValue", Classes.FFloatProperty);
		SetFloatValueToMaterialAdvect_IsValid = SetFloatValueToMaterialAdvect_FunctionAddress != IntPtr.Zero && SetFloatValueToMaterialAdvect_ParamName_IsValid && SetFloatValueToMaterialAdvect_FloatValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUDroppableDestructionActorBase:SetFloatValueToMaterialAdvect", SetFloatValueToMaterialAdvect_IsValid);
	}

	static BGUDroppableDestructionActorBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUDroppableDestructionActorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUDroppableDestructionActorBase));
	}
}
