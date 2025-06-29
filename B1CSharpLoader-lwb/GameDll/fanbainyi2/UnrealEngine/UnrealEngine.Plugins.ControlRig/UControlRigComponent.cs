using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/ControlRig.ControlRigComponent", "ControlRig", UnrealModuleType.EnginePlugin)]
public class UControlRigComponent : UPrimitiveComponent
{
	private static bool OnPreInitializeDelegate_IsValid;

	private static int OnPreInitializeDelegate_Offset;

	private FControlRigComponentDelegate OnPreInitializeDelegate_DelegateCached;

	private static bool OnPostInitializeDelegate_IsValid;

	private static int OnPostInitializeDelegate_Offset;

	private FControlRigComponentDelegate OnPostInitializeDelegate_DelegateCached;

	private static bool OnPreSetupDelegate_IsValid;

	private static int OnPreSetupDelegate_Offset;

	private FControlRigComponentDelegate OnPreSetupDelegate_DelegateCached;

	private static bool OnPostSetupDelegate_IsValid;

	private static int OnPostSetupDelegate_Offset;

	private FControlRigComponentDelegate OnPostSetupDelegate_DelegateCached;

	private static bool OnPreForwardsSolveDelegate_IsValid;

	private static int OnPreForwardsSolveDelegate_Offset;

	private FControlRigComponentDelegate OnPreForwardsSolveDelegate_DelegateCached;

	private static bool OnPostForwardsSolveDelegate_IsValid;

	private static int OnPostForwardsSolveDelegate_Offset;

	private FControlRigComponentDelegate OnPostForwardsSolveDelegate_DelegateCached;

	private static bool Update_IsValid;

	private static IntPtr Update_FunctionAddress;

	private static int Update_ParamsSize;

	private static bool Update_DeltaTime_IsValid;

	private static FFieldAddress Update_DeltaTime_PropertyAddress;

	private static int Update_DeltaTime_Offset;

	private static bool SetMappedElements_IsValid;

	private static IntPtr SetMappedElements_FunctionAddress;

	private static int SetMappedElements_ParamsSize;

	private static bool SetMappedElements_NewMappedElements_IsValid;

	private static FFieldAddress SetMappedElements_NewMappedElements_PropertyAddress;

	private static int SetMappedElements_NewMappedElements_Offset;

	private static bool SetInitialSpaceTransform_IsValid;

	private static IntPtr SetInitialSpaceTransform_FunctionAddress;

	private static int SetInitialSpaceTransform_ParamsSize;

	private static bool SetInitialSpaceTransform_SpaceName_IsValid;

	private static FFieldAddress SetInitialSpaceTransform_SpaceName_PropertyAddress;

	private static int SetInitialSpaceTransform_SpaceName_Offset;

	private static bool SetInitialSpaceTransform_InitialTransform_IsValid;

	private static FFieldAddress SetInitialSpaceTransform_InitialTransform_PropertyAddress;

	private static int SetInitialSpaceTransform_InitialTransform_Offset;

	private static bool SetInitialSpaceTransform_Space_IsValid;

	private static FFieldAddress SetInitialSpaceTransform_Space_PropertyAddress;

	private static int SetInitialSpaceTransform_Space_Offset;

	private static bool SetInitialBoneTransform_IsValid;

	private static IntPtr SetInitialBoneTransform_FunctionAddress;

	private static int SetInitialBoneTransform_ParamsSize;

	private static bool SetInitialBoneTransform_BoneName_IsValid;

	private static FFieldAddress SetInitialBoneTransform_BoneName_PropertyAddress;

	private static int SetInitialBoneTransform_BoneName_Offset;

	private static bool SetInitialBoneTransform_InitialTransform_IsValid;

	private static FFieldAddress SetInitialBoneTransform_InitialTransform_PropertyAddress;

	private static int SetInitialBoneTransform_InitialTransform_Offset;

	private static bool SetInitialBoneTransform_Space_IsValid;

	private static FFieldAddress SetInitialBoneTransform_Space_PropertyAddress;

	private static int SetInitialBoneTransform_Space_Offset;

	private static bool SetInitialBoneTransform_bPropagateToChildren_IsValid;

	private static FFieldAddress SetInitialBoneTransform_bPropagateToChildren_PropertyAddress;

	private static int SetInitialBoneTransform_bPropagateToChildren_Offset;

	private static bool SetControlVector2D_IsValid;

	private static IntPtr SetControlVector2D_FunctionAddress;

	private static int SetControlVector2D_ParamsSize;

	private static bool SetControlVector2D_ControlName_IsValid;

	private static FFieldAddress SetControlVector2D_ControlName_PropertyAddress;

	private static int SetControlVector2D_ControlName_Offset;

	private static bool SetControlVector2D_Value_IsValid;

	private static FFieldAddress SetControlVector2D_Value_PropertyAddress;

	private static int SetControlVector2D_Value_Offset;

	private static bool SetControlTransform_IsValid;

	private static IntPtr SetControlTransform_FunctionAddress;

	private static int SetControlTransform_ParamsSize;

	private static bool SetControlTransform_ControlName_IsValid;

	private static FFieldAddress SetControlTransform_ControlName_PropertyAddress;

	private static int SetControlTransform_ControlName_Offset;

	private static bool SetControlTransform_Value_IsValid;

	private static FFieldAddress SetControlTransform_Value_PropertyAddress;

	private static int SetControlTransform_Value_Offset;

	private static bool SetControlTransform_Space_IsValid;

	private static FFieldAddress SetControlTransform_Space_PropertyAddress;

	private static int SetControlTransform_Space_Offset;

	private static bool SetControlScale_IsValid;

	private static IntPtr SetControlScale_FunctionAddress;

	private static int SetControlScale_ParamsSize;

	private static bool SetControlScale_ControlName_IsValid;

	private static FFieldAddress SetControlScale_ControlName_PropertyAddress;

	private static int SetControlScale_ControlName_Offset;

	private static bool SetControlScale_Value_IsValid;

	private static FFieldAddress SetControlScale_Value_PropertyAddress;

	private static int SetControlScale_Value_Offset;

	private static bool SetControlScale_Space_IsValid;

	private static FFieldAddress SetControlScale_Space_PropertyAddress;

	private static int SetControlScale_Space_Offset;

	private static bool SetControlRotator_IsValid;

	private static IntPtr SetControlRotator_FunctionAddress;

	private static int SetControlRotator_ParamsSize;

	private static bool SetControlRotator_ControlName_IsValid;

	private static FFieldAddress SetControlRotator_ControlName_PropertyAddress;

	private static int SetControlRotator_ControlName_Offset;

	private static bool SetControlRotator_Value_IsValid;

	private static FFieldAddress SetControlRotator_Value_PropertyAddress;

	private static int SetControlRotator_Value_Offset;

	private static bool SetControlRotator_Space_IsValid;

	private static FFieldAddress SetControlRotator_Space_PropertyAddress;

	private static int SetControlRotator_Space_Offset;

	private static bool SetControlPosition_IsValid;

	private static IntPtr SetControlPosition_FunctionAddress;

	private static int SetControlPosition_ParamsSize;

	private static bool SetControlPosition_ControlName_IsValid;

	private static FFieldAddress SetControlPosition_ControlName_PropertyAddress;

	private static int SetControlPosition_ControlName_Offset;

	private static bool SetControlPosition_Value_IsValid;

	private static FFieldAddress SetControlPosition_Value_PropertyAddress;

	private static int SetControlPosition_Value_Offset;

	private static bool SetControlPosition_Space_IsValid;

	private static FFieldAddress SetControlPosition_Space_PropertyAddress;

	private static int SetControlPosition_Space_Offset;

	private static bool SetControlOffset_IsValid;

	private static IntPtr SetControlOffset_FunctionAddress;

	private static int SetControlOffset_ParamsSize;

	private static bool SetControlOffset_ControlName_IsValid;

	private static FFieldAddress SetControlOffset_ControlName_PropertyAddress;

	private static int SetControlOffset_ControlName_Offset;

	private static bool SetControlOffset_OffsetTransform_IsValid;

	private static FFieldAddress SetControlOffset_OffsetTransform_PropertyAddress;

	private static int SetControlOffset_OffsetTransform_Offset;

	private static bool SetControlOffset_Space_IsValid;

	private static FFieldAddress SetControlOffset_Space_PropertyAddress;

	private static int SetControlOffset_Space_Offset;

	private static bool SetControlInt_IsValid;

	private static IntPtr SetControlInt_FunctionAddress;

	private static int SetControlInt_ParamsSize;

	private static bool SetControlInt_ControlName_IsValid;

	private static FFieldAddress SetControlInt_ControlName_PropertyAddress;

	private static int SetControlInt_ControlName_Offset;

	private static bool SetControlInt_Value_IsValid;

	private static FFieldAddress SetControlInt_Value_PropertyAddress;

	private static int SetControlInt_Value_Offset;

	private static bool SetControlFloat_IsValid;

	private static IntPtr SetControlFloat_FunctionAddress;

	private static int SetControlFloat_ParamsSize;

	private static bool SetControlFloat_ControlName_IsValid;

	private static FFieldAddress SetControlFloat_ControlName_PropertyAddress;

	private static int SetControlFloat_ControlName_Offset;

	private static bool SetControlFloat_Value_IsValid;

	private static FFieldAddress SetControlFloat_Value_PropertyAddress;

	private static int SetControlFloat_Value_Offset;

	private static bool SetControlBool_IsValid;

	private static IntPtr SetControlBool_FunctionAddress;

	private static int SetControlBool_ParamsSize;

	private static bool SetControlBool_ControlName_IsValid;

	private static FFieldAddress SetControlBool_ControlName_PropertyAddress;

	private static int SetControlBool_ControlName_Offset;

	private static bool SetControlBool_Value_IsValid;

	private static FFieldAddress SetControlBool_Value_PropertyAddress;

	private static int SetControlBool_Value_Offset;

	private static bool SetBoneTransform_IsValid;

	private static IntPtr SetBoneTransform_FunctionAddress;

	private static int SetBoneTransform_ParamsSize;

	private static bool SetBoneTransform_BoneName_IsValid;

	private static FFieldAddress SetBoneTransform_BoneName_PropertyAddress;

	private static int SetBoneTransform_BoneName_Offset;

	private static bool SetBoneTransform_Transform_IsValid;

	private static FFieldAddress SetBoneTransform_Transform_PropertyAddress;

	private static int SetBoneTransform_Transform_Offset;

	private static bool SetBoneTransform_Space_IsValid;

	private static FFieldAddress SetBoneTransform_Space_PropertyAddress;

	private static int SetBoneTransform_Space_Offset;

	private static bool SetBoneTransform_Weight_IsValid;

	private static FFieldAddress SetBoneTransform_Weight_PropertyAddress;

	private static int SetBoneTransform_Weight_Offset;

	private static bool SetBoneTransform_bPropagateToChildren_IsValid;

	private static FFieldAddress SetBoneTransform_bPropagateToChildren_PropertyAddress;

	private static int SetBoneTransform_bPropagateToChildren_Offset;

	private static bool SetBoneInitialTransformsFromSkeletalMesh_IsValid;

	private static IntPtr SetBoneInitialTransformsFromSkeletalMesh_FunctionAddress;

	private static int SetBoneInitialTransformsFromSkeletalMesh_ParamsSize;

	private static bool SetBoneInitialTransformsFromSkeletalMesh_InSkeletalMesh_IsValid;

	private static FFieldAddress SetBoneInitialTransformsFromSkeletalMesh_InSkeletalMesh_PropertyAddress;

	private static int SetBoneInitialTransformsFromSkeletalMesh_InSkeletalMesh_Offset;

	private static bool OnPreSetup_IsValid;

	private IntPtr OnPreSetup_InstanceFunctionAddress;

	private static IntPtr OnPreSetup_FunctionAddress;

	private static int OnPreSetup_ParamsSize;

	private static bool OnPreSetup_Component_IsValid;

	private static FFieldAddress OnPreSetup_Component_PropertyAddress;

	private static int OnPreSetup_Component_Offset;

	private static bool OnPreInitialize_IsValid;

	private IntPtr OnPreInitialize_InstanceFunctionAddress;

	private static IntPtr OnPreInitialize_FunctionAddress;

	private static int OnPreInitialize_ParamsSize;

	private static bool OnPreInitialize_Component_IsValid;

	private static FFieldAddress OnPreInitialize_Component_PropertyAddress;

	private static int OnPreInitialize_Component_Offset;

	private static bool OnPreForwardsSolve_IsValid;

	private IntPtr OnPreForwardsSolve_InstanceFunctionAddress;

	private static IntPtr OnPreForwardsSolve_FunctionAddress;

	private static int OnPreForwardsSolve_ParamsSize;

	private static bool OnPreForwardsSolve_Component_IsValid;

	private static FFieldAddress OnPreForwardsSolve_Component_PropertyAddress;

	private static int OnPreForwardsSolve_Component_Offset;

	private static bool OnPostSetup_IsValid;

	private IntPtr OnPostSetup_InstanceFunctionAddress;

	private static IntPtr OnPostSetup_FunctionAddress;

	private static int OnPostSetup_ParamsSize;

	private static bool OnPostSetup_Component_IsValid;

	private static FFieldAddress OnPostSetup_Component_PropertyAddress;

	private static int OnPostSetup_Component_Offset;

	private static bool OnPostInitialize_IsValid;

	private IntPtr OnPostInitialize_InstanceFunctionAddress;

	private static IntPtr OnPostInitialize_FunctionAddress;

	private static int OnPostInitialize_ParamsSize;

	private static bool OnPostInitialize_Component_IsValid;

	private static FFieldAddress OnPostInitialize_Component_PropertyAddress;

	private static int OnPostInitialize_Component_Offset;

	private static bool OnPostForwardsSolve_IsValid;

	private IntPtr OnPostForwardsSolve_InstanceFunctionAddress;

	private static IntPtr OnPostForwardsSolve_FunctionAddress;

	private static int OnPostForwardsSolve_ParamsSize;

	private static bool OnPostForwardsSolve_Component_IsValid;

	private static FFieldAddress OnPostForwardsSolve_Component_PropertyAddress;

	private static int OnPostForwardsSolve_Component_Offset;

	private static bool Initialize_IsValid;

	private static IntPtr Initialize_FunctionAddress;

	private static int Initialize_ParamsSize;

	private static bool GetSpaceTransform_IsValid;

	private static IntPtr GetSpaceTransform_FunctionAddress;

	private static int GetSpaceTransform_ParamsSize;

	private static bool GetSpaceTransform_SpaceName_IsValid;

	private static FFieldAddress GetSpaceTransform_SpaceName_PropertyAddress;

	private static int GetSpaceTransform_SpaceName_Offset;

	private static bool GetSpaceTransform_Space_IsValid;

	private static FFieldAddress GetSpaceTransform_Space_PropertyAddress;

	private static int GetSpaceTransform_Space_Offset;

	private static bool GetSpaceTransform_ReturnValue_IsValid;

	private static FFieldAddress GetSpaceTransform_ReturnValue_PropertyAddress;

	private static int GetSpaceTransform_ReturnValue_Offset;

	private static bool GetInitialSpaceTransform_IsValid;

	private static IntPtr GetInitialSpaceTransform_FunctionAddress;

	private static int GetInitialSpaceTransform_ParamsSize;

	private static bool GetInitialSpaceTransform_SpaceName_IsValid;

	private static FFieldAddress GetInitialSpaceTransform_SpaceName_PropertyAddress;

	private static int GetInitialSpaceTransform_SpaceName_Offset;

	private static bool GetInitialSpaceTransform_Space_IsValid;

	private static FFieldAddress GetInitialSpaceTransform_Space_PropertyAddress;

	private static int GetInitialSpaceTransform_Space_Offset;

	private static bool GetInitialSpaceTransform_ReturnValue_IsValid;

	private static FFieldAddress GetInitialSpaceTransform_ReturnValue_PropertyAddress;

	private static int GetInitialSpaceTransform_ReturnValue_Offset;

	private static bool GetInitialBoneTransform_IsValid;

	private static IntPtr GetInitialBoneTransform_FunctionAddress;

	private static int GetInitialBoneTransform_ParamsSize;

	private static bool GetInitialBoneTransform_BoneName_IsValid;

	private static FFieldAddress GetInitialBoneTransform_BoneName_PropertyAddress;

	private static int GetInitialBoneTransform_BoneName_Offset;

	private static bool GetInitialBoneTransform_Space_IsValid;

	private static FFieldAddress GetInitialBoneTransform_Space_PropertyAddress;

	private static int GetInitialBoneTransform_Space_Offset;

	private static bool GetInitialBoneTransform_ReturnValue_IsValid;

	private static FFieldAddress GetInitialBoneTransform_ReturnValue_PropertyAddress;

	private static int GetInitialBoneTransform_ReturnValue_Offset;

	private static bool GetElementNames_IsValid;

	private static IntPtr GetElementNames_FunctionAddress;

	private static int GetElementNames_ParamsSize;

	private static bool GetElementNames_ElementType_IsValid;

	private static FFieldAddress GetElementNames_ElementType_PropertyAddress;

	private static int GetElementNames_ElementType_Offset;

	private static bool GetElementNames_ReturnValue_IsValid;

	private static FFieldAddress GetElementNames_ReturnValue_PropertyAddress;

	private static int GetElementNames_ReturnValue_Offset;

	private static bool GetControlVector2D_IsValid;

	private static IntPtr GetControlVector2D_FunctionAddress;

	private static int GetControlVector2D_ParamsSize;

	private static bool GetControlVector2D_ControlName_IsValid;

	private static FFieldAddress GetControlVector2D_ControlName_PropertyAddress;

	private static int GetControlVector2D_ControlName_Offset;

	private static bool GetControlVector2D_ReturnValue_IsValid;

	private static FFieldAddress GetControlVector2D_ReturnValue_PropertyAddress;

	private static int GetControlVector2D_ReturnValue_Offset;

	private static bool GetControlTransform_IsValid;

	private static IntPtr GetControlTransform_FunctionAddress;

	private static int GetControlTransform_ParamsSize;

	private static bool GetControlTransform_ControlName_IsValid;

	private static FFieldAddress GetControlTransform_ControlName_PropertyAddress;

	private static int GetControlTransform_ControlName_Offset;

	private static bool GetControlTransform_Space_IsValid;

	private static FFieldAddress GetControlTransform_Space_PropertyAddress;

	private static int GetControlTransform_Space_Offset;

	private static bool GetControlTransform_ReturnValue_IsValid;

	private static FFieldAddress GetControlTransform_ReturnValue_PropertyAddress;

	private static int GetControlTransform_ReturnValue_Offset;

	private static bool GetControlScale_IsValid;

	private static IntPtr GetControlScale_FunctionAddress;

	private static int GetControlScale_ParamsSize;

	private static bool GetControlScale_ControlName_IsValid;

	private static FFieldAddress GetControlScale_ControlName_PropertyAddress;

	private static int GetControlScale_ControlName_Offset;

	private static bool GetControlScale_Space_IsValid;

	private static FFieldAddress GetControlScale_Space_PropertyAddress;

	private static int GetControlScale_Space_Offset;

	private static bool GetControlScale_ReturnValue_IsValid;

	private static FFieldAddress GetControlScale_ReturnValue_PropertyAddress;

	private static int GetControlScale_ReturnValue_Offset;

	private static bool GetControlRotator_IsValid;

	private static IntPtr GetControlRotator_FunctionAddress;

	private static int GetControlRotator_ParamsSize;

	private static bool GetControlRotator_ControlName_IsValid;

	private static FFieldAddress GetControlRotator_ControlName_PropertyAddress;

	private static int GetControlRotator_ControlName_Offset;

	private static bool GetControlRotator_Space_IsValid;

	private static FFieldAddress GetControlRotator_Space_PropertyAddress;

	private static int GetControlRotator_Space_Offset;

	private static bool GetControlRotator_ReturnValue_IsValid;

	private static FFieldAddress GetControlRotator_ReturnValue_PropertyAddress;

	private static int GetControlRotator_ReturnValue_Offset;

	private static bool GetControlRig_IsValid;

	private static IntPtr GetControlRig_FunctionAddress;

	private static int GetControlRig_ParamsSize;

	private static bool GetControlRig_ReturnValue_IsValid;

	private static FFieldAddress GetControlRig_ReturnValue_PropertyAddress;

	private static int GetControlRig_ReturnValue_Offset;

	private static bool GetControlPosition_IsValid;

	private static IntPtr GetControlPosition_FunctionAddress;

	private static int GetControlPosition_ParamsSize;

	private static bool GetControlPosition_ControlName_IsValid;

	private static FFieldAddress GetControlPosition_ControlName_PropertyAddress;

	private static int GetControlPosition_ControlName_Offset;

	private static bool GetControlPosition_Space_IsValid;

	private static FFieldAddress GetControlPosition_Space_PropertyAddress;

	private static int GetControlPosition_Space_Offset;

	private static bool GetControlPosition_ReturnValue_IsValid;

	private static FFieldAddress GetControlPosition_ReturnValue_PropertyAddress;

	private static int GetControlPosition_ReturnValue_Offset;

	private static bool GetControlOffset_IsValid;

	private static IntPtr GetControlOffset_FunctionAddress;

	private static int GetControlOffset_ParamsSize;

	private static bool GetControlOffset_ControlName_IsValid;

	private static FFieldAddress GetControlOffset_ControlName_PropertyAddress;

	private static int GetControlOffset_ControlName_Offset;

	private static bool GetControlOffset_Space_IsValid;

	private static FFieldAddress GetControlOffset_Space_PropertyAddress;

	private static int GetControlOffset_Space_Offset;

	private static bool GetControlOffset_ReturnValue_IsValid;

	private static FFieldAddress GetControlOffset_ReturnValue_PropertyAddress;

	private static int GetControlOffset_ReturnValue_Offset;

	private static bool GetControlInt_IsValid;

	private static IntPtr GetControlInt_FunctionAddress;

	private static int GetControlInt_ParamsSize;

	private static bool GetControlInt_ControlName_IsValid;

	private static FFieldAddress GetControlInt_ControlName_PropertyAddress;

	private static int GetControlInt_ControlName_Offset;

	private static bool GetControlInt_ReturnValue_IsValid;

	private static FFieldAddress GetControlInt_ReturnValue_PropertyAddress;

	private static int GetControlInt_ReturnValue_Offset;

	private static bool GetControlFloat_IsValid;

	private static IntPtr GetControlFloat_FunctionAddress;

	private static int GetControlFloat_ParamsSize;

	private static bool GetControlFloat_ControlName_IsValid;

	private static FFieldAddress GetControlFloat_ControlName_PropertyAddress;

	private static int GetControlFloat_ControlName_Offset;

	private static bool GetControlFloat_ReturnValue_IsValid;

	private static FFieldAddress GetControlFloat_ReturnValue_PropertyAddress;

	private static int GetControlFloat_ReturnValue_Offset;

	private static bool GetControlBool_IsValid;

	private static IntPtr GetControlBool_FunctionAddress;

	private static int GetControlBool_ParamsSize;

	private static bool GetControlBool_ControlName_IsValid;

	private static FFieldAddress GetControlBool_ControlName_PropertyAddress;

	private static int GetControlBool_ControlName_Offset;

	private static bool GetControlBool_ReturnValue_IsValid;

	private static FFieldAddress GetControlBool_ReturnValue_PropertyAddress;

	private static int GetControlBool_ReturnValue_Offset;

	private static bool GetBoneTransform_IsValid;

	private static IntPtr GetBoneTransform_FunctionAddress;

	private static int GetBoneTransform_ParamsSize;

	private static bool GetBoneTransform_BoneName_IsValid;

	private static FFieldAddress GetBoneTransform_BoneName_PropertyAddress;

	private static int GetBoneTransform_BoneName_Offset;

	private static bool GetBoneTransform_Space_IsValid;

	private static FFieldAddress GetBoneTransform_Space_PropertyAddress;

	private static int GetBoneTransform_Space_Offset;

	private static bool GetBoneTransform_ReturnValue_IsValid;

	private static FFieldAddress GetBoneTransform_ReturnValue_PropertyAddress;

	private static int GetBoneTransform_ReturnValue_Offset;

	private static bool GetAbsoluteTime_IsValid;

	private static IntPtr GetAbsoluteTime_FunctionAddress;

	private static int GetAbsoluteTime_ParamsSize;

	private static bool GetAbsoluteTime_ReturnValue_IsValid;

	private static FFieldAddress GetAbsoluteTime_ReturnValue_PropertyAddress;

	private static int GetAbsoluteTime_ReturnValue_Offset;

	private static bool DoesElementExist_IsValid;

	private static IntPtr DoesElementExist_FunctionAddress;

	private static int DoesElementExist_ParamsSize;

	private static bool DoesElementExist_Name_IsValid;

	private static FFieldAddress DoesElementExist_Name_PropertyAddress;

	private static int DoesElementExist_Name_Offset;

	private static bool DoesElementExist_ElementType_IsValid;

	private static FFieldAddress DoesElementExist_ElementType_PropertyAddress;

	private static int DoesElementExist_ElementType_Offset;

	private static bool DoesElementExist_ReturnValue_IsValid;

	private static FFieldAddress DoesElementExist_ReturnValue_PropertyAddress;

	private static int DoesElementExist_ReturnValue_Offset;

	private static bool ClearMappedElements_IsValid;

	private static IntPtr ClearMappedElements_FunctionAddress;

	private static int ClearMappedElements_ParamsSize;

	private static bool CanExecute_IsValid;

	private static IntPtr CanExecute_FunctionAddress;

	private static int CanExecute_ParamsSize;

	private static bool CanExecute_ReturnValue_IsValid;

	private static FFieldAddress CanExecute_ReturnValue_PropertyAddress;

	private static int CanExecute_ReturnValue_Offset;

	private static bool AddMappedSkeletalMesh_IsValid;

	private static IntPtr AddMappedSkeletalMesh_FunctionAddress;

	private static int AddMappedSkeletalMesh_ParamsSize;

	private static bool AddMappedSkeletalMesh_SkeletalMeshComponent_IsValid;

	private static FFieldAddress AddMappedSkeletalMesh_SkeletalMeshComponent_PropertyAddress;

	private static int AddMappedSkeletalMesh_SkeletalMeshComponent_Offset;

	private static bool AddMappedSkeletalMesh_Bones_IsValid;

	private static FFieldAddress AddMappedSkeletalMesh_Bones_PropertyAddress;

	private static int AddMappedSkeletalMesh_Bones_Offset;

	private static bool AddMappedSkeletalMesh_Curves_IsValid;

	private static FFieldAddress AddMappedSkeletalMesh_Curves_PropertyAddress;

	private static int AddMappedSkeletalMesh_Curves_Offset;

	private static bool AddMappedElements_IsValid;

	private static IntPtr AddMappedElements_FunctionAddress;

	private static int AddMappedElements_ParamsSize;

	private static bool AddMappedElements_NewMappedElements_IsValid;

	private static FFieldAddress AddMappedElements_NewMappedElements_PropertyAddress;

	private static int AddMappedElements_NewMappedElements_Offset;

	private static bool AddMappedComponents_IsValid;

	private static IntPtr AddMappedComponents_FunctionAddress;

	private static int AddMappedComponents_ParamsSize;

	private static bool AddMappedComponents_Components_IsValid;

	private static FFieldAddress AddMappedComponents_Components_PropertyAddress;

	private static int AddMappedComponents_Components_Offset;

	private static bool AddMappedCompleteSkeletalMesh_IsValid;

	private static IntPtr AddMappedCompleteSkeletalMesh_FunctionAddress;

	private static int AddMappedCompleteSkeletalMesh_ParamsSize;

	private static bool AddMappedCompleteSkeletalMesh_SkeletalMeshComponent_IsValid;

	private static FFieldAddress AddMappedCompleteSkeletalMesh_SkeletalMeshComponent_PropertyAddress;

	private static int AddMappedCompleteSkeletalMesh_SkeletalMeshComponent_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:OnPreInitializeDelegate")]
	public FControlRigComponentDelegate OnPreInitializeDelegate
	{
		get
		{
			CheckDestroyed();
			if (!OnPreInitializeDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigComponent:OnPreInitializeDelegate");
				return new FControlRigComponentDelegate();
			}
			if (OnPreInitializeDelegate_DelegateCached == null)
			{
				OnPreInitializeDelegate_DelegateCached = new FControlRigComponentDelegate();
				OnPreInitializeDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPreInitializeDelegate_Offset));
			}
			return OnPreInitializeDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:OnPostInitializeDelegate")]
	public FControlRigComponentDelegate OnPostInitializeDelegate
	{
		get
		{
			CheckDestroyed();
			if (!OnPostInitializeDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigComponent:OnPostInitializeDelegate");
				return new FControlRigComponentDelegate();
			}
			if (OnPostInitializeDelegate_DelegateCached == null)
			{
				OnPostInitializeDelegate_DelegateCached = new FControlRigComponentDelegate();
				OnPostInitializeDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPostInitializeDelegate_Offset));
			}
			return OnPostInitializeDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:OnPreSetupDelegate")]
	public FControlRigComponentDelegate OnPreSetupDelegate
	{
		get
		{
			CheckDestroyed();
			if (!OnPreSetupDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigComponent:OnPreSetupDelegate");
				return new FControlRigComponentDelegate();
			}
			if (OnPreSetupDelegate_DelegateCached == null)
			{
				OnPreSetupDelegate_DelegateCached = new FControlRigComponentDelegate();
				OnPreSetupDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPreSetupDelegate_Offset));
			}
			return OnPreSetupDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:OnPostSetupDelegate")]
	public FControlRigComponentDelegate OnPostSetupDelegate
	{
		get
		{
			CheckDestroyed();
			if (!OnPostSetupDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigComponent:OnPostSetupDelegate");
				return new FControlRigComponentDelegate();
			}
			if (OnPostSetupDelegate_DelegateCached == null)
			{
				OnPostSetupDelegate_DelegateCached = new FControlRigComponentDelegate();
				OnPostSetupDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPostSetupDelegate_Offset));
			}
			return OnPostSetupDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:OnPreForwardsSolveDelegate")]
	public FControlRigComponentDelegate OnPreForwardsSolveDelegate
	{
		get
		{
			CheckDestroyed();
			if (!OnPreForwardsSolveDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigComponent:OnPreForwardsSolveDelegate");
				return new FControlRigComponentDelegate();
			}
			if (OnPreForwardsSolveDelegate_DelegateCached == null)
			{
				OnPreForwardsSolveDelegate_DelegateCached = new FControlRigComponentDelegate();
				OnPreForwardsSolveDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPreForwardsSolveDelegate_Offset));
			}
			return OnPreForwardsSolveDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:OnPostForwardsSolveDelegate")]
	public FControlRigComponentDelegate OnPostForwardsSolveDelegate
	{
		get
		{
			CheckDestroyed();
			if (!OnPostForwardsSolveDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigComponent:OnPostForwardsSolveDelegate");
				return new FControlRigComponentDelegate();
			}
			if (OnPostForwardsSolveDelegate_DelegateCached == null)
			{
				OnPostForwardsSolveDelegate_DelegateCached = new FControlRigComponentDelegate();
				OnPostForwardsSolveDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPostForwardsSolveDelegate_Offset));
			}
			return OnPostForwardsSolveDelegate_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:Update")]
	public unsafe void Update(float DeltaTime = 0f)
	{
		CheckDestroyed();
		if (!Update_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:Update");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Update_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Update_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Update_DeltaTime_Offset), 0, Update_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, Update_FunctionAddress, intPtr, Update_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:SetMappedElements")]
	public unsafe void SetMappedElements(List<FControlRigComponentMappedElement> NewMappedElements)
	{
		CheckDestroyed();
		if (!SetMappedElements_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:SetMappedElements");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMappedElements_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMappedElements_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FControlRigComponentMappedElement>(1, SetMappedElements_NewMappedElements_PropertyAddress, CachedMarshalingDelegates<FControlRigComponentMappedElement, FControlRigComponentMappedElement>.FromNative, CachedMarshalingDelegates<FControlRigComponentMappedElement, FControlRigComponentMappedElement>.ToNative).ToNative(IntPtr.Add(intPtr, SetMappedElements_NewMappedElements_Offset), NewMappedElements);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMappedElements_FunctionAddress, intPtr, SetMappedElements_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMappedElements_NewMappedElements_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:SetInitialSpaceTransform")]
	public unsafe void SetInitialSpaceTransform(FName SpaceName, FTransform InitialTransform, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
	{
		CheckDestroyed();
		if (!SetInitialSpaceTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:SetInitialSpaceTransform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInitialSpaceTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInitialSpaceTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetInitialSpaceTransform_SpaceName_Offset), 0, SetInitialSpaceTransform_SpaceName_PropertyAddress.Address, SpaceName);
		NativeReflection.InitializeValue_InContainer(SetInitialSpaceTransform_InitialTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetInitialSpaceTransform_InitialTransform_Offset), 0, SetInitialSpaceTransform_InitialTransform_PropertyAddress.Address, InitialTransform);
		EnumMarshaler<EControlRigComponentSpace>.ToNative(IntPtr.Add(intPtr, SetInitialSpaceTransform_Space_Offset), 0, SetInitialSpaceTransform_Space_PropertyAddress.Address, Space);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetInitialSpaceTransform_FunctionAddress, intPtr, SetInitialSpaceTransform_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:SetInitialBoneTransform")]
	public unsafe void SetInitialBoneTransform(FName BoneName, FTransform InitialTransform, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace, bool bPropagateToChildren = false)
	{
		CheckDestroyed();
		if (!SetInitialBoneTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:SetInitialBoneTransform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInitialBoneTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInitialBoneTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetInitialBoneTransform_BoneName_Offset), 0, SetInitialBoneTransform_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InitializeValue_InContainer(SetInitialBoneTransform_InitialTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetInitialBoneTransform_InitialTransform_Offset), 0, SetInitialBoneTransform_InitialTransform_PropertyAddress.Address, InitialTransform);
		EnumMarshaler<EControlRigComponentSpace>.ToNative(IntPtr.Add(intPtr, SetInitialBoneTransform_Space_Offset), 0, SetInitialBoneTransform_Space_PropertyAddress.Address, Space);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetInitialBoneTransform_bPropagateToChildren_Offset), 0, SetInitialBoneTransform_bPropagateToChildren_PropertyAddress.Address, bPropagateToChildren);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetInitialBoneTransform_FunctionAddress, intPtr, SetInitialBoneTransform_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:SetControlVector2D")]
	public unsafe void SetControlVector2D(FName ControlName, FVector2D Value)
	{
		CheckDestroyed();
		if (!SetControlVector2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:SetControlVector2D");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetControlVector2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetControlVector2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetControlVector2D_ControlName_Offset), 0, SetControlVector2D_ControlName_PropertyAddress.Address, ControlName);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetControlVector2D_Value_Offset), 0, SetControlVector2D_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetControlVector2D_FunctionAddress, intPtr, SetControlVector2D_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:SetControlTransform")]
	public unsafe void SetControlTransform(FName ControlName, FTransform Value, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
	{
		CheckDestroyed();
		if (!SetControlTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:SetControlTransform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetControlTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetControlTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetControlTransform_ControlName_Offset), 0, SetControlTransform_ControlName_PropertyAddress.Address, ControlName);
		NativeReflection.InitializeValue_InContainer(SetControlTransform_Value_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetControlTransform_Value_Offset), 0, SetControlTransform_Value_PropertyAddress.Address, Value);
		EnumMarshaler<EControlRigComponentSpace>.ToNative(IntPtr.Add(intPtr, SetControlTransform_Space_Offset), 0, SetControlTransform_Space_PropertyAddress.Address, Space);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetControlTransform_FunctionAddress, intPtr, SetControlTransform_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:SetControlScale")]
	public unsafe void SetControlScale(FName ControlName, FVector Value, EControlRigComponentSpace Space = EControlRigComponentSpace.LocalSpace)
	{
		CheckDestroyed();
		if (!SetControlScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:SetControlScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetControlScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetControlScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetControlScale_ControlName_Offset), 0, SetControlScale_ControlName_PropertyAddress.Address, ControlName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetControlScale_Value_Offset), 0, SetControlScale_Value_PropertyAddress.Address, Value);
		EnumMarshaler<EControlRigComponentSpace>.ToNative(IntPtr.Add(intPtr, SetControlScale_Space_Offset), 0, SetControlScale_Space_PropertyAddress.Address, Space);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetControlScale_FunctionAddress, intPtr, SetControlScale_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:SetControlRotator")]
	public unsafe void SetControlRotator(FName ControlName, FRotator Value, EControlRigComponentSpace Space = EControlRigComponentSpace.LocalSpace)
	{
		CheckDestroyed();
		if (!SetControlRotator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:SetControlRotator");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetControlRotator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetControlRotator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetControlRotator_ControlName_Offset), 0, SetControlRotator_ControlName_PropertyAddress.Address, ControlName);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetControlRotator_Value_Offset), 0, SetControlRotator_Value_PropertyAddress.Address, Value);
		EnumMarshaler<EControlRigComponentSpace>.ToNative(IntPtr.Add(intPtr, SetControlRotator_Space_Offset), 0, SetControlRotator_Space_PropertyAddress.Address, Space);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetControlRotator_FunctionAddress, intPtr, SetControlRotator_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:SetControlPosition")]
	public unsafe void SetControlPosition(FName ControlName, FVector Value, EControlRigComponentSpace Space = EControlRigComponentSpace.LocalSpace)
	{
		CheckDestroyed();
		if (!SetControlPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:SetControlPosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetControlPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetControlPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetControlPosition_ControlName_Offset), 0, SetControlPosition_ControlName_PropertyAddress.Address, ControlName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetControlPosition_Value_Offset), 0, SetControlPosition_Value_PropertyAddress.Address, Value);
		EnumMarshaler<EControlRigComponentSpace>.ToNative(IntPtr.Add(intPtr, SetControlPosition_Space_Offset), 0, SetControlPosition_Space_PropertyAddress.Address, Space);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetControlPosition_FunctionAddress, intPtr, SetControlPosition_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:SetControlOffset")]
	public unsafe void SetControlOffset(FName ControlName, FTransform OffsetTransform, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
	{
		CheckDestroyed();
		if (!SetControlOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:SetControlOffset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetControlOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetControlOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetControlOffset_ControlName_Offset), 0, SetControlOffset_ControlName_PropertyAddress.Address, ControlName);
		NativeReflection.InitializeValue_InContainer(SetControlOffset_OffsetTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetControlOffset_OffsetTransform_Offset), 0, SetControlOffset_OffsetTransform_PropertyAddress.Address, OffsetTransform);
		EnumMarshaler<EControlRigComponentSpace>.ToNative(IntPtr.Add(intPtr, SetControlOffset_Space_Offset), 0, SetControlOffset_Space_PropertyAddress.Address, Space);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetControlOffset_FunctionAddress, intPtr, SetControlOffset_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:SetControlInt")]
	public unsafe void SetControlInt(FName ControlName, int Value)
	{
		CheckDestroyed();
		if (!SetControlInt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:SetControlInt");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetControlInt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetControlInt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetControlInt_ControlName_Offset), 0, SetControlInt_ControlName_PropertyAddress.Address, ControlName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetControlInt_Value_Offset), 0, SetControlInt_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetControlInt_FunctionAddress, intPtr, SetControlInt_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:SetControlFloat")]
	public unsafe void SetControlFloat(FName ControlName, float Value)
	{
		CheckDestroyed();
		if (!SetControlFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:SetControlFloat");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetControlFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetControlFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetControlFloat_ControlName_Offset), 0, SetControlFloat_ControlName_PropertyAddress.Address, ControlName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetControlFloat_Value_Offset), 0, SetControlFloat_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetControlFloat_FunctionAddress, intPtr, SetControlFloat_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:SetControlBool")]
	public unsafe void SetControlBool(FName ControlName, bool Value)
	{
		CheckDestroyed();
		if (!SetControlBool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:SetControlBool");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetControlBool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetControlBool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetControlBool_ControlName_Offset), 0, SetControlBool_ControlName_PropertyAddress.Address, ControlName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlBool_Value_Offset), 0, SetControlBool_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetControlBool_FunctionAddress, intPtr, SetControlBool_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:SetBoneTransform")]
	public unsafe void SetBoneTransform(FName BoneName, FTransform Transform, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace, float Weight = 1f, bool bPropagateToChildren = true)
	{
		CheckDestroyed();
		if (!SetBoneTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:SetBoneTransform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBoneTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBoneTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetBoneTransform_BoneName_Offset), 0, SetBoneTransform_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InitializeValue_InContainer(SetBoneTransform_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetBoneTransform_Transform_Offset), 0, SetBoneTransform_Transform_PropertyAddress.Address, Transform);
		EnumMarshaler<EControlRigComponentSpace>.ToNative(IntPtr.Add(intPtr, SetBoneTransform_Space_Offset), 0, SetBoneTransform_Space_PropertyAddress.Address, Space);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetBoneTransform_Weight_Offset), 0, SetBoneTransform_Weight_PropertyAddress.Address, Weight);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBoneTransform_bPropagateToChildren_Offset), 0, SetBoneTransform_bPropagateToChildren_PropertyAddress.Address, bPropagateToChildren);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBoneTransform_FunctionAddress, intPtr, SetBoneTransform_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:SetBoneInitialTransformsFromSkeletalMesh")]
	public unsafe void SetBoneInitialTransformsFromSkeletalMesh(USkeletalMesh InSkeletalMesh)
	{
		CheckDestroyed();
		if (!SetBoneInitialTransformsFromSkeletalMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:SetBoneInitialTransformsFromSkeletalMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBoneInitialTransformsFromSkeletalMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBoneInitialTransformsFromSkeletalMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, SetBoneInitialTransformsFromSkeletalMesh_InSkeletalMesh_Offset), 0, SetBoneInitialTransformsFromSkeletalMesh_InSkeletalMesh_PropertyAddress.Address, InSkeletalMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBoneInitialTransformsFromSkeletalMesh_FunctionAddress, intPtr, SetBoneInitialTransformsFromSkeletalMesh_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:OnPreSetup")]
	public unsafe void OnPreSetup(UControlRigComponent Component)
	{
		CheckDestroyed();
		if (!OnPreSetup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:OnPreSetup");
			return;
		}
		if (OnPreSetup_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPreSetup_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPreSetup");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPreSetup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPreSetup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRigComponent>.ToNative(IntPtr.Add(intPtr, OnPreSetup_Component_Offset), 0, OnPreSetup_Component_PropertyAddress.Address, Component);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPreSetup_InstanceFunctionAddress, intPtr, OnPreSetup_ParamsSize);
	}

	protected unsafe virtual void OnPreSetup_Implementation(UControlRigComponent Component)
	{
		CheckDestroyed();
		if (!OnPreSetup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:OnPreSetup");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPreSetup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPreSetup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRigComponent>.ToNative(IntPtr.Add(intPtr, OnPreSetup_Component_Offset), 0, OnPreSetup_Component_PropertyAddress.Address, Component);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPreSetup_FunctionAddress, intPtr, OnPreSetup_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:OnPreInitialize")]
	public unsafe void OnPreInitialize(UControlRigComponent Component)
	{
		CheckDestroyed();
		if (!OnPreInitialize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:OnPreInitialize");
			return;
		}
		if (OnPreInitialize_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPreInitialize_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPreInitialize");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPreInitialize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPreInitialize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRigComponent>.ToNative(IntPtr.Add(intPtr, OnPreInitialize_Component_Offset), 0, OnPreInitialize_Component_PropertyAddress.Address, Component);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPreInitialize_InstanceFunctionAddress, intPtr, OnPreInitialize_ParamsSize);
	}

	protected unsafe virtual void OnPreInitialize_Implementation(UControlRigComponent Component)
	{
		CheckDestroyed();
		if (!OnPreInitialize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:OnPreInitialize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPreInitialize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPreInitialize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRigComponent>.ToNative(IntPtr.Add(intPtr, OnPreInitialize_Component_Offset), 0, OnPreInitialize_Component_PropertyAddress.Address, Component);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPreInitialize_FunctionAddress, intPtr, OnPreInitialize_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:OnPreForwardsSolve")]
	public unsafe void OnPreForwardsSolve(UControlRigComponent Component)
	{
		CheckDestroyed();
		if (!OnPreForwardsSolve_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:OnPreForwardsSolve");
			return;
		}
		if (OnPreForwardsSolve_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPreForwardsSolve_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPreForwardsSolve");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPreForwardsSolve_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPreForwardsSolve_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRigComponent>.ToNative(IntPtr.Add(intPtr, OnPreForwardsSolve_Component_Offset), 0, OnPreForwardsSolve_Component_PropertyAddress.Address, Component);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPreForwardsSolve_InstanceFunctionAddress, intPtr, OnPreForwardsSolve_ParamsSize);
	}

	protected unsafe virtual void OnPreForwardsSolve_Implementation(UControlRigComponent Component)
	{
		CheckDestroyed();
		if (!OnPreForwardsSolve_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:OnPreForwardsSolve");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPreForwardsSolve_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPreForwardsSolve_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRigComponent>.ToNative(IntPtr.Add(intPtr, OnPreForwardsSolve_Component_Offset), 0, OnPreForwardsSolve_Component_PropertyAddress.Address, Component);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPreForwardsSolve_FunctionAddress, intPtr, OnPreForwardsSolve_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:OnPostSetup")]
	public unsafe void OnPostSetup(UControlRigComponent Component)
	{
		CheckDestroyed();
		if (!OnPostSetup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:OnPostSetup");
			return;
		}
		if (OnPostSetup_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPostSetup_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPostSetup");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPostSetup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPostSetup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRigComponent>.ToNative(IntPtr.Add(intPtr, OnPostSetup_Component_Offset), 0, OnPostSetup_Component_PropertyAddress.Address, Component);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPostSetup_InstanceFunctionAddress, intPtr, OnPostSetup_ParamsSize);
	}

	protected unsafe virtual void OnPostSetup_Implementation(UControlRigComponent Component)
	{
		CheckDestroyed();
		if (!OnPostSetup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:OnPostSetup");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPostSetup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPostSetup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRigComponent>.ToNative(IntPtr.Add(intPtr, OnPostSetup_Component_Offset), 0, OnPostSetup_Component_PropertyAddress.Address, Component);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPostSetup_FunctionAddress, intPtr, OnPostSetup_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:OnPostInitialize")]
	public unsafe void OnPostInitialize(UControlRigComponent Component)
	{
		CheckDestroyed();
		if (!OnPostInitialize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:OnPostInitialize");
			return;
		}
		if (OnPostInitialize_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPostInitialize_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPostInitialize");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPostInitialize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPostInitialize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRigComponent>.ToNative(IntPtr.Add(intPtr, OnPostInitialize_Component_Offset), 0, OnPostInitialize_Component_PropertyAddress.Address, Component);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPostInitialize_InstanceFunctionAddress, intPtr, OnPostInitialize_ParamsSize);
	}

	protected unsafe virtual void OnPostInitialize_Implementation(UControlRigComponent Component)
	{
		CheckDestroyed();
		if (!OnPostInitialize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:OnPostInitialize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPostInitialize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPostInitialize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRigComponent>.ToNative(IntPtr.Add(intPtr, OnPostInitialize_Component_Offset), 0, OnPostInitialize_Component_PropertyAddress.Address, Component);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPostInitialize_FunctionAddress, intPtr, OnPostInitialize_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:OnPostForwardsSolve")]
	public unsafe void OnPostForwardsSolve(UControlRigComponent Component)
	{
		CheckDestroyed();
		if (!OnPostForwardsSolve_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:OnPostForwardsSolve");
			return;
		}
		if (OnPostForwardsSolve_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPostForwardsSolve_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPostForwardsSolve");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPostForwardsSolve_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPostForwardsSolve_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRigComponent>.ToNative(IntPtr.Add(intPtr, OnPostForwardsSolve_Component_Offset), 0, OnPostForwardsSolve_Component_PropertyAddress.Address, Component);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPostForwardsSolve_InstanceFunctionAddress, intPtr, OnPostForwardsSolve_ParamsSize);
	}

	protected unsafe virtual void OnPostForwardsSolve_Implementation(UControlRigComponent Component)
	{
		CheckDestroyed();
		if (!OnPostForwardsSolve_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:OnPostForwardsSolve");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPostForwardsSolve_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPostForwardsSolve_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRigComponent>.ToNative(IntPtr.Add(intPtr, OnPostForwardsSolve_Component_Offset), 0, OnPostForwardsSolve_Component_PropertyAddress.Address, Component);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPostForwardsSolve_FunctionAddress, intPtr, OnPostForwardsSolve_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:Initialize")]
	public new unsafe void Initialize()
	{
		CheckDestroyed();
		if (!Initialize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:Initialize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Initialize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Initialize_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Initialize_FunctionAddress, argsSize: Initialize_ParamsSize);
	}

	[UFunction(Flags = 344065025u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:GetSpaceTransform")]
	public unsafe FTransform GetSpaceTransform(FName SpaceName, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
	{
		CheckDestroyed();
		if (!GetSpaceTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:GetSpaceTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSpaceTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSpaceTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetSpaceTransform_SpaceName_Offset), 0, GetSpaceTransform_SpaceName_PropertyAddress.Address, SpaceName);
		EnumMarshaler<EControlRigComponentSpace>.ToNative(IntPtr.Add(intPtr, GetSpaceTransform_Space_Offset), 0, GetSpaceTransform_Space_PropertyAddress.Address, Space);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSpaceTransform_FunctionAddress, intPtr, GetSpaceTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetSpaceTransform_ReturnValue_Offset), 0, GetSpaceTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344065025u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:GetInitialSpaceTransform")]
	public unsafe FTransform GetInitialSpaceTransform(FName SpaceName, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
	{
		CheckDestroyed();
		if (!GetInitialSpaceTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:GetInitialSpaceTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInitialSpaceTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInitialSpaceTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetInitialSpaceTransform_SpaceName_Offset), 0, GetInitialSpaceTransform_SpaceName_PropertyAddress.Address, SpaceName);
		EnumMarshaler<EControlRigComponentSpace>.ToNative(IntPtr.Add(intPtr, GetInitialSpaceTransform_Space_Offset), 0, GetInitialSpaceTransform_Space_PropertyAddress.Address, Space);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInitialSpaceTransform_FunctionAddress, intPtr, GetInitialSpaceTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetInitialSpaceTransform_ReturnValue_Offset), 0, GetInitialSpaceTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344065025u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:GetInitialBoneTransform")]
	public unsafe FTransform GetInitialBoneTransform(FName BoneName, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
	{
		CheckDestroyed();
		if (!GetInitialBoneTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:GetInitialBoneTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInitialBoneTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInitialBoneTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetInitialBoneTransform_BoneName_Offset), 0, GetInitialBoneTransform_BoneName_PropertyAddress.Address, BoneName);
		EnumMarshaler<EControlRigComponentSpace>.ToNative(IntPtr.Add(intPtr, GetInitialBoneTransform_Space_Offset), 0, GetInitialBoneTransform_Space_PropertyAddress.Address, Space);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInitialBoneTransform_FunctionAddress, intPtr, GetInitialBoneTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetInitialBoneTransform_ReturnValue_Offset), 0, GetInitialBoneTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:GetElementNames")]
	public unsafe List<FName> GetElementNames(ERigElementType ElementType = ERigElementType.Bone)
	{
		CheckDestroyed();
		if (!GetElementNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:GetElementNames");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetElementNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetElementNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ERigElementType>.ToNative(IntPtr.Add(intPtr, GetElementNames_ElementType_Offset), 0, GetElementNames_ElementType_PropertyAddress.Address, ElementType);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetElementNames_FunctionAddress, intPtr, GetElementNames_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetElementNames_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetElementNames_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetElementNames_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 344065025u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:GetControlVector2D")]
	public unsafe FVector2D GetControlVector2D(FName ControlName)
	{
		CheckDestroyed();
		if (!GetControlVector2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:GetControlVector2D");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetControlVector2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetControlVector2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetControlVector2D_ControlName_Offset), 0, GetControlVector2D_ControlName_PropertyAddress.Address, ControlName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetControlVector2D_FunctionAddress, intPtr, GetControlVector2D_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetControlVector2D_ReturnValue_Offset), 0, GetControlVector2D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344065025u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:GetControlTransform")]
	public unsafe FTransform GetControlTransform(FName ControlName, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
	{
		CheckDestroyed();
		if (!GetControlTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:GetControlTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetControlTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetControlTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetControlTransform_ControlName_Offset), 0, GetControlTransform_ControlName_PropertyAddress.Address, ControlName);
		EnumMarshaler<EControlRigComponentSpace>.ToNative(IntPtr.Add(intPtr, GetControlTransform_Space_Offset), 0, GetControlTransform_Space_PropertyAddress.Address, Space);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetControlTransform_FunctionAddress, intPtr, GetControlTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetControlTransform_ReturnValue_Offset), 0, GetControlTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344065025u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:GetControlScale")]
	public unsafe FVector GetControlScale(FName ControlName, EControlRigComponentSpace Space = EControlRigComponentSpace.LocalSpace)
	{
		CheckDestroyed();
		if (!GetControlScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:GetControlScale");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetControlScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetControlScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetControlScale_ControlName_Offset), 0, GetControlScale_ControlName_PropertyAddress.Address, ControlName);
		EnumMarshaler<EControlRigComponentSpace>.ToNative(IntPtr.Add(intPtr, GetControlScale_Space_Offset), 0, GetControlScale_Space_PropertyAddress.Address, Space);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetControlScale_FunctionAddress, intPtr, GetControlScale_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetControlScale_ReturnValue_Offset), 0, GetControlScale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344065025u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:GetControlRotator")]
	public unsafe FRotator GetControlRotator(FName ControlName, EControlRigComponentSpace Space = EControlRigComponentSpace.LocalSpace)
	{
		CheckDestroyed();
		if (!GetControlRotator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:GetControlRotator");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetControlRotator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetControlRotator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetControlRotator_ControlName_Offset), 0, GetControlRotator_ControlName_PropertyAddress.Address, ControlName);
		EnumMarshaler<EControlRigComponentSpace>.ToNative(IntPtr.Add(intPtr, GetControlRotator_Space_Offset), 0, GetControlRotator_Space_PropertyAddress.Address, Space);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetControlRotator_FunctionAddress, intPtr, GetControlRotator_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetControlRotator_ReturnValue_Offset), 0, GetControlRotator_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:GetControlRig")]
	public unsafe UControlRig GetControlRig()
	{
		CheckDestroyed();
		if (!GetControlRig_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:GetControlRig");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetControlRig_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetControlRig_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetControlRig_FunctionAddress, intPtr, GetControlRig_ParamsSize);
		return UObjectMarshaler<UControlRig>.FromNative(IntPtr.Add(intPtr, GetControlRig_ReturnValue_Offset), 0, GetControlRig_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344065025u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:GetControlPosition")]
	public unsafe FVector GetControlPosition(FName ControlName, EControlRigComponentSpace Space = EControlRigComponentSpace.LocalSpace)
	{
		CheckDestroyed();
		if (!GetControlPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:GetControlPosition");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetControlPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetControlPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetControlPosition_ControlName_Offset), 0, GetControlPosition_ControlName_PropertyAddress.Address, ControlName);
		EnumMarshaler<EControlRigComponentSpace>.ToNative(IntPtr.Add(intPtr, GetControlPosition_Space_Offset), 0, GetControlPosition_Space_PropertyAddress.Address, Space);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetControlPosition_FunctionAddress, intPtr, GetControlPosition_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetControlPosition_ReturnValue_Offset), 0, GetControlPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:GetControlOffset")]
	public unsafe FTransform GetControlOffset(FName ControlName, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
	{
		CheckDestroyed();
		if (!GetControlOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:GetControlOffset");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetControlOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetControlOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetControlOffset_ControlName_Offset), 0, GetControlOffset_ControlName_PropertyAddress.Address, ControlName);
		EnumMarshaler<EControlRigComponentSpace>.ToNative(IntPtr.Add(intPtr, GetControlOffset_Space_Offset), 0, GetControlOffset_Space_PropertyAddress.Address, Space);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetControlOffset_FunctionAddress, intPtr, GetControlOffset_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetControlOffset_ReturnValue_Offset), 0, GetControlOffset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:GetControlInt")]
	public unsafe int GetControlInt(FName ControlName)
	{
		CheckDestroyed();
		if (!GetControlInt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:GetControlInt");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetControlInt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetControlInt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetControlInt_ControlName_Offset), 0, GetControlInt_ControlName_PropertyAddress.Address, ControlName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetControlInt_FunctionAddress, intPtr, GetControlInt_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetControlInt_ReturnValue_Offset), 0, GetControlInt_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:GetControlFloat")]
	public unsafe float GetControlFloat(FName ControlName)
	{
		CheckDestroyed();
		if (!GetControlFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:GetControlFloat");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetControlFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetControlFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetControlFloat_ControlName_Offset), 0, GetControlFloat_ControlName_PropertyAddress.Address, ControlName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetControlFloat_FunctionAddress, intPtr, GetControlFloat_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetControlFloat_ReturnValue_Offset), 0, GetControlFloat_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:GetControlBool")]
	public unsafe bool GetControlBool(FName ControlName)
	{
		CheckDestroyed();
		if (!GetControlBool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:GetControlBool");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetControlBool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetControlBool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetControlBool_ControlName_Offset), 0, GetControlBool_ControlName_PropertyAddress.Address, ControlName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetControlBool_FunctionAddress, intPtr, GetControlBool_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetControlBool_ReturnValue_Offset), 0, GetControlBool_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344065025u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:GetBoneTransform")]
	public unsafe FTransform GetBoneTransform(FName BoneName, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
	{
		CheckDestroyed();
		if (!GetBoneTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:GetBoneTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoneTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoneTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetBoneTransform_BoneName_Offset), 0, GetBoneTransform_BoneName_PropertyAddress.Address, BoneName);
		EnumMarshaler<EControlRigComponentSpace>.ToNative(IntPtr.Add(intPtr, GetBoneTransform_Space_Offset), 0, GetBoneTransform_Space_PropertyAddress.Address, Space);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBoneTransform_FunctionAddress, intPtr, GetBoneTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetBoneTransform_ReturnValue_Offset), 0, GetBoneTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:GetAbsoluteTime")]
	public unsafe float GetAbsoluteTime()
	{
		CheckDestroyed();
		if (!GetAbsoluteTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:GetAbsoluteTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAbsoluteTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAbsoluteTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAbsoluteTime_FunctionAddress, intPtr, GetAbsoluteTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAbsoluteTime_ReturnValue_Offset), 0, GetAbsoluteTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:DoesElementExist")]
	public unsafe bool DoesElementExist(FName Name, ERigElementType ElementType = ERigElementType.Bone)
	{
		CheckDestroyed();
		if (!DoesElementExist_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:DoesElementExist");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DoesElementExist_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoesElementExist_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, DoesElementExist_Name_Offset), 0, DoesElementExist_Name_PropertyAddress.Address, Name);
		EnumMarshaler<ERigElementType>.ToNative(IntPtr.Add(intPtr, DoesElementExist_ElementType_Offset), 0, DoesElementExist_ElementType_PropertyAddress.Address, ElementType);
		NativeReflection.InvokeFunctionOptimized(base.Address, DoesElementExist_FunctionAddress, intPtr, DoesElementExist_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DoesElementExist_ReturnValue_Offset), 0, DoesElementExist_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:ClearMappedElements")]
	public unsafe void ClearMappedElements()
	{
		CheckDestroyed();
		if (!ClearMappedElements_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:ClearMappedElements");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearMappedElements_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearMappedElements_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearMappedElements_FunctionAddress, argsSize: ClearMappedElements_ParamsSize);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:CanExecute")]
	public unsafe bool CanExecute()
	{
		CheckDestroyed();
		if (!CanExecute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:CanExecute");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanExecute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanExecute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanExecute_FunctionAddress, intPtr, CanExecute_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanExecute_ReturnValue_Offset), 0, CanExecute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:AddMappedSkeletalMesh")]
	public unsafe void AddMappedSkeletalMesh(USkeletalMeshComponent SkeletalMeshComponent, List<FControlRigComponentMappedBone> Bones, List<FControlRigComponentMappedCurve> Curves)
	{
		CheckDestroyed();
		if (!AddMappedSkeletalMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:AddMappedSkeletalMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMappedSkeletalMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMappedSkeletalMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, AddMappedSkeletalMesh_SkeletalMeshComponent_Offset), 0, AddMappedSkeletalMesh_SkeletalMeshComponent_PropertyAddress.Address, SkeletalMeshComponent);
		new TArrayCopyMarshaler<FControlRigComponentMappedBone>(1, AddMappedSkeletalMesh_Bones_PropertyAddress, CachedMarshalingDelegates<FControlRigComponentMappedBone, FControlRigComponentMappedBone>.FromNative, CachedMarshalingDelegates<FControlRigComponentMappedBone, FControlRigComponentMappedBone>.ToNative).ToNative(IntPtr.Add(intPtr, AddMappedSkeletalMesh_Bones_Offset), Bones);
		new TArrayCopyMarshaler<FControlRigComponentMappedCurve>(1, AddMappedSkeletalMesh_Curves_PropertyAddress, CachedMarshalingDelegates<FControlRigComponentMappedCurve, FControlRigComponentMappedCurve>.FromNative, CachedMarshalingDelegates<FControlRigComponentMappedCurve, FControlRigComponentMappedCurve>.ToNative).ToNative(IntPtr.Add(intPtr, AddMappedSkeletalMesh_Curves_Offset), Curves);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddMappedSkeletalMesh_FunctionAddress, intPtr, AddMappedSkeletalMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddMappedSkeletalMesh_Bones_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddMappedSkeletalMesh_Curves_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:AddMappedElements")]
	public unsafe void AddMappedElements(List<FControlRigComponentMappedElement> NewMappedElements)
	{
		CheckDestroyed();
		if (!AddMappedElements_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:AddMappedElements");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMappedElements_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMappedElements_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FControlRigComponentMappedElement>(1, AddMappedElements_NewMappedElements_PropertyAddress, CachedMarshalingDelegates<FControlRigComponentMappedElement, FControlRigComponentMappedElement>.FromNative, CachedMarshalingDelegates<FControlRigComponentMappedElement, FControlRigComponentMappedElement>.ToNative).ToNative(IntPtr.Add(intPtr, AddMappedElements_NewMappedElements_Offset), NewMappedElements);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddMappedElements_FunctionAddress, intPtr, AddMappedElements_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddMappedElements_NewMappedElements_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:AddMappedComponents")]
	public unsafe void AddMappedComponents(List<FControlRigComponentMappedComponent> Components)
	{
		CheckDestroyed();
		if (!AddMappedComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:AddMappedComponents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMappedComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMappedComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FControlRigComponentMappedComponent>(1, AddMappedComponents_Components_PropertyAddress, CachedMarshalingDelegates<FControlRigComponentMappedComponent, FControlRigComponentMappedComponent>.FromNative, CachedMarshalingDelegates<FControlRigComponentMappedComponent, FControlRigComponentMappedComponent>.ToNative).ToNative(IntPtr.Add(intPtr, AddMappedComponents_Components_Offset), Components);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddMappedComponents_FunctionAddress, intPtr, AddMappedComponents_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddMappedComponents_Components_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRigComponent:AddMappedCompleteSkeletalMesh")]
	public unsafe void AddMappedCompleteSkeletalMesh(USkeletalMeshComponent SkeletalMeshComponent)
	{
		CheckDestroyed();
		if (!AddMappedCompleteSkeletalMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponent:AddMappedCompleteSkeletalMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMappedCompleteSkeletalMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMappedCompleteSkeletalMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, AddMappedCompleteSkeletalMesh_SkeletalMeshComponent_Offset), 0, AddMappedCompleteSkeletalMesh_SkeletalMeshComponent_PropertyAddress.Address, SkeletalMeshComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddMappedCompleteSkeletalMesh_FunctionAddress, intPtr, AddMappedCompleteSkeletalMesh_ParamsSize);
	}

	static UControlRigComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UControlRigComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UControlRigComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/ControlRig.ControlRigComponent");
		OnPreInitializeDelegate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPreInitializeDelegate");
		OnPreInitializeDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPreInitializeDelegate", Classes.FMulticastDelegateProperty);
		OnPostInitializeDelegate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPostInitializeDelegate");
		OnPostInitializeDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPostInitializeDelegate", Classes.FMulticastDelegateProperty);
		OnPreSetupDelegate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPreSetupDelegate");
		OnPreSetupDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPreSetupDelegate", Classes.FMulticastDelegateProperty);
		OnPostSetupDelegate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPostSetupDelegate");
		OnPostSetupDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPostSetupDelegate", Classes.FMulticastDelegateProperty);
		OnPreForwardsSolveDelegate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPreForwardsSolveDelegate");
		OnPreForwardsSolveDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPreForwardsSolveDelegate", Classes.FMulticastDelegateProperty);
		OnPostForwardsSolveDelegate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPostForwardsSolveDelegate");
		OnPostForwardsSolveDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPostForwardsSolveDelegate", Classes.FMulticastDelegateProperty);
		Update_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Update");
		Update_ParamsSize = NativeReflection.GetFunctionParamsSize(Update_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Update_DeltaTime_PropertyAddress, Update_FunctionAddress, "DeltaTime");
		Update_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(Update_FunctionAddress, "DeltaTime");
		Update_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(Update_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		Update_IsValid = Update_FunctionAddress != IntPtr.Zero && Update_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:Update", Update_IsValid);
		SetMappedElements_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMappedElements");
		SetMappedElements_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMappedElements_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMappedElements_NewMappedElements_PropertyAddress, SetMappedElements_FunctionAddress, "NewMappedElements");
		SetMappedElements_NewMappedElements_Offset = NativeReflectionCached.GetPropertyOffset(SetMappedElements_FunctionAddress, "NewMappedElements");
		SetMappedElements_NewMappedElements_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMappedElements_FunctionAddress, "NewMappedElements", Classes.FArrayProperty);
		SetMappedElements_IsValid = SetMappedElements_FunctionAddress != IntPtr.Zero && SetMappedElements_NewMappedElements_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:SetMappedElements", SetMappedElements_IsValid);
		SetInitialSpaceTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetInitialSpaceTransform");
		SetInitialSpaceTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInitialSpaceTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInitialSpaceTransform_SpaceName_PropertyAddress, SetInitialSpaceTransform_FunctionAddress, "SpaceName");
		SetInitialSpaceTransform_SpaceName_Offset = NativeReflectionCached.GetPropertyOffset(SetInitialSpaceTransform_FunctionAddress, "SpaceName");
		SetInitialSpaceTransform_SpaceName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInitialSpaceTransform_FunctionAddress, "SpaceName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInitialSpaceTransform_InitialTransform_PropertyAddress, SetInitialSpaceTransform_FunctionAddress, "InitialTransform");
		SetInitialSpaceTransform_InitialTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetInitialSpaceTransform_FunctionAddress, "InitialTransform");
		SetInitialSpaceTransform_InitialTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInitialSpaceTransform_FunctionAddress, "InitialTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInitialSpaceTransform_Space_PropertyAddress, SetInitialSpaceTransform_FunctionAddress, "Space");
		SetInitialSpaceTransform_Space_Offset = NativeReflectionCached.GetPropertyOffset(SetInitialSpaceTransform_FunctionAddress, "Space");
		SetInitialSpaceTransform_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInitialSpaceTransform_FunctionAddress, "Space", Classes.FEnumProperty);
		SetInitialSpaceTransform_IsValid = SetInitialSpaceTransform_FunctionAddress != IntPtr.Zero && SetInitialSpaceTransform_SpaceName_IsValid && SetInitialSpaceTransform_InitialTransform_IsValid && SetInitialSpaceTransform_Space_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:SetInitialSpaceTransform", SetInitialSpaceTransform_IsValid);
		SetInitialBoneTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetInitialBoneTransform");
		SetInitialBoneTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInitialBoneTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInitialBoneTransform_BoneName_PropertyAddress, SetInitialBoneTransform_FunctionAddress, "BoneName");
		SetInitialBoneTransform_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetInitialBoneTransform_FunctionAddress, "BoneName");
		SetInitialBoneTransform_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInitialBoneTransform_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInitialBoneTransform_InitialTransform_PropertyAddress, SetInitialBoneTransform_FunctionAddress, "InitialTransform");
		SetInitialBoneTransform_InitialTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetInitialBoneTransform_FunctionAddress, "InitialTransform");
		SetInitialBoneTransform_InitialTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInitialBoneTransform_FunctionAddress, "InitialTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInitialBoneTransform_Space_PropertyAddress, SetInitialBoneTransform_FunctionAddress, "Space");
		SetInitialBoneTransform_Space_Offset = NativeReflectionCached.GetPropertyOffset(SetInitialBoneTransform_FunctionAddress, "Space");
		SetInitialBoneTransform_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInitialBoneTransform_FunctionAddress, "Space", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInitialBoneTransform_bPropagateToChildren_PropertyAddress, SetInitialBoneTransform_FunctionAddress, "bPropagateToChildren");
		SetInitialBoneTransform_bPropagateToChildren_Offset = NativeReflectionCached.GetPropertyOffset(SetInitialBoneTransform_FunctionAddress, "bPropagateToChildren");
		SetInitialBoneTransform_bPropagateToChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInitialBoneTransform_FunctionAddress, "bPropagateToChildren", Classes.FBoolProperty);
		SetInitialBoneTransform_IsValid = SetInitialBoneTransform_FunctionAddress != IntPtr.Zero && SetInitialBoneTransform_BoneName_IsValid && SetInitialBoneTransform_InitialTransform_IsValid && SetInitialBoneTransform_Space_IsValid && SetInitialBoneTransform_bPropagateToChildren_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:SetInitialBoneTransform", SetInitialBoneTransform_IsValid);
		SetControlVector2D_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetControlVector2D");
		SetControlVector2D_ParamsSize = NativeReflection.GetFunctionParamsSize(SetControlVector2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetControlVector2D_ControlName_PropertyAddress, SetControlVector2D_FunctionAddress, "ControlName");
		SetControlVector2D_ControlName_Offset = NativeReflectionCached.GetPropertyOffset(SetControlVector2D_FunctionAddress, "ControlName");
		SetControlVector2D_ControlName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlVector2D_FunctionAddress, "ControlName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlVector2D_Value_PropertyAddress, SetControlVector2D_FunctionAddress, "Value");
		SetControlVector2D_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetControlVector2D_FunctionAddress, "Value");
		SetControlVector2D_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlVector2D_FunctionAddress, "Value", Classes.FStructProperty);
		SetControlVector2D_IsValid = SetControlVector2D_FunctionAddress != IntPtr.Zero && SetControlVector2D_ControlName_IsValid && SetControlVector2D_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:SetControlVector2D", SetControlVector2D_IsValid);
		SetControlTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetControlTransform");
		SetControlTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetControlTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetControlTransform_ControlName_PropertyAddress, SetControlTransform_FunctionAddress, "ControlName");
		SetControlTransform_ControlName_Offset = NativeReflectionCached.GetPropertyOffset(SetControlTransform_FunctionAddress, "ControlName");
		SetControlTransform_ControlName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlTransform_FunctionAddress, "ControlName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlTransform_Value_PropertyAddress, SetControlTransform_FunctionAddress, "Value");
		SetControlTransform_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetControlTransform_FunctionAddress, "Value");
		SetControlTransform_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlTransform_FunctionAddress, "Value", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlTransform_Space_PropertyAddress, SetControlTransform_FunctionAddress, "Space");
		SetControlTransform_Space_Offset = NativeReflectionCached.GetPropertyOffset(SetControlTransform_FunctionAddress, "Space");
		SetControlTransform_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlTransform_FunctionAddress, "Space", Classes.FEnumProperty);
		SetControlTransform_IsValid = SetControlTransform_FunctionAddress != IntPtr.Zero && SetControlTransform_ControlName_IsValid && SetControlTransform_Value_IsValid && SetControlTransform_Space_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:SetControlTransform", SetControlTransform_IsValid);
		SetControlScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetControlScale");
		SetControlScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetControlScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetControlScale_ControlName_PropertyAddress, SetControlScale_FunctionAddress, "ControlName");
		SetControlScale_ControlName_Offset = NativeReflectionCached.GetPropertyOffset(SetControlScale_FunctionAddress, "ControlName");
		SetControlScale_ControlName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlScale_FunctionAddress, "ControlName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlScale_Value_PropertyAddress, SetControlScale_FunctionAddress, "Value");
		SetControlScale_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetControlScale_FunctionAddress, "Value");
		SetControlScale_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlScale_FunctionAddress, "Value", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlScale_Space_PropertyAddress, SetControlScale_FunctionAddress, "Space");
		SetControlScale_Space_Offset = NativeReflectionCached.GetPropertyOffset(SetControlScale_FunctionAddress, "Space");
		SetControlScale_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlScale_FunctionAddress, "Space", Classes.FEnumProperty);
		SetControlScale_IsValid = SetControlScale_FunctionAddress != IntPtr.Zero && SetControlScale_ControlName_IsValid && SetControlScale_Value_IsValid && SetControlScale_Space_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:SetControlScale", SetControlScale_IsValid);
		SetControlRotator_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetControlRotator");
		SetControlRotator_ParamsSize = NativeReflection.GetFunctionParamsSize(SetControlRotator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetControlRotator_ControlName_PropertyAddress, SetControlRotator_FunctionAddress, "ControlName");
		SetControlRotator_ControlName_Offset = NativeReflectionCached.GetPropertyOffset(SetControlRotator_FunctionAddress, "ControlName");
		SetControlRotator_ControlName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlRotator_FunctionAddress, "ControlName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlRotator_Value_PropertyAddress, SetControlRotator_FunctionAddress, "Value");
		SetControlRotator_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetControlRotator_FunctionAddress, "Value");
		SetControlRotator_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlRotator_FunctionAddress, "Value", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlRotator_Space_PropertyAddress, SetControlRotator_FunctionAddress, "Space");
		SetControlRotator_Space_Offset = NativeReflectionCached.GetPropertyOffset(SetControlRotator_FunctionAddress, "Space");
		SetControlRotator_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlRotator_FunctionAddress, "Space", Classes.FEnumProperty);
		SetControlRotator_IsValid = SetControlRotator_FunctionAddress != IntPtr.Zero && SetControlRotator_ControlName_IsValid && SetControlRotator_Value_IsValid && SetControlRotator_Space_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:SetControlRotator", SetControlRotator_IsValid);
		SetControlPosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetControlPosition");
		SetControlPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetControlPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetControlPosition_ControlName_PropertyAddress, SetControlPosition_FunctionAddress, "ControlName");
		SetControlPosition_ControlName_Offset = NativeReflectionCached.GetPropertyOffset(SetControlPosition_FunctionAddress, "ControlName");
		SetControlPosition_ControlName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlPosition_FunctionAddress, "ControlName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlPosition_Value_PropertyAddress, SetControlPosition_FunctionAddress, "Value");
		SetControlPosition_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetControlPosition_FunctionAddress, "Value");
		SetControlPosition_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlPosition_FunctionAddress, "Value", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlPosition_Space_PropertyAddress, SetControlPosition_FunctionAddress, "Space");
		SetControlPosition_Space_Offset = NativeReflectionCached.GetPropertyOffset(SetControlPosition_FunctionAddress, "Space");
		SetControlPosition_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlPosition_FunctionAddress, "Space", Classes.FEnumProperty);
		SetControlPosition_IsValid = SetControlPosition_FunctionAddress != IntPtr.Zero && SetControlPosition_ControlName_IsValid && SetControlPosition_Value_IsValid && SetControlPosition_Space_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:SetControlPosition", SetControlPosition_IsValid);
		SetControlOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetControlOffset");
		SetControlOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetControlOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetControlOffset_ControlName_PropertyAddress, SetControlOffset_FunctionAddress, "ControlName");
		SetControlOffset_ControlName_Offset = NativeReflectionCached.GetPropertyOffset(SetControlOffset_FunctionAddress, "ControlName");
		SetControlOffset_ControlName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlOffset_FunctionAddress, "ControlName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlOffset_OffsetTransform_PropertyAddress, SetControlOffset_FunctionAddress, "OffsetTransform");
		SetControlOffset_OffsetTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetControlOffset_FunctionAddress, "OffsetTransform");
		SetControlOffset_OffsetTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlOffset_FunctionAddress, "OffsetTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlOffset_Space_PropertyAddress, SetControlOffset_FunctionAddress, "Space");
		SetControlOffset_Space_Offset = NativeReflectionCached.GetPropertyOffset(SetControlOffset_FunctionAddress, "Space");
		SetControlOffset_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlOffset_FunctionAddress, "Space", Classes.FEnumProperty);
		SetControlOffset_IsValid = SetControlOffset_FunctionAddress != IntPtr.Zero && SetControlOffset_ControlName_IsValid && SetControlOffset_OffsetTransform_IsValid && SetControlOffset_Space_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:SetControlOffset", SetControlOffset_IsValid);
		SetControlInt_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetControlInt");
		SetControlInt_ParamsSize = NativeReflection.GetFunctionParamsSize(SetControlInt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetControlInt_ControlName_PropertyAddress, SetControlInt_FunctionAddress, "ControlName");
		SetControlInt_ControlName_Offset = NativeReflectionCached.GetPropertyOffset(SetControlInt_FunctionAddress, "ControlName");
		SetControlInt_ControlName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlInt_FunctionAddress, "ControlName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlInt_Value_PropertyAddress, SetControlInt_FunctionAddress, "Value");
		SetControlInt_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetControlInt_FunctionAddress, "Value");
		SetControlInt_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlInt_FunctionAddress, "Value", Classes.FIntProperty);
		SetControlInt_IsValid = SetControlInt_FunctionAddress != IntPtr.Zero && SetControlInt_ControlName_IsValid && SetControlInt_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:SetControlInt", SetControlInt_IsValid);
		SetControlFloat_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetControlFloat");
		SetControlFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(SetControlFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetControlFloat_ControlName_PropertyAddress, SetControlFloat_FunctionAddress, "ControlName");
		SetControlFloat_ControlName_Offset = NativeReflectionCached.GetPropertyOffset(SetControlFloat_FunctionAddress, "ControlName");
		SetControlFloat_ControlName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlFloat_FunctionAddress, "ControlName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlFloat_Value_PropertyAddress, SetControlFloat_FunctionAddress, "Value");
		SetControlFloat_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetControlFloat_FunctionAddress, "Value");
		SetControlFloat_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlFloat_FunctionAddress, "Value", Classes.FFloatProperty);
		SetControlFloat_IsValid = SetControlFloat_FunctionAddress != IntPtr.Zero && SetControlFloat_ControlName_IsValid && SetControlFloat_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:SetControlFloat", SetControlFloat_IsValid);
		SetControlBool_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetControlBool");
		SetControlBool_ParamsSize = NativeReflection.GetFunctionParamsSize(SetControlBool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetControlBool_ControlName_PropertyAddress, SetControlBool_FunctionAddress, "ControlName");
		SetControlBool_ControlName_Offset = NativeReflectionCached.GetPropertyOffset(SetControlBool_FunctionAddress, "ControlName");
		SetControlBool_ControlName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlBool_FunctionAddress, "ControlName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlBool_Value_PropertyAddress, SetControlBool_FunctionAddress, "Value");
		SetControlBool_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetControlBool_FunctionAddress, "Value");
		SetControlBool_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlBool_FunctionAddress, "Value", Classes.FBoolProperty);
		SetControlBool_IsValid = SetControlBool_FunctionAddress != IntPtr.Zero && SetControlBool_ControlName_IsValid && SetControlBool_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:SetControlBool", SetControlBool_IsValid);
		SetBoneTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBoneTransform");
		SetBoneTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoneTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBoneTransform_BoneName_PropertyAddress, SetBoneTransform_FunctionAddress, "BoneName");
		SetBoneTransform_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneTransform_FunctionAddress, "BoneName");
		SetBoneTransform_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneTransform_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoneTransform_Transform_PropertyAddress, SetBoneTransform_FunctionAddress, "Transform");
		SetBoneTransform_Transform_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneTransform_FunctionAddress, "Transform");
		SetBoneTransform_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneTransform_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoneTransform_Space_PropertyAddress, SetBoneTransform_FunctionAddress, "Space");
		SetBoneTransform_Space_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneTransform_FunctionAddress, "Space");
		SetBoneTransform_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneTransform_FunctionAddress, "Space", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoneTransform_Weight_PropertyAddress, SetBoneTransform_FunctionAddress, "Weight");
		SetBoneTransform_Weight_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneTransform_FunctionAddress, "Weight");
		SetBoneTransform_Weight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneTransform_FunctionAddress, "Weight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoneTransform_bPropagateToChildren_PropertyAddress, SetBoneTransform_FunctionAddress, "bPropagateToChildren");
		SetBoneTransform_bPropagateToChildren_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneTransform_FunctionAddress, "bPropagateToChildren");
		SetBoneTransform_bPropagateToChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneTransform_FunctionAddress, "bPropagateToChildren", Classes.FBoolProperty);
		SetBoneTransform_IsValid = SetBoneTransform_FunctionAddress != IntPtr.Zero && SetBoneTransform_BoneName_IsValid && SetBoneTransform_Transform_IsValid && SetBoneTransform_Space_IsValid && SetBoneTransform_Weight_IsValid && SetBoneTransform_bPropagateToChildren_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:SetBoneTransform", SetBoneTransform_IsValid);
		SetBoneInitialTransformsFromSkeletalMesh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBoneInitialTransformsFromSkeletalMesh");
		SetBoneInitialTransformsFromSkeletalMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoneInitialTransformsFromSkeletalMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBoneInitialTransformsFromSkeletalMesh_InSkeletalMesh_PropertyAddress, SetBoneInitialTransformsFromSkeletalMesh_FunctionAddress, "InSkeletalMesh");
		SetBoneInitialTransformsFromSkeletalMesh_InSkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneInitialTransformsFromSkeletalMesh_FunctionAddress, "InSkeletalMesh");
		SetBoneInitialTransformsFromSkeletalMesh_InSkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneInitialTransformsFromSkeletalMesh_FunctionAddress, "InSkeletalMesh", Classes.FObjectProperty);
		SetBoneInitialTransformsFromSkeletalMesh_IsValid = SetBoneInitialTransformsFromSkeletalMesh_FunctionAddress != IntPtr.Zero && SetBoneInitialTransformsFromSkeletalMesh_InSkeletalMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:SetBoneInitialTransformsFromSkeletalMesh", SetBoneInitialTransformsFromSkeletalMesh_IsValid);
		OnPreSetup_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPreSetup");
		OnPreSetup_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPreSetup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPreSetup_Component_PropertyAddress, OnPreSetup_FunctionAddress, "Component");
		OnPreSetup_Component_Offset = NativeReflectionCached.GetPropertyOffset(OnPreSetup_FunctionAddress, "Component");
		OnPreSetup_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPreSetup_FunctionAddress, "Component", Classes.FObjectProperty);
		OnPreSetup_IsValid = OnPreSetup_FunctionAddress != IntPtr.Zero && OnPreSetup_Component_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:OnPreSetup", OnPreSetup_IsValid);
		OnPreInitialize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPreInitialize");
		OnPreInitialize_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPreInitialize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPreInitialize_Component_PropertyAddress, OnPreInitialize_FunctionAddress, "Component");
		OnPreInitialize_Component_Offset = NativeReflectionCached.GetPropertyOffset(OnPreInitialize_FunctionAddress, "Component");
		OnPreInitialize_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPreInitialize_FunctionAddress, "Component", Classes.FObjectProperty);
		OnPreInitialize_IsValid = OnPreInitialize_FunctionAddress != IntPtr.Zero && OnPreInitialize_Component_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:OnPreInitialize", OnPreInitialize_IsValid);
		OnPreForwardsSolve_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPreForwardsSolve");
		OnPreForwardsSolve_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPreForwardsSolve_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPreForwardsSolve_Component_PropertyAddress, OnPreForwardsSolve_FunctionAddress, "Component");
		OnPreForwardsSolve_Component_Offset = NativeReflectionCached.GetPropertyOffset(OnPreForwardsSolve_FunctionAddress, "Component");
		OnPreForwardsSolve_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPreForwardsSolve_FunctionAddress, "Component", Classes.FObjectProperty);
		OnPreForwardsSolve_IsValid = OnPreForwardsSolve_FunctionAddress != IntPtr.Zero && OnPreForwardsSolve_Component_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:OnPreForwardsSolve", OnPreForwardsSolve_IsValid);
		OnPostSetup_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPostSetup");
		OnPostSetup_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPostSetup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPostSetup_Component_PropertyAddress, OnPostSetup_FunctionAddress, "Component");
		OnPostSetup_Component_Offset = NativeReflectionCached.GetPropertyOffset(OnPostSetup_FunctionAddress, "Component");
		OnPostSetup_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPostSetup_FunctionAddress, "Component", Classes.FObjectProperty);
		OnPostSetup_IsValid = OnPostSetup_FunctionAddress != IntPtr.Zero && OnPostSetup_Component_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:OnPostSetup", OnPostSetup_IsValid);
		OnPostInitialize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPostInitialize");
		OnPostInitialize_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPostInitialize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPostInitialize_Component_PropertyAddress, OnPostInitialize_FunctionAddress, "Component");
		OnPostInitialize_Component_Offset = NativeReflectionCached.GetPropertyOffset(OnPostInitialize_FunctionAddress, "Component");
		OnPostInitialize_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPostInitialize_FunctionAddress, "Component", Classes.FObjectProperty);
		OnPostInitialize_IsValid = OnPostInitialize_FunctionAddress != IntPtr.Zero && OnPostInitialize_Component_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:OnPostInitialize", OnPostInitialize_IsValid);
		OnPostForwardsSolve_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPostForwardsSolve");
		OnPostForwardsSolve_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPostForwardsSolve_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPostForwardsSolve_Component_PropertyAddress, OnPostForwardsSolve_FunctionAddress, "Component");
		OnPostForwardsSolve_Component_Offset = NativeReflectionCached.GetPropertyOffset(OnPostForwardsSolve_FunctionAddress, "Component");
		OnPostForwardsSolve_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPostForwardsSolve_FunctionAddress, "Component", Classes.FObjectProperty);
		OnPostForwardsSolve_IsValid = OnPostForwardsSolve_FunctionAddress != IntPtr.Zero && OnPostForwardsSolve_Component_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:OnPostForwardsSolve", OnPostForwardsSolve_IsValid);
		Initialize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Initialize");
		Initialize_ParamsSize = NativeReflection.GetFunctionParamsSize(Initialize_FunctionAddress);
		Initialize_IsValid = Initialize_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:Initialize", Initialize_IsValid);
		GetSpaceTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSpaceTransform");
		GetSpaceTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSpaceTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSpaceTransform_SpaceName_PropertyAddress, GetSpaceTransform_FunctionAddress, "SpaceName");
		GetSpaceTransform_SpaceName_Offset = NativeReflectionCached.GetPropertyOffset(GetSpaceTransform_FunctionAddress, "SpaceName");
		GetSpaceTransform_SpaceName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpaceTransform_FunctionAddress, "SpaceName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSpaceTransform_Space_PropertyAddress, GetSpaceTransform_FunctionAddress, "Space");
		GetSpaceTransform_Space_Offset = NativeReflectionCached.GetPropertyOffset(GetSpaceTransform_FunctionAddress, "Space");
		GetSpaceTransform_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpaceTransform_FunctionAddress, "Space", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSpaceTransform_ReturnValue_PropertyAddress, GetSpaceTransform_FunctionAddress, "ReturnValue");
		GetSpaceTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSpaceTransform_FunctionAddress, "ReturnValue");
		GetSpaceTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpaceTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSpaceTransform_IsValid = GetSpaceTransform_FunctionAddress != IntPtr.Zero && GetSpaceTransform_SpaceName_IsValid && GetSpaceTransform_Space_IsValid && GetSpaceTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:GetSpaceTransform", GetSpaceTransform_IsValid);
		GetInitialSpaceTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInitialSpaceTransform");
		GetInitialSpaceTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInitialSpaceTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInitialSpaceTransform_SpaceName_PropertyAddress, GetInitialSpaceTransform_FunctionAddress, "SpaceName");
		GetInitialSpaceTransform_SpaceName_Offset = NativeReflectionCached.GetPropertyOffset(GetInitialSpaceTransform_FunctionAddress, "SpaceName");
		GetInitialSpaceTransform_SpaceName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInitialSpaceTransform_FunctionAddress, "SpaceName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInitialSpaceTransform_Space_PropertyAddress, GetInitialSpaceTransform_FunctionAddress, "Space");
		GetInitialSpaceTransform_Space_Offset = NativeReflectionCached.GetPropertyOffset(GetInitialSpaceTransform_FunctionAddress, "Space");
		GetInitialSpaceTransform_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInitialSpaceTransform_FunctionAddress, "Space", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInitialSpaceTransform_ReturnValue_PropertyAddress, GetInitialSpaceTransform_FunctionAddress, "ReturnValue");
		GetInitialSpaceTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInitialSpaceTransform_FunctionAddress, "ReturnValue");
		GetInitialSpaceTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInitialSpaceTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetInitialSpaceTransform_IsValid = GetInitialSpaceTransform_FunctionAddress != IntPtr.Zero && GetInitialSpaceTransform_SpaceName_IsValid && GetInitialSpaceTransform_Space_IsValid && GetInitialSpaceTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:GetInitialSpaceTransform", GetInitialSpaceTransform_IsValid);
		GetInitialBoneTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInitialBoneTransform");
		GetInitialBoneTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInitialBoneTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInitialBoneTransform_BoneName_PropertyAddress, GetInitialBoneTransform_FunctionAddress, "BoneName");
		GetInitialBoneTransform_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetInitialBoneTransform_FunctionAddress, "BoneName");
		GetInitialBoneTransform_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInitialBoneTransform_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInitialBoneTransform_Space_PropertyAddress, GetInitialBoneTransform_FunctionAddress, "Space");
		GetInitialBoneTransform_Space_Offset = NativeReflectionCached.GetPropertyOffset(GetInitialBoneTransform_FunctionAddress, "Space");
		GetInitialBoneTransform_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInitialBoneTransform_FunctionAddress, "Space", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInitialBoneTransform_ReturnValue_PropertyAddress, GetInitialBoneTransform_FunctionAddress, "ReturnValue");
		GetInitialBoneTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInitialBoneTransform_FunctionAddress, "ReturnValue");
		GetInitialBoneTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInitialBoneTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetInitialBoneTransform_IsValid = GetInitialBoneTransform_FunctionAddress != IntPtr.Zero && GetInitialBoneTransform_BoneName_IsValid && GetInitialBoneTransform_Space_IsValid && GetInitialBoneTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:GetInitialBoneTransform", GetInitialBoneTransform_IsValid);
		GetElementNames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetElementNames");
		GetElementNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetElementNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetElementNames_ElementType_PropertyAddress, GetElementNames_FunctionAddress, "ElementType");
		GetElementNames_ElementType_Offset = NativeReflectionCached.GetPropertyOffset(GetElementNames_FunctionAddress, "ElementType");
		GetElementNames_ElementType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetElementNames_FunctionAddress, "ElementType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetElementNames_ReturnValue_PropertyAddress, GetElementNames_FunctionAddress, "ReturnValue");
		GetElementNames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetElementNames_FunctionAddress, "ReturnValue");
		GetElementNames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetElementNames_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetElementNames_IsValid = GetElementNames_FunctionAddress != IntPtr.Zero && GetElementNames_ElementType_IsValid && GetElementNames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:GetElementNames", GetElementNames_IsValid);
		GetControlVector2D_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetControlVector2D");
		GetControlVector2D_ParamsSize = NativeReflection.GetFunctionParamsSize(GetControlVector2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetControlVector2D_ControlName_PropertyAddress, GetControlVector2D_FunctionAddress, "ControlName");
		GetControlVector2D_ControlName_Offset = NativeReflectionCached.GetPropertyOffset(GetControlVector2D_FunctionAddress, "ControlName");
		GetControlVector2D_ControlName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlVector2D_FunctionAddress, "ControlName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetControlVector2D_ReturnValue_PropertyAddress, GetControlVector2D_FunctionAddress, "ReturnValue");
		GetControlVector2D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetControlVector2D_FunctionAddress, "ReturnValue");
		GetControlVector2D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlVector2D_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetControlVector2D_IsValid = GetControlVector2D_FunctionAddress != IntPtr.Zero && GetControlVector2D_ControlName_IsValid && GetControlVector2D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:GetControlVector2D", GetControlVector2D_IsValid);
		GetControlTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetControlTransform");
		GetControlTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetControlTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetControlTransform_ControlName_PropertyAddress, GetControlTransform_FunctionAddress, "ControlName");
		GetControlTransform_ControlName_Offset = NativeReflectionCached.GetPropertyOffset(GetControlTransform_FunctionAddress, "ControlName");
		GetControlTransform_ControlName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlTransform_FunctionAddress, "ControlName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetControlTransform_Space_PropertyAddress, GetControlTransform_FunctionAddress, "Space");
		GetControlTransform_Space_Offset = NativeReflectionCached.GetPropertyOffset(GetControlTransform_FunctionAddress, "Space");
		GetControlTransform_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlTransform_FunctionAddress, "Space", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetControlTransform_ReturnValue_PropertyAddress, GetControlTransform_FunctionAddress, "ReturnValue");
		GetControlTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetControlTransform_FunctionAddress, "ReturnValue");
		GetControlTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetControlTransform_IsValid = GetControlTransform_FunctionAddress != IntPtr.Zero && GetControlTransform_ControlName_IsValid && GetControlTransform_Space_IsValid && GetControlTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:GetControlTransform", GetControlTransform_IsValid);
		GetControlScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetControlScale");
		GetControlScale_ParamsSize = NativeReflection.GetFunctionParamsSize(GetControlScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetControlScale_ControlName_PropertyAddress, GetControlScale_FunctionAddress, "ControlName");
		GetControlScale_ControlName_Offset = NativeReflectionCached.GetPropertyOffset(GetControlScale_FunctionAddress, "ControlName");
		GetControlScale_ControlName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlScale_FunctionAddress, "ControlName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetControlScale_Space_PropertyAddress, GetControlScale_FunctionAddress, "Space");
		GetControlScale_Space_Offset = NativeReflectionCached.GetPropertyOffset(GetControlScale_FunctionAddress, "Space");
		GetControlScale_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlScale_FunctionAddress, "Space", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetControlScale_ReturnValue_PropertyAddress, GetControlScale_FunctionAddress, "ReturnValue");
		GetControlScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetControlScale_FunctionAddress, "ReturnValue");
		GetControlScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlScale_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetControlScale_IsValid = GetControlScale_FunctionAddress != IntPtr.Zero && GetControlScale_ControlName_IsValid && GetControlScale_Space_IsValid && GetControlScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:GetControlScale", GetControlScale_IsValid);
		GetControlRotator_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetControlRotator");
		GetControlRotator_ParamsSize = NativeReflection.GetFunctionParamsSize(GetControlRotator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetControlRotator_ControlName_PropertyAddress, GetControlRotator_FunctionAddress, "ControlName");
		GetControlRotator_ControlName_Offset = NativeReflectionCached.GetPropertyOffset(GetControlRotator_FunctionAddress, "ControlName");
		GetControlRotator_ControlName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlRotator_FunctionAddress, "ControlName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetControlRotator_Space_PropertyAddress, GetControlRotator_FunctionAddress, "Space");
		GetControlRotator_Space_Offset = NativeReflectionCached.GetPropertyOffset(GetControlRotator_FunctionAddress, "Space");
		GetControlRotator_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlRotator_FunctionAddress, "Space", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetControlRotator_ReturnValue_PropertyAddress, GetControlRotator_FunctionAddress, "ReturnValue");
		GetControlRotator_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetControlRotator_FunctionAddress, "ReturnValue");
		GetControlRotator_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlRotator_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetControlRotator_IsValid = GetControlRotator_FunctionAddress != IntPtr.Zero && GetControlRotator_ControlName_IsValid && GetControlRotator_Space_IsValid && GetControlRotator_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:GetControlRotator", GetControlRotator_IsValid);
		GetControlRig_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetControlRig");
		GetControlRig_ParamsSize = NativeReflection.GetFunctionParamsSize(GetControlRig_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetControlRig_ReturnValue_PropertyAddress, GetControlRig_FunctionAddress, "ReturnValue");
		GetControlRig_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetControlRig_FunctionAddress, "ReturnValue");
		GetControlRig_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlRig_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetControlRig_IsValid = GetControlRig_FunctionAddress != IntPtr.Zero && GetControlRig_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:GetControlRig", GetControlRig_IsValid);
		GetControlPosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetControlPosition");
		GetControlPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetControlPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetControlPosition_ControlName_PropertyAddress, GetControlPosition_FunctionAddress, "ControlName");
		GetControlPosition_ControlName_Offset = NativeReflectionCached.GetPropertyOffset(GetControlPosition_FunctionAddress, "ControlName");
		GetControlPosition_ControlName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlPosition_FunctionAddress, "ControlName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetControlPosition_Space_PropertyAddress, GetControlPosition_FunctionAddress, "Space");
		GetControlPosition_Space_Offset = NativeReflectionCached.GetPropertyOffset(GetControlPosition_FunctionAddress, "Space");
		GetControlPosition_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlPosition_FunctionAddress, "Space", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetControlPosition_ReturnValue_PropertyAddress, GetControlPosition_FunctionAddress, "ReturnValue");
		GetControlPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetControlPosition_FunctionAddress, "ReturnValue");
		GetControlPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlPosition_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetControlPosition_IsValid = GetControlPosition_FunctionAddress != IntPtr.Zero && GetControlPosition_ControlName_IsValid && GetControlPosition_Space_IsValid && GetControlPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:GetControlPosition", GetControlPosition_IsValid);
		GetControlOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetControlOffset");
		GetControlOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetControlOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetControlOffset_ControlName_PropertyAddress, GetControlOffset_FunctionAddress, "ControlName");
		GetControlOffset_ControlName_Offset = NativeReflectionCached.GetPropertyOffset(GetControlOffset_FunctionAddress, "ControlName");
		GetControlOffset_ControlName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlOffset_FunctionAddress, "ControlName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetControlOffset_Space_PropertyAddress, GetControlOffset_FunctionAddress, "Space");
		GetControlOffset_Space_Offset = NativeReflectionCached.GetPropertyOffset(GetControlOffset_FunctionAddress, "Space");
		GetControlOffset_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlOffset_FunctionAddress, "Space", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetControlOffset_ReturnValue_PropertyAddress, GetControlOffset_FunctionAddress, "ReturnValue");
		GetControlOffset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetControlOffset_FunctionAddress, "ReturnValue");
		GetControlOffset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlOffset_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetControlOffset_IsValid = GetControlOffset_FunctionAddress != IntPtr.Zero && GetControlOffset_ControlName_IsValid && GetControlOffset_Space_IsValid && GetControlOffset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:GetControlOffset", GetControlOffset_IsValid);
		GetControlInt_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetControlInt");
		GetControlInt_ParamsSize = NativeReflection.GetFunctionParamsSize(GetControlInt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetControlInt_ControlName_PropertyAddress, GetControlInt_FunctionAddress, "ControlName");
		GetControlInt_ControlName_Offset = NativeReflectionCached.GetPropertyOffset(GetControlInt_FunctionAddress, "ControlName");
		GetControlInt_ControlName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlInt_FunctionAddress, "ControlName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetControlInt_ReturnValue_PropertyAddress, GetControlInt_FunctionAddress, "ReturnValue");
		GetControlInt_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetControlInt_FunctionAddress, "ReturnValue");
		GetControlInt_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlInt_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetControlInt_IsValid = GetControlInt_FunctionAddress != IntPtr.Zero && GetControlInt_ControlName_IsValid && GetControlInt_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:GetControlInt", GetControlInt_IsValid);
		GetControlFloat_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetControlFloat");
		GetControlFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(GetControlFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetControlFloat_ControlName_PropertyAddress, GetControlFloat_FunctionAddress, "ControlName");
		GetControlFloat_ControlName_Offset = NativeReflectionCached.GetPropertyOffset(GetControlFloat_FunctionAddress, "ControlName");
		GetControlFloat_ControlName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlFloat_FunctionAddress, "ControlName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetControlFloat_ReturnValue_PropertyAddress, GetControlFloat_FunctionAddress, "ReturnValue");
		GetControlFloat_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetControlFloat_FunctionAddress, "ReturnValue");
		GetControlFloat_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlFloat_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetControlFloat_IsValid = GetControlFloat_FunctionAddress != IntPtr.Zero && GetControlFloat_ControlName_IsValid && GetControlFloat_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:GetControlFloat", GetControlFloat_IsValid);
		GetControlBool_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetControlBool");
		GetControlBool_ParamsSize = NativeReflection.GetFunctionParamsSize(GetControlBool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetControlBool_ControlName_PropertyAddress, GetControlBool_FunctionAddress, "ControlName");
		GetControlBool_ControlName_Offset = NativeReflectionCached.GetPropertyOffset(GetControlBool_FunctionAddress, "ControlName");
		GetControlBool_ControlName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlBool_FunctionAddress, "ControlName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetControlBool_ReturnValue_PropertyAddress, GetControlBool_FunctionAddress, "ReturnValue");
		GetControlBool_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetControlBool_FunctionAddress, "ReturnValue");
		GetControlBool_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlBool_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetControlBool_IsValid = GetControlBool_FunctionAddress != IntPtr.Zero && GetControlBool_ControlName_IsValid && GetControlBool_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:GetControlBool", GetControlBool_IsValid);
		GetBoneTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBoneTransform");
		GetBoneTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoneTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTransform_BoneName_PropertyAddress, GetBoneTransform_FunctionAddress, "BoneName");
		GetBoneTransform_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTransform_FunctionAddress, "BoneName");
		GetBoneTransform_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTransform_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTransform_Space_PropertyAddress, GetBoneTransform_FunctionAddress, "Space");
		GetBoneTransform_Space_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTransform_FunctionAddress, "Space");
		GetBoneTransform_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTransform_FunctionAddress, "Space", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTransform_ReturnValue_PropertyAddress, GetBoneTransform_FunctionAddress, "ReturnValue");
		GetBoneTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTransform_FunctionAddress, "ReturnValue");
		GetBoneTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBoneTransform_IsValid = GetBoneTransform_FunctionAddress != IntPtr.Zero && GetBoneTransform_BoneName_IsValid && GetBoneTransform_Space_IsValid && GetBoneTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:GetBoneTransform", GetBoneTransform_IsValid);
		GetAbsoluteTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAbsoluteTime");
		GetAbsoluteTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAbsoluteTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAbsoluteTime_ReturnValue_PropertyAddress, GetAbsoluteTime_FunctionAddress, "ReturnValue");
		GetAbsoluteTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAbsoluteTime_FunctionAddress, "ReturnValue");
		GetAbsoluteTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAbsoluteTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetAbsoluteTime_IsValid = GetAbsoluteTime_FunctionAddress != IntPtr.Zero && GetAbsoluteTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:GetAbsoluteTime", GetAbsoluteTime_IsValid);
		DoesElementExist_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoesElementExist");
		DoesElementExist_ParamsSize = NativeReflection.GetFunctionParamsSize(DoesElementExist_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DoesElementExist_Name_PropertyAddress, DoesElementExist_FunctionAddress, "Name");
		DoesElementExist_Name_Offset = NativeReflectionCached.GetPropertyOffset(DoesElementExist_FunctionAddress, "Name");
		DoesElementExist_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesElementExist_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesElementExist_ElementType_PropertyAddress, DoesElementExist_FunctionAddress, "ElementType");
		DoesElementExist_ElementType_Offset = NativeReflectionCached.GetPropertyOffset(DoesElementExist_FunctionAddress, "ElementType");
		DoesElementExist_ElementType_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesElementExist_FunctionAddress, "ElementType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesElementExist_ReturnValue_PropertyAddress, DoesElementExist_FunctionAddress, "ReturnValue");
		DoesElementExist_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DoesElementExist_FunctionAddress, "ReturnValue");
		DoesElementExist_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesElementExist_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DoesElementExist_IsValid = DoesElementExist_FunctionAddress != IntPtr.Zero && DoesElementExist_Name_IsValid && DoesElementExist_ElementType_IsValid && DoesElementExist_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:DoesElementExist", DoesElementExist_IsValid);
		ClearMappedElements_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearMappedElements");
		ClearMappedElements_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearMappedElements_FunctionAddress);
		ClearMappedElements_IsValid = ClearMappedElements_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:ClearMappedElements", ClearMappedElements_IsValid);
		CanExecute_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CanExecute");
		CanExecute_ParamsSize = NativeReflection.GetFunctionParamsSize(CanExecute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanExecute_ReturnValue_PropertyAddress, CanExecute_FunctionAddress, "ReturnValue");
		CanExecute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanExecute_FunctionAddress, "ReturnValue");
		CanExecute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanExecute_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanExecute_IsValid = CanExecute_FunctionAddress != IntPtr.Zero && CanExecute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:CanExecute", CanExecute_IsValid);
		AddMappedSkeletalMesh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddMappedSkeletalMesh");
		AddMappedSkeletalMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMappedSkeletalMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMappedSkeletalMesh_SkeletalMeshComponent_PropertyAddress, AddMappedSkeletalMesh_FunctionAddress, "SkeletalMeshComponent");
		AddMappedSkeletalMesh_SkeletalMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(AddMappedSkeletalMesh_FunctionAddress, "SkeletalMeshComponent");
		AddMappedSkeletalMesh_SkeletalMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMappedSkeletalMesh_FunctionAddress, "SkeletalMeshComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMappedSkeletalMesh_Bones_PropertyAddress, AddMappedSkeletalMesh_FunctionAddress, "Bones");
		AddMappedSkeletalMesh_Bones_Offset = NativeReflectionCached.GetPropertyOffset(AddMappedSkeletalMesh_FunctionAddress, "Bones");
		AddMappedSkeletalMesh_Bones_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMappedSkeletalMesh_FunctionAddress, "Bones", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMappedSkeletalMesh_Curves_PropertyAddress, AddMappedSkeletalMesh_FunctionAddress, "Curves");
		AddMappedSkeletalMesh_Curves_Offset = NativeReflectionCached.GetPropertyOffset(AddMappedSkeletalMesh_FunctionAddress, "Curves");
		AddMappedSkeletalMesh_Curves_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMappedSkeletalMesh_FunctionAddress, "Curves", Classes.FArrayProperty);
		AddMappedSkeletalMesh_IsValid = AddMappedSkeletalMesh_FunctionAddress != IntPtr.Zero && AddMappedSkeletalMesh_SkeletalMeshComponent_IsValid && AddMappedSkeletalMesh_Bones_IsValid && AddMappedSkeletalMesh_Curves_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:AddMappedSkeletalMesh", AddMappedSkeletalMesh_IsValid);
		AddMappedElements_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddMappedElements");
		AddMappedElements_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMappedElements_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMappedElements_NewMappedElements_PropertyAddress, AddMappedElements_FunctionAddress, "NewMappedElements");
		AddMappedElements_NewMappedElements_Offset = NativeReflectionCached.GetPropertyOffset(AddMappedElements_FunctionAddress, "NewMappedElements");
		AddMappedElements_NewMappedElements_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMappedElements_FunctionAddress, "NewMappedElements", Classes.FArrayProperty);
		AddMappedElements_IsValid = AddMappedElements_FunctionAddress != IntPtr.Zero && AddMappedElements_NewMappedElements_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:AddMappedElements", AddMappedElements_IsValid);
		AddMappedComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddMappedComponents");
		AddMappedComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMappedComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMappedComponents_Components_PropertyAddress, AddMappedComponents_FunctionAddress, "Components");
		AddMappedComponents_Components_Offset = NativeReflectionCached.GetPropertyOffset(AddMappedComponents_FunctionAddress, "Components");
		AddMappedComponents_Components_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMappedComponents_FunctionAddress, "Components", Classes.FArrayProperty);
		AddMappedComponents_IsValid = AddMappedComponents_FunctionAddress != IntPtr.Zero && AddMappedComponents_Components_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:AddMappedComponents", AddMappedComponents_IsValid);
		AddMappedCompleteSkeletalMesh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddMappedCompleteSkeletalMesh");
		AddMappedCompleteSkeletalMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMappedCompleteSkeletalMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMappedCompleteSkeletalMesh_SkeletalMeshComponent_PropertyAddress, AddMappedCompleteSkeletalMesh_FunctionAddress, "SkeletalMeshComponent");
		AddMappedCompleteSkeletalMesh_SkeletalMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(AddMappedCompleteSkeletalMesh_FunctionAddress, "SkeletalMeshComponent");
		AddMappedCompleteSkeletalMesh_SkeletalMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMappedCompleteSkeletalMesh_FunctionAddress, "SkeletalMeshComponent", Classes.FObjectProperty);
		AddMappedCompleteSkeletalMesh_IsValid = AddMappedCompleteSkeletalMesh_FunctionAddress != IntPtr.Zero && AddMappedCompleteSkeletalMesh_SkeletalMeshComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponent:AddMappedCompleteSkeletalMesh", AddMappedCompleteSkeletalMesh_IsValid);
	}
}
