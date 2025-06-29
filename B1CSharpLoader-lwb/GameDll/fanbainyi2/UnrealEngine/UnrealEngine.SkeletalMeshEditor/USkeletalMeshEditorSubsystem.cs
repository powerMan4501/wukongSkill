using System;
using System.Runtime.CompilerServices;
using UnrealEngine.EditorSubsystem;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.SkeletalMeshEditor;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem", "SkeletalMeshEditor", UnrealModuleType.Engine)]
public class USkeletalMeshEditorSubsystem : UEditorSubsystem
{
	private static IntPtr classAddress;

	private static bool SetOverrideLODStreaming_IsValid;

	private static IntPtr SetOverrideLODStreaming_FunctionAddress;

	private static int SetOverrideLODStreaming_ParamsSize;

	private static bool SetOverrideLODStreaming_SkeletalMesh_IsValid;

	private static FFieldAddress SetOverrideLODStreaming_SkeletalMesh_PropertyAddress;

	private static int SetOverrideLODStreaming_SkeletalMesh_Offset;

	private static bool SetOverrideLODStreaming_Override_IsValid;

	private static FFieldAddress SetOverrideLODStreaming_Override_PropertyAddress;

	private static int SetOverrideLODStreaming_Override_Offset;

	private static bool SetOverrideLODStreaming_StreamLODs_IsValid;

	private static FFieldAddress SetOverrideLODStreaming_StreamLODs_PropertyAddress;

	private static int SetOverrideLODStreaming_StreamLODs_Offset;

	private static bool SetOverrideLODStreaming_MaxNumStreamedLODs_IsValid;

	private static FFieldAddress SetOverrideLODStreaming_MaxNumStreamedLODs_PropertyAddress;

	private static int SetOverrideLODStreaming_MaxNumStreamedLODs_Offset;

	private static bool SetOverrideLODStreaming_MaxNumOptionalLODs_IsValid;

	private static FFieldAddress SetOverrideLODStreaming_MaxNumOptionalLODs_PropertyAddress;

	private static int SetOverrideLODStreaming_MaxNumOptionalLODs_Offset;

	private static bool SetOverrideLODStreaming_ReturnValue_IsValid;

	private static FFieldAddress SetOverrideLODStreaming_ReturnValue_PropertyAddress;

	private static int SetOverrideLODStreaming_ReturnValue_Offset;

	private static bool SetLodBuildSettings_IsValid;

	private static IntPtr SetLodBuildSettings_FunctionAddress;

	private static int SetLodBuildSettings_ParamsSize;

	private static bool SetLodBuildSettings_SkeletalMesh_IsValid;

	private static FFieldAddress SetLodBuildSettings_SkeletalMesh_PropertyAddress;

	private static int SetLodBuildSettings_SkeletalMesh_Offset;

	private static bool SetLodBuildSettings_LodIndex_IsValid;

	private static FFieldAddress SetLodBuildSettings_LodIndex_PropertyAddress;

	private static int SetLodBuildSettings_LodIndex_Offset;

	private static bool SetLodBuildSettings_BuildOptions_IsValid;

	private static FFieldAddress SetLodBuildSettings_BuildOptions_PropertyAddress;

	private static int SetLodBuildSettings_BuildOptions_Offset;

	private static bool RenameSocket_IsValid;

	private static IntPtr RenameSocket_FunctionAddress;

	private static int RenameSocket_ParamsSize;

	private static bool RenameSocket_SkeletalMesh_IsValid;

	private static FFieldAddress RenameSocket_SkeletalMesh_PropertyAddress;

	private static int RenameSocket_SkeletalMesh_Offset;

	private static bool RenameSocket_OldName_IsValid;

	private static FFieldAddress RenameSocket_OldName_PropertyAddress;

	private static int RenameSocket_OldName_Offset;

	private static bool RenameSocket_NewName_IsValid;

	private static FFieldAddress RenameSocket_NewName_PropertyAddress;

	private static int RenameSocket_NewName_Offset;

	private static bool RenameSocket_ReturnValue_IsValid;

	private static FFieldAddress RenameSocket_ReturnValue_PropertyAddress;

	private static int RenameSocket_ReturnValue_Offset;

	private static bool ReimportAllCustomLODs_IsValid;

	private static IntPtr ReimportAllCustomLODs_FunctionAddress;

	private static int ReimportAllCustomLODs_ParamsSize;

	private static bool ReimportAllCustomLODs_SkeletalMesh_IsValid;

	private static FFieldAddress ReimportAllCustomLODs_SkeletalMesh_PropertyAddress;

	private static int ReimportAllCustomLODs_SkeletalMesh_Offset;

	private static bool ReimportAllCustomLODs_ReturnValue_IsValid;

	private static FFieldAddress ReimportAllCustomLODs_ReturnValue_PropertyAddress;

	private static int ReimportAllCustomLODs_ReturnValue_Offset;

	private static bool RegenerateLOD_IsValid;

	private static IntPtr RegenerateLOD_FunctionAddress;

	private static int RegenerateLOD_ParamsSize;

	private static bool RegenerateLOD_SkeletalMesh_IsValid;

	private static FFieldAddress RegenerateLOD_SkeletalMesh_PropertyAddress;

	private static int RegenerateLOD_SkeletalMesh_Offset;

	private static bool RegenerateLOD_NewLODCount_IsValid;

	private static FFieldAddress RegenerateLOD_NewLODCount_PropertyAddress;

	private static int RegenerateLOD_NewLODCount_Offset;

	private static bool RegenerateLOD_bRegenerateEvenIfImported_IsValid;

	private static FFieldAddress RegenerateLOD_bRegenerateEvenIfImported_PropertyAddress;

	private static int RegenerateLOD_bRegenerateEvenIfImported_Offset;

	private static bool RegenerateLOD_bGenerateBaseLOD_IsValid;

	private static FFieldAddress RegenerateLOD_bGenerateBaseLOD_PropertyAddress;

	private static int RegenerateLOD_bGenerateBaseLOD_Offset;

	private static bool RegenerateLOD_ReturnValue_IsValid;

	private static FFieldAddress RegenerateLOD_ReturnValue_PropertyAddress;

	private static int RegenerateLOD_ReturnValue_Offset;

	private static bool ImportLOD_IsValid;

	private static IntPtr ImportLOD_FunctionAddress;

	private static int ImportLOD_ParamsSize;

	private static bool ImportLOD_BaseMesh_IsValid;

	private static FFieldAddress ImportLOD_BaseMesh_PropertyAddress;

	private static int ImportLOD_BaseMesh_Offset;

	private static bool ImportLOD_LODIndex_IsValid;

	private static FFieldAddress ImportLOD_LODIndex_PropertyAddress;

	private static int ImportLOD_LODIndex_Offset;

	private static bool ImportLOD_SourceFilename_IsValid;

	private static FFieldAddress ImportLOD_SourceFilename_PropertyAddress;

	private static int ImportLOD_SourceFilename_Offset;

	private static bool ImportLOD_ReturnValue_IsValid;

	private static FFieldAddress ImportLOD_ReturnValue_PropertyAddress;

	private static int ImportLOD_ReturnValue_Offset;

	private static bool GetNumVerts_IsValid;

	private static IntPtr GetNumVerts_FunctionAddress;

	private static int GetNumVerts_ParamsSize;

	private static bool GetNumVerts_SkeletalMesh_IsValid;

	private static FFieldAddress GetNumVerts_SkeletalMesh_PropertyAddress;

	private static int GetNumVerts_SkeletalMesh_Offset;

	private static bool GetNumVerts_LODIndex_IsValid;

	private static FFieldAddress GetNumVerts_LODIndex_PropertyAddress;

	private static int GetNumVerts_LODIndex_Offset;

	private static bool GetNumVerts_ReturnValue_IsValid;

	private static FFieldAddress GetNumVerts_ReturnValue_PropertyAddress;

	private static int GetNumVerts_ReturnValue_Offset;

	private static bool GetNumSections_IsValid;

	private static IntPtr GetNumSections_FunctionAddress;

	private static int GetNumSections_ParamsSize;

	private static bool GetNumSections_SkeletalMesh_IsValid;

	private static FFieldAddress GetNumSections_SkeletalMesh_PropertyAddress;

	private static int GetNumSections_SkeletalMesh_Offset;

	private static bool GetNumSections_LODIndex_IsValid;

	private static FFieldAddress GetNumSections_LODIndex_PropertyAddress;

	private static int GetNumSections_LODIndex_Offset;

	private static bool GetNumSections_ReturnValue_IsValid;

	private static FFieldAddress GetNumSections_ReturnValue_PropertyAddress;

	private static int GetNumSections_ReturnValue_Offset;

	private static bool GetLODMaterialSlot_IsValid;

	private static IntPtr GetLODMaterialSlot_FunctionAddress;

	private static int GetLODMaterialSlot_ParamsSize;

	private static bool GetLODMaterialSlot_SkeletalMesh_IsValid;

	private static FFieldAddress GetLODMaterialSlot_SkeletalMesh_PropertyAddress;

	private static int GetLODMaterialSlot_SkeletalMesh_Offset;

	private static bool GetLODMaterialSlot_LODIndex_IsValid;

	private static FFieldAddress GetLODMaterialSlot_LODIndex_PropertyAddress;

	private static int GetLODMaterialSlot_LODIndex_Offset;

	private static bool GetLODMaterialSlot_SectionIndex_IsValid;

	private static FFieldAddress GetLODMaterialSlot_SectionIndex_PropertyAddress;

	private static int GetLODMaterialSlot_SectionIndex_Offset;

	private static bool GetLODMaterialSlot_ReturnValue_IsValid;

	private static FFieldAddress GetLODMaterialSlot_ReturnValue_PropertyAddress;

	private static int GetLODMaterialSlot_ReturnValue_Offset;

	private static bool GetLODCount_IsValid;

	private static IntPtr GetLODCount_FunctionAddress;

	private static int GetLODCount_ParamsSize;

	private static bool GetLODCount_SkeletalMesh_IsValid;

	private static FFieldAddress GetLODCount_SkeletalMesh_PropertyAddress;

	private static int GetLODCount_SkeletalMesh_Offset;

	private static bool GetLODCount_ReturnValue_IsValid;

	private static FFieldAddress GetLODCount_ReturnValue_PropertyAddress;

	private static int GetLODCount_ReturnValue_Offset;

	private static bool GetLodBuildSettings_IsValid;

	private static IntPtr GetLodBuildSettings_FunctionAddress;

	private static int GetLodBuildSettings_ParamsSize;

	private static bool GetLodBuildSettings_SkeletalMesh_IsValid;

	private static FFieldAddress GetLodBuildSettings_SkeletalMesh_PropertyAddress;

	private static int GetLodBuildSettings_SkeletalMesh_Offset;

	private static bool GetLodBuildSettings_LodIndex_IsValid;

	private static FFieldAddress GetLodBuildSettings_LodIndex_PropertyAddress;

	private static int GetLodBuildSettings_LodIndex_Offset;

	private static bool GetLodBuildSettings_OutBuildOptions_IsValid;

	private static FFieldAddress GetLodBuildSettings_OutBuildOptions_PropertyAddress;

	private static int GetLodBuildSettings_OutBuildOptions_Offset;

	private static bool CreatePhysicsAsset_IsValid;

	private static IntPtr CreatePhysicsAsset_FunctionAddress;

	private static int CreatePhysicsAsset_ParamsSize;

	private static bool CreatePhysicsAsset_SkeletalMesh_IsValid;

	private static FFieldAddress CreatePhysicsAsset_SkeletalMesh_PropertyAddress;

	private static int CreatePhysicsAsset_SkeletalMesh_Offset;

	private static bool CreatePhysicsAsset_ReturnValue_IsValid;

	private static FFieldAddress CreatePhysicsAsset_ReturnValue_PropertyAddress;

	private static int CreatePhysicsAsset_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:SetOverrideLODStreaming")]
	public unsafe static bool SetOverrideLODStreaming(USkeletalMesh SkeletalMesh, bool Override = false, bool StreamLODs = true, int MaxNumStreamedLODs = 0, int MaxNumOptionalLODs = 0)
	{
		if (!SetOverrideLODStreaming_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:SetOverrideLODStreaming");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOverrideLODStreaming_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOverrideLODStreaming_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, SetOverrideLODStreaming_SkeletalMesh_Offset), 0, SetOverrideLODStreaming_SkeletalMesh_PropertyAddress.Address, SkeletalMesh);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetOverrideLODStreaming_Override_Offset), 0, SetOverrideLODStreaming_Override_PropertyAddress.Address, Override);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetOverrideLODStreaming_StreamLODs_Offset), 0, SetOverrideLODStreaming_StreamLODs_PropertyAddress.Address, StreamLODs);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetOverrideLODStreaming_MaxNumStreamedLODs_Offset), 0, SetOverrideLODStreaming_MaxNumStreamedLODs_PropertyAddress.Address, MaxNumStreamedLODs);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetOverrideLODStreaming_MaxNumOptionalLODs_Offset), 0, SetOverrideLODStreaming_MaxNumOptionalLODs_PropertyAddress.Address, MaxNumOptionalLODs);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetOverrideLODStreaming_FunctionAddress, intPtr, SetOverrideLODStreaming_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetOverrideLODStreaming_ReturnValue_Offset), 0, SetOverrideLODStreaming_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:SetLodBuildSettings")]
	public unsafe static void SetLodBuildSettings(USkeletalMesh SkeletalMesh, int LodIndex, FSkeletalMeshBuildSettings BuildOptions)
	{
		if (!SetLodBuildSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:SetLodBuildSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLodBuildSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLodBuildSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, SetLodBuildSettings_SkeletalMesh_Offset), 0, SetLodBuildSettings_SkeletalMesh_PropertyAddress.Address, SkeletalMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLodBuildSettings_LodIndex_Offset), 0, SetLodBuildSettings_LodIndex_PropertyAddress.Address, LodIndex);
		NativeReflection.InitializeValue_InContainer(SetLodBuildSettings_BuildOptions_PropertyAddress.Address, intPtr);
		FSkeletalMeshBuildSettings.ToNative(IntPtr.Add(intPtr, SetLodBuildSettings_BuildOptions_Offset), 0, SetLodBuildSettings_BuildOptions_PropertyAddress.Address, BuildOptions);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLodBuildSettings_FunctionAddress, intPtr, SetLodBuildSettings_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:RenameSocket")]
	public unsafe static bool RenameSocket(USkeletalMesh SkeletalMesh, FName OldName, FName NewName)
	{
		if (!RenameSocket_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:RenameSocket");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenameSocket_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenameSocket_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, RenameSocket_SkeletalMesh_Offset), 0, RenameSocket_SkeletalMesh_PropertyAddress.Address, SkeletalMesh);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RenameSocket_OldName_Offset), 0, RenameSocket_OldName_PropertyAddress.Address, OldName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RenameSocket_NewName_Offset), 0, RenameSocket_NewName_PropertyAddress.Address, NewName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RenameSocket_FunctionAddress, intPtr, RenameSocket_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RenameSocket_ReturnValue_Offset), 0, RenameSocket_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:ReimportAllCustomLODs")]
	public unsafe static bool ReimportAllCustomLODs(USkeletalMesh SkeletalMesh)
	{
		if (!ReimportAllCustomLODs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:ReimportAllCustomLODs");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReimportAllCustomLODs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReimportAllCustomLODs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, ReimportAllCustomLODs_SkeletalMesh_Offset), 0, ReimportAllCustomLODs_SkeletalMesh_PropertyAddress.Address, SkeletalMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReimportAllCustomLODs_FunctionAddress, intPtr, ReimportAllCustomLODs_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ReimportAllCustomLODs_ReturnValue_Offset), 0, ReimportAllCustomLODs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:RegenerateLOD")]
	public unsafe static bool RegenerateLOD(USkeletalMesh SkeletalMesh, int NewLODCount = 0, bool bRegenerateEvenIfImported = false, bool bGenerateBaseLOD = false)
	{
		if (!RegenerateLOD_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:RegenerateLOD");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegenerateLOD_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegenerateLOD_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, RegenerateLOD_SkeletalMesh_Offset), 0, RegenerateLOD_SkeletalMesh_PropertyAddress.Address, SkeletalMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RegenerateLOD_NewLODCount_Offset), 0, RegenerateLOD_NewLODCount_PropertyAddress.Address, NewLODCount);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RegenerateLOD_bRegenerateEvenIfImported_Offset), 0, RegenerateLOD_bRegenerateEvenIfImported_PropertyAddress.Address, bRegenerateEvenIfImported);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RegenerateLOD_bGenerateBaseLOD_Offset), 0, RegenerateLOD_bGenerateBaseLOD_PropertyAddress.Address, bGenerateBaseLOD);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RegenerateLOD_FunctionAddress, intPtr, RegenerateLOD_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RegenerateLOD_ReturnValue_Offset), 0, RegenerateLOD_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:ImportLOD")]
	public unsafe static int ImportLOD(USkeletalMesh BaseMesh, int LODIndex, string SourceFilename)
	{
		if (!ImportLOD_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:ImportLOD");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ImportLOD_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ImportLOD_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, ImportLOD_BaseMesh_Offset), 0, ImportLOD_BaseMesh_PropertyAddress.Address, BaseMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ImportLOD_LODIndex_Offset), 0, ImportLOD_LODIndex_PropertyAddress.Address, LODIndex);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ImportLOD_SourceFilename_Offset), 0, ImportLOD_SourceFilename_PropertyAddress.Address, SourceFilename);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ImportLOD_FunctionAddress, intPtr, ImportLOD_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ImportLOD_SourceFilename_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, ImportLOD_ReturnValue_Offset), 0, ImportLOD_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:GetNumVerts")]
	public unsafe int GetNumVerts(USkeletalMesh SkeletalMesh, int LODIndex)
	{
		CheckDestroyed();
		if (!GetNumVerts_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:GetNumVerts");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumVerts_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumVerts_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, GetNumVerts_SkeletalMesh_Offset), 0, GetNumVerts_SkeletalMesh_PropertyAddress.Address, SkeletalMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetNumVerts_LODIndex_Offset), 0, GetNumVerts_LODIndex_PropertyAddress.Address, LODIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumVerts_FunctionAddress, intPtr, GetNumVerts_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumVerts_ReturnValue_Offset), 0, GetNumVerts_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:GetNumSections")]
	public unsafe int GetNumSections(USkeletalMesh SkeletalMesh, int LODIndex)
	{
		CheckDestroyed();
		if (!GetNumSections_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:GetNumSections");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumSections_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumSections_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, GetNumSections_SkeletalMesh_Offset), 0, GetNumSections_SkeletalMesh_PropertyAddress.Address, SkeletalMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetNumSections_LODIndex_Offset), 0, GetNumSections_LODIndex_PropertyAddress.Address, LODIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumSections_FunctionAddress, intPtr, GetNumSections_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumSections_ReturnValue_Offset), 0, GetNumSections_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:GetLODMaterialSlot")]
	public unsafe int GetLODMaterialSlot(USkeletalMesh SkeletalMesh, int LODIndex, int SectionIndex)
	{
		CheckDestroyed();
		if (!GetLODMaterialSlot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:GetLODMaterialSlot");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLODMaterialSlot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLODMaterialSlot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, GetLODMaterialSlot_SkeletalMesh_Offset), 0, GetLODMaterialSlot_SkeletalMesh_PropertyAddress.Address, SkeletalMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetLODMaterialSlot_LODIndex_Offset), 0, GetLODMaterialSlot_LODIndex_PropertyAddress.Address, LODIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetLODMaterialSlot_SectionIndex_Offset), 0, GetLODMaterialSlot_SectionIndex_PropertyAddress.Address, SectionIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLODMaterialSlot_FunctionAddress, intPtr, GetLODMaterialSlot_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetLODMaterialSlot_ReturnValue_Offset), 0, GetLODMaterialSlot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:GetLODCount")]
	public unsafe static int GetLODCount(USkeletalMesh SkeletalMesh)
	{
		if (!GetLODCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:GetLODCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLODCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLODCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, GetLODCount_SkeletalMesh_Offset), 0, GetLODCount_SkeletalMesh_PropertyAddress.Address, SkeletalMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLODCount_FunctionAddress, intPtr, GetLODCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetLODCount_ReturnValue_Offset), 0, GetLODCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:GetLodBuildSettings")]
	public unsafe static void GetLodBuildSettings(USkeletalMesh SkeletalMesh, int LodIndex, out FSkeletalMeshBuildSettings OutBuildOptions)
	{
		if (!GetLodBuildSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:GetLodBuildSettings");
			OutBuildOptions = default(FSkeletalMeshBuildSettings);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLodBuildSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLodBuildSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, GetLodBuildSettings_SkeletalMesh_Offset), 0, GetLodBuildSettings_SkeletalMesh_PropertyAddress.Address, SkeletalMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetLodBuildSettings_LodIndex_Offset), 0, GetLodBuildSettings_LodIndex_PropertyAddress.Address, LodIndex);
		NativeReflection.InitializeValue_InContainer(GetLodBuildSettings_OutBuildOptions_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLodBuildSettings_FunctionAddress, intPtr, GetLodBuildSettings_ParamsSize);
		OutBuildOptions = FSkeletalMeshBuildSettings.FromNative(IntPtr.Add(intPtr, GetLodBuildSettings_OutBuildOptions_Offset), 0, GetLodBuildSettings_OutBuildOptions_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:CreatePhysicsAsset")]
	public unsafe static UPhysicsAsset CreatePhysicsAsset(USkeletalMesh SkeletalMesh)
	{
		if (!CreatePhysicsAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:CreatePhysicsAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreatePhysicsAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreatePhysicsAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, CreatePhysicsAsset_SkeletalMesh_Offset), 0, CreatePhysicsAsset_SkeletalMesh_PropertyAddress.Address, SkeletalMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreatePhysicsAsset_FunctionAddress, intPtr, CreatePhysicsAsset_ParamsSize);
		return UObjectMarshaler<UPhysicsAsset>.FromNative(IntPtr.Add(intPtr, CreatePhysicsAsset_ReturnValue_Offset), 0, CreatePhysicsAsset_ReturnValue_PropertyAddress.Address);
	}

	static USkeletalMeshEditorSubsystem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USkeletalMeshEditorSubsystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USkeletalMeshEditorSubsystem));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem");
		SetOverrideLODStreaming_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetOverrideLODStreaming");
		SetOverrideLODStreaming_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOverrideLODStreaming_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOverrideLODStreaming_SkeletalMesh_PropertyAddress, SetOverrideLODStreaming_FunctionAddress, "SkeletalMesh");
		SetOverrideLODStreaming_SkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetOverrideLODStreaming_FunctionAddress, "SkeletalMesh");
		SetOverrideLODStreaming_SkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOverrideLODStreaming_FunctionAddress, "SkeletalMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOverrideLODStreaming_Override_PropertyAddress, SetOverrideLODStreaming_FunctionAddress, "Override");
		SetOverrideLODStreaming_Override_Offset = NativeReflectionCached.GetPropertyOffset(SetOverrideLODStreaming_FunctionAddress, "Override");
		SetOverrideLODStreaming_Override_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOverrideLODStreaming_FunctionAddress, "Override", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOverrideLODStreaming_StreamLODs_PropertyAddress, SetOverrideLODStreaming_FunctionAddress, "StreamLODs");
		SetOverrideLODStreaming_StreamLODs_Offset = NativeReflectionCached.GetPropertyOffset(SetOverrideLODStreaming_FunctionAddress, "StreamLODs");
		SetOverrideLODStreaming_StreamLODs_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOverrideLODStreaming_FunctionAddress, "StreamLODs", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOverrideLODStreaming_MaxNumStreamedLODs_PropertyAddress, SetOverrideLODStreaming_FunctionAddress, "MaxNumStreamedLODs");
		SetOverrideLODStreaming_MaxNumStreamedLODs_Offset = NativeReflectionCached.GetPropertyOffset(SetOverrideLODStreaming_FunctionAddress, "MaxNumStreamedLODs");
		SetOverrideLODStreaming_MaxNumStreamedLODs_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOverrideLODStreaming_FunctionAddress, "MaxNumStreamedLODs", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOverrideLODStreaming_MaxNumOptionalLODs_PropertyAddress, SetOverrideLODStreaming_FunctionAddress, "MaxNumOptionalLODs");
		SetOverrideLODStreaming_MaxNumOptionalLODs_Offset = NativeReflectionCached.GetPropertyOffset(SetOverrideLODStreaming_FunctionAddress, "MaxNumOptionalLODs");
		SetOverrideLODStreaming_MaxNumOptionalLODs_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOverrideLODStreaming_FunctionAddress, "MaxNumOptionalLODs", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOverrideLODStreaming_ReturnValue_PropertyAddress, SetOverrideLODStreaming_FunctionAddress, "ReturnValue");
		SetOverrideLODStreaming_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetOverrideLODStreaming_FunctionAddress, "ReturnValue");
		SetOverrideLODStreaming_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOverrideLODStreaming_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetOverrideLODStreaming_IsValid = SetOverrideLODStreaming_FunctionAddress != IntPtr.Zero && SetOverrideLODStreaming_SkeletalMesh_IsValid && SetOverrideLODStreaming_Override_IsValid && SetOverrideLODStreaming_StreamLODs_IsValid && SetOverrideLODStreaming_MaxNumStreamedLODs_IsValid && SetOverrideLODStreaming_MaxNumOptionalLODs_IsValid && SetOverrideLODStreaming_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:SetOverrideLODStreaming", SetOverrideLODStreaming_IsValid);
		SetLodBuildSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLodBuildSettings");
		SetLodBuildSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLodBuildSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLodBuildSettings_SkeletalMesh_PropertyAddress, SetLodBuildSettings_FunctionAddress, "SkeletalMesh");
		SetLodBuildSettings_SkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetLodBuildSettings_FunctionAddress, "SkeletalMesh");
		SetLodBuildSettings_SkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLodBuildSettings_FunctionAddress, "SkeletalMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLodBuildSettings_LodIndex_PropertyAddress, SetLodBuildSettings_FunctionAddress, "LodIndex");
		SetLodBuildSettings_LodIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetLodBuildSettings_FunctionAddress, "LodIndex");
		SetLodBuildSettings_LodIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLodBuildSettings_FunctionAddress, "LodIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLodBuildSettings_BuildOptions_PropertyAddress, SetLodBuildSettings_FunctionAddress, "BuildOptions");
		SetLodBuildSettings_BuildOptions_Offset = NativeReflectionCached.GetPropertyOffset(SetLodBuildSettings_FunctionAddress, "BuildOptions");
		SetLodBuildSettings_BuildOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLodBuildSettings_FunctionAddress, "BuildOptions", Classes.FStructProperty);
		SetLodBuildSettings_IsValid = SetLodBuildSettings_FunctionAddress != IntPtr.Zero && SetLodBuildSettings_SkeletalMesh_IsValid && SetLodBuildSettings_LodIndex_IsValid && SetLodBuildSettings_BuildOptions_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:SetLodBuildSettings", SetLodBuildSettings_IsValid);
		RenameSocket_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RenameSocket");
		RenameSocket_ParamsSize = NativeReflection.GetFunctionParamsSize(RenameSocket_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenameSocket_SkeletalMesh_PropertyAddress, RenameSocket_FunctionAddress, "SkeletalMesh");
		RenameSocket_SkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(RenameSocket_FunctionAddress, "SkeletalMesh");
		RenameSocket_SkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameSocket_FunctionAddress, "SkeletalMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameSocket_OldName_PropertyAddress, RenameSocket_FunctionAddress, "OldName");
		RenameSocket_OldName_Offset = NativeReflectionCached.GetPropertyOffset(RenameSocket_FunctionAddress, "OldName");
		RenameSocket_OldName_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameSocket_FunctionAddress, "OldName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameSocket_NewName_PropertyAddress, RenameSocket_FunctionAddress, "NewName");
		RenameSocket_NewName_Offset = NativeReflectionCached.GetPropertyOffset(RenameSocket_FunctionAddress, "NewName");
		RenameSocket_NewName_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameSocket_FunctionAddress, "NewName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameSocket_ReturnValue_PropertyAddress, RenameSocket_FunctionAddress, "ReturnValue");
		RenameSocket_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RenameSocket_FunctionAddress, "ReturnValue");
		RenameSocket_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameSocket_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RenameSocket_IsValid = RenameSocket_FunctionAddress != IntPtr.Zero && RenameSocket_SkeletalMesh_IsValid && RenameSocket_OldName_IsValid && RenameSocket_NewName_IsValid && RenameSocket_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:RenameSocket", RenameSocket_IsValid);
		ReimportAllCustomLODs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReimportAllCustomLODs");
		ReimportAllCustomLODs_ParamsSize = NativeReflection.GetFunctionParamsSize(ReimportAllCustomLODs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReimportAllCustomLODs_SkeletalMesh_PropertyAddress, ReimportAllCustomLODs_FunctionAddress, "SkeletalMesh");
		ReimportAllCustomLODs_SkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(ReimportAllCustomLODs_FunctionAddress, "SkeletalMesh");
		ReimportAllCustomLODs_SkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ReimportAllCustomLODs_FunctionAddress, "SkeletalMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReimportAllCustomLODs_ReturnValue_PropertyAddress, ReimportAllCustomLODs_FunctionAddress, "ReturnValue");
		ReimportAllCustomLODs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReimportAllCustomLODs_FunctionAddress, "ReturnValue");
		ReimportAllCustomLODs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReimportAllCustomLODs_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ReimportAllCustomLODs_IsValid = ReimportAllCustomLODs_FunctionAddress != IntPtr.Zero && ReimportAllCustomLODs_SkeletalMesh_IsValid && ReimportAllCustomLODs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:ReimportAllCustomLODs", ReimportAllCustomLODs_IsValid);
		RegenerateLOD_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RegenerateLOD");
		RegenerateLOD_ParamsSize = NativeReflection.GetFunctionParamsSize(RegenerateLOD_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegenerateLOD_SkeletalMesh_PropertyAddress, RegenerateLOD_FunctionAddress, "SkeletalMesh");
		RegenerateLOD_SkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(RegenerateLOD_FunctionAddress, "SkeletalMesh");
		RegenerateLOD_SkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(RegenerateLOD_FunctionAddress, "SkeletalMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RegenerateLOD_NewLODCount_PropertyAddress, RegenerateLOD_FunctionAddress, "NewLODCount");
		RegenerateLOD_NewLODCount_Offset = NativeReflectionCached.GetPropertyOffset(RegenerateLOD_FunctionAddress, "NewLODCount");
		RegenerateLOD_NewLODCount_IsValid = NativeReflectionCached.ValidatePropertyClass(RegenerateLOD_FunctionAddress, "NewLODCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RegenerateLOD_bRegenerateEvenIfImported_PropertyAddress, RegenerateLOD_FunctionAddress, "bRegenerateEvenIfImported");
		RegenerateLOD_bRegenerateEvenIfImported_Offset = NativeReflectionCached.GetPropertyOffset(RegenerateLOD_FunctionAddress, "bRegenerateEvenIfImported");
		RegenerateLOD_bRegenerateEvenIfImported_IsValid = NativeReflectionCached.ValidatePropertyClass(RegenerateLOD_FunctionAddress, "bRegenerateEvenIfImported", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RegenerateLOD_bGenerateBaseLOD_PropertyAddress, RegenerateLOD_FunctionAddress, "bGenerateBaseLOD");
		RegenerateLOD_bGenerateBaseLOD_Offset = NativeReflectionCached.GetPropertyOffset(RegenerateLOD_FunctionAddress, "bGenerateBaseLOD");
		RegenerateLOD_bGenerateBaseLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(RegenerateLOD_FunctionAddress, "bGenerateBaseLOD", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RegenerateLOD_ReturnValue_PropertyAddress, RegenerateLOD_FunctionAddress, "ReturnValue");
		RegenerateLOD_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RegenerateLOD_FunctionAddress, "ReturnValue");
		RegenerateLOD_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RegenerateLOD_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RegenerateLOD_IsValid = RegenerateLOD_FunctionAddress != IntPtr.Zero && RegenerateLOD_SkeletalMesh_IsValid && RegenerateLOD_NewLODCount_IsValid && RegenerateLOD_bRegenerateEvenIfImported_IsValid && RegenerateLOD_bGenerateBaseLOD_IsValid && RegenerateLOD_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:RegenerateLOD", RegenerateLOD_IsValid);
		ImportLOD_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ImportLOD");
		ImportLOD_ParamsSize = NativeReflection.GetFunctionParamsSize(ImportLOD_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ImportLOD_BaseMesh_PropertyAddress, ImportLOD_FunctionAddress, "BaseMesh");
		ImportLOD_BaseMesh_Offset = NativeReflectionCached.GetPropertyOffset(ImportLOD_FunctionAddress, "BaseMesh");
		ImportLOD_BaseMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportLOD_FunctionAddress, "BaseMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportLOD_LODIndex_PropertyAddress, ImportLOD_FunctionAddress, "LODIndex");
		ImportLOD_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(ImportLOD_FunctionAddress, "LODIndex");
		ImportLOD_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportLOD_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportLOD_SourceFilename_PropertyAddress, ImportLOD_FunctionAddress, "SourceFilename");
		ImportLOD_SourceFilename_Offset = NativeReflectionCached.GetPropertyOffset(ImportLOD_FunctionAddress, "SourceFilename");
		ImportLOD_SourceFilename_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportLOD_FunctionAddress, "SourceFilename", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportLOD_ReturnValue_PropertyAddress, ImportLOD_FunctionAddress, "ReturnValue");
		ImportLOD_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ImportLOD_FunctionAddress, "ReturnValue");
		ImportLOD_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportLOD_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		ImportLOD_IsValid = ImportLOD_FunctionAddress != IntPtr.Zero && ImportLOD_BaseMesh_IsValid && ImportLOD_LODIndex_IsValid && ImportLOD_SourceFilename_IsValid && ImportLOD_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:ImportLOD", ImportLOD_IsValid);
		GetNumVerts_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNumVerts");
		GetNumVerts_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumVerts_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumVerts_SkeletalMesh_PropertyAddress, GetNumVerts_FunctionAddress, "SkeletalMesh");
		GetNumVerts_SkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetNumVerts_FunctionAddress, "SkeletalMesh");
		GetNumVerts_SkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumVerts_FunctionAddress, "SkeletalMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumVerts_LODIndex_PropertyAddress, GetNumVerts_FunctionAddress, "LODIndex");
		GetNumVerts_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetNumVerts_FunctionAddress, "LODIndex");
		GetNumVerts_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumVerts_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumVerts_ReturnValue_PropertyAddress, GetNumVerts_FunctionAddress, "ReturnValue");
		GetNumVerts_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumVerts_FunctionAddress, "ReturnValue");
		GetNumVerts_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumVerts_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumVerts_IsValid = GetNumVerts_FunctionAddress != IntPtr.Zero && GetNumVerts_SkeletalMesh_IsValid && GetNumVerts_LODIndex_IsValid && GetNumVerts_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:GetNumVerts", GetNumVerts_IsValid);
		GetNumSections_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNumSections");
		GetNumSections_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumSections_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumSections_SkeletalMesh_PropertyAddress, GetNumSections_FunctionAddress, "SkeletalMesh");
		GetNumSections_SkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetNumSections_FunctionAddress, "SkeletalMesh");
		GetNumSections_SkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumSections_FunctionAddress, "SkeletalMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumSections_LODIndex_PropertyAddress, GetNumSections_FunctionAddress, "LODIndex");
		GetNumSections_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetNumSections_FunctionAddress, "LODIndex");
		GetNumSections_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumSections_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumSections_ReturnValue_PropertyAddress, GetNumSections_FunctionAddress, "ReturnValue");
		GetNumSections_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumSections_FunctionAddress, "ReturnValue");
		GetNumSections_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumSections_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumSections_IsValid = GetNumSections_FunctionAddress != IntPtr.Zero && GetNumSections_SkeletalMesh_IsValid && GetNumSections_LODIndex_IsValid && GetNumSections_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:GetNumSections", GetNumSections_IsValid);
		GetLODMaterialSlot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLODMaterialSlot");
		GetLODMaterialSlot_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLODMaterialSlot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLODMaterialSlot_SkeletalMesh_PropertyAddress, GetLODMaterialSlot_FunctionAddress, "SkeletalMesh");
		GetLODMaterialSlot_SkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetLODMaterialSlot_FunctionAddress, "SkeletalMesh");
		GetLODMaterialSlot_SkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLODMaterialSlot_FunctionAddress, "SkeletalMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLODMaterialSlot_LODIndex_PropertyAddress, GetLODMaterialSlot_FunctionAddress, "LODIndex");
		GetLODMaterialSlot_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetLODMaterialSlot_FunctionAddress, "LODIndex");
		GetLODMaterialSlot_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLODMaterialSlot_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLODMaterialSlot_SectionIndex_PropertyAddress, GetLODMaterialSlot_FunctionAddress, "SectionIndex");
		GetLODMaterialSlot_SectionIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetLODMaterialSlot_FunctionAddress, "SectionIndex");
		GetLODMaterialSlot_SectionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLODMaterialSlot_FunctionAddress, "SectionIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLODMaterialSlot_ReturnValue_PropertyAddress, GetLODMaterialSlot_FunctionAddress, "ReturnValue");
		GetLODMaterialSlot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLODMaterialSlot_FunctionAddress, "ReturnValue");
		GetLODMaterialSlot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLODMaterialSlot_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetLODMaterialSlot_IsValid = GetLODMaterialSlot_FunctionAddress != IntPtr.Zero && GetLODMaterialSlot_SkeletalMesh_IsValid && GetLODMaterialSlot_LODIndex_IsValid && GetLODMaterialSlot_SectionIndex_IsValid && GetLODMaterialSlot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:GetLODMaterialSlot", GetLODMaterialSlot_IsValid);
		GetLODCount_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLODCount");
		GetLODCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLODCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLODCount_SkeletalMesh_PropertyAddress, GetLODCount_FunctionAddress, "SkeletalMesh");
		GetLODCount_SkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetLODCount_FunctionAddress, "SkeletalMesh");
		GetLODCount_SkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLODCount_FunctionAddress, "SkeletalMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLODCount_ReturnValue_PropertyAddress, GetLODCount_FunctionAddress, "ReturnValue");
		GetLODCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLODCount_FunctionAddress, "ReturnValue");
		GetLODCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLODCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetLODCount_IsValid = GetLODCount_FunctionAddress != IntPtr.Zero && GetLODCount_SkeletalMesh_IsValid && GetLODCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:GetLODCount", GetLODCount_IsValid);
		GetLodBuildSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLodBuildSettings");
		GetLodBuildSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLodBuildSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLodBuildSettings_SkeletalMesh_PropertyAddress, GetLodBuildSettings_FunctionAddress, "SkeletalMesh");
		GetLodBuildSettings_SkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetLodBuildSettings_FunctionAddress, "SkeletalMesh");
		GetLodBuildSettings_SkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLodBuildSettings_FunctionAddress, "SkeletalMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLodBuildSettings_LodIndex_PropertyAddress, GetLodBuildSettings_FunctionAddress, "LodIndex");
		GetLodBuildSettings_LodIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetLodBuildSettings_FunctionAddress, "LodIndex");
		GetLodBuildSettings_LodIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLodBuildSettings_FunctionAddress, "LodIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLodBuildSettings_OutBuildOptions_PropertyAddress, GetLodBuildSettings_FunctionAddress, "OutBuildOptions");
		GetLodBuildSettings_OutBuildOptions_Offset = NativeReflectionCached.GetPropertyOffset(GetLodBuildSettings_FunctionAddress, "OutBuildOptions");
		GetLodBuildSettings_OutBuildOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLodBuildSettings_FunctionAddress, "OutBuildOptions", Classes.FStructProperty);
		GetLodBuildSettings_IsValid = GetLodBuildSettings_FunctionAddress != IntPtr.Zero && GetLodBuildSettings_SkeletalMesh_IsValid && GetLodBuildSettings_LodIndex_IsValid && GetLodBuildSettings_OutBuildOptions_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:GetLodBuildSettings", GetLodBuildSettings_IsValid);
		CreatePhysicsAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreatePhysicsAsset");
		CreatePhysicsAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(CreatePhysicsAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreatePhysicsAsset_SkeletalMesh_PropertyAddress, CreatePhysicsAsset_FunctionAddress, "SkeletalMesh");
		CreatePhysicsAsset_SkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(CreatePhysicsAsset_FunctionAddress, "SkeletalMesh");
		CreatePhysicsAsset_SkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePhysicsAsset_FunctionAddress, "SkeletalMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreatePhysicsAsset_ReturnValue_PropertyAddress, CreatePhysicsAsset_FunctionAddress, "ReturnValue");
		CreatePhysicsAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreatePhysicsAsset_FunctionAddress, "ReturnValue");
		CreatePhysicsAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePhysicsAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreatePhysicsAsset_IsValid = CreatePhysicsAsset_FunctionAddress != IntPtr.Zero && CreatePhysicsAsset_SkeletalMesh_IsValid && CreatePhysicsAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem:CreatePhysicsAsset", CreatePhysicsAsset_IsValid);
	}
}
