using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig")]
public class BGWDataAsset_BuffSetCurveValueToMeshConfig : UBGWDataAsset
{
	private static bool FloatCurveParamList_IsValid;

	private static int FloatCurveParamList_Offset;

	private static FFieldAddress FloatCurveParamList_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSFloatCurveToParam> FloatCurveParamList_Marshaler;

	private static bool LinearColorCurveParamList_IsValid;

	private static int LinearColorCurveParamList_Offset;

	private static FFieldAddress LinearColorCurveParamList_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSLinearColorCurveToParam> LinearColorCurveParamList_Marshaler;

	private static bool NotApplyToChrMesh_IsValid;

	private static int NotApplyToChrMesh_Offset;

	private static FFieldAddress NotApplyToChrMesh_PropertyAddress;

	private static bool MatIndexList_IsValid;

	private static int MatIndexList_Offset;

	private static FFieldAddress MatIndexList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> MatIndexList_Marshaler;

	private static bool BothWeapons_IsValid;

	private static int BothWeapons_Offset;

	private static FFieldAddress BothWeapons_PropertyAddress;

	private static bool WeaponIndexList_IsValid;

	private static int WeaponIndexList_Offset;

	private static FFieldAddress WeaponIndexList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> WeaponIndexList_Marshaler;

	private static bool WeaponMatIndexList_IsValid;

	private static int WeaponMatIndexList_Offset;

	private static FFieldAddress WeaponMatIndexList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> WeaponMatIndexList_Marshaler;

	private static bool BothChildMeshes_IsValid;

	private static int BothChildMeshes_Offset;

	private static FFieldAddress BothChildMeshes_PropertyAddress;

	private static bool ChildMeshTagList_IsValid;

	private static int ChildMeshTagList_Offset;

	private static FFieldAddress ChildMeshTagList_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> ChildMeshTagList_Marshaler;

	private static bool ChildMeshMatIndexList_IsValid;

	private static int ChildMeshMatIndexList_Offset;

	private static FFieldAddress ChildMeshMatIndexList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> ChildMeshMatIndexList_Marshaler;

	private static bool BothChildActor_IsValid;

	private static int BothChildActor_Offset;

	private static FFieldAddress BothChildActor_PropertyAddress;

	private static bool ChildActorMeshMatIndexList_IsValid;

	private static int ChildActorMeshMatIndexList_Offset;

	private static FFieldAddress ChildActorMeshMatIndexList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> ChildActorMeshMatIndexList_Marshaler;

	private static bool BothHair_IsValid;

	private static int BothHair_Offset;

	private static FFieldAddress BothHair_PropertyAddress;

	private static bool HairType_IsValid;

	private static int HairType_Offset;

	private static FFieldAddress HairType_PropertyAddress;

	private static bool HairCompTagList_IsValid;

	private static int HairCompTagList_Offset;

	private static FFieldAddress HairCompTagList_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> HairCompTagList_Marshaler;

	private static bool HairFloatCurveParamList_IsValid;

	private static int HairFloatCurveParamList_Offset;

	private static FFieldAddress HairFloatCurveParamList_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSFloatCurveToParam> HairFloatCurveParamList_Marshaler;

	private static bool NeedRecovery_IsValid;

	private static int NeedRecovery_Offset;

	private static FFieldAddress NeedRecovery_PropertyAddress;

	private static bool bFitRealTime_IsValid;

	private static int bFitRealTime_Offset;

	private static FFieldAddress bFitRealTime_PropertyAddress;

	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("SetCurveToMeshConfig")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:FloatCurveParamList")]
	public TArrayReadWrite<FGSFloatCurveToParam> FloatCurveParamList
	{
		get
		{
			CheckDestroyed();
			if (!FloatCurveParamList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:FloatCurveParamList");
				return null;
			}
			if (FloatCurveParamList_Marshaler == null)
			{
				FloatCurveParamList_Marshaler = new TArrayReadWriteMarshaler<FGSFloatCurveToParam>(1, FloatCurveParamList_PropertyAddress, CachedMarshalingDelegates<FGSFloatCurveToParam, FGSFloatCurveToParam>.FromNative, CachedMarshalingDelegates<FGSFloatCurveToParam, FGSFloatCurveToParam>.ToNative);
			}
			return FloatCurveParamList_Marshaler.FromNative(IntPtr.Add(base.Address, FloatCurveParamList_Offset));
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("SetCurveToMeshConfig")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:LinearColorCurveParamList")]
	public TArrayReadWrite<FGSLinearColorCurveToParam> LinearColorCurveParamList
	{
		get
		{
			CheckDestroyed();
			if (!LinearColorCurveParamList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:LinearColorCurveParamList");
				return null;
			}
			if (LinearColorCurveParamList_Marshaler == null)
			{
				LinearColorCurveParamList_Marshaler = new TArrayReadWriteMarshaler<FGSLinearColorCurveToParam>(1, LinearColorCurveParamList_PropertyAddress, CachedMarshalingDelegates<FGSLinearColorCurveToParam, FGSLinearColorCurveToParam>.FromNative, CachedMarshalingDelegates<FGSLinearColorCurveToParam, FGSLinearColorCurveToParam>.ToNative);
			}
			return LinearColorCurveParamList_Marshaler.FromNative(IntPtr.Add(base.Address, LinearColorCurveParamList_Offset));
		}
	}

	[DisplayName("不应用到角色Mesh")]
	[Category("SetCurveToMeshConfig")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:NotApplyToChrMesh")]
	public bool NotApplyToChrMesh
	{
		get
		{
			CheckDestroyed();
			if (!NotApplyToChrMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:NotApplyToChrMesh");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NotApplyToChrMesh_Offset), 0, NotApplyToChrMesh_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NotApplyToChrMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:NotApplyToChrMesh");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NotApplyToChrMesh_Offset), 0, NotApplyToChrMesh_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("SetCurveToMeshConfig")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:MatIndexList")]
	public TArrayReadWrite<int> MatIndexList
	{
		get
		{
			CheckDestroyed();
			if (!MatIndexList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:MatIndexList");
				return null;
			}
			if (MatIndexList_Marshaler == null)
			{
				MatIndexList_Marshaler = new TArrayReadWriteMarshaler<int>(1, MatIndexList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return MatIndexList_Marshaler.FromNative(IntPtr.Add(base.Address, MatIndexList_Offset));
		}
	}

	[BlueprintReadOnly]
	[EditAnywhere]
	[Category("SetCurveToMeshConfig")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:BothWeapons")]
	public bool BothWeapons
	{
		get
		{
			CheckDestroyed();
			if (!BothWeapons_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:BothWeapons");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BothWeapons_Offset), 0, BothWeapons_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BothWeapons_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:BothWeapons");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BothWeapons_Offset), 0, BothWeapons_PropertyAddress.Address, value);
			}
		}
	}

	[Category("SetCurveToMeshConfig")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[UMeta(MDProp.EditCondition, "BothWeapons")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:WeaponIndexList")]
	public TArrayReadWrite<int> WeaponIndexList
	{
		get
		{
			CheckDestroyed();
			if (!WeaponIndexList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:WeaponIndexList");
				return null;
			}
			if (WeaponIndexList_Marshaler == null)
			{
				WeaponIndexList_Marshaler = new TArrayReadWriteMarshaler<int>(1, WeaponIndexList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return WeaponIndexList_Marshaler.FromNative(IntPtr.Add(base.Address, WeaponIndexList_Offset));
		}
	}

	[UMeta(MDProp.EditCondition, "BothWeapons")]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("SetCurveToMeshConfig")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:WeaponMatIndexList")]
	public TArrayReadWrite<int> WeaponMatIndexList
	{
		get
		{
			CheckDestroyed();
			if (!WeaponMatIndexList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:WeaponMatIndexList");
				return null;
			}
			if (WeaponMatIndexList_Marshaler == null)
			{
				WeaponMatIndexList_Marshaler = new TArrayReadWriteMarshaler<int>(1, WeaponMatIndexList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return WeaponMatIndexList_Marshaler.FromNative(IntPtr.Add(base.Address, WeaponMatIndexList_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("SetCurveToMeshConfig")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:BothChildMeshes")]
	public bool BothChildMeshes
	{
		get
		{
			CheckDestroyed();
			if (!BothChildMeshes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:BothChildMeshes");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BothChildMeshes_Offset), 0, BothChildMeshes_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BothChildMeshes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:BothChildMeshes");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BothChildMeshes_Offset), 0, BothChildMeshes_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("SetCurveToMeshConfig")]
	[UMeta(MDProp.EditCondition, "BothChildMeshes")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:ChildMeshTagList")]
	public TArrayReadWrite<FName> ChildMeshTagList
	{
		get
		{
			CheckDestroyed();
			if (!ChildMeshTagList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:ChildMeshTagList");
				return null;
			}
			if (ChildMeshTagList_Marshaler == null)
			{
				ChildMeshTagList_Marshaler = new TArrayReadWriteMarshaler<FName>(1, ChildMeshTagList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return ChildMeshTagList_Marshaler.FromNative(IntPtr.Add(base.Address, ChildMeshTagList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("SetCurveToMeshConfig")]
	[UMeta(MDProp.EditCondition, "BothChildMeshes")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:ChildMeshMatIndexList")]
	public TArrayReadWrite<int> ChildMeshMatIndexList
	{
		get
		{
			CheckDestroyed();
			if (!ChildMeshMatIndexList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:ChildMeshMatIndexList");
				return null;
			}
			if (ChildMeshMatIndexList_Marshaler == null)
			{
				ChildMeshMatIndexList_Marshaler = new TArrayReadWriteMarshaler<int>(1, ChildMeshMatIndexList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return ChildMeshMatIndexList_Marshaler.FromNative(IntPtr.Add(base.Address, ChildMeshMatIndexList_Offset));
		}
	}

	[UProperty]
	[Category("SetCurveToMeshConfig")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:BothChildActor")]
	public bool BothChildActor
	{
		get
		{
			CheckDestroyed();
			if (!BothChildActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:BothChildActor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BothChildActor_Offset), 0, BothChildActor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BothChildActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:BothChildActor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BothChildActor_Offset), 0, BothChildActor_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "BothChildActor")]
	[Category("SetCurveToMeshConfig")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:ChildActorMeshMatIndexList")]
	public TArrayReadWrite<int> ChildActorMeshMatIndexList
	{
		get
		{
			CheckDestroyed();
			if (!ChildActorMeshMatIndexList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:ChildActorMeshMatIndexList");
				return null;
			}
			if (ChildActorMeshMatIndexList_Marshaler == null)
			{
				ChildActorMeshMatIndexList_Marshaler = new TArrayReadWriteMarshaler<int>(1, ChildActorMeshMatIndexList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return ChildActorMeshMatIndexList_Marshaler.FromNative(IntPtr.Add(base.Address, ChildActorMeshMatIndexList_Offset));
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Hair")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:BothHair")]
	public bool BothHair
	{
		get
		{
			CheckDestroyed();
			if (!BothHair_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:BothHair");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BothHair_Offset), 0, BothHair_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BothHair_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:BothHair");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BothHair_Offset), 0, BothHair_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "BothHair")]
	[Category("Hair")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:HairType")]
	public EGSHairType HairType
	{
		get
		{
			CheckDestroyed();
			if (!HairType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:HairType");
				return EGSHairType.TressFX;
			}
			return EnumMarshaler<EGSHairType>.FromNative(IntPtr.Add(base.Address, HairType_Offset), 0, HairType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HairType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:HairType");
			}
			else
			{
				EnumMarshaler<EGSHairType>.ToNative(IntPtr.Add(base.Address, HairType_Offset), 0, HairType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Hair")]
	[UMeta(MDProp.EditCondition, "BothHair")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:HairCompTagList")]
	public TArrayReadWrite<FName> HairCompTagList
	{
		get
		{
			CheckDestroyed();
			if (!HairCompTagList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:HairCompTagList");
				return null;
			}
			if (HairCompTagList_Marshaler == null)
			{
				HairCompTagList_Marshaler = new TArrayReadWriteMarshaler<FName>(1, HairCompTagList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return HairCompTagList_Marshaler.FromNative(IntPtr.Add(base.Address, HairCompTagList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Hair")]
	[UMeta(MDProp.EditCondition, "BothHair")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:HairFloatCurveParamList")]
	public TArrayReadWrite<FGSFloatCurveToParam> HairFloatCurveParamList
	{
		get
		{
			CheckDestroyed();
			if (!HairFloatCurveParamList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:HairFloatCurveParamList");
				return null;
			}
			if (HairFloatCurveParamList_Marshaler == null)
			{
				HairFloatCurveParamList_Marshaler = new TArrayReadWriteMarshaler<FGSFloatCurveToParam>(1, HairFloatCurveParamList_PropertyAddress, CachedMarshalingDelegates<FGSFloatCurveToParam, FGSFloatCurveToParam>.FromNative, CachedMarshalingDelegates<FGSFloatCurveToParam, FGSFloatCurveToParam>.ToNative);
			}
			return HairFloatCurveParamList_Marshaler.FromNative(IntPtr.Add(base.Address, HairFloatCurveParamList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("Other")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:NeedRecovery")]
	public bool NeedRecovery
	{
		get
		{
			CheckDestroyed();
			if (!NeedRecovery_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:NeedRecovery");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedRecovery_Offset), 0, NeedRecovery_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedRecovery_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:NeedRecovery");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedRecovery_Offset), 0, NeedRecovery_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Other")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:bFitRealTime")]
	public bool bFitRealTime
	{
		get
		{
			CheckDestroyed();
			if (!bFitRealTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:bFitRealTime");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFitRealTime_Offset), 0, bFitRealTime_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFitRealTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig:bFitRealTime");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFitRealTime_Offset), 0, bFitRealTime_PropertyAddress.Address, value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_BuffSetCurveValueToMeshConfig");
		NativeReflection.GetPropertyRef(ref FloatCurveParamList_PropertyAddress, unrealStruct, "FloatCurveParamList");
		FloatCurveParamList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FloatCurveParamList");
		FloatCurveParamList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FloatCurveParamList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref LinearColorCurveParamList_PropertyAddress, unrealStruct, "LinearColorCurveParamList");
		LinearColorCurveParamList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LinearColorCurveParamList");
		LinearColorCurveParamList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LinearColorCurveParamList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref NotApplyToChrMesh_PropertyAddress, unrealStruct, "NotApplyToChrMesh");
		NotApplyToChrMesh_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NotApplyToChrMesh");
		NotApplyToChrMesh_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NotApplyToChrMesh", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref MatIndexList_PropertyAddress, unrealStruct, "MatIndexList");
		MatIndexList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MatIndexList");
		MatIndexList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MatIndexList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BothWeapons_PropertyAddress, unrealStruct, "BothWeapons");
		BothWeapons_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BothWeapons");
		BothWeapons_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BothWeapons", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref WeaponIndexList_PropertyAddress, unrealStruct, "WeaponIndexList");
		WeaponIndexList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WeaponIndexList");
		WeaponIndexList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WeaponIndexList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref WeaponMatIndexList_PropertyAddress, unrealStruct, "WeaponMatIndexList");
		WeaponMatIndexList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WeaponMatIndexList");
		WeaponMatIndexList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WeaponMatIndexList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BothChildMeshes_PropertyAddress, unrealStruct, "BothChildMeshes");
		BothChildMeshes_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BothChildMeshes");
		BothChildMeshes_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BothChildMeshes", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ChildMeshTagList_PropertyAddress, unrealStruct, "ChildMeshTagList");
		ChildMeshTagList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ChildMeshTagList");
		ChildMeshTagList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ChildMeshTagList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ChildMeshMatIndexList_PropertyAddress, unrealStruct, "ChildMeshMatIndexList");
		ChildMeshMatIndexList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ChildMeshMatIndexList");
		ChildMeshMatIndexList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ChildMeshMatIndexList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BothChildActor_PropertyAddress, unrealStruct, "BothChildActor");
		BothChildActor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BothChildActor");
		BothChildActor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BothChildActor", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ChildActorMeshMatIndexList_PropertyAddress, unrealStruct, "ChildActorMeshMatIndexList");
		ChildActorMeshMatIndexList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ChildActorMeshMatIndexList");
		ChildActorMeshMatIndexList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ChildActorMeshMatIndexList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BothHair_PropertyAddress, unrealStruct, "BothHair");
		BothHair_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BothHair");
		BothHair_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BothHair", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref HairType_PropertyAddress, unrealStruct, "HairType");
		HairType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HairType");
		HairType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HairType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref HairCompTagList_PropertyAddress, unrealStruct, "HairCompTagList");
		HairCompTagList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HairCompTagList");
		HairCompTagList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HairCompTagList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref HairFloatCurveParamList_PropertyAddress, unrealStruct, "HairFloatCurveParamList");
		HairFloatCurveParamList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HairFloatCurveParamList");
		HairFloatCurveParamList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HairFloatCurveParamList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref NeedRecovery_PropertyAddress, unrealStruct, "NeedRecovery");
		NeedRecovery_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NeedRecovery");
		NeedRecovery_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NeedRecovery", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bFitRealTime_PropertyAddress, unrealStruct, "bFitRealTime");
		bFitRealTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bFitRealTime");
		bFitRealTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bFitRealTime", Classes.FBoolProperty);
	}

	static BGWDataAsset_BuffSetCurveValueToMeshConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_BuffSetCurveValueToMeshConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_BuffSetCurveValueToMeshConfig));
	}
}
