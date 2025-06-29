using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigHierarchyController", "ControlRig", UnrealModuleType.EnginePlugin)]
public class URigHierarchyController : UObject
{
	private static bool SetSelection_IsValid;

	private static IntPtr SetSelection_FunctionAddress;

	private static int SetSelection_ParamsSize;

	private static bool SetSelection_InKeys_IsValid;

	private static FFieldAddress SetSelection_InKeys_PropertyAddress;

	private static int SetSelection_InKeys_Offset;

	private static bool SetSelection_bPrintPythonCommand_IsValid;

	private static FFieldAddress SetSelection_bPrintPythonCommand_PropertyAddress;

	private static int SetSelection_bPrintPythonCommand_Offset;

	private static bool SetSelection_ReturnValue_IsValid;

	private static FFieldAddress SetSelection_ReturnValue_PropertyAddress;

	private static int SetSelection_ReturnValue_Offset;

	private static bool SetParent_IsValid;

	private static IntPtr SetParent_FunctionAddress;

	private static int SetParent_ParamsSize;

	private static bool SetParent_InChild_IsValid;

	private static FFieldAddress SetParent_InChild_PropertyAddress;

	private static int SetParent_InChild_Offset;

	private static bool SetParent_InParent_IsValid;

	private static FFieldAddress SetParent_InParent_PropertyAddress;

	private static int SetParent_InParent_Offset;

	private static bool SetParent_bMaintainGlobalTransform_IsValid;

	private static FFieldAddress SetParent_bMaintainGlobalTransform_PropertyAddress;

	private static int SetParent_bMaintainGlobalTransform_Offset;

	private static bool SetParent_bSetupUndo_IsValid;

	private static FFieldAddress SetParent_bSetupUndo_PropertyAddress;

	private static int SetParent_bSetupUndo_Offset;

	private static bool SetParent_bPrintPythonCommand_IsValid;

	private static FFieldAddress SetParent_bPrintPythonCommand_PropertyAddress;

	private static int SetParent_bPrintPythonCommand_Offset;

	private static bool SetParent_ReturnValue_IsValid;

	private static FFieldAddress SetParent_ReturnValue_PropertyAddress;

	private static int SetParent_ReturnValue_Offset;

	private static bool SetHierarchy_IsValid;

	private static IntPtr SetHierarchy_FunctionAddress;

	private static int SetHierarchy_ParamsSize;

	private static bool SetHierarchy_InHierarchy_IsValid;

	private static FFieldAddress SetHierarchy_InHierarchy_PropertyAddress;

	private static int SetHierarchy_InHierarchy_Offset;

	private static bool SetControlSettings_IsValid;

	private static IntPtr SetControlSettings_FunctionAddress;

	private static int SetControlSettings_ParamsSize;

	private static bool SetControlSettings_InKey_IsValid;

	private static FFieldAddress SetControlSettings_InKey_PropertyAddress;

	private static int SetControlSettings_InKey_Offset;

	private static bool SetControlSettings_InSettings_IsValid;

	private static FFieldAddress SetControlSettings_InSettings_PropertyAddress;

	private static int SetControlSettings_InSettings_Offset;

	private static bool SetControlSettings_bSetupUndo_IsValid;

	private static FFieldAddress SetControlSettings_bSetupUndo_PropertyAddress;

	private static int SetControlSettings_bSetupUndo_Offset;

	private static bool SetControlSettings_ReturnValue_IsValid;

	private static FFieldAddress SetControlSettings_ReturnValue_PropertyAddress;

	private static int SetControlSettings_ReturnValue_Offset;

	private static bool SelectElement_IsValid;

	private static IntPtr SelectElement_FunctionAddress;

	private static int SelectElement_ParamsSize;

	private static bool SelectElement_InKey_IsValid;

	private static FFieldAddress SelectElement_InKey_PropertyAddress;

	private static int SelectElement_InKey_Offset;

	private static bool SelectElement_bSelect_IsValid;

	private static FFieldAddress SelectElement_bSelect_PropertyAddress;

	private static int SelectElement_bSelect_Offset;

	private static bool SelectElement_bClearSelection_IsValid;

	private static FFieldAddress SelectElement_bClearSelection_PropertyAddress;

	private static int SelectElement_bClearSelection_Offset;

	private static bool SelectElement_ReturnValue_IsValid;

	private static FFieldAddress SelectElement_ReturnValue_PropertyAddress;

	private static int SelectElement_ReturnValue_Offset;

	private static bool RenameElement_IsValid;

	private static IntPtr RenameElement_FunctionAddress;

	private static int RenameElement_ParamsSize;

	private static bool RenameElement_InElement_IsValid;

	private static FFieldAddress RenameElement_InElement_PropertyAddress;

	private static int RenameElement_InElement_Offset;

	private static bool RenameElement_InName_IsValid;

	private static FFieldAddress RenameElement_InName_PropertyAddress;

	private static int RenameElement_InName_Offset;

	private static bool RenameElement_bSetupUndo_IsValid;

	private static FFieldAddress RenameElement_bSetupUndo_PropertyAddress;

	private static int RenameElement_bSetupUndo_Offset;

	private static bool RenameElement_bPrintPythonCommand_IsValid;

	private static FFieldAddress RenameElement_bPrintPythonCommand_PropertyAddress;

	private static int RenameElement_bPrintPythonCommand_Offset;

	private static bool RenameElement_bClearSelection_IsValid;

	private static FFieldAddress RenameElement_bClearSelection_PropertyAddress;

	private static int RenameElement_bClearSelection_Offset;

	private static bool RenameElement_ReturnValue_IsValid;

	private static FFieldAddress RenameElement_ReturnValue_PropertyAddress;

	private static int RenameElement_ReturnValue_Offset;

	private static bool RemoveParent_IsValid;

	private static IntPtr RemoveParent_FunctionAddress;

	private static int RemoveParent_ParamsSize;

	private static bool RemoveParent_InChild_IsValid;

	private static FFieldAddress RemoveParent_InChild_PropertyAddress;

	private static int RemoveParent_InChild_Offset;

	private static bool RemoveParent_InParent_IsValid;

	private static FFieldAddress RemoveParent_InParent_PropertyAddress;

	private static int RemoveParent_InParent_Offset;

	private static bool RemoveParent_bMaintainGlobalTransform_IsValid;

	private static FFieldAddress RemoveParent_bMaintainGlobalTransform_PropertyAddress;

	private static int RemoveParent_bMaintainGlobalTransform_Offset;

	private static bool RemoveParent_bSetupUndo_IsValid;

	private static FFieldAddress RemoveParent_bSetupUndo_PropertyAddress;

	private static int RemoveParent_bSetupUndo_Offset;

	private static bool RemoveParent_bPrintPythonCommand_IsValid;

	private static FFieldAddress RemoveParent_bPrintPythonCommand_PropertyAddress;

	private static int RemoveParent_bPrintPythonCommand_Offset;

	private static bool RemoveParent_ReturnValue_IsValid;

	private static FFieldAddress RemoveParent_ReturnValue_PropertyAddress;

	private static int RemoveParent_ReturnValue_Offset;

	private static bool RemoveElement_IsValid;

	private static IntPtr RemoveElement_FunctionAddress;

	private static int RemoveElement_ParamsSize;

	private static bool RemoveElement_InElement_IsValid;

	private static FFieldAddress RemoveElement_InElement_PropertyAddress;

	private static int RemoveElement_InElement_Offset;

	private static bool RemoveElement_bSetupUndo_IsValid;

	private static FFieldAddress RemoveElement_bSetupUndo_PropertyAddress;

	private static int RemoveElement_bSetupUndo_Offset;

	private static bool RemoveElement_bPrintPythonCommand_IsValid;

	private static FFieldAddress RemoveElement_bPrintPythonCommand_PropertyAddress;

	private static int RemoveElement_bPrintPythonCommand_Offset;

	private static bool RemoveElement_ReturnValue_IsValid;

	private static FFieldAddress RemoveElement_ReturnValue_PropertyAddress;

	private static int RemoveElement_ReturnValue_Offset;

	private static bool RemoveAllParents_IsValid;

	private static IntPtr RemoveAllParents_FunctionAddress;

	private static int RemoveAllParents_ParamsSize;

	private static bool RemoveAllParents_InChild_IsValid;

	private static FFieldAddress RemoveAllParents_InChild_PropertyAddress;

	private static int RemoveAllParents_InChild_Offset;

	private static bool RemoveAllParents_bMaintainGlobalTransform_IsValid;

	private static FFieldAddress RemoveAllParents_bMaintainGlobalTransform_PropertyAddress;

	private static int RemoveAllParents_bMaintainGlobalTransform_Offset;

	private static bool RemoveAllParents_bSetupUndo_IsValid;

	private static FFieldAddress RemoveAllParents_bSetupUndo_PropertyAddress;

	private static int RemoveAllParents_bSetupUndo_Offset;

	private static bool RemoveAllParents_bPrintPythonCommand_IsValid;

	private static FFieldAddress RemoveAllParents_bPrintPythonCommand_PropertyAddress;

	private static int RemoveAllParents_bPrintPythonCommand_Offset;

	private static bool RemoveAllParents_ReturnValue_IsValid;

	private static FFieldAddress RemoveAllParents_ReturnValue_PropertyAddress;

	private static int RemoveAllParents_ReturnValue_Offset;

	private static bool MirrorElements_IsValid;

	private static IntPtr MirrorElements_FunctionAddress;

	private static int MirrorElements_ParamsSize;

	private static bool MirrorElements_InKeys_IsValid;

	private static FFieldAddress MirrorElements_InKeys_PropertyAddress;

	private static int MirrorElements_InKeys_Offset;

	private static bool MirrorElements_InSettings_IsValid;

	private static FFieldAddress MirrorElements_InSettings_PropertyAddress;

	private static int MirrorElements_InSettings_Offset;

	private static bool MirrorElements_bSelectNewElements_IsValid;

	private static FFieldAddress MirrorElements_bSelectNewElements_PropertyAddress;

	private static int MirrorElements_bSelectNewElements_Offset;

	private static bool MirrorElements_bSetupUndo_IsValid;

	private static FFieldAddress MirrorElements_bSetupUndo_PropertyAddress;

	private static int MirrorElements_bSetupUndo_Offset;

	private static bool MirrorElements_bPrintPythonCommands_IsValid;

	private static FFieldAddress MirrorElements_bPrintPythonCommands_PropertyAddress;

	private static int MirrorElements_bPrintPythonCommands_Offset;

	private static bool MirrorElements_ReturnValue_IsValid;

	private static FFieldAddress MirrorElements_ReturnValue_PropertyAddress;

	private static int MirrorElements_ReturnValue_Offset;

	private static bool ImportFromText_IsValid;

	private static IntPtr ImportFromText_FunctionAddress;

	private static int ImportFromText_ParamsSize;

	private static bool ImportFromText_InContent_IsValid;

	private static FFieldAddress ImportFromText_InContent_PropertyAddress;

	private static int ImportFromText_InContent_Offset;

	private static bool ImportFromText_bReplaceExistingElements_IsValid;

	private static FFieldAddress ImportFromText_bReplaceExistingElements_PropertyAddress;

	private static int ImportFromText_bReplaceExistingElements_Offset;

	private static bool ImportFromText_bSelectNewElements_IsValid;

	private static FFieldAddress ImportFromText_bSelectNewElements_PropertyAddress;

	private static int ImportFromText_bSelectNewElements_Offset;

	private static bool ImportFromText_bSetupUndo_IsValid;

	private static FFieldAddress ImportFromText_bSetupUndo_PropertyAddress;

	private static int ImportFromText_bSetupUndo_Offset;

	private static bool ImportFromText_bPrintPythonCommands_IsValid;

	private static FFieldAddress ImportFromText_bPrintPythonCommands_PropertyAddress;

	private static int ImportFromText_bPrintPythonCommands_Offset;

	private static bool ImportFromText_ReturnValue_IsValid;

	private static FFieldAddress ImportFromText_ReturnValue_PropertyAddress;

	private static int ImportFromText_ReturnValue_Offset;

	private static bool ImportCurvesFromAsset_IsValid;

	private static IntPtr ImportCurvesFromAsset_FunctionAddress;

	private static int ImportCurvesFromAsset_ParamsSize;

	private static bool ImportCurvesFromAsset_InAssetPath_IsValid;

	private static FFieldAddress ImportCurvesFromAsset_InAssetPath_PropertyAddress;

	private static int ImportCurvesFromAsset_InAssetPath_Offset;

	private static bool ImportCurvesFromAsset_InNameSpace_IsValid;

	private static FFieldAddress ImportCurvesFromAsset_InNameSpace_PropertyAddress;

	private static int ImportCurvesFromAsset_InNameSpace_Offset;

	private static bool ImportCurvesFromAsset_bSelectCurves_IsValid;

	private static FFieldAddress ImportCurvesFromAsset_bSelectCurves_PropertyAddress;

	private static int ImportCurvesFromAsset_bSelectCurves_Offset;

	private static bool ImportCurvesFromAsset_bSetupUndo_IsValid;

	private static FFieldAddress ImportCurvesFromAsset_bSetupUndo_PropertyAddress;

	private static int ImportCurvesFromAsset_bSetupUndo_Offset;

	private static bool ImportCurvesFromAsset_ReturnValue_IsValid;

	private static FFieldAddress ImportCurvesFromAsset_ReturnValue_PropertyAddress;

	private static int ImportCurvesFromAsset_ReturnValue_Offset;

	private static bool ImportCurves_IsValid;

	private static IntPtr ImportCurves_FunctionAddress;

	private static int ImportCurves_ParamsSize;

	private static bool ImportCurves_InSkeleton_IsValid;

	private static FFieldAddress ImportCurves_InSkeleton_PropertyAddress;

	private static int ImportCurves_InSkeleton_Offset;

	private static bool ImportCurves_InNameSpace_IsValid;

	private static FFieldAddress ImportCurves_InNameSpace_PropertyAddress;

	private static int ImportCurves_InNameSpace_Offset;

	private static bool ImportCurves_bSelectCurves_IsValid;

	private static FFieldAddress ImportCurves_bSelectCurves_PropertyAddress;

	private static int ImportCurves_bSelectCurves_Offset;

	private static bool ImportCurves_bSetupUndo_IsValid;

	private static FFieldAddress ImportCurves_bSetupUndo_PropertyAddress;

	private static int ImportCurves_bSetupUndo_Offset;

	private static bool ImportCurves_bPrintPythonCommand_IsValid;

	private static FFieldAddress ImportCurves_bPrintPythonCommand_PropertyAddress;

	private static int ImportCurves_bPrintPythonCommand_Offset;

	private static bool ImportCurves_ReturnValue_IsValid;

	private static FFieldAddress ImportCurves_ReturnValue_PropertyAddress;

	private static int ImportCurves_ReturnValue_Offset;

	private static bool ImportBonesFromAsset_IsValid;

	private static IntPtr ImportBonesFromAsset_FunctionAddress;

	private static int ImportBonesFromAsset_ParamsSize;

	private static bool ImportBonesFromAsset_InAssetPath_IsValid;

	private static FFieldAddress ImportBonesFromAsset_InAssetPath_PropertyAddress;

	private static int ImportBonesFromAsset_InAssetPath_Offset;

	private static bool ImportBonesFromAsset_InNameSpace_IsValid;

	private static FFieldAddress ImportBonesFromAsset_InNameSpace_PropertyAddress;

	private static int ImportBonesFromAsset_InNameSpace_Offset;

	private static bool ImportBonesFromAsset_bReplaceExistingBones_IsValid;

	private static FFieldAddress ImportBonesFromAsset_bReplaceExistingBones_PropertyAddress;

	private static int ImportBonesFromAsset_bReplaceExistingBones_Offset;

	private static bool ImportBonesFromAsset_bRemoveObsoleteBones_IsValid;

	private static FFieldAddress ImportBonesFromAsset_bRemoveObsoleteBones_PropertyAddress;

	private static int ImportBonesFromAsset_bRemoveObsoleteBones_Offset;

	private static bool ImportBonesFromAsset_bSelectBones_IsValid;

	private static FFieldAddress ImportBonesFromAsset_bSelectBones_PropertyAddress;

	private static int ImportBonesFromAsset_bSelectBones_Offset;

	private static bool ImportBonesFromAsset_bSetupUndo_IsValid;

	private static FFieldAddress ImportBonesFromAsset_bSetupUndo_PropertyAddress;

	private static int ImportBonesFromAsset_bSetupUndo_Offset;

	private static bool ImportBonesFromAsset_ReturnValue_IsValid;

	private static FFieldAddress ImportBonesFromAsset_ReturnValue_PropertyAddress;

	private static int ImportBonesFromAsset_ReturnValue_Offset;

	private static bool ImportBones_IsValid;

	private static IntPtr ImportBones_FunctionAddress;

	private static int ImportBones_ParamsSize;

	private static bool ImportBones_InSkeleton_IsValid;

	private static FFieldAddress ImportBones_InSkeleton_PropertyAddress;

	private static int ImportBones_InSkeleton_Offset;

	private static bool ImportBones_InNameSpace_IsValid;

	private static FFieldAddress ImportBones_InNameSpace_PropertyAddress;

	private static int ImportBones_InNameSpace_Offset;

	private static bool ImportBones_bReplaceExistingBones_IsValid;

	private static FFieldAddress ImportBones_bReplaceExistingBones_PropertyAddress;

	private static int ImportBones_bReplaceExistingBones_Offset;

	private static bool ImportBones_bRemoveObsoleteBones_IsValid;

	private static FFieldAddress ImportBones_bRemoveObsoleteBones_PropertyAddress;

	private static int ImportBones_bRemoveObsoleteBones_Offset;

	private static bool ImportBones_bSelectBones_IsValid;

	private static FFieldAddress ImportBones_bSelectBones_PropertyAddress;

	private static int ImportBones_bSelectBones_Offset;

	private static bool ImportBones_bSetupUndo_IsValid;

	private static FFieldAddress ImportBones_bSetupUndo_PropertyAddress;

	private static int ImportBones_bSetupUndo_Offset;

	private static bool ImportBones_bPrintPythonCommand_IsValid;

	private static FFieldAddress ImportBones_bPrintPythonCommand_PropertyAddress;

	private static int ImportBones_bPrintPythonCommand_Offset;

	private static bool ImportBones_ReturnValue_IsValid;

	private static FFieldAddress ImportBones_ReturnValue_PropertyAddress;

	private static int ImportBones_ReturnValue_Offset;

	private static bool GetHierarchy_IsValid;

	private static IntPtr GetHierarchy_FunctionAddress;

	private static int GetHierarchy_ParamsSize;

	private static bool GetHierarchy_ReturnValue_IsValid;

	private static FFieldAddress GetHierarchy_ReturnValue_PropertyAddress;

	private static int GetHierarchy_ReturnValue_Offset;

	private static bool GetControlSettings_IsValid;

	private static IntPtr GetControlSettings_FunctionAddress;

	private static int GetControlSettings_ParamsSize;

	private static bool GetControlSettings_InKey_IsValid;

	private static FFieldAddress GetControlSettings_InKey_PropertyAddress;

	private static int GetControlSettings_InKey_Offset;

	private static bool GetControlSettings_ReturnValue_IsValid;

	private static FFieldAddress GetControlSettings_ReturnValue_PropertyAddress;

	private static int GetControlSettings_ReturnValue_Offset;

	private static bool GeneratePythonCommands_IsValid;

	private static IntPtr GeneratePythonCommands_FunctionAddress;

	private static int GeneratePythonCommands_ParamsSize;

	private static bool GeneratePythonCommands_ReturnValue_IsValid;

	private static FFieldAddress GeneratePythonCommands_ReturnValue_PropertyAddress;

	private static int GeneratePythonCommands_ReturnValue_Offset;

	private static bool ExportToText_IsValid;

	private static IntPtr ExportToText_FunctionAddress;

	private static int ExportToText_ParamsSize;

	private static bool ExportToText_InKeys_IsValid;

	private static FFieldAddress ExportToText_InKeys_PropertyAddress;

	private static int ExportToText_InKeys_Offset;

	private static bool ExportToText_ReturnValue_IsValid;

	private static FFieldAddress ExportToText_ReturnValue_PropertyAddress;

	private static int ExportToText_ReturnValue_Offset;

	private static bool ExportSelectionToText_IsValid;

	private static IntPtr ExportSelectionToText_FunctionAddress;

	private static int ExportSelectionToText_ParamsSize;

	private static bool ExportSelectionToText_ReturnValue_IsValid;

	private static FFieldAddress ExportSelectionToText_ReturnValue_PropertyAddress;

	private static int ExportSelectionToText_ReturnValue_Offset;

	private static bool DuplicateElements_IsValid;

	private static IntPtr DuplicateElements_FunctionAddress;

	private static int DuplicateElements_ParamsSize;

	private static bool DuplicateElements_InKeys_IsValid;

	private static FFieldAddress DuplicateElements_InKeys_PropertyAddress;

	private static int DuplicateElements_InKeys_Offset;

	private static bool DuplicateElements_bSelectNewElements_IsValid;

	private static FFieldAddress DuplicateElements_bSelectNewElements_PropertyAddress;

	private static int DuplicateElements_bSelectNewElements_Offset;

	private static bool DuplicateElements_bSetupUndo_IsValid;

	private static FFieldAddress DuplicateElements_bSetupUndo_PropertyAddress;

	private static int DuplicateElements_bSetupUndo_Offset;

	private static bool DuplicateElements_bPrintPythonCommands_IsValid;

	private static FFieldAddress DuplicateElements_bPrintPythonCommands_PropertyAddress;

	private static int DuplicateElements_bPrintPythonCommands_Offset;

	private static bool DuplicateElements_ReturnValue_IsValid;

	private static FFieldAddress DuplicateElements_ReturnValue_PropertyAddress;

	private static int DuplicateElements_ReturnValue_Offset;

	private static bool DeselectElement_IsValid;

	private static IntPtr DeselectElement_FunctionAddress;

	private static int DeselectElement_ParamsSize;

	private static bool DeselectElement_InKey_IsValid;

	private static FFieldAddress DeselectElement_InKey_PropertyAddress;

	private static int DeselectElement_InKey_Offset;

	private static bool DeselectElement_ReturnValue_IsValid;

	private static FFieldAddress DeselectElement_ReturnValue_PropertyAddress;

	private static int DeselectElement_ReturnValue_Offset;

	private static bool ClearSelection_IsValid;

	private static IntPtr ClearSelection_FunctionAddress;

	private static int ClearSelection_ParamsSize;

	private static bool ClearSelection_ReturnValue_IsValid;

	private static FFieldAddress ClearSelection_ReturnValue_PropertyAddress;

	private static int ClearSelection_ReturnValue_Offset;

	private static bool AddRigidBody_IsValid;

	private static IntPtr AddRigidBody_FunctionAddress;

	private static int AddRigidBody_ParamsSize;

	private static bool AddRigidBody_InName_IsValid;

	private static FFieldAddress AddRigidBody_InName_PropertyAddress;

	private static int AddRigidBody_InName_Offset;

	private static bool AddRigidBody_InParent_IsValid;

	private static FFieldAddress AddRigidBody_InParent_PropertyAddress;

	private static int AddRigidBody_InParent_Offset;

	private static bool AddRigidBody_InSettings_IsValid;

	private static FFieldAddress AddRigidBody_InSettings_PropertyAddress;

	private static int AddRigidBody_InSettings_Offset;

	private static bool AddRigidBody_InLocalTransform_IsValid;

	private static FFieldAddress AddRigidBody_InLocalTransform_PropertyAddress;

	private static int AddRigidBody_InLocalTransform_Offset;

	private static bool AddRigidBody_bSetupUndo_IsValid;

	private static FFieldAddress AddRigidBody_bSetupUndo_PropertyAddress;

	private static int AddRigidBody_bSetupUndo_Offset;

	private static bool AddRigidBody_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddRigidBody_bPrintPythonCommand_PropertyAddress;

	private static int AddRigidBody_bPrintPythonCommand_Offset;

	private static bool AddRigidBody_ReturnValue_IsValid;

	private static FFieldAddress AddRigidBody_ReturnValue_PropertyAddress;

	private static int AddRigidBody_ReturnValue_Offset;

	private static bool AddParent_IsValid;

	private static IntPtr AddParent_FunctionAddress;

	private static int AddParent_ParamsSize;

	private static bool AddParent_InChild_IsValid;

	private static FFieldAddress AddParent_InChild_PropertyAddress;

	private static int AddParent_InChild_Offset;

	private static bool AddParent_InParent_IsValid;

	private static FFieldAddress AddParent_InParent_PropertyAddress;

	private static int AddParent_InParent_Offset;

	private static bool AddParent_InWeight_IsValid;

	private static FFieldAddress AddParent_InWeight_PropertyAddress;

	private static int AddParent_InWeight_Offset;

	private static bool AddParent_bMaintainGlobalTransform_IsValid;

	private static FFieldAddress AddParent_bMaintainGlobalTransform_PropertyAddress;

	private static int AddParent_bMaintainGlobalTransform_Offset;

	private static bool AddParent_bSetupUndo_IsValid;

	private static FFieldAddress AddParent_bSetupUndo_PropertyAddress;

	private static int AddParent_bSetupUndo_Offset;

	private static bool AddParent_ReturnValue_IsValid;

	private static FFieldAddress AddParent_ReturnValue_PropertyAddress;

	private static int AddParent_ReturnValue_Offset;

	private static bool AddNull_IsValid;

	private static IntPtr AddNull_FunctionAddress;

	private static int AddNull_ParamsSize;

	private static bool AddNull_InName_IsValid;

	private static FFieldAddress AddNull_InName_PropertyAddress;

	private static int AddNull_InName_Offset;

	private static bool AddNull_InParent_IsValid;

	private static FFieldAddress AddNull_InParent_PropertyAddress;

	private static int AddNull_InParent_Offset;

	private static bool AddNull_InTransform_IsValid;

	private static FFieldAddress AddNull_InTransform_PropertyAddress;

	private static int AddNull_InTransform_Offset;

	private static bool AddNull_bTransformInGlobal_IsValid;

	private static FFieldAddress AddNull_bTransformInGlobal_PropertyAddress;

	private static int AddNull_bTransformInGlobal_Offset;

	private static bool AddNull_bSetupUndo_IsValid;

	private static FFieldAddress AddNull_bSetupUndo_PropertyAddress;

	private static int AddNull_bSetupUndo_Offset;

	private static bool AddNull_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddNull_bPrintPythonCommand_PropertyAddress;

	private static int AddNull_bPrintPythonCommand_Offset;

	private static bool AddNull_ReturnValue_IsValid;

	private static FFieldAddress AddNull_ReturnValue_PropertyAddress;

	private static int AddNull_ReturnValue_Offset;

	private static bool AddCurve_IsValid;

	private static IntPtr AddCurve_FunctionAddress;

	private static int AddCurve_ParamsSize;

	private static bool AddCurve_InName_IsValid;

	private static FFieldAddress AddCurve_InName_PropertyAddress;

	private static int AddCurve_InName_Offset;

	private static bool AddCurve_InValue_IsValid;

	private static FFieldAddress AddCurve_InValue_PropertyAddress;

	private static int AddCurve_InValue_Offset;

	private static bool AddCurve_bSetupUndo_IsValid;

	private static FFieldAddress AddCurve_bSetupUndo_PropertyAddress;

	private static int AddCurve_bSetupUndo_Offset;

	private static bool AddCurve_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddCurve_bPrintPythonCommand_PropertyAddress;

	private static int AddCurve_bPrintPythonCommand_Offset;

	private static bool AddCurve_ReturnValue_IsValid;

	private static FFieldAddress AddCurve_ReturnValue_PropertyAddress;

	private static int AddCurve_ReturnValue_Offset;

	private static bool AddControl_IsValid;

	private static IntPtr AddControl_FunctionAddress;

	private static int AddControl_ParamsSize;

	private static bool AddControl_InName_IsValid;

	private static FFieldAddress AddControl_InName_PropertyAddress;

	private static int AddControl_InName_Offset;

	private static bool AddControl_InParent_IsValid;

	private static FFieldAddress AddControl_InParent_PropertyAddress;

	private static int AddControl_InParent_Offset;

	private static bool AddControl_InSettings_IsValid;

	private static FFieldAddress AddControl_InSettings_PropertyAddress;

	private static int AddControl_InSettings_Offset;

	private static bool AddControl_InValue_IsValid;

	private static FFieldAddress AddControl_InValue_PropertyAddress;

	private static int AddControl_InValue_Offset;

	private static bool AddControl_bSetupUndo_IsValid;

	private static FFieldAddress AddControl_bSetupUndo_PropertyAddress;

	private static int AddControl_bSetupUndo_Offset;

	private static bool AddControl_ReturnValue_IsValid;

	private static FFieldAddress AddControl_ReturnValue_PropertyAddress;

	private static int AddControl_ReturnValue_Offset;

	private static bool AddBone_IsValid;

	private static IntPtr AddBone_FunctionAddress;

	private static int AddBone_ParamsSize;

	private static bool AddBone_InName_IsValid;

	private static FFieldAddress AddBone_InName_PropertyAddress;

	private static int AddBone_InName_Offset;

	private static bool AddBone_InParent_IsValid;

	private static FFieldAddress AddBone_InParent_PropertyAddress;

	private static int AddBone_InParent_Offset;

	private static bool AddBone_InTransform_IsValid;

	private static FFieldAddress AddBone_InTransform_PropertyAddress;

	private static int AddBone_InTransform_Offset;

	private static bool AddBone_bTransformInGlobal_IsValid;

	private static FFieldAddress AddBone_bTransformInGlobal_PropertyAddress;

	private static int AddBone_bTransformInGlobal_Offset;

	private static bool AddBone_InBoneType_IsValid;

	private static FFieldAddress AddBone_InBoneType_PropertyAddress;

	private static int AddBone_InBoneType_Offset;

	private static bool AddBone_bSetupUndo_IsValid;

	private static FFieldAddress AddBone_bSetupUndo_PropertyAddress;

	private static int AddBone_bSetupUndo_Offset;

	private static bool AddBone_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddBone_bPrintPythonCommand_PropertyAddress;

	private static int AddBone_bPrintPythonCommand_Offset;

	private static bool AddBone_ReturnValue_IsValid;

	private static FFieldAddress AddBone_ReturnValue_PropertyAddress;

	private static int AddBone_ReturnValue_Offset;

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:SetSelection")]
	public unsafe bool SetSelection(List<FRigElementKey> InKeys, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!SetSelection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:SetSelection");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSelection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSelection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FRigElementKey>(1, SetSelection_InKeys_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).ToNative(IntPtr.Add(intPtr, SetSelection_InKeys_Offset), InKeys);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSelection_bPrintPythonCommand_Offset), 0, SetSelection_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSelection_FunctionAddress, intPtr, SetSelection_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSelection_InKeys_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetSelection_ReturnValue_Offset), 0, SetSelection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:SetParent")]
	public unsafe bool SetParent(FRigElementKey InChild, FRigElementKey InParent, bool bMaintainGlobalTransform = true, bool bSetupUndo = false, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!SetParent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:SetParent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetParent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetParent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetParent_InChild_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, SetParent_InChild_Offset), 0, SetParent_InChild_PropertyAddress.Address, InChild);
		NativeReflection.InitializeValue_InContainer(SetParent_InParent_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, SetParent_InParent_Offset), 0, SetParent_InParent_PropertyAddress.Address, InParent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetParent_bMaintainGlobalTransform_Offset), 0, SetParent_bMaintainGlobalTransform_PropertyAddress.Address, bMaintainGlobalTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetParent_bSetupUndo_Offset), 0, SetParent_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetParent_bPrintPythonCommand_Offset), 0, SetParent_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetParent_FunctionAddress, intPtr, SetParent_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetParent_ReturnValue_Offset), 0, SetParent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:SetHierarchy")]
	public unsafe void SetHierarchy(URigHierarchy InHierarchy)
	{
		CheckDestroyed();
		if (!SetHierarchy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:SetHierarchy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHierarchy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHierarchy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigHierarchy>.ToNative(IntPtr.Add(intPtr, SetHierarchy_InHierarchy_Offset), 0, SetHierarchy_InHierarchy_PropertyAddress.Address, InHierarchy);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHierarchy_FunctionAddress, intPtr, SetHierarchy_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:SetControlSettings")]
	public unsafe bool SetControlSettings(FRigElementKey InKey, FRigControlSettings InSettings, bool bSetupUndo = false)
	{
		CheckDestroyed();
		if (!SetControlSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:SetControlSettings");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetControlSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetControlSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetControlSettings_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, SetControlSettings_InKey_Offset), 0, SetControlSettings_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InitializeValue_InContainer(SetControlSettings_InSettings_PropertyAddress.Address, intPtr);
		FRigControlSettings.ToNative(IntPtr.Add(intPtr, SetControlSettings_InSettings_Offset), 0, SetControlSettings_InSettings_PropertyAddress.Address, InSettings);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlSettings_bSetupUndo_Offset), 0, SetControlSettings_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetControlSettings_FunctionAddress, intPtr, SetControlSettings_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetControlSettings_InSettings_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetControlSettings_ReturnValue_Offset), 0, SetControlSettings_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:SelectElement")]
	public unsafe bool SelectElement(FRigElementKey InKey, bool bSelect = true, bool bClearSelection = false)
	{
		CheckDestroyed();
		if (!SelectElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:SelectElement");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectElement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectElement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SelectElement_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, SelectElement_InKey_Offset), 0, SelectElement_InKey_PropertyAddress.Address, InKey);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectElement_bSelect_Offset), 0, SelectElement_bSelect_PropertyAddress.Address, bSelect);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectElement_bClearSelection_Offset), 0, SelectElement_bClearSelection_PropertyAddress.Address, bClearSelection);
		NativeReflection.InvokeFunctionOptimized(base.Address, SelectElement_FunctionAddress, intPtr, SelectElement_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SelectElement_ReturnValue_Offset), 0, SelectElement_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:RenameElement")]
	public unsafe FRigElementKey RenameElement(FRigElementKey InElement, FName InName, bool bSetupUndo = false, bool bPrintPythonCommand = false, bool bClearSelection = true)
	{
		CheckDestroyed();
		if (!RenameElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:RenameElement");
			return default(FRigElementKey);
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenameElement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenameElement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RenameElement_InElement_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, RenameElement_InElement_Offset), 0, RenameElement_InElement_PropertyAddress.Address, InElement);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RenameElement_InName_Offset), 0, RenameElement_InName_PropertyAddress.Address, InName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RenameElement_bSetupUndo_Offset), 0, RenameElement_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RenameElement_bPrintPythonCommand_Offset), 0, RenameElement_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RenameElement_bClearSelection_Offset), 0, RenameElement_bClearSelection_PropertyAddress.Address, bClearSelection);
		NativeReflection.InvokeFunctionOptimized(base.Address, RenameElement_FunctionAddress, intPtr, RenameElement_ParamsSize);
		return FRigElementKey.FromNative(IntPtr.Add(intPtr, RenameElement_ReturnValue_Offset), 0, RenameElement_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:RemoveParent")]
	public unsafe bool RemoveParent(FRigElementKey InChild, FRigElementKey InParent, bool bMaintainGlobalTransform = true, bool bSetupUndo = false, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!RemoveParent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:RemoveParent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveParent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveParent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemoveParent_InChild_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, RemoveParent_InChild_Offset), 0, RemoveParent_InChild_PropertyAddress.Address, InChild);
		NativeReflection.InitializeValue_InContainer(RemoveParent_InParent_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, RemoveParent_InParent_Offset), 0, RemoveParent_InParent_PropertyAddress.Address, InParent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveParent_bMaintainGlobalTransform_Offset), 0, RemoveParent_bMaintainGlobalTransform_PropertyAddress.Address, bMaintainGlobalTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveParent_bSetupUndo_Offset), 0, RemoveParent_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveParent_bPrintPythonCommand_Offset), 0, RemoveParent_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveParent_FunctionAddress, intPtr, RemoveParent_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveParent_ReturnValue_Offset), 0, RemoveParent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:RemoveElement")]
	public unsafe bool RemoveElement(FRigElementKey InElement, bool bSetupUndo = false, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!RemoveElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:RemoveElement");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveElement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveElement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemoveElement_InElement_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, RemoveElement_InElement_Offset), 0, RemoveElement_InElement_PropertyAddress.Address, InElement);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveElement_bSetupUndo_Offset), 0, RemoveElement_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveElement_bPrintPythonCommand_Offset), 0, RemoveElement_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveElement_FunctionAddress, intPtr, RemoveElement_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveElement_ReturnValue_Offset), 0, RemoveElement_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:RemoveAllParents")]
	public unsafe bool RemoveAllParents(FRigElementKey InChild, bool bMaintainGlobalTransform = true, bool bSetupUndo = false, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!RemoveAllParents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:RemoveAllParents");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllParents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllParents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemoveAllParents_InChild_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, RemoveAllParents_InChild_Offset), 0, RemoveAllParents_InChild_PropertyAddress.Address, InChild);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveAllParents_bMaintainGlobalTransform_Offset), 0, RemoveAllParents_bMaintainGlobalTransform_PropertyAddress.Address, bMaintainGlobalTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveAllParents_bSetupUndo_Offset), 0, RemoveAllParents_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveAllParents_bPrintPythonCommand_Offset), 0, RemoveAllParents_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveAllParents_FunctionAddress, intPtr, RemoveAllParents_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveAllParents_ReturnValue_Offset), 0, RemoveAllParents_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:MirrorElements")]
	public unsafe List<FRigElementKey> MirrorElements(List<FRigElementKey> InKeys, FRigMirrorSettings InSettings, bool bSelectNewElements = true, bool bSetupUndo = false, bool bPrintPythonCommands = false)
	{
		CheckDestroyed();
		if (!MirrorElements_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:MirrorElements");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MirrorElements_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MirrorElements_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FRigElementKey>(1, MirrorElements_InKeys_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).ToNative(IntPtr.Add(intPtr, MirrorElements_InKeys_Offset), InKeys);
		NativeReflection.InitializeValue_InContainer(MirrorElements_InSettings_PropertyAddress.Address, intPtr);
		FRigMirrorSettings.ToNative(IntPtr.Add(intPtr, MirrorElements_InSettings_Offset), 0, MirrorElements_InSettings_PropertyAddress.Address, InSettings);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MirrorElements_bSelectNewElements_Offset), 0, MirrorElements_bSelectNewElements_PropertyAddress.Address, bSelectNewElements);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MirrorElements_bSetupUndo_Offset), 0, MirrorElements_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MirrorElements_bPrintPythonCommands_Offset), 0, MirrorElements_bPrintPythonCommands_PropertyAddress.Address, bPrintPythonCommands);
		NativeReflection.InvokeFunctionOptimized(base.Address, MirrorElements_FunctionAddress, intPtr, MirrorElements_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MirrorElements_InKeys_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(MirrorElements_InSettings_PropertyAddress.Address, intPtr);
		List<FRigElementKey> result = new TArrayCopyMarshaler<FRigElementKey>(1, MirrorElements_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).FromNative(IntPtr.Add(intPtr, MirrorElements_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(MirrorElements_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:ImportFromText")]
	public unsafe List<FRigElementKey> ImportFromText(string InContent, bool bReplaceExistingElements = false, bool bSelectNewElements = true, bool bSetupUndo = false, bool bPrintPythonCommands = false)
	{
		CheckDestroyed();
		if (!ImportFromText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:ImportFromText");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ImportFromText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ImportFromText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ImportFromText_InContent_Offset), 0, ImportFromText_InContent_PropertyAddress.Address, InContent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ImportFromText_bReplaceExistingElements_Offset), 0, ImportFromText_bReplaceExistingElements_PropertyAddress.Address, bReplaceExistingElements);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ImportFromText_bSelectNewElements_Offset), 0, ImportFromText_bSelectNewElements_PropertyAddress.Address, bSelectNewElements);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ImportFromText_bSetupUndo_Offset), 0, ImportFromText_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ImportFromText_bPrintPythonCommands_Offset), 0, ImportFromText_bPrintPythonCommands_PropertyAddress.Address, bPrintPythonCommands);
		NativeReflection.InvokeFunctionOptimized(base.Address, ImportFromText_FunctionAddress, intPtr, ImportFromText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ImportFromText_InContent_PropertyAddress.Address, intPtr);
		List<FRigElementKey> result = new TArrayCopyMarshaler<FRigElementKey>(1, ImportFromText_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).FromNative(IntPtr.Add(intPtr, ImportFromText_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ImportFromText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:ImportCurvesFromAsset")]
	public unsafe List<FRigElementKey> ImportCurvesFromAsset(string InAssetPath, FName InNameSpace, bool bSelectCurves, bool bSetupUndo)
	{
		CheckDestroyed();
		if (!ImportCurvesFromAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:ImportCurvesFromAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ImportCurvesFromAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ImportCurvesFromAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ImportCurvesFromAsset_InAssetPath_Offset), 0, ImportCurvesFromAsset_InAssetPath_PropertyAddress.Address, InAssetPath);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ImportCurvesFromAsset_InNameSpace_Offset), 0, ImportCurvesFromAsset_InNameSpace_PropertyAddress.Address, InNameSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ImportCurvesFromAsset_bSelectCurves_Offset), 0, ImportCurvesFromAsset_bSelectCurves_PropertyAddress.Address, bSelectCurves);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ImportCurvesFromAsset_bSetupUndo_Offset), 0, ImportCurvesFromAsset_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		NativeReflection.InvokeFunctionOptimized(base.Address, ImportCurvesFromAsset_FunctionAddress, intPtr, ImportCurvesFromAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ImportCurvesFromAsset_InAssetPath_PropertyAddress.Address, intPtr);
		List<FRigElementKey> result = new TArrayCopyMarshaler<FRigElementKey>(1, ImportCurvesFromAsset_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).FromNative(IntPtr.Add(intPtr, ImportCurvesFromAsset_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ImportCurvesFromAsset_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:ImportCurves")]
	public unsafe List<FRigElementKey> ImportCurves(USkeleton InSkeleton, FName InNameSpace, bool bSelectCurves, bool bSetupUndo, bool bPrintPythonCommand)
	{
		CheckDestroyed();
		if (!ImportCurves_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:ImportCurves");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ImportCurves_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ImportCurves_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, ImportCurves_InSkeleton_Offset), 0, ImportCurves_InSkeleton_PropertyAddress.Address, InSkeleton);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ImportCurves_InNameSpace_Offset), 0, ImportCurves_InNameSpace_PropertyAddress.Address, InNameSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ImportCurves_bSelectCurves_Offset), 0, ImportCurves_bSelectCurves_PropertyAddress.Address, bSelectCurves);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ImportCurves_bSetupUndo_Offset), 0, ImportCurves_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ImportCurves_bPrintPythonCommand_Offset), 0, ImportCurves_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, ImportCurves_FunctionAddress, intPtr, ImportCurves_ParamsSize);
		List<FRigElementKey> result = new TArrayCopyMarshaler<FRigElementKey>(1, ImportCurves_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).FromNative(IntPtr.Add(intPtr, ImportCurves_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ImportCurves_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:ImportBonesFromAsset")]
	public unsafe List<FRigElementKey> ImportBonesFromAsset(string InAssetPath, FName InNameSpace, bool bReplaceExistingBones, bool bRemoveObsoleteBones, bool bSelectBones, bool bSetupUndo)
	{
		CheckDestroyed();
		if (!ImportBonesFromAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:ImportBonesFromAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ImportBonesFromAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ImportBonesFromAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ImportBonesFromAsset_InAssetPath_Offset), 0, ImportBonesFromAsset_InAssetPath_PropertyAddress.Address, InAssetPath);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ImportBonesFromAsset_InNameSpace_Offset), 0, ImportBonesFromAsset_InNameSpace_PropertyAddress.Address, InNameSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ImportBonesFromAsset_bReplaceExistingBones_Offset), 0, ImportBonesFromAsset_bReplaceExistingBones_PropertyAddress.Address, bReplaceExistingBones);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ImportBonesFromAsset_bRemoveObsoleteBones_Offset), 0, ImportBonesFromAsset_bRemoveObsoleteBones_PropertyAddress.Address, bRemoveObsoleteBones);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ImportBonesFromAsset_bSelectBones_Offset), 0, ImportBonesFromAsset_bSelectBones_PropertyAddress.Address, bSelectBones);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ImportBonesFromAsset_bSetupUndo_Offset), 0, ImportBonesFromAsset_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		NativeReflection.InvokeFunctionOptimized(base.Address, ImportBonesFromAsset_FunctionAddress, intPtr, ImportBonesFromAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ImportBonesFromAsset_InAssetPath_PropertyAddress.Address, intPtr);
		List<FRigElementKey> result = new TArrayCopyMarshaler<FRigElementKey>(1, ImportBonesFromAsset_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).FromNative(IntPtr.Add(intPtr, ImportBonesFromAsset_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ImportBonesFromAsset_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:ImportBones")]
	public unsafe List<FRigElementKey> ImportBones(USkeleton InSkeleton, FName InNameSpace, bool bReplaceExistingBones, bool bRemoveObsoleteBones, bool bSelectBones, bool bSetupUndo, bool bPrintPythonCommand)
	{
		CheckDestroyed();
		if (!ImportBones_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:ImportBones");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ImportBones_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ImportBones_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, ImportBones_InSkeleton_Offset), 0, ImportBones_InSkeleton_PropertyAddress.Address, InSkeleton);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ImportBones_InNameSpace_Offset), 0, ImportBones_InNameSpace_PropertyAddress.Address, InNameSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ImportBones_bReplaceExistingBones_Offset), 0, ImportBones_bReplaceExistingBones_PropertyAddress.Address, bReplaceExistingBones);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ImportBones_bRemoveObsoleteBones_Offset), 0, ImportBones_bRemoveObsoleteBones_PropertyAddress.Address, bRemoveObsoleteBones);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ImportBones_bSelectBones_Offset), 0, ImportBones_bSelectBones_PropertyAddress.Address, bSelectBones);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ImportBones_bSetupUndo_Offset), 0, ImportBones_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ImportBones_bPrintPythonCommand_Offset), 0, ImportBones_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, ImportBones_FunctionAddress, intPtr, ImportBones_ParamsSize);
		List<FRigElementKey> result = new TArrayCopyMarshaler<FRigElementKey>(1, ImportBones_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).FromNative(IntPtr.Add(intPtr, ImportBones_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ImportBones_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:GetHierarchy")]
	public unsafe URigHierarchy GetHierarchy()
	{
		CheckDestroyed();
		if (!GetHierarchy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:GetHierarchy");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHierarchy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHierarchy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHierarchy_FunctionAddress, intPtr, GetHierarchy_ParamsSize);
		return UObjectMarshaler<URigHierarchy>.FromNative(IntPtr.Add(intPtr, GetHierarchy_ReturnValue_Offset), 0, GetHierarchy_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:GetControlSettings")]
	public unsafe FRigControlSettings GetControlSettings(FRigElementKey InKey)
	{
		CheckDestroyed();
		if (!GetControlSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:GetControlSettings");
			return default(FRigControlSettings);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetControlSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetControlSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetControlSettings_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, GetControlSettings_InKey_Offset), 0, GetControlSettings_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetControlSettings_FunctionAddress, intPtr, GetControlSettings_ParamsSize);
		FRigControlSettings result = FRigControlSettings.FromNative(IntPtr.Add(intPtr, GetControlSettings_ReturnValue_Offset), 0, GetControlSettings_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetControlSettings_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:GeneratePythonCommands")]
	public unsafe List<string> GeneratePythonCommands()
	{
		CheckDestroyed();
		if (!GeneratePythonCommands_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:GeneratePythonCommands");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GeneratePythonCommands_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GeneratePythonCommands_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GeneratePythonCommands_FunctionAddress, intPtr, GeneratePythonCommands_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GeneratePythonCommands_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GeneratePythonCommands_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GeneratePythonCommands_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:ExportToText")]
	public unsafe string ExportToText(List<FRigElementKey> InKeys)
	{
		CheckDestroyed();
		if (!ExportToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:ExportToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FRigElementKey>(1, ExportToText_InKeys_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).ToNative(IntPtr.Add(intPtr, ExportToText_InKeys_Offset), InKeys);
		NativeReflection.InvokeFunctionOptimized(base.Address, ExportToText_FunctionAddress, intPtr, ExportToText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExportToText_InKeys_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ExportToText_ReturnValue_Offset), 0, ExportToText_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ExportToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:ExportSelectionToText")]
	public unsafe string ExportSelectionToText()
	{
		CheckDestroyed();
		if (!ExportSelectionToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:ExportSelectionToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportSelectionToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportSelectionToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ExportSelectionToText_FunctionAddress, intPtr, ExportSelectionToText_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ExportSelectionToText_ReturnValue_Offset), 0, ExportSelectionToText_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ExportSelectionToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:DuplicateElements")]
	public unsafe List<FRigElementKey> DuplicateElements(List<FRigElementKey> InKeys, bool bSelectNewElements = true, bool bSetupUndo = false, bool bPrintPythonCommands = false)
	{
		CheckDestroyed();
		if (!DuplicateElements_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:DuplicateElements");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateElements_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateElements_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FRigElementKey>(1, DuplicateElements_InKeys_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).ToNative(IntPtr.Add(intPtr, DuplicateElements_InKeys_Offset), InKeys);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateElements_bSelectNewElements_Offset), 0, DuplicateElements_bSelectNewElements_PropertyAddress.Address, bSelectNewElements);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateElements_bSetupUndo_Offset), 0, DuplicateElements_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateElements_bPrintPythonCommands_Offset), 0, DuplicateElements_bPrintPythonCommands_PropertyAddress.Address, bPrintPythonCommands);
		NativeReflection.InvokeFunctionOptimized(base.Address, DuplicateElements_FunctionAddress, intPtr, DuplicateElements_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DuplicateElements_InKeys_PropertyAddress.Address, intPtr);
		List<FRigElementKey> result = new TArrayCopyMarshaler<FRigElementKey>(1, DuplicateElements_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).FromNative(IntPtr.Add(intPtr, DuplicateElements_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(DuplicateElements_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:DeselectElement")]
	public unsafe bool DeselectElement(FRigElementKey InKey)
	{
		CheckDestroyed();
		if (!DeselectElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:DeselectElement");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeselectElement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeselectElement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DeselectElement_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, DeselectElement_InKey_Offset), 0, DeselectElement_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, DeselectElement_FunctionAddress, intPtr, DeselectElement_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DeselectElement_ReturnValue_Offset), 0, DeselectElement_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:ClearSelection")]
	public unsafe bool ClearSelection()
	{
		CheckDestroyed();
		if (!ClearSelection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:ClearSelection");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearSelection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearSelection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClearSelection_FunctionAddress, intPtr, ClearSelection_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ClearSelection_ReturnValue_Offset), 0, ClearSelection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:AddRigidBody")]
	public unsafe FRigElementKey AddRigidBody(FName InName, FRigElementKey InParent, FRigRigidBodySettings InSettings, FTransform InLocalTransform, bool bSetupUndo = false, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddRigidBody_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:AddRigidBody");
			return default(FRigElementKey);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddRigidBody_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddRigidBody_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddRigidBody_InName_Offset), 0, AddRigidBody_InName_PropertyAddress.Address, InName);
		NativeReflection.InitializeValue_InContainer(AddRigidBody_InParent_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, AddRigidBody_InParent_Offset), 0, AddRigidBody_InParent_PropertyAddress.Address, InParent);
		NativeReflection.InitializeValue_InContainer(AddRigidBody_InSettings_PropertyAddress.Address, intPtr);
		FRigRigidBodySettings.ToNative(IntPtr.Add(intPtr, AddRigidBody_InSettings_Offset), 0, AddRigidBody_InSettings_PropertyAddress.Address, InSettings);
		NativeReflection.InitializeValue_InContainer(AddRigidBody_InLocalTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AddRigidBody_InLocalTransform_Offset), 0, AddRigidBody_InLocalTransform_PropertyAddress.Address, InLocalTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddRigidBody_bSetupUndo_Offset), 0, AddRigidBody_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddRigidBody_bPrintPythonCommand_Offset), 0, AddRigidBody_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddRigidBody_FunctionAddress, intPtr, AddRigidBody_ParamsSize);
		return FRigElementKey.FromNative(IntPtr.Add(intPtr, AddRigidBody_ReturnValue_Offset), 0, AddRigidBody_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:AddParent")]
	public unsafe bool AddParent(FRigElementKey InChild, FRigElementKey InParent, float InWeight = 0f, bool bMaintainGlobalTransform = true, bool bSetupUndo = false)
	{
		CheckDestroyed();
		if (!AddParent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:AddParent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddParent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddParent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddParent_InChild_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, AddParent_InChild_Offset), 0, AddParent_InChild_PropertyAddress.Address, InChild);
		NativeReflection.InitializeValue_InContainer(AddParent_InParent_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, AddParent_InParent_Offset), 0, AddParent_InParent_PropertyAddress.Address, InParent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddParent_InWeight_Offset), 0, AddParent_InWeight_PropertyAddress.Address, InWeight);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddParent_bMaintainGlobalTransform_Offset), 0, AddParent_bMaintainGlobalTransform_PropertyAddress.Address, bMaintainGlobalTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddParent_bSetupUndo_Offset), 0, AddParent_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddParent_FunctionAddress, intPtr, AddParent_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddParent_ReturnValue_Offset), 0, AddParent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:AddNull")]
	public unsafe FRigElementKey AddNull(FName InName, FRigElementKey InParent, FTransform InTransform, bool bTransformInGlobal = true, bool bSetupUndo = false, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddNull_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:AddNull");
			return default(FRigElementKey);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddNull_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddNull_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddNull_InName_Offset), 0, AddNull_InName_PropertyAddress.Address, InName);
		NativeReflection.InitializeValue_InContainer(AddNull_InParent_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, AddNull_InParent_Offset), 0, AddNull_InParent_PropertyAddress.Address, InParent);
		NativeReflection.InitializeValue_InContainer(AddNull_InTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AddNull_InTransform_Offset), 0, AddNull_InTransform_PropertyAddress.Address, InTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddNull_bTransformInGlobal_Offset), 0, AddNull_bTransformInGlobal_PropertyAddress.Address, bTransformInGlobal);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddNull_bSetupUndo_Offset), 0, AddNull_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddNull_bPrintPythonCommand_Offset), 0, AddNull_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddNull_FunctionAddress, intPtr, AddNull_ParamsSize);
		return FRigElementKey.FromNative(IntPtr.Add(intPtr, AddNull_ReturnValue_Offset), 0, AddNull_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:AddCurve")]
	public unsafe FRigElementKey AddCurve(FName InName, float InValue = 0f, bool bSetupUndo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddCurve_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:AddCurve");
			return default(FRigElementKey);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddCurve_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddCurve_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddCurve_InName_Offset), 0, AddCurve_InName_PropertyAddress.Address, InName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddCurve_InValue_Offset), 0, AddCurve_InValue_PropertyAddress.Address, InValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddCurve_bSetupUndo_Offset), 0, AddCurve_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddCurve_bPrintPythonCommand_Offset), 0, AddCurve_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddCurve_FunctionAddress, intPtr, AddCurve_ParamsSize);
		return FRigElementKey.FromNative(IntPtr.Add(intPtr, AddCurve_ReturnValue_Offset), 0, AddCurve_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u, OriginalName = "AddControl_ForBlueprint")]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:AddControl_ForBlueprint")]
	public unsafe FRigElementKey AddControl(FName InName, FRigElementKey InParent, FRigControlSettings InSettings, FRigControlValue InValue, bool bSetupUndo = true)
	{
		CheckDestroyed();
		if (!AddControl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:AddControl_ForBlueprint");
			return default(FRigElementKey);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddControl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddControl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddControl_InName_Offset), 0, AddControl_InName_PropertyAddress.Address, InName);
		NativeReflection.InitializeValue_InContainer(AddControl_InParent_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, AddControl_InParent_Offset), 0, AddControl_InParent_PropertyAddress.Address, InParent);
		NativeReflection.InitializeValue_InContainer(AddControl_InSettings_PropertyAddress.Address, intPtr);
		FRigControlSettings.ToNative(IntPtr.Add(intPtr, AddControl_InSettings_Offset), 0, AddControl_InSettings_PropertyAddress.Address, InSettings);
		NativeReflection.InitializeValue_InContainer(AddControl_InValue_PropertyAddress.Address, intPtr);
		FRigControlValue.ToNative(IntPtr.Add(intPtr, AddControl_InValue_Offset), 0, AddControl_InValue_PropertyAddress.Address, InValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddControl_bSetupUndo_Offset), 0, AddControl_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddControl_FunctionAddress, intPtr, AddControl_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddControl_InSettings_PropertyAddress.Address, intPtr);
		return FRigElementKey.FromNative(IntPtr.Add(intPtr, AddControl_ReturnValue_Offset), 0, AddControl_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ControlRig.RigHierarchyController:AddBone")]
	public unsafe FRigElementKey AddBone(FName InName, FRigElementKey InParent, FTransform InTransform, bool bTransformInGlobal = true, ERigBoneType InBoneType = ERigBoneType.User, bool bSetupUndo = false, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddBone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchyController:AddBone");
			return default(FRigElementKey);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddBone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddBone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddBone_InName_Offset), 0, AddBone_InName_PropertyAddress.Address, InName);
		NativeReflection.InitializeValue_InContainer(AddBone_InParent_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, AddBone_InParent_Offset), 0, AddBone_InParent_PropertyAddress.Address, InParent);
		NativeReflection.InitializeValue_InContainer(AddBone_InTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AddBone_InTransform_Offset), 0, AddBone_InTransform_PropertyAddress.Address, InTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddBone_bTransformInGlobal_Offset), 0, AddBone_bTransformInGlobal_PropertyAddress.Address, bTransformInGlobal);
		EnumMarshaler<ERigBoneType>.ToNative(IntPtr.Add(intPtr, AddBone_InBoneType_Offset), 0, AddBone_InBoneType_PropertyAddress.Address, InBoneType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddBone_bSetupUndo_Offset), 0, AddBone_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddBone_bPrintPythonCommand_Offset), 0, AddBone_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddBone_FunctionAddress, intPtr, AddBone_ParamsSize);
		return FRigElementKey.FromNative(IntPtr.Add(intPtr, AddBone_ReturnValue_Offset), 0, AddBone_ReturnValue_PropertyAddress.Address);
	}

	static URigHierarchyController()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URigHierarchyController)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URigHierarchyController));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/ControlRig.RigHierarchyController");
		SetSelection_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetSelection");
		SetSelection_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSelection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSelection_InKeys_PropertyAddress, SetSelection_FunctionAddress, "InKeys");
		SetSelection_InKeys_Offset = NativeReflectionCached.GetPropertyOffset(SetSelection_FunctionAddress, "InKeys");
		SetSelection_InKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSelection_FunctionAddress, "InKeys", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSelection_bPrintPythonCommand_PropertyAddress, SetSelection_FunctionAddress, "bPrintPythonCommand");
		SetSelection_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(SetSelection_FunctionAddress, "bPrintPythonCommand");
		SetSelection_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSelection_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSelection_ReturnValue_PropertyAddress, SetSelection_FunctionAddress, "ReturnValue");
		SetSelection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSelection_FunctionAddress, "ReturnValue");
		SetSelection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSelection_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetSelection_IsValid = SetSelection_FunctionAddress != IntPtr.Zero && SetSelection_InKeys_IsValid && SetSelection_bPrintPythonCommand_IsValid && SetSelection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:SetSelection", SetSelection_IsValid);
		SetParent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetParent");
		SetParent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetParent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetParent_InChild_PropertyAddress, SetParent_FunctionAddress, "InChild");
		SetParent_InChild_Offset = NativeReflectionCached.GetPropertyOffset(SetParent_FunctionAddress, "InChild");
		SetParent_InChild_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParent_FunctionAddress, "InChild", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParent_InParent_PropertyAddress, SetParent_FunctionAddress, "InParent");
		SetParent_InParent_Offset = NativeReflectionCached.GetPropertyOffset(SetParent_FunctionAddress, "InParent");
		SetParent_InParent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParent_FunctionAddress, "InParent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParent_bMaintainGlobalTransform_PropertyAddress, SetParent_FunctionAddress, "bMaintainGlobalTransform");
		SetParent_bMaintainGlobalTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetParent_FunctionAddress, "bMaintainGlobalTransform");
		SetParent_bMaintainGlobalTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParent_FunctionAddress, "bMaintainGlobalTransform", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParent_bSetupUndo_PropertyAddress, SetParent_FunctionAddress, "bSetupUndo");
		SetParent_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(SetParent_FunctionAddress, "bSetupUndo");
		SetParent_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParent_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParent_bPrintPythonCommand_PropertyAddress, SetParent_FunctionAddress, "bPrintPythonCommand");
		SetParent_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(SetParent_FunctionAddress, "bPrintPythonCommand");
		SetParent_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParent_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParent_ReturnValue_PropertyAddress, SetParent_FunctionAddress, "ReturnValue");
		SetParent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetParent_FunctionAddress, "ReturnValue");
		SetParent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetParent_IsValid = SetParent_FunctionAddress != IntPtr.Zero && SetParent_InChild_IsValid && SetParent_InParent_IsValid && SetParent_bMaintainGlobalTransform_IsValid && SetParent_bSetupUndo_IsValid && SetParent_bPrintPythonCommand_IsValid && SetParent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:SetParent", SetParent_IsValid);
		SetHierarchy_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetHierarchy");
		SetHierarchy_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHierarchy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHierarchy_InHierarchy_PropertyAddress, SetHierarchy_FunctionAddress, "InHierarchy");
		SetHierarchy_InHierarchy_Offset = NativeReflectionCached.GetPropertyOffset(SetHierarchy_FunctionAddress, "InHierarchy");
		SetHierarchy_InHierarchy_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHierarchy_FunctionAddress, "InHierarchy", Classes.FObjectProperty);
		SetHierarchy_IsValid = SetHierarchy_FunctionAddress != IntPtr.Zero && SetHierarchy_InHierarchy_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:SetHierarchy", SetHierarchy_IsValid);
		SetControlSettings_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetControlSettings");
		SetControlSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetControlSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetControlSettings_InKey_PropertyAddress, SetControlSettings_FunctionAddress, "InKey");
		SetControlSettings_InKey_Offset = NativeReflectionCached.GetPropertyOffset(SetControlSettings_FunctionAddress, "InKey");
		SetControlSettings_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlSettings_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlSettings_InSettings_PropertyAddress, SetControlSettings_FunctionAddress, "InSettings");
		SetControlSettings_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetControlSettings_FunctionAddress, "InSettings");
		SetControlSettings_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlSettings_FunctionAddress, "InSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlSettings_bSetupUndo_PropertyAddress, SetControlSettings_FunctionAddress, "bSetupUndo");
		SetControlSettings_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(SetControlSettings_FunctionAddress, "bSetupUndo");
		SetControlSettings_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlSettings_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlSettings_ReturnValue_PropertyAddress, SetControlSettings_FunctionAddress, "ReturnValue");
		SetControlSettings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetControlSettings_FunctionAddress, "ReturnValue");
		SetControlSettings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlSettings_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetControlSettings_IsValid = SetControlSettings_FunctionAddress != IntPtr.Zero && SetControlSettings_InKey_IsValid && SetControlSettings_InSettings_IsValid && SetControlSettings_bSetupUndo_IsValid && SetControlSettings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:SetControlSettings", SetControlSettings_IsValid);
		SelectElement_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SelectElement");
		SelectElement_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectElement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectElement_InKey_PropertyAddress, SelectElement_FunctionAddress, "InKey");
		SelectElement_InKey_Offset = NativeReflectionCached.GetPropertyOffset(SelectElement_FunctionAddress, "InKey");
		SelectElement_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectElement_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectElement_bSelect_PropertyAddress, SelectElement_FunctionAddress, "bSelect");
		SelectElement_bSelect_Offset = NativeReflectionCached.GetPropertyOffset(SelectElement_FunctionAddress, "bSelect");
		SelectElement_bSelect_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectElement_FunctionAddress, "bSelect", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectElement_bClearSelection_PropertyAddress, SelectElement_FunctionAddress, "bClearSelection");
		SelectElement_bClearSelection_Offset = NativeReflectionCached.GetPropertyOffset(SelectElement_FunctionAddress, "bClearSelection");
		SelectElement_bClearSelection_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectElement_FunctionAddress, "bClearSelection", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectElement_ReturnValue_PropertyAddress, SelectElement_FunctionAddress, "ReturnValue");
		SelectElement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SelectElement_FunctionAddress, "ReturnValue");
		SelectElement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectElement_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SelectElement_IsValid = SelectElement_FunctionAddress != IntPtr.Zero && SelectElement_InKey_IsValid && SelectElement_bSelect_IsValid && SelectElement_bClearSelection_IsValid && SelectElement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:SelectElement", SelectElement_IsValid);
		RenameElement_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RenameElement");
		RenameElement_ParamsSize = NativeReflection.GetFunctionParamsSize(RenameElement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenameElement_InElement_PropertyAddress, RenameElement_FunctionAddress, "InElement");
		RenameElement_InElement_Offset = NativeReflectionCached.GetPropertyOffset(RenameElement_FunctionAddress, "InElement");
		RenameElement_InElement_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameElement_FunctionAddress, "InElement", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameElement_InName_PropertyAddress, RenameElement_FunctionAddress, "InName");
		RenameElement_InName_Offset = NativeReflectionCached.GetPropertyOffset(RenameElement_FunctionAddress, "InName");
		RenameElement_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameElement_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameElement_bSetupUndo_PropertyAddress, RenameElement_FunctionAddress, "bSetupUndo");
		RenameElement_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(RenameElement_FunctionAddress, "bSetupUndo");
		RenameElement_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameElement_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameElement_bPrintPythonCommand_PropertyAddress, RenameElement_FunctionAddress, "bPrintPythonCommand");
		RenameElement_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(RenameElement_FunctionAddress, "bPrintPythonCommand");
		RenameElement_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameElement_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameElement_bClearSelection_PropertyAddress, RenameElement_FunctionAddress, "bClearSelection");
		RenameElement_bClearSelection_Offset = NativeReflectionCached.GetPropertyOffset(RenameElement_FunctionAddress, "bClearSelection");
		RenameElement_bClearSelection_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameElement_FunctionAddress, "bClearSelection", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameElement_ReturnValue_PropertyAddress, RenameElement_FunctionAddress, "ReturnValue");
		RenameElement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RenameElement_FunctionAddress, "ReturnValue");
		RenameElement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameElement_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		RenameElement_IsValid = RenameElement_FunctionAddress != IntPtr.Zero && RenameElement_InElement_IsValid && RenameElement_InName_IsValid && RenameElement_bSetupUndo_IsValid && RenameElement_bPrintPythonCommand_IsValid && RenameElement_bClearSelection_IsValid && RenameElement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:RenameElement", RenameElement_IsValid);
		RemoveParent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveParent");
		RemoveParent_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveParent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveParent_InChild_PropertyAddress, RemoveParent_FunctionAddress, "InChild");
		RemoveParent_InChild_Offset = NativeReflectionCached.GetPropertyOffset(RemoveParent_FunctionAddress, "InChild");
		RemoveParent_InChild_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveParent_FunctionAddress, "InChild", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveParent_InParent_PropertyAddress, RemoveParent_FunctionAddress, "InParent");
		RemoveParent_InParent_Offset = NativeReflectionCached.GetPropertyOffset(RemoveParent_FunctionAddress, "InParent");
		RemoveParent_InParent_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveParent_FunctionAddress, "InParent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveParent_bMaintainGlobalTransform_PropertyAddress, RemoveParent_FunctionAddress, "bMaintainGlobalTransform");
		RemoveParent_bMaintainGlobalTransform_Offset = NativeReflectionCached.GetPropertyOffset(RemoveParent_FunctionAddress, "bMaintainGlobalTransform");
		RemoveParent_bMaintainGlobalTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveParent_FunctionAddress, "bMaintainGlobalTransform", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveParent_bSetupUndo_PropertyAddress, RemoveParent_FunctionAddress, "bSetupUndo");
		RemoveParent_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(RemoveParent_FunctionAddress, "bSetupUndo");
		RemoveParent_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveParent_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveParent_bPrintPythonCommand_PropertyAddress, RemoveParent_FunctionAddress, "bPrintPythonCommand");
		RemoveParent_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(RemoveParent_FunctionAddress, "bPrintPythonCommand");
		RemoveParent_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveParent_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveParent_ReturnValue_PropertyAddress, RemoveParent_FunctionAddress, "ReturnValue");
		RemoveParent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveParent_FunctionAddress, "ReturnValue");
		RemoveParent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveParent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveParent_IsValid = RemoveParent_FunctionAddress != IntPtr.Zero && RemoveParent_InChild_IsValid && RemoveParent_InParent_IsValid && RemoveParent_bMaintainGlobalTransform_IsValid && RemoveParent_bSetupUndo_IsValid && RemoveParent_bPrintPythonCommand_IsValid && RemoveParent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:RemoveParent", RemoveParent_IsValid);
		RemoveElement_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveElement");
		RemoveElement_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveElement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveElement_InElement_PropertyAddress, RemoveElement_FunctionAddress, "InElement");
		RemoveElement_InElement_Offset = NativeReflectionCached.GetPropertyOffset(RemoveElement_FunctionAddress, "InElement");
		RemoveElement_InElement_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveElement_FunctionAddress, "InElement", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveElement_bSetupUndo_PropertyAddress, RemoveElement_FunctionAddress, "bSetupUndo");
		RemoveElement_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(RemoveElement_FunctionAddress, "bSetupUndo");
		RemoveElement_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveElement_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveElement_bPrintPythonCommand_PropertyAddress, RemoveElement_FunctionAddress, "bPrintPythonCommand");
		RemoveElement_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(RemoveElement_FunctionAddress, "bPrintPythonCommand");
		RemoveElement_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveElement_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveElement_ReturnValue_PropertyAddress, RemoveElement_FunctionAddress, "ReturnValue");
		RemoveElement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveElement_FunctionAddress, "ReturnValue");
		RemoveElement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveElement_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveElement_IsValid = RemoveElement_FunctionAddress != IntPtr.Zero && RemoveElement_InElement_IsValid && RemoveElement_bSetupUndo_IsValid && RemoveElement_bPrintPythonCommand_IsValid && RemoveElement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:RemoveElement", RemoveElement_IsValid);
		RemoveAllParents_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveAllParents");
		RemoveAllParents_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllParents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllParents_InChild_PropertyAddress, RemoveAllParents_FunctionAddress, "InChild");
		RemoveAllParents_InChild_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllParents_FunctionAddress, "InChild");
		RemoveAllParents_InChild_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllParents_FunctionAddress, "InChild", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllParents_bMaintainGlobalTransform_PropertyAddress, RemoveAllParents_FunctionAddress, "bMaintainGlobalTransform");
		RemoveAllParents_bMaintainGlobalTransform_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllParents_FunctionAddress, "bMaintainGlobalTransform");
		RemoveAllParents_bMaintainGlobalTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllParents_FunctionAddress, "bMaintainGlobalTransform", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllParents_bSetupUndo_PropertyAddress, RemoveAllParents_FunctionAddress, "bSetupUndo");
		RemoveAllParents_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllParents_FunctionAddress, "bSetupUndo");
		RemoveAllParents_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllParents_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllParents_bPrintPythonCommand_PropertyAddress, RemoveAllParents_FunctionAddress, "bPrintPythonCommand");
		RemoveAllParents_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllParents_FunctionAddress, "bPrintPythonCommand");
		RemoveAllParents_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllParents_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllParents_ReturnValue_PropertyAddress, RemoveAllParents_FunctionAddress, "ReturnValue");
		RemoveAllParents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllParents_FunctionAddress, "ReturnValue");
		RemoveAllParents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllParents_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveAllParents_IsValid = RemoveAllParents_FunctionAddress != IntPtr.Zero && RemoveAllParents_InChild_IsValid && RemoveAllParents_bMaintainGlobalTransform_IsValid && RemoveAllParents_bSetupUndo_IsValid && RemoveAllParents_bPrintPythonCommand_IsValid && RemoveAllParents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:RemoveAllParents", RemoveAllParents_IsValid);
		MirrorElements_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "MirrorElements");
		MirrorElements_ParamsSize = NativeReflection.GetFunctionParamsSize(MirrorElements_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MirrorElements_InKeys_PropertyAddress, MirrorElements_FunctionAddress, "InKeys");
		MirrorElements_InKeys_Offset = NativeReflectionCached.GetPropertyOffset(MirrorElements_FunctionAddress, "InKeys");
		MirrorElements_InKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(MirrorElements_FunctionAddress, "InKeys", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref MirrorElements_InSettings_PropertyAddress, MirrorElements_FunctionAddress, "InSettings");
		MirrorElements_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(MirrorElements_FunctionAddress, "InSettings");
		MirrorElements_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(MirrorElements_FunctionAddress, "InSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MirrorElements_bSelectNewElements_PropertyAddress, MirrorElements_FunctionAddress, "bSelectNewElements");
		MirrorElements_bSelectNewElements_Offset = NativeReflectionCached.GetPropertyOffset(MirrorElements_FunctionAddress, "bSelectNewElements");
		MirrorElements_bSelectNewElements_IsValid = NativeReflectionCached.ValidatePropertyClass(MirrorElements_FunctionAddress, "bSelectNewElements", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MirrorElements_bSetupUndo_PropertyAddress, MirrorElements_FunctionAddress, "bSetupUndo");
		MirrorElements_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(MirrorElements_FunctionAddress, "bSetupUndo");
		MirrorElements_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(MirrorElements_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MirrorElements_bPrintPythonCommands_PropertyAddress, MirrorElements_FunctionAddress, "bPrintPythonCommands");
		MirrorElements_bPrintPythonCommands_Offset = NativeReflectionCached.GetPropertyOffset(MirrorElements_FunctionAddress, "bPrintPythonCommands");
		MirrorElements_bPrintPythonCommands_IsValid = NativeReflectionCached.ValidatePropertyClass(MirrorElements_FunctionAddress, "bPrintPythonCommands", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MirrorElements_ReturnValue_PropertyAddress, MirrorElements_FunctionAddress, "ReturnValue");
		MirrorElements_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MirrorElements_FunctionAddress, "ReturnValue");
		MirrorElements_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MirrorElements_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		MirrorElements_IsValid = MirrorElements_FunctionAddress != IntPtr.Zero && MirrorElements_InKeys_IsValid && MirrorElements_InSettings_IsValid && MirrorElements_bSelectNewElements_IsValid && MirrorElements_bSetupUndo_IsValid && MirrorElements_bPrintPythonCommands_IsValid && MirrorElements_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:MirrorElements", MirrorElements_IsValid);
		ImportFromText_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ImportFromText");
		ImportFromText_ParamsSize = NativeReflection.GetFunctionParamsSize(ImportFromText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ImportFromText_InContent_PropertyAddress, ImportFromText_FunctionAddress, "InContent");
		ImportFromText_InContent_Offset = NativeReflectionCached.GetPropertyOffset(ImportFromText_FunctionAddress, "InContent");
		ImportFromText_InContent_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportFromText_FunctionAddress, "InContent", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportFromText_bReplaceExistingElements_PropertyAddress, ImportFromText_FunctionAddress, "bReplaceExistingElements");
		ImportFromText_bReplaceExistingElements_Offset = NativeReflectionCached.GetPropertyOffset(ImportFromText_FunctionAddress, "bReplaceExistingElements");
		ImportFromText_bReplaceExistingElements_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportFromText_FunctionAddress, "bReplaceExistingElements", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportFromText_bSelectNewElements_PropertyAddress, ImportFromText_FunctionAddress, "bSelectNewElements");
		ImportFromText_bSelectNewElements_Offset = NativeReflectionCached.GetPropertyOffset(ImportFromText_FunctionAddress, "bSelectNewElements");
		ImportFromText_bSelectNewElements_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportFromText_FunctionAddress, "bSelectNewElements", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportFromText_bSetupUndo_PropertyAddress, ImportFromText_FunctionAddress, "bSetupUndo");
		ImportFromText_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(ImportFromText_FunctionAddress, "bSetupUndo");
		ImportFromText_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportFromText_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportFromText_bPrintPythonCommands_PropertyAddress, ImportFromText_FunctionAddress, "bPrintPythonCommands");
		ImportFromText_bPrintPythonCommands_Offset = NativeReflectionCached.GetPropertyOffset(ImportFromText_FunctionAddress, "bPrintPythonCommands");
		ImportFromText_bPrintPythonCommands_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportFromText_FunctionAddress, "bPrintPythonCommands", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportFromText_ReturnValue_PropertyAddress, ImportFromText_FunctionAddress, "ReturnValue");
		ImportFromText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ImportFromText_FunctionAddress, "ReturnValue");
		ImportFromText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportFromText_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ImportFromText_IsValid = ImportFromText_FunctionAddress != IntPtr.Zero && ImportFromText_InContent_IsValid && ImportFromText_bReplaceExistingElements_IsValid && ImportFromText_bSelectNewElements_IsValid && ImportFromText_bSetupUndo_IsValid && ImportFromText_bPrintPythonCommands_IsValid && ImportFromText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:ImportFromText", ImportFromText_IsValid);
		ImportCurvesFromAsset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ImportCurvesFromAsset");
		ImportCurvesFromAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(ImportCurvesFromAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ImportCurvesFromAsset_InAssetPath_PropertyAddress, ImportCurvesFromAsset_FunctionAddress, "InAssetPath");
		ImportCurvesFromAsset_InAssetPath_Offset = NativeReflectionCached.GetPropertyOffset(ImportCurvesFromAsset_FunctionAddress, "InAssetPath");
		ImportCurvesFromAsset_InAssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportCurvesFromAsset_FunctionAddress, "InAssetPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportCurvesFromAsset_InNameSpace_PropertyAddress, ImportCurvesFromAsset_FunctionAddress, "InNameSpace");
		ImportCurvesFromAsset_InNameSpace_Offset = NativeReflectionCached.GetPropertyOffset(ImportCurvesFromAsset_FunctionAddress, "InNameSpace");
		ImportCurvesFromAsset_InNameSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportCurvesFromAsset_FunctionAddress, "InNameSpace", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportCurvesFromAsset_bSelectCurves_PropertyAddress, ImportCurvesFromAsset_FunctionAddress, "bSelectCurves");
		ImportCurvesFromAsset_bSelectCurves_Offset = NativeReflectionCached.GetPropertyOffset(ImportCurvesFromAsset_FunctionAddress, "bSelectCurves");
		ImportCurvesFromAsset_bSelectCurves_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportCurvesFromAsset_FunctionAddress, "bSelectCurves", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportCurvesFromAsset_bSetupUndo_PropertyAddress, ImportCurvesFromAsset_FunctionAddress, "bSetupUndo");
		ImportCurvesFromAsset_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(ImportCurvesFromAsset_FunctionAddress, "bSetupUndo");
		ImportCurvesFromAsset_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportCurvesFromAsset_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportCurvesFromAsset_ReturnValue_PropertyAddress, ImportCurvesFromAsset_FunctionAddress, "ReturnValue");
		ImportCurvesFromAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ImportCurvesFromAsset_FunctionAddress, "ReturnValue");
		ImportCurvesFromAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportCurvesFromAsset_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ImportCurvesFromAsset_IsValid = ImportCurvesFromAsset_FunctionAddress != IntPtr.Zero && ImportCurvesFromAsset_InAssetPath_IsValid && ImportCurvesFromAsset_InNameSpace_IsValid && ImportCurvesFromAsset_bSelectCurves_IsValid && ImportCurvesFromAsset_bSetupUndo_IsValid && ImportCurvesFromAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:ImportCurvesFromAsset", ImportCurvesFromAsset_IsValid);
		ImportCurves_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ImportCurves");
		ImportCurves_ParamsSize = NativeReflection.GetFunctionParamsSize(ImportCurves_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ImportCurves_InSkeleton_PropertyAddress, ImportCurves_FunctionAddress, "InSkeleton");
		ImportCurves_InSkeleton_Offset = NativeReflectionCached.GetPropertyOffset(ImportCurves_FunctionAddress, "InSkeleton");
		ImportCurves_InSkeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportCurves_FunctionAddress, "InSkeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportCurves_InNameSpace_PropertyAddress, ImportCurves_FunctionAddress, "InNameSpace");
		ImportCurves_InNameSpace_Offset = NativeReflectionCached.GetPropertyOffset(ImportCurves_FunctionAddress, "InNameSpace");
		ImportCurves_InNameSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportCurves_FunctionAddress, "InNameSpace", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportCurves_bSelectCurves_PropertyAddress, ImportCurves_FunctionAddress, "bSelectCurves");
		ImportCurves_bSelectCurves_Offset = NativeReflectionCached.GetPropertyOffset(ImportCurves_FunctionAddress, "bSelectCurves");
		ImportCurves_bSelectCurves_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportCurves_FunctionAddress, "bSelectCurves", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportCurves_bSetupUndo_PropertyAddress, ImportCurves_FunctionAddress, "bSetupUndo");
		ImportCurves_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(ImportCurves_FunctionAddress, "bSetupUndo");
		ImportCurves_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportCurves_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportCurves_bPrintPythonCommand_PropertyAddress, ImportCurves_FunctionAddress, "bPrintPythonCommand");
		ImportCurves_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(ImportCurves_FunctionAddress, "bPrintPythonCommand");
		ImportCurves_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportCurves_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportCurves_ReturnValue_PropertyAddress, ImportCurves_FunctionAddress, "ReturnValue");
		ImportCurves_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ImportCurves_FunctionAddress, "ReturnValue");
		ImportCurves_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportCurves_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ImportCurves_IsValid = ImportCurves_FunctionAddress != IntPtr.Zero && ImportCurves_InSkeleton_IsValid && ImportCurves_InNameSpace_IsValid && ImportCurves_bSelectCurves_IsValid && ImportCurves_bSetupUndo_IsValid && ImportCurves_bPrintPythonCommand_IsValid && ImportCurves_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:ImportCurves", ImportCurves_IsValid);
		ImportBonesFromAsset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ImportBonesFromAsset");
		ImportBonesFromAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(ImportBonesFromAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ImportBonesFromAsset_InAssetPath_PropertyAddress, ImportBonesFromAsset_FunctionAddress, "InAssetPath");
		ImportBonesFromAsset_InAssetPath_Offset = NativeReflectionCached.GetPropertyOffset(ImportBonesFromAsset_FunctionAddress, "InAssetPath");
		ImportBonesFromAsset_InAssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportBonesFromAsset_FunctionAddress, "InAssetPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportBonesFromAsset_InNameSpace_PropertyAddress, ImportBonesFromAsset_FunctionAddress, "InNameSpace");
		ImportBonesFromAsset_InNameSpace_Offset = NativeReflectionCached.GetPropertyOffset(ImportBonesFromAsset_FunctionAddress, "InNameSpace");
		ImportBonesFromAsset_InNameSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportBonesFromAsset_FunctionAddress, "InNameSpace", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportBonesFromAsset_bReplaceExistingBones_PropertyAddress, ImportBonesFromAsset_FunctionAddress, "bReplaceExistingBones");
		ImportBonesFromAsset_bReplaceExistingBones_Offset = NativeReflectionCached.GetPropertyOffset(ImportBonesFromAsset_FunctionAddress, "bReplaceExistingBones");
		ImportBonesFromAsset_bReplaceExistingBones_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportBonesFromAsset_FunctionAddress, "bReplaceExistingBones", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportBonesFromAsset_bRemoveObsoleteBones_PropertyAddress, ImportBonesFromAsset_FunctionAddress, "bRemoveObsoleteBones");
		ImportBonesFromAsset_bRemoveObsoleteBones_Offset = NativeReflectionCached.GetPropertyOffset(ImportBonesFromAsset_FunctionAddress, "bRemoveObsoleteBones");
		ImportBonesFromAsset_bRemoveObsoleteBones_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportBonesFromAsset_FunctionAddress, "bRemoveObsoleteBones", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportBonesFromAsset_bSelectBones_PropertyAddress, ImportBonesFromAsset_FunctionAddress, "bSelectBones");
		ImportBonesFromAsset_bSelectBones_Offset = NativeReflectionCached.GetPropertyOffset(ImportBonesFromAsset_FunctionAddress, "bSelectBones");
		ImportBonesFromAsset_bSelectBones_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportBonesFromAsset_FunctionAddress, "bSelectBones", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportBonesFromAsset_bSetupUndo_PropertyAddress, ImportBonesFromAsset_FunctionAddress, "bSetupUndo");
		ImportBonesFromAsset_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(ImportBonesFromAsset_FunctionAddress, "bSetupUndo");
		ImportBonesFromAsset_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportBonesFromAsset_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportBonesFromAsset_ReturnValue_PropertyAddress, ImportBonesFromAsset_FunctionAddress, "ReturnValue");
		ImportBonesFromAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ImportBonesFromAsset_FunctionAddress, "ReturnValue");
		ImportBonesFromAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportBonesFromAsset_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ImportBonesFromAsset_IsValid = ImportBonesFromAsset_FunctionAddress != IntPtr.Zero && ImportBonesFromAsset_InAssetPath_IsValid && ImportBonesFromAsset_InNameSpace_IsValid && ImportBonesFromAsset_bReplaceExistingBones_IsValid && ImportBonesFromAsset_bRemoveObsoleteBones_IsValid && ImportBonesFromAsset_bSelectBones_IsValid && ImportBonesFromAsset_bSetupUndo_IsValid && ImportBonesFromAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:ImportBonesFromAsset", ImportBonesFromAsset_IsValid);
		ImportBones_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ImportBones");
		ImportBones_ParamsSize = NativeReflection.GetFunctionParamsSize(ImportBones_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ImportBones_InSkeleton_PropertyAddress, ImportBones_FunctionAddress, "InSkeleton");
		ImportBones_InSkeleton_Offset = NativeReflectionCached.GetPropertyOffset(ImportBones_FunctionAddress, "InSkeleton");
		ImportBones_InSkeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportBones_FunctionAddress, "InSkeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportBones_InNameSpace_PropertyAddress, ImportBones_FunctionAddress, "InNameSpace");
		ImportBones_InNameSpace_Offset = NativeReflectionCached.GetPropertyOffset(ImportBones_FunctionAddress, "InNameSpace");
		ImportBones_InNameSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportBones_FunctionAddress, "InNameSpace", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportBones_bReplaceExistingBones_PropertyAddress, ImportBones_FunctionAddress, "bReplaceExistingBones");
		ImportBones_bReplaceExistingBones_Offset = NativeReflectionCached.GetPropertyOffset(ImportBones_FunctionAddress, "bReplaceExistingBones");
		ImportBones_bReplaceExistingBones_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportBones_FunctionAddress, "bReplaceExistingBones", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportBones_bRemoveObsoleteBones_PropertyAddress, ImportBones_FunctionAddress, "bRemoveObsoleteBones");
		ImportBones_bRemoveObsoleteBones_Offset = NativeReflectionCached.GetPropertyOffset(ImportBones_FunctionAddress, "bRemoveObsoleteBones");
		ImportBones_bRemoveObsoleteBones_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportBones_FunctionAddress, "bRemoveObsoleteBones", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportBones_bSelectBones_PropertyAddress, ImportBones_FunctionAddress, "bSelectBones");
		ImportBones_bSelectBones_Offset = NativeReflectionCached.GetPropertyOffset(ImportBones_FunctionAddress, "bSelectBones");
		ImportBones_bSelectBones_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportBones_FunctionAddress, "bSelectBones", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportBones_bSetupUndo_PropertyAddress, ImportBones_FunctionAddress, "bSetupUndo");
		ImportBones_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(ImportBones_FunctionAddress, "bSetupUndo");
		ImportBones_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportBones_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportBones_bPrintPythonCommand_PropertyAddress, ImportBones_FunctionAddress, "bPrintPythonCommand");
		ImportBones_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(ImportBones_FunctionAddress, "bPrintPythonCommand");
		ImportBones_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportBones_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportBones_ReturnValue_PropertyAddress, ImportBones_FunctionAddress, "ReturnValue");
		ImportBones_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ImportBones_FunctionAddress, "ReturnValue");
		ImportBones_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportBones_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ImportBones_IsValid = ImportBones_FunctionAddress != IntPtr.Zero && ImportBones_InSkeleton_IsValid && ImportBones_InNameSpace_IsValid && ImportBones_bReplaceExistingBones_IsValid && ImportBones_bRemoveObsoleteBones_IsValid && ImportBones_bSelectBones_IsValid && ImportBones_bSetupUndo_IsValid && ImportBones_bPrintPythonCommand_IsValid && ImportBones_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:ImportBones", ImportBones_IsValid);
		GetHierarchy_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetHierarchy");
		GetHierarchy_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHierarchy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHierarchy_ReturnValue_PropertyAddress, GetHierarchy_FunctionAddress, "ReturnValue");
		GetHierarchy_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHierarchy_FunctionAddress, "ReturnValue");
		GetHierarchy_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHierarchy_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetHierarchy_IsValid = GetHierarchy_FunctionAddress != IntPtr.Zero && GetHierarchy_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:GetHierarchy", GetHierarchy_IsValid);
		GetControlSettings_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetControlSettings");
		GetControlSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetControlSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetControlSettings_InKey_PropertyAddress, GetControlSettings_FunctionAddress, "InKey");
		GetControlSettings_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetControlSettings_FunctionAddress, "InKey");
		GetControlSettings_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlSettings_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetControlSettings_ReturnValue_PropertyAddress, GetControlSettings_FunctionAddress, "ReturnValue");
		GetControlSettings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetControlSettings_FunctionAddress, "ReturnValue");
		GetControlSettings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlSettings_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetControlSettings_IsValid = GetControlSettings_FunctionAddress != IntPtr.Zero && GetControlSettings_InKey_IsValid && GetControlSettings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:GetControlSettings", GetControlSettings_IsValid);
		GeneratePythonCommands_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GeneratePythonCommands");
		GeneratePythonCommands_ParamsSize = NativeReflection.GetFunctionParamsSize(GeneratePythonCommands_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GeneratePythonCommands_ReturnValue_PropertyAddress, GeneratePythonCommands_FunctionAddress, "ReturnValue");
		GeneratePythonCommands_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GeneratePythonCommands_FunctionAddress, "ReturnValue");
		GeneratePythonCommands_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GeneratePythonCommands_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GeneratePythonCommands_IsValid = GeneratePythonCommands_FunctionAddress != IntPtr.Zero && GeneratePythonCommands_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:GeneratePythonCommands", GeneratePythonCommands_IsValid);
		ExportToText_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ExportToText");
		ExportToText_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportToText_InKeys_PropertyAddress, ExportToText_FunctionAddress, "InKeys");
		ExportToText_InKeys_Offset = NativeReflectionCached.GetPropertyOffset(ExportToText_FunctionAddress, "InKeys");
		ExportToText_InKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportToText_FunctionAddress, "InKeys", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportToText_ReturnValue_PropertyAddress, ExportToText_FunctionAddress, "ReturnValue");
		ExportToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExportToText_FunctionAddress, "ReturnValue");
		ExportToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportToText_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ExportToText_IsValid = ExportToText_FunctionAddress != IntPtr.Zero && ExportToText_InKeys_IsValid && ExportToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:ExportToText", ExportToText_IsValid);
		ExportSelectionToText_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ExportSelectionToText");
		ExportSelectionToText_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportSelectionToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportSelectionToText_ReturnValue_PropertyAddress, ExportSelectionToText_FunctionAddress, "ReturnValue");
		ExportSelectionToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExportSelectionToText_FunctionAddress, "ReturnValue");
		ExportSelectionToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportSelectionToText_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ExportSelectionToText_IsValid = ExportSelectionToText_FunctionAddress != IntPtr.Zero && ExportSelectionToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:ExportSelectionToText", ExportSelectionToText_IsValid);
		DuplicateElements_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DuplicateElements");
		DuplicateElements_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateElements_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateElements_InKeys_PropertyAddress, DuplicateElements_FunctionAddress, "InKeys");
		DuplicateElements_InKeys_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateElements_FunctionAddress, "InKeys");
		DuplicateElements_InKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateElements_FunctionAddress, "InKeys", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateElements_bSelectNewElements_PropertyAddress, DuplicateElements_FunctionAddress, "bSelectNewElements");
		DuplicateElements_bSelectNewElements_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateElements_FunctionAddress, "bSelectNewElements");
		DuplicateElements_bSelectNewElements_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateElements_FunctionAddress, "bSelectNewElements", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateElements_bSetupUndo_PropertyAddress, DuplicateElements_FunctionAddress, "bSetupUndo");
		DuplicateElements_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateElements_FunctionAddress, "bSetupUndo");
		DuplicateElements_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateElements_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateElements_bPrintPythonCommands_PropertyAddress, DuplicateElements_FunctionAddress, "bPrintPythonCommands");
		DuplicateElements_bPrintPythonCommands_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateElements_FunctionAddress, "bPrintPythonCommands");
		DuplicateElements_bPrintPythonCommands_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateElements_FunctionAddress, "bPrintPythonCommands", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateElements_ReturnValue_PropertyAddress, DuplicateElements_FunctionAddress, "ReturnValue");
		DuplicateElements_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateElements_FunctionAddress, "ReturnValue");
		DuplicateElements_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateElements_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		DuplicateElements_IsValid = DuplicateElements_FunctionAddress != IntPtr.Zero && DuplicateElements_InKeys_IsValid && DuplicateElements_bSelectNewElements_IsValid && DuplicateElements_bSetupUndo_IsValid && DuplicateElements_bPrintPythonCommands_IsValid && DuplicateElements_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:DuplicateElements", DuplicateElements_IsValid);
		DeselectElement_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DeselectElement");
		DeselectElement_ParamsSize = NativeReflection.GetFunctionParamsSize(DeselectElement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeselectElement_InKey_PropertyAddress, DeselectElement_FunctionAddress, "InKey");
		DeselectElement_InKey_Offset = NativeReflectionCached.GetPropertyOffset(DeselectElement_FunctionAddress, "InKey");
		DeselectElement_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(DeselectElement_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DeselectElement_ReturnValue_PropertyAddress, DeselectElement_FunctionAddress, "ReturnValue");
		DeselectElement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DeselectElement_FunctionAddress, "ReturnValue");
		DeselectElement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DeselectElement_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DeselectElement_IsValid = DeselectElement_FunctionAddress != IntPtr.Zero && DeselectElement_InKey_IsValid && DeselectElement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:DeselectElement", DeselectElement_IsValid);
		ClearSelection_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ClearSelection");
		ClearSelection_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearSelection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearSelection_ReturnValue_PropertyAddress, ClearSelection_FunctionAddress, "ReturnValue");
		ClearSelection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ClearSelection_FunctionAddress, "ReturnValue");
		ClearSelection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearSelection_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ClearSelection_IsValid = ClearSelection_FunctionAddress != IntPtr.Zero && ClearSelection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:ClearSelection", ClearSelection_IsValid);
		AddRigidBody_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddRigidBody");
		AddRigidBody_ParamsSize = NativeReflection.GetFunctionParamsSize(AddRigidBody_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddRigidBody_InName_PropertyAddress, AddRigidBody_FunctionAddress, "InName");
		AddRigidBody_InName_Offset = NativeReflectionCached.GetPropertyOffset(AddRigidBody_FunctionAddress, "InName");
		AddRigidBody_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRigidBody_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRigidBody_InParent_PropertyAddress, AddRigidBody_FunctionAddress, "InParent");
		AddRigidBody_InParent_Offset = NativeReflectionCached.GetPropertyOffset(AddRigidBody_FunctionAddress, "InParent");
		AddRigidBody_InParent_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRigidBody_FunctionAddress, "InParent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRigidBody_InSettings_PropertyAddress, AddRigidBody_FunctionAddress, "InSettings");
		AddRigidBody_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(AddRigidBody_FunctionAddress, "InSettings");
		AddRigidBody_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRigidBody_FunctionAddress, "InSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRigidBody_InLocalTransform_PropertyAddress, AddRigidBody_FunctionAddress, "InLocalTransform");
		AddRigidBody_InLocalTransform_Offset = NativeReflectionCached.GetPropertyOffset(AddRigidBody_FunctionAddress, "InLocalTransform");
		AddRigidBody_InLocalTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRigidBody_FunctionAddress, "InLocalTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRigidBody_bSetupUndo_PropertyAddress, AddRigidBody_FunctionAddress, "bSetupUndo");
		AddRigidBody_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(AddRigidBody_FunctionAddress, "bSetupUndo");
		AddRigidBody_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRigidBody_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRigidBody_bPrintPythonCommand_PropertyAddress, AddRigidBody_FunctionAddress, "bPrintPythonCommand");
		AddRigidBody_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddRigidBody_FunctionAddress, "bPrintPythonCommand");
		AddRigidBody_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRigidBody_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRigidBody_ReturnValue_PropertyAddress, AddRigidBody_FunctionAddress, "ReturnValue");
		AddRigidBody_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddRigidBody_FunctionAddress, "ReturnValue");
		AddRigidBody_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRigidBody_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AddRigidBody_IsValid = AddRigidBody_FunctionAddress != IntPtr.Zero && AddRigidBody_InName_IsValid && AddRigidBody_InParent_IsValid && AddRigidBody_InSettings_IsValid && AddRigidBody_InLocalTransform_IsValid && AddRigidBody_bSetupUndo_IsValid && AddRigidBody_bPrintPythonCommand_IsValid && AddRigidBody_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:AddRigidBody", AddRigidBody_IsValid);
		AddParent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddParent");
		AddParent_ParamsSize = NativeReflection.GetFunctionParamsSize(AddParent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddParent_InChild_PropertyAddress, AddParent_FunctionAddress, "InChild");
		AddParent_InChild_Offset = NativeReflectionCached.GetPropertyOffset(AddParent_FunctionAddress, "InChild");
		AddParent_InChild_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParent_FunctionAddress, "InChild", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParent_InParent_PropertyAddress, AddParent_FunctionAddress, "InParent");
		AddParent_InParent_Offset = NativeReflectionCached.GetPropertyOffset(AddParent_FunctionAddress, "InParent");
		AddParent_InParent_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParent_FunctionAddress, "InParent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParent_InWeight_PropertyAddress, AddParent_FunctionAddress, "InWeight");
		AddParent_InWeight_Offset = NativeReflectionCached.GetPropertyOffset(AddParent_FunctionAddress, "InWeight");
		AddParent_InWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParent_FunctionAddress, "InWeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParent_bMaintainGlobalTransform_PropertyAddress, AddParent_FunctionAddress, "bMaintainGlobalTransform");
		AddParent_bMaintainGlobalTransform_Offset = NativeReflectionCached.GetPropertyOffset(AddParent_FunctionAddress, "bMaintainGlobalTransform");
		AddParent_bMaintainGlobalTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParent_FunctionAddress, "bMaintainGlobalTransform", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParent_bSetupUndo_PropertyAddress, AddParent_FunctionAddress, "bSetupUndo");
		AddParent_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(AddParent_FunctionAddress, "bSetupUndo");
		AddParent_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParent_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParent_ReturnValue_PropertyAddress, AddParent_FunctionAddress, "ReturnValue");
		AddParent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddParent_FunctionAddress, "ReturnValue");
		AddParent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddParent_IsValid = AddParent_FunctionAddress != IntPtr.Zero && AddParent_InChild_IsValid && AddParent_InParent_IsValid && AddParent_InWeight_IsValid && AddParent_bMaintainGlobalTransform_IsValid && AddParent_bSetupUndo_IsValid && AddParent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:AddParent", AddParent_IsValid);
		AddNull_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddNull");
		AddNull_ParamsSize = NativeReflection.GetFunctionParamsSize(AddNull_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddNull_InName_PropertyAddress, AddNull_FunctionAddress, "InName");
		AddNull_InName_Offset = NativeReflectionCached.GetPropertyOffset(AddNull_FunctionAddress, "InName");
		AddNull_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNull_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNull_InParent_PropertyAddress, AddNull_FunctionAddress, "InParent");
		AddNull_InParent_Offset = NativeReflectionCached.GetPropertyOffset(AddNull_FunctionAddress, "InParent");
		AddNull_InParent_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNull_FunctionAddress, "InParent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNull_InTransform_PropertyAddress, AddNull_FunctionAddress, "InTransform");
		AddNull_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(AddNull_FunctionAddress, "InTransform");
		AddNull_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNull_FunctionAddress, "InTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNull_bTransformInGlobal_PropertyAddress, AddNull_FunctionAddress, "bTransformInGlobal");
		AddNull_bTransformInGlobal_Offset = NativeReflectionCached.GetPropertyOffset(AddNull_FunctionAddress, "bTransformInGlobal");
		AddNull_bTransformInGlobal_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNull_FunctionAddress, "bTransformInGlobal", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNull_bSetupUndo_PropertyAddress, AddNull_FunctionAddress, "bSetupUndo");
		AddNull_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(AddNull_FunctionAddress, "bSetupUndo");
		AddNull_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNull_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNull_bPrintPythonCommand_PropertyAddress, AddNull_FunctionAddress, "bPrintPythonCommand");
		AddNull_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddNull_FunctionAddress, "bPrintPythonCommand");
		AddNull_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNull_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNull_ReturnValue_PropertyAddress, AddNull_FunctionAddress, "ReturnValue");
		AddNull_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddNull_FunctionAddress, "ReturnValue");
		AddNull_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNull_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AddNull_IsValid = AddNull_FunctionAddress != IntPtr.Zero && AddNull_InName_IsValid && AddNull_InParent_IsValid && AddNull_InTransform_IsValid && AddNull_bTransformInGlobal_IsValid && AddNull_bSetupUndo_IsValid && AddNull_bPrintPythonCommand_IsValid && AddNull_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:AddNull", AddNull_IsValid);
		AddCurve_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddCurve");
		AddCurve_ParamsSize = NativeReflection.GetFunctionParamsSize(AddCurve_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddCurve_InName_PropertyAddress, AddCurve_FunctionAddress, "InName");
		AddCurve_InName_Offset = NativeReflectionCached.GetPropertyOffset(AddCurve_FunctionAddress, "InName");
		AddCurve_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCurve_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCurve_InValue_PropertyAddress, AddCurve_FunctionAddress, "InValue");
		AddCurve_InValue_Offset = NativeReflectionCached.GetPropertyOffset(AddCurve_FunctionAddress, "InValue");
		AddCurve_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCurve_FunctionAddress, "InValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCurve_bSetupUndo_PropertyAddress, AddCurve_FunctionAddress, "bSetupUndo");
		AddCurve_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(AddCurve_FunctionAddress, "bSetupUndo");
		AddCurve_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCurve_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCurve_bPrintPythonCommand_PropertyAddress, AddCurve_FunctionAddress, "bPrintPythonCommand");
		AddCurve_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddCurve_FunctionAddress, "bPrintPythonCommand");
		AddCurve_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCurve_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCurve_ReturnValue_PropertyAddress, AddCurve_FunctionAddress, "ReturnValue");
		AddCurve_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddCurve_FunctionAddress, "ReturnValue");
		AddCurve_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCurve_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AddCurve_IsValid = AddCurve_FunctionAddress != IntPtr.Zero && AddCurve_InName_IsValid && AddCurve_InValue_IsValid && AddCurve_bSetupUndo_IsValid && AddCurve_bPrintPythonCommand_IsValid && AddCurve_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:AddCurve", AddCurve_IsValid);
		AddControl_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddControl_ForBlueprint");
		AddControl_ParamsSize = NativeReflection.GetFunctionParamsSize(AddControl_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddControl_InName_PropertyAddress, AddControl_FunctionAddress, "InName");
		AddControl_InName_Offset = NativeReflectionCached.GetPropertyOffset(AddControl_FunctionAddress, "InName");
		AddControl_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddControl_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddControl_InParent_PropertyAddress, AddControl_FunctionAddress, "InParent");
		AddControl_InParent_Offset = NativeReflectionCached.GetPropertyOffset(AddControl_FunctionAddress, "InParent");
		AddControl_InParent_IsValid = NativeReflectionCached.ValidatePropertyClass(AddControl_FunctionAddress, "InParent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddControl_InSettings_PropertyAddress, AddControl_FunctionAddress, "InSettings");
		AddControl_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(AddControl_FunctionAddress, "InSettings");
		AddControl_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(AddControl_FunctionAddress, "InSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddControl_InValue_PropertyAddress, AddControl_FunctionAddress, "InValue");
		AddControl_InValue_Offset = NativeReflectionCached.GetPropertyOffset(AddControl_FunctionAddress, "InValue");
		AddControl_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddControl_FunctionAddress, "InValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddControl_bSetupUndo_PropertyAddress, AddControl_FunctionAddress, "bSetupUndo");
		AddControl_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(AddControl_FunctionAddress, "bSetupUndo");
		AddControl_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddControl_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddControl_ReturnValue_PropertyAddress, AddControl_FunctionAddress, "ReturnValue");
		AddControl_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddControl_FunctionAddress, "ReturnValue");
		AddControl_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddControl_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AddControl_IsValid = AddControl_FunctionAddress != IntPtr.Zero && AddControl_InName_IsValid && AddControl_InParent_IsValid && AddControl_InSettings_IsValid && AddControl_InValue_IsValid && AddControl_bSetupUndo_IsValid && AddControl_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:AddControl_ForBlueprint", AddControl_IsValid);
		AddBone_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddBone");
		AddBone_ParamsSize = NativeReflection.GetFunctionParamsSize(AddBone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddBone_InName_PropertyAddress, AddBone_FunctionAddress, "InName");
		AddBone_InName_Offset = NativeReflectionCached.GetPropertyOffset(AddBone_FunctionAddress, "InName");
		AddBone_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBone_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBone_InParent_PropertyAddress, AddBone_FunctionAddress, "InParent");
		AddBone_InParent_Offset = NativeReflectionCached.GetPropertyOffset(AddBone_FunctionAddress, "InParent");
		AddBone_InParent_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBone_FunctionAddress, "InParent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBone_InTransform_PropertyAddress, AddBone_FunctionAddress, "InTransform");
		AddBone_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(AddBone_FunctionAddress, "InTransform");
		AddBone_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBone_FunctionAddress, "InTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBone_bTransformInGlobal_PropertyAddress, AddBone_FunctionAddress, "bTransformInGlobal");
		AddBone_bTransformInGlobal_Offset = NativeReflectionCached.GetPropertyOffset(AddBone_FunctionAddress, "bTransformInGlobal");
		AddBone_bTransformInGlobal_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBone_FunctionAddress, "bTransformInGlobal", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBone_InBoneType_PropertyAddress, AddBone_FunctionAddress, "InBoneType");
		AddBone_InBoneType_Offset = NativeReflectionCached.GetPropertyOffset(AddBone_FunctionAddress, "InBoneType");
		AddBone_InBoneType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBone_FunctionAddress, "InBoneType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBone_bSetupUndo_PropertyAddress, AddBone_FunctionAddress, "bSetupUndo");
		AddBone_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(AddBone_FunctionAddress, "bSetupUndo");
		AddBone_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBone_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBone_bPrintPythonCommand_PropertyAddress, AddBone_FunctionAddress, "bPrintPythonCommand");
		AddBone_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddBone_FunctionAddress, "bPrintPythonCommand");
		AddBone_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBone_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBone_ReturnValue_PropertyAddress, AddBone_FunctionAddress, "ReturnValue");
		AddBone_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddBone_FunctionAddress, "ReturnValue");
		AddBone_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBone_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AddBone_IsValid = AddBone_FunctionAddress != IntPtr.Zero && AddBone_InName_IsValid && AddBone_InParent_IsValid && AddBone_InTransform_IsValid && AddBone_bTransformInGlobal_IsValid && AddBone_InBoneType_IsValid && AddBone_bSetupUndo_IsValid && AddBone_bPrintPythonCommand_IsValid && AddBone_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchyController:AddBone", AddBone_IsValid);
	}
}
