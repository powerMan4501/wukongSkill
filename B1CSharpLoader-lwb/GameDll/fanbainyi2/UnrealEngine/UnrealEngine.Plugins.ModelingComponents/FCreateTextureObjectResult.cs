using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingComponents;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ModelingComponents.CreateTextureObjectResult", "ModelingComponents", UnrealModuleType.EnginePlugin)]
public struct FCreateTextureObjectResult
{
	private static bool FCreateTextureObjectResult_IsValid;

	private static int FCreateTextureObjectResult_StructSize;

	public FCreateTextureObjectResult Copy()
	{
		return this;
	}

	public static FCreateTextureObjectResult FromNative(IntPtr nativeBuffer)
	{
		return new FCreateTextureObjectResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCreateTextureObjectResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCreateTextureObjectResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCreateTextureObjectResult(nativeBuffer + arrayIndex * FCreateTextureObjectResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCreateTextureObjectResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCreateTextureObjectResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCreateTextureObjectResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ModelingComponents.CreateTextureObjectResult");
		}
	}

	public FCreateTextureObjectResult(IntPtr nativeStruct)
	{
		if (!FCreateTextureObjectResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ModelingComponents.CreateTextureObjectResult");
		}
	}

	static FCreateTextureObjectResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCreateTextureObjectResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCreateTextureObjectResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ModelingComponents.CreateTextureObjectResult");
		FCreateTextureObjectResult_StructSize = NativeReflection.GetStructSize(intPtr);
		FCreateTextureObjectResult_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ModelingComponents.CreateTextureObjectResult", FCreateTextureObjectResult_IsValid);
	}
}
