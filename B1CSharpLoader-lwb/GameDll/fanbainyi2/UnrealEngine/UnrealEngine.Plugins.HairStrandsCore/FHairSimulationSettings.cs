using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairSimulationSettings", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairSimulationSettings
{
	private static bool OverrideSettings_IsValid;

	private static FFieldAddress OverrideSettings_PropertyAddress;

	private static int OverrideSettings_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationSettings:bOverrideSettings")]
	public bool OverrideSettings;

	private static bool SimulationSetup_IsValid;

	private static int SimulationSetup_Offset;

	[UProperty(Flags = (PropFlags)4503608217305093uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationSettings:SimulationSetup")]
	public FHairSimulationSetup SimulationSetup;

	private static bool SolverSettings_IsValid;

	private static int SolverSettings_Offset;

	[UProperty(Flags = (PropFlags)4503676936781829uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationSettings:SolverSettings")]
	public FHairSimulationSolver SolverSettings;

	private static bool ExternalForces_IsValid;

	private static int ExternalForces_Offset;

	[UProperty(Flags = (PropFlags)4503676936781829uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationSettings:ExternalForces")]
	public FHairSimulationForces ExternalForces;

	private static bool MaterialConstraints_IsValid;

	private static int MaterialConstraints_Offset;

	[UProperty(Flags = (PropFlags)4503676936781829uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationSettings:MaterialConstraints")]
	public FHairSimulationConstraints MaterialConstraints;

	private static bool FHairSimulationSettings_IsValid;

	private static int FHairSimulationSettings_StructSize;

	public FHairSimulationSettings Copy()
	{
		return this;
	}

	public static FHairSimulationSettings FromNative(IntPtr nativeBuffer)
	{
		return new FHairSimulationSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairSimulationSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairSimulationSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairSimulationSettings(nativeBuffer + arrayIndex * FHairSimulationSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairSimulationSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairSimulationSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairSimulationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairSimulationSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OverrideSettings_Offset), 0, OverrideSettings_PropertyAddress.Address, OverrideSettings);
		FHairSimulationSetup.ToNative(IntPtr.Add(nativeStruct, SimulationSetup_Offset), SimulationSetup);
		FHairSimulationSolver.ToNative(IntPtr.Add(nativeStruct, SolverSettings_Offset), SolverSettings);
		FHairSimulationForces.ToNative(IntPtr.Add(nativeStruct, ExternalForces_Offset), ExternalForces);
		FHairSimulationConstraints.ToNative(IntPtr.Add(nativeStruct, MaterialConstraints_Offset), MaterialConstraints);
	}

	public FHairSimulationSettings(IntPtr nativeStruct)
	{
		if (!FHairSimulationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairSimulationSettings");
			OverrideSettings = false;
			SimulationSetup = default(FHairSimulationSetup);
			SolverSettings = default(FHairSimulationSolver);
			ExternalForces = default(FHairSimulationForces);
			MaterialConstraints = default(FHairSimulationConstraints);
		}
		else
		{
			OverrideSettings = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OverrideSettings_Offset), 0, OverrideSettings_PropertyAddress.Address);
			SimulationSetup = FHairSimulationSetup.FromNative(IntPtr.Add(nativeStruct, SimulationSetup_Offset));
			SolverSettings = FHairSimulationSolver.FromNative(IntPtr.Add(nativeStruct, SolverSettings_Offset));
			ExternalForces = FHairSimulationForces.FromNative(IntPtr.Add(nativeStruct, ExternalForces_Offset));
			MaterialConstraints = FHairSimulationConstraints.FromNative(IntPtr.Add(nativeStruct, MaterialConstraints_Offset));
		}
	}

	static FHairSimulationSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairSimulationSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairSimulationSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairSimulationSettings");
		FHairSimulationSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref OverrideSettings_PropertyAddress, intPtr, "bOverrideSettings");
		OverrideSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverrideSettings");
		OverrideSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverrideSettings", Classes.FBoolProperty);
		SimulationSetup_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SimulationSetup");
		SimulationSetup_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SimulationSetup", Classes.FStructProperty);
		SolverSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SolverSettings");
		SolverSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SolverSettings", Classes.FStructProperty);
		ExternalForces_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExternalForces");
		ExternalForces_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExternalForces", Classes.FStructProperty);
		MaterialConstraints_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaterialConstraints");
		MaterialConstraints_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaterialConstraints", Classes.FStructProperty);
		FHairSimulationSettings_IsValid = intPtr != IntPtr.Zero && OverrideSettings_IsValid && SimulationSetup_IsValid && SolverSettings_IsValid && ExternalForces_IsValid && MaterialConstraints_IsValid;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairSimulationSettings", FHairSimulationSettings_IsValid);
	}
}
