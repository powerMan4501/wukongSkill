using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.SolverIterations", "Engine", UnrealModuleType.Engine)]
public struct FSolverIterations
{
	private static bool SolverIterations_IsValid;

	private static int SolverIterations_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SolverIterations:SolverIterations")]
	public int SolverIterations;

	private static bool JointIterations_IsValid;

	private static int JointIterations_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SolverIterations:JointIterations")]
	public int JointIterations;

	private static bool CollisionIterations_IsValid;

	private static int CollisionIterations_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SolverIterations:CollisionIterations")]
	public int CollisionIterations;

	private static bool SolverPushOutIterations_IsValid;

	private static int SolverPushOutIterations_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SolverIterations:SolverPushOutIterations")]
	public int SolverPushOutIterations;

	private static bool JointPushOutIterations_IsValid;

	private static int JointPushOutIterations_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SolverIterations:JointPushOutIterations")]
	public int JointPushOutIterations;

	private static bool CollisionPushOutIterations_IsValid;

	private static int CollisionPushOutIterations_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SolverIterations:CollisionPushOutIterations")]
	public int CollisionPushOutIterations;

	private static bool FSolverIterations_IsValid;

	private static int FSolverIterations_StructSize;

	public FSolverIterations Copy()
	{
		return this;
	}

	public static FSolverIterations FromNative(IntPtr nativeBuffer)
	{
		return new FSolverIterations(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSolverIterations value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSolverIterations FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSolverIterations(nativeBuffer + arrayIndex * FSolverIterations_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSolverIterations value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSolverIterations_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSolverIterations_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SolverIterations");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SolverIterations_Offset), SolverIterations);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, JointIterations_Offset), JointIterations);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CollisionIterations_Offset), CollisionIterations);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SolverPushOutIterations_Offset), SolverPushOutIterations);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, JointPushOutIterations_Offset), JointPushOutIterations);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CollisionPushOutIterations_Offset), CollisionPushOutIterations);
	}

	public FSolverIterations(IntPtr nativeStruct)
	{
		if (!FSolverIterations_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SolverIterations");
			SolverIterations = 0;
			JointIterations = 0;
			CollisionIterations = 0;
			SolverPushOutIterations = 0;
			JointPushOutIterations = 0;
			CollisionPushOutIterations = 0;
		}
		else
		{
			SolverIterations = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SolverIterations_Offset));
			JointIterations = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, JointIterations_Offset));
			CollisionIterations = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CollisionIterations_Offset));
			SolverPushOutIterations = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SolverPushOutIterations_Offset));
			JointPushOutIterations = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, JointPushOutIterations_Offset));
			CollisionPushOutIterations = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CollisionPushOutIterations_Offset));
		}
	}

	static FSolverIterations()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSolverIterations)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSolverIterations));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SolverIterations");
		FSolverIterations_StructSize = NativeReflection.GetStructSize(intPtr);
		SolverIterations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SolverIterations");
		SolverIterations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SolverIterations", Classes.FIntProperty);
		JointIterations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JointIterations");
		JointIterations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JointIterations", Classes.FIntProperty);
		CollisionIterations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CollisionIterations");
		CollisionIterations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CollisionIterations", Classes.FIntProperty);
		SolverPushOutIterations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SolverPushOutIterations");
		SolverPushOutIterations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SolverPushOutIterations", Classes.FIntProperty);
		JointPushOutIterations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JointPushOutIterations");
		JointPushOutIterations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JointPushOutIterations", Classes.FIntProperty);
		CollisionPushOutIterations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CollisionPushOutIterations");
		CollisionPushOutIterations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CollisionPushOutIterations", Classes.FIntProperty);
		FSolverIterations_IsValid = intPtr != IntPtr.Zero && SolverIterations_IsValid && JointIterations_IsValid && CollisionIterations_IsValid && SolverPushOutIterations_IsValid && JointPushOutIterations_IsValid && CollisionPushOutIterations_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SolverIterations", FSolverIterations_IsValid);
	}
}
