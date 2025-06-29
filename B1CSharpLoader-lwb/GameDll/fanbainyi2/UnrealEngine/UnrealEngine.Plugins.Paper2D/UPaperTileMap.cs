using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Paper2D.PaperTileMap", "Paper2D", UnrealModuleType.EnginePlugin)]
public class UPaperTileMap : UObject
{
	private static bool MapWidth_IsValid;

	private static int MapWidth_Offset;

	private static bool MapHeight_IsValid;

	private static int MapHeight_Offset;

	private static bool TileWidth_IsValid;

	private static int TileWidth_Offset;

	private static bool TileHeight_IsValid;

	private static int TileHeight_Offset;

	private static bool SeparationPerLayer_IsValid;

	private static int SeparationPerLayer_Offset;

	private static bool Material_IsValid;

	private static int Material_Offset;

	private static bool TileLayers_IsValid;

	private static FFieldAddress TileLayers_PropertyAddress;

	private static int TileLayers_Offset;

	private TArrayReadOnlyMarshaler<UPaperTileLayer> TileLayers_MarshalerCached;

	private static bool CollisionThickness_IsValid;

	private static int CollisionThickness_Offset;

	private static bool SpriteCollisionDomain_IsValid;

	private static FFieldAddress SpriteCollisionDomain_PropertyAddress;

	private static int SpriteCollisionDomain_Offset;

	private static bool ProjectionMode_IsValid;

	private static FFieldAddress ProjectionMode_PropertyAddress;

	private static int ProjectionMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Paper2D.PaperTileMap:MapWidth")]
	public int MapWidth
	{
		get
		{
			CheckDestroyed();
			if (!MapWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileMap:MapWidth");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MapWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MapWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileMap:MapWidth");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MapWidth_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Paper2D.PaperTileMap:MapHeight")]
	public int MapHeight
	{
		get
		{
			CheckDestroyed();
			if (!MapHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileMap:MapHeight");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MapHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MapHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileMap:MapHeight");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MapHeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Paper2D.PaperTileMap:TileWidth")]
	public int TileWidth
	{
		get
		{
			CheckDestroyed();
			if (!TileWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileMap:TileWidth");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TileWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TileWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileMap:TileWidth");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TileWidth_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Paper2D.PaperTileMap:TileHeight")]
	public int TileHeight
	{
		get
		{
			CheckDestroyed();
			if (!TileHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileMap:TileHeight");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TileHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TileHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileMap:TileHeight");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TileHeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Paper2D.PaperTileMap:SeparationPerLayer")]
	public float SeparationPerLayer
	{
		get
		{
			CheckDestroyed();
			if (!SeparationPerLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileMap:SeparationPerLayer");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SeparationPerLayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SeparationPerLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileMap:SeparationPerLayer");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SeparationPerLayer_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Paper2D.PaperTileMap:Material")]
	public UMaterialInterface Material
	{
		get
		{
			CheckDestroyed();
			if (!Material_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileMap:Material");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, Material_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Material_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileMap:Material");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, Material_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5630049290027549uL)]
	[UMetaPath("/Script/Paper2D.PaperTileMap:TileLayers")]
	public TArrayReadOnly<UPaperTileLayer> TileLayers
	{
		get
		{
			CheckDestroyed();
			if (!TileLayers_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileMap:TileLayers");
				return null;
			}
			if (TileLayers_MarshalerCached == null)
			{
				TileLayers_MarshalerCached = new TArrayReadOnlyMarshaler<UPaperTileLayer>(1, TileLayers_PropertyAddress, CachedMarshalingDelegates<UPaperTileLayer, UObjectMarshaler<UPaperTileLayer>>.FromNative, CachedMarshalingDelegates<UPaperTileLayer, UObjectMarshaler<UPaperTileLayer>>.ToNative);
			}
			return TileLayers_MarshalerCached.FromNative(IntPtr.Add(base.Address, TileLayers_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/Paper2D.PaperTileMap:CollisionThickness")]
	protected float CollisionThickness
	{
		get
		{
			CheckDestroyed();
			if (!CollisionThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileMap:CollisionThickness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CollisionThickness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollisionThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileMap:CollisionThickness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CollisionThickness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/Paper2D.PaperTileMap:SpriteCollisionDomain")]
	protected ESpriteCollisionMode SpriteCollisionDomain
	{
		get
		{
			CheckDestroyed();
			if (!SpriteCollisionDomain_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileMap:SpriteCollisionDomain");
				return ESpriteCollisionMode.None;
			}
			return EnumMarshaler<ESpriteCollisionMode>.FromNative(IntPtr.Add(base.Address, SpriteCollisionDomain_Offset), 0, SpriteCollisionDomain_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpriteCollisionDomain_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileMap:SpriteCollisionDomain");
			}
			else
			{
				EnumMarshaler<ESpriteCollisionMode>.ToNative(IntPtr.Add(base.Address, SpriteCollisionDomain_Offset), 0, SpriteCollisionDomain_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Paper2D.PaperTileMap:ProjectionMode")]
	public ETileMapProjectionMode ProjectionMode
	{
		get
		{
			CheckDestroyed();
			if (!ProjectionMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileMap:ProjectionMode");
				return ETileMapProjectionMode.Orthogonal;
			}
			return EnumMarshaler<ETileMapProjectionMode>.FromNative(IntPtr.Add(base.Address, ProjectionMode_Offset), 0, ProjectionMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ProjectionMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileMap:ProjectionMode");
			}
			else
			{
				EnumMarshaler<ETileMapProjectionMode>.ToNative(IntPtr.Add(base.Address, ProjectionMode_Offset), 0, ProjectionMode_PropertyAddress.Address, value);
			}
		}
	}

	static UPaperTileMap()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPaperTileMap)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPaperTileMap));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Paper2D.PaperTileMap");
		MapWidth_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MapWidth");
		MapWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MapWidth", Classes.FIntProperty);
		MapHeight_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MapHeight");
		MapHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MapHeight", Classes.FIntProperty);
		TileWidth_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TileWidth");
		TileWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TileWidth", Classes.FIntProperty);
		TileHeight_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TileHeight");
		TileHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TileHeight", Classes.FIntProperty);
		SeparationPerLayer_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SeparationPerLayer");
		SeparationPerLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SeparationPerLayer", Classes.FFloatProperty);
		Material_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Material");
		Material_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Material", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TileLayers_PropertyAddress, unrealStruct, "TileLayers");
		TileLayers_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TileLayers");
		TileLayers_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TileLayers", Classes.FArrayProperty);
		CollisionThickness_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CollisionThickness");
		CollisionThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CollisionThickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SpriteCollisionDomain_PropertyAddress, unrealStruct, "SpriteCollisionDomain");
		SpriteCollisionDomain_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SpriteCollisionDomain");
		SpriteCollisionDomain_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SpriteCollisionDomain", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectionMode_PropertyAddress, unrealStruct, "ProjectionMode");
		ProjectionMode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ProjectionMode");
		ProjectionMode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ProjectionMode", Classes.FByteProperty);
	}
}
