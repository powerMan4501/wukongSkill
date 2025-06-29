using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.ComponentSpacePoseLink", "Engine", UnrealModuleType.Engine)]
public struct FComponentSpacePoseLink
{
	private static bool FComponentSpacePoseLink_IsValid;

	private static int FComponentSpacePoseLink_StructSize;

	public FComponentSpacePoseLink Copy()
	{
		return this;
	}

	public static FComponentSpacePoseLink FromNative(IntPtr nativeBuffer)
	{
		return new FComponentSpacePoseLink(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FComponentSpacePoseLink value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FComponentSpacePoseLink FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FComponentSpacePoseLink(nativeBuffer + arrayIndex * FComponentSpacePoseLink_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FComponentSpacePoseLink value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FComponentSpacePoseLink_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FComponentSpacePoseLink_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ComponentSpacePoseLink");
		}
	}

	public FComponentSpacePoseLink(IntPtr nativeStruct)
	{
		if (!FComponentSpacePoseLink_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ComponentSpacePoseLink");
		}
	}

	static FComponentSpacePoseLink()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FComponentSpacePoseLink)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FComponentSpacePoseLink));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.ComponentSpacePoseLink");
		FComponentSpacePoseLink_StructSize = NativeReflection.GetStructSize(intPtr);
		FComponentSpacePoseLink_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.ComponentSpacePoseLink", FComponentSpacePoseLink_IsValid);
	}
}
