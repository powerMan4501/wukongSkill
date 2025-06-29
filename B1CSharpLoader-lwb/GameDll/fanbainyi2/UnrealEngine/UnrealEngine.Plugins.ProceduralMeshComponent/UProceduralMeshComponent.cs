using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ProceduralMeshComponent;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/ProceduralMeshComponent.ProceduralMeshComponent", "ProceduralMeshComponent", UnrealModuleType.EnginePlugin)]
public class UProceduralMeshComponent : UMeshComponent, IInterface_CollisionDataProvider, IInterface
{
	private static bool UseComplexAsSimpleCollision_IsValid;

	private static FFieldAddress UseComplexAsSimpleCollision_PropertyAddress;

	private static int UseComplexAsSimpleCollision_Offset;

	private static bool UseAsyncCooking_IsValid;

	private static FFieldAddress UseAsyncCooking_PropertyAddress;

	private static int UseAsyncCooking_Offset;

	private static bool UpdateMeshSection_LinearColor_IsValid;

	private static IntPtr UpdateMeshSection_LinearColor_FunctionAddress;

	private static int UpdateMeshSection_LinearColor_ParamsSize;

	private static bool UpdateMeshSection_LinearColor_SectionIndex_IsValid;

	private static FFieldAddress UpdateMeshSection_LinearColor_SectionIndex_PropertyAddress;

	private static int UpdateMeshSection_LinearColor_SectionIndex_Offset;

	private static bool UpdateMeshSection_LinearColor_Vertices_IsValid;

	private static FFieldAddress UpdateMeshSection_LinearColor_Vertices_PropertyAddress;

	private static int UpdateMeshSection_LinearColor_Vertices_Offset;

	private static bool UpdateMeshSection_LinearColor_Normals_IsValid;

	private static FFieldAddress UpdateMeshSection_LinearColor_Normals_PropertyAddress;

	private static int UpdateMeshSection_LinearColor_Normals_Offset;

	private static bool UpdateMeshSection_LinearColor_UV0_IsValid;

	private static FFieldAddress UpdateMeshSection_LinearColor_UV0_PropertyAddress;

	private static int UpdateMeshSection_LinearColor_UV0_Offset;

	private static bool UpdateMeshSection_LinearColor_UV1_IsValid;

	private static FFieldAddress UpdateMeshSection_LinearColor_UV1_PropertyAddress;

	private static int UpdateMeshSection_LinearColor_UV1_Offset;

	private static bool UpdateMeshSection_LinearColor_UV2_IsValid;

	private static FFieldAddress UpdateMeshSection_LinearColor_UV2_PropertyAddress;

	private static int UpdateMeshSection_LinearColor_UV2_Offset;

	private static bool UpdateMeshSection_LinearColor_UV3_IsValid;

	private static FFieldAddress UpdateMeshSection_LinearColor_UV3_PropertyAddress;

	private static int UpdateMeshSection_LinearColor_UV3_Offset;

	private static bool UpdateMeshSection_LinearColor_VertexColors_IsValid;

	private static FFieldAddress UpdateMeshSection_LinearColor_VertexColors_PropertyAddress;

	private static int UpdateMeshSection_LinearColor_VertexColors_Offset;

	private static bool UpdateMeshSection_LinearColor_Tangents_IsValid;

	private static FFieldAddress UpdateMeshSection_LinearColor_Tangents_PropertyAddress;

	private static int UpdateMeshSection_LinearColor_Tangents_Offset;

	private static bool SetMeshSectionVisible_IsValid;

	private static IntPtr SetMeshSectionVisible_FunctionAddress;

	private static int SetMeshSectionVisible_ParamsSize;

	private static bool SetMeshSectionVisible_SectionIndex_IsValid;

	private static FFieldAddress SetMeshSectionVisible_SectionIndex_PropertyAddress;

	private static int SetMeshSectionVisible_SectionIndex_Offset;

	private static bool SetMeshSectionVisible_bNewVisibility_IsValid;

	private static FFieldAddress SetMeshSectionVisible_bNewVisibility_PropertyAddress;

	private static int SetMeshSectionVisible_bNewVisibility_Offset;

	private static bool IsMeshSectionVisible_IsValid;

	private static IntPtr IsMeshSectionVisible_FunctionAddress;

	private static int IsMeshSectionVisible_ParamsSize;

	private static bool IsMeshSectionVisible_SectionIndex_IsValid;

	private static FFieldAddress IsMeshSectionVisible_SectionIndex_PropertyAddress;

	private static int IsMeshSectionVisible_SectionIndex_Offset;

	private static bool IsMeshSectionVisible_ReturnValue_IsValid;

	private static FFieldAddress IsMeshSectionVisible_ReturnValue_PropertyAddress;

	private static int IsMeshSectionVisible_ReturnValue_Offset;

	private static bool GetNumSections_IsValid;

	private static IntPtr GetNumSections_FunctionAddress;

	private static int GetNumSections_ParamsSize;

	private static bool GetNumSections_ReturnValue_IsValid;

	private static FFieldAddress GetNumSections_ReturnValue_PropertyAddress;

	private static int GetNumSections_ReturnValue_Offset;

	private static bool CreateMeshSection_LinearColor_IsValid;

	private static IntPtr CreateMeshSection_LinearColor_FunctionAddress;

	private static int CreateMeshSection_LinearColor_ParamsSize;

	private static bool CreateMeshSection_LinearColor_SectionIndex_IsValid;

	private static FFieldAddress CreateMeshSection_LinearColor_SectionIndex_PropertyAddress;

	private static int CreateMeshSection_LinearColor_SectionIndex_Offset;

	private static bool CreateMeshSection_LinearColor_Vertices_IsValid;

	private static FFieldAddress CreateMeshSection_LinearColor_Vertices_PropertyAddress;

	private static int CreateMeshSection_LinearColor_Vertices_Offset;

	private static bool CreateMeshSection_LinearColor_Triangles_IsValid;

	private static FFieldAddress CreateMeshSection_LinearColor_Triangles_PropertyAddress;

	private static int CreateMeshSection_LinearColor_Triangles_Offset;

	private static bool CreateMeshSection_LinearColor_Normals_IsValid;

	private static FFieldAddress CreateMeshSection_LinearColor_Normals_PropertyAddress;

	private static int CreateMeshSection_LinearColor_Normals_Offset;

	private static bool CreateMeshSection_LinearColor_UV0_IsValid;

	private static FFieldAddress CreateMeshSection_LinearColor_UV0_PropertyAddress;

	private static int CreateMeshSection_LinearColor_UV0_Offset;

	private static bool CreateMeshSection_LinearColor_UV1_IsValid;

	private static FFieldAddress CreateMeshSection_LinearColor_UV1_PropertyAddress;

	private static int CreateMeshSection_LinearColor_UV1_Offset;

	private static bool CreateMeshSection_LinearColor_UV2_IsValid;

	private static FFieldAddress CreateMeshSection_LinearColor_UV2_PropertyAddress;

	private static int CreateMeshSection_LinearColor_UV2_Offset;

	private static bool CreateMeshSection_LinearColor_UV3_IsValid;

	private static FFieldAddress CreateMeshSection_LinearColor_UV3_PropertyAddress;

	private static int CreateMeshSection_LinearColor_UV3_Offset;

	private static bool CreateMeshSection_LinearColor_VertexColors_IsValid;

	private static FFieldAddress CreateMeshSection_LinearColor_VertexColors_PropertyAddress;

	private static int CreateMeshSection_LinearColor_VertexColors_Offset;

	private static bool CreateMeshSection_LinearColor_Tangents_IsValid;

	private static FFieldAddress CreateMeshSection_LinearColor_Tangents_PropertyAddress;

	private static int CreateMeshSection_LinearColor_Tangents_Offset;

	private static bool CreateMeshSection_LinearColor_bCreateCollision_IsValid;

	private static FFieldAddress CreateMeshSection_LinearColor_bCreateCollision_PropertyAddress;

	private static int CreateMeshSection_LinearColor_bCreateCollision_Offset;

	private static bool ClearMeshSection_IsValid;

	private static IntPtr ClearMeshSection_FunctionAddress;

	private static int ClearMeshSection_ParamsSize;

	private static bool ClearMeshSection_SectionIndex_IsValid;

	private static FFieldAddress ClearMeshSection_SectionIndex_PropertyAddress;

	private static int ClearMeshSection_SectionIndex_Offset;

	private static bool ClearCollisionConvexMeshes_IsValid;

	private static IntPtr ClearCollisionConvexMeshes_FunctionAddress;

	private static int ClearCollisionConvexMeshes_ParamsSize;

	private static bool ClearAllMeshSections_IsValid;

	private static IntPtr ClearAllMeshSections_FunctionAddress;

	private static int ClearAllMeshSections_ParamsSize;

	private static bool AddCollisionConvexMesh_IsValid;

	private static IntPtr AddCollisionConvexMesh_FunctionAddress;

	private static int AddCollisionConvexMesh_ParamsSize;

	private static bool AddCollisionConvexMesh_ConvexVerts_IsValid;

	private static FFieldAddress AddCollisionConvexMesh_ConvexVerts_PropertyAddress;

	private static int AddCollisionConvexMesh_ConvexVerts_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/ProceduralMeshComponent.ProceduralMeshComponent:bUseComplexAsSimpleCollision")]
	public bool UseComplexAsSimpleCollision
	{
		get
		{
			CheckDestroyed();
			if (!UseComplexAsSimpleCollision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ProceduralMeshComponent.ProceduralMeshComponent:bUseComplexAsSimpleCollision");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseComplexAsSimpleCollision_Offset), 0, UseComplexAsSimpleCollision_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseComplexAsSimpleCollision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ProceduralMeshComponent.ProceduralMeshComponent:bUseComplexAsSimpleCollision");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseComplexAsSimpleCollision_Offset), 0, UseComplexAsSimpleCollision_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/ProceduralMeshComponent.ProceduralMeshComponent:bUseAsyncCooking")]
	public bool UseAsyncCooking
	{
		get
		{
			CheckDestroyed();
			if (!UseAsyncCooking_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ProceduralMeshComponent.ProceduralMeshComponent:bUseAsyncCooking");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseAsyncCooking_Offset), 0, UseAsyncCooking_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseAsyncCooking_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ProceduralMeshComponent.ProceduralMeshComponent:bUseAsyncCooking");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseAsyncCooking_Offset), 0, UseAsyncCooking_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/ProceduralMeshComponent.ProceduralMeshComponent:UpdateMeshSection_LinearColor")]
	public unsafe void UpdateMeshSection_LinearColor(int SectionIndex, List<FVector> Vertices, List<FVector> Normals, List<FVector2D> UV0, List<FVector2D> UV1, List<FVector2D> UV2, List<FVector2D> UV3, List<FLinearColor> VertexColors, List<FProcMeshTangent> Tangents)
	{
		CheckDestroyed();
		if (!UpdateMeshSection_LinearColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ProceduralMeshComponent.ProceduralMeshComponent:UpdateMeshSection_LinearColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateMeshSection_LinearColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateMeshSection_LinearColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, UpdateMeshSection_LinearColor_SectionIndex_Offset), 0, UpdateMeshSection_LinearColor_SectionIndex_PropertyAddress.Address, SectionIndex);
		new TArrayCopyMarshaler<FVector>(1, UpdateMeshSection_LinearColor_Vertices_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, UpdateMeshSection_LinearColor_Vertices_Offset), Vertices);
		new TArrayCopyMarshaler<FVector>(1, UpdateMeshSection_LinearColor_Normals_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, UpdateMeshSection_LinearColor_Normals_Offset), Normals);
		new TArrayCopyMarshaler<FVector2D>(1, UpdateMeshSection_LinearColor_UV0_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(intPtr, UpdateMeshSection_LinearColor_UV0_Offset), UV0);
		new TArrayCopyMarshaler<FVector2D>(1, UpdateMeshSection_LinearColor_UV1_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(intPtr, UpdateMeshSection_LinearColor_UV1_Offset), UV1);
		new TArrayCopyMarshaler<FVector2D>(1, UpdateMeshSection_LinearColor_UV2_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(intPtr, UpdateMeshSection_LinearColor_UV2_Offset), UV2);
		new TArrayCopyMarshaler<FVector2D>(1, UpdateMeshSection_LinearColor_UV3_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(intPtr, UpdateMeshSection_LinearColor_UV3_Offset), UV3);
		new TArrayCopyMarshaler<FLinearColor>(1, UpdateMeshSection_LinearColor_VertexColors_PropertyAddress, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.FromNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.ToNative).ToNative(IntPtr.Add(intPtr, UpdateMeshSection_LinearColor_VertexColors_Offset), VertexColors);
		new TArrayCopyMarshaler<FProcMeshTangent>(1, UpdateMeshSection_LinearColor_Tangents_PropertyAddress, CachedMarshalingDelegates<FProcMeshTangent, FProcMeshTangent>.FromNative, CachedMarshalingDelegates<FProcMeshTangent, FProcMeshTangent>.ToNative).ToNative(IntPtr.Add(intPtr, UpdateMeshSection_LinearColor_Tangents_Offset), Tangents);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateMeshSection_LinearColor_FunctionAddress, intPtr, UpdateMeshSection_LinearColor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UpdateMeshSection_LinearColor_Vertices_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(UpdateMeshSection_LinearColor_Normals_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(UpdateMeshSection_LinearColor_UV0_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(UpdateMeshSection_LinearColor_UV1_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(UpdateMeshSection_LinearColor_UV2_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(UpdateMeshSection_LinearColor_UV3_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(UpdateMeshSection_LinearColor_VertexColors_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(UpdateMeshSection_LinearColor_Tangents_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ProceduralMeshComponent.ProceduralMeshComponent:SetMeshSectionVisible")]
	public unsafe void SetMeshSectionVisible(int SectionIndex, bool bNewVisibility)
	{
		CheckDestroyed();
		if (!SetMeshSectionVisible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ProceduralMeshComponent.ProceduralMeshComponent:SetMeshSectionVisible");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMeshSectionVisible_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMeshSectionVisible_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMeshSectionVisible_SectionIndex_Offset), 0, SetMeshSectionVisible_SectionIndex_PropertyAddress.Address, SectionIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetMeshSectionVisible_bNewVisibility_Offset), 0, SetMeshSectionVisible_bNewVisibility_PropertyAddress.Address, bNewVisibility);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMeshSectionVisible_FunctionAddress, intPtr, SetMeshSectionVisible_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ProceduralMeshComponent.ProceduralMeshComponent:IsMeshSectionVisible")]
	public unsafe bool IsMeshSectionVisible(int SectionIndex)
	{
		CheckDestroyed();
		if (!IsMeshSectionVisible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ProceduralMeshComponent.ProceduralMeshComponent:IsMeshSectionVisible");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsMeshSectionVisible_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsMeshSectionVisible_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, IsMeshSectionVisible_SectionIndex_Offset), 0, IsMeshSectionVisible_SectionIndex_PropertyAddress.Address, SectionIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsMeshSectionVisible_FunctionAddress, intPtr, IsMeshSectionVisible_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsMeshSectionVisible_ReturnValue_Offset), 0, IsMeshSectionVisible_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ProceduralMeshComponent.ProceduralMeshComponent:GetNumSections")]
	public unsafe int GetNumSections()
	{
		CheckDestroyed();
		if (!GetNumSections_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ProceduralMeshComponent.ProceduralMeshComponent:GetNumSections");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumSections_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumSections_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumSections_FunctionAddress, intPtr, GetNumSections_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumSections_ReturnValue_Offset), 0, GetNumSections_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/ProceduralMeshComponent.ProceduralMeshComponent:CreateMeshSection_LinearColor")]
	public unsafe void CreateMeshSection_LinearColor(int SectionIndex, List<FVector> Vertices, List<int> Triangles, List<FVector> Normals, List<FVector2D> UV0, List<FVector2D> UV1, List<FVector2D> UV2, List<FVector2D> UV3, List<FLinearColor> VertexColors, List<FProcMeshTangent> Tangents, bool bCreateCollision)
	{
		CheckDestroyed();
		if (!CreateMeshSection_LinearColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ProceduralMeshComponent.ProceduralMeshComponent:CreateMeshSection_LinearColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateMeshSection_LinearColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateMeshSection_LinearColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateMeshSection_LinearColor_SectionIndex_Offset), 0, CreateMeshSection_LinearColor_SectionIndex_PropertyAddress.Address, SectionIndex);
		new TArrayCopyMarshaler<FVector>(1, CreateMeshSection_LinearColor_Vertices_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, CreateMeshSection_LinearColor_Vertices_Offset), Vertices);
		new TArrayCopyMarshaler<int>(1, CreateMeshSection_LinearColor_Triangles_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, CreateMeshSection_LinearColor_Triangles_Offset), Triangles);
		new TArrayCopyMarshaler<FVector>(1, CreateMeshSection_LinearColor_Normals_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, CreateMeshSection_LinearColor_Normals_Offset), Normals);
		new TArrayCopyMarshaler<FVector2D>(1, CreateMeshSection_LinearColor_UV0_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(intPtr, CreateMeshSection_LinearColor_UV0_Offset), UV0);
		new TArrayCopyMarshaler<FVector2D>(1, CreateMeshSection_LinearColor_UV1_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(intPtr, CreateMeshSection_LinearColor_UV1_Offset), UV1);
		new TArrayCopyMarshaler<FVector2D>(1, CreateMeshSection_LinearColor_UV2_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(intPtr, CreateMeshSection_LinearColor_UV2_Offset), UV2);
		new TArrayCopyMarshaler<FVector2D>(1, CreateMeshSection_LinearColor_UV3_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(intPtr, CreateMeshSection_LinearColor_UV3_Offset), UV3);
		new TArrayCopyMarshaler<FLinearColor>(1, CreateMeshSection_LinearColor_VertexColors_PropertyAddress, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.FromNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.ToNative).ToNative(IntPtr.Add(intPtr, CreateMeshSection_LinearColor_VertexColors_Offset), VertexColors);
		new TArrayCopyMarshaler<FProcMeshTangent>(1, CreateMeshSection_LinearColor_Tangents_PropertyAddress, CachedMarshalingDelegates<FProcMeshTangent, FProcMeshTangent>.FromNative, CachedMarshalingDelegates<FProcMeshTangent, FProcMeshTangent>.ToNative).ToNative(IntPtr.Add(intPtr, CreateMeshSection_LinearColor_Tangents_Offset), Tangents);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateMeshSection_LinearColor_bCreateCollision_Offset), 0, CreateMeshSection_LinearColor_bCreateCollision_PropertyAddress.Address, bCreateCollision);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateMeshSection_LinearColor_FunctionAddress, intPtr, CreateMeshSection_LinearColor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateMeshSection_LinearColor_Vertices_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateMeshSection_LinearColor_Triangles_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateMeshSection_LinearColor_Normals_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateMeshSection_LinearColor_UV0_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateMeshSection_LinearColor_UV1_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateMeshSection_LinearColor_UV2_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateMeshSection_LinearColor_UV3_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateMeshSection_LinearColor_VertexColors_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateMeshSection_LinearColor_Tangents_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ProceduralMeshComponent.ProceduralMeshComponent:ClearMeshSection")]
	public unsafe void ClearMeshSection(int SectionIndex)
	{
		CheckDestroyed();
		if (!ClearMeshSection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ProceduralMeshComponent.ProceduralMeshComponent:ClearMeshSection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearMeshSection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearMeshSection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ClearMeshSection_SectionIndex_Offset), 0, ClearMeshSection_SectionIndex_PropertyAddress.Address, SectionIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClearMeshSection_FunctionAddress, intPtr, ClearMeshSection_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ProceduralMeshComponent.ProceduralMeshComponent:ClearCollisionConvexMeshes")]
	public unsafe void ClearCollisionConvexMeshes()
	{
		CheckDestroyed();
		if (!ClearCollisionConvexMeshes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ProceduralMeshComponent.ProceduralMeshComponent:ClearCollisionConvexMeshes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearCollisionConvexMeshes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearCollisionConvexMeshes_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearCollisionConvexMeshes_FunctionAddress, argsSize: ClearCollisionConvexMeshes_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ProceduralMeshComponent.ProceduralMeshComponent:ClearAllMeshSections")]
	public unsafe void ClearAllMeshSections()
	{
		CheckDestroyed();
		if (!ClearAllMeshSections_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ProceduralMeshComponent.ProceduralMeshComponent:ClearAllMeshSections");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearAllMeshSections_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearAllMeshSections_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearAllMeshSections_FunctionAddress, argsSize: ClearAllMeshSections_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ProceduralMeshComponent.ProceduralMeshComponent:AddCollisionConvexMesh")]
	public unsafe void AddCollisionConvexMesh(List<FVector> ConvexVerts)
	{
		CheckDestroyed();
		if (!AddCollisionConvexMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ProceduralMeshComponent.ProceduralMeshComponent:AddCollisionConvexMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddCollisionConvexMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddCollisionConvexMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, AddCollisionConvexMesh_ConvexVerts_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, AddCollisionConvexMesh_ConvexVerts_Offset), ConvexVerts);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddCollisionConvexMesh_FunctionAddress, intPtr, AddCollisionConvexMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddCollisionConvexMesh_ConvexVerts_PropertyAddress.Address, intPtr);
	}

	static UProceduralMeshComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UProceduralMeshComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UProceduralMeshComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/ProceduralMeshComponent.ProceduralMeshComponent");
		NativeReflectionCached.GetPropertyRef(ref UseComplexAsSimpleCollision_PropertyAddress, intPtr, "bUseComplexAsSimpleCollision");
		UseComplexAsSimpleCollision_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseComplexAsSimpleCollision");
		UseComplexAsSimpleCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseComplexAsSimpleCollision", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseAsyncCooking_PropertyAddress, intPtr, "bUseAsyncCooking");
		UseAsyncCooking_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseAsyncCooking");
		UseAsyncCooking_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseAsyncCooking", Classes.FBoolProperty);
		UpdateMeshSection_LinearColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateMeshSection_LinearColor");
		UpdateMeshSection_LinearColor_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateMeshSection_LinearColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateMeshSection_LinearColor_SectionIndex_PropertyAddress, UpdateMeshSection_LinearColor_FunctionAddress, "SectionIndex");
		UpdateMeshSection_LinearColor_SectionIndex_Offset = NativeReflectionCached.GetPropertyOffset(UpdateMeshSection_LinearColor_FunctionAddress, "SectionIndex");
		UpdateMeshSection_LinearColor_SectionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateMeshSection_LinearColor_FunctionAddress, "SectionIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateMeshSection_LinearColor_Vertices_PropertyAddress, UpdateMeshSection_LinearColor_FunctionAddress, "Vertices");
		UpdateMeshSection_LinearColor_Vertices_Offset = NativeReflectionCached.GetPropertyOffset(UpdateMeshSection_LinearColor_FunctionAddress, "Vertices");
		UpdateMeshSection_LinearColor_Vertices_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateMeshSection_LinearColor_FunctionAddress, "Vertices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateMeshSection_LinearColor_Normals_PropertyAddress, UpdateMeshSection_LinearColor_FunctionAddress, "Normals");
		UpdateMeshSection_LinearColor_Normals_Offset = NativeReflectionCached.GetPropertyOffset(UpdateMeshSection_LinearColor_FunctionAddress, "Normals");
		UpdateMeshSection_LinearColor_Normals_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateMeshSection_LinearColor_FunctionAddress, "Normals", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateMeshSection_LinearColor_UV0_PropertyAddress, UpdateMeshSection_LinearColor_FunctionAddress, "UV0");
		UpdateMeshSection_LinearColor_UV0_Offset = NativeReflectionCached.GetPropertyOffset(UpdateMeshSection_LinearColor_FunctionAddress, "UV0");
		UpdateMeshSection_LinearColor_UV0_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateMeshSection_LinearColor_FunctionAddress, "UV0", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateMeshSection_LinearColor_UV1_PropertyAddress, UpdateMeshSection_LinearColor_FunctionAddress, "UV1");
		UpdateMeshSection_LinearColor_UV1_Offset = NativeReflectionCached.GetPropertyOffset(UpdateMeshSection_LinearColor_FunctionAddress, "UV1");
		UpdateMeshSection_LinearColor_UV1_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateMeshSection_LinearColor_FunctionAddress, "UV1", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateMeshSection_LinearColor_UV2_PropertyAddress, UpdateMeshSection_LinearColor_FunctionAddress, "UV2");
		UpdateMeshSection_LinearColor_UV2_Offset = NativeReflectionCached.GetPropertyOffset(UpdateMeshSection_LinearColor_FunctionAddress, "UV2");
		UpdateMeshSection_LinearColor_UV2_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateMeshSection_LinearColor_FunctionAddress, "UV2", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateMeshSection_LinearColor_UV3_PropertyAddress, UpdateMeshSection_LinearColor_FunctionAddress, "UV3");
		UpdateMeshSection_LinearColor_UV3_Offset = NativeReflectionCached.GetPropertyOffset(UpdateMeshSection_LinearColor_FunctionAddress, "UV3");
		UpdateMeshSection_LinearColor_UV3_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateMeshSection_LinearColor_FunctionAddress, "UV3", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateMeshSection_LinearColor_VertexColors_PropertyAddress, UpdateMeshSection_LinearColor_FunctionAddress, "VertexColors");
		UpdateMeshSection_LinearColor_VertexColors_Offset = NativeReflectionCached.GetPropertyOffset(UpdateMeshSection_LinearColor_FunctionAddress, "VertexColors");
		UpdateMeshSection_LinearColor_VertexColors_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateMeshSection_LinearColor_FunctionAddress, "VertexColors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateMeshSection_LinearColor_Tangents_PropertyAddress, UpdateMeshSection_LinearColor_FunctionAddress, "Tangents");
		UpdateMeshSection_LinearColor_Tangents_Offset = NativeReflectionCached.GetPropertyOffset(UpdateMeshSection_LinearColor_FunctionAddress, "Tangents");
		UpdateMeshSection_LinearColor_Tangents_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateMeshSection_LinearColor_FunctionAddress, "Tangents", Classes.FArrayProperty);
		UpdateMeshSection_LinearColor_IsValid = UpdateMeshSection_LinearColor_FunctionAddress != IntPtr.Zero && UpdateMeshSection_LinearColor_SectionIndex_IsValid && UpdateMeshSection_LinearColor_Vertices_IsValid && UpdateMeshSection_LinearColor_Normals_IsValid && UpdateMeshSection_LinearColor_UV0_IsValid && UpdateMeshSection_LinearColor_UV1_IsValid && UpdateMeshSection_LinearColor_UV2_IsValid && UpdateMeshSection_LinearColor_UV3_IsValid && UpdateMeshSection_LinearColor_VertexColors_IsValid && UpdateMeshSection_LinearColor_Tangents_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ProceduralMeshComponent.ProceduralMeshComponent:UpdateMeshSection_LinearColor", UpdateMeshSection_LinearColor_IsValid);
		SetMeshSectionVisible_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMeshSectionVisible");
		SetMeshSectionVisible_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMeshSectionVisible_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMeshSectionVisible_SectionIndex_PropertyAddress, SetMeshSectionVisible_FunctionAddress, "SectionIndex");
		SetMeshSectionVisible_SectionIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshSectionVisible_FunctionAddress, "SectionIndex");
		SetMeshSectionVisible_SectionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshSectionVisible_FunctionAddress, "SectionIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshSectionVisible_bNewVisibility_PropertyAddress, SetMeshSectionVisible_FunctionAddress, "bNewVisibility");
		SetMeshSectionVisible_bNewVisibility_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshSectionVisible_FunctionAddress, "bNewVisibility");
		SetMeshSectionVisible_bNewVisibility_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshSectionVisible_FunctionAddress, "bNewVisibility", Classes.FBoolProperty);
		SetMeshSectionVisible_IsValid = SetMeshSectionVisible_FunctionAddress != IntPtr.Zero && SetMeshSectionVisible_SectionIndex_IsValid && SetMeshSectionVisible_bNewVisibility_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ProceduralMeshComponent.ProceduralMeshComponent:SetMeshSectionVisible", SetMeshSectionVisible_IsValid);
		IsMeshSectionVisible_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsMeshSectionVisible");
		IsMeshSectionVisible_ParamsSize = NativeReflection.GetFunctionParamsSize(IsMeshSectionVisible_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsMeshSectionVisible_SectionIndex_PropertyAddress, IsMeshSectionVisible_FunctionAddress, "SectionIndex");
		IsMeshSectionVisible_SectionIndex_Offset = NativeReflectionCached.GetPropertyOffset(IsMeshSectionVisible_FunctionAddress, "SectionIndex");
		IsMeshSectionVisible_SectionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMeshSectionVisible_FunctionAddress, "SectionIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IsMeshSectionVisible_ReturnValue_PropertyAddress, IsMeshSectionVisible_FunctionAddress, "ReturnValue");
		IsMeshSectionVisible_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsMeshSectionVisible_FunctionAddress, "ReturnValue");
		IsMeshSectionVisible_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMeshSectionVisible_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsMeshSectionVisible_IsValid = IsMeshSectionVisible_FunctionAddress != IntPtr.Zero && IsMeshSectionVisible_SectionIndex_IsValid && IsMeshSectionVisible_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ProceduralMeshComponent.ProceduralMeshComponent:IsMeshSectionVisible", IsMeshSectionVisible_IsValid);
		GetNumSections_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumSections");
		GetNumSections_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumSections_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumSections_ReturnValue_PropertyAddress, GetNumSections_FunctionAddress, "ReturnValue");
		GetNumSections_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumSections_FunctionAddress, "ReturnValue");
		GetNumSections_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumSections_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumSections_IsValid = GetNumSections_FunctionAddress != IntPtr.Zero && GetNumSections_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ProceduralMeshComponent.ProceduralMeshComponent:GetNumSections", GetNumSections_IsValid);
		CreateMeshSection_LinearColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CreateMeshSection_LinearColor");
		CreateMeshSection_LinearColor_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateMeshSection_LinearColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateMeshSection_LinearColor_SectionIndex_PropertyAddress, CreateMeshSection_LinearColor_FunctionAddress, "SectionIndex");
		CreateMeshSection_LinearColor_SectionIndex_Offset = NativeReflectionCached.GetPropertyOffset(CreateMeshSection_LinearColor_FunctionAddress, "SectionIndex");
		CreateMeshSection_LinearColor_SectionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateMeshSection_LinearColor_FunctionAddress, "SectionIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateMeshSection_LinearColor_Vertices_PropertyAddress, CreateMeshSection_LinearColor_FunctionAddress, "Vertices");
		CreateMeshSection_LinearColor_Vertices_Offset = NativeReflectionCached.GetPropertyOffset(CreateMeshSection_LinearColor_FunctionAddress, "Vertices");
		CreateMeshSection_LinearColor_Vertices_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateMeshSection_LinearColor_FunctionAddress, "Vertices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateMeshSection_LinearColor_Triangles_PropertyAddress, CreateMeshSection_LinearColor_FunctionAddress, "Triangles");
		CreateMeshSection_LinearColor_Triangles_Offset = NativeReflectionCached.GetPropertyOffset(CreateMeshSection_LinearColor_FunctionAddress, "Triangles");
		CreateMeshSection_LinearColor_Triangles_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateMeshSection_LinearColor_FunctionAddress, "Triangles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateMeshSection_LinearColor_Normals_PropertyAddress, CreateMeshSection_LinearColor_FunctionAddress, "Normals");
		CreateMeshSection_LinearColor_Normals_Offset = NativeReflectionCached.GetPropertyOffset(CreateMeshSection_LinearColor_FunctionAddress, "Normals");
		CreateMeshSection_LinearColor_Normals_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateMeshSection_LinearColor_FunctionAddress, "Normals", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateMeshSection_LinearColor_UV0_PropertyAddress, CreateMeshSection_LinearColor_FunctionAddress, "UV0");
		CreateMeshSection_LinearColor_UV0_Offset = NativeReflectionCached.GetPropertyOffset(CreateMeshSection_LinearColor_FunctionAddress, "UV0");
		CreateMeshSection_LinearColor_UV0_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateMeshSection_LinearColor_FunctionAddress, "UV0", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateMeshSection_LinearColor_UV1_PropertyAddress, CreateMeshSection_LinearColor_FunctionAddress, "UV1");
		CreateMeshSection_LinearColor_UV1_Offset = NativeReflectionCached.GetPropertyOffset(CreateMeshSection_LinearColor_FunctionAddress, "UV1");
		CreateMeshSection_LinearColor_UV1_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateMeshSection_LinearColor_FunctionAddress, "UV1", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateMeshSection_LinearColor_UV2_PropertyAddress, CreateMeshSection_LinearColor_FunctionAddress, "UV2");
		CreateMeshSection_LinearColor_UV2_Offset = NativeReflectionCached.GetPropertyOffset(CreateMeshSection_LinearColor_FunctionAddress, "UV2");
		CreateMeshSection_LinearColor_UV2_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateMeshSection_LinearColor_FunctionAddress, "UV2", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateMeshSection_LinearColor_UV3_PropertyAddress, CreateMeshSection_LinearColor_FunctionAddress, "UV3");
		CreateMeshSection_LinearColor_UV3_Offset = NativeReflectionCached.GetPropertyOffset(CreateMeshSection_LinearColor_FunctionAddress, "UV3");
		CreateMeshSection_LinearColor_UV3_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateMeshSection_LinearColor_FunctionAddress, "UV3", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateMeshSection_LinearColor_VertexColors_PropertyAddress, CreateMeshSection_LinearColor_FunctionAddress, "VertexColors");
		CreateMeshSection_LinearColor_VertexColors_Offset = NativeReflectionCached.GetPropertyOffset(CreateMeshSection_LinearColor_FunctionAddress, "VertexColors");
		CreateMeshSection_LinearColor_VertexColors_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateMeshSection_LinearColor_FunctionAddress, "VertexColors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateMeshSection_LinearColor_Tangents_PropertyAddress, CreateMeshSection_LinearColor_FunctionAddress, "Tangents");
		CreateMeshSection_LinearColor_Tangents_Offset = NativeReflectionCached.GetPropertyOffset(CreateMeshSection_LinearColor_FunctionAddress, "Tangents");
		CreateMeshSection_LinearColor_Tangents_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateMeshSection_LinearColor_FunctionAddress, "Tangents", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateMeshSection_LinearColor_bCreateCollision_PropertyAddress, CreateMeshSection_LinearColor_FunctionAddress, "bCreateCollision");
		CreateMeshSection_LinearColor_bCreateCollision_Offset = NativeReflectionCached.GetPropertyOffset(CreateMeshSection_LinearColor_FunctionAddress, "bCreateCollision");
		CreateMeshSection_LinearColor_bCreateCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateMeshSection_LinearColor_FunctionAddress, "bCreateCollision", Classes.FBoolProperty);
		CreateMeshSection_LinearColor_IsValid = CreateMeshSection_LinearColor_FunctionAddress != IntPtr.Zero && CreateMeshSection_LinearColor_SectionIndex_IsValid && CreateMeshSection_LinearColor_Vertices_IsValid && CreateMeshSection_LinearColor_Triangles_IsValid && CreateMeshSection_LinearColor_Normals_IsValid && CreateMeshSection_LinearColor_UV0_IsValid && CreateMeshSection_LinearColor_UV1_IsValid && CreateMeshSection_LinearColor_UV2_IsValid && CreateMeshSection_LinearColor_UV3_IsValid && CreateMeshSection_LinearColor_VertexColors_IsValid && CreateMeshSection_LinearColor_Tangents_IsValid && CreateMeshSection_LinearColor_bCreateCollision_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ProceduralMeshComponent.ProceduralMeshComponent:CreateMeshSection_LinearColor", CreateMeshSection_LinearColor_IsValid);
		ClearMeshSection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearMeshSection");
		ClearMeshSection_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearMeshSection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearMeshSection_SectionIndex_PropertyAddress, ClearMeshSection_FunctionAddress, "SectionIndex");
		ClearMeshSection_SectionIndex_Offset = NativeReflectionCached.GetPropertyOffset(ClearMeshSection_FunctionAddress, "SectionIndex");
		ClearMeshSection_SectionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearMeshSection_FunctionAddress, "SectionIndex", Classes.FIntProperty);
		ClearMeshSection_IsValid = ClearMeshSection_FunctionAddress != IntPtr.Zero && ClearMeshSection_SectionIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ProceduralMeshComponent.ProceduralMeshComponent:ClearMeshSection", ClearMeshSection_IsValid);
		ClearCollisionConvexMeshes_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearCollisionConvexMeshes");
		ClearCollisionConvexMeshes_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearCollisionConvexMeshes_FunctionAddress);
		ClearCollisionConvexMeshes_IsValid = ClearCollisionConvexMeshes_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/ProceduralMeshComponent.ProceduralMeshComponent:ClearCollisionConvexMeshes", ClearCollisionConvexMeshes_IsValid);
		ClearAllMeshSections_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearAllMeshSections");
		ClearAllMeshSections_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearAllMeshSections_FunctionAddress);
		ClearAllMeshSections_IsValid = ClearAllMeshSections_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/ProceduralMeshComponent.ProceduralMeshComponent:ClearAllMeshSections", ClearAllMeshSections_IsValid);
		AddCollisionConvexMesh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddCollisionConvexMesh");
		AddCollisionConvexMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(AddCollisionConvexMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddCollisionConvexMesh_ConvexVerts_PropertyAddress, AddCollisionConvexMesh_FunctionAddress, "ConvexVerts");
		AddCollisionConvexMesh_ConvexVerts_Offset = NativeReflectionCached.GetPropertyOffset(AddCollisionConvexMesh_FunctionAddress, "ConvexVerts");
		AddCollisionConvexMesh_ConvexVerts_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCollisionConvexMesh_FunctionAddress, "ConvexVerts", Classes.FArrayProperty);
		AddCollisionConvexMesh_IsValid = AddCollisionConvexMesh_FunctionAddress != IntPtr.Zero && AddCollisionConvexMesh_ConvexVerts_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ProceduralMeshComponent.ProceduralMeshComponent:AddCollisionConvexMesh", AddCollisionConvexMesh_IsValid);
	}
}
