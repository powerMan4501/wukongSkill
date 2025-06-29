using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.SubjectMetadata", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FSubjectMetadata
{
	private static bool StringMetadata_IsValid;

	private static FFieldAddress StringMetadata_PropertyAddress;

	private static int StringMetadata_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/LiveLinkInterface.SubjectMetadata:StringMetadata")]
	public Dictionary<FName, string> StringMetadata;

	private static bool SceneTimecode_IsValid;

	private static int SceneTimecode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LiveLinkInterface.SubjectMetadata:SceneTimecode")]
	public FTimecode SceneTimecode;

	private static bool SceneFramerate_IsValid;

	private static int SceneFramerate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LiveLinkInterface.SubjectMetadata:SceneFramerate")]
	public FFrameRate SceneFramerate;

	private static bool FSubjectMetadata_IsValid;

	private static int FSubjectMetadata_StructSize;

	public FSubjectMetadata Copy()
	{
		FSubjectMetadata result = this;
		if (StringMetadata != null)
		{
			result.StringMetadata = new Dictionary<FName, string>(StringMetadata);
		}
		return result;
	}

	public static FSubjectMetadata FromNative(IntPtr nativeBuffer)
	{
		return new FSubjectMetadata(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSubjectMetadata value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSubjectMetadata FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSubjectMetadata(nativeBuffer + arrayIndex * FSubjectMetadata_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSubjectMetadata value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSubjectMetadata_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSubjectMetadata_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.SubjectMetadata");
			return;
		}
		new TMapCopyMarshaler<FName, string>(1, StringMetadata_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, StringMetadata_Offset), StringMetadata);
		FTimecode.ToNative(IntPtr.Add(nativeStruct, SceneTimecode_Offset), SceneTimecode);
		BlittableTypeMarshaler<FFrameRate>.ToNative(IntPtr.Add(nativeStruct, SceneFramerate_Offset), SceneFramerate);
	}

	public FSubjectMetadata(IntPtr nativeStruct)
	{
		if (!FSubjectMetadata_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.SubjectMetadata");
			StringMetadata = null;
			SceneTimecode = default(FTimecode);
			SceneFramerate = default(FFrameRate);
		}
		else
		{
			StringMetadata = new TMapCopyMarshaler<FName, string>(1, StringMetadata_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, StringMetadata_Offset));
			SceneTimecode = FTimecode.FromNative(IntPtr.Add(nativeStruct, SceneTimecode_Offset));
			SceneFramerate = BlittableTypeMarshaler<FFrameRate>.FromNative(IntPtr.Add(nativeStruct, SceneFramerate_Offset));
		}
	}

	static FSubjectMetadata()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSubjectMetadata)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSubjectMetadata));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.SubjectMetadata");
		FSubjectMetadata_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref StringMetadata_PropertyAddress, intPtr, "StringMetadata");
		StringMetadata_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StringMetadata");
		StringMetadata_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StringMetadata", Classes.FMapProperty);
		SceneTimecode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SceneTimecode");
		SceneTimecode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SceneTimecode", Classes.FStructProperty);
		SceneFramerate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SceneFramerate");
		SceneFramerate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SceneFramerate", Classes.FStructProperty);
		FSubjectMetadata_IsValid = intPtr != IntPtr.Zero && StringMetadata_IsValid && SceneTimecode_IsValid && SceneFramerate_IsValid;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.SubjectMetadata", FSubjectMetadata_IsValid);
	}
}
