using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.CinematicCamera;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CinematicCamera.CameraLookatTrackingSettings", "CinematicCamera", UnrealModuleType.Engine)]
public struct FCameraLookatTrackingSettings
{
	private static bool EnableLookAtTracking_IsValid;

	private static FFieldAddress EnableLookAtTracking_PropertyAddress;

	private static int EnableLookAtTracking_Offset;

	[UProperty(Flags = (PropFlags)6755476750467077uL)]
	[UMetaPath("/Script/CinematicCamera.CameraLookatTrackingSettings:bEnableLookAtTracking")]
	public bool EnableLookAtTracking;

	private static bool DrawDebugLookAtTrackingPosition_IsValid;

	private static FFieldAddress DrawDebugLookAtTrackingPosition_PropertyAddress;

	private static int DrawDebugLookAtTrackingPosition_Offset;

	[UProperty(Flags = (PropFlags)6755468160540677uL)]
	[UMetaPath("/Script/CinematicCamera.CameraLookatTrackingSettings:bDrawDebugLookAtTrackingPosition")]
	public bool DrawDebugLookAtTrackingPosition;

	private static bool LookAtTrackingInterpSpeed_IsValid;

	private static int LookAtTrackingInterpSpeed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CinematicCamera.CameraLookatTrackingSettings:LookAtTrackingInterpSpeed")]
	public float LookAtTrackingInterpSpeed;

	private static bool ActorToTrack_IsValid;

	private static int ActorToTrack_Offset;

	[UProperty(Flags = (PropFlags)7881307937832965uL)]
	[UMetaPath("/Script/CinematicCamera.CameraLookatTrackingSettings:ActorToTrack")]
	public TSoftObject<AActor> ActorToTrack;

	private static bool RelativeOffset_IsValid;

	private static int RelativeOffset_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/CinematicCamera.CameraLookatTrackingSettings:RelativeOffset")]
	public FVector RelativeOffset;

	private static bool AllowRoll_IsValid;

	private static FFieldAddress AllowRoll_PropertyAddress;

	private static int AllowRoll_Offset;

	[UProperty(Flags = (PropFlags)6755476750467077uL)]
	[UMetaPath("/Script/CinematicCamera.CameraLookatTrackingSettings:bAllowRoll")]
	public bool AllowRoll;

	private static bool FCameraLookatTrackingSettings_IsValid;

	private static int FCameraLookatTrackingSettings_StructSize;

	public FCameraLookatTrackingSettings Copy()
	{
		return this;
	}

	public static FCameraLookatTrackingSettings FromNative(IntPtr nativeBuffer)
	{
		return new FCameraLookatTrackingSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCameraLookatTrackingSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCameraLookatTrackingSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCameraLookatTrackingSettings(nativeBuffer + arrayIndex * FCameraLookatTrackingSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCameraLookatTrackingSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCameraLookatTrackingSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCameraLookatTrackingSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CinematicCamera.CameraLookatTrackingSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableLookAtTracking_Offset), 0, EnableLookAtTracking_PropertyAddress.Address, EnableLookAtTracking);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DrawDebugLookAtTrackingPosition_Offset), 0, DrawDebugLookAtTrackingPosition_PropertyAddress.Address, DrawDebugLookAtTrackingPosition);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LookAtTrackingInterpSpeed_Offset), LookAtTrackingInterpSpeed);
		TSoftObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, ActorToTrack_Offset), ActorToTrack);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, RelativeOffset_Offset), RelativeOffset);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AllowRoll_Offset), 0, AllowRoll_PropertyAddress.Address, AllowRoll);
	}

	public FCameraLookatTrackingSettings(IntPtr nativeStruct)
	{
		if (!FCameraLookatTrackingSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CinematicCamera.CameraLookatTrackingSettings");
			EnableLookAtTracking = false;
			DrawDebugLookAtTrackingPosition = false;
			LookAtTrackingInterpSpeed = 0f;
			ActorToTrack = default(TSoftObject<AActor>);
			RelativeOffset = default(FVector);
			AllowRoll = false;
		}
		else
		{
			EnableLookAtTracking = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableLookAtTracking_Offset), 0, EnableLookAtTracking_PropertyAddress.Address);
			DrawDebugLookAtTrackingPosition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DrawDebugLookAtTrackingPosition_Offset), 0, DrawDebugLookAtTrackingPosition_PropertyAddress.Address);
			LookAtTrackingInterpSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LookAtTrackingInterpSpeed_Offset));
			ActorToTrack = TSoftObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, ActorToTrack_Offset));
			RelativeOffset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, RelativeOffset_Offset));
			AllowRoll = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AllowRoll_Offset), 0, AllowRoll_PropertyAddress.Address);
		}
	}

	static FCameraLookatTrackingSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCameraLookatTrackingSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCameraLookatTrackingSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CinematicCamera.CameraLookatTrackingSettings");
		FCameraLookatTrackingSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref EnableLookAtTracking_PropertyAddress, intPtr, "bEnableLookAtTracking");
		EnableLookAtTracking_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableLookAtTracking");
		EnableLookAtTracking_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableLookAtTracking", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDebugLookAtTrackingPosition_PropertyAddress, intPtr, "bDrawDebugLookAtTrackingPosition");
		DrawDebugLookAtTrackingPosition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDrawDebugLookAtTrackingPosition");
		DrawDebugLookAtTrackingPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDrawDebugLookAtTrackingPosition", Classes.FBoolProperty);
		LookAtTrackingInterpSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LookAtTrackingInterpSpeed");
		LookAtTrackingInterpSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LookAtTrackingInterpSpeed", Classes.FFloatProperty);
		ActorToTrack_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorToTrack");
		ActorToTrack_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorToTrack", Classes.FSoftObjectProperty);
		RelativeOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RelativeOffset");
		RelativeOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RelativeOffset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowRoll_PropertyAddress, intPtr, "bAllowRoll");
		AllowRoll_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowRoll");
		AllowRoll_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowRoll", Classes.FBoolProperty);
		FCameraLookatTrackingSettings_IsValid = intPtr != IntPtr.Zero && EnableLookAtTracking_IsValid && DrawDebugLookAtTrackingPosition_IsValid && LookAtTrackingInterpSpeed_IsValid && ActorToTrack_IsValid && RelativeOffset_IsValid && AllowRoll_IsValid;
		NativeReflection.LogStructIsValid("/Script/CinematicCamera.CameraLookatTrackingSettings", FCameraLookatTrackingSettings_IsValid);
	}
}
