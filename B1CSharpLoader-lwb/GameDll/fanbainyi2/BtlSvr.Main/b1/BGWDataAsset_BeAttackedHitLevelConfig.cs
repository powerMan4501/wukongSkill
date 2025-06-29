using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig")]
public class BGWDataAsset_BeAttackedHitLevelConfig : UBGWDataAsset
{
	private static bool StiffLevelInfoList_IsValid;

	private static int StiffLevelInfoList_Offset;

	private static FFieldAddress StiffLevelInfoList_PropertyAddress;

	private TArrayReadWriteMarshaler<FStiffLevelInfo> StiffLevelInfoList_Marshaler;

	private static bool FlyHitWithoutRMValue_IsValid;

	private static int FlyHitWithoutRMValue_Offset;

	private static bool NoFeelingDeadValue_IsValid;

	private static int NoFeelingDeadValue_Offset;

	private static bool LightDeadValue_IsValid;

	private static int LightDeadValue_Offset;

	private static bool HeavyDeadValue_IsValid;

	private static int HeavyDeadValue_Offset;

	private static bool StrikeFlyDeadValue_IsValid;

	private static int StrikeFlyDeadValue_Offset;

	private static bool NoFeelingRoarValue_IsValid;

	private static int NoFeelingRoarValue_Offset;

	private static bool LightRoarValue_IsValid;

	private static int LightRoarValue_Offset;

	private static bool MediumRoarValue_IsValid;

	private static int MediumRoarValue_Offset;

	private static bool HeavyRoarValue_IsValid;

	private static int HeavyRoarValue_Offset;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[Tooltip("抽象划分")]
	[DisplayName("受击挡位")]
	[Category("NormalHitLevel")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:StiffLevelInfoList")]
	public TArrayReadWrite<FStiffLevelInfo> StiffLevelInfoList
	{
		get
		{
			CheckDestroyed();
			if (!StiffLevelInfoList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:StiffLevelInfoList");
				return null;
			}
			if (StiffLevelInfoList_Marshaler == null)
			{
				StiffLevelInfoList_Marshaler = new TArrayReadWriteMarshaler<FStiffLevelInfo>(1, StiffLevelInfoList_PropertyAddress, CachedMarshalingDelegates<FStiffLevelInfo, FStiffLevelInfo>.FromNative, CachedMarshalingDelegates<FStiffLevelInfo, FStiffLevelInfo>.ToNative);
			}
			return StiffLevelInfoList_Marshaler.FromNative(IntPtr.Add(base.Address, StiffLevelInfoList_Offset));
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("HitFlyLevel")]
	[DisplayName("空中受击不带位移")]
	[Tooltip("空中连击不带位移")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:FlyHitWithoutRMValue")]
	public float FlyHitWithoutRMValue
	{
		get
		{
			CheckDestroyed();
			if (!FlyHitWithoutRMValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:FlyHitWithoutRMValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FlyHitWithoutRMValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FlyHitWithoutRMValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:FlyHitWithoutRMValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FlyHitWithoutRMValue_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("HitDeadLevel")]
	[DisplayName("原地死亡")]
	[Tooltip("原地死亡")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:NoFeelingDeadValue")]
	public float NoFeelingDeadValue
	{
		get
		{
			CheckDestroyed();
			if (!NoFeelingDeadValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:NoFeelingDeadValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NoFeelingDeadValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NoFeelingDeadValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:NoFeelingDeadValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NoFeelingDeadValue_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Tooltip("轻受击死亡")]
	[DisplayName("轻击死亡")]
	[Category("HitDeadLevel")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:LightDeadValue")]
	public float LightDeadValue
	{
		get
		{
			CheckDestroyed();
			if (!LightDeadValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:LightDeadValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LightDeadValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightDeadValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:LightDeadValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LightDeadValue_Offset), value);
			}
		}
	}

	[Tooltip("重受击死亡")]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("HitDeadLevel")]
	[DisplayName("重击死亡")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:HeavyDeadValue")]
	public float HeavyDeadValue
	{
		get
		{
			CheckDestroyed();
			if (!HeavyDeadValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:HeavyDeadValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HeavyDeadValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeavyDeadValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:HeavyDeadValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HeavyDeadValue_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("HitDeadLevel")]
	[DisplayName("击飞死亡")]
	[Tooltip("击飞死亡")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:StrikeFlyDeadValue")]
	public float StrikeFlyDeadValue
	{
		get
		{
			CheckDestroyed();
			if (!StrikeFlyDeadValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:StrikeFlyDeadValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StrikeFlyDeadValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StrikeFlyDeadValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:StrikeFlyDeadValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StrikeFlyDeadValue_Offset), value);
			}
		}
	}

	[Category("RoarLevel")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[Tooltip("无吼叫硬直")]
	[DisplayName("无吼叫硬直")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:NoFeelingRoarValue")]
	public float NoFeelingRoarValue
	{
		get
		{
			CheckDestroyed();
			if (!NoFeelingRoarValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:NoFeelingRoarValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NoFeelingRoarValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NoFeelingRoarValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:NoFeelingRoarValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NoFeelingRoarValue_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("RoarLevel")]
	[DisplayName("轻吼叫硬直")]
	[Tooltip("轻吼叫硬直")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:LightRoarValue")]
	public float LightRoarValue
	{
		get
		{
			CheckDestroyed();
			if (!LightRoarValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:LightRoarValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LightRoarValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightRoarValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:LightRoarValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LightRoarValue_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("RoarLevel")]
	[DisplayName("中吼叫硬直")]
	[Tooltip("中吼叫硬直")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:MediumRoarValue")]
	public float MediumRoarValue
	{
		get
		{
			CheckDestroyed();
			if (!MediumRoarValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:MediumRoarValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MediumRoarValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MediumRoarValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:MediumRoarValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MediumRoarValue_Offset), value);
			}
		}
	}

	[Tooltip("重吼叫硬直")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("RoarLevel")]
	[DisplayName("重吼叫硬直")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:HeavyRoarValue")]
	public float HeavyRoarValue
	{
		get
		{
			CheckDestroyed();
			if (!HeavyRoarValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:HeavyRoarValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HeavyRoarValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeavyRoarValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig:HeavyRoarValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HeavyRoarValue_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_BeAttackedHitLevelConfig");
		NativeReflection.GetPropertyRef(ref StiffLevelInfoList_PropertyAddress, unrealStruct, "StiffLevelInfoList");
		StiffLevelInfoList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StiffLevelInfoList");
		StiffLevelInfoList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StiffLevelInfoList", Classes.FArrayProperty);
		FlyHitWithoutRMValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FlyHitWithoutRMValue");
		FlyHitWithoutRMValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FlyHitWithoutRMValue", Classes.FFloatProperty);
		NoFeelingDeadValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NoFeelingDeadValue");
		NoFeelingDeadValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NoFeelingDeadValue", Classes.FFloatProperty);
		LightDeadValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LightDeadValue");
		LightDeadValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LightDeadValue", Classes.FFloatProperty);
		HeavyDeadValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HeavyDeadValue");
		HeavyDeadValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HeavyDeadValue", Classes.FFloatProperty);
		StrikeFlyDeadValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StrikeFlyDeadValue");
		StrikeFlyDeadValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StrikeFlyDeadValue", Classes.FFloatProperty);
		NoFeelingRoarValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NoFeelingRoarValue");
		NoFeelingRoarValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NoFeelingRoarValue", Classes.FFloatProperty);
		LightRoarValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LightRoarValue");
		LightRoarValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LightRoarValue", Classes.FFloatProperty);
		MediumRoarValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MediumRoarValue");
		MediumRoarValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MediumRoarValue", Classes.FFloatProperty);
		HeavyRoarValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HeavyRoarValue");
		HeavyRoarValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HeavyRoarValue", Classes.FFloatProperty);
	}

	static BGWDataAsset_BeAttackedHitLevelConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_BeAttackedHitLevelConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_BeAttackedHitLevelConfig));
	}
}
