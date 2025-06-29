using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineRenderPasses;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineRenderPasses.MoviePipelinePostProcessPass", "MovieRenderPipelineRenderPasses", UnrealModuleType.EnginePlugin)]
public struct FMoviePipelinePostProcessPass
{
	private static bool Enabled_IsValid;

	private static FFieldAddress Enabled_PropertyAddress;

	private static int Enabled_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineRenderPasses.MoviePipelinePostProcessPass:bEnabled")]
	public bool Enabled;

	private static bool Material_IsValid;

	private static int Material_Offset;

	[UProperty(Flags = (PropFlags)7881299347898373uL)]
	[UMetaPath("/Script/MovieRenderPipelineRenderPasses.MoviePipelinePostProcessPass:Material")]
	public TSoftObject<UMaterialInterface> Material;

	private static bool FMoviePipelinePostProcessPass_IsValid;

	private static int FMoviePipelinePostProcessPass_StructSize;

	public FMoviePipelinePostProcessPass Copy()
	{
		return this;
	}

	public static FMoviePipelinePostProcessPass FromNative(IntPtr nativeBuffer)
	{
		return new FMoviePipelinePostProcessPass(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMoviePipelinePostProcessPass value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMoviePipelinePostProcessPass FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMoviePipelinePostProcessPass(nativeBuffer + arrayIndex * FMoviePipelinePostProcessPass_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMoviePipelinePostProcessPass value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMoviePipelinePostProcessPass_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMoviePipelinePostProcessPass_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieRenderPipelineRenderPasses.MoviePipelinePostProcessPass");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Enabled_Offset), 0, Enabled_PropertyAddress.Address, Enabled);
		TSoftObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(nativeStruct, Material_Offset), Material);
	}

	public FMoviePipelinePostProcessPass(IntPtr nativeStruct)
	{
		if (!FMoviePipelinePostProcessPass_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieRenderPipelineRenderPasses.MoviePipelinePostProcessPass");
			Enabled = false;
			Material = default(TSoftObject<UMaterialInterface>);
		}
		else
		{
			Enabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Enabled_Offset), 0, Enabled_PropertyAddress.Address);
			Material = TSoftObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(nativeStruct, Material_Offset));
		}
	}

	static FMoviePipelinePostProcessPass()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMoviePipelinePostProcessPass)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMoviePipelinePostProcessPass));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieRenderPipelineRenderPasses.MoviePipelinePostProcessPass");
		FMoviePipelinePostProcessPass_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Enabled_PropertyAddress, intPtr, "bEnabled");
		Enabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnabled");
		Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnabled", Classes.FBoolProperty);
		Material_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Material");
		Material_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Material", Classes.FSoftObjectProperty);
		FMoviePipelinePostProcessPass_IsValid = intPtr != IntPtr.Zero && Enabled_IsValid && Material_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieRenderPipelineRenderPasses.MoviePipelinePostProcessPass", FMoviePipelinePostProcessPass_IsValid);
	}
}
