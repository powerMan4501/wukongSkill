using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.ImportanceTexture", "Engine", UnrealModuleType.Engine)]
public struct FImportanceTexture
{
	private static bool FImportanceTexture_IsValid;

	private static int FImportanceTexture_StructSize;

	public FImportanceTexture Copy()
	{
		return this;
	}

	public static FImportanceTexture FromNative(IntPtr nativeBuffer)
	{
		return new FImportanceTexture(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FImportanceTexture value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FImportanceTexture FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FImportanceTexture(nativeBuffer + arrayIndex * FImportanceTexture_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FImportanceTexture value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FImportanceTexture_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FImportanceTexture_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ImportanceTexture");
		}
	}

	public FImportanceTexture(IntPtr nativeStruct)
	{
		if (!FImportanceTexture_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ImportanceTexture");
		}
	}

	static FImportanceTexture()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FImportanceTexture)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FImportanceTexture));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.ImportanceTexture");
		FImportanceTexture_StructSize = NativeReflection.GetStructSize(intPtr);
		FImportanceTexture_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.ImportanceTexture", FImportanceTexture_IsValid);
	}
}
