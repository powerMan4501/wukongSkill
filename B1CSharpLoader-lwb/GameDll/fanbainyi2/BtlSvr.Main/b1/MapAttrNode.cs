using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.MapAttrNode")]
public struct MapAttrNode
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MapAttrNode:BlockCatDir")]
	public MapCatFlag BlockCatDir;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MapAttrNode:IsPointBlock")]
	public bool IsPointBlock;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MapAttrNode:InPointLoc")]
	public PointBlockLocFlag InPointLoc;

	[UProperty]
	[USharpPath("/Script/b1-Managed.MapAttrNode:PathCatID")]
	public ulong PathCatID;

	private static int MapAttrNode_StructSize;

	private static int MapAttrNode_IsValid;

	private static bool BlockCatDir_IsValid;

	private static int BlockCatDir_Offset;

	private static FFieldAddress BlockCatDir_PropertyAddress;

	private static bool IsPointBlock_IsValid;

	private static int IsPointBlock_Offset;

	private static FFieldAddress IsPointBlock_PropertyAddress;

	private static bool InPointLoc_IsValid;

	private static int InPointLoc_Offset;

	private static FFieldAddress InPointLoc_PropertyAddress;

	private static bool PathCatID_IsValid;

	private static int PathCatID_Offset;

	public MapAttrNode Copy()
	{
		return this;
	}

	public static MapAttrNode FromNative(IntPtr nativeBuffer)
	{
		return new MapAttrNode(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, MapAttrNode value)
	{
		value.ToNative(nativeBuffer);
	}

	public static MapAttrNode FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new MapAttrNode(IntPtr.Add(nativeBuffer, arrayIndex * MapAttrNode_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, MapAttrNode value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MapAttrNode_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MapAttrNode_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MapAttrNode");
			return;
		}
		EnumMarshaler<MapCatFlag>.ToNative(IntPtr.Add(nativeStruct, BlockCatDir_Offset), 0, BlockCatDir_PropertyAddress.Address, BlockCatDir);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsPointBlock_Offset), 0, IsPointBlock_PropertyAddress.Address, IsPointBlock);
		EnumMarshaler<PointBlockLocFlag>.ToNative(IntPtr.Add(nativeStruct, InPointLoc_Offset), 0, InPointLoc_PropertyAddress.Address, InPointLoc);
		BlittableTypeMarshaler<ulong>.ToNative(IntPtr.Add(nativeStruct, PathCatID_Offset), PathCatID);
	}

	public MapAttrNode(IntPtr nativeStruct)
	{
		if (MapAttrNode_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MapAttrNode");
			BlockCatDir = MapCatFlag.CAT_NONE;
			IsPointBlock = false;
			InPointLoc = PointBlockLocFlag.PBL_NONE;
			PathCatID = 0uL;
		}
		else
		{
			BlockCatDir = EnumMarshaler<MapCatFlag>.FromNative(IntPtr.Add(nativeStruct, BlockCatDir_Offset), 0, BlockCatDir_PropertyAddress.Address);
			IsPointBlock = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsPointBlock_Offset), 0, IsPointBlock_PropertyAddress.Address);
			InPointLoc = EnumMarshaler<PointBlockLocFlag>.FromNative(IntPtr.Add(nativeStruct, InPointLoc_Offset), 0, InPointLoc_PropertyAddress.Address);
			PathCatID = BlittableTypeMarshaler<ulong>.FromNative(IntPtr.Add(nativeStruct, PathCatID_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MapAttrNode");
		MapAttrNode_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref BlockCatDir_PropertyAddress, intPtr, "BlockCatDir");
		BlockCatDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlockCatDir");
		BlockCatDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlockCatDir", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsPointBlock_PropertyAddress, intPtr, "IsPointBlock");
		IsPointBlock_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsPointBlock");
		IsPointBlock_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsPointBlock", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref InPointLoc_PropertyAddress, intPtr, "InPointLoc");
		InPointLoc_Offset = NativeReflection.GetPropertyOffset(intPtr, "InPointLoc");
		InPointLoc_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InPointLoc", Classes.FEnumProperty);
		PathCatID_Offset = NativeReflection.GetPropertyOffset(intPtr, "PathCatID");
		PathCatID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PathCatID", Classes.FUInt64Property);
		MapAttrNode_IsValid = ((intPtr != IntPtr.Zero && BlockCatDir_IsValid && IsPointBlock_IsValid && InPointLoc_IsValid && PathCatID_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MapAttrNode", (byte)MapAttrNode_IsValid != 0);
	}

	static MapAttrNode()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MapAttrNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MapAttrNode));
	}
}
