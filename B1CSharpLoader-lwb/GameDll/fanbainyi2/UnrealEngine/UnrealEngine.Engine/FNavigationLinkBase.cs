using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 266753)]
[BlueprintType]
[UMetaPath("/Script/Engine.NavigationLinkBase", "Engine", UnrealModuleType.Engine)]
public struct FNavigationLinkBase
{
	private static bool Direction_IsValid;

	private static FFieldAddress Direction_PropertyAddress;

	private static int Direction_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.NavigationLinkBase:Direction")]
	public ENavLinkDirection Direction;

	private static bool FNavigationLinkBase_IsValid;

	private static int FNavigationLinkBase_StructSize;

	public FNavigationLinkBase Copy()
	{
		return this;
	}

	public static FNavigationLinkBase FromNative(IntPtr nativeBuffer)
	{
		return new FNavigationLinkBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNavigationLinkBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNavigationLinkBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNavigationLinkBase(nativeBuffer + arrayIndex * FNavigationLinkBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNavigationLinkBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FNavigationLinkBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FNavigationLinkBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.NavigationLinkBase");
		}
		else
		{
			EnumMarshaler<ENavLinkDirection>.ToNative(IntPtr.Add(nativeStruct, Direction_Offset), 0, Direction_PropertyAddress.Address, Direction);
		}
	}

	public FNavigationLinkBase(IntPtr nativeStruct)
	{
		if (!FNavigationLinkBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.NavigationLinkBase");
			Direction = ENavLinkDirection.BothWays;
		}
		else
		{
			Direction = EnumMarshaler<ENavLinkDirection>.FromNative(IntPtr.Add(nativeStruct, Direction_Offset), 0, Direction_PropertyAddress.Address);
		}
	}

	static FNavigationLinkBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FNavigationLinkBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNavigationLinkBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.NavigationLinkBase");
		FNavigationLinkBase_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Direction_PropertyAddress, intPtr, "Direction");
		Direction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Direction");
		Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Direction", Classes.FByteProperty);
		FNavigationLinkBase_IsValid = intPtr != IntPtr.Zero && Direction_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.NavigationLinkBase", FNavigationLinkBase_IsValid);
	}
}
