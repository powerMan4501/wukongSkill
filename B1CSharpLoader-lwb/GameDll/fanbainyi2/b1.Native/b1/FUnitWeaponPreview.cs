using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/b1.UnitWeaponPreview", "b1", UnrealModuleType.Game)]
public struct FUnitWeaponPreview
{
	private static bool Weapon_IsValid;

	private static int Weapon_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/b1.UnitWeaponPreview:Weapon")]
	public TSubclassOf<AActor> Weapon;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.UnitWeaponPreview:SocketName")]
	public FName SocketName;

	private static bool FUnitWeaponPreview_IsValid;

	private static int FUnitWeaponPreview_StructSize;

	public FUnitWeaponPreview Copy()
	{
		return this;
	}

	public static FUnitWeaponPreview FromNative(IntPtr nativeBuffer)
	{
		return new FUnitWeaponPreview(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUnitWeaponPreview value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUnitWeaponPreview FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUnitWeaponPreview(nativeBuffer + arrayIndex * FUnitWeaponPreview_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUnitWeaponPreview value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FUnitWeaponPreview_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FUnitWeaponPreview_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.UnitWeaponPreview");
			return;
		}
		TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, Weapon_Offset), Weapon);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SocketName_Offset), SocketName);
	}

	public FUnitWeaponPreview(IntPtr nativeStruct)
	{
		if (!FUnitWeaponPreview_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.UnitWeaponPreview");
			Weapon = default(TSubclassOf<AActor>);
			SocketName = default(FName);
		}
		else
		{
			Weapon = TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, Weapon_Offset));
			SocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SocketName_Offset));
		}
	}

	static FUnitWeaponPreview()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FUnitWeaponPreview)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUnitWeaponPreview));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.UnitWeaponPreview");
		FUnitWeaponPreview_StructSize = NativeReflection.GetStructSize(intPtr);
		Weapon_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Weapon");
		Weapon_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Weapon", Classes.FClassProperty);
		SocketName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		FUnitWeaponPreview_IsValid = intPtr != IntPtr.Zero && Weapon_IsValid && SocketName_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.UnitWeaponPreview", FUnitWeaponPreview_IsValid);
	}
}
