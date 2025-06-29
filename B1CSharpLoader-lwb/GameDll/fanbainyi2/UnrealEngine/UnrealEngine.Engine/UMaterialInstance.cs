using System;
using UnrealEngine.PhysicsCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)818413729uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialInstance", "Engine", UnrealModuleType.Engine)]
public class UMaterialInstance : UMaterialInterface
{
	private static bool PhysMaterial_IsValid;

	private static int PhysMaterial_Offset;

	private static bool Parent_IsValid;

	private static int Parent_Offset;

	private static bool OverrideSubsurfaceProfile_IsValid;

	private static FFieldAddress OverrideSubsurfaceProfile_PropertyAddress;

	private static int OverrideSubsurfaceProfile_Offset;

	private static bool ScalarParameterValues_IsValid;

	private static FFieldAddress ScalarParameterValues_PropertyAddress;

	private static int ScalarParameterValues_Offset;

	private TArrayReadOnlyMarshaler<FScalarParameterValue> ScalarParameterValues_MarshalerCached;

	private static bool VectorParameterValues_IsValid;

	private static FFieldAddress VectorParameterValues_PropertyAddress;

	private static int VectorParameterValues_Offset;

	private TArrayReadOnlyMarshaler<FVectorParameterValue> VectorParameterValues_MarshalerCached;

	private static bool DoubleVectorParameterValues_IsValid;

	private static FFieldAddress DoubleVectorParameterValues_PropertyAddress;

	private static int DoubleVectorParameterValues_Offset;

	private TArrayReadOnlyMarshaler<FDoubleVectorParameterValue> DoubleVectorParameterValues_MarshalerCached;

	private static bool TextureParameterValues_IsValid;

	private static FFieldAddress TextureParameterValues_PropertyAddress;

	private static int TextureParameterValues_Offset;

	private TArrayReadOnlyMarshaler<FTextureParameterValue> TextureParameterValues_MarshalerCached;

	private static bool RuntimeVirtualTextureParameterValues_IsValid;

	private static FFieldAddress RuntimeVirtualTextureParameterValues_PropertyAddress;

	private static int RuntimeVirtualTextureParameterValues_Offset;

	private TArrayReadOnlyMarshaler<FRuntimeVirtualTextureParameterValue> RuntimeVirtualTextureParameterValues_MarshalerCached;

	private static bool SparseVolumeTextureParameterValues_IsValid;

	private static FFieldAddress SparseVolumeTextureParameterValues_PropertyAddress;

	private static int SparseVolumeTextureParameterValues_Offset;

	private TArrayReadOnlyMarshaler<FSparseVolumeTextureParameterValue> SparseVolumeTextureParameterValues_MarshalerCached;

	private static bool FontParameterValues_IsValid;

	private static FFieldAddress FontParameterValues_PropertyAddress;

	private static int FontParameterValues_Offset;

	private TArrayReadOnlyMarshaler<FFontParameterValue> FontParameterValues_MarshalerCached;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.MaterialInstance:PhysMaterial")]
	public UPhysicalMaterial PhysMaterial
	{
		get
		{
			CheckDestroyed();
			if (!PhysMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialInstance:PhysMaterial");
				return null;
			}
			return UObjectMarshaler<UPhysicalMaterial>.FromNative(IntPtr.Add(base.Address, PhysMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhysMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialInstance:PhysMaterial");
			}
			else
			{
				UObjectMarshaler<UPhysicalMaterial>.ToNative(IntPtr.Add(base.Address, PhysMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7882468652745237uL)]
	[UMetaPath("/Script/Engine.MaterialInstance:Parent")]
	public UMaterialInterface Parent
	{
		get
		{
			CheckDestroyed();
			if (!Parent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialInstance:Parent");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, Parent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Parent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialInstance:Parent");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, Parent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.MaterialInstance:bOverrideSubsurfaceProfile")]
	public bool OverrideSubsurfaceProfile
	{
		get
		{
			CheckDestroyed();
			if (!OverrideSubsurfaceProfile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialInstance:bOverrideSubsurfaceProfile");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideSubsurfaceProfile_Offset), 0, OverrideSubsurfaceProfile_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideSubsurfaceProfile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialInstance:bOverrideSubsurfaceProfile");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideSubsurfaceProfile_Offset), 0, OverrideSubsurfaceProfile_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/Engine.MaterialInstance:ScalarParameterValues")]
	public TArrayReadOnly<FScalarParameterValue> ScalarParameterValues
	{
		get
		{
			CheckDestroyed();
			if (!ScalarParameterValues_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialInstance:ScalarParameterValues");
				return null;
			}
			if (ScalarParameterValues_MarshalerCached == null)
			{
				ScalarParameterValues_MarshalerCached = new TArrayReadOnlyMarshaler<FScalarParameterValue>(1, ScalarParameterValues_PropertyAddress, CachedMarshalingDelegates<FScalarParameterValue, FScalarParameterValue>.FromNative, CachedMarshalingDelegates<FScalarParameterValue, FScalarParameterValue>.ToNative);
			}
			return ScalarParameterValues_MarshalerCached.FromNative(IntPtr.Add(base.Address, ScalarParameterValues_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/Engine.MaterialInstance:VectorParameterValues")]
	public TArrayReadOnly<FVectorParameterValue> VectorParameterValues
	{
		get
		{
			CheckDestroyed();
			if (!VectorParameterValues_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialInstance:VectorParameterValues");
				return null;
			}
			if (VectorParameterValues_MarshalerCached == null)
			{
				VectorParameterValues_MarshalerCached = new TArrayReadOnlyMarshaler<FVectorParameterValue>(1, VectorParameterValues_PropertyAddress, CachedMarshalingDelegates<FVectorParameterValue, FVectorParameterValue>.FromNative, CachedMarshalingDelegates<FVectorParameterValue, FVectorParameterValue>.ToNative);
			}
			return VectorParameterValues_MarshalerCached.FromNative(IntPtr.Add(base.Address, VectorParameterValues_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/Engine.MaterialInstance:DoubleVectorParameterValues")]
	public TArrayReadOnly<FDoubleVectorParameterValue> DoubleVectorParameterValues
	{
		get
		{
			CheckDestroyed();
			if (!DoubleVectorParameterValues_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialInstance:DoubleVectorParameterValues");
				return null;
			}
			if (DoubleVectorParameterValues_MarshalerCached == null)
			{
				DoubleVectorParameterValues_MarshalerCached = new TArrayReadOnlyMarshaler<FDoubleVectorParameterValue>(1, DoubleVectorParameterValues_PropertyAddress, CachedMarshalingDelegates<FDoubleVectorParameterValue, FDoubleVectorParameterValue>.FromNative, CachedMarshalingDelegates<FDoubleVectorParameterValue, FDoubleVectorParameterValue>.ToNative);
			}
			return DoubleVectorParameterValues_MarshalerCached.FromNative(IntPtr.Add(base.Address, DoubleVectorParameterValues_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/Engine.MaterialInstance:TextureParameterValues")]
	public TArrayReadOnly<FTextureParameterValue> TextureParameterValues
	{
		get
		{
			CheckDestroyed();
			if (!TextureParameterValues_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialInstance:TextureParameterValues");
				return null;
			}
			if (TextureParameterValues_MarshalerCached == null)
			{
				TextureParameterValues_MarshalerCached = new TArrayReadOnlyMarshaler<FTextureParameterValue>(1, TextureParameterValues_PropertyAddress, CachedMarshalingDelegates<FTextureParameterValue, FTextureParameterValue>.FromNative, CachedMarshalingDelegates<FTextureParameterValue, FTextureParameterValue>.ToNative);
			}
			return TextureParameterValues_MarshalerCached.FromNative(IntPtr.Add(base.Address, TextureParameterValues_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/Engine.MaterialInstance:RuntimeVirtualTextureParameterValues")]
	public TArrayReadOnly<FRuntimeVirtualTextureParameterValue> RuntimeVirtualTextureParameterValues
	{
		get
		{
			CheckDestroyed();
			if (!RuntimeVirtualTextureParameterValues_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialInstance:RuntimeVirtualTextureParameterValues");
				return null;
			}
			if (RuntimeVirtualTextureParameterValues_MarshalerCached == null)
			{
				RuntimeVirtualTextureParameterValues_MarshalerCached = new TArrayReadOnlyMarshaler<FRuntimeVirtualTextureParameterValue>(1, RuntimeVirtualTextureParameterValues_PropertyAddress, CachedMarshalingDelegates<FRuntimeVirtualTextureParameterValue, FRuntimeVirtualTextureParameterValue>.FromNative, CachedMarshalingDelegates<FRuntimeVirtualTextureParameterValue, FRuntimeVirtualTextureParameterValue>.ToNative);
			}
			return RuntimeVirtualTextureParameterValues_MarshalerCached.FromNative(IntPtr.Add(base.Address, RuntimeVirtualTextureParameterValues_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/Engine.MaterialInstance:SparseVolumeTextureParameterValues")]
	public TArrayReadOnly<FSparseVolumeTextureParameterValue> SparseVolumeTextureParameterValues
	{
		get
		{
			CheckDestroyed();
			if (!SparseVolumeTextureParameterValues_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialInstance:SparseVolumeTextureParameterValues");
				return null;
			}
			if (SparseVolumeTextureParameterValues_MarshalerCached == null)
			{
				SparseVolumeTextureParameterValues_MarshalerCached = new TArrayReadOnlyMarshaler<FSparseVolumeTextureParameterValue>(1, SparseVolumeTextureParameterValues_PropertyAddress, CachedMarshalingDelegates<FSparseVolumeTextureParameterValue, FSparseVolumeTextureParameterValue>.FromNative, CachedMarshalingDelegates<FSparseVolumeTextureParameterValue, FSparseVolumeTextureParameterValue>.ToNative);
			}
			return SparseVolumeTextureParameterValues_MarshalerCached.FromNative(IntPtr.Add(base.Address, SparseVolumeTextureParameterValues_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/Engine.MaterialInstance:FontParameterValues")]
	public TArrayReadOnly<FFontParameterValue> FontParameterValues
	{
		get
		{
			CheckDestroyed();
			if (!FontParameterValues_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialInstance:FontParameterValues");
				return null;
			}
			if (FontParameterValues_MarshalerCached == null)
			{
				FontParameterValues_MarshalerCached = new TArrayReadOnlyMarshaler<FFontParameterValue>(1, FontParameterValues_PropertyAddress, CachedMarshalingDelegates<FFontParameterValue, FFontParameterValue>.FromNative, CachedMarshalingDelegates<FFontParameterValue, FFontParameterValue>.ToNative);
			}
			return FontParameterValues_MarshalerCached.FromNative(IntPtr.Add(base.Address, FontParameterValues_Offset));
		}
	}

	static UMaterialInstance()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialInstance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialInstance));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.MaterialInstance");
		PhysMaterial_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PhysMaterial");
		PhysMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PhysMaterial", Classes.FObjectProperty);
		Parent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Parent");
		Parent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Parent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideSubsurfaceProfile_PropertyAddress, unrealStruct, "bOverrideSubsurfaceProfile");
		OverrideSubsurfaceProfile_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bOverrideSubsurfaceProfile");
		OverrideSubsurfaceProfile_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bOverrideSubsurfaceProfile", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ScalarParameterValues_PropertyAddress, unrealStruct, "ScalarParameterValues");
		ScalarParameterValues_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ScalarParameterValues");
		ScalarParameterValues_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ScalarParameterValues", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref VectorParameterValues_PropertyAddress, unrealStruct, "VectorParameterValues");
		VectorParameterValues_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VectorParameterValues");
		VectorParameterValues_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VectorParameterValues", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DoubleVectorParameterValues_PropertyAddress, unrealStruct, "DoubleVectorParameterValues");
		DoubleVectorParameterValues_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DoubleVectorParameterValues");
		DoubleVectorParameterValues_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DoubleVectorParameterValues", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref TextureParameterValues_PropertyAddress, unrealStruct, "TextureParameterValues");
		TextureParameterValues_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TextureParameterValues");
		TextureParameterValues_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TextureParameterValues", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RuntimeVirtualTextureParameterValues_PropertyAddress, unrealStruct, "RuntimeVirtualTextureParameterValues");
		RuntimeVirtualTextureParameterValues_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RuntimeVirtualTextureParameterValues");
		RuntimeVirtualTextureParameterValues_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RuntimeVirtualTextureParameterValues", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SparseVolumeTextureParameterValues_PropertyAddress, unrealStruct, "SparseVolumeTextureParameterValues");
		SparseVolumeTextureParameterValues_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SparseVolumeTextureParameterValues");
		SparseVolumeTextureParameterValues_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SparseVolumeTextureParameterValues", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref FontParameterValues_PropertyAddress, unrealStruct, "FontParameterValues");
		FontParameterValues_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FontParameterValues");
		FontParameterValues_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FontParameterValues", Classes.FArrayProperty);
	}
}
