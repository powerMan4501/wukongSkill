using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGWDataAsset_BeImmobilizedConfig")]
public class BGWDataAsset_BeImmobilizedConfig : UBGWDataAsset
{
	private static bool DefaultImmobilizeTimeFactorForBeAttacked_IsValid;

	private static int DefaultImmobilizeTimeFactorForBeAttacked_Offset;

	private static bool ImmobilizeTimeFactorForBeAttacked_IsValid;

	private static int ImmobilizeTimeFactorForBeAttacked_Offset;

	private static FFieldAddress ImmobilizeTimeFactorForBeAttacked_PropertyAddress;

	private TMapReadWriteMarshaler<int, float> ImmobilizeTimeFactorForBeAttacked_Marshaler;

	private static bool SpecialImmobilizeTimeFactorForBeAttacked_IsValid;

	private static int SpecialImmobilizeTimeFactorForBeAttacked_Offset;

	private static FFieldAddress SpecialImmobilizeTimeFactorForBeAttacked_PropertyAddress;

	private TMapReadWriteMarshaler<int, float> SpecialImmobilizeTimeFactorForBeAttacked_Marshaler;

	private static bool ImmobilizeTimeFactorForBreakPart2Weak_IsValid;

	private static int ImmobilizeTimeFactorForBreakPart2Weak_Offset;

	private static bool SpecialImmobilizeTimeFactorForBreakPart2Weak_IsValid;

	private static int SpecialImmobilizeTimeFactorForBreakPart2Weak_Offset;

	private static bool ImmobilizeTimeFactorForBlindStiff_IsValid;

	private static int ImmobilizeTimeFactorForBlindStiff_Offset;

	private static bool SpecialImmobilizeTimeFactorForBlindStiff_IsValid;

	private static int SpecialImmobilizeTimeFactorForBlindStiff_Offset;

	[BlueprintReadWrite]
	[DisplayName("默认受击影响定身时间乘数")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BeImmobilizedConfig:DefaultImmobilizeTimeFactorForBeAttacked")]
	public float DefaultImmobilizeTimeFactorForBeAttacked
	{
		get
		{
			CheckDestroyed();
			if (!DefaultImmobilizeTimeFactorForBeAttacked_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeImmobilizedConfig:DefaultImmobilizeTimeFactorForBeAttacked");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DefaultImmobilizeTimeFactorForBeAttacked_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultImmobilizeTimeFactorForBeAttacked_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeImmobilizedConfig:DefaultImmobilizeTimeFactorForBeAttacked");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DefaultImmobilizeTimeFactorForBeAttacked_Offset), value);
			}
		}
	}

	[DisplayName("挡位受击影响定身时间乘数")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BeImmobilizedConfig:ImmobilizeTimeFactorForBeAttacked")]
	public TMapReadWrite<int, float> ImmobilizeTimeFactorForBeAttacked
	{
		get
		{
			CheckDestroyed();
			if (!ImmobilizeTimeFactorForBeAttacked_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeImmobilizedConfig:ImmobilizeTimeFactorForBeAttacked");
				return null;
			}
			if (ImmobilizeTimeFactorForBeAttacked_Marshaler == null)
			{
				ImmobilizeTimeFactorForBeAttacked_Marshaler = new TMapReadWriteMarshaler<int, float>(1, ImmobilizeTimeFactorForBeAttacked_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return ImmobilizeTimeFactorForBeAttacked_Marshaler.FromNative(IntPtr.Add(base.Address, ImmobilizeTimeFactorForBeAttacked_Offset));
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("大圣天赋挡位受击影响定身时间乘数")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BeImmobilizedConfig:SpecialImmobilizeTimeFactorForBeAttacked")]
	public TMapReadWrite<int, float> SpecialImmobilizeTimeFactorForBeAttacked
	{
		get
		{
			CheckDestroyed();
			if (!SpecialImmobilizeTimeFactorForBeAttacked_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeImmobilizedConfig:SpecialImmobilizeTimeFactorForBeAttacked");
				return null;
			}
			if (SpecialImmobilizeTimeFactorForBeAttacked_Marshaler == null)
			{
				SpecialImmobilizeTimeFactorForBeAttacked_Marshaler = new TMapReadWriteMarshaler<int, float>(1, SpecialImmobilizeTimeFactorForBeAttacked_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return SpecialImmobilizeTimeFactorForBeAttacked_Marshaler.FromNative(IntPtr.Add(base.Address, SpecialImmobilizeTimeFactorForBeAttacked_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("BreakPart2Weak影响定身时间乘数")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BeImmobilizedConfig:ImmobilizeTimeFactorForBreakPart2Weak")]
	public float ImmobilizeTimeFactorForBreakPart2Weak
	{
		get
		{
			CheckDestroyed();
			if (!ImmobilizeTimeFactorForBreakPart2Weak_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeImmobilizedConfig:ImmobilizeTimeFactorForBreakPart2Weak");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ImmobilizeTimeFactorForBreakPart2Weak_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImmobilizeTimeFactorForBreakPart2Weak_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeImmobilizedConfig:ImmobilizeTimeFactorForBreakPart2Weak");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ImmobilizeTimeFactorForBreakPart2Weak_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("大圣天赋BreakPart2Weak影响定身时间乘数")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BeImmobilizedConfig:SpecialImmobilizeTimeFactorForBreakPart2Weak")]
	public float SpecialImmobilizeTimeFactorForBreakPart2Weak
	{
		get
		{
			CheckDestroyed();
			if (!SpecialImmobilizeTimeFactorForBreakPart2Weak_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeImmobilizedConfig:SpecialImmobilizeTimeFactorForBreakPart2Weak");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpecialImmobilizeTimeFactorForBreakPart2Weak_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpecialImmobilizeTimeFactorForBreakPart2Weak_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeImmobilizedConfig:SpecialImmobilizeTimeFactorForBreakPart2Weak");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpecialImmobilizeTimeFactorForBreakPart2Weak_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("BlindStiff影响定身时间乘数")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BeImmobilizedConfig:ImmobilizeTimeFactorForBlindStiff")]
	public float ImmobilizeTimeFactorForBlindStiff
	{
		get
		{
			CheckDestroyed();
			if (!ImmobilizeTimeFactorForBlindStiff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeImmobilizedConfig:ImmobilizeTimeFactorForBlindStiff");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ImmobilizeTimeFactorForBlindStiff_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImmobilizeTimeFactorForBlindStiff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeImmobilizedConfig:ImmobilizeTimeFactorForBlindStiff");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ImmobilizeTimeFactorForBlindStiff_Offset), value);
			}
		}
	}

	[DisplayName("大圣天赋BlindStiff影响定身时间乘数")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BeImmobilizedConfig:SpecialImmobilizeTimeFactorForBlindStiff")]
	public float SpecialImmobilizeTimeFactorForBlindStiff
	{
		get
		{
			CheckDestroyed();
			if (!SpecialImmobilizeTimeFactorForBlindStiff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeImmobilizedConfig:SpecialImmobilizeTimeFactorForBlindStiff");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpecialImmobilizeTimeFactorForBlindStiff_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpecialImmobilizeTimeFactorForBlindStiff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BeImmobilizedConfig:SpecialImmobilizeTimeFactorForBlindStiff");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpecialImmobilizeTimeFactorForBlindStiff_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_BeImmobilizedConfig");
		DefaultImmobilizeTimeFactorForBeAttacked_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DefaultImmobilizeTimeFactorForBeAttacked");
		DefaultImmobilizeTimeFactorForBeAttacked_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DefaultImmobilizeTimeFactorForBeAttacked", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref ImmobilizeTimeFactorForBeAttacked_PropertyAddress, unrealStruct, "ImmobilizeTimeFactorForBeAttacked");
		ImmobilizeTimeFactorForBeAttacked_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ImmobilizeTimeFactorForBeAttacked");
		ImmobilizeTimeFactorForBeAttacked_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ImmobilizeTimeFactorForBeAttacked", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref SpecialImmobilizeTimeFactorForBeAttacked_PropertyAddress, unrealStruct, "SpecialImmobilizeTimeFactorForBeAttacked");
		SpecialImmobilizeTimeFactorForBeAttacked_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpecialImmobilizeTimeFactorForBeAttacked");
		SpecialImmobilizeTimeFactorForBeAttacked_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpecialImmobilizeTimeFactorForBeAttacked", Classes.FMapProperty);
		ImmobilizeTimeFactorForBreakPart2Weak_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ImmobilizeTimeFactorForBreakPart2Weak");
		ImmobilizeTimeFactorForBreakPart2Weak_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ImmobilizeTimeFactorForBreakPart2Weak", Classes.FFloatProperty);
		SpecialImmobilizeTimeFactorForBreakPart2Weak_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpecialImmobilizeTimeFactorForBreakPart2Weak");
		SpecialImmobilizeTimeFactorForBreakPart2Weak_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpecialImmobilizeTimeFactorForBreakPart2Weak", Classes.FFloatProperty);
		ImmobilizeTimeFactorForBlindStiff_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ImmobilizeTimeFactorForBlindStiff");
		ImmobilizeTimeFactorForBlindStiff_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ImmobilizeTimeFactorForBlindStiff", Classes.FFloatProperty);
		SpecialImmobilizeTimeFactorForBlindStiff_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpecialImmobilizeTimeFactorForBlindStiff");
		SpecialImmobilizeTimeFactorForBlindStiff_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpecialImmobilizeTimeFactorForBlindStiff", Classes.FFloatProperty);
	}

	static BGWDataAsset_BeImmobilizedConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_BeImmobilizedConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_BeImmobilizedConfig));
	}
}
