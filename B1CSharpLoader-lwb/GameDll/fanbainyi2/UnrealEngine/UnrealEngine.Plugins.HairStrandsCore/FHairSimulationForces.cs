using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairSimulationForces", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairSimulationForces
{
	private static bool GravityVector_IsValid;

	private static int GravityVector_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationForces:GravityVector")]
	public FVector GravityVector;

	private static bool AirDrag_IsValid;

	private static int AirDrag_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationForces:AirDrag")]
	public float AirDrag;

	private static bool AirVelocity_IsValid;

	private static int AirVelocity_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationForces:AirVelocity")]
	public FVector AirVelocity;

	private static bool FHairSimulationForces_IsValid;

	private static int FHairSimulationForces_StructSize;

	public FHairSimulationForces Copy()
	{
		return this;
	}

	public static FHairSimulationForces FromNative(IntPtr nativeBuffer)
	{
		return new FHairSimulationForces(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairSimulationForces value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairSimulationForces FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairSimulationForces(nativeBuffer + arrayIndex * FHairSimulationForces_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairSimulationForces value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairSimulationForces_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairSimulationForces_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairSimulationForces");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, GravityVector_Offset), GravityVector);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AirDrag_Offset), AirDrag);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, AirVelocity_Offset), AirVelocity);
	}

	public FHairSimulationForces(IntPtr nativeStruct)
	{
		if (!FHairSimulationForces_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairSimulationForces");
			GravityVector = default(FVector);
			AirDrag = 0f;
			AirVelocity = default(FVector);
		}
		else
		{
			GravityVector = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, GravityVector_Offset));
			AirDrag = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AirDrag_Offset));
			AirVelocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, AirVelocity_Offset));
		}
	}

	static FHairSimulationForces()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairSimulationForces)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairSimulationForces));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairSimulationForces");
		FHairSimulationForces_StructSize = NativeReflection.GetStructSize(intPtr);
		GravityVector_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GravityVector");
		GravityVector_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GravityVector", Classes.FStructProperty);
		AirDrag_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AirDrag");
		AirDrag_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AirDrag", Classes.FFloatProperty);
		AirVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AirVelocity");
		AirVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AirVelocity", Classes.FStructProperty);
		FHairSimulationForces_IsValid = intPtr != IntPtr.Zero && GravityVector_IsValid && AirDrag_IsValid && AirVelocity_IsValid;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairSimulationForces", FHairSimulationForces_IsValid);
	}
}
