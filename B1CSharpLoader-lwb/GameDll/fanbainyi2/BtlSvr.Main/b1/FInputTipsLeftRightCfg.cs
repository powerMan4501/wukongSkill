using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.InputTipsLeftRightCfg")]
public struct FInputTipsLeftRightCfg
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("左侧底部栏Tips")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.InputTipsLeftRightCfg:LeftInputTipsCfg")]
	public FInputTipsCfg LeftInputTipsCfg;

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("右侧底部栏Tips")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.InputTipsLeftRightCfg:RightInputTipsCfg")]
	public FInputTipsCfg RightInputTipsCfg;

	private static int InputTipsLeftRightCfg_StructSize;

	private static int InputTipsLeftRightCfg_IsValid;

	private static bool LeftInputTipsCfg_IsValid;

	private static int LeftInputTipsCfg_Offset;

	private static bool RightInputTipsCfg_IsValid;

	private static int RightInputTipsCfg_Offset;

	public FInputTipsLeftRightCfg Copy()
	{
		return this;
	}

	public static FInputTipsLeftRightCfg FromNative(IntPtr nativeBuffer)
	{
		return new FInputTipsLeftRightCfg(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInputTipsLeftRightCfg value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInputTipsLeftRightCfg FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInputTipsLeftRightCfg(IntPtr.Add(nativeBuffer, arrayIndex * InputTipsLeftRightCfg_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInputTipsLeftRightCfg value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * InputTipsLeftRightCfg_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (InputTipsLeftRightCfg_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.InputTipsLeftRightCfg");
			return;
		}
		FInputTipsCfg.ToNative(IntPtr.Add(nativeStruct, LeftInputTipsCfg_Offset), LeftInputTipsCfg);
		FInputTipsCfg.ToNative(IntPtr.Add(nativeStruct, RightInputTipsCfg_Offset), RightInputTipsCfg);
	}

	public FInputTipsLeftRightCfg(IntPtr nativeStruct)
	{
		if (InputTipsLeftRightCfg_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.InputTipsLeftRightCfg");
			LeftInputTipsCfg = default(FInputTipsCfg);
			RightInputTipsCfg = default(FInputTipsCfg);
		}
		else
		{
			LeftInputTipsCfg = FInputTipsCfg.FromNative(IntPtr.Add(nativeStruct, LeftInputTipsCfg_Offset));
			RightInputTipsCfg = FInputTipsCfg.FromNative(IntPtr.Add(nativeStruct, RightInputTipsCfg_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.InputTipsLeftRightCfg");
		InputTipsLeftRightCfg_StructSize = NativeReflection.GetStructSize(intPtr);
		LeftInputTipsCfg_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeftInputTipsCfg");
		LeftInputTipsCfg_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeftInputTipsCfg", Classes.FStructProperty);
		RightInputTipsCfg_Offset = NativeReflection.GetPropertyOffset(intPtr, "RightInputTipsCfg");
		RightInputTipsCfg_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RightInputTipsCfg", Classes.FStructProperty);
		InputTipsLeftRightCfg_IsValid = ((intPtr != IntPtr.Zero && LeftInputTipsCfg_IsValid && RightInputTipsCfg_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.InputTipsLeftRightCfg", (byte)InputTipsLeftRightCfg_IsValid != 0);
	}

	static FInputTipsLeftRightCfg()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FInputTipsLeftRightCfg)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInputTipsLeftRightCfg));
	}
}
