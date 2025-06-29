using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 266753)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.SimSpaceSettings", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FSimSpaceSettings
{
	private static bool MasterAlpha_IsValid;

	private static int MasterAlpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.SimSpaceSettings:MasterAlpha")]
	public float MasterAlpha;

	private static bool VelocityScaleZ_IsValid;

	private static int VelocityScaleZ_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.SimSpaceSettings:VelocityScaleZ")]
	public float VelocityScaleZ;

	private static bool MaxLinearVelocity_IsValid;

	private static int MaxLinearVelocity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.SimSpaceSettings:MaxLinearVelocity")]
	public float MaxLinearVelocity;

	private static bool MaxAngularVelocity_IsValid;

	private static int MaxAngularVelocity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.SimSpaceSettings:MaxAngularVelocity")]
	public float MaxAngularVelocity;

	private static bool MaxLinearAcceleration_IsValid;

	private static int MaxLinearAcceleration_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.SimSpaceSettings:MaxLinearAcceleration")]
	public float MaxLinearAcceleration;

	private static bool MaxAngularAcceleration_IsValid;

	private static int MaxAngularAcceleration_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.SimSpaceSettings:MaxAngularAcceleration")]
	public float MaxAngularAcceleration;

	private static bool ExternalLinearDragV_IsValid;

	private static int ExternalLinearDragV_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.SimSpaceSettings:ExternalLinearDragV")]
	public FVector ExternalLinearDragV;

	private static bool ExternalLinearVelocity_IsValid;

	private static int ExternalLinearVelocity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.SimSpaceSettings:ExternalLinearVelocity")]
	public FVector ExternalLinearVelocity;

	private static bool ExternalAngularVelocity_IsValid;

	private static int ExternalAngularVelocity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.SimSpaceSettings:ExternalAngularVelocity")]
	public FVector ExternalAngularVelocity;

	private static bool FSimSpaceSettings_IsValid;

	private static int FSimSpaceSettings_StructSize;

	public FSimSpaceSettings Copy()
	{
		return this;
	}

	public static FSimSpaceSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSimSpaceSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSimSpaceSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSimSpaceSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSimSpaceSettings(nativeBuffer + arrayIndex * FSimSpaceSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSimSpaceSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSimSpaceSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSimSpaceSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.SimSpaceSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MasterAlpha_Offset), MasterAlpha);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, VelocityScaleZ_Offset), VelocityScaleZ);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxLinearVelocity_Offset), MaxLinearVelocity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxAngularVelocity_Offset), MaxAngularVelocity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxLinearAcceleration_Offset), MaxLinearAcceleration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxAngularAcceleration_Offset), MaxAngularAcceleration);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, ExternalLinearDragV_Offset), ExternalLinearDragV);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, ExternalLinearVelocity_Offset), ExternalLinearVelocity);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, ExternalAngularVelocity_Offset), ExternalAngularVelocity);
	}

	public FSimSpaceSettings(IntPtr nativeStruct)
	{
		if (!FSimSpaceSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.SimSpaceSettings");
			MasterAlpha = 0f;
			VelocityScaleZ = 0f;
			MaxLinearVelocity = 0f;
			MaxAngularVelocity = 0f;
			MaxLinearAcceleration = 0f;
			MaxAngularAcceleration = 0f;
			ExternalLinearDragV = default(FVector);
			ExternalLinearVelocity = default(FVector);
			ExternalAngularVelocity = default(FVector);
		}
		else
		{
			MasterAlpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MasterAlpha_Offset));
			VelocityScaleZ = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, VelocityScaleZ_Offset));
			MaxLinearVelocity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxLinearVelocity_Offset));
			MaxAngularVelocity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxAngularVelocity_Offset));
			MaxLinearAcceleration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxLinearAcceleration_Offset));
			MaxAngularAcceleration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxAngularAcceleration_Offset));
			ExternalLinearDragV = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, ExternalLinearDragV_Offset));
			ExternalLinearVelocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, ExternalLinearVelocity_Offset));
			ExternalAngularVelocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, ExternalAngularVelocity_Offset));
		}
	}

	static FSimSpaceSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSimSpaceSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSimSpaceSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.SimSpaceSettings");
		FSimSpaceSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		MasterAlpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MasterAlpha");
		MasterAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MasterAlpha", Classes.FFloatProperty);
		VelocityScaleZ_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VelocityScaleZ");
		VelocityScaleZ_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VelocityScaleZ", Classes.FFloatProperty);
		MaxLinearVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxLinearVelocity");
		MaxLinearVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxLinearVelocity", Classes.FFloatProperty);
		MaxAngularVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxAngularVelocity");
		MaxAngularVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxAngularVelocity", Classes.FFloatProperty);
		MaxLinearAcceleration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxLinearAcceleration");
		MaxLinearAcceleration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxLinearAcceleration", Classes.FFloatProperty);
		MaxAngularAcceleration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxAngularAcceleration");
		MaxAngularAcceleration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxAngularAcceleration", Classes.FFloatProperty);
		ExternalLinearDragV_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExternalLinearDragV");
		ExternalLinearDragV_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExternalLinearDragV", Classes.FStructProperty);
		ExternalLinearVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExternalLinearVelocity");
		ExternalLinearVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExternalLinearVelocity", Classes.FStructProperty);
		ExternalAngularVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExternalAngularVelocity");
		ExternalAngularVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExternalAngularVelocity", Classes.FStructProperty);
		FSimSpaceSettings_IsValid = intPtr != IntPtr.Zero && MasterAlpha_IsValid && VelocityScaleZ_IsValid && MaxLinearVelocity_IsValid && MaxAngularVelocity_IsValid && MaxLinearAcceleration_IsValid && MaxAngularAcceleration_IsValid && ExternalLinearDragV_IsValid && ExternalLinearVelocity_IsValid && ExternalAngularVelocity_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.SimSpaceSettings", FSimSpaceSettings_IsValid);
	}
}
