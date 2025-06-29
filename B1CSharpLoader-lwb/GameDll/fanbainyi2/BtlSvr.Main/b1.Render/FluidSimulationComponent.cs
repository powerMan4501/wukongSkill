using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Render;

[UClass]
[BlueprintSpawnableComponent]
[USharpPath("/Script/b1-Managed.FluidSimulationComponent")]
public class FluidSimulationComponent : UBaseActorCompTickable
{
	private FTransform P;

	private FVector ForceVelocity;

	private FVector ForceLocation;

	private FVector ObstacleLocation;

	private FVector2D XYFrames;

	private FVector2D SavedResolution;

	private FVector2D RTSize;

	private int SavedPressureDivisor;

	private int PressureDivisor;

	private float OldObstacleRadius;

	private float ObstacleRadius;

	private float OldObstacleX;

	private FVector OldO;

	private bool RightClick;

	private static bool VelocityTexture_IsValid;

	private static int VelocityTexture_Offset;

	private static bool AdvectedVelocityTexture_IsValid;

	private static int AdvectedVelocityTexture_Offset;

	private static bool ColorTexture_IsValid;

	private static int ColorTexture_Offset;

	private static bool DivergenceTexture_IsValid;

	private static int DivergenceTexture_Offset;

	private static bool PressureTexture_IsValid;

	private static int PressureTexture_Offset;

	private static bool ScratchRT_IsValid;

	private static int ScratchRT_Offset;

	private static bool ObstacleTexture_IsValid;

	private static int ObstacleTexture_Offset;

	private static bool AdvectMID_IsValid;

	private static int AdvectMID_Offset;

	private static bool DivergenceMID_IsValid;

	private static int DivergenceMID_Offset;

	private static bool PressureIterationMID_IsValid;

	private static int PressureIterationMID_Offset;

	private static bool GradientSubtractionMID_IsValid;

	private static int GradientSubtractionMID_Offset;

	private static bool BoundaryConditionMID_IsValid;

	private static int BoundaryConditionMID_Offset;

	private static bool VelocityPreviewMID_IsValid;

	private static int VelocityPreviewMID_Offset;

	private static bool ObstacleMID_IsValid;

	private static int ObstacleMID_Offset;

	private static bool ColorPreviewMID_IsValid;

	private static int ColorPreviewMID_Offset;

	private static bool VelocitySeedMID_IsValid;

	private static int VelocitySeedMID_Offset;

	private static bool ColorSeedMID_IsValid;

	private static int ColorSeedMID_Offset;

	private static bool CopyRTMID_IsValid;

	private static int CopyRTMID_Offset;

	private static bool VolumeFogMID_IsValid;

	private static int VolumeFogMID_Offset;

	private static bool RaymarchVelocityMID_IsValid;

	private static int RaymarchVelocityMID_Offset;

	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool DefaultRes_IsValid;

	private static int DefaultRes_Offset;

	private static bool Positions_IsValid;

	private static int Positions_Offset;

	private static FFieldAddress Positions_PropertyAddress;

	private TArrayReadWriteMarshaler<FVector> Positions_Marshaler;

	private static bool Velocities_IsValid;

	private static int Velocities_Offset;

	private static FFieldAddress Velocities_PropertyAddress;

	private TArrayReadWriteMarshaler<FVector> Velocities_Marshaler;

	private static bool OverlappedActors_IsValid;

	private static int OverlappedActors_Offset;

	private static FFieldAddress OverlappedActors_PropertyAddress;

	private TArrayReadWriteMarshaler<AActor> OverlappedActors_Marshaler;

	private static bool VolumeFogComponent_IsValid;

	private static int VolumeFogComponent_Offset;

	private static bool AddActor_IsValid;

	private static IntPtr AddActor_FunctionAddress;

	private static int AddActor_ParamsSize;

	private static bool AddActor_actor_IsValid;

	private static int AddActor_actor_Offset;

	private static bool RemoveActor_IsValid;

	private static IntPtr RemoveActor_FunctionAddress;

	private static int RemoveActor_ParamsSize;

	private static bool RemoveActor_actor_IsValid;

	private static int RemoveActor_actor_Offset;

	private static bool BeginPlayInCS_IsValid;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	private static bool TickComponentInCS_IsValid;

	private static IntPtr TickComponentInCS_FunctionAddress;

	private static int TickComponentInCS_ParamsSize;

	private static bool TickComponentInCS_DeltaTime_IsValid;

	private static int TickComponentInCS_DeltaTime_Offset;

	[UProperty(Flags = PropFlags.Transient)]
	[VisibleAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:VelocityTexture")]
	public UTextureRenderTarget2D VelocityTexture
	{
		get
		{
			CheckDestroyed();
			if (!VelocityTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:VelocityTexture");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, VelocityTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocityTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:VelocityTexture");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, VelocityTexture_Offset), value);
			}
		}
	}

	[VisibleAnywhere]
	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:AdvectedVelocityTexture")]
	private UTextureRenderTarget2D AdvectedVelocityTexture
	{
		get
		{
			CheckDestroyed();
			if (!AdvectedVelocityTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:AdvectedVelocityTexture");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, AdvectedVelocityTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdvectedVelocityTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:AdvectedVelocityTexture");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, AdvectedVelocityTexture_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[VisibleAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:ColorTexture")]
	public UTextureRenderTarget2D ColorTexture
	{
		get
		{
			CheckDestroyed();
			if (!ColorTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:ColorTexture");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, ColorTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ColorTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:ColorTexture");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, ColorTexture_Offset), value);
			}
		}
	}

	[VisibleAnywhere]
	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:DivergenceTexture")]
	private UTextureRenderTarget2D DivergenceTexture
	{
		get
		{
			CheckDestroyed();
			if (!DivergenceTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:DivergenceTexture");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, DivergenceTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DivergenceTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:DivergenceTexture");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, DivergenceTexture_Offset), value);
			}
		}
	}

	[VisibleAnywhere]
	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:PressureTexture")]
	private UTextureRenderTarget2D PressureTexture
	{
		get
		{
			CheckDestroyed();
			if (!PressureTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:PressureTexture");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, PressureTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PressureTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:PressureTexture");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, PressureTexture_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:ScratchRT")]
	private UTextureRenderTarget2D ScratchRT
	{
		get
		{
			CheckDestroyed();
			if (!ScratchRT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:ScratchRT");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, ScratchRT_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScratchRT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:ScratchRT");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, ScratchRT_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:ObstacleTexture")]
	private UTextureRenderTarget2D ObstacleTexture
	{
		get
		{
			CheckDestroyed();
			if (!ObstacleTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:ObstacleTexture");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, ObstacleTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ObstacleTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:ObstacleTexture");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, ObstacleTexture_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:AdvectMID")]
	private UMaterialInstanceDynamic AdvectMID
	{
		get
		{
			CheckDestroyed();
			if (!AdvectMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:AdvectMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, AdvectMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdvectMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:AdvectMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, AdvectMID_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:DivergenceMID")]
	private UMaterialInstanceDynamic DivergenceMID
	{
		get
		{
			CheckDestroyed();
			if (!DivergenceMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:DivergenceMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, DivergenceMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DivergenceMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:DivergenceMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, DivergenceMID_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:PressureIterationMID")]
	private UMaterialInstanceDynamic PressureIterationMID
	{
		get
		{
			CheckDestroyed();
			if (!PressureIterationMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:PressureIterationMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, PressureIterationMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PressureIterationMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:PressureIterationMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, PressureIterationMID_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:GradientSubtractionMID")]
	private UMaterialInstanceDynamic GradientSubtractionMID
	{
		get
		{
			CheckDestroyed();
			if (!GradientSubtractionMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:GradientSubtractionMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, GradientSubtractionMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GradientSubtractionMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:GradientSubtractionMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, GradientSubtractionMID_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:BoundaryConditionMID")]
	private UMaterialInstanceDynamic BoundaryConditionMID
	{
		get
		{
			CheckDestroyed();
			if (!BoundaryConditionMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:BoundaryConditionMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, BoundaryConditionMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoundaryConditionMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:BoundaryConditionMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, BoundaryConditionMID_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:VelocityPreviewMID")]
	private UMaterialInstanceDynamic VelocityPreviewMID
	{
		get
		{
			CheckDestroyed();
			if (!VelocityPreviewMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:VelocityPreviewMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, VelocityPreviewMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocityPreviewMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:VelocityPreviewMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, VelocityPreviewMID_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:ObstacleMID")]
	private UMaterialInstanceDynamic ObstacleMID
	{
		get
		{
			CheckDestroyed();
			if (!ObstacleMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:ObstacleMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, ObstacleMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ObstacleMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:ObstacleMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, ObstacleMID_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:ColorPreviewMID")]
	private UMaterialInstanceDynamic ColorPreviewMID
	{
		get
		{
			CheckDestroyed();
			if (!ColorPreviewMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:ColorPreviewMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, ColorPreviewMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ColorPreviewMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:ColorPreviewMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, ColorPreviewMID_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:VelocitySeedMID")]
	private UMaterialInstanceDynamic VelocitySeedMID
	{
		get
		{
			CheckDestroyed();
			if (!VelocitySeedMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:VelocitySeedMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, VelocitySeedMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocitySeedMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:VelocitySeedMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, VelocitySeedMID_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:ColorSeedMID")]
	private UMaterialInstanceDynamic ColorSeedMID
	{
		get
		{
			CheckDestroyed();
			if (!ColorSeedMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:ColorSeedMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, ColorSeedMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ColorSeedMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:ColorSeedMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, ColorSeedMID_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:CopyRTMID")]
	private UMaterialInstanceDynamic CopyRTMID
	{
		get
		{
			CheckDestroyed();
			if (!CopyRTMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:CopyRTMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, CopyRTMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CopyRTMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:CopyRTMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, CopyRTMID_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:VolumeFogMID")]
	private UMaterialInstanceDynamic VolumeFogMID
	{
		get
		{
			CheckDestroyed();
			if (!VolumeFogMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:VolumeFogMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, VolumeFogMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumeFogMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:VolumeFogMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, VolumeFogMID_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:RaymarchVelocityMID")]
	private UMaterialInstanceDynamic RaymarchVelocityMID
	{
		get
		{
			CheckDestroyed();
			if (!RaymarchVelocityMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:RaymarchVelocityMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, RaymarchVelocityMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RaymarchVelocityMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:RaymarchVelocityMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, RaymarchVelocityMID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:Settings")]
	private FluidSimulationSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:Settings");
				return null;
			}
			return UObjectMarshaler<FluidSimulationSettings>.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:Settings");
			}
			else
			{
				UObjectMarshaler<FluidSimulationSettings>.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:DefaultRes")]
	private FluidSimulationRes DefaultRes
	{
		get
		{
			CheckDestroyed();
			if (!DefaultRes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:DefaultRes");
				return null;
			}
			return UObjectMarshaler<FluidSimulationRes>.FromNative(IntPtr.Add(base.Address, DefaultRes_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultRes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:DefaultRes");
			}
			else
			{
				UObjectMarshaler<FluidSimulationRes>.ToNative(IntPtr.Add(base.Address, DefaultRes_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:Positions")]
	public TArrayReadWrite<FVector> Positions
	{
		get
		{
			CheckDestroyed();
			if (!Positions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:Positions");
				return null;
			}
			if (Positions_Marshaler == null)
			{
				Positions_Marshaler = new TArrayReadWriteMarshaler<FVector>(1, Positions_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return Positions_Marshaler.FromNative(IntPtr.Add(base.Address, Positions_Offset));
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:Velocities")]
	public TArrayReadWrite<FVector> Velocities
	{
		get
		{
			CheckDestroyed();
			if (!Velocities_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:Velocities");
				return null;
			}
			if (Velocities_Marshaler == null)
			{
				Velocities_Marshaler = new TArrayReadWriteMarshaler<FVector>(1, Velocities_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return Velocities_Marshaler.FromNative(IntPtr.Add(base.Address, Velocities_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:OverlappedActors")]
	public TArrayReadWrite<AActor> OverlappedActors
	{
		get
		{
			CheckDestroyed();
			if (!OverlappedActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:OverlappedActors");
				return null;
			}
			if (OverlappedActors_Marshaler == null)
			{
				OverlappedActors_Marshaler = new TArrayReadWriteMarshaler<AActor>(1, OverlappedActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative);
			}
			return OverlappedActors_Marshaler.FromNative(IntPtr.Add(base.Address, OverlappedActors_Offset));
		}
	}

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:VolumeFogComponent")]
	public UStaticMeshComponent VolumeFogComponent
	{
		get
		{
			CheckDestroyed();
			if (!VolumeFogComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:VolumeFogComponent");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, VolumeFogComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumeFogComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationComponent:VolumeFogComponent");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, VolumeFogComponent_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
		SetResolution();
		CreateRTs();
		CreateMIDs();
		SetMIDParams();
		SeedColorAndPreview();
		UpdateObstacles();
		DebugPreivewSetup();
		foreach (UActorComponent item in GetOwner().GetComponentsByClass(UClass.GetClass<UStaticMeshComponent>()))
		{
			UStaticMeshComponent uStaticMeshComponent = item as UStaticMeshComponent;
			if (uStaticMeshComponent != null && !(uStaticMeshComponent.StaticMesh == null))
			{
				VolumeFogComponent = uStaticMeshComponent;
				break;
			}
		}
		if (VolumeFogComponent != null && VolumeFogComponent.StaticMesh != null && DefaultRes.InteractiveVolumeFogMaterial != null)
		{
			VolumeFogMID = VolumeFogComponent.CreateDynamicMaterialInstance(0, DefaultRes.InteractiveVolumeFogMaterial, B1Names.None);
			VolumeFogMID.SetTextureParameterValue(B1GlobalFNames.DensityMap, ColorTexture);
		}
	}

	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:TickComponentInCS")]
	protected override void TickComponentInCS_Implementation(float DeltaTime)
	{
		CollectCollisionAndEmitters(GetOwner().GetActorTransform());
		UpdateObstacles();
		SimulationStep();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:AddActor")]
	public void AddActor(AActor actor)
	{
		OverlappedActors.Add(actor);
		Positions.Add(actor.GetActorLocation());
		Velocities.Add(FVector.ZeroVector);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.FluidSimulationComponent:RemoveActor")]
	public void RemoveActor(AActor actor)
	{
		int num = OverlappedActors.IndexOf(actor);
		if (num >= 0)
		{
			OverlappedActors.RemoveAt(num);
			Positions.RemoveAt(num);
			Velocities.RemoveAt(num);
		}
	}

	private void SetResolution()
	{
		PressureDivisor = FMath.Max(Settings.PressureDivisor, 1);
		switch (Settings.Resolution3D)
		{
		case EFluidSimDimension.Vol_32_3:
			XYFrames.Set(32, 1);
			break;
		case EFluidSimDimension.Vol_64_3:
			XYFrames.Set(8, 8);
			break;
		case EFluidSimDimension.Vol_100_3:
			XYFrames.Set(10, 10);
			break;
		case EFluidSimDimension.Vol_128_3:
			XYFrames.Set(16, 8);
			break;
		case EFluidSimDimension.Vol_196_3:
			XYFrames.Set(14, 14);
			break;
		case EFluidSimDimension.Vol_256_3:
			XYFrames.Set(16, 16);
			break;
		case EFluidSimDimension.Vol_324_3:
			XYFrames.Set(18, 18);
			break;
		case EFluidSimDimension.Vol_400_3:
			XYFrames.Set(20, 20);
			break;
		}
		if (Settings.Is3D)
		{
			switch (Settings.Resolution3D)
			{
			case EFluidSimDimension.Vol_32_3:
				RTSize.Set(1024, 32);
				break;
			case EFluidSimDimension.Vol_64_3:
				RTSize.Set(512, 512);
				break;
			case EFluidSimDimension.Vol_100_3:
				RTSize.Set(1000, 1000);
				break;
			case EFluidSimDimension.Vol_128_3:
				RTSize.Set(2048, 1024);
				break;
			case EFluidSimDimension.Vol_196_3:
				RTSize.Set(2744, 2744);
				break;
			case EFluidSimDimension.Vol_256_3:
				RTSize.Set(4096, 4096);
				break;
			case EFluidSimDimension.Vol_324_3:
				RTSize.Set(5184, 5184);
				break;
			case EFluidSimDimension.Vol_400_3:
				RTSize.Set(8000, 8000);
				break;
			}
		}
		else
		{
			RTSize.Set(Settings.Resolution2D, Settings.Resolution2D);
		}
	}

	private void CreateRTs()
	{
		if (!(VelocityTexture != null) || SavedResolution != RTSize || SavedPressureDivisor != PressureDivisor)
		{
			int width = (int)RTSize.X / PressureDivisor;
			int height = (int)RTSize.Y / PressureDivisor;
			VelocityTexture = URenderingLibrary.CreateRenderTarget2D(this, (int)RTSize.X, (int)RTSize.Y, ETextureRenderTargetFormat.RTF_RGBA16f, FLinearColor.Black, bAutoGenerateMipMaps: false);
			AdvectedVelocityTexture = URenderingLibrary.CreateRenderTarget2D(this, (int)RTSize.X, (int)RTSize.Y, ETextureRenderTargetFormat.RTF_RGBA16f, FLinearColor.Black, bAutoGenerateMipMaps: false);
			ColorTexture = URenderingLibrary.CreateRenderTarget2D(this, (int)RTSize.X, (int)RTSize.Y, ETextureRenderTargetFormat.RTF_RGBA16f, FLinearColor.Black, bAutoGenerateMipMaps: false);
			DivergenceTexture = URenderingLibrary.CreateRenderTarget2D(this, width, height, ETextureRenderTargetFormat.RTF_RGBA16f, FLinearColor.Black, bAutoGenerateMipMaps: false);
			PressureTexture = URenderingLibrary.CreateRenderTarget2D(this, width, height, ETextureRenderTargetFormat.RTF_RGBA16f, FLinearColor.Black, bAutoGenerateMipMaps: false);
			ScratchRT = URenderingLibrary.CreateRenderTarget2D(this, width, height, ETextureRenderTargetFormat.RTF_RGBA16f, FLinearColor.Black, bAutoGenerateMipMaps: false);
			ObstacleTexture = URenderingLibrary.CreateRenderTarget2D(this, (int)RTSize.X, (int)RTSize.Y, ETextureRenderTargetFormat.RTF_RGBA16f, FLinearColor.Black, bAutoGenerateMipMaps: false);
			SavedResolution = RTSize;
			SavedPressureDivisor = PressureDivisor;
		}
	}

	private void CreateMIDs()
	{
		AdvectMID = UMaterialLibrary.CreateDynamicMaterialInstance(this, DefaultRes.AdvectionMaterial, B1Names.None, EMIDCreationFlags.None);
		AdvectMID.SetScalarParameterValue(B1Names.TimeStep, Settings.TimeStep);
		DivergenceMID = UMaterialLibrary.CreateDynamicMaterialInstance(this, DefaultRes.DivergenceMaterial, B1Names.None, EMIDCreationFlags.None);
		PressureIterationMID = UMaterialLibrary.CreateDynamicMaterialInstance(this, DefaultRes.PressureIterationMaterial, B1Names.None, EMIDCreationFlags.None);
		GradientSubtractionMID = UMaterialLibrary.CreateDynamicMaterialInstance(this, DefaultRes.GradientSubtractionMaterial, B1Names.None, EMIDCreationFlags.None);
		BoundaryConditionMID = UMaterialLibrary.CreateDynamicMaterialInstance(this, DefaultRes.BoundaryConditionMaterial, B1Names.None, EMIDCreationFlags.None);
		ObstacleMID = UMaterialLibrary.CreateDynamicMaterialInstance(this, DefaultRes.ObstacleMaterial, B1Names.None, EMIDCreationFlags.None);
		ColorPreviewMID = UMaterialLibrary.CreateDynamicMaterialInstance(this, DefaultRes.ColorPreviewMaterial, B1Names.None, EMIDCreationFlags.None);
		VelocityPreviewMID = UMaterialLibrary.CreateDynamicMaterialInstance(this, DefaultRes.VelocityPreviewMaterial, B1Names.None, EMIDCreationFlags.None);
		VelocitySeedMID = UMaterialLibrary.CreateDynamicMaterialInstance(this, DefaultRes.VelocitySeedMaterial, B1Names.None, EMIDCreationFlags.None);
		CopyRTMID = UMaterialLibrary.CreateDynamicMaterialInstance(this, DefaultRes.CopyRTMaterial, B1Names.None, EMIDCreationFlags.None);
		ColorSeedMID = UMaterialLibrary.CreateDynamicMaterialInstance(this, Settings.ColorSeedMaterial, B1Names.None, EMIDCreationFlags.None);
		RaymarchVelocityMID = UMaterialLibrary.CreateDynamicMaterialInstance(this, DefaultRes.RaymarchVelocityMaterial, B1Names.None, EMIDCreationFlags.None);
	}

	private void SetMIDParams()
	{
		AdvectMID.SetTextureParameterValue(B1Names.Mask, ObstacleTexture);
		DivergenceMID.SetTextureParameterValue(B1Names.Mask, ObstacleTexture);
		PressureIterationMID.SetTextureParameterValue(B1Names.Mask, ObstacleTexture);
		GradientSubtractionMID.SetTextureParameterValue(B1Names.Mask, ObstacleTexture);
		ColorPreviewMID.SetTextureParameterValue(B1Names.Mask, ObstacleTexture);
		float value = Settings.Resolution2D;
		AdvectMID.SetScalarParameterValue(B1Names.Resolution, value);
		DivergenceMID.SetScalarParameterValue(B1Names.Resolution, value);
		PressureIterationMID.SetScalarParameterValue(B1Names.Resolution, value);
		GradientSubtractionMID.SetScalarParameterValue(B1Names.Resolution, value);
		FLinearColor value2 = new FLinearColor(RTSize.X, RTSize.Y, 0f);
		AdvectMID.SetVectorParameterValue(B1Names.Resolution, value2);
		DivergenceMID.SetVectorParameterValue(B1Names.Resolution, value2);
		PressureIterationMID.SetVectorParameterValue(B1Names.Resolution, value2);
		GradientSubtractionMID.SetVectorParameterValue(B1Names.Resolution, value2);
		RaymarchVelocityMID?.SetVectorParameterValue(B1Names.Resolution, value2);
		FLinearColor value3 = new FLinearColor(RTSize.X / XYFrames.X, RTSize.Y / XYFrames.Y, XYFrames.X * XYFrames.Y);
		AdvectMID.SetVectorParameterValue(B1Names.FrameResolution, value3);
		DivergenceMID.SetVectorParameterValue(B1Names.FrameResolution, value3);
		PressureIterationMID.SetVectorParameterValue(B1Names.FrameResolution, value3);
		GradientSubtractionMID.SetVectorParameterValue(B1Names.FrameResolution, value3);
		RaymarchVelocityMID?.SetVectorParameterValue(B1Names.FrameResolution, value3);
		FLinearColor value4 = new FLinearColor(XYFrames.X, XYFrames.Y, 0f);
		AdvectMID.SetVectorParameterValue(B1Names.XYFrames, value4);
		DivergenceMID.SetVectorParameterValue(B1Names.XYFrames, value4);
		PressureIterationMID.SetVectorParameterValue(B1Names.XYFrames, value4);
		GradientSubtractionMID.SetVectorParameterValue(B1Names.XYFrames, value4);
		VelocityPreviewMID.SetVectorParameterValue(B1Names.XYFrames, value4);
		VelocitySeedMID.SetVectorParameterValue(B1Names.XYFrames, value4);
		ColorSeedMID.SetVectorParameterValue(B1Names.XYFrames, value4);
		RaymarchVelocityMID?.SetVectorParameterValue(B1Names.XYFrames, value4);
		AdvectMID.SetScalarParameterValue(B1Names.Temp, Settings.ConstantCurlTiling);
		AdvectMID.SetScalarParameterValue(B1Names.Force, Settings.ConstantCurlStrength);
		AdvectMID.SetScalarParameterValue(B1Names.Temp_Buoyancy, Settings.TemperatureBuoyancy);
		AdvectMID.SetScalarParameterValue(B1Names.Temperature_Dampening, 1f - Settings.TemperatureDampening);
		AdvectMID.SetScalarParameterValue(B1Names.Color_Dampening, 1f - Settings.DensityDampening);
		AdvectMID.SetScalarParameterValue(B1Names.Color_Erosion, Settings.DensityErosion);
		AdvectMID.SetScalarParameterValue(B1Names.Constant_Curl, Settings.ConstantCurlStrength);
		AdvectMID.SetScalarParameterValue(B1Names.Constant_Curl_Tiling, Settings.ConstantCurlTiling);
		FLinearColor value5 = (P.GetLocation() / 256.0 - new FVector(-0.5, -0.5, 0.0)).Conv_VectorToLinearColor();
		ColorSeedMID.SetVectorParameterValue(B1Names.P, value5);
		AdvectMID.SetVectorParameterValue(B1Names.P, value5);
		VelocitySeedMID.SetVectorParameterValue(B1Names.P, value5);
		AdvectMID.SetVectorParameterValue(B1Names.P2, value5);
		float value6 = P.GetScale3D().X * 0.1f;
		ColorSeedMID.SetScalarParameterValue(B1Names.R, value6);
		AdvectMID.SetScalarParameterValue(B1Names.R, value6);
		ColorSeedMID.SetScalarParameterValue(B1Names.Hardness, Settings.EdgeHardness);
		ColorSeedMID.SetScalarParameterValue(B1Names.Noise_Strength, Settings.NoiseStrength);
		ColorSeedMID.SetScalarParameterValue(B1Names.Density_Multiplier, Settings.DensityMultiplier);
		VelocitySeedMID.SetScalarParameterValue(B1Names.Temp, Settings.SeedTemperatureMultiplier);
		ColorSeedMID.SetScalarParameterValue(B1Names.Temp, Settings.SeedTemperatureMultiplier);
		VelocitySeedMID.SetScalarParameterValue(B1Names.Force, Settings.OverallVelocityMultiplier);
		ColorSeedMID.SetScalarParameterValue(B1Names.Force, Settings.OverallVelocityMultiplier);
		VelocitySeedMID.SetScalarParameterValue(B1Names.Radial_Force, Settings.RadialForce);
		ColorSeedMID.SetScalarParameterValue(B1Names.Radial_Force, Settings.RadialForce);
		VelocitySeedMID.SetVectorParameterValue(B1Names.Offset, Settings.NoiseFieldPosOffset.Conv_VectorToLinearColor());
		ColorSeedMID.SetVectorParameterValue(B1Names.Offset, Settings.NoiseFieldPosOffset.Conv_VectorToLinearColor());
		VelocitySeedMID.SetScalarParameterValue(B1Names.Temperature_Multiplier, Settings.SeedTemperatureMultiplier);
		ColorSeedMID.SetScalarParameterValue(B1Names.Temperature_Multiplier, Settings.SeedTemperatureMultiplier);
		VelocitySeedMID.SetScalarParameterValue(B1Names.Heat_Inset, Settings.TemperatureInset);
		ColorSeedMID.SetScalarParameterValue(B1Names.Heat_Inset, Settings.TemperatureInset);
		VelocitySeedMID.SetScalarParameterValue(B1Names.Curl_1_Tiling, Settings.Curl1Tiling);
		VelocitySeedMID.SetScalarParameterValue(B1Names.Curl_1_Strength, Settings.Curl1Strength);
		VelocitySeedMID.SetScalarParameterValue(B1Names.Curl_2_Tiling, Settings.Curl2Tiling);
		VelocitySeedMID.SetScalarParameterValue(B1Names.Curl_2_Strength, Settings.Curl2Strength);
		VelocitySeedMID.SetTextureParameterValue(B1Names.Color, ColorTexture);
		VelocityPreviewMID.SetTextureParameterValue(B1Names.RT, VelocityTexture);
		ColorPreviewMID.SetTextureParameterValue(B1Names.RT, VelocityTexture);
		ColorPreviewMID.SetTextureParameterValue(B1Names.RT2, ColorTexture);
		VelocityPreviewMID.SetTextureParameterValue(B1Names.Pressure, PressureTexture);
		RaymarchVelocityMID?.SetTextureParameterValue(B1Names.Color, ColorTexture);
		RaymarchVelocityMID?.SetTextureParameterValue(B1Names.Velocity, VelocityTexture);
		RaymarchVelocityMID?.SetScalarParameterValue(B1Names.Density_Mask, Settings.VelocityDensityMaskAmount);
		VelocityPreviewMID.SetScalarParameterValue(B1Names.PressurePreview, Settings.DebugPressureStrength);
	}

	private void SeedColorAndPreview()
	{
		URenderingLibrary.DrawMaterialToRenderTarget(this, ColorTexture, ColorSeedMID);
		URenderingLibrary.ClearRenderTarget2D(this, AdvectedVelocityTexture, FLinearColor.Black);
		URenderingLibrary.ClearRenderTarget2D(this, VelocityTexture, FLinearColor.Black);
		URenderingLibrary.DrawMaterialToRenderTarget(this, VelocityTexture, VelocitySeedMID);
		URenderingLibrary.DrawMaterialToRenderTarget(this, ObstacleTexture, ObstacleMID);
	}

	private void UpdateObstacles()
	{
		FVector fVector = ObstacleLocation / 500.0 + 0.5;
		ObstacleMID.SetVectorParameterValue(B1Names.P, new FLinearColor(fVector.X, fVector.Y, 0f, ObstacleRadius));
		ObstacleMID.SetVectorParameterValue(B1Names.V, new FLinearColor(ForceVelocity.X, ForceVelocity.Y, 0f, OldObstacleRadius - ObstacleRadius * 500f));
		OldObstacleRadius = ObstacleRadius;
		URenderingLibrary.DrawMaterialToRenderTarget(this, ObstacleTexture, ObstacleMID);
	}

	private void CollectCollisionAndEmitters(FTransform worldTranform)
	{
		FVector fVector = new FVector(100f * worldTranform.GetScale3D().X, 100f * worldTranform.GetScale3D().Y, 100f * worldTranform.GetScale3D().Z);
		worldTranform.SetScale3D(FVector.OneVector);
		FTransform t = worldTranform.Inverse();
		for (int i = 0; i < OverlappedActors.Count; i++)
		{
			AActor aActor = OverlappedActors[i];
			FVector fVector2 = Positions[i];
			FVector actorLocation = aActor.GetActorLocation();
			FVector value = actorLocation - fVector2;
			Velocities[i] = value;
			Positions[i] = actorLocation;
		}
		if (!(Settings.InteractInfo != null))
		{
			return;
		}
		for (int j = 0; j < 4 && j < 4; j++)
		{
			FName parameterName = new FName(Settings.MPCInteractPosName.ToString() + j);
			FName parameterName2 = new FName(Settings.MPCInteractVelName.ToString() + j);
			if (j < OverlappedActors.Count)
			{
				FVector location = Positions[j];
				FVector fVector3 = Velocities[j];
				FVector fVector4 = t.TransformLocation(location);
				fVector4.X += fVector.X * 0.5f;
				fVector4.Y += fVector.Y * 0.5f;
				float num = (float)Settings.Resolution2D / fVector.X;
				float num2 = (float)Settings.Resolution2D / fVector.Y;
				fVector4.X *= num;
				fVector4.Y *= num2;
				float a = 128f * num;
				UMaterialLibrary.SetVectorParameterValue(GetOwner().World, Settings.InteractInfo, parameterName, new FLinearColor(fVector4.X, fVector4.Y, fVector4.Z, a));
				UMaterialLibrary.SetVectorParameterValue(GetOwner().World, Settings.InteractInfo, parameterName2, new FLinearColor(fVector3.X, fVector3.Y, fVector3.Z));
			}
			else
			{
				UMaterialLibrary.SetVectorParameterValue(GetOwner().World, Settings.InteractInfo, parameterName, FLinearColor.TransparentBlack);
				UMaterialLibrary.SetVectorParameterValue(GetOwner().World, Settings.InteractInfo, parameterName2, FLinearColor.TransparentBlack);
			}
		}
		if (VolumeFogMID != null)
		{
			VolumeFogMID.SetVectorParameterValue(B1GlobalFNames.SizeXY, new FLinearColor(fVector.X, fVector.Y, fVector.Z, worldTranform.GetLocation().Z));
		}
		AdvectMID.SetScalarParameterValue(B1Names.InteractVelocityMultipier, Settings.InteractVelocityMultiper);
	}

	private void DebugPreivewSetup()
	{
	}

	private void SimulationStep()
	{
		Advect(VelocityTexture, VelocityTexture, AdvectedVelocityTexture, IsVelocity: true);
		Divergence(AdvectedVelocityTexture, DivergenceTexture);
		PressureIteration(PressureTexture, ScratchRT, DivergenceTexture);
		GradientSubtraction(AdvectedVelocityTexture, PressureTexture, VelocityTexture);
		Advect(VelocityTexture, ColorTexture, AdvectedVelocityTexture, IsVelocity: false);
		UTextureRenderTarget2D colorTexture = ColorTexture;
		ColorTexture = AdvectedVelocityTexture;
		AdvectedVelocityTexture = colorTexture;
		SetMIDParams();
	}

	private void Advect(UTextureRenderTarget2D SourceVelocity, UTextureRenderTarget2D SourceTexture, UTextureRenderTarget2D DestinationTexture, bool IsVelocity)
	{
		AdvectMID.SetTextureParameterValue(B1Names.Velocity, SourceVelocity);
		AdvectMID.SetTextureParameterValue(B1Names.Source, SourceTexture);
		AdvectMID.SetScalarParameterValue(B1Names.IsVelocity, IsVelocity ? 1 : 0);
		AdvectMID.SetTextureParameterValue(B1Names.Source, SourceTexture);
		AdvectMID.SetVectorParameterValue(B1Names.P, (P.GetLocation() / 256.0 - new FVector(-0.5, -0.5, -0.5)).Conv_VectorToLinearColor());
		AdvectMID.SetScalarParameterValue(B1Names.Color, RightClick ? 1 : 0);
		URenderingLibrary.ClearRenderTarget2D(this, DestinationTexture, FLinearColor.Black);
		AdvectMID.SetScalarParameterValue(B1Names.Emission_Strength, Settings.EmissionCurve.GetFloatValue(GetOwner().GetGameTimeSinceCreation()) * Settings.EmissionMultiplier);
		AdvectMID.SetScalarParameterValue(B1Names.Emission_Temperature, Settings.EmissionTemperatureMultiplier);
		URenderingLibrary.DrawMaterialToRenderTarget(this, DestinationTexture, AdvectMID);
	}

	private void Divergence(UTextureRenderTarget2D SourceTexture, UTextureRenderTarget2D DestTexture)
	{
		DivergenceMID.SetTextureParameterValue(B1Names.Velocity, SourceTexture);
		URenderingLibrary.DrawMaterialToRenderTarget(this, DestTexture, DivergenceMID);
	}

	private void PressureIteration(UTextureRenderTarget2D Pressure, UTextureRenderTarget2D ScratchRT, UTextureRenderTarget2D Divergence)
	{
		PressureIterationMID.SetTextureParameterValue(B1Names.Divergence, Divergence);
		int jacobiIterations = Settings.JacobiIterations;
		for (int i = 0; i < jacobiIterations; i++)
		{
			switch (i % 2)
			{
			case 0:
				PressureIterationMID.SetTextureParameterValue(B1Names.Pressure, Pressure);
				URenderingLibrary.DrawMaterialToRenderTarget(this, ScratchRT, PressureIterationMID);
				break;
			case 1:
				PressureIterationMID.SetTextureParameterValue(B1Names.Pressure, ScratchRT);
				URenderingLibrary.DrawMaterialToRenderTarget(this, Pressure, PressureIterationMID);
				break;
			}
		}
	}

	private void GradientSubtraction(UTextureRenderTarget2D SourceVelocityTexture, UTextureRenderTarget2D SourcePressureGradientTexture, UTextureRenderTarget2D DestVelocityTexture)
	{
		GradientSubtractionMID.SetTextureParameterValue(B1Names.Velocity, SourceVelocityTexture);
		GradientSubtractionMID.SetTextureParameterValue(B1Names.Pressure, SourcePressureGradientTexture);
		URenderingLibrary.ClearRenderTarget2D(this, DestVelocityTexture, FLinearColor.Black);
		URenderingLibrary.DrawMaterialToRenderTarget(this, DestVelocityTexture, GradientSubtractionMID);
	}

	[UFunctionInvoker("/Script/b1-Managed.FluidSimulationComponent:AddActor")]
	private static void AddActor__Invoker(IntPtr buffer, IntPtr obj)
	{
		FluidSimulationComponent fluidSimulationComponent = GCHelper.Find<FluidSimulationComponent>(obj);
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, AddActor_actor_Offset));
		fluidSimulationComponent.AddActor(actor);
	}

	[UFunctionInvoker("/Script/b1-Managed.FluidSimulationComponent:RemoveActor")]
	private static void RemoveActor__Invoker(IntPtr buffer, IntPtr obj)
	{
		FluidSimulationComponent fluidSimulationComponent = GCHelper.Find<FluidSimulationComponent>(obj);
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, RemoveActor_actor_Offset));
		fluidSimulationComponent.RemoveActor(actor);
	}

	[UFunctionInvoker("/Script/b1-Managed.FluidSimulationComponent:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		FluidSimulationComponent fluidSimulationComponent = GCHelper.Find<FluidSimulationComponent>(obj);
		fluidSimulationComponent.BeginPlayInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.FluidSimulationComponent:TickComponentInCS")]
	private static void TickComponentInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		FluidSimulationComponent fluidSimulationComponent = GCHelper.Find<FluidSimulationComponent>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TickComponentInCS_DeltaTime_Offset));
		fluidSimulationComponent.TickComponentInCS_Implementation(deltaTime);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.FluidSimulationComponent");
		VelocityTexture_Offset = NativeReflection.GetPropertyOffset(intPtr, "VelocityTexture");
		VelocityTexture_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VelocityTexture", Classes.FObjectProperty);
		AdvectedVelocityTexture_Offset = NativeReflection.GetPropertyOffset(intPtr, "AdvectedVelocityTexture");
		AdvectedVelocityTexture_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AdvectedVelocityTexture", Classes.FObjectProperty);
		ColorTexture_Offset = NativeReflection.GetPropertyOffset(intPtr, "ColorTexture");
		ColorTexture_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ColorTexture", Classes.FObjectProperty);
		DivergenceTexture_Offset = NativeReflection.GetPropertyOffset(intPtr, "DivergenceTexture");
		DivergenceTexture_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DivergenceTexture", Classes.FObjectProperty);
		PressureTexture_Offset = NativeReflection.GetPropertyOffset(intPtr, "PressureTexture");
		PressureTexture_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PressureTexture", Classes.FObjectProperty);
		ScratchRT_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScratchRT");
		ScratchRT_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScratchRT", Classes.FObjectProperty);
		ObstacleTexture_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObstacleTexture");
		ObstacleTexture_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObstacleTexture", Classes.FObjectProperty);
		AdvectMID_Offset = NativeReflection.GetPropertyOffset(intPtr, "AdvectMID");
		AdvectMID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AdvectMID", Classes.FObjectProperty);
		DivergenceMID_Offset = NativeReflection.GetPropertyOffset(intPtr, "DivergenceMID");
		DivergenceMID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DivergenceMID", Classes.FObjectProperty);
		PressureIterationMID_Offset = NativeReflection.GetPropertyOffset(intPtr, "PressureIterationMID");
		PressureIterationMID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PressureIterationMID", Classes.FObjectProperty);
		GradientSubtractionMID_Offset = NativeReflection.GetPropertyOffset(intPtr, "GradientSubtractionMID");
		GradientSubtractionMID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GradientSubtractionMID", Classes.FObjectProperty);
		BoundaryConditionMID_Offset = NativeReflection.GetPropertyOffset(intPtr, "BoundaryConditionMID");
		BoundaryConditionMID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BoundaryConditionMID", Classes.FObjectProperty);
		VelocityPreviewMID_Offset = NativeReflection.GetPropertyOffset(intPtr, "VelocityPreviewMID");
		VelocityPreviewMID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VelocityPreviewMID", Classes.FObjectProperty);
		ObstacleMID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObstacleMID");
		ObstacleMID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObstacleMID", Classes.FObjectProperty);
		ColorPreviewMID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ColorPreviewMID");
		ColorPreviewMID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ColorPreviewMID", Classes.FObjectProperty);
		VelocitySeedMID_Offset = NativeReflection.GetPropertyOffset(intPtr, "VelocitySeedMID");
		VelocitySeedMID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VelocitySeedMID", Classes.FObjectProperty);
		ColorSeedMID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ColorSeedMID");
		ColorSeedMID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ColorSeedMID", Classes.FObjectProperty);
		CopyRTMID_Offset = NativeReflection.GetPropertyOffset(intPtr, "CopyRTMID");
		CopyRTMID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CopyRTMID", Classes.FObjectProperty);
		VolumeFogMID_Offset = NativeReflection.GetPropertyOffset(intPtr, "VolumeFogMID");
		VolumeFogMID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VolumeFogMID", Classes.FObjectProperty);
		RaymarchVelocityMID_Offset = NativeReflection.GetPropertyOffset(intPtr, "RaymarchVelocityMID");
		RaymarchVelocityMID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RaymarchVelocityMID", Classes.FObjectProperty);
		Settings_Offset = NativeReflection.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Settings", Classes.FObjectProperty);
		DefaultRes_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultRes");
		DefaultRes_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultRes", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref Positions_PropertyAddress, intPtr, "Positions");
		Positions_Offset = NativeReflection.GetPropertyOffset(intPtr, "Positions");
		Positions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Positions", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref Velocities_PropertyAddress, intPtr, "Velocities");
		Velocities_Offset = NativeReflection.GetPropertyOffset(intPtr, "Velocities");
		Velocities_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Velocities", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref OverlappedActors_PropertyAddress, intPtr, "OverlappedActors");
		OverlappedActors_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverlappedActors");
		OverlappedActors_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverlappedActors", Classes.FArrayProperty);
		VolumeFogComponent_Offset = NativeReflection.GetPropertyOffset(intPtr, "VolumeFogComponent");
		VolumeFogComponent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VolumeFogComponent", Classes.FObjectProperty);
		AddActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddActor");
		AddActor_ParamsSize = NativeReflection.GetFunctionParamsSize(AddActor_FunctionAddress);
		AddActor_actor_Offset = NativeReflection.GetPropertyOffset(AddActor_FunctionAddress, "actor");
		AddActor_actor_IsValid = NativeReflection.ValidatePropertyClass(AddActor_FunctionAddress, "actor", Classes.FObjectProperty);
		AddActor_IsValid = AddActor_FunctionAddress != IntPtr.Zero && AddActor_actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FluidSimulationComponent:AddActor", AddActor_IsValid);
		RemoveActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveActor");
		RemoveActor_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveActor_FunctionAddress);
		RemoveActor_actor_Offset = NativeReflection.GetPropertyOffset(RemoveActor_FunctionAddress, "actor");
		RemoveActor_actor_IsValid = NativeReflection.ValidatePropertyClass(RemoveActor_FunctionAddress, "actor", Classes.FObjectProperty);
		RemoveActor_IsValid = RemoveActor_FunctionAddress != IntPtr.Zero && RemoveActor_actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FluidSimulationComponent:RemoveActor", RemoveActor_IsValid);
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FluidSimulationComponent:BeginPlayInCS", BeginPlayInCS_IsValid);
		TickComponentInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickComponentInCS");
		TickComponentInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickComponentInCS_FunctionAddress);
		TickComponentInCS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(TickComponentInCS_FunctionAddress, "DeltaTime");
		TickComponentInCS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(TickComponentInCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		TickComponentInCS_IsValid = TickComponentInCS_FunctionAddress != IntPtr.Zero && TickComponentInCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FluidSimulationComponent:TickComponentInCS", TickComponentInCS_IsValid);
	}

	static FluidSimulationComponent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FluidSimulationComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FluidSimulationComponent));
	}
}
