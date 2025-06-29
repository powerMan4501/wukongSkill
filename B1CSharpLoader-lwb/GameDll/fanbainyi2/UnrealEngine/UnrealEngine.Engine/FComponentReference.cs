using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.ComponentReference", "Engine", UnrealModuleType.Engine)]
public struct FComponentReference
{
	private static bool OtherActor_IsValid;

	private static int OtherActor_Offset;

	[UProperty(Flags = (PropFlags)7881369141119493uL)]
	[UMetaPath("/Script/Engine.ComponentReference:OtherActor")]
	public AActor OtherActor;

	private static bool ComponentProperty_IsValid;

	private static int ComponentProperty_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ComponentReference:ComponentProperty")]
	public FName ComponentProperty;

	private static bool FComponentReference_IsValid;

	private static int FComponentReference_StructSize;

	public FComponentReference Copy()
	{
		return this;
	}

	public static FComponentReference FromNative(IntPtr nativeBuffer)
	{
		return new FComponentReference(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FComponentReference value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FComponentReference FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FComponentReference(nativeBuffer + arrayIndex * FComponentReference_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FComponentReference value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FComponentReference_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FComponentReference_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ComponentReference");
			return;
		}
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, OtherActor_Offset), OtherActor);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ComponentProperty_Offset), ComponentProperty);
	}

	public FComponentReference(IntPtr nativeStruct)
	{
		if (!FComponentReference_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ComponentReference");
			OtherActor = null;
			ComponentProperty = default(FName);
		}
		else
		{
			OtherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, OtherActor_Offset));
			ComponentProperty = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ComponentProperty_Offset));
		}
	}

	static FComponentReference()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FComponentReference)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FComponentReference));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.ComponentReference");
		FComponentReference_StructSize = NativeReflection.GetStructSize(intPtr);
		OtherActor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OtherActor");
		OtherActor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OtherActor", Classes.FObjectProperty);
		ComponentProperty_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ComponentProperty");
		ComponentProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ComponentProperty", Classes.FNameProperty);
		FComponentReference_IsValid = intPtr != IntPtr.Zero && OtherActor_IsValid && ComponentProperty_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.ComponentReference", FComponentReference_IsValid);
	}
}
