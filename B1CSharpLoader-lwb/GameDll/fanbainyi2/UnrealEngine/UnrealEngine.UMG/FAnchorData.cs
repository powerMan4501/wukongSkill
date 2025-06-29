using System;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UMG.AnchorData", "UMG", UnrealModuleType.Engine)]
public struct FAnchorData
{
	private static bool Offsets_IsValid;

	private static int Offsets_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/UMG.AnchorData:Offsets")]
	public FMargin Offsets;

	private static bool Anchors_IsValid;

	private static int Anchors_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/UMG.AnchorData:Anchors")]
	public FAnchors Anchors;

	private static bool Alignment_IsValid;

	private static int Alignment_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMG.AnchorData:Alignment")]
	public FVector2D Alignment;

	private static bool FAnchorData_IsValid;

	private static int FAnchorData_StructSize;

	public FAnchorData Copy()
	{
		return this;
	}

	public static FAnchorData FromNative(IntPtr nativeBuffer)
	{
		return new FAnchorData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnchorData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnchorData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnchorData(nativeBuffer + arrayIndex * FAnchorData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnchorData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnchorData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnchorData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMG.AnchorData");
			return;
		}
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(nativeStruct, Offsets_Offset), Offsets);
		FAnchors.ToNative(IntPtr.Add(nativeStruct, Anchors_Offset), Anchors);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, Alignment_Offset), Alignment);
	}

	public FAnchorData(IntPtr nativeStruct)
	{
		if (!FAnchorData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMG.AnchorData");
			Offsets = default(FMargin);
			Anchors = default(FAnchors);
			Alignment = default(FVector2D);
		}
		else
		{
			Offsets = BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(nativeStruct, Offsets_Offset));
			Anchors = FAnchors.FromNative(IntPtr.Add(nativeStruct, Anchors_Offset));
			Alignment = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, Alignment_Offset));
		}
	}

	static FAnchorData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnchorData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnchorData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UMG.AnchorData");
		FAnchorData_StructSize = NativeReflection.GetStructSize(intPtr);
		Offsets_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Offsets");
		Offsets_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Offsets", Classes.FStructProperty);
		Anchors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Anchors");
		Anchors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Anchors", Classes.FStructProperty);
		Alignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Alignment");
		Alignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Alignment", Classes.FStructProperty);
		FAnchorData_IsValid = intPtr != IntPtr.Zero && Offsets_IsValid && Anchors_IsValid && Alignment_IsValid;
		NativeReflection.LogStructIsValid("/Script/UMG.AnchorData", FAnchorData_IsValid);
	}
}
