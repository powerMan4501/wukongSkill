using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.IKRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/IKRig.IKRigGoal", "IKRig", UnrealModuleType.EnginePlugin)]
public struct FIKRigGoal
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/IKRig.IKRigGoal:Name")]
	public FName Name;

	private static bool TransformSource_IsValid;

	private static FFieldAddress TransformSource_PropertyAddress;

	private static int TransformSource_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/IKRig.IKRigGoal:TransformSource")]
	public EIKRigGoalTransformSource TransformSource;

	private static bool Position_IsValid;

	private static int Position_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/IKRig.IKRigGoal:Position")]
	public FVector Position;

	private static bool Rotation_IsValid;

	private static int Rotation_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/IKRig.IKRigGoal:Rotation")]
	public FRotator Rotation;

	private static bool PositionAlpha_IsValid;

	private static int PositionAlpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/IKRig.IKRigGoal:PositionAlpha")]
	public float PositionAlpha;

	private static bool RotationAlpha_IsValid;

	private static int RotationAlpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/IKRig.IKRigGoal:RotationAlpha")]
	public float RotationAlpha;

	private static bool PositionSpace_IsValid;

	private static FFieldAddress PositionSpace_PropertyAddress;

	private static int PositionSpace_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/IKRig.IKRigGoal:PositionSpace")]
	public EIKRigGoalSpace PositionSpace;

	private static bool RotationSpace_IsValid;

	private static FFieldAddress RotationSpace_PropertyAddress;

	private static int RotationSpace_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/IKRig.IKRigGoal:RotationSpace")]
	public EIKRigGoalSpace RotationSpace;

	private static bool FIKRigGoal_IsValid;

	private static int FIKRigGoal_StructSize;

	public FIKRigGoal Copy()
	{
		return this;
	}

	public static FIKRigGoal FromNative(IntPtr nativeBuffer)
	{
		return new FIKRigGoal(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FIKRigGoal value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FIKRigGoal FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FIKRigGoal(nativeBuffer + arrayIndex * FIKRigGoal_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FIKRigGoal value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FIKRigGoal_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FIKRigGoal_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/IKRig.IKRigGoal");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		EnumMarshaler<EIKRigGoalTransformSource>.ToNative(IntPtr.Add(nativeStruct, TransformSource_Offset), 0, TransformSource_PropertyAddress.Address, TransformSource);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Position_Offset), Position);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, Rotation_Offset), Rotation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PositionAlpha_Offset), PositionAlpha);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RotationAlpha_Offset), RotationAlpha);
		EnumMarshaler<EIKRigGoalSpace>.ToNative(IntPtr.Add(nativeStruct, PositionSpace_Offset), 0, PositionSpace_PropertyAddress.Address, PositionSpace);
		EnumMarshaler<EIKRigGoalSpace>.ToNative(IntPtr.Add(nativeStruct, RotationSpace_Offset), 0, RotationSpace_PropertyAddress.Address, RotationSpace);
	}

	public FIKRigGoal(IntPtr nativeStruct)
	{
		if (!FIKRigGoal_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/IKRig.IKRigGoal");
			Name = default(FName);
			TransformSource = EIKRigGoalTransformSource.Manual;
			Position = default(FVector);
			Rotation = default(FRotator);
			PositionAlpha = 0f;
			RotationAlpha = 0f;
			PositionSpace = EIKRigGoalSpace.Component;
			RotationSpace = EIKRigGoalSpace.Component;
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			TransformSource = EnumMarshaler<EIKRigGoalTransformSource>.FromNative(IntPtr.Add(nativeStruct, TransformSource_Offset), 0, TransformSource_PropertyAddress.Address);
			Position = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Position_Offset));
			Rotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, Rotation_Offset));
			PositionAlpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PositionAlpha_Offset));
			RotationAlpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RotationAlpha_Offset));
			PositionSpace = EnumMarshaler<EIKRigGoalSpace>.FromNative(IntPtr.Add(nativeStruct, PositionSpace_Offset), 0, PositionSpace_PropertyAddress.Address);
			RotationSpace = EnumMarshaler<EIKRigGoalSpace>.FromNative(IntPtr.Add(nativeStruct, RotationSpace_Offset), 0, RotationSpace_PropertyAddress.Address);
		}
	}

	static FIKRigGoal()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FIKRigGoal)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FIKRigGoal));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/IKRig.IKRigGoal");
		FIKRigGoal_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformSource_PropertyAddress, intPtr, "TransformSource");
		TransformSource_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TransformSource");
		TransformSource_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TransformSource", Classes.FEnumProperty);
		Position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Position");
		Position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Position", Classes.FStructProperty);
		Rotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Rotation");
		Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Rotation", Classes.FStructProperty);
		PositionAlpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PositionAlpha");
		PositionAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PositionAlpha", Classes.FFloatProperty);
		RotationAlpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RotationAlpha");
		RotationAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RotationAlpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PositionSpace_PropertyAddress, intPtr, "PositionSpace");
		PositionSpace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PositionSpace");
		PositionSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PositionSpace", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref RotationSpace_PropertyAddress, intPtr, "RotationSpace");
		RotationSpace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RotationSpace");
		RotationSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RotationSpace", Classes.FEnumProperty);
		FIKRigGoal_IsValid = intPtr != IntPtr.Zero && Name_IsValid && TransformSource_IsValid && Position_IsValid && Rotation_IsValid && PositionAlpha_IsValid && RotationAlpha_IsValid && PositionSpace_IsValid && RotationSpace_IsValid;
		NativeReflection.LogStructIsValid("/Script/IKRig.IKRigGoal", FIKRigGoal_IsValid);
	}
}
