using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelinePassIdentifier", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public struct FMoviePipelinePassIdentifier
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelinePassIdentifier:Name")]
	public string Name;

	private static bool FMoviePipelinePassIdentifier_IsValid;

	private static int FMoviePipelinePassIdentifier_StructSize;

	public FMoviePipelinePassIdentifier Copy()
	{
		return this;
	}

	public static FMoviePipelinePassIdentifier FromNative(IntPtr nativeBuffer)
	{
		return new FMoviePipelinePassIdentifier(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMoviePipelinePassIdentifier value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMoviePipelinePassIdentifier FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMoviePipelinePassIdentifier(nativeBuffer + arrayIndex * FMoviePipelinePassIdentifier_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMoviePipelinePassIdentifier value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMoviePipelinePassIdentifier_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMoviePipelinePassIdentifier_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieRenderPipelineCore.MoviePipelinePassIdentifier");
		}
		else
		{
			FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		}
	}

	public FMoviePipelinePassIdentifier(IntPtr nativeStruct)
	{
		if (!FMoviePipelinePassIdentifier_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieRenderPipelineCore.MoviePipelinePassIdentifier");
			Name = FStringMarshaler.DefaultString;
		}
		else
		{
			Name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
		}
	}

	static FMoviePipelinePassIdentifier()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMoviePipelinePassIdentifier)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMoviePipelinePassIdentifier));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieRenderPipelineCore.MoviePipelinePassIdentifier");
		FMoviePipelinePassIdentifier_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FStrProperty);
		FMoviePipelinePassIdentifier_IsValid = intPtr != IntPtr.Zero && Name_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieRenderPipelineCore.MoviePipelinePassIdentifier", FMoviePipelinePassIdentifier_IsValid);
	}
}
