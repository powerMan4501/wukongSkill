using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 266753)]
[BlueprintType]
[UMetaPath("/Script/Engine.NavigationLink", "Engine", UnrealModuleType.Engine)]
public struct FNavigationLink
{
	private static bool Direction_IsValid;

	private static FFieldAddress Direction_PropertyAddress;

	private static int Direction_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.NavigationLinkBase:Direction")]
	public ENavLinkDirection Direction;

	private static bool Left_IsValid;

	private static int Left_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.NavigationLink:Left")]
	public FVector Left;

	private static bool Right_IsValid;

	private static int Right_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.NavigationLink:Right")]
	public FVector Right;

	private static bool FNavigationLink_IsValid;

	private static int FNavigationLink_StructSize;

	public FNavigationLink Copy()
	{
		return this;
	}

	public static FNavigationLink FromNative(IntPtr nativeBuffer)
	{
		return new FNavigationLink(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNavigationLink value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNavigationLink FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNavigationLink(nativeBuffer + arrayIndex * FNavigationLink_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNavigationLink value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FNavigationLink_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FNavigationLink_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.NavigationLink");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Left_Offset), Left);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Right_Offset), Right);
		EnumMarshaler<ENavLinkDirection>.ToNative(IntPtr.Add(nativeStruct, Direction_Offset), 0, Direction_PropertyAddress.Address, Direction);
	}

	public FNavigationLink(IntPtr nativeStruct)
	{
		if (!FNavigationLink_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.NavigationLink");
			Left = default(FVector);
			Right = default(FVector);
			Direction = ENavLinkDirection.BothWays;
		}
		else
		{
			Left = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Left_Offset));
			Right = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Right_Offset));
			Direction = EnumMarshaler<ENavLinkDirection>.FromNative(IntPtr.Add(nativeStruct, Direction_Offset), 0, Direction_PropertyAddress.Address);
		}
	}

	static FNavigationLink()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FNavigationLink)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNavigationLink));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.NavigationLink");
		FNavigationLink_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Direction_PropertyAddress, intPtr, "Direction");
		Direction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Direction");
		Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Direction", Classes.FByteProperty);
		Left_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Left");
		Left_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Left", Classes.FStructProperty);
		Right_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Right");
		Right_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Right", Classes.FStructProperty);
		FNavigationLink_IsValid = intPtr != IntPtr.Zero && Left_IsValid && Right_IsValid && Direction_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.NavigationLink", FNavigationLink_IsValid);
	}
}
