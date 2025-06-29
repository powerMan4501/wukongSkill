using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.MapProceduralInfo")]
public struct MapProceduralInfo
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MapProceduralInfo:MapInfoMatrix")]
	public List<MapAttrNode> MapInfoMatrix;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MapProceduralInfo:MapBlockMapping")]
	public Dictionary<MapCatFlag, FSoftObjectPath> MapBlockMapping;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MapProceduralInfo:MapCustomLightConfigs")]
	public List<FSoftObjectPath> MapCustomLightConfigs;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MapProceduralInfo:EntranceX")]
	public int EntranceX;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MapProceduralInfo:EntranceY")]
	public int EntranceY;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MapProceduralInfo:ExitX")]
	public int ExitX;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MapProceduralInfo:ExitY")]
	public int ExitY;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MapProceduralInfo:ExpectedPointNumber")]
	public int ExpectedPointNumber;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MapProceduralInfo:MapWidth")]
	public int MapWidth;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MapProceduralInfo:MapHeight")]
	public int MapHeight;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MapProceduralInfo:BlockWidth")]
	public int BlockWidth;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MapProceduralInfo:BlockHeight")]
	public int BlockHeight;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MapProceduralInfo:MaxPointWidth")]
	public int MaxPointWidth;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MapProceduralInfo:MaxPointHeight")]
	public int MaxPointHeight;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MapProceduralInfo:MinPointWidth")]
	public int MinPointWidth;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MapProceduralInfo:MinPointHeight")]
	public int MinPointHeight;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MapProceduralInfo:IsUsingRanEE")]
	public bool IsUsingRanEE;

	[UProperty]
	[USharpPath("/Script/b1-Managed.MapProceduralInfo:MapType")]
	public ProceduralMapType MapType;

	[UProperty]
	[USharpPath("/Script/b1-Managed.MapProceduralInfo:PathCount")]
	public ushort PathCount;

	public List<MapPointData> PointsData;

	public List<MapLineData> LinesData;

	public int ValidBlockNum;

	public int MapMobConfigID;

	private static int MapProceduralInfo_StructSize;

	private static int MapProceduralInfo_IsValid;

	private static bool MapInfoMatrix_IsValid;

	private static int MapInfoMatrix_Offset;

	private static FFieldAddress MapInfoMatrix_PropertyAddress;

	private static bool MapBlockMapping_IsValid;

	private static int MapBlockMapping_Offset;

	private static FFieldAddress MapBlockMapping_PropertyAddress;

	private static bool MapCustomLightConfigs_IsValid;

	private static int MapCustomLightConfigs_Offset;

	private static FFieldAddress MapCustomLightConfigs_PropertyAddress;

	private static bool EntranceX_IsValid;

	private static int EntranceX_Offset;

	private static bool EntranceY_IsValid;

	private static int EntranceY_Offset;

	private static bool ExitX_IsValid;

	private static int ExitX_Offset;

	private static bool ExitY_IsValid;

	private static int ExitY_Offset;

	private static bool ExpectedPointNumber_IsValid;

	private static int ExpectedPointNumber_Offset;

	private static bool MapWidth_IsValid;

	private static int MapWidth_Offset;

	private static bool MapHeight_IsValid;

	private static int MapHeight_Offset;

	private static bool BlockWidth_IsValid;

	private static int BlockWidth_Offset;

	private static bool BlockHeight_IsValid;

	private static int BlockHeight_Offset;

	private static bool MaxPointWidth_IsValid;

	private static int MaxPointWidth_Offset;

	private static bool MaxPointHeight_IsValid;

	private static int MaxPointHeight_Offset;

	private static bool MinPointWidth_IsValid;

	private static int MinPointWidth_Offset;

	private static bool MinPointHeight_IsValid;

	private static int MinPointHeight_Offset;

	private static bool IsUsingRanEE_IsValid;

	private static int IsUsingRanEE_Offset;

	private static FFieldAddress IsUsingRanEE_PropertyAddress;

	private static bool MapType_IsValid;

	private static int MapType_Offset;

	private static FFieldAddress MapType_PropertyAddress;

	private static bool PathCount_IsValid;

	private static int PathCount_Offset;

	public MapProceduralInfo Copy()
	{
		MapProceduralInfo result = this;
		if (MapInfoMatrix != null)
		{
			result.MapInfoMatrix = new List<MapAttrNode>(MapInfoMatrix);
		}
		if (MapBlockMapping != null)
		{
			result.MapBlockMapping = new Dictionary<MapCatFlag, FSoftObjectPath>(MapBlockMapping);
		}
		if (MapCustomLightConfigs != null)
		{
			result.MapCustomLightConfigs = new List<FSoftObjectPath>(MapCustomLightConfigs);
		}
		return result;
	}

	public static MapProceduralInfo FromNative(IntPtr nativeBuffer)
	{
		return new MapProceduralInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, MapProceduralInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static MapProceduralInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new MapProceduralInfo(IntPtr.Add(nativeBuffer, arrayIndex * MapProceduralInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, MapProceduralInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MapProceduralInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MapProceduralInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MapProceduralInfo");
			return;
		}
		new TArrayCopyMarshaler<MapAttrNode>(1, MapInfoMatrix_PropertyAddress, CachedMarshalingDelegates<MapAttrNode, MapAttrNode>.FromNative, CachedMarshalingDelegates<MapAttrNode, MapAttrNode>.ToNative).ToNative(IntPtr.Add(nativeStruct, MapInfoMatrix_Offset), MapInfoMatrix);
		new TMapCopyMarshaler<MapCatFlag, FSoftObjectPath>(1, MapBlockMapping_PropertyAddress, CachedMarshalingDelegates<MapCatFlag, EnumMarshaler<MapCatFlag>>.FromNative, CachedMarshalingDelegates<MapCatFlag, EnumMarshaler<MapCatFlag>>.ToNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative).ToNative(IntPtr.Add(nativeStruct, MapBlockMapping_Offset), MapBlockMapping);
		new TArrayCopyMarshaler<FSoftObjectPath>(1, MapCustomLightConfigs_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative).ToNative(IntPtr.Add(nativeStruct, MapCustomLightConfigs_Offset), MapCustomLightConfigs);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, EntranceX_Offset), EntranceX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, EntranceY_Offset), EntranceY);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ExitX_Offset), ExitX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ExitY_Offset), ExitY);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ExpectedPointNumber_Offset), ExpectedPointNumber);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MapWidth_Offset), MapWidth);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MapHeight_Offset), MapHeight);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BlockWidth_Offset), BlockWidth);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BlockHeight_Offset), BlockHeight);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxPointWidth_Offset), MaxPointWidth);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxPointHeight_Offset), MaxPointHeight);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MinPointWidth_Offset), MinPointWidth);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MinPointHeight_Offset), MinPointHeight);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsUsingRanEE_Offset), 0, IsUsingRanEE_PropertyAddress.Address, IsUsingRanEE);
		EnumMarshaler<ProceduralMapType>.ToNative(IntPtr.Add(nativeStruct, MapType_Offset), 0, MapType_PropertyAddress.Address, MapType);
		BlittableTypeMarshaler<ushort>.ToNative(IntPtr.Add(nativeStruct, PathCount_Offset), PathCount);
	}

	public MapProceduralInfo(IntPtr nativeStruct)
	{
		if (MapProceduralInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MapProceduralInfo");
			MapInfoMatrix = null;
			MapBlockMapping = null;
			MapCustomLightConfigs = null;
			EntranceX = 0;
			EntranceY = 0;
			ExitX = 0;
			ExitY = 0;
			ExpectedPointNumber = 0;
			MapWidth = 0;
			MapHeight = 0;
			BlockWidth = 0;
			BlockHeight = 0;
			MaxPointWidth = 0;
			MaxPointHeight = 0;
			MinPointWidth = 0;
			MinPointHeight = 0;
			IsUsingRanEE = false;
			MapType = ProceduralMapType.PROCEDURAL_DUNGEON;
			PathCount = 0;
		}
		else
		{
			MapInfoMatrix = new TArrayCopyMarshaler<MapAttrNode>(1, MapInfoMatrix_PropertyAddress, CachedMarshalingDelegates<MapAttrNode, MapAttrNode>.FromNative, CachedMarshalingDelegates<MapAttrNode, MapAttrNode>.ToNative).FromNative(IntPtr.Add(nativeStruct, MapInfoMatrix_Offset));
			MapBlockMapping = new TMapCopyMarshaler<MapCatFlag, FSoftObjectPath>(1, MapBlockMapping_PropertyAddress, CachedMarshalingDelegates<MapCatFlag, EnumMarshaler<MapCatFlag>>.FromNative, CachedMarshalingDelegates<MapCatFlag, EnumMarshaler<MapCatFlag>>.ToNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative).FromNative(IntPtr.Add(nativeStruct, MapBlockMapping_Offset));
			MapCustomLightConfigs = new TArrayCopyMarshaler<FSoftObjectPath>(1, MapCustomLightConfigs_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative).FromNative(IntPtr.Add(nativeStruct, MapCustomLightConfigs_Offset));
			EntranceX = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, EntranceX_Offset));
			EntranceY = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, EntranceY_Offset));
			ExitX = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ExitX_Offset));
			ExitY = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ExitY_Offset));
			ExpectedPointNumber = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ExpectedPointNumber_Offset));
			MapWidth = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MapWidth_Offset));
			MapHeight = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MapHeight_Offset));
			BlockWidth = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BlockWidth_Offset));
			BlockHeight = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BlockHeight_Offset));
			MaxPointWidth = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxPointWidth_Offset));
			MaxPointHeight = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxPointHeight_Offset));
			MinPointWidth = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MinPointWidth_Offset));
			MinPointHeight = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MinPointHeight_Offset));
			IsUsingRanEE = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsUsingRanEE_Offset), 0, IsUsingRanEE_PropertyAddress.Address);
			MapType = EnumMarshaler<ProceduralMapType>.FromNative(IntPtr.Add(nativeStruct, MapType_Offset), 0, MapType_PropertyAddress.Address);
			PathCount = BlittableTypeMarshaler<ushort>.FromNative(IntPtr.Add(nativeStruct, PathCount_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MapProceduralInfo");
		MapProceduralInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref MapInfoMatrix_PropertyAddress, intPtr, "MapInfoMatrix");
		MapInfoMatrix_Offset = NativeReflection.GetPropertyOffset(intPtr, "MapInfoMatrix");
		MapInfoMatrix_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MapInfoMatrix", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref MapBlockMapping_PropertyAddress, intPtr, "MapBlockMapping");
		MapBlockMapping_Offset = NativeReflection.GetPropertyOffset(intPtr, "MapBlockMapping");
		MapBlockMapping_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MapBlockMapping", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref MapCustomLightConfigs_PropertyAddress, intPtr, "MapCustomLightConfigs");
		MapCustomLightConfigs_Offset = NativeReflection.GetPropertyOffset(intPtr, "MapCustomLightConfigs");
		MapCustomLightConfigs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MapCustomLightConfigs", Classes.FArrayProperty);
		EntranceX_Offset = NativeReflection.GetPropertyOffset(intPtr, "EntranceX");
		EntranceX_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EntranceX", Classes.FIntProperty);
		EntranceY_Offset = NativeReflection.GetPropertyOffset(intPtr, "EntranceY");
		EntranceY_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EntranceY", Classes.FIntProperty);
		ExitX_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExitX");
		ExitX_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExitX", Classes.FIntProperty);
		ExitY_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExitY");
		ExitY_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExitY", Classes.FIntProperty);
		ExpectedPointNumber_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExpectedPointNumber");
		ExpectedPointNumber_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExpectedPointNumber", Classes.FIntProperty);
		MapWidth_Offset = NativeReflection.GetPropertyOffset(intPtr, "MapWidth");
		MapWidth_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MapWidth", Classes.FIntProperty);
		MapHeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "MapHeight");
		MapHeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MapHeight", Classes.FIntProperty);
		BlockWidth_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlockWidth");
		BlockWidth_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlockWidth", Classes.FIntProperty);
		BlockHeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlockHeight");
		BlockHeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlockHeight", Classes.FIntProperty);
		MaxPointWidth_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxPointWidth");
		MaxPointWidth_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxPointWidth", Classes.FIntProperty);
		MaxPointHeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxPointHeight");
		MaxPointHeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxPointHeight", Classes.FIntProperty);
		MinPointWidth_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinPointWidth");
		MinPointWidth_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinPointWidth", Classes.FIntProperty);
		MinPointHeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinPointHeight");
		MinPointHeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinPointHeight", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref IsUsingRanEE_PropertyAddress, intPtr, "IsUsingRanEE");
		IsUsingRanEE_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsUsingRanEE");
		IsUsingRanEE_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsUsingRanEE", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref MapType_PropertyAddress, intPtr, "MapType");
		MapType_Offset = NativeReflection.GetPropertyOffset(intPtr, "MapType");
		MapType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MapType", Classes.FEnumProperty);
		PathCount_Offset = NativeReflection.GetPropertyOffset(intPtr, "PathCount");
		PathCount_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PathCount", Classes.FUInt16Property);
		MapProceduralInfo_IsValid = ((intPtr != IntPtr.Zero && MapInfoMatrix_IsValid && MapBlockMapping_IsValid && MapCustomLightConfigs_IsValid && EntranceX_IsValid && EntranceY_IsValid && ExitX_IsValid && ExitY_IsValid && ExpectedPointNumber_IsValid && MapWidth_IsValid && MapHeight_IsValid && BlockWidth_IsValid && BlockHeight_IsValid && MaxPointWidth_IsValid && MaxPointHeight_IsValid && MinPointWidth_IsValid && MinPointHeight_IsValid && IsUsingRanEE_IsValid && MapType_IsValid && PathCount_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MapProceduralInfo", (byte)MapProceduralInfo_IsValid != 0);
	}

	static MapProceduralInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MapProceduralInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MapProceduralInfo));
	}
}
