using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairSimulationSolver", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairSimulationSolver
{
	private static bool EnableSimulation_IsValid;

	private static FFieldAddress EnableSimulation_PropertyAddress;

	private static int EnableSimulation_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationSolver:bEnableSimulation")]
	public bool EnableSimulation;

	private static bool FHairSimulationSolver_IsValid;

	private static int FHairSimulationSolver_StructSize;

	public FHairSimulationSolver Copy()
	{
		return this;
	}

	public static FHairSimulationSolver FromNative(IntPtr nativeBuffer)
	{
		return new FHairSimulationSolver(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairSimulationSolver value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairSimulationSolver FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairSimulationSolver(nativeBuffer + arrayIndex * FHairSimulationSolver_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairSimulationSolver value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairSimulationSolver_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairSimulationSolver_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairSimulationSolver");
		}
		else
		{
			BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableSimulation_Offset), 0, EnableSimulation_PropertyAddress.Address, EnableSimulation);
		}
	}

	public FHairSimulationSolver(IntPtr nativeStruct)
	{
		if (!FHairSimulationSolver_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairSimulationSolver");
			EnableSimulation = false;
		}
		else
		{
			EnableSimulation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableSimulation_Offset), 0, EnableSimulation_PropertyAddress.Address);
		}
	}

	static FHairSimulationSolver()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairSimulationSolver)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairSimulationSolver));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairSimulationSolver");
		FHairSimulationSolver_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref EnableSimulation_PropertyAddress, intPtr, "bEnableSimulation");
		EnableSimulation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableSimulation");
		EnableSimulation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableSimulation", Classes.FBoolProperty);
		FHairSimulationSolver_IsValid = intPtr != IntPtr.Zero && EnableSimulation_IsValid;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairSimulationSolver", FHairSimulationSolver_IsValid);
	}
}
