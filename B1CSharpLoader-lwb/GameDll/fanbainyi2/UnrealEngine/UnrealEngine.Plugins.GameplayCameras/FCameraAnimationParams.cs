using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GameplayCameras;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GameplayCameras.CameraAnimationParams", "GameplayCameras", UnrealModuleType.EnginePlugin)]
public struct FCameraAnimationParams
{
	private static bool PlayRate_IsValid;

	private static int PlayRate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GameplayCameras.CameraAnimationParams:PlayRate")]
	public float PlayRate;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GameplayCameras.CameraAnimationParams:Scale")]
	public float Scale;

	private static bool EaseInType_IsValid;

	private static FFieldAddress EaseInType_PropertyAddress;

	private static int EaseInType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GameplayCameras.CameraAnimationParams:EaseInType")]
	public ECameraAnimationEasingType EaseInType;

	private static bool EaseInDuration_IsValid;

	private static int EaseInDuration_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GameplayCameras.CameraAnimationParams:EaseInDuration")]
	public float EaseInDuration;

	private static bool EaseOutType_IsValid;

	private static FFieldAddress EaseOutType_PropertyAddress;

	private static int EaseOutType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GameplayCameras.CameraAnimationParams:EaseOutType")]
	public ECameraAnimationEasingType EaseOutType;

	private static bool EaseOutDuration_IsValid;

	private static int EaseOutDuration_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GameplayCameras.CameraAnimationParams:EaseOutDuration")]
	public float EaseOutDuration;

	private static bool Loop_IsValid;

	private static FFieldAddress Loop_PropertyAddress;

	private static int Loop_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GameplayCameras.CameraAnimationParams:bLoop")]
	public bool Loop;

	private static bool RandomStartTime_IsValid;

	private static FFieldAddress RandomStartTime_PropertyAddress;

	private static int RandomStartTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GameplayCameras.CameraAnimationParams:bRandomStartTime")]
	public bool RandomStartTime;

	private static bool DurationOverride_IsValid;

	private static int DurationOverride_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GameplayCameras.CameraAnimationParams:DurationOverride")]
	public float DurationOverride;

	private static bool PlaySpace_IsValid;

	private static FFieldAddress PlaySpace_PropertyAddress;

	private static int PlaySpace_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GameplayCameras.CameraAnimationParams:PlaySpace")]
	public ECameraAnimationPlaySpace PlaySpace;

	private static bool UserPlaySpaceRot_IsValid;

	private static int UserPlaySpaceRot_Offset;

	[UProperty(Flags = (PropFlags)4503669420589572uL)]
	[UMetaPath("/Script/GameplayCameras.CameraAnimationParams:UserPlaySpaceRot")]
	public FRotator UserPlaySpaceRot;

	private static bool FCameraAnimationParams_IsValid;

	private static int FCameraAnimationParams_StructSize;

	public FCameraAnimationParams Copy()
	{
		return this;
	}

	public static FCameraAnimationParams FromNative(IntPtr nativeBuffer)
	{
		return new FCameraAnimationParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCameraAnimationParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCameraAnimationParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCameraAnimationParams(nativeBuffer + arrayIndex * FCameraAnimationParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCameraAnimationParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCameraAnimationParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCameraAnimationParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayCameras.CameraAnimationParams");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PlayRate_Offset), PlayRate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), Scale);
		EnumMarshaler<ECameraAnimationEasingType>.ToNative(IntPtr.Add(nativeStruct, EaseInType_Offset), 0, EaseInType_PropertyAddress.Address, EaseInType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, EaseInDuration_Offset), EaseInDuration);
		EnumMarshaler<ECameraAnimationEasingType>.ToNative(IntPtr.Add(nativeStruct, EaseOutType_Offset), 0, EaseOutType_PropertyAddress.Address, EaseOutType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, EaseOutDuration_Offset), EaseOutDuration);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Loop_Offset), 0, Loop_PropertyAddress.Address, Loop);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RandomStartTime_Offset), 0, RandomStartTime_PropertyAddress.Address, RandomStartTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DurationOverride_Offset), DurationOverride);
		EnumMarshaler<ECameraAnimationPlaySpace>.ToNative(IntPtr.Add(nativeStruct, PlaySpace_Offset), 0, PlaySpace_PropertyAddress.Address, PlaySpace);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, UserPlaySpaceRot_Offset), UserPlaySpaceRot);
	}

	public FCameraAnimationParams(IntPtr nativeStruct)
	{
		if (!FCameraAnimationParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayCameras.CameraAnimationParams");
			PlayRate = 0f;
			Scale = 0f;
			EaseInType = ECameraAnimationEasingType.Linear;
			EaseInDuration = 0f;
			EaseOutType = ECameraAnimationEasingType.Linear;
			EaseOutDuration = 0f;
			Loop = false;
			RandomStartTime = false;
			DurationOverride = 0f;
			PlaySpace = ECameraAnimationPlaySpace.CameraLocal;
			UserPlaySpaceRot = default(FRotator);
		}
		else
		{
			PlayRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PlayRate_Offset));
			Scale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Scale_Offset));
			EaseInType = EnumMarshaler<ECameraAnimationEasingType>.FromNative(IntPtr.Add(nativeStruct, EaseInType_Offset), 0, EaseInType_PropertyAddress.Address);
			EaseInDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, EaseInDuration_Offset));
			EaseOutType = EnumMarshaler<ECameraAnimationEasingType>.FromNative(IntPtr.Add(nativeStruct, EaseOutType_Offset), 0, EaseOutType_PropertyAddress.Address);
			EaseOutDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, EaseOutDuration_Offset));
			Loop = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Loop_Offset), 0, Loop_PropertyAddress.Address);
			RandomStartTime = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RandomStartTime_Offset), 0, RandomStartTime_PropertyAddress.Address);
			DurationOverride = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DurationOverride_Offset));
			PlaySpace = EnumMarshaler<ECameraAnimationPlaySpace>.FromNative(IntPtr.Add(nativeStruct, PlaySpace_Offset), 0, PlaySpace_PropertyAddress.Address);
			UserPlaySpaceRot = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, UserPlaySpaceRot_Offset));
		}
	}

	static FCameraAnimationParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCameraAnimationParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCameraAnimationParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GameplayCameras.CameraAnimationParams");
		FCameraAnimationParams_StructSize = NativeReflection.GetStructSize(intPtr);
		PlayRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayRate");
		PlayRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayRate", Classes.FFloatProperty);
		Scale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Scale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EaseInType_PropertyAddress, intPtr, "EaseInType");
		EaseInType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EaseInType");
		EaseInType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EaseInType", Classes.FEnumProperty);
		EaseInDuration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EaseInDuration");
		EaseInDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EaseInDuration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EaseOutType_PropertyAddress, intPtr, "EaseOutType");
		EaseOutType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EaseOutType");
		EaseOutType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EaseOutType", Classes.FEnumProperty);
		EaseOutDuration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EaseOutDuration");
		EaseOutDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EaseOutDuration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Loop_PropertyAddress, intPtr, "bLoop");
		Loop_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLoop");
		Loop_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLoop", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RandomStartTime_PropertyAddress, intPtr, "bRandomStartTime");
		RandomStartTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRandomStartTime");
		RandomStartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRandomStartTime", Classes.FBoolProperty);
		DurationOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DurationOverride");
		DurationOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DurationOverride", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlaySpace_PropertyAddress, intPtr, "PlaySpace");
		PlaySpace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlaySpace");
		PlaySpace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlaySpace", Classes.FEnumProperty);
		UserPlaySpaceRot_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UserPlaySpaceRot");
		UserPlaySpaceRot_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UserPlaySpaceRot", Classes.FStructProperty);
		FCameraAnimationParams_IsValid = intPtr != IntPtr.Zero && PlayRate_IsValid && Scale_IsValid && EaseInType_IsValid && EaseInDuration_IsValid && EaseOutType_IsValid && EaseOutDuration_IsValid && Loop_IsValid && RandomStartTime_IsValid && DurationOverride_IsValid && PlaySpace_IsValid && UserPlaySpaceRot_IsValid;
		NativeReflection.LogStructIsValid("/Script/GameplayCameras.CameraAnimationParams", FCameraAnimationParams_IsValid);
	}
}
