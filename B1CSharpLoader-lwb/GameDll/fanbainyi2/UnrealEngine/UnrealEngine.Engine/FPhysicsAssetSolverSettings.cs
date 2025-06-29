using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.PhysicsAssetSolverSettings", "Engine", UnrealModuleType.Engine)]
public struct FPhysicsAssetSolverSettings
{
	private static bool PositionIterations_IsValid;

	private static int PositionIterations_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicsAssetSolverSettings:PositionIterations")]
	public int PositionIterations;

	private static bool VelocityIterations_IsValid;

	private static int VelocityIterations_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicsAssetSolverSettings:VelocityIterations")]
	public int VelocityIterations;

	private static bool ProjectionIterations_IsValid;

	private static int ProjectionIterations_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicsAssetSolverSettings:ProjectionIterations")]
	public int ProjectionIterations;

	private static bool CullDistance_IsValid;

	private static int CullDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicsAssetSolverSettings:CullDistance")]
	public float CullDistance;

	private static bool MaxDepenetrationVelocity_IsValid;

	private static int MaxDepenetrationVelocity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicsAssetSolverSettings:MaxDepenetrationVelocity")]
	public float MaxDepenetrationVelocity;

	private static bool FixedTimeStep_IsValid;

	private static int FixedTimeStep_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicsAssetSolverSettings:FixedTimeStep")]
	public float FixedTimeStep;

	private static bool FPhysicsAssetSolverSettings_IsValid;

	private static int FPhysicsAssetSolverSettings_StructSize;

	public FPhysicsAssetSolverSettings Copy()
	{
		return this;
	}

	public static FPhysicsAssetSolverSettings FromNative(IntPtr nativeBuffer)
	{
		return new FPhysicsAssetSolverSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPhysicsAssetSolverSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPhysicsAssetSolverSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPhysicsAssetSolverSettings(nativeBuffer + arrayIndex * FPhysicsAssetSolverSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPhysicsAssetSolverSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPhysicsAssetSolverSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPhysicsAssetSolverSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PhysicsAssetSolverSettings");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PositionIterations_Offset), PositionIterations);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, VelocityIterations_Offset), VelocityIterations);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ProjectionIterations_Offset), ProjectionIterations);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CullDistance_Offset), CullDistance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxDepenetrationVelocity_Offset), MaxDepenetrationVelocity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FixedTimeStep_Offset), FixedTimeStep);
	}

	public FPhysicsAssetSolverSettings(IntPtr nativeStruct)
	{
		if (!FPhysicsAssetSolverSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PhysicsAssetSolverSettings");
			PositionIterations = 0;
			VelocityIterations = 0;
			ProjectionIterations = 0;
			CullDistance = 0f;
			MaxDepenetrationVelocity = 0f;
			FixedTimeStep = 0f;
		}
		else
		{
			PositionIterations = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PositionIterations_Offset));
			VelocityIterations = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, VelocityIterations_Offset));
			ProjectionIterations = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ProjectionIterations_Offset));
			CullDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CullDistance_Offset));
			MaxDepenetrationVelocity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxDepenetrationVelocity_Offset));
			FixedTimeStep = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FixedTimeStep_Offset));
		}
	}

	static FPhysicsAssetSolverSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPhysicsAssetSolverSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPhysicsAssetSolverSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.PhysicsAssetSolverSettings");
		FPhysicsAssetSolverSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		PositionIterations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PositionIterations");
		PositionIterations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PositionIterations", Classes.FIntProperty);
		VelocityIterations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VelocityIterations");
		VelocityIterations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VelocityIterations", Classes.FIntProperty);
		ProjectionIterations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ProjectionIterations");
		ProjectionIterations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ProjectionIterations", Classes.FIntProperty);
		CullDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CullDistance");
		CullDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CullDistance", Classes.FFloatProperty);
		MaxDepenetrationVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxDepenetrationVelocity");
		MaxDepenetrationVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxDepenetrationVelocity", Classes.FFloatProperty);
		FixedTimeStep_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FixedTimeStep");
		FixedTimeStep_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FixedTimeStep", Classes.FFloatProperty);
		FPhysicsAssetSolverSettings_IsValid = intPtr != IntPtr.Zero && PositionIterations_IsValid && VelocityIterations_IsValid && ProjectionIterations_IsValid && CullDistance_IsValid && MaxDepenetrationVelocity_IsValid && FixedTimeStep_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.PhysicsAssetSolverSettings", FPhysicsAssetSolverSettings_IsValid);
	}
}
