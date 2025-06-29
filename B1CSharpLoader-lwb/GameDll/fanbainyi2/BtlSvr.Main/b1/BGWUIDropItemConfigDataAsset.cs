using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWUIDropItemConfigDataAsset")]
public class BGWUIDropItemConfigDataAsset : UBGWDataAsset
{
	private static bool DropItemWidgetCls_IsValid;

	private static int DropItemWidgetCls_Offset;

	private static bool DropItemFlyTime_IsValid;

	private static int DropItemFlyTime_Offset;

	private static bool DropItemDelayDestroyTime_IsValid;

	private static int DropItemDelayDestroyTime_Offset;

	private static bool DropItemFlyCurveType_IsValid;

	private static int DropItemFlyCurveType_Offset;

	private static FFieldAddress DropItemFlyCurveType_PropertyAddress;

	private static bool AmplitudeMin_IsValid;

	private static int AmplitudeMin_Offset;

	private static bool AmplitudeMax_IsValid;

	private static int AmplitudeMax_Offset;

	private static bool EffectBoomLengthMin_IsValid;

	private static int EffectBoomLengthMin_Offset;

	private static bool EffectBoomLengthMax_IsValid;

	private static int EffectBoomLengthMax_Offset;

	private static bool DistParam_IsValid;

	private static int DistParam_Offset;

	private static bool DegParam_IsValid;

	private static int DegParam_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("掉落物体UI")]
	[USharpPath("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:DropItemWidgetCls")]
	public TSubclassOf<UUserWidget> DropItemWidgetCls
	{
		get
		{
			CheckDestroyed();
			if (!DropItemWidgetCls_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:DropItemWidgetCls");
				return default(TSubclassOf<UUserWidget>);
			}
			return TSubclassOfMarshaler<UUserWidget>.FromNative(IntPtr.Add(base.Address, DropItemWidgetCls_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropItemWidgetCls_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:DropItemWidgetCls");
			}
			else
			{
				TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(base.Address, DropItemWidgetCls_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("掉落物体飞行时间")]
	[USharpPath("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:DropItemFlyTime")]
	public float DropItemFlyTime
	{
		get
		{
			CheckDestroyed();
			if (!DropItemFlyTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:DropItemFlyTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DropItemFlyTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropItemFlyTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:DropItemFlyTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DropItemFlyTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("掉落物体延迟销毁时间")]
	[USharpPath("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:DropItemDelayDestroyTime")]
	public float DropItemDelayDestroyTime
	{
		get
		{
			CheckDestroyed();
			if (!DropItemDelayDestroyTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:DropItemDelayDestroyTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DropItemDelayDestroyTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropItemDelayDestroyTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:DropItemDelayDestroyTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DropItemDelayDestroyTime_Offset), value);
			}
		}
	}

	[DisplayName("凋落物体曲线类型")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:DropItemFlyCurveType")]
	public EDropItemFlyCurveType DropItemFlyCurveType
	{
		get
		{
			CheckDestroyed();
			if (!DropItemFlyCurveType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:DropItemFlyCurveType");
				return EDropItemFlyCurveType.FastBezier;
			}
			return EnumMarshaler<EDropItemFlyCurveType>.FromNative(IntPtr.Add(base.Address, DropItemFlyCurveType_Offset), 0, DropItemFlyCurveType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DropItemFlyCurveType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:DropItemFlyCurveType");
			}
			else
			{
				EnumMarshaler<EDropItemFlyCurveType>.ToNative(IntPtr.Add(base.Address, DropItemFlyCurveType_Offset), 0, DropItemFlyCurveType_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("飞行振幅最小值")]
	[Category("CurveTranslation")]
	[UMeta(MDProp.EditCondition, "DropItemFlyCurveType == DropItemFlyCurveType::CurveTranslation")]
	[USharpPath("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:AmplitudeMin")]
	public float AmplitudeMin
	{
		get
		{
			CheckDestroyed();
			if (!AmplitudeMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:AmplitudeMin");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AmplitudeMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AmplitudeMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:AmplitudeMin");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AmplitudeMin_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("飞行振幅最大值")]
	[Category("CurveTranslation")]
	[UMeta(MDProp.EditCondition, "DropItemFlyCurveType == DropItemFlyCurveType::CurveTranslation")]
	[USharpPath("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:AmplitudeMax")]
	public float AmplitudeMax
	{
		get
		{
			CheckDestroyed();
			if (!AmplitudeMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:AmplitudeMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AmplitudeMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AmplitudeMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:AmplitudeMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AmplitudeMax_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("CurveTranslation")]
	[DisplayName("特效Boom长度最小值")]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "DropItemFlyCurveType == DropItemFlyCurveType::CurveTranslation")]
	[USharpPath("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:EffectBoomLengthMin")]
	public float EffectBoomLengthMin
	{
		get
		{
			CheckDestroyed();
			if (!EffectBoomLengthMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:EffectBoomLengthMin");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EffectBoomLengthMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EffectBoomLengthMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:EffectBoomLengthMin");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EffectBoomLengthMin_Offset), value);
			}
		}
	}

	[DisplayName("特效Boom长度最大值")]
	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "DropItemFlyCurveType == DropItemFlyCurveType::CurveTranslation")]
	[Category("CurveTranslation")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:EffectBoomLengthMax")]
	public float EffectBoomLengthMax
	{
		get
		{
			CheckDestroyed();
			if (!EffectBoomLengthMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:EffectBoomLengthMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EffectBoomLengthMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EffectBoomLengthMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:EffectBoomLengthMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EffectBoomLengthMax_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("控制点选取距离")]
	[Category("FastBezier")]
	[UMeta(MDProp.EditCondition, "DropItemFlyCurveType == DropItemFlyCurveType::FastBezier")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:DistParam")]
	public float DistParam
	{
		get
		{
			CheckDestroyed();
			if (!DistParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:DistParam");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DistParam_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:DistParam");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DistParam_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("控制点选取角度")]
	[Category("FastBezier")]
	[UMeta(MDProp.EditCondition, "DropItemFlyCurveType == DropItemFlyCurveType::FastBezier")]
	[USharpPath("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:DegParam")]
	public float DegParam
	{
		get
		{
			CheckDestroyed();
			if (!DegParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:DegParam");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DegParam_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DegParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIDropItemConfigDataAsset:DegParam");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DegParam_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWUIDropItemConfigDataAsset");
		DropItemWidgetCls_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropItemWidgetCls");
		DropItemWidgetCls_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropItemWidgetCls", Classes.FClassProperty);
		DropItemFlyTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropItemFlyTime");
		DropItemFlyTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropItemFlyTime", Classes.FFloatProperty);
		DropItemDelayDestroyTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropItemDelayDestroyTime");
		DropItemDelayDestroyTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropItemDelayDestroyTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref DropItemFlyCurveType_PropertyAddress, unrealStruct, "DropItemFlyCurveType");
		DropItemFlyCurveType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropItemFlyCurveType");
		DropItemFlyCurveType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropItemFlyCurveType", Classes.FEnumProperty);
		AmplitudeMin_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AmplitudeMin");
		AmplitudeMin_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AmplitudeMin", Classes.FFloatProperty);
		AmplitudeMax_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AmplitudeMax");
		AmplitudeMax_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AmplitudeMax", Classes.FFloatProperty);
		EffectBoomLengthMin_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EffectBoomLengthMin");
		EffectBoomLengthMin_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EffectBoomLengthMin", Classes.FFloatProperty);
		EffectBoomLengthMax_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EffectBoomLengthMax");
		EffectBoomLengthMax_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EffectBoomLengthMax", Classes.FFloatProperty);
		DistParam_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DistParam");
		DistParam_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DistParam", Classes.FFloatProperty);
		DegParam_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DegParam");
		DegParam_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DegParam", Classes.FFloatProperty);
	}

	static BGWUIDropItemConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWUIDropItemConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWUIDropItemConfigDataAsset));
	}
}
