using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.CanvasUVTri", "Engine", UnrealModuleType.Engine)]
public struct FCanvasUVTri
{
	private static bool V0_Pos_IsValid;

	private static int V0_Pos_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CanvasUVTri:V0_Pos")]
	public FVector2D V0_Pos;

	private static bool V0_UV_IsValid;

	private static int V0_UV_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CanvasUVTri:V0_UV")]
	public FVector2D V0_UV;

	private static bool V0_Color_IsValid;

	private static int V0_Color_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CanvasUVTri:V0_Color")]
	public FLinearColor V0_Color;

	private static bool V1_Pos_IsValid;

	private static int V1_Pos_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CanvasUVTri:V1_Pos")]
	public FVector2D V1_Pos;

	private static bool V1_UV_IsValid;

	private static int V1_UV_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CanvasUVTri:V1_UV")]
	public FVector2D V1_UV;

	private static bool V1_Color_IsValid;

	private static int V1_Color_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CanvasUVTri:V1_Color")]
	public FLinearColor V1_Color;

	private static bool V2_Pos_IsValid;

	private static int V2_Pos_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CanvasUVTri:V2_Pos")]
	public FVector2D V2_Pos;

	private static bool V2_UV_IsValid;

	private static int V2_UV_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CanvasUVTri:V2_UV")]
	public FVector2D V2_UV;

	private static bool V2_Color_IsValid;

	private static int V2_Color_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CanvasUVTri:V2_Color")]
	public FLinearColor V2_Color;

	private static bool FCanvasUVTri_IsValid;

	private static int FCanvasUVTri_StructSize;

	public FCanvasUVTri Copy()
	{
		return this;
	}

	public static FCanvasUVTri FromNative(IntPtr nativeBuffer)
	{
		return new FCanvasUVTri(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCanvasUVTri value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCanvasUVTri FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCanvasUVTri(nativeBuffer + arrayIndex * FCanvasUVTri_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCanvasUVTri value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCanvasUVTri_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCanvasUVTri_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CanvasUVTri");
			return;
		}
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, V0_Pos_Offset), V0_Pos);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, V0_UV_Offset), V0_UV);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, V0_Color_Offset), V0_Color);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, V1_Pos_Offset), V1_Pos);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, V1_UV_Offset), V1_UV);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, V1_Color_Offset), V1_Color);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, V2_Pos_Offset), V2_Pos);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, V2_UV_Offset), V2_UV);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, V2_Color_Offset), V2_Color);
	}

	public FCanvasUVTri(IntPtr nativeStruct)
	{
		if (!FCanvasUVTri_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CanvasUVTri");
			V0_Pos = default(FVector2D);
			V0_UV = default(FVector2D);
			V0_Color = default(FLinearColor);
			V1_Pos = default(FVector2D);
			V1_UV = default(FVector2D);
			V1_Color = default(FLinearColor);
			V2_Pos = default(FVector2D);
			V2_UV = default(FVector2D);
			V2_Color = default(FLinearColor);
		}
		else
		{
			V0_Pos = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, V0_Pos_Offset));
			V0_UV = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, V0_UV_Offset));
			V0_Color = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, V0_Color_Offset));
			V1_Pos = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, V1_Pos_Offset));
			V1_UV = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, V1_UV_Offset));
			V1_Color = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, V1_Color_Offset));
			V2_Pos = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, V2_Pos_Offset));
			V2_UV = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, V2_UV_Offset));
			V2_Color = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, V2_Color_Offset));
		}
	}

	static FCanvasUVTri()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCanvasUVTri)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCanvasUVTri));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CanvasUVTri");
		FCanvasUVTri_StructSize = NativeReflection.GetStructSize(intPtr);
		V0_Pos_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "V0_Pos");
		V0_Pos_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "V0_Pos", Classes.FStructProperty);
		V0_UV_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "V0_UV");
		V0_UV_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "V0_UV", Classes.FStructProperty);
		V0_Color_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "V0_Color");
		V0_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "V0_Color", Classes.FStructProperty);
		V1_Pos_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "V1_Pos");
		V1_Pos_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "V1_Pos", Classes.FStructProperty);
		V1_UV_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "V1_UV");
		V1_UV_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "V1_UV", Classes.FStructProperty);
		V1_Color_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "V1_Color");
		V1_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "V1_Color", Classes.FStructProperty);
		V2_Pos_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "V2_Pos");
		V2_Pos_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "V2_Pos", Classes.FStructProperty);
		V2_UV_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "V2_UV");
		V2_UV_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "V2_UV", Classes.FStructProperty);
		V2_Color_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "V2_Color");
		V2_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "V2_Color", Classes.FStructProperty);
		FCanvasUVTri_IsValid = intPtr != IntPtr.Zero && V0_Pos_IsValid && V0_UV_IsValid && V0_Color_IsValid && V1_Pos_IsValid && V1_UV_IsValid && V1_Color_IsValid && V2_Pos_IsValid && V2_UV_IsValid && V2_Color_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.CanvasUVTri", FCanvasUVTri_IsValid);
	}
}
