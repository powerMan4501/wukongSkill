using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.TileItemConfig")]
public struct FTileItemConfig
{
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TileItemConfig:Size")]
	public FVector2D Size;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TileItemConfig:Spacer")]
	public FVector2D Spacer;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TileItemConfig:ItemPath")]
	public string ItemPath;

	private static int TileItemConfig_StructSize;

	private static int TileItemConfig_IsValid;

	private static bool Size_IsValid;

	private static int Size_Offset;

	private static bool Spacer_IsValid;

	private static int Spacer_Offset;

	private static bool ItemPath_IsValid;

	private static int ItemPath_Offset;

	public FTileItemConfig Copy()
	{
		return this;
	}

	public static FTileItemConfig FromNative(IntPtr nativeBuffer)
	{
		return new FTileItemConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTileItemConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTileItemConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTileItemConfig(IntPtr.Add(nativeBuffer, arrayIndex * TileItemConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTileItemConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TileItemConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TileItemConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TileItemConfig");
			return;
		}
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, Size_Offset), Size);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, Spacer_Offset), Spacer);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ItemPath_Offset), ItemPath);
	}

	public FTileItemConfig(IntPtr nativeStruct)
	{
		if (TileItemConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TileItemConfig");
			Size = default(FVector2D);
			Spacer = default(FVector2D);
			ItemPath = null;
		}
		else
		{
			Size = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, Size_Offset));
			Spacer = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, Spacer_Offset));
			ItemPath = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ItemPath_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TileItemConfig");
		TileItemConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		Size_Offset = NativeReflection.GetPropertyOffset(intPtr, "Size");
		Size_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Size", Classes.FStructProperty);
		Spacer_Offset = NativeReflection.GetPropertyOffset(intPtr, "Spacer");
		Spacer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Spacer", Classes.FStructProperty);
		ItemPath_Offset = NativeReflection.GetPropertyOffset(intPtr, "ItemPath");
		ItemPath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ItemPath", Classes.FStrProperty);
		TileItemConfig_IsValid = ((intPtr != IntPtr.Zero && Size_IsValid && Spacer_IsValid && ItemPath_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TileItemConfig", (byte)TileItemConfig_IsValid != 0);
	}

	static FTileItemConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTileItemConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTileItemConfig));
	}
}
