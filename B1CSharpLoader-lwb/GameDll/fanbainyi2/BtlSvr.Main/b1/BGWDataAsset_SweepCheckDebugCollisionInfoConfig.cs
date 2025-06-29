using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig")]
public class BGWDataAsset_SweepCheckDebugCollisionInfoConfig : UBGWDataAsset
{
	private static bool SCDCollisionInfo_IsValid;

	private static int SCDCollisionInfo_Offset;

	private static bool HitUnitSCDCollisionInfo_IsValid;

	private static int HitUnitSCDCollisionInfo_Offset;

	private static bool HitBulletSCDCollisionInfo_IsValid;

	private static int HitBulletSCDCollisionInfo_Offset;

	private static bool HitSceneItemSCDCollisionInfo_IsValid;

	private static int HitSceneItemSCDCollisionInfo_Offset;

	private static bool HitWorldItemSCDCollisionInfo_IsValid;

	private static int HitWorldItemSCDCollisionInfo_Offset;

	private static bool AWDCollisionInfo_IsValid;

	private static int AWDCollisionInfo_Offset;

	private static bool HitUnitAWDCollisionInfo_IsValid;

	private static int HitUnitAWDCollisionInfo_Offset;

	private static bool HitSceneItemAWDCollisionInfo_IsValid;

	private static int HitSceneItemAWDCollisionInfo_Offset;

	private static bool HitWorldItemAWDCollisionInfo_IsValid;

	private static int HitWorldItemAWDCollisionInfo_Offset;

	private static bool HitBulletAWDCollisionInfo_IsValid;

	private static int HitBulletAWDCollisionInfo_Offset;

	[BlueprintReadWrite]
	[DisplayName("SweepCheck扫描")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:SCDCollisionInfo")]
	public FSCDCollisionInfo SCDCollisionInfo
	{
		get
		{
			CheckDestroyed();
			if (!SCDCollisionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:SCDCollisionInfo");
				return default(FSCDCollisionInfo);
			}
			return BlittableTypeMarshaler<FSCDCollisionInfo>.FromNative(IntPtr.Add(base.Address, SCDCollisionInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SCDCollisionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:SCDCollisionInfo");
			}
			else
			{
				BlittableTypeMarshaler<FSCDCollisionInfo>.ToNative(IntPtr.Add(base.Address, SCDCollisionInfo_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("打中单位")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitUnitSCDCollisionInfo")]
	public FSCDCollisionInfo HitUnitSCDCollisionInfo
	{
		get
		{
			CheckDestroyed();
			if (!HitUnitSCDCollisionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitUnitSCDCollisionInfo");
				return default(FSCDCollisionInfo);
			}
			return BlittableTypeMarshaler<FSCDCollisionInfo>.FromNative(IntPtr.Add(base.Address, HitUnitSCDCollisionInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitUnitSCDCollisionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitUnitSCDCollisionInfo");
			}
			else
			{
				BlittableTypeMarshaler<FSCDCollisionInfo>.ToNative(IntPtr.Add(base.Address, HitUnitSCDCollisionInfo_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("打中可击回子弹")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitBulletSCDCollisionInfo")]
	public FSCDCollisionInfo HitBulletSCDCollisionInfo
	{
		get
		{
			CheckDestroyed();
			if (!HitBulletSCDCollisionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitBulletSCDCollisionInfo");
				return default(FSCDCollisionInfo);
			}
			return BlittableTypeMarshaler<FSCDCollisionInfo>.FromNative(IntPtr.Add(base.Address, HitBulletSCDCollisionInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitBulletSCDCollisionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitBulletSCDCollisionInfo");
			}
			else
			{
				BlittableTypeMarshaler<FSCDCollisionInfo>.ToNative(IntPtr.Add(base.Address, HitBulletSCDCollisionInfo_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("打中场景物件")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitSceneItemSCDCollisionInfo")]
	public FSCDCollisionInfo HitSceneItemSCDCollisionInfo
	{
		get
		{
			CheckDestroyed();
			if (!HitSceneItemSCDCollisionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitSceneItemSCDCollisionInfo");
				return default(FSCDCollisionInfo);
			}
			return BlittableTypeMarshaler<FSCDCollisionInfo>.FromNative(IntPtr.Add(base.Address, HitSceneItemSCDCollisionInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitSceneItemSCDCollisionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitSceneItemSCDCollisionInfo");
			}
			else
			{
				BlittableTypeMarshaler<FSCDCollisionInfo>.ToNative(IntPtr.Add(base.Address, HitSceneItemSCDCollisionInfo_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("打中世界物件")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitWorldItemSCDCollisionInfo")]
	public FSCDCollisionInfo HitWorldItemSCDCollisionInfo
	{
		get
		{
			CheckDestroyed();
			if (!HitWorldItemSCDCollisionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitWorldItemSCDCollisionInfo");
				return default(FSCDCollisionInfo);
			}
			return BlittableTypeMarshaler<FSCDCollisionInfo>.FromNative(IntPtr.Add(base.Address, HitWorldItemSCDCollisionInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitWorldItemSCDCollisionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitWorldItemSCDCollisionInfo");
			}
			else
			{
				BlittableTypeMarshaler<FSCDCollisionInfo>.ToNative(IntPtr.Add(base.Address, HitWorldItemSCDCollisionInfo_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("AttackWarning扫描")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:AWDCollisionInfo")]
	public FSCDCollisionInfo AWDCollisionInfo
	{
		get
		{
			CheckDestroyed();
			if (!AWDCollisionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:AWDCollisionInfo");
				return default(FSCDCollisionInfo);
			}
			return BlittableTypeMarshaler<FSCDCollisionInfo>.FromNative(IntPtr.Add(base.Address, AWDCollisionInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AWDCollisionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:AWDCollisionInfo");
			}
			else
			{
				BlittableTypeMarshaler<FSCDCollisionInfo>.ToNative(IntPtr.Add(base.Address, AWDCollisionInfo_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("AttackWarning命中单位")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitUnitAWDCollisionInfo")]
	public FSCDCollisionInfo HitUnitAWDCollisionInfo
	{
		get
		{
			CheckDestroyed();
			if (!HitUnitAWDCollisionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitUnitAWDCollisionInfo");
				return default(FSCDCollisionInfo);
			}
			return BlittableTypeMarshaler<FSCDCollisionInfo>.FromNative(IntPtr.Add(base.Address, HitUnitAWDCollisionInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitUnitAWDCollisionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitUnitAWDCollisionInfo");
			}
			else
			{
				BlittableTypeMarshaler<FSCDCollisionInfo>.ToNative(IntPtr.Add(base.Address, HitUnitAWDCollisionInfo_Offset), value);
			}
		}
	}

	[DisplayName("AttackWarning命中场景物件")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitSceneItemAWDCollisionInfo")]
	public FSCDCollisionInfo HitSceneItemAWDCollisionInfo
	{
		get
		{
			CheckDestroyed();
			if (!HitSceneItemAWDCollisionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitSceneItemAWDCollisionInfo");
				return default(FSCDCollisionInfo);
			}
			return BlittableTypeMarshaler<FSCDCollisionInfo>.FromNative(IntPtr.Add(base.Address, HitSceneItemAWDCollisionInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitSceneItemAWDCollisionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitSceneItemAWDCollisionInfo");
			}
			else
			{
				BlittableTypeMarshaler<FSCDCollisionInfo>.ToNative(IntPtr.Add(base.Address, HitSceneItemAWDCollisionInfo_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("AttackWarning命中世界物件")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitWorldItemAWDCollisionInfo")]
	public FSCDCollisionInfo HitWorldItemAWDCollisionInfo
	{
		get
		{
			CheckDestroyed();
			if (!HitWorldItemAWDCollisionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitWorldItemAWDCollisionInfo");
				return default(FSCDCollisionInfo);
			}
			return BlittableTypeMarshaler<FSCDCollisionInfo>.FromNative(IntPtr.Add(base.Address, HitWorldItemAWDCollisionInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitWorldItemAWDCollisionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitWorldItemAWDCollisionInfo");
			}
			else
			{
				BlittableTypeMarshaler<FSCDCollisionInfo>.ToNative(IntPtr.Add(base.Address, HitWorldItemAWDCollisionInfo_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("AttackWarning命中可击回子弹")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitBulletAWDCollisionInfo")]
	public FSCDCollisionInfo HitBulletAWDCollisionInfo
	{
		get
		{
			CheckDestroyed();
			if (!HitBulletAWDCollisionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitBulletAWDCollisionInfo");
				return default(FSCDCollisionInfo);
			}
			return BlittableTypeMarshaler<FSCDCollisionInfo>.FromNative(IntPtr.Add(base.Address, HitBulletAWDCollisionInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitBulletAWDCollisionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig:HitBulletAWDCollisionInfo");
			}
			else
			{
				BlittableTypeMarshaler<FSCDCollisionInfo>.ToNative(IntPtr.Add(base.Address, HitBulletAWDCollisionInfo_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_SweepCheckDebugCollisionInfoConfig");
		SCDCollisionInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SCDCollisionInfo");
		SCDCollisionInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SCDCollisionInfo", Classes.FStructProperty);
		HitUnitSCDCollisionInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HitUnitSCDCollisionInfo");
		HitUnitSCDCollisionInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HitUnitSCDCollisionInfo", Classes.FStructProperty);
		HitBulletSCDCollisionInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HitBulletSCDCollisionInfo");
		HitBulletSCDCollisionInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HitBulletSCDCollisionInfo", Classes.FStructProperty);
		HitSceneItemSCDCollisionInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HitSceneItemSCDCollisionInfo");
		HitSceneItemSCDCollisionInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HitSceneItemSCDCollisionInfo", Classes.FStructProperty);
		HitWorldItemSCDCollisionInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HitWorldItemSCDCollisionInfo");
		HitWorldItemSCDCollisionInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HitWorldItemSCDCollisionInfo", Classes.FStructProperty);
		AWDCollisionInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AWDCollisionInfo");
		AWDCollisionInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AWDCollisionInfo", Classes.FStructProperty);
		HitUnitAWDCollisionInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HitUnitAWDCollisionInfo");
		HitUnitAWDCollisionInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HitUnitAWDCollisionInfo", Classes.FStructProperty);
		HitSceneItemAWDCollisionInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HitSceneItemAWDCollisionInfo");
		HitSceneItemAWDCollisionInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HitSceneItemAWDCollisionInfo", Classes.FStructProperty);
		HitWorldItemAWDCollisionInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HitWorldItemAWDCollisionInfo");
		HitWorldItemAWDCollisionInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HitWorldItemAWDCollisionInfo", Classes.FStructProperty);
		HitBulletAWDCollisionInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HitBulletAWDCollisionInfo");
		HitBulletAWDCollisionInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HitBulletAWDCollisionInfo", Classes.FStructProperty);
	}

	static BGWDataAsset_SweepCheckDebugCollisionInfoConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_SweepCheckDebugCollisionInfoConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_SweepCheckDebugCollisionInfoConfig));
	}
}
