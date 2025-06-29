using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.MM;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/MM.DefaultMotionJointData", "MM", UnrealModuleType.GamePlugin)]
public struct FDefaultMotionJointData
{
	private static bool JointLocation_IsValid;

	private static FFieldAddress JointLocation_PropertyAddress;

	private static int JointLocation_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/MM.DefaultMotionJointData:JointLocation")]
	public List<FVector> JointLocation;

	private static bool JointVelocity_IsValid;

	private static FFieldAddress JointVelocity_PropertyAddress;

	private static int JointVelocity_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/MM.DefaultMotionJointData:JointVelocity")]
	public List<FVector> JointVelocity;

	private static bool FDefaultMotionJointData_IsValid;

	private static int FDefaultMotionJointData_StructSize;

	public FDefaultMotionJointData Copy()
	{
		FDefaultMotionJointData result = this;
		if (JointLocation != null)
		{
			result.JointLocation = new List<FVector>(JointLocation);
		}
		if (JointVelocity != null)
		{
			result.JointVelocity = new List<FVector>(JointVelocity);
		}
		return result;
	}

	public static FDefaultMotionJointData FromNative(IntPtr nativeBuffer)
	{
		return new FDefaultMotionJointData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDefaultMotionJointData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDefaultMotionJointData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDefaultMotionJointData(nativeBuffer + arrayIndex * FDefaultMotionJointData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDefaultMotionJointData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDefaultMotionJointData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDefaultMotionJointData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.DefaultMotionJointData");
			return;
		}
		new TArrayCopyMarshaler<FVector>(1, JointLocation_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(nativeStruct, JointLocation_Offset), JointLocation);
		new TArrayCopyMarshaler<FVector>(1, JointVelocity_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(nativeStruct, JointVelocity_Offset), JointVelocity);
	}

	public FDefaultMotionJointData(IntPtr nativeStruct)
	{
		if (!FDefaultMotionJointData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.DefaultMotionJointData");
			JointLocation = null;
			JointVelocity = null;
		}
		else
		{
			JointLocation = new TArrayCopyMarshaler<FVector>(1, JointLocation_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(nativeStruct, JointLocation_Offset));
			JointVelocity = new TArrayCopyMarshaler<FVector>(1, JointVelocity_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(nativeStruct, JointVelocity_Offset));
		}
	}

	static FDefaultMotionJointData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDefaultMotionJointData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDefaultMotionJointData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MM.DefaultMotionJointData");
		FDefaultMotionJointData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref JointLocation_PropertyAddress, intPtr, "JointLocation");
		JointLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JointLocation");
		JointLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JointLocation", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref JointVelocity_PropertyAddress, intPtr, "JointVelocity");
		JointVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JointVelocity");
		JointVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JointVelocity", Classes.FArrayProperty);
		FDefaultMotionJointData_IsValid = intPtr != IntPtr.Zero && JointLocation_IsValid && JointVelocity_IsValid;
		NativeReflection.LogStructIsValid("/Script/MM.DefaultMotionJointData", FDefaultMotionJointData_IsValid);
	}
}
