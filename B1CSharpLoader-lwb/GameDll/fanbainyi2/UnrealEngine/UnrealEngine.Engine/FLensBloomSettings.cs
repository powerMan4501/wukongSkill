using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.LensBloomSettings", "Engine", UnrealModuleType.Engine)]
public struct FLensBloomSettings
{
	private static bool GaussianSum_IsValid;

	private static int GaussianSum_Offset;

	[UProperty(Flags = (PropFlags)4503676936781829uL)]
	[UMetaPath("/Script/Engine.LensBloomSettings:GaussianSum")]
	public FGaussianSumBloomSettings GaussianSum;

	private static bool Convolution_IsValid;

	private static int Convolution_Offset;

	[UProperty(Flags = (PropFlags)4503676936781829uL)]
	[UMetaPath("/Script/Engine.LensBloomSettings:Convolution")]
	public FConvolutionBloomSettings Convolution;

	private static bool Method_IsValid;

	private static FFieldAddress Method_PropertyAddress;

	private static int Method_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.LensBloomSettings:Method")]
	public EBloomMethod Method;

	private static bool FLensBloomSettings_IsValid;

	private static int FLensBloomSettings_StructSize;

	public FLensBloomSettings Copy()
	{
		return this;
	}

	public static FLensBloomSettings FromNative(IntPtr nativeBuffer)
	{
		return new FLensBloomSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLensBloomSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLensBloomSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLensBloomSettings(nativeBuffer + arrayIndex * FLensBloomSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLensBloomSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLensBloomSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLensBloomSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.LensBloomSettings");
			return;
		}
		FGaussianSumBloomSettings.ToNative(IntPtr.Add(nativeStruct, GaussianSum_Offset), GaussianSum);
		FConvolutionBloomSettings.ToNative(IntPtr.Add(nativeStruct, Convolution_Offset), Convolution);
		EnumMarshaler<EBloomMethod>.ToNative(IntPtr.Add(nativeStruct, Method_Offset), 0, Method_PropertyAddress.Address, Method);
	}

	public FLensBloomSettings(IntPtr nativeStruct)
	{
		if (!FLensBloomSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.LensBloomSettings");
			GaussianSum = default(FGaussianSumBloomSettings);
			Convolution = default(FConvolutionBloomSettings);
			Method = EBloomMethod.BM_SOG;
		}
		else
		{
			GaussianSum = FGaussianSumBloomSettings.FromNative(IntPtr.Add(nativeStruct, GaussianSum_Offset));
			Convolution = FConvolutionBloomSettings.FromNative(IntPtr.Add(nativeStruct, Convolution_Offset));
			Method = EnumMarshaler<EBloomMethod>.FromNative(IntPtr.Add(nativeStruct, Method_Offset), 0, Method_PropertyAddress.Address);
		}
	}

	static FLensBloomSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLensBloomSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLensBloomSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.LensBloomSettings");
		FLensBloomSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		GaussianSum_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GaussianSum");
		GaussianSum_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GaussianSum", Classes.FStructProperty);
		Convolution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Convolution");
		Convolution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Convolution", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Method_PropertyAddress, intPtr, "Method");
		Method_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Method");
		Method_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Method", Classes.FByteProperty);
		FLensBloomSettings_IsValid = intPtr != IntPtr.Zero && GaussianSum_IsValid && Convolution_IsValid && Method_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.LensBloomSettings", FLensBloomSettings_IsValid);
	}
}
