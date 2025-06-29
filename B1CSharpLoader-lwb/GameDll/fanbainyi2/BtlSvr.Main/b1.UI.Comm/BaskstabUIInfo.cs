using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI.Comm;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BaskstabUIInfo")]
public struct BaskstabUIInfo
{
	[BlueprintReadWrite]
	[Category("Backstab")]
	[DisplayName("ImgA")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BaskstabUIInfo:BackstabMatArrayA")]
	public UMaterialInstance BackstabMatArrayA;

	[DisplayName("ImgB")]
	[Category("Backstab")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BaskstabUIInfo:BackstabMatArrayB")]
	public UMaterialInstance BackstabMatArrayB;

	private static int BaskstabUIInfo_StructSize;

	private static int BaskstabUIInfo_IsValid;

	private static bool BackstabMatArrayA_IsValid;

	private static int BackstabMatArrayA_Offset;

	private static bool BackstabMatArrayB_IsValid;

	private static int BackstabMatArrayB_Offset;

	public BaskstabUIInfo Copy()
	{
		return this;
	}

	public static BaskstabUIInfo FromNative(IntPtr nativeBuffer)
	{
		return new BaskstabUIInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BaskstabUIInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BaskstabUIInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BaskstabUIInfo(IntPtr.Add(nativeBuffer, arrayIndex * BaskstabUIInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BaskstabUIInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BaskstabUIInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BaskstabUIInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BaskstabUIInfo");
			return;
		}
		UObjectMarshaler<UMaterialInstance>.ToNative(IntPtr.Add(nativeStruct, BackstabMatArrayA_Offset), BackstabMatArrayA);
		UObjectMarshaler<UMaterialInstance>.ToNative(IntPtr.Add(nativeStruct, BackstabMatArrayB_Offset), BackstabMatArrayB);
	}

	public BaskstabUIInfo(IntPtr nativeStruct)
	{
		if (BaskstabUIInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BaskstabUIInfo");
			BackstabMatArrayA = null;
			BackstabMatArrayB = null;
		}
		else
		{
			BackstabMatArrayA = UObjectMarshaler<UMaterialInstance>.FromNative(IntPtr.Add(nativeStruct, BackstabMatArrayA_Offset));
			BackstabMatArrayB = UObjectMarshaler<UMaterialInstance>.FromNative(IntPtr.Add(nativeStruct, BackstabMatArrayB_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BaskstabUIInfo");
		BaskstabUIInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		BackstabMatArrayA_Offset = NativeReflection.GetPropertyOffset(intPtr, "BackstabMatArrayA");
		BackstabMatArrayA_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BackstabMatArrayA", Classes.FObjectProperty);
		BackstabMatArrayB_Offset = NativeReflection.GetPropertyOffset(intPtr, "BackstabMatArrayB");
		BackstabMatArrayB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BackstabMatArrayB", Classes.FObjectProperty);
		BaskstabUIInfo_IsValid = ((intPtr != IntPtr.Zero && BackstabMatArrayA_IsValid && BackstabMatArrayB_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BaskstabUIInfo", (byte)BaskstabUIInfo_IsValid != 0);
	}

	static BaskstabUIInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BaskstabUIInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BaskstabUIInfo));
	}
}
