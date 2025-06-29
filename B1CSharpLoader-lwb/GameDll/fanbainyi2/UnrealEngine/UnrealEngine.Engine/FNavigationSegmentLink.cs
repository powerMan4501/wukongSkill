using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 266753)]
[BlueprintType]
[UMetaPath("/Script/Engine.NavigationSegmentLink", "Engine", UnrealModuleType.Engine)]
public struct FNavigationSegmentLink
{
	private static bool Direction_IsValid;

	private static FFieldAddress Direction_PropertyAddress;

	private static int Direction_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.NavigationLinkBase:Direction")]
	public ENavLinkDirection Direction;

	private static bool FNavigationSegmentLink_IsValid;

	private static int FNavigationSegmentLink_StructSize;

	public FNavigationSegmentLink Copy()
	{
		return this;
	}

	public static FNavigationSegmentLink FromNative(IntPtr nativeBuffer)
	{
		return new FNavigationSegmentLink(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNavigationSegmentLink value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNavigationSegmentLink FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNavigationSegmentLink(nativeBuffer + arrayIndex * FNavigationSegmentLink_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNavigationSegmentLink value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FNavigationSegmentLink_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FNavigationSegmentLink_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.NavigationSegmentLink");
		}
		else
		{
			EnumMarshaler<ENavLinkDirection>.ToNative(IntPtr.Add(nativeStruct, Direction_Offset), 0, Direction_PropertyAddress.Address, Direction);
		}
	}

	public FNavigationSegmentLink(IntPtr nativeStruct)
	{
		if (!FNavigationSegmentLink_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.NavigationSegmentLink");
			Direction = ENavLinkDirection.BothWays;
		}
		else
		{
			Direction = EnumMarshaler<ENavLinkDirection>.FromNative(IntPtr.Add(nativeStruct, Direction_Offset), 0, Direction_PropertyAddress.Address);
		}
	}

	static FNavigationSegmentLink()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FNavigationSegmentLink)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNavigationSegmentLink));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.NavigationSegmentLink");
		FNavigationSegmentLink_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Direction_PropertyAddress, intPtr, "Direction");
		Direction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Direction");
		Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Direction", Classes.FByteProperty);
		FNavigationSegmentLink_IsValid = intPtr != IntPtr.Zero && Direction_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.NavigationSegmentLink", FNavigationSegmentLink_IsValid);
	}
}
