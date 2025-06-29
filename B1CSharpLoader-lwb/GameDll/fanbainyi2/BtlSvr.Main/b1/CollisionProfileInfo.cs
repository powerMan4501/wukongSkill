using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.CollisionProfileInfo")]
public struct CollisionProfileInfo
{
	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CollisionProfileInfo:Type")]
	public ECollisionBodyType Type;

	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CollisionProfileInfo:ProfileName")]
	public FName ProfileName;

	private static int CollisionProfileInfo_StructSize;

	private static int CollisionProfileInfo_IsValid;

	private static bool Type_IsValid;

	private static int Type_Offset;

	private static FFieldAddress Type_PropertyAddress;

	private static bool ProfileName_IsValid;

	private static int ProfileName_Offset;

	public CollisionProfileInfo Copy()
	{
		return this;
	}

	public static CollisionProfileInfo FromNative(IntPtr nativeBuffer)
	{
		return new CollisionProfileInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, CollisionProfileInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static CollisionProfileInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new CollisionProfileInfo(IntPtr.Add(nativeBuffer, arrayIndex * CollisionProfileInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, CollisionProfileInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * CollisionProfileInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (CollisionProfileInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CollisionProfileInfo");
			return;
		}
		EnumMarshaler<ECollisionBodyType>.ToNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address, Type);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ProfileName_Offset), ProfileName);
	}

	public CollisionProfileInfo(IntPtr nativeStruct)
	{
		if (CollisionProfileInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CollisionProfileInfo");
			Type = (ECollisionBodyType)0;
			ProfileName = default(FName);
		}
		else
		{
			Type = EnumMarshaler<ECollisionBodyType>.FromNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address);
			ProfileName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ProfileName_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.CollisionProfileInfo");
		CollisionProfileInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref Type_PropertyAddress, intPtr, "Type");
		Type_Offset = NativeReflection.GetPropertyOffset(intPtr, "Type");
		Type_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Type", Classes.FEnumProperty);
		ProfileName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProfileName");
		ProfileName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProfileName", Classes.FNameProperty);
		CollisionProfileInfo_IsValid = ((intPtr != IntPtr.Zero && Type_IsValid && ProfileName_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.CollisionProfileInfo", (byte)CollisionProfileInfo_IsValid != 0);
	}

	static CollisionProfileInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(CollisionProfileInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(CollisionProfileInfo));
	}
}
