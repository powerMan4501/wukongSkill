using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.RuntimeVirtualTexture", "Engine", UnrealModuleType.Engine)]
public class URuntimeVirtualTexture : UObject
{
	private static bool TileCount_IsValid;

	private static int TileCount_Offset;

	private static bool TileSize_IsValid;

	private static int TileSize_Offset;

	private static bool TileBorderSize_IsValid;

	private static int TileBorderSize_Offset;

	private static bool MaterialType_IsValid;

	private static FFieldAddress MaterialType_PropertyAddress;

	private static int MaterialType_Offset;

	private static bool CompressTextures_IsValid;

	private static FFieldAddress CompressTextures_PropertyAddress;

	private static int CompressTextures_Offset;

	private static bool UseLowQualityCompression_IsValid;

	private static FFieldAddress UseLowQualityCompression_PropertyAddress;

	private static int UseLowQualityCompression_Offset;

	private static bool LODGroup_IsValid;

	private static FFieldAddress LODGroup_PropertyAddress;

	private static int LODGroup_Offset;

	private static bool GetTileSize_IsValid;

	private static IntPtr GetTileSize_FunctionAddress;

	private static int GetTileSize_ParamsSize;

	private static bool GetTileSize_ReturnValue_IsValid;

	private static FFieldAddress GetTileSize_ReturnValue_PropertyAddress;

	private static int GetTileSize_ReturnValue_Offset;

	private static bool GetTileCount_IsValid;

	private static IntPtr GetTileCount_FunctionAddress;

	private static int GetTileCount_ParamsSize;

	private static bool GetTileCount_ReturnValue_IsValid;

	private static FFieldAddress GetTileCount_ReturnValue_PropertyAddress;

	private static int GetTileCount_ReturnValue_Offset;

	private static bool GetTileBorderSize_IsValid;

	private static IntPtr GetTileBorderSize_FunctionAddress;

	private static int GetTileBorderSize_ParamsSize;

	private static bool GetTileBorderSize_ReturnValue_IsValid;

	private static FFieldAddress GetTileBorderSize_ReturnValue_PropertyAddress;

	private static int GetTileBorderSize_ReturnValue_Offset;

	private static bool GetSize_IsValid;

	private static IntPtr GetSize_FunctionAddress;

	private static int GetSize_ParamsSize;

	private static bool GetSize_ReturnValue_IsValid;

	private static FFieldAddress GetSize_ReturnValue_PropertyAddress;

	private static int GetSize_ReturnValue_Offset;

	private static bool GetPageTableSize_IsValid;

	private static IntPtr GetPageTableSize_FunctionAddress;

	private static int GetPageTableSize_ParamsSize;

	private static bool GetPageTableSize_ReturnValue_IsValid;

	private static FFieldAddress GetPageTableSize_ReturnValue_PropertyAddress;

	private static int GetPageTableSize_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/Engine.RuntimeVirtualTexture:TileCount")]
	protected int TileCount
	{
		get
		{
			CheckDestroyed();
			if (!TileCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RuntimeVirtualTexture:TileCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TileCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TileCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RuntimeVirtualTexture:TileCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TileCount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/Engine.RuntimeVirtualTexture:TileSize")]
	protected int TileSize
	{
		get
		{
			CheckDestroyed();
			if (!TileSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RuntimeVirtualTexture:TileSize");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TileSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TileSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RuntimeVirtualTexture:TileSize");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TileSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/Engine.RuntimeVirtualTexture:TileBorderSize")]
	protected int TileBorderSize
	{
		get
		{
			CheckDestroyed();
			if (!TileBorderSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RuntimeVirtualTexture:TileBorderSize");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TileBorderSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TileBorderSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RuntimeVirtualTexture:TileBorderSize");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TileBorderSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11268964466295317uL)]
	[UMetaPath("/Script/Engine.RuntimeVirtualTexture:MaterialType")]
	protected ERuntimeVirtualTextureMaterialType MaterialType
	{
		get
		{
			CheckDestroyed();
			if (!MaterialType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RuntimeVirtualTexture:MaterialType");
				return ERuntimeVirtualTextureMaterialType.BaseColor;
			}
			return EnumMarshaler<ERuntimeVirtualTextureMaterialType>.FromNative(IntPtr.Add(base.Address, MaterialType_Offset), 0, MaterialType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MaterialType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RuntimeVirtualTexture:MaterialType");
			}
			else
			{
				EnumMarshaler<ERuntimeVirtualTextureMaterialType>.ToNative(IntPtr.Add(base.Address, MaterialType_Offset), 0, MaterialType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/Engine.RuntimeVirtualTexture:bCompressTextures")]
	protected bool CompressTextures
	{
		get
		{
			CheckDestroyed();
			if (!CompressTextures_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RuntimeVirtualTexture:bCompressTextures");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CompressTextures_Offset), 0, CompressTextures_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CompressTextures_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RuntimeVirtualTexture:bCompressTextures");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CompressTextures_Offset), 0, CompressTextures_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/Engine.RuntimeVirtualTexture:bUseLowQualityCompression")]
	protected bool UseLowQualityCompression
	{
		get
		{
			CheckDestroyed();
			if (!UseLowQualityCompression_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RuntimeVirtualTexture:bUseLowQualityCompression");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseLowQualityCompression_Offset), 0, UseLowQualityCompression_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseLowQualityCompression_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RuntimeVirtualTexture:bUseLowQualityCompression");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseLowQualityCompression_Offset), 0, UseLowQualityCompression_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11268964466295301uL)]
	[UMetaPath("/Script/Engine.RuntimeVirtualTexture:LODGroup")]
	protected ETextureGroup LODGroup
	{
		get
		{
			CheckDestroyed();
			if (!LODGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RuntimeVirtualTexture:LODGroup");
				return ETextureGroup.TEXTUREGROUP_World;
			}
			return EnumMarshaler<ETextureGroup>.FromNative(IntPtr.Add(base.Address, LODGroup_Offset), 0, LODGroup_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LODGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RuntimeVirtualTexture:LODGroup");
			}
			else
			{
				EnumMarshaler<ETextureGroup>.ToNative(IntPtr.Add(base.Address, LODGroup_Offset), 0, LODGroup_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.RuntimeVirtualTexture:GetTileSize")]
	public unsafe int GetTileSize()
	{
		CheckDestroyed();
		if (!GetTileSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.RuntimeVirtualTexture:GetTileSize");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTileSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTileSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTileSize_FunctionAddress, intPtr, GetTileSize_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTileSize_ReturnValue_Offset), 0, GetTileSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.RuntimeVirtualTexture:GetTileCount")]
	public unsafe int GetTileCount()
	{
		CheckDestroyed();
		if (!GetTileCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.RuntimeVirtualTexture:GetTileCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTileCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTileCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTileCount_FunctionAddress, intPtr, GetTileCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTileCount_ReturnValue_Offset), 0, GetTileCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.RuntimeVirtualTexture:GetTileBorderSize")]
	public unsafe int GetTileBorderSize()
	{
		CheckDestroyed();
		if (!GetTileBorderSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.RuntimeVirtualTexture:GetTileBorderSize");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTileBorderSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTileBorderSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTileBorderSize_FunctionAddress, intPtr, GetTileBorderSize_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTileBorderSize_ReturnValue_Offset), 0, GetTileBorderSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.RuntimeVirtualTexture:GetSize")]
	public unsafe int GetSize()
	{
		CheckDestroyed();
		if (!GetSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.RuntimeVirtualTexture:GetSize");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSize_FunctionAddress, intPtr, GetSize_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSize_ReturnValue_Offset), 0, GetSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.RuntimeVirtualTexture:GetPageTableSize")]
	public unsafe int GetPageTableSize()
	{
		CheckDestroyed();
		if (!GetPageTableSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.RuntimeVirtualTexture:GetPageTableSize");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPageTableSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPageTableSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPageTableSize_FunctionAddress, intPtr, GetPageTableSize_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetPageTableSize_ReturnValue_Offset), 0, GetPageTableSize_ReturnValue_PropertyAddress.Address);
	}

	static URuntimeVirtualTexture()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URuntimeVirtualTexture)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URuntimeVirtualTexture));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.RuntimeVirtualTexture");
		TileCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TileCount");
		TileCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TileCount", Classes.FIntProperty);
		TileSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TileSize");
		TileSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TileSize", Classes.FIntProperty);
		TileBorderSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TileBorderSize");
		TileBorderSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TileBorderSize", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MaterialType_PropertyAddress, intPtr, "MaterialType");
		MaterialType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaterialType");
		MaterialType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaterialType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref CompressTextures_PropertyAddress, intPtr, "bCompressTextures");
		CompressTextures_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCompressTextures");
		CompressTextures_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCompressTextures", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseLowQualityCompression_PropertyAddress, intPtr, "bUseLowQualityCompression");
		UseLowQualityCompression_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseLowQualityCompression");
		UseLowQualityCompression_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseLowQualityCompression", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LODGroup_PropertyAddress, intPtr, "LODGroup");
		LODGroup_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LODGroup");
		LODGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LODGroup", Classes.FByteProperty);
		GetTileSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTileSize");
		GetTileSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTileSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTileSize_ReturnValue_PropertyAddress, GetTileSize_FunctionAddress, "ReturnValue");
		GetTileSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTileSize_FunctionAddress, "ReturnValue");
		GetTileSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTileSize_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTileSize_IsValid = GetTileSize_FunctionAddress != IntPtr.Zero && GetTileSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.RuntimeVirtualTexture:GetTileSize", GetTileSize_IsValid);
		GetTileCount_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTileCount");
		GetTileCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTileCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTileCount_ReturnValue_PropertyAddress, GetTileCount_FunctionAddress, "ReturnValue");
		GetTileCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTileCount_FunctionAddress, "ReturnValue");
		GetTileCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTileCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTileCount_IsValid = GetTileCount_FunctionAddress != IntPtr.Zero && GetTileCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.RuntimeVirtualTexture:GetTileCount", GetTileCount_IsValid);
		GetTileBorderSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTileBorderSize");
		GetTileBorderSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTileBorderSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTileBorderSize_ReturnValue_PropertyAddress, GetTileBorderSize_FunctionAddress, "ReturnValue");
		GetTileBorderSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTileBorderSize_FunctionAddress, "ReturnValue");
		GetTileBorderSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTileBorderSize_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTileBorderSize_IsValid = GetTileBorderSize_FunctionAddress != IntPtr.Zero && GetTileBorderSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.RuntimeVirtualTexture:GetTileBorderSize", GetTileBorderSize_IsValid);
		GetSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSize");
		GetSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSize_ReturnValue_PropertyAddress, GetSize_FunctionAddress, "ReturnValue");
		GetSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSize_FunctionAddress, "ReturnValue");
		GetSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSize_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSize_IsValid = GetSize_FunctionAddress != IntPtr.Zero && GetSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.RuntimeVirtualTexture:GetSize", GetSize_IsValid);
		GetPageTableSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPageTableSize");
		GetPageTableSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPageTableSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPageTableSize_ReturnValue_PropertyAddress, GetPageTableSize_FunctionAddress, "ReturnValue");
		GetPageTableSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPageTableSize_FunctionAddress, "ReturnValue");
		GetPageTableSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPageTableSize_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetPageTableSize_IsValid = GetPageTableSize_FunctionAddress != IntPtr.Zero && GetPageTableSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.RuntimeVirtualTexture:GetPageTableSize", GetPageTableSize_IsValid);
	}
}
