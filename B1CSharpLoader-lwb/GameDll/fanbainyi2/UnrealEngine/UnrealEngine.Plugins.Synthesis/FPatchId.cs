using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.PatchId", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FPatchId
{
	private static bool FPatchId_IsValid;

	private static int FPatchId_StructSize;

	public FPatchId Copy()
	{
		return this;
	}

	public static FPatchId FromNative(IntPtr nativeBuffer)
	{
		return new FPatchId(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPatchId value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPatchId FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPatchId(nativeBuffer + arrayIndex * FPatchId_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPatchId value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPatchId_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPatchId_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.PatchId");
		}
	}

	public FPatchId(IntPtr nativeStruct)
	{
		if (!FPatchId_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.PatchId");
		}
	}

	static FPatchId()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPatchId)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPatchId));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.PatchId");
		FPatchId_StructSize = NativeReflection.GetStructSize(intPtr);
		FPatchId_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Synthesis.PatchId", FPatchId_IsValid);
	}
}
