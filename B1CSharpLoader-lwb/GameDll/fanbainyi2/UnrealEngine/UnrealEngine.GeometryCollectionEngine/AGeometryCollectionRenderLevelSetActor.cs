using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionRenderLevelSetActor", "GeometryCollectionEngine", UnrealModuleType.Engine)]
public class AGeometryCollectionRenderLevelSetActor : AActor
{
	private static bool TargetVolumeTexture_IsValid;

	private static int TargetVolumeTexture_Offset;

	private static bool RayMarchMaterial_IsValid;

	private static int RayMarchMaterial_Offset;

	private static bool SurfaceTolerance_IsValid;

	private static int SurfaceTolerance_Offset;

	private static bool Isovalue_IsValid;

	private static int Isovalue_Offset;

	private static bool Enabled_IsValid;

	private static FFieldAddress Enabled_PropertyAddress;

	private static int Enabled_Offset;

	private static bool RenderVolumeBoundingBox_IsValid;

	private static FFieldAddress RenderVolumeBoundingBox_PropertyAddress;

	private static int RenderVolumeBoundingBox_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionRenderLevelSetActor:TargetVolumeTexture")]
	public UVolumeTexture TargetVolumeTexture
	{
		get
		{
			CheckDestroyed();
			if (!TargetVolumeTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionRenderLevelSetActor:TargetVolumeTexture");
				return null;
			}
			return UObjectMarshaler<UVolumeTexture>.FromNative(IntPtr.Add(base.Address, TargetVolumeTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetVolumeTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionRenderLevelSetActor:TargetVolumeTexture");
			}
			else
			{
				UObjectMarshaler<UVolumeTexture>.ToNative(IntPtr.Add(base.Address, TargetVolumeTexture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionRenderLevelSetActor:RayMarchMaterial")]
	public UMaterial RayMarchMaterial
	{
		get
		{
			CheckDestroyed();
			if (!RayMarchMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionRenderLevelSetActor:RayMarchMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, RayMarchMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RayMarchMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionRenderLevelSetActor:RayMarchMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, RayMarchMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionRenderLevelSetActor:SurfaceTolerance")]
	public float SurfaceTolerance
	{
		get
		{
			CheckDestroyed();
			if (!SurfaceTolerance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionRenderLevelSetActor:SurfaceTolerance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SurfaceTolerance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SurfaceTolerance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionRenderLevelSetActor:SurfaceTolerance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SurfaceTolerance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionRenderLevelSetActor:Isovalue")]
	public float Isovalue
	{
		get
		{
			CheckDestroyed();
			if (!Isovalue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionRenderLevelSetActor:Isovalue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Isovalue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Isovalue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionRenderLevelSetActor:Isovalue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Isovalue_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionRenderLevelSetActor:Enabled")]
	public bool Enabled
	{
		get
		{
			CheckDestroyed();
			if (!Enabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionRenderLevelSetActor:Enabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Enabled_Offset), 0, Enabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Enabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionRenderLevelSetActor:Enabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Enabled_Offset), 0, Enabled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionRenderLevelSetActor:RenderVolumeBoundingBox")]
	public bool RenderVolumeBoundingBox
	{
		get
		{
			CheckDestroyed();
			if (!RenderVolumeBoundingBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionRenderLevelSetActor:RenderVolumeBoundingBox");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RenderVolumeBoundingBox_Offset), 0, RenderVolumeBoundingBox_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RenderVolumeBoundingBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionRenderLevelSetActor:RenderVolumeBoundingBox");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RenderVolumeBoundingBox_Offset), 0, RenderVolumeBoundingBox_PropertyAddress.Address, value);
			}
		}
	}

	static AGeometryCollectionRenderLevelSetActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGeometryCollectionRenderLevelSetActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGeometryCollectionRenderLevelSetActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/GeometryCollectionEngine.GeometryCollectionRenderLevelSetActor");
		TargetVolumeTexture_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TargetVolumeTexture");
		TargetVolumeTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TargetVolumeTexture", Classes.FObjectProperty);
		RayMarchMaterial_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RayMarchMaterial");
		RayMarchMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RayMarchMaterial", Classes.FObjectProperty);
		SurfaceTolerance_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SurfaceTolerance");
		SurfaceTolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SurfaceTolerance", Classes.FFloatProperty);
		Isovalue_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Isovalue");
		Isovalue_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Isovalue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Enabled_PropertyAddress, unrealStruct, "Enabled");
		Enabled_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Enabled");
		Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Enabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderVolumeBoundingBox_PropertyAddress, unrealStruct, "RenderVolumeBoundingBox");
		RenderVolumeBoundingBox_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RenderVolumeBoundingBox");
		RenderVolumeBoundingBox_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RenderVolumeBoundingBox", Classes.FBoolProperty);
	}
}
