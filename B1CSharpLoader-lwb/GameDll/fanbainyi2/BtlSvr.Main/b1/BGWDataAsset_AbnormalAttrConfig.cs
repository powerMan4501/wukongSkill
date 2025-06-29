using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_AbnormalAttrConfig")]
public class BGWDataAsset_AbnormalAttrConfig : UBGWDataAsset
{
	private static bool AbnomalAttrConfigInfo_Freeze_IsValid;

	private static int AbnomalAttrConfigInfo_Freeze_Offset;

	private static bool AbnomalAttrConfigInfo_Burn_IsValid;

	private static int AbnomalAttrConfigInfo_Burn_Offset;

	private static bool AbnomalAttrConfigInfo_Poison_IsValid;

	private static int AbnomalAttrConfigInfo_Poison_Offset;

	private static bool AbnomalAttrConfigInfo_Thunder_IsValid;

	private static int AbnomalAttrConfigInfo_Thunder_Offset;

	private static bool AbnomalAttrConfigInfo_Yin_IsValid;

	private static int AbnomalAttrConfigInfo_Yin_Offset;

	private static bool AbnomalAttrConfigInfo_Yang_IsValid;

	private static int AbnomalAttrConfigInfo_Yang_Offset;

	[UProperty]
	[BlueprintReadOnly]
	[DisplayName("冰属性异常相关")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbnormalAttrConfig:AbnomalAttrConfigInfo_Freeze")]
	public FAbnomalAttrConfigInfo AbnomalAttrConfigInfo_Freeze
	{
		get
		{
			CheckDestroyed();
			if (!AbnomalAttrConfigInfo_Freeze_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbnormalAttrConfig:AbnomalAttrConfigInfo_Freeze");
				return default(FAbnomalAttrConfigInfo);
			}
			return BlittableTypeMarshaler<FAbnomalAttrConfigInfo>.FromNative(IntPtr.Add(base.Address, AbnomalAttrConfigInfo_Freeze_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AbnomalAttrConfigInfo_Freeze_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbnormalAttrConfig:AbnomalAttrConfigInfo_Freeze");
			}
			else
			{
				BlittableTypeMarshaler<FAbnomalAttrConfigInfo>.ToNative(IntPtr.Add(base.Address, AbnomalAttrConfigInfo_Freeze_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("火属性异常相关")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbnormalAttrConfig:AbnomalAttrConfigInfo_Burn")]
	public FAbnomalAttrConfigInfo AbnomalAttrConfigInfo_Burn
	{
		get
		{
			CheckDestroyed();
			if (!AbnomalAttrConfigInfo_Burn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbnormalAttrConfig:AbnomalAttrConfigInfo_Burn");
				return default(FAbnomalAttrConfigInfo);
			}
			return BlittableTypeMarshaler<FAbnomalAttrConfigInfo>.FromNative(IntPtr.Add(base.Address, AbnomalAttrConfigInfo_Burn_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AbnomalAttrConfigInfo_Burn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbnormalAttrConfig:AbnomalAttrConfigInfo_Burn");
			}
			else
			{
				BlittableTypeMarshaler<FAbnomalAttrConfigInfo>.ToNative(IntPtr.Add(base.Address, AbnomalAttrConfigInfo_Burn_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("毒属性异常相关")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbnormalAttrConfig:AbnomalAttrConfigInfo_Poison")]
	public FAbnomalAttrConfigInfo AbnomalAttrConfigInfo_Poison
	{
		get
		{
			CheckDestroyed();
			if (!AbnomalAttrConfigInfo_Poison_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbnormalAttrConfig:AbnomalAttrConfigInfo_Poison");
				return default(FAbnomalAttrConfigInfo);
			}
			return BlittableTypeMarshaler<FAbnomalAttrConfigInfo>.FromNative(IntPtr.Add(base.Address, AbnomalAttrConfigInfo_Poison_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AbnomalAttrConfigInfo_Poison_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbnormalAttrConfig:AbnomalAttrConfigInfo_Poison");
			}
			else
			{
				BlittableTypeMarshaler<FAbnomalAttrConfigInfo>.ToNative(IntPtr.Add(base.Address, AbnomalAttrConfigInfo_Poison_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("雷属性异常相关")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbnormalAttrConfig:AbnomalAttrConfigInfo_Thunder")]
	public FAbnomalAttrConfigInfo AbnomalAttrConfigInfo_Thunder
	{
		get
		{
			CheckDestroyed();
			if (!AbnomalAttrConfigInfo_Thunder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbnormalAttrConfig:AbnomalAttrConfigInfo_Thunder");
				return default(FAbnomalAttrConfigInfo);
			}
			return BlittableTypeMarshaler<FAbnomalAttrConfigInfo>.FromNative(IntPtr.Add(base.Address, AbnomalAttrConfigInfo_Thunder_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AbnomalAttrConfigInfo_Thunder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbnormalAttrConfig:AbnomalAttrConfigInfo_Thunder");
			}
			else
			{
				BlittableTypeMarshaler<FAbnomalAttrConfigInfo>.ToNative(IntPtr.Add(base.Address, AbnomalAttrConfigInfo_Thunder_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("阴属性异常相关")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbnormalAttrConfig:AbnomalAttrConfigInfo_Yin")]
	public FAbnomalAttrConfigInfo AbnomalAttrConfigInfo_Yin
	{
		get
		{
			CheckDestroyed();
			if (!AbnomalAttrConfigInfo_Yin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbnormalAttrConfig:AbnomalAttrConfigInfo_Yin");
				return default(FAbnomalAttrConfigInfo);
			}
			return BlittableTypeMarshaler<FAbnomalAttrConfigInfo>.FromNative(IntPtr.Add(base.Address, AbnomalAttrConfigInfo_Yin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AbnomalAttrConfigInfo_Yin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbnormalAttrConfig:AbnomalAttrConfigInfo_Yin");
			}
			else
			{
				BlittableTypeMarshaler<FAbnomalAttrConfigInfo>.ToNative(IntPtr.Add(base.Address, AbnomalAttrConfigInfo_Yin_Offset), value);
			}
		}
	}

	[DisplayName("阳属性异常相关")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbnormalAttrConfig:AbnomalAttrConfigInfo_Yang")]
	public FAbnomalAttrConfigInfo AbnomalAttrConfigInfo_Yang
	{
		get
		{
			CheckDestroyed();
			if (!AbnomalAttrConfigInfo_Yang_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbnormalAttrConfig:AbnomalAttrConfigInfo_Yang");
				return default(FAbnomalAttrConfigInfo);
			}
			return BlittableTypeMarshaler<FAbnomalAttrConfigInfo>.FromNative(IntPtr.Add(base.Address, AbnomalAttrConfigInfo_Yang_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AbnomalAttrConfigInfo_Yang_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbnormalAttrConfig:AbnomalAttrConfigInfo_Yang");
			}
			else
			{
				BlittableTypeMarshaler<FAbnomalAttrConfigInfo>.ToNative(IntPtr.Add(base.Address, AbnomalAttrConfigInfo_Yang_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_AbnormalAttrConfig");
		AbnomalAttrConfigInfo_Freeze_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AbnomalAttrConfigInfo_Freeze");
		AbnomalAttrConfigInfo_Freeze_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AbnomalAttrConfigInfo_Freeze", Classes.FStructProperty);
		AbnomalAttrConfigInfo_Burn_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AbnomalAttrConfigInfo_Burn");
		AbnomalAttrConfigInfo_Burn_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AbnomalAttrConfigInfo_Burn", Classes.FStructProperty);
		AbnomalAttrConfigInfo_Poison_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AbnomalAttrConfigInfo_Poison");
		AbnomalAttrConfigInfo_Poison_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AbnomalAttrConfigInfo_Poison", Classes.FStructProperty);
		AbnomalAttrConfigInfo_Thunder_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AbnomalAttrConfigInfo_Thunder");
		AbnomalAttrConfigInfo_Thunder_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AbnomalAttrConfigInfo_Thunder", Classes.FStructProperty);
		AbnomalAttrConfigInfo_Yin_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AbnomalAttrConfigInfo_Yin");
		AbnomalAttrConfigInfo_Yin_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AbnomalAttrConfigInfo_Yin", Classes.FStructProperty);
		AbnomalAttrConfigInfo_Yang_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AbnomalAttrConfigInfo_Yang");
		AbnomalAttrConfigInfo_Yang_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AbnomalAttrConfigInfo_Yang", Classes.FStructProperty);
	}

	static BGWDataAsset_AbnormalAttrConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_AbnormalAttrConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_AbnormalAttrConfig));
	}
}
