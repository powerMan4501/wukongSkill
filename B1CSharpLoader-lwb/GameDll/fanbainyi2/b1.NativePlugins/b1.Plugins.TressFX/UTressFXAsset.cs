using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.TressFX;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/TressFX.TressFXAsset", "TressFX", UnrealModuleType.GamePlugin)]
public class UTressFXAsset : UObject, IInterface_AssetUserData, IInterface
{
	private static bool NumVerticesFromRootNoSimulation_IsValid;

	private static int NumVerticesFromRootNoSimulation_Offset;

	private static bool RawGuideCount_IsValid;

	private static int RawGuideCount_Offset;

	private static bool TotalStrandCount_IsValid;

	private static int TotalStrandCount_Offset;

	private static bool VertexCountPerStrand_IsValid;

	private static int VertexCountPerStrand_Offset;

	private static bool TotalVertexCount_IsValid;

	private static int TotalVertexCount_Offset;

	private static bool TotalTriangleCount_IsValid;

	private static int TotalTriangleCount_Offset;

	private static bool NumDependHairGroups_IsValid;

	private static int NumDependHairGroups_Offset;

	private static bool PreCalculateBounds_IsValid;

	private static int PreCalculateBounds_Offset;

	private static bool TressFXSimulationSettings_IsValid;

	private static int TressFXSimulationSettings_Offset;

	private static bool TressFXSimulationSettingsArray_IsValid;

	private static FFieldAddress TressFXSimulationSettingsArray_PropertyAddress;

	private static int TressFXSimulationSettingsArray_Offset;

	private TArrayReadWriteMarshaler<FTressFXSimulationSettings> TressFXSimulationSettingsArray_MarshalerCached;

	private static bool AnimationSimulationSettingsMap_IsValid;

	private static FFieldAddress AnimationSimulationSettingsMap_PropertyAddress;

	private static int AnimationSimulationSettingsMap_Offset;

	private TArrayReadWriteMarshaler<FAnimationTressFXSimulationSettings> AnimationSimulationSettingsMap_MarshalerCached;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXAsset:NumVerticesFromRootNoSimulation")]
	public int NumVerticesFromRootNoSimulation
	{
		get
		{
			CheckDestroyed();
			if (!NumVerticesFromRootNoSimulation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXAsset:NumVerticesFromRootNoSimulation");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumVerticesFromRootNoSimulation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumVerticesFromRootNoSimulation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXAsset:NumVerticesFromRootNoSimulation");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumVerticesFromRootNoSimulation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/TressFX.TressFXAsset:RawGuideCount")]
	public int RawGuideCount
	{
		get
		{
			CheckDestroyed();
			if (!RawGuideCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXAsset:RawGuideCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RawGuideCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RawGuideCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXAsset:RawGuideCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RawGuideCount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/TressFX.TressFXAsset:TotalStrandCount")]
	public int TotalStrandCount
	{
		get
		{
			CheckDestroyed();
			if (!TotalStrandCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXAsset:TotalStrandCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TotalStrandCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TotalStrandCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXAsset:TotalStrandCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TotalStrandCount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/TressFX.TressFXAsset:VertexCountPerStrand")]
	public int VertexCountPerStrand
	{
		get
		{
			CheckDestroyed();
			if (!VertexCountPerStrand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXAsset:VertexCountPerStrand");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, VertexCountPerStrand_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VertexCountPerStrand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXAsset:VertexCountPerStrand");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, VertexCountPerStrand_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/TressFX.TressFXAsset:TotalVertexCount")]
	public int TotalVertexCount
	{
		get
		{
			CheckDestroyed();
			if (!TotalVertexCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXAsset:TotalVertexCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TotalVertexCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TotalVertexCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXAsset:TotalVertexCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TotalVertexCount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/TressFX.TressFXAsset:TotalTriangleCount")]
	public int TotalTriangleCount
	{
		get
		{
			CheckDestroyed();
			if (!TotalTriangleCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXAsset:TotalTriangleCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TotalTriangleCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TotalTriangleCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXAsset:TotalTriangleCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TotalTriangleCount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/TressFX.TressFXAsset:NumDependHairGroups")]
	public int NumDependHairGroups
	{
		get
		{
			CheckDestroyed();
			if (!NumDependHairGroups_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXAsset:NumDependHairGroups");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumDependHairGroups_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumDependHairGroups_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXAsset:NumDependHairGroups");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumDependHairGroups_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420720661uL)]
	[UMetaPath("/Script/TressFX.TressFXAsset:PreCalculateBounds")]
	public FBoxSphereBounds PreCalculateBounds
	{
		get
		{
			CheckDestroyed();
			if (!PreCalculateBounds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXAsset:PreCalculateBounds");
				return default(FBoxSphereBounds);
			}
			return BlittableTypeMarshaler<FBoxSphereBounds>.FromNative(IntPtr.Add(base.Address, PreCalculateBounds_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PreCalculateBounds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXAsset:PreCalculateBounds");
			}
			else
			{
				BlittableTypeMarshaler<FBoxSphereBounds>.ToNative(IntPtr.Add(base.Address, PreCalculateBounds_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/TressFX.TressFXAsset:TressFXSimulationSettings")]
	public FTressFXSimulationSettings TressFXSimulationSettings
	{
		get
		{
			CheckDestroyed();
			if (!TressFXSimulationSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXAsset:TressFXSimulationSettings");
				return default(FTressFXSimulationSettings);
			}
			return FTressFXSimulationSettings.FromNative(IntPtr.Add(base.Address, TressFXSimulationSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TressFXSimulationSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXAsset:TressFXSimulationSettings");
			}
			else
			{
				FTressFXSimulationSettings.ToNative(IntPtr.Add(base.Address, TressFXSimulationSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/TressFX.TressFXAsset:TressFXSimulationSettingsArray")]
	public TArrayReadWrite<FTressFXSimulationSettings> TressFXSimulationSettingsArray
	{
		get
		{
			CheckDestroyed();
			if (!TressFXSimulationSettingsArray_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXAsset:TressFXSimulationSettingsArray");
				return null;
			}
			if (TressFXSimulationSettingsArray_MarshalerCached == null)
			{
				TressFXSimulationSettingsArray_MarshalerCached = new TArrayReadWriteMarshaler<FTressFXSimulationSettings>(1, TressFXSimulationSettingsArray_PropertyAddress, CachedMarshalingDelegates<FTressFXSimulationSettings, FTressFXSimulationSettings>.FromNative, CachedMarshalingDelegates<FTressFXSimulationSettings, FTressFXSimulationSettings>.ToNative);
			}
			return TressFXSimulationSettingsArray_MarshalerCached.FromNative(IntPtr.Add(base.Address, TressFXSimulationSettingsArray_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/TressFX.TressFXAsset:AnimationSimulationSettingsMap")]
	public TArrayReadWrite<FAnimationTressFXSimulationSettings> AnimationSimulationSettingsMap
	{
		get
		{
			CheckDestroyed();
			if (!AnimationSimulationSettingsMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXAsset:AnimationSimulationSettingsMap");
				return null;
			}
			if (AnimationSimulationSettingsMap_MarshalerCached == null)
			{
				AnimationSimulationSettingsMap_MarshalerCached = new TArrayReadWriteMarshaler<FAnimationTressFXSimulationSettings>(1, AnimationSimulationSettingsMap_PropertyAddress, CachedMarshalingDelegates<FAnimationTressFXSimulationSettings, FAnimationTressFXSimulationSettings>.FromNative, CachedMarshalingDelegates<FAnimationTressFXSimulationSettings, FAnimationTressFXSimulationSettings>.ToNative);
			}
			return AnimationSimulationSettingsMap_MarshalerCached.FromNative(IntPtr.Add(base.Address, AnimationSimulationSettingsMap_Offset));
		}
	}

	static UTressFXAsset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTressFXAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTressFXAsset));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/TressFX.TressFXAsset");
		NumVerticesFromRootNoSimulation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NumVerticesFromRootNoSimulation");
		NumVerticesFromRootNoSimulation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NumVerticesFromRootNoSimulation", Classes.FIntProperty);
		RawGuideCount_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RawGuideCount");
		RawGuideCount_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RawGuideCount", Classes.FIntProperty);
		TotalStrandCount_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TotalStrandCount");
		TotalStrandCount_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TotalStrandCount", Classes.FIntProperty);
		VertexCountPerStrand_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VertexCountPerStrand");
		VertexCountPerStrand_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VertexCountPerStrand", Classes.FIntProperty);
		TotalVertexCount_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TotalVertexCount");
		TotalVertexCount_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TotalVertexCount", Classes.FIntProperty);
		TotalTriangleCount_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TotalTriangleCount");
		TotalTriangleCount_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TotalTriangleCount", Classes.FIntProperty);
		NumDependHairGroups_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NumDependHairGroups");
		NumDependHairGroups_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NumDependHairGroups", Classes.FIntProperty);
		PreCalculateBounds_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PreCalculateBounds");
		PreCalculateBounds_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PreCalculateBounds", Classes.FStructProperty);
		TressFXSimulationSettings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TressFXSimulationSettings");
		TressFXSimulationSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TressFXSimulationSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TressFXSimulationSettingsArray_PropertyAddress, unrealStruct, "TressFXSimulationSettingsArray");
		TressFXSimulationSettingsArray_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TressFXSimulationSettingsArray");
		TressFXSimulationSettingsArray_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TressFXSimulationSettingsArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimationSimulationSettingsMap_PropertyAddress, unrealStruct, "AnimationSimulationSettingsMap");
		AnimationSimulationSettingsMap_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AnimationSimulationSettingsMap");
		AnimationSimulationSettingsMap_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AnimationSimulationSettingsMap", Classes.FArrayProperty);
	}
}
