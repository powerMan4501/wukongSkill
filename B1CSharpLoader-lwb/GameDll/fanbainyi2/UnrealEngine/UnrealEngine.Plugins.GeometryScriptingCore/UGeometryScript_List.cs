using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_List : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetVectorListLength_IsValid;

	private static IntPtr GetVectorListLength_FunctionAddress;

	private static int GetVectorListLength_ParamsSize;

	private static bool GetVectorListLength_VectorList_IsValid;

	private static FFieldAddress GetVectorListLength_VectorList_PropertyAddress;

	private static int GetVectorListLength_VectorList_Offset;

	private static bool GetVectorListLength_ReturnValue_IsValid;

	private static FFieldAddress GetVectorListLength_ReturnValue_PropertyAddress;

	private static int GetVectorListLength_ReturnValue_Offset;

	private static bool GetVectorListLastIndex_IsValid;

	private static IntPtr GetVectorListLastIndex_FunctionAddress;

	private static int GetVectorListLastIndex_ParamsSize;

	private static bool GetVectorListLastIndex_VectorList_IsValid;

	private static FFieldAddress GetVectorListLastIndex_VectorList_PropertyAddress;

	private static int GetVectorListLastIndex_VectorList_Offset;

	private static bool GetVectorListLastIndex_ReturnValue_IsValid;

	private static FFieldAddress GetVectorListLastIndex_ReturnValue_PropertyAddress;

	private static int GetVectorListLastIndex_ReturnValue_Offset;

	private static bool GetVectorListItem_IsValid;

	private static IntPtr GetVectorListItem_FunctionAddress;

	private static int GetVectorListItem_ParamsSize;

	private static bool GetVectorListItem_VectorList_IsValid;

	private static FFieldAddress GetVectorListItem_VectorList_PropertyAddress;

	private static int GetVectorListItem_VectorList_Offset;

	private static bool GetVectorListItem_Index_IsValid;

	private static FFieldAddress GetVectorListItem_Index_PropertyAddress;

	private static int GetVectorListItem_Index_Offset;

	private static bool GetVectorListItem_bIsValidIndex_IsValid;

	private static FFieldAddress GetVectorListItem_bIsValidIndex_PropertyAddress;

	private static int GetVectorListItem_bIsValidIndex_Offset;

	private static bool GetVectorListItem_ReturnValue_IsValid;

	private static FFieldAddress GetVectorListItem_ReturnValue_PropertyAddress;

	private static int GetVectorListItem_ReturnValue_Offset;

	private static bool GetUVListLength_IsValid;

	private static IntPtr GetUVListLength_FunctionAddress;

	private static int GetUVListLength_ParamsSize;

	private static bool GetUVListLength_UVList_IsValid;

	private static FFieldAddress GetUVListLength_UVList_PropertyAddress;

	private static int GetUVListLength_UVList_Offset;

	private static bool GetUVListLength_ReturnValue_IsValid;

	private static FFieldAddress GetUVListLength_ReturnValue_PropertyAddress;

	private static int GetUVListLength_ReturnValue_Offset;

	private static bool GetUVListLastIndex_IsValid;

	private static IntPtr GetUVListLastIndex_FunctionAddress;

	private static int GetUVListLastIndex_ParamsSize;

	private static bool GetUVListLastIndex_UVList_IsValid;

	private static FFieldAddress GetUVListLastIndex_UVList_PropertyAddress;

	private static int GetUVListLastIndex_UVList_Offset;

	private static bool GetUVListLastIndex_ReturnValue_IsValid;

	private static FFieldAddress GetUVListLastIndex_ReturnValue_PropertyAddress;

	private static int GetUVListLastIndex_ReturnValue_Offset;

	private static bool GetUVListItem_IsValid;

	private static IntPtr GetUVListItem_FunctionAddress;

	private static int GetUVListItem_ParamsSize;

	private static bool GetUVListItem_UVList_IsValid;

	private static FFieldAddress GetUVListItem_UVList_PropertyAddress;

	private static int GetUVListItem_UVList_Offset;

	private static bool GetUVListItem_Index_IsValid;

	private static FFieldAddress GetUVListItem_Index_PropertyAddress;

	private static int GetUVListItem_Index_Offset;

	private static bool GetUVListItem_bIsValidIndex_IsValid;

	private static FFieldAddress GetUVListItem_bIsValidIndex_PropertyAddress;

	private static int GetUVListItem_bIsValidIndex_Offset;

	private static bool GetUVListItem_ReturnValue_IsValid;

	private static FFieldAddress GetUVListItem_ReturnValue_PropertyAddress;

	private static int GetUVListItem_ReturnValue_Offset;

	private static bool GetTriangleListLength_IsValid;

	private static IntPtr GetTriangleListLength_FunctionAddress;

	private static int GetTriangleListLength_ParamsSize;

	private static bool GetTriangleListLength_TriangleList_IsValid;

	private static FFieldAddress GetTriangleListLength_TriangleList_PropertyAddress;

	private static int GetTriangleListLength_TriangleList_Offset;

	private static bool GetTriangleListLength_ReturnValue_IsValid;

	private static FFieldAddress GetTriangleListLength_ReturnValue_PropertyAddress;

	private static int GetTriangleListLength_ReturnValue_Offset;

	private static bool GetTriangleListLastTriangle_IsValid;

	private static IntPtr GetTriangleListLastTriangle_FunctionAddress;

	private static int GetTriangleListLastTriangle_ParamsSize;

	private static bool GetTriangleListLastTriangle_TriangleList_IsValid;

	private static FFieldAddress GetTriangleListLastTriangle_TriangleList_PropertyAddress;

	private static int GetTriangleListLastTriangle_TriangleList_Offset;

	private static bool GetTriangleListLastTriangle_ReturnValue_IsValid;

	private static FFieldAddress GetTriangleListLastTriangle_ReturnValue_PropertyAddress;

	private static int GetTriangleListLastTriangle_ReturnValue_Offset;

	private static bool GetTriangleListItem_IsValid;

	private static IntPtr GetTriangleListItem_FunctionAddress;

	private static int GetTriangleListItem_ParamsSize;

	private static bool GetTriangleListItem_TriangleList_IsValid;

	private static FFieldAddress GetTriangleListItem_TriangleList_PropertyAddress;

	private static int GetTriangleListItem_TriangleList_Offset;

	private static bool GetTriangleListItem_Triangle_IsValid;

	private static FFieldAddress GetTriangleListItem_Triangle_PropertyAddress;

	private static int GetTriangleListItem_Triangle_Offset;

	private static bool GetTriangleListItem_bIsValidTriangle_IsValid;

	private static FFieldAddress GetTriangleListItem_bIsValidTriangle_PropertyAddress;

	private static int GetTriangleListItem_bIsValidTriangle_Offset;

	private static bool GetTriangleListItem_ReturnValue_IsValid;

	private static FFieldAddress GetTriangleListItem_ReturnValue_PropertyAddress;

	private static int GetTriangleListItem_ReturnValue_Offset;

	private static bool GetIndexListLength_IsValid;

	private static IntPtr GetIndexListLength_FunctionAddress;

	private static int GetIndexListLength_ParamsSize;

	private static bool GetIndexListLength_IndexList_IsValid;

	private static FFieldAddress GetIndexListLength_IndexList_PropertyAddress;

	private static int GetIndexListLength_IndexList_Offset;

	private static bool GetIndexListLength_ReturnValue_IsValid;

	private static FFieldAddress GetIndexListLength_ReturnValue_PropertyAddress;

	private static int GetIndexListLength_ReturnValue_Offset;

	private static bool GetIndexListLastIndex_IsValid;

	private static IntPtr GetIndexListLastIndex_FunctionAddress;

	private static int GetIndexListLastIndex_ParamsSize;

	private static bool GetIndexListLastIndex_IndexList_IsValid;

	private static FFieldAddress GetIndexListLastIndex_IndexList_PropertyAddress;

	private static int GetIndexListLastIndex_IndexList_Offset;

	private static bool GetIndexListLastIndex_ReturnValue_IsValid;

	private static FFieldAddress GetIndexListLastIndex_ReturnValue_PropertyAddress;

	private static int GetIndexListLastIndex_ReturnValue_Offset;

	private static bool GetIndexListItem_IsValid;

	private static IntPtr GetIndexListItem_FunctionAddress;

	private static int GetIndexListItem_ParamsSize;

	private static bool GetIndexListItem_IndexList_IsValid;

	private static FFieldAddress GetIndexListItem_IndexList_PropertyAddress;

	private static int GetIndexListItem_IndexList_Offset;

	private static bool GetIndexListItem_Index_IsValid;

	private static FFieldAddress GetIndexListItem_Index_PropertyAddress;

	private static int GetIndexListItem_Index_Offset;

	private static bool GetIndexListItem_bIsValidIndex_IsValid;

	private static FFieldAddress GetIndexListItem_bIsValidIndex_PropertyAddress;

	private static int GetIndexListItem_bIsValidIndex_Offset;

	private static bool GetIndexListItem_ReturnValue_IsValid;

	private static FFieldAddress GetIndexListItem_ReturnValue_PropertyAddress;

	private static int GetIndexListItem_ReturnValue_Offset;

	private static bool GetColorListLength_IsValid;

	private static IntPtr GetColorListLength_FunctionAddress;

	private static int GetColorListLength_ParamsSize;

	private static bool GetColorListLength_ColorList_IsValid;

	private static FFieldAddress GetColorListLength_ColorList_PropertyAddress;

	private static int GetColorListLength_ColorList_Offset;

	private static bool GetColorListLength_ReturnValue_IsValid;

	private static FFieldAddress GetColorListLength_ReturnValue_PropertyAddress;

	private static int GetColorListLength_ReturnValue_Offset;

	private static bool GetColorListLastIndex_IsValid;

	private static IntPtr GetColorListLastIndex_FunctionAddress;

	private static int GetColorListLastIndex_ParamsSize;

	private static bool GetColorListLastIndex_ColorList_IsValid;

	private static FFieldAddress GetColorListLastIndex_ColorList_PropertyAddress;

	private static int GetColorListLastIndex_ColorList_Offset;

	private static bool GetColorListLastIndex_ReturnValue_IsValid;

	private static FFieldAddress GetColorListLastIndex_ReturnValue_PropertyAddress;

	private static int GetColorListLastIndex_ReturnValue_Offset;

	private static bool GetColorListItem_IsValid;

	private static IntPtr GetColorListItem_FunctionAddress;

	private static int GetColorListItem_ParamsSize;

	private static bool GetColorListItem_ColorList_IsValid;

	private static FFieldAddress GetColorListItem_ColorList_PropertyAddress;

	private static int GetColorListItem_ColorList_Offset;

	private static bool GetColorListItem_Index_IsValid;

	private static FFieldAddress GetColorListItem_Index_PropertyAddress;

	private static int GetColorListItem_Index_Offset;

	private static bool GetColorListItem_bIsValidIndex_IsValid;

	private static FFieldAddress GetColorListItem_bIsValidIndex_PropertyAddress;

	private static int GetColorListItem_bIsValidIndex_Offset;

	private static bool GetColorListItem_ReturnValue_IsValid;

	private static FFieldAddress GetColorListItem_ReturnValue_PropertyAddress;

	private static int GetColorListItem_ReturnValue_Offset;

	private static bool ConvertVectorListToArray_IsValid;

	private static IntPtr ConvertVectorListToArray_FunctionAddress;

	private static int ConvertVectorListToArray_ParamsSize;

	private static bool ConvertVectorListToArray_VectorList_IsValid;

	private static FFieldAddress ConvertVectorListToArray_VectorList_PropertyAddress;

	private static int ConvertVectorListToArray_VectorList_Offset;

	private static bool ConvertVectorListToArray_VectorArray_IsValid;

	private static FFieldAddress ConvertVectorListToArray_VectorArray_PropertyAddress;

	private static int ConvertVectorListToArray_VectorArray_Offset;

	private static bool ConvertUVListToArray_IsValid;

	private static IntPtr ConvertUVListToArray_FunctionAddress;

	private static int ConvertUVListToArray_ParamsSize;

	private static bool ConvertUVListToArray_UVList_IsValid;

	private static FFieldAddress ConvertUVListToArray_UVList_PropertyAddress;

	private static int ConvertUVListToArray_UVList_Offset;

	private static bool ConvertUVListToArray_UVArray_IsValid;

	private static FFieldAddress ConvertUVListToArray_UVArray_PropertyAddress;

	private static int ConvertUVListToArray_UVArray_Offset;

	private static bool ConvertTriangleListToArray_IsValid;

	private static IntPtr ConvertTriangleListToArray_FunctionAddress;

	private static int ConvertTriangleListToArray_ParamsSize;

	private static bool ConvertTriangleListToArray_TriangleList_IsValid;

	private static FFieldAddress ConvertTriangleListToArray_TriangleList_PropertyAddress;

	private static int ConvertTriangleListToArray_TriangleList_Offset;

	private static bool ConvertTriangleListToArray_TriangleArray_IsValid;

	private static FFieldAddress ConvertTriangleListToArray_TriangleArray_PropertyAddress;

	private static int ConvertTriangleListToArray_TriangleArray_Offset;

	private static bool ConvertIndexListToArray_IsValid;

	private static IntPtr ConvertIndexListToArray_FunctionAddress;

	private static int ConvertIndexListToArray_ParamsSize;

	private static bool ConvertIndexListToArray_IndexList_IsValid;

	private static FFieldAddress ConvertIndexListToArray_IndexList_PropertyAddress;

	private static int ConvertIndexListToArray_IndexList_Offset;

	private static bool ConvertIndexListToArray_IndexArray_IsValid;

	private static FFieldAddress ConvertIndexListToArray_IndexArray_PropertyAddress;

	private static int ConvertIndexListToArray_IndexArray_Offset;

	private static bool ConvertColorListToArray_IsValid;

	private static IntPtr ConvertColorListToArray_FunctionAddress;

	private static int ConvertColorListToArray_ParamsSize;

	private static bool ConvertColorListToArray_ColorList_IsValid;

	private static FFieldAddress ConvertColorListToArray_ColorList_PropertyAddress;

	private static int ConvertColorListToArray_ColorList_Offset;

	private static bool ConvertColorListToArray_ColorArray_IsValid;

	private static FFieldAddress ConvertColorListToArray_ColorArray_PropertyAddress;

	private static int ConvertColorListToArray_ColorArray_Offset;

	private static bool ConvertArrayToVectorList_IsValid;

	private static IntPtr ConvertArrayToVectorList_FunctionAddress;

	private static int ConvertArrayToVectorList_ParamsSize;

	private static bool ConvertArrayToVectorList_VectorArray_IsValid;

	private static FFieldAddress ConvertArrayToVectorList_VectorArray_PropertyAddress;

	private static int ConvertArrayToVectorList_VectorArray_Offset;

	private static bool ConvertArrayToVectorList_VectorList_IsValid;

	private static FFieldAddress ConvertArrayToVectorList_VectorList_PropertyAddress;

	private static int ConvertArrayToVectorList_VectorList_Offset;

	private static bool ConvertArrayToUVList_IsValid;

	private static IntPtr ConvertArrayToUVList_FunctionAddress;

	private static int ConvertArrayToUVList_ParamsSize;

	private static bool ConvertArrayToUVList_UVArray_IsValid;

	private static FFieldAddress ConvertArrayToUVList_UVArray_PropertyAddress;

	private static int ConvertArrayToUVList_UVArray_Offset;

	private static bool ConvertArrayToUVList_UVList_IsValid;

	private static FFieldAddress ConvertArrayToUVList_UVList_PropertyAddress;

	private static int ConvertArrayToUVList_UVList_Offset;

	private static bool ConvertArrayToTriangleList_IsValid;

	private static IntPtr ConvertArrayToTriangleList_FunctionAddress;

	private static int ConvertArrayToTriangleList_ParamsSize;

	private static bool ConvertArrayToTriangleList_TriangleArray_IsValid;

	private static FFieldAddress ConvertArrayToTriangleList_TriangleArray_PropertyAddress;

	private static int ConvertArrayToTriangleList_TriangleArray_Offset;

	private static bool ConvertArrayToTriangleList_TriangleList_IsValid;

	private static FFieldAddress ConvertArrayToTriangleList_TriangleList_PropertyAddress;

	private static int ConvertArrayToTriangleList_TriangleList_Offset;

	private static bool ConvertArrayToIndexList_IsValid;

	private static IntPtr ConvertArrayToIndexList_FunctionAddress;

	private static int ConvertArrayToIndexList_ParamsSize;

	private static bool ConvertArrayToIndexList_IndexArray_IsValid;

	private static FFieldAddress ConvertArrayToIndexList_IndexArray_PropertyAddress;

	private static int ConvertArrayToIndexList_IndexArray_Offset;

	private static bool ConvertArrayToIndexList_IndexList_IsValid;

	private static FFieldAddress ConvertArrayToIndexList_IndexList_PropertyAddress;

	private static int ConvertArrayToIndexList_IndexList_Offset;

	private static bool ConvertArrayToIndexList_IndexType_IsValid;

	private static FFieldAddress ConvertArrayToIndexList_IndexType_PropertyAddress;

	private static int ConvertArrayToIndexList_IndexType_Offset;

	private static bool ConvertArrayToColorList_IsValid;

	private static IntPtr ConvertArrayToColorList_FunctionAddress;

	private static int ConvertArrayToColorList_ParamsSize;

	private static bool ConvertArrayToColorList_ColorArray_IsValid;

	private static FFieldAddress ConvertArrayToColorList_ColorArray_PropertyAddress;

	private static int ConvertArrayToColorList_ColorArray_Offset;

	private static bool ConvertArrayToColorList_ColorList_IsValid;

	private static FFieldAddress ConvertArrayToColorList_ColorList_PropertyAddress;

	private static int ConvertArrayToColorList_ColorList_Offset;

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetVectorListLength")]
	public unsafe static int GetVectorListLength(FGeometryScriptVectorList VectorList)
	{
		if (!GetVectorListLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetVectorListLength");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVectorListLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVectorListLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVectorListLength_VectorList_PropertyAddress.Address, intPtr);
		FGeometryScriptVectorList.ToNative(IntPtr.Add(intPtr, GetVectorListLength_VectorList_Offset), 0, GetVectorListLength_VectorList_PropertyAddress.Address, VectorList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVectorListLength_FunctionAddress, intPtr, GetVectorListLength_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetVectorListLength_VectorList_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetVectorListLength_ReturnValue_Offset), 0, GetVectorListLength_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetVectorListLastIndex")]
	public unsafe static int GetVectorListLastIndex(FGeometryScriptVectorList VectorList)
	{
		if (!GetVectorListLastIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetVectorListLastIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVectorListLastIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVectorListLastIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVectorListLastIndex_VectorList_PropertyAddress.Address, intPtr);
		FGeometryScriptVectorList.ToNative(IntPtr.Add(intPtr, GetVectorListLastIndex_VectorList_Offset), 0, GetVectorListLastIndex_VectorList_PropertyAddress.Address, VectorList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVectorListLastIndex_FunctionAddress, intPtr, GetVectorListLastIndex_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetVectorListLastIndex_VectorList_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetVectorListLastIndex_ReturnValue_Offset), 0, GetVectorListLastIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetVectorListItem")]
	public unsafe static FVector GetVectorListItem(FGeometryScriptVectorList VectorList, int Index, out bool bIsValidIndex)
	{
		if (!GetVectorListItem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetVectorListItem");
			bIsValidIndex = false;
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVectorListItem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVectorListItem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVectorListItem_VectorList_PropertyAddress.Address, intPtr);
		FGeometryScriptVectorList.ToNative(IntPtr.Add(intPtr, GetVectorListItem_VectorList_Offset), 0, GetVectorListItem_VectorList_PropertyAddress.Address, VectorList);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetVectorListItem_Index_Offset), 0, GetVectorListItem_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVectorListItem_FunctionAddress, intPtr, GetVectorListItem_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetVectorListItem_VectorList_PropertyAddress.Address, intPtr);
		bIsValidIndex = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetVectorListItem_bIsValidIndex_Offset), 0, GetVectorListItem_bIsValidIndex_PropertyAddress.Address);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetVectorListItem_ReturnValue_Offset), 0, GetVectorListItem_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetUVListLength")]
	public unsafe static int GetUVListLength(FGeometryScriptUVList UVList)
	{
		if (!GetUVListLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetUVListLength");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUVListLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUVListLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetUVListLength_UVList_PropertyAddress.Address, intPtr);
		FGeometryScriptUVList.ToNative(IntPtr.Add(intPtr, GetUVListLength_UVList_Offset), 0, GetUVListLength_UVList_PropertyAddress.Address, UVList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetUVListLength_FunctionAddress, intPtr, GetUVListLength_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetUVListLength_UVList_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetUVListLength_ReturnValue_Offset), 0, GetUVListLength_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetUVListLastIndex")]
	public unsafe static int GetUVListLastIndex(FGeometryScriptUVList UVList)
	{
		if (!GetUVListLastIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetUVListLastIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUVListLastIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUVListLastIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetUVListLastIndex_UVList_PropertyAddress.Address, intPtr);
		FGeometryScriptUVList.ToNative(IntPtr.Add(intPtr, GetUVListLastIndex_UVList_Offset), 0, GetUVListLastIndex_UVList_PropertyAddress.Address, UVList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetUVListLastIndex_FunctionAddress, intPtr, GetUVListLastIndex_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetUVListLastIndex_UVList_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetUVListLastIndex_ReturnValue_Offset), 0, GetUVListLastIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetUVListItem")]
	public unsafe static FVector2D GetUVListItem(FGeometryScriptUVList UVList, int Index, out bool bIsValidIndex)
	{
		if (!GetUVListItem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetUVListItem");
			bIsValidIndex = false;
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUVListItem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUVListItem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetUVListItem_UVList_PropertyAddress.Address, intPtr);
		FGeometryScriptUVList.ToNative(IntPtr.Add(intPtr, GetUVListItem_UVList_Offset), 0, GetUVListItem_UVList_PropertyAddress.Address, UVList);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetUVListItem_Index_Offset), 0, GetUVListItem_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetUVListItem_FunctionAddress, intPtr, GetUVListItem_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetUVListItem_UVList_PropertyAddress.Address, intPtr);
		bIsValidIndex = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetUVListItem_bIsValidIndex_Offset), 0, GetUVListItem_bIsValidIndex_PropertyAddress.Address);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetUVListItem_ReturnValue_Offset), 0, GetUVListItem_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetTriangleListLength")]
	public unsafe static int GetTriangleListLength(FGeometryScriptTriangleList TriangleList)
	{
		if (!GetTriangleListLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetTriangleListLength");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTriangleListLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTriangleListLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTriangleListLength_TriangleList_PropertyAddress.Address, intPtr);
		FGeometryScriptTriangleList.ToNative(IntPtr.Add(intPtr, GetTriangleListLength_TriangleList_Offset), 0, GetTriangleListLength_TriangleList_PropertyAddress.Address, TriangleList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTriangleListLength_FunctionAddress, intPtr, GetTriangleListLength_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetTriangleListLength_TriangleList_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTriangleListLength_ReturnValue_Offset), 0, GetTriangleListLength_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetTriangleListLastTriangle")]
	public unsafe static int GetTriangleListLastTriangle(FGeometryScriptTriangleList TriangleList)
	{
		if (!GetTriangleListLastTriangle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetTriangleListLastTriangle");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTriangleListLastTriangle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTriangleListLastTriangle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTriangleListLastTriangle_TriangleList_PropertyAddress.Address, intPtr);
		FGeometryScriptTriangleList.ToNative(IntPtr.Add(intPtr, GetTriangleListLastTriangle_TriangleList_Offset), 0, GetTriangleListLastTriangle_TriangleList_PropertyAddress.Address, TriangleList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTriangleListLastTriangle_FunctionAddress, intPtr, GetTriangleListLastTriangle_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetTriangleListLastTriangle_TriangleList_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTriangleListLastTriangle_ReturnValue_Offset), 0, GetTriangleListLastTriangle_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetTriangleListItem")]
	public unsafe static FIntVector GetTriangleListItem(FGeometryScriptTriangleList TriangleList, int Triangle, out bool bIsValidTriangle)
	{
		if (!GetTriangleListItem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetTriangleListItem");
			bIsValidTriangle = false;
			return default(FIntVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTriangleListItem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTriangleListItem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTriangleListItem_TriangleList_PropertyAddress.Address, intPtr);
		FGeometryScriptTriangleList.ToNative(IntPtr.Add(intPtr, GetTriangleListItem_TriangleList_Offset), 0, GetTriangleListItem_TriangleList_PropertyAddress.Address, TriangleList);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTriangleListItem_Triangle_Offset), 0, GetTriangleListItem_Triangle_PropertyAddress.Address, Triangle);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTriangleListItem_FunctionAddress, intPtr, GetTriangleListItem_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetTriangleListItem_TriangleList_PropertyAddress.Address, intPtr);
		bIsValidTriangle = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetTriangleListItem_bIsValidTriangle_Offset), 0, GetTriangleListItem_bIsValidTriangle_PropertyAddress.Address);
		return BlittableTypeMarshaler<FIntVector>.FromNative(IntPtr.Add(intPtr, GetTriangleListItem_ReturnValue_Offset), 0, GetTriangleListItem_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetIndexListLength")]
	public unsafe static int GetIndexListLength(FGeometryScriptIndexList IndexList)
	{
		if (!GetIndexListLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetIndexListLength");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIndexListLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIndexListLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetIndexListLength_IndexList_PropertyAddress.Address, intPtr);
		FGeometryScriptIndexList.ToNative(IntPtr.Add(intPtr, GetIndexListLength_IndexList_Offset), 0, GetIndexListLength_IndexList_PropertyAddress.Address, IndexList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIndexListLength_FunctionAddress, intPtr, GetIndexListLength_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetIndexListLength_IndexList_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetIndexListLength_ReturnValue_Offset), 0, GetIndexListLength_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetIndexListLastIndex")]
	public unsafe static int GetIndexListLastIndex(FGeometryScriptIndexList IndexList)
	{
		if (!GetIndexListLastIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetIndexListLastIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIndexListLastIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIndexListLastIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetIndexListLastIndex_IndexList_PropertyAddress.Address, intPtr);
		FGeometryScriptIndexList.ToNative(IntPtr.Add(intPtr, GetIndexListLastIndex_IndexList_Offset), 0, GetIndexListLastIndex_IndexList_PropertyAddress.Address, IndexList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIndexListLastIndex_FunctionAddress, intPtr, GetIndexListLastIndex_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetIndexListLastIndex_IndexList_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetIndexListLastIndex_ReturnValue_Offset), 0, GetIndexListLastIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetIndexListItem")]
	public unsafe static int GetIndexListItem(FGeometryScriptIndexList IndexList, int Index, out bool bIsValidIndex)
	{
		if (!GetIndexListItem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetIndexListItem");
			bIsValidIndex = false;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIndexListItem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIndexListItem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetIndexListItem_IndexList_PropertyAddress.Address, intPtr);
		FGeometryScriptIndexList.ToNative(IntPtr.Add(intPtr, GetIndexListItem_IndexList_Offset), 0, GetIndexListItem_IndexList_PropertyAddress.Address, IndexList);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetIndexListItem_Index_Offset), 0, GetIndexListItem_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIndexListItem_FunctionAddress, intPtr, GetIndexListItem_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetIndexListItem_IndexList_PropertyAddress.Address, intPtr);
		bIsValidIndex = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIndexListItem_bIsValidIndex_Offset), 0, GetIndexListItem_bIsValidIndex_PropertyAddress.Address);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetIndexListItem_ReturnValue_Offset), 0, GetIndexListItem_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetColorListLength")]
	public unsafe static int GetColorListLength(FGeometryScriptColorList ColorList)
	{
		if (!GetColorListLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetColorListLength");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetColorListLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetColorListLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetColorListLength_ColorList_PropertyAddress.Address, intPtr);
		FGeometryScriptColorList.ToNative(IntPtr.Add(intPtr, GetColorListLength_ColorList_Offset), 0, GetColorListLength_ColorList_PropertyAddress.Address, ColorList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetColorListLength_FunctionAddress, intPtr, GetColorListLength_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetColorListLength_ColorList_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetColorListLength_ReturnValue_Offset), 0, GetColorListLength_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetColorListLastIndex")]
	public unsafe static int GetColorListLastIndex(FGeometryScriptColorList ColorList)
	{
		if (!GetColorListLastIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetColorListLastIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetColorListLastIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetColorListLastIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetColorListLastIndex_ColorList_PropertyAddress.Address, intPtr);
		FGeometryScriptColorList.ToNative(IntPtr.Add(intPtr, GetColorListLastIndex_ColorList_Offset), 0, GetColorListLastIndex_ColorList_PropertyAddress.Address, ColorList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetColorListLastIndex_FunctionAddress, intPtr, GetColorListLastIndex_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetColorListLastIndex_ColorList_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetColorListLastIndex_ReturnValue_Offset), 0, GetColorListLastIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetColorListItem")]
	public unsafe static FLinearColor GetColorListItem(FGeometryScriptColorList ColorList, int Index, out bool bIsValidIndex)
	{
		if (!GetColorListItem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetColorListItem");
			bIsValidIndex = false;
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetColorListItem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetColorListItem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetColorListItem_ColorList_PropertyAddress.Address, intPtr);
		FGeometryScriptColorList.ToNative(IntPtr.Add(intPtr, GetColorListItem_ColorList_Offset), 0, GetColorListItem_ColorList_PropertyAddress.Address, ColorList);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetColorListItem_Index_Offset), 0, GetColorListItem_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetColorListItem_FunctionAddress, intPtr, GetColorListItem_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetColorListItem_ColorList_PropertyAddress.Address, intPtr);
		bIsValidIndex = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetColorListItem_bIsValidIndex_Offset), 0, GetColorListItem_bIsValidIndex_PropertyAddress.Address);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetColorListItem_ReturnValue_Offset), 0, GetColorListItem_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertVectorListToArray")]
	public unsafe static void ConvertVectorListToArray(FGeometryScriptVectorList VectorList, out List<FVector> VectorArray)
	{
		if (!ConvertVectorListToArray_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertVectorListToArray");
			VectorArray = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertVectorListToArray_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertVectorListToArray_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ConvertVectorListToArray_VectorList_PropertyAddress.Address, intPtr);
		FGeometryScriptVectorList.ToNative(IntPtr.Add(intPtr, ConvertVectorListToArray_VectorList_Offset), 0, ConvertVectorListToArray_VectorList_PropertyAddress.Address, VectorList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertVectorListToArray_FunctionAddress, intPtr, ConvertVectorListToArray_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertVectorListToArray_VectorList_PropertyAddress.Address, intPtr);
		VectorArray = new TArrayCopyMarshaler<FVector>(1, ConvertVectorListToArray_VectorArray_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, ConvertVectorListToArray_VectorArray_Offset));
		NativeReflection.DestroyValue_InContainer(ConvertVectorListToArray_VectorArray_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertUVListToArray")]
	public unsafe static void ConvertUVListToArray(FGeometryScriptUVList UVList, out List<FVector2D> UVArray)
	{
		if (!ConvertUVListToArray_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertUVListToArray");
			UVArray = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertUVListToArray_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertUVListToArray_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ConvertUVListToArray_UVList_PropertyAddress.Address, intPtr);
		FGeometryScriptUVList.ToNative(IntPtr.Add(intPtr, ConvertUVListToArray_UVList_Offset), 0, ConvertUVListToArray_UVList_PropertyAddress.Address, UVList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertUVListToArray_FunctionAddress, intPtr, ConvertUVListToArray_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertUVListToArray_UVList_PropertyAddress.Address, intPtr);
		UVArray = new TArrayCopyMarshaler<FVector2D>(1, ConvertUVListToArray_UVArray_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).FromNative(IntPtr.Add(intPtr, ConvertUVListToArray_UVArray_Offset));
		NativeReflection.DestroyValue_InContainer(ConvertUVListToArray_UVArray_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertTriangleListToArray")]
	public unsafe static void ConvertTriangleListToArray(FGeometryScriptTriangleList TriangleList, out List<FIntVector> TriangleArray)
	{
		if (!ConvertTriangleListToArray_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertTriangleListToArray");
			TriangleArray = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertTriangleListToArray_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertTriangleListToArray_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ConvertTriangleListToArray_TriangleList_PropertyAddress.Address, intPtr);
		FGeometryScriptTriangleList.ToNative(IntPtr.Add(intPtr, ConvertTriangleListToArray_TriangleList_Offset), 0, ConvertTriangleListToArray_TriangleList_PropertyAddress.Address, TriangleList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertTriangleListToArray_FunctionAddress, intPtr, ConvertTriangleListToArray_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertTriangleListToArray_TriangleList_PropertyAddress.Address, intPtr);
		TriangleArray = new TArrayCopyMarshaler<FIntVector>(1, ConvertTriangleListToArray_TriangleArray_PropertyAddress, CachedMarshalingDelegates<FIntVector, BlittableTypeMarshaler<FIntVector>>.FromNative, CachedMarshalingDelegates<FIntVector, BlittableTypeMarshaler<FIntVector>>.ToNative).FromNative(IntPtr.Add(intPtr, ConvertTriangleListToArray_TriangleArray_Offset));
		NativeReflection.DestroyValue_InContainer(ConvertTriangleListToArray_TriangleArray_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertIndexListToArray")]
	public unsafe static void ConvertIndexListToArray(FGeometryScriptIndexList IndexList, out List<int> IndexArray)
	{
		if (!ConvertIndexListToArray_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertIndexListToArray");
			IndexArray = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertIndexListToArray_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertIndexListToArray_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ConvertIndexListToArray_IndexList_PropertyAddress.Address, intPtr);
		FGeometryScriptIndexList.ToNative(IntPtr.Add(intPtr, ConvertIndexListToArray_IndexList_Offset), 0, ConvertIndexListToArray_IndexList_PropertyAddress.Address, IndexList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertIndexListToArray_FunctionAddress, intPtr, ConvertIndexListToArray_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertIndexListToArray_IndexList_PropertyAddress.Address, intPtr);
		IndexArray = new TArrayCopyMarshaler<int>(1, ConvertIndexListToArray_IndexArray_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, ConvertIndexListToArray_IndexArray_Offset));
		NativeReflection.DestroyValue_InContainer(ConvertIndexListToArray_IndexArray_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertColorListToArray")]
	public unsafe static void ConvertColorListToArray(FGeometryScriptColorList ColorList, out List<FLinearColor> ColorArray)
	{
		if (!ConvertColorListToArray_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertColorListToArray");
			ColorArray = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertColorListToArray_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertColorListToArray_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ConvertColorListToArray_ColorList_PropertyAddress.Address, intPtr);
		FGeometryScriptColorList.ToNative(IntPtr.Add(intPtr, ConvertColorListToArray_ColorList_Offset), 0, ConvertColorListToArray_ColorList_PropertyAddress.Address, ColorList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertColorListToArray_FunctionAddress, intPtr, ConvertColorListToArray_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertColorListToArray_ColorList_PropertyAddress.Address, intPtr);
		ColorArray = new TArrayCopyMarshaler<FLinearColor>(1, ConvertColorListToArray_ColorArray_PropertyAddress, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.FromNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.ToNative).FromNative(IntPtr.Add(intPtr, ConvertColorListToArray_ColorArray_Offset));
		NativeReflection.DestroyValue_InContainer(ConvertColorListToArray_ColorArray_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertArrayToVectorList")]
	public unsafe static void ConvertArrayToVectorList(List<FVector> VectorArray, out FGeometryScriptVectorList VectorList)
	{
		if (!ConvertArrayToVectorList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertArrayToVectorList");
			VectorList = default(FGeometryScriptVectorList);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertArrayToVectorList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertArrayToVectorList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, ConvertArrayToVectorList_VectorArray_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, ConvertArrayToVectorList_VectorArray_Offset), VectorArray);
		NativeReflection.InitializeValue_InContainer(ConvertArrayToVectorList_VectorList_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertArrayToVectorList_FunctionAddress, intPtr, ConvertArrayToVectorList_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertArrayToVectorList_VectorArray_PropertyAddress.Address, intPtr);
		VectorList = FGeometryScriptVectorList.FromNative(IntPtr.Add(intPtr, ConvertArrayToVectorList_VectorList_Offset), 0, ConvertArrayToVectorList_VectorList_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ConvertArrayToVectorList_VectorList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertArrayToUVList")]
	public unsafe static void ConvertArrayToUVList(List<FVector2D> UVArray, out FGeometryScriptUVList UVList)
	{
		if (!ConvertArrayToUVList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertArrayToUVList");
			UVList = default(FGeometryScriptUVList);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertArrayToUVList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertArrayToUVList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector2D>(1, ConvertArrayToUVList_UVArray_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(intPtr, ConvertArrayToUVList_UVArray_Offset), UVArray);
		NativeReflection.InitializeValue_InContainer(ConvertArrayToUVList_UVList_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertArrayToUVList_FunctionAddress, intPtr, ConvertArrayToUVList_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertArrayToUVList_UVArray_PropertyAddress.Address, intPtr);
		UVList = FGeometryScriptUVList.FromNative(IntPtr.Add(intPtr, ConvertArrayToUVList_UVList_Offset), 0, ConvertArrayToUVList_UVList_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ConvertArrayToUVList_UVList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertArrayToTriangleList")]
	public unsafe static void ConvertArrayToTriangleList(List<FIntVector> TriangleArray, out FGeometryScriptTriangleList TriangleList)
	{
		if (!ConvertArrayToTriangleList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertArrayToTriangleList");
			TriangleList = default(FGeometryScriptTriangleList);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertArrayToTriangleList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertArrayToTriangleList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FIntVector>(1, ConvertArrayToTriangleList_TriangleArray_PropertyAddress, CachedMarshalingDelegates<FIntVector, BlittableTypeMarshaler<FIntVector>>.FromNative, CachedMarshalingDelegates<FIntVector, BlittableTypeMarshaler<FIntVector>>.ToNative).ToNative(IntPtr.Add(intPtr, ConvertArrayToTriangleList_TriangleArray_Offset), TriangleArray);
		NativeReflection.InitializeValue_InContainer(ConvertArrayToTriangleList_TriangleList_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertArrayToTriangleList_FunctionAddress, intPtr, ConvertArrayToTriangleList_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertArrayToTriangleList_TriangleArray_PropertyAddress.Address, intPtr);
		TriangleList = FGeometryScriptTriangleList.FromNative(IntPtr.Add(intPtr, ConvertArrayToTriangleList_TriangleList_Offset), 0, ConvertArrayToTriangleList_TriangleList_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ConvertArrayToTriangleList_TriangleList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertArrayToIndexList")]
	public unsafe static void ConvertArrayToIndexList(List<int> IndexArray, out FGeometryScriptIndexList IndexList, EGeometryScriptIndexType IndexType = EGeometryScriptIndexType.Any)
	{
		if (!ConvertArrayToIndexList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertArrayToIndexList");
			IndexList = default(FGeometryScriptIndexList);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertArrayToIndexList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertArrayToIndexList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<int>(1, ConvertArrayToIndexList_IndexArray_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, ConvertArrayToIndexList_IndexArray_Offset), IndexArray);
		NativeReflection.InitializeValue_InContainer(ConvertArrayToIndexList_IndexList_PropertyAddress.Address, intPtr);
		EnumMarshaler<EGeometryScriptIndexType>.ToNative(IntPtr.Add(intPtr, ConvertArrayToIndexList_IndexType_Offset), 0, ConvertArrayToIndexList_IndexType_PropertyAddress.Address, IndexType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertArrayToIndexList_FunctionAddress, intPtr, ConvertArrayToIndexList_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertArrayToIndexList_IndexArray_PropertyAddress.Address, intPtr);
		IndexList = FGeometryScriptIndexList.FromNative(IntPtr.Add(intPtr, ConvertArrayToIndexList_IndexList_Offset), 0, ConvertArrayToIndexList_IndexList_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ConvertArrayToIndexList_IndexList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertArrayToColorList")]
	public unsafe static void ConvertArrayToColorList(List<FLinearColor> ColorArray, out FGeometryScriptColorList ColorList)
	{
		if (!ConvertArrayToColorList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertArrayToColorList");
			ColorList = default(FGeometryScriptColorList);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertArrayToColorList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertArrayToColorList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FLinearColor>(1, ConvertArrayToColorList_ColorArray_PropertyAddress, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.FromNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.ToNative).ToNative(IntPtr.Add(intPtr, ConvertArrayToColorList_ColorArray_Offset), ColorArray);
		NativeReflection.InitializeValue_InContainer(ConvertArrayToColorList_ColorList_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertArrayToColorList_FunctionAddress, intPtr, ConvertArrayToColorList_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertArrayToColorList_ColorArray_PropertyAddress.Address, intPtr);
		ColorList = FGeometryScriptColorList.FromNative(IntPtr.Add(intPtr, ConvertArrayToColorList_ColorList_Offset), 0, ConvertArrayToColorList_ColorList_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ConvertArrayToColorList_ColorList_PropertyAddress.Address, intPtr);
	}

	static UGeometryScript_List()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_List)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_List));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions");
		GetVectorListLength_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVectorListLength");
		GetVectorListLength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVectorListLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVectorListLength_VectorList_PropertyAddress, GetVectorListLength_FunctionAddress, "VectorList");
		GetVectorListLength_VectorList_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorListLength_FunctionAddress, "VectorList");
		GetVectorListLength_VectorList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorListLength_FunctionAddress, "VectorList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorListLength_ReturnValue_PropertyAddress, GetVectorListLength_FunctionAddress, "ReturnValue");
		GetVectorListLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorListLength_FunctionAddress, "ReturnValue");
		GetVectorListLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorListLength_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetVectorListLength_IsValid = GetVectorListLength_FunctionAddress != IntPtr.Zero && GetVectorListLength_VectorList_IsValid && GetVectorListLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetVectorListLength", GetVectorListLength_IsValid);
		GetVectorListLastIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVectorListLastIndex");
		GetVectorListLastIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVectorListLastIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVectorListLastIndex_VectorList_PropertyAddress, GetVectorListLastIndex_FunctionAddress, "VectorList");
		GetVectorListLastIndex_VectorList_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorListLastIndex_FunctionAddress, "VectorList");
		GetVectorListLastIndex_VectorList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorListLastIndex_FunctionAddress, "VectorList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorListLastIndex_ReturnValue_PropertyAddress, GetVectorListLastIndex_FunctionAddress, "ReturnValue");
		GetVectorListLastIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorListLastIndex_FunctionAddress, "ReturnValue");
		GetVectorListLastIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorListLastIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetVectorListLastIndex_IsValid = GetVectorListLastIndex_FunctionAddress != IntPtr.Zero && GetVectorListLastIndex_VectorList_IsValid && GetVectorListLastIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetVectorListLastIndex", GetVectorListLastIndex_IsValid);
		GetVectorListItem_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVectorListItem");
		GetVectorListItem_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVectorListItem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVectorListItem_VectorList_PropertyAddress, GetVectorListItem_FunctionAddress, "VectorList");
		GetVectorListItem_VectorList_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorListItem_FunctionAddress, "VectorList");
		GetVectorListItem_VectorList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorListItem_FunctionAddress, "VectorList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorListItem_Index_PropertyAddress, GetVectorListItem_FunctionAddress, "Index");
		GetVectorListItem_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorListItem_FunctionAddress, "Index");
		GetVectorListItem_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorListItem_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorListItem_bIsValidIndex_PropertyAddress, GetVectorListItem_FunctionAddress, "bIsValidIndex");
		GetVectorListItem_bIsValidIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorListItem_FunctionAddress, "bIsValidIndex");
		GetVectorListItem_bIsValidIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorListItem_FunctionAddress, "bIsValidIndex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorListItem_ReturnValue_PropertyAddress, GetVectorListItem_FunctionAddress, "ReturnValue");
		GetVectorListItem_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorListItem_FunctionAddress, "ReturnValue");
		GetVectorListItem_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorListItem_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVectorListItem_IsValid = GetVectorListItem_FunctionAddress != IntPtr.Zero && GetVectorListItem_VectorList_IsValid && GetVectorListItem_Index_IsValid && GetVectorListItem_bIsValidIndex_IsValid && GetVectorListItem_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetVectorListItem", GetVectorListItem_IsValid);
		GetUVListLength_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetUVListLength");
		GetUVListLength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUVListLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUVListLength_UVList_PropertyAddress, GetUVListLength_FunctionAddress, "UVList");
		GetUVListLength_UVList_Offset = NativeReflectionCached.GetPropertyOffset(GetUVListLength_FunctionAddress, "UVList");
		GetUVListLength_UVList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUVListLength_FunctionAddress, "UVList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUVListLength_ReturnValue_PropertyAddress, GetUVListLength_FunctionAddress, "ReturnValue");
		GetUVListLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUVListLength_FunctionAddress, "ReturnValue");
		GetUVListLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUVListLength_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetUVListLength_IsValid = GetUVListLength_FunctionAddress != IntPtr.Zero && GetUVListLength_UVList_IsValid && GetUVListLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetUVListLength", GetUVListLength_IsValid);
		GetUVListLastIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetUVListLastIndex");
		GetUVListLastIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUVListLastIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUVListLastIndex_UVList_PropertyAddress, GetUVListLastIndex_FunctionAddress, "UVList");
		GetUVListLastIndex_UVList_Offset = NativeReflectionCached.GetPropertyOffset(GetUVListLastIndex_FunctionAddress, "UVList");
		GetUVListLastIndex_UVList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUVListLastIndex_FunctionAddress, "UVList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUVListLastIndex_ReturnValue_PropertyAddress, GetUVListLastIndex_FunctionAddress, "ReturnValue");
		GetUVListLastIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUVListLastIndex_FunctionAddress, "ReturnValue");
		GetUVListLastIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUVListLastIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetUVListLastIndex_IsValid = GetUVListLastIndex_FunctionAddress != IntPtr.Zero && GetUVListLastIndex_UVList_IsValid && GetUVListLastIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetUVListLastIndex", GetUVListLastIndex_IsValid);
		GetUVListItem_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetUVListItem");
		GetUVListItem_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUVListItem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUVListItem_UVList_PropertyAddress, GetUVListItem_FunctionAddress, "UVList");
		GetUVListItem_UVList_Offset = NativeReflectionCached.GetPropertyOffset(GetUVListItem_FunctionAddress, "UVList");
		GetUVListItem_UVList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUVListItem_FunctionAddress, "UVList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUVListItem_Index_PropertyAddress, GetUVListItem_FunctionAddress, "Index");
		GetUVListItem_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetUVListItem_FunctionAddress, "Index");
		GetUVListItem_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUVListItem_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUVListItem_bIsValidIndex_PropertyAddress, GetUVListItem_FunctionAddress, "bIsValidIndex");
		GetUVListItem_bIsValidIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetUVListItem_FunctionAddress, "bIsValidIndex");
		GetUVListItem_bIsValidIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUVListItem_FunctionAddress, "bIsValidIndex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUVListItem_ReturnValue_PropertyAddress, GetUVListItem_FunctionAddress, "ReturnValue");
		GetUVListItem_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUVListItem_FunctionAddress, "ReturnValue");
		GetUVListItem_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUVListItem_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetUVListItem_IsValid = GetUVListItem_FunctionAddress != IntPtr.Zero && GetUVListItem_UVList_IsValid && GetUVListItem_Index_IsValid && GetUVListItem_bIsValidIndex_IsValid && GetUVListItem_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetUVListItem", GetUVListItem_IsValid);
		GetTriangleListLength_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTriangleListLength");
		GetTriangleListLength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTriangleListLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleListLength_TriangleList_PropertyAddress, GetTriangleListLength_FunctionAddress, "TriangleList");
		GetTriangleListLength_TriangleList_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleListLength_FunctionAddress, "TriangleList");
		GetTriangleListLength_TriangleList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleListLength_FunctionAddress, "TriangleList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleListLength_ReturnValue_PropertyAddress, GetTriangleListLength_FunctionAddress, "ReturnValue");
		GetTriangleListLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleListLength_FunctionAddress, "ReturnValue");
		GetTriangleListLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleListLength_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTriangleListLength_IsValid = GetTriangleListLength_FunctionAddress != IntPtr.Zero && GetTriangleListLength_TriangleList_IsValid && GetTriangleListLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetTriangleListLength", GetTriangleListLength_IsValid);
		GetTriangleListLastTriangle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTriangleListLastTriangle");
		GetTriangleListLastTriangle_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTriangleListLastTriangle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleListLastTriangle_TriangleList_PropertyAddress, GetTriangleListLastTriangle_FunctionAddress, "TriangleList");
		GetTriangleListLastTriangle_TriangleList_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleListLastTriangle_FunctionAddress, "TriangleList");
		GetTriangleListLastTriangle_TriangleList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleListLastTriangle_FunctionAddress, "TriangleList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleListLastTriangle_ReturnValue_PropertyAddress, GetTriangleListLastTriangle_FunctionAddress, "ReturnValue");
		GetTriangleListLastTriangle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleListLastTriangle_FunctionAddress, "ReturnValue");
		GetTriangleListLastTriangle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleListLastTriangle_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTriangleListLastTriangle_IsValid = GetTriangleListLastTriangle_FunctionAddress != IntPtr.Zero && GetTriangleListLastTriangle_TriangleList_IsValid && GetTriangleListLastTriangle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetTriangleListLastTriangle", GetTriangleListLastTriangle_IsValid);
		GetTriangleListItem_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTriangleListItem");
		GetTriangleListItem_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTriangleListItem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleListItem_TriangleList_PropertyAddress, GetTriangleListItem_FunctionAddress, "TriangleList");
		GetTriangleListItem_TriangleList_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleListItem_FunctionAddress, "TriangleList");
		GetTriangleListItem_TriangleList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleListItem_FunctionAddress, "TriangleList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleListItem_Triangle_PropertyAddress, GetTriangleListItem_FunctionAddress, "Triangle");
		GetTriangleListItem_Triangle_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleListItem_FunctionAddress, "Triangle");
		GetTriangleListItem_Triangle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleListItem_FunctionAddress, "Triangle", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleListItem_bIsValidTriangle_PropertyAddress, GetTriangleListItem_FunctionAddress, "bIsValidTriangle");
		GetTriangleListItem_bIsValidTriangle_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleListItem_FunctionAddress, "bIsValidTriangle");
		GetTriangleListItem_bIsValidTriangle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleListItem_FunctionAddress, "bIsValidTriangle", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleListItem_ReturnValue_PropertyAddress, GetTriangleListItem_FunctionAddress, "ReturnValue");
		GetTriangleListItem_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleListItem_FunctionAddress, "ReturnValue");
		GetTriangleListItem_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleListItem_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTriangleListItem_IsValid = GetTriangleListItem_FunctionAddress != IntPtr.Zero && GetTriangleListItem_TriangleList_IsValid && GetTriangleListItem_Triangle_IsValid && GetTriangleListItem_bIsValidTriangle_IsValid && GetTriangleListItem_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetTriangleListItem", GetTriangleListItem_IsValid);
		GetIndexListLength_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIndexListLength");
		GetIndexListLength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIndexListLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIndexListLength_IndexList_PropertyAddress, GetIndexListLength_FunctionAddress, "IndexList");
		GetIndexListLength_IndexList_Offset = NativeReflectionCached.GetPropertyOffset(GetIndexListLength_FunctionAddress, "IndexList");
		GetIndexListLength_IndexList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIndexListLength_FunctionAddress, "IndexList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIndexListLength_ReturnValue_PropertyAddress, GetIndexListLength_FunctionAddress, "ReturnValue");
		GetIndexListLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIndexListLength_FunctionAddress, "ReturnValue");
		GetIndexListLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIndexListLength_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetIndexListLength_IsValid = GetIndexListLength_FunctionAddress != IntPtr.Zero && GetIndexListLength_IndexList_IsValid && GetIndexListLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetIndexListLength", GetIndexListLength_IsValid);
		GetIndexListLastIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIndexListLastIndex");
		GetIndexListLastIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIndexListLastIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIndexListLastIndex_IndexList_PropertyAddress, GetIndexListLastIndex_FunctionAddress, "IndexList");
		GetIndexListLastIndex_IndexList_Offset = NativeReflectionCached.GetPropertyOffset(GetIndexListLastIndex_FunctionAddress, "IndexList");
		GetIndexListLastIndex_IndexList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIndexListLastIndex_FunctionAddress, "IndexList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIndexListLastIndex_ReturnValue_PropertyAddress, GetIndexListLastIndex_FunctionAddress, "ReturnValue");
		GetIndexListLastIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIndexListLastIndex_FunctionAddress, "ReturnValue");
		GetIndexListLastIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIndexListLastIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetIndexListLastIndex_IsValid = GetIndexListLastIndex_FunctionAddress != IntPtr.Zero && GetIndexListLastIndex_IndexList_IsValid && GetIndexListLastIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetIndexListLastIndex", GetIndexListLastIndex_IsValid);
		GetIndexListItem_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIndexListItem");
		GetIndexListItem_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIndexListItem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIndexListItem_IndexList_PropertyAddress, GetIndexListItem_FunctionAddress, "IndexList");
		GetIndexListItem_IndexList_Offset = NativeReflectionCached.GetPropertyOffset(GetIndexListItem_FunctionAddress, "IndexList");
		GetIndexListItem_IndexList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIndexListItem_FunctionAddress, "IndexList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIndexListItem_Index_PropertyAddress, GetIndexListItem_FunctionAddress, "Index");
		GetIndexListItem_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetIndexListItem_FunctionAddress, "Index");
		GetIndexListItem_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIndexListItem_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIndexListItem_bIsValidIndex_PropertyAddress, GetIndexListItem_FunctionAddress, "bIsValidIndex");
		GetIndexListItem_bIsValidIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetIndexListItem_FunctionAddress, "bIsValidIndex");
		GetIndexListItem_bIsValidIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIndexListItem_FunctionAddress, "bIsValidIndex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIndexListItem_ReturnValue_PropertyAddress, GetIndexListItem_FunctionAddress, "ReturnValue");
		GetIndexListItem_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIndexListItem_FunctionAddress, "ReturnValue");
		GetIndexListItem_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIndexListItem_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetIndexListItem_IsValid = GetIndexListItem_FunctionAddress != IntPtr.Zero && GetIndexListItem_IndexList_IsValid && GetIndexListItem_Index_IsValid && GetIndexListItem_bIsValidIndex_IsValid && GetIndexListItem_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetIndexListItem", GetIndexListItem_IsValid);
		GetColorListLength_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetColorListLength");
		GetColorListLength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetColorListLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetColorListLength_ColorList_PropertyAddress, GetColorListLength_FunctionAddress, "ColorList");
		GetColorListLength_ColorList_Offset = NativeReflectionCached.GetPropertyOffset(GetColorListLength_FunctionAddress, "ColorList");
		GetColorListLength_ColorList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetColorListLength_FunctionAddress, "ColorList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetColorListLength_ReturnValue_PropertyAddress, GetColorListLength_FunctionAddress, "ReturnValue");
		GetColorListLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetColorListLength_FunctionAddress, "ReturnValue");
		GetColorListLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetColorListLength_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetColorListLength_IsValid = GetColorListLength_FunctionAddress != IntPtr.Zero && GetColorListLength_ColorList_IsValid && GetColorListLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetColorListLength", GetColorListLength_IsValid);
		GetColorListLastIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetColorListLastIndex");
		GetColorListLastIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetColorListLastIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetColorListLastIndex_ColorList_PropertyAddress, GetColorListLastIndex_FunctionAddress, "ColorList");
		GetColorListLastIndex_ColorList_Offset = NativeReflectionCached.GetPropertyOffset(GetColorListLastIndex_FunctionAddress, "ColorList");
		GetColorListLastIndex_ColorList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetColorListLastIndex_FunctionAddress, "ColorList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetColorListLastIndex_ReturnValue_PropertyAddress, GetColorListLastIndex_FunctionAddress, "ReturnValue");
		GetColorListLastIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetColorListLastIndex_FunctionAddress, "ReturnValue");
		GetColorListLastIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetColorListLastIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetColorListLastIndex_IsValid = GetColorListLastIndex_FunctionAddress != IntPtr.Zero && GetColorListLastIndex_ColorList_IsValid && GetColorListLastIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetColorListLastIndex", GetColorListLastIndex_IsValid);
		GetColorListItem_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetColorListItem");
		GetColorListItem_ParamsSize = NativeReflection.GetFunctionParamsSize(GetColorListItem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetColorListItem_ColorList_PropertyAddress, GetColorListItem_FunctionAddress, "ColorList");
		GetColorListItem_ColorList_Offset = NativeReflectionCached.GetPropertyOffset(GetColorListItem_FunctionAddress, "ColorList");
		GetColorListItem_ColorList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetColorListItem_FunctionAddress, "ColorList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetColorListItem_Index_PropertyAddress, GetColorListItem_FunctionAddress, "Index");
		GetColorListItem_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetColorListItem_FunctionAddress, "Index");
		GetColorListItem_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetColorListItem_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetColorListItem_bIsValidIndex_PropertyAddress, GetColorListItem_FunctionAddress, "bIsValidIndex");
		GetColorListItem_bIsValidIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetColorListItem_FunctionAddress, "bIsValidIndex");
		GetColorListItem_bIsValidIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetColorListItem_FunctionAddress, "bIsValidIndex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetColorListItem_ReturnValue_PropertyAddress, GetColorListItem_FunctionAddress, "ReturnValue");
		GetColorListItem_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetColorListItem_FunctionAddress, "ReturnValue");
		GetColorListItem_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetColorListItem_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetColorListItem_IsValid = GetColorListItem_FunctionAddress != IntPtr.Zero && GetColorListItem_ColorList_IsValid && GetColorListItem_Index_IsValid && GetColorListItem_bIsValidIndex_IsValid && GetColorListItem_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:GetColorListItem", GetColorListItem_IsValid);
		ConvertVectorListToArray_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertVectorListToArray");
		ConvertVectorListToArray_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertVectorListToArray_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertVectorListToArray_VectorList_PropertyAddress, ConvertVectorListToArray_FunctionAddress, "VectorList");
		ConvertVectorListToArray_VectorList_Offset = NativeReflectionCached.GetPropertyOffset(ConvertVectorListToArray_FunctionAddress, "VectorList");
		ConvertVectorListToArray_VectorList_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertVectorListToArray_FunctionAddress, "VectorList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertVectorListToArray_VectorArray_PropertyAddress, ConvertVectorListToArray_FunctionAddress, "VectorArray");
		ConvertVectorListToArray_VectorArray_Offset = NativeReflectionCached.GetPropertyOffset(ConvertVectorListToArray_FunctionAddress, "VectorArray");
		ConvertVectorListToArray_VectorArray_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertVectorListToArray_FunctionAddress, "VectorArray", Classes.FArrayProperty);
		ConvertVectorListToArray_IsValid = ConvertVectorListToArray_FunctionAddress != IntPtr.Zero && ConvertVectorListToArray_VectorList_IsValid && ConvertVectorListToArray_VectorArray_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertVectorListToArray", ConvertVectorListToArray_IsValid);
		ConvertUVListToArray_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertUVListToArray");
		ConvertUVListToArray_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertUVListToArray_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertUVListToArray_UVList_PropertyAddress, ConvertUVListToArray_FunctionAddress, "UVList");
		ConvertUVListToArray_UVList_Offset = NativeReflectionCached.GetPropertyOffset(ConvertUVListToArray_FunctionAddress, "UVList");
		ConvertUVListToArray_UVList_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertUVListToArray_FunctionAddress, "UVList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertUVListToArray_UVArray_PropertyAddress, ConvertUVListToArray_FunctionAddress, "UVArray");
		ConvertUVListToArray_UVArray_Offset = NativeReflectionCached.GetPropertyOffset(ConvertUVListToArray_FunctionAddress, "UVArray");
		ConvertUVListToArray_UVArray_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertUVListToArray_FunctionAddress, "UVArray", Classes.FArrayProperty);
		ConvertUVListToArray_IsValid = ConvertUVListToArray_FunctionAddress != IntPtr.Zero && ConvertUVListToArray_UVList_IsValid && ConvertUVListToArray_UVArray_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertUVListToArray", ConvertUVListToArray_IsValid);
		ConvertTriangleListToArray_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertTriangleListToArray");
		ConvertTriangleListToArray_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertTriangleListToArray_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertTriangleListToArray_TriangleList_PropertyAddress, ConvertTriangleListToArray_FunctionAddress, "TriangleList");
		ConvertTriangleListToArray_TriangleList_Offset = NativeReflectionCached.GetPropertyOffset(ConvertTriangleListToArray_FunctionAddress, "TriangleList");
		ConvertTriangleListToArray_TriangleList_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertTriangleListToArray_FunctionAddress, "TriangleList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertTriangleListToArray_TriangleArray_PropertyAddress, ConvertTriangleListToArray_FunctionAddress, "TriangleArray");
		ConvertTriangleListToArray_TriangleArray_Offset = NativeReflectionCached.GetPropertyOffset(ConvertTriangleListToArray_FunctionAddress, "TriangleArray");
		ConvertTriangleListToArray_TriangleArray_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertTriangleListToArray_FunctionAddress, "TriangleArray", Classes.FArrayProperty);
		ConvertTriangleListToArray_IsValid = ConvertTriangleListToArray_FunctionAddress != IntPtr.Zero && ConvertTriangleListToArray_TriangleList_IsValid && ConvertTriangleListToArray_TriangleArray_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertTriangleListToArray", ConvertTriangleListToArray_IsValid);
		ConvertIndexListToArray_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertIndexListToArray");
		ConvertIndexListToArray_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertIndexListToArray_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertIndexListToArray_IndexList_PropertyAddress, ConvertIndexListToArray_FunctionAddress, "IndexList");
		ConvertIndexListToArray_IndexList_Offset = NativeReflectionCached.GetPropertyOffset(ConvertIndexListToArray_FunctionAddress, "IndexList");
		ConvertIndexListToArray_IndexList_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertIndexListToArray_FunctionAddress, "IndexList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertIndexListToArray_IndexArray_PropertyAddress, ConvertIndexListToArray_FunctionAddress, "IndexArray");
		ConvertIndexListToArray_IndexArray_Offset = NativeReflectionCached.GetPropertyOffset(ConvertIndexListToArray_FunctionAddress, "IndexArray");
		ConvertIndexListToArray_IndexArray_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertIndexListToArray_FunctionAddress, "IndexArray", Classes.FArrayProperty);
		ConvertIndexListToArray_IsValid = ConvertIndexListToArray_FunctionAddress != IntPtr.Zero && ConvertIndexListToArray_IndexList_IsValid && ConvertIndexListToArray_IndexArray_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertIndexListToArray", ConvertIndexListToArray_IsValid);
		ConvertColorListToArray_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertColorListToArray");
		ConvertColorListToArray_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertColorListToArray_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertColorListToArray_ColorList_PropertyAddress, ConvertColorListToArray_FunctionAddress, "ColorList");
		ConvertColorListToArray_ColorList_Offset = NativeReflectionCached.GetPropertyOffset(ConvertColorListToArray_FunctionAddress, "ColorList");
		ConvertColorListToArray_ColorList_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertColorListToArray_FunctionAddress, "ColorList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertColorListToArray_ColorArray_PropertyAddress, ConvertColorListToArray_FunctionAddress, "ColorArray");
		ConvertColorListToArray_ColorArray_Offset = NativeReflectionCached.GetPropertyOffset(ConvertColorListToArray_FunctionAddress, "ColorArray");
		ConvertColorListToArray_ColorArray_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertColorListToArray_FunctionAddress, "ColorArray", Classes.FArrayProperty);
		ConvertColorListToArray_IsValid = ConvertColorListToArray_FunctionAddress != IntPtr.Zero && ConvertColorListToArray_ColorList_IsValid && ConvertColorListToArray_ColorArray_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertColorListToArray", ConvertColorListToArray_IsValid);
		ConvertArrayToVectorList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertArrayToVectorList");
		ConvertArrayToVectorList_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertArrayToVectorList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertArrayToVectorList_VectorArray_PropertyAddress, ConvertArrayToVectorList_FunctionAddress, "VectorArray");
		ConvertArrayToVectorList_VectorArray_Offset = NativeReflectionCached.GetPropertyOffset(ConvertArrayToVectorList_FunctionAddress, "VectorArray");
		ConvertArrayToVectorList_VectorArray_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertArrayToVectorList_FunctionAddress, "VectorArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertArrayToVectorList_VectorList_PropertyAddress, ConvertArrayToVectorList_FunctionAddress, "VectorList");
		ConvertArrayToVectorList_VectorList_Offset = NativeReflectionCached.GetPropertyOffset(ConvertArrayToVectorList_FunctionAddress, "VectorList");
		ConvertArrayToVectorList_VectorList_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertArrayToVectorList_FunctionAddress, "VectorList", Classes.FStructProperty);
		ConvertArrayToVectorList_IsValid = ConvertArrayToVectorList_FunctionAddress != IntPtr.Zero && ConvertArrayToVectorList_VectorArray_IsValid && ConvertArrayToVectorList_VectorList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertArrayToVectorList", ConvertArrayToVectorList_IsValid);
		ConvertArrayToUVList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertArrayToUVList");
		ConvertArrayToUVList_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertArrayToUVList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertArrayToUVList_UVArray_PropertyAddress, ConvertArrayToUVList_FunctionAddress, "UVArray");
		ConvertArrayToUVList_UVArray_Offset = NativeReflectionCached.GetPropertyOffset(ConvertArrayToUVList_FunctionAddress, "UVArray");
		ConvertArrayToUVList_UVArray_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertArrayToUVList_FunctionAddress, "UVArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertArrayToUVList_UVList_PropertyAddress, ConvertArrayToUVList_FunctionAddress, "UVList");
		ConvertArrayToUVList_UVList_Offset = NativeReflectionCached.GetPropertyOffset(ConvertArrayToUVList_FunctionAddress, "UVList");
		ConvertArrayToUVList_UVList_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertArrayToUVList_FunctionAddress, "UVList", Classes.FStructProperty);
		ConvertArrayToUVList_IsValid = ConvertArrayToUVList_FunctionAddress != IntPtr.Zero && ConvertArrayToUVList_UVArray_IsValid && ConvertArrayToUVList_UVList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertArrayToUVList", ConvertArrayToUVList_IsValid);
		ConvertArrayToTriangleList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertArrayToTriangleList");
		ConvertArrayToTriangleList_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertArrayToTriangleList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertArrayToTriangleList_TriangleArray_PropertyAddress, ConvertArrayToTriangleList_FunctionAddress, "TriangleArray");
		ConvertArrayToTriangleList_TriangleArray_Offset = NativeReflectionCached.GetPropertyOffset(ConvertArrayToTriangleList_FunctionAddress, "TriangleArray");
		ConvertArrayToTriangleList_TriangleArray_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertArrayToTriangleList_FunctionAddress, "TriangleArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertArrayToTriangleList_TriangleList_PropertyAddress, ConvertArrayToTriangleList_FunctionAddress, "TriangleList");
		ConvertArrayToTriangleList_TriangleList_Offset = NativeReflectionCached.GetPropertyOffset(ConvertArrayToTriangleList_FunctionAddress, "TriangleList");
		ConvertArrayToTriangleList_TriangleList_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertArrayToTriangleList_FunctionAddress, "TriangleList", Classes.FStructProperty);
		ConvertArrayToTriangleList_IsValid = ConvertArrayToTriangleList_FunctionAddress != IntPtr.Zero && ConvertArrayToTriangleList_TriangleArray_IsValid && ConvertArrayToTriangleList_TriangleList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertArrayToTriangleList", ConvertArrayToTriangleList_IsValid);
		ConvertArrayToIndexList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertArrayToIndexList");
		ConvertArrayToIndexList_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertArrayToIndexList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertArrayToIndexList_IndexArray_PropertyAddress, ConvertArrayToIndexList_FunctionAddress, "IndexArray");
		ConvertArrayToIndexList_IndexArray_Offset = NativeReflectionCached.GetPropertyOffset(ConvertArrayToIndexList_FunctionAddress, "IndexArray");
		ConvertArrayToIndexList_IndexArray_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertArrayToIndexList_FunctionAddress, "IndexArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertArrayToIndexList_IndexList_PropertyAddress, ConvertArrayToIndexList_FunctionAddress, "IndexList");
		ConvertArrayToIndexList_IndexList_Offset = NativeReflectionCached.GetPropertyOffset(ConvertArrayToIndexList_FunctionAddress, "IndexList");
		ConvertArrayToIndexList_IndexList_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertArrayToIndexList_FunctionAddress, "IndexList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertArrayToIndexList_IndexType_PropertyAddress, ConvertArrayToIndexList_FunctionAddress, "IndexType");
		ConvertArrayToIndexList_IndexType_Offset = NativeReflectionCached.GetPropertyOffset(ConvertArrayToIndexList_FunctionAddress, "IndexType");
		ConvertArrayToIndexList_IndexType_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertArrayToIndexList_FunctionAddress, "IndexType", Classes.FEnumProperty);
		ConvertArrayToIndexList_IsValid = ConvertArrayToIndexList_FunctionAddress != IntPtr.Zero && ConvertArrayToIndexList_IndexArray_IsValid && ConvertArrayToIndexList_IndexList_IsValid && ConvertArrayToIndexList_IndexType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertArrayToIndexList", ConvertArrayToIndexList_IsValid);
		ConvertArrayToColorList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertArrayToColorList");
		ConvertArrayToColorList_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertArrayToColorList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertArrayToColorList_ColorArray_PropertyAddress, ConvertArrayToColorList_FunctionAddress, "ColorArray");
		ConvertArrayToColorList_ColorArray_Offset = NativeReflectionCached.GetPropertyOffset(ConvertArrayToColorList_FunctionAddress, "ColorArray");
		ConvertArrayToColorList_ColorArray_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertArrayToColorList_FunctionAddress, "ColorArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertArrayToColorList_ColorList_PropertyAddress, ConvertArrayToColorList_FunctionAddress, "ColorList");
		ConvertArrayToColorList_ColorList_Offset = NativeReflectionCached.GetPropertyOffset(ConvertArrayToColorList_FunctionAddress, "ColorList");
		ConvertArrayToColorList_ColorList_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertArrayToColorList_FunctionAddress, "ColorList", Classes.FStructProperty);
		ConvertArrayToColorList_IsValid = ConvertArrayToColorList_FunctionAddress != IntPtr.Zero && ConvertArrayToColorList_ColorArray_IsValid && ConvertArrayToColorList_ColorList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ListUtilityFunctions:ConvertArrayToColorList", ConvertArrayToColorList_IsValid);
	}
}
