using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineRenderPasses;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieRenderPipelineRenderPasses.MoviePipelineImageSequenceOutput_EXR", "MovieRenderPipelineRenderPasses", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineImageSequenceOutput_EXR : UMoviePipelineImageSequenceOutputBase
{
	private static bool Compression_IsValid;

	private static FFieldAddress Compression_PropertyAddress;

	private static int Compression_Offset;

	private static bool Multilayer_IsValid;

	private static FFieldAddress Multilayer_PropertyAddress;

	private static int Multilayer_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineRenderPasses.MoviePipelineImageSequenceOutput_EXR:Compression")]
	public EEXRCompressionFormat Compression
	{
		get
		{
			CheckDestroyed();
			if (!Compression_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineRenderPasses.MoviePipelineImageSequenceOutput_EXR:Compression");
				return EEXRCompressionFormat.None;
			}
			return EnumMarshaler<EEXRCompressionFormat>.FromNative(IntPtr.Add(base.Address, Compression_Offset), 0, Compression_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Compression_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineRenderPasses.MoviePipelineImageSequenceOutput_EXR:Compression");
			}
			else
			{
				EnumMarshaler<EEXRCompressionFormat>.ToNative(IntPtr.Add(base.Address, Compression_Offset), 0, Compression_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineRenderPasses.MoviePipelineImageSequenceOutput_EXR:bMultilayer")]
	public bool Multilayer
	{
		get
		{
			CheckDestroyed();
			if (!Multilayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineRenderPasses.MoviePipelineImageSequenceOutput_EXR:bMultilayer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Multilayer_Offset), 0, Multilayer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Multilayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineRenderPasses.MoviePipelineImageSequenceOutput_EXR:bMultilayer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Multilayer_Offset), 0, Multilayer_PropertyAddress.Address, value);
			}
		}
	}

	static UMoviePipelineImageSequenceOutput_EXR()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineImageSequenceOutput_EXR)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineImageSequenceOutput_EXR));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieRenderPipelineRenderPasses.MoviePipelineImageSequenceOutput_EXR");
		NativeReflectionCached.GetPropertyRef(ref Compression_PropertyAddress, unrealStruct, "Compression");
		Compression_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Compression");
		Compression_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Compression", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref Multilayer_PropertyAddress, unrealStruct, "bMultilayer");
		Multilayer_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bMultilayer");
		Multilayer_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bMultilayer", Classes.FBoolProperty);
	}
}
