using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTrigger", "MovieSceneTracks", UnrealModuleType.Engine)]
public struct FMovieSceneCameraShakeSourceTrigger
{
	private static bool ShakeClass_IsValid;

	private static int ShakeClass_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTrigger:ShakeClass")]
	public TSubclassOf<UCameraShakeBase> ShakeClass;

	private static bool PlayScale_IsValid;

	private static int PlayScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTrigger:PlayScale")]
	public float PlayScale;

	private static bool PlaySpace_IsValid;

	private static FFieldAddress PlaySpace_PropertyAddress;

	private static int PlaySpace_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTrigger:PlaySpace")]
	public ECameraShakePlaySpace PlaySpace;

	private static bool UserDefinedPlaySpace_IsValid;

	private static int UserDefinedPlaySpace_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTrigger:UserDefinedPlaySpace")]
	public FRotator UserDefinedPlaySpace;

	private static bool FMovieSceneCameraShakeSourceTrigger_IsValid;

	private static int FMovieSceneCameraShakeSourceTrigger_StructSize;

	public FMovieSceneCameraShakeSourceTrigger Copy()
	{
		return this;
	}

	public static FMovieSceneCameraShakeSourceTrigger FromNative(IntPtr nativeBuffer)
	{
		return new FMovieSceneCameraShakeSourceTrigger(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMovieSceneCameraShakeSourceTrigger value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMovieSceneCameraShakeSourceTrigger FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMovieSceneCameraShakeSourceTrigger(nativeBuffer + arrayIndex * FMovieSceneCameraShakeSourceTrigger_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMovieSceneCameraShakeSourceTrigger value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMovieSceneCameraShakeSourceTrigger_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMovieSceneCameraShakeSourceTrigger_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTrigger");
			return;
		}
		TSubclassOfMarshaler<UCameraShakeBase>.ToNative(IntPtr.Add(nativeStruct, ShakeClass_Offset), ShakeClass);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PlayScale_Offset), PlayScale);
		EnumMarshaler<ECameraShakePlaySpace>.ToNative(IntPtr.Add(nativeStruct, PlaySpace_Offset), 0, PlaySpace_PropertyAddress.Address, PlaySpace);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, UserDefinedPlaySpace_Offset), UserDefinedPlaySpace);
	}

	public FMovieSceneCameraShakeSourceTrigger(IntPtr nativeStruct)
	{
		if (!FMovieSceneCameraShakeSourceTrigger_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTrigger");
			ShakeClass = default(TSubclassOf<UCameraShakeBase>);
			PlayScale = 0f;
			PlaySpace = ECameraShakePlaySpace.CameraLocal;
			UserDefinedPlaySpace = default(FRotator);
		}
		else
		{
			ShakeClass = TSubclassOfMarshaler<UCameraShakeBase>.FromNative(IntPtr.Add(nativeStruct, ShakeClass_Offset));
			PlayScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PlayScale_Offset));
			PlaySpace = EnumMarshaler<ECameraShakePlaySpace>.FromNative(IntPtr.Add(nativeStruct, PlaySpace_Offset), 0, PlaySpace_PropertyAddress.Address);
			UserDefinedPlaySpace = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, UserDefinedPlaySpace_Offset));
		}
	}

	static FMovieSceneCameraShakeSourceTrigger()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMovieSceneCameraShakeSourceTrigger)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovieSceneCameraShakeSourceTrigger));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTrigger");
		FMovieSceneCameraShakeSourceTrigger_StructSize = NativeReflection.GetStructSize(intPtr);
		ShakeClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShakeClass");
		ShakeClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShakeClass", Classes.FClassProperty);
		PlayScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayScale");
		PlayScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlaySpace_PropertyAddress, intPtr, "PlaySpace");
		PlaySpace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlaySpace");
		PlaySpace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlaySpace", Classes.FEnumProperty);
		UserDefinedPlaySpace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UserDefinedPlaySpace");
		UserDefinedPlaySpace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UserDefinedPlaySpace", Classes.FStructProperty);
		FMovieSceneCameraShakeSourceTrigger_IsValid = intPtr != IntPtr.Zero && ShakeClass_IsValid && PlayScale_IsValid && PlaySpace_IsValid && UserDefinedPlaySpace_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTrigger", FMovieSceneCameraShakeSourceTrigger_IsValid);
	}
}
