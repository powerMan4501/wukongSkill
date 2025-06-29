using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Slate;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Slate.Anchors", "Slate", UnrealModuleType.Engine)]
public struct FAnchors
{
	private static bool Minimum_IsValid;

	private static int Minimum_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Slate.Anchors:Minimum")]
	public FVector2D Minimum;

	private static bool Maximum_IsValid;

	private static int Maximum_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Slate.Anchors:Maximum")]
	public FVector2D Maximum;

	private static bool FAnchors_IsValid;

	private static int FAnchors_StructSize;

	public FAnchors Copy()
	{
		return this;
	}

	public static FAnchors FromNative(IntPtr nativeBuffer)
	{
		return new FAnchors(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnchors value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnchors FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnchors(nativeBuffer + arrayIndex * FAnchors_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnchors value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnchors_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnchors_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Slate.Anchors");
			return;
		}
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, Minimum_Offset), Minimum);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, Maximum_Offset), Maximum);
	}

	public FAnchors(IntPtr nativeStruct)
	{
		if (!FAnchors_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Slate.Anchors");
			Minimum = default(FVector2D);
			Maximum = default(FVector2D);
		}
		else
		{
			Minimum = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, Minimum_Offset));
			Maximum = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, Maximum_Offset));
		}
	}

	static FAnchors()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnchors)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnchors));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Slate.Anchors");
		FAnchors_StructSize = NativeReflection.GetStructSize(intPtr);
		Minimum_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Minimum");
		Minimum_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Minimum", Classes.FStructProperty);
		Maximum_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Maximum");
		Maximum_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Maximum", Classes.FStructProperty);
		FAnchors_IsValid = intPtr != IntPtr.Zero && Minimum_IsValid && Maximum_IsValid;
		NativeReflection.LogStructIsValid("/Script/Slate.Anchors", FAnchors_IsValid);
	}
}
