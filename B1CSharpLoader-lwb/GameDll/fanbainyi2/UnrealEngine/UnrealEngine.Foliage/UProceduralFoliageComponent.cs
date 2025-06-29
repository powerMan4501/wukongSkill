using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Foliage;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Foliage.ProceduralFoliageComponent", "Foliage", UnrealModuleType.Engine)]
public class UProceduralFoliageComponent : UActorComponent
{
	private static bool FoliageSpawner_IsValid;

	private static int FoliageSpawner_Offset;

	private static bool TileOverlap_IsValid;

	private static int TileOverlap_Offset;

	private static bool AllowLandscape_IsValid;

	private static FFieldAddress AllowLandscape_PropertyAddress;

	private static int AllowLandscape_Offset;

	private static bool AllowBSP_IsValid;

	private static FFieldAddress AllowBSP_PropertyAddress;

	private static int AllowBSP_Offset;

	private static bool AllowStaticMesh_IsValid;

	private static FFieldAddress AllowStaticMesh_PropertyAddress;

	private static int AllowStaticMesh_Offset;

	private static bool AllowTranslucent_IsValid;

	private static FFieldAddress AllowTranslucent_PropertyAddress;

	private static int AllowTranslucent_Offset;

	private static bool AllowFoliage_IsValid;

	private static FFieldAddress AllowFoliage_PropertyAddress;

	private static int AllowFoliage_Offset;

	private static bool ShowDebugTiles_IsValid;

	private static FFieldAddress ShowDebugTiles_PropertyAddress;

	private static int ShowDebugTiles_Offset;

	private static bool DataLayer_IsValid;

	private static int DataLayer_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Foliage.ProceduralFoliageComponent:FoliageSpawner")]
	public UProceduralFoliageSpawner FoliageSpawner
	{
		get
		{
			CheckDestroyed();
			if (!FoliageSpawner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageComponent:FoliageSpawner");
				return null;
			}
			return UObjectMarshaler<UProceduralFoliageSpawner>.FromNative(IntPtr.Add(base.Address, FoliageSpawner_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FoliageSpawner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageComponent:FoliageSpawner");
			}
			else
			{
				UObjectMarshaler<UProceduralFoliageSpawner>.ToNative(IntPtr.Add(base.Address, FoliageSpawner_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Foliage.ProceduralFoliageComponent:TileOverlap")]
	public float TileOverlap
	{
		get
		{
			CheckDestroyed();
			if (!TileOverlap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageComponent:TileOverlap");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TileOverlap_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TileOverlap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageComponent:TileOverlap");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TileOverlap_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Foliage.ProceduralFoliageComponent:bAllowLandscape")]
	public bool AllowLandscape
	{
		get
		{
			CheckDestroyed();
			if (!AllowLandscape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageComponent:bAllowLandscape");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AllowLandscape_Offset), 0, AllowLandscape_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AllowLandscape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageComponent:bAllowLandscape");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AllowLandscape_Offset), 0, AllowLandscape_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Foliage.ProceduralFoliageComponent:bAllowBSP")]
	public bool AllowBSP
	{
		get
		{
			CheckDestroyed();
			if (!AllowBSP_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageComponent:bAllowBSP");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AllowBSP_Offset), 0, AllowBSP_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AllowBSP_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageComponent:bAllowBSP");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AllowBSP_Offset), 0, AllowBSP_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Foliage.ProceduralFoliageComponent:bAllowStaticMesh")]
	public bool AllowStaticMesh
	{
		get
		{
			CheckDestroyed();
			if (!AllowStaticMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageComponent:bAllowStaticMesh");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AllowStaticMesh_Offset), 0, AllowStaticMesh_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AllowStaticMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageComponent:bAllowStaticMesh");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AllowStaticMesh_Offset), 0, AllowStaticMesh_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Foliage.ProceduralFoliageComponent:bAllowTranslucent")]
	public bool AllowTranslucent
	{
		get
		{
			CheckDestroyed();
			if (!AllowTranslucent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageComponent:bAllowTranslucent");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AllowTranslucent_Offset), 0, AllowTranslucent_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AllowTranslucent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageComponent:bAllowTranslucent");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AllowTranslucent_Offset), 0, AllowTranslucent_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Foliage.ProceduralFoliageComponent:bAllowFoliage")]
	public bool AllowFoliage
	{
		get
		{
			CheckDestroyed();
			if (!AllowFoliage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageComponent:bAllowFoliage");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AllowFoliage_Offset), 0, AllowFoliage_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AllowFoliage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageComponent:bAllowFoliage");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AllowFoliage_Offset), 0, AllowFoliage_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Foliage.ProceduralFoliageComponent:bShowDebugTiles")]
	public bool ShowDebugTiles
	{
		get
		{
			CheckDestroyed();
			if (!ShowDebugTiles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageComponent:bShowDebugTiles");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShowDebugTiles_Offset), 0, ShowDebugTiles_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShowDebugTiles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageComponent:bShowDebugTiles");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShowDebugTiles_Offset), 0, ShowDebugTiles_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755502520270853uL)]
	[UMetaPath("/Script/Foliage.ProceduralFoliageComponent:DataLayer")]
	public FActorDataLayer DataLayer
	{
		get
		{
			CheckDestroyed();
			if (!DataLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageComponent:DataLayer");
				return default(FActorDataLayer);
			}
			return FActorDataLayer.FromNative(IntPtr.Add(base.Address, DataLayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DataLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageComponent:DataLayer");
			}
			else
			{
				FActorDataLayer.ToNative(IntPtr.Add(base.Address, DataLayer_Offset), value);
			}
		}
	}

	static UProceduralFoliageComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UProceduralFoliageComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UProceduralFoliageComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Foliage.ProceduralFoliageComponent");
		FoliageSpawner_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FoliageSpawner");
		FoliageSpawner_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FoliageSpawner", Classes.FObjectProperty);
		TileOverlap_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TileOverlap");
		TileOverlap_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TileOverlap", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowLandscape_PropertyAddress, unrealStruct, "bAllowLandscape");
		AllowLandscape_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAllowLandscape");
		AllowLandscape_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAllowLandscape", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowBSP_PropertyAddress, unrealStruct, "bAllowBSP");
		AllowBSP_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAllowBSP");
		AllowBSP_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAllowBSP", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowStaticMesh_PropertyAddress, unrealStruct, "bAllowStaticMesh");
		AllowStaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAllowStaticMesh");
		AllowStaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAllowStaticMesh", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowTranslucent_PropertyAddress, unrealStruct, "bAllowTranslucent");
		AllowTranslucent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAllowTranslucent");
		AllowTranslucent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAllowTranslucent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowFoliage_PropertyAddress, unrealStruct, "bAllowFoliage");
		AllowFoliage_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAllowFoliage");
		AllowFoliage_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAllowFoliage", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowDebugTiles_PropertyAddress, unrealStruct, "bShowDebugTiles");
		ShowDebugTiles_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bShowDebugTiles");
		ShowDebugTiles_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bShowDebugTiles", Classes.FBoolProperty);
		DataLayer_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DataLayer");
		DataLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DataLayer", Classes.FStructProperty);
	}
}
