using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Paper2D.PaperTileLayer", "Paper2D", UnrealModuleType.EnginePlugin)]
public class UPaperTileLayer : UObject
{
	private static bool LayerName_IsValid;

	private static int LayerName_Offset;

	private FText LayerName_TextCached;

	private static bool LayerWidth_IsValid;

	private static int LayerWidth_Offset;

	private static bool LayerHeight_IsValid;

	private static int LayerHeight_Offset;

	private static bool HiddenInGame_IsValid;

	private static FFieldAddress HiddenInGame_PropertyAddress;

	private static int HiddenInGame_Offset;

	private static bool LayerCollides_IsValid;

	private static FFieldAddress LayerCollides_PropertyAddress;

	private static int LayerCollides_Offset;

	private static bool OverrideCollisionThickness_IsValid;

	private static FFieldAddress OverrideCollisionThickness_PropertyAddress;

	private static int OverrideCollisionThickness_Offset;

	private static bool OverrideCollisionOffset_IsValid;

	private static FFieldAddress OverrideCollisionOffset_PropertyAddress;

	private static int OverrideCollisionOffset_Offset;

	private static bool CollisionThicknessOverride_IsValid;

	private static int CollisionThicknessOverride_Offset;

	private static bool CollisionOffsetOverride_IsValid;

	private static int CollisionOffsetOverride_Offset;

	private static bool LayerColor_IsValid;

	private static int LayerColor_Offset;

	[UProperty(Flags = (PropFlags)4503599627370516uL)]
	[UMetaPath("/Script/Paper2D.PaperTileLayer:LayerName")]
	public FText LayerName
	{
		get
		{
			CheckDestroyed();
			if (!LayerName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileLayer:LayerName");
				return null;
			}
			if (LayerName_TextCached == null)
			{
				LayerName_TextCached = new FText(IntPtr.Add(base.Address, LayerName_Offset), createReference: false);
			}
			return LayerName_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!LayerName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileLayer:LayerName");
				return;
			}
			if (LayerName_TextCached == null)
			{
				LayerName_TextCached = new FText(IntPtr.Add(base.Address, LayerName_Offset), createReference: false);
			}
			LayerName_TextCached.CopyFrom(value);
		}
	}

	[UProperty(Flags = (PropFlags)20266268116386324uL)]
	[UMetaPath("/Script/Paper2D.PaperTileLayer:LayerWidth")]
	public int LayerWidth
	{
		get
		{
			CheckDestroyed();
			if (!LayerWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileLayer:LayerWidth");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LayerWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LayerWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileLayer:LayerWidth");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LayerWidth_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20266268116386324uL)]
	[UMetaPath("/Script/Paper2D.PaperTileLayer:LayerHeight")]
	public int LayerHeight
	{
		get
		{
			CheckDestroyed();
			if (!LayerHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileLayer:LayerHeight");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LayerHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LayerHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileLayer:LayerHeight");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LayerHeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20266267042643989uL)]
	[UMetaPath("/Script/Paper2D.PaperTileLayer:bHiddenInGame")]
	public bool HiddenInGame
	{
		get
		{
			CheckDestroyed();
			if (!HiddenInGame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileLayer:bHiddenInGame");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HiddenInGame_Offset), 0, HiddenInGame_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HiddenInGame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileLayer:bHiddenInGame");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HiddenInGame_Offset), 0, HiddenInGame_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20266267042643989uL)]
	[UMetaPath("/Script/Paper2D.PaperTileLayer:bLayerCollides")]
	public bool LayerCollides
	{
		get
		{
			CheckDestroyed();
			if (!LayerCollides_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileLayer:bLayerCollides");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, LayerCollides_Offset), 0, LayerCollides_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LayerCollides_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileLayer:bLayerCollides");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, LayerCollides_Offset), 0, LayerCollides_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20266267042643989uL)]
	[UMetaPath("/Script/Paper2D.PaperTileLayer:bOverrideCollisionThickness")]
	public bool OverrideCollisionThickness
	{
		get
		{
			CheckDestroyed();
			if (!OverrideCollisionThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileLayer:bOverrideCollisionThickness");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideCollisionThickness_Offset), 0, OverrideCollisionThickness_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideCollisionThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileLayer:bOverrideCollisionThickness");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideCollisionThickness_Offset), 0, OverrideCollisionThickness_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20266267042643989uL)]
	[UMetaPath("/Script/Paper2D.PaperTileLayer:bOverrideCollisionOffset")]
	public bool OverrideCollisionOffset
	{
		get
		{
			CheckDestroyed();
			if (!OverrideCollisionOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileLayer:bOverrideCollisionOffset");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideCollisionOffset_Offset), 0, OverrideCollisionOffset_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideCollisionOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileLayer:bOverrideCollisionOffset");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideCollisionOffset_Offset), 0, OverrideCollisionOffset_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20266268116386325uL)]
	[UMetaPath("/Script/Paper2D.PaperTileLayer:CollisionThicknessOverride")]
	public float CollisionThicknessOverride
	{
		get
		{
			CheckDestroyed();
			if (!CollisionThicknessOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileLayer:CollisionThicknessOverride");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CollisionThicknessOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollisionThicknessOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileLayer:CollisionThicknessOverride");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CollisionThicknessOverride_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20266268116386325uL)]
	[UMetaPath("/Script/Paper2D.PaperTileLayer:CollisionOffsetOverride")]
	public float CollisionOffsetOverride
	{
		get
		{
			CheckDestroyed();
			if (!CollisionOffsetOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileLayer:CollisionOffsetOverride");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CollisionOffsetOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollisionOffsetOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileLayer:CollisionOffsetOverride");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CollisionOffsetOverride_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20266268116386325uL)]
	[UMetaPath("/Script/Paper2D.PaperTileLayer:LayerColor")]
	public FLinearColor LayerColor
	{
		get
		{
			CheckDestroyed();
			if (!LayerColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileLayer:LayerColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, LayerColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LayerColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileLayer:LayerColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, LayerColor_Offset), value);
			}
		}
	}

	static UPaperTileLayer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPaperTileLayer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPaperTileLayer));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Paper2D.PaperTileLayer");
		LayerName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LayerName");
		LayerName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LayerName", Classes.FTextProperty);
		LayerWidth_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LayerWidth");
		LayerWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LayerWidth", Classes.FIntProperty);
		LayerHeight_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LayerHeight");
		LayerHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LayerHeight", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref HiddenInGame_PropertyAddress, unrealStruct, "bHiddenInGame");
		HiddenInGame_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bHiddenInGame");
		HiddenInGame_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bHiddenInGame", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LayerCollides_PropertyAddress, unrealStruct, "bLayerCollides");
		LayerCollides_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bLayerCollides");
		LayerCollides_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bLayerCollides", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideCollisionThickness_PropertyAddress, unrealStruct, "bOverrideCollisionThickness");
		OverrideCollisionThickness_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bOverrideCollisionThickness");
		OverrideCollisionThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bOverrideCollisionThickness", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideCollisionOffset_PropertyAddress, unrealStruct, "bOverrideCollisionOffset");
		OverrideCollisionOffset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bOverrideCollisionOffset");
		OverrideCollisionOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bOverrideCollisionOffset", Classes.FBoolProperty);
		CollisionThicknessOverride_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CollisionThicknessOverride");
		CollisionThicknessOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CollisionThicknessOverride", Classes.FFloatProperty);
		CollisionOffsetOverride_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CollisionOffsetOverride");
		CollisionOffsetOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CollisionOffsetOverride", Classes.FFloatProperty);
		LayerColor_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LayerColor");
		LayerColor_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LayerColor", Classes.FStructProperty);
	}
}
