using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimNotifyEventReference", "Engine", UnrealModuleType.Engine)]
public struct FAnimNotifyEventReference
{
	private static bool FAnimNotifyEventReference_IsValid;

	private static int FAnimNotifyEventReference_StructSize;

	public FAnimNotifyEventReference Copy()
	{
		return this;
	}

	public static FAnimNotifyEventReference FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNotifyEventReference(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNotifyEventReference value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNotifyEventReference FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNotifyEventReference(nativeBuffer + arrayIndex * FAnimNotifyEventReference_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNotifyEventReference value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNotifyEventReference_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNotifyEventReference_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNotifyEventReference");
		}
	}

	public FAnimNotifyEventReference(IntPtr nativeStruct)
	{
		if (!FAnimNotifyEventReference_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNotifyEventReference");
		}
	}

	static FAnimNotifyEventReference()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNotifyEventReference)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNotifyEventReference));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimNotifyEventReference");
		FAnimNotifyEventReference_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimNotifyEventReference_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimNotifyEventReference", FAnimNotifyEventReference_IsValid);
	}
}
