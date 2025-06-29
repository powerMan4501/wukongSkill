using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.ControlRig;
using UnrealEngine.RigVMDeveloper;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigDeveloper;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint", "ControlRigDeveloper", UnrealModuleType.EnginePlugin)]
public class UControlRigBlueprint : UBlueprint, IInterface_PreviewMeshProvider, IInterface
{
	private static IntPtr classAddress;

	private static bool VMCompileSettings_IsValid;

	private static int VMCompileSettings_Offset;

	private static bool Model_IsValid;

	private static int Model_Offset;

	private static bool FunctionLibrary_IsValid;

	private static int FunctionLibrary_Offset;

	private static bool Controllers_IsValid;

	private static FFieldAddress Controllers_PropertyAddress;

	private static int Controllers_Offset;

	private TMapReadOnlyMarshaler<URigVMGraph, URigVMController> Controllers_MarshalerCached;

	private static bool Hierarchy_IsValid;

	private static int Hierarchy_Offset;

	private static bool SuspendNotifications_IsValid;

	private static IntPtr SuspendNotifications_FunctionAddress;

	private static int SuspendNotifications_ParamsSize;

	private static bool SuspendNotifications_bSuspendNotifs_IsValid;

	private static FFieldAddress SuspendNotifications_bSuspendNotifs_PropertyAddress;

	private static int SuspendNotifications_bSuspendNotifs_Offset;

	private static bool SetPreviewMesh_IsValid;

	private static IntPtr SetPreviewMesh_FunctionAddress;

	private static int SetPreviewMesh_ParamsSize;

	private static bool SetPreviewMesh_PreviewMesh_IsValid;

	private static FFieldAddress SetPreviewMesh_PreviewMesh_PropertyAddress;

	private static int SetPreviewMesh_PreviewMesh_Offset;

	private static bool SetPreviewMesh_bMarkAsDirty_IsValid;

	private static FFieldAddress SetPreviewMesh_bMarkAsDirty_PropertyAddress;

	private static int SetPreviewMesh_bMarkAsDirty_Offset;

	private static bool RequestControlRigInit_IsValid;

	private static IntPtr RequestControlRigInit_FunctionAddress;

	private static int RequestControlRigInit_ParamsSize;

	private static bool RequestAutoVMRecompilation_IsValid;

	private static IntPtr RequestAutoVMRecompilation_FunctionAddress;

	private static int RequestAutoVMRecompilation_ParamsSize;

	private static bool RenameMemberVariable_IsValid;

	private static IntPtr RenameMemberVariable_FunctionAddress;

	private static int RenameMemberVariable_ParamsSize;

	private static bool RenameMemberVariable_InOldName_IsValid;

	private static FFieldAddress RenameMemberVariable_InOldName_PropertyAddress;

	private static int RenameMemberVariable_InOldName_Offset;

	private static bool RenameMemberVariable_InNewName_IsValid;

	private static FFieldAddress RenameMemberVariable_InNewName_PropertyAddress;

	private static int RenameMemberVariable_InNewName_Offset;

	private static bool RenameMemberVariable_ReturnValue_IsValid;

	private static FFieldAddress RenameMemberVariable_ReturnValue_PropertyAddress;

	private static int RenameMemberVariable_ReturnValue_Offset;

	private static bool RemoveMemberVariable_IsValid;

	private static IntPtr RemoveMemberVariable_FunctionAddress;

	private static int RemoveMemberVariable_ParamsSize;

	private static bool RemoveMemberVariable_InName_IsValid;

	private static FFieldAddress RemoveMemberVariable_InName_PropertyAddress;

	private static int RemoveMemberVariable_InName_Offset;

	private static bool RemoveMemberVariable_ReturnValue_IsValid;

	private static FFieldAddress RemoveMemberVariable_ReturnValue_PropertyAddress;

	private static int RemoveMemberVariable_ReturnValue_Offset;

	private static bool RecompileVMIfRequired_IsValid;

	private static IntPtr RecompileVMIfRequired_FunctionAddress;

	private static int RecompileVMIfRequired_ParamsSize;

	private static bool RecompileVM_IsValid;

	private static IntPtr RecompileVM_FunctionAddress;

	private static int RecompileVM_ParamsSize;

	private static bool GetPreviewMesh_IsValid;

	private static IntPtr GetPreviewMesh_FunctionAddress;

	private static int GetPreviewMesh_ParamsSize;

	private static bool GetPreviewMesh_ReturnValue_IsValid;

	private static FFieldAddress GetPreviewMesh_ReturnValue_PropertyAddress;

	private static int GetPreviewMesh_ReturnValue_Offset;

	private static bool GetOrCreateController_IsValid;

	private static IntPtr GetOrCreateController_FunctionAddress;

	private static int GetOrCreateController_ParamsSize;

	private static bool GetOrCreateController_InGraph_IsValid;

	private static FFieldAddress GetOrCreateController_InGraph_PropertyAddress;

	private static int GetOrCreateController_InGraph_Offset;

	private static bool GetOrCreateController_ReturnValue_IsValid;

	private static FFieldAddress GetOrCreateController_ReturnValue_PropertyAddress;

	private static int GetOrCreateController_ReturnValue_Offset;

	private static bool GetModel_IsValid;

	private static IntPtr GetModel_FunctionAddress;

	private static int GetModel_ParamsSize;

	private static bool GetModel_InEdGraph_IsValid;

	private static FFieldAddress GetModel_InEdGraph_PropertyAddress;

	private static int GetModel_InEdGraph_Offset;

	private static bool GetModel_ReturnValue_IsValid;

	private static FFieldAddress GetModel_ReturnValue_PropertyAddress;

	private static int GetModel_ReturnValue_Offset;

	private static bool GetLocalFunctionLibrary_IsValid;

	private static IntPtr GetLocalFunctionLibrary_FunctionAddress;

	private static int GetLocalFunctionLibrary_ParamsSize;

	private static bool GetLocalFunctionLibrary_ReturnValue_IsValid;

	private static FFieldAddress GetLocalFunctionLibrary_ReturnValue_PropertyAddress;

	private static int GetLocalFunctionLibrary_ReturnValue_Offset;

	private static bool GetHierarchyController_IsValid;

	private static IntPtr GetHierarchyController_FunctionAddress;

	private static int GetHierarchyController_ParamsSize;

	private static bool GetHierarchyController_ReturnValue_IsValid;

	private static FFieldAddress GetHierarchyController_ReturnValue_PropertyAddress;

	private static int GetHierarchyController_ReturnValue_Offset;

	private static bool GetCurrentlyOpenRigBlueprints_IsValid;

	private static IntPtr GetCurrentlyOpenRigBlueprints_FunctionAddress;

	private static int GetCurrentlyOpenRigBlueprints_ParamsSize;

	private static bool GetCurrentlyOpenRigBlueprints_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentlyOpenRigBlueprints_ReturnValue_PropertyAddress;

	private static int GetCurrentlyOpenRigBlueprints_ReturnValue_Offset;

	private static bool GetControlRigClass_IsValid;

	private static IntPtr GetControlRigClass_FunctionAddress;

	private static int GetControlRigClass_ParamsSize;

	private static bool GetControlRigClass_ReturnValue_IsValid;

	private static FFieldAddress GetControlRigClass_ReturnValue_PropertyAddress;

	private static int GetControlRigClass_ReturnValue_Offset;

	private static bool GetControllerByName_IsValid;

	private static IntPtr GetControllerByName_FunctionAddress;

	private static int GetControllerByName_ParamsSize;

	private static bool GetControllerByName_InGraphName_IsValid;

	private static FFieldAddress GetControllerByName_InGraphName_PropertyAddress;

	private static int GetControllerByName_InGraphName_Offset;

	private static bool GetControllerByName_ReturnValue_IsValid;

	private static FFieldAddress GetControllerByName_ReturnValue_PropertyAddress;

	private static int GetControllerByName_ReturnValue_Offset;

	private static bool GetController_IsValid;

	private static IntPtr GetController_FunctionAddress;

	private static int GetController_ParamsSize;

	private static bool GetController_InGraph_IsValid;

	private static FFieldAddress GetController_InGraph_PropertyAddress;

	private static int GetController_InGraph_Offset;

	private static bool GetController_ReturnValue_IsValid;

	private static FFieldAddress GetController_ReturnValue_PropertyAddress;

	private static int GetController_ReturnValue_Offset;

	private static bool GetAvailableRigUnits_IsValid;

	private static IntPtr GetAvailableRigUnits_FunctionAddress;

	private static int GetAvailableRigUnits_ParamsSize;

	private static bool GetAvailableRigUnits_ReturnValue_IsValid;

	private static FFieldAddress GetAvailableRigUnits_ReturnValue_PropertyAddress;

	private static int GetAvailableRigUnits_ReturnValue_Offset;

	private static bool GetAllModels_IsValid;

	private static IntPtr GetAllModels_FunctionAddress;

	private static int GetAllModels_ParamsSize;

	private static bool GetAllModels_ReturnValue_IsValid;

	private static FFieldAddress GetAllModels_ReturnValue_PropertyAddress;

	private static int GetAllModels_ReturnValue_Offset;

	private static bool GeneratePythonCommands_IsValid;

	private static IntPtr GeneratePythonCommands_FunctionAddress;

	private static int GeneratePythonCommands_ParamsSize;

	private static bool GeneratePythonCommands_InNewBlueprintName_IsValid;

	private static FFieldAddress GeneratePythonCommands_InNewBlueprintName_PropertyAddress;

	private static int GeneratePythonCommands_InNewBlueprintName_Offset;

	private static bool GeneratePythonCommands_ReturnValue_IsValid;

	private static FFieldAddress GeneratePythonCommands_ReturnValue_PropertyAddress;

	private static int GeneratePythonCommands_ReturnValue_Offset;

	private static bool CreateControlRig_IsValid;

	private static IntPtr CreateControlRig_FunctionAddress;

	private static int CreateControlRig_ParamsSize;

	private static bool CreateControlRig_ReturnValue_IsValid;

	private static FFieldAddress CreateControlRig_ReturnValue_PropertyAddress;

	private static int CreateControlRig_ReturnValue_Offset;

	private static bool ChangeMemberVariableType_IsValid;

	private static IntPtr ChangeMemberVariableType_FunctionAddress;

	private static int ChangeMemberVariableType_ParamsSize;

	private static bool ChangeMemberVariableType_InName_IsValid;

	private static FFieldAddress ChangeMemberVariableType_InName_PropertyAddress;

	private static int ChangeMemberVariableType_InName_Offset;

	private static bool ChangeMemberVariableType_InCPPType_IsValid;

	private static FFieldAddress ChangeMemberVariableType_InCPPType_PropertyAddress;

	private static int ChangeMemberVariableType_InCPPType_Offset;

	private static bool ChangeMemberVariableType_bIsPublic_IsValid;

	private static FFieldAddress ChangeMemberVariableType_bIsPublic_PropertyAddress;

	private static int ChangeMemberVariableType_bIsPublic_Offset;

	private static bool ChangeMemberVariableType_bIsReadOnly_IsValid;

	private static FFieldAddress ChangeMemberVariableType_bIsReadOnly_PropertyAddress;

	private static int ChangeMemberVariableType_bIsReadOnly_Offset;

	private static bool ChangeMemberVariableType_InDefaultValue_IsValid;

	private static FFieldAddress ChangeMemberVariableType_InDefaultValue_PropertyAddress;

	private static int ChangeMemberVariableType_InDefaultValue_Offset;

	private static bool ChangeMemberVariableType_ReturnValue_IsValid;

	private static FFieldAddress ChangeMemberVariableType_ReturnValue_PropertyAddress;

	private static int ChangeMemberVariableType_ReturnValue_Offset;

	private static bool AddMemberVariable_IsValid;

	private static IntPtr AddMemberVariable_FunctionAddress;

	private static int AddMemberVariable_ParamsSize;

	private static bool AddMemberVariable_InName_IsValid;

	private static FFieldAddress AddMemberVariable_InName_PropertyAddress;

	private static int AddMemberVariable_InName_Offset;

	private static bool AddMemberVariable_InCPPType_IsValid;

	private static FFieldAddress AddMemberVariable_InCPPType_PropertyAddress;

	private static int AddMemberVariable_InCPPType_Offset;

	private static bool AddMemberVariable_bIsPublic_IsValid;

	private static FFieldAddress AddMemberVariable_bIsPublic_PropertyAddress;

	private static int AddMemberVariable_bIsPublic_Offset;

	private static bool AddMemberVariable_bIsReadOnly_IsValid;

	private static FFieldAddress AddMemberVariable_bIsReadOnly_PropertyAddress;

	private static int AddMemberVariable_bIsReadOnly_Offset;

	private static bool AddMemberVariable_InDefaultValue_IsValid;

	private static FFieldAddress AddMemberVariable_InDefaultValue_PropertyAddress;

	private static int AddMemberVariable_InDefaultValue_Offset;

	private static bool AddMemberVariable_ReturnValue_IsValid;

	private static FFieldAddress AddMemberVariable_ReturnValue_PropertyAddress;

	private static int AddMemberVariable_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:VMCompileSettings")]
	public FRigVMCompileSettings VMCompileSettings
	{
		get
		{
			CheckDestroyed();
			if (!VMCompileSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:VMCompileSettings");
				return default(FRigVMCompileSettings);
			}
			return FRigVMCompileSettings.FromNative(IntPtr.Add(base.Address, VMCompileSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VMCompileSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:VMCompileSettings");
			}
			else
			{
				FRigVMCompileSettings.ToNative(IntPtr.Add(base.Address, VMCompileSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764861510164uL)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:Model")]
	protected URigVMGraph Model
	{
		get
		{
			CheckDestroyed();
			if (!Model_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:Model");
				return null;
			}
			return UObjectMarshaler<URigVMGraph>.FromNative(IntPtr.Add(base.Address, Model_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Model_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:Model");
			}
			else
			{
				UObjectMarshaler<URigVMGraph>.ToNative(IntPtr.Add(base.Address, Model_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764861510164uL)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:FunctionLibrary")]
	protected URigVMFunctionLibrary FunctionLibrary
	{
		get
		{
			CheckDestroyed();
			if (!FunctionLibrary_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:FunctionLibrary");
				return null;
			}
			return UObjectMarshaler<URigVMFunctionLibrary>.FromNative(IntPtr.Add(base.Address, FunctionLibrary_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FunctionLibrary_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:FunctionLibrary");
			}
			else
			{
				UObjectMarshaler<URigVMFunctionLibrary>.ToNative(IntPtr.Add(base.Address, FunctionLibrary_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)10141895254614036uL)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:Controllers")]
	protected TMapReadOnly<URigVMGraph, URigVMController> Controllers
	{
		get
		{
			CheckDestroyed();
			if (!Controllers_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:Controllers");
				return null;
			}
			if (Controllers_MarshalerCached == null)
			{
				Controllers_MarshalerCached = new TMapReadOnlyMarshaler<URigVMGraph, URigVMController>(1, Controllers_PropertyAddress, CachedMarshalingDelegates<URigVMGraph, UObjectMarshaler<URigVMGraph>>.FromNative, CachedMarshalingDelegates<URigVMGraph, UObjectMarshaler<URigVMGraph>>.ToNative, CachedMarshalingDelegates<URigVMController, UObjectMarshaler<URigVMController>>.FromNative, CachedMarshalingDelegates<URigVMController, UObjectMarshaler<URigVMController>>.ToNative);
			}
			return Controllers_MarshalerCached.FromNative(IntPtr.Add(base.Address, Controllers_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117460uL)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:Hierarchy")]
	public URigHierarchy Hierarchy
	{
		get
		{
			CheckDestroyed();
			if (!Hierarchy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:Hierarchy");
				return null;
			}
			return UObjectMarshaler<URigHierarchy>.FromNative(IntPtr.Add(base.Address, Hierarchy_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Hierarchy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:Hierarchy");
			}
			else
			{
				UObjectMarshaler<URigHierarchy>.ToNative(IntPtr.Add(base.Address, Hierarchy_Offset), value);
			}
		}
	}

	[UFunction(Flags = 604242945u)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:SuspendNotifications")]
	public unsafe void SuspendNotifications(bool bSuspendNotifs)
	{
		CheckDestroyed();
		if (!SuspendNotifications_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:SuspendNotifications");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SuspendNotifications_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SuspendNotifications_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SuspendNotifications_bSuspendNotifs_Offset), 0, SuspendNotifications_bSuspendNotifs_PropertyAddress.Address, bSuspendNotifs);
		NativeReflection.InvokeFunctionOptimized(base.Address, SuspendNotifications_FunctionAddress, intPtr, SuspendNotifications_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:SetPreviewMesh")]
	public unsafe void SetPreviewMesh(USkeletalMesh PreviewMesh, bool bMarkAsDirty = true)
	{
		CheckDestroyed();
		if (!SetPreviewMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:SetPreviewMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPreviewMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPreviewMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, SetPreviewMesh_PreviewMesh_Offset), 0, SetPreviewMesh_PreviewMesh_PropertyAddress.Address, PreviewMesh);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPreviewMesh_bMarkAsDirty_Offset), 0, SetPreviewMesh_bMarkAsDirty_PropertyAddress.Address, bMarkAsDirty);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPreviewMesh_FunctionAddress, intPtr, SetPreviewMesh_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:RequestControlRigInit")]
	public unsafe void RequestControlRigInit()
	{
		CheckDestroyed();
		if (!RequestControlRigInit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:RequestControlRigInit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestControlRigInit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestControlRigInit_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RequestControlRigInit_FunctionAddress, argsSize: RequestControlRigInit_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:RequestAutoVMRecompilation")]
	public unsafe void RequestAutoVMRecompilation()
	{
		CheckDestroyed();
		if (!RequestAutoVMRecompilation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:RequestAutoVMRecompilation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestAutoVMRecompilation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestAutoVMRecompilation_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RequestAutoVMRecompilation_FunctionAddress, argsSize: RequestAutoVMRecompilation_ParamsSize);
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:RenameMemberVariable")]
	public unsafe bool RenameMemberVariable(FName InOldName, FName InNewName)
	{
		CheckDestroyed();
		if (!RenameMemberVariable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:RenameMemberVariable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenameMemberVariable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenameMemberVariable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RenameMemberVariable_InOldName_Offset), 0, RenameMemberVariable_InOldName_PropertyAddress.Address, InOldName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RenameMemberVariable_InNewName_Offset), 0, RenameMemberVariable_InNewName_PropertyAddress.Address, InNewName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RenameMemberVariable_FunctionAddress, intPtr, RenameMemberVariable_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RenameMemberVariable_ReturnValue_Offset), 0, RenameMemberVariable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:RemoveMemberVariable")]
	public unsafe bool RemoveMemberVariable(FName InName)
	{
		CheckDestroyed();
		if (!RemoveMemberVariable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:RemoveMemberVariable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveMemberVariable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveMemberVariable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveMemberVariable_InName_Offset), 0, RemoveMemberVariable_InName_PropertyAddress.Address, InName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveMemberVariable_FunctionAddress, intPtr, RemoveMemberVariable_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveMemberVariable_ReturnValue_Offset), 0, RemoveMemberVariable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:RecompileVMIfRequired")]
	public unsafe void RecompileVMIfRequired()
	{
		CheckDestroyed();
		if (!RecompileVMIfRequired_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:RecompileVMIfRequired");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecompileVMIfRequired_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecompileVMIfRequired_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RecompileVMIfRequired_FunctionAddress, argsSize: RecompileVMIfRequired_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:RecompileVM")]
	public unsafe void RecompileVM()
	{
		CheckDestroyed();
		if (!RecompileVM_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:RecompileVM");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecompileVM_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecompileVM_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RecompileVM_FunctionAddress, argsSize: RecompileVM_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:GetPreviewMesh")]
	public unsafe USkeletalMesh GetPreviewMesh()
	{
		CheckDestroyed();
		if (!GetPreviewMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:GetPreviewMesh");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPreviewMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPreviewMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPreviewMesh_FunctionAddress, intPtr, GetPreviewMesh_ParamsSize);
		return UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(intPtr, GetPreviewMesh_ReturnValue_Offset), 0, GetPreviewMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:GetOrCreateController")]
	public unsafe URigVMController GetOrCreateController(URigVMGraph InGraph)
	{
		CheckDestroyed();
		if (!GetOrCreateController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:GetOrCreateController");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOrCreateController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOrCreateController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigVMGraph>.ToNative(IntPtr.Add(intPtr, GetOrCreateController_InGraph_Offset), 0, GetOrCreateController_InGraph_PropertyAddress.Address, InGraph);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOrCreateController_FunctionAddress, intPtr, GetOrCreateController_ParamsSize);
		return UObjectMarshaler<URigVMController>.FromNative(IntPtr.Add(intPtr, GetOrCreateController_ReturnValue_Offset), 0, GetOrCreateController_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:GetModel")]
	public unsafe URigVMGraph GetModel(UEdGraph InEdGraph)
	{
		CheckDestroyed();
		if (!GetModel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:GetModel");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetModel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetModel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEdGraph>.ToNative(IntPtr.Add(intPtr, GetModel_InEdGraph_Offset), 0, GetModel_InEdGraph_PropertyAddress.Address, InEdGraph);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetModel_FunctionAddress, intPtr, GetModel_ParamsSize);
		return UObjectMarshaler<URigVMGraph>.FromNative(IntPtr.Add(intPtr, GetModel_ReturnValue_Offset), 0, GetModel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:GetLocalFunctionLibrary")]
	public unsafe URigVMFunctionLibrary GetLocalFunctionLibrary()
	{
		CheckDestroyed();
		if (!GetLocalFunctionLibrary_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:GetLocalFunctionLibrary");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocalFunctionLibrary_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocalFunctionLibrary_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLocalFunctionLibrary_FunctionAddress, intPtr, GetLocalFunctionLibrary_ParamsSize);
		return UObjectMarshaler<URigVMFunctionLibrary>.FromNative(IntPtr.Add(intPtr, GetLocalFunctionLibrary_ReturnValue_Offset), 0, GetLocalFunctionLibrary_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:GetHierarchyController")]
	public unsafe URigHierarchyController GetHierarchyController()
	{
		CheckDestroyed();
		if (!GetHierarchyController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:GetHierarchyController");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHierarchyController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHierarchyController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHierarchyController_FunctionAddress, intPtr, GetHierarchyController_ParamsSize);
		return UObjectMarshaler<URigHierarchyController>.FromNative(IntPtr.Add(intPtr, GetHierarchyController_ReturnValue_Offset), 0, GetHierarchyController_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:GetCurrentlyOpenRigBlueprints")]
	public unsafe static List<UControlRigBlueprint> GetCurrentlyOpenRigBlueprints()
	{
		if (!GetCurrentlyOpenRigBlueprints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:GetCurrentlyOpenRigBlueprints");
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

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:GetControlRigClass")]
	public unsafe TSubclassOf<UObject> GetControlRigClass()
	{
		CheckDestroyed();
		if (!GetControlRigClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:GetControlRigClass");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetControlRigClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetControlRigClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetControlRigClass_FunctionAddress, intPtr, GetControlRigClass_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetControlRigClass_ReturnValue_Offset), 0, GetControlRigClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:GetControllerByName")]
	public unsafe URigVMController GetControllerByName(string InGraphName)
	{
		CheckDestroyed();
		if (!GetControllerByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:GetControllerByName");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetControllerByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetControllerByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetControllerByName_InGraphName_Offset), 0, GetControllerByName_InGraphName_PropertyAddress.Address, InGraphName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetControllerByName_FunctionAddress, intPtr, GetControllerByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetControllerByName_InGraphName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMController>.FromNative(IntPtr.Add(intPtr, GetControllerByName_ReturnValue_Offset), 0, GetControllerByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:GetController")]
	public unsafe URigVMController GetController(URigVMGraph InGraph)
	{
		CheckDestroyed();
		if (!GetController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:GetController");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigVMGraph>.ToNative(IntPtr.Add(intPtr, GetController_InGraph_Offset), 0, GetController_InGraph_PropertyAddress.Address, InGraph);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetController_FunctionAddress, intPtr, GetController_ParamsSize);
		return UObjectMarshaler<URigVMController>.FromNative(IntPtr.Add(intPtr, GetController_ReturnValue_Offset), 0, GetController_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:GetAvailableRigUnits")]
	public unsafe static List<UStruct> GetAvailableRigUnits()
	{
		if (!GetAvailableRigUnits_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:GetAvailableRigUnits");
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

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:GetAllModels")]
	public unsafe List<URigVMGraph> GetAllModels()
	{
		CheckDestroyed();
		if (!GetAllModels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:GetAllModels");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllModels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllModels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllModels_FunctionAddress, intPtr, GetAllModels_ParamsSize);
		List<URigVMGraph> result = new TArrayCopyMarshaler<URigVMGraph>(1, GetAllModels_ReturnValue_PropertyAddress, CachedMarshalingDelegates<URigVMGraph, UObjectMarshaler<URigVMGraph>>.FromNative, CachedMarshalingDelegates<URigVMGraph, UObjectMarshaler<URigVMGraph>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllModels_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllModels_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:GeneratePythonCommands")]
	public unsafe List<string> GeneratePythonCommands(string InNewBlueprintName)
	{
		CheckDestroyed();
		if (!GeneratePythonCommands_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:GeneratePythonCommands");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GeneratePythonCommands_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GeneratePythonCommands_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GeneratePythonCommands_InNewBlueprintName_Offset), 0, GeneratePythonCommands_InNewBlueprintName_PropertyAddress.Address, InNewBlueprintName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GeneratePythonCommands_FunctionAddress, intPtr, GeneratePythonCommands_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GeneratePythonCommands_InNewBlueprintName_PropertyAddress.Address, intPtr);
		List<string> result = new TArrayCopyMarshaler<string>(1, GeneratePythonCommands_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GeneratePythonCommands_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GeneratePythonCommands_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:CreateControlRig")]
	public unsafe UControlRig CreateControlRig()
	{
		CheckDestroyed();
		if (!CreateControlRig_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:CreateControlRig");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateControlRig_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateControlRig_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateControlRig_FunctionAddress, intPtr, CreateControlRig_ParamsSize);
		return UObjectMarshaler<UControlRig>.FromNative(IntPtr.Add(intPtr, CreateControlRig_ReturnValue_Offset), 0, CreateControlRig_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:ChangeMemberVariableType")]
	public unsafe bool ChangeMemberVariableType(FName InName, string InCPPType, bool bIsPublic = false, bool bIsReadOnly = false, string InDefaultValue = null)
	{
		CheckDestroyed();
		if (!ChangeMemberVariableType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:ChangeMemberVariableType");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ChangeMemberVariableType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ChangeMemberVariableType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ChangeMemberVariableType_InName_Offset), 0, ChangeMemberVariableType_InName_PropertyAddress.Address, InName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ChangeMemberVariableType_InCPPType_Offset), 0, ChangeMemberVariableType_InCPPType_PropertyAddress.Address, InCPPType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ChangeMemberVariableType_bIsPublic_Offset), 0, ChangeMemberVariableType_bIsPublic_PropertyAddress.Address, bIsPublic);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ChangeMemberVariableType_bIsReadOnly_Offset), 0, ChangeMemberVariableType_bIsReadOnly_PropertyAddress.Address, bIsReadOnly);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ChangeMemberVariableType_InDefaultValue_Offset), 0, ChangeMemberVariableType_InDefaultValue_PropertyAddress.Address, InDefaultValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, ChangeMemberVariableType_FunctionAddress, intPtr, ChangeMemberVariableType_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ChangeMemberVariableType_InCPPType_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ChangeMemberVariableType_InDefaultValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ChangeMemberVariableType_ReturnValue_Offset), 0, ChangeMemberVariableType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/ControlRigDeveloper.ControlRigBlueprint:AddMemberVariable")]
	public unsafe FName AddMemberVariable(FName InName, string InCPPType, bool bIsPublic = false, bool bIsReadOnly = false, string InDefaultValue = null)
	{
		CheckDestroyed();
		if (!AddMemberVariable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigDeveloper.ControlRigBlueprint:AddMemberVariable");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMemberVariable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMemberVariable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddMemberVariable_InName_Offset), 0, AddMemberVariable_InName_PropertyAddress.Address, InName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddMemberVariable_InCPPType_Offset), 0, AddMemberVariable_InCPPType_PropertyAddress.Address, InCPPType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddMemberVariable_bIsPublic_Offset), 0, AddMemberVariable_bIsPublic_PropertyAddress.Address, bIsPublic);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddMemberVariable_bIsReadOnly_Offset), 0, AddMemberVariable_bIsReadOnly_PropertyAddress.Address, bIsReadOnly);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddMemberVariable_InDefaultValue_Offset), 0, AddMemberVariable_InDefaultValue_PropertyAddress.Address, InDefaultValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddMemberVariable_FunctionAddress, intPtr, AddMemberVariable_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddMemberVariable_InCPPType_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddMemberVariable_InDefaultValue_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, AddMemberVariable_ReturnValue_Offset), 0, AddMemberVariable_ReturnValue_PropertyAddress.Address);
	}

	static UControlRigBlueprint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UControlRigBlueprint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UControlRigBlueprint));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/ControlRigDeveloper.ControlRigBlueprint");
		VMCompileSettings_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "VMCompileSettings");
		VMCompileSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "VMCompileSettings", Classes.FStructProperty);
		Model_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "Model");
		Model_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "Model", Classes.FObjectProperty);
		FunctionLibrary_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "FunctionLibrary");
		FunctionLibrary_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "FunctionLibrary", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Controllers_PropertyAddress, classAddress, "Controllers");
		Controllers_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "Controllers");
		Controllers_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "Controllers", Classes.FMapProperty);
		Hierarchy_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "Hierarchy");
		Hierarchy_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "Hierarchy", Classes.FObjectProperty);
		SuspendNotifications_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SuspendNotifications");
		SuspendNotifications_ParamsSize = NativeReflection.GetFunctionParamsSize(SuspendNotifications_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SuspendNotifications_bSuspendNotifs_PropertyAddress, SuspendNotifications_FunctionAddress, "bSuspendNotifs");
		SuspendNotifications_bSuspendNotifs_Offset = NativeReflectionCached.GetPropertyOffset(SuspendNotifications_FunctionAddress, "bSuspendNotifs");
		SuspendNotifications_bSuspendNotifs_IsValid = NativeReflectionCached.ValidatePropertyClass(SuspendNotifications_FunctionAddress, "bSuspendNotifs", Classes.FBoolProperty);
		SuspendNotifications_IsValid = SuspendNotifications_FunctionAddress != IntPtr.Zero && SuspendNotifications_bSuspendNotifs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigDeveloper.ControlRigBlueprint:SuspendNotifications", SuspendNotifications_IsValid);
		SetPreviewMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPreviewMesh");
		SetPreviewMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPreviewMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPreviewMesh_PreviewMesh_PropertyAddress, SetPreviewMesh_FunctionAddress, "PreviewMesh");
		SetPreviewMesh_PreviewMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetPreviewMesh_FunctionAddress, "PreviewMesh");
		SetPreviewMesh_PreviewMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPreviewMesh_FunctionAddress, "PreviewMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPreviewMesh_bMarkAsDirty_PropertyAddress, SetPreviewMesh_FunctionAddress, "bMarkAsDirty");
		SetPreviewMesh_bMarkAsDirty_Offset = NativeReflectionCached.GetPropertyOffset(SetPreviewMesh_FunctionAddress, "bMarkAsDirty");
		SetPreviewMesh_bMarkAsDirty_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPreviewMesh_FunctionAddress, "bMarkAsDirty", Classes.FBoolProperty);
		SetPreviewMesh_IsValid = SetPreviewMesh_FunctionAddress != IntPtr.Zero && SetPreviewMesh_PreviewMesh_IsValid && SetPreviewMesh_bMarkAsDirty_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigDeveloper.ControlRigBlueprint:SetPreviewMesh", SetPreviewMesh_IsValid);
		RequestControlRigInit_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestControlRigInit");
		RequestControlRigInit_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestControlRigInit_FunctionAddress);
		RequestControlRigInit_IsValid = RequestControlRigInit_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigDeveloper.ControlRigBlueprint:RequestControlRigInit", RequestControlRigInit_IsValid);
		RequestAutoVMRecompilation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestAutoVMRecompilation");
		RequestAutoVMRecompilation_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestAutoVMRecompilation_FunctionAddress);
		RequestAutoVMRecompilation_IsValid = RequestAutoVMRecompilation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigDeveloper.ControlRigBlueprint:RequestAutoVMRecompilation", RequestAutoVMRecompilation_IsValid);
		RenameMemberVariable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RenameMemberVariable");
		RenameMemberVariable_ParamsSize = NativeReflection.GetFunctionParamsSize(RenameMemberVariable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenameMemberVariable_InOldName_PropertyAddress, RenameMemberVariable_FunctionAddress, "InOldName");
		RenameMemberVariable_InOldName_Offset = NativeReflectionCached.GetPropertyOffset(RenameMemberVariable_FunctionAddress, "InOldName");
		RenameMemberVariable_InOldName_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameMemberVariable_FunctionAddress, "InOldName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameMemberVariable_InNewName_PropertyAddress, RenameMemberVariable_FunctionAddress, "InNewName");
		RenameMemberVariable_InNewName_Offset = NativeReflectionCached.GetPropertyOffset(RenameMemberVariable_FunctionAddress, "InNewName");
		RenameMemberVariable_InNewName_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameMemberVariable_FunctionAddress, "InNewName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameMemberVariable_ReturnValue_PropertyAddress, RenameMemberVariable_FunctionAddress, "ReturnValue");
		RenameMemberVariable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RenameMemberVariable_FunctionAddress, "ReturnValue");
		RenameMemberVariable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameMemberVariable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RenameMemberVariable_IsValid = RenameMemberVariable_FunctionAddress != IntPtr.Zero && RenameMemberVariable_InOldName_IsValid && RenameMemberVariable_InNewName_IsValid && RenameMemberVariable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigDeveloper.ControlRigBlueprint:RenameMemberVariable", RenameMemberVariable_IsValid);
		RemoveMemberVariable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveMemberVariable");
		RemoveMemberVariable_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveMemberVariable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveMemberVariable_InName_PropertyAddress, RemoveMemberVariable_FunctionAddress, "InName");
		RemoveMemberVariable_InName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveMemberVariable_FunctionAddress, "InName");
		RemoveMemberVariable_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveMemberVariable_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveMemberVariable_ReturnValue_PropertyAddress, RemoveMemberVariable_FunctionAddress, "ReturnValue");
		RemoveMemberVariable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveMemberVariable_FunctionAddress, "ReturnValue");
		RemoveMemberVariable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveMemberVariable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveMemberVariable_IsValid = RemoveMemberVariable_FunctionAddress != IntPtr.Zero && RemoveMemberVariable_InName_IsValid && RemoveMemberVariable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigDeveloper.ControlRigBlueprint:RemoveMemberVariable", RemoveMemberVariable_IsValid);
		RecompileVMIfRequired_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RecompileVMIfRequired");
		RecompileVMIfRequired_ParamsSize = NativeReflection.GetFunctionParamsSize(RecompileVMIfRequired_FunctionAddress);
		RecompileVMIfRequired_IsValid = RecompileVMIfRequired_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigDeveloper.ControlRigBlueprint:RecompileVMIfRequired", RecompileVMIfRequired_IsValid);
		RecompileVM_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RecompileVM");
		RecompileVM_ParamsSize = NativeReflection.GetFunctionParamsSize(RecompileVM_FunctionAddress);
		RecompileVM_IsValid = RecompileVM_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigDeveloper.ControlRigBlueprint:RecompileVM", RecompileVM_IsValid);
		GetPreviewMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPreviewMesh");
		GetPreviewMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPreviewMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPreviewMesh_ReturnValue_PropertyAddress, GetPreviewMesh_FunctionAddress, "ReturnValue");
		GetPreviewMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPreviewMesh_FunctionAddress, "ReturnValue");
		GetPreviewMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreviewMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPreviewMesh_IsValid = GetPreviewMesh_FunctionAddress != IntPtr.Zero && GetPreviewMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigDeveloper.ControlRigBlueprint:GetPreviewMesh", GetPreviewMesh_IsValid);
		GetOrCreateController_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOrCreateController");
		GetOrCreateController_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOrCreateController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOrCreateController_InGraph_PropertyAddress, GetOrCreateController_FunctionAddress, "InGraph");
		GetOrCreateController_InGraph_Offset = NativeReflectionCached.GetPropertyOffset(GetOrCreateController_FunctionAddress, "InGraph");
		GetOrCreateController_InGraph_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOrCreateController_FunctionAddress, "InGraph", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOrCreateController_ReturnValue_PropertyAddress, GetOrCreateController_FunctionAddress, "ReturnValue");
		GetOrCreateController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOrCreateController_FunctionAddress, "ReturnValue");
		GetOrCreateController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOrCreateController_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetOrCreateController_IsValid = GetOrCreateController_FunctionAddress != IntPtr.Zero && GetOrCreateController_InGraph_IsValid && GetOrCreateController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigDeveloper.ControlRigBlueprint:GetOrCreateController", GetOrCreateController_IsValid);
		GetModel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetModel");
		GetModel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetModel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetModel_InEdGraph_PropertyAddress, GetModel_FunctionAddress, "InEdGraph");
		GetModel_InEdGraph_Offset = NativeReflectionCached.GetPropertyOffset(GetModel_FunctionAddress, "InEdGraph");
		GetModel_InEdGraph_IsValid = NativeReflectionCached.ValidatePropertyClass(GetModel_FunctionAddress, "InEdGraph", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetModel_ReturnValue_PropertyAddress, GetModel_FunctionAddress, "ReturnValue");
		GetModel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetModel_FunctionAddress, "ReturnValue");
		GetModel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetModel_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetModel_IsValid = GetModel_FunctionAddress != IntPtr.Zero && GetModel_InEdGraph_IsValid && GetModel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigDeveloper.ControlRigBlueprint:GetModel", GetModel_IsValid);
		GetLocalFunctionLibrary_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLocalFunctionLibrary");
		GetLocalFunctionLibrary_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocalFunctionLibrary_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocalFunctionLibrary_ReturnValue_PropertyAddress, GetLocalFunctionLibrary_FunctionAddress, "ReturnValue");
		GetLocalFunctionLibrary_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalFunctionLibrary_FunctionAddress, "ReturnValue");
		GetLocalFunctionLibrary_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalFunctionLibrary_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetLocalFunctionLibrary_IsValid = GetLocalFunctionLibrary_FunctionAddress != IntPtr.Zero && GetLocalFunctionLibrary_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigDeveloper.ControlRigBlueprint:GetLocalFunctionLibrary", GetLocalFunctionLibrary_IsValid);
		GetHierarchyController_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetHierarchyController");
		GetHierarchyController_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHierarchyController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHierarchyController_ReturnValue_PropertyAddress, GetHierarchyController_FunctionAddress, "ReturnValue");
		GetHierarchyController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHierarchyController_FunctionAddress, "ReturnValue");
		GetHierarchyController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHierarchyController_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetHierarchyController_IsValid = GetHierarchyController_FunctionAddress != IntPtr.Zero && GetHierarchyController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigDeveloper.ControlRigBlueprint:GetHierarchyController", GetHierarchyController_IsValid);
		GetCurrentlyOpenRigBlueprints_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentlyOpenRigBlueprints");
		GetCurrentlyOpenRigBlueprints_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentlyOpenRigBlueprints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentlyOpenRigBlueprints_ReturnValue_PropertyAddress, GetCurrentlyOpenRigBlueprints_FunctionAddress, "ReturnValue");
		GetCurrentlyOpenRigBlueprints_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentlyOpenRigBlueprints_FunctionAddress, "ReturnValue");
		GetCurrentlyOpenRigBlueprints_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentlyOpenRigBlueprints_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetCurrentlyOpenRigBlueprints_IsValid = GetCurrentlyOpenRigBlueprints_FunctionAddress != IntPtr.Zero && GetCurrentlyOpenRigBlueprints_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigDeveloper.ControlRigBlueprint:GetCurrentlyOpenRigBlueprints", GetCurrentlyOpenRigBlueprints_IsValid);
		GetControlRigClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetControlRigClass");
		GetControlRigClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetControlRigClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetControlRigClass_ReturnValue_PropertyAddress, GetControlRigClass_FunctionAddress, "ReturnValue");
		GetControlRigClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetControlRigClass_FunctionAddress, "ReturnValue");
		GetControlRigClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlRigClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetControlRigClass_IsValid = GetControlRigClass_FunctionAddress != IntPtr.Zero && GetControlRigClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigDeveloper.ControlRigBlueprint:GetControlRigClass", GetControlRigClass_IsValid);
		GetControllerByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetControllerByName");
		GetControllerByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetControllerByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetControllerByName_InGraphName_PropertyAddress, GetControllerByName_FunctionAddress, "InGraphName");
		GetControllerByName_InGraphName_Offset = NativeReflectionCached.GetPropertyOffset(GetControllerByName_FunctionAddress, "InGraphName");
		GetControllerByName_InGraphName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControllerByName_FunctionAddress, "InGraphName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetControllerByName_ReturnValue_PropertyAddress, GetControllerByName_FunctionAddress, "ReturnValue");
		GetControllerByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetControllerByName_FunctionAddress, "ReturnValue");
		GetControllerByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControllerByName_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetControllerByName_IsValid = GetControllerByName_FunctionAddress != IntPtr.Zero && GetControllerByName_InGraphName_IsValid && GetControllerByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigDeveloper.ControlRigBlueprint:GetControllerByName", GetControllerByName_IsValid);
		GetController_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetController");
		GetController_ParamsSize = NativeReflection.GetFunctionParamsSize(GetController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetController_InGraph_PropertyAddress, GetController_FunctionAddress, "InGraph");
		GetController_InGraph_Offset = NativeReflectionCached.GetPropertyOffset(GetController_FunctionAddress, "InGraph");
		GetController_InGraph_IsValid = NativeReflectionCached.ValidatePropertyClass(GetController_FunctionAddress, "InGraph", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetController_ReturnValue_PropertyAddress, GetController_FunctionAddress, "ReturnValue");
		GetController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetController_FunctionAddress, "ReturnValue");
		GetController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetController_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetController_IsValid = GetController_FunctionAddress != IntPtr.Zero && GetController_InGraph_IsValid && GetController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigDeveloper.ControlRigBlueprint:GetController", GetController_IsValid);
		GetAvailableRigUnits_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAvailableRigUnits");
		GetAvailableRigUnits_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAvailableRigUnits_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAvailableRigUnits_ReturnValue_PropertyAddress, GetAvailableRigUnits_FunctionAddress, "ReturnValue");
		GetAvailableRigUnits_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAvailableRigUnits_FunctionAddress, "ReturnValue");
		GetAvailableRigUnits_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAvailableRigUnits_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAvailableRigUnits_IsValid = GetAvailableRigUnits_FunctionAddress != IntPtr.Zero && GetAvailableRigUnits_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigDeveloper.ControlRigBlueprint:GetAvailableRigUnits", GetAvailableRigUnits_IsValid);
		GetAllModels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllModels");
		GetAllModels_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllModels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllModels_ReturnValue_PropertyAddress, GetAllModels_FunctionAddress, "ReturnValue");
		GetAllModels_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllModels_FunctionAddress, "ReturnValue");
		GetAllModels_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllModels_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllModels_IsValid = GetAllModels_FunctionAddress != IntPtr.Zero && GetAllModels_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigDeveloper.ControlRigBlueprint:GetAllModels", GetAllModels_IsValid);
		GeneratePythonCommands_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GeneratePythonCommands");
		GeneratePythonCommands_ParamsSize = NativeReflection.GetFunctionParamsSize(GeneratePythonCommands_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GeneratePythonCommands_InNewBlueprintName_PropertyAddress, GeneratePythonCommands_FunctionAddress, "InNewBlueprintName");
		GeneratePythonCommands_InNewBlueprintName_Offset = NativeReflectionCached.GetPropertyOffset(GeneratePythonCommands_FunctionAddress, "InNewBlueprintName");
		GeneratePythonCommands_InNewBlueprintName_IsValid = NativeReflectionCached.ValidatePropertyClass(GeneratePythonCommands_FunctionAddress, "InNewBlueprintName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GeneratePythonCommands_ReturnValue_PropertyAddress, GeneratePythonCommands_FunctionAddress, "ReturnValue");
		GeneratePythonCommands_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GeneratePythonCommands_FunctionAddress, "ReturnValue");
		GeneratePythonCommands_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GeneratePythonCommands_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GeneratePythonCommands_IsValid = GeneratePythonCommands_FunctionAddress != IntPtr.Zero && GeneratePythonCommands_InNewBlueprintName_IsValid && GeneratePythonCommands_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigDeveloper.ControlRigBlueprint:GeneratePythonCommands", GeneratePythonCommands_IsValid);
		CreateControlRig_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateControlRig");
		CreateControlRig_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateControlRig_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateControlRig_ReturnValue_PropertyAddress, CreateControlRig_FunctionAddress, "ReturnValue");
		CreateControlRig_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateControlRig_FunctionAddress, "ReturnValue");
		CreateControlRig_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateControlRig_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateControlRig_IsValid = CreateControlRig_FunctionAddress != IntPtr.Zero && CreateControlRig_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigDeveloper.ControlRigBlueprint:CreateControlRig", CreateControlRig_IsValid);
		ChangeMemberVariableType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ChangeMemberVariableType");
		ChangeMemberVariableType_ParamsSize = NativeReflection.GetFunctionParamsSize(ChangeMemberVariableType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ChangeMemberVariableType_InName_PropertyAddress, ChangeMemberVariableType_FunctionAddress, "InName");
		ChangeMemberVariableType_InName_Offset = NativeReflectionCached.GetPropertyOffset(ChangeMemberVariableType_FunctionAddress, "InName");
		ChangeMemberVariableType_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeMemberVariableType_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ChangeMemberVariableType_InCPPType_PropertyAddress, ChangeMemberVariableType_FunctionAddress, "InCPPType");
		ChangeMemberVariableType_InCPPType_Offset = NativeReflectionCached.GetPropertyOffset(ChangeMemberVariableType_FunctionAddress, "InCPPType");
		ChangeMemberVariableType_InCPPType_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeMemberVariableType_FunctionAddress, "InCPPType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ChangeMemberVariableType_bIsPublic_PropertyAddress, ChangeMemberVariableType_FunctionAddress, "bIsPublic");
		ChangeMemberVariableType_bIsPublic_Offset = NativeReflectionCached.GetPropertyOffset(ChangeMemberVariableType_FunctionAddress, "bIsPublic");
		ChangeMemberVariableType_bIsPublic_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeMemberVariableType_FunctionAddress, "bIsPublic", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ChangeMemberVariableType_bIsReadOnly_PropertyAddress, ChangeMemberVariableType_FunctionAddress, "bIsReadOnly");
		ChangeMemberVariableType_bIsReadOnly_Offset = NativeReflectionCached.GetPropertyOffset(ChangeMemberVariableType_FunctionAddress, "bIsReadOnly");
		ChangeMemberVariableType_bIsReadOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeMemberVariableType_FunctionAddress, "bIsReadOnly", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ChangeMemberVariableType_InDefaultValue_PropertyAddress, ChangeMemberVariableType_FunctionAddress, "InDefaultValue");
		ChangeMemberVariableType_InDefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(ChangeMemberVariableType_FunctionAddress, "InDefaultValue");
		ChangeMemberVariableType_InDefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeMemberVariableType_FunctionAddress, "InDefaultValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ChangeMemberVariableType_ReturnValue_PropertyAddress, ChangeMemberVariableType_FunctionAddress, "ReturnValue");
		ChangeMemberVariableType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ChangeMemberVariableType_FunctionAddress, "ReturnValue");
		ChangeMemberVariableType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeMemberVariableType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ChangeMemberVariableType_IsValid = ChangeMemberVariableType_FunctionAddress != IntPtr.Zero && ChangeMemberVariableType_InName_IsValid && ChangeMemberVariableType_InCPPType_IsValid && ChangeMemberVariableType_bIsPublic_IsValid && ChangeMemberVariableType_bIsReadOnly_IsValid && ChangeMemberVariableType_InDefaultValue_IsValid && ChangeMemberVariableType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigDeveloper.ControlRigBlueprint:ChangeMemberVariableType", ChangeMemberVariableType_IsValid);
		AddMemberVariable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddMemberVariable");
		AddMemberVariable_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMemberVariable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMemberVariable_InName_PropertyAddress, AddMemberVariable_FunctionAddress, "InName");
		AddMemberVariable_InName_Offset = NativeReflectionCached.GetPropertyOffset(AddMemberVariable_FunctionAddress, "InName");
		AddMemberVariable_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMemberVariable_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMemberVariable_InCPPType_PropertyAddress, AddMemberVariable_FunctionAddress, "InCPPType");
		AddMemberVariable_InCPPType_Offset = NativeReflectionCached.GetPropertyOffset(AddMemberVariable_FunctionAddress, "InCPPType");
		AddMemberVariable_InCPPType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMemberVariable_FunctionAddress, "InCPPType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMemberVariable_bIsPublic_PropertyAddress, AddMemberVariable_FunctionAddress, "bIsPublic");
		AddMemberVariable_bIsPublic_Offset = NativeReflectionCached.GetPropertyOffset(AddMemberVariable_FunctionAddress, "bIsPublic");
		AddMemberVariable_bIsPublic_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMemberVariable_FunctionAddress, "bIsPublic", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMemberVariable_bIsReadOnly_PropertyAddress, AddMemberVariable_FunctionAddress, "bIsReadOnly");
		AddMemberVariable_bIsReadOnly_Offset = NativeReflectionCached.GetPropertyOffset(AddMemberVariable_FunctionAddress, "bIsReadOnly");
		AddMemberVariable_bIsReadOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMemberVariable_FunctionAddress, "bIsReadOnly", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMemberVariable_InDefaultValue_PropertyAddress, AddMemberVariable_FunctionAddress, "InDefaultValue");
		AddMemberVariable_InDefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(AddMemberVariable_FunctionAddress, "InDefaultValue");
		AddMemberVariable_InDefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMemberVariable_FunctionAddress, "InDefaultValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMemberVariable_ReturnValue_PropertyAddress, AddMemberVariable_FunctionAddress, "ReturnValue");
		AddMemberVariable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddMemberVariable_FunctionAddress, "ReturnValue");
		AddMemberVariable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMemberVariable_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		AddMemberVariable_IsValid = AddMemberVariable_FunctionAddress != IntPtr.Zero && AddMemberVariable_InName_IsValid && AddMemberVariable_InCPPType_IsValid && AddMemberVariable_bIsPublic_IsValid && AddMemberVariable_bIsReadOnly_IsValid && AddMemberVariable_InDefaultValue_IsValid && AddMemberVariable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigDeveloper.ControlRigBlueprint:AddMemberVariable", AddMemberVariable_IsValid);
	}
}
