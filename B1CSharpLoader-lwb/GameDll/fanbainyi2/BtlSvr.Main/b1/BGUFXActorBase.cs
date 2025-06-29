using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUFXActorBase")]
public class BGUFXActorBase : BGUActorBaseCS, IBGUDestructibleActor
{
	private static bool Root_IsValid;

	private static int Root_Offset;

	private static bool FXActorBaseConfigComp_IsValid;

	private static int FXActorBaseConfigComp_Offset;

	private static bool DestructibleConfigComp_IsValid;

	private static int DestructibleConfigComp_Offset;

	private static bool FXAudioEditComp_IsValid;

	private static int FXAudioEditComp_Offset;

	private static bool IsDead_IsValid;

	private static IntPtr IsDead_FunctionAddress;

	private static int IsDead_ParamsSize;

	private static bool IsDead_ReturnValue_IsValid;

	private static int IsDead_ReturnValue_Offset;

	private static FFieldAddress IsDead_ReturnValue_PropertyAddress;

	private static bool OnHitDestructible_IsValid;

	private static IntPtr OnHitDestructible_FunctionAddress;

	private static int OnHitDestructible_ParamsSize;

	private static bool OnHitDestructible_HitLocation_IsValid;

	private static int OnHitDestructible_HitLocation_Offset;

	private static FFieldAddress OnHitDestructible_HitLocation_PropertyAddress;

	private static bool OnHitDestructible_ImpulseDir_IsValid;

	private static int OnHitDestructible_ImpulseDir_Offset;

	private static FFieldAddress OnHitDestructible_ImpulseDir_PropertyAddress;

	private static bool OnHitDestructible_ImpulseStrength_IsValid;

	private static int OnHitDestructible_ImpulseStrength_Offset;

	private static bool OnHitDestructible_Damage_IsValid;

	private static int OnHitDestructible_Damage_Offset;

	private IntPtr OnHitDestructible_InstanceFunctionAddressInstance;

	private static bool OnResetDestructible_IsValid;

	private static IntPtr OnResetDestructible_FunctionAddress;

	private static int OnResetDestructible_ParamsSize;

	private static bool OnResetDestructible_IsDestroyed_IsValid;

	private static int OnResetDestructible_IsDestroyed_Offset;

	private static FFieldAddress OnResetDestructible_IsDestroyed_PropertyAddress;

	private IntPtr OnResetDestructible_InstanceFunctionAddressInstance;

	private static bool OnDestroyDestructible_IsValid;

	private static IntPtr OnDestroyDestructible_FunctionAddress;

	private static int OnDestroyDestructible_ParamsSize;

	private static bool OnDestroyDestructible_HitLocation_IsValid;

	private static int OnDestroyDestructible_HitLocation_Offset;

	private static FFieldAddress OnDestroyDestructible_HitLocation_PropertyAddress;

	private static bool OnDestroyDestructible_ImpulseDir_IsValid;

	private static int OnDestroyDestructible_ImpulseDir_Offset;

	private static FFieldAddress OnDestroyDestructible_ImpulseDir_PropertyAddress;

	private static bool OnDestroyDestructible_ImpulseStrength_IsValid;

	private static int OnDestroyDestructible_ImpulseStrength_Offset;

	private static bool OnDestroyDestructible_Damage_IsValid;

	private static int OnDestroyDestructible_Damage_Offset;

	private IntPtr OnDestroyDestructible_InstanceFunctionAddressInstance;

	private static bool SetFloatValueToMaterialAdvect_IsValid;

	private static IntPtr SetFloatValueToMaterialAdvect_FunctionAddress;

	private static int SetFloatValueToMaterialAdvect_ParamsSize;

	private static bool SetFloatValueToMaterialAdvect_ParamName_IsValid;

	private static int SetFloatValueToMaterialAdvect_ParamName_Offset;

	private static bool SetFloatValueToMaterialAdvect_FloatValue_IsValid;

	private static int SetFloatValueToMaterialAdvect_FloatValue_Offset;

	private IntPtr SetFloatValueToMaterialAdvect_InstanceFunctionAddressInstance;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUFXActorBase:Root")]
	public USceneComponent Root
	{
		get
		{
			CheckDestroyed();
			if (!Root_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUFXActorBase:Root");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, Root_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Root_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUFXActorBase:Root");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, Root_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUFXActorBase:FXActorBaseConfigComp")]
	public BUS_FXActorBaseConfigComp FXActorBaseConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!FXActorBaseConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUFXActorBase:FXActorBaseConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_FXActorBaseConfigComp>.FromNative(IntPtr.Add(base.Address, FXActorBaseConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FXActorBaseConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUFXActorBase:FXActorBaseConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_FXActorBaseConfigComp>.ToNative(IntPtr.Add(base.Address, FXActorBaseConfigComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUFXActorBase:DestructibleConfigComp")]
	public BUS_DestructibleConfigComp DestructibleConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!DestructibleConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUFXActorBase:DestructibleConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_DestructibleConfigComp>.FromNative(IntPtr.Add(base.Address, DestructibleConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestructibleConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUFXActorBase:DestructibleConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_DestructibleConfigComp>.ToNative(IntPtr.Add(base.Address, DestructibleConfigComp_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUFXActorBase:FXAudioEditComp")]
	public BUS_FXAudioEditComp FXAudioEditComp
	{
		get
		{
			CheckDestroyed();
			if (!FXAudioEditComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUFXActorBase:FXAudioEditComp");
				return null;
			}
			return UObjectMarshaler<BUS_FXAudioEditComp>.FromNative(IntPtr.Add(base.Address, FXAudioEditComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FXAudioEditComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUFXActorBase:FXAudioEditComp");
			}
			else
			{
				UObjectMarshaler<BUS_FXAudioEditComp>.ToNative(IntPtr.Add(base.Address, FXAudioEditComp_Offset), value);
			}
		}
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_FXDataComp>(this, B1GlobalFNames.FXDataComp);
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		Root = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.Root);
		SetRootComponentCS(Root);
		FXActorBaseConfigComp = initializer.CreateDefaultSubobject<BUS_FXActorBaseConfigComp>(this, B1GlobalFNames.FXActorBaseConfigComp);
		FXAudioEditComp = initializer.CreateDefaultSubobject<BUS_FXAudioEditComp>(this, B1GlobalFNames.FXAudioEditComp);
		DestructibleConfigComp = initializer.CreateDefaultSubobject<BUS_DestructibleConfigComp>(this, B1GlobalFNames.DestructibleConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_FXProcessComp());
		base.ActorCompContainerCS.AddComp(new BUS_DestructibleComp());
		base.ActorCompContainerCS.AddComp(new BUS_FXActorLifeComp());
		base.ActorCompContainerCS.AddComp(new BUS_FXAkComp());
		base.ActorCompContainerCS.AddComp(new BUS_SimpleOverlapComp());
	}

	[USharpPath("/Script/b1-Managed.BGUFXActorBase:ReceiveBeginPlay")]
	protected override void ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
		UBGUFunctionLibrary.BGUResetActorVelocity(this);
	}

	[BlueprintCallable]
	[BlueprintImplementedEvent]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFXActorBase:OnHitDestructible")]
	public unsafe void OnHitDestructible(FVector HitLocation, FVector ImpulseDir, float ImpulseStrength, float Damage)
	{
		CheckDestroyed();
		if (!OnHitDestructible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUFXActorBase:OnHitDestructible");
			return;
		}
		if (OnHitDestructible_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnHitDestructible_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnHitDestructible");
		}
		byte* value = stackalloc byte[(int)(uint)OnHitDestructible_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnHitDestructible_ParamsSize);
		NativeReflection.InitializeValue_InContainer(OnHitDestructible_HitLocation_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnHitDestructible_HitLocation_Offset), HitLocation);
		NativeReflection.InitializeValue_InContainer(OnHitDestructible_ImpulseDir_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnHitDestructible_ImpulseDir_Offset), ImpulseDir);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnHitDestructible_ImpulseStrength_Offset), ImpulseStrength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnHitDestructible_Damage_Offset), Damage);
		NativeReflection.InvokeFunction(base.Address, OnHitDestructible_InstanceFunctionAddressInstance, intPtr, OnHitDestructible_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnHitDestructible_HitLocation_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OnHitDestructible_ImpulseDir_PropertyAddress.Address, intPtr);
	}

	[UFunction]
	[BlueprintCallable]
	[BlueprintImplementedEvent]
	[USharpPath("/Script/b1-Managed.BGUFXActorBase:OnDestroyDestructible")]
	public unsafe void OnDestroyDestructible(FVector HitLocation, FVector ImpulseDir, float ImpulseStrength, float Damage)
	{
		CheckDestroyed();
		if (!OnDestroyDestructible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUFXActorBase:OnDestroyDestructible");
			return;
		}
		if (OnDestroyDestructible_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnDestroyDestructible_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnDestroyDestructible");
		}
		byte* value = stackalloc byte[(int)(uint)OnDestroyDestructible_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnDestroyDestructible_ParamsSize);
		NativeReflection.InitializeValue_InContainer(OnDestroyDestructible_HitLocation_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnDestroyDestructible_HitLocation_Offset), HitLocation);
		NativeReflection.InitializeValue_InContainer(OnDestroyDestructible_ImpulseDir_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnDestroyDestructible_ImpulseDir_Offset), ImpulseDir);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnDestroyDestructible_ImpulseStrength_Offset), ImpulseStrength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnDestroyDestructible_Damage_Offset), Damage);
		NativeReflection.InvokeFunction(base.Address, OnDestroyDestructible_InstanceFunctionAddressInstance, intPtr, OnDestroyDestructible_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnDestroyDestructible_HitLocation_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OnDestroyDestructible_ImpulseDir_PropertyAddress.Address, intPtr);
	}

	[BlueprintCallable]
	[BlueprintImplementedEvent]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFXActorBase:OnResetDestructible")]
	public unsafe void OnResetDestructible(bool IsDestroyed)
	{
		CheckDestroyed();
		if (!OnResetDestructible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUFXActorBase:OnResetDestructible");
			return;
		}
		if (OnResetDestructible_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnResetDestructible_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnResetDestructible");
		}
		byte* value = stackalloc byte[(int)(uint)OnResetDestructible_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnResetDestructible_ParamsSize);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnResetDestructible_IsDestroyed_Offset), 0, OnResetDestructible_IsDestroyed_PropertyAddress.Address, IsDestroyed);
		NativeReflection.InvokeFunction(base.Address, OnResetDestructible_InstanceFunctionAddressInstance, intPtr, OnResetDestructible_ParamsSize);
	}

	[BlueprintImplementedEvent]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFXActorBase:SetFloatValueToMaterialAdvect")]
	public unsafe void SetFloatValueToMaterialAdvect(FName ParamName, float FloatValue)
	{
		CheckDestroyed();
		if (!SetFloatValueToMaterialAdvect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUFXActorBase:SetFloatValueToMaterialAdvect");
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

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFXActorBase:IsDead")]
	public bool IsDead()
	{
		return BGU_DataUtil.GetReadOnlyData<BUC_FXActorLifeData>(this)?.FXActorIsDead ?? false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFXActorBase:IsDead")]
	private static void IsDead__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUFXActorBase bGUFXActorBase = GCHelper.Find<BGUFXActorBase>(obj);
		bool value = bGUFXActorBase.IsDead();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsDead_ReturnValue_Offset), 0, IsDead_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFXActorBase:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUFXActorBase bGUFXActorBase = GCHelper.Find<BGUFXActorBase>(obj);
		bGUFXActorBase.ReceiveBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUFXActorBase");
		Root_Offset = NativeReflection.GetPropertyOffset(intPtr, "Root");
		Root_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Root", Classes.FObjectProperty);
		FXActorBaseConfigComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "FXActorBaseConfigComp");
		FXActorBaseConfigComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FXActorBaseConfigComp", Classes.FObjectProperty);
		DestructibleConfigComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "DestructibleConfigComp");
		DestructibleConfigComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DestructibleConfigComp", Classes.FObjectProperty);
		FXAudioEditComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "FXAudioEditComp");
		FXAudioEditComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FXAudioEditComp", Classes.FObjectProperty);
		IsDead_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsDead");
		IsDead_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDead_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsDead_ReturnValue_PropertyAddress, IsDead_FunctionAddress, "ReturnValue");
		IsDead_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsDead_FunctionAddress, "ReturnValue");
		IsDead_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsDead_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDead_IsValid = IsDead_FunctionAddress != IntPtr.Zero && IsDead_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFXActorBase:IsDead", IsDead_IsValid);
		OnHitDestructible_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnHitDestructible");
		OnHitDestructible_ParamsSize = NativeReflection.GetFunctionParamsSize(OnHitDestructible_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnHitDestructible_HitLocation_PropertyAddress, OnHitDestructible_FunctionAddress, "HitLocation");
		OnHitDestructible_HitLocation_Offset = NativeReflection.GetPropertyOffset(OnHitDestructible_FunctionAddress, "HitLocation");
		OnHitDestructible_HitLocation_IsValid = NativeReflection.ValidatePropertyClass(OnHitDestructible_FunctionAddress, "HitLocation", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnHitDestructible_ImpulseDir_PropertyAddress, OnHitDestructible_FunctionAddress, "ImpulseDir");
		OnHitDestructible_ImpulseDir_Offset = NativeReflection.GetPropertyOffset(OnHitDestructible_FunctionAddress, "ImpulseDir");
		OnHitDestructible_ImpulseDir_IsValid = NativeReflection.ValidatePropertyClass(OnHitDestructible_FunctionAddress, "ImpulseDir", Classes.FStructProperty);
		OnHitDestructible_ImpulseStrength_Offset = NativeReflection.GetPropertyOffset(OnHitDestructible_FunctionAddress, "ImpulseStrength");
		OnHitDestructible_ImpulseStrength_IsValid = NativeReflection.ValidatePropertyClass(OnHitDestructible_FunctionAddress, "ImpulseStrength", Classes.FFloatProperty);
		OnHitDestructible_Damage_Offset = NativeReflection.GetPropertyOffset(OnHitDestructible_FunctionAddress, "Damage");
		OnHitDestructible_Damage_IsValid = NativeReflection.ValidatePropertyClass(OnHitDestructible_FunctionAddress, "Damage", Classes.FFloatProperty);
		OnHitDestructible_IsValid = OnHitDestructible_FunctionAddress != IntPtr.Zero && OnHitDestructible_HitLocation_IsValid && OnHitDestructible_ImpulseDir_IsValid && OnHitDestructible_ImpulseStrength_IsValid && OnHitDestructible_Damage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFXActorBase:OnHitDestructible", OnHitDestructible_IsValid);
		OnResetDestructible_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnResetDestructible");
		OnResetDestructible_ParamsSize = NativeReflection.GetFunctionParamsSize(OnResetDestructible_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnResetDestructible_IsDestroyed_PropertyAddress, OnResetDestructible_FunctionAddress, "IsDestroyed");
		OnResetDestructible_IsDestroyed_Offset = NativeReflection.GetPropertyOffset(OnResetDestructible_FunctionAddress, "IsDestroyed");
		OnResetDestructible_IsDestroyed_IsValid = NativeReflection.ValidatePropertyClass(OnResetDestructible_FunctionAddress, "IsDestroyed", Classes.FBoolProperty);
		OnResetDestructible_IsValid = OnResetDestructible_FunctionAddress != IntPtr.Zero && OnResetDestructible_IsDestroyed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFXActorBase:OnResetDestructible", OnResetDestructible_IsValid);
		OnDestroyDestructible_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnDestroyDestructible");
		OnDestroyDestructible_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDestroyDestructible_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnDestroyDestructible_HitLocation_PropertyAddress, OnDestroyDestructible_FunctionAddress, "HitLocation");
		OnDestroyDestructible_HitLocation_Offset = NativeReflection.GetPropertyOffset(OnDestroyDestructible_FunctionAddress, "HitLocation");
		OnDestroyDestructible_HitLocation_IsValid = NativeReflection.ValidatePropertyClass(OnDestroyDestructible_FunctionAddress, "HitLocation", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnDestroyDestructible_ImpulseDir_PropertyAddress, OnDestroyDestructible_FunctionAddress, "ImpulseDir");
		OnDestroyDestructible_ImpulseDir_Offset = NativeReflection.GetPropertyOffset(OnDestroyDestructible_FunctionAddress, "ImpulseDir");
		OnDestroyDestructible_ImpulseDir_IsValid = NativeReflection.ValidatePropertyClass(OnDestroyDestructible_FunctionAddress, "ImpulseDir", Classes.FStructProperty);
		OnDestroyDestructible_ImpulseStrength_Offset = NativeReflection.GetPropertyOffset(OnDestroyDestructible_FunctionAddress, "ImpulseStrength");
		OnDestroyDestructible_ImpulseStrength_IsValid = NativeReflection.ValidatePropertyClass(OnDestroyDestructible_FunctionAddress, "ImpulseStrength", Classes.FFloatProperty);
		OnDestroyDestructible_Damage_Offset = NativeReflection.GetPropertyOffset(OnDestroyDestructible_FunctionAddress, "Damage");
		OnDestroyDestructible_Damage_IsValid = NativeReflection.ValidatePropertyClass(OnDestroyDestructible_FunctionAddress, "Damage", Classes.FFloatProperty);
		OnDestroyDestructible_IsValid = OnDestroyDestructible_FunctionAddress != IntPtr.Zero && OnDestroyDestructible_HitLocation_IsValid && OnDestroyDestructible_ImpulseDir_IsValid && OnDestroyDestructible_ImpulseStrength_IsValid && OnDestroyDestructible_Damage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFXActorBase:OnDestroyDestructible", OnDestroyDestructible_IsValid);
		SetFloatValueToMaterialAdvect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFloatValueToMaterialAdvect");
		SetFloatValueToMaterialAdvect_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFloatValueToMaterialAdvect_FunctionAddress);
		SetFloatValueToMaterialAdvect_ParamName_Offset = NativeReflection.GetPropertyOffset(SetFloatValueToMaterialAdvect_FunctionAddress, "ParamName");
		SetFloatValueToMaterialAdvect_ParamName_IsValid = NativeReflection.ValidatePropertyClass(SetFloatValueToMaterialAdvect_FunctionAddress, "ParamName", Classes.FNameProperty);
		SetFloatValueToMaterialAdvect_FloatValue_Offset = NativeReflection.GetPropertyOffset(SetFloatValueToMaterialAdvect_FunctionAddress, "FloatValue");
		SetFloatValueToMaterialAdvect_FloatValue_IsValid = NativeReflection.ValidatePropertyClass(SetFloatValueToMaterialAdvect_FunctionAddress, "FloatValue", Classes.FFloatProperty);
		SetFloatValueToMaterialAdvect_IsValid = SetFloatValueToMaterialAdvect_FunctionAddress != IntPtr.Zero && SetFloatValueToMaterialAdvect_ParamName_IsValid && SetFloatValueToMaterialAdvect_FloatValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFXActorBase:SetFloatValueToMaterialAdvect", SetFloatValueToMaterialAdvect_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFXActorBase:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
	}

	static BGUFXActorBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUFXActorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUFXActorBase));
	}
}
