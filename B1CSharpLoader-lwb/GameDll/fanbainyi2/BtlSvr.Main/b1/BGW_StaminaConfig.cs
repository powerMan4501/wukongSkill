using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_StaminaConfig")]
public class BGW_StaminaConfig : UBGWDataAsset
{
	private static bool StaminaMI_IsValid;

	private static int StaminaMI_Offset;

	private static bool StaminaMPC_IsValid;

	private static int StaminaMPC_Offset;

	private static bool StaminaParamList_IsValid;

	private static int StaminaParamList_Offset;

	private static FFieldAddress StaminaParamList_PropertyAddress;

	private TArrayReadWriteMarshaler<StaminaTextureInfo> StaminaParamList_Marshaler;

	private static bool StaminaRecoverCurve1_IsValid;

	private static int StaminaRecoverCurve1_Offset;

	private static bool StaminaRecoverCurveLength1_IsValid;

	private static int StaminaRecoverCurveLength1_Offset;

	private static bool StaminaRecoverCurve2_IsValid;

	private static int StaminaRecoverCurve2_Offset;

	private static bool StaminaRecoverCurveLength2_IsValid;

	private static int StaminaRecoverCurveLength2_Offset;

	private static bool StaminaCostCurve_IsValid;

	private static int StaminaCostCurve_Offset;

	private static bool StaminaCostCurveLength_IsValid;

	private static int StaminaCostCurveLength_Offset;

	private static bool StaminaWarnCurve_IsValid;

	private static int StaminaWarnCurve_Offset;

	private static bool StaminaWarnCurveLength_IsValid;

	private static int StaminaWarnCurveLength_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("体力材质")]
	[USharpPath("/Script/b1-Managed.BGW_StaminaConfig:StaminaMI")]
	public UMaterialInstance StaminaMI
	{
		get
		{
			CheckDestroyed();
			if (!StaminaMI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_StaminaConfig:StaminaMI");
				return null;
			}
			return UObjectMarshaler<UMaterialInstance>.FromNative(IntPtr.Add(base.Address, StaminaMI_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaminaMI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_StaminaConfig:StaminaMI");
			}
			else
			{
				UObjectMarshaler<UMaterialInstance>.ToNative(IntPtr.Add(base.Address, StaminaMI_Offset), value);
			}
		}
	}

	[Tooltip("体力材质参数集")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGW_StaminaConfig:StaminaMPC")]
	public UMaterialParameterCollection StaminaMPC
	{
		get
		{
			CheckDestroyed();
			if (!StaminaMPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_StaminaConfig:StaminaMPC");
				return null;
			}
			return UObjectMarshaler<UMaterialParameterCollection>.FromNative(IntPtr.Add(base.Address, StaminaMPC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaminaMPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_StaminaConfig:StaminaMPC");
			}
			else
			{
				UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(base.Address, StaminaMPC_Offset), value);
			}
		}
	}

	[Tooltip("体力点参数列表")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_StaminaConfig:StaminaParamList")]
	public TArrayReadWrite<StaminaTextureInfo> StaminaParamList
	{
		get
		{
			CheckDestroyed();
			if (!StaminaParamList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_StaminaConfig:StaminaParamList");
				return null;
			}
			if (StaminaParamList_Marshaler == null)
			{
				StaminaParamList_Marshaler = new TArrayReadWriteMarshaler<StaminaTextureInfo>(1, StaminaParamList_PropertyAddress, CachedMarshalingDelegates<StaminaTextureInfo, StaminaTextureInfo>.FromNative, CachedMarshalingDelegates<StaminaTextureInfo, StaminaTextureInfo>.ToNative);
			}
			return StaminaParamList_Marshaler.FromNative(IntPtr.Add(base.Address, StaminaParamList_Offset));
		}
	}

	[Tooltip("体力回复效果曲线1")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_StaminaConfig:StaminaRecoverCurve1")]
	public UCurveFloat StaminaRecoverCurve1
	{
		get
		{
			CheckDestroyed();
			if (!StaminaRecoverCurve1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_StaminaConfig:StaminaRecoverCurve1");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, StaminaRecoverCurve1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaminaRecoverCurve1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_StaminaConfig:StaminaRecoverCurve1");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, StaminaRecoverCurve1_Offset), value);
			}
		}
	}

	[Tooltip("体力回复效果曲线长度1")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_StaminaConfig:StaminaRecoverCurveLength1")]
	public float StaminaRecoverCurveLength1
	{
		get
		{
			CheckDestroyed();
			if (!StaminaRecoverCurveLength1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_StaminaConfig:StaminaRecoverCurveLength1");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StaminaRecoverCurveLength1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaminaRecoverCurveLength1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_StaminaConfig:StaminaRecoverCurveLength1");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StaminaRecoverCurveLength1_Offset), value);
			}
		}
	}

	[UProperty]
	[Tooltip("体力回复效果曲线2")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGW_StaminaConfig:StaminaRecoverCurve2")]
	public UCurveFloat StaminaRecoverCurve2
	{
		get
		{
			CheckDestroyed();
			if (!StaminaRecoverCurve2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_StaminaConfig:StaminaRecoverCurve2");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, StaminaRecoverCurve2_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaminaRecoverCurve2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_StaminaConfig:StaminaRecoverCurve2");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, StaminaRecoverCurve2_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("体力回复效果曲线长度2")]
	[USharpPath("/Script/b1-Managed.BGW_StaminaConfig:StaminaRecoverCurveLength2")]
	public float StaminaRecoverCurveLength2
	{
		get
		{
			CheckDestroyed();
			if (!StaminaRecoverCurveLength2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_StaminaConfig:StaminaRecoverCurveLength2");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StaminaRecoverCurveLength2_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaminaRecoverCurveLength2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_StaminaConfig:StaminaRecoverCurveLength2");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StaminaRecoverCurveLength2_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("体力消耗效果曲线")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_StaminaConfig:StaminaCostCurve")]
	public UCurveFloat StaminaCostCurve
	{
		get
		{
			CheckDestroyed();
			if (!StaminaCostCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_StaminaConfig:StaminaCostCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, StaminaCostCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaminaCostCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_StaminaConfig:StaminaCostCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, StaminaCostCurve_Offset), value);
			}
		}
	}

	[Tooltip("体力消耗效果曲线长度")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_StaminaConfig:StaminaCostCurveLength")]
	public float StaminaCostCurveLength
	{
		get
		{
			CheckDestroyed();
			if (!StaminaCostCurveLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_StaminaConfig:StaminaCostCurveLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StaminaCostCurveLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaminaCostCurveLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_StaminaConfig:StaminaCostCurveLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StaminaCostCurveLength_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Tooltip("体力警告效果曲线")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_StaminaConfig:StaminaWarnCurve")]
	public UCurveFloat StaminaWarnCurve
	{
		get
		{
			CheckDestroyed();
			if (!StaminaWarnCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_StaminaConfig:StaminaWarnCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, StaminaWarnCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaminaWarnCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_StaminaConfig:StaminaWarnCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, StaminaWarnCurve_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Tooltip("体力警告效果曲线长度")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_StaminaConfig:StaminaWarnCurveLength")]
	public float StaminaWarnCurveLength
	{
		get
		{
			CheckDestroyed();
			if (!StaminaWarnCurveLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_StaminaConfig:StaminaWarnCurveLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StaminaWarnCurveLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaminaWarnCurveLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_StaminaConfig:StaminaWarnCurveLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StaminaWarnCurveLength_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGW_StaminaConfig");
		StaminaMI_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StaminaMI");
		StaminaMI_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StaminaMI", Classes.FObjectProperty);
		StaminaMPC_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StaminaMPC");
		StaminaMPC_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StaminaMPC", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref StaminaParamList_PropertyAddress, unrealStruct, "StaminaParamList");
		StaminaParamList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StaminaParamList");
		StaminaParamList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StaminaParamList", Classes.FArrayProperty);
		StaminaRecoverCurve1_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StaminaRecoverCurve1");
		StaminaRecoverCurve1_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StaminaRecoverCurve1", Classes.FObjectProperty);
		StaminaRecoverCurveLength1_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StaminaRecoverCurveLength1");
		StaminaRecoverCurveLength1_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StaminaRecoverCurveLength1", Classes.FFloatProperty);
		StaminaRecoverCurve2_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StaminaRecoverCurve2");
		StaminaRecoverCurve2_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StaminaRecoverCurve2", Classes.FObjectProperty);
		StaminaRecoverCurveLength2_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StaminaRecoverCurveLength2");
		StaminaRecoverCurveLength2_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StaminaRecoverCurveLength2", Classes.FFloatProperty);
		StaminaCostCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StaminaCostCurve");
		StaminaCostCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StaminaCostCurve", Classes.FObjectProperty);
		StaminaCostCurveLength_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StaminaCostCurveLength");
		StaminaCostCurveLength_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StaminaCostCurveLength", Classes.FFloatProperty);
		StaminaWarnCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StaminaWarnCurve");
		StaminaWarnCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StaminaWarnCurve", Classes.FObjectProperty);
		StaminaWarnCurveLength_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StaminaWarnCurveLength");
		StaminaWarnCurveLength_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StaminaWarnCurveLength", Classes.FFloatProperty);
	}

	static BGW_StaminaConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_StaminaConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_StaminaConfig));
	}
}
