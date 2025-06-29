using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGSurfaceSamplerSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGSurfaceSamplerSettings : UPCGSettings
{
	private static bool PointsPerSquaredMeter_IsValid;

	private static int PointsPerSquaredMeter_Offset;

	private static bool PointExtents_IsValid;

	private static int PointExtents_Offset;

	private static bool Looseness_IsValid;

	private static int Looseness_Offset;

	private static bool Unbounded_IsValid;

	private static FFieldAddress Unbounded_PropertyAddress;

	private static int Unbounded_Offset;

	private static bool ApplyDensityToPoints_IsValid;

	private static FFieldAddress ApplyDensityToPoints_PropertyAddress;

	private static int ApplyDensityToPoints_Offset;

	private static bool PointSteepness_IsValid;

	private static int PointSteepness_Offset;

	private static bool KeepZeroDensityPoints_IsValid;

	private static FFieldAddress KeepZeroDensityPoints_PropertyAddress;

	private static int KeepZeroDensityPoints_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSurfaceSamplerSettings:PointsPerSquaredMeter")]
	public float PointsPerSquaredMeter
	{
		get
		{
			CheckDestroyed();
			if (!PointsPerSquaredMeter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSurfaceSamplerSettings:PointsPerSquaredMeter");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PointsPerSquaredMeter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PointsPerSquaredMeter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSurfaceSamplerSettings:PointsPerSquaredMeter");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PointsPerSquaredMeter_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSurfaceSamplerSettings:PointExtents")]
	public FVector PointExtents
	{
		get
		{
			CheckDestroyed();
			if (!PointExtents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSurfaceSamplerSettings:PointExtents");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, PointExtents_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PointExtents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSurfaceSamplerSettings:PointExtents");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, PointExtents_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSurfaceSamplerSettings:Looseness")]
	public float Looseness
	{
		get
		{
			CheckDestroyed();
			if (!Looseness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSurfaceSamplerSettings:Looseness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Looseness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Looseness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSurfaceSamplerSettings:Looseness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Looseness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSurfaceSamplerSettings:bUnbounded")]
	public bool Unbounded
	{
		get
		{
			CheckDestroyed();
			if (!Unbounded_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSurfaceSamplerSettings:bUnbounded");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Unbounded_Offset), 0, Unbounded_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Unbounded_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSurfaceSamplerSettings:bUnbounded");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Unbounded_Offset), 0, Unbounded_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSurfaceSamplerSettings:bApplyDensityToPoints")]
	public bool ApplyDensityToPoints
	{
		get
		{
			CheckDestroyed();
			if (!ApplyDensityToPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSurfaceSamplerSettings:bApplyDensityToPoints");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ApplyDensityToPoints_Offset), 0, ApplyDensityToPoints_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ApplyDensityToPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSurfaceSamplerSettings:bApplyDensityToPoints");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ApplyDensityToPoints_Offset), 0, ApplyDensityToPoints_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSurfaceSamplerSettings:PointSteepness")]
	public float PointSteepness
	{
		get
		{
			CheckDestroyed();
			if (!PointSteepness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSurfaceSamplerSettings:PointSteepness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PointSteepness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PointSteepness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSurfaceSamplerSettings:PointSteepness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PointSteepness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594021381uL)]
	[UMetaPath("/Script/PCG.PCGSurfaceSamplerSettings:bKeepZeroDensityPoints")]
	public bool KeepZeroDensityPoints
	{
		get
		{
			CheckDestroyed();
			if (!KeepZeroDensityPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSurfaceSamplerSettings:bKeepZeroDensityPoints");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, KeepZeroDensityPoints_Offset), 0, KeepZeroDensityPoints_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!KeepZeroDensityPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSurfaceSamplerSettings:bKeepZeroDensityPoints");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, KeepZeroDensityPoints_Offset), 0, KeepZeroDensityPoints_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGSurfaceSamplerSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGSurfaceSamplerSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGSurfaceSamplerSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGSurfaceSamplerSettings");
		PointsPerSquaredMeter_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PointsPerSquaredMeter");
		PointsPerSquaredMeter_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PointsPerSquaredMeter", Classes.FFloatProperty);
		PointExtents_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PointExtents");
		PointExtents_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PointExtents", Classes.FStructProperty);
		Looseness_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Looseness");
		Looseness_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Looseness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Unbounded_PropertyAddress, unrealStruct, "bUnbounded");
		Unbounded_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUnbounded");
		Unbounded_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUnbounded", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyDensityToPoints_PropertyAddress, unrealStruct, "bApplyDensityToPoints");
		ApplyDensityToPoints_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bApplyDensityToPoints");
		ApplyDensityToPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bApplyDensityToPoints", Classes.FBoolProperty);
		PointSteepness_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PointSteepness");
		PointSteepness_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PointSteepness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref KeepZeroDensityPoints_PropertyAddress, unrealStruct, "bKeepZeroDensityPoints");
		KeepZeroDensityPoints_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bKeepZeroDensityPoints");
		KeepZeroDensityPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bKeepZeroDensityPoints", Classes.FBoolProperty);
	}
}
