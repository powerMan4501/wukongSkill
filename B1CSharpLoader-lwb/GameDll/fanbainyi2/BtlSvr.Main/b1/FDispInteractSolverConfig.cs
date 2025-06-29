using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.DispInteractSolverConfig")]
public struct FDispInteractSolverConfig
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("生成DSDF解算器")]
	[Category("B1DispInteract")]
	[USharpPath("/Script/b1-Managed.DispInteractSolverConfig:SpawnDSDFSolver")]
	public bool SpawnDSDFSolver;

	[UProperty]
	[Category("B1DispInteract")]
	[EditAnywhere]
	[DisplayName("DSDF解算器优先级")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispInteractSolverConfig:Pority")]
	public int Pority;

	private static int DispInteractSolverConfig_StructSize;

	private static int DispInteractSolverConfig_IsValid;

	private static bool SpawnDSDFSolver_IsValid;

	private static int SpawnDSDFSolver_Offset;

	private static FFieldAddress SpawnDSDFSolver_PropertyAddress;

	private static bool Pority_IsValid;

	private static int Pority_Offset;

	public FDispInteractSolverConfig Copy()
	{
		return this;
	}

	public static FDispInteractSolverConfig FromNative(IntPtr nativeBuffer)
	{
		return new FDispInteractSolverConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDispInteractSolverConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDispInteractSolverConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDispInteractSolverConfig(IntPtr.Add(nativeBuffer, arrayIndex * DispInteractSolverConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDispInteractSolverConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DispInteractSolverConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DispInteractSolverConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DispInteractSolverConfig");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SpawnDSDFSolver_Offset), 0, SpawnDSDFSolver_PropertyAddress.Address, SpawnDSDFSolver);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Pority_Offset), Pority);
	}

	public FDispInteractSolverConfig(IntPtr nativeStruct)
	{
		if (DispInteractSolverConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DispInteractSolverConfig");
			SpawnDSDFSolver = false;
			Pority = 0;
		}
		else
		{
			SpawnDSDFSolver = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SpawnDSDFSolver_Offset), 0, SpawnDSDFSolver_PropertyAddress.Address);
			Pority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Pority_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DispInteractSolverConfig");
		DispInteractSolverConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref SpawnDSDFSolver_PropertyAddress, intPtr, "SpawnDSDFSolver");
		SpawnDSDFSolver_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnDSDFSolver");
		SpawnDSDFSolver_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnDSDFSolver", Classes.FBoolProperty);
		Pority_Offset = NativeReflection.GetPropertyOffset(intPtr, "Pority");
		Pority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Pority", Classes.FIntProperty);
		DispInteractSolverConfig_IsValid = ((intPtr != IntPtr.Zero && SpawnDSDFSolver_IsValid && Pority_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DispInteractSolverConfig", (byte)DispInteractSolverConfig_IsValid != 0);
	}

	static FDispInteractSolverConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDispInteractSolverConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDispInteractSolverConfig));
	}
}
