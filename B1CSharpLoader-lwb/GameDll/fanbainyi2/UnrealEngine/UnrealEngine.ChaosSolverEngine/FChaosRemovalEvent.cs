using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.ChaosSolverEngine;

[UStruct(Flags = 4613)]
[BlueprintType]
[UMetaPath("/Script/ChaosSolverEngine.ChaosRemovalEvent", "ChaosSolverEngine", UnrealModuleType.Engine)]
public struct FChaosRemovalEvent
{
	private static bool Component_IsValid;

	private static int Component_Offset;

	[UProperty(Flags = (PropFlags)7881369141641756uL)]
	[UMetaPath("/Script/ChaosSolverEngine.ChaosRemovalEvent:Component")]
	public UPrimitiveComponent Component;

	private static bool Location_IsValid;

	private static int Location_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/ChaosSolverEngine.ChaosRemovalEvent:Location")]
	public FVector Location;

	private static bool Mass_IsValid;

	private static int Mass_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/ChaosSolverEngine.ChaosRemovalEvent:Mass")]
	public float Mass;

	private static bool FChaosRemovalEvent_IsValid;

	private static int FChaosRemovalEvent_StructSize;

	public FChaosRemovalEvent Copy()
	{
		return this;
	}

	public static FChaosRemovalEvent FromNative(IntPtr nativeBuffer)
	{
		return new FChaosRemovalEvent(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FChaosRemovalEvent value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FChaosRemovalEvent FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FChaosRemovalEvent(nativeBuffer + arrayIndex * FChaosRemovalEvent_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FChaosRemovalEvent value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FChaosRemovalEvent_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FChaosRemovalEvent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ChaosSolverEngine.ChaosRemovalEvent");
			return;
		}
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(nativeStruct, Component_Offset), Component);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Mass_Offset), Mass);
	}

	public FChaosRemovalEvent(IntPtr nativeStruct)
	{
		if (!FChaosRemovalEvent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ChaosSolverEngine.ChaosRemovalEvent");
			Component = null;
			Location = default(FVector);
			Mass = 0f;
		}
		else
		{
			Component = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(nativeStruct, Component_Offset));
			Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
			Mass = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Mass_Offset));
		}
	}

	static FChaosRemovalEvent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FChaosRemovalEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FChaosRemovalEvent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ChaosSolverEngine.ChaosRemovalEvent");
		FChaosRemovalEvent_StructSize = NativeReflection.GetStructSize(intPtr);
		Component_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Component");
		Component_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Component", Classes.FObjectProperty);
		Location_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Location", Classes.FStructProperty);
		Mass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mass");
		Mass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mass", Classes.FFloatProperty);
		FChaosRemovalEvent_IsValid = intPtr != IntPtr.Zero && Component_IsValid && Location_IsValid && Mass_IsValid;
		NativeReflection.LogStructIsValid("/Script/ChaosSolverEngine.ChaosRemovalEvent", FChaosRemovalEvent_IsValid);
	}
}
