using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MaterialEditor;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MaterialEditor.MaterialStatistics", "MaterialEditor", UnrealModuleType.Engine)]
public struct FMaterialStatistics
{
	private static bool NumVertexShaderInstructions_IsValid;

	private static int NumVertexShaderInstructions_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MaterialEditor.MaterialStatistics:NumVertexShaderInstructions")]
	public int NumVertexShaderInstructions;

	private static bool NumPixelShaderInstructions_IsValid;

	private static int NumPixelShaderInstructions_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MaterialEditor.MaterialStatistics:NumPixelShaderInstructions")]
	public int NumPixelShaderInstructions;

	private static bool NumSamplers_IsValid;

	private static int NumSamplers_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MaterialEditor.MaterialStatistics:NumSamplers")]
	public int NumSamplers;

	private static bool NumVertexTextureSamples_IsValid;

	private static int NumVertexTextureSamples_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MaterialEditor.MaterialStatistics:NumVertexTextureSamples")]
	public int NumVertexTextureSamples;

	private static bool NumPixelTextureSamples_IsValid;

	private static int NumPixelTextureSamples_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MaterialEditor.MaterialStatistics:NumPixelTextureSamples")]
	public int NumPixelTextureSamples;

	private static bool NumVirtualTextureSamples_IsValid;

	private static int NumVirtualTextureSamples_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MaterialEditor.MaterialStatistics:NumVirtualTextureSamples")]
	public int NumVirtualTextureSamples;

	private static bool NumUVScalars_IsValid;

	private static int NumUVScalars_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MaterialEditor.MaterialStatistics:NumUVScalars")]
	public int NumUVScalars;

	private static bool NumInterpolatorScalars_IsValid;

	private static int NumInterpolatorScalars_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MaterialEditor.MaterialStatistics:NumInterpolatorScalars")]
	public int NumInterpolatorScalars;

	private static bool FMaterialStatistics_IsValid;

	private static int FMaterialStatistics_StructSize;

	public FMaterialStatistics Copy()
	{
		return this;
	}

	public static FMaterialStatistics FromNative(IntPtr nativeBuffer)
	{
		return new FMaterialStatistics(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMaterialStatistics value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMaterialStatistics FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMaterialStatistics(nativeBuffer + arrayIndex * FMaterialStatistics_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMaterialStatistics value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMaterialStatistics_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMaterialStatistics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MaterialEditor.MaterialStatistics");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumVertexShaderInstructions_Offset), NumVertexShaderInstructions);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumPixelShaderInstructions_Offset), NumPixelShaderInstructions);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumSamplers_Offset), NumSamplers);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumVertexTextureSamples_Offset), NumVertexTextureSamples);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumPixelTextureSamples_Offset), NumPixelTextureSamples);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumVirtualTextureSamples_Offset), NumVirtualTextureSamples);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumUVScalars_Offset), NumUVScalars);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumInterpolatorScalars_Offset), NumInterpolatorScalars);
	}

	public FMaterialStatistics(IntPtr nativeStruct)
	{
		if (!FMaterialStatistics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MaterialEditor.MaterialStatistics");
			NumVertexShaderInstructions = 0;
			NumPixelShaderInstructions = 0;
			NumSamplers = 0;
			NumVertexTextureSamples = 0;
			NumPixelTextureSamples = 0;
			NumVirtualTextureSamples = 0;
			NumUVScalars = 0;
			NumInterpolatorScalars = 0;
		}
		else
		{
			NumVertexShaderInstructions = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumVertexShaderInstructions_Offset));
			NumPixelShaderInstructions = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumPixelShaderInstructions_Offset));
			NumSamplers = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumSamplers_Offset));
			NumVertexTextureSamples = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumVertexTextureSamples_Offset));
			NumPixelTextureSamples = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumPixelTextureSamples_Offset));
			NumVirtualTextureSamples = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumVirtualTextureSamples_Offset));
			NumUVScalars = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumUVScalars_Offset));
			NumInterpolatorScalars = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumInterpolatorScalars_Offset));
		}
	}

	static FMaterialStatistics()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMaterialStatistics)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMaterialStatistics));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MaterialEditor.MaterialStatistics");
		FMaterialStatistics_StructSize = NativeReflection.GetStructSize(intPtr);
		NumVertexShaderInstructions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumVertexShaderInstructions");
		NumVertexShaderInstructions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumVertexShaderInstructions", Classes.FIntProperty);
		NumPixelShaderInstructions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumPixelShaderInstructions");
		NumPixelShaderInstructions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumPixelShaderInstructions", Classes.FIntProperty);
		NumSamplers_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumSamplers");
		NumSamplers_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumSamplers", Classes.FIntProperty);
		NumVertexTextureSamples_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumVertexTextureSamples");
		NumVertexTextureSamples_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumVertexTextureSamples", Classes.FIntProperty);
		NumPixelTextureSamples_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumPixelTextureSamples");
		NumPixelTextureSamples_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumPixelTextureSamples", Classes.FIntProperty);
		NumVirtualTextureSamples_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumVirtualTextureSamples");
		NumVirtualTextureSamples_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumVirtualTextureSamples", Classes.FIntProperty);
		NumUVScalars_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumUVScalars");
		NumUVScalars_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumUVScalars", Classes.FIntProperty);
		NumInterpolatorScalars_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumInterpolatorScalars");
		NumInterpolatorScalars_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumInterpolatorScalars", Classes.FIntProperty);
		FMaterialStatistics_IsValid = intPtr != IntPtr.Zero && NumVertexShaderInstructions_IsValid && NumPixelShaderInstructions_IsValid && NumSamplers_IsValid && NumVertexTextureSamples_IsValid && NumPixelTextureSamples_IsValid && NumVirtualTextureSamples_IsValid && NumUVScalars_IsValid && NumInterpolatorScalars_IsValid;
		NativeReflection.LogStructIsValid("/Script/MaterialEditor.MaterialStatistics", FMaterialStatistics_IsValid);
	}
}
