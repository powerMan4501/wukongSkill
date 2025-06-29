using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSPlayerLightWatchData", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSPlayerLightWatchData
{
	private static bool OriginData_IsValid;

	private static int OriginData_Offset;

	[UProperty(Flags = (PropFlags)6755399441187349uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSCategoryWatchData:OriginData")]
	public string OriginData;

	private static bool CurrentData_IsValid;

	private static int CurrentData_Offset;

	[UProperty(Flags = (PropFlags)6755399441187349uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSCategoryWatchData:CurrentData")]
	public string CurrentData;

	private static bool TargetData_IsValid;

	private static int TargetData_Offset;

	[UProperty(Flags = (PropFlags)6755399441187349uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSCategoryWatchData:TargetData")]
	public string TargetData;

	private static bool SpeedAlpha_IsValid;

	private static int SpeedAlpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSCategoryWatchData:SpeedAlpha")]
	public float SpeedAlpha;

	private static bool OriginUseCustomBlendOutSpeed_IsValid;

	private static FFieldAddress OriginUseCustomBlendOutSpeed_PropertyAddress;

	private static int OriginUseCustomBlendOutSpeed_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSCategoryWatchData:bOriginUseCustomBlendOutSpeed")]
	public bool OriginUseCustomBlendOutSpeed;

	private static bool OriginCustomBlendOutSpeedAlpha_IsValid;

	private static int OriginCustomBlendOutSpeedAlpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSCategoryWatchData:OriginCustomBlendOutSpeedAlpha")]
	public float OriginCustomBlendOutSpeedAlpha;

	private static bool TargetUseCustomBlendOutSpeed_IsValid;

	private static FFieldAddress TargetUseCustomBlendOutSpeed_PropertyAddress;

	private static int TargetUseCustomBlendOutSpeed_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSCategoryWatchData:bTargetUseCustomBlendOutSpeed")]
	public bool TargetUseCustomBlendOutSpeed;

	private static bool TargetCustomBlendOutSpeedAlpha_IsValid;

	private static int TargetCustomBlendOutSpeedAlpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSCategoryWatchData:TargetCustomBlendOutSpeedAlpha")]
	public float TargetCustomBlendOutSpeedAlpha;

	private static bool CurrentAlpha_IsValid;

	private static int CurrentAlpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSCategoryWatchData:CurrentAlpha")]
	public float CurrentAlpha;

	private static bool TargetAlpha_IsValid;

	private static int TargetAlpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSCategoryWatchData:TargetAlpha")]
	public float TargetAlpha;

	private static bool CurrentPercentage_IsValid;

	private static int CurrentPercentage_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSCategoryWatchData:CurrentPercentage")]
	public float CurrentPercentage;

	private static bool FrontLightData_IsValid;

	private static int FrontLightData_Offset;

	[UProperty(Flags = (PropFlags)4503668346978325uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSPlayerLightWatchData:FrontLightData")]
	public FCLSPlayerLightDataBase FrontLightData;

	private static bool BackLightData_IsValid;

	private static int BackLightData_Offset;

	[UProperty(Flags = (PropFlags)4503668346978325uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSPlayerLightWatchData:BackLightData")]
	public FCLSPlayerLightDataBase BackLightData;

	private static bool FCLSPlayerLightWatchData_IsValid;

	private static int FCLSPlayerLightWatchData_StructSize;

	public FCLSPlayerLightWatchData Copy()
	{
		return this;
	}

	public static FCLSPlayerLightWatchData FromNative(IntPtr nativeBuffer)
	{
		return new FCLSPlayerLightWatchData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSPlayerLightWatchData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSPlayerLightWatchData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSPlayerLightWatchData(nativeBuffer + arrayIndex * FCLSPlayerLightWatchData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSPlayerLightWatchData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSPlayerLightWatchData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSPlayerLightWatchData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSPlayerLightWatchData");
			return;
		}
		FCLSPlayerLightDataBase.ToNative(IntPtr.Add(nativeStruct, FrontLightData_Offset), FrontLightData);
		FCLSPlayerLightDataBase.ToNative(IntPtr.Add(nativeStruct, BackLightData_Offset), BackLightData);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, OriginData_Offset), OriginData);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, CurrentData_Offset), CurrentData);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, TargetData_Offset), TargetData);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SpeedAlpha_Offset), SpeedAlpha);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OriginUseCustomBlendOutSpeed_Offset), 0, OriginUseCustomBlendOutSpeed_PropertyAddress.Address, OriginUseCustomBlendOutSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OriginCustomBlendOutSpeedAlpha_Offset), OriginCustomBlendOutSpeedAlpha);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, TargetUseCustomBlendOutSpeed_Offset), 0, TargetUseCustomBlendOutSpeed_PropertyAddress.Address, TargetUseCustomBlendOutSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TargetCustomBlendOutSpeedAlpha_Offset), TargetCustomBlendOutSpeedAlpha);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CurrentAlpha_Offset), CurrentAlpha);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TargetAlpha_Offset), TargetAlpha);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CurrentPercentage_Offset), CurrentPercentage);
	}

	public FCLSPlayerLightWatchData(IntPtr nativeStruct)
	{
		if (!FCLSPlayerLightWatchData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSPlayerLightWatchData");
			FrontLightData = default(FCLSPlayerLightDataBase);
			BackLightData = default(FCLSPlayerLightDataBase);
			OriginData = FStringMarshaler.DefaultString;
			CurrentData = FStringMarshaler.DefaultString;
			TargetData = FStringMarshaler.DefaultString;
			SpeedAlpha = 0f;
			OriginUseCustomBlendOutSpeed = false;
			OriginCustomBlendOutSpeedAlpha = 0f;
			TargetUseCustomBlendOutSpeed = false;
			TargetCustomBlendOutSpeedAlpha = 0f;
			CurrentAlpha = 0f;
			TargetAlpha = 0f;
			CurrentPercentage = 0f;
		}
		else
		{
			FrontLightData = FCLSPlayerLightDataBase.FromNative(IntPtr.Add(nativeStruct, FrontLightData_Offset));
			BackLightData = FCLSPlayerLightDataBase.FromNative(IntPtr.Add(nativeStruct, BackLightData_Offset));
			OriginData = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, OriginData_Offset));
			CurrentData = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, CurrentData_Offset));
			TargetData = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, TargetData_Offset));
			SpeedAlpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SpeedAlpha_Offset));
			OriginUseCustomBlendOutSpeed = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OriginUseCustomBlendOutSpeed_Offset), 0, OriginUseCustomBlendOutSpeed_PropertyAddress.Address);
			OriginCustomBlendOutSpeedAlpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OriginCustomBlendOutSpeedAlpha_Offset));
			TargetUseCustomBlendOutSpeed = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, TargetUseCustomBlendOutSpeed_Offset), 0, TargetUseCustomBlendOutSpeed_PropertyAddress.Address);
			TargetCustomBlendOutSpeedAlpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TargetCustomBlendOutSpeedAlpha_Offset));
			CurrentAlpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CurrentAlpha_Offset));
			TargetAlpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TargetAlpha_Offset));
			CurrentPercentage = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CurrentPercentage_Offset));
		}
	}

	static FCLSPlayerLightWatchData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSPlayerLightWatchData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSPlayerLightWatchData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSPlayerLightWatchData");
		FCLSPlayerLightWatchData_StructSize = NativeReflection.GetStructSize(intPtr);
		OriginData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OriginData");
		OriginData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OriginData", Classes.FStrProperty);
		CurrentData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrentData");
		CurrentData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrentData", Classes.FStrProperty);
		TargetData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetData");
		TargetData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetData", Classes.FStrProperty);
		SpeedAlpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpeedAlpha");
		SpeedAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpeedAlpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OriginUseCustomBlendOutSpeed_PropertyAddress, intPtr, "bOriginUseCustomBlendOutSpeed");
		OriginUseCustomBlendOutSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOriginUseCustomBlendOutSpeed");
		OriginUseCustomBlendOutSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOriginUseCustomBlendOutSpeed", Classes.FBoolProperty);
		OriginCustomBlendOutSpeedAlpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OriginCustomBlendOutSpeedAlpha");
		OriginCustomBlendOutSpeedAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OriginCustomBlendOutSpeedAlpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TargetUseCustomBlendOutSpeed_PropertyAddress, intPtr, "bTargetUseCustomBlendOutSpeed");
		TargetUseCustomBlendOutSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bTargetUseCustomBlendOutSpeed");
		TargetUseCustomBlendOutSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bTargetUseCustomBlendOutSpeed", Classes.FBoolProperty);
		TargetCustomBlendOutSpeedAlpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetCustomBlendOutSpeedAlpha");
		TargetCustomBlendOutSpeedAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetCustomBlendOutSpeedAlpha", Classes.FFloatProperty);
		CurrentAlpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrentAlpha");
		CurrentAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrentAlpha", Classes.FFloatProperty);
		TargetAlpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetAlpha");
		TargetAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetAlpha", Classes.FFloatProperty);
		CurrentPercentage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrentPercentage");
		CurrentPercentage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrentPercentage", Classes.FFloatProperty);
		FrontLightData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrontLightData");
		FrontLightData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrontLightData", Classes.FStructProperty);
		BackLightData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackLightData");
		BackLightData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackLightData", Classes.FStructProperty);
		FCLSPlayerLightWatchData_IsValid = intPtr != IntPtr.Zero && FrontLightData_IsValid && BackLightData_IsValid && OriginData_IsValid && CurrentData_IsValid && TargetData_IsValid && SpeedAlpha_IsValid && OriginUseCustomBlendOutSpeed_IsValid && OriginCustomBlendOutSpeedAlpha_IsValid && TargetUseCustomBlendOutSpeed_IsValid && TargetCustomBlendOutSpeedAlpha_IsValid && CurrentAlpha_IsValid && TargetAlpha_IsValid && CurrentPercentage_IsValid;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSPlayerLightWatchData", FCLSPlayerLightWatchData_IsValid);
	}
}
