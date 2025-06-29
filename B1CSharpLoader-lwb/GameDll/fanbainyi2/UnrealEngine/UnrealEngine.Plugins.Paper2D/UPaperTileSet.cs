using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Paper2D.PaperTileSet", "Paper2D", UnrealModuleType.EnginePlugin)]
public class UPaperTileSet : UObject
{
	private static bool TileSize_IsValid;

	private static int TileSize_Offset;

	private static bool TileSheet_IsValid;

	private static int TileSheet_Offset;

	private static bool BorderMargin_IsValid;

	private static int BorderMargin_Offset;

	private static bool PerTileSpacing_IsValid;

	private static int PerTileSpacing_Offset;

	private static bool DrawingOffset_IsValid;

	private static int DrawingOffset_Offset;

	[UProperty(Flags = (PropFlags)20266268116386325uL)]
	[UMetaPath("/Script/Paper2D.PaperTileSet:TileSize")]
	public FIntPoint TileSize
	{
		get
		{
			CheckDestroyed();
			if (!TileSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileSet:TileSize");
				return default(FIntPoint);
			}
			return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(base.Address, TileSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TileSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileSet:TileSize");
			}
			else
			{
				BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(base.Address, TileSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)21392168023228949uL)]
	[UMetaPath("/Script/Paper2D.PaperTileSet:TileSheet")]
	public UTexture2D TileSheet
	{
		get
		{
			CheckDestroyed();
			if (!TileSheet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileSet:TileSheet");
				return null;
			}
			return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, TileSheet_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TileSheet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileSet:TileSheet");
			}
			else
			{
				UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, TileSheet_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)18014467228958741uL)]
	[UMetaPath("/Script/Paper2D.PaperTileSet:BorderMargin")]
	public FIntMargin BorderMargin
	{
		get
		{
			CheckDestroyed();
			if (!BorderMargin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileSet:BorderMargin");
				return default(FIntMargin);
			}
			return FIntMargin.FromNative(IntPtr.Add(base.Address, BorderMargin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BorderMargin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileSet:BorderMargin");
			}
			else
			{
				FIntMargin.ToNative(IntPtr.Add(base.Address, BorderMargin_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20266268116386325uL)]
	[UMetaPath("/Script/Paper2D.PaperTileSet:PerTileSpacing")]
	public FIntPoint PerTileSpacing
	{
		get
		{
			CheckDestroyed();
			if (!PerTileSpacing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileSet:PerTileSpacing");
				return default(FIntPoint);
			}
			return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(base.Address, PerTileSpacing_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PerTileSpacing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileSet:PerTileSpacing");
			}
			else
			{
				BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(base.Address, PerTileSpacing_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20266268116386325uL)]
	[UMetaPath("/Script/Paper2D.PaperTileSet:DrawingOffset")]
	public FIntPoint DrawingOffset
	{
		get
		{
			CheckDestroyed();
			if (!DrawingOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileSet:DrawingOffset");
				return default(FIntPoint);
			}
			return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(base.Address, DrawingOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DrawingOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileSet:DrawingOffset");
			}
			else
			{
				BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(base.Address, DrawingOffset_Offset), value);
			}
		}
	}

	static UPaperTileSet()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPaperTileSet)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPaperTileSet));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Paper2D.PaperTileSet");
		TileSize_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TileSize");
		TileSize_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TileSize", Classes.FStructProperty);
		TileSheet_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TileSheet");
		TileSheet_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TileSheet", Classes.FObjectProperty);
		BorderMargin_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BorderMargin");
		BorderMargin_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BorderMargin", Classes.FStructProperty);
		PerTileSpacing_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PerTileSpacing");
		PerTileSpacing_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PerTileSpacing", Classes.FStructProperty);
		DrawingOffset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DrawingOffset");
		DrawingOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DrawingOffset", Classes.FStructProperty);
	}
}
