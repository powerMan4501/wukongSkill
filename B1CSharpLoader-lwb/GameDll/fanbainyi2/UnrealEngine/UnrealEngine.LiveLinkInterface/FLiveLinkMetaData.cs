using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkMetaData", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkMetaData
{
	private static bool StringMetaData_IsValid;

	private static FFieldAddress StringMetaData_PropertyAddress;

	private static int StringMetaData_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkMetaData:StringMetaData")]
	public Dictionary<FName, string> StringMetaData;

	private static bool SceneTime_IsValid;

	private static int SceneTime_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkMetaData:SceneTime")]
	public FQualifiedTime SceneTime;

	private static bool FLiveLinkMetaData_IsValid;

	private static int FLiveLinkMetaData_StructSize;

	public FLiveLinkMetaData Copy()
	{
		FLiveLinkMetaData result = this;
		if (StringMetaData != null)
		{
			result.StringMetaData = new Dictionary<FName, string>(StringMetaData);
		}
		return result;
	}

	public static FLiveLinkMetaData FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkMetaData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkMetaData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkMetaData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkMetaData(nativeBuffer + arrayIndex * FLiveLinkMetaData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkMetaData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkMetaData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkMetaData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkMetaData");
			return;
		}
		new TMapCopyMarshaler<FName, string>(1, StringMetaData_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, StringMetaData_Offset), StringMetaData);
		FQualifiedTime.ToNative(IntPtr.Add(nativeStruct, SceneTime_Offset), SceneTime);
	}

	public FLiveLinkMetaData(IntPtr nativeStruct)
	{
		if (!FLiveLinkMetaData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkMetaData");
			StringMetaData = null;
			SceneTime = default(FQualifiedTime);
		}
		else
		{
			StringMetaData = new TMapCopyMarshaler<FName, string>(1, StringMetaData_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, StringMetaData_Offset));
			SceneTime = FQualifiedTime.FromNative(IntPtr.Add(nativeStruct, SceneTime_Offset));
		}
	}

	static FLiveLinkMetaData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkMetaData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkMetaData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkMetaData");
		FLiveLinkMetaData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref StringMetaData_PropertyAddress, intPtr, "StringMetaData");
		StringMetaData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StringMetaData");
		StringMetaData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StringMetaData", Classes.FMapProperty);
		SceneTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SceneTime");
		SceneTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SceneTime", Classes.FStructProperty);
		FLiveLinkMetaData_IsValid = intPtr != IntPtr.Zero && StringMetaData_IsValid && SceneTime_IsValid;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkMetaData", FLiveLinkMetaData_IsValid);
	}
}
