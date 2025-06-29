using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

public static class UGeometryScript_List_CsExtensions
{
	public static int GetVectorListLength(this FGeometryScriptVectorList VectorList)
	{
		return UGeometryScript_List.GetVectorListLength(VectorList);
	}

	public static int GetVectorListLastIndex(this FGeometryScriptVectorList VectorList)
	{
		return UGeometryScript_List.GetVectorListLastIndex(VectorList);
	}

	public static FVector GetVectorListItem(this FGeometryScriptVectorList VectorList, int Index, out bool bIsValidIndex)
	{
		return UGeometryScript_List.GetVectorListItem(VectorList, Index, out bIsValidIndex);
	}

	public static int GetUVListLength(this FGeometryScriptUVList UVList)
	{
		return UGeometryScript_List.GetUVListLength(UVList);
	}

	public static int GetUVListLastIndex(this FGeometryScriptUVList UVList)
	{
		return UGeometryScript_List.GetUVListLastIndex(UVList);
	}

	public static FVector2D GetUVListItem(this FGeometryScriptUVList UVList, int Index, out bool bIsValidIndex)
	{
		return UGeometryScript_List.GetUVListItem(UVList, Index, out bIsValidIndex);
	}

	public static int GetTriangleListLength(this FGeometryScriptTriangleList TriangleList)
	{
		return UGeometryScript_List.GetTriangleListLength(TriangleList);
	}

	public static int GetTriangleListLastTriangle(this FGeometryScriptTriangleList TriangleList)
	{
		return UGeometryScript_List.GetTriangleListLastTriangle(TriangleList);
	}

	public static FIntVector GetTriangleListItem(this FGeometryScriptTriangleList TriangleList, int Triangle, out bool bIsValidTriangle)
	{
		return UGeometryScript_List.GetTriangleListItem(TriangleList, Triangle, out bIsValidTriangle);
	}

	public static int GetIndexListLength(this FGeometryScriptIndexList IndexList)
	{
		return UGeometryScript_List.GetIndexListLength(IndexList);
	}

	public static int GetIndexListLastIndex(this FGeometryScriptIndexList IndexList)
	{
		return UGeometryScript_List.GetIndexListLastIndex(IndexList);
	}

	public static int GetIndexListItem(this FGeometryScriptIndexList IndexList, int Index, out bool bIsValidIndex)
	{
		return UGeometryScript_List.GetIndexListItem(IndexList, Index, out bIsValidIndex);
	}

	public static int GetColorListLength(this FGeometryScriptColorList ColorList)
	{
		return UGeometryScript_List.GetColorListLength(ColorList);
	}

	public static int GetColorListLastIndex(this FGeometryScriptColorList ColorList)
	{
		return UGeometryScript_List.GetColorListLastIndex(ColorList);
	}

	public static FLinearColor GetColorListItem(this FGeometryScriptColorList ColorList, int Index, out bool bIsValidIndex)
	{
		return UGeometryScript_List.GetColorListItem(ColorList, Index, out bIsValidIndex);
	}

	public static void ConvertVectorListToArray(this FGeometryScriptVectorList VectorList, out List<FVector> VectorArray)
	{
		UGeometryScript_List.ConvertVectorListToArray(VectorList, out VectorArray);
	}

	public static void ConvertUVListToArray(this FGeometryScriptUVList UVList, out List<FVector2D> UVArray)
	{
		UGeometryScript_List.ConvertUVListToArray(UVList, out UVArray);
	}

	public static void ConvertTriangleListToArray(this FGeometryScriptTriangleList TriangleList, out List<FIntVector> TriangleArray)
	{
		UGeometryScript_List.ConvertTriangleListToArray(TriangleList, out TriangleArray);
	}

	public static void ConvertIndexListToArray(this FGeometryScriptIndexList IndexList, out List<int> IndexArray)
	{
		UGeometryScript_List.ConvertIndexListToArray(IndexList, out IndexArray);
	}

	public static void ConvertColorListToArray(this FGeometryScriptColorList ColorList, out List<FLinearColor> ColorArray)
	{
		UGeometryScript_List.ConvertColorListToArray(ColorList, out ColorArray);
	}
}
