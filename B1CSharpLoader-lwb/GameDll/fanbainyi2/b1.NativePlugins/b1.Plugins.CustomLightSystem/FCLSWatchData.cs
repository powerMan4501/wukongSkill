using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSWatchData", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSWatchData
{
	private static bool DirectionalLightData_IsValid;

	private static int DirectionalLightData_Offset;

	[UProperty(Flags = (PropFlags)4503599627501589uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSWatchData:DirectionalLightData")]
	public FCLSCategoryWatchData DirectionalLightData;

	private static bool SkyLightData_IsValid;

	private static int SkyLightData_Offset;

	[UProperty(Flags = (PropFlags)4503599627501589uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSWatchData:SkyLightData")]
	public FCLSCategoryWatchData SkyLightData;

	private static bool AtmosphereData_IsValid;

	private static int AtmosphereData_Offset;

	[UProperty(Flags = (PropFlags)4503599627501589uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSWatchData:AtmosphereData")]
	public FCLSCategoryWatchData AtmosphereData;

	private static bool HeightFogData_IsValid;

	private static int HeightFogData_Offset;

	[UProperty(Flags = (PropFlags)4503599627501589uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSWatchData:HeightFogData")]
	public FCLSCategoryWatchData HeightFogData;

	private static bool CustomVariableData_IsValid;

	private static int CustomVariableData_Offset;

	[UProperty(Flags = (PropFlags)4503599627501589uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSWatchData:CustomVariableData")]
	public FCLSCategoryWatchData CustomVariableData;

	private static bool OtherData_IsValid;

	private static int OtherData_Offset;

	[UProperty(Flags = (PropFlags)4503599627501589uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSWatchData:OtherData")]
	public FCLSCategoryWatchData OtherData;

	private static bool PlayerLightData_IsValid;

	private static int PlayerLightData_Offset;

	[UProperty(Flags = (PropFlags)4503599627501589uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSWatchData:PlayerLightData")]
	public FCLSPlayerLightWatchData PlayerLightData;

	private static bool VolumeData_IsValid;

	private static FFieldAddress VolumeData_PropertyAddress;

	private static int VolumeData_Offset;

	[UProperty(Flags = (PropFlags)4503599627502101uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSWatchData:VolumeData")]
	public List<FCLSVolumeWatchData> VolumeData;

	private static bool FCLSWatchData_IsValid;

	private static int FCLSWatchData_StructSize;

	public FCLSWatchData Copy()
	{
		FCLSWatchData result = this;
		if (VolumeData != null)
		{
			result.VolumeData = new List<FCLSVolumeWatchData>(VolumeData);
		}
		return result;
	}

	public static FCLSWatchData FromNative(IntPtr nativeBuffer)
	{
		return new FCLSWatchData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSWatchData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSWatchData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSWatchData(nativeBuffer + arrayIndex * FCLSWatchData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSWatchData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSWatchData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSWatchData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSWatchData");
			return;
		}
		FCLSCategoryWatchData.ToNative(IntPtr.Add(nativeStruct, DirectionalLightData_Offset), DirectionalLightData);
		FCLSCategoryWatchData.ToNative(IntPtr.Add(nativeStruct, SkyLightData_Offset), SkyLightData);
		FCLSCategoryWatchData.ToNative(IntPtr.Add(nativeStruct, AtmosphereData_Offset), AtmosphereData);
		FCLSCategoryWatchData.ToNative(IntPtr.Add(nativeStruct, HeightFogData_Offset), HeightFogData);
		FCLSCategoryWatchData.ToNative(IntPtr.Add(nativeStruct, CustomVariableData_Offset), CustomVariableData);
		FCLSCategoryWatchData.ToNative(IntPtr.Add(nativeStruct, OtherData_Offset), OtherData);
		FCLSPlayerLightWatchData.ToNative(IntPtr.Add(nativeStruct, PlayerLightData_Offset), PlayerLightData);
		new TArrayCopyMarshaler<FCLSVolumeWatchData>(1, VolumeData_PropertyAddress, CachedMarshalingDelegates<FCLSVolumeWatchData, FCLSVolumeWatchData>.FromNative, CachedMarshalingDelegates<FCLSVolumeWatchData, FCLSVolumeWatchData>.ToNative).ToNative(IntPtr.Add(nativeStruct, VolumeData_Offset), VolumeData);
	}

	public FCLSWatchData(IntPtr nativeStruct)
	{
		if (!FCLSWatchData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSWatchData");
			DirectionalLightData = default(FCLSCategoryWatchData);
			SkyLightData = default(FCLSCategoryWatchData);
			AtmosphereData = default(FCLSCategoryWatchData);
			HeightFogData = default(FCLSCategoryWatchData);
			CustomVariableData = default(FCLSCategoryWatchData);
			OtherData = default(FCLSCategoryWatchData);
			PlayerLightData = default(FCLSPlayerLightWatchData);
			VolumeData = null;
		}
		else
		{
			DirectionalLightData = FCLSCategoryWatchData.FromNative(IntPtr.Add(nativeStruct, DirectionalLightData_Offset));
			SkyLightData = FCLSCategoryWatchData.FromNative(IntPtr.Add(nativeStruct, SkyLightData_Offset));
			AtmosphereData = FCLSCategoryWatchData.FromNative(IntPtr.Add(nativeStruct, AtmosphereData_Offset));
			HeightFogData = FCLSCategoryWatchData.FromNative(IntPtr.Add(nativeStruct, HeightFogData_Offset));
			CustomVariableData = FCLSCategoryWatchData.FromNative(IntPtr.Add(nativeStruct, CustomVariableData_Offset));
			OtherData = FCLSCategoryWatchData.FromNative(IntPtr.Add(nativeStruct, OtherData_Offset));
			PlayerLightData = FCLSPlayerLightWatchData.FromNative(IntPtr.Add(nativeStruct, PlayerLightData_Offset));
			VolumeData = new TArrayCopyMarshaler<FCLSVolumeWatchData>(1, VolumeData_PropertyAddress, CachedMarshalingDelegates<FCLSVolumeWatchData, FCLSVolumeWatchData>.FromNative, CachedMarshalingDelegates<FCLSVolumeWatchData, FCLSVolumeWatchData>.ToNative).FromNative(IntPtr.Add(nativeStruct, VolumeData_Offset));
		}
	}

	static FCLSWatchData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSWatchData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSWatchData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSWatchData");
		FCLSWatchData_StructSize = NativeReflection.GetStructSize(intPtr);
		DirectionalLightData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DirectionalLightData");
		DirectionalLightData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DirectionalLightData", Classes.FStructProperty);
		SkyLightData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SkyLightData");
		SkyLightData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SkyLightData", Classes.FStructProperty);
		AtmosphereData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AtmosphereData");
		AtmosphereData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AtmosphereData", Classes.FStructProperty);
		HeightFogData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HeightFogData");
		HeightFogData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HeightFogData", Classes.FStructProperty);
		CustomVariableData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomVariableData");
		CustomVariableData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomVariableData", Classes.FStructProperty);
		OtherData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OtherData");
		OtherData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OtherData", Classes.FStructProperty);
		PlayerLightData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayerLightData");
		PlayerLightData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayerLightData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VolumeData_PropertyAddress, intPtr, "VolumeData");
		VolumeData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumeData");
		VolumeData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumeData", Classes.FArrayProperty);
		FCLSWatchData_IsValid = intPtr != IntPtr.Zero && DirectionalLightData_IsValid && SkyLightData_IsValid && AtmosphereData_IsValid && HeightFogData_IsValid && CustomVariableData_IsValid && OtherData_IsValid && PlayerLightData_IsValid && VolumeData_IsValid;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSWatchData", FCLSWatchData_IsValid);
	}
}
