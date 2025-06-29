using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.UnitPhysicsDesc")]
public struct FUnitPhysicsDesc
{
	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.UnitPhysicsDesc:DefaultTigerWoodsConfig")]
	public BGWDataAsset_TigerWoodsConfig DefaultTigerWoodsConfig;

	private static int UnitPhysicsDesc_StructSize;

	private static int UnitPhysicsDesc_IsValid;

	private static bool DefaultTigerWoodsConfig_IsValid;

	private static int DefaultTigerWoodsConfig_Offset;

	public FUnitPhysicsDesc Copy()
	{
		return this;
	}

	public static FUnitPhysicsDesc FromNative(IntPtr nativeBuffer)
	{
		return new FUnitPhysicsDesc(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUnitPhysicsDesc value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUnitPhysicsDesc FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUnitPhysicsDesc(IntPtr.Add(nativeBuffer, arrayIndex * UnitPhysicsDesc_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUnitPhysicsDesc value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * UnitPhysicsDesc_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (UnitPhysicsDesc_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UnitPhysicsDesc");
		}
		else
		{
			UObjectMarshaler<BGWDataAsset_TigerWoodsConfig>.ToNative(IntPtr.Add(nativeStruct, DefaultTigerWoodsConfig_Offset), DefaultTigerWoodsConfig);
		}
	}

	public FUnitPhysicsDesc(IntPtr nativeStruct)
	{
		if (UnitPhysicsDesc_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UnitPhysicsDesc");
			DefaultTigerWoodsConfig = null;
		}
		else
		{
			DefaultTigerWoodsConfig = UObjectMarshaler<BGWDataAsset_TigerWoodsConfig>.FromNative(IntPtr.Add(nativeStruct, DefaultTigerWoodsConfig_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.UnitPhysicsDesc");
		UnitPhysicsDesc_StructSize = NativeReflection.GetStructSize(intPtr);
		DefaultTigerWoodsConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultTigerWoodsConfig");
		DefaultTigerWoodsConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultTigerWoodsConfig", Classes.FObjectProperty);
		UnitPhysicsDesc_IsValid = ((intPtr != IntPtr.Zero && DefaultTigerWoodsConfig_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.UnitPhysicsDesc", (byte)UnitPhysicsDesc_IsValid != 0);
	}

	static FUnitPhysicsDesc()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FUnitPhysicsDesc)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUnitPhysicsDesc));
	}
}
