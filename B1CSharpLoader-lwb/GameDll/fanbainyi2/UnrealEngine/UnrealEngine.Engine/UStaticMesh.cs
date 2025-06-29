using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.StaticMeshDescription;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413728uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.StaticMesh", "Engine", UnrealModuleType.Engine)]
public class UStaticMesh : UStreamableRenderAsset, IInterface_CollisionDataProvider, IInterface, IInterface_AssetUserData, IInterface_AsyncCompilation
{
	private static IntPtr classAddress;

	private static bool LODForCollision_IsValid;

	private static int LODForCollision_Offset;

	private static bool SetStaticMaterials_IsValid;

	private static IntPtr SetStaticMaterials_FunctionAddress;

	private static int SetStaticMaterials_ParamsSize;

	private static bool SetStaticMaterials_InStaticMaterials_IsValid;

	private static FFieldAddress SetStaticMaterials_InStaticMaterials_PropertyAddress;

	private static int SetStaticMaterials_InStaticMaterials_Offset;

	private static bool SetNumSourceModels_IsValid;

	private static IntPtr SetNumSourceModels_FunctionAddress;

	private static int SetNumSourceModels_ParamsSize;

	private static bool SetNumSourceModels_Num_IsValid;

	private static FFieldAddress SetNumSourceModels_Num_PropertyAddress;

	private static int SetNumSourceModels_Num_Offset;

	private static bool SetMinimumLODForPlatforms_IsValid;

	private static IntPtr SetMinimumLODForPlatforms_FunctionAddress;

	private static int SetMinimumLODForPlatforms_ParamsSize;

	private static bool SetMinimumLODForPlatforms_PlatformMinimumLODs_IsValid;

	private static FFieldAddress SetMinimumLODForPlatforms_PlatformMinimumLODs_PropertyAddress;

	private static int SetMinimumLODForPlatforms_PlatformMinimumLODs_Offset;

	private static bool SetMinimumLODForPlatform_IsValid;

	private static IntPtr SetMinimumLODForPlatform_FunctionAddress;

	private static int SetMinimumLODForPlatform_ParamsSize;

	private static bool SetMinimumLODForPlatform_PlatformName_IsValid;

	private static FFieldAddress SetMinimumLODForPlatform_PlatformName_PropertyAddress;

	private static int SetMinimumLODForPlatform_PlatformName_Offset;

	private static bool SetMinimumLODForPlatform_InMinLOD_IsValid;

	private static FFieldAddress SetMinimumLODForPlatform_InMinLOD_PropertyAddress;

	private static int SetMinimumLODForPlatform_InMinLOD_Offset;

	private static bool SetMaterial_IsValid;

	private static IntPtr SetMaterial_FunctionAddress;

	private static int SetMaterial_ParamsSize;

	private static bool SetMaterial_MaterialIndex_IsValid;

	private static FFieldAddress SetMaterial_MaterialIndex_PropertyAddress;

	private static int SetMaterial_MaterialIndex_Offset;

	private static bool SetMaterial_NewMaterial_IsValid;

	private static FFieldAddress SetMaterial_NewMaterial_PropertyAddress;

	private static int SetMaterial_NewMaterial_Offset;

	private static bool RemoveSocket_IsValid;

	private static IntPtr RemoveSocket_FunctionAddress;

	private static int RemoveSocket_ParamsSize;

	private static bool RemoveSocket_Socket_IsValid;

	private static FFieldAddress RemoveSocket_Socket_PropertyAddress;

	private static int RemoveSocket_Socket_Offset;

	private static bool GetStaticMeshDescription_IsValid;

	private static IntPtr GetStaticMeshDescription_FunctionAddress;

	private static int GetStaticMeshDescription_ParamsSize;

	private static bool GetStaticMeshDescription_LODIndex_IsValid;

	private static FFieldAddress GetStaticMeshDescription_LODIndex_PropertyAddress;

	private static int GetStaticMeshDescription_LODIndex_Offset;

	private static bool GetStaticMeshDescription_ReturnValue_IsValid;

	private static FFieldAddress GetStaticMeshDescription_ReturnValue_PropertyAddress;

	private static int GetStaticMeshDescription_ReturnValue_Offset;

	private static bool GetStaticMaterials_IsValid;

	private static IntPtr GetStaticMaterials_FunctionAddress;

	private static int GetStaticMaterials_ParamsSize;

	private static bool GetStaticMaterials_ReturnValue_IsValid;

	private static FFieldAddress GetStaticMaterials_ReturnValue_PropertyAddress;

	private static int GetStaticMaterials_ReturnValue_Offset;

	private static bool GetNumSections_IsValid;

	private static IntPtr GetNumSections_FunctionAddress;

	private static int GetNumSections_ParamsSize;

	private static bool GetNumSections_InLOD_IsValid;

	private static FFieldAddress GetNumSections_InLOD_PropertyAddress;

	private static int GetNumSections_InLOD_Offset;

	private static bool GetNumSections_ReturnValue_IsValid;

	private static FFieldAddress GetNumSections_ReturnValue_PropertyAddress;

	private static int GetNumSections_ReturnValue_Offset;

	private static bool GetNumLods_IsValid;

	private static IntPtr GetNumLods_FunctionAddress;

	private static int GetNumLods_ParamsSize;

	private static bool GetNumLods_ReturnValue_IsValid;

	private static FFieldAddress GetNumLods_ReturnValue_PropertyAddress;

	private static int GetNumLods_ReturnValue_Offset;

	private static bool GetMinimumLODForQualityLevels_IsValid;

	private static IntPtr GetMinimumLODForQualityLevels_FunctionAddress;

	private static int GetMinimumLODForQualityLevels_ParamsSize;

	private static bool GetMinimumLODForQualityLevels_QualityLevelMinimumLODs_IsValid;

	private static FFieldAddress GetMinimumLODForQualityLevels_QualityLevelMinimumLODs_PropertyAddress;

	private static int GetMinimumLODForQualityLevels_QualityLevelMinimumLODs_Offset;

	private static bool GetMinimumLODForQualityLevel_IsValid;

	private static IntPtr GetMinimumLODForQualityLevel_FunctionAddress;

	private static int GetMinimumLODForQualityLevel_ParamsSize;

	private static bool GetMinimumLODForQualityLevel_QualityLevel_IsValid;

	private static FFieldAddress GetMinimumLODForQualityLevel_QualityLevel_PropertyAddress;

	private static int GetMinimumLODForQualityLevel_QualityLevel_Offset;

	private static bool GetMinimumLODForQualityLevel_ReturnValue_IsValid;

	private static FFieldAddress GetMinimumLODForQualityLevel_ReturnValue_PropertyAddress;

	private static int GetMinimumLODForQualityLevel_ReturnValue_Offset;

	private static bool GetMinimumLODForPlatforms_IsValid;

	private static IntPtr GetMinimumLODForPlatforms_FunctionAddress;

	private static int GetMinimumLODForPlatforms_ParamsSize;

	private static bool GetMinimumLODForPlatforms_PlatformMinimumLODs_IsValid;

	private static FFieldAddress GetMinimumLODForPlatforms_PlatformMinimumLODs_PropertyAddress;

	private static int GetMinimumLODForPlatforms_PlatformMinimumLODs_Offset;

	private static bool GetMinimumLODForPlatform_IsValid;

	private static IntPtr GetMinimumLODForPlatform_FunctionAddress;

	private static int GetMinimumLODForPlatform_ParamsSize;

	private static bool GetMinimumLODForPlatform_PlatformName_IsValid;

	private static FFieldAddress GetMinimumLODForPlatform_PlatformName_PropertyAddress;

	private static int GetMinimumLODForPlatform_PlatformName_Offset;

	private static bool GetMinimumLODForPlatform_ReturnValue_IsValid;

	private static FFieldAddress GetMinimumLODForPlatform_ReturnValue_PropertyAddress;

	private static int GetMinimumLODForPlatform_ReturnValue_Offset;

	private static bool GetMaterialIndex_IsValid;

	private static IntPtr GetMaterialIndex_FunctionAddress;

	private static int GetMaterialIndex_ParamsSize;

	private static bool GetMaterialIndex_MaterialSlotName_IsValid;

	private static FFieldAddress GetMaterialIndex_MaterialSlotName_PropertyAddress;

	private static int GetMaterialIndex_MaterialSlotName_Offset;

	private static bool GetMaterialIndex_ReturnValue_IsValid;

	private static FFieldAddress GetMaterialIndex_ReturnValue_PropertyAddress;

	private static int GetMaterialIndex_ReturnValue_Offset;

	private static bool GetMaterial_IsValid;

	private static IntPtr GetMaterial_FunctionAddress;

	private static int GetMaterial_ParamsSize;

	private static bool GetMaterial_MaterialIndex_IsValid;

	private static FFieldAddress GetMaterial_MaterialIndex_PropertyAddress;

	private static int GetMaterial_MaterialIndex_Offset;

	private static bool GetMaterial_ReturnValue_IsValid;

	private static FFieldAddress GetMaterial_ReturnValue_PropertyAddress;

	private static int GetMaterial_ReturnValue_Offset;

	private static bool GetBounds_IsValid;

	private static IntPtr GetBounds_FunctionAddress;

	private static int GetBounds_ParamsSize;

	private static bool GetBounds_ReturnValue_IsValid;

	private static FFieldAddress GetBounds_ReturnValue_PropertyAddress;

	private static int GetBounds_ReturnValue_Offset;

	private static bool GetBoundingBox_IsValid;

	private static IntPtr GetBoundingBox_FunctionAddress;

	private static int GetBoundingBox_ParamsSize;

	private static bool GetBoundingBox_ReturnValue_IsValid;

	private static FFieldAddress GetBoundingBox_ReturnValue_PropertyAddress;

	private static int GetBoundingBox_ReturnValue_Offset;

	private static bool FindSocket_IsValid;

	private static IntPtr FindSocket_FunctionAddress;

	private static int FindSocket_ParamsSize;

	private static bool FindSocket_InSocketName_IsValid;

	private static FFieldAddress FindSocket_InSocketName_PropertyAddress;

	private static int FindSocket_InSocketName_Offset;

	private static bool FindSocket_ReturnValue_IsValid;

	private static FFieldAddress FindSocket_ReturnValue_PropertyAddress;

	private static int FindSocket_ReturnValue_Offset;

	private static bool CreateStaticMeshDescription_IsValid;

	private static IntPtr CreateStaticMeshDescription_FunctionAddress;

	private static int CreateStaticMeshDescription_ParamsSize;

	private static bool CreateStaticMeshDescription_Outer_IsValid;

	private static FFieldAddress CreateStaticMeshDescription_Outer_PropertyAddress;

	private static int CreateStaticMeshDescription_Outer_Offset;

	private static bool CreateStaticMeshDescription_ReturnValue_IsValid;

	private static FFieldAddress CreateStaticMeshDescription_ReturnValue_PropertyAddress;

	private static int CreateStaticMeshDescription_ReturnValue_Offset;

	private static bool BuildFromStaticMeshDescriptions_IsValid;

	private static IntPtr BuildFromStaticMeshDescriptions_FunctionAddress;

	private static int BuildFromStaticMeshDescriptions_ParamsSize;

	private static bool BuildFromStaticMeshDescriptions_StaticMeshDescriptions_IsValid;

	private static FFieldAddress BuildFromStaticMeshDescriptions_StaticMeshDescriptions_PropertyAddress;

	private static int BuildFromStaticMeshDescriptions_StaticMeshDescriptions_Offset;

	private static bool BuildFromStaticMeshDescriptions_bBuildSimpleCollision_IsValid;

	private static FFieldAddress BuildFromStaticMeshDescriptions_bBuildSimpleCollision_PropertyAddress;

	private static int BuildFromStaticMeshDescriptions_bBuildSimpleCollision_Offset;

	private static bool BuildFromStaticMeshDescriptions_bFastBuild_IsValid;

	private static FFieldAddress BuildFromStaticMeshDescriptions_bFastBuild_PropertyAddress;

	private static int BuildFromStaticMeshDescriptions_bFastBuild_Offset;

	private static bool AddSocket_IsValid;

	private static IntPtr AddSocket_FunctionAddress;

	private static int AddSocket_ParamsSize;

	private static bool AddSocket_Socket_IsValid;

	private static FFieldAddress AddSocket_Socket_PropertyAddress;

	private static int AddSocket_Socket_Offset;

	private static bool AddMaterial_IsValid;

	private static IntPtr AddMaterial_FunctionAddress;

	private static int AddMaterial_ParamsSize;

	private static bool AddMaterial_Material_IsValid;

	private static FFieldAddress AddMaterial_Material_PropertyAddress;

	private static int AddMaterial_Material_Offset;

	private static bool AddMaterial_ReturnValue_IsValid;

	private static FFieldAddress AddMaterial_ReturnValue_PropertyAddress;

	private static int AddMaterial_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.StaticMesh:LODForCollision")]
	public int LODForCollision
	{
		get
		{
			CheckDestroyed();
			if (!LODForCollision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMesh:LODForCollision");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LODForCollision_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LODForCollision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMesh:LODForCollision");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LODForCollision_Offset), value);
			}
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.StaticMesh:SetStaticMaterials")]
	public unsafe void SetStaticMaterials(List<FStaticMaterial> InStaticMaterials)
	{
		CheckDestroyed();
		if (!SetStaticMaterials_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMesh:SetStaticMaterials");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStaticMaterials_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStaticMaterials_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FStaticMaterial>(1, SetStaticMaterials_InStaticMaterials_PropertyAddress, CachedMarshalingDelegates<FStaticMaterial, FStaticMaterial>.FromNative, CachedMarshalingDelegates<FStaticMaterial, FStaticMaterial>.ToNative).ToNative(IntPtr.Add(intPtr, SetStaticMaterials_InStaticMaterials_Offset), InStaticMaterials);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStaticMaterials_FunctionAddress, intPtr, SetStaticMaterials_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetStaticMaterials_InStaticMaterials_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604111875u)]
	[UMetaPath("/Script/Engine.StaticMesh:SetNumSourceModels")]
	public unsafe void SetNumSourceModels(int Num)
	{
		CheckDestroyed();
		if (!SetNumSourceModels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMesh:SetNumSourceModels");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNumSourceModels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNumSourceModels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNumSourceModels_Num_Offset), 0, SetNumSourceModels_Num_PropertyAddress.Address, Num);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNumSourceModels_FunctionAddress, intPtr, SetNumSourceModels_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.StaticMesh:SetMinimumLODForPlatforms")]
	public unsafe void SetMinimumLODForPlatforms(Dictionary<FName, int> PlatformMinimumLODs)
	{
		CheckDestroyed();
		if (!SetMinimumLODForPlatforms_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMesh:SetMinimumLODForPlatforms");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMinimumLODForPlatforms_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMinimumLODForPlatforms_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetMinimumLODForPlatforms_PlatformMinimumLODs_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<FName, int>(1, SetMinimumLODForPlatforms_PlatformMinimumLODs_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, SetMinimumLODForPlatforms_PlatformMinimumLODs_Offset), PlatformMinimumLODs);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMinimumLODForPlatforms_FunctionAddress, intPtr, SetMinimumLODForPlatforms_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMinimumLODForPlatforms_PlatformMinimumLODs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.StaticMesh:SetMinimumLODForPlatform")]
	public unsafe void SetMinimumLODForPlatform(FName PlatformName, int InMinLOD)
	{
		CheckDestroyed();
		if (!SetMinimumLODForPlatform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMesh:SetMinimumLODForPlatform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMinimumLODForPlatform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMinimumLODForPlatform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetMinimumLODForPlatform_PlatformName_Offset), 0, SetMinimumLODForPlatform_PlatformName_PropertyAddress.Address, PlatformName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMinimumLODForPlatform_InMinLOD_Offset), 0, SetMinimumLODForPlatform_InMinLOD_PropertyAddress.Address, InMinLOD);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMinimumLODForPlatform_FunctionAddress, intPtr, SetMinimumLODForPlatform_ParamsSize);
	}

	[UFunction(Flags = 604111875u)]
	[UMetaPath("/Script/Engine.StaticMesh:SetMaterial")]
	public unsafe void SetMaterial(int MaterialIndex, UMaterialInterface NewMaterial)
	{
		CheckDestroyed();
		if (!SetMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMesh:SetMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMaterial_MaterialIndex_Offset), 0, SetMaterial_MaterialIndex_PropertyAddress.Address, MaterialIndex);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetMaterial_NewMaterial_Offset), 0, SetMaterial_NewMaterial_PropertyAddress.Address, NewMaterial);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMaterial_FunctionAddress, intPtr, SetMaterial_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.StaticMesh:RemoveSocket")]
	public unsafe void RemoveSocket(UStaticMeshSocket Socket)
	{
		CheckDestroyed();
		if (!RemoveSocket_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMesh:RemoveSocket");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveSocket_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveSocket_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMeshSocket>.ToNative(IntPtr.Add(intPtr, RemoveSocket_Socket_Offset), 0, RemoveSocket_Socket_PropertyAddress.Address, Socket);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveSocket_FunctionAddress, intPtr, RemoveSocket_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.StaticMesh:GetStaticMeshDescription")]
	public unsafe UStaticMeshDescription GetStaticMeshDescription(int LODIndex)
	{
		CheckDestroyed();
		if (!GetStaticMeshDescription_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMesh:GetStaticMeshDescription");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStaticMeshDescription_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStaticMeshDescription_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetStaticMeshDescription_LODIndex_Offset), 0, GetStaticMeshDescription_LODIndex_PropertyAddress.Address, LODIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStaticMeshDescription_FunctionAddress, intPtr, GetStaticMeshDescription_ParamsSize);
		return UObjectMarshaler<UStaticMeshDescription>.FromNative(IntPtr.Add(intPtr, GetStaticMeshDescription_ReturnValue_Offset), 0, GetStaticMeshDescription_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.StaticMesh:GetStaticMaterials")]
	public unsafe List<FStaticMaterial> GetStaticMaterials()
	{
		CheckDestroyed();
		if (!GetStaticMaterials_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMesh:GetStaticMaterials");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStaticMaterials_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStaticMaterials_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStaticMaterials_FunctionAddress, intPtr, GetStaticMaterials_ParamsSize);
		List<FStaticMaterial> result = new TArrayCopyMarshaler<FStaticMaterial>(1, GetStaticMaterials_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FStaticMaterial, FStaticMaterial>.FromNative, CachedMarshalingDelegates<FStaticMaterial, FStaticMaterial>.ToNative).FromNative(IntPtr.Add(intPtr, GetStaticMaterials_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetStaticMaterials_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418243u)]
	[UMetaPath("/Script/Engine.StaticMesh:GetNumSections")]
	public unsafe int GetNumSections(int InLOD)
	{
		CheckDestroyed();
		if (!GetNumSections_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMesh:GetNumSections");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumSections_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumSections_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetNumSections_InLOD_Offset), 0, GetNumSections_InLOD_PropertyAddress.Address, InLOD);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumSections_FunctionAddress, intPtr, GetNumSections_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumSections_ReturnValue_Offset), 0, GetNumSections_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418243u, OriginalName = "GetNumLODs")]
	[UMetaPath("/Script/Engine.StaticMesh:GetNumLODs")]
	public unsafe int GetNumLods()
	{
		CheckDestroyed();
		if (!GetNumLods_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMesh:GetNumLODs");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumLods_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumLods_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumLods_FunctionAddress, intPtr, GetNumLods_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumLods_ReturnValue_Offset), 0, GetNumLods_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.StaticMesh:GetMinimumLODForQualityLevels")]
	public unsafe void GetMinimumLODForQualityLevels(out Dictionary<FName, int> QualityLevelMinimumLODs)
	{
		CheckDestroyed();
		if (!GetMinimumLODForQualityLevels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMesh:GetMinimumLODForQualityLevels");
			QualityLevelMinimumLODs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMinimumLODForQualityLevels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMinimumLODForQualityLevels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetMinimumLODForQualityLevels_QualityLevelMinimumLODs_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMinimumLODForQualityLevels_FunctionAddress, intPtr, GetMinimumLODForQualityLevels_ParamsSize);
		QualityLevelMinimumLODs = new TMapCopyMarshaler<FName, int>(1, GetMinimumLODForQualityLevels_QualityLevelMinimumLODs_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GetMinimumLODForQualityLevels_QualityLevelMinimumLODs_Offset));
		NativeReflection.DestroyValue_InContainer(GetMinimumLODForQualityLevels_QualityLevelMinimumLODs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.StaticMesh:GetMinimumLODForQualityLevel")]
	public unsafe int GetMinimumLODForQualityLevel(FName QualityLevel)
	{
		CheckDestroyed();
		if (!GetMinimumLODForQualityLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMesh:GetMinimumLODForQualityLevel");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMinimumLODForQualityLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMinimumLODForQualityLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetMinimumLODForQualityLevel_QualityLevel_Offset), 0, GetMinimumLODForQualityLevel_QualityLevel_PropertyAddress.Address, QualityLevel);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMinimumLODForQualityLevel_FunctionAddress, intPtr, GetMinimumLODForQualityLevel_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetMinimumLODForQualityLevel_ReturnValue_Offset), 0, GetMinimumLODForQualityLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.StaticMesh:GetMinimumLODForPlatforms")]
	public unsafe void GetMinimumLODForPlatforms(out Dictionary<FName, int> PlatformMinimumLODs)
	{
		CheckDestroyed();
		if (!GetMinimumLODForPlatforms_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMesh:GetMinimumLODForPlatforms");
			PlatformMinimumLODs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMinimumLODForPlatforms_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMinimumLODForPlatforms_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetMinimumLODForPlatforms_PlatformMinimumLODs_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMinimumLODForPlatforms_FunctionAddress, intPtr, GetMinimumLODForPlatforms_ParamsSize);
		PlatformMinimumLODs = new TMapCopyMarshaler<FName, int>(1, GetMinimumLODForPlatforms_PlatformMinimumLODs_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GetMinimumLODForPlatforms_PlatformMinimumLODs_Offset));
		NativeReflection.DestroyValue_InContainer(GetMinimumLODForPlatforms_PlatformMinimumLODs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.StaticMesh:GetMinimumLODForPlatform")]
	public unsafe int GetMinimumLODForPlatform(FName PlatformName)
	{
		CheckDestroyed();
		if (!GetMinimumLODForPlatform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMesh:GetMinimumLODForPlatform");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMinimumLODForPlatform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMinimumLODForPlatform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetMinimumLODForPlatform_PlatformName_Offset), 0, GetMinimumLODForPlatform_PlatformName_PropertyAddress.Address, PlatformName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMinimumLODForPlatform_FunctionAddress, intPtr, GetMinimumLODForPlatform_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetMinimumLODForPlatform_ReturnValue_Offset), 0, GetMinimumLODForPlatform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418243u)]
	[UMetaPath("/Script/Engine.StaticMesh:GetMaterialIndex")]
	public unsafe int GetMaterialIndex(FName MaterialSlotName)
	{
		CheckDestroyed();
		if (!GetMaterialIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMesh:GetMaterialIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaterialIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaterialIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetMaterialIndex_MaterialSlotName_Offset), 0, GetMaterialIndex_MaterialSlotName_PropertyAddress.Address, MaterialSlotName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaterialIndex_FunctionAddress, intPtr, GetMaterialIndex_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetMaterialIndex_ReturnValue_Offset), 0, GetMaterialIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418243u)]
	[UMetaPath("/Script/Engine.StaticMesh:GetMaterial")]
	public unsafe UMaterialInterface GetMaterial(int MaterialIndex)
	{
		CheckDestroyed();
		if (!GetMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMesh:GetMaterial");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetMaterial_MaterialIndex_Offset), 0, GetMaterial_MaterialIndex_PropertyAddress.Address, MaterialIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaterial_FunctionAddress, intPtr, GetMaterial_ParamsSize);
		return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(intPtr, GetMaterial_ReturnValue_Offset), 0, GetMaterial_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806851u)]
	[UMetaPath("/Script/Engine.StaticMesh:GetBounds")]
	public unsafe FBoxSphereBounds GetBounds()
	{
		CheckDestroyed();
		if (!GetBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMesh:GetBounds");
			return default(FBoxSphereBounds);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBounds_FunctionAddress, intPtr, GetBounds_ParamsSize);
		return BlittableTypeMarshaler<FBoxSphereBounds>.FromNative(IntPtr.Add(intPtr, GetBounds_ReturnValue_Offset), 0, GetBounds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806851u)]
	[UMetaPath("/Script/Engine.StaticMesh:GetBoundingBox")]
	public unsafe FBox GetBoundingBox()
	{
		CheckDestroyed();
		if (!GetBoundingBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMesh:GetBoundingBox");
			return default(FBox);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoundingBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoundingBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBoundingBox_FunctionAddress, intPtr, GetBoundingBox_ParamsSize);
		return BlittableTypeMarshaler<FBox>.FromNative(IntPtr.Add(intPtr, GetBoundingBox_ReturnValue_Offset), 0, GetBoundingBox_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418243u)]
	[UMetaPath("/Script/Engine.StaticMesh:FindSocket")]
	public unsafe UStaticMeshSocket FindSocket(FName InSocketName)
	{
		CheckDestroyed();
		if (!FindSocket_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMesh:FindSocket");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindSocket_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindSocket_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FindSocket_InSocketName_Offset), 0, FindSocket_InSocketName_PropertyAddress.Address, InSocketName);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindSocket_FunctionAddress, intPtr, FindSocket_ParamsSize);
		return UObjectMarshaler<UStaticMeshSocket>.FromNative(IntPtr.Add(intPtr, FindSocket_ReturnValue_Offset), 0, FindSocket_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249155u)]
	[UMetaPath("/Script/Engine.StaticMesh:CreateStaticMeshDescription")]
	public unsafe static UStaticMeshDescription CreateStaticMeshDescription(UObject Outer)
	{
		if (!CreateStaticMeshDescription_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMesh:CreateStaticMeshDescription");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateStaticMeshDescription_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateStaticMeshDescription_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateStaticMeshDescription_Outer_Offset), 0, CreateStaticMeshDescription_Outer_PropertyAddress.Address, Outer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateStaticMeshDescription_FunctionAddress, intPtr, CreateStaticMeshDescription_ParamsSize);
		return UObjectMarshaler<UStaticMeshDescription>.FromNative(IntPtr.Add(intPtr, CreateStaticMeshDescription_ReturnValue_Offset), 0, CreateStaticMeshDescription_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435267u)]
	[UMetaPath("/Script/Engine.StaticMesh:BuildFromStaticMeshDescriptions")]
	public unsafe void BuildFromStaticMeshDescriptions(List<UStaticMeshDescription> StaticMeshDescriptions, bool bBuildSimpleCollision = false, bool bFastBuild = true)
	{
		CheckDestroyed();
		if (!BuildFromStaticMeshDescriptions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMesh:BuildFromStaticMeshDescriptions");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BuildFromStaticMeshDescriptions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BuildFromStaticMeshDescriptions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UStaticMeshDescription>(1, BuildFromStaticMeshDescriptions_StaticMeshDescriptions_PropertyAddress, CachedMarshalingDelegates<UStaticMeshDescription, UObjectMarshaler<UStaticMeshDescription>>.FromNative, CachedMarshalingDelegates<UStaticMeshDescription, UObjectMarshaler<UStaticMeshDescription>>.ToNative).ToNative(IntPtr.Add(intPtr, BuildFromStaticMeshDescriptions_StaticMeshDescriptions_Offset), StaticMeshDescriptions);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BuildFromStaticMeshDescriptions_bBuildSimpleCollision_Offset), 0, BuildFromStaticMeshDescriptions_bBuildSimpleCollision_PropertyAddress.Address, bBuildSimpleCollision);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BuildFromStaticMeshDescriptions_bFastBuild_Offset), 0, BuildFromStaticMeshDescriptions_bFastBuild_PropertyAddress.Address, bFastBuild);
		NativeReflection.InvokeFunctionOptimized(base.Address, BuildFromStaticMeshDescriptions_FunctionAddress, intPtr, BuildFromStaticMeshDescriptions_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BuildFromStaticMeshDescriptions_StaticMeshDescriptions_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.StaticMesh:AddSocket")]
	public unsafe void AddSocket(UStaticMeshSocket Socket)
	{
		CheckDestroyed();
		if (!AddSocket_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMesh:AddSocket");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddSocket_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddSocket_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMeshSocket>.ToNative(IntPtr.Add(intPtr, AddSocket_Socket_Offset), 0, AddSocket_Socket_PropertyAddress.Address, Socket);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddSocket_FunctionAddress, intPtr, AddSocket_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.StaticMesh:AddMaterial")]
	public unsafe FName AddMaterial(UMaterialInterface Material)
	{
		CheckDestroyed();
		if (!AddMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMesh:AddMaterial");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, AddMaterial_Material_Offset), 0, AddMaterial_Material_PropertyAddress.Address, Material);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddMaterial_FunctionAddress, intPtr, AddMaterial_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, AddMaterial_ReturnValue_Offset), 0, AddMaterial_ReturnValue_PropertyAddress.Address);
	}

	static UStaticMesh()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UStaticMesh)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UStaticMesh));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.StaticMesh");
		LODForCollision_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "LODForCollision");
		LODForCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "LODForCollision", Classes.FIntProperty);
		SetStaticMaterials_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStaticMaterials");
		SetStaticMaterials_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStaticMaterials_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMaterials_InStaticMaterials_PropertyAddress, SetStaticMaterials_FunctionAddress, "InStaticMaterials");
		SetStaticMaterials_InStaticMaterials_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMaterials_FunctionAddress, "InStaticMaterials");
		SetStaticMaterials_InStaticMaterials_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMaterials_FunctionAddress, "InStaticMaterials", Classes.FArrayProperty);
		SetStaticMaterials_IsValid = SetStaticMaterials_FunctionAddress != IntPtr.Zero && SetStaticMaterials_InStaticMaterials_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMesh:SetStaticMaterials", SetStaticMaterials_IsValid);
		SetNumSourceModels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNumSourceModels");
		SetNumSourceModels_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNumSourceModels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNumSourceModels_Num_PropertyAddress, SetNumSourceModels_FunctionAddress, "Num");
		SetNumSourceModels_Num_Offset = NativeReflectionCached.GetPropertyOffset(SetNumSourceModels_FunctionAddress, "Num");
		SetNumSourceModels_Num_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumSourceModels_FunctionAddress, "Num", Classes.FIntProperty);
		SetNumSourceModels_IsValid = SetNumSourceModels_FunctionAddress != IntPtr.Zero && SetNumSourceModels_Num_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMesh:SetNumSourceModels", SetNumSourceModels_IsValid);
		SetMinimumLODForPlatforms_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMinimumLODForPlatforms");
		SetMinimumLODForPlatforms_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMinimumLODForPlatforms_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMinimumLODForPlatforms_PlatformMinimumLODs_PropertyAddress, SetMinimumLODForPlatforms_FunctionAddress, "PlatformMinimumLODs");
		SetMinimumLODForPlatforms_PlatformMinimumLODs_Offset = NativeReflectionCached.GetPropertyOffset(SetMinimumLODForPlatforms_FunctionAddress, "PlatformMinimumLODs");
		SetMinimumLODForPlatforms_PlatformMinimumLODs_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMinimumLODForPlatforms_FunctionAddress, "PlatformMinimumLODs", Classes.FMapProperty);
		SetMinimumLODForPlatforms_IsValid = SetMinimumLODForPlatforms_FunctionAddress != IntPtr.Zero && SetMinimumLODForPlatforms_PlatformMinimumLODs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMesh:SetMinimumLODForPlatforms", SetMinimumLODForPlatforms_IsValid);
		SetMinimumLODForPlatform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMinimumLODForPlatform");
		SetMinimumLODForPlatform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMinimumLODForPlatform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMinimumLODForPlatform_PlatformName_PropertyAddress, SetMinimumLODForPlatform_FunctionAddress, "PlatformName");
		SetMinimumLODForPlatform_PlatformName_Offset = NativeReflectionCached.GetPropertyOffset(SetMinimumLODForPlatform_FunctionAddress, "PlatformName");
		SetMinimumLODForPlatform_PlatformName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMinimumLODForPlatform_FunctionAddress, "PlatformName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMinimumLODForPlatform_InMinLOD_PropertyAddress, SetMinimumLODForPlatform_FunctionAddress, "InMinLOD");
		SetMinimumLODForPlatform_InMinLOD_Offset = NativeReflectionCached.GetPropertyOffset(SetMinimumLODForPlatform_FunctionAddress, "InMinLOD");
		SetMinimumLODForPlatform_InMinLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMinimumLODForPlatform_FunctionAddress, "InMinLOD", Classes.FIntProperty);
		SetMinimumLODForPlatform_IsValid = SetMinimumLODForPlatform_FunctionAddress != IntPtr.Zero && SetMinimumLODForPlatform_PlatformName_IsValid && SetMinimumLODForPlatform_InMinLOD_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMesh:SetMinimumLODForPlatform", SetMinimumLODForPlatform_IsValid);
		SetMaterial_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMaterial");
		SetMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_MaterialIndex_PropertyAddress, SetMaterial_FunctionAddress, "MaterialIndex");
		SetMaterial_MaterialIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "MaterialIndex");
		SetMaterial_MaterialIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "MaterialIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_NewMaterial_PropertyAddress, SetMaterial_FunctionAddress, "NewMaterial");
		SetMaterial_NewMaterial_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "NewMaterial");
		SetMaterial_NewMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "NewMaterial", Classes.FObjectProperty);
		SetMaterial_IsValid = SetMaterial_FunctionAddress != IntPtr.Zero && SetMaterial_MaterialIndex_IsValid && SetMaterial_NewMaterial_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMesh:SetMaterial", SetMaterial_IsValid);
		RemoveSocket_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveSocket");
		RemoveSocket_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveSocket_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveSocket_Socket_PropertyAddress, RemoveSocket_FunctionAddress, "Socket");
		RemoveSocket_Socket_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSocket_FunctionAddress, "Socket");
		RemoveSocket_Socket_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSocket_FunctionAddress, "Socket", Classes.FObjectProperty);
		RemoveSocket_IsValid = RemoveSocket_FunctionAddress != IntPtr.Zero && RemoveSocket_Socket_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMesh:RemoveSocket", RemoveSocket_IsValid);
		GetStaticMeshDescription_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStaticMeshDescription");
		GetStaticMeshDescription_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStaticMeshDescription_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshDescription_LODIndex_PropertyAddress, GetStaticMeshDescription_FunctionAddress, "LODIndex");
		GetStaticMeshDescription_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshDescription_FunctionAddress, "LODIndex");
		GetStaticMeshDescription_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshDescription_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshDescription_ReturnValue_PropertyAddress, GetStaticMeshDescription_FunctionAddress, "ReturnValue");
		GetStaticMeshDescription_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshDescription_FunctionAddress, "ReturnValue");
		GetStaticMeshDescription_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshDescription_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetStaticMeshDescription_IsValid = GetStaticMeshDescription_FunctionAddress != IntPtr.Zero && GetStaticMeshDescription_LODIndex_IsValid && GetStaticMeshDescription_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMesh:GetStaticMeshDescription", GetStaticMeshDescription_IsValid);
		GetStaticMaterials_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStaticMaterials");
		GetStaticMaterials_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStaticMaterials_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMaterials_ReturnValue_PropertyAddress, GetStaticMaterials_FunctionAddress, "ReturnValue");
		GetStaticMaterials_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMaterials_FunctionAddress, "ReturnValue");
		GetStaticMaterials_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMaterials_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetStaticMaterials_IsValid = GetStaticMaterials_FunctionAddress != IntPtr.Zero && GetStaticMaterials_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMesh:GetStaticMaterials", GetStaticMaterials_IsValid);
		GetNumSections_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNumSections");
		GetNumSections_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumSections_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumSections_InLOD_PropertyAddress, GetNumSections_FunctionAddress, "InLOD");
		GetNumSections_InLOD_Offset = NativeReflectionCached.GetPropertyOffset(GetNumSections_FunctionAddress, "InLOD");
		GetNumSections_InLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumSections_FunctionAddress, "InLOD", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumSections_ReturnValue_PropertyAddress, GetNumSections_FunctionAddress, "ReturnValue");
		GetNumSections_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumSections_FunctionAddress, "ReturnValue");
		GetNumSections_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumSections_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumSections_IsValid = GetNumSections_FunctionAddress != IntPtr.Zero && GetNumSections_InLOD_IsValid && GetNumSections_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMesh:GetNumSections", GetNumSections_IsValid);
		GetNumLods_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNumLODs");
		GetNumLods_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumLods_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumLods_ReturnValue_PropertyAddress, GetNumLods_FunctionAddress, "ReturnValue");
		GetNumLods_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumLods_FunctionAddress, "ReturnValue");
		GetNumLods_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumLods_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumLods_IsValid = GetNumLods_FunctionAddress != IntPtr.Zero && GetNumLods_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMesh:GetNumLODs", GetNumLods_IsValid);
		GetMinimumLODForQualityLevels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMinimumLODForQualityLevels");
		GetMinimumLODForQualityLevels_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMinimumLODForQualityLevels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMinimumLODForQualityLevels_QualityLevelMinimumLODs_PropertyAddress, GetMinimumLODForQualityLevels_FunctionAddress, "QualityLevelMinimumLODs");
		GetMinimumLODForQualityLevels_QualityLevelMinimumLODs_Offset = NativeReflectionCached.GetPropertyOffset(GetMinimumLODForQualityLevels_FunctionAddress, "QualityLevelMinimumLODs");
		GetMinimumLODForQualityLevels_QualityLevelMinimumLODs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMinimumLODForQualityLevels_FunctionAddress, "QualityLevelMinimumLODs", Classes.FMapProperty);
		GetMinimumLODForQualityLevels_IsValid = GetMinimumLODForQualityLevels_FunctionAddress != IntPtr.Zero && GetMinimumLODForQualityLevels_QualityLevelMinimumLODs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMesh:GetMinimumLODForQualityLevels", GetMinimumLODForQualityLevels_IsValid);
		GetMinimumLODForQualityLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMinimumLODForQualityLevel");
		GetMinimumLODForQualityLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMinimumLODForQualityLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMinimumLODForQualityLevel_QualityLevel_PropertyAddress, GetMinimumLODForQualityLevel_FunctionAddress, "QualityLevel");
		GetMinimumLODForQualityLevel_QualityLevel_Offset = NativeReflectionCached.GetPropertyOffset(GetMinimumLODForQualityLevel_FunctionAddress, "QualityLevel");
		GetMinimumLODForQualityLevel_QualityLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMinimumLODForQualityLevel_FunctionAddress, "QualityLevel", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMinimumLODForQualityLevel_ReturnValue_PropertyAddress, GetMinimumLODForQualityLevel_FunctionAddress, "ReturnValue");
		GetMinimumLODForQualityLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMinimumLODForQualityLevel_FunctionAddress, "ReturnValue");
		GetMinimumLODForQualityLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMinimumLODForQualityLevel_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetMinimumLODForQualityLevel_IsValid = GetMinimumLODForQualityLevel_FunctionAddress != IntPtr.Zero && GetMinimumLODForQualityLevel_QualityLevel_IsValid && GetMinimumLODForQualityLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMesh:GetMinimumLODForQualityLevel", GetMinimumLODForQualityLevel_IsValid);
		GetMinimumLODForPlatforms_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMinimumLODForPlatforms");
		GetMinimumLODForPlatforms_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMinimumLODForPlatforms_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMinimumLODForPlatforms_PlatformMinimumLODs_PropertyAddress, GetMinimumLODForPlatforms_FunctionAddress, "PlatformMinimumLODs");
		GetMinimumLODForPlatforms_PlatformMinimumLODs_Offset = NativeReflectionCached.GetPropertyOffset(GetMinimumLODForPlatforms_FunctionAddress, "PlatformMinimumLODs");
		GetMinimumLODForPlatforms_PlatformMinimumLODs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMinimumLODForPlatforms_FunctionAddress, "PlatformMinimumLODs", Classes.FMapProperty);
		GetMinimumLODForPlatforms_IsValid = GetMinimumLODForPlatforms_FunctionAddress != IntPtr.Zero && GetMinimumLODForPlatforms_PlatformMinimumLODs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMesh:GetMinimumLODForPlatforms", GetMinimumLODForPlatforms_IsValid);
		GetMinimumLODForPlatform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMinimumLODForPlatform");
		GetMinimumLODForPlatform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMinimumLODForPlatform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMinimumLODForPlatform_PlatformName_PropertyAddress, GetMinimumLODForPlatform_FunctionAddress, "PlatformName");
		GetMinimumLODForPlatform_PlatformName_Offset = NativeReflectionCached.GetPropertyOffset(GetMinimumLODForPlatform_FunctionAddress, "PlatformName");
		GetMinimumLODForPlatform_PlatformName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMinimumLODForPlatform_FunctionAddress, "PlatformName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMinimumLODForPlatform_ReturnValue_PropertyAddress, GetMinimumLODForPlatform_FunctionAddress, "ReturnValue");
		GetMinimumLODForPlatform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMinimumLODForPlatform_FunctionAddress, "ReturnValue");
		GetMinimumLODForPlatform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMinimumLODForPlatform_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetMinimumLODForPlatform_IsValid = GetMinimumLODForPlatform_FunctionAddress != IntPtr.Zero && GetMinimumLODForPlatform_PlatformName_IsValid && GetMinimumLODForPlatform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMesh:GetMinimumLODForPlatform", GetMinimumLODForPlatform_IsValid);
		GetMaterialIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMaterialIndex");
		GetMaterialIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaterialIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaterialIndex_MaterialSlotName_PropertyAddress, GetMaterialIndex_FunctionAddress, "MaterialSlotName");
		GetMaterialIndex_MaterialSlotName_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterialIndex_FunctionAddress, "MaterialSlotName");
		GetMaterialIndex_MaterialSlotName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterialIndex_FunctionAddress, "MaterialSlotName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMaterialIndex_ReturnValue_PropertyAddress, GetMaterialIndex_FunctionAddress, "ReturnValue");
		GetMaterialIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterialIndex_FunctionAddress, "ReturnValue");
		GetMaterialIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterialIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetMaterialIndex_IsValid = GetMaterialIndex_FunctionAddress != IntPtr.Zero && GetMaterialIndex_MaterialSlotName_IsValid && GetMaterialIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMesh:GetMaterialIndex", GetMaterialIndex_IsValid);
		GetMaterial_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMaterial");
		GetMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaterial_MaterialIndex_PropertyAddress, GetMaterial_FunctionAddress, "MaterialIndex");
		GetMaterial_MaterialIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterial_FunctionAddress, "MaterialIndex");
		GetMaterial_MaterialIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterial_FunctionAddress, "MaterialIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMaterial_ReturnValue_PropertyAddress, GetMaterial_FunctionAddress, "ReturnValue");
		GetMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterial_FunctionAddress, "ReturnValue");
		GetMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterial_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetMaterial_IsValid = GetMaterial_FunctionAddress != IntPtr.Zero && GetMaterial_MaterialIndex_IsValid && GetMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMesh:GetMaterial", GetMaterial_IsValid);
		GetBounds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBounds");
		GetBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBounds_ReturnValue_PropertyAddress, GetBounds_FunctionAddress, "ReturnValue");
		GetBounds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBounds_FunctionAddress, "ReturnValue");
		GetBounds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBounds_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBounds_IsValid = GetBounds_FunctionAddress != IntPtr.Zero && GetBounds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMesh:GetBounds", GetBounds_IsValid);
		GetBoundingBox_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBoundingBox");
		GetBoundingBox_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoundingBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoundingBox_ReturnValue_PropertyAddress, GetBoundingBox_FunctionAddress, "ReturnValue");
		GetBoundingBox_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoundingBox_FunctionAddress, "ReturnValue");
		GetBoundingBox_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoundingBox_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBoundingBox_IsValid = GetBoundingBox_FunctionAddress != IntPtr.Zero && GetBoundingBox_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMesh:GetBoundingBox", GetBoundingBox_IsValid);
		FindSocket_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindSocket");
		FindSocket_ParamsSize = NativeReflection.GetFunctionParamsSize(FindSocket_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindSocket_InSocketName_PropertyAddress, FindSocket_FunctionAddress, "InSocketName");
		FindSocket_InSocketName_Offset = NativeReflectionCached.GetPropertyOffset(FindSocket_FunctionAddress, "InSocketName");
		FindSocket_InSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSocket_FunctionAddress, "InSocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FindSocket_ReturnValue_PropertyAddress, FindSocket_FunctionAddress, "ReturnValue");
		FindSocket_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindSocket_FunctionAddress, "ReturnValue");
		FindSocket_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSocket_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindSocket_IsValid = FindSocket_FunctionAddress != IntPtr.Zero && FindSocket_InSocketName_IsValid && FindSocket_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMesh:FindSocket", FindSocket_IsValid);
		CreateStaticMeshDescription_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateStaticMeshDescription");
		CreateStaticMeshDescription_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateStaticMeshDescription_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateStaticMeshDescription_Outer_PropertyAddress, CreateStaticMeshDescription_FunctionAddress, "Outer");
		CreateStaticMeshDescription_Outer_Offset = NativeReflectionCached.GetPropertyOffset(CreateStaticMeshDescription_FunctionAddress, "Outer");
		CreateStaticMeshDescription_Outer_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateStaticMeshDescription_FunctionAddress, "Outer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateStaticMeshDescription_ReturnValue_PropertyAddress, CreateStaticMeshDescription_FunctionAddress, "ReturnValue");
		CreateStaticMeshDescription_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateStaticMeshDescription_FunctionAddress, "ReturnValue");
		CreateStaticMeshDescription_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateStaticMeshDescription_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateStaticMeshDescription_IsValid = CreateStaticMeshDescription_FunctionAddress != IntPtr.Zero && CreateStaticMeshDescription_Outer_IsValid && CreateStaticMeshDescription_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMesh:CreateStaticMeshDescription", CreateStaticMeshDescription_IsValid);
		BuildFromStaticMeshDescriptions_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BuildFromStaticMeshDescriptions");
		BuildFromStaticMeshDescriptions_ParamsSize = NativeReflection.GetFunctionParamsSize(BuildFromStaticMeshDescriptions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BuildFromStaticMeshDescriptions_StaticMeshDescriptions_PropertyAddress, BuildFromStaticMeshDescriptions_FunctionAddress, "StaticMeshDescriptions");
		BuildFromStaticMeshDescriptions_StaticMeshDescriptions_Offset = NativeReflectionCached.GetPropertyOffset(BuildFromStaticMeshDescriptions_FunctionAddress, "StaticMeshDescriptions");
		BuildFromStaticMeshDescriptions_StaticMeshDescriptions_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildFromStaticMeshDescriptions_FunctionAddress, "StaticMeshDescriptions", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildFromStaticMeshDescriptions_bBuildSimpleCollision_PropertyAddress, BuildFromStaticMeshDescriptions_FunctionAddress, "bBuildSimpleCollision");
		BuildFromStaticMeshDescriptions_bBuildSimpleCollision_Offset = NativeReflectionCached.GetPropertyOffset(BuildFromStaticMeshDescriptions_FunctionAddress, "bBuildSimpleCollision");
		BuildFromStaticMeshDescriptions_bBuildSimpleCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildFromStaticMeshDescriptions_FunctionAddress, "bBuildSimpleCollision", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildFromStaticMeshDescriptions_bFastBuild_PropertyAddress, BuildFromStaticMeshDescriptions_FunctionAddress, "bFastBuild");
		BuildFromStaticMeshDescriptions_bFastBuild_Offset = NativeReflectionCached.GetPropertyOffset(BuildFromStaticMeshDescriptions_FunctionAddress, "bFastBuild");
		BuildFromStaticMeshDescriptions_bFastBuild_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildFromStaticMeshDescriptions_FunctionAddress, "bFastBuild", Classes.FBoolProperty);
		BuildFromStaticMeshDescriptions_IsValid = BuildFromStaticMeshDescriptions_FunctionAddress != IntPtr.Zero && BuildFromStaticMeshDescriptions_StaticMeshDescriptions_IsValid && BuildFromStaticMeshDescriptions_bBuildSimpleCollision_IsValid && BuildFromStaticMeshDescriptions_bFastBuild_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMesh:BuildFromStaticMeshDescriptions", BuildFromStaticMeshDescriptions_IsValid);
		AddSocket_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddSocket");
		AddSocket_ParamsSize = NativeReflection.GetFunctionParamsSize(AddSocket_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddSocket_Socket_PropertyAddress, AddSocket_FunctionAddress, "Socket");
		AddSocket_Socket_Offset = NativeReflectionCached.GetPropertyOffset(AddSocket_FunctionAddress, "Socket");
		AddSocket_Socket_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSocket_FunctionAddress, "Socket", Classes.FObjectProperty);
		AddSocket_IsValid = AddSocket_FunctionAddress != IntPtr.Zero && AddSocket_Socket_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMesh:AddSocket", AddSocket_IsValid);
		AddMaterial_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddMaterial");
		AddMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMaterial_Material_PropertyAddress, AddMaterial_FunctionAddress, "Material");
		AddMaterial_Material_Offset = NativeReflectionCached.GetPropertyOffset(AddMaterial_FunctionAddress, "Material");
		AddMaterial_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMaterial_FunctionAddress, "Material", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMaterial_ReturnValue_PropertyAddress, AddMaterial_FunctionAddress, "ReturnValue");
		AddMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddMaterial_FunctionAddress, "ReturnValue");
		AddMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMaterial_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		AddMaterial_IsValid = AddMaterial_FunctionAddress != IntPtr.Zero && AddMaterial_Material_IsValid && AddMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMesh:AddMaterial", AddMaterial_IsValid);
	}
}
