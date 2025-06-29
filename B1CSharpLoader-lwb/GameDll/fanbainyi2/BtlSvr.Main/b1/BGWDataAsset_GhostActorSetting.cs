using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_GhostActorSetting")]
public class BGWDataAsset_GhostActorSetting : UBGWDataAsset
{
	private static bool GhostActorClass_IsValid;

	private static int GhostActorClass_Offset;

	private static bool JustCopyWeapon_IsValid;

	private static int JustCopyWeapon_Offset;

	private static FFieldAddress JustCopyWeapon_PropertyAddress;

	private static bool WeaponIndex_IsValid;

	private static int WeaponIndex_Offset;

	private static bool MatInstances_IsValid;

	private static int MatInstances_Offset;

	private static FFieldAddress MatInstances_PropertyAddress;

	private TArrayReadWriteMarshaler<UMaterialInterface> MatInstances_Marshaler;

	private static bool MatParams_IsValid;

	private static int MatParams_Offset;

	private static FFieldAddress MatParams_PropertyAddress;

	private TArrayReadWriteMarshaler<FMatParamInfo> MatParams_Marshaler;

	private static bool PostProcessMatInstances_IsValid;

	private static int PostProcessMatInstances_Offset;

	private static FFieldAddress PostProcessMatInstances_PropertyAddress;

	private TArrayReadWriteMarshaler<UMaterialInterface> PostProcessMatInstances_Marshaler;

	private static bool PostProcessMatParams_IsValid;

	private static int PostProcessMatParams_Offset;

	private static FFieldAddress PostProcessMatParams_PropertyAddress;

	private TArrayReadWriteMarshaler<FMatParam> PostProcessMatParams_Marshaler;

	private static bool bEnableCustomDepthStencil_IsValid;

	private static int bEnableCustomDepthStencil_Offset;

	private static FFieldAddress bEnableCustomDepthStencil_PropertyAddress;

	private static bool CustomDepthStencilInfos_IsValid;

	private static int CustomDepthStencilInfos_Offset;

	private static FFieldAddress CustomDepthStencilInfos_PropertyAddress;

	private TArrayReadWriteMarshaler<FCustomDepthStencilInfo> CustomDepthStencilInfos_Marshaler;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	private static bool ScaleUseCurve_IsValid;

	private static int ScaleUseCurve_Offset;

	private static FFieldAddress ScaleUseCurve_PropertyAddress;

	private static bool ScaleCurve_IsValid;

	private static int ScaleCurve_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("GhostActorSetting|Actor")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:GhostActorClass")]
	public TSubclassOf<ABGUActorBase> GhostActorClass
	{
		get
		{
			CheckDestroyed();
			if (!GhostActorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:GhostActorClass");
				return default(TSubclassOf<ABGUActorBase>);
			}
			return TSubclassOfMarshaler<ABGUActorBase>.FromNative(IntPtr.Add(base.Address, GhostActorClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GhostActorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:GhostActorClass");
			}
			else
			{
				TSubclassOfMarshaler<ABGUActorBase>.ToNative(IntPtr.Add(base.Address, GhostActorClass_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("GhostActorSetting|Weapon")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:JustCopyWeapon")]
	public bool JustCopyWeapon
	{
		get
		{
			CheckDestroyed();
			if (!JustCopyWeapon_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:JustCopyWeapon");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, JustCopyWeapon_Offset), 0, JustCopyWeapon_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!JustCopyWeapon_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:JustCopyWeapon");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, JustCopyWeapon_Offset), 0, JustCopyWeapon_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "JustCopyWeapon")]
	[Category("GhostActorSetting|Weapon")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:WeaponIndex")]
	public int WeaponIndex
	{
		get
		{
			CheckDestroyed();
			if (!WeaponIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:WeaponIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, WeaponIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeaponIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:WeaponIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, WeaponIndex_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("GhostActorSetting|Mat")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:MatInstances")]
	public TArrayReadWrite<UMaterialInterface> MatInstances
	{
		get
		{
			CheckDestroyed();
			if (!MatInstances_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:MatInstances");
				return null;
			}
			if (MatInstances_Marshaler == null)
			{
				MatInstances_Marshaler = new TArrayReadWriteMarshaler<UMaterialInterface>(1, MatInstances_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative);
			}
			return MatInstances_Marshaler.FromNative(IntPtr.Add(base.Address, MatInstances_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("GhostActorSetting|Mat")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:MatParams")]
	public TArrayReadWrite<FMatParamInfo> MatParams
	{
		get
		{
			CheckDestroyed();
			if (!MatParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:MatParams");
				return null;
			}
			if (MatParams_Marshaler == null)
			{
				MatParams_Marshaler = new TArrayReadWriteMarshaler<FMatParamInfo>(1, MatParams_PropertyAddress, CachedMarshalingDelegates<FMatParamInfo, FMatParamInfo>.FromNative, CachedMarshalingDelegates<FMatParamInfo, FMatParamInfo>.ToNative);
			}
			return MatParams_Marshaler.FromNative(IntPtr.Add(base.Address, MatParams_Offset));
		}
	}

	[Category("GhostActorSetting|PostProcess")]
	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:PostProcessMatInstances")]
	public TArrayReadWrite<UMaterialInterface> PostProcessMatInstances
	{
		get
		{
			CheckDestroyed();
			if (!PostProcessMatInstances_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:PostProcessMatInstances");
				return null;
			}
			if (PostProcessMatInstances_Marshaler == null)
			{
				PostProcessMatInstances_Marshaler = new TArrayReadWriteMarshaler<UMaterialInterface>(1, PostProcessMatInstances_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative);
			}
			return PostProcessMatInstances_Marshaler.FromNative(IntPtr.Add(base.Address, PostProcessMatInstances_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("GhostActorSetting|PostProcess")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:PostProcessMatParams")]
	public TArrayReadWrite<FMatParam> PostProcessMatParams
	{
		get
		{
			CheckDestroyed();
			if (!PostProcessMatParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:PostProcessMatParams");
				return null;
			}
			if (PostProcessMatParams_Marshaler == null)
			{
				PostProcessMatParams_Marshaler = new TArrayReadWriteMarshaler<FMatParam>(1, PostProcessMatParams_PropertyAddress, CachedMarshalingDelegates<FMatParam, FMatParam>.FromNative, CachedMarshalingDelegates<FMatParam, FMatParam>.ToNative);
			}
			return PostProcessMatParams_Marshaler.FromNative(IntPtr.Add(base.Address, PostProcessMatParams_Offset));
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("GhostActorSetting|PostProcess")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:bEnableCustomDepthStencil")]
	public bool bEnableCustomDepthStencil
	{
		get
		{
			CheckDestroyed();
			if (!bEnableCustomDepthStencil_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:bEnableCustomDepthStencil");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableCustomDepthStencil_Offset), 0, bEnableCustomDepthStencil_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableCustomDepthStencil_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:bEnableCustomDepthStencil");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableCustomDepthStencil_Offset), 0, bEnableCustomDepthStencil_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[Category("GhostActorSetting|PostProcess")]
	[UMeta(MDProp.EditCondition, "bEnableCustomDepthStencil")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:CustomDepthStencilInfos")]
	public TArrayReadWrite<FCustomDepthStencilInfo> CustomDepthStencilInfos
	{
		get
		{
			CheckDestroyed();
			if (!CustomDepthStencilInfos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:CustomDepthStencilInfos");
				return null;
			}
			if (CustomDepthStencilInfos_Marshaler == null)
			{
				CustomDepthStencilInfos_Marshaler = new TArrayReadWriteMarshaler<FCustomDepthStencilInfo>(1, CustomDepthStencilInfos_PropertyAddress, CachedMarshalingDelegates<FCustomDepthStencilInfo, FCustomDepthStencilInfo>.FromNative, CachedMarshalingDelegates<FCustomDepthStencilInfo, FCustomDepthStencilInfo>.ToNative);
			}
			return CustomDepthStencilInfos_Marshaler.FromNative(IntPtr.Add(base.Address, CustomDepthStencilInfos_Offset));
		}
	}

	[Category("GhostActorSetting|Scale")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:Scale")]
	public float Scale
	{
		get
		{
			CheckDestroyed();
			if (!Scale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:Scale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Scale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Scale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:Scale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Scale_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[Category("GhostActorSetting|Scale")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:ScaleUseCurve")]
	public bool ScaleUseCurve
	{
		get
		{
			CheckDestroyed();
			if (!ScaleUseCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:ScaleUseCurve");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ScaleUseCurve_Offset), 0, ScaleUseCurve_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ScaleUseCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:ScaleUseCurve");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ScaleUseCurve_Offset), 0, ScaleUseCurve_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("GhostActorSetting|Scale")]
	[UMeta(MDProp.EditCondition, "ScaleUseCurve")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:ScaleCurve")]
	public UCurveFloat ScaleCurve
	{
		get
		{
			CheckDestroyed();
			if (!ScaleCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:ScaleCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, ScaleCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScaleCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GhostActorSetting:ScaleCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, ScaleCurve_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_GhostActorSetting");
		GhostActorClass_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GhostActorClass");
		GhostActorClass_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GhostActorClass", Classes.FClassProperty);
		NativeReflection.GetPropertyRef(ref JustCopyWeapon_PropertyAddress, unrealStruct, "JustCopyWeapon");
		JustCopyWeapon_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "JustCopyWeapon");
		JustCopyWeapon_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "JustCopyWeapon", Classes.FBoolProperty);
		WeaponIndex_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WeaponIndex");
		WeaponIndex_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WeaponIndex", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref MatInstances_PropertyAddress, unrealStruct, "MatInstances");
		MatInstances_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MatInstances");
		MatInstances_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MatInstances", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref MatParams_PropertyAddress, unrealStruct, "MatParams");
		MatParams_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MatParams");
		MatParams_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MatParams", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref PostProcessMatInstances_PropertyAddress, unrealStruct, "PostProcessMatInstances");
		PostProcessMatInstances_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PostProcessMatInstances");
		PostProcessMatInstances_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PostProcessMatInstances", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref PostProcessMatParams_PropertyAddress, unrealStruct, "PostProcessMatParams");
		PostProcessMatParams_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PostProcessMatParams");
		PostProcessMatParams_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PostProcessMatParams", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bEnableCustomDepthStencil_PropertyAddress, unrealStruct, "bEnableCustomDepthStencil");
		bEnableCustomDepthStencil_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEnableCustomDepthStencil");
		bEnableCustomDepthStencil_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEnableCustomDepthStencil", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CustomDepthStencilInfos_PropertyAddress, unrealStruct, "CustomDepthStencilInfos");
		CustomDepthStencilInfos_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CustomDepthStencilInfos");
		CustomDepthStencilInfos_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CustomDepthStencilInfos", Classes.FArrayProperty);
		Scale_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Scale");
		Scale_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Scale", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref ScaleUseCurve_PropertyAddress, unrealStruct, "ScaleUseCurve");
		ScaleUseCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ScaleUseCurve");
		ScaleUseCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ScaleUseCurve", Classes.FBoolProperty);
		ScaleCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ScaleCurve");
		ScaleCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ScaleCurve", Classes.FObjectProperty);
	}

	static BGWDataAsset_GhostActorSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_GhostActorSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_GhostActorSetting));
	}
}
