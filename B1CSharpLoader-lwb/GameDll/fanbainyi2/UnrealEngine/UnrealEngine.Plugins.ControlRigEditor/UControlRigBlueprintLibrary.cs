using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.ControlRig;
using UnrealEngine.Plugins.ControlRigDeveloper;
using UnrealEngine.RigVMDeveloper;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigEditor;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary", "ControlRigEditor", UnrealModuleType.EnginePlugin)]
public class UControlRigBlueprintLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetPreviewMesh_IsValid;

	private static IntPtr SetPreviewMesh_FunctionAddress;

	private static int SetPreviewMesh_ParamsSize;

	private static bool SetPreviewMesh_InRigBlueprint_IsValid;

	private static FFieldAddress SetPreviewMesh_InRigBlueprint_PropertyAddress;

	private static int SetPreviewMesh_InRigBlueprint_Offset;

	private static bool SetPreviewMesh_PreviewMesh_IsValid;

	private static FFieldAddress SetPreviewMesh_PreviewMesh_PropertyAddress;

	private static int SetPreviewMesh_PreviewMesh_Offset;

	private static bool SetPreviewMesh_bMarkAsDirty_IsValid;

	private static FFieldAddress SetPreviewMesh_bMarkAsDirty_PropertyAddress;

	private static int SetPreviewMesh_bMarkAsDirty_Offset;

	private static bool RequestControlRigInit_IsValid;

	private static IntPtr RequestControlRigInit_FunctionAddress;

	private static int RequestControlRigInit_ParamsSize;

	private static bool RequestControlRigInit_InRigBlueprint_IsValid;

	private static FFieldAddress RequestControlRigInit_InRigBlueprint_PropertyAddress;

	private static int RequestControlRigInit_InRigBlueprint_Offset;

	private static bool RequestAutoVMRecompilation_IsValid;

	private static IntPtr RequestAutoVMRecompilation_FunctionAddress;

	private static int RequestAutoVMRecompilation_ParamsSize;

	private static bool RequestAutoVMRecompilation_InRigBlueprint_IsValid;

	private static FFieldAddress RequestAutoVMRecompilation_InRigBlueprint_PropertyAddress;

	private static int RequestAutoVMRecompilation_InRigBlueprint_Offset;

	private static bool RecompileVMIfRequired_IsValid;

	private static IntPtr RecompileVMIfRequired_FunctionAddress;

	private static int RecompileVMIfRequired_ParamsSize;

	private static bool RecompileVMIfRequired_InRigBlueprint_IsValid;

	private static FFieldAddress RecompileVMIfRequired_InRigBlueprint_PropertyAddress;

	private static int RecompileVMIfRequired_InRigBlueprint_Offset;

	private static bool RecompileVM_IsValid;

	private static IntPtr RecompileVM_FunctionAddress;

	private static int RecompileVM_ParamsSize;

	private static bool RecompileVM_InRigBlueprint_IsValid;

	private static FFieldAddress RecompileVM_InRigBlueprint_PropertyAddress;

	private static int RecompileVM_InRigBlueprint_Offset;

	private static bool GetPreviewMesh_IsValid;

	private static IntPtr GetPreviewMesh_FunctionAddress;

	private static int GetPreviewMesh_ParamsSize;

	private static bool GetPreviewMesh_InRigBlueprint_IsValid;

	private static FFieldAddress GetPreviewMesh_InRigBlueprint_PropertyAddress;

	private static int GetPreviewMesh_InRigBlueprint_Offset;

	private static bool GetPreviewMesh_ReturnValue_IsValid;

	private static FFieldAddress GetPreviewMesh_ReturnValue_PropertyAddress;

	private static int GetPreviewMesh_ReturnValue_Offset;

	private static bool GetModel_IsValid;

	private static IntPtr GetModel_FunctionAddress;

	private static int GetModel_ParamsSize;

	private static bool GetModel_InRigBlueprint_IsValid;

	private static FFieldAddress GetModel_InRigBlueprint_PropertyAddress;

	private static int GetModel_InRigBlueprint_Offset;

	private static bool GetModel_ReturnValue_IsValid;

	private static FFieldAddress GetModel_ReturnValue_PropertyAddress;

	private static int GetModel_ReturnValue_Offset;

	private static bool GetHierarchyController_IsValid;

	private static IntPtr GetHierarchyController_FunctionAddress;

	private static int GetHierarchyController_ParamsSize;

	private static bool GetHierarchyController_InRigBlueprint_IsValid;

	private static FFieldAddress GetHierarchyController_InRigBlueprint_PropertyAddress;

	private static int GetHierarchyController_InRigBlueprint_Offset;

	private static bool GetHierarchyController_ReturnValue_IsValid;

	private static FFieldAddress GetHierarchyController_ReturnValue_PropertyAddress;

	private static int GetHierarchyController_ReturnValue_Offset;

	private static bool GetHierarchy_IsValid;

	private static IntPtr GetHierarchy_FunctionAddress;

	private static int GetHierarchy_ParamsSize;

	private static bool GetHierarchy_InRigBlueprint_IsValid;

	private static FFieldAddress GetHierarchy_InRigBlueprint_PropertyAddress;

	private static int GetHierarchy_InRigBlueprint_Offset;

	private static bool GetHierarchy_ReturnValue_IsValid;

	private static FFieldAddress GetHierarchy_ReturnValue_PropertyAddress;

	private static int GetHierarchy_ReturnValue_Offset;

	private static bool GetCurrentlyOpenRigBlueprints_IsValid;

	private static IntPtr GetCurrentlyOpenRigBlueprints_FunctionAddress;

	private static int GetCurrentlyOpenRigBlueprints_ParamsSize;

	private static bool GetCurrentlyOpenRigBlueprints_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentlyOpenRigBlueprints_ReturnValue_PropertyAddress;

	private static int GetCurrentlyOpenRigBlueprints_ReturnValue_Offset;

	private static bool GetController_IsValid;

	private static IntPtr GetController_FunctionAddress;

	private static int GetController_ParamsSize;

	private static bool GetController_InRigBlueprint_IsValid;

	private static FFieldAddress GetController_InRigBlueprint_PropertyAddress;

	private static int GetController_InRigBlueprint_Offset;

	private static bool GetController_ReturnValue_IsValid;

	private static FFieldAddress GetController_ReturnValue_PropertyAddress;

	private static int GetController_ReturnValue_Offset;

	private static bool GetAvailableRigUnits_IsValid;

	private static IntPtr GetAvailableRigUnits_FunctionAddress;

	private static int GetAvailableRigUnits_ParamsSize;

	private static bool GetAvailableRigUnits_ReturnValue_IsValid;

	private static FFieldAddress GetAvailableRigUnits_ReturnValue_PropertyAddress;

	private static int GetAvailableRigUnits_ReturnValue_Offset;

	private static bool CastToControlRigBlueprint_IsValid;

	private static IntPtr CastToControlRigBlueprint_FunctionAddress;

	private static int CastToControlRigBlueprint_ParamsSize;

	private static bool CastToControlRigBlueprint_Object_IsValid;

	private static FFieldAddress CastToControlRigBlueprint_Object_PropertyAddress;

	private static int CastToControlRigBlueprint_Object_Offset;

	private static bool CastToControlRigBlueprint_Branches_IsValid;

	private static FFieldAddress CastToControlRigBlueprint_Branches_PropertyAddress;

	private static int CastToControlRigBlueprint_Branches_Offset;

	private static bool CastToControlRigBlueprint_AsControlRigBlueprint_IsValid;

	private static FFieldAddress CastToControlRigBlueprint_AsControlRigBlueprint_PropertyAddress;

	private static int CastToControlRigBlueprint_AsControlRigBlueprint_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:SetPreviewMesh")]
	public unsafe static void SetPreviewMesh(UControlRigBlueprint InRigBlueprint, USkeletalMesh PreviewMesh, bool bMarkAsDirty = true)
	{
		if (!SetPreviewMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:SetPreviewMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPreviewMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPreviewMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRigBlueprint>.ToNative(IntPtr.Add(intPtr, SetPreviewMesh_InRigBlueprint_Offset), 0, SetPreviewMesh_InRigBlueprint_PropertyAddress.Address, InRigBlueprint);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, SetPreviewMesh_PreviewMesh_Offset), 0, SetPreviewMesh_PreviewMesh_PropertyAddress.Address, PreviewMesh);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPreviewMesh_bMarkAsDirty_Offset), 0, SetPreviewMesh_bMarkAsDirty_PropertyAddress.Address, bMarkAsDirty);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPreviewMesh_FunctionAddress, intPtr, SetPreviewMesh_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:RequestControlRigInit")]
	public unsafe static void RequestControlRigInit(UControlRigBlueprint InRigBlueprint)
	{
		if (!RequestControlRigInit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:RequestControlRigInit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestControlRigInit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestControlRigInit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRigBlueprint>.ToNative(IntPtr.Add(intPtr, RequestControlRigInit_InRigBlueprint_Offset), 0, RequestControlRigInit_InRigBlueprint_PropertyAddress.Address, InRigBlueprint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RequestControlRigInit_FunctionAddress, intPtr, RequestControlRigInit_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:RequestAutoVMRecompilation")]
	public unsafe static void RequestAutoVMRecompilation(UControlRigBlueprint InRigBlueprint)
	{
		if (!RequestAutoVMRecompilation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:RequestAutoVMRecompilation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestAutoVMRecompilation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestAutoVMRecompilation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRigBlueprint>.ToNative(IntPtr.Add(intPtr, RequestAutoVMRecompilation_InRigBlueprint_Offset), 0, RequestAutoVMRecompilation_InRigBlueprint_PropertyAddress.Address, InRigBlueprint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RequestAutoVMRecompilation_FunctionAddress, intPtr, RequestAutoVMRecompilation_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:RecompileVMIfRequired")]
	public unsafe static void RecompileVMIfRequired(UControlRigBlueprint InRigBlueprint)
	{
		if (!RecompileVMIfRequired_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:RecompileVMIfRequired");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecompileVMIfRequired_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecompileVMIfRequired_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRigBlueprint>.ToNative(IntPtr.Add(intPtr, RecompileVMIfRequired_InRigBlueprint_Offset), 0, RecompileVMIfRequired_InRigBlueprint_PropertyAddress.Address, InRigBlueprint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RecompileVMIfRequired_FunctionAddress, intPtr, RecompileVMIfRequired_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:RecompileVM")]
	public unsafe static void RecompileVM(UControlRigBlueprint InRigBlueprint)
	{
		if (!RecompileVM_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:RecompileVM");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecompileVM_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecompileVM_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRigBlueprint>.ToNative(IntPtr.Add(intPtr, RecompileVM_InRigBlueprint_Offset), 0, RecompileVM_InRigBlueprint_PropertyAddress.Address, InRigBlueprint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RecompileVM_FunctionAddress, intPtr, RecompileVM_ParamsSize);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetPreviewMesh")]
	public unsafe static USkeletalMesh GetPreviewMesh(UControlRigBlueprint InRigBlueprint)
	{
		if (!GetPreviewMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetPreviewMesh");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPreviewMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPreviewMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRigBlueprint>.ToNative(IntPtr.Add(intPtr, GetPreviewMesh_InRigBlueprint_Offset), 0, GetPreviewMesh_InRigBlueprint_PropertyAddress.Address, InRigBlueprint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPreviewMesh_FunctionAddress, intPtr, GetPreviewMesh_ParamsSize);
		return UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(intPtr, GetPreviewMesh_ReturnValue_Offset), 0, GetPreviewMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetModel")]
	public unsafe static URigVMGraph GetModel(UControlRigBlueprint InRigBlueprint)
	{
		if (!GetModel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetModel");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetModel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetModel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRigBlueprint>.ToNative(IntPtr.Add(intPtr, GetModel_InRigBlueprint_Offset), 0, GetModel_InRigBlueprint_PropertyAddress.Address, InRigBlueprint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetModel_FunctionAddress, intPtr, GetModel_ParamsSize);
		return UObjectMarshaler<URigVMGraph>.FromNative(IntPtr.Add(intPtr, GetModel_ReturnValue_Offset), 0, GetModel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetHierarchyController")]
	public unsafe static URigHierarchyController GetHierarchyController(UControlRigBlueprint InRigBlueprint)
	{
		if (!GetHierarchyController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetHierarchyController");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHierarchyController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHierarchyController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRigBlueprint>.ToNative(IntPtr.Add(intPtr, GetHierarchyController_InRigBlueprint_Offset), 0, GetHierarchyController_InRigBlueprint_PropertyAddress.Address, InRigBlueprint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetHierarchyController_FunctionAddress, intPtr, GetHierarchyController_ParamsSize);
		return UObjectMarshaler<URigHierarchyController>.FromNative(IntPtr.Add(intPtr, GetHierarchyController_ReturnValue_Offset), 0, GetHierarchyController_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetHierarchy")]
	public unsafe static URigHierarchy GetHierarchy(UControlRigBlueprint InRigBlueprint)
	{
		if (!GetHierarchy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetHierarchy");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHierarchy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHierarchy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRigBlueprint>.ToNative(IntPtr.Add(intPtr, GetHierarchy_InRigBlueprint_Offset), 0, GetHierarchy_InRigBlueprint_PropertyAddress.Address, InRigBlueprint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetHierarchy_FunctionAddress, intPtr, GetHierarchy_ParamsSize);
		return UObjectMarshaler<URigHierarchy>.FromNative(IntPtr.Add(intPtr, GetHierarchy_ReturnValue_Offset), 0, GetHierarchy_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetCurrentlyOpenRigBlueprints")]
	public unsafe static List<UControlRigBlueprint> GetCurrentlyOpenRigBlueprints()
	{
		if (!GetCurrentlyOpenRigBlueprints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetCurrentlyOpenRigBlueprints");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentlyOpenRigBlueprints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentlyOpenRigBlueprints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentlyOpenRigBlueprints_FunctionAddress, intPtr, GetCurrentlyOpenRigBlueprints_ParamsSize);
		List<UControlRigBlueprint> result = new TArrayCopyMarshaler<UControlRigBlueprint>(1, GetCurrentlyOpenRigBlueprints_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UControlRigBlueprint, UObjectMarshaler<UControlRigBlueprint>>.FromNative, CachedMarshalingDelegates<UControlRigBlueprint, UObjectMarshaler<UControlRigBlueprint>>.ToNative).FromNative(IntPtr.Add(intPtr, GetCurrentlyOpenRigBlueprints_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetCurrentlyOpenRigBlueprints_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetController")]
	public unsafe static URigVMController GetController(UControlRigBlueprint InRigBlueprint)
	{
		if (!GetController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetController");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRigBlueprint>.ToNative(IntPtr.Add(intPtr, GetController_InRigBlueprint_Offset), 0, GetController_InRigBlueprint_PropertyAddress.Address, InRigBlueprint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetController_FunctionAddress, intPtr, GetController_ParamsSize);
		return UObjectMarshaler<URigVMController>.FromNative(IntPtr.Add(intPtr, GetController_ReturnValue_Offset), 0, GetController_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetAvailableRigUnits")]
	public unsafe static List<UStruct> GetAvailableRigUnits()
	{
		if (!GetAvailableRigUnits_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetAvailableRigUnits");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAvailableRigUnits_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAvailableRigUnits_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAvailableRigUnits_FunctionAddress, intPtr, GetAvailableRigUnits_ParamsSize);
		List<UStruct> result = new TArrayCopyMarshaler<UStruct>(1, GetAvailableRigUnits_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UStruct, UObjectMarshaler<UStruct>>.FromNative, CachedMarshalingDelegates<UStruct, UObjectMarshaler<UStruct>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAvailableRigUnits_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAvailableRigUnits_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:CastToControlRigBlueprint")]
	public unsafe static void CastToControlRigBlueprint(UObject Object, out ECastToControlRigBlueprintCases Branches, out UControlRigBlueprint AsControlRigBlueprint)
	{
		if (!CastToControlRigBlueprint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:CastToControlRigBlueprint");
			Branches = ECastToControlRigBlueprintCases.CastSucceeded;
			AsControlRigBlueprint = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CastToControlRigBlueprint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CastToControlRigBlueprint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CastToControlRigBlueprint_Object_Offset), 0, CastToControlRigBlueprint_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CastToControlRigBlueprint_FunctionAddress, intPtr, CastToControlRigBlueprint_ParamsSize);
		Branches = EnumMarshaler<ECastToControlRigBlueprintCases>.FromNative(IntPtr.Add(intPtr, CastToControlRigBlueprint_Branches_Offset), 0, CastToControlRigBlueprint_Branches_PropertyAddress.Address);
		AsControlRigBlueprint = UObjectMarshaler<UControlRigBlueprint>.FromNative(IntPtr.Add(intPtr, CastToControlRigBlueprint_AsControlRigBlueprint_Offset), 0, CastToControlRigBlueprint_AsControlRigBlueprint_PropertyAddress.Address);
	}

	static UControlRigBlueprintLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UControlRigBlueprintLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UControlRigBlueprintLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary");
		SetPreviewMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPreviewMesh");
		SetPreviewMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPreviewMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPreviewMesh_InRigBlueprint_PropertyAddress, SetPreviewMesh_FunctionAddress, "InRigBlueprint");
		SetPreviewMesh_InRigBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(SetPreviewMesh_FunctionAddress, "InRigBlueprint");
		SetPreviewMesh_InRigBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPreviewMesh_FunctionAddress, "InRigBlueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPreviewMesh_PreviewMesh_PropertyAddress, SetPreviewMesh_FunctionAddress, "PreviewMesh");
		SetPreviewMesh_PreviewMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetPreviewMesh_FunctionAddress, "PreviewMesh");
		SetPreviewMesh_PreviewMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPreviewMesh_FunctionAddress, "PreviewMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPreviewMesh_bMarkAsDirty_PropertyAddress, SetPreviewMesh_FunctionAddress, "bMarkAsDirty");
		SetPreviewMesh_bMarkAsDirty_Offset = NativeReflectionCached.GetPropertyOffset(SetPreviewMesh_FunctionAddress, "bMarkAsDirty");
		SetPreviewMesh_bMarkAsDirty_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPreviewMesh_FunctionAddress, "bMarkAsDirty", Classes.FBoolProperty);
		SetPreviewMesh_IsValid = SetPreviewMesh_FunctionAddress != IntPtr.Zero && SetPreviewMesh_InRigBlueprint_IsValid && SetPreviewMesh_PreviewMesh_IsValid && SetPreviewMesh_bMarkAsDirty_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:SetPreviewMesh", SetPreviewMesh_IsValid);
		RequestControlRigInit_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestControlRigInit");
		RequestControlRigInit_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestControlRigInit_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequestControlRigInit_InRigBlueprint_PropertyAddress, RequestControlRigInit_FunctionAddress, "InRigBlueprint");
		RequestControlRigInit_InRigBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(RequestControlRigInit_FunctionAddress, "InRigBlueprint");
		RequestControlRigInit_InRigBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestControlRigInit_FunctionAddress, "InRigBlueprint", Classes.FObjectProperty);
		RequestControlRigInit_IsValid = RequestControlRigInit_FunctionAddress != IntPtr.Zero && RequestControlRigInit_InRigBlueprint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:RequestControlRigInit", RequestControlRigInit_IsValid);
		RequestAutoVMRecompilation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestAutoVMRecompilation");
		RequestAutoVMRecompilation_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestAutoVMRecompilation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequestAutoVMRecompilation_InRigBlueprint_PropertyAddress, RequestAutoVMRecompilation_FunctionAddress, "InRigBlueprint");
		RequestAutoVMRecompilation_InRigBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(RequestAutoVMRecompilation_FunctionAddress, "InRigBlueprint");
		RequestAutoVMRecompilation_InRigBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAutoVMRecompilation_FunctionAddress, "InRigBlueprint", Classes.FObjectProperty);
		RequestAutoVMRecompilation_IsValid = RequestAutoVMRecompilation_FunctionAddress != IntPtr.Zero && RequestAutoVMRecompilation_InRigBlueprint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:RequestAutoVMRecompilation", RequestAutoVMRecompilation_IsValid);
		RecompileVMIfRequired_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RecompileVMIfRequired");
		RecompileVMIfRequired_ParamsSize = NativeReflection.GetFunctionParamsSize(RecompileVMIfRequired_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RecompileVMIfRequired_InRigBlueprint_PropertyAddress, RecompileVMIfRequired_FunctionAddress, "InRigBlueprint");
		RecompileVMIfRequired_InRigBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(RecompileVMIfRequired_FunctionAddress, "InRigBlueprint");
		RecompileVMIfRequired_InRigBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(RecompileVMIfRequired_FunctionAddress, "InRigBlueprint", Classes.FObjectProperty);
		RecompileVMIfRequired_IsValid = RecompileVMIfRequired_FunctionAddress != IntPtr.Zero && RecompileVMIfRequired_InRigBlueprint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:RecompileVMIfRequired", RecompileVMIfRequired_IsValid);
		RecompileVM_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RecompileVM");
		RecompileVM_ParamsSize = NativeReflection.GetFunctionParamsSize(RecompileVM_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RecompileVM_InRigBlueprint_PropertyAddress, RecompileVM_FunctionAddress, "InRigBlueprint");
		RecompileVM_InRigBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(RecompileVM_FunctionAddress, "InRigBlueprint");
		RecompileVM_InRigBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(RecompileVM_FunctionAddress, "InRigBlueprint", Classes.FObjectProperty);
		RecompileVM_IsValid = RecompileVM_FunctionAddress != IntPtr.Zero && RecompileVM_InRigBlueprint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:RecompileVM", RecompileVM_IsValid);
		GetPreviewMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPreviewMesh");
		GetPreviewMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPreviewMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPreviewMesh_InRigBlueprint_PropertyAddress, GetPreviewMesh_FunctionAddress, "InRigBlueprint");
		GetPreviewMesh_InRigBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(GetPreviewMesh_FunctionAddress, "InRigBlueprint");
		GetPreviewMesh_InRigBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreviewMesh_FunctionAddress, "InRigBlueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPreviewMesh_ReturnValue_PropertyAddress, GetPreviewMesh_FunctionAddress, "ReturnValue");
		GetPreviewMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPreviewMesh_FunctionAddress, "ReturnValue");
		GetPreviewMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreviewMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPreviewMesh_IsValid = GetPreviewMesh_FunctionAddress != IntPtr.Zero && GetPreviewMesh_InRigBlueprint_IsValid && GetPreviewMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetPreviewMesh", GetPreviewMesh_IsValid);
		GetModel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetModel");
		GetModel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetModel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetModel_InRigBlueprint_PropertyAddress, GetModel_FunctionAddress, "InRigBlueprint");
		GetModel_InRigBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(GetModel_FunctionAddress, "InRigBlueprint");
		GetModel_InRigBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(GetModel_FunctionAddress, "InRigBlueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetModel_ReturnValue_PropertyAddress, GetModel_FunctionAddress, "ReturnValue");
		GetModel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetModel_FunctionAddress, "ReturnValue");
		GetModel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetModel_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetModel_IsValid = GetModel_FunctionAddress != IntPtr.Zero && GetModel_InRigBlueprint_IsValid && GetModel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetModel", GetModel_IsValid);
		GetHierarchyController_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetHierarchyController");
		GetHierarchyController_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHierarchyController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHierarchyController_InRigBlueprint_PropertyAddress, GetHierarchyController_FunctionAddress, "InRigBlueprint");
		GetHierarchyController_InRigBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(GetHierarchyController_FunctionAddress, "InRigBlueprint");
		GetHierarchyController_InRigBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHierarchyController_FunctionAddress, "InRigBlueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHierarchyController_ReturnValue_PropertyAddress, GetHierarchyController_FunctionAddress, "ReturnValue");
		GetHierarchyController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHierarchyController_FunctionAddress, "ReturnValue");
		GetHierarchyController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHierarchyController_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetHierarchyController_IsValid = GetHierarchyController_FunctionAddress != IntPtr.Zero && GetHierarchyController_InRigBlueprint_IsValid && GetHierarchyController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetHierarchyController", GetHierarchyController_IsValid);
		GetHierarchy_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetHierarchy");
		GetHierarchy_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHierarchy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHierarchy_InRigBlueprint_PropertyAddress, GetHierarchy_FunctionAddress, "InRigBlueprint");
		GetHierarchy_InRigBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(GetHierarchy_FunctionAddress, "InRigBlueprint");
		GetHierarchy_InRigBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHierarchy_FunctionAddress, "InRigBlueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHierarchy_ReturnValue_PropertyAddress, GetHierarchy_FunctionAddress, "ReturnValue");
		GetHierarchy_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHierarchy_FunctionAddress, "ReturnValue");
		GetHierarchy_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHierarchy_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetHierarchy_IsValid = GetHierarchy_FunctionAddress != IntPtr.Zero && GetHierarchy_InRigBlueprint_IsValid && GetHierarchy_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetHierarchy", GetHierarchy_IsValid);
		GetCurrentlyOpenRigBlueprints_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentlyOpenRigBlueprints");
		GetCurrentlyOpenRigBlueprints_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentlyOpenRigBlueprints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentlyOpenRigBlueprints_ReturnValue_PropertyAddress, GetCurrentlyOpenRigBlueprints_FunctionAddress, "ReturnValue");
		GetCurrentlyOpenRigBlueprints_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentlyOpenRigBlueprints_FunctionAddress, "ReturnValue");
		GetCurrentlyOpenRigBlueprints_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentlyOpenRigBlueprints_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetCurrentlyOpenRigBlueprints_IsValid = GetCurrentlyOpenRigBlueprints_FunctionAddress != IntPtr.Zero && GetCurrentlyOpenRigBlueprints_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetCurrentlyOpenRigBlueprints", GetCurrentlyOpenRigBlueprints_IsValid);
		GetController_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetController");
		GetController_ParamsSize = NativeReflection.GetFunctionParamsSize(GetController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetController_InRigBlueprint_PropertyAddress, GetController_FunctionAddress, "InRigBlueprint");
		GetController_InRigBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(GetController_FunctionAddress, "InRigBlueprint");
		GetController_InRigBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(GetController_FunctionAddress, "InRigBlueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetController_ReturnValue_PropertyAddress, GetController_FunctionAddress, "ReturnValue");
		GetController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetController_FunctionAddress, "ReturnValue");
		GetController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetController_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetController_IsValid = GetController_FunctionAddress != IntPtr.Zero && GetController_InRigBlueprint_IsValid && GetController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetController", GetController_IsValid);
		GetAvailableRigUnits_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAvailableRigUnits");
		GetAvailableRigUnits_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAvailableRigUnits_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAvailableRigUnits_ReturnValue_PropertyAddress, GetAvailableRigUnits_FunctionAddress, "ReturnValue");
		GetAvailableRigUnits_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAvailableRigUnits_FunctionAddress, "ReturnValue");
		GetAvailableRigUnits_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAvailableRigUnits_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAvailableRigUnits_IsValid = GetAvailableRigUnits_FunctionAddress != IntPtr.Zero && GetAvailableRigUnits_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetAvailableRigUnits", GetAvailableRigUnits_IsValid);
		CastToControlRigBlueprint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CastToControlRigBlueprint");
		CastToControlRigBlueprint_ParamsSize = NativeReflection.GetFunctionParamsSize(CastToControlRigBlueprint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CastToControlRigBlueprint_Object_PropertyAddress, CastToControlRigBlueprint_FunctionAddress, "Object");
		CastToControlRigBlueprint_Object_Offset = NativeReflectionCached.GetPropertyOffset(CastToControlRigBlueprint_FunctionAddress, "Object");
		CastToControlRigBlueprint_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(CastToControlRigBlueprint_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CastToControlRigBlueprint_Branches_PropertyAddress, CastToControlRigBlueprint_FunctionAddress, "Branches");
		CastToControlRigBlueprint_Branches_Offset = NativeReflectionCached.GetPropertyOffset(CastToControlRigBlueprint_FunctionAddress, "Branches");
		CastToControlRigBlueprint_Branches_IsValid = NativeReflectionCached.ValidatePropertyClass(CastToControlRigBlueprint_FunctionAddress, "Branches", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref CastToControlRigBlueprint_AsControlRigBlueprint_PropertyAddress, CastToControlRigBlueprint_FunctionAddress, "AsControlRigBlueprint");
		CastToControlRigBlueprint_AsControlRigBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(CastToControlRigBlueprint_FunctionAddress, "AsControlRigBlueprint");
		CastToControlRigBlueprint_AsControlRigBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(CastToControlRigBlueprint_FunctionAddress, "AsControlRigBlueprint", Classes.FObjectProperty);
		CastToControlRigBlueprint_IsValid = CastToControlRigBlueprint_FunctionAddress != IntPtr.Zero && CastToControlRigBlueprint_Object_IsValid && CastToControlRigBlueprint_Branches_IsValid && CastToControlRigBlueprint_AsControlRigBlueprint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:CastToControlRigBlueprint", CastToControlRigBlueprint_IsValid);
	}
}
