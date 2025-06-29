using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.VertexOffsetUsage", "Engine", UnrealModuleType.Engine)]
public struct FVertexOffsetUsage
{
	private static bool FVertexOffsetUsage_IsValid;

	private static int FVertexOffsetUsage_StructSize;

	public FVertexOffsetUsage Copy()
	{
		return this;
	}

	public static FVertexOffsetUsage FromNative(IntPtr nativeBuffer)
	{
		return new FVertexOffsetUsage(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FVertexOffsetUsage value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FVertexOffsetUsage FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FVertexOffsetUsage(nativeBuffer + arrayIndex * FVertexOffsetUsage_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FVertexOffsetUsage value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FVertexOffsetUsage_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FVertexOffsetUsage_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.VertexOffsetUsage");
		}
	}

	public FVertexOffsetUsage(IntPtr nativeStruct)
	{
		if (!FVertexOffsetUsage_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.VertexOffsetUsage");
		}
	}

	static FVertexOffsetUsage()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FVertexOffsetUsage)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FVertexOffsetUsage));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.VertexOffsetUsage");
		FVertexOffsetUsage_StructSize = NativeReflection.GetStructSize(intPtr);
		FVertexOffsetUsage_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.VertexOffsetUsage", FVertexOffsetUsage_IsValid);
	}
}
