using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.MinimalViewInfo", "Engine", UnrealModuleType.Engine)]
public struct FMinimalViewInfo
{
	private static bool Location_IsValid;

	private static int Location_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MinimalViewInfo:Location")]
	public FVector Location;

	private static bool Rotation_IsValid;

	private static int Rotation_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/Engine.MinimalViewInfo:Rotation")]
	public FRotator Rotation;

	private static bool FOV_IsValid;

	private static int FOV_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MinimalViewInfo:FOV")]
	public float FOV;

	private static bool OrthoWidth_IsValid;

	private static int OrthoWidth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MinimalViewInfo:OrthoWidth")]
	public float OrthoWidth;

	private static bool OrthoNearClipPlane_IsValid;

	private static int OrthoNearClipPlane_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.MinimalViewInfo:OrthoNearClipPlane")]
	public float OrthoNearClipPlane;

	private static bool OrthoFarClipPlane_IsValid;

	private static int OrthoFarClipPlane_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.MinimalViewInfo:OrthoFarClipPlane")]
	public float OrthoFarClipPlane;

	private static bool AspectRatio_IsValid;

	private static int AspectRatio_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MinimalViewInfo:AspectRatio")]
	public float AspectRatio;

	private static bool ConstrainAspectRatio_IsValid;

	private static FFieldAddress ConstrainAspectRatio_PropertyAddress;

	private static int ConstrainAspectRatio_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MinimalViewInfo:bConstrainAspectRatio")]
	public bool ConstrainAspectRatio;

	private static bool UseFieldOfViewForLOD_IsValid;

	private static FFieldAddress UseFieldOfViewForLOD_PropertyAddress;

	private static int UseFieldOfViewForLOD_Offset;

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.MinimalViewInfo:bUseFieldOfViewForLOD")]
	public bool UseFieldOfViewForLOD;

	private static bool ProjectionMode_IsValid;

	private static FFieldAddress ProjectionMode_PropertyAddress;

	private static int ProjectionMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MinimalViewInfo:ProjectionMode")]
	public ECameraProjectionMode ProjectionMode;

	private static bool PostProcessBlendWeight_IsValid;

	private static int PostProcessBlendWeight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Engine.MinimalViewInfo:PostProcessBlendWeight")]
	public float PostProcessBlendWeight;

	private static bool PostProcessSettings_IsValid;

	private static int PostProcessSettings_Offset;

	[UProperty(Flags = (PropFlags)4503599627370500uL)]
	[UMetaPath("/Script/Engine.MinimalViewInfo:PostProcessSettings")]
	public FPostProcessSettings PostProcessSettings;

	private static bool OffCenterProjectionOffset_IsValid;

	private static int OffCenterProjectionOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234416133uL)]
	[UMetaPath("/Script/Engine.MinimalViewInfo:OffCenterProjectionOffset")]
	public FVector2D OffCenterProjectionOffset;

	private static bool FMinimalViewInfo_IsValid;

	private static int FMinimalViewInfo_StructSize;

	public FMinimalViewInfo Copy()
	{
		return this;
	}

	public static FMinimalViewInfo FromNative(IntPtr nativeBuffer)
	{
		return new FMinimalViewInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMinimalViewInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMinimalViewInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMinimalViewInfo(nativeBuffer + arrayIndex * FMinimalViewInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMinimalViewInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMinimalViewInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMinimalViewInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MinimalViewInfo");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, Rotation_Offset), Rotation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FOV_Offset), FOV);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OrthoWidth_Offset), OrthoWidth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OrthoNearClipPlane_Offset), OrthoNearClipPlane);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OrthoFarClipPlane_Offset), OrthoFarClipPlane);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AspectRatio_Offset), AspectRatio);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ConstrainAspectRatio_Offset), 0, ConstrainAspectRatio_PropertyAddress.Address, ConstrainAspectRatio);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseFieldOfViewForLOD_Offset), 0, UseFieldOfViewForLOD_PropertyAddress.Address, UseFieldOfViewForLOD);
		EnumMarshaler<ECameraProjectionMode>.ToNative(IntPtr.Add(nativeStruct, ProjectionMode_Offset), 0, ProjectionMode_PropertyAddress.Address, ProjectionMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PostProcessBlendWeight_Offset), PostProcessBlendWeight);
		FPostProcessSettings.ToNative(IntPtr.Add(nativeStruct, PostProcessSettings_Offset), PostProcessSettings);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, OffCenterProjectionOffset_Offset), OffCenterProjectionOffset);
	}

	public FMinimalViewInfo(IntPtr nativeStruct)
	{
		if (!FMinimalViewInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MinimalViewInfo");
			Location = default(FVector);
			Rotation = default(FRotator);
			FOV = 0f;
			OrthoWidth = 0f;
			OrthoNearClipPlane = 0f;
			OrthoFarClipPlane = 0f;
			AspectRatio = 0f;
			ConstrainAspectRatio = false;
			UseFieldOfViewForLOD = false;
			ProjectionMode = ECameraProjectionMode.Perspective;
			PostProcessBlendWeight = 0f;
			PostProcessSettings = default(FPostProcessSettings);
			OffCenterProjectionOffset = default(FVector2D);
		}
		else
		{
			Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
			Rotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, Rotation_Offset));
			FOV = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FOV_Offset));
			OrthoWidth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OrthoWidth_Offset));
			OrthoNearClipPlane = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OrthoNearClipPlane_Offset));
			OrthoFarClipPlane = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OrthoFarClipPlane_Offset));
			AspectRatio = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AspectRatio_Offset));
			ConstrainAspectRatio = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ConstrainAspectRatio_Offset), 0, ConstrainAspectRatio_PropertyAddress.Address);
			UseFieldOfViewForLOD = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseFieldOfViewForLOD_Offset), 0, UseFieldOfViewForLOD_PropertyAddress.Address);
			ProjectionMode = EnumMarshaler<ECameraProjectionMode>.FromNative(IntPtr.Add(nativeStruct, ProjectionMode_Offset), 0, ProjectionMode_PropertyAddress.Address);
			PostProcessBlendWeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PostProcessBlendWeight_Offset));
			PostProcessSettings = FPostProcessSettings.FromNative(IntPtr.Add(nativeStruct, PostProcessSettings_Offset));
			OffCenterProjectionOffset = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, OffCenterProjectionOffset_Offset));
		}
	}

	static FMinimalViewInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMinimalViewInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMinimalViewInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.MinimalViewInfo");
		FMinimalViewInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		Location_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Location", Classes.FStructProperty);
		Rotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Rotation");
		Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Rotation", Classes.FStructProperty);
		FOV_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FOV");
		FOV_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FOV", Classes.FFloatProperty);
		OrthoWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OrthoWidth");
		OrthoWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OrthoWidth", Classes.FFloatProperty);
		OrthoNearClipPlane_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OrthoNearClipPlane");
		OrthoNearClipPlane_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OrthoNearClipPlane", Classes.FFloatProperty);
		OrthoFarClipPlane_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OrthoFarClipPlane");
		OrthoFarClipPlane_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OrthoFarClipPlane", Classes.FFloatProperty);
		AspectRatio_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AspectRatio");
		AspectRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AspectRatio", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ConstrainAspectRatio_PropertyAddress, intPtr, "bConstrainAspectRatio");
		ConstrainAspectRatio_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bConstrainAspectRatio");
		ConstrainAspectRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bConstrainAspectRatio", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseFieldOfViewForLOD_PropertyAddress, intPtr, "bUseFieldOfViewForLOD");
		UseFieldOfViewForLOD_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseFieldOfViewForLOD");
		UseFieldOfViewForLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseFieldOfViewForLOD", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectionMode_PropertyAddress, intPtr, "ProjectionMode");
		ProjectionMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ProjectionMode");
		ProjectionMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ProjectionMode", Classes.FByteProperty);
		PostProcessBlendWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PostProcessBlendWeight");
		PostProcessBlendWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PostProcessBlendWeight", Classes.FFloatProperty);
		PostProcessSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PostProcessSettings");
		PostProcessSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PostProcessSettings", Classes.FStructProperty);
		OffCenterProjectionOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OffCenterProjectionOffset");
		OffCenterProjectionOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OffCenterProjectionOffset", Classes.FStructProperty);
		FMinimalViewInfo_IsValid = intPtr != IntPtr.Zero && Location_IsValid && Rotation_IsValid && FOV_IsValid && OrthoWidth_IsValid && OrthoNearClipPlane_IsValid && OrthoFarClipPlane_IsValid && AspectRatio_IsValid && ConstrainAspectRatio_IsValid && UseFieldOfViewForLOD_IsValid && ProjectionMode_IsValid && PostProcessBlendWeight_IsValid && PostProcessSettings_IsValid && OffCenterProjectionOffset_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.MinimalViewInfo", FMinimalViewInfo_IsValid);
	}
}
