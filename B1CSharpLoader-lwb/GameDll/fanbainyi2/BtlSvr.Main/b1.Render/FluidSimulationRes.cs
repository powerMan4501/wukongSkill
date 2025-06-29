using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Render;

[UClass]
[USharpPath("/Script/b1-Managed.FluidSimulationRes")]
public class FluidSimulationRes : UPrimaryDataAsset
{
	private static bool AdvectionMaterial_IsValid;

	private static int AdvectionMaterial_Offset;

	private static bool DivergenceMaterial_IsValid;

	private static int DivergenceMaterial_Offset;

	private static bool PressureIterationMaterial_IsValid;

	private static int PressureIterationMaterial_Offset;

	private static bool GradientSubtractionMaterial_IsValid;

	private static int GradientSubtractionMaterial_Offset;

	private static bool BoundaryConditionMaterial_IsValid;

	private static int BoundaryConditionMaterial_Offset;

	private static bool ObstacleMaterial_IsValid;

	private static int ObstacleMaterial_Offset;

	private static bool ColorPreviewMaterial_IsValid;

	private static int ColorPreviewMaterial_Offset;

	private static bool VelocityPreviewMaterial_IsValid;

	private static int VelocityPreviewMaterial_Offset;

	private static bool VolumePreviewMaterial_IsValid;

	private static int VolumePreviewMaterial_Offset;

	private static bool VelocitySeedMaterial_IsValid;

	private static int VelocitySeedMaterial_Offset;

	private static bool CopyRTMaterial_IsValid;

	private static int CopyRTMaterial_Offset;

	private static bool RaymarchVelocityMaterial_IsValid;

	private static int RaymarchVelocityMaterial_Offset;

	private static bool InteractiveVolumeFogMaterial_IsValid;

	private static int InteractiveVolumeFogMaterial_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FluidSimulationRes:AdvectionMaterial")]
	public UMaterial AdvectionMaterial
	{
		get
		{
			CheckDestroyed();
			if (!AdvectionMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:AdvectionMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, AdvectionMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdvectionMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:AdvectionMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, AdvectionMaterial_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FluidSimulationRes:DivergenceMaterial")]
	public UMaterial DivergenceMaterial
	{
		get
		{
			CheckDestroyed();
			if (!DivergenceMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:DivergenceMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, DivergenceMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DivergenceMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:DivergenceMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, DivergenceMaterial_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationRes:PressureIterationMaterial")]
	public UMaterial PressureIterationMaterial
	{
		get
		{
			CheckDestroyed();
			if (!PressureIterationMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:PressureIterationMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, PressureIterationMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PressureIterationMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:PressureIterationMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, PressureIterationMaterial_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FluidSimulationRes:GradientSubtractionMaterial")]
	public UMaterial GradientSubtractionMaterial
	{
		get
		{
			CheckDestroyed();
			if (!GradientSubtractionMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:GradientSubtractionMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, GradientSubtractionMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GradientSubtractionMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:GradientSubtractionMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, GradientSubtractionMaterial_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationRes:BoundaryConditionMaterial")]
	public UMaterial BoundaryConditionMaterial
	{
		get
		{
			CheckDestroyed();
			if (!BoundaryConditionMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:BoundaryConditionMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, BoundaryConditionMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoundaryConditionMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:BoundaryConditionMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, BoundaryConditionMaterial_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationRes:ObstacleMaterial")]
	public UMaterial ObstacleMaterial
	{
		get
		{
			CheckDestroyed();
			if (!ObstacleMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:ObstacleMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, ObstacleMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ObstacleMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:ObstacleMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, ObstacleMaterial_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FluidSimulationRes:ColorPreviewMaterial")]
	public UMaterial ColorPreviewMaterial
	{
		get
		{
			CheckDestroyed();
			if (!ColorPreviewMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:ColorPreviewMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, ColorPreviewMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ColorPreviewMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:ColorPreviewMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, ColorPreviewMaterial_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationRes:VelocityPreviewMaterial")]
	public UMaterial VelocityPreviewMaterial
	{
		get
		{
			CheckDestroyed();
			if (!VelocityPreviewMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:VelocityPreviewMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, VelocityPreviewMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocityPreviewMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:VelocityPreviewMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, VelocityPreviewMaterial_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FluidSimulationRes:VolumePreviewMaterial")]
	public UMaterial VolumePreviewMaterial
	{
		get
		{
			CheckDestroyed();
			if (!VolumePreviewMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:VolumePreviewMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, VolumePreviewMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumePreviewMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:VolumePreviewMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, VolumePreviewMaterial_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FluidSimulationRes:VelocitySeedMaterial")]
	public UMaterial VelocitySeedMaterial
	{
		get
		{
			CheckDestroyed();
			if (!VelocitySeedMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:VelocitySeedMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, VelocitySeedMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocitySeedMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:VelocitySeedMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, VelocitySeedMaterial_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationRes:CopyRTMaterial")]
	public UMaterial CopyRTMaterial
	{
		get
		{
			CheckDestroyed();
			if (!CopyRTMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:CopyRTMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, CopyRTMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CopyRTMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:CopyRTMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, CopyRTMaterial_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FluidSimulationRes:RaymarchVelocityMaterial")]
	public UMaterial RaymarchVelocityMaterial
	{
		get
		{
			CheckDestroyed();
			if (!RaymarchVelocityMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:RaymarchVelocityMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, RaymarchVelocityMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RaymarchVelocityMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:RaymarchVelocityMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, RaymarchVelocityMaterial_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidSimulationRes:InteractiveVolumeFogMaterial")]
	public UMaterial InteractiveVolumeFogMaterial
	{
		get
		{
			CheckDestroyed();
			if (!InteractiveVolumeFogMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:InteractiveVolumeFogMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, InteractiveVolumeFogMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractiveVolumeFogMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidSimulationRes:InteractiveVolumeFogMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, InteractiveVolumeFogMaterial_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.FluidSimulationRes");
		AdvectionMaterial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AdvectionMaterial");
		AdvectionMaterial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AdvectionMaterial", Classes.FObjectProperty);
		DivergenceMaterial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DivergenceMaterial");
		DivergenceMaterial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DivergenceMaterial", Classes.FObjectProperty);
		PressureIterationMaterial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PressureIterationMaterial");
		PressureIterationMaterial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PressureIterationMaterial", Classes.FObjectProperty);
		GradientSubtractionMaterial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GradientSubtractionMaterial");
		GradientSubtractionMaterial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GradientSubtractionMaterial", Classes.FObjectProperty);
		BoundaryConditionMaterial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BoundaryConditionMaterial");
		BoundaryConditionMaterial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BoundaryConditionMaterial", Classes.FObjectProperty);
		ObstacleMaterial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ObstacleMaterial");
		ObstacleMaterial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ObstacleMaterial", Classes.FObjectProperty);
		ColorPreviewMaterial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ColorPreviewMaterial");
		ColorPreviewMaterial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ColorPreviewMaterial", Classes.FObjectProperty);
		VelocityPreviewMaterial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VelocityPreviewMaterial");
		VelocityPreviewMaterial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VelocityPreviewMaterial", Classes.FObjectProperty);
		VolumePreviewMaterial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VolumePreviewMaterial");
		VolumePreviewMaterial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VolumePreviewMaterial", Classes.FObjectProperty);
		VelocitySeedMaterial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VelocitySeedMaterial");
		VelocitySeedMaterial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VelocitySeedMaterial", Classes.FObjectProperty);
		CopyRTMaterial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CopyRTMaterial");
		CopyRTMaterial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CopyRTMaterial", Classes.FObjectProperty);
		RaymarchVelocityMaterial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RaymarchVelocityMaterial");
		RaymarchVelocityMaterial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RaymarchVelocityMaterial", Classes.FObjectProperty);
		InteractiveVolumeFogMaterial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InteractiveVolumeFogMaterial");
		InteractiveVolumeFogMaterial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InteractiveVolumeFogMaterial", Classes.FObjectProperty);
	}

	static FluidSimulationRes()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FluidSimulationRes)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FluidSimulationRes));
	}
}
