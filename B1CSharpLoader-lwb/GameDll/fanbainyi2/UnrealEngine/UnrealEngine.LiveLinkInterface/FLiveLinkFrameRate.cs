using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkFrameRate", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkFrameRate
{
	private static bool Numerator_IsValid;

	private static int Numerator_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.FrameRate:Numerator")]
	public int Numerator;

	private static bool Denominator_IsValid;

	private static int Denominator_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.FrameRate:Denominator")]
	public int Denominator;

	private static bool FLiveLinkFrameRate_IsValid;

	private static int FLiveLinkFrameRate_StructSize;

	public FLiveLinkFrameRate Copy()
	{
		return this;
	}

	public static FLiveLinkFrameRate FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkFrameRate(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkFrameRate value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkFrameRate FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkFrameRate(nativeBuffer + arrayIndex * FLiveLinkFrameRate_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkFrameRate value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkFrameRate_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkFrameRate_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkFrameRate");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Numerator_Offset), Numerator);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Denominator_Offset), Denominator);
	}

	public FLiveLinkFrameRate(IntPtr nativeStruct)
	{
		if (!FLiveLinkFrameRate_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkFrameRate");
			Numerator = 0;
			Denominator = 0;
		}
		else
		{
			Numerator = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Numerator_Offset));
			Denominator = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Denominator_Offset));
		}
	}

	static FLiveLinkFrameRate()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkFrameRate)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkFrameRate));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkFrameRate");
		FLiveLinkFrameRate_StructSize = NativeReflection.GetStructSize(intPtr);
		Numerator_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Numerator");
		Numerator_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Numerator", Classes.FIntProperty);
		Denominator_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Denominator");
		Denominator_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Denominator", Classes.FIntProperty);
		FLiveLinkFrameRate_IsValid = intPtr != IntPtr.Zero && Numerator_IsValid && Denominator_IsValid;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkFrameRate", FLiveLinkFrameRate_IsValid);
	}
}
