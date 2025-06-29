using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_OSSCollectionConfig")]
public class BGWDataAsset_OSSCollectionConfig : UBGWDataAsset
{
	private static bool Battle_SpellFire_AngelUnit_IsValid;

	private static int Battle_SpellFire_AngelUnit_Offset;

	private static bool Battle_SpellFire_DistanceUnit_IsValid;

	private static int Battle_SpellFire_DistanceUnit_Offset;

	[BlueprintReadWrite]
	[DisplayName("战斗事件_技能释放_单位角度区间")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_OSSCollectionConfig:Battle_SpellFire_AngelUnit")]
	public int Battle_SpellFire_AngelUnit
	{
		get
		{
			CheckDestroyed();
			if (!Battle_SpellFire_AngelUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_OSSCollectionConfig:Battle_SpellFire_AngelUnit");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Battle_SpellFire_AngelUnit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Battle_SpellFire_AngelUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_OSSCollectionConfig:Battle_SpellFire_AngelUnit");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Battle_SpellFire_AngelUnit_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("战斗事件_技能释放_单位距离区间")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_OSSCollectionConfig:Battle_SpellFire_DistanceUnit")]
	public int Battle_SpellFire_DistanceUnit
	{
		get
		{
			CheckDestroyed();
			if (!Battle_SpellFire_DistanceUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_OSSCollectionConfig:Battle_SpellFire_DistanceUnit");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Battle_SpellFire_DistanceUnit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Battle_SpellFire_DistanceUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_OSSCollectionConfig:Battle_SpellFire_DistanceUnit");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Battle_SpellFire_DistanceUnit_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_OSSCollectionConfig");
		Battle_SpellFire_AngelUnit_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Battle_SpellFire_AngelUnit");
		Battle_SpellFire_AngelUnit_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Battle_SpellFire_AngelUnit", Classes.FIntProperty);
		Battle_SpellFire_DistanceUnit_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Battle_SpellFire_DistanceUnit");
		Battle_SpellFire_DistanceUnit_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Battle_SpellFire_DistanceUnit", Classes.FIntProperty);
	}

	static BGWDataAsset_OSSCollectionConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_OSSCollectionConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_OSSCollectionConfig));
	}
}
