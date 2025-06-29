using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Paper2D.PaperTileMetadata", "Paper2D", UnrealModuleType.EnginePlugin)]
public struct FPaperTileMetadata
{
	private static bool UserDataName_IsValid;

	private static int UserDataName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Paper2D.PaperTileMetadata:UserDataName")]
	public FName UserDataName;

	private static bool FPaperTileMetadata_IsValid;

	private static int FPaperTileMetadata_StructSize;

	public FPaperTileMetadata Copy()
	{
		return this;
	}

	public static FPaperTileMetadata FromNative(IntPtr nativeBuffer)
	{
		return new FPaperTileMetadata(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPaperTileMetadata value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPaperTileMetadata FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPaperTileMetadata(nativeBuffer + arrayIndex * FPaperTileMetadata_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPaperTileMetadata value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPaperTileMetadata_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPaperTileMetadata_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Paper2D.PaperTileMetadata");
		}
		else
		{
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, UserDataName_Offset), UserDataName);
		}
	}

	public FPaperTileMetadata(IntPtr nativeStruct)
	{
		if (!FPaperTileMetadata_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Paper2D.PaperTileMetadata");
			UserDataName = default(FName);
		}
		else
		{
			UserDataName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, UserDataName_Offset));
		}
	}

	static FPaperTileMetadata()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPaperTileMetadata)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPaperTileMetadata));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Paper2D.PaperTileMetadata");
		FPaperTileMetadata_StructSize = NativeReflection.GetStructSize(intPtr);
		UserDataName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UserDataName");
		UserDataName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UserDataName", Classes.FNameProperty);
		FPaperTileMetadata_IsValid = intPtr != IntPtr.Zero && UserDataName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Paper2D.PaperTileMetadata", FPaperTileMetadata_IsValid);
	}
}
