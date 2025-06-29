using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ProceduralMeshComponent;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary", "ProceduralMeshComponent", UnrealModuleType.EnginePlugin)]
public class UProceduralMeshLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SliceProceduralMesh_IsValid;

	private static IntPtr SliceProceduralMesh_FunctionAddress;

	private static int SliceProceduralMesh_ParamsSize;

	private static bool SliceProceduralMesh_InProcMesh_IsValid;

	private static FFieldAddress SliceProceduralMesh_InProcMesh_PropertyAddress;

	private static int SliceProceduralMesh_InProcMesh_Offset;

	private static bool SliceProceduralMesh_PlanePosition_IsValid;

	private static FFieldAddress SliceProceduralMesh_PlanePosition_PropertyAddress;

	private static int SliceProceduralMesh_PlanePosition_Offset;

	private static bool SliceProceduralMesh_PlaneNormal_IsValid;

	private static FFieldAddress SliceProceduralMesh_PlaneNormal_PropertyAddress;

	private static int SliceProceduralMesh_PlaneNormal_Offset;

	private static bool SliceProceduralMesh_bCreateOtherHalf_IsValid;

	private static FFieldAddress SliceProceduralMesh_bCreateOtherHalf_PropertyAddress;

	private static int SliceProceduralMesh_bCreateOtherHalf_Offset;

	private static bool SliceProceduralMesh_OutOtherHalfProcMesh_IsValid;

	private static FFieldAddress SliceProceduralMesh_OutOtherHalfProcMesh_PropertyAddress;

	private static int SliceProceduralMesh_OutOtherHalfProcMesh_Offset;

	private static bool SliceProceduralMesh_CapOption_IsValid;

	private static FFieldAddress SliceProceduralMesh_CapOption_PropertyAddress;

	private static int SliceProceduralMesh_CapOption_Offset;

	private static bool SliceProceduralMesh_CapMaterial_IsValid;

	private static FFieldAddress SliceProceduralMesh_CapMaterial_PropertyAddress;

	private static int SliceProceduralMesh_CapMaterial_Offset;

	private static bool GetSectionFromStaticMesh_IsValid;

	private static IntPtr GetSectionFromStaticMesh_FunctionAddress;

	private static int GetSectionFromStaticMesh_ParamsSize;

	private static bool GetSectionFromStaticMesh_InMesh_IsValid;

	private static FFieldAddress GetSectionFromStaticMesh_InMesh_PropertyAddress;

	private static int GetSectionFromStaticMesh_InMesh_Offset;

	private static bool GetSectionFromStaticMesh_LODIndex_IsValid;

	private static FFieldAddress GetSectionFromStaticMesh_LODIndex_PropertyAddress;

	private static int GetSectionFromStaticMesh_LODIndex_Offset;

	private static bool GetSectionFromStaticMesh_SectionIndex_IsValid;

	private static FFieldAddress GetSectionFromStaticMesh_SectionIndex_PropertyAddress;

	private static int GetSectionFromStaticMesh_SectionIndex_Offset;

	private static bool GetSectionFromStaticMesh_Vertices_IsValid;

	private static FFieldAddress GetSectionFromStaticMesh_Vertices_PropertyAddress;

	private static int GetSectionFromStaticMesh_Vertices_Offset;

	private static bool GetSectionFromStaticMesh_Triangles_IsValid;

	private static FFieldAddress GetSectionFromStaticMesh_Triangles_PropertyAddress;

	private static int GetSectionFromStaticMesh_Triangles_Offset;

	private static bool GetSectionFromStaticMesh_Normals_IsValid;

	private static FFieldAddress GetSectionFromStaticMesh_Normals_PropertyAddress;

	private static int GetSectionFromStaticMesh_Normals_Offset;

	private static bool GetSectionFromStaticMesh_UVs_IsValid;

	private static FFieldAddress GetSectionFromStaticMesh_UVs_PropertyAddress;

	private static int GetSectionFromStaticMesh_UVs_Offset;

	private static bool GetSectionFromStaticMesh_Tangents_IsValid;

	private static FFieldAddress GetSectionFromStaticMesh_Tangents_PropertyAddress;

	private static int GetSectionFromStaticMesh_Tangents_Offset;

	private static bool GetSectionFromProceduralMesh_IsValid;

	private static IntPtr GetSectionFromProceduralMesh_FunctionAddress;

	private static int GetSectionFromProceduralMesh_ParamsSize;

	private static bool GetSectionFromProceduralMesh_InProcMesh_IsValid;

	private static FFieldAddress GetSectionFromProceduralMesh_InProcMesh_PropertyAddress;

	private static int GetSectionFromProceduralMesh_InProcMesh_Offset;

	private static bool GetSectionFromProceduralMesh_SectionIndex_IsValid;

	private static FFieldAddress GetSectionFromProceduralMesh_SectionIndex_PropertyAddress;

	private static int GetSectionFromProceduralMesh_SectionIndex_Offset;

	private static bool GetSectionFromProceduralMesh_Vertices_IsValid;

	private static FFieldAddress GetSectionFromProceduralMesh_Vertices_PropertyAddress;

	private static int GetSectionFromProceduralMesh_Vertices_Offset;

	private static bool GetSectionFromProceduralMesh_Triangles_IsValid;

	private static FFieldAddress GetSectionFromProceduralMesh_Triangles_PropertyAddress;

	private static int GetSectionFromProceduralMesh_Triangles_Offset;

	private static bool GetSectionFromProceduralMesh_Normals_IsValid;

	private static FFieldAddress GetSectionFromProceduralMesh_Normals_PropertyAddress;

	private static int GetSectionFromProceduralMesh_Normals_Offset;

	private static bool GetSectionFromProceduralMesh_UVs_IsValid;

	private static FFieldAddress GetSectionFromProceduralMesh_UVs_PropertyAddress;

	private static int GetSectionFromProceduralMesh_UVs_Offset;

	private static bool GetSectionFromProceduralMesh_Tangents_IsValid;

	private static FFieldAddress GetSectionFromProceduralMesh_Tangents_PropertyAddress;

	private static int GetSectionFromProceduralMesh_Tangents_Offset;

	private static bool GenerateBoxMesh_IsValid;

	private static IntPtr GenerateBoxMesh_FunctionAddress;

	private static int GenerateBoxMesh_ParamsSize;

	private static bool GenerateBoxMesh_BoxRadius_IsValid;

	private static FFieldAddress GenerateBoxMesh_BoxRadius_PropertyAddress;

	private static int GenerateBoxMesh_BoxRadius_Offset;

	private static bool GenerateBoxMesh_Vertices_IsValid;

	private static FFieldAddress GenerateBoxMesh_Vertices_PropertyAddress;

	private static int GenerateBoxMesh_Vertices_Offset;

	private static bool GenerateBoxMesh_Triangles_IsValid;

	private static FFieldAddress GenerateBoxMesh_Triangles_PropertyAddress;

	private static int GenerateBoxMesh_Triangles_Offset;

	private static bool GenerateBoxMesh_Normals_IsValid;

	private static FFieldAddress GenerateBoxMesh_Normals_PropertyAddress;

	private static int GenerateBoxMesh_Normals_Offset;

	private static bool GenerateBoxMesh_UVs_IsValid;

	private static FFieldAddress GenerateBoxMesh_UVs_PropertyAddress;

	private static int GenerateBoxMesh_UVs_Offset;

	private static bool GenerateBoxMesh_Tangents_IsValid;

	private static FFieldAddress GenerateBoxMesh_Tangents_PropertyAddress;

	private static int GenerateBoxMesh_Tangents_Offset;

	private static bool CreateGridMeshWelded_IsValid;

	private static IntPtr CreateGridMeshWelded_FunctionAddress;

	private static int CreateGridMeshWelded_ParamsSize;

	private static bool CreateGridMeshWelded_NumX_IsValid;

	private static FFieldAddress CreateGridMeshWelded_NumX_PropertyAddress;

	private static int CreateGridMeshWelded_NumX_Offset;

	private static bool CreateGridMeshWelded_NumY_IsValid;

	private static FFieldAddress CreateGridMeshWelded_NumY_PropertyAddress;

	private static int CreateGridMeshWelded_NumY_Offset;

	private static bool CreateGridMeshWelded_Triangles_IsValid;

	private static FFieldAddress CreateGridMeshWelded_Triangles_PropertyAddress;

	private static int CreateGridMeshWelded_Triangles_Offset;

	private static bool CreateGridMeshWelded_Vertices_IsValid;

	private static FFieldAddress CreateGridMeshWelded_Vertices_PropertyAddress;

	private static int CreateGridMeshWelded_Vertices_Offset;

	private static bool CreateGridMeshWelded_UVs_IsValid;

	private static FFieldAddress CreateGridMeshWelded_UVs_PropertyAddress;

	private static int CreateGridMeshWelded_UVs_Offset;

	private static bool CreateGridMeshWelded_GridSpacing_IsValid;

	private static FFieldAddress CreateGridMeshWelded_GridSpacing_PropertyAddress;

	private static int CreateGridMeshWelded_GridSpacing_Offset;

	private static bool CreateGridMeshTriangles_IsValid;

	private static IntPtr CreateGridMeshTriangles_FunctionAddress;

	private static int CreateGridMeshTriangles_ParamsSize;

	private static bool CreateGridMeshTriangles_NumX_IsValid;

	private static FFieldAddress CreateGridMeshTriangles_NumX_PropertyAddress;

	private static int CreateGridMeshTriangles_NumX_Offset;

	private static bool CreateGridMeshTriangles_NumY_IsValid;

	private static FFieldAddress CreateGridMeshTriangles_NumY_PropertyAddress;

	private static int CreateGridMeshTriangles_NumY_Offset;

	private static bool CreateGridMeshTriangles_bWinding_IsValid;

	private static FFieldAddress CreateGridMeshTriangles_bWinding_PropertyAddress;

	private static int CreateGridMeshTriangles_bWinding_Offset;

	private static bool CreateGridMeshTriangles_Triangles_IsValid;

	private static FFieldAddress CreateGridMeshTriangles_Triangles_PropertyAddress;

	private static int CreateGridMeshTriangles_Triangles_Offset;

	private static bool CreateGridMeshSplit_IsValid;

	private static IntPtr CreateGridMeshSplit_FunctionAddress;

	private static int CreateGridMeshSplit_ParamsSize;

	private static bool CreateGridMeshSplit_NumX_IsValid;

	private static FFieldAddress CreateGridMeshSplit_NumX_PropertyAddress;

	private static int CreateGridMeshSplit_NumX_Offset;

	private static bool CreateGridMeshSplit_NumY_IsValid;

	private static FFieldAddress CreateGridMeshSplit_NumY_PropertyAddress;

	private static int CreateGridMeshSplit_NumY_Offset;

	private static bool CreateGridMeshSplit_Triangles_IsValid;

	private static FFieldAddress CreateGridMeshSplit_Triangles_PropertyAddress;

	private static int CreateGridMeshSplit_Triangles_Offset;

	private static bool CreateGridMeshSplit_Vertices_IsValid;

	private static FFieldAddress CreateGridMeshSplit_Vertices_PropertyAddress;

	private static int CreateGridMeshSplit_Vertices_Offset;

	private static bool CreateGridMeshSplit_UVs_IsValid;

	private static FFieldAddress CreateGridMeshSplit_UVs_PropertyAddress;

	private static int CreateGridMeshSplit_UVs_Offset;

	private static bool CreateGridMeshSplit_UV1s_IsValid;

	private static FFieldAddress CreateGridMeshSplit_UV1s_PropertyAddress;

	private static int CreateGridMeshSplit_UV1s_Offset;

	private static bool CreateGridMeshSplit_GridSpacing_IsValid;

	private static FFieldAddress CreateGridMeshSplit_GridSpacing_PropertyAddress;

	private static int CreateGridMeshSplit_GridSpacing_Offset;

	private static bool CopyProceduralMeshFromStaticMeshComponent_IsValid;

	private static IntPtr CopyProceduralMeshFromStaticMeshComponent_FunctionAddress;

	private static int CopyProceduralMeshFromStaticMeshComponent_ParamsSize;

	private static bool CopyProceduralMeshFromStaticMeshComponent_StaticMeshComponent_IsValid;

	private static FFieldAddress CopyProceduralMeshFromStaticMeshComponent_StaticMeshComponent_PropertyAddress;

	private static int CopyProceduralMeshFromStaticMeshComponent_StaticMeshComponent_Offset;

	private static bool CopyProceduralMeshFromStaticMeshComponent_LODIndex_IsValid;

	private static FFieldAddress CopyProceduralMeshFromStaticMeshComponent_LODIndex_PropertyAddress;

	private static int CopyProceduralMeshFromStaticMeshComponent_LODIndex_Offset;

	private static bool CopyProceduralMeshFromStaticMeshComponent_ProcMeshComponent_IsValid;

	private static FFieldAddress CopyProceduralMeshFromStaticMeshComponent_ProcMeshComponent_PropertyAddress;

	private static int CopyProceduralMeshFromStaticMeshComponent_ProcMeshComponent_Offset;

	private static bool CopyProceduralMeshFromStaticMeshComponent_bCreateCollision_IsValid;

	private static FFieldAddress CopyProceduralMeshFromStaticMeshComponent_bCreateCollision_PropertyAddress;

	private static int CopyProceduralMeshFromStaticMeshComponent_bCreateCollision_Offset;

	private static bool ConvertQuadToTriangles_IsValid;

	private static IntPtr ConvertQuadToTriangles_FunctionAddress;

	private static int ConvertQuadToTriangles_ParamsSize;

	private static bool ConvertQuadToTriangles_Triangles_IsValid;

	private static FFieldAddress ConvertQuadToTriangles_Triangles_PropertyAddress;

	private static int ConvertQuadToTriangles_Triangles_Offset;

	private static bool ConvertQuadToTriangles_Vert0_IsValid;

	private static FFieldAddress ConvertQuadToTriangles_Vert0_PropertyAddress;

	private static int ConvertQuadToTriangles_Vert0_Offset;

	private static bool ConvertQuadToTriangles_Vert1_IsValid;

	private static FFieldAddress ConvertQuadToTriangles_Vert1_PropertyAddress;

	private static int ConvertQuadToTriangles_Vert1_Offset;

	private static bool ConvertQuadToTriangles_Vert2_IsValid;

	private static FFieldAddress ConvertQuadToTriangles_Vert2_PropertyAddress;

	private static int ConvertQuadToTriangles_Vert2_Offset;

	private static bool ConvertQuadToTriangles_Vert3_IsValid;

	private static FFieldAddress ConvertQuadToTriangles_Vert3_PropertyAddress;

	private static int ConvertQuadToTriangles_Vert3_Offset;

	private static bool CalculateTangentsForMesh_IsValid;

	private static IntPtr CalculateTangentsForMesh_FunctionAddress;

	private static int CalculateTangentsForMesh_ParamsSize;

	private static bool CalculateTangentsForMesh_Vertices_IsValid;

	private static FFieldAddress CalculateTangentsForMesh_Vertices_PropertyAddress;

	private static int CalculateTangentsForMesh_Vertices_Offset;

	private static bool CalculateTangentsForMesh_Triangles_IsValid;

	private static FFieldAddress CalculateTangentsForMesh_Triangles_PropertyAddress;

	private static int CalculateTangentsForMesh_Triangles_Offset;

	private static bool CalculateTangentsForMesh_UVs_IsValid;

	private static FFieldAddress CalculateTangentsForMesh_UVs_PropertyAddress;

	private static int CalculateTangentsForMesh_UVs_Offset;

	private static bool CalculateTangentsForMesh_Normals_IsValid;

	private static FFieldAddress CalculateTangentsForMesh_Normals_PropertyAddress;

	private static int CalculateTangentsForMesh_Normals_Offset;

	private static bool CalculateTangentsForMesh_Tangents_IsValid;

	private static FFieldAddress CalculateTangentsForMesh_Tangents_PropertyAddress;

	private static int CalculateTangentsForMesh_Tangents_Offset;

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:SliceProceduralMesh")]
	public unsafe static void SliceProceduralMesh(UProceduralMeshComponent InProcMesh, FVector PlanePosition, FVector PlaneNormal, bool bCreateOtherHalf, out UProceduralMeshComponent OutOtherHalfProcMesh, EProcMeshSliceCapOption CapOption, UMaterialInterface CapMaterial)
	{
		if (!SliceProceduralMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:SliceProceduralMesh");
			OutOtherHalfProcMesh = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SliceProceduralMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SliceProceduralMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UProceduralMeshComponent>.ToNative(IntPtr.Add(intPtr, SliceProceduralMesh_InProcMesh_Offset), 0, SliceProceduralMesh_InProcMesh_PropertyAddress.Address, InProcMesh);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SliceProceduralMesh_PlanePosition_Offset), 0, SliceProceduralMesh_PlanePosition_PropertyAddress.Address, PlanePosition);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SliceProceduralMesh_PlaneNormal_Offset), 0, SliceProceduralMesh_PlaneNormal_PropertyAddress.Address, PlaneNormal);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SliceProceduralMesh_bCreateOtherHalf_Offset), 0, SliceProceduralMesh_bCreateOtherHalf_PropertyAddress.Address, bCreateOtherHalf);
		EnumMarshaler<EProcMeshSliceCapOption>.ToNative(IntPtr.Add(intPtr, SliceProceduralMesh_CapOption_Offset), 0, SliceProceduralMesh_CapOption_PropertyAddress.Address, CapOption);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SliceProceduralMesh_CapMaterial_Offset), 0, SliceProceduralMesh_CapMaterial_PropertyAddress.Address, CapMaterial);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SliceProceduralMesh_FunctionAddress, intPtr, SliceProceduralMesh_ParamsSize);
		OutOtherHalfProcMesh = UObjectMarshaler<UProceduralMeshComponent>.FromNative(IntPtr.Add(intPtr, SliceProceduralMesh_OutOtherHalfProcMesh_Offset), 0, SliceProceduralMesh_OutOtherHalfProcMesh_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:GetSectionFromStaticMesh")]
	public unsafe static void GetSectionFromStaticMesh(UStaticMesh InMesh, int LODIndex, int SectionIndex, out List<FVector> Vertices, out List<int> Triangles, out List<FVector> Normals, out List<FVector2D> UVs, out List<FProcMeshTangent> Tangents)
	{
		if (!GetSectionFromStaticMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:GetSectionFromStaticMesh");
			Vertices = null;
			Triangles = null;
			Normals = null;
			UVs = null;
			Tangents = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSectionFromStaticMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSectionFromStaticMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetSectionFromStaticMesh_InMesh_Offset), 0, GetSectionFromStaticMesh_InMesh_PropertyAddress.Address, InMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetSectionFromStaticMesh_LODIndex_Offset), 0, GetSectionFromStaticMesh_LODIndex_PropertyAddress.Address, LODIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetSectionFromStaticMesh_SectionIndex_Offset), 0, GetSectionFromStaticMesh_SectionIndex_PropertyAddress.Address, SectionIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSectionFromStaticMesh_FunctionAddress, intPtr, GetSectionFromStaticMesh_ParamsSize);
		Vertices = new TArrayCopyMarshaler<FVector>(1, GetSectionFromStaticMesh_Vertices_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSectionFromStaticMesh_Vertices_Offset));
		NativeReflection.DestroyValue_InContainer(GetSectionFromStaticMesh_Vertices_PropertyAddress.Address, intPtr);
		Triangles = new TArrayCopyMarshaler<int>(1, GetSectionFromStaticMesh_Triangles_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSectionFromStaticMesh_Triangles_Offset));
		NativeReflection.DestroyValue_InContainer(GetSectionFromStaticMesh_Triangles_PropertyAddress.Address, intPtr);
		Normals = new TArrayCopyMarshaler<FVector>(1, GetSectionFromStaticMesh_Normals_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSectionFromStaticMesh_Normals_Offset));
		NativeReflection.DestroyValue_InContainer(GetSectionFromStaticMesh_Normals_PropertyAddress.Address, intPtr);
		UVs = new TArrayCopyMarshaler<FVector2D>(1, GetSectionFromStaticMesh_UVs_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSectionFromStaticMesh_UVs_Offset));
		NativeReflection.DestroyValue_InContainer(GetSectionFromStaticMesh_UVs_PropertyAddress.Address, intPtr);
		Tangents = new TArrayCopyMarshaler<FProcMeshTangent>(1, GetSectionFromStaticMesh_Tangents_PropertyAddress, CachedMarshalingDelegates<FProcMeshTangent, FProcMeshTangent>.FromNative, CachedMarshalingDelegates<FProcMeshTangent, FProcMeshTangent>.ToNative).FromNative(IntPtr.Add(intPtr, GetSectionFromStaticMesh_Tangents_Offset));
		NativeReflection.DestroyValue_InContainer(GetSectionFromStaticMesh_Tangents_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:GetSectionFromProceduralMesh")]
	public unsafe static void GetSectionFromProceduralMesh(UProceduralMeshComponent InProcMesh, int SectionIndex, out List<FVector> Vertices, out List<int> Triangles, out List<FVector> Normals, out List<FVector2D> UVs, out List<FProcMeshTangent> Tangents)
	{
		if (!GetSectionFromProceduralMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:GetSectionFromProceduralMesh");
			Vertices = null;
			Triangles = null;
			Normals = null;
			UVs = null;
			Tangents = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSectionFromProceduralMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSectionFromProceduralMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UProceduralMeshComponent>.ToNative(IntPtr.Add(intPtr, GetSectionFromProceduralMesh_InProcMesh_Offset), 0, GetSectionFromProceduralMesh_InProcMesh_PropertyAddress.Address, InProcMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetSectionFromProceduralMesh_SectionIndex_Offset), 0, GetSectionFromProceduralMesh_SectionIndex_PropertyAddress.Address, SectionIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSectionFromProceduralMesh_FunctionAddress, intPtr, GetSectionFromProceduralMesh_ParamsSize);
		Vertices = new TArrayCopyMarshaler<FVector>(1, GetSectionFromProceduralMesh_Vertices_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSectionFromProceduralMesh_Vertices_Offset));
		NativeReflection.DestroyValue_InContainer(GetSectionFromProceduralMesh_Vertices_PropertyAddress.Address, intPtr);
		Triangles = new TArrayCopyMarshaler<int>(1, GetSectionFromProceduralMesh_Triangles_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSectionFromProceduralMesh_Triangles_Offset));
		NativeReflection.DestroyValue_InContainer(GetSectionFromProceduralMesh_Triangles_PropertyAddress.Address, intPtr);
		Normals = new TArrayCopyMarshaler<FVector>(1, GetSectionFromProceduralMesh_Normals_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSectionFromProceduralMesh_Normals_Offset));
		NativeReflection.DestroyValue_InContainer(GetSectionFromProceduralMesh_Normals_PropertyAddress.Address, intPtr);
		UVs = new TArrayCopyMarshaler<FVector2D>(1, GetSectionFromProceduralMesh_UVs_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSectionFromProceduralMesh_UVs_Offset));
		NativeReflection.DestroyValue_InContainer(GetSectionFromProceduralMesh_UVs_PropertyAddress.Address, intPtr);
		Tangents = new TArrayCopyMarshaler<FProcMeshTangent>(1, GetSectionFromProceduralMesh_Tangents_PropertyAddress, CachedMarshalingDelegates<FProcMeshTangent, FProcMeshTangent>.FromNative, CachedMarshalingDelegates<FProcMeshTangent, FProcMeshTangent>.ToNative).FromNative(IntPtr.Add(intPtr, GetSectionFromProceduralMesh_Tangents_Offset));
		NativeReflection.DestroyValue_InContainer(GetSectionFromProceduralMesh_Tangents_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:GenerateBoxMesh")]
	public unsafe static void GenerateBoxMesh(FVector BoxRadius, out List<FVector> Vertices, out List<int> Triangles, out List<FVector> Normals, out List<FVector2D> UVs, out List<FProcMeshTangent> Tangents)
	{
		if (!GenerateBoxMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:GenerateBoxMesh");
			Vertices = null;
			Triangles = null;
			Normals = null;
			UVs = null;
			Tangents = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateBoxMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateBoxMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GenerateBoxMesh_BoxRadius_Offset), 0, GenerateBoxMesh_BoxRadius_PropertyAddress.Address, BoxRadius);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GenerateBoxMesh_FunctionAddress, intPtr, GenerateBoxMesh_ParamsSize);
		Vertices = new TArrayCopyMarshaler<FVector>(1, GenerateBoxMesh_Vertices_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GenerateBoxMesh_Vertices_Offset));
		NativeReflection.DestroyValue_InContainer(GenerateBoxMesh_Vertices_PropertyAddress.Address, intPtr);
		Triangles = new TArrayCopyMarshaler<int>(1, GenerateBoxMesh_Triangles_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GenerateBoxMesh_Triangles_Offset));
		NativeReflection.DestroyValue_InContainer(GenerateBoxMesh_Triangles_PropertyAddress.Address, intPtr);
		Normals = new TArrayCopyMarshaler<FVector>(1, GenerateBoxMesh_Normals_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GenerateBoxMesh_Normals_Offset));
		NativeReflection.DestroyValue_InContainer(GenerateBoxMesh_Normals_PropertyAddress.Address, intPtr);
		UVs = new TArrayCopyMarshaler<FVector2D>(1, GenerateBoxMesh_UVs_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).FromNative(IntPtr.Add(intPtr, GenerateBoxMesh_UVs_Offset));
		NativeReflection.DestroyValue_InContainer(GenerateBoxMesh_UVs_PropertyAddress.Address, intPtr);
		Tangents = new TArrayCopyMarshaler<FProcMeshTangent>(1, GenerateBoxMesh_Tangents_PropertyAddress, CachedMarshalingDelegates<FProcMeshTangent, FProcMeshTangent>.FromNative, CachedMarshalingDelegates<FProcMeshTangent, FProcMeshTangent>.ToNative).FromNative(IntPtr.Add(intPtr, GenerateBoxMesh_Tangents_Offset));
		NativeReflection.DestroyValue_InContainer(GenerateBoxMesh_Tangents_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:CreateGridMeshWelded")]
	public unsafe static void CreateGridMeshWelded(int NumX, int NumY, out List<int> Triangles, out List<FVector> Vertices, out List<FVector2D> UVs, float GridSpacing = 16f)
	{
		if (!CreateGridMeshWelded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:CreateGridMeshWelded");
			Triangles = null;
			Vertices = null;
			UVs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateGridMeshWelded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateGridMeshWelded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateGridMeshWelded_NumX_Offset), 0, CreateGridMeshWelded_NumX_PropertyAddress.Address, NumX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateGridMeshWelded_NumY_Offset), 0, CreateGridMeshWelded_NumY_PropertyAddress.Address, NumY);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CreateGridMeshWelded_GridSpacing_Offset), 0, CreateGridMeshWelded_GridSpacing_PropertyAddress.Address, GridSpacing);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateGridMeshWelded_FunctionAddress, intPtr, CreateGridMeshWelded_ParamsSize);
		Triangles = new TArrayCopyMarshaler<int>(1, CreateGridMeshWelded_Triangles_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, CreateGridMeshWelded_Triangles_Offset));
		NativeReflection.DestroyValue_InContainer(CreateGridMeshWelded_Triangles_PropertyAddress.Address, intPtr);
		Vertices = new TArrayCopyMarshaler<FVector>(1, CreateGridMeshWelded_Vertices_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, CreateGridMeshWelded_Vertices_Offset));
		NativeReflection.DestroyValue_InContainer(CreateGridMeshWelded_Vertices_PropertyAddress.Address, intPtr);
		UVs = new TArrayCopyMarshaler<FVector2D>(1, CreateGridMeshWelded_UVs_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).FromNative(IntPtr.Add(intPtr, CreateGridMeshWelded_UVs_Offset));
		NativeReflection.DestroyValue_InContainer(CreateGridMeshWelded_UVs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:CreateGridMeshTriangles")]
	public unsafe static void CreateGridMeshTriangles(int NumX, int NumY, bool bWinding, out List<int> Triangles)
	{
		if (!CreateGridMeshTriangles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:CreateGridMeshTriangles");
			Triangles = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateGridMeshTriangles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateGridMeshTriangles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateGridMeshTriangles_NumX_Offset), 0, CreateGridMeshTriangles_NumX_PropertyAddress.Address, NumX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateGridMeshTriangles_NumY_Offset), 0, CreateGridMeshTriangles_NumY_PropertyAddress.Address, NumY);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateGridMeshTriangles_bWinding_Offset), 0, CreateGridMeshTriangles_bWinding_PropertyAddress.Address, bWinding);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateGridMeshTriangles_FunctionAddress, intPtr, CreateGridMeshTriangles_ParamsSize);
		Triangles = new TArrayCopyMarshaler<int>(1, CreateGridMeshTriangles_Triangles_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, CreateGridMeshTriangles_Triangles_Offset));
		NativeReflection.DestroyValue_InContainer(CreateGridMeshTriangles_Triangles_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:CreateGridMeshSplit")]
	public unsafe static void CreateGridMeshSplit(int NumX, int NumY, out List<int> Triangles, out List<FVector> Vertices, out List<FVector2D> UVs, out List<FVector2D> UV1s, float GridSpacing = 16f)
	{
		if (!CreateGridMeshSplit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:CreateGridMeshSplit");
			Triangles = null;
			Vertices = null;
			UVs = null;
			UV1s = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateGridMeshSplit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateGridMeshSplit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateGridMeshSplit_NumX_Offset), 0, CreateGridMeshSplit_NumX_PropertyAddress.Address, NumX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateGridMeshSplit_NumY_Offset), 0, CreateGridMeshSplit_NumY_PropertyAddress.Address, NumY);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CreateGridMeshSplit_GridSpacing_Offset), 0, CreateGridMeshSplit_GridSpacing_PropertyAddress.Address, GridSpacing);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateGridMeshSplit_FunctionAddress, intPtr, CreateGridMeshSplit_ParamsSize);
		Triangles = new TArrayCopyMarshaler<int>(1, CreateGridMeshSplit_Triangles_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, CreateGridMeshSplit_Triangles_Offset));
		NativeReflection.DestroyValue_InContainer(CreateGridMeshSplit_Triangles_PropertyAddress.Address, intPtr);
		Vertices = new TArrayCopyMarshaler<FVector>(1, CreateGridMeshSplit_Vertices_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, CreateGridMeshSplit_Vertices_Offset));
		NativeReflection.DestroyValue_InContainer(CreateGridMeshSplit_Vertices_PropertyAddress.Address, intPtr);
		UVs = new TArrayCopyMarshaler<FVector2D>(1, CreateGridMeshSplit_UVs_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).FromNative(IntPtr.Add(intPtr, CreateGridMeshSplit_UVs_Offset));
		NativeReflection.DestroyValue_InContainer(CreateGridMeshSplit_UVs_PropertyAddress.Address, intPtr);
		UV1s = new TArrayCopyMarshaler<FVector2D>(1, CreateGridMeshSplit_UV1s_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).FromNative(IntPtr.Add(intPtr, CreateGridMeshSplit_UV1s_Offset));
		NativeReflection.DestroyValue_InContainer(CreateGridMeshSplit_UV1s_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:CopyProceduralMeshFromStaticMeshComponent")]
	public unsafe static void CopyProceduralMeshFromStaticMeshComponent(UStaticMeshComponent StaticMeshComponent, int LODIndex, UProceduralMeshComponent ProcMeshComponent, bool bCreateCollision)
	{
		if (!CopyProceduralMeshFromStaticMeshComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:CopyProceduralMeshFromStaticMeshComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyProceduralMeshFromStaticMeshComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyProceduralMeshFromStaticMeshComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(intPtr, CopyProceduralMeshFromStaticMeshComponent_StaticMeshComponent_Offset), 0, CopyProceduralMeshFromStaticMeshComponent_StaticMeshComponent_PropertyAddress.Address, StaticMeshComponent);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CopyProceduralMeshFromStaticMeshComponent_LODIndex_Offset), 0, CopyProceduralMeshFromStaticMeshComponent_LODIndex_PropertyAddress.Address, LODIndex);
		UObjectMarshaler<UProceduralMeshComponent>.ToNative(IntPtr.Add(intPtr, CopyProceduralMeshFromStaticMeshComponent_ProcMeshComponent_Offset), 0, CopyProceduralMeshFromStaticMeshComponent_ProcMeshComponent_PropertyAddress.Address, ProcMeshComponent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CopyProceduralMeshFromStaticMeshComponent_bCreateCollision_Offset), 0, CopyProceduralMeshFromStaticMeshComponent_bCreateCollision_PropertyAddress.Address, bCreateCollision);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, intPtr, CopyProceduralMeshFromStaticMeshComponent_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:ConvertQuadToTriangles")]
	public unsafe static void ConvertQuadToTriangles(ref List<int> Triangles, int Vert0, int Vert1, int Vert2, int Vert3)
	{
		if (!ConvertQuadToTriangles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:ConvertQuadToTriangles");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertQuadToTriangles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertQuadToTriangles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TArrayCopyMarshaler<int> tArrayCopyMarshaler = new TArrayCopyMarshaler<int>(1, ConvertQuadToTriangles_Triangles_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(intPtr, ConvertQuadToTriangles_Triangles_Offset), Triangles);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConvertQuadToTriangles_Vert0_Offset), 0, ConvertQuadToTriangles_Vert0_PropertyAddress.Address, Vert0);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConvertQuadToTriangles_Vert1_Offset), 0, ConvertQuadToTriangles_Vert1_PropertyAddress.Address, Vert1);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConvertQuadToTriangles_Vert2_Offset), 0, ConvertQuadToTriangles_Vert2_PropertyAddress.Address, Vert2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConvertQuadToTriangles_Vert3_Offset), 0, ConvertQuadToTriangles_Vert3_PropertyAddress.Address, Vert3);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertQuadToTriangles_FunctionAddress, intPtr, ConvertQuadToTriangles_ParamsSize);
		Triangles = tArrayCopyMarshaler.FromNative(IntPtr.Add(intPtr, ConvertQuadToTriangles_Triangles_Offset));
		NativeReflection.DestroyValue_InContainer(ConvertQuadToTriangles_Triangles_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:CalculateTangentsForMesh")]
	public unsafe static void CalculateTangentsForMesh(List<FVector> Vertices, List<int> Triangles, List<FVector2D> UVs, out List<FVector> Normals, out List<FProcMeshTangent> Tangents)
	{
		if (!CalculateTangentsForMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:CalculateTangentsForMesh");
			Normals = null;
			Tangents = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalculateTangentsForMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalculateTangentsForMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, CalculateTangentsForMesh_Vertices_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, CalculateTangentsForMesh_Vertices_Offset), Vertices);
		new TArrayCopyMarshaler<int>(1, CalculateTangentsForMesh_Triangles_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, CalculateTangentsForMesh_Triangles_Offset), Triangles);
		new TArrayCopyMarshaler<FVector2D>(1, CalculateTangentsForMesh_UVs_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(intPtr, CalculateTangentsForMesh_UVs_Offset), UVs);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CalculateTangentsForMesh_FunctionAddress, intPtr, CalculateTangentsForMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CalculateTangentsForMesh_Vertices_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CalculateTangentsForMesh_Triangles_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CalculateTangentsForMesh_UVs_PropertyAddress.Address, intPtr);
		Normals = new TArrayCopyMarshaler<FVector>(1, CalculateTangentsForMesh_Normals_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, CalculateTangentsForMesh_Normals_Offset));
		NativeReflection.DestroyValue_InContainer(CalculateTangentsForMesh_Normals_PropertyAddress.Address, intPtr);
		Tangents = new TArrayCopyMarshaler<FProcMeshTangent>(1, CalculateTangentsForMesh_Tangents_PropertyAddress, CachedMarshalingDelegates<FProcMeshTangent, FProcMeshTangent>.FromNative, CachedMarshalingDelegates<FProcMeshTangent, FProcMeshTangent>.ToNative).FromNative(IntPtr.Add(intPtr, CalculateTangentsForMesh_Tangents_Offset));
		NativeReflection.DestroyValue_InContainer(CalculateTangentsForMesh_Tangents_PropertyAddress.Address, intPtr);
	}

	static UProceduralMeshLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UProceduralMeshLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UProceduralMeshLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary");
		SliceProceduralMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SliceProceduralMesh");
		SliceProceduralMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(SliceProceduralMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SliceProceduralMesh_InProcMesh_PropertyAddress, SliceProceduralMesh_FunctionAddress, "InProcMesh");
		SliceProceduralMesh_InProcMesh_Offset = NativeReflectionCached.GetPropertyOffset(SliceProceduralMesh_FunctionAddress, "InProcMesh");
		SliceProceduralMesh_InProcMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SliceProceduralMesh_FunctionAddress, "InProcMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SliceProceduralMesh_PlanePosition_PropertyAddress, SliceProceduralMesh_FunctionAddress, "PlanePosition");
		SliceProceduralMesh_PlanePosition_Offset = NativeReflectionCached.GetPropertyOffset(SliceProceduralMesh_FunctionAddress, "PlanePosition");
		SliceProceduralMesh_PlanePosition_IsValid = NativeReflectionCached.ValidatePropertyClass(SliceProceduralMesh_FunctionAddress, "PlanePosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SliceProceduralMesh_PlaneNormal_PropertyAddress, SliceProceduralMesh_FunctionAddress, "PlaneNormal");
		SliceProceduralMesh_PlaneNormal_Offset = NativeReflectionCached.GetPropertyOffset(SliceProceduralMesh_FunctionAddress, "PlaneNormal");
		SliceProceduralMesh_PlaneNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(SliceProceduralMesh_FunctionAddress, "PlaneNormal", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SliceProceduralMesh_bCreateOtherHalf_PropertyAddress, SliceProceduralMesh_FunctionAddress, "bCreateOtherHalf");
		SliceProceduralMesh_bCreateOtherHalf_Offset = NativeReflectionCached.GetPropertyOffset(SliceProceduralMesh_FunctionAddress, "bCreateOtherHalf");
		SliceProceduralMesh_bCreateOtherHalf_IsValid = NativeReflectionCached.ValidatePropertyClass(SliceProceduralMesh_FunctionAddress, "bCreateOtherHalf", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SliceProceduralMesh_OutOtherHalfProcMesh_PropertyAddress, SliceProceduralMesh_FunctionAddress, "OutOtherHalfProcMesh");
		SliceProceduralMesh_OutOtherHalfProcMesh_Offset = NativeReflectionCached.GetPropertyOffset(SliceProceduralMesh_FunctionAddress, "OutOtherHalfProcMesh");
		SliceProceduralMesh_OutOtherHalfProcMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SliceProceduralMesh_FunctionAddress, "OutOtherHalfProcMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SliceProceduralMesh_CapOption_PropertyAddress, SliceProceduralMesh_FunctionAddress, "CapOption");
		SliceProceduralMesh_CapOption_Offset = NativeReflectionCached.GetPropertyOffset(SliceProceduralMesh_FunctionAddress, "CapOption");
		SliceProceduralMesh_CapOption_IsValid = NativeReflectionCached.ValidatePropertyClass(SliceProceduralMesh_FunctionAddress, "CapOption", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SliceProceduralMesh_CapMaterial_PropertyAddress, SliceProceduralMesh_FunctionAddress, "CapMaterial");
		SliceProceduralMesh_CapMaterial_Offset = NativeReflectionCached.GetPropertyOffset(SliceProceduralMesh_FunctionAddress, "CapMaterial");
		SliceProceduralMesh_CapMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(SliceProceduralMesh_FunctionAddress, "CapMaterial", Classes.FObjectProperty);
		SliceProceduralMesh_IsValid = SliceProceduralMesh_FunctionAddress != IntPtr.Zero && SliceProceduralMesh_InProcMesh_IsValid && SliceProceduralMesh_PlanePosition_IsValid && SliceProceduralMesh_PlaneNormal_IsValid && SliceProceduralMesh_bCreateOtherHalf_IsValid && SliceProceduralMesh_OutOtherHalfProcMesh_IsValid && SliceProceduralMesh_CapOption_IsValid && SliceProceduralMesh_CapMaterial_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:SliceProceduralMesh", SliceProceduralMesh_IsValid);
		GetSectionFromStaticMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSectionFromStaticMesh");
		GetSectionFromStaticMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSectionFromStaticMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSectionFromStaticMesh_InMesh_PropertyAddress, GetSectionFromStaticMesh_FunctionAddress, "InMesh");
		GetSectionFromStaticMesh_InMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetSectionFromStaticMesh_FunctionAddress, "InMesh");
		GetSectionFromStaticMesh_InMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSectionFromStaticMesh_FunctionAddress, "InMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSectionFromStaticMesh_LODIndex_PropertyAddress, GetSectionFromStaticMesh_FunctionAddress, "LODIndex");
		GetSectionFromStaticMesh_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetSectionFromStaticMesh_FunctionAddress, "LODIndex");
		GetSectionFromStaticMesh_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSectionFromStaticMesh_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSectionFromStaticMesh_SectionIndex_PropertyAddress, GetSectionFromStaticMesh_FunctionAddress, "SectionIndex");
		GetSectionFromStaticMesh_SectionIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetSectionFromStaticMesh_FunctionAddress, "SectionIndex");
		GetSectionFromStaticMesh_SectionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSectionFromStaticMesh_FunctionAddress, "SectionIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSectionFromStaticMesh_Vertices_PropertyAddress, GetSectionFromStaticMesh_FunctionAddress, "Vertices");
		GetSectionFromStaticMesh_Vertices_Offset = NativeReflectionCached.GetPropertyOffset(GetSectionFromStaticMesh_FunctionAddress, "Vertices");
		GetSectionFromStaticMesh_Vertices_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSectionFromStaticMesh_FunctionAddress, "Vertices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSectionFromStaticMesh_Triangles_PropertyAddress, GetSectionFromStaticMesh_FunctionAddress, "Triangles");
		GetSectionFromStaticMesh_Triangles_Offset = NativeReflectionCached.GetPropertyOffset(GetSectionFromStaticMesh_FunctionAddress, "Triangles");
		GetSectionFromStaticMesh_Triangles_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSectionFromStaticMesh_FunctionAddress, "Triangles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSectionFromStaticMesh_Normals_PropertyAddress, GetSectionFromStaticMesh_FunctionAddress, "Normals");
		GetSectionFromStaticMesh_Normals_Offset = NativeReflectionCached.GetPropertyOffset(GetSectionFromStaticMesh_FunctionAddress, "Normals");
		GetSectionFromStaticMesh_Normals_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSectionFromStaticMesh_FunctionAddress, "Normals", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSectionFromStaticMesh_UVs_PropertyAddress, GetSectionFromStaticMesh_FunctionAddress, "UVs");
		GetSectionFromStaticMesh_UVs_Offset = NativeReflectionCached.GetPropertyOffset(GetSectionFromStaticMesh_FunctionAddress, "UVs");
		GetSectionFromStaticMesh_UVs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSectionFromStaticMesh_FunctionAddress, "UVs", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSectionFromStaticMesh_Tangents_PropertyAddress, GetSectionFromStaticMesh_FunctionAddress, "Tangents");
		GetSectionFromStaticMesh_Tangents_Offset = NativeReflectionCached.GetPropertyOffset(GetSectionFromStaticMesh_FunctionAddress, "Tangents");
		GetSectionFromStaticMesh_Tangents_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSectionFromStaticMesh_FunctionAddress, "Tangents", Classes.FArrayProperty);
		GetSectionFromStaticMesh_IsValid = GetSectionFromStaticMesh_FunctionAddress != IntPtr.Zero && GetSectionFromStaticMesh_InMesh_IsValid && GetSectionFromStaticMesh_LODIndex_IsValid && GetSectionFromStaticMesh_SectionIndex_IsValid && GetSectionFromStaticMesh_Vertices_IsValid && GetSectionFromStaticMesh_Triangles_IsValid && GetSectionFromStaticMesh_Normals_IsValid && GetSectionFromStaticMesh_UVs_IsValid && GetSectionFromStaticMesh_Tangents_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:GetSectionFromStaticMesh", GetSectionFromStaticMesh_IsValid);
		GetSectionFromProceduralMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSectionFromProceduralMesh");
		GetSectionFromProceduralMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSectionFromProceduralMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSectionFromProceduralMesh_InProcMesh_PropertyAddress, GetSectionFromProceduralMesh_FunctionAddress, "InProcMesh");
		GetSectionFromProceduralMesh_InProcMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetSectionFromProceduralMesh_FunctionAddress, "InProcMesh");
		GetSectionFromProceduralMesh_InProcMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSectionFromProceduralMesh_FunctionAddress, "InProcMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSectionFromProceduralMesh_SectionIndex_PropertyAddress, GetSectionFromProceduralMesh_FunctionAddress, "SectionIndex");
		GetSectionFromProceduralMesh_SectionIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetSectionFromProceduralMesh_FunctionAddress, "SectionIndex");
		GetSectionFromProceduralMesh_SectionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSectionFromProceduralMesh_FunctionAddress, "SectionIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSectionFromProceduralMesh_Vertices_PropertyAddress, GetSectionFromProceduralMesh_FunctionAddress, "Vertices");
		GetSectionFromProceduralMesh_Vertices_Offset = NativeReflectionCached.GetPropertyOffset(GetSectionFromProceduralMesh_FunctionAddress, "Vertices");
		GetSectionFromProceduralMesh_Vertices_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSectionFromProceduralMesh_FunctionAddress, "Vertices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSectionFromProceduralMesh_Triangles_PropertyAddress, GetSectionFromProceduralMesh_FunctionAddress, "Triangles");
		GetSectionFromProceduralMesh_Triangles_Offset = NativeReflectionCached.GetPropertyOffset(GetSectionFromProceduralMesh_FunctionAddress, "Triangles");
		GetSectionFromProceduralMesh_Triangles_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSectionFromProceduralMesh_FunctionAddress, "Triangles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSectionFromProceduralMesh_Normals_PropertyAddress, GetSectionFromProceduralMesh_FunctionAddress, "Normals");
		GetSectionFromProceduralMesh_Normals_Offset = NativeReflectionCached.GetPropertyOffset(GetSectionFromProceduralMesh_FunctionAddress, "Normals");
		GetSectionFromProceduralMesh_Normals_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSectionFromProceduralMesh_FunctionAddress, "Normals", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSectionFromProceduralMesh_UVs_PropertyAddress, GetSectionFromProceduralMesh_FunctionAddress, "UVs");
		GetSectionFromProceduralMesh_UVs_Offset = NativeReflectionCached.GetPropertyOffset(GetSectionFromProceduralMesh_FunctionAddress, "UVs");
		GetSectionFromProceduralMesh_UVs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSectionFromProceduralMesh_FunctionAddress, "UVs", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSectionFromProceduralMesh_Tangents_PropertyAddress, GetSectionFromProceduralMesh_FunctionAddress, "Tangents");
		GetSectionFromProceduralMesh_Tangents_Offset = NativeReflectionCached.GetPropertyOffset(GetSectionFromProceduralMesh_FunctionAddress, "Tangents");
		GetSectionFromProceduralMesh_Tangents_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSectionFromProceduralMesh_FunctionAddress, "Tangents", Classes.FArrayProperty);
		GetSectionFromProceduralMesh_IsValid = GetSectionFromProceduralMesh_FunctionAddress != IntPtr.Zero && GetSectionFromProceduralMesh_InProcMesh_IsValid && GetSectionFromProceduralMesh_SectionIndex_IsValid && GetSectionFromProceduralMesh_Vertices_IsValid && GetSectionFromProceduralMesh_Triangles_IsValid && GetSectionFromProceduralMesh_Normals_IsValid && GetSectionFromProceduralMesh_UVs_IsValid && GetSectionFromProceduralMesh_Tangents_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:GetSectionFromProceduralMesh", GetSectionFromProceduralMesh_IsValid);
		GenerateBoxMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GenerateBoxMesh");
		GenerateBoxMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateBoxMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenerateBoxMesh_BoxRadius_PropertyAddress, GenerateBoxMesh_FunctionAddress, "BoxRadius");
		GenerateBoxMesh_BoxRadius_Offset = NativeReflectionCached.GetPropertyOffset(GenerateBoxMesh_FunctionAddress, "BoxRadius");
		GenerateBoxMesh_BoxRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateBoxMesh_FunctionAddress, "BoxRadius", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateBoxMesh_Vertices_PropertyAddress, GenerateBoxMesh_FunctionAddress, "Vertices");
		GenerateBoxMesh_Vertices_Offset = NativeReflectionCached.GetPropertyOffset(GenerateBoxMesh_FunctionAddress, "Vertices");
		GenerateBoxMesh_Vertices_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateBoxMesh_FunctionAddress, "Vertices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateBoxMesh_Triangles_PropertyAddress, GenerateBoxMesh_FunctionAddress, "Triangles");
		GenerateBoxMesh_Triangles_Offset = NativeReflectionCached.GetPropertyOffset(GenerateBoxMesh_FunctionAddress, "Triangles");
		GenerateBoxMesh_Triangles_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateBoxMesh_FunctionAddress, "Triangles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateBoxMesh_Normals_PropertyAddress, GenerateBoxMesh_FunctionAddress, "Normals");
		GenerateBoxMesh_Normals_Offset = NativeReflectionCached.GetPropertyOffset(GenerateBoxMesh_FunctionAddress, "Normals");
		GenerateBoxMesh_Normals_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateBoxMesh_FunctionAddress, "Normals", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateBoxMesh_UVs_PropertyAddress, GenerateBoxMesh_FunctionAddress, "UVs");
		GenerateBoxMesh_UVs_Offset = NativeReflectionCached.GetPropertyOffset(GenerateBoxMesh_FunctionAddress, "UVs");
		GenerateBoxMesh_UVs_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateBoxMesh_FunctionAddress, "UVs", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateBoxMesh_Tangents_PropertyAddress, GenerateBoxMesh_FunctionAddress, "Tangents");
		GenerateBoxMesh_Tangents_Offset = NativeReflectionCached.GetPropertyOffset(GenerateBoxMesh_FunctionAddress, "Tangents");
		GenerateBoxMesh_Tangents_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateBoxMesh_FunctionAddress, "Tangents", Classes.FArrayProperty);
		GenerateBoxMesh_IsValid = GenerateBoxMesh_FunctionAddress != IntPtr.Zero && GenerateBoxMesh_BoxRadius_IsValid && GenerateBoxMesh_Vertices_IsValid && GenerateBoxMesh_Triangles_IsValid && GenerateBoxMesh_Normals_IsValid && GenerateBoxMesh_UVs_IsValid && GenerateBoxMesh_Tangents_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:GenerateBoxMesh", GenerateBoxMesh_IsValid);
		CreateGridMeshWelded_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateGridMeshWelded");
		CreateGridMeshWelded_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateGridMeshWelded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateGridMeshWelded_NumX_PropertyAddress, CreateGridMeshWelded_FunctionAddress, "NumX");
		CreateGridMeshWelded_NumX_Offset = NativeReflectionCached.GetPropertyOffset(CreateGridMeshWelded_FunctionAddress, "NumX");
		CreateGridMeshWelded_NumX_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateGridMeshWelded_FunctionAddress, "NumX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateGridMeshWelded_NumY_PropertyAddress, CreateGridMeshWelded_FunctionAddress, "NumY");
		CreateGridMeshWelded_NumY_Offset = NativeReflectionCached.GetPropertyOffset(CreateGridMeshWelded_FunctionAddress, "NumY");
		CreateGridMeshWelded_NumY_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateGridMeshWelded_FunctionAddress, "NumY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateGridMeshWelded_Triangles_PropertyAddress, CreateGridMeshWelded_FunctionAddress, "Triangles");
		CreateGridMeshWelded_Triangles_Offset = NativeReflectionCached.GetPropertyOffset(CreateGridMeshWelded_FunctionAddress, "Triangles");
		CreateGridMeshWelded_Triangles_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateGridMeshWelded_FunctionAddress, "Triangles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateGridMeshWelded_Vertices_PropertyAddress, CreateGridMeshWelded_FunctionAddress, "Vertices");
		CreateGridMeshWelded_Vertices_Offset = NativeReflectionCached.GetPropertyOffset(CreateGridMeshWelded_FunctionAddress, "Vertices");
		CreateGridMeshWelded_Vertices_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateGridMeshWelded_FunctionAddress, "Vertices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateGridMeshWelded_UVs_PropertyAddress, CreateGridMeshWelded_FunctionAddress, "UVs");
		CreateGridMeshWelded_UVs_Offset = NativeReflectionCached.GetPropertyOffset(CreateGridMeshWelded_FunctionAddress, "UVs");
		CreateGridMeshWelded_UVs_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateGridMeshWelded_FunctionAddress, "UVs", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateGridMeshWelded_GridSpacing_PropertyAddress, CreateGridMeshWelded_FunctionAddress, "GridSpacing");
		CreateGridMeshWelded_GridSpacing_Offset = NativeReflectionCached.GetPropertyOffset(CreateGridMeshWelded_FunctionAddress, "GridSpacing");
		CreateGridMeshWelded_GridSpacing_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateGridMeshWelded_FunctionAddress, "GridSpacing", Classes.FFloatProperty);
		CreateGridMeshWelded_IsValid = CreateGridMeshWelded_FunctionAddress != IntPtr.Zero && CreateGridMeshWelded_NumX_IsValid && CreateGridMeshWelded_NumY_IsValid && CreateGridMeshWelded_Triangles_IsValid && CreateGridMeshWelded_Vertices_IsValid && CreateGridMeshWelded_UVs_IsValid && CreateGridMeshWelded_GridSpacing_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:CreateGridMeshWelded", CreateGridMeshWelded_IsValid);
		CreateGridMeshTriangles_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateGridMeshTriangles");
		CreateGridMeshTriangles_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateGridMeshTriangles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateGridMeshTriangles_NumX_PropertyAddress, CreateGridMeshTriangles_FunctionAddress, "NumX");
		CreateGridMeshTriangles_NumX_Offset = NativeReflectionCached.GetPropertyOffset(CreateGridMeshTriangles_FunctionAddress, "NumX");
		CreateGridMeshTriangles_NumX_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateGridMeshTriangles_FunctionAddress, "NumX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateGridMeshTriangles_NumY_PropertyAddress, CreateGridMeshTriangles_FunctionAddress, "NumY");
		CreateGridMeshTriangles_NumY_Offset = NativeReflectionCached.GetPropertyOffset(CreateGridMeshTriangles_FunctionAddress, "NumY");
		CreateGridMeshTriangles_NumY_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateGridMeshTriangles_FunctionAddress, "NumY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateGridMeshTriangles_bWinding_PropertyAddress, CreateGridMeshTriangles_FunctionAddress, "bWinding");
		CreateGridMeshTriangles_bWinding_Offset = NativeReflectionCached.GetPropertyOffset(CreateGridMeshTriangles_FunctionAddress, "bWinding");
		CreateGridMeshTriangles_bWinding_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateGridMeshTriangles_FunctionAddress, "bWinding", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateGridMeshTriangles_Triangles_PropertyAddress, CreateGridMeshTriangles_FunctionAddress, "Triangles");
		CreateGridMeshTriangles_Triangles_Offset = NativeReflectionCached.GetPropertyOffset(CreateGridMeshTriangles_FunctionAddress, "Triangles");
		CreateGridMeshTriangles_Triangles_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateGridMeshTriangles_FunctionAddress, "Triangles", Classes.FArrayProperty);
		CreateGridMeshTriangles_IsValid = CreateGridMeshTriangles_FunctionAddress != IntPtr.Zero && CreateGridMeshTriangles_NumX_IsValid && CreateGridMeshTriangles_NumY_IsValid && CreateGridMeshTriangles_bWinding_IsValid && CreateGridMeshTriangles_Triangles_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:CreateGridMeshTriangles", CreateGridMeshTriangles_IsValid);
		CreateGridMeshSplit_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateGridMeshSplit");
		CreateGridMeshSplit_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateGridMeshSplit_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateGridMeshSplit_NumX_PropertyAddress, CreateGridMeshSplit_FunctionAddress, "NumX");
		CreateGridMeshSplit_NumX_Offset = NativeReflectionCached.GetPropertyOffset(CreateGridMeshSplit_FunctionAddress, "NumX");
		CreateGridMeshSplit_NumX_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateGridMeshSplit_FunctionAddress, "NumX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateGridMeshSplit_NumY_PropertyAddress, CreateGridMeshSplit_FunctionAddress, "NumY");
		CreateGridMeshSplit_NumY_Offset = NativeReflectionCached.GetPropertyOffset(CreateGridMeshSplit_FunctionAddress, "NumY");
		CreateGridMeshSplit_NumY_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateGridMeshSplit_FunctionAddress, "NumY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateGridMeshSplit_Triangles_PropertyAddress, CreateGridMeshSplit_FunctionAddress, "Triangles");
		CreateGridMeshSplit_Triangles_Offset = NativeReflectionCached.GetPropertyOffset(CreateGridMeshSplit_FunctionAddress, "Triangles");
		CreateGridMeshSplit_Triangles_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateGridMeshSplit_FunctionAddress, "Triangles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateGridMeshSplit_Vertices_PropertyAddress, CreateGridMeshSplit_FunctionAddress, "Vertices");
		CreateGridMeshSplit_Vertices_Offset = NativeReflectionCached.GetPropertyOffset(CreateGridMeshSplit_FunctionAddress, "Vertices");
		CreateGridMeshSplit_Vertices_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateGridMeshSplit_FunctionAddress, "Vertices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateGridMeshSplit_UVs_PropertyAddress, CreateGridMeshSplit_FunctionAddress, "UVs");
		CreateGridMeshSplit_UVs_Offset = NativeReflectionCached.GetPropertyOffset(CreateGridMeshSplit_FunctionAddress, "UVs");
		CreateGridMeshSplit_UVs_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateGridMeshSplit_FunctionAddress, "UVs", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateGridMeshSplit_UV1s_PropertyAddress, CreateGridMeshSplit_FunctionAddress, "UV1s");
		CreateGridMeshSplit_UV1s_Offset = NativeReflectionCached.GetPropertyOffset(CreateGridMeshSplit_FunctionAddress, "UV1s");
		CreateGridMeshSplit_UV1s_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateGridMeshSplit_FunctionAddress, "UV1s", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateGridMeshSplit_GridSpacing_PropertyAddress, CreateGridMeshSplit_FunctionAddress, "GridSpacing");
		CreateGridMeshSplit_GridSpacing_Offset = NativeReflectionCached.GetPropertyOffset(CreateGridMeshSplit_FunctionAddress, "GridSpacing");
		CreateGridMeshSplit_GridSpacing_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateGridMeshSplit_FunctionAddress, "GridSpacing", Classes.FFloatProperty);
		CreateGridMeshSplit_IsValid = CreateGridMeshSplit_FunctionAddress != IntPtr.Zero && CreateGridMeshSplit_NumX_IsValid && CreateGridMeshSplit_NumY_IsValid && CreateGridMeshSplit_Triangles_IsValid && CreateGridMeshSplit_Vertices_IsValid && CreateGridMeshSplit_UVs_IsValid && CreateGridMeshSplit_UV1s_IsValid && CreateGridMeshSplit_GridSpacing_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:CreateGridMeshSplit", CreateGridMeshSplit_IsValid);
		CopyProceduralMeshFromStaticMeshComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyProceduralMeshFromStaticMeshComponent");
		CopyProceduralMeshFromStaticMeshComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyProceduralMeshFromStaticMeshComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyProceduralMeshFromStaticMeshComponent_StaticMeshComponent_PropertyAddress, CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "StaticMeshComponent");
		CopyProceduralMeshFromStaticMeshComponent_StaticMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "StaticMeshComponent");
		CopyProceduralMeshFromStaticMeshComponent_StaticMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "StaticMeshComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyProceduralMeshFromStaticMeshComponent_LODIndex_PropertyAddress, CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "LODIndex");
		CopyProceduralMeshFromStaticMeshComponent_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "LODIndex");
		CopyProceduralMeshFromStaticMeshComponent_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyProceduralMeshFromStaticMeshComponent_ProcMeshComponent_PropertyAddress, CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "ProcMeshComponent");
		CopyProceduralMeshFromStaticMeshComponent_ProcMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "ProcMeshComponent");
		CopyProceduralMeshFromStaticMeshComponent_ProcMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "ProcMeshComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyProceduralMeshFromStaticMeshComponent_bCreateCollision_PropertyAddress, CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "bCreateCollision");
		CopyProceduralMeshFromStaticMeshComponent_bCreateCollision_Offset = NativeReflectionCached.GetPropertyOffset(CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "bCreateCollision");
		CopyProceduralMeshFromStaticMeshComponent_bCreateCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyProceduralMeshFromStaticMeshComponent_FunctionAddress, "bCreateCollision", Classes.FBoolProperty);
		CopyProceduralMeshFromStaticMeshComponent_IsValid = CopyProceduralMeshFromStaticMeshComponent_FunctionAddress != IntPtr.Zero && CopyProceduralMeshFromStaticMeshComponent_StaticMeshComponent_IsValid && CopyProceduralMeshFromStaticMeshComponent_LODIndex_IsValid && CopyProceduralMeshFromStaticMeshComponent_ProcMeshComponent_IsValid && CopyProceduralMeshFromStaticMeshComponent_bCreateCollision_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:CopyProceduralMeshFromStaticMeshComponent", CopyProceduralMeshFromStaticMeshComponent_IsValid);
		ConvertQuadToTriangles_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertQuadToTriangles");
		ConvertQuadToTriangles_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertQuadToTriangles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertQuadToTriangles_Triangles_PropertyAddress, ConvertQuadToTriangles_FunctionAddress, "Triangles");
		ConvertQuadToTriangles_Triangles_Offset = NativeReflectionCached.GetPropertyOffset(ConvertQuadToTriangles_FunctionAddress, "Triangles");
		ConvertQuadToTriangles_Triangles_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertQuadToTriangles_FunctionAddress, "Triangles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertQuadToTriangles_Vert0_PropertyAddress, ConvertQuadToTriangles_FunctionAddress, "Vert0");
		ConvertQuadToTriangles_Vert0_Offset = NativeReflectionCached.GetPropertyOffset(ConvertQuadToTriangles_FunctionAddress, "Vert0");
		ConvertQuadToTriangles_Vert0_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertQuadToTriangles_FunctionAddress, "Vert0", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertQuadToTriangles_Vert1_PropertyAddress, ConvertQuadToTriangles_FunctionAddress, "Vert1");
		ConvertQuadToTriangles_Vert1_Offset = NativeReflectionCached.GetPropertyOffset(ConvertQuadToTriangles_FunctionAddress, "Vert1");
		ConvertQuadToTriangles_Vert1_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertQuadToTriangles_FunctionAddress, "Vert1", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertQuadToTriangles_Vert2_PropertyAddress, ConvertQuadToTriangles_FunctionAddress, "Vert2");
		ConvertQuadToTriangles_Vert2_Offset = NativeReflectionCached.GetPropertyOffset(ConvertQuadToTriangles_FunctionAddress, "Vert2");
		ConvertQuadToTriangles_Vert2_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertQuadToTriangles_FunctionAddress, "Vert2", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertQuadToTriangles_Vert3_PropertyAddress, ConvertQuadToTriangles_FunctionAddress, "Vert3");
		ConvertQuadToTriangles_Vert3_Offset = NativeReflectionCached.GetPropertyOffset(ConvertQuadToTriangles_FunctionAddress, "Vert3");
		ConvertQuadToTriangles_Vert3_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertQuadToTriangles_FunctionAddress, "Vert3", Classes.FIntProperty);
		ConvertQuadToTriangles_IsValid = ConvertQuadToTriangles_FunctionAddress != IntPtr.Zero && ConvertQuadToTriangles_Triangles_IsValid && ConvertQuadToTriangles_Vert0_IsValid && ConvertQuadToTriangles_Vert1_IsValid && ConvertQuadToTriangles_Vert2_IsValid && ConvertQuadToTriangles_Vert3_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:ConvertQuadToTriangles", ConvertQuadToTriangles_IsValid);
		CalculateTangentsForMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CalculateTangentsForMesh");
		CalculateTangentsForMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(CalculateTangentsForMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalculateTangentsForMesh_Vertices_PropertyAddress, CalculateTangentsForMesh_FunctionAddress, "Vertices");
		CalculateTangentsForMesh_Vertices_Offset = NativeReflectionCached.GetPropertyOffset(CalculateTangentsForMesh_FunctionAddress, "Vertices");
		CalculateTangentsForMesh_Vertices_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateTangentsForMesh_FunctionAddress, "Vertices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateTangentsForMesh_Triangles_PropertyAddress, CalculateTangentsForMesh_FunctionAddress, "Triangles");
		CalculateTangentsForMesh_Triangles_Offset = NativeReflectionCached.GetPropertyOffset(CalculateTangentsForMesh_FunctionAddress, "Triangles");
		CalculateTangentsForMesh_Triangles_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateTangentsForMesh_FunctionAddress, "Triangles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateTangentsForMesh_UVs_PropertyAddress, CalculateTangentsForMesh_FunctionAddress, "UVs");
		CalculateTangentsForMesh_UVs_Offset = NativeReflectionCached.GetPropertyOffset(CalculateTangentsForMesh_FunctionAddress, "UVs");
		CalculateTangentsForMesh_UVs_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateTangentsForMesh_FunctionAddress, "UVs", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateTangentsForMesh_Normals_PropertyAddress, CalculateTangentsForMesh_FunctionAddress, "Normals");
		CalculateTangentsForMesh_Normals_Offset = NativeReflectionCached.GetPropertyOffset(CalculateTangentsForMesh_FunctionAddress, "Normals");
		CalculateTangentsForMesh_Normals_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateTangentsForMesh_FunctionAddress, "Normals", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateTangentsForMesh_Tangents_PropertyAddress, CalculateTangentsForMesh_FunctionAddress, "Tangents");
		CalculateTangentsForMesh_Tangents_Offset = NativeReflectionCached.GetPropertyOffset(CalculateTangentsForMesh_FunctionAddress, "Tangents");
		CalculateTangentsForMesh_Tangents_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateTangentsForMesh_FunctionAddress, "Tangents", Classes.FArrayProperty);
		CalculateTangentsForMesh_IsValid = CalculateTangentsForMesh_FunctionAddress != IntPtr.Zero && CalculateTangentsForMesh_Vertices_IsValid && CalculateTangentsForMesh_Triangles_IsValid && CalculateTangentsForMesh_UVs_IsValid && CalculateTangentsForMesh_Normals_IsValid && CalculateTangentsForMesh_Tangents_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary:CalculateTangentsForMesh", CalculateTangentsForMesh_IsValid);
	}
}
