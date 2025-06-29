using System;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.MapSymbolConfig")]
public struct FMapSymbolConfig
{
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MapSymbolConfig:Name")]
	public string Name;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MapSymbolConfig:MapSymbolType")]
	public BtlB1.EMapSymbolType MapSymbolType;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MapSymbolConfig:UnlockRadius")]
	public int UnlockRadius;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MapSymbolConfig:UnlockHeight")]
	public int UnlockHeight;

	private static int MapSymbolConfig_StructSize;

	private static int MapSymbolConfig_IsValid;

	private static bool Name_IsValid;

	private static int Name_Offset;

	private static bool MapSymbolType_IsValid;

	private static int MapSymbolType_Offset;

	private static FFieldAddress MapSymbolType_PropertyAddress;

	private static bool UnlockRadius_IsValid;

	private static int UnlockRadius_Offset;

	private static bool UnlockHeight_IsValid;

	private static int UnlockHeight_Offset;

	public FMapSymbolConfig Copy()
	{
		return this;
	}

	public static FMapSymbolConfig FromNative(IntPtr nativeBuffer)
	{
		return new FMapSymbolConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMapSymbolConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMapSymbolConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMapSymbolConfig(IntPtr.Add(nativeBuffer, arrayIndex * MapSymbolConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMapSymbolConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MapSymbolConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MapSymbolConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MapSymbolConfig");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		EnumMarshaler<BtlB1.EMapSymbolType>.ToNative(IntPtr.Add(nativeStruct, MapSymbolType_Offset), 0, MapSymbolType_PropertyAddress.Address, MapSymbolType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, UnlockRadius_Offset), UnlockRadius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, UnlockHeight_Offset), UnlockHeight);
	}

	public FMapSymbolConfig(IntPtr nativeStruct)
	{
		if (MapSymbolConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MapSymbolConfig");
			Name = null;
			MapSymbolType = BtlB1.EMapSymbolType.Min;
			UnlockRadius = 0;
			UnlockHeight = 0;
		}
		else
		{
			Name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			MapSymbolType = EnumMarshaler<BtlB1.EMapSymbolType>.FromNative(IntPtr.Add(nativeStruct, MapSymbolType_Offset), 0, MapSymbolType_PropertyAddress.Address);
			UnlockRadius = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, UnlockRadius_Offset));
			UnlockHeight = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, UnlockHeight_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MapSymbolConfig");
		MapSymbolConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflection.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Name", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref MapSymbolType_PropertyAddress, intPtr, "MapSymbolType");
		MapSymbolType_Offset = NativeReflection.GetPropertyOffset(intPtr, "MapSymbolType");
		MapSymbolType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MapSymbolType", Classes.FEnumProperty);
		UnlockRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnlockRadius");
		UnlockRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnlockRadius", Classes.FIntProperty);
		UnlockHeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnlockHeight");
		UnlockHeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnlockHeight", Classes.FIntProperty);
		MapSymbolConfig_IsValid = ((intPtr != IntPtr.Zero && Name_IsValid && MapSymbolType_IsValid && UnlockRadius_IsValid && UnlockHeight_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MapSymbolConfig", (byte)MapSymbolConfig_IsValid != 0);
	}

	static FMapSymbolConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FMapSymbolConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMapSymbolConfig));
	}
}
