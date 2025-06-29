using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.ChaosSolverEngine;

[UStruct(Flags = 4613)]
[BlueprintType]
[UMetaPath("/Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo", "ChaosSolverEngine", UnrealModuleType.Engine)]
public struct FChaosPhysicsCollisionInfo
{
	private static bool Component_IsValid;

	private static int Component_Offset;

	[UProperty(Flags = (PropFlags)7881369141641741uL)]
	[UMetaPath("/Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo:Component")]
	public UPrimitiveComponent Component;

	private static bool OtherComponent_IsValid;

	private static int OtherComponent_Offset;

	[UProperty(Flags = (PropFlags)7881369141641741uL)]
	[UMetaPath("/Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo:OtherComponent")]
	public UPrimitiveComponent OtherComponent;

	private static bool Location_IsValid;

	private static int Location_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo:Location")]
	public FVector Location;

	private static bool Normal_IsValid;

	private static int Normal_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo:Normal")]
	public FVector Normal;

	private static bool AccumulatedImpulse_IsValid;

	private static int AccumulatedImpulse_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo:AccumulatedImpulse")]
	public FVector AccumulatedImpulse;

	private static bool Velocity_IsValid;

	private static int Velocity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo:Velocity")]
	public FVector Velocity;

	private static bool OtherVelocity_IsValid;

	private static int OtherVelocity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo:OtherVelocity")]
	public FVector OtherVelocity;

	private static bool AngularVelocity_IsValid;

	private static int AngularVelocity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo:AngularVelocity")]
	public FVector AngularVelocity;

	private static bool OtherAngularVelocity_IsValid;

	private static int OtherAngularVelocity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo:OtherAngularVelocity")]
	public FVector OtherAngularVelocity;

	private static bool Mass_IsValid;

	private static int Mass_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo:Mass")]
	public float Mass;

	private static bool OtherMass_IsValid;

	private static int OtherMass_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo:OtherMass")]
	public float OtherMass;

	private static bool FChaosPhysicsCollisionInfo_IsValid;

	private static int FChaosPhysicsCollisionInfo_StructSize;

	public FChaosPhysicsCollisionInfo Copy()
	{
		return this;
	}

	public static FChaosPhysicsCollisionInfo FromNative(IntPtr nativeBuffer)
	{
		return new FChaosPhysicsCollisionInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FChaosPhysicsCollisionInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FChaosPhysicsCollisionInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FChaosPhysicsCollisionInfo(nativeBuffer + arrayIndex * FChaosPhysicsCollisionInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FChaosPhysicsCollisionInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FChaosPhysicsCollisionInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FChaosPhysicsCollisionInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo");
			return;
		}
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(nativeStruct, Component_Offset), Component);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(nativeStruct, OtherComponent_Offset), OtherComponent);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Normal_Offset), Normal);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, AccumulatedImpulse_Offset), AccumulatedImpulse);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Velocity_Offset), Velocity);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, OtherVelocity_Offset), OtherVelocity);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, AngularVelocity_Offset), AngularVelocity);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, OtherAngularVelocity_Offset), OtherAngularVelocity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Mass_Offset), Mass);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OtherMass_Offset), OtherMass);
	}

	public FChaosPhysicsCollisionInfo(IntPtr nativeStruct)
	{
		if (!FChaosPhysicsCollisionInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo");
			Component = null;
			OtherComponent = null;
			Location = default(FVector);
			Normal = default(FVector);
			AccumulatedImpulse = default(FVector);
			Velocity = default(FVector);
			OtherVelocity = default(FVector);
			AngularVelocity = default(FVector);
			OtherAngularVelocity = default(FVector);
			Mass = 0f;
			OtherMass = 0f;
		}
		else
		{
			Component = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(nativeStruct, Component_Offset));
			OtherComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(nativeStruct, OtherComponent_Offset));
			Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
			Normal = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Normal_Offset));
			AccumulatedImpulse = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, AccumulatedImpulse_Offset));
			Velocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Velocity_Offset));
			OtherVelocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, OtherVelocity_Offset));
			AngularVelocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, AngularVelocity_Offset));
			OtherAngularVelocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, OtherAngularVelocity_Offset));
			Mass = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Mass_Offset));
			OtherMass = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OtherMass_Offset));
		}
	}

	static FChaosPhysicsCollisionInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FChaosPhysicsCollisionInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FChaosPhysicsCollisionInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo");
		FChaosPhysicsCollisionInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		Component_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Component");
		Component_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Component", Classes.FObjectProperty);
		OtherComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OtherComponent");
		OtherComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OtherComponent", Classes.FObjectProperty);
		Location_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Location", Classes.FStructProperty);
		Normal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Normal");
		Normal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Normal", Classes.FStructProperty);
		AccumulatedImpulse_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AccumulatedImpulse");
		AccumulatedImpulse_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AccumulatedImpulse", Classes.FStructProperty);
		Velocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Velocity");
		Velocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Velocity", Classes.FStructProperty);
		OtherVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OtherVelocity");
		OtherVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OtherVelocity", Classes.FStructProperty);
		AngularVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AngularVelocity");
		AngularVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AngularVelocity", Classes.FStructProperty);
		OtherAngularVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OtherAngularVelocity");
		OtherAngularVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OtherAngularVelocity", Classes.FStructProperty);
		Mass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mass");
		Mass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mass", Classes.FFloatProperty);
		OtherMass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OtherMass");
		OtherMass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OtherMass", Classes.FFloatProperty);
		FChaosPhysicsCollisionInfo_IsValid = intPtr != IntPtr.Zero && Component_IsValid && OtherComponent_IsValid && Location_IsValid && Normal_IsValid && AccumulatedImpulse_IsValid && Velocity_IsValid && OtherVelocity_IsValid && AngularVelocity_IsValid && OtherAngularVelocity_IsValid && Mass_IsValid && OtherMass_IsValid;
		NativeReflection.LogStructIsValid("/Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo", FChaosPhysicsCollisionInfo_IsValid);
	}
}
