using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.CanvasIcon", "Engine", UnrealModuleType.Engine)]
public struct FCanvasIcon
{
	private static bool Texture_IsValid;

	private static int Texture_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.CanvasIcon:Texture")]
	public UTexture Texture;

	private static bool U_IsValid;

	private static int U_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CanvasIcon:U")]
	public float U;

	private static bool V_IsValid;

	private static int V_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CanvasIcon:V")]
	public float V;

	private static bool UL_IsValid;

	private static int UL_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CanvasIcon:UL")]
	public float UL;

	private static bool VL_IsValid;

	private static int VL_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CanvasIcon:VL")]
	public float VL;

	private static bool FCanvasIcon_IsValid;

	private static int FCanvasIcon_StructSize;

	public FCanvasIcon Copy()
	{
		return this;
	}

	public static FCanvasIcon FromNative(IntPtr nativeBuffer)
	{
		return new FCanvasIcon(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCanvasIcon value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCanvasIcon FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCanvasIcon(nativeBuffer + arrayIndex * FCanvasIcon_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCanvasIcon value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCanvasIcon_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCanvasIcon_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CanvasIcon");
			return;
		}
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(nativeStruct, Texture_Offset), Texture);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, U_Offset), U);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, V_Offset), V);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, UL_Offset), UL);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, VL_Offset), VL);
	}

	public FCanvasIcon(IntPtr nativeStruct)
	{
		if (!FCanvasIcon_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CanvasIcon");
			Texture = null;
			U = 0f;
			V = 0f;
			UL = 0f;
			VL = 0f;
		}
		else
		{
			Texture = UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(nativeStruct, Texture_Offset));
			U = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, U_Offset));
			V = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, V_Offset));
			UL = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, UL_Offset));
			VL = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, VL_Offset));
		}
	}

	static FCanvasIcon()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCanvasIcon)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCanvasIcon));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CanvasIcon");
		FCanvasIcon_StructSize = NativeReflection.GetStructSize(intPtr);
		Texture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Texture");
		Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Texture", Classes.FObjectProperty);
		U_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "U");
		U_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "U", Classes.FFloatProperty);
		V_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "V");
		V_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "V", Classes.FFloatProperty);
		UL_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UL");
		UL_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UL", Classes.FFloatProperty);
		VL_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VL");
		VL_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VL", Classes.FFloatProperty);
		FCanvasIcon_IsValid = intPtr != IntPtr.Zero && Texture_IsValid && U_IsValid && V_IsValid && UL_IsValid && VL_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.CanvasIcon", FCanvasIcon_IsValid);
	}
}
