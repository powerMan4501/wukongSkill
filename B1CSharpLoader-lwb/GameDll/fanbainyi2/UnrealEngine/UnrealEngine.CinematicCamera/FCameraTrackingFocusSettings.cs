using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.CinematicCamera;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CinematicCamera.CameraTrackingFocusSettings", "CinematicCamera", UnrealModuleType.Engine)]
public struct FCameraTrackingFocusSettings
{
	private static bool ActorToTrack_IsValid;

	private static int ActorToTrack_Offset;

	[UProperty(Flags = (PropFlags)7881307937832965uL)]
	[UMetaPath("/Script/CinematicCamera.CameraTrackingFocusSettings:ActorToTrack")]
	public TSoftObject<AActor> ActorToTrack;

	private static bool RelativeOffset_IsValid;

	private static int RelativeOffset_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/CinematicCamera.CameraTrackingFocusSettings:RelativeOffset")]
	public FVector RelativeOffset;

	private static bool DrawDebugTrackingFocusPoint_IsValid;

	private static FFieldAddress DrawDebugTrackingFocusPoint_PropertyAddress;

	private static int DrawDebugTrackingFocusPoint_Offset;

	[UProperty(Flags = (PropFlags)6755468160540677uL)]
	[UMetaPath("/Script/CinematicCamera.CameraTrackingFocusSettings:bDrawDebugTrackingFocusPoint")]
	public bool DrawDebugTrackingFocusPoint;

	private static bool FCameraTrackingFocusSettings_IsValid;

	private static int FCameraTrackingFocusSettings_StructSize;

	public FCameraTrackingFocusSettings Copy()
	{
		return this;
	}

	public static FCameraTrackingFocusSettings FromNative(IntPtr nativeBuffer)
	{
		return new FCameraTrackingFocusSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCameraTrackingFocusSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCameraTrackingFocusSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCameraTrackingFocusSettings(nativeBuffer + arrayIndex * FCameraTrackingFocusSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCameraTrackingFocusSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCameraTrackingFocusSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCameraTrackingFocusSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CinematicCamera.CameraTrackingFocusSettings");
			return;
		}
		TSoftObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, ActorToTrack_Offset), ActorToTrack);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, RelativeOffset_Offset), RelativeOffset);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DrawDebugTrackingFocusPoint_Offset), 0, DrawDebugTrackingFocusPoint_PropertyAddress.Address, DrawDebugTrackingFocusPoint);
	}

	public FCameraTrackingFocusSettings(IntPtr nativeStruct)
	{
		if (!FCameraTrackingFocusSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CinematicCamera.CameraTrackingFocusSettings");
			ActorToTrack = default(TSoftObject<AActor>);
			RelativeOffset = default(FVector);
			DrawDebugTrackingFocusPoint = false;
		}
		else
		{
			ActorToTrack = TSoftObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, ActorToTrack_Offset));
			RelativeOffset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, RelativeOffset_Offset));
			DrawDebugTrackingFocusPoint = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DrawDebugTrackingFocusPoint_Offset), 0, DrawDebugTrackingFocusPoint_PropertyAddress.Address);
		}
	}

	static FCameraTrackingFocusSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCameraTrackingFocusSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCameraTrackingFocusSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CinematicCamera.CameraTrackingFocusSettings");
		FCameraTrackingFocusSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		ActorToTrack_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorToTrack");
		ActorToTrack_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorToTrack", Classes.FSoftObjectProperty);
		RelativeOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RelativeOffset");
		RelativeOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RelativeOffset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDebugTrackingFocusPoint_PropertyAddress, intPtr, "bDrawDebugTrackingFocusPoint");
		DrawDebugTrackingFocusPoint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDrawDebugTrackingFocusPoint");
		DrawDebugTrackingFocusPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDrawDebugTrackingFocusPoint", Classes.FBoolProperty);
		FCameraTrackingFocusSettings_IsValid = intPtr != IntPtr.Zero && ActorToTrack_IsValid && RelativeOffset_IsValid && DrawDebugTrackingFocusPoint_IsValid;
		NativeReflection.LogStructIsValid("/Script/CinematicCamera.CameraTrackingFocusSettings", FCameraTrackingFocusSettings_IsValid);
	}
}
