using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.PhysicalAnimationData", "Engine", UnrealModuleType.Engine)]
public struct FPhysicalAnimationData
{
	private static bool IsLocalSimulation_IsValid;

	private static FFieldAddress IsLocalSimulation_PropertyAddress;

	private static int IsLocalSimulation_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PhysicalAnimationData:bIsLocalSimulation")]
	public bool IsLocalSimulation;

	private static bool OrientationStrength_IsValid;

	private static int OrientationStrength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicalAnimationData:OrientationStrength")]
	public float OrientationStrength;

	private static bool AngularVelocityStrength_IsValid;

	private static int AngularVelocityStrength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicalAnimationData:AngularVelocityStrength")]
	public float AngularVelocityStrength;

	private static bool PositionStrength_IsValid;

	private static int PositionStrength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicalAnimationData:PositionStrength")]
	public float PositionStrength;

	private static bool VelocityStrength_IsValid;

	private static int VelocityStrength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicalAnimationData:VelocityStrength")]
	public float VelocityStrength;

	private static bool MaxLinearForce_IsValid;

	private static int MaxLinearForce_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicalAnimationData:MaxLinearForce")]
	public float MaxLinearForce;

	private static bool MaxAngularForce_IsValid;

	private static int MaxAngularForce_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicalAnimationData:MaxAngularForce")]
	public float MaxAngularForce;

	private static bool FPhysicalAnimationData_IsValid;

	private static int FPhysicalAnimationData_StructSize;

	public FPhysicalAnimationData Copy()
	{
		return this;
	}

	public static FPhysicalAnimationData FromNative(IntPtr nativeBuffer)
	{
		return new FPhysicalAnimationData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPhysicalAnimationData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPhysicalAnimationData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPhysicalAnimationData(nativeBuffer + arrayIndex * FPhysicalAnimationData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPhysicalAnimationData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPhysicalAnimationData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPhysicalAnimationData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PhysicalAnimationData");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsLocalSimulation_Offset), 0, IsLocalSimulation_PropertyAddress.Address, IsLocalSimulation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OrientationStrength_Offset), OrientationStrength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AngularVelocityStrength_Offset), AngularVelocityStrength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PositionStrength_Offset), PositionStrength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, VelocityStrength_Offset), VelocityStrength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxLinearForce_Offset), MaxLinearForce);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxAngularForce_Offset), MaxAngularForce);
	}

	public FPhysicalAnimationData(IntPtr nativeStruct)
	{
		if (!FPhysicalAnimationData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PhysicalAnimationData");
			IsLocalSimulation = false;
			OrientationStrength = 0f;
			AngularVelocityStrength = 0f;
			PositionStrength = 0f;
			VelocityStrength = 0f;
			MaxLinearForce = 0f;
			MaxAngularForce = 0f;
		}
		else
		{
			IsLocalSimulation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsLocalSimulation_Offset), 0, IsLocalSimulation_PropertyAddress.Address);
			OrientationStrength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OrientationStrength_Offset));
			AngularVelocityStrength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AngularVelocityStrength_Offset));
			PositionStrength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PositionStrength_Offset));
			VelocityStrength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, VelocityStrength_Offset));
			MaxLinearForce = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxLinearForce_Offset));
			MaxAngularForce = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxAngularForce_Offset));
		}
	}

	static FPhysicalAnimationData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPhysicalAnimationData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPhysicalAnimationData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.PhysicalAnimationData");
		FPhysicalAnimationData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref IsLocalSimulation_PropertyAddress, intPtr, "bIsLocalSimulation");
		IsLocalSimulation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsLocalSimulation");
		IsLocalSimulation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsLocalSimulation", Classes.FBoolProperty);
		OrientationStrength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OrientationStrength");
		OrientationStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OrientationStrength", Classes.FFloatProperty);
		AngularVelocityStrength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AngularVelocityStrength");
		AngularVelocityStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AngularVelocityStrength", Classes.FFloatProperty);
		PositionStrength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PositionStrength");
		PositionStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PositionStrength", Classes.FFloatProperty);
		VelocityStrength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VelocityStrength");
		VelocityStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VelocityStrength", Classes.FFloatProperty);
		MaxLinearForce_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxLinearForce");
		MaxLinearForce_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxLinearForce", Classes.FFloatProperty);
		MaxAngularForce_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxAngularForce");
		MaxAngularForce_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxAngularForce", Classes.FFloatProperty);
		FPhysicalAnimationData_IsValid = intPtr != IntPtr.Zero && IsLocalSimulation_IsValid && OrientationStrength_IsValid && AngularVelocityStrength_IsValid && PositionStrength_IsValid && VelocityStrength_IsValid && MaxLinearForce_IsValid && MaxAngularForce_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.PhysicalAnimationData", FPhysicalAnimationData_IsValid);
	}
}
