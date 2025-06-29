using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSVolumeWatchData", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSVolumeWatchData
{
	private static bool Valid_IsValid;

	private static FFieldAddress Valid_PropertyAddress;

	private static int Valid_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeWatchData:bValid")]
	public bool Valid;

	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755399441187349uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeWatchData:Name")]
	public string Name;

	private static bool Level_IsValid;

	private static int Level_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeWatchData:Level")]
	public int Level;

	private static bool DynamicLevel_IsValid;

	private static int DynamicLevel_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeWatchData:DynamicLevel")]
	public int DynamicLevel;

	private static bool InVolume_IsValid;

	private static FFieldAddress InVolume_PropertyAddress;

	private static int InVolume_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeWatchData:bInVolume")]
	public bool InVolume;

	private static bool DistanceToPoint_IsValid;

	private static int DistanceToPoint_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeWatchData:DistanceToPoint")]
	public float DistanceToPoint;

	private static bool FCLSVolumeWatchData_IsValid;

	private static int FCLSVolumeWatchData_StructSize;

	public FCLSVolumeWatchData Copy()
	{
		return this;
	}

	public static FCLSVolumeWatchData FromNative(IntPtr nativeBuffer)
	{
		return new FCLSVolumeWatchData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSVolumeWatchData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSVolumeWatchData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSVolumeWatchData(nativeBuffer + arrayIndex * FCLSVolumeWatchData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSVolumeWatchData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSVolumeWatchData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSVolumeWatchData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSVolumeWatchData");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Valid_Offset), 0, Valid_PropertyAddress.Address, Valid);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Level_Offset), Level);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, DynamicLevel_Offset), DynamicLevel);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, InVolume_Offset), 0, InVolume_PropertyAddress.Address, InVolume);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DistanceToPoint_Offset), DistanceToPoint);
	}

	public FCLSVolumeWatchData(IntPtr nativeStruct)
	{
		if (!FCLSVolumeWatchData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSVolumeWatchData");
			Valid = false;
			Name = FStringMarshaler.DefaultString;
			Level = 0;
			DynamicLevel = 0;
			InVolume = false;
			DistanceToPoint = 0f;
		}
		else
		{
			Valid = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Valid_Offset), 0, Valid_PropertyAddress.Address);
			Name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			Level = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Level_Offset));
			DynamicLevel = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, DynamicLevel_Offset));
			InVolume = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, InVolume_Offset), 0, InVolume_PropertyAddress.Address);
			DistanceToPoint = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DistanceToPoint_Offset));
		}
	}

	static FCLSVolumeWatchData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSVolumeWatchData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSVolumeWatchData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSVolumeWatchData");
		FCLSVolumeWatchData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Valid_PropertyAddress, intPtr, "bValid");
		Valid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bValid");
		Valid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bValid", Classes.FBoolProperty);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FStrProperty);
		Level_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Level");
		Level_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Level", Classes.FIntProperty);
		DynamicLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DynamicLevel");
		DynamicLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DynamicLevel", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref InVolume_PropertyAddress, intPtr, "bInVolume");
		InVolume_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bInVolume");
		InVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bInVolume", Classes.FBoolProperty);
		DistanceToPoint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DistanceToPoint");
		DistanceToPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DistanceToPoint", Classes.FFloatProperty);
		FCLSVolumeWatchData_IsValid = intPtr != IntPtr.Zero && Valid_IsValid && Name_IsValid && Level_IsValid && DynamicLevel_IsValid && InVolume_IsValid && DistanceToPoint_IsValid;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSVolumeWatchData", FCLSVolumeWatchData_IsValid);
	}
}
