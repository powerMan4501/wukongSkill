using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.StreamingSourceShape", "Engine", UnrealModuleType.Engine)]
public struct FStreamingSourceShape
{
	private static bool UseGridLoadingRange_IsValid;

	private static FFieldAddress UseGridLoadingRange_PropertyAddress;

	private static int UseGridLoadingRange_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.StreamingSourceShape:bUseGridLoadingRange")]
	public bool UseGridLoadingRange;

	private static bool Radius_IsValid;

	private static int Radius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.StreamingSourceShape:Radius")]
	public float Radius;

	private static bool IsSector_IsValid;

	private static FFieldAddress IsSector_PropertyAddress;

	private static int IsSector_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.StreamingSourceShape:bIsSector")]
	public bool IsSector;

	private static bool SectorAngle_IsValid;

	private static int SectorAngle_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.StreamingSourceShape:SectorAngle")]
	public float SectorAngle;

	private static bool Location_IsValid;

	private static int Location_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.StreamingSourceShape:Location")]
	public FVector Location;

	private static bool Rotation_IsValid;

	private static int Rotation_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/Engine.StreamingSourceShape:Rotation")]
	public FRotator Rotation;

	private static bool FStreamingSourceShape_IsValid;

	private static int FStreamingSourceShape_StructSize;

	public FStreamingSourceShape Copy()
	{
		return this;
	}

	public static FStreamingSourceShape FromNative(IntPtr nativeBuffer)
	{
		return new FStreamingSourceShape(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FStreamingSourceShape value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FStreamingSourceShape FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FStreamingSourceShape(nativeBuffer + arrayIndex * FStreamingSourceShape_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FStreamingSourceShape value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FStreamingSourceShape_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FStreamingSourceShape_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.StreamingSourceShape");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseGridLoadingRange_Offset), 0, UseGridLoadingRange_PropertyAddress.Address, UseGridLoadingRange);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Radius_Offset), Radius);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsSector_Offset), 0, IsSector_PropertyAddress.Address, IsSector);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SectorAngle_Offset), SectorAngle);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, Rotation_Offset), Rotation);
	}

	public FStreamingSourceShape(IntPtr nativeStruct)
	{
		if (!FStreamingSourceShape_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.StreamingSourceShape");
			UseGridLoadingRange = false;
			Radius = 0f;
			IsSector = false;
			SectorAngle = 0f;
			Location = default(FVector);
			Rotation = default(FRotator);
		}
		else
		{
			UseGridLoadingRange = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseGridLoadingRange_Offset), 0, UseGridLoadingRange_PropertyAddress.Address);
			Radius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Radius_Offset));
			IsSector = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsSector_Offset), 0, IsSector_PropertyAddress.Address);
			SectorAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SectorAngle_Offset));
			Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
			Rotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, Rotation_Offset));
		}
	}

	static FStreamingSourceShape()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FStreamingSourceShape)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FStreamingSourceShape));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.StreamingSourceShape");
		FStreamingSourceShape_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref UseGridLoadingRange_PropertyAddress, intPtr, "bUseGridLoadingRange");
		UseGridLoadingRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseGridLoadingRange");
		UseGridLoadingRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseGridLoadingRange", Classes.FBoolProperty);
		Radius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Radius");
		Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSector_PropertyAddress, intPtr, "bIsSector");
		IsSector_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsSector");
		IsSector_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsSector", Classes.FBoolProperty);
		SectorAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SectorAngle");
		SectorAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SectorAngle", Classes.FFloatProperty);
		Location_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Location", Classes.FStructProperty);
		Rotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Rotation");
		Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Rotation", Classes.FStructProperty);
		FStreamingSourceShape_IsValid = intPtr != IntPtr.Zero && UseGridLoadingRange_IsValid && Radius_IsValid && IsSector_IsValid && SectorAngle_IsValid && Location_IsValid && Rotation_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.StreamingSourceShape", FStreamingSourceShape_IsValid);
	}
}
