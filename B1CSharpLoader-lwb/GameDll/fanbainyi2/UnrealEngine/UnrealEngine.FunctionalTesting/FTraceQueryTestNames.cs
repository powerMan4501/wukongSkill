using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/FunctionalTesting.TraceQueryTestNames", "FunctionalTesting", UnrealModuleType.Engine)]
public struct FTraceQueryTestNames
{
	private static bool ComponentName_IsValid;

	private static int ComponentName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceQueryTestNames:ComponentName")]
	public FName ComponentName;

	private static bool PhysicalMaterialName_IsValid;

	private static int PhysicalMaterialName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceQueryTestNames:PhysicalMaterialName")]
	public FName PhysicalMaterialName;

	private static bool ActorName_IsValid;

	private static int ActorName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceQueryTestNames:ActorName")]
	public FName ActorName;

	private static bool FTraceQueryTestNames_IsValid;

	private static int FTraceQueryTestNames_StructSize;

	public FTraceQueryTestNames Copy()
	{
		return this;
	}

	public static FTraceQueryTestNames FromNative(IntPtr nativeBuffer)
	{
		return new FTraceQueryTestNames(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTraceQueryTestNames value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTraceQueryTestNames FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTraceQueryTestNames(nativeBuffer + arrayIndex * FTraceQueryTestNames_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTraceQueryTestNames value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTraceQueryTestNames_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTraceQueryTestNames_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.TraceQueryTestNames");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ComponentName_Offset), ComponentName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, PhysicalMaterialName_Offset), PhysicalMaterialName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ActorName_Offset), ActorName);
	}

	public FTraceQueryTestNames(IntPtr nativeStruct)
	{
		if (!FTraceQueryTestNames_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.TraceQueryTestNames");
			ComponentName = default(FName);
			PhysicalMaterialName = default(FName);
			ActorName = default(FName);
		}
		else
		{
			ComponentName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ComponentName_Offset));
			PhysicalMaterialName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, PhysicalMaterialName_Offset));
			ActorName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ActorName_Offset));
		}
	}

	static FTraceQueryTestNames()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTraceQueryTestNames)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTraceQueryTestNames));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FunctionalTesting.TraceQueryTestNames");
		FTraceQueryTestNames_StructSize = NativeReflection.GetStructSize(intPtr);
		ComponentName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ComponentName");
		ComponentName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ComponentName", Classes.FNameProperty);
		PhysicalMaterialName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PhysicalMaterialName");
		PhysicalMaterialName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PhysicalMaterialName", Classes.FNameProperty);
		ActorName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorName");
		ActorName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorName", Classes.FNameProperty);
		FTraceQueryTestNames_IsValid = intPtr != IntPtr.Zero && ComponentName_IsValid && PhysicalMaterialName_IsValid && ActorName_IsValid;
		NativeReflection.LogStructIsValid("/Script/FunctionalTesting.TraceQueryTestNames", FTraceQueryTestNames_IsValid);
	}
}
