using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Render;

[UClass]
[USharpPath("/Script/b1-Managed.FluidSimulationSettings")]
public class FluidSimulationSettings : UPrimaryDataAsset
{
	private static bool Is3D_IsValid;

	private static int Is3D_Offset;

	private static FFieldAddress Is3D_PropertyAddress;

	private static bool Resolution2D_IsValid;

	private static int Resolution2D_Offset;

	private static bool Resolution3D_IsValid;

	private static int Resolution3D_Offset;

	private static FFieldAddress Resolution3D_PropertyAddress;

	private static bool PressureDivisor_IsValid;

	private static int PressureDivisor_Offset;

	private static bool VelocityDensityMaskAmount_IsValid;

	private static int VelocityDensityMaskAmount_Offset;

	private static bool DebugPressureStrength_IsValid;

	private static int DebugPressureStrength_Offset;

	private static bool ColorSeedMaterial_IsValid;

	private static int ColorSeedMaterial_Offset;

	private static bool ObstaclePoint_IsValid;

	private static int ObstaclePoint_Offset;

	private static bool SeedTemperatureMultiplier_IsValid;

	private static int SeedTemperatureMultiplier_Offset;

	private static bool TemperatureInset_IsValid;

	private static int TemperatureInset_Offset;

	private static bool EdgeHardness_IsValid;

	private static int EdgeHardness_Offset;

	private static bool NoiseStrength_IsValid;

	private static int NoiseStrength_Offset;

	private static bool DensityMultiplier_IsValid;

	private static int DensityMultiplier_Offset;

	private static bool VelocitySeedMaterial_IsValid;

	private static int VelocitySeedMaterial_Offset;

	private static bool Curl1Strength_IsValid;

	private static int Curl1Strength_Offset;

	private static bool Curl1Tiling_IsValid;

	private static int Curl1Tiling_Offset;

	private static bool Curl2Strength_IsValid;

	private static int Curl2Strength_Offset;

	private static bool Curl2Tiling_IsValid;

	private static int Curl2Tiling_Offset;

	private static bool OverallVelocityMultiplier_IsValid;

	private static int OverallVelocityMultiplier_Offset;

	private static bool RadialForce_IsValid;

	private static int RadialForce_Offset;

	private static bool NoiseFieldPosOffset_IsValid;

	private static int NoiseFieldPosOffset_Offset;

	private static bool ObstacleMaterial2D_IsValid;

	private static int ObstacleMaterial2D_Offset;

	private static bool AdvectionMaterial3D_IsValid;

	private static int AdvectionMaterial3D_Offset;

	private static bool JacobiIterations_IsValid;

	private static int JacobiIterations_Offset;

	private static bool TimeStep_IsValid;

	private static int TimeStep_Offset;

	private static bool ConstantCurlTiling_IsValid;

	private static int ConstantCurlTiling_Offset;

	private static bool ConstantCurlStrength_IsValid;

	private static int ConstantCurlStrength_Offset;

	private static bool TemperatureBuoyancy_IsValid;

	private static int TemperatureBuoyancy_Offset;

	private static bool TemperatureDampening_IsValid;

	private static int TemperatureDampening_Offset;

	private static bool DensityDampening_IsValid;

	private static int DensityDampening_Offset;

	private static bool DensityErosion_IsValid;

	private static int DensityErosion_Offset;

	private static bool EmissionCurve_IsValid;

	private static int EmissionCurve_Offset;

	private static bool EmissionMultiplier_IsValid;

	private static int EmissionMultiplier_Offset;

	private static bool EmissionTemperatureMultiplier_IsValid;

	private static int EmissionTemperatureMultiplier_Offset;

	private static bool InteractInfo_IsValid;

	private static int InteractInfo_Offset;

	private static bool MPCInteractPosName_IsValid;

	private static int MPCInteractPosName_Offset;

	private static bool MPCInteractVelName_IsValid;

	private static int MPCInteractVelName_Offset;

	private static bool InteractVelocityMultiper_IsValid;

	private static int InteractVelocityMultiper_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:Is3D")]
	public bool Is3D
	{
		get
		{
			CheckDestroyed();
			if (!Is3D_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:Is3D");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Is3D_Offset), 0, Is3D_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Is3D_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:Is3D");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Is3D_Offset), 0, Is3D_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:Resolution2D")]
	public int Resolution2D
	{
		get
		{
			CheckDestroyed();
			if (!Resolution2D_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:Resolution2D");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Resolution2D_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Resolution2D_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:Resolution2D");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Resolution2D_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:Resolution3D")]
	public EFluidSimDimension Resolution3D
	{
		get
		{
			CheckDestroyed();
			if (!Resolution3D_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:Resolution3D");
				return EFluidSimDimension.Vol_32_3;
			}
			return EnumMarshaler<EFluidSimDimension>.FromNative(IntPtr.Add(base.Address, Resolution3D_Offset), 0, Resolution3D_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Resolution3D_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:Resolution3D");
			}
			else
			{
				EnumMarshaler<EFluidSimDimension>.ToNative(IntPtr.Add(base.Address, Resolution3D_Offset), 0, Resolution3D_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:PressureDivisor")]
	public int PressureDivisor
	{
		get
		{
			CheckDestroyed();
			if (!PressureDivisor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:PressureDivisor");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PressureDivisor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PressureDivisor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:PressureDivisor");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PressureDivisor_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:VelocityDensityMaskAmount")]
	public float VelocityDensityMaskAmount
	{
		get
		{
			CheckDestroyed();
			if (!VelocityDensityMaskAmount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:VelocityDensityMaskAmount");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VelocityDensityMaskAmount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocityDensityMaskAmount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:VelocityDensityMaskAmount");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VelocityDensityMaskAmount_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:DebugPressureStrength")]
	public float DebugPressureStrength
	{
		get
		{
			CheckDestroyed();
			if (!DebugPressureStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:DebugPressureStrength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DebugPressureStrength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugPressureStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:DebugPressureStrength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DebugPressureStrength_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:ColorSeedMaterial")]
	public UMaterial ColorSeedMaterial
	{
		get
		{
			CheckDestroyed();
			if (!ColorSeedMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:ColorSeedMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, ColorSeedMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ColorSeedMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:ColorSeedMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, ColorSeedMaterial_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:ObstaclePoint")]
	public FTransform ObstaclePoint
	{
		get
		{
			CheckDestroyed();
			if (!ObstaclePoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:ObstaclePoint");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, ObstaclePoint_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ObstaclePoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:ObstaclePoint");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, ObstaclePoint_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:SeedTemperatureMultiplier")]
	public float SeedTemperatureMultiplier
	{
		get
		{
			CheckDestroyed();
			if (!SeedTemperatureMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:SeedTemperatureMultiplier");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SeedTemperatureMultiplier_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SeedTemperatureMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:SeedTemperatureMultiplier");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SeedTemperatureMultiplier_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:TemperatureInset")]
	public float TemperatureInset
	{
		get
		{
			CheckDestroyed();
			if (!TemperatureInset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:TemperatureInset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TemperatureInset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TemperatureInset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:TemperatureInset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TemperatureInset_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:EdgeHardness")]
	public float EdgeHardness
	{
		get
		{
			CheckDestroyed();
			if (!EdgeHardness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:EdgeHardness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EdgeHardness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EdgeHardness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:EdgeHardness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EdgeHardness_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:NoiseStrength")]
	public float NoiseStrength
	{
		get
		{
			CheckDestroyed();
			if (!NoiseStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:NoiseStrength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NoiseStrength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NoiseStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:NoiseStrength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NoiseStrength_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:DensityMultiplier")]
	public float DensityMultiplier
	{
		get
		{
			CheckDestroyed();
			if (!DensityMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:DensityMultiplier");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DensityMultiplier_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DensityMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:DensityMultiplier");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DensityMultiplier_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:VelocitySeedMaterial")]
	public UMaterial VelocitySeedMaterial
	{
		get
		{
			CheckDestroyed();
			if (!VelocitySeedMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:VelocitySeedMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, VelocitySeedMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocitySeedMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:VelocitySeedMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, VelocitySeedMaterial_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:Curl1Strength")]
	public float Curl1Strength
	{
		get
		{
			CheckDestroyed();
			if (!Curl1Strength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:Curl1Strength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Curl1Strength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Curl1Strength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:Curl1Strength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Curl1Strength_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:Curl1Tiling")]
	public float Curl1Tiling
	{
		get
		{
			CheckDestroyed();
			if (!Curl1Tiling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:Curl1Tiling");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Curl1Tiling_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Curl1Tiling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:Curl1Tiling");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Curl1Tiling_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:Curl2Strength")]
	public float Curl2Strength
	{
		get
		{
			CheckDestroyed();
			if (!Curl2Strength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:Curl2Strength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Curl2Strength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Curl2Strength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:Curl2Strength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Curl2Strength_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:Curl2Tiling")]
	public float Curl2Tiling
	{
		get
		{
			CheckDestroyed();
			if (!Curl2Tiling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:Curl2Tiling");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Curl2Tiling_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Curl2Tiling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:Curl2Tiling");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Curl2Tiling_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:OverallVelocityMultiplier")]
	public float OverallVelocityMultiplier
	{
		get
		{
			CheckDestroyed();
			if (!OverallVelocityMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:OverallVelocityMultiplier");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OverallVelocityMultiplier_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverallVelocityMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:OverallVelocityMultiplier");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OverallVelocityMultiplier_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:RadialForce")]
	public float RadialForce
	{
		get
		{
			CheckDestroyed();
			if (!RadialForce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:RadialForce");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RadialForce_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RadialForce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:RadialForce");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RadialForce_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:NoiseFieldPosOffset")]
	public FVector NoiseFieldPosOffset
	{
		get
		{
			CheckDestroyed();
			if (!NoiseFieldPosOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:NoiseFieldPosOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, NoiseFieldPosOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NoiseFieldPosOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:NoiseFieldPosOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, NoiseFieldPosOffset_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:ObstacleMaterial2D")]
	public UMaterial ObstacleMaterial2D
	{
		get
		{
			CheckDestroyed();
			if (!ObstacleMaterial2D_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:ObstacleMaterial2D");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, ObstacleMaterial2D_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ObstacleMaterial2D_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:ObstacleMaterial2D");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, ObstacleMaterial2D_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:AdvectionMaterial3D")]
	public UMaterial AdvectionMaterial3D
	{
		get
		{
			CheckDestroyed();
			if (!AdvectionMaterial3D_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:AdvectionMaterial3D");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, AdvectionMaterial3D_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdvectionMaterial3D_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:AdvectionMaterial3D");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, AdvectionMaterial3D_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:JacobiIterations")]
	public int JacobiIterations
	{
		get
		{
			CheckDestroyed();
			if (!JacobiIterations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:JacobiIterations");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, JacobiIterations_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JacobiIterations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:JacobiIterations");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, JacobiIterations_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:TimeStep")]
	public float TimeStep
	{
		get
		{
			CheckDestroyed();
			if (!TimeStep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:TimeStep");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TimeStep_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TimeStep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:TimeStep");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TimeStep_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:ConstantCurlTiling")]
	public float ConstantCurlTiling
	{
		get
		{
			CheckDestroyed();
			if (!ConstantCurlTiling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:ConstantCurlTiling");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ConstantCurlTiling_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ConstantCurlTiling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:ConstantCurlTiling");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ConstantCurlTiling_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:ConstantCurlStrength")]
	public float ConstantCurlStrength
	{
		get
		{
			CheckDestroyed();
			if (!ConstantCurlStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:ConstantCurlStrength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ConstantCurlStrength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ConstantCurlStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:ConstantCurlStrength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ConstantCurlStrength_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:TemperatureBuoyancy")]
	public float TemperatureBuoyancy
	{
		get
		{
			CheckDestroyed();
			if (!TemperatureBuoyancy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:TemperatureBuoyancy");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TemperatureBuoyancy_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TemperatureBuoyancy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:TemperatureBuoyancy");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TemperatureBuoyancy_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:TemperatureDampening")]
	public float TemperatureDampening
	{
		get
		{
			CheckDestroyed();
			if (!TemperatureDampening_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:TemperatureDampening");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TemperatureDampening_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TemperatureDampening_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:TemperatureDampening");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TemperatureDampening_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:DensityDampening")]
	public float DensityDampening
	{
		get
		{
			CheckDestroyed();
			if (!DensityDampening_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:DensityDampening");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DensityDampening_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DensityDampening_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:DensityDampening");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DensityDampening_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:DensityErosion")]
	public float DensityErosion
	{
		get
		{
			CheckDestroyed();
			if (!DensityErosion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:DensityErosion");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DensityErosion_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DensityErosion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:DensityErosion");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DensityErosion_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:EmissionCurve")]
	public UCurveFloat EmissionCurve
	{
		get
		{
			CheckDestroyed();
			if (!EmissionCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:EmissionCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, EmissionCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EmissionCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:EmissionCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, EmissionCurve_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:EmissionMultiplier")]
	public float EmissionMultiplier
	{
		get
		{
			CheckDestroyed();
			if (!EmissionMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:EmissionMultiplier");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EmissionMultiplier_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EmissionMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:EmissionMultiplier");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EmissionMultiplier_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:EmissionTemperatureMultiplier")]
	public float EmissionTemperatureMultiplier
	{
		get
		{
			CheckDestroyed();
			if (!EmissionTemperatureMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:EmissionTemperatureMultiplier");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EmissionTemperatureMultiplier_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EmissionTemperatureMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:EmissionTemperatureMultiplier");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EmissionTemperatureMultiplier_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:InteractInfo")]
	public UMaterialParameterCollection InteractInfo
	{
		get
		{
			CheckDestroyed();
			if (!InteractInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:InteractInfo");
				return null;
			}
			return UObjectMarshaler<UMaterialParameterCollection>.FromNative(IntPtr.Add(base.Address, InteractInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:InteractInfo");
			}
			else
			{
				UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(base.Address, InteractInfo_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:MPCInteractPosName")]
	public FName MPCInteractPosName
	{
		get
		{
			CheckDestroyed();
			if (!MPCInteractPosName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:MPCInteractPosName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, MPCInteractPosName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MPCInteractPosName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:MPCInteractPosName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, MPCInteractPosName_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:MPCInteractVelName")]
	public FName MPCInteractVelName
	{
		get
		{
			CheckDestroyed();
			if (!MPCInteractVelName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:MPCInteractVelName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, MPCInteractVelName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MPCInteractVelName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:MPCInteractVelName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, MPCInteractVelName_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationSettings:InteractVelocityMultiper")]
	public float InteractVelocityMultiper
	{
		get
		{
			CheckDestroyed();
			if (!InteractVelocityMultiper_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:InteractVelocityMultiper");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InteractVelocityMultiper_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractVelocityMultiper_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationSettings:InteractVelocityMultiper");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InteractVelocityMultiper_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		JacobiIterations = 20;
		TimeStep = 1f;
		ConstantCurlTiling = 1f;
		ConstantCurlStrength = 0f;
		TemperatureBuoyancy = 1f;
		TemperatureDampening = 0f;
		DensityDampening = 0f;
		DensityErosion = 0f;
		EmissionMultiplier = 0f;
		EmissionTemperatureMultiplier = 0f;
		Resolution2D = 1024;
		SeedTemperatureMultiplier = 1f;
		TemperatureInset = 0.5f;
		EdgeHardness = 1f;
		NoiseStrength = 1f;
		DensityMultiplier = 1f;
		Curl1Strength = 1f;
		Curl1Tiling = 4f;
		Curl2Strength = 1f;
		Curl2Tiling = 15f;
		OverallVelocityMultiplier = 1f;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.FluidSimulationSettings");
		NativeReflection.GetPropertyRef(ref Is3D_PropertyAddress, unrealStruct, "Is3D");
		Is3D_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Is3D");
		Is3D_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Is3D", Classes.FBoolProperty);
		Resolution2D_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Resolution2D");
		Resolution2D_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Resolution2D", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref Resolution3D_PropertyAddress, unrealStruct, "Resolution3D");
		Resolution3D_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Resolution3D");
		Resolution3D_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Resolution3D", Classes.FEnumProperty);
		PressureDivisor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PressureDivisor");
		PressureDivisor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PressureDivisor", Classes.FIntProperty);
		VelocityDensityMaskAmount_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VelocityDensityMaskAmount");
		VelocityDensityMaskAmount_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VelocityDensityMaskAmount", Classes.FFloatProperty);
		DebugPressureStrength_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugPressureStrength");
		DebugPressureStrength_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugPressureStrength", Classes.FFloatProperty);
		ColorSeedMaterial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ColorSeedMaterial");
		ColorSeedMaterial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ColorSeedMaterial", Classes.FObjectProperty);
		ObstaclePoint_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ObstaclePoint");
		ObstaclePoint_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ObstaclePoint", Classes.FStructProperty);
		SeedTemperatureMultiplier_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SeedTemperatureMultiplier");
		SeedTemperatureMultiplier_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SeedTemperatureMultiplier", Classes.FFloatProperty);
		TemperatureInset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TemperatureInset");
		TemperatureInset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TemperatureInset", Classes.FFloatProperty);
		EdgeHardness_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EdgeHardness");
		EdgeHardness_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EdgeHardness", Classes.FFloatProperty);
		NoiseStrength_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NoiseStrength");
		NoiseStrength_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NoiseStrength", Classes.FFloatProperty);
		DensityMultiplier_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DensityMultiplier");
		DensityMultiplier_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DensityMultiplier", Classes.FFloatProperty);
		VelocitySeedMaterial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VelocitySeedMaterial");
		VelocitySeedMaterial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VelocitySeedMaterial", Classes.FObjectProperty);
		Curl1Strength_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Curl1Strength");
		Curl1Strength_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Curl1Strength", Classes.FFloatProperty);
		Curl1Tiling_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Curl1Tiling");
		Curl1Tiling_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Curl1Tiling", Classes.FFloatProperty);
		Curl2Strength_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Curl2Strength");
		Curl2Strength_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Curl2Strength", Classes.FFloatProperty);
		Curl2Tiling_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Curl2Tiling");
		Curl2Tiling_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Curl2Tiling", Classes.FFloatProperty);
		OverallVelocityMultiplier_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OverallVelocityMultiplier");
		OverallVelocityMultiplier_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OverallVelocityMultiplier", Classes.FFloatProperty);
		RadialForce_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RadialForce");
		RadialForce_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RadialForce", Classes.FFloatProperty);
		NoiseFieldPosOffset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NoiseFieldPosOffset");
		NoiseFieldPosOffset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NoiseFieldPosOffset", Classes.FStructProperty);
		ObstacleMaterial2D_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ObstacleMaterial2D");
		ObstacleMaterial2D_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ObstacleMaterial2D", Classes.FObjectProperty);
		AdvectionMaterial3D_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AdvectionMaterial3D");
		AdvectionMaterial3D_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AdvectionMaterial3D", Classes.FObjectProperty);
		JacobiIterations_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "JacobiIterations");
		JacobiIterations_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "JacobiIterations", Classes.FIntProperty);
		TimeStep_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TimeStep");
		TimeStep_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TimeStep", Classes.FFloatProperty);
		ConstantCurlTiling_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ConstantCurlTiling");
		ConstantCurlTiling_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ConstantCurlTiling", Classes.FFloatProperty);
		ConstantCurlStrength_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ConstantCurlStrength");
		ConstantCurlStrength_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ConstantCurlStrength", Classes.FFloatProperty);
		TemperatureBuoyancy_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TemperatureBuoyancy");
		TemperatureBuoyancy_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TemperatureBuoyancy", Classes.FFloatProperty);
		TemperatureDampening_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TemperatureDampening");
		TemperatureDampening_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TemperatureDampening", Classes.FFloatProperty);
		DensityDampening_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DensityDampening");
		DensityDampening_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DensityDampening", Classes.FFloatProperty);
		DensityErosion_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DensityErosion");
		DensityErosion_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DensityErosion", Classes.FFloatProperty);
		EmissionCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EmissionCurve");
		EmissionCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EmissionCurve", Classes.FObjectProperty);
		EmissionMultiplier_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EmissionMultiplier");
		EmissionMultiplier_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EmissionMultiplier", Classes.FFloatProperty);
		EmissionTemperatureMultiplier_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EmissionTemperatureMultiplier");
		EmissionTemperatureMultiplier_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EmissionTemperatureMultiplier", Classes.FFloatProperty);
		InteractInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InteractInfo");
		InteractInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InteractInfo", Classes.FObjectProperty);
		MPCInteractPosName_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MPCInteractPosName");
		MPCInteractPosName_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MPCInteractPosName", Classes.FNameProperty);
		MPCInteractVelName_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MPCInteractVelName");
		MPCInteractVelName_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MPCInteractVelName", Classes.FNameProperty);
		InteractVelocityMultiper_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InteractVelocityMultiper");
		InteractVelocityMultiper_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InteractVelocityMultiper", Classes.FFloatProperty);
	}

	static FluidSimulationSettings()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FluidSimulationSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FluidSimulationSettings));
	}
}
