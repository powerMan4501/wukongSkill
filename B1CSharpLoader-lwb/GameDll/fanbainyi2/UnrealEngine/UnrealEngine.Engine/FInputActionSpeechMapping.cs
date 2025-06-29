using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.InputActionSpeechMapping", "Engine", UnrealModuleType.Engine)]
public struct FInputActionSpeechMapping
{
	private static bool FInputActionSpeechMapping_IsValid;

	private static int FInputActionSpeechMapping_StructSize;

	public FInputActionSpeechMapping Copy()
	{
		return this;
	}

	public static FInputActionSpeechMapping FromNative(IntPtr nativeBuffer)
	{
		return new FInputActionSpeechMapping(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInputActionSpeechMapping value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInputActionSpeechMapping FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInputActionSpeechMapping(nativeBuffer + arrayIndex * FInputActionSpeechMapping_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInputActionSpeechMapping value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInputActionSpeechMapping_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInputActionSpeechMapping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InputActionSpeechMapping");
		}
	}

	public FInputActionSpeechMapping(IntPtr nativeStruct)
	{
		if (!FInputActionSpeechMapping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InputActionSpeechMapping");
		}
	}

	static FInputActionSpeechMapping()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInputActionSpeechMapping)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInputActionSpeechMapping));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.InputActionSpeechMapping");
		FInputActionSpeechMapping_StructSize = NativeReflection.GetStructSize(intPtr);
		FInputActionSpeechMapping_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.InputActionSpeechMapping", FInputActionSpeechMapping_IsValid);
	}
}
