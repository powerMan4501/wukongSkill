using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.SubjectFrameHandle", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FSubjectFrameHandle
{
	private static bool FSubjectFrameHandle_IsValid;

	private static int FSubjectFrameHandle_StructSize;

	public FSubjectFrameHandle Copy()
	{
		return this;
	}

	public static FSubjectFrameHandle FromNative(IntPtr nativeBuffer)
	{
		return new FSubjectFrameHandle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSubjectFrameHandle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSubjectFrameHandle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSubjectFrameHandle(nativeBuffer + arrayIndex * FSubjectFrameHandle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSubjectFrameHandle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSubjectFrameHandle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSubjectFrameHandle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.SubjectFrameHandle");
		}
	}

	public FSubjectFrameHandle(IntPtr nativeStruct)
	{
		if (!FSubjectFrameHandle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.SubjectFrameHandle");
		}
	}

	static FSubjectFrameHandle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSubjectFrameHandle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSubjectFrameHandle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.SubjectFrameHandle");
		FSubjectFrameHandle_StructSize = NativeReflection.GetStructSize(intPtr);
		FSubjectFrameHandle_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.SubjectFrameHandle", FSubjectFrameHandle_IsValid);
	}
}
