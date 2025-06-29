using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.StaticMeshDescription;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/StaticMeshDescription.UVMapSettings", "StaticMeshDescription", UnrealModuleType.Engine)]
public struct FUVMapSettings
{
	private static bool Size_IsValid;

	private static int Size_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/StaticMeshDescription.UVMapSettings:Size")]
	public FVector Size;

	private static bool UVTile_IsValid;

	private static int UVTile_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/StaticMeshDescription.UVMapSettings:UVTile")]
	public FVector2D UVTile;

	private static bool Position_IsValid;

	private static int Position_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/StaticMeshDescription.UVMapSettings:Position")]
	public FVector Position;

	private static bool Rotation_IsValid;

	private static int Rotation_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/StaticMeshDescription.UVMapSettings:Rotation")]
	public FRotator Rotation;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/StaticMeshDescription.UVMapSettings:Scale")]
	public FVector Scale;

	private static bool FUVMapSettings_IsValid;

	private static int FUVMapSettings_StructSize;

	public FUVMapSettings Copy()
	{
		return this;
	}

	public static FUVMapSettings FromNative(IntPtr nativeBuffer)
	{
		return new FUVMapSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUVMapSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUVMapSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUVMapSettings(nativeBuffer + arrayIndex * FUVMapSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUVMapSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FUVMapSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FUVMapSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/StaticMeshDescription.UVMapSettings");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Size_Offset), Size);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, UVTile_Offset), UVTile);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Position_Offset), Position);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, Rotation_Offset), Rotation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), Scale);
	}

	public FUVMapSettings(IntPtr nativeStruct)
	{
		if (!FUVMapSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/StaticMeshDescription.UVMapSettings");
			Size = default(FVector);
			UVTile = default(FVector2D);
			Position = default(FVector);
			Rotation = default(FRotator);
			Scale = default(FVector);
		}
		else
		{
			Size = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Size_Offset));
			UVTile = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, UVTile_Offset));
			Position = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Position_Offset));
			Rotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, Rotation_Offset));
			Scale = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Scale_Offset));
		}
	}

	static FUVMapSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FUVMapSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUVMapSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/StaticMeshDescription.UVMapSettings");
		FUVMapSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		Size_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Size");
		Size_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Size", Classes.FStructProperty);
		UVTile_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UVTile");
		UVTile_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UVTile", Classes.FStructProperty);
		Position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Position");
		Position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Position", Classes.FStructProperty);
		Rotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Rotation");
		Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Rotation", Classes.FStructProperty);
		Scale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Scale", Classes.FStructProperty);
		FUVMapSettings_IsValid = intPtr != IntPtr.Zero && Size_IsValid && UVTile_IsValid && Position_IsValid && Rotation_IsValid && Scale_IsValid;
		NativeReflection.LogStructIsValid("/Script/StaticMeshDescription.UVMapSettings", FUVMapSettings_IsValid);
	}
}
