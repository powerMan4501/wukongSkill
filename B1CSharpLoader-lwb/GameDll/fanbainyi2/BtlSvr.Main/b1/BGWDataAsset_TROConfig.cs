using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_TROConfig")]
public class BGWDataAsset_TROConfig : UBGWDataAsset
{
	private static bool BaseVisibleDistanceFactorThesholds_IsValid;

	private static int BaseVisibleDistanceFactorThesholds_Offset;

	private static FFieldAddress BaseVisibleDistanceFactorThesholds_PropertyAddress;

	private TArrayReadWriteMarshaler<float> BaseVisibleDistanceFactorThesholds_Marshaler;

	private static bool BaseNonRenderedUpdateRate_IsValid;

	private static int BaseNonRenderedUpdateRate_Offset;

	private static bool CppTickCullDistance_IsValid;

	private static int CppTickCullDistance_Offset;

	private static bool CharacterMovementNavWalkingDistance_IsValid;

	private static int CharacterMovementNavWalkingDistance_Offset;

	private static bool CharacterMovementTickCullDistance_IsValid;

	private static int CharacterMovementTickCullDistance_Offset;

	[Tooltip("更新频率阈值，若数组里分别为0.4，0.2，则当屏占比大于0.4时跳过零帧；大于0.2时跳过一帧；大于0时跳过两帧")]
	[Category("General")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TROConfig:BaseVisibleDistanceFactorThesholds")]
	public TArrayReadWrite<float> BaseVisibleDistanceFactorThesholds
	{
		get
		{
			CheckDestroyed();
			if (!BaseVisibleDistanceFactorThesholds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TROConfig:BaseVisibleDistanceFactorThesholds");
				return null;
			}
			if (BaseVisibleDistanceFactorThesholds_Marshaler == null)
			{
				BaseVisibleDistanceFactorThesholds_Marshaler = new TArrayReadWriteMarshaler<float>(1, BaseVisibleDistanceFactorThesholds_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return BaseVisibleDistanceFactorThesholds_Marshaler.FromNative(IntPtr.Add(base.Address, BaseVisibleDistanceFactorThesholds_Offset));
		}
	}

	[Category("General")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[Tooltip("未被渲染的更新频率，4值意味着tick一帧，跳过三帧")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TROConfig:BaseNonRenderedUpdateRate")]
	public int BaseNonRenderedUpdateRate
	{
		get
		{
			CheckDestroyed();
			if (!BaseNonRenderedUpdateRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TROConfig:BaseNonRenderedUpdateRate");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BaseNonRenderedUpdateRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BaseNonRenderedUpdateRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TROConfig:BaseNonRenderedUpdateRate");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BaseNonRenderedUpdateRate_Offset), value);
			}
		}
	}

	[Category("General")]
	[Tooltip("C++禁用Tick的距离（包括BT tick，SK tick等）")]
	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TROConfig:CppTickCullDistance")]
	public float CppTickCullDistance
	{
		get
		{
			CheckDestroyed();
			if (!CppTickCullDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TROConfig:CppTickCullDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CppTickCullDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CppTickCullDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TROConfig:CppTickCullDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CppTickCullDistance_Offset), value);
			}
		}
	}

	[Tooltip("C++ CharacterMovement切换MovementMode.NavWalking距离")]
	[Category("General")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TROConfig:CharacterMovementNavWalkingDistance")]
	public float CharacterMovementNavWalkingDistance
	{
		get
		{
			CheckDestroyed();
			if (!CharacterMovementNavWalkingDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TROConfig:CharacterMovementNavWalkingDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CharacterMovementNavWalkingDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CharacterMovementNavWalkingDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TROConfig:CharacterMovementNavWalkingDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CharacterMovementNavWalkingDistance_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[Tooltip("C++ CharacterMovement禁用Tick的距离")]
	[Category("General")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TROConfig:CharacterMovementTickCullDistance")]
	public float CharacterMovementTickCullDistance
	{
		get
		{
			CheckDestroyed();
			if (!CharacterMovementTickCullDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TROConfig:CharacterMovementTickCullDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CharacterMovementTickCullDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CharacterMovementTickCullDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TROConfig:CharacterMovementTickCullDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CharacterMovementTickCullDistance_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_TROConfig");
		NativeReflection.GetPropertyRef(ref BaseVisibleDistanceFactorThesholds_PropertyAddress, unrealStruct, "BaseVisibleDistanceFactorThesholds");
		BaseVisibleDistanceFactorThesholds_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BaseVisibleDistanceFactorThesholds");
		BaseVisibleDistanceFactorThesholds_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BaseVisibleDistanceFactorThesholds", Classes.FArrayProperty);
		BaseNonRenderedUpdateRate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BaseNonRenderedUpdateRate");
		BaseNonRenderedUpdateRate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BaseNonRenderedUpdateRate", Classes.FIntProperty);
		CppTickCullDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CppTickCullDistance");
		CppTickCullDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CppTickCullDistance", Classes.FFloatProperty);
		CharacterMovementNavWalkingDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CharacterMovementNavWalkingDistance");
		CharacterMovementNavWalkingDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CharacterMovementNavWalkingDistance", Classes.FFloatProperty);
		CharacterMovementTickCullDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CharacterMovementTickCullDistance");
		CharacterMovementTickCullDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CharacterMovementTickCullDistance", Classes.FFloatProperty);
	}

	static BGWDataAsset_TROConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_TROConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_TROConfig));
	}
}
