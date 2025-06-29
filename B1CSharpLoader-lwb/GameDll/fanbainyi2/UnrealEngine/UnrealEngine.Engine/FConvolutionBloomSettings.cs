using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.ConvolutionBloomSettings", "Engine", UnrealModuleType.Engine)]
public struct FConvolutionBloomSettings
{
	private static bool Texture_IsValid;

	private static int Texture_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.ConvolutionBloomSettings:Texture")]
	public UTexture2D Texture;

	private static bool ScatterDispersion_IsValid;

	private static int ScatterDispersion_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.ConvolutionBloomSettings:ScatterDispersion")]
	public float ScatterDispersion;

	private static bool Size_IsValid;

	private static int Size_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.ConvolutionBloomSettings:Size")]
	public float Size;

	private static bool CenterUV_IsValid;

	private static int CenterUV_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.ConvolutionBloomSettings:CenterUV")]
	public FVector2D CenterUV;

	private static bool PreFilterMin_IsValid;

	private static int PreFilterMin_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.ConvolutionBloomSettings:PreFilterMin")]
	public float PreFilterMin;

	private static bool PreFilterMax_IsValid;

	private static int PreFilterMax_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.ConvolutionBloomSettings:PreFilterMax")]
	public float PreFilterMax;

	private static bool PreFilterMult_IsValid;

	private static int PreFilterMult_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.ConvolutionBloomSettings:PreFilterMult")]
	public float PreFilterMult;

	private static bool BufferScale_IsValid;

	private static int BufferScale_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.ConvolutionBloomSettings:BufferScale")]
	public float BufferScale;

	private static bool FConvolutionBloomSettings_IsValid;

	private static int FConvolutionBloomSettings_StructSize;

	public FConvolutionBloomSettings Copy()
	{
		return this;
	}

	public static FConvolutionBloomSettings FromNative(IntPtr nativeBuffer)
	{
		return new FConvolutionBloomSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FConvolutionBloomSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FConvolutionBloomSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FConvolutionBloomSettings(nativeBuffer + arrayIndex * FConvolutionBloomSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FConvolutionBloomSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FConvolutionBloomSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FConvolutionBloomSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ConvolutionBloomSettings");
			return;
		}
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(nativeStruct, Texture_Offset), Texture);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ScatterDispersion_Offset), ScatterDispersion);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Size_Offset), Size);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, CenterUV_Offset), CenterUV);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PreFilterMin_Offset), PreFilterMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PreFilterMax_Offset), PreFilterMax);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PreFilterMult_Offset), PreFilterMult);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BufferScale_Offset), BufferScale);
	}

	public FConvolutionBloomSettings(IntPtr nativeStruct)
	{
		if (!FConvolutionBloomSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ConvolutionBloomSettings");
			Texture = null;
			ScatterDispersion = 0f;
			Size = 0f;
			CenterUV = default(FVector2D);
			PreFilterMin = 0f;
			PreFilterMax = 0f;
			PreFilterMult = 0f;
			BufferScale = 0f;
		}
		else
		{
			Texture = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(nativeStruct, Texture_Offset));
			ScatterDispersion = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ScatterDispersion_Offset));
			Size = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Size_Offset));
			CenterUV = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, CenterUV_Offset));
			PreFilterMin = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PreFilterMin_Offset));
			PreFilterMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PreFilterMax_Offset));
			PreFilterMult = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PreFilterMult_Offset));
			BufferScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BufferScale_Offset));
		}
	}

	static FConvolutionBloomSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FConvolutionBloomSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FConvolutionBloomSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.ConvolutionBloomSettings");
		FConvolutionBloomSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		Texture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Texture");
		Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Texture", Classes.FObjectProperty);
		ScatterDispersion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScatterDispersion");
		ScatterDispersion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScatterDispersion", Classes.FFloatProperty);
		Size_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Size");
		Size_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Size", Classes.FFloatProperty);
		CenterUV_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CenterUV");
		CenterUV_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CenterUV", Classes.FStructProperty);
		PreFilterMin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PreFilterMin");
		PreFilterMin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PreFilterMin", Classes.FFloatProperty);
		PreFilterMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PreFilterMax");
		PreFilterMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PreFilterMax", Classes.FFloatProperty);
		PreFilterMult_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PreFilterMult");
		PreFilterMult_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PreFilterMult", Classes.FFloatProperty);
		BufferScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BufferScale");
		BufferScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BufferScale", Classes.FFloatProperty);
		FConvolutionBloomSettings_IsValid = intPtr != IntPtr.Zero && Texture_IsValid && ScatterDispersion_IsValid && Size_IsValid && CenterUV_IsValid && PreFilterMin_IsValid && PreFilterMax_IsValid && PreFilterMult_IsValid && BufferScale_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.ConvolutionBloomSettings", FConvolutionBloomSettings_IsValid);
	}
}
