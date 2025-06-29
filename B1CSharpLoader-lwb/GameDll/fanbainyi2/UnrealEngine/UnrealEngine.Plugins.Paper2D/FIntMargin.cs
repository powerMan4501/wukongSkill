using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Paper2D.IntMargin", "Paper2D", UnrealModuleType.EnginePlugin)]
public struct FIntMargin
{
	private static bool Left_IsValid;

	private static int Left_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Paper2D.IntMargin:Left")]
	public int Left;

	private static bool Top_IsValid;

	private static int Top_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Paper2D.IntMargin:Top")]
	public int Top;

	private static bool Right_IsValid;

	private static int Right_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Paper2D.IntMargin:Right")]
	public int Right;

	private static bool Bottom_IsValid;

	private static int Bottom_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Paper2D.IntMargin:Bottom")]
	public int Bottom;

	private static bool FIntMargin_IsValid;

	private static int FIntMargin_StructSize;

	public FIntMargin Copy()
	{
		return this;
	}

	public static FIntMargin FromNative(IntPtr nativeBuffer)
	{
		return new FIntMargin(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FIntMargin value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FIntMargin FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FIntMargin(nativeBuffer + arrayIndex * FIntMargin_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FIntMargin value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FIntMargin_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FIntMargin_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Paper2D.IntMargin");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Left_Offset), Left);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Top_Offset), Top);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Right_Offset), Right);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Bottom_Offset), Bottom);
	}

	public FIntMargin(IntPtr nativeStruct)
	{
		if (!FIntMargin_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Paper2D.IntMargin");
			Left = 0;
			Top = 0;
			Right = 0;
			Bottom = 0;
		}
		else
		{
			Left = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Left_Offset));
			Top = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Top_Offset));
			Right = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Right_Offset));
			Bottom = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Bottom_Offset));
		}
	}

	static FIntMargin()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FIntMargin)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FIntMargin));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Paper2D.IntMargin");
		FIntMargin_StructSize = NativeReflection.GetStructSize(intPtr);
		Left_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Left");
		Left_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Left", Classes.FIntProperty);
		Top_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Top");
		Top_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Top", Classes.FIntProperty);
		Right_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Right");
		Right_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Right", Classes.FIntProperty);
		Bottom_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Bottom");
		Bottom_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Bottom", Classes.FIntProperty);
		FIntMargin_IsValid = intPtr != IntPtr.Zero && Left_IsValid && Top_IsValid && Right_IsValid && Bottom_IsValid;
		NativeReflection.LogStructIsValid("/Script/Paper2D.IntMargin", FIntMargin_IsValid);
	}
}
