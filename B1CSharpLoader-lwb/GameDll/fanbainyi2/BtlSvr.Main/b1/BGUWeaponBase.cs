using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUWeaponBase")]
public class BGUWeaponBase : BGUActorBaseCS
{
	private static bool DefaultRootComponent_IsValid;

	private static int DefaultRootComponent_Offset;

	private static bool SkeletalMeshComp_IsValid;

	private static int SkeletalMeshComp_Offset;

	private static bool WeaponBPFunc_IsValid;

	private static IntPtr WeaponBPFunc_FunctionAddress;

	private static int WeaponBPFunc_ParamsSize;

	private static bool WeaponBPFunc_FloatParam_IsValid;

	private static int WeaponBPFunc_FloatParam_Offset;

	private IntPtr WeaponBPFunc_InstanceFunctionAddressInstance;

	private static bool SetMeshNoCollision_IsValid;

	private static IntPtr SetMeshNoCollision_FunctionAddress;

	private static int SetMeshNoCollision_ParamsSize;

	private static bool Tool_ReadWriteTrans_IsValid;

	private static IntPtr Tool_ReadWriteTrans_FunctionAddress;

	private static int Tool_ReadWriteTrans_ParamsSize;

	private static bool Tool_SetRelativeTrans_IsValid;

	private static IntPtr Tool_SetRelativeTrans_FunctionAddress;

	private static int Tool_SetRelativeTrans_ParamsSize;

	private static bool Tool_CheckBoxChildren_IsValid;

	private static IntPtr Tool_CheckBoxChildren_FunctionAddress;

	private static int Tool_CheckBoxChildren_ParamsSize;

	private static bool Tool_CheckBoxChildren_ReturnValue_IsValid;

	private static int Tool_CheckBoxChildren_ReturnValue_Offset;

	private static FFieldAddress Tool_CheckBoxChildren_ReturnValue_PropertyAddress;

	private static bool SetWeaponHasCollision_IsValid;

	private static IntPtr SetWeaponHasCollision_FunctionAddress;

	private static int SetWeaponHasCollision_ParamsSize;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUWeaponBase:DefaultRootComponent")]
	public USceneComponent DefaultRootComponent
	{
		get
		{
			CheckDestroyed();
			if (!DefaultRootComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUWeaponBase:DefaultRootComponent");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, DefaultRootComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultRootComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUWeaponBase:DefaultRootComponent");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, DefaultRootComponent_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUWeaponBase:SkeletalMeshComp")]
	public USkeletalMeshComponent SkeletalMeshComp
	{
		get
		{
			CheckDestroyed();
			if (!SkeletalMeshComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUWeaponBase:SkeletalMeshComp");
				return null;
			}
			return UObjectMarshaler<USkeletalMeshComponent>.FromNative(IntPtr.Add(base.Address, SkeletalMeshComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkeletalMeshComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUWeaponBase:SkeletalMeshComp");
			}
			else
			{
				UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(base.Address, SkeletalMeshComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		USceneComponent rootComponent = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.Root);
		base.RootComponent = rootComponent;
		SkeletalMeshComp = initializer.CreateDefaultSubobject<USkeletalMeshComponent>(this, B1GlobalFNames.MeshComp);
		SkeletalMeshComp.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_WeaponCommComp());
		base.ActorCompContainerCS.AddComp(new b1.BUS_PropMgrComp());
		base.ActorCompContainerCS.AddComp(new b1.BUS_MasterComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_WeaponDataComp>(this, B1GlobalFNames.WeaponDataComp);
	}

	[UFunction]
	[BlueprintCallable]
	[BlueprintImplementedEvent]
	[USharpPath("/Script/b1-Managed.BGUWeaponBase:WeaponBPFunc")]
	public unsafe void WeaponBPFunc(float FloatParam)
	{
		CheckDestroyed();
		if (!WeaponBPFunc_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUWeaponBase:WeaponBPFunc");
			return;
		}
		if (WeaponBPFunc_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			WeaponBPFunc_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "WeaponBPFunc");
		}
		byte* value = stackalloc byte[(int)(uint)WeaponBPFunc_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, WeaponBPFunc_ParamsSize);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, WeaponBPFunc_FloatParam_Offset), FloatParam);
		NativeReflection.InvokeFunction(base.Address, WeaponBPFunc_InstanceFunctionAddressInstance, intPtr, WeaponBPFunc_ParamsSize);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUWeaponBase:Tool_ReadWriteTrans")]
	public void Tool_ReadWriteTrans()
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUWeaponBase:Tool_SetRelativeTrans")]
	public void Tool_SetRelativeTrans()
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUWeaponBase:Tool_CheckBoxChildren")]
	public bool Tool_CheckBoxChildren()
	{
		return false;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUWeaponBase:SetMeshNoCollision")]
	public void SetMeshNoCollision()
	{
		SkeletalMeshComp.SetCollisionProfileName(B1GlobalFNames.NoCollision);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUWeaponBase:SetWeaponHasCollision")]
	public void SetWeaponHasCollision()
	{
		SkeletalMeshComp.SetCollisionProfileName(B1GlobalFNames.WeaponMesh);
		SkeletalMeshComp.SetRenderStatic(bNewValue: false);
		SkeletalMeshComp.NoSkeletonUpdate = false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUWeaponBase:SetMeshNoCollision")]
	private static void SetMeshNoCollision__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUWeaponBase bGUWeaponBase = GCHelper.Find<BGUWeaponBase>(obj);
		bGUWeaponBase.SetMeshNoCollision();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUWeaponBase:Tool_ReadWriteTrans")]
	private static void Tool_ReadWriteTrans__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUWeaponBase bGUWeaponBase = GCHelper.Find<BGUWeaponBase>(obj);
		bGUWeaponBase.Tool_ReadWriteTrans();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUWeaponBase:Tool_SetRelativeTrans")]
	private static void Tool_SetRelativeTrans__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUWeaponBase bGUWeaponBase = GCHelper.Find<BGUWeaponBase>(obj);
		bGUWeaponBase.Tool_SetRelativeTrans();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUWeaponBase:Tool_CheckBoxChildren")]
	private static void Tool_CheckBoxChildren__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUWeaponBase bGUWeaponBase = GCHelper.Find<BGUWeaponBase>(obj);
		bool value = bGUWeaponBase.Tool_CheckBoxChildren();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, Tool_CheckBoxChildren_ReturnValue_Offset), 0, Tool_CheckBoxChildren_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUWeaponBase:SetWeaponHasCollision")]
	private static void SetWeaponHasCollision__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUWeaponBase bGUWeaponBase = GCHelper.Find<BGUWeaponBase>(obj);
		bGUWeaponBase.SetWeaponHasCollision();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUWeaponBase");
		DefaultRootComponent_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultRootComponent");
		DefaultRootComponent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultRootComponent", Classes.FObjectProperty);
		SkeletalMeshComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkeletalMeshComp");
		SkeletalMeshComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkeletalMeshComp", Classes.FObjectProperty);
		WeaponBPFunc_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "WeaponBPFunc");
		WeaponBPFunc_ParamsSize = NativeReflection.GetFunctionParamsSize(WeaponBPFunc_FunctionAddress);
		WeaponBPFunc_FloatParam_Offset = NativeReflection.GetPropertyOffset(WeaponBPFunc_FunctionAddress, "FloatParam");
		WeaponBPFunc_FloatParam_IsValid = NativeReflection.ValidatePropertyClass(WeaponBPFunc_FunctionAddress, "FloatParam", Classes.FFloatProperty);
		WeaponBPFunc_IsValid = WeaponBPFunc_FunctionAddress != IntPtr.Zero && WeaponBPFunc_FloatParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUWeaponBase:WeaponBPFunc", WeaponBPFunc_IsValid);
		SetMeshNoCollision_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMeshNoCollision");
		SetMeshNoCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMeshNoCollision_FunctionAddress);
		SetMeshNoCollision_IsValid = SetMeshNoCollision_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUWeaponBase:SetMeshNoCollision", SetMeshNoCollision_IsValid);
		Tool_ReadWriteTrans_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Tool_ReadWriteTrans");
		Tool_ReadWriteTrans_ParamsSize = NativeReflection.GetFunctionParamsSize(Tool_ReadWriteTrans_FunctionAddress);
		Tool_ReadWriteTrans_IsValid = Tool_ReadWriteTrans_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUWeaponBase:Tool_ReadWriteTrans", Tool_ReadWriteTrans_IsValid);
		Tool_SetRelativeTrans_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Tool_SetRelativeTrans");
		Tool_SetRelativeTrans_ParamsSize = NativeReflection.GetFunctionParamsSize(Tool_SetRelativeTrans_FunctionAddress);
		Tool_SetRelativeTrans_IsValid = Tool_SetRelativeTrans_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUWeaponBase:Tool_SetRelativeTrans", Tool_SetRelativeTrans_IsValid);
		Tool_CheckBoxChildren_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Tool_CheckBoxChildren");
		Tool_CheckBoxChildren_ParamsSize = NativeReflection.GetFunctionParamsSize(Tool_CheckBoxChildren_FunctionAddress);
		NativeReflection.GetPropertyRef(ref Tool_CheckBoxChildren_ReturnValue_PropertyAddress, Tool_CheckBoxChildren_FunctionAddress, "ReturnValue");
		Tool_CheckBoxChildren_ReturnValue_Offset = NativeReflection.GetPropertyOffset(Tool_CheckBoxChildren_FunctionAddress, "ReturnValue");
		Tool_CheckBoxChildren_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(Tool_CheckBoxChildren_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Tool_CheckBoxChildren_IsValid = Tool_CheckBoxChildren_FunctionAddress != IntPtr.Zero && Tool_CheckBoxChildren_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUWeaponBase:Tool_CheckBoxChildren", Tool_CheckBoxChildren_IsValid);
		SetWeaponHasCollision_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetWeaponHasCollision");
		SetWeaponHasCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWeaponHasCollision_FunctionAddress);
		SetWeaponHasCollision_IsValid = SetWeaponHasCollision_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUWeaponBase:SetWeaponHasCollision", SetWeaponHasCollision_IsValid);
	}

	static BGUWeaponBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUWeaponBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUWeaponBase));
	}
}
