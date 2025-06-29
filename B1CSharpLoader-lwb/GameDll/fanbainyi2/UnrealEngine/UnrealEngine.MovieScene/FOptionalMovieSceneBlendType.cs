using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MovieScene.OptionalMovieSceneBlendType", "MovieScene", UnrealModuleType.Engine)]
public struct FOptionalMovieSceneBlendType
{
	private static bool BlendType_IsValid;

	private static FFieldAddress BlendType_PropertyAddress;

	private static int BlendType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/MovieScene.OptionalMovieSceneBlendType:BlendType")]
	public EMovieSceneBlendType BlendType;

	private static bool IsValid_IsValid;

	private static FFieldAddress IsValid_PropertyAddress;

	private static int IsValid_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/MovieScene.OptionalMovieSceneBlendType:bIsValid")]
	public bool IsValid;

	private static bool FOptionalMovieSceneBlendType_IsValid;

	private static int FOptionalMovieSceneBlendType_StructSize;

	public FOptionalMovieSceneBlendType Copy()
	{
		return this;
	}

	public static FOptionalMovieSceneBlendType FromNative(IntPtr nativeBuffer)
	{
		return new FOptionalMovieSceneBlendType(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FOptionalMovieSceneBlendType value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FOptionalMovieSceneBlendType FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FOptionalMovieSceneBlendType(nativeBuffer + arrayIndex * FOptionalMovieSceneBlendType_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FOptionalMovieSceneBlendType value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FOptionalMovieSceneBlendType_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FOptionalMovieSceneBlendType_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieScene.OptionalMovieSceneBlendType");
			return;
		}
		EnumMarshaler<EMovieSceneBlendType>.ToNative(IntPtr.Add(nativeStruct, BlendType_Offset), 0, BlendType_PropertyAddress.Address, BlendType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsValid_Offset), 0, IsValid_PropertyAddress.Address, IsValid);
	}

	public FOptionalMovieSceneBlendType(IntPtr nativeStruct)
	{
		if (!FOptionalMovieSceneBlendType_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieScene.OptionalMovieSceneBlendType");
			BlendType = EMovieSceneBlendType.Invalid;
			IsValid = false;
		}
		else
		{
			BlendType = EnumMarshaler<EMovieSceneBlendType>.FromNative(IntPtr.Add(nativeStruct, BlendType_Offset), 0, BlendType_PropertyAddress.Address);
			IsValid = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsValid_Offset), 0, IsValid_PropertyAddress.Address);
		}
	}

	static FOptionalMovieSceneBlendType()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FOptionalMovieSceneBlendType)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOptionalMovieSceneBlendType));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieScene.OptionalMovieSceneBlendType");
		FOptionalMovieSceneBlendType_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref BlendType_PropertyAddress, intPtr, "BlendType");
		BlendType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendType");
		BlendType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValid_PropertyAddress, intPtr, "bIsValid");
		IsValid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsValid");
		IsValid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsValid", Classes.FBoolProperty);
		FOptionalMovieSceneBlendType_IsValid = intPtr != IntPtr.Zero && BlendType_IsValid && IsValid_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieScene.OptionalMovieSceneBlendType", FOptionalMovieSceneBlendType_IsValid);
	}
}
