using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptDisplaceFromTextureOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptDisplaceFromTextureOptions
{
	private static bool Magnitude_IsValid;

	private static int Magnitude_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptDisplaceFromTextureOptions:Magnitude")]
	public float Magnitude;

	private static bool UVScale_IsValid;

	private static int UVScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptDisplaceFromTextureOptions:UVScale")]
	public FVector2D UVScale;

	private static bool UVOffset_IsValid;

	private static int UVOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptDisplaceFromTextureOptions:UVOffset")]
	public FVector2D UVOffset;

	private static bool Center_IsValid;

	private static int Center_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptDisplaceFromTextureOptions:Center")]
	public float Center;

	private static bool ImageChannel_IsValid;

	private static int ImageChannel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptDisplaceFromTextureOptions:ImageChannel")]
	public int ImageChannel;

	private static bool FGeometryScriptDisplaceFromTextureOptions_IsValid;

	private static int FGeometryScriptDisplaceFromTextureOptions_StructSize;

	public FGeometryScriptDisplaceFromTextureOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptDisplaceFromTextureOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptDisplaceFromTextureOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptDisplaceFromTextureOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptDisplaceFromTextureOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptDisplaceFromTextureOptions(nativeBuffer + arrayIndex * FGeometryScriptDisplaceFromTextureOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptDisplaceFromTextureOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptDisplaceFromTextureOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptDisplaceFromTextureOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptDisplaceFromTextureOptions");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Magnitude_Offset), Magnitude);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, UVScale_Offset), UVScale);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, UVOffset_Offset), UVOffset);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Center_Offset), Center);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ImageChannel_Offset), ImageChannel);
	}

	public FGeometryScriptDisplaceFromTextureOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptDisplaceFromTextureOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptDisplaceFromTextureOptions");
			Magnitude = 0f;
			UVScale = default(FVector2D);
			UVOffset = default(FVector2D);
			Center = 0f;
			ImageChannel = 0;
		}
		else
		{
			Magnitude = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Magnitude_Offset));
			UVScale = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, UVScale_Offset));
			UVOffset = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, UVOffset_Offset));
			Center = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Center_Offset));
			ImageChannel = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ImageChannel_Offset));
		}
	}

	static FGeometryScriptDisplaceFromTextureOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptDisplaceFromTextureOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptDisplaceFromTextureOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptDisplaceFromTextureOptions");
		FGeometryScriptDisplaceFromTextureOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Magnitude");
		Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Magnitude", Classes.FFloatProperty);
		UVScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UVScale");
		UVScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UVScale", Classes.FStructProperty);
		UVOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UVOffset");
		UVOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UVOffset", Classes.FStructProperty);
		Center_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Center");
		Center_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Center", Classes.FFloatProperty);
		ImageChannel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ImageChannel");
		ImageChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ImageChannel", Classes.FIntProperty);
		FGeometryScriptDisplaceFromTextureOptions_IsValid = intPtr != IntPtr.Zero && Magnitude_IsValid && UVScale_IsValid && UVOffset_IsValid && Center_IsValid && ImageChannel_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptDisplaceFromTextureOptions", FGeometryScriptDisplaceFromTextureOptions_IsValid);
	}
}
