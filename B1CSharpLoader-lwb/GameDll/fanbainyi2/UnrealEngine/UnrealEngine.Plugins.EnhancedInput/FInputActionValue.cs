using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.InputActionValue", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public struct FInputActionValue
{
	private static bool FInputActionValue_IsValid;

	private static int FInputActionValue_StructSize;

	public FInputActionValue Copy()
	{
		return this;
	}

	public static FInputActionValue FromNative(IntPtr nativeBuffer)
	{
		return new FInputActionValue(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInputActionValue value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInputActionValue FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInputActionValue(nativeBuffer + arrayIndex * FInputActionValue_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInputActionValue value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInputActionValue_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInputActionValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EnhancedInput.InputActionValue");
		}
	}

	public FInputActionValue(IntPtr nativeStruct)
	{
		if (!FInputActionValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EnhancedInput.InputActionValue");
		}
	}

	static FInputActionValue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInputActionValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInputActionValue));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/EnhancedInput.InputActionValue");
		FInputActionValue_StructSize = NativeReflection.GetStructSize(intPtr);
		FInputActionValue_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/EnhancedInput.InputActionValue", FInputActionValue_IsValid);
	}
}
