using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.TableViewStyle", "SlateCore", UnrealModuleType.Engine)]
public struct FTableViewStyle
{
	private static bool BackgroundBrush_IsValid;

	private static int BackgroundBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.TableViewStyle:BackgroundBrush")]
	public FSlateBrush BackgroundBrush;

	private static bool FTableViewStyle_IsValid;

	private static int FTableViewStyle_StructSize;

	public FTableViewStyle Copy()
	{
		return this;
	}

	public static FTableViewStyle FromNative(IntPtr nativeBuffer)
	{
		return new FTableViewStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTableViewStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTableViewStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTableViewStyle(nativeBuffer + arrayIndex * FTableViewStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTableViewStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTableViewStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTableViewStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.TableViewStyle");
		}
		else
		{
			FSlateBrush.ToNative(IntPtr.Add(nativeStruct, BackgroundBrush_Offset), BackgroundBrush);
		}
	}

	public FTableViewStyle(IntPtr nativeStruct)
	{
		if (!FTableViewStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.TableViewStyle");
			BackgroundBrush = default(FSlateBrush);
		}
		else
		{
			BackgroundBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, BackgroundBrush_Offset));
		}
	}

	static FTableViewStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTableViewStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTableViewStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.TableViewStyle");
		FTableViewStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		BackgroundBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackgroundBrush");
		BackgroundBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackgroundBrush", Classes.FStructProperty);
		FTableViewStyle_IsValid = intPtr != IntPtr.Zero && BackgroundBrush_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.TableViewStyle", FTableViewStyle_IsValid);
	}
}
