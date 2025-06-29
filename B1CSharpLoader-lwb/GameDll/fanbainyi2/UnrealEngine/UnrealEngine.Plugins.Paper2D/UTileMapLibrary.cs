using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/Paper2D.TileMapBlueprintLibrary", "Paper2D", UnrealModuleType.EnginePlugin)]
public class UTileMapLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool MakeTile_IsValid;

	private static IntPtr MakeTile_FunctionAddress;

	private static int MakeTile_ParamsSize;

	private static bool MakeTile_TileIndex_IsValid;

	private static FFieldAddress MakeTile_TileIndex_PropertyAddress;

	private static int MakeTile_TileIndex_Offset;

	private static bool MakeTile_TileSet_IsValid;

	private static FFieldAddress MakeTile_TileSet_PropertyAddress;

	private static int MakeTile_TileSet_Offset;

	private static bool MakeTile_bFlipH_IsValid;

	private static FFieldAddress MakeTile_bFlipH_PropertyAddress;

	private static int MakeTile_bFlipH_Offset;

	private static bool MakeTile_bFlipV_IsValid;

	private static FFieldAddress MakeTile_bFlipV_PropertyAddress;

	private static int MakeTile_bFlipV_Offset;

	private static bool MakeTile_bFlipD_IsValid;

	private static FFieldAddress MakeTile_bFlipD_PropertyAddress;

	private static int MakeTile_bFlipD_Offset;

	private static bool MakeTile_ReturnValue_IsValid;

	private static FFieldAddress MakeTile_ReturnValue_PropertyAddress;

	private static int MakeTile_ReturnValue_Offset;

	private static bool GetTileUserData_IsValid;

	private static IntPtr GetTileUserData_FunctionAddress;

	private static int GetTileUserData_ParamsSize;

	private static bool GetTileUserData_Tile_IsValid;

	private static FFieldAddress GetTileUserData_Tile_PropertyAddress;

	private static int GetTileUserData_Tile_Offset;

	private static bool GetTileUserData_ReturnValue_IsValid;

	private static FFieldAddress GetTileUserData_ReturnValue_PropertyAddress;

	private static int GetTileUserData_ReturnValue_Offset;

	private static bool GetTileTransform_IsValid;

	private static IntPtr GetTileTransform_FunctionAddress;

	private static int GetTileTransform_ParamsSize;

	private static bool GetTileTransform_Tile_IsValid;

	private static FFieldAddress GetTileTransform_Tile_PropertyAddress;

	private static int GetTileTransform_Tile_Offset;

	private static bool GetTileTransform_ReturnValue_IsValid;

	private static FFieldAddress GetTileTransform_ReturnValue_PropertyAddress;

	private static int GetTileTransform_ReturnValue_Offset;

	private static bool BreakTile_IsValid;

	private static IntPtr BreakTile_FunctionAddress;

	private static int BreakTile_ParamsSize;

	private static bool BreakTile_Tile_IsValid;

	private static FFieldAddress BreakTile_Tile_PropertyAddress;

	private static int BreakTile_Tile_Offset;

	private static bool BreakTile_TileIndex_IsValid;

	private static FFieldAddress BreakTile_TileIndex_PropertyAddress;

	private static int BreakTile_TileIndex_Offset;

	private static bool BreakTile_TileSet_IsValid;

	private static FFieldAddress BreakTile_TileSet_PropertyAddress;

	private static int BreakTile_TileSet_Offset;

	private static bool BreakTile_bFlipH_IsValid;

	private static FFieldAddress BreakTile_bFlipH_PropertyAddress;

	private static int BreakTile_bFlipH_Offset;

	private static bool BreakTile_bFlipV_IsValid;

	private static FFieldAddress BreakTile_bFlipV_PropertyAddress;

	private static int BreakTile_bFlipV_Offset;

	private static bool BreakTile_bFlipD_IsValid;

	private static FFieldAddress BreakTile_bFlipD_PropertyAddress;

	private static int BreakTile_bFlipD_Offset;

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Paper2D.TileMapBlueprintLibrary:MakeTile")]
	public unsafe static FPaperTileInfo MakeTile(int TileIndex, UPaperTileSet TileSet, bool bFlipH, bool bFlipV, bool bFlipD)
	{
		if (!MakeTile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.TileMapBlueprintLibrary:MakeTile");
			return default(FPaperTileInfo);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeTile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeTile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakeTile_TileIndex_Offset), 0, MakeTile_TileIndex_PropertyAddress.Address, TileIndex);
		UObjectMarshaler<UPaperTileSet>.ToNative(IntPtr.Add(intPtr, MakeTile_TileSet_Offset), 0, MakeTile_TileSet_PropertyAddress.Address, TileSet);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MakeTile_bFlipH_Offset), 0, MakeTile_bFlipH_PropertyAddress.Address, bFlipH);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MakeTile_bFlipV_Offset), 0, MakeTile_bFlipV_PropertyAddress.Address, bFlipV);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MakeTile_bFlipD_Offset), 0, MakeTile_bFlipD_PropertyAddress.Address, bFlipD);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeTile_FunctionAddress, intPtr, MakeTile_ParamsSize);
		return FPaperTileInfo.FromNative(IntPtr.Add(intPtr, MakeTile_ReturnValue_Offset), 0, MakeTile_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Paper2D.TileMapBlueprintLibrary:GetTileUserData")]
	public unsafe static FName GetTileUserData(FPaperTileInfo Tile)
	{
		if (!GetTileUserData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.TileMapBlueprintLibrary:GetTileUserData");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTileUserData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTileUserData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTileUserData_Tile_PropertyAddress.Address, intPtr);
		FPaperTileInfo.ToNative(IntPtr.Add(intPtr, GetTileUserData_Tile_Offset), 0, GetTileUserData_Tile_PropertyAddress.Address, Tile);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTileUserData_FunctionAddress, intPtr, GetTileUserData_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetTileUserData_ReturnValue_Offset), 0, GetTileUserData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/Paper2D.TileMapBlueprintLibrary:GetTileTransform")]
	public unsafe static FTransform GetTileTransform(FPaperTileInfo Tile)
	{
		if (!GetTileTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.TileMapBlueprintLibrary:GetTileTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTileTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTileTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTileTransform_Tile_PropertyAddress.Address, intPtr);
		FPaperTileInfo.ToNative(IntPtr.Add(intPtr, GetTileTransform_Tile_Offset), 0, GetTileTransform_Tile_PropertyAddress.Address, Tile);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTileTransform_FunctionAddress, intPtr, GetTileTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetTileTransform_ReturnValue_Offset), 0, GetTileTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Paper2D.TileMapBlueprintLibrary:BreakTile")]
	public unsafe static void BreakTile(FPaperTileInfo Tile, out int TileIndex, out UPaperTileSet TileSet, out bool bFlipH, out bool bFlipV, out bool bFlipD)
	{
		if (!BreakTile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.TileMapBlueprintLibrary:BreakTile");
			TileIndex = 0;
			TileSet = null;
			bFlipH = false;
			bFlipV = false;
			bFlipD = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BreakTile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BreakTile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(BreakTile_Tile_PropertyAddress.Address, intPtr);
		FPaperTileInfo.ToNative(IntPtr.Add(intPtr, BreakTile_Tile_Offset), 0, BreakTile_Tile_PropertyAddress.Address, Tile);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BreakTile_FunctionAddress, intPtr, BreakTile_ParamsSize);
		TileIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BreakTile_TileIndex_Offset), 0, BreakTile_TileIndex_PropertyAddress.Address);
		TileSet = UObjectMarshaler<UPaperTileSet>.FromNative(IntPtr.Add(intPtr, BreakTile_TileSet_Offset), 0, BreakTile_TileSet_PropertyAddress.Address);
		bFlipH = BoolMarshaler.FromNative(IntPtr.Add(intPtr, BreakTile_bFlipH_Offset), 0, BreakTile_bFlipH_PropertyAddress.Address);
		bFlipV = BoolMarshaler.FromNative(IntPtr.Add(intPtr, BreakTile_bFlipV_Offset), 0, BreakTile_bFlipV_PropertyAddress.Address);
		bFlipD = BoolMarshaler.FromNative(IntPtr.Add(intPtr, BreakTile_bFlipD_Offset), 0, BreakTile_bFlipD_PropertyAddress.Address);
	}

	static UTileMapLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTileMapLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTileMapLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Paper2D.TileMapBlueprintLibrary");
		MakeTile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeTile");
		MakeTile_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeTile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeTile_TileIndex_PropertyAddress, MakeTile_FunctionAddress, "TileIndex");
		MakeTile_TileIndex_Offset = NativeReflectionCached.GetPropertyOffset(MakeTile_FunctionAddress, "TileIndex");
		MakeTile_TileIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeTile_FunctionAddress, "TileIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeTile_TileSet_PropertyAddress, MakeTile_FunctionAddress, "TileSet");
		MakeTile_TileSet_Offset = NativeReflectionCached.GetPropertyOffset(MakeTile_FunctionAddress, "TileSet");
		MakeTile_TileSet_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeTile_FunctionAddress, "TileSet", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeTile_bFlipH_PropertyAddress, MakeTile_FunctionAddress, "bFlipH");
		MakeTile_bFlipH_Offset = NativeReflectionCached.GetPropertyOffset(MakeTile_FunctionAddress, "bFlipH");
		MakeTile_bFlipH_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeTile_FunctionAddress, "bFlipH", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeTile_bFlipV_PropertyAddress, MakeTile_FunctionAddress, "bFlipV");
		MakeTile_bFlipV_Offset = NativeReflectionCached.GetPropertyOffset(MakeTile_FunctionAddress, "bFlipV");
		MakeTile_bFlipV_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeTile_FunctionAddress, "bFlipV", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeTile_bFlipD_PropertyAddress, MakeTile_FunctionAddress, "bFlipD");
		MakeTile_bFlipD_Offset = NativeReflectionCached.GetPropertyOffset(MakeTile_FunctionAddress, "bFlipD");
		MakeTile_bFlipD_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeTile_FunctionAddress, "bFlipD", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeTile_ReturnValue_PropertyAddress, MakeTile_FunctionAddress, "ReturnValue");
		MakeTile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeTile_FunctionAddress, "ReturnValue");
		MakeTile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeTile_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeTile_IsValid = MakeTile_FunctionAddress != IntPtr.Zero && MakeTile_TileIndex_IsValid && MakeTile_TileSet_IsValid && MakeTile_bFlipH_IsValid && MakeTile_bFlipV_IsValid && MakeTile_bFlipD_IsValid && MakeTile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.TileMapBlueprintLibrary:MakeTile", MakeTile_IsValid);
		GetTileUserData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTileUserData");
		GetTileUserData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTileUserData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTileUserData_Tile_PropertyAddress, GetTileUserData_FunctionAddress, "Tile");
		GetTileUserData_Tile_Offset = NativeReflectionCached.GetPropertyOffset(GetTileUserData_FunctionAddress, "Tile");
		GetTileUserData_Tile_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTileUserData_FunctionAddress, "Tile", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTileUserData_ReturnValue_PropertyAddress, GetTileUserData_FunctionAddress, "ReturnValue");
		GetTileUserData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTileUserData_FunctionAddress, "ReturnValue");
		GetTileUserData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTileUserData_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetTileUserData_IsValid = GetTileUserData_FunctionAddress != IntPtr.Zero && GetTileUserData_Tile_IsValid && GetTileUserData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.TileMapBlueprintLibrary:GetTileUserData", GetTileUserData_IsValid);
		GetTileTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTileTransform");
		GetTileTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTileTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTileTransform_Tile_PropertyAddress, GetTileTransform_FunctionAddress, "Tile");
		GetTileTransform_Tile_Offset = NativeReflectionCached.GetPropertyOffset(GetTileTransform_FunctionAddress, "Tile");
		GetTileTransform_Tile_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTileTransform_FunctionAddress, "Tile", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTileTransform_ReturnValue_PropertyAddress, GetTileTransform_FunctionAddress, "ReturnValue");
		GetTileTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTileTransform_FunctionAddress, "ReturnValue");
		GetTileTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTileTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTileTransform_IsValid = GetTileTransform_FunctionAddress != IntPtr.Zero && GetTileTransform_Tile_IsValid && GetTileTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.TileMapBlueprintLibrary:GetTileTransform", GetTileTransform_IsValid);
		BreakTile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BreakTile");
		BreakTile_ParamsSize = NativeReflection.GetFunctionParamsSize(BreakTile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BreakTile_Tile_PropertyAddress, BreakTile_FunctionAddress, "Tile");
		BreakTile_Tile_Offset = NativeReflectionCached.GetPropertyOffset(BreakTile_FunctionAddress, "Tile");
		BreakTile_Tile_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakTile_FunctionAddress, "Tile", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakTile_TileIndex_PropertyAddress, BreakTile_FunctionAddress, "TileIndex");
		BreakTile_TileIndex_Offset = NativeReflectionCached.GetPropertyOffset(BreakTile_FunctionAddress, "TileIndex");
		BreakTile_TileIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakTile_FunctionAddress, "TileIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakTile_TileSet_PropertyAddress, BreakTile_FunctionAddress, "TileSet");
		BreakTile_TileSet_Offset = NativeReflectionCached.GetPropertyOffset(BreakTile_FunctionAddress, "TileSet");
		BreakTile_TileSet_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakTile_FunctionAddress, "TileSet", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakTile_bFlipH_PropertyAddress, BreakTile_FunctionAddress, "bFlipH");
		BreakTile_bFlipH_Offset = NativeReflectionCached.GetPropertyOffset(BreakTile_FunctionAddress, "bFlipH");
		BreakTile_bFlipH_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakTile_FunctionAddress, "bFlipH", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakTile_bFlipV_PropertyAddress, BreakTile_FunctionAddress, "bFlipV");
		BreakTile_bFlipV_Offset = NativeReflectionCached.GetPropertyOffset(BreakTile_FunctionAddress, "bFlipV");
		BreakTile_bFlipV_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakTile_FunctionAddress, "bFlipV", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakTile_bFlipD_PropertyAddress, BreakTile_FunctionAddress, "bFlipD");
		BreakTile_bFlipD_Offset = NativeReflectionCached.GetPropertyOffset(BreakTile_FunctionAddress, "bFlipD");
		BreakTile_bFlipD_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakTile_FunctionAddress, "bFlipD", Classes.FBoolProperty);
		BreakTile_IsValid = BreakTile_FunctionAddress != IntPtr.Zero && BreakTile_Tile_IsValid && BreakTile_TileIndex_IsValid && BreakTile_TileSet_IsValid && BreakTile_bFlipH_IsValid && BreakTile_bFlipV_IsValid && BreakTile_bFlipD_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.TileMapBlueprintLibrary:BreakTile", BreakTile_IsValid);
	}
}
