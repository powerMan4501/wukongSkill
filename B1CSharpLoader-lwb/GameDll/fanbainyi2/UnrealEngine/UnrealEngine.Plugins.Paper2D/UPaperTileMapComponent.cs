using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Paper2D.PaperTileMapComponent", "Paper2D", UnrealModuleType.EnginePlugin)]
public class UPaperTileMapComponent : UMeshComponent
{
	private static bool TileMap_IsValid;

	private static int TileMap_Offset;

	private static bool SetTileMapColor_IsValid;

	private static IntPtr SetTileMapColor_FunctionAddress;

	private static int SetTileMapColor_ParamsSize;

	private static bool SetTileMapColor_NewColor_IsValid;

	private static FFieldAddress SetTileMapColor_NewColor_PropertyAddress;

	private static int SetTileMapColor_NewColor_Offset;

	private static bool SetTileMap_IsValid;

	private static IntPtr SetTileMap_FunctionAddress;

	private static int SetTileMap_ParamsSize;

	private static bool SetTileMap_NewTileMap_IsValid;

	private static FFieldAddress SetTileMap_NewTileMap_PropertyAddress;

	private static int SetTileMap_NewTileMap_Offset;

	private static bool SetTileMap_ReturnValue_IsValid;

	private static FFieldAddress SetTileMap_ReturnValue_PropertyAddress;

	private static int SetTileMap_ReturnValue_Offset;

	private static bool SetTile_IsValid;

	private static IntPtr SetTile_FunctionAddress;

	private static int SetTile_ParamsSize;

	private static bool SetTile_X_IsValid;

	private static FFieldAddress SetTile_X_PropertyAddress;

	private static int SetTile_X_Offset;

	private static bool SetTile_Y_IsValid;

	private static FFieldAddress SetTile_Y_PropertyAddress;

	private static int SetTile_Y_Offset;

	private static bool SetTile_Layer_IsValid;

	private static FFieldAddress SetTile_Layer_PropertyAddress;

	private static int SetTile_Layer_Offset;

	private static bool SetTile_NewValue_IsValid;

	private static FFieldAddress SetTile_NewValue_PropertyAddress;

	private static int SetTile_NewValue_Offset;

	private static bool SetLayerColor_IsValid;

	private static IntPtr SetLayerColor_FunctionAddress;

	private static int SetLayerColor_ParamsSize;

	private static bool SetLayerColor_NewColor_IsValid;

	private static FFieldAddress SetLayerColor_NewColor_PropertyAddress;

	private static int SetLayerColor_NewColor_Offset;

	private static bool SetLayerColor_Layer_IsValid;

	private static FFieldAddress SetLayerColor_Layer_PropertyAddress;

	private static int SetLayerColor_Layer_Offset;

	private static bool SetLayerCollision_IsValid;

	private static IntPtr SetLayerCollision_FunctionAddress;

	private static int SetLayerCollision_ParamsSize;

	private static bool SetLayerCollision_Layer_IsValid;

	private static FFieldAddress SetLayerCollision_Layer_PropertyAddress;

	private static int SetLayerCollision_Layer_Offset;

	private static bool SetLayerCollision_bHasCollision_IsValid;

	private static FFieldAddress SetLayerCollision_bHasCollision_PropertyAddress;

	private static int SetLayerCollision_bHasCollision_Offset;

	private static bool SetLayerCollision_bOverrideThickness_IsValid;

	private static FFieldAddress SetLayerCollision_bOverrideThickness_PropertyAddress;

	private static int SetLayerCollision_bOverrideThickness_Offset;

	private static bool SetLayerCollision_CustomThickness_IsValid;

	private static FFieldAddress SetLayerCollision_CustomThickness_PropertyAddress;

	private static int SetLayerCollision_CustomThickness_Offset;

	private static bool SetLayerCollision_bOverrideOffset_IsValid;

	private static FFieldAddress SetLayerCollision_bOverrideOffset_PropertyAddress;

	private static int SetLayerCollision_bOverrideOffset_Offset;

	private static bool SetLayerCollision_CustomOffset_IsValid;

	private static FFieldAddress SetLayerCollision_CustomOffset_PropertyAddress;

	private static int SetLayerCollision_CustomOffset_Offset;

	private static bool SetLayerCollision_bRebuildCollision_IsValid;

	private static FFieldAddress SetLayerCollision_bRebuildCollision_PropertyAddress;

	private static int SetLayerCollision_bRebuildCollision_Offset;

	private static bool SetDefaultCollisionThickness_IsValid;

	private static IntPtr SetDefaultCollisionThickness_FunctionAddress;

	private static int SetDefaultCollisionThickness_ParamsSize;

	private static bool SetDefaultCollisionThickness_Thickness_IsValid;

	private static FFieldAddress SetDefaultCollisionThickness_Thickness_PropertyAddress;

	private static int SetDefaultCollisionThickness_Thickness_Offset;

	private static bool SetDefaultCollisionThickness_bRebuildCollision_IsValid;

	private static FFieldAddress SetDefaultCollisionThickness_bRebuildCollision_PropertyAddress;

	private static int SetDefaultCollisionThickness_bRebuildCollision_Offset;

	private static bool ResizeMap_IsValid;

	private static IntPtr ResizeMap_FunctionAddress;

	private static int ResizeMap_ParamsSize;

	private static bool ResizeMap_NewWidthInTiles_IsValid;

	private static FFieldAddress ResizeMap_NewWidthInTiles_PropertyAddress;

	private static int ResizeMap_NewWidthInTiles_Offset;

	private static bool ResizeMap_NewHeightInTiles_IsValid;

	private static FFieldAddress ResizeMap_NewHeightInTiles_PropertyAddress;

	private static int ResizeMap_NewHeightInTiles_Offset;

	private static bool RebuildCollision_IsValid;

	private static IntPtr RebuildCollision_FunctionAddress;

	private static int RebuildCollision_ParamsSize;

	private static bool OwnsTileMap_IsValid;

	private static IntPtr OwnsTileMap_FunctionAddress;

	private static int OwnsTileMap_ParamsSize;

	private static bool OwnsTileMap_ReturnValue_IsValid;

	private static FFieldAddress OwnsTileMap_ReturnValue_PropertyAddress;

	private static int OwnsTileMap_ReturnValue_Offset;

	private static bool MakeTileMapEditable_IsValid;

	private static IntPtr MakeTileMapEditable_FunctionAddress;

	private static int MakeTileMapEditable_ParamsSize;

	private static bool GetTilePolygon_IsValid;

	private static IntPtr GetTilePolygon_FunctionAddress;

	private static int GetTilePolygon_ParamsSize;

	private static bool GetTilePolygon_TileX_IsValid;

	private static FFieldAddress GetTilePolygon_TileX_PropertyAddress;

	private static int GetTilePolygon_TileX_Offset;

	private static bool GetTilePolygon_TileY_IsValid;

	private static FFieldAddress GetTilePolygon_TileY_PropertyAddress;

	private static int GetTilePolygon_TileY_Offset;

	private static bool GetTilePolygon_Points_IsValid;

	private static FFieldAddress GetTilePolygon_Points_PropertyAddress;

	private static int GetTilePolygon_Points_Offset;

	private static bool GetTilePolygon_LayerIndex_IsValid;

	private static FFieldAddress GetTilePolygon_LayerIndex_PropertyAddress;

	private static int GetTilePolygon_LayerIndex_Offset;

	private static bool GetTilePolygon_bWorldSpace_IsValid;

	private static FFieldAddress GetTilePolygon_bWorldSpace_PropertyAddress;

	private static int GetTilePolygon_bWorldSpace_Offset;

	private static bool GetTileMapColor_IsValid;

	private static IntPtr GetTileMapColor_FunctionAddress;

	private static int GetTileMapColor_ParamsSize;

	private static bool GetTileMapColor_ReturnValue_IsValid;

	private static FFieldAddress GetTileMapColor_ReturnValue_PropertyAddress;

	private static int GetTileMapColor_ReturnValue_Offset;

	private static bool GetTileCornerPosition_IsValid;

	private static IntPtr GetTileCornerPosition_FunctionAddress;

	private static int GetTileCornerPosition_ParamsSize;

	private static bool GetTileCornerPosition_TileX_IsValid;

	private static FFieldAddress GetTileCornerPosition_TileX_PropertyAddress;

	private static int GetTileCornerPosition_TileX_Offset;

	private static bool GetTileCornerPosition_TileY_IsValid;

	private static FFieldAddress GetTileCornerPosition_TileY_PropertyAddress;

	private static int GetTileCornerPosition_TileY_Offset;

	private static bool GetTileCornerPosition_LayerIndex_IsValid;

	private static FFieldAddress GetTileCornerPosition_LayerIndex_PropertyAddress;

	private static int GetTileCornerPosition_LayerIndex_Offset;

	private static bool GetTileCornerPosition_bWorldSpace_IsValid;

	private static FFieldAddress GetTileCornerPosition_bWorldSpace_PropertyAddress;

	private static int GetTileCornerPosition_bWorldSpace_Offset;

	private static bool GetTileCornerPosition_ReturnValue_IsValid;

	private static FFieldAddress GetTileCornerPosition_ReturnValue_PropertyAddress;

	private static int GetTileCornerPosition_ReturnValue_Offset;

	private static bool GetTileCenterPosition_IsValid;

	private static IntPtr GetTileCenterPosition_FunctionAddress;

	private static int GetTileCenterPosition_ParamsSize;

	private static bool GetTileCenterPosition_TileX_IsValid;

	private static FFieldAddress GetTileCenterPosition_TileX_PropertyAddress;

	private static int GetTileCenterPosition_TileX_Offset;

	private static bool GetTileCenterPosition_TileY_IsValid;

	private static FFieldAddress GetTileCenterPosition_TileY_PropertyAddress;

	private static int GetTileCenterPosition_TileY_Offset;

	private static bool GetTileCenterPosition_LayerIndex_IsValid;

	private static FFieldAddress GetTileCenterPosition_LayerIndex_PropertyAddress;

	private static int GetTileCenterPosition_LayerIndex_Offset;

	private static bool GetTileCenterPosition_bWorldSpace_IsValid;

	private static FFieldAddress GetTileCenterPosition_bWorldSpace_PropertyAddress;

	private static int GetTileCenterPosition_bWorldSpace_Offset;

	private static bool GetTileCenterPosition_ReturnValue_IsValid;

	private static FFieldAddress GetTileCenterPosition_ReturnValue_PropertyAddress;

	private static int GetTileCenterPosition_ReturnValue_Offset;

	private static bool GetTile_IsValid;

	private static IntPtr GetTile_FunctionAddress;

	private static int GetTile_ParamsSize;

	private static bool GetTile_X_IsValid;

	private static FFieldAddress GetTile_X_PropertyAddress;

	private static int GetTile_X_Offset;

	private static bool GetTile_Y_IsValid;

	private static FFieldAddress GetTile_Y_PropertyAddress;

	private static int GetTile_Y_Offset;

	private static bool GetTile_Layer_IsValid;

	private static FFieldAddress GetTile_Layer_PropertyAddress;

	private static int GetTile_Layer_Offset;

	private static bool GetTile_ReturnValue_IsValid;

	private static FFieldAddress GetTile_ReturnValue_PropertyAddress;

	private static int GetTile_ReturnValue_Offset;

	private static bool GetMapSize_IsValid;

	private static IntPtr GetMapSize_FunctionAddress;

	private static int GetMapSize_ParamsSize;

	private static bool GetMapSize_MapWidth_IsValid;

	private static FFieldAddress GetMapSize_MapWidth_PropertyAddress;

	private static int GetMapSize_MapWidth_Offset;

	private static bool GetMapSize_MapHeight_IsValid;

	private static FFieldAddress GetMapSize_MapHeight_PropertyAddress;

	private static int GetMapSize_MapHeight_Offset;

	private static bool GetMapSize_NumLayers_IsValid;

	private static FFieldAddress GetMapSize_NumLayers_PropertyAddress;

	private static int GetMapSize_NumLayers_Offset;

	private static bool GetLayerColor_IsValid;

	private static IntPtr GetLayerColor_FunctionAddress;

	private static int GetLayerColor_ParamsSize;

	private static bool GetLayerColor_Layer_IsValid;

	private static FFieldAddress GetLayerColor_Layer_PropertyAddress;

	private static int GetLayerColor_Layer_Offset;

	private static bool GetLayerColor_ReturnValue_IsValid;

	private static FFieldAddress GetLayerColor_ReturnValue_PropertyAddress;

	private static int GetLayerColor_ReturnValue_Offset;

	private static bool CreateNewTileMap_IsValid;

	private static IntPtr CreateNewTileMap_FunctionAddress;

	private static int CreateNewTileMap_ParamsSize;

	private static bool CreateNewTileMap_MapWidth_IsValid;

	private static FFieldAddress CreateNewTileMap_MapWidth_PropertyAddress;

	private static int CreateNewTileMap_MapWidth_Offset;

	private static bool CreateNewTileMap_MapHeight_IsValid;

	private static FFieldAddress CreateNewTileMap_MapHeight_PropertyAddress;

	private static int CreateNewTileMap_MapHeight_Offset;

	private static bool CreateNewTileMap_TileWidth_IsValid;

	private static FFieldAddress CreateNewTileMap_TileWidth_PropertyAddress;

	private static int CreateNewTileMap_TileWidth_Offset;

	private static bool CreateNewTileMap_TileHeight_IsValid;

	private static FFieldAddress CreateNewTileMap_TileHeight_PropertyAddress;

	private static int CreateNewTileMap_TileHeight_Offset;

	private static bool CreateNewTileMap_PixelsPerUnrealUnit_IsValid;

	private static FFieldAddress CreateNewTileMap_PixelsPerUnrealUnit_PropertyAddress;

	private static int CreateNewTileMap_PixelsPerUnrealUnit_Offset;

	private static bool CreateNewTileMap_bCreateLayer_IsValid;

	private static FFieldAddress CreateNewTileMap_bCreateLayer_PropertyAddress;

	private static int CreateNewTileMap_bCreateLayer_Offset;

	private static bool AddNewLayer_IsValid;

	private static IntPtr AddNewLayer_FunctionAddress;

	private static int AddNewLayer_ParamsSize;

	private static bool AddNewLayer_ReturnValue_IsValid;

	private static FFieldAddress AddNewLayer_ReturnValue_PropertyAddress;

	private static int AddNewLayer_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Paper2D.PaperTileMapComponent:TileMap")]
	public UPaperTileMap TileMap
	{
		get
		{
			CheckDestroyed();
			if (!TileMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileMapComponent:TileMap");
				return null;
			}
			return UObjectMarshaler<UPaperTileMap>.FromNative(IntPtr.Add(base.Address, TileMap_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TileMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTileMapComponent:TileMap");
			}
			else
			{
				UObjectMarshaler<UPaperTileMap>.ToNative(IntPtr.Add(base.Address, TileMap_Offset), value);
			}
		}
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Paper2D.PaperTileMapComponent:SetTileMapColor")]
	public unsafe void SetTileMapColor(FLinearColor NewColor)
	{
		CheckDestroyed();
		if (!SetTileMapColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperTileMapComponent:SetTileMapColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTileMapColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTileMapColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetTileMapColor_NewColor_Offset), 0, SetTileMapColor_NewColor_PropertyAddress.Address, NewColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTileMapColor_FunctionAddress, intPtr, SetTileMapColor_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Paper2D.PaperTileMapComponent:SetTileMap")]
	public unsafe bool SetTileMap(UPaperTileMap NewTileMap)
	{
		CheckDestroyed();
		if (!SetTileMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperTileMapComponent:SetTileMap");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTileMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTileMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPaperTileMap>.ToNative(IntPtr.Add(intPtr, SetTileMap_NewTileMap_Offset), 0, SetTileMap_NewTileMap_PropertyAddress.Address, NewTileMap);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTileMap_FunctionAddress, intPtr, SetTileMap_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetTileMap_ReturnValue_Offset), 0, SetTileMap_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Paper2D.PaperTileMapComponent:SetTile")]
	public unsafe void SetTile(int X, int Y, int Layer, FPaperTileInfo NewValue)
	{
		CheckDestroyed();
		if (!SetTile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperTileMapComponent:SetTile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetTile_X_Offset), 0, SetTile_X_PropertyAddress.Address, X);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetTile_Y_Offset), 0, SetTile_Y_PropertyAddress.Address, Y);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetTile_Layer_Offset), 0, SetTile_Layer_PropertyAddress.Address, Layer);
		NativeReflection.InitializeValue_InContainer(SetTile_NewValue_PropertyAddress.Address, intPtr);
		FPaperTileInfo.ToNative(IntPtr.Add(intPtr, SetTile_NewValue_Offset), 0, SetTile_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTile_FunctionAddress, intPtr, SetTile_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Paper2D.PaperTileMapComponent:SetLayerColor")]
	public unsafe void SetLayerColor(FLinearColor NewColor, int Layer = 0)
	{
		CheckDestroyed();
		if (!SetLayerColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperTileMapComponent:SetLayerColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLayerColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLayerColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetLayerColor_NewColor_Offset), 0, SetLayerColor_NewColor_PropertyAddress.Address, NewColor);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLayerColor_Layer_Offset), 0, SetLayerColor_Layer_PropertyAddress.Address, Layer);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLayerColor_FunctionAddress, intPtr, SetLayerColor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Paper2D.PaperTileMapComponent:SetLayerCollision")]
	public unsafe void SetLayerCollision(int Layer = 0, bool bHasCollision = true, bool bOverrideThickness = true, float CustomThickness = 50f, bool bOverrideOffset = false, float CustomOffset = 0f, bool bRebuildCollision = true)
	{
		CheckDestroyed();
		if (!SetLayerCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperTileMapComponent:SetLayerCollision");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLayerCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLayerCollision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLayerCollision_Layer_Offset), 0, SetLayerCollision_Layer_PropertyAddress.Address, Layer);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLayerCollision_bHasCollision_Offset), 0, SetLayerCollision_bHasCollision_PropertyAddress.Address, bHasCollision);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLayerCollision_bOverrideThickness_Offset), 0, SetLayerCollision_bOverrideThickness_PropertyAddress.Address, bOverrideThickness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLayerCollision_CustomThickness_Offset), 0, SetLayerCollision_CustomThickness_PropertyAddress.Address, CustomThickness);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLayerCollision_bOverrideOffset_Offset), 0, SetLayerCollision_bOverrideOffset_PropertyAddress.Address, bOverrideOffset);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLayerCollision_CustomOffset_Offset), 0, SetLayerCollision_CustomOffset_PropertyAddress.Address, CustomOffset);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLayerCollision_bRebuildCollision_Offset), 0, SetLayerCollision_bRebuildCollision_PropertyAddress.Address, bRebuildCollision);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLayerCollision_FunctionAddress, intPtr, SetLayerCollision_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Paper2D.PaperTileMapComponent:SetDefaultCollisionThickness")]
	public unsafe void SetDefaultCollisionThickness(float Thickness, bool bRebuildCollision = true)
	{
		CheckDestroyed();
		if (!SetDefaultCollisionThickness_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperTileMapComponent:SetDefaultCollisionThickness");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDefaultCollisionThickness_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDefaultCollisionThickness_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDefaultCollisionThickness_Thickness_Offset), 0, SetDefaultCollisionThickness_Thickness_PropertyAddress.Address, Thickness);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetDefaultCollisionThickness_bRebuildCollision_Offset), 0, SetDefaultCollisionThickness_bRebuildCollision_PropertyAddress.Address, bRebuildCollision);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDefaultCollisionThickness_FunctionAddress, intPtr, SetDefaultCollisionThickness_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Paper2D.PaperTileMapComponent:ResizeMap")]
	public unsafe void ResizeMap(int NewWidthInTiles, int NewHeightInTiles)
	{
		CheckDestroyed();
		if (!ResizeMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperTileMapComponent:ResizeMap");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResizeMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResizeMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ResizeMap_NewWidthInTiles_Offset), 0, ResizeMap_NewWidthInTiles_PropertyAddress.Address, NewWidthInTiles);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ResizeMap_NewHeightInTiles_Offset), 0, ResizeMap_NewHeightInTiles_PropertyAddress.Address, NewHeightInTiles);
		NativeReflection.InvokeFunctionOptimized(base.Address, ResizeMap_FunctionAddress, intPtr, ResizeMap_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Paper2D.PaperTileMapComponent:RebuildCollision")]
	public unsafe void RebuildCollision()
	{
		CheckDestroyed();
		if (!RebuildCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperTileMapComponent:RebuildCollision");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RebuildCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RebuildCollision_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RebuildCollision_FunctionAddress, argsSize: RebuildCollision_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Paper2D.PaperTileMapComponent:OwnsTileMap")]
	public unsafe bool OwnsTileMap()
	{
		CheckDestroyed();
		if (!OwnsTileMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperTileMapComponent:OwnsTileMap");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OwnsTileMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OwnsTileMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, OwnsTileMap_FunctionAddress, intPtr, OwnsTileMap_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OwnsTileMap_ReturnValue_Offset), 0, OwnsTileMap_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Paper2D.PaperTileMapComponent:MakeTileMapEditable")]
	public unsafe void MakeTileMapEditable()
	{
		CheckDestroyed();
		if (!MakeTileMapEditable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperTileMapComponent:MakeTileMapEditable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeTileMapEditable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeTileMapEditable_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: MakeTileMapEditable_FunctionAddress, argsSize: MakeTileMapEditable_ParamsSize);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Paper2D.PaperTileMapComponent:GetTilePolygon")]
	public unsafe void GetTilePolygon(int TileX, int TileY, out List<FVector> Points, int LayerIndex = 0, bool bWorldSpace = false)
	{
		CheckDestroyed();
		if (!GetTilePolygon_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperTileMapComponent:GetTilePolygon");
			Points = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTilePolygon_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTilePolygon_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTilePolygon_TileX_Offset), 0, GetTilePolygon_TileX_PropertyAddress.Address, TileX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTilePolygon_TileY_Offset), 0, GetTilePolygon_TileY_PropertyAddress.Address, TileY);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTilePolygon_LayerIndex_Offset), 0, GetTilePolygon_LayerIndex_PropertyAddress.Address, LayerIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetTilePolygon_bWorldSpace_Offset), 0, GetTilePolygon_bWorldSpace_PropertyAddress.Address, bWorldSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTilePolygon_FunctionAddress, intPtr, GetTilePolygon_ParamsSize);
		Points = new TArrayCopyMarshaler<FVector>(1, GetTilePolygon_Points_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GetTilePolygon_Points_Offset));
		NativeReflection.DestroyValue_InContainer(GetTilePolygon_Points_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Paper2D.PaperTileMapComponent:GetTileMapColor")]
	public unsafe FLinearColor GetTileMapColor()
	{
		CheckDestroyed();
		if (!GetTileMapColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperTileMapComponent:GetTileMapColor");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTileMapColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTileMapColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTileMapColor_FunctionAddress, intPtr, GetTileMapColor_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetTileMapColor_ReturnValue_Offset), 0, GetTileMapColor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Paper2D.PaperTileMapComponent:GetTileCornerPosition")]
	public unsafe FVector GetTileCornerPosition(int TileX, int TileY, int LayerIndex = 0, bool bWorldSpace = false)
	{
		CheckDestroyed();
		if (!GetTileCornerPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperTileMapComponent:GetTileCornerPosition");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTileCornerPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTileCornerPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTileCornerPosition_TileX_Offset), 0, GetTileCornerPosition_TileX_PropertyAddress.Address, TileX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTileCornerPosition_TileY_Offset), 0, GetTileCornerPosition_TileY_PropertyAddress.Address, TileY);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTileCornerPosition_LayerIndex_Offset), 0, GetTileCornerPosition_LayerIndex_PropertyAddress.Address, LayerIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetTileCornerPosition_bWorldSpace_Offset), 0, GetTileCornerPosition_bWorldSpace_PropertyAddress.Address, bWorldSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTileCornerPosition_FunctionAddress, intPtr, GetTileCornerPosition_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetTileCornerPosition_ReturnValue_Offset), 0, GetTileCornerPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Paper2D.PaperTileMapComponent:GetTileCenterPosition")]
	public unsafe FVector GetTileCenterPosition(int TileX, int TileY, int LayerIndex = 0, bool bWorldSpace = false)
	{
		CheckDestroyed();
		if (!GetTileCenterPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperTileMapComponent:GetTileCenterPosition");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTileCenterPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTileCenterPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTileCenterPosition_TileX_Offset), 0, GetTileCenterPosition_TileX_PropertyAddress.Address, TileX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTileCenterPosition_TileY_Offset), 0, GetTileCenterPosition_TileY_PropertyAddress.Address, TileY);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTileCenterPosition_LayerIndex_Offset), 0, GetTileCenterPosition_LayerIndex_PropertyAddress.Address, LayerIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetTileCenterPosition_bWorldSpace_Offset), 0, GetTileCenterPosition_bWorldSpace_PropertyAddress.Address, bWorldSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTileCenterPosition_FunctionAddress, intPtr, GetTileCenterPosition_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetTileCenterPosition_ReturnValue_Offset), 0, GetTileCenterPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Paper2D.PaperTileMapComponent:GetTile")]
	public unsafe FPaperTileInfo GetTile(int X, int Y, int Layer)
	{
		CheckDestroyed();
		if (!GetTile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperTileMapComponent:GetTile");
			return default(FPaperTileInfo);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTile_X_Offset), 0, GetTile_X_PropertyAddress.Address, X);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTile_Y_Offset), 0, GetTile_Y_PropertyAddress.Address, Y);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTile_Layer_Offset), 0, GetTile_Layer_PropertyAddress.Address, Layer);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTile_FunctionAddress, intPtr, GetTile_ParamsSize);
		return FPaperTileInfo.FromNative(IntPtr.Add(intPtr, GetTile_ReturnValue_Offset), 0, GetTile_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Paper2D.PaperTileMapComponent:GetMapSize")]
	public unsafe void GetMapSize(out int MapWidth, out int MapHeight, out int NumLayers)
	{
		CheckDestroyed();
		if (!GetMapSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperTileMapComponent:GetMapSize");
			MapWidth = 0;
			MapHeight = 0;
			NumLayers = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMapSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMapSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMapSize_FunctionAddress, intPtr, GetMapSize_ParamsSize);
		MapWidth = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetMapSize_MapWidth_Offset), 0, GetMapSize_MapWidth_PropertyAddress.Address);
		MapHeight = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetMapSize_MapHeight_Offset), 0, GetMapSize_MapHeight_PropertyAddress.Address);
		NumLayers = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetMapSize_NumLayers_Offset), 0, GetMapSize_NumLayers_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Paper2D.PaperTileMapComponent:GetLayerColor")]
	public unsafe FLinearColor GetLayerColor(int Layer = 0)
	{
		CheckDestroyed();
		if (!GetLayerColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperTileMapComponent:GetLayerColor");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLayerColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLayerColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetLayerColor_Layer_Offset), 0, GetLayerColor_Layer_PropertyAddress.Address, Layer);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLayerColor_FunctionAddress, intPtr, GetLayerColor_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetLayerColor_ReturnValue_Offset), 0, GetLayerColor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Paper2D.PaperTileMapComponent:CreateNewTileMap")]
	public unsafe void CreateNewTileMap(int MapWidth = 4, int MapHeight = 4, int TileWidth = 32, int TileHeight = 32, float PixelsPerUnrealUnit = 1f, bool bCreateLayer = true)
	{
		CheckDestroyed();
		if (!CreateNewTileMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperTileMapComponent:CreateNewTileMap");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateNewTileMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateNewTileMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateNewTileMap_MapWidth_Offset), 0, CreateNewTileMap_MapWidth_PropertyAddress.Address, MapWidth);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateNewTileMap_MapHeight_Offset), 0, CreateNewTileMap_MapHeight_PropertyAddress.Address, MapHeight);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateNewTileMap_TileWidth_Offset), 0, CreateNewTileMap_TileWidth_PropertyAddress.Address, TileWidth);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateNewTileMap_TileHeight_Offset), 0, CreateNewTileMap_TileHeight_PropertyAddress.Address, TileHeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CreateNewTileMap_PixelsPerUnrealUnit_Offset), 0, CreateNewTileMap_PixelsPerUnrealUnit_PropertyAddress.Address, PixelsPerUnrealUnit);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateNewTileMap_bCreateLayer_Offset), 0, CreateNewTileMap_bCreateLayer_PropertyAddress.Address, bCreateLayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateNewTileMap_FunctionAddress, intPtr, CreateNewTileMap_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Paper2D.PaperTileMapComponent:AddNewLayer")]
	public unsafe UPaperTileLayer AddNewLayer()
	{
		CheckDestroyed();
		if (!AddNewLayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperTileMapComponent:AddNewLayer");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddNewLayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddNewLayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddNewLayer_FunctionAddress, intPtr, AddNewLayer_ParamsSize);
		return UObjectMarshaler<UPaperTileLayer>.FromNative(IntPtr.Add(intPtr, AddNewLayer_ReturnValue_Offset), 0, AddNewLayer_ReturnValue_PropertyAddress.Address);
	}

	static UPaperTileMapComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPaperTileMapComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPaperTileMapComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Paper2D.PaperTileMapComponent");
		TileMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TileMap");
		TileMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TileMap", Classes.FObjectProperty);
		SetTileMapColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTileMapColor");
		SetTileMapColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTileMapColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTileMapColor_NewColor_PropertyAddress, SetTileMapColor_FunctionAddress, "NewColor");
		SetTileMapColor_NewColor_Offset = NativeReflectionCached.GetPropertyOffset(SetTileMapColor_FunctionAddress, "NewColor");
		SetTileMapColor_NewColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTileMapColor_FunctionAddress, "NewColor", Classes.FStructProperty);
		SetTileMapColor_IsValid = SetTileMapColor_FunctionAddress != IntPtr.Zero && SetTileMapColor_NewColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperTileMapComponent:SetTileMapColor", SetTileMapColor_IsValid);
		SetTileMap_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTileMap");
		SetTileMap_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTileMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTileMap_NewTileMap_PropertyAddress, SetTileMap_FunctionAddress, "NewTileMap");
		SetTileMap_NewTileMap_Offset = NativeReflectionCached.GetPropertyOffset(SetTileMap_FunctionAddress, "NewTileMap");
		SetTileMap_NewTileMap_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTileMap_FunctionAddress, "NewTileMap", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTileMap_ReturnValue_PropertyAddress, SetTileMap_FunctionAddress, "ReturnValue");
		SetTileMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetTileMap_FunctionAddress, "ReturnValue");
		SetTileMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTileMap_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetTileMap_IsValid = SetTileMap_FunctionAddress != IntPtr.Zero && SetTileMap_NewTileMap_IsValid && SetTileMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperTileMapComponent:SetTileMap", SetTileMap_IsValid);
		SetTile_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTile");
		SetTile_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTile_X_PropertyAddress, SetTile_FunctionAddress, "X");
		SetTile_X_Offset = NativeReflectionCached.GetPropertyOffset(SetTile_FunctionAddress, "X");
		SetTile_X_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTile_FunctionAddress, "X", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTile_Y_PropertyAddress, SetTile_FunctionAddress, "Y");
		SetTile_Y_Offset = NativeReflectionCached.GetPropertyOffset(SetTile_FunctionAddress, "Y");
		SetTile_Y_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTile_FunctionAddress, "Y", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTile_Layer_PropertyAddress, SetTile_FunctionAddress, "Layer");
		SetTile_Layer_Offset = NativeReflectionCached.GetPropertyOffset(SetTile_FunctionAddress, "Layer");
		SetTile_Layer_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTile_FunctionAddress, "Layer", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTile_NewValue_PropertyAddress, SetTile_FunctionAddress, "NewValue");
		SetTile_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetTile_FunctionAddress, "NewValue");
		SetTile_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTile_FunctionAddress, "NewValue", Classes.FStructProperty);
		SetTile_IsValid = SetTile_FunctionAddress != IntPtr.Zero && SetTile_X_IsValid && SetTile_Y_IsValid && SetTile_Layer_IsValid && SetTile_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperTileMapComponent:SetTile", SetTile_IsValid);
		SetLayerColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLayerColor");
		SetLayerColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLayerColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLayerColor_NewColor_PropertyAddress, SetLayerColor_FunctionAddress, "NewColor");
		SetLayerColor_NewColor_Offset = NativeReflectionCached.GetPropertyOffset(SetLayerColor_FunctionAddress, "NewColor");
		SetLayerColor_NewColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLayerColor_FunctionAddress, "NewColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLayerColor_Layer_PropertyAddress, SetLayerColor_FunctionAddress, "Layer");
		SetLayerColor_Layer_Offset = NativeReflectionCached.GetPropertyOffset(SetLayerColor_FunctionAddress, "Layer");
		SetLayerColor_Layer_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLayerColor_FunctionAddress, "Layer", Classes.FIntProperty);
		SetLayerColor_IsValid = SetLayerColor_FunctionAddress != IntPtr.Zero && SetLayerColor_NewColor_IsValid && SetLayerColor_Layer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperTileMapComponent:SetLayerColor", SetLayerColor_IsValid);
		SetLayerCollision_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLayerCollision");
		SetLayerCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLayerCollision_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLayerCollision_Layer_PropertyAddress, SetLayerCollision_FunctionAddress, "Layer");
		SetLayerCollision_Layer_Offset = NativeReflectionCached.GetPropertyOffset(SetLayerCollision_FunctionAddress, "Layer");
		SetLayerCollision_Layer_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLayerCollision_FunctionAddress, "Layer", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLayerCollision_bHasCollision_PropertyAddress, SetLayerCollision_FunctionAddress, "bHasCollision");
		SetLayerCollision_bHasCollision_Offset = NativeReflectionCached.GetPropertyOffset(SetLayerCollision_FunctionAddress, "bHasCollision");
		SetLayerCollision_bHasCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLayerCollision_FunctionAddress, "bHasCollision", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLayerCollision_bOverrideThickness_PropertyAddress, SetLayerCollision_FunctionAddress, "bOverrideThickness");
		SetLayerCollision_bOverrideThickness_Offset = NativeReflectionCached.GetPropertyOffset(SetLayerCollision_FunctionAddress, "bOverrideThickness");
		SetLayerCollision_bOverrideThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLayerCollision_FunctionAddress, "bOverrideThickness", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLayerCollision_CustomThickness_PropertyAddress, SetLayerCollision_FunctionAddress, "CustomThickness");
		SetLayerCollision_CustomThickness_Offset = NativeReflectionCached.GetPropertyOffset(SetLayerCollision_FunctionAddress, "CustomThickness");
		SetLayerCollision_CustomThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLayerCollision_FunctionAddress, "CustomThickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLayerCollision_bOverrideOffset_PropertyAddress, SetLayerCollision_FunctionAddress, "bOverrideOffset");
		SetLayerCollision_bOverrideOffset_Offset = NativeReflectionCached.GetPropertyOffset(SetLayerCollision_FunctionAddress, "bOverrideOffset");
		SetLayerCollision_bOverrideOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLayerCollision_FunctionAddress, "bOverrideOffset", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLayerCollision_CustomOffset_PropertyAddress, SetLayerCollision_FunctionAddress, "CustomOffset");
		SetLayerCollision_CustomOffset_Offset = NativeReflectionCached.GetPropertyOffset(SetLayerCollision_FunctionAddress, "CustomOffset");
		SetLayerCollision_CustomOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLayerCollision_FunctionAddress, "CustomOffset", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLayerCollision_bRebuildCollision_PropertyAddress, SetLayerCollision_FunctionAddress, "bRebuildCollision");
		SetLayerCollision_bRebuildCollision_Offset = NativeReflectionCached.GetPropertyOffset(SetLayerCollision_FunctionAddress, "bRebuildCollision");
		SetLayerCollision_bRebuildCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLayerCollision_FunctionAddress, "bRebuildCollision", Classes.FBoolProperty);
		SetLayerCollision_IsValid = SetLayerCollision_FunctionAddress != IntPtr.Zero && SetLayerCollision_Layer_IsValid && SetLayerCollision_bHasCollision_IsValid && SetLayerCollision_bOverrideThickness_IsValid && SetLayerCollision_CustomThickness_IsValid && SetLayerCollision_bOverrideOffset_IsValid && SetLayerCollision_CustomOffset_IsValid && SetLayerCollision_bRebuildCollision_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperTileMapComponent:SetLayerCollision", SetLayerCollision_IsValid);
		SetDefaultCollisionThickness_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDefaultCollisionThickness");
		SetDefaultCollisionThickness_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDefaultCollisionThickness_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultCollisionThickness_Thickness_PropertyAddress, SetDefaultCollisionThickness_FunctionAddress, "Thickness");
		SetDefaultCollisionThickness_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultCollisionThickness_FunctionAddress, "Thickness");
		SetDefaultCollisionThickness_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultCollisionThickness_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultCollisionThickness_bRebuildCollision_PropertyAddress, SetDefaultCollisionThickness_FunctionAddress, "bRebuildCollision");
		SetDefaultCollisionThickness_bRebuildCollision_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultCollisionThickness_FunctionAddress, "bRebuildCollision");
		SetDefaultCollisionThickness_bRebuildCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultCollisionThickness_FunctionAddress, "bRebuildCollision", Classes.FBoolProperty);
		SetDefaultCollisionThickness_IsValid = SetDefaultCollisionThickness_FunctionAddress != IntPtr.Zero && SetDefaultCollisionThickness_Thickness_IsValid && SetDefaultCollisionThickness_bRebuildCollision_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperTileMapComponent:SetDefaultCollisionThickness", SetDefaultCollisionThickness_IsValid);
		ResizeMap_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResizeMap");
		ResizeMap_ParamsSize = NativeReflection.GetFunctionParamsSize(ResizeMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResizeMap_NewWidthInTiles_PropertyAddress, ResizeMap_FunctionAddress, "NewWidthInTiles");
		ResizeMap_NewWidthInTiles_Offset = NativeReflectionCached.GetPropertyOffset(ResizeMap_FunctionAddress, "NewWidthInTiles");
		ResizeMap_NewWidthInTiles_IsValid = NativeReflectionCached.ValidatePropertyClass(ResizeMap_FunctionAddress, "NewWidthInTiles", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ResizeMap_NewHeightInTiles_PropertyAddress, ResizeMap_FunctionAddress, "NewHeightInTiles");
		ResizeMap_NewHeightInTiles_Offset = NativeReflectionCached.GetPropertyOffset(ResizeMap_FunctionAddress, "NewHeightInTiles");
		ResizeMap_NewHeightInTiles_IsValid = NativeReflectionCached.ValidatePropertyClass(ResizeMap_FunctionAddress, "NewHeightInTiles", Classes.FIntProperty);
		ResizeMap_IsValid = ResizeMap_FunctionAddress != IntPtr.Zero && ResizeMap_NewWidthInTiles_IsValid && ResizeMap_NewHeightInTiles_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperTileMapComponent:ResizeMap", ResizeMap_IsValid);
		RebuildCollision_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RebuildCollision");
		RebuildCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(RebuildCollision_FunctionAddress);
		RebuildCollision_IsValid = RebuildCollision_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperTileMapComponent:RebuildCollision", RebuildCollision_IsValid);
		OwnsTileMap_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OwnsTileMap");
		OwnsTileMap_ParamsSize = NativeReflection.GetFunctionParamsSize(OwnsTileMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OwnsTileMap_ReturnValue_PropertyAddress, OwnsTileMap_FunctionAddress, "ReturnValue");
		OwnsTileMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OwnsTileMap_FunctionAddress, "ReturnValue");
		OwnsTileMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OwnsTileMap_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OwnsTileMap_IsValid = OwnsTileMap_FunctionAddress != IntPtr.Zero && OwnsTileMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperTileMapComponent:OwnsTileMap", OwnsTileMap_IsValid);
		MakeTileMapEditable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MakeTileMapEditable");
		MakeTileMapEditable_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeTileMapEditable_FunctionAddress);
		MakeTileMapEditable_IsValid = MakeTileMapEditable_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperTileMapComponent:MakeTileMapEditable", MakeTileMapEditable_IsValid);
		GetTilePolygon_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTilePolygon");
		GetTilePolygon_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTilePolygon_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTilePolygon_TileX_PropertyAddress, GetTilePolygon_FunctionAddress, "TileX");
		GetTilePolygon_TileX_Offset = NativeReflectionCached.GetPropertyOffset(GetTilePolygon_FunctionAddress, "TileX");
		GetTilePolygon_TileX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTilePolygon_FunctionAddress, "TileX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTilePolygon_TileY_PropertyAddress, GetTilePolygon_FunctionAddress, "TileY");
		GetTilePolygon_TileY_Offset = NativeReflectionCached.GetPropertyOffset(GetTilePolygon_FunctionAddress, "TileY");
		GetTilePolygon_TileY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTilePolygon_FunctionAddress, "TileY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTilePolygon_Points_PropertyAddress, GetTilePolygon_FunctionAddress, "Points");
		GetTilePolygon_Points_Offset = NativeReflectionCached.GetPropertyOffset(GetTilePolygon_FunctionAddress, "Points");
		GetTilePolygon_Points_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTilePolygon_FunctionAddress, "Points", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTilePolygon_LayerIndex_PropertyAddress, GetTilePolygon_FunctionAddress, "LayerIndex");
		GetTilePolygon_LayerIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetTilePolygon_FunctionAddress, "LayerIndex");
		GetTilePolygon_LayerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTilePolygon_FunctionAddress, "LayerIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTilePolygon_bWorldSpace_PropertyAddress, GetTilePolygon_FunctionAddress, "bWorldSpace");
		GetTilePolygon_bWorldSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetTilePolygon_FunctionAddress, "bWorldSpace");
		GetTilePolygon_bWorldSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTilePolygon_FunctionAddress, "bWorldSpace", Classes.FBoolProperty);
		GetTilePolygon_IsValid = GetTilePolygon_FunctionAddress != IntPtr.Zero && GetTilePolygon_TileX_IsValid && GetTilePolygon_TileY_IsValid && GetTilePolygon_Points_IsValid && GetTilePolygon_LayerIndex_IsValid && GetTilePolygon_bWorldSpace_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperTileMapComponent:GetTilePolygon", GetTilePolygon_IsValid);
		GetTileMapColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTileMapColor");
		GetTileMapColor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTileMapColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTileMapColor_ReturnValue_PropertyAddress, GetTileMapColor_FunctionAddress, "ReturnValue");
		GetTileMapColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTileMapColor_FunctionAddress, "ReturnValue");
		GetTileMapColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTileMapColor_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTileMapColor_IsValid = GetTileMapColor_FunctionAddress != IntPtr.Zero && GetTileMapColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperTileMapComponent:GetTileMapColor", GetTileMapColor_IsValid);
		GetTileCornerPosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTileCornerPosition");
		GetTileCornerPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTileCornerPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTileCornerPosition_TileX_PropertyAddress, GetTileCornerPosition_FunctionAddress, "TileX");
		GetTileCornerPosition_TileX_Offset = NativeReflectionCached.GetPropertyOffset(GetTileCornerPosition_FunctionAddress, "TileX");
		GetTileCornerPosition_TileX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTileCornerPosition_FunctionAddress, "TileX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTileCornerPosition_TileY_PropertyAddress, GetTileCornerPosition_FunctionAddress, "TileY");
		GetTileCornerPosition_TileY_Offset = NativeReflectionCached.GetPropertyOffset(GetTileCornerPosition_FunctionAddress, "TileY");
		GetTileCornerPosition_TileY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTileCornerPosition_FunctionAddress, "TileY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTileCornerPosition_LayerIndex_PropertyAddress, GetTileCornerPosition_FunctionAddress, "LayerIndex");
		GetTileCornerPosition_LayerIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetTileCornerPosition_FunctionAddress, "LayerIndex");
		GetTileCornerPosition_LayerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTileCornerPosition_FunctionAddress, "LayerIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTileCornerPosition_bWorldSpace_PropertyAddress, GetTileCornerPosition_FunctionAddress, "bWorldSpace");
		GetTileCornerPosition_bWorldSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetTileCornerPosition_FunctionAddress, "bWorldSpace");
		GetTileCornerPosition_bWorldSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTileCornerPosition_FunctionAddress, "bWorldSpace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTileCornerPosition_ReturnValue_PropertyAddress, GetTileCornerPosition_FunctionAddress, "ReturnValue");
		GetTileCornerPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTileCornerPosition_FunctionAddress, "ReturnValue");
		GetTileCornerPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTileCornerPosition_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTileCornerPosition_IsValid = GetTileCornerPosition_FunctionAddress != IntPtr.Zero && GetTileCornerPosition_TileX_IsValid && GetTileCornerPosition_TileY_IsValid && GetTileCornerPosition_LayerIndex_IsValid && GetTileCornerPosition_bWorldSpace_IsValid && GetTileCornerPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperTileMapComponent:GetTileCornerPosition", GetTileCornerPosition_IsValid);
		GetTileCenterPosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTileCenterPosition");
		GetTileCenterPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTileCenterPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTileCenterPosition_TileX_PropertyAddress, GetTileCenterPosition_FunctionAddress, "TileX");
		GetTileCenterPosition_TileX_Offset = NativeReflectionCached.GetPropertyOffset(GetTileCenterPosition_FunctionAddress, "TileX");
		GetTileCenterPosition_TileX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTileCenterPosition_FunctionAddress, "TileX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTileCenterPosition_TileY_PropertyAddress, GetTileCenterPosition_FunctionAddress, "TileY");
		GetTileCenterPosition_TileY_Offset = NativeReflectionCached.GetPropertyOffset(GetTileCenterPosition_FunctionAddress, "TileY");
		GetTileCenterPosition_TileY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTileCenterPosition_FunctionAddress, "TileY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTileCenterPosition_LayerIndex_PropertyAddress, GetTileCenterPosition_FunctionAddress, "LayerIndex");
		GetTileCenterPosition_LayerIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetTileCenterPosition_FunctionAddress, "LayerIndex");
		GetTileCenterPosition_LayerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTileCenterPosition_FunctionAddress, "LayerIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTileCenterPosition_bWorldSpace_PropertyAddress, GetTileCenterPosition_FunctionAddress, "bWorldSpace");
		GetTileCenterPosition_bWorldSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetTileCenterPosition_FunctionAddress, "bWorldSpace");
		GetTileCenterPosition_bWorldSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTileCenterPosition_FunctionAddress, "bWorldSpace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTileCenterPosition_ReturnValue_PropertyAddress, GetTileCenterPosition_FunctionAddress, "ReturnValue");
		GetTileCenterPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTileCenterPosition_FunctionAddress, "ReturnValue");
		GetTileCenterPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTileCenterPosition_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTileCenterPosition_IsValid = GetTileCenterPosition_FunctionAddress != IntPtr.Zero && GetTileCenterPosition_TileX_IsValid && GetTileCenterPosition_TileY_IsValid && GetTileCenterPosition_LayerIndex_IsValid && GetTileCenterPosition_bWorldSpace_IsValid && GetTileCenterPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperTileMapComponent:GetTileCenterPosition", GetTileCenterPosition_IsValid);
		GetTile_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTile");
		GetTile_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTile_X_PropertyAddress, GetTile_FunctionAddress, "X");
		GetTile_X_Offset = NativeReflectionCached.GetPropertyOffset(GetTile_FunctionAddress, "X");
		GetTile_X_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTile_FunctionAddress, "X", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTile_Y_PropertyAddress, GetTile_FunctionAddress, "Y");
		GetTile_Y_Offset = NativeReflectionCached.GetPropertyOffset(GetTile_FunctionAddress, "Y");
		GetTile_Y_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTile_FunctionAddress, "Y", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTile_Layer_PropertyAddress, GetTile_FunctionAddress, "Layer");
		GetTile_Layer_Offset = NativeReflectionCached.GetPropertyOffset(GetTile_FunctionAddress, "Layer");
		GetTile_Layer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTile_FunctionAddress, "Layer", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTile_ReturnValue_PropertyAddress, GetTile_FunctionAddress, "ReturnValue");
		GetTile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTile_FunctionAddress, "ReturnValue");
		GetTile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTile_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTile_IsValid = GetTile_FunctionAddress != IntPtr.Zero && GetTile_X_IsValid && GetTile_Y_IsValid && GetTile_Layer_IsValid && GetTile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperTileMapComponent:GetTile", GetTile_IsValid);
		GetMapSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMapSize");
		GetMapSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMapSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMapSize_MapWidth_PropertyAddress, GetMapSize_FunctionAddress, "MapWidth");
		GetMapSize_MapWidth_Offset = NativeReflectionCached.GetPropertyOffset(GetMapSize_FunctionAddress, "MapWidth");
		GetMapSize_MapWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMapSize_FunctionAddress, "MapWidth", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMapSize_MapHeight_PropertyAddress, GetMapSize_FunctionAddress, "MapHeight");
		GetMapSize_MapHeight_Offset = NativeReflectionCached.GetPropertyOffset(GetMapSize_FunctionAddress, "MapHeight");
		GetMapSize_MapHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMapSize_FunctionAddress, "MapHeight", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMapSize_NumLayers_PropertyAddress, GetMapSize_FunctionAddress, "NumLayers");
		GetMapSize_NumLayers_Offset = NativeReflectionCached.GetPropertyOffset(GetMapSize_FunctionAddress, "NumLayers");
		GetMapSize_NumLayers_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMapSize_FunctionAddress, "NumLayers", Classes.FIntProperty);
		GetMapSize_IsValid = GetMapSize_FunctionAddress != IntPtr.Zero && GetMapSize_MapWidth_IsValid && GetMapSize_MapHeight_IsValid && GetMapSize_NumLayers_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperTileMapComponent:GetMapSize", GetMapSize_IsValid);
		GetLayerColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLayerColor");
		GetLayerColor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLayerColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLayerColor_Layer_PropertyAddress, GetLayerColor_FunctionAddress, "Layer");
		GetLayerColor_Layer_Offset = NativeReflectionCached.GetPropertyOffset(GetLayerColor_FunctionAddress, "Layer");
		GetLayerColor_Layer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLayerColor_FunctionAddress, "Layer", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLayerColor_ReturnValue_PropertyAddress, GetLayerColor_FunctionAddress, "ReturnValue");
		GetLayerColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLayerColor_FunctionAddress, "ReturnValue");
		GetLayerColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLayerColor_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLayerColor_IsValid = GetLayerColor_FunctionAddress != IntPtr.Zero && GetLayerColor_Layer_IsValid && GetLayerColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperTileMapComponent:GetLayerColor", GetLayerColor_IsValid);
		CreateNewTileMap_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CreateNewTileMap");
		CreateNewTileMap_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateNewTileMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateNewTileMap_MapWidth_PropertyAddress, CreateNewTileMap_FunctionAddress, "MapWidth");
		CreateNewTileMap_MapWidth_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewTileMap_FunctionAddress, "MapWidth");
		CreateNewTileMap_MapWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewTileMap_FunctionAddress, "MapWidth", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewTileMap_MapHeight_PropertyAddress, CreateNewTileMap_FunctionAddress, "MapHeight");
		CreateNewTileMap_MapHeight_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewTileMap_FunctionAddress, "MapHeight");
		CreateNewTileMap_MapHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewTileMap_FunctionAddress, "MapHeight", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewTileMap_TileWidth_PropertyAddress, CreateNewTileMap_FunctionAddress, "TileWidth");
		CreateNewTileMap_TileWidth_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewTileMap_FunctionAddress, "TileWidth");
		CreateNewTileMap_TileWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewTileMap_FunctionAddress, "TileWidth", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewTileMap_TileHeight_PropertyAddress, CreateNewTileMap_FunctionAddress, "TileHeight");
		CreateNewTileMap_TileHeight_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewTileMap_FunctionAddress, "TileHeight");
		CreateNewTileMap_TileHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewTileMap_FunctionAddress, "TileHeight", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewTileMap_PixelsPerUnrealUnit_PropertyAddress, CreateNewTileMap_FunctionAddress, "PixelsPerUnrealUnit");
		CreateNewTileMap_PixelsPerUnrealUnit_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewTileMap_FunctionAddress, "PixelsPerUnrealUnit");
		CreateNewTileMap_PixelsPerUnrealUnit_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewTileMap_FunctionAddress, "PixelsPerUnrealUnit", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewTileMap_bCreateLayer_PropertyAddress, CreateNewTileMap_FunctionAddress, "bCreateLayer");
		CreateNewTileMap_bCreateLayer_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewTileMap_FunctionAddress, "bCreateLayer");
		CreateNewTileMap_bCreateLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewTileMap_FunctionAddress, "bCreateLayer", Classes.FBoolProperty);
		CreateNewTileMap_IsValid = CreateNewTileMap_FunctionAddress != IntPtr.Zero && CreateNewTileMap_MapWidth_IsValid && CreateNewTileMap_MapHeight_IsValid && CreateNewTileMap_TileWidth_IsValid && CreateNewTileMap_TileHeight_IsValid && CreateNewTileMap_PixelsPerUnrealUnit_IsValid && CreateNewTileMap_bCreateLayer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperTileMapComponent:CreateNewTileMap", CreateNewTileMap_IsValid);
		AddNewLayer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddNewLayer");
		AddNewLayer_ParamsSize = NativeReflection.GetFunctionParamsSize(AddNewLayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddNewLayer_ReturnValue_PropertyAddress, AddNewLayer_FunctionAddress, "ReturnValue");
		AddNewLayer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddNewLayer_FunctionAddress, "ReturnValue");
		AddNewLayer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNewLayer_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddNewLayer_IsValid = AddNewLayer_FunctionAddress != IntPtr.Zero && AddNewLayer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperTileMapComponent:AddNewLayer", AddNewLayer_IsValid);
	}
}
