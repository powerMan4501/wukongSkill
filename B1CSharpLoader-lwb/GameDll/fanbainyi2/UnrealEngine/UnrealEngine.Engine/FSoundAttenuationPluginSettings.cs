using System;
using System.Collections.Generic;
using UnrealEngine.AudioExtensions;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundAttenuationPluginSettings", "Engine", UnrealModuleType.Engine)]
public struct FSoundAttenuationPluginSettings
{
	private static bool SpatializationPluginSettingsArray_IsValid;

	private static FFieldAddress SpatializationPluginSettingsArray_PropertyAddress;

	private static int SpatializationPluginSettingsArray_Offset;

	[UProperty(Flags = (PropFlags)5629499534213637uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationPluginSettings:SpatializationPluginSettingsArray")]
	public List<USpatializationPluginSourceSettingsBase> SpatializationPluginSettingsArray;

	private static bool OcclusionPluginSettingsArray_IsValid;

	private static FFieldAddress OcclusionPluginSettingsArray_PropertyAddress;

	private static int OcclusionPluginSettingsArray_Offset;

	[UProperty(Flags = (PropFlags)5629499534213637uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationPluginSettings:OcclusionPluginSettingsArray")]
	public List<UOcclusionPluginSourceSettingsBase> OcclusionPluginSettingsArray;

	private static bool ReverbPluginSettingsArray_IsValid;

	private static FFieldAddress ReverbPluginSettingsArray_PropertyAddress;

	private static int ReverbPluginSettingsArray_Offset;

	[UProperty(Flags = (PropFlags)5629499534213637uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationPluginSettings:ReverbPluginSettingsArray")]
	public List<UReverbPluginSourceSettingsBase> ReverbPluginSettingsArray;

	private static bool SourceDataOverridePluginSettingsArray_IsValid;

	private static FFieldAddress SourceDataOverridePluginSettingsArray_PropertyAddress;

	private static int SourceDataOverridePluginSettingsArray_Offset;

	[UProperty(Flags = (PropFlags)5629499534213637uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationPluginSettings:SourceDataOverridePluginSettingsArray")]
	public List<USourceDataOverridePluginSourceSettingsBase> SourceDataOverridePluginSettingsArray;

	private static bool FSoundAttenuationPluginSettings_IsValid;

	private static int FSoundAttenuationPluginSettings_StructSize;

	public FSoundAttenuationPluginSettings Copy()
	{
		FSoundAttenuationPluginSettings result = this;
		if (SpatializationPluginSettingsArray != null)
		{
			result.SpatializationPluginSettingsArray = new List<USpatializationPluginSourceSettingsBase>(SpatializationPluginSettingsArray);
		}
		if (OcclusionPluginSettingsArray != null)
		{
			result.OcclusionPluginSettingsArray = new List<UOcclusionPluginSourceSettingsBase>(OcclusionPluginSettingsArray);
		}
		if (ReverbPluginSettingsArray != null)
		{
			result.ReverbPluginSettingsArray = new List<UReverbPluginSourceSettingsBase>(ReverbPluginSettingsArray);
		}
		if (SourceDataOverridePluginSettingsArray != null)
		{
			result.SourceDataOverridePluginSettingsArray = new List<USourceDataOverridePluginSourceSettingsBase>(SourceDataOverridePluginSettingsArray);
		}
		return result;
	}

	public static FSoundAttenuationPluginSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSoundAttenuationPluginSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSoundAttenuationPluginSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSoundAttenuationPluginSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSoundAttenuationPluginSettings(nativeBuffer + arrayIndex * FSoundAttenuationPluginSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSoundAttenuationPluginSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSoundAttenuationPluginSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSoundAttenuationPluginSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundAttenuationPluginSettings");
			return;
		}
		new TArrayCopyMarshaler<USpatializationPluginSourceSettingsBase>(1, SpatializationPluginSettingsArray_PropertyAddress, CachedMarshalingDelegates<USpatializationPluginSourceSettingsBase, UObjectMarshaler<USpatializationPluginSourceSettingsBase>>.FromNative, CachedMarshalingDelegates<USpatializationPluginSourceSettingsBase, UObjectMarshaler<USpatializationPluginSourceSettingsBase>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SpatializationPluginSettingsArray_Offset), SpatializationPluginSettingsArray);
		new TArrayCopyMarshaler<UOcclusionPluginSourceSettingsBase>(1, OcclusionPluginSettingsArray_PropertyAddress, CachedMarshalingDelegates<UOcclusionPluginSourceSettingsBase, UObjectMarshaler<UOcclusionPluginSourceSettingsBase>>.FromNative, CachedMarshalingDelegates<UOcclusionPluginSourceSettingsBase, UObjectMarshaler<UOcclusionPluginSourceSettingsBase>>.ToNative).ToNative(IntPtr.Add(nativeStruct, OcclusionPluginSettingsArray_Offset), OcclusionPluginSettingsArray);
		new TArrayCopyMarshaler<UReverbPluginSourceSettingsBase>(1, ReverbPluginSettingsArray_PropertyAddress, CachedMarshalingDelegates<UReverbPluginSourceSettingsBase, UObjectMarshaler<UReverbPluginSourceSettingsBase>>.FromNative, CachedMarshalingDelegates<UReverbPluginSourceSettingsBase, UObjectMarshaler<UReverbPluginSourceSettingsBase>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ReverbPluginSettingsArray_Offset), ReverbPluginSettingsArray);
		new TArrayCopyMarshaler<USourceDataOverridePluginSourceSettingsBase>(1, SourceDataOverridePluginSettingsArray_PropertyAddress, CachedMarshalingDelegates<USourceDataOverridePluginSourceSettingsBase, UObjectMarshaler<USourceDataOverridePluginSourceSettingsBase>>.FromNative, CachedMarshalingDelegates<USourceDataOverridePluginSourceSettingsBase, UObjectMarshaler<USourceDataOverridePluginSourceSettingsBase>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SourceDataOverridePluginSettingsArray_Offset), SourceDataOverridePluginSettingsArray);
	}

	public FSoundAttenuationPluginSettings(IntPtr nativeStruct)
	{
		if (!FSoundAttenuationPluginSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundAttenuationPluginSettings");
			SpatializationPluginSettingsArray = null;
			OcclusionPluginSettingsArray = null;
			ReverbPluginSettingsArray = null;
			SourceDataOverridePluginSettingsArray = null;
		}
		else
		{
			SpatializationPluginSettingsArray = new TArrayCopyMarshaler<USpatializationPluginSourceSettingsBase>(1, SpatializationPluginSettingsArray_PropertyAddress, CachedMarshalingDelegates<USpatializationPluginSourceSettingsBase, UObjectMarshaler<USpatializationPluginSourceSettingsBase>>.FromNative, CachedMarshalingDelegates<USpatializationPluginSourceSettingsBase, UObjectMarshaler<USpatializationPluginSourceSettingsBase>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SpatializationPluginSettingsArray_Offset));
			OcclusionPluginSettingsArray = new TArrayCopyMarshaler<UOcclusionPluginSourceSettingsBase>(1, OcclusionPluginSettingsArray_PropertyAddress, CachedMarshalingDelegates<UOcclusionPluginSourceSettingsBase, UObjectMarshaler<UOcclusionPluginSourceSettingsBase>>.FromNative, CachedMarshalingDelegates<UOcclusionPluginSourceSettingsBase, UObjectMarshaler<UOcclusionPluginSourceSettingsBase>>.ToNative).FromNative(IntPtr.Add(nativeStruct, OcclusionPluginSettingsArray_Offset));
			ReverbPluginSettingsArray = new TArrayCopyMarshaler<UReverbPluginSourceSettingsBase>(1, ReverbPluginSettingsArray_PropertyAddress, CachedMarshalingDelegates<UReverbPluginSourceSettingsBase, UObjectMarshaler<UReverbPluginSourceSettingsBase>>.FromNative, CachedMarshalingDelegates<UReverbPluginSourceSettingsBase, UObjectMarshaler<UReverbPluginSourceSettingsBase>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ReverbPluginSettingsArray_Offset));
			SourceDataOverridePluginSettingsArray = new TArrayCopyMarshaler<USourceDataOverridePluginSourceSettingsBase>(1, SourceDataOverridePluginSettingsArray_PropertyAddress, CachedMarshalingDelegates<USourceDataOverridePluginSourceSettingsBase, UObjectMarshaler<USourceDataOverridePluginSourceSettingsBase>>.FromNative, CachedMarshalingDelegates<USourceDataOverridePluginSourceSettingsBase, UObjectMarshaler<USourceDataOverridePluginSourceSettingsBase>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SourceDataOverridePluginSettingsArray_Offset));
		}
	}

	static FSoundAttenuationPluginSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSoundAttenuationPluginSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSoundAttenuationPluginSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SoundAttenuationPluginSettings");
		FSoundAttenuationPluginSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref SpatializationPluginSettingsArray_PropertyAddress, intPtr, "SpatializationPluginSettingsArray");
		SpatializationPluginSettingsArray_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpatializationPluginSettingsArray");
		SpatializationPluginSettingsArray_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpatializationPluginSettingsArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref OcclusionPluginSettingsArray_PropertyAddress, intPtr, "OcclusionPluginSettingsArray");
		OcclusionPluginSettingsArray_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OcclusionPluginSettingsArray");
		OcclusionPluginSettingsArray_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OcclusionPluginSettingsArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ReverbPluginSettingsArray_PropertyAddress, intPtr, "ReverbPluginSettingsArray");
		ReverbPluginSettingsArray_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReverbPluginSettingsArray");
		ReverbPluginSettingsArray_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReverbPluginSettingsArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SourceDataOverridePluginSettingsArray_PropertyAddress, intPtr, "SourceDataOverridePluginSettingsArray");
		SourceDataOverridePluginSettingsArray_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceDataOverridePluginSettingsArray");
		SourceDataOverridePluginSettingsArray_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceDataOverridePluginSettingsArray", Classes.FArrayProperty);
		FSoundAttenuationPluginSettings_IsValid = intPtr != IntPtr.Zero && SpatializationPluginSettingsArray_IsValid && OcclusionPluginSettingsArray_IsValid && ReverbPluginSettingsArray_IsValid && SourceDataOverridePluginSettingsArray_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SoundAttenuationPluginSettings", FSoundAttenuationPluginSettings_IsValid);
	}
}
