using System;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1.UI;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.InputBrushStruct")]
public struct InputBrushStruct
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.InputBrushStruct:ImgIconBGBrush")]
	public FSlateBrush ImgIconBGBrush;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.InputBrushStruct:ImgProgBarBrush")]
	public FSlateBrush ImgProgBarBrush;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.InputBrushStruct:ImgProgressBrush")]
	public FSlateBrush ImgProgressBrush;

	private static int InputBrushStruct_StructSize;

	private static int InputBrushStruct_IsValid;

	private static bool ImgIconBGBrush_IsValid;

	private static int ImgIconBGBrush_Offset;

	private static bool ImgProgBarBrush_IsValid;

	private static int ImgProgBarBrush_Offset;

	private static bool ImgProgressBrush_IsValid;

	private static int ImgProgressBrush_Offset;

	public InputBrushStruct Copy()
	{
		return this;
	}

	public static InputBrushStruct FromNative(IntPtr nativeBuffer)
	{
		return new InputBrushStruct(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, InputBrushStruct value)
	{
		value.ToNative(nativeBuffer);
	}

	public static InputBrushStruct FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new InputBrushStruct(IntPtr.Add(nativeBuffer, arrayIndex * InputBrushStruct_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, InputBrushStruct value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * InputBrushStruct_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (InputBrushStruct_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.InputBrushStruct");
			return;
		}
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, ImgIconBGBrush_Offset), ImgIconBGBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, ImgProgBarBrush_Offset), ImgProgBarBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, ImgProgressBrush_Offset), ImgProgressBrush);
	}

	public InputBrushStruct(IntPtr nativeStruct)
	{
		if (InputBrushStruct_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.InputBrushStruct");
			ImgIconBGBrush = default(FSlateBrush);
			ImgProgBarBrush = default(FSlateBrush);
			ImgProgressBrush = default(FSlateBrush);
		}
		else
		{
			ImgIconBGBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, ImgIconBGBrush_Offset));
			ImgProgBarBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, ImgProgBarBrush_Offset));
			ImgProgressBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, ImgProgressBrush_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.InputBrushStruct");
		InputBrushStruct_StructSize = NativeReflection.GetStructSize(intPtr);
		ImgIconBGBrush_Offset = NativeReflection.GetPropertyOffset(intPtr, "ImgIconBGBrush");
		ImgIconBGBrush_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ImgIconBGBrush", Classes.FStructProperty);
		ImgProgBarBrush_Offset = NativeReflection.GetPropertyOffset(intPtr, "ImgProgBarBrush");
		ImgProgBarBrush_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ImgProgBarBrush", Classes.FStructProperty);
		ImgProgressBrush_Offset = NativeReflection.GetPropertyOffset(intPtr, "ImgProgressBrush");
		ImgProgressBrush_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ImgProgressBrush", Classes.FStructProperty);
		InputBrushStruct_IsValid = ((intPtr != IntPtr.Zero && ImgIconBGBrush_IsValid && ImgProgBarBrush_IsValid && ImgProgressBrush_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.InputBrushStruct", (byte)InputBrushStruct_IsValid != 0);
	}

	static InputBrushStruct()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(InputBrushStruct)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(InputBrushStruct));
	}
}
