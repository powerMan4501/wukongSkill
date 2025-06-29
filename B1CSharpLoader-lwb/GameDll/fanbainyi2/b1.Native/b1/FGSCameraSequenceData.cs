using System;
using UnrealEngine.CinematicCamera;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/b1.GSCameraSequenceData", "b1", UnrealModuleType.Game)]
public struct FGSCameraSequenceData
{
	private static bool CameraSequence_IsValid;

	private static int CameraSequence_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSCameraSequenceData:CameraSequence")]
	public ULevelSequence CameraSequence;

	private static bool CameraRailClass_IsValid;

	private static int CameraRailClass_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/b1.GSCameraSequenceData:CameraRailClass")]
	public TSubclassOf<ACameraRig_Rail> CameraRailClass;

	private static bool ShouldUseCinematicCamera_IsValid;

	private static FFieldAddress ShouldUseCinematicCamera_PropertyAddress;

	private static int ShouldUseCinematicCamera_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSCameraSequenceData:bShouldUseCinematicCamera")]
	public bool ShouldUseCinematicCamera;

	private static bool FGSCameraSequenceData_IsValid;

	private static int FGSCameraSequenceData_StructSize;

	public FGSCameraSequenceData Copy()
	{
		return this;
	}

	public static FGSCameraSequenceData FromNative(IntPtr nativeBuffer)
	{
		return new FGSCameraSequenceData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSCameraSequenceData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSCameraSequenceData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSCameraSequenceData(nativeBuffer + arrayIndex * FGSCameraSequenceData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSCameraSequenceData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSCameraSequenceData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSCameraSequenceData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSCameraSequenceData");
			return;
		}
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(nativeStruct, CameraSequence_Offset), CameraSequence);
		TSubclassOfMarshaler<ACameraRig_Rail>.ToNative(IntPtr.Add(nativeStruct, CameraRailClass_Offset), CameraRailClass);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ShouldUseCinematicCamera_Offset), 0, ShouldUseCinematicCamera_PropertyAddress.Address, ShouldUseCinematicCamera);
	}

	public FGSCameraSequenceData(IntPtr nativeStruct)
	{
		if (!FGSCameraSequenceData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSCameraSequenceData");
			CameraSequence = null;
			CameraRailClass = default(TSubclassOf<ACameraRig_Rail>);
			ShouldUseCinematicCamera = false;
		}
		else
		{
			CameraSequence = UObjectMarshaler<ULevelSequence>.FromNative(IntPtr.Add(nativeStruct, CameraSequence_Offset));
			CameraRailClass = TSubclassOfMarshaler<ACameraRig_Rail>.FromNative(IntPtr.Add(nativeStruct, CameraRailClass_Offset));
			ShouldUseCinematicCamera = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ShouldUseCinematicCamera_Offset), 0, ShouldUseCinematicCamera_PropertyAddress.Address);
		}
	}

	static FGSCameraSequenceData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSCameraSequenceData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSCameraSequenceData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.GSCameraSequenceData");
		FGSCameraSequenceData_StructSize = NativeReflection.GetStructSize(intPtr);
		CameraSequence_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CameraSequence");
		CameraSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CameraSequence", Classes.FObjectProperty);
		CameraRailClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CameraRailClass");
		CameraRailClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CameraRailClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldUseCinematicCamera_PropertyAddress, intPtr, "bShouldUseCinematicCamera");
		ShouldUseCinematicCamera_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShouldUseCinematicCamera");
		ShouldUseCinematicCamera_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShouldUseCinematicCamera", Classes.FBoolProperty);
		FGSCameraSequenceData_IsValid = intPtr != IntPtr.Zero && CameraSequence_IsValid && CameraRailClass_IsValid && ShouldUseCinematicCamera_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.GSCameraSequenceData", FGSCameraSequenceData_IsValid);
	}
}
