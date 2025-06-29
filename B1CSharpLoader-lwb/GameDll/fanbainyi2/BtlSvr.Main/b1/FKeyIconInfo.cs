using System;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.KeyIconInfo")]
public struct FKeyIconInfo
{
	[DisplayName("按键")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.KeyIconInfo:Key")]
	public FKey Key;

	[UProperty]
	[DisplayName("图标偏移量")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.KeyIconInfo:Offset")]
	public float Offset;

	private static int KeyIconInfo_StructSize;

	private static int KeyIconInfo_IsValid;

	private static bool Key_IsValid;

	private static int Key_Offset;

	private static bool Offset_IsValid;

	private static int Offset_Offset;

	public FKeyIconInfo Copy()
	{
		return this;
	}

	public static FKeyIconInfo FromNative(IntPtr nativeBuffer)
	{
		return new FKeyIconInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FKeyIconInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FKeyIconInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FKeyIconInfo(IntPtr.Add(nativeBuffer, arrayIndex * KeyIconInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FKeyIconInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * KeyIconInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (KeyIconInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.KeyIconInfo");
			return;
		}
		FKey.ToNative(IntPtr.Add(nativeStruct, Key_Offset), Key);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Offset_Offset), Offset);
	}

	public FKeyIconInfo(IntPtr nativeStruct)
	{
		if (KeyIconInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.KeyIconInfo");
			Key = default(FKey);
			Offset = 0f;
		}
		else
		{
			Key = FKey.FromNative(IntPtr.Add(nativeStruct, Key_Offset));
			Offset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Offset_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.KeyIconInfo");
		KeyIconInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		Key_Offset = NativeReflection.GetPropertyOffset(intPtr, "Key");
		Key_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Key", Classes.FStructProperty);
		Offset_Offset = NativeReflection.GetPropertyOffset(intPtr, "Offset");
		Offset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Offset", Classes.FFloatProperty);
		KeyIconInfo_IsValid = ((intPtr != IntPtr.Zero && Key_IsValid && Offset_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.KeyIconInfo", (byte)KeyIconInfo_IsValid != 0);
	}

	static FKeyIconInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FKeyIconInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FKeyIconInfo));
	}
}
