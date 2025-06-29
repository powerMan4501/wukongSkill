using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.ChaosSolverEngine;

[UStruct(Flags = 4613)]
[BlueprintType]
[UMetaPath("/Script/ChaosSolverEngine.ChaosBreakEvent", "ChaosSolverEngine", UnrealModuleType.Engine)]
public struct FChaosBreakEvent
{
	private static bool Component_IsValid;

	private static int Component_Offset;

	[UProperty(Flags = (PropFlags)7881369141641756uL)]
	[UMetaPath("/Script/ChaosSolverEngine.ChaosBreakEvent:Component")]
	public UPrimitiveComponent Component;

	private static bool Location_IsValid;

	private static int Location_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/ChaosSolverEngine.ChaosBreakEvent:Location")]
	public FVector Location;

	private static bool Velocity_IsValid;

	private static int Velocity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/ChaosSolverEngine.ChaosBreakEvent:Velocity")]
	public FVector Velocity;

	private static bool AngularVelocity_IsValid;

	private static int AngularVelocity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/ChaosSolverEngine.ChaosBreakEvent:AngularVelocity")]
	public FVector AngularVelocity;

	private static bool Mass_IsValid;

	private static int Mass_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/ChaosSolverEngine.ChaosBreakEvent:Mass")]
	public float Mass;

	private static bool FChaosBreakEvent_IsValid;

	private static int FChaosBreakEvent_StructSize;

	public FChaosBreakEvent Copy()
	{
		return this;
	}

	public static FChaosBreakEvent FromNative(IntPtr nativeBuffer)
	{
		return new FChaosBreakEvent(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FChaosBreakEvent value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FChaosBreakEvent FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FChaosBreakEvent(nativeBuffer + arrayIndex * FChaosBreakEvent_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FChaosBreakEvent value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FChaosBreakEvent_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FChaosBreakEvent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ChaosSolverEngine.ChaosBreakEvent");
			return;
		}
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(nativeStruct, Component_Offset), Component);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Velocity_Offset), Velocity);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, AngularVelocity_Offset), AngularVelocity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Mass_Offset), Mass);
	}

	public FChaosBreakEvent(IntPtr nativeStruct)
	{
		if (!FChaosBreakEvent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ChaosSolverEngine.ChaosBreakEvent");
			Component = null;
			Location = default(FVector);
			Velocity = default(FVector);
			AngularVelocity = default(FVector);
			Mass = 0f;
		}
		else
		{
			Component = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(nativeStruct, Component_Offset));
			Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
			Velocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Velocity_Offset));
			AngularVelocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, AngularVelocity_Offset));
			Mass = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Mass_Offset));
		}
	}

	static FChaosBreakEvent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FChaosBreakEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FChaosBreakEvent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ChaosSolverEngine.ChaosBreakEvent");
		FChaosBreakEvent_StructSize = NativeReflection.GetStructSize(intPtr);
		Component_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Component");
		Component_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Component", Classes.FObjectProperty);
		Location_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Location", Classes.FStructProperty);
		Velocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Velocity");
		Velocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Velocity", Classes.FStructProperty);
		AngularVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AngularVelocity");
		AngularVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AngularVelocity", Classes.FStructProperty);
		Mass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mass");
		Mass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mass", Classes.FFloatProperty);
		FChaosBreakEvent_IsValid = intPtr != IntPtr.Zero && Component_IsValid && Location_IsValid && Velocity_IsValid && AngularVelocity_IsValid && Mass_IsValid;
		NativeReflection.LogStructIsValid("/Script/ChaosSolverEngine.ChaosBreakEvent", FChaosBreakEvent_IsValid);
	}
}
