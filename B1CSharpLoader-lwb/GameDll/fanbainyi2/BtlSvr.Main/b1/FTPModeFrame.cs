using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FTPModeFrame")]
public struct FTPModeFrame
{
	[BlueprintReadWrite]
	[DisplayName("显示名称")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FTPModeFrame:DisplayName")]
	public FText DisplayName;

	[DisplayName("对应")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FTPModeFrame:TargetAKB")]
	public string TargetAKB;

	private static int FTPModeFrame_StructSize;

	private static int FTPModeFrame_IsValid;

	private static bool DisplayName_IsValid;

	private static int DisplayName_Offset;

	private static bool TargetAKB_IsValid;

	private static int TargetAKB_Offset;

	public FTPModeFrame Copy()
	{
		return this;
	}

	public static FTPModeFrame FromNative(IntPtr nativeBuffer)
	{
		return new FTPModeFrame(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTPModeFrame value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTPModeFrame FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTPModeFrame(IntPtr.Add(nativeBuffer, arrayIndex * FTPModeFrame_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTPModeFrame value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FTPModeFrame_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FTPModeFrame_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FTPModeFrame");
			return;
		}
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, DisplayName_Offset), DisplayName);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, TargetAKB_Offset), TargetAKB);
	}

	public FTPModeFrame(IntPtr nativeStruct)
	{
		if (FTPModeFrame_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FTPModeFrame");
			DisplayName = null;
			TargetAKB = null;
		}
		else
		{
			DisplayName = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, DisplayName_Offset));
			TargetAKB = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, TargetAKB_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FTPModeFrame");
		FTPModeFrame_StructSize = NativeReflection.GetStructSize(intPtr);
		DisplayName_Offset = NativeReflection.GetPropertyOffset(intPtr, "DisplayName");
		DisplayName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DisplayName", Classes.FTextProperty);
		TargetAKB_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetAKB");
		TargetAKB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetAKB", Classes.FStrProperty);
		FTPModeFrame_IsValid = ((intPtr != IntPtr.Zero && DisplayName_IsValid && TargetAKB_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FTPModeFrame", (byte)FTPModeFrame_IsValid != 0);
	}

	static FTPModeFrame()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTPModeFrame)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTPModeFrame));
	}
}
