using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.UnitWeapon")]
public struct FUnitWeapon
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.UnitWeapon:Weapon")]
	public TSubclassOf<AActor> Weapon;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.UnitWeapon:SocketName")]
	public FName SocketName;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UnitWeapon:bDefaultInactive")]
	public bool bDefaultInactive;

	private static int UnitWeapon_StructSize;

	private static int UnitWeapon_IsValid;

	private static bool Weapon_IsValid;

	private static int Weapon_Offset;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	private static bool bDefaultInactive_IsValid;

	private static int bDefaultInactive_Offset;

	private static FFieldAddress bDefaultInactive_PropertyAddress;

	public FUnitWeapon Copy()
	{
		return this;
	}

	public static FUnitWeapon FromNative(IntPtr nativeBuffer)
	{
		return new FUnitWeapon(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUnitWeapon value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUnitWeapon FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUnitWeapon(IntPtr.Add(nativeBuffer, arrayIndex * UnitWeapon_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUnitWeapon value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * UnitWeapon_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (UnitWeapon_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UnitWeapon");
			return;
		}
		TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, Weapon_Offset), Weapon);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SocketName_Offset), SocketName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bDefaultInactive_Offset), 0, bDefaultInactive_PropertyAddress.Address, bDefaultInactive);
	}

	public FUnitWeapon(IntPtr nativeStruct)
	{
		if (UnitWeapon_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UnitWeapon");
			Weapon = default(TSubclassOf<AActor>);
			SocketName = default(FName);
			bDefaultInactive = false;
		}
		else
		{
			Weapon = TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, Weapon_Offset));
			SocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SocketName_Offset));
			bDefaultInactive = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bDefaultInactive_Offset), 0, bDefaultInactive_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.UnitWeapon");
		UnitWeapon_StructSize = NativeReflection.GetStructSize(intPtr);
		Weapon_Offset = NativeReflection.GetPropertyOffset(intPtr, "Weapon");
		Weapon_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Weapon", Classes.FClassProperty);
		SocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref bDefaultInactive_PropertyAddress, intPtr, "bDefaultInactive");
		bDefaultInactive_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDefaultInactive");
		bDefaultInactive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDefaultInactive", Classes.FBoolProperty);
		UnitWeapon_IsValid = ((intPtr != IntPtr.Zero && Weapon_IsValid && SocketName_IsValid && bDefaultInactive_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.UnitWeapon", (byte)UnitWeapon_IsValid != 0);
	}

	static FUnitWeapon()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FUnitWeapon)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUnitWeapon));
	}
}
