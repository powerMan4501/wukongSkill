using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingComponents;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ModelingComponents.CreateTextureObjectParams", "ModelingComponents", UnrealModuleType.EnginePlugin)]
public struct FCreateTextureObjectParams
{
	private static bool FCreateTextureObjectParams_IsValid;

	private static int FCreateTextureObjectParams_StructSize;

	public FCreateTextureObjectParams Copy()
	{
		return this;
	}

	public static FCreateTextureObjectParams FromNative(IntPtr nativeBuffer)
	{
		return new FCreateTextureObjectParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCreateTextureObjectParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCreateTextureObjectParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCreateTextureObjectParams(nativeBuffer + arrayIndex * FCreateTextureObjectParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCreateTextureObjectParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCreateTextureObjectParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCreateTextureObjectParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ModelingComponents.CreateTextureObjectParams");
		}
	}

	public FCreateTextureObjectParams(IntPtr nativeStruct)
	{
		if (!FCreateTextureObjectParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ModelingComponents.CreateTextureObjectParams");
		}
	}

	static FCreateTextureObjectParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCreateTextureObjectParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCreateTextureObjectParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ModelingComponents.CreateTextureObjectParams");
		FCreateTextureObjectParams_StructSize = NativeReflection.GetStructSize(intPtr);
		FCreateTextureObjectParams_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ModelingComponents.CreateTextureObjectParams", FCreateTextureObjectParams_IsValid);
	}
}
