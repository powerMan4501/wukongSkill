using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGMetadata", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGMetadata : UObject
{
	private static bool SetPointAttributes_IsValid;

	private static IntPtr SetPointAttributes_FunctionAddress;

	private static int SetPointAttributes_ParamsSize;

	private static bool SetPointAttributes_Point_IsValid;

	private static FFieldAddress SetPointAttributes_Point_PropertyAddress;

	private static int SetPointAttributes_Point_Offset;

	private static bool SetPointAttributes_Metadata_IsValid;

	private static FFieldAddress SetPointAttributes_Metadata_PropertyAddress;

	private static int SetPointAttributes_Metadata_Offset;

	private static bool SetPointAttributes_OutPoint_IsValid;

	private static FFieldAddress SetPointAttributes_OutPoint_PropertyAddress;

	private static int SetPointAttributes_OutPoint_Offset;

	private static bool SetAttributesByKey_IsValid;

	private static IntPtr SetAttributesByKey_FunctionAddress;

	private static int SetAttributesByKey_ParamsSize;

	private static bool SetAttributesByKey_Key_IsValid;

	private static FFieldAddress SetAttributesByKey_Key_PropertyAddress;

	private static int SetAttributesByKey_Key_Offset;

	private static bool SetAttributesByKey_InMetadata_IsValid;

	private static FFieldAddress SetAttributesByKey_InMetadata_PropertyAddress;

	private static int SetAttributesByKey_InMetadata_Offset;

	private static bool SetAttributesByKey_TargetKey_IsValid;

	private static FFieldAddress SetAttributesByKey_TargetKey_PropertyAddress;

	private static int SetAttributesByKey_TargetKey_Offset;

	private static bool SetAttributesByKey_OutKey_IsValid;

	private static FFieldAddress SetAttributesByKey_OutKey_PropertyAddress;

	private static int SetAttributesByKey_OutKey_Offset;

	private static bool ResetWeightedAttributesByKey_IsValid;

	private static IntPtr ResetWeightedAttributesByKey_FunctionAddress;

	private static int ResetWeightedAttributesByKey_ParamsSize;

	private static bool ResetWeightedAttributesByKey_TargetKey_IsValid;

	private static FFieldAddress ResetWeightedAttributesByKey_TargetKey_PropertyAddress;

	private static int ResetWeightedAttributesByKey_TargetKey_Offset;

	private static bool ResetWeightedAttributesByKey_OutKey_IsValid;

	private static FFieldAddress ResetWeightedAttributesByKey_OutKey_PropertyAddress;

	private static int ResetWeightedAttributesByKey_OutKey_Offset;

	private static bool ResetPointWeightedAttributes_IsValid;

	private static IntPtr ResetPointWeightedAttributes_FunctionAddress;

	private static int ResetPointWeightedAttributes_ParamsSize;

	private static bool ResetPointWeightedAttributes_OutPoint_IsValid;

	private static FFieldAddress ResetPointWeightedAttributes_OutPoint_PropertyAddress;

	private static int ResetPointWeightedAttributes_OutPoint_Offset;

	private static bool RenameAttribute_IsValid;

	private static IntPtr RenameAttribute_FunctionAddress;

	private static int RenameAttribute_ParamsSize;

	private static bool RenameAttribute_AttributeToRename_IsValid;

	private static FFieldAddress RenameAttribute_AttributeToRename_PropertyAddress;

	private static int RenameAttribute_AttributeToRename_Offset;

	private static bool RenameAttribute_NewAttributeName_IsValid;

	private static FFieldAddress RenameAttribute_NewAttributeName_PropertyAddress;

	private static int RenameAttribute_NewAttributeName_Offset;

	private static bool RenameAttribute_ReturnValue_IsValid;

	private static FFieldAddress RenameAttribute_ReturnValue_PropertyAddress;

	private static int RenameAttribute_ReturnValue_Offset;

	private static bool MergePointAttributes_IsValid;

	private static IntPtr MergePointAttributes_FunctionAddress;

	private static int MergePointAttributes_ParamsSize;

	private static bool MergePointAttributes_PointA_IsValid;

	private static FFieldAddress MergePointAttributes_PointA_PropertyAddress;

	private static int MergePointAttributes_PointA_Offset;

	private static bool MergePointAttributes_MetadataA_IsValid;

	private static FFieldAddress MergePointAttributes_MetadataA_PropertyAddress;

	private static int MergePointAttributes_MetadataA_Offset;

	private static bool MergePointAttributes_PointB_IsValid;

	private static FFieldAddress MergePointAttributes_PointB_PropertyAddress;

	private static int MergePointAttributes_PointB_Offset;

	private static bool MergePointAttributes_MetadataB_IsValid;

	private static FFieldAddress MergePointAttributes_MetadataB_PropertyAddress;

	private static int MergePointAttributes_MetadataB_Offset;

	private static bool MergePointAttributes_TargetPoint_IsValid;

	private static FFieldAddress MergePointAttributes_TargetPoint_PropertyAddress;

	private static int MergePointAttributes_TargetPoint_Offset;

	private static bool MergePointAttributes_Op_IsValid;

	private static FFieldAddress MergePointAttributes_Op_PropertyAddress;

	private static int MergePointAttributes_Op_Offset;

	private static bool MergeAttributesByKey_IsValid;

	private static IntPtr MergeAttributesByKey_FunctionAddress;

	private static int MergeAttributesByKey_ParamsSize;

	private static bool MergeAttributesByKey_KeyA_IsValid;

	private static FFieldAddress MergeAttributesByKey_KeyA_PropertyAddress;

	private static int MergeAttributesByKey_KeyA_Offset;

	private static bool MergeAttributesByKey_MetadataA_IsValid;

	private static FFieldAddress MergeAttributesByKey_MetadataA_PropertyAddress;

	private static int MergeAttributesByKey_MetadataA_Offset;

	private static bool MergeAttributesByKey_KeyB_IsValid;

	private static FFieldAddress MergeAttributesByKey_KeyB_PropertyAddress;

	private static int MergeAttributesByKey_KeyB_Offset;

	private static bool MergeAttributesByKey_MetadataB_IsValid;

	private static FFieldAddress MergeAttributesByKey_MetadataB_PropertyAddress;

	private static int MergeAttributesByKey_MetadataB_Offset;

	private static bool MergeAttributesByKey_TargetKey_IsValid;

	private static FFieldAddress MergeAttributesByKey_TargetKey_PropertyAddress;

	private static int MergeAttributesByKey_TargetKey_Offset;

	private static bool MergeAttributesByKey_Op_IsValid;

	private static FFieldAddress MergeAttributesByKey_Op_PropertyAddress;

	private static int MergeAttributesByKey_Op_Offset;

	private static bool MergeAttributesByKey_OutKey_IsValid;

	private static FFieldAddress MergeAttributesByKey_OutKey_PropertyAddress;

	private static int MergeAttributesByKey_OutKey_Offset;

	private static bool InitializeWithAttributeFilter_IsValid;

	private static IntPtr InitializeWithAttributeFilter_FunctionAddress;

	private static int InitializeWithAttributeFilter_ParamsSize;

	private static bool InitializeWithAttributeFilter_InParent_IsValid;

	private static FFieldAddress InitializeWithAttributeFilter_InParent_PropertyAddress;

	private static int InitializeWithAttributeFilter_InParent_Offset;

	private static bool InitializeWithAttributeFilter_InFilteredAttributes_IsValid;

	private static FFieldAddress InitializeWithAttributeFilter_InFilteredAttributes_PropertyAddress;

	private static int InitializeWithAttributeFilter_InFilteredAttributes_Offset;

	private static bool InitializeWithAttributeFilter_InFilterMode_IsValid;

	private static FFieldAddress InitializeWithAttributeFilter_InFilterMode_PropertyAddress;

	private static int InitializeWithAttributeFilter_InFilterMode_Offset;

	private static bool InitializeAsCopyWithAttributeFilter_IsValid;

	private static IntPtr InitializeAsCopyWithAttributeFilter_FunctionAddress;

	private static int InitializeAsCopyWithAttributeFilter_ParamsSize;

	private static bool InitializeAsCopyWithAttributeFilter_InMetadataToCopy_IsValid;

	private static FFieldAddress InitializeAsCopyWithAttributeFilter_InMetadataToCopy_PropertyAddress;

	private static int InitializeAsCopyWithAttributeFilter_InMetadataToCopy_Offset;

	private static bool InitializeAsCopyWithAttributeFilter_InFilteredAttributes_IsValid;

	private static FFieldAddress InitializeAsCopyWithAttributeFilter_InFilteredAttributes_PropertyAddress;

	private static int InitializeAsCopyWithAttributeFilter_InFilteredAttributes_Offset;

	private static bool InitializeAsCopyWithAttributeFilter_InFilterMode_IsValid;

	private static FFieldAddress InitializeAsCopyWithAttributeFilter_InFilterMode_PropertyAddress;

	private static int InitializeAsCopyWithAttributeFilter_InFilterMode_Offset;

	private static bool InitializeAsCopy_IsValid;

	private static IntPtr InitializeAsCopy_FunctionAddress;

	private static int InitializeAsCopy_ParamsSize;

	private static bool InitializeAsCopy_InMetadataToCopy_IsValid;

	private static FFieldAddress InitializeAsCopy_InMetadataToCopy_PropertyAddress;

	private static int InitializeAsCopy_InMetadataToCopy_Offset;

	private static bool Initialize_IsValid;

	private static IntPtr Initialize_FunctionAddress;

	private static int Initialize_ParamsSize;

	private static bool Initialize_InParent_IsValid;

	private static FFieldAddress Initialize_InParent_PropertyAddress;

	private static int Initialize_InParent_Offset;

	private static bool HasCommonAttributes_IsValid;

	private static IntPtr HasCommonAttributes_FunctionAddress;

	private static int HasCommonAttributes_ParamsSize;

	private static bool HasCommonAttributes_InMetadata_IsValid;

	private static FFieldAddress HasCommonAttributes_InMetadata_PropertyAddress;

	private static int HasCommonAttributes_InMetadata_Offset;

	private static bool HasCommonAttributes_ReturnValue_IsValid;

	private static FFieldAddress HasCommonAttributes_ReturnValue_PropertyAddress;

	private static int HasCommonAttributes_ReturnValue_Offset;

	private static bool HasAttribute_IsValid;

	private static IntPtr HasAttribute_FunctionAddress;

	private static int HasAttribute_ParamsSize;

	private static bool HasAttribute_AttributeName_IsValid;

	private static FFieldAddress HasAttribute_AttributeName_PropertyAddress;

	private static int HasAttribute_AttributeName_Offset;

	private static bool HasAttribute_ReturnValue_IsValid;

	private static FFieldAddress HasAttribute_ReturnValue_PropertyAddress;

	private static int HasAttribute_ReturnValue_Offset;

	private static bool GetAttributes_IsValid;

	private static IntPtr GetAttributes_FunctionAddress;

	private static int GetAttributes_ParamsSize;

	private static bool GetAttributes_AttributeNames_IsValid;

	private static FFieldAddress GetAttributes_AttributeNames_PropertyAddress;

	private static int GetAttributes_AttributeNames_Offset;

	private static bool GetAttributes_AttributeTypes_IsValid;

	private static FFieldAddress GetAttributes_AttributeTypes_PropertyAddress;

	private static int GetAttributes_AttributeTypes_Offset;

	private static bool Flatten_IsValid;

	private static IntPtr Flatten_FunctionAddress;

	private static int Flatten_ParamsSize;

	private static bool DeleteAttribute_IsValid;

	private static IntPtr DeleteAttribute_FunctionAddress;

	private static int DeleteAttribute_ParamsSize;

	private static bool DeleteAttribute_AttributeName_IsValid;

	private static FFieldAddress DeleteAttribute_AttributeName_PropertyAddress;

	private static int DeleteAttribute_AttributeName_Offset;

	private static bool CreateVectorAttribute_IsValid;

	private static IntPtr CreateVectorAttribute_FunctionAddress;

	private static int CreateVectorAttribute_ParamsSize;

	private static bool CreateVectorAttribute_AttributeName_IsValid;

	private static FFieldAddress CreateVectorAttribute_AttributeName_PropertyAddress;

	private static int CreateVectorAttribute_AttributeName_Offset;

	private static bool CreateVectorAttribute_DefaultValue_IsValid;

	private static FFieldAddress CreateVectorAttribute_DefaultValue_PropertyAddress;

	private static int CreateVectorAttribute_DefaultValue_Offset;

	private static bool CreateVectorAttribute_bAllowsInterpolation_IsValid;

	private static FFieldAddress CreateVectorAttribute_bAllowsInterpolation_PropertyAddress;

	private static int CreateVectorAttribute_bAllowsInterpolation_Offset;

	private static bool CreateVectorAttribute_bOverrideParent_IsValid;

	private static FFieldAddress CreateVectorAttribute_bOverrideParent_PropertyAddress;

	private static int CreateVectorAttribute_bOverrideParent_Offset;

	private static bool CreateVector4Attribute_IsValid;

	private static IntPtr CreateVector4Attribute_FunctionAddress;

	private static int CreateVector4Attribute_ParamsSize;

	private static bool CreateVector4Attribute_AttributeName_IsValid;

	private static FFieldAddress CreateVector4Attribute_AttributeName_PropertyAddress;

	private static int CreateVector4Attribute_AttributeName_Offset;

	private static bool CreateVector4Attribute_DefaultValue_IsValid;

	private static FFieldAddress CreateVector4Attribute_DefaultValue_PropertyAddress;

	private static int CreateVector4Attribute_DefaultValue_Offset;

	private static bool CreateVector4Attribute_bAllowsInterpolation_IsValid;

	private static FFieldAddress CreateVector4Attribute_bAllowsInterpolation_PropertyAddress;

	private static int CreateVector4Attribute_bAllowsInterpolation_Offset;

	private static bool CreateVector4Attribute_bOverrideParent_IsValid;

	private static FFieldAddress CreateVector4Attribute_bOverrideParent_PropertyAddress;

	private static int CreateVector4Attribute_bOverrideParent_Offset;

	private static bool CreateVector2Attribute_IsValid;

	private static IntPtr CreateVector2Attribute_FunctionAddress;

	private static int CreateVector2Attribute_ParamsSize;

	private static bool CreateVector2Attribute_AttributeName_IsValid;

	private static FFieldAddress CreateVector2Attribute_AttributeName_PropertyAddress;

	private static int CreateVector2Attribute_AttributeName_Offset;

	private static bool CreateVector2Attribute_DefaultValue_IsValid;

	private static FFieldAddress CreateVector2Attribute_DefaultValue_PropertyAddress;

	private static int CreateVector2Attribute_DefaultValue_Offset;

	private static bool CreateVector2Attribute_bAllowsInterpolation_IsValid;

	private static FFieldAddress CreateVector2Attribute_bAllowsInterpolation_PropertyAddress;

	private static int CreateVector2Attribute_bAllowsInterpolation_Offset;

	private static bool CreateVector2Attribute_bOverrideParent_IsValid;

	private static FFieldAddress CreateVector2Attribute_bOverrideParent_PropertyAddress;

	private static int CreateVector2Attribute_bOverrideParent_Offset;

	private static bool CreateTransformAttribute_IsValid;

	private static IntPtr CreateTransformAttribute_FunctionAddress;

	private static int CreateTransformAttribute_ParamsSize;

	private static bool CreateTransformAttribute_AttributeName_IsValid;

	private static FFieldAddress CreateTransformAttribute_AttributeName_PropertyAddress;

	private static int CreateTransformAttribute_AttributeName_Offset;

	private static bool CreateTransformAttribute_DefaultValue_IsValid;

	private static FFieldAddress CreateTransformAttribute_DefaultValue_PropertyAddress;

	private static int CreateTransformAttribute_DefaultValue_Offset;

	private static bool CreateTransformAttribute_bAllowsInterpolation_IsValid;

	private static FFieldAddress CreateTransformAttribute_bAllowsInterpolation_PropertyAddress;

	private static int CreateTransformAttribute_bAllowsInterpolation_Offset;

	private static bool CreateTransformAttribute_bOverrideParent_IsValid;

	private static FFieldAddress CreateTransformAttribute_bOverrideParent_PropertyAddress;

	private static int CreateTransformAttribute_bOverrideParent_Offset;

	private static bool CreateStringAttribute_IsValid;

	private static IntPtr CreateStringAttribute_FunctionAddress;

	private static int CreateStringAttribute_ParamsSize;

	private static bool CreateStringAttribute_AttributeName_IsValid;

	private static FFieldAddress CreateStringAttribute_AttributeName_PropertyAddress;

	private static int CreateStringAttribute_AttributeName_Offset;

	private static bool CreateStringAttribute_DefaultValue_IsValid;

	private static FFieldAddress CreateStringAttribute_DefaultValue_PropertyAddress;

	private static int CreateStringAttribute_DefaultValue_Offset;

	private static bool CreateStringAttribute_bAllowsInterpolation_IsValid;

	private static FFieldAddress CreateStringAttribute_bAllowsInterpolation_PropertyAddress;

	private static int CreateStringAttribute_bAllowsInterpolation_Offset;

	private static bool CreateStringAttribute_bOverrideParent_IsValid;

	private static FFieldAddress CreateStringAttribute_bOverrideParent_PropertyAddress;

	private static int CreateStringAttribute_bOverrideParent_Offset;

	private static bool CreateRotatorAttribute_IsValid;

	private static IntPtr CreateRotatorAttribute_FunctionAddress;

	private static int CreateRotatorAttribute_ParamsSize;

	private static bool CreateRotatorAttribute_AttributeName_IsValid;

	private static FFieldAddress CreateRotatorAttribute_AttributeName_PropertyAddress;

	private static int CreateRotatorAttribute_AttributeName_Offset;

	private static bool CreateRotatorAttribute_DefaultValue_IsValid;

	private static FFieldAddress CreateRotatorAttribute_DefaultValue_PropertyAddress;

	private static int CreateRotatorAttribute_DefaultValue_Offset;

	private static bool CreateRotatorAttribute_bAllowsInterpolation_IsValid;

	private static FFieldAddress CreateRotatorAttribute_bAllowsInterpolation_PropertyAddress;

	private static int CreateRotatorAttribute_bAllowsInterpolation_Offset;

	private static bool CreateRotatorAttribute_bOverrideParent_IsValid;

	private static FFieldAddress CreateRotatorAttribute_bOverrideParent_PropertyAddress;

	private static int CreateRotatorAttribute_bOverrideParent_Offset;

	private static bool CreateQuatAttribute_IsValid;

	private static IntPtr CreateQuatAttribute_FunctionAddress;

	private static int CreateQuatAttribute_ParamsSize;

	private static bool CreateQuatAttribute_AttributeName_IsValid;

	private static FFieldAddress CreateQuatAttribute_AttributeName_PropertyAddress;

	private static int CreateQuatAttribute_AttributeName_Offset;

	private static bool CreateQuatAttribute_DefaultValue_IsValid;

	private static FFieldAddress CreateQuatAttribute_DefaultValue_PropertyAddress;

	private static int CreateQuatAttribute_DefaultValue_Offset;

	private static bool CreateQuatAttribute_bAllowsInterpolation_IsValid;

	private static FFieldAddress CreateQuatAttribute_bAllowsInterpolation_PropertyAddress;

	private static int CreateQuatAttribute_bAllowsInterpolation_Offset;

	private static bool CreateQuatAttribute_bOverrideParent_IsValid;

	private static FFieldAddress CreateQuatAttribute_bOverrideParent_PropertyAddress;

	private static int CreateQuatAttribute_bOverrideParent_Offset;

	private static bool CreateNameAttribute_IsValid;

	private static IntPtr CreateNameAttribute_FunctionAddress;

	private static int CreateNameAttribute_ParamsSize;

	private static bool CreateNameAttribute_AttributeName_IsValid;

	private static FFieldAddress CreateNameAttribute_AttributeName_PropertyAddress;

	private static int CreateNameAttribute_AttributeName_Offset;

	private static bool CreateNameAttribute_DefaultValue_IsValid;

	private static FFieldAddress CreateNameAttribute_DefaultValue_PropertyAddress;

	private static int CreateNameAttribute_DefaultValue_Offset;

	private static bool CreateNameAttribute_bAllowsInterpolation_IsValid;

	private static FFieldAddress CreateNameAttribute_bAllowsInterpolation_PropertyAddress;

	private static int CreateNameAttribute_bAllowsInterpolation_Offset;

	private static bool CreateNameAttribute_bOverrideParent_IsValid;

	private static FFieldAddress CreateNameAttribute_bOverrideParent_PropertyAddress;

	private static int CreateNameAttribute_bOverrideParent_Offset;

	private static bool CreateInteger64Attribute_IsValid;

	private static IntPtr CreateInteger64Attribute_FunctionAddress;

	private static int CreateInteger64Attribute_ParamsSize;

	private static bool CreateInteger64Attribute_AttributeName_IsValid;

	private static FFieldAddress CreateInteger64Attribute_AttributeName_PropertyAddress;

	private static int CreateInteger64Attribute_AttributeName_Offset;

	private static bool CreateInteger64Attribute_DefaultValue_IsValid;

	private static FFieldAddress CreateInteger64Attribute_DefaultValue_PropertyAddress;

	private static int CreateInteger64Attribute_DefaultValue_Offset;

	private static bool CreateInteger64Attribute_bAllowsInterpolation_IsValid;

	private static FFieldAddress CreateInteger64Attribute_bAllowsInterpolation_PropertyAddress;

	private static int CreateInteger64Attribute_bAllowsInterpolation_Offset;

	private static bool CreateInteger64Attribute_bOverrideParent_IsValid;

	private static FFieldAddress CreateInteger64Attribute_bOverrideParent_PropertyAddress;

	private static int CreateInteger64Attribute_bOverrideParent_Offset;

	private static bool CreateInteger32Attribute_IsValid;

	private static IntPtr CreateInteger32Attribute_FunctionAddress;

	private static int CreateInteger32Attribute_ParamsSize;

	private static bool CreateInteger32Attribute_AttributeName_IsValid;

	private static FFieldAddress CreateInteger32Attribute_AttributeName_PropertyAddress;

	private static int CreateInteger32Attribute_AttributeName_Offset;

	private static bool CreateInteger32Attribute_DefaultValue_IsValid;

	private static FFieldAddress CreateInteger32Attribute_DefaultValue_PropertyAddress;

	private static int CreateInteger32Attribute_DefaultValue_Offset;

	private static bool CreateInteger32Attribute_bAllowsInterpolation_IsValid;

	private static FFieldAddress CreateInteger32Attribute_bAllowsInterpolation_PropertyAddress;

	private static int CreateInteger32Attribute_bAllowsInterpolation_Offset;

	private static bool CreateInteger32Attribute_bOverrideParent_IsValid;

	private static FFieldAddress CreateInteger32Attribute_bOverrideParent_PropertyAddress;

	private static int CreateInteger32Attribute_bOverrideParent_Offset;

	private static bool CreateFloatAttribute_IsValid;

	private static IntPtr CreateFloatAttribute_FunctionAddress;

	private static int CreateFloatAttribute_ParamsSize;

	private static bool CreateFloatAttribute_AttributeName_IsValid;

	private static FFieldAddress CreateFloatAttribute_AttributeName_PropertyAddress;

	private static int CreateFloatAttribute_AttributeName_Offset;

	private static bool CreateFloatAttribute_DefaultValue_IsValid;

	private static FFieldAddress CreateFloatAttribute_DefaultValue_PropertyAddress;

	private static int CreateFloatAttribute_DefaultValue_Offset;

	private static bool CreateFloatAttribute_bAllowsInterpolation_IsValid;

	private static FFieldAddress CreateFloatAttribute_bAllowsInterpolation_PropertyAddress;

	private static int CreateFloatAttribute_bAllowsInterpolation_Offset;

	private static bool CreateFloatAttribute_bOverrideParent_IsValid;

	private static FFieldAddress CreateFloatAttribute_bOverrideParent_PropertyAddress;

	private static int CreateFloatAttribute_bOverrideParent_Offset;

	private static bool CreateDoubleAttribute_IsValid;

	private static IntPtr CreateDoubleAttribute_FunctionAddress;

	private static int CreateDoubleAttribute_ParamsSize;

	private static bool CreateDoubleAttribute_AttributeName_IsValid;

	private static FFieldAddress CreateDoubleAttribute_AttributeName_PropertyAddress;

	private static int CreateDoubleAttribute_AttributeName_Offset;

	private static bool CreateDoubleAttribute_DefaultValue_IsValid;

	private static FFieldAddress CreateDoubleAttribute_DefaultValue_PropertyAddress;

	private static int CreateDoubleAttribute_DefaultValue_Offset;

	private static bool CreateDoubleAttribute_bAllowsInterpolation_IsValid;

	private static FFieldAddress CreateDoubleAttribute_bAllowsInterpolation_PropertyAddress;

	private static int CreateDoubleAttribute_bAllowsInterpolation_Offset;

	private static bool CreateDoubleAttribute_bOverrideParent_IsValid;

	private static FFieldAddress CreateDoubleAttribute_bOverrideParent_PropertyAddress;

	private static int CreateDoubleAttribute_bOverrideParent_Offset;

	private static bool CreateBoolAttribute_IsValid;

	private static IntPtr CreateBoolAttribute_FunctionAddress;

	private static int CreateBoolAttribute_ParamsSize;

	private static bool CreateBoolAttribute_AttributeName_IsValid;

	private static FFieldAddress CreateBoolAttribute_AttributeName_PropertyAddress;

	private static int CreateBoolAttribute_AttributeName_Offset;

	private static bool CreateBoolAttribute_DefaultValue_IsValid;

	private static FFieldAddress CreateBoolAttribute_DefaultValue_PropertyAddress;

	private static int CreateBoolAttribute_DefaultValue_Offset;

	private static bool CreateBoolAttribute_bAllowsInterpolation_IsValid;

	private static FFieldAddress CreateBoolAttribute_bAllowsInterpolation_PropertyAddress;

	private static int CreateBoolAttribute_bAllowsInterpolation_Offset;

	private static bool CreateBoolAttribute_bOverrideParent_IsValid;

	private static FFieldAddress CreateBoolAttribute_bOverrideParent_PropertyAddress;

	private static int CreateBoolAttribute_bOverrideParent_Offset;

	private static bool CopyExistingAttribute_IsValid;

	private static IntPtr CopyExistingAttribute_FunctionAddress;

	private static int CopyExistingAttribute_ParamsSize;

	private static bool CopyExistingAttribute_AttributeToCopy_IsValid;

	private static FFieldAddress CopyExistingAttribute_AttributeToCopy_PropertyAddress;

	private static int CopyExistingAttribute_AttributeToCopy_Offset;

	private static bool CopyExistingAttribute_NewAttributeName_IsValid;

	private static FFieldAddress CopyExistingAttribute_NewAttributeName_PropertyAddress;

	private static int CopyExistingAttribute_NewAttributeName_Offset;

	private static bool CopyExistingAttribute_bKeepParent_IsValid;

	private static FFieldAddress CopyExistingAttribute_bKeepParent_PropertyAddress;

	private static int CopyExistingAttribute_bKeepParent_Offset;

	private static bool CopyExistingAttribute_ReturnValue_IsValid;

	private static FFieldAddress CopyExistingAttribute_ReturnValue_PropertyAddress;

	private static int CopyExistingAttribute_ReturnValue_Offset;

	private static bool CopyAttributes_IsValid;

	private static IntPtr CopyAttributes_FunctionAddress;

	private static int CopyAttributes_ParamsSize;

	private static bool CopyAttributes_InOther_IsValid;

	private static FFieldAddress CopyAttributes_InOther_PropertyAddress;

	private static int CopyAttributes_InOther_Offset;

	private static bool CopyAttribute_IsValid;

	private static IntPtr CopyAttribute_FunctionAddress;

	private static int CopyAttribute_ParamsSize;

	private static bool CopyAttribute_InOther_IsValid;

	private static FFieldAddress CopyAttribute_InOther_PropertyAddress;

	private static int CopyAttribute_InOther_Offset;

	private static bool CopyAttribute_AttributeToCopy_IsValid;

	private static FFieldAddress CopyAttribute_AttributeToCopy_PropertyAddress;

	private static int CopyAttribute_AttributeToCopy_Offset;

	private static bool CopyAttribute_NewAttributeName_IsValid;

	private static FFieldAddress CopyAttribute_NewAttributeName_PropertyAddress;

	private static int CopyAttribute_NewAttributeName_Offset;

	private static bool ClearAttribute_IsValid;

	private static IntPtr ClearAttribute_FunctionAddress;

	private static int ClearAttribute_ParamsSize;

	private static bool ClearAttribute_AttributeToClear_IsValid;

	private static FFieldAddress ClearAttribute_AttributeToClear_PropertyAddress;

	private static int ClearAttribute_AttributeToClear_Offset;

	private static bool AddEntry_IsValid;

	private static IntPtr AddEntry_FunctionAddress;

	private static int AddEntry_ParamsSize;

	private static bool AddEntry_ParentEntryKey_IsValid;

	private static FFieldAddress AddEntry_ParentEntryKey_PropertyAddress;

	private static int AddEntry_ParentEntryKey_Offset;

	private static bool AddEntry_ReturnValue_IsValid;

	private static FFieldAddress AddEntry_ReturnValue_PropertyAddress;

	private static int AddEntry_ReturnValue_Offset;

	private static bool AddAttributesFiltered_IsValid;

	private static IntPtr AddAttributesFiltered_FunctionAddress;

	private static int AddAttributesFiltered_ParamsSize;

	private static bool AddAttributesFiltered_InOther_IsValid;

	private static FFieldAddress AddAttributesFiltered_InOther_PropertyAddress;

	private static int AddAttributesFiltered_InOther_Offset;

	private static bool AddAttributesFiltered_InFilteredAttributes_IsValid;

	private static FFieldAddress AddAttributesFiltered_InFilteredAttributes_PropertyAddress;

	private static int AddAttributesFiltered_InFilteredAttributes_Offset;

	private static bool AddAttributesFiltered_InFilterMode_IsValid;

	private static FFieldAddress AddAttributesFiltered_InFilterMode_PropertyAddress;

	private static int AddAttributesFiltered_InFilterMode_Offset;

	private static bool AddAttributes_IsValid;

	private static IntPtr AddAttributes_FunctionAddress;

	private static int AddAttributes_ParamsSize;

	private static bool AddAttributes_InOther_IsValid;

	private static FFieldAddress AddAttributes_InOther_PropertyAddress;

	private static int AddAttributes_InOther_Offset;

	private static bool AddAttribute_IsValid;

	private static IntPtr AddAttribute_FunctionAddress;

	private static int AddAttribute_ParamsSize;

	private static bool AddAttribute_InOther_IsValid;

	private static FFieldAddress AddAttribute_InOther_PropertyAddress;

	private static int AddAttribute_InOther_Offset;

	private static bool AddAttribute_AttributeName_IsValid;

	private static FFieldAddress AddAttribute_AttributeName_PropertyAddress;

	private static int AddAttribute_AttributeName_Offset;

	private static bool AccumulateWeightedAttributesByKey_IsValid;

	private static IntPtr AccumulateWeightedAttributesByKey_FunctionAddress;

	private static int AccumulateWeightedAttributesByKey_ParamsSize;

	private static bool AccumulateWeightedAttributesByKey_Key_IsValid;

	private static FFieldAddress AccumulateWeightedAttributesByKey_Key_PropertyAddress;

	private static int AccumulateWeightedAttributesByKey_Key_Offset;

	private static bool AccumulateWeightedAttributesByKey_Metadata_IsValid;

	private static FFieldAddress AccumulateWeightedAttributesByKey_Metadata_PropertyAddress;

	private static int AccumulateWeightedAttributesByKey_Metadata_Offset;

	private static bool AccumulateWeightedAttributesByKey_Weight_IsValid;

	private static FFieldAddress AccumulateWeightedAttributesByKey_Weight_PropertyAddress;

	private static int AccumulateWeightedAttributesByKey_Weight_Offset;

	private static bool AccumulateWeightedAttributesByKey_bSetNonInterpolableAttributes_IsValid;

	private static FFieldAddress AccumulateWeightedAttributesByKey_bSetNonInterpolableAttributes_PropertyAddress;

	private static int AccumulateWeightedAttributesByKey_bSetNonInterpolableAttributes_Offset;

	private static bool AccumulateWeightedAttributesByKey_TargetKey_IsValid;

	private static FFieldAddress AccumulateWeightedAttributesByKey_TargetKey_PropertyAddress;

	private static int AccumulateWeightedAttributesByKey_TargetKey_Offset;

	private static bool AccumulateWeightedAttributesByKey_OutKey_IsValid;

	private static FFieldAddress AccumulateWeightedAttributesByKey_OutKey_PropertyAddress;

	private static int AccumulateWeightedAttributesByKey_OutKey_Offset;

	private static bool AccumulatePointWeightedAttributes_IsValid;

	private static IntPtr AccumulatePointWeightedAttributes_FunctionAddress;

	private static int AccumulatePointWeightedAttributes_ParamsSize;

	private static bool AccumulatePointWeightedAttributes_InPoint_IsValid;

	private static FFieldAddress AccumulatePointWeightedAttributes_InPoint_PropertyAddress;

	private static int AccumulatePointWeightedAttributes_InPoint_Offset;

	private static bool AccumulatePointWeightedAttributes_InMetadata_IsValid;

	private static FFieldAddress AccumulatePointWeightedAttributes_InMetadata_PropertyAddress;

	private static int AccumulatePointWeightedAttributes_InMetadata_Offset;

	private static bool AccumulatePointWeightedAttributes_Weight_IsValid;

	private static FFieldAddress AccumulatePointWeightedAttributes_Weight_PropertyAddress;

	private static int AccumulatePointWeightedAttributes_Weight_Offset;

	private static bool AccumulatePointWeightedAttributes_bSetNonInterpolableAttributes_IsValid;

	private static FFieldAddress AccumulatePointWeightedAttributes_bSetNonInterpolableAttributes_PropertyAddress;

	private static int AccumulatePointWeightedAttributes_bSetNonInterpolableAttributes_Offset;

	private static bool AccumulatePointWeightedAttributes_OutPoint_IsValid;

	private static FFieldAddress AccumulatePointWeightedAttributes_OutPoint_PropertyAddress;

	private static int AccumulatePointWeightedAttributes_OutPoint_Offset;

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/PCG.PCGMetadata:SetPointAttributes")]
	public unsafe void SetPointAttributes(FPCGPoint Point, UPCGMetadata Metadata, ref FPCGPoint OutPoint)
	{
		CheckDestroyed();
		if (!SetPointAttributes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:SetPointAttributes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPointAttributes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPointAttributes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetPointAttributes_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, SetPointAttributes_Point_Offset), 0, SetPointAttributes_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetPointAttributes_Metadata_Offset), 0, SetPointAttributes_Metadata_PropertyAddress.Address, Metadata);
		NativeReflection.InitializeValue_InContainer(SetPointAttributes_OutPoint_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, SetPointAttributes_OutPoint_Offset), 0, SetPointAttributes_OutPoint_PropertyAddress.Address, OutPoint);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPointAttributes_FunctionAddress, intPtr, SetPointAttributes_ParamsSize);
		OutPoint = FPCGPoint.FromNative(IntPtr.Add(intPtr, SetPointAttributes_OutPoint_Offset), 0, SetPointAttributes_OutPoint_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/PCG.PCGMetadata:SetAttributesByKey")]
	public unsafe void SetAttributesByKey(long Key, UPCGMetadata InMetadata, long TargetKey, out long OutKey)
	{
		CheckDestroyed();
		if (!SetAttributesByKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:SetAttributesByKey");
			OutKey = 0L;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAttributesByKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAttributesByKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, SetAttributesByKey_Key_Offset), 0, SetAttributesByKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetAttributesByKey_InMetadata_Offset), 0, SetAttributesByKey_InMetadata_PropertyAddress.Address, InMetadata);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, SetAttributesByKey_TargetKey_Offset), 0, SetAttributesByKey_TargetKey_PropertyAddress.Address, TargetKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAttributesByKey_FunctionAddress, intPtr, SetAttributesByKey_ParamsSize);
		OutKey = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, SetAttributesByKey_OutKey_Offset), 0, SetAttributesByKey_OutKey_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/PCG.PCGMetadata:ResetWeightedAttributesByKey")]
	public unsafe void ResetWeightedAttributesByKey(long TargetKey, out long OutKey)
	{
		CheckDestroyed();
		if (!ResetWeightedAttributesByKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:ResetWeightedAttributesByKey");
			OutKey = 0L;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetWeightedAttributesByKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetWeightedAttributesByKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, ResetWeightedAttributesByKey_TargetKey_Offset), 0, ResetWeightedAttributesByKey_TargetKey_PropertyAddress.Address, TargetKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, ResetWeightedAttributesByKey_FunctionAddress, intPtr, ResetWeightedAttributesByKey_ParamsSize);
		OutKey = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, ResetWeightedAttributesByKey_OutKey_Offset), 0, ResetWeightedAttributesByKey_OutKey_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/PCG.PCGMetadata:ResetPointWeightedAttributes")]
	public unsafe void ResetPointWeightedAttributes(out FPCGPoint OutPoint)
	{
		CheckDestroyed();
		if (!ResetPointWeightedAttributes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:ResetPointWeightedAttributes");
			OutPoint = default(FPCGPoint);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetPointWeightedAttributes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetPointWeightedAttributes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ResetPointWeightedAttributes_OutPoint_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, ResetPointWeightedAttributes_FunctionAddress, intPtr, ResetPointWeightedAttributes_ParamsSize);
		OutPoint = FPCGPoint.FromNative(IntPtr.Add(intPtr, ResetPointWeightedAttributes_OutPoint_Offset), 0, ResetPointWeightedAttributes_OutPoint_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGMetadata:RenameAttribute")]
	public unsafe bool RenameAttribute(FName AttributeToRename, FName NewAttributeName)
	{
		CheckDestroyed();
		if (!RenameAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:RenameAttribute");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenameAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenameAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RenameAttribute_AttributeToRename_Offset), 0, RenameAttribute_AttributeToRename_PropertyAddress.Address, AttributeToRename);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RenameAttribute_NewAttributeName_Offset), 0, RenameAttribute_NewAttributeName_PropertyAddress.Address, NewAttributeName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RenameAttribute_FunctionAddress, intPtr, RenameAttribute_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RenameAttribute_ReturnValue_Offset), 0, RenameAttribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/PCG.PCGMetadata:MergePointAttributes")]
	public unsafe void MergePointAttributes(FPCGPoint PointA, UPCGMetadata MetadataA, FPCGPoint PointB, UPCGMetadata MetadataB, ref FPCGPoint TargetPoint, EPCGMetadataOp Op)
	{
		CheckDestroyed();
		if (!MergePointAttributes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:MergePointAttributes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MergePointAttributes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MergePointAttributes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(MergePointAttributes_PointA_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, MergePointAttributes_PointA_Offset), 0, MergePointAttributes_PointA_PropertyAddress.Address, PointA);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, MergePointAttributes_MetadataA_Offset), 0, MergePointAttributes_MetadataA_PropertyAddress.Address, MetadataA);
		NativeReflection.InitializeValue_InContainer(MergePointAttributes_PointB_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, MergePointAttributes_PointB_Offset), 0, MergePointAttributes_PointB_PropertyAddress.Address, PointB);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, MergePointAttributes_MetadataB_Offset), 0, MergePointAttributes_MetadataB_PropertyAddress.Address, MetadataB);
		NativeReflection.InitializeValue_InContainer(MergePointAttributes_TargetPoint_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, MergePointAttributes_TargetPoint_Offset), 0, MergePointAttributes_TargetPoint_PropertyAddress.Address, TargetPoint);
		EnumMarshaler<EPCGMetadataOp>.ToNative(IntPtr.Add(intPtr, MergePointAttributes_Op_Offset), 0, MergePointAttributes_Op_PropertyAddress.Address, Op);
		NativeReflection.InvokeFunctionOptimized(base.Address, MergePointAttributes_FunctionAddress, intPtr, MergePointAttributes_ParamsSize);
		TargetPoint = FPCGPoint.FromNative(IntPtr.Add(intPtr, MergePointAttributes_TargetPoint_Offset), 0, MergePointAttributes_TargetPoint_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/PCG.PCGMetadata:MergeAttributesByKey")]
	public unsafe void MergeAttributesByKey(long KeyA, UPCGMetadata MetadataA, long KeyB, UPCGMetadata MetadataB, long TargetKey, EPCGMetadataOp Op, out long OutKey)
	{
		CheckDestroyed();
		if (!MergeAttributesByKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:MergeAttributesByKey");
			OutKey = 0L;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MergeAttributesByKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MergeAttributesByKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, MergeAttributesByKey_KeyA_Offset), 0, MergeAttributesByKey_KeyA_PropertyAddress.Address, KeyA);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, MergeAttributesByKey_MetadataA_Offset), 0, MergeAttributesByKey_MetadataA_PropertyAddress.Address, MetadataA);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, MergeAttributesByKey_KeyB_Offset), 0, MergeAttributesByKey_KeyB_PropertyAddress.Address, KeyB);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, MergeAttributesByKey_MetadataB_Offset), 0, MergeAttributesByKey_MetadataB_PropertyAddress.Address, MetadataB);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, MergeAttributesByKey_TargetKey_Offset), 0, MergeAttributesByKey_TargetKey_PropertyAddress.Address, TargetKey);
		EnumMarshaler<EPCGMetadataOp>.ToNative(IntPtr.Add(intPtr, MergeAttributesByKey_Op_Offset), 0, MergeAttributesByKey_Op_PropertyAddress.Address, Op);
		NativeReflection.InvokeFunctionOptimized(base.Address, MergeAttributesByKey_FunctionAddress, intPtr, MergeAttributesByKey_ParamsSize);
		OutKey = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, MergeAttributesByKey_OutKey_Offset), 0, MergeAttributesByKey_OutKey_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/PCG.PCGMetadata:InitializeWithAttributeFilter")]
	public unsafe void InitializeWithAttributeFilter(UPCGMetadata InParent, HashSet<FName> InFilteredAttributes, EPCGMetadataFilterMode InFilterMode = EPCGMetadataFilterMode.ExcludeAttributes)
	{
		CheckDestroyed();
		if (!InitializeWithAttributeFilter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:InitializeWithAttributeFilter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitializeWithAttributeFilter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitializeWithAttributeFilter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, InitializeWithAttributeFilter_InParent_Offset), 0, InitializeWithAttributeFilter_InParent_PropertyAddress.Address, InParent);
		NativeReflection.InitializeValue_InContainer(InitializeWithAttributeFilter_InFilteredAttributes_PropertyAddress.Address, intPtr);
		new TSetCopyMarshaler<FName>(1, InitializeWithAttributeFilter_InFilteredAttributes_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, InitializeWithAttributeFilter_InFilteredAttributes_Offset), InFilteredAttributes);
		EnumMarshaler<EPCGMetadataFilterMode>.ToNative(IntPtr.Add(intPtr, InitializeWithAttributeFilter_InFilterMode_Offset), 0, InitializeWithAttributeFilter_InFilterMode_PropertyAddress.Address, InFilterMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitializeWithAttributeFilter_FunctionAddress, intPtr, InitializeWithAttributeFilter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InitializeWithAttributeFilter_InFilteredAttributes_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/PCG.PCGMetadata:InitializeAsCopyWithAttributeFilter")]
	public unsafe void InitializeAsCopyWithAttributeFilter(UPCGMetadata InMetadataToCopy, HashSet<FName> InFilteredAttributes, EPCGMetadataFilterMode InFilterMode = EPCGMetadataFilterMode.ExcludeAttributes)
	{
		CheckDestroyed();
		if (!InitializeAsCopyWithAttributeFilter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:InitializeAsCopyWithAttributeFilter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitializeAsCopyWithAttributeFilter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitializeAsCopyWithAttributeFilter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, InitializeAsCopyWithAttributeFilter_InMetadataToCopy_Offset), 0, InitializeAsCopyWithAttributeFilter_InMetadataToCopy_PropertyAddress.Address, InMetadataToCopy);
		NativeReflection.InitializeValue_InContainer(InitializeAsCopyWithAttributeFilter_InFilteredAttributes_PropertyAddress.Address, intPtr);
		new TSetCopyMarshaler<FName>(1, InitializeAsCopyWithAttributeFilter_InFilteredAttributes_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, InitializeAsCopyWithAttributeFilter_InFilteredAttributes_Offset), InFilteredAttributes);
		EnumMarshaler<EPCGMetadataFilterMode>.ToNative(IntPtr.Add(intPtr, InitializeAsCopyWithAttributeFilter_InFilterMode_Offset), 0, InitializeAsCopyWithAttributeFilter_InFilterMode_PropertyAddress.Address, InFilterMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitializeAsCopyWithAttributeFilter_FunctionAddress, intPtr, InitializeAsCopyWithAttributeFilter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InitializeAsCopyWithAttributeFilter_InFilteredAttributes_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGMetadata:InitializeAsCopy")]
	public unsafe void InitializeAsCopy(UPCGMetadata InMetadataToCopy)
	{
		CheckDestroyed();
		if (!InitializeAsCopy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:InitializeAsCopy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitializeAsCopy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitializeAsCopy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, InitializeAsCopy_InMetadataToCopy_Offset), 0, InitializeAsCopy_InMetadataToCopy_PropertyAddress.Address, InMetadataToCopy);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitializeAsCopy_FunctionAddress, intPtr, InitializeAsCopy_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGMetadata:Initialize")]
	public unsafe void Initialize(UPCGMetadata InParent)
	{
		CheckDestroyed();
		if (!Initialize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:Initialize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Initialize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Initialize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, Initialize_InParent_Offset), 0, Initialize_InParent_PropertyAddress.Address, InParent);
		NativeReflection.InvokeFunctionOptimized(base.Address, Initialize_FunctionAddress, intPtr, Initialize_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/PCG.PCGMetadata:HasCommonAttributes")]
	public unsafe bool HasCommonAttributes(UPCGMetadata InMetadata)
	{
		CheckDestroyed();
		if (!HasCommonAttributes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:HasCommonAttributes");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasCommonAttributes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasCommonAttributes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, HasCommonAttributes_InMetadata_Offset), 0, HasCommonAttributes_InMetadata_PropertyAddress.Address, InMetadata);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasCommonAttributes_FunctionAddress, intPtr, HasCommonAttributes_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasCommonAttributes_ReturnValue_Offset), 0, HasCommonAttributes_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/PCG.PCGMetadata:HasAttribute")]
	public unsafe bool HasAttribute(FName AttributeName)
	{
		CheckDestroyed();
		if (!HasAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:HasAttribute");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, HasAttribute_AttributeName_Offset), 0, HasAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasAttribute_FunctionAddress, intPtr, HasAttribute_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasAttribute_ReturnValue_Offset), 0, HasAttribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/PCG.PCGMetadata:GetAttributes")]
	public unsafe void GetAttributes(out List<FName> AttributeNames, out List<EPCGMetadataTypes> AttributeTypes)
	{
		CheckDestroyed();
		if (!GetAttributes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:GetAttributes");
			AttributeNames = null;
			AttributeTypes = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAttributes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAttributes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAttributes_FunctionAddress, intPtr, GetAttributes_ParamsSize);
		AttributeNames = new TArrayCopyMarshaler<FName>(1, GetAttributes_AttributeNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAttributes_AttributeNames_Offset));
		NativeReflection.DestroyValue_InContainer(GetAttributes_AttributeNames_PropertyAddress.Address, intPtr);
		AttributeTypes = new TArrayCopyMarshaler<EPCGMetadataTypes>(1, GetAttributes_AttributeTypes_PropertyAddress, CachedMarshalingDelegates<EPCGMetadataTypes, EnumMarshaler<EPCGMetadataTypes>>.FromNative, CachedMarshalingDelegates<EPCGMetadataTypes, EnumMarshaler<EPCGMetadataTypes>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAttributes_AttributeTypes_Offset));
		NativeReflection.DestroyValue_InContainer(GetAttributes_AttributeTypes_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGMetadata:Flatten")]
	public unsafe void Flatten()
	{
		CheckDestroyed();
		if (!Flatten_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:Flatten");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Flatten_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Flatten_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Flatten_FunctionAddress, argsSize: Flatten_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGMetadata:DeleteAttribute")]
	public unsafe void DeleteAttribute(FName AttributeName)
	{
		CheckDestroyed();
		if (!DeleteAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:DeleteAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, DeleteAttribute_AttributeName_Offset), 0, DeleteAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeFunctionOptimized(base.Address, DeleteAttribute_FunctionAddress, intPtr, DeleteAttribute_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/PCG.PCGMetadata:CreateVectorAttribute")]
	public unsafe void CreateVectorAttribute(FName AttributeName, FVector DefaultValue, bool bAllowsInterpolation, bool bOverrideParent = true)
	{
		CheckDestroyed();
		if (!CreateVectorAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:CreateVectorAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateVectorAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateVectorAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateVectorAttribute_AttributeName_Offset), 0, CreateVectorAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CreateVectorAttribute_DefaultValue_Offset), 0, CreateVectorAttribute_DefaultValue_PropertyAddress.Address, DefaultValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateVectorAttribute_bAllowsInterpolation_Offset), 0, CreateVectorAttribute_bAllowsInterpolation_PropertyAddress.Address, bAllowsInterpolation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateVectorAttribute_bOverrideParent_Offset), 0, CreateVectorAttribute_bOverrideParent_PropertyAddress.Address, bOverrideParent);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateVectorAttribute_FunctionAddress, intPtr, CreateVectorAttribute_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/PCG.PCGMetadata:CreateVector4Attribute")]
	public unsafe void CreateVector4Attribute(FName AttributeName, FVector4 DefaultValue, bool bAllowsInterpolation, bool bOverrideParent = true)
	{
		CheckDestroyed();
		if (!CreateVector4Attribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:CreateVector4Attribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateVector4Attribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateVector4Attribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateVector4Attribute_AttributeName_Offset), 0, CreateVector4Attribute_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(intPtr, CreateVector4Attribute_DefaultValue_Offset), 0, CreateVector4Attribute_DefaultValue_PropertyAddress.Address, DefaultValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateVector4Attribute_bAllowsInterpolation_Offset), 0, CreateVector4Attribute_bAllowsInterpolation_PropertyAddress.Address, bAllowsInterpolation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateVector4Attribute_bOverrideParent_Offset), 0, CreateVector4Attribute_bOverrideParent_PropertyAddress.Address, bOverrideParent);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateVector4Attribute_FunctionAddress, intPtr, CreateVector4Attribute_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/PCG.PCGMetadata:CreateVector2Attribute")]
	public unsafe void CreateVector2Attribute(FName AttributeName, FVector2D DefaultValue, bool bAllowsInterpolation, bool bOverrideParent = true)
	{
		CheckDestroyed();
		if (!CreateVector2Attribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:CreateVector2Attribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateVector2Attribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateVector2Attribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateVector2Attribute_AttributeName_Offset), 0, CreateVector2Attribute_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, CreateVector2Attribute_DefaultValue_Offset), 0, CreateVector2Attribute_DefaultValue_PropertyAddress.Address, DefaultValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateVector2Attribute_bAllowsInterpolation_Offset), 0, CreateVector2Attribute_bAllowsInterpolation_PropertyAddress.Address, bAllowsInterpolation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateVector2Attribute_bOverrideParent_Offset), 0, CreateVector2Attribute_bOverrideParent_PropertyAddress.Address, bOverrideParent);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateVector2Attribute_FunctionAddress, intPtr, CreateVector2Attribute_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/PCG.PCGMetadata:CreateTransformAttribute")]
	public unsafe void CreateTransformAttribute(FName AttributeName, FTransform DefaultValue, bool bAllowsInterpolation, bool bOverrideParent = true)
	{
		CheckDestroyed();
		if (!CreateTransformAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:CreateTransformAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateTransformAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateTransformAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateTransformAttribute_AttributeName_Offset), 0, CreateTransformAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InitializeValue_InContainer(CreateTransformAttribute_DefaultValue_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, CreateTransformAttribute_DefaultValue_Offset), 0, CreateTransformAttribute_DefaultValue_PropertyAddress.Address, DefaultValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateTransformAttribute_bAllowsInterpolation_Offset), 0, CreateTransformAttribute_bAllowsInterpolation_PropertyAddress.Address, bAllowsInterpolation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateTransformAttribute_bOverrideParent_Offset), 0, CreateTransformAttribute_bOverrideParent_PropertyAddress.Address, bOverrideParent);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateTransformAttribute_FunctionAddress, intPtr, CreateTransformAttribute_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGMetadata:CreateStringAttribute")]
	public unsafe void CreateStringAttribute(FName AttributeName, string DefaultValue, bool bAllowsInterpolation, bool bOverrideParent = true)
	{
		CheckDestroyed();
		if (!CreateStringAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:CreateStringAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateStringAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateStringAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateStringAttribute_AttributeName_Offset), 0, CreateStringAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateStringAttribute_DefaultValue_Offset), 0, CreateStringAttribute_DefaultValue_PropertyAddress.Address, DefaultValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateStringAttribute_bAllowsInterpolation_Offset), 0, CreateStringAttribute_bAllowsInterpolation_PropertyAddress.Address, bAllowsInterpolation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateStringAttribute_bOverrideParent_Offset), 0, CreateStringAttribute_bOverrideParent_PropertyAddress.Address, bOverrideParent);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateStringAttribute_FunctionAddress, intPtr, CreateStringAttribute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateStringAttribute_DefaultValue_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/PCG.PCGMetadata:CreateRotatorAttribute")]
	public unsafe void CreateRotatorAttribute(FName AttributeName, FRotator DefaultValue, bool bAllowsInterpolation, bool bOverrideParent = true)
	{
		CheckDestroyed();
		if (!CreateRotatorAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:CreateRotatorAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateRotatorAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateRotatorAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateRotatorAttribute_AttributeName_Offset), 0, CreateRotatorAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, CreateRotatorAttribute_DefaultValue_Offset), 0, CreateRotatorAttribute_DefaultValue_PropertyAddress.Address, DefaultValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateRotatorAttribute_bAllowsInterpolation_Offset), 0, CreateRotatorAttribute_bAllowsInterpolation_PropertyAddress.Address, bAllowsInterpolation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateRotatorAttribute_bOverrideParent_Offset), 0, CreateRotatorAttribute_bOverrideParent_PropertyAddress.Address, bOverrideParent);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateRotatorAttribute_FunctionAddress, intPtr, CreateRotatorAttribute_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/PCG.PCGMetadata:CreateQuatAttribute")]
	public unsafe void CreateQuatAttribute(FName AttributeName, FQuat DefaultValue, bool bAllowsInterpolation, bool bOverrideParent = true)
	{
		CheckDestroyed();
		if (!CreateQuatAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:CreateQuatAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateQuatAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateQuatAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateQuatAttribute_AttributeName_Offset), 0, CreateQuatAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InitializeValue_InContainer(CreateQuatAttribute_DefaultValue_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(intPtr, CreateQuatAttribute_DefaultValue_Offset), 0, CreateQuatAttribute_DefaultValue_PropertyAddress.Address, DefaultValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateQuatAttribute_bAllowsInterpolation_Offset), 0, CreateQuatAttribute_bAllowsInterpolation_PropertyAddress.Address, bAllowsInterpolation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateQuatAttribute_bOverrideParent_Offset), 0, CreateQuatAttribute_bOverrideParent_PropertyAddress.Address, bOverrideParent);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateQuatAttribute_FunctionAddress, intPtr, CreateQuatAttribute_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGMetadata:CreateNameAttribute")]
	public unsafe void CreateNameAttribute(FName AttributeName, FName DefaultValue, bool bAllowsInterpolation, bool bOverrideParent = true)
	{
		CheckDestroyed();
		if (!CreateNameAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:CreateNameAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateNameAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateNameAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateNameAttribute_AttributeName_Offset), 0, CreateNameAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateNameAttribute_DefaultValue_Offset), 0, CreateNameAttribute_DefaultValue_PropertyAddress.Address, DefaultValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateNameAttribute_bAllowsInterpolation_Offset), 0, CreateNameAttribute_bAllowsInterpolation_PropertyAddress.Address, bAllowsInterpolation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateNameAttribute_bOverrideParent_Offset), 0, CreateNameAttribute_bOverrideParent_PropertyAddress.Address, bOverrideParent);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateNameAttribute_FunctionAddress, intPtr, CreateNameAttribute_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGMetadata:CreateInteger64Attribute")]
	public unsafe void CreateInteger64Attribute(FName AttributeName, long DefaultValue, bool bAllowsInterpolation, bool bOverrideParent = true)
	{
		CheckDestroyed();
		if (!CreateInteger64Attribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:CreateInteger64Attribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateInteger64Attribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateInteger64Attribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateInteger64Attribute_AttributeName_Offset), 0, CreateInteger64Attribute_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, CreateInteger64Attribute_DefaultValue_Offset), 0, CreateInteger64Attribute_DefaultValue_PropertyAddress.Address, DefaultValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateInteger64Attribute_bAllowsInterpolation_Offset), 0, CreateInteger64Attribute_bAllowsInterpolation_PropertyAddress.Address, bAllowsInterpolation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateInteger64Attribute_bOverrideParent_Offset), 0, CreateInteger64Attribute_bOverrideParent_PropertyAddress.Address, bOverrideParent);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateInteger64Attribute_FunctionAddress, intPtr, CreateInteger64Attribute_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGMetadata:CreateInteger32Attribute")]
	public unsafe void CreateInteger32Attribute(FName AttributeName, int DefaultValue, bool bAllowsInterpolation, bool bOverrideParent = true)
	{
		CheckDestroyed();
		if (!CreateInteger32Attribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:CreateInteger32Attribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateInteger32Attribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateInteger32Attribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateInteger32Attribute_AttributeName_Offset), 0, CreateInteger32Attribute_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateInteger32Attribute_DefaultValue_Offset), 0, CreateInteger32Attribute_DefaultValue_PropertyAddress.Address, DefaultValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateInteger32Attribute_bAllowsInterpolation_Offset), 0, CreateInteger32Attribute_bAllowsInterpolation_PropertyAddress.Address, bAllowsInterpolation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateInteger32Attribute_bOverrideParent_Offset), 0, CreateInteger32Attribute_bOverrideParent_PropertyAddress.Address, bOverrideParent);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateInteger32Attribute_FunctionAddress, intPtr, CreateInteger32Attribute_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGMetadata:CreateFloatAttribute")]
	public unsafe void CreateFloatAttribute(FName AttributeName, float DefaultValue, bool bAllowsInterpolation, bool bOverrideParent = true)
	{
		CheckDestroyed();
		if (!CreateFloatAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:CreateFloatAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateFloatAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateFloatAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateFloatAttribute_AttributeName_Offset), 0, CreateFloatAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CreateFloatAttribute_DefaultValue_Offset), 0, CreateFloatAttribute_DefaultValue_PropertyAddress.Address, DefaultValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateFloatAttribute_bAllowsInterpolation_Offset), 0, CreateFloatAttribute_bAllowsInterpolation_PropertyAddress.Address, bAllowsInterpolation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateFloatAttribute_bOverrideParent_Offset), 0, CreateFloatAttribute_bOverrideParent_PropertyAddress.Address, bOverrideParent);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateFloatAttribute_FunctionAddress, intPtr, CreateFloatAttribute_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGMetadata:CreateDoubleAttribute")]
	public unsafe void CreateDoubleAttribute(FName AttributeName, double DefaultValue, bool bAllowsInterpolation, bool bOverrideParent = true)
	{
		CheckDestroyed();
		if (!CreateDoubleAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:CreateDoubleAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateDoubleAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateDoubleAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateDoubleAttribute_AttributeName_Offset), 0, CreateDoubleAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(intPtr, CreateDoubleAttribute_DefaultValue_Offset), 0, CreateDoubleAttribute_DefaultValue_PropertyAddress.Address, DefaultValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateDoubleAttribute_bAllowsInterpolation_Offset), 0, CreateDoubleAttribute_bAllowsInterpolation_PropertyAddress.Address, bAllowsInterpolation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateDoubleAttribute_bOverrideParent_Offset), 0, CreateDoubleAttribute_bOverrideParent_PropertyAddress.Address, bOverrideParent);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateDoubleAttribute_FunctionAddress, intPtr, CreateDoubleAttribute_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGMetadata:CreateBoolAttribute")]
	public unsafe void CreateBoolAttribute(FName AttributeName, bool DefaultValue, bool bAllowsInterpolation, bool bOverrideParent = true)
	{
		CheckDestroyed();
		if (!CreateBoolAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:CreateBoolAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateBoolAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateBoolAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateBoolAttribute_AttributeName_Offset), 0, CreateBoolAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateBoolAttribute_DefaultValue_Offset), 0, CreateBoolAttribute_DefaultValue_PropertyAddress.Address, DefaultValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateBoolAttribute_bAllowsInterpolation_Offset), 0, CreateBoolAttribute_bAllowsInterpolation_PropertyAddress.Address, bAllowsInterpolation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateBoolAttribute_bOverrideParent_Offset), 0, CreateBoolAttribute_bOverrideParent_PropertyAddress.Address, bOverrideParent);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateBoolAttribute_FunctionAddress, intPtr, CreateBoolAttribute_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGMetadata:CopyExistingAttribute")]
	public unsafe bool CopyExistingAttribute(FName AttributeToCopy, FName NewAttributeName, bool bKeepParent = true)
	{
		CheckDestroyed();
		if (!CopyExistingAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:CopyExistingAttribute");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyExistingAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyExistingAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CopyExistingAttribute_AttributeToCopy_Offset), 0, CopyExistingAttribute_AttributeToCopy_PropertyAddress.Address, AttributeToCopy);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CopyExistingAttribute_NewAttributeName_Offset), 0, CopyExistingAttribute_NewAttributeName_PropertyAddress.Address, NewAttributeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CopyExistingAttribute_bKeepParent_Offset), 0, CopyExistingAttribute_bKeepParent_PropertyAddress.Address, bKeepParent);
		NativeReflection.InvokeFunctionOptimized(base.Address, CopyExistingAttribute_FunctionAddress, intPtr, CopyExistingAttribute_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CopyExistingAttribute_ReturnValue_Offset), 0, CopyExistingAttribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGMetadata:CopyAttributes")]
	public unsafe void CopyAttributes(UPCGMetadata InOther)
	{
		CheckDestroyed();
		if (!CopyAttributes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:CopyAttributes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyAttributes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyAttributes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, CopyAttributes_InOther_Offset), 0, CopyAttributes_InOther_PropertyAddress.Address, InOther);
		NativeReflection.InvokeFunctionOptimized(base.Address, CopyAttributes_FunctionAddress, intPtr, CopyAttributes_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGMetadata:CopyAttribute")]
	public unsafe void CopyAttribute(UPCGMetadata InOther, FName AttributeToCopy, FName NewAttributeName)
	{
		CheckDestroyed();
		if (!CopyAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:CopyAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, CopyAttribute_InOther_Offset), 0, CopyAttribute_InOther_PropertyAddress.Address, InOther);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CopyAttribute_AttributeToCopy_Offset), 0, CopyAttribute_AttributeToCopy_PropertyAddress.Address, AttributeToCopy);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CopyAttribute_NewAttributeName_Offset), 0, CopyAttribute_NewAttributeName_PropertyAddress.Address, NewAttributeName);
		NativeReflection.InvokeFunctionOptimized(base.Address, CopyAttribute_FunctionAddress, intPtr, CopyAttribute_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGMetadata:ClearAttribute")]
	public unsafe void ClearAttribute(FName AttributeToClear)
	{
		CheckDestroyed();
		if (!ClearAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:ClearAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ClearAttribute_AttributeToClear_Offset), 0, ClearAttribute_AttributeToClear_PropertyAddress.Address, AttributeToClear);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClearAttribute_FunctionAddress, intPtr, ClearAttribute_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGMetadata:AddEntry")]
	public unsafe long AddEntry(long ParentEntryKey = -1L)
	{
		CheckDestroyed();
		if (!AddEntry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:AddEntry");
			return 0L;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddEntry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddEntry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, AddEntry_ParentEntryKey_Offset), 0, AddEntry_ParentEntryKey_PropertyAddress.Address, ParentEntryKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddEntry_FunctionAddress, intPtr, AddEntry_ParamsSize);
		return BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, AddEntry_ReturnValue_Offset), 0, AddEntry_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/PCG.PCGMetadata:AddAttributesFiltered")]
	public unsafe void AddAttributesFiltered(UPCGMetadata InOther, HashSet<FName> InFilteredAttributes, EPCGMetadataFilterMode InFilterMode = EPCGMetadataFilterMode.ExcludeAttributes)
	{
		CheckDestroyed();
		if (!AddAttributesFiltered_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:AddAttributesFiltered");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAttributesFiltered_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAttributesFiltered_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, AddAttributesFiltered_InOther_Offset), 0, AddAttributesFiltered_InOther_PropertyAddress.Address, InOther);
		NativeReflection.InitializeValue_InContainer(AddAttributesFiltered_InFilteredAttributes_PropertyAddress.Address, intPtr);
		new TSetCopyMarshaler<FName>(1, AddAttributesFiltered_InFilteredAttributes_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, AddAttributesFiltered_InFilteredAttributes_Offset), InFilteredAttributes);
		EnumMarshaler<EPCGMetadataFilterMode>.ToNative(IntPtr.Add(intPtr, AddAttributesFiltered_InFilterMode_Offset), 0, AddAttributesFiltered_InFilterMode_PropertyAddress.Address, InFilterMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddAttributesFiltered_FunctionAddress, intPtr, AddAttributesFiltered_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddAttributesFiltered_InFilteredAttributes_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGMetadata:AddAttributes")]
	public unsafe void AddAttributes(UPCGMetadata InOther)
	{
		CheckDestroyed();
		if (!AddAttributes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:AddAttributes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAttributes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAttributes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, AddAttributes_InOther_Offset), 0, AddAttributes_InOther_PropertyAddress.Address, InOther);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddAttributes_FunctionAddress, intPtr, AddAttributes_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGMetadata:AddAttribute")]
	public unsafe void AddAttribute(UPCGMetadata InOther, FName AttributeName)
	{
		CheckDestroyed();
		if (!AddAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:AddAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, AddAttribute_InOther_Offset), 0, AddAttribute_InOther_PropertyAddress.Address, InOther);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddAttribute_AttributeName_Offset), 0, AddAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddAttribute_FunctionAddress, intPtr, AddAttribute_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/PCG.PCGMetadata:AccumulateWeightedAttributesByKey")]
	public unsafe void AccumulateWeightedAttributesByKey(long Key, UPCGMetadata Metadata, float Weight, bool bSetNonInterpolableAttributes, long TargetKey, out long OutKey)
	{
		CheckDestroyed();
		if (!AccumulateWeightedAttributesByKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:AccumulateWeightedAttributesByKey");
			OutKey = 0L;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AccumulateWeightedAttributesByKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AccumulateWeightedAttributesByKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, AccumulateWeightedAttributesByKey_Key_Offset), 0, AccumulateWeightedAttributesByKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, AccumulateWeightedAttributesByKey_Metadata_Offset), 0, AccumulateWeightedAttributesByKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AccumulateWeightedAttributesByKey_Weight_Offset), 0, AccumulateWeightedAttributesByKey_Weight_PropertyAddress.Address, Weight);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AccumulateWeightedAttributesByKey_bSetNonInterpolableAttributes_Offset), 0, AccumulateWeightedAttributesByKey_bSetNonInterpolableAttributes_PropertyAddress.Address, bSetNonInterpolableAttributes);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, AccumulateWeightedAttributesByKey_TargetKey_Offset), 0, AccumulateWeightedAttributesByKey_TargetKey_PropertyAddress.Address, TargetKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, AccumulateWeightedAttributesByKey_FunctionAddress, intPtr, AccumulateWeightedAttributesByKey_ParamsSize);
		OutKey = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, AccumulateWeightedAttributesByKey_OutKey_Offset), 0, AccumulateWeightedAttributesByKey_OutKey_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/PCG.PCGMetadata:AccumulatePointWeightedAttributes")]
	public unsafe void AccumulatePointWeightedAttributes(FPCGPoint InPoint, UPCGMetadata InMetadata, float Weight, bool bSetNonInterpolableAttributes, ref FPCGPoint OutPoint)
	{
		CheckDestroyed();
		if (!AccumulatePointWeightedAttributes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadata:AccumulatePointWeightedAttributes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AccumulatePointWeightedAttributes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AccumulatePointWeightedAttributes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AccumulatePointWeightedAttributes_InPoint_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, AccumulatePointWeightedAttributes_InPoint_Offset), 0, AccumulatePointWeightedAttributes_InPoint_PropertyAddress.Address, InPoint);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, AccumulatePointWeightedAttributes_InMetadata_Offset), 0, AccumulatePointWeightedAttributes_InMetadata_PropertyAddress.Address, InMetadata);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AccumulatePointWeightedAttributes_Weight_Offset), 0, AccumulatePointWeightedAttributes_Weight_PropertyAddress.Address, Weight);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AccumulatePointWeightedAttributes_bSetNonInterpolableAttributes_Offset), 0, AccumulatePointWeightedAttributes_bSetNonInterpolableAttributes_PropertyAddress.Address, bSetNonInterpolableAttributes);
		NativeReflection.InitializeValue_InContainer(AccumulatePointWeightedAttributes_OutPoint_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, AccumulatePointWeightedAttributes_OutPoint_Offset), 0, AccumulatePointWeightedAttributes_OutPoint_PropertyAddress.Address, OutPoint);
		NativeReflection.InvokeFunctionOptimized(base.Address, AccumulatePointWeightedAttributes_FunctionAddress, intPtr, AccumulatePointWeightedAttributes_ParamsSize);
		OutPoint = FPCGPoint.FromNative(IntPtr.Add(intPtr, AccumulatePointWeightedAttributes_OutPoint_Offset), 0, AccumulatePointWeightedAttributes_OutPoint_PropertyAddress.Address);
	}

	static UPCGMetadata()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGMetadata)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGMetadata));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/PCG.PCGMetadata");
		SetPointAttributes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPointAttributes");
		SetPointAttributes_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPointAttributes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPointAttributes_Point_PropertyAddress, SetPointAttributes_FunctionAddress, "Point");
		SetPointAttributes_Point_Offset = NativeReflectionCached.GetPropertyOffset(SetPointAttributes_FunctionAddress, "Point");
		SetPointAttributes_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPointAttributes_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPointAttributes_Metadata_PropertyAddress, SetPointAttributes_FunctionAddress, "Metadata");
		SetPointAttributes_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetPointAttributes_FunctionAddress, "Metadata");
		SetPointAttributes_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPointAttributes_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPointAttributes_OutPoint_PropertyAddress, SetPointAttributes_FunctionAddress, "OutPoint");
		SetPointAttributes_OutPoint_Offset = NativeReflectionCached.GetPropertyOffset(SetPointAttributes_FunctionAddress, "OutPoint");
		SetPointAttributes_OutPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPointAttributes_FunctionAddress, "OutPoint", Classes.FStructProperty);
		SetPointAttributes_IsValid = SetPointAttributes_FunctionAddress != IntPtr.Zero && SetPointAttributes_Point_IsValid && SetPointAttributes_Metadata_IsValid && SetPointAttributes_OutPoint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:SetPointAttributes", SetPointAttributes_IsValid);
		SetAttributesByKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetAttributesByKey");
		SetAttributesByKey_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAttributesByKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAttributesByKey_Key_PropertyAddress, SetAttributesByKey_FunctionAddress, "Key");
		SetAttributesByKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetAttributesByKey_FunctionAddress, "Key");
		SetAttributesByKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAttributesByKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref SetAttributesByKey_InMetadata_PropertyAddress, SetAttributesByKey_FunctionAddress, "InMetadata");
		SetAttributesByKey_InMetadata_Offset = NativeReflectionCached.GetPropertyOffset(SetAttributesByKey_FunctionAddress, "InMetadata");
		SetAttributesByKey_InMetadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAttributesByKey_FunctionAddress, "InMetadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAttributesByKey_TargetKey_PropertyAddress, SetAttributesByKey_FunctionAddress, "TargetKey");
		SetAttributesByKey_TargetKey_Offset = NativeReflectionCached.GetPropertyOffset(SetAttributesByKey_FunctionAddress, "TargetKey");
		SetAttributesByKey_TargetKey_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAttributesByKey_FunctionAddress, "TargetKey", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref SetAttributesByKey_OutKey_PropertyAddress, SetAttributesByKey_FunctionAddress, "OutKey");
		SetAttributesByKey_OutKey_Offset = NativeReflectionCached.GetPropertyOffset(SetAttributesByKey_FunctionAddress, "OutKey");
		SetAttributesByKey_OutKey_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAttributesByKey_FunctionAddress, "OutKey", Classes.FInt64Property);
		SetAttributesByKey_IsValid = SetAttributesByKey_FunctionAddress != IntPtr.Zero && SetAttributesByKey_Key_IsValid && SetAttributesByKey_InMetadata_IsValid && SetAttributesByKey_TargetKey_IsValid && SetAttributesByKey_OutKey_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:SetAttributesByKey", SetAttributesByKey_IsValid);
		ResetWeightedAttributesByKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ResetWeightedAttributesByKey");
		ResetWeightedAttributesByKey_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetWeightedAttributesByKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResetWeightedAttributesByKey_TargetKey_PropertyAddress, ResetWeightedAttributesByKey_FunctionAddress, "TargetKey");
		ResetWeightedAttributesByKey_TargetKey_Offset = NativeReflectionCached.GetPropertyOffset(ResetWeightedAttributesByKey_FunctionAddress, "TargetKey");
		ResetWeightedAttributesByKey_TargetKey_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetWeightedAttributesByKey_FunctionAddress, "TargetKey", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref ResetWeightedAttributesByKey_OutKey_PropertyAddress, ResetWeightedAttributesByKey_FunctionAddress, "OutKey");
		ResetWeightedAttributesByKey_OutKey_Offset = NativeReflectionCached.GetPropertyOffset(ResetWeightedAttributesByKey_FunctionAddress, "OutKey");
		ResetWeightedAttributesByKey_OutKey_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetWeightedAttributesByKey_FunctionAddress, "OutKey", Classes.FInt64Property);
		ResetWeightedAttributesByKey_IsValid = ResetWeightedAttributesByKey_FunctionAddress != IntPtr.Zero && ResetWeightedAttributesByKey_TargetKey_IsValid && ResetWeightedAttributesByKey_OutKey_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:ResetWeightedAttributesByKey", ResetWeightedAttributesByKey_IsValid);
		ResetPointWeightedAttributes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ResetPointWeightedAttributes");
		ResetPointWeightedAttributes_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetPointWeightedAttributes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResetPointWeightedAttributes_OutPoint_PropertyAddress, ResetPointWeightedAttributes_FunctionAddress, "OutPoint");
		ResetPointWeightedAttributes_OutPoint_Offset = NativeReflectionCached.GetPropertyOffset(ResetPointWeightedAttributes_FunctionAddress, "OutPoint");
		ResetPointWeightedAttributes_OutPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetPointWeightedAttributes_FunctionAddress, "OutPoint", Classes.FStructProperty);
		ResetPointWeightedAttributes_IsValid = ResetPointWeightedAttributes_FunctionAddress != IntPtr.Zero && ResetPointWeightedAttributes_OutPoint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:ResetPointWeightedAttributes", ResetPointWeightedAttributes_IsValid);
		RenameAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RenameAttribute");
		RenameAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(RenameAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenameAttribute_AttributeToRename_PropertyAddress, RenameAttribute_FunctionAddress, "AttributeToRename");
		RenameAttribute_AttributeToRename_Offset = NativeReflectionCached.GetPropertyOffset(RenameAttribute_FunctionAddress, "AttributeToRename");
		RenameAttribute_AttributeToRename_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameAttribute_FunctionAddress, "AttributeToRename", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameAttribute_NewAttributeName_PropertyAddress, RenameAttribute_FunctionAddress, "NewAttributeName");
		RenameAttribute_NewAttributeName_Offset = NativeReflectionCached.GetPropertyOffset(RenameAttribute_FunctionAddress, "NewAttributeName");
		RenameAttribute_NewAttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameAttribute_FunctionAddress, "NewAttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameAttribute_ReturnValue_PropertyAddress, RenameAttribute_FunctionAddress, "ReturnValue");
		RenameAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RenameAttribute_FunctionAddress, "ReturnValue");
		RenameAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameAttribute_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RenameAttribute_IsValid = RenameAttribute_FunctionAddress != IntPtr.Zero && RenameAttribute_AttributeToRename_IsValid && RenameAttribute_NewAttributeName_IsValid && RenameAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:RenameAttribute", RenameAttribute_IsValid);
		MergePointAttributes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "MergePointAttributes");
		MergePointAttributes_ParamsSize = NativeReflection.GetFunctionParamsSize(MergePointAttributes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MergePointAttributes_PointA_PropertyAddress, MergePointAttributes_FunctionAddress, "PointA");
		MergePointAttributes_PointA_Offset = NativeReflectionCached.GetPropertyOffset(MergePointAttributes_FunctionAddress, "PointA");
		MergePointAttributes_PointA_IsValid = NativeReflectionCached.ValidatePropertyClass(MergePointAttributes_FunctionAddress, "PointA", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MergePointAttributes_MetadataA_PropertyAddress, MergePointAttributes_FunctionAddress, "MetadataA");
		MergePointAttributes_MetadataA_Offset = NativeReflectionCached.GetPropertyOffset(MergePointAttributes_FunctionAddress, "MetadataA");
		MergePointAttributes_MetadataA_IsValid = NativeReflectionCached.ValidatePropertyClass(MergePointAttributes_FunctionAddress, "MetadataA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MergePointAttributes_PointB_PropertyAddress, MergePointAttributes_FunctionAddress, "PointB");
		MergePointAttributes_PointB_Offset = NativeReflectionCached.GetPropertyOffset(MergePointAttributes_FunctionAddress, "PointB");
		MergePointAttributes_PointB_IsValid = NativeReflectionCached.ValidatePropertyClass(MergePointAttributes_FunctionAddress, "PointB", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MergePointAttributes_MetadataB_PropertyAddress, MergePointAttributes_FunctionAddress, "MetadataB");
		MergePointAttributes_MetadataB_Offset = NativeReflectionCached.GetPropertyOffset(MergePointAttributes_FunctionAddress, "MetadataB");
		MergePointAttributes_MetadataB_IsValid = NativeReflectionCached.ValidatePropertyClass(MergePointAttributes_FunctionAddress, "MetadataB", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MergePointAttributes_TargetPoint_PropertyAddress, MergePointAttributes_FunctionAddress, "TargetPoint");
		MergePointAttributes_TargetPoint_Offset = NativeReflectionCached.GetPropertyOffset(MergePointAttributes_FunctionAddress, "TargetPoint");
		MergePointAttributes_TargetPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(MergePointAttributes_FunctionAddress, "TargetPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MergePointAttributes_Op_PropertyAddress, MergePointAttributes_FunctionAddress, "Op");
		MergePointAttributes_Op_Offset = NativeReflectionCached.GetPropertyOffset(MergePointAttributes_FunctionAddress, "Op");
		MergePointAttributes_Op_IsValid = NativeReflectionCached.ValidatePropertyClass(MergePointAttributes_FunctionAddress, "Op", Classes.FEnumProperty);
		MergePointAttributes_IsValid = MergePointAttributes_FunctionAddress != IntPtr.Zero && MergePointAttributes_PointA_IsValid && MergePointAttributes_MetadataA_IsValid && MergePointAttributes_PointB_IsValid && MergePointAttributes_MetadataB_IsValid && MergePointAttributes_TargetPoint_IsValid && MergePointAttributes_Op_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:MergePointAttributes", MergePointAttributes_IsValid);
		MergeAttributesByKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "MergeAttributesByKey");
		MergeAttributesByKey_ParamsSize = NativeReflection.GetFunctionParamsSize(MergeAttributesByKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MergeAttributesByKey_KeyA_PropertyAddress, MergeAttributesByKey_FunctionAddress, "KeyA");
		MergeAttributesByKey_KeyA_Offset = NativeReflectionCached.GetPropertyOffset(MergeAttributesByKey_FunctionAddress, "KeyA");
		MergeAttributesByKey_KeyA_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeAttributesByKey_FunctionAddress, "KeyA", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref MergeAttributesByKey_MetadataA_PropertyAddress, MergeAttributesByKey_FunctionAddress, "MetadataA");
		MergeAttributesByKey_MetadataA_Offset = NativeReflectionCached.GetPropertyOffset(MergeAttributesByKey_FunctionAddress, "MetadataA");
		MergeAttributesByKey_MetadataA_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeAttributesByKey_FunctionAddress, "MetadataA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeAttributesByKey_KeyB_PropertyAddress, MergeAttributesByKey_FunctionAddress, "KeyB");
		MergeAttributesByKey_KeyB_Offset = NativeReflectionCached.GetPropertyOffset(MergeAttributesByKey_FunctionAddress, "KeyB");
		MergeAttributesByKey_KeyB_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeAttributesByKey_FunctionAddress, "KeyB", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref MergeAttributesByKey_MetadataB_PropertyAddress, MergeAttributesByKey_FunctionAddress, "MetadataB");
		MergeAttributesByKey_MetadataB_Offset = NativeReflectionCached.GetPropertyOffset(MergeAttributesByKey_FunctionAddress, "MetadataB");
		MergeAttributesByKey_MetadataB_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeAttributesByKey_FunctionAddress, "MetadataB", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeAttributesByKey_TargetKey_PropertyAddress, MergeAttributesByKey_FunctionAddress, "TargetKey");
		MergeAttributesByKey_TargetKey_Offset = NativeReflectionCached.GetPropertyOffset(MergeAttributesByKey_FunctionAddress, "TargetKey");
		MergeAttributesByKey_TargetKey_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeAttributesByKey_FunctionAddress, "TargetKey", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref MergeAttributesByKey_Op_PropertyAddress, MergeAttributesByKey_FunctionAddress, "Op");
		MergeAttributesByKey_Op_Offset = NativeReflectionCached.GetPropertyOffset(MergeAttributesByKey_FunctionAddress, "Op");
		MergeAttributesByKey_Op_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeAttributesByKey_FunctionAddress, "Op", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeAttributesByKey_OutKey_PropertyAddress, MergeAttributesByKey_FunctionAddress, "OutKey");
		MergeAttributesByKey_OutKey_Offset = NativeReflectionCached.GetPropertyOffset(MergeAttributesByKey_FunctionAddress, "OutKey");
		MergeAttributesByKey_OutKey_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeAttributesByKey_FunctionAddress, "OutKey", Classes.FInt64Property);
		MergeAttributesByKey_IsValid = MergeAttributesByKey_FunctionAddress != IntPtr.Zero && MergeAttributesByKey_KeyA_IsValid && MergeAttributesByKey_MetadataA_IsValid && MergeAttributesByKey_KeyB_IsValid && MergeAttributesByKey_MetadataB_IsValid && MergeAttributesByKey_TargetKey_IsValid && MergeAttributesByKey_Op_IsValid && MergeAttributesByKey_OutKey_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:MergeAttributesByKey", MergeAttributesByKey_IsValid);
		InitializeWithAttributeFilter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitializeWithAttributeFilter");
		InitializeWithAttributeFilter_ParamsSize = NativeReflection.GetFunctionParamsSize(InitializeWithAttributeFilter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitializeWithAttributeFilter_InParent_PropertyAddress, InitializeWithAttributeFilter_FunctionAddress, "InParent");
		InitializeWithAttributeFilter_InParent_Offset = NativeReflectionCached.GetPropertyOffset(InitializeWithAttributeFilter_FunctionAddress, "InParent");
		InitializeWithAttributeFilter_InParent_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeWithAttributeFilter_FunctionAddress, "InParent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializeWithAttributeFilter_InFilteredAttributes_PropertyAddress, InitializeWithAttributeFilter_FunctionAddress, "InFilteredAttributes");
		InitializeWithAttributeFilter_InFilteredAttributes_Offset = NativeReflectionCached.GetPropertyOffset(InitializeWithAttributeFilter_FunctionAddress, "InFilteredAttributes");
		InitializeWithAttributeFilter_InFilteredAttributes_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeWithAttributeFilter_FunctionAddress, "InFilteredAttributes", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializeWithAttributeFilter_InFilterMode_PropertyAddress, InitializeWithAttributeFilter_FunctionAddress, "InFilterMode");
		InitializeWithAttributeFilter_InFilterMode_Offset = NativeReflectionCached.GetPropertyOffset(InitializeWithAttributeFilter_FunctionAddress, "InFilterMode");
		InitializeWithAttributeFilter_InFilterMode_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeWithAttributeFilter_FunctionAddress, "InFilterMode", Classes.FEnumProperty);
		InitializeWithAttributeFilter_IsValid = InitializeWithAttributeFilter_FunctionAddress != IntPtr.Zero && InitializeWithAttributeFilter_InParent_IsValid && InitializeWithAttributeFilter_InFilteredAttributes_IsValid && InitializeWithAttributeFilter_InFilterMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:InitializeWithAttributeFilter", InitializeWithAttributeFilter_IsValid);
		InitializeAsCopyWithAttributeFilter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitializeAsCopyWithAttributeFilter");
		InitializeAsCopyWithAttributeFilter_ParamsSize = NativeReflection.GetFunctionParamsSize(InitializeAsCopyWithAttributeFilter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitializeAsCopyWithAttributeFilter_InMetadataToCopy_PropertyAddress, InitializeAsCopyWithAttributeFilter_FunctionAddress, "InMetadataToCopy");
		InitializeAsCopyWithAttributeFilter_InMetadataToCopy_Offset = NativeReflectionCached.GetPropertyOffset(InitializeAsCopyWithAttributeFilter_FunctionAddress, "InMetadataToCopy");
		InitializeAsCopyWithAttributeFilter_InMetadataToCopy_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeAsCopyWithAttributeFilter_FunctionAddress, "InMetadataToCopy", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializeAsCopyWithAttributeFilter_InFilteredAttributes_PropertyAddress, InitializeAsCopyWithAttributeFilter_FunctionAddress, "InFilteredAttributes");
		InitializeAsCopyWithAttributeFilter_InFilteredAttributes_Offset = NativeReflectionCached.GetPropertyOffset(InitializeAsCopyWithAttributeFilter_FunctionAddress, "InFilteredAttributes");
		InitializeAsCopyWithAttributeFilter_InFilteredAttributes_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeAsCopyWithAttributeFilter_FunctionAddress, "InFilteredAttributes", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializeAsCopyWithAttributeFilter_InFilterMode_PropertyAddress, InitializeAsCopyWithAttributeFilter_FunctionAddress, "InFilterMode");
		InitializeAsCopyWithAttributeFilter_InFilterMode_Offset = NativeReflectionCached.GetPropertyOffset(InitializeAsCopyWithAttributeFilter_FunctionAddress, "InFilterMode");
		InitializeAsCopyWithAttributeFilter_InFilterMode_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeAsCopyWithAttributeFilter_FunctionAddress, "InFilterMode", Classes.FEnumProperty);
		InitializeAsCopyWithAttributeFilter_IsValid = InitializeAsCopyWithAttributeFilter_FunctionAddress != IntPtr.Zero && InitializeAsCopyWithAttributeFilter_InMetadataToCopy_IsValid && InitializeAsCopyWithAttributeFilter_InFilteredAttributes_IsValid && InitializeAsCopyWithAttributeFilter_InFilterMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:InitializeAsCopyWithAttributeFilter", InitializeAsCopyWithAttributeFilter_IsValid);
		InitializeAsCopy_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitializeAsCopy");
		InitializeAsCopy_ParamsSize = NativeReflection.GetFunctionParamsSize(InitializeAsCopy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitializeAsCopy_InMetadataToCopy_PropertyAddress, InitializeAsCopy_FunctionAddress, "InMetadataToCopy");
		InitializeAsCopy_InMetadataToCopy_Offset = NativeReflectionCached.GetPropertyOffset(InitializeAsCopy_FunctionAddress, "InMetadataToCopy");
		InitializeAsCopy_InMetadataToCopy_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeAsCopy_FunctionAddress, "InMetadataToCopy", Classes.FObjectProperty);
		InitializeAsCopy_IsValid = InitializeAsCopy_FunctionAddress != IntPtr.Zero && InitializeAsCopy_InMetadataToCopy_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:InitializeAsCopy", InitializeAsCopy_IsValid);
		Initialize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Initialize");
		Initialize_ParamsSize = NativeReflection.GetFunctionParamsSize(Initialize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Initialize_InParent_PropertyAddress, Initialize_FunctionAddress, "InParent");
		Initialize_InParent_Offset = NativeReflectionCached.GetPropertyOffset(Initialize_FunctionAddress, "InParent");
		Initialize_InParent_IsValid = NativeReflectionCached.ValidatePropertyClass(Initialize_FunctionAddress, "InParent", Classes.FObjectProperty);
		Initialize_IsValid = Initialize_FunctionAddress != IntPtr.Zero && Initialize_InParent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:Initialize", Initialize_IsValid);
		HasCommonAttributes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasCommonAttributes");
		HasCommonAttributes_ParamsSize = NativeReflection.GetFunctionParamsSize(HasCommonAttributes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasCommonAttributes_InMetadata_PropertyAddress, HasCommonAttributes_FunctionAddress, "InMetadata");
		HasCommonAttributes_InMetadata_Offset = NativeReflectionCached.GetPropertyOffset(HasCommonAttributes_FunctionAddress, "InMetadata");
		HasCommonAttributes_InMetadata_IsValid = NativeReflectionCached.ValidatePropertyClass(HasCommonAttributes_FunctionAddress, "InMetadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref HasCommonAttributes_ReturnValue_PropertyAddress, HasCommonAttributes_FunctionAddress, "ReturnValue");
		HasCommonAttributes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasCommonAttributes_FunctionAddress, "ReturnValue");
		HasCommonAttributes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasCommonAttributes_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasCommonAttributes_IsValid = HasCommonAttributes_FunctionAddress != IntPtr.Zero && HasCommonAttributes_InMetadata_IsValid && HasCommonAttributes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:HasCommonAttributes", HasCommonAttributes_IsValid);
		HasAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasAttribute");
		HasAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(HasAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasAttribute_AttributeName_PropertyAddress, HasAttribute_FunctionAddress, "AttributeName");
		HasAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(HasAttribute_FunctionAddress, "AttributeName");
		HasAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref HasAttribute_ReturnValue_PropertyAddress, HasAttribute_FunctionAddress, "ReturnValue");
		HasAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasAttribute_FunctionAddress, "ReturnValue");
		HasAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAttribute_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasAttribute_IsValid = HasAttribute_FunctionAddress != IntPtr.Zero && HasAttribute_AttributeName_IsValid && HasAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:HasAttribute", HasAttribute_IsValid);
		GetAttributes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAttributes");
		GetAttributes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAttributes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAttributes_AttributeNames_PropertyAddress, GetAttributes_FunctionAddress, "AttributeNames");
		GetAttributes_AttributeNames_Offset = NativeReflectionCached.GetPropertyOffset(GetAttributes_FunctionAddress, "AttributeNames");
		GetAttributes_AttributeNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttributes_FunctionAddress, "AttributeNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAttributes_AttributeTypes_PropertyAddress, GetAttributes_FunctionAddress, "AttributeTypes");
		GetAttributes_AttributeTypes_Offset = NativeReflectionCached.GetPropertyOffset(GetAttributes_FunctionAddress, "AttributeTypes");
		GetAttributes_AttributeTypes_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttributes_FunctionAddress, "AttributeTypes", Classes.FArrayProperty);
		GetAttributes_IsValid = GetAttributes_FunctionAddress != IntPtr.Zero && GetAttributes_AttributeNames_IsValid && GetAttributes_AttributeTypes_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:GetAttributes", GetAttributes_IsValid);
		Flatten_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Flatten");
		Flatten_ParamsSize = NativeReflection.GetFunctionParamsSize(Flatten_FunctionAddress);
		Flatten_IsValid = Flatten_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:Flatten", Flatten_IsValid);
		DeleteAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DeleteAttribute");
		DeleteAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteAttribute_AttributeName_PropertyAddress, DeleteAttribute_FunctionAddress, "AttributeName");
		DeleteAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(DeleteAttribute_FunctionAddress, "AttributeName");
		DeleteAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		DeleteAttribute_IsValid = DeleteAttribute_FunctionAddress != IntPtr.Zero && DeleteAttribute_AttributeName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:DeleteAttribute", DeleteAttribute_IsValid);
		CreateVectorAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateVectorAttribute");
		CreateVectorAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateVectorAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateVectorAttribute_AttributeName_PropertyAddress, CreateVectorAttribute_FunctionAddress, "AttributeName");
		CreateVectorAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(CreateVectorAttribute_FunctionAddress, "AttributeName");
		CreateVectorAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateVectorAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateVectorAttribute_DefaultValue_PropertyAddress, CreateVectorAttribute_FunctionAddress, "DefaultValue");
		CreateVectorAttribute_DefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateVectorAttribute_FunctionAddress, "DefaultValue");
		CreateVectorAttribute_DefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateVectorAttribute_FunctionAddress, "DefaultValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateVectorAttribute_bAllowsInterpolation_PropertyAddress, CreateVectorAttribute_FunctionAddress, "bAllowsInterpolation");
		CreateVectorAttribute_bAllowsInterpolation_Offset = NativeReflectionCached.GetPropertyOffset(CreateVectorAttribute_FunctionAddress, "bAllowsInterpolation");
		CreateVectorAttribute_bAllowsInterpolation_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateVectorAttribute_FunctionAddress, "bAllowsInterpolation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateVectorAttribute_bOverrideParent_PropertyAddress, CreateVectorAttribute_FunctionAddress, "bOverrideParent");
		CreateVectorAttribute_bOverrideParent_Offset = NativeReflectionCached.GetPropertyOffset(CreateVectorAttribute_FunctionAddress, "bOverrideParent");
		CreateVectorAttribute_bOverrideParent_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateVectorAttribute_FunctionAddress, "bOverrideParent", Classes.FBoolProperty);
		CreateVectorAttribute_IsValid = CreateVectorAttribute_FunctionAddress != IntPtr.Zero && CreateVectorAttribute_AttributeName_IsValid && CreateVectorAttribute_DefaultValue_IsValid && CreateVectorAttribute_bAllowsInterpolation_IsValid && CreateVectorAttribute_bOverrideParent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:CreateVectorAttribute", CreateVectorAttribute_IsValid);
		CreateVector4Attribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateVector4Attribute");
		CreateVector4Attribute_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateVector4Attribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateVector4Attribute_AttributeName_PropertyAddress, CreateVector4Attribute_FunctionAddress, "AttributeName");
		CreateVector4Attribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(CreateVector4Attribute_FunctionAddress, "AttributeName");
		CreateVector4Attribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateVector4Attribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateVector4Attribute_DefaultValue_PropertyAddress, CreateVector4Attribute_FunctionAddress, "DefaultValue");
		CreateVector4Attribute_DefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateVector4Attribute_FunctionAddress, "DefaultValue");
		CreateVector4Attribute_DefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateVector4Attribute_FunctionAddress, "DefaultValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateVector4Attribute_bAllowsInterpolation_PropertyAddress, CreateVector4Attribute_FunctionAddress, "bAllowsInterpolation");
		CreateVector4Attribute_bAllowsInterpolation_Offset = NativeReflectionCached.GetPropertyOffset(CreateVector4Attribute_FunctionAddress, "bAllowsInterpolation");
		CreateVector4Attribute_bAllowsInterpolation_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateVector4Attribute_FunctionAddress, "bAllowsInterpolation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateVector4Attribute_bOverrideParent_PropertyAddress, CreateVector4Attribute_FunctionAddress, "bOverrideParent");
		CreateVector4Attribute_bOverrideParent_Offset = NativeReflectionCached.GetPropertyOffset(CreateVector4Attribute_FunctionAddress, "bOverrideParent");
		CreateVector4Attribute_bOverrideParent_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateVector4Attribute_FunctionAddress, "bOverrideParent", Classes.FBoolProperty);
		CreateVector4Attribute_IsValid = CreateVector4Attribute_FunctionAddress != IntPtr.Zero && CreateVector4Attribute_AttributeName_IsValid && CreateVector4Attribute_DefaultValue_IsValid && CreateVector4Attribute_bAllowsInterpolation_IsValid && CreateVector4Attribute_bOverrideParent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:CreateVector4Attribute", CreateVector4Attribute_IsValid);
		CreateVector2Attribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateVector2Attribute");
		CreateVector2Attribute_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateVector2Attribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateVector2Attribute_AttributeName_PropertyAddress, CreateVector2Attribute_FunctionAddress, "AttributeName");
		CreateVector2Attribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(CreateVector2Attribute_FunctionAddress, "AttributeName");
		CreateVector2Attribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateVector2Attribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateVector2Attribute_DefaultValue_PropertyAddress, CreateVector2Attribute_FunctionAddress, "DefaultValue");
		CreateVector2Attribute_DefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateVector2Attribute_FunctionAddress, "DefaultValue");
		CreateVector2Attribute_DefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateVector2Attribute_FunctionAddress, "DefaultValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateVector2Attribute_bAllowsInterpolation_PropertyAddress, CreateVector2Attribute_FunctionAddress, "bAllowsInterpolation");
		CreateVector2Attribute_bAllowsInterpolation_Offset = NativeReflectionCached.GetPropertyOffset(CreateVector2Attribute_FunctionAddress, "bAllowsInterpolation");
		CreateVector2Attribute_bAllowsInterpolation_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateVector2Attribute_FunctionAddress, "bAllowsInterpolation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateVector2Attribute_bOverrideParent_PropertyAddress, CreateVector2Attribute_FunctionAddress, "bOverrideParent");
		CreateVector2Attribute_bOverrideParent_Offset = NativeReflectionCached.GetPropertyOffset(CreateVector2Attribute_FunctionAddress, "bOverrideParent");
		CreateVector2Attribute_bOverrideParent_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateVector2Attribute_FunctionAddress, "bOverrideParent", Classes.FBoolProperty);
		CreateVector2Attribute_IsValid = CreateVector2Attribute_FunctionAddress != IntPtr.Zero && CreateVector2Attribute_AttributeName_IsValid && CreateVector2Attribute_DefaultValue_IsValid && CreateVector2Attribute_bAllowsInterpolation_IsValid && CreateVector2Attribute_bOverrideParent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:CreateVector2Attribute", CreateVector2Attribute_IsValid);
		CreateTransformAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateTransformAttribute");
		CreateTransformAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateTransformAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateTransformAttribute_AttributeName_PropertyAddress, CreateTransformAttribute_FunctionAddress, "AttributeName");
		CreateTransformAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(CreateTransformAttribute_FunctionAddress, "AttributeName");
		CreateTransformAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTransformAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTransformAttribute_DefaultValue_PropertyAddress, CreateTransformAttribute_FunctionAddress, "DefaultValue");
		CreateTransformAttribute_DefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateTransformAttribute_FunctionAddress, "DefaultValue");
		CreateTransformAttribute_DefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTransformAttribute_FunctionAddress, "DefaultValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTransformAttribute_bAllowsInterpolation_PropertyAddress, CreateTransformAttribute_FunctionAddress, "bAllowsInterpolation");
		CreateTransformAttribute_bAllowsInterpolation_Offset = NativeReflectionCached.GetPropertyOffset(CreateTransformAttribute_FunctionAddress, "bAllowsInterpolation");
		CreateTransformAttribute_bAllowsInterpolation_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTransformAttribute_FunctionAddress, "bAllowsInterpolation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTransformAttribute_bOverrideParent_PropertyAddress, CreateTransformAttribute_FunctionAddress, "bOverrideParent");
		CreateTransformAttribute_bOverrideParent_Offset = NativeReflectionCached.GetPropertyOffset(CreateTransformAttribute_FunctionAddress, "bOverrideParent");
		CreateTransformAttribute_bOverrideParent_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTransformAttribute_FunctionAddress, "bOverrideParent", Classes.FBoolProperty);
		CreateTransformAttribute_IsValid = CreateTransformAttribute_FunctionAddress != IntPtr.Zero && CreateTransformAttribute_AttributeName_IsValid && CreateTransformAttribute_DefaultValue_IsValid && CreateTransformAttribute_bAllowsInterpolation_IsValid && CreateTransformAttribute_bOverrideParent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:CreateTransformAttribute", CreateTransformAttribute_IsValid);
		CreateStringAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateStringAttribute");
		CreateStringAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateStringAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateStringAttribute_AttributeName_PropertyAddress, CreateStringAttribute_FunctionAddress, "AttributeName");
		CreateStringAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(CreateStringAttribute_FunctionAddress, "AttributeName");
		CreateStringAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateStringAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateStringAttribute_DefaultValue_PropertyAddress, CreateStringAttribute_FunctionAddress, "DefaultValue");
		CreateStringAttribute_DefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateStringAttribute_FunctionAddress, "DefaultValue");
		CreateStringAttribute_DefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateStringAttribute_FunctionAddress, "DefaultValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateStringAttribute_bAllowsInterpolation_PropertyAddress, CreateStringAttribute_FunctionAddress, "bAllowsInterpolation");
		CreateStringAttribute_bAllowsInterpolation_Offset = NativeReflectionCached.GetPropertyOffset(CreateStringAttribute_FunctionAddress, "bAllowsInterpolation");
		CreateStringAttribute_bAllowsInterpolation_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateStringAttribute_FunctionAddress, "bAllowsInterpolation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateStringAttribute_bOverrideParent_PropertyAddress, CreateStringAttribute_FunctionAddress, "bOverrideParent");
		CreateStringAttribute_bOverrideParent_Offset = NativeReflectionCached.GetPropertyOffset(CreateStringAttribute_FunctionAddress, "bOverrideParent");
		CreateStringAttribute_bOverrideParent_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateStringAttribute_FunctionAddress, "bOverrideParent", Classes.FBoolProperty);
		CreateStringAttribute_IsValid = CreateStringAttribute_FunctionAddress != IntPtr.Zero && CreateStringAttribute_AttributeName_IsValid && CreateStringAttribute_DefaultValue_IsValid && CreateStringAttribute_bAllowsInterpolation_IsValid && CreateStringAttribute_bOverrideParent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:CreateStringAttribute", CreateStringAttribute_IsValid);
		CreateRotatorAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateRotatorAttribute");
		CreateRotatorAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateRotatorAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateRotatorAttribute_AttributeName_PropertyAddress, CreateRotatorAttribute_FunctionAddress, "AttributeName");
		CreateRotatorAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(CreateRotatorAttribute_FunctionAddress, "AttributeName");
		CreateRotatorAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRotatorAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRotatorAttribute_DefaultValue_PropertyAddress, CreateRotatorAttribute_FunctionAddress, "DefaultValue");
		CreateRotatorAttribute_DefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateRotatorAttribute_FunctionAddress, "DefaultValue");
		CreateRotatorAttribute_DefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRotatorAttribute_FunctionAddress, "DefaultValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRotatorAttribute_bAllowsInterpolation_PropertyAddress, CreateRotatorAttribute_FunctionAddress, "bAllowsInterpolation");
		CreateRotatorAttribute_bAllowsInterpolation_Offset = NativeReflectionCached.GetPropertyOffset(CreateRotatorAttribute_FunctionAddress, "bAllowsInterpolation");
		CreateRotatorAttribute_bAllowsInterpolation_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRotatorAttribute_FunctionAddress, "bAllowsInterpolation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRotatorAttribute_bOverrideParent_PropertyAddress, CreateRotatorAttribute_FunctionAddress, "bOverrideParent");
		CreateRotatorAttribute_bOverrideParent_Offset = NativeReflectionCached.GetPropertyOffset(CreateRotatorAttribute_FunctionAddress, "bOverrideParent");
		CreateRotatorAttribute_bOverrideParent_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRotatorAttribute_FunctionAddress, "bOverrideParent", Classes.FBoolProperty);
		CreateRotatorAttribute_IsValid = CreateRotatorAttribute_FunctionAddress != IntPtr.Zero && CreateRotatorAttribute_AttributeName_IsValid && CreateRotatorAttribute_DefaultValue_IsValid && CreateRotatorAttribute_bAllowsInterpolation_IsValid && CreateRotatorAttribute_bOverrideParent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:CreateRotatorAttribute", CreateRotatorAttribute_IsValid);
		CreateQuatAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateQuatAttribute");
		CreateQuatAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateQuatAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateQuatAttribute_AttributeName_PropertyAddress, CreateQuatAttribute_FunctionAddress, "AttributeName");
		CreateQuatAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(CreateQuatAttribute_FunctionAddress, "AttributeName");
		CreateQuatAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateQuatAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateQuatAttribute_DefaultValue_PropertyAddress, CreateQuatAttribute_FunctionAddress, "DefaultValue");
		CreateQuatAttribute_DefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateQuatAttribute_FunctionAddress, "DefaultValue");
		CreateQuatAttribute_DefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateQuatAttribute_FunctionAddress, "DefaultValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateQuatAttribute_bAllowsInterpolation_PropertyAddress, CreateQuatAttribute_FunctionAddress, "bAllowsInterpolation");
		CreateQuatAttribute_bAllowsInterpolation_Offset = NativeReflectionCached.GetPropertyOffset(CreateQuatAttribute_FunctionAddress, "bAllowsInterpolation");
		CreateQuatAttribute_bAllowsInterpolation_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateQuatAttribute_FunctionAddress, "bAllowsInterpolation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateQuatAttribute_bOverrideParent_PropertyAddress, CreateQuatAttribute_FunctionAddress, "bOverrideParent");
		CreateQuatAttribute_bOverrideParent_Offset = NativeReflectionCached.GetPropertyOffset(CreateQuatAttribute_FunctionAddress, "bOverrideParent");
		CreateQuatAttribute_bOverrideParent_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateQuatAttribute_FunctionAddress, "bOverrideParent", Classes.FBoolProperty);
		CreateQuatAttribute_IsValid = CreateQuatAttribute_FunctionAddress != IntPtr.Zero && CreateQuatAttribute_AttributeName_IsValid && CreateQuatAttribute_DefaultValue_IsValid && CreateQuatAttribute_bAllowsInterpolation_IsValid && CreateQuatAttribute_bOverrideParent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:CreateQuatAttribute", CreateQuatAttribute_IsValid);
		CreateNameAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateNameAttribute");
		CreateNameAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateNameAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateNameAttribute_AttributeName_PropertyAddress, CreateNameAttribute_FunctionAddress, "AttributeName");
		CreateNameAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(CreateNameAttribute_FunctionAddress, "AttributeName");
		CreateNameAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNameAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNameAttribute_DefaultValue_PropertyAddress, CreateNameAttribute_FunctionAddress, "DefaultValue");
		CreateNameAttribute_DefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateNameAttribute_FunctionAddress, "DefaultValue");
		CreateNameAttribute_DefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNameAttribute_FunctionAddress, "DefaultValue", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNameAttribute_bAllowsInterpolation_PropertyAddress, CreateNameAttribute_FunctionAddress, "bAllowsInterpolation");
		CreateNameAttribute_bAllowsInterpolation_Offset = NativeReflectionCached.GetPropertyOffset(CreateNameAttribute_FunctionAddress, "bAllowsInterpolation");
		CreateNameAttribute_bAllowsInterpolation_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNameAttribute_FunctionAddress, "bAllowsInterpolation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNameAttribute_bOverrideParent_PropertyAddress, CreateNameAttribute_FunctionAddress, "bOverrideParent");
		CreateNameAttribute_bOverrideParent_Offset = NativeReflectionCached.GetPropertyOffset(CreateNameAttribute_FunctionAddress, "bOverrideParent");
		CreateNameAttribute_bOverrideParent_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNameAttribute_FunctionAddress, "bOverrideParent", Classes.FBoolProperty);
		CreateNameAttribute_IsValid = CreateNameAttribute_FunctionAddress != IntPtr.Zero && CreateNameAttribute_AttributeName_IsValid && CreateNameAttribute_DefaultValue_IsValid && CreateNameAttribute_bAllowsInterpolation_IsValid && CreateNameAttribute_bOverrideParent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:CreateNameAttribute", CreateNameAttribute_IsValid);
		CreateInteger64Attribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateInteger64Attribute");
		CreateInteger64Attribute_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateInteger64Attribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateInteger64Attribute_AttributeName_PropertyAddress, CreateInteger64Attribute_FunctionAddress, "AttributeName");
		CreateInteger64Attribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(CreateInteger64Attribute_FunctionAddress, "AttributeName");
		CreateInteger64Attribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateInteger64Attribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateInteger64Attribute_DefaultValue_PropertyAddress, CreateInteger64Attribute_FunctionAddress, "DefaultValue");
		CreateInteger64Attribute_DefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateInteger64Attribute_FunctionAddress, "DefaultValue");
		CreateInteger64Attribute_DefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateInteger64Attribute_FunctionAddress, "DefaultValue", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref CreateInteger64Attribute_bAllowsInterpolation_PropertyAddress, CreateInteger64Attribute_FunctionAddress, "bAllowsInterpolation");
		CreateInteger64Attribute_bAllowsInterpolation_Offset = NativeReflectionCached.GetPropertyOffset(CreateInteger64Attribute_FunctionAddress, "bAllowsInterpolation");
		CreateInteger64Attribute_bAllowsInterpolation_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateInteger64Attribute_FunctionAddress, "bAllowsInterpolation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateInteger64Attribute_bOverrideParent_PropertyAddress, CreateInteger64Attribute_FunctionAddress, "bOverrideParent");
		CreateInteger64Attribute_bOverrideParent_Offset = NativeReflectionCached.GetPropertyOffset(CreateInteger64Attribute_FunctionAddress, "bOverrideParent");
		CreateInteger64Attribute_bOverrideParent_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateInteger64Attribute_FunctionAddress, "bOverrideParent", Classes.FBoolProperty);
		CreateInteger64Attribute_IsValid = CreateInteger64Attribute_FunctionAddress != IntPtr.Zero && CreateInteger64Attribute_AttributeName_IsValid && CreateInteger64Attribute_DefaultValue_IsValid && CreateInteger64Attribute_bAllowsInterpolation_IsValid && CreateInteger64Attribute_bOverrideParent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:CreateInteger64Attribute", CreateInteger64Attribute_IsValid);
		CreateInteger32Attribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateInteger32Attribute");
		CreateInteger32Attribute_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateInteger32Attribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateInteger32Attribute_AttributeName_PropertyAddress, CreateInteger32Attribute_FunctionAddress, "AttributeName");
		CreateInteger32Attribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(CreateInteger32Attribute_FunctionAddress, "AttributeName");
		CreateInteger32Attribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateInteger32Attribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateInteger32Attribute_DefaultValue_PropertyAddress, CreateInteger32Attribute_FunctionAddress, "DefaultValue");
		CreateInteger32Attribute_DefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateInteger32Attribute_FunctionAddress, "DefaultValue");
		CreateInteger32Attribute_DefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateInteger32Attribute_FunctionAddress, "DefaultValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateInteger32Attribute_bAllowsInterpolation_PropertyAddress, CreateInteger32Attribute_FunctionAddress, "bAllowsInterpolation");
		CreateInteger32Attribute_bAllowsInterpolation_Offset = NativeReflectionCached.GetPropertyOffset(CreateInteger32Attribute_FunctionAddress, "bAllowsInterpolation");
		CreateInteger32Attribute_bAllowsInterpolation_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateInteger32Attribute_FunctionAddress, "bAllowsInterpolation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateInteger32Attribute_bOverrideParent_PropertyAddress, CreateInteger32Attribute_FunctionAddress, "bOverrideParent");
		CreateInteger32Attribute_bOverrideParent_Offset = NativeReflectionCached.GetPropertyOffset(CreateInteger32Attribute_FunctionAddress, "bOverrideParent");
		CreateInteger32Attribute_bOverrideParent_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateInteger32Attribute_FunctionAddress, "bOverrideParent", Classes.FBoolProperty);
		CreateInteger32Attribute_IsValid = CreateInteger32Attribute_FunctionAddress != IntPtr.Zero && CreateInteger32Attribute_AttributeName_IsValid && CreateInteger32Attribute_DefaultValue_IsValid && CreateInteger32Attribute_bAllowsInterpolation_IsValid && CreateInteger32Attribute_bOverrideParent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:CreateInteger32Attribute", CreateInteger32Attribute_IsValid);
		CreateFloatAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateFloatAttribute");
		CreateFloatAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateFloatAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateFloatAttribute_AttributeName_PropertyAddress, CreateFloatAttribute_FunctionAddress, "AttributeName");
		CreateFloatAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(CreateFloatAttribute_FunctionAddress, "AttributeName");
		CreateFloatAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateFloatAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateFloatAttribute_DefaultValue_PropertyAddress, CreateFloatAttribute_FunctionAddress, "DefaultValue");
		CreateFloatAttribute_DefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateFloatAttribute_FunctionAddress, "DefaultValue");
		CreateFloatAttribute_DefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateFloatAttribute_FunctionAddress, "DefaultValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateFloatAttribute_bAllowsInterpolation_PropertyAddress, CreateFloatAttribute_FunctionAddress, "bAllowsInterpolation");
		CreateFloatAttribute_bAllowsInterpolation_Offset = NativeReflectionCached.GetPropertyOffset(CreateFloatAttribute_FunctionAddress, "bAllowsInterpolation");
		CreateFloatAttribute_bAllowsInterpolation_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateFloatAttribute_FunctionAddress, "bAllowsInterpolation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateFloatAttribute_bOverrideParent_PropertyAddress, CreateFloatAttribute_FunctionAddress, "bOverrideParent");
		CreateFloatAttribute_bOverrideParent_Offset = NativeReflectionCached.GetPropertyOffset(CreateFloatAttribute_FunctionAddress, "bOverrideParent");
		CreateFloatAttribute_bOverrideParent_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateFloatAttribute_FunctionAddress, "bOverrideParent", Classes.FBoolProperty);
		CreateFloatAttribute_IsValid = CreateFloatAttribute_FunctionAddress != IntPtr.Zero && CreateFloatAttribute_AttributeName_IsValid && CreateFloatAttribute_DefaultValue_IsValid && CreateFloatAttribute_bAllowsInterpolation_IsValid && CreateFloatAttribute_bOverrideParent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:CreateFloatAttribute", CreateFloatAttribute_IsValid);
		CreateDoubleAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateDoubleAttribute");
		CreateDoubleAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateDoubleAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateDoubleAttribute_AttributeName_PropertyAddress, CreateDoubleAttribute_FunctionAddress, "AttributeName");
		CreateDoubleAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(CreateDoubleAttribute_FunctionAddress, "AttributeName");
		CreateDoubleAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateDoubleAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateDoubleAttribute_DefaultValue_PropertyAddress, CreateDoubleAttribute_FunctionAddress, "DefaultValue");
		CreateDoubleAttribute_DefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateDoubleAttribute_FunctionAddress, "DefaultValue");
		CreateDoubleAttribute_DefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateDoubleAttribute_FunctionAddress, "DefaultValue", Classes.FDoubleProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateDoubleAttribute_bAllowsInterpolation_PropertyAddress, CreateDoubleAttribute_FunctionAddress, "bAllowsInterpolation");
		CreateDoubleAttribute_bAllowsInterpolation_Offset = NativeReflectionCached.GetPropertyOffset(CreateDoubleAttribute_FunctionAddress, "bAllowsInterpolation");
		CreateDoubleAttribute_bAllowsInterpolation_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateDoubleAttribute_FunctionAddress, "bAllowsInterpolation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateDoubleAttribute_bOverrideParent_PropertyAddress, CreateDoubleAttribute_FunctionAddress, "bOverrideParent");
		CreateDoubleAttribute_bOverrideParent_Offset = NativeReflectionCached.GetPropertyOffset(CreateDoubleAttribute_FunctionAddress, "bOverrideParent");
		CreateDoubleAttribute_bOverrideParent_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateDoubleAttribute_FunctionAddress, "bOverrideParent", Classes.FBoolProperty);
		CreateDoubleAttribute_IsValid = CreateDoubleAttribute_FunctionAddress != IntPtr.Zero && CreateDoubleAttribute_AttributeName_IsValid && CreateDoubleAttribute_DefaultValue_IsValid && CreateDoubleAttribute_bAllowsInterpolation_IsValid && CreateDoubleAttribute_bOverrideParent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:CreateDoubleAttribute", CreateDoubleAttribute_IsValid);
		CreateBoolAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateBoolAttribute");
		CreateBoolAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateBoolAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateBoolAttribute_AttributeName_PropertyAddress, CreateBoolAttribute_FunctionAddress, "AttributeName");
		CreateBoolAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(CreateBoolAttribute_FunctionAddress, "AttributeName");
		CreateBoolAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateBoolAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateBoolAttribute_DefaultValue_PropertyAddress, CreateBoolAttribute_FunctionAddress, "DefaultValue");
		CreateBoolAttribute_DefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateBoolAttribute_FunctionAddress, "DefaultValue");
		CreateBoolAttribute_DefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateBoolAttribute_FunctionAddress, "DefaultValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateBoolAttribute_bAllowsInterpolation_PropertyAddress, CreateBoolAttribute_FunctionAddress, "bAllowsInterpolation");
		CreateBoolAttribute_bAllowsInterpolation_Offset = NativeReflectionCached.GetPropertyOffset(CreateBoolAttribute_FunctionAddress, "bAllowsInterpolation");
		CreateBoolAttribute_bAllowsInterpolation_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateBoolAttribute_FunctionAddress, "bAllowsInterpolation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateBoolAttribute_bOverrideParent_PropertyAddress, CreateBoolAttribute_FunctionAddress, "bOverrideParent");
		CreateBoolAttribute_bOverrideParent_Offset = NativeReflectionCached.GetPropertyOffset(CreateBoolAttribute_FunctionAddress, "bOverrideParent");
		CreateBoolAttribute_bOverrideParent_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateBoolAttribute_FunctionAddress, "bOverrideParent", Classes.FBoolProperty);
		CreateBoolAttribute_IsValid = CreateBoolAttribute_FunctionAddress != IntPtr.Zero && CreateBoolAttribute_AttributeName_IsValid && CreateBoolAttribute_DefaultValue_IsValid && CreateBoolAttribute_bAllowsInterpolation_IsValid && CreateBoolAttribute_bOverrideParent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:CreateBoolAttribute", CreateBoolAttribute_IsValid);
		CopyExistingAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CopyExistingAttribute");
		CopyExistingAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyExistingAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyExistingAttribute_AttributeToCopy_PropertyAddress, CopyExistingAttribute_FunctionAddress, "AttributeToCopy");
		CopyExistingAttribute_AttributeToCopy_Offset = NativeReflectionCached.GetPropertyOffset(CopyExistingAttribute_FunctionAddress, "AttributeToCopy");
		CopyExistingAttribute_AttributeToCopy_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyExistingAttribute_FunctionAddress, "AttributeToCopy", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyExistingAttribute_NewAttributeName_PropertyAddress, CopyExistingAttribute_FunctionAddress, "NewAttributeName");
		CopyExistingAttribute_NewAttributeName_Offset = NativeReflectionCached.GetPropertyOffset(CopyExistingAttribute_FunctionAddress, "NewAttributeName");
		CopyExistingAttribute_NewAttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyExistingAttribute_FunctionAddress, "NewAttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyExistingAttribute_bKeepParent_PropertyAddress, CopyExistingAttribute_FunctionAddress, "bKeepParent");
		CopyExistingAttribute_bKeepParent_Offset = NativeReflectionCached.GetPropertyOffset(CopyExistingAttribute_FunctionAddress, "bKeepParent");
		CopyExistingAttribute_bKeepParent_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyExistingAttribute_FunctionAddress, "bKeepParent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyExistingAttribute_ReturnValue_PropertyAddress, CopyExistingAttribute_FunctionAddress, "ReturnValue");
		CopyExistingAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CopyExistingAttribute_FunctionAddress, "ReturnValue");
		CopyExistingAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyExistingAttribute_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CopyExistingAttribute_IsValid = CopyExistingAttribute_FunctionAddress != IntPtr.Zero && CopyExistingAttribute_AttributeToCopy_IsValid && CopyExistingAttribute_NewAttributeName_IsValid && CopyExistingAttribute_bKeepParent_IsValid && CopyExistingAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:CopyExistingAttribute", CopyExistingAttribute_IsValid);
		CopyAttributes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CopyAttributes");
		CopyAttributes_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyAttributes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyAttributes_InOther_PropertyAddress, CopyAttributes_FunctionAddress, "InOther");
		CopyAttributes_InOther_Offset = NativeReflectionCached.GetPropertyOffset(CopyAttributes_FunctionAddress, "InOther");
		CopyAttributes_InOther_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAttributes_FunctionAddress, "InOther", Classes.FObjectProperty);
		CopyAttributes_IsValid = CopyAttributes_FunctionAddress != IntPtr.Zero && CopyAttributes_InOther_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:CopyAttributes", CopyAttributes_IsValid);
		CopyAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CopyAttribute");
		CopyAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyAttribute_InOther_PropertyAddress, CopyAttribute_FunctionAddress, "InOther");
		CopyAttribute_InOther_Offset = NativeReflectionCached.GetPropertyOffset(CopyAttribute_FunctionAddress, "InOther");
		CopyAttribute_InOther_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAttribute_FunctionAddress, "InOther", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyAttribute_AttributeToCopy_PropertyAddress, CopyAttribute_FunctionAddress, "AttributeToCopy");
		CopyAttribute_AttributeToCopy_Offset = NativeReflectionCached.GetPropertyOffset(CopyAttribute_FunctionAddress, "AttributeToCopy");
		CopyAttribute_AttributeToCopy_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAttribute_FunctionAddress, "AttributeToCopy", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyAttribute_NewAttributeName_PropertyAddress, CopyAttribute_FunctionAddress, "NewAttributeName");
		CopyAttribute_NewAttributeName_Offset = NativeReflectionCached.GetPropertyOffset(CopyAttribute_FunctionAddress, "NewAttributeName");
		CopyAttribute_NewAttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAttribute_FunctionAddress, "NewAttributeName", Classes.FNameProperty);
		CopyAttribute_IsValid = CopyAttribute_FunctionAddress != IntPtr.Zero && CopyAttribute_InOther_IsValid && CopyAttribute_AttributeToCopy_IsValid && CopyAttribute_NewAttributeName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:CopyAttribute", CopyAttribute_IsValid);
		ClearAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ClearAttribute");
		ClearAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearAttribute_AttributeToClear_PropertyAddress, ClearAttribute_FunctionAddress, "AttributeToClear");
		ClearAttribute_AttributeToClear_Offset = NativeReflectionCached.GetPropertyOffset(ClearAttribute_FunctionAddress, "AttributeToClear");
		ClearAttribute_AttributeToClear_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearAttribute_FunctionAddress, "AttributeToClear", Classes.FNameProperty);
		ClearAttribute_IsValid = ClearAttribute_FunctionAddress != IntPtr.Zero && ClearAttribute_AttributeToClear_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:ClearAttribute", ClearAttribute_IsValid);
		AddEntry_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddEntry");
		AddEntry_ParamsSize = NativeReflection.GetFunctionParamsSize(AddEntry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddEntry_ParentEntryKey_PropertyAddress, AddEntry_FunctionAddress, "ParentEntryKey");
		AddEntry_ParentEntryKey_Offset = NativeReflectionCached.GetPropertyOffset(AddEntry_FunctionAddress, "ParentEntryKey");
		AddEntry_ParentEntryKey_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEntry_FunctionAddress, "ParentEntryKey", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref AddEntry_ReturnValue_PropertyAddress, AddEntry_FunctionAddress, "ReturnValue");
		AddEntry_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddEntry_FunctionAddress, "ReturnValue");
		AddEntry_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEntry_FunctionAddress, "ReturnValue", Classes.FInt64Property);
		AddEntry_IsValid = AddEntry_FunctionAddress != IntPtr.Zero && AddEntry_ParentEntryKey_IsValid && AddEntry_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:AddEntry", AddEntry_IsValid);
		AddAttributesFiltered_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddAttributesFiltered");
		AddAttributesFiltered_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAttributesFiltered_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAttributesFiltered_InOther_PropertyAddress, AddAttributesFiltered_FunctionAddress, "InOther");
		AddAttributesFiltered_InOther_Offset = NativeReflectionCached.GetPropertyOffset(AddAttributesFiltered_FunctionAddress, "InOther");
		AddAttributesFiltered_InOther_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAttributesFiltered_FunctionAddress, "InOther", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAttributesFiltered_InFilteredAttributes_PropertyAddress, AddAttributesFiltered_FunctionAddress, "InFilteredAttributes");
		AddAttributesFiltered_InFilteredAttributes_Offset = NativeReflectionCached.GetPropertyOffset(AddAttributesFiltered_FunctionAddress, "InFilteredAttributes");
		AddAttributesFiltered_InFilteredAttributes_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAttributesFiltered_FunctionAddress, "InFilteredAttributes", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAttributesFiltered_InFilterMode_PropertyAddress, AddAttributesFiltered_FunctionAddress, "InFilterMode");
		AddAttributesFiltered_InFilterMode_Offset = NativeReflectionCached.GetPropertyOffset(AddAttributesFiltered_FunctionAddress, "InFilterMode");
		AddAttributesFiltered_InFilterMode_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAttributesFiltered_FunctionAddress, "InFilterMode", Classes.FEnumProperty);
		AddAttributesFiltered_IsValid = AddAttributesFiltered_FunctionAddress != IntPtr.Zero && AddAttributesFiltered_InOther_IsValid && AddAttributesFiltered_InFilteredAttributes_IsValid && AddAttributesFiltered_InFilterMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:AddAttributesFiltered", AddAttributesFiltered_IsValid);
		AddAttributes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddAttributes");
		AddAttributes_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAttributes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAttributes_InOther_PropertyAddress, AddAttributes_FunctionAddress, "InOther");
		AddAttributes_InOther_Offset = NativeReflectionCached.GetPropertyOffset(AddAttributes_FunctionAddress, "InOther");
		AddAttributes_InOther_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAttributes_FunctionAddress, "InOther", Classes.FObjectProperty);
		AddAttributes_IsValid = AddAttributes_FunctionAddress != IntPtr.Zero && AddAttributes_InOther_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:AddAttributes", AddAttributes_IsValid);
		AddAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddAttribute");
		AddAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAttribute_InOther_PropertyAddress, AddAttribute_FunctionAddress, "InOther");
		AddAttribute_InOther_Offset = NativeReflectionCached.GetPropertyOffset(AddAttribute_FunctionAddress, "InOther");
		AddAttribute_InOther_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAttribute_FunctionAddress, "InOther", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAttribute_AttributeName_PropertyAddress, AddAttribute_FunctionAddress, "AttributeName");
		AddAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(AddAttribute_FunctionAddress, "AttributeName");
		AddAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		AddAttribute_IsValid = AddAttribute_FunctionAddress != IntPtr.Zero && AddAttribute_InOther_IsValid && AddAttribute_AttributeName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:AddAttribute", AddAttribute_IsValid);
		AccumulateWeightedAttributesByKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AccumulateWeightedAttributesByKey");
		AccumulateWeightedAttributesByKey_ParamsSize = NativeReflection.GetFunctionParamsSize(AccumulateWeightedAttributesByKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AccumulateWeightedAttributesByKey_Key_PropertyAddress, AccumulateWeightedAttributesByKey_FunctionAddress, "Key");
		AccumulateWeightedAttributesByKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(AccumulateWeightedAttributesByKey_FunctionAddress, "Key");
		AccumulateWeightedAttributesByKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(AccumulateWeightedAttributesByKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref AccumulateWeightedAttributesByKey_Metadata_PropertyAddress, AccumulateWeightedAttributesByKey_FunctionAddress, "Metadata");
		AccumulateWeightedAttributesByKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(AccumulateWeightedAttributesByKey_FunctionAddress, "Metadata");
		AccumulateWeightedAttributesByKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(AccumulateWeightedAttributesByKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AccumulateWeightedAttributesByKey_Weight_PropertyAddress, AccumulateWeightedAttributesByKey_FunctionAddress, "Weight");
		AccumulateWeightedAttributesByKey_Weight_Offset = NativeReflectionCached.GetPropertyOffset(AccumulateWeightedAttributesByKey_FunctionAddress, "Weight");
		AccumulateWeightedAttributesByKey_Weight_IsValid = NativeReflectionCached.ValidatePropertyClass(AccumulateWeightedAttributesByKey_FunctionAddress, "Weight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AccumulateWeightedAttributesByKey_bSetNonInterpolableAttributes_PropertyAddress, AccumulateWeightedAttributesByKey_FunctionAddress, "bSetNonInterpolableAttributes");
		AccumulateWeightedAttributesByKey_bSetNonInterpolableAttributes_Offset = NativeReflectionCached.GetPropertyOffset(AccumulateWeightedAttributesByKey_FunctionAddress, "bSetNonInterpolableAttributes");
		AccumulateWeightedAttributesByKey_bSetNonInterpolableAttributes_IsValid = NativeReflectionCached.ValidatePropertyClass(AccumulateWeightedAttributesByKey_FunctionAddress, "bSetNonInterpolableAttributes", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AccumulateWeightedAttributesByKey_TargetKey_PropertyAddress, AccumulateWeightedAttributesByKey_FunctionAddress, "TargetKey");
		AccumulateWeightedAttributesByKey_TargetKey_Offset = NativeReflectionCached.GetPropertyOffset(AccumulateWeightedAttributesByKey_FunctionAddress, "TargetKey");
		AccumulateWeightedAttributesByKey_TargetKey_IsValid = NativeReflectionCached.ValidatePropertyClass(AccumulateWeightedAttributesByKey_FunctionAddress, "TargetKey", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref AccumulateWeightedAttributesByKey_OutKey_PropertyAddress, AccumulateWeightedAttributesByKey_FunctionAddress, "OutKey");
		AccumulateWeightedAttributesByKey_OutKey_Offset = NativeReflectionCached.GetPropertyOffset(AccumulateWeightedAttributesByKey_FunctionAddress, "OutKey");
		AccumulateWeightedAttributesByKey_OutKey_IsValid = NativeReflectionCached.ValidatePropertyClass(AccumulateWeightedAttributesByKey_FunctionAddress, "OutKey", Classes.FInt64Property);
		AccumulateWeightedAttributesByKey_IsValid = AccumulateWeightedAttributesByKey_FunctionAddress != IntPtr.Zero && AccumulateWeightedAttributesByKey_Key_IsValid && AccumulateWeightedAttributesByKey_Metadata_IsValid && AccumulateWeightedAttributesByKey_Weight_IsValid && AccumulateWeightedAttributesByKey_bSetNonInterpolableAttributes_IsValid && AccumulateWeightedAttributesByKey_TargetKey_IsValid && AccumulateWeightedAttributesByKey_OutKey_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:AccumulateWeightedAttributesByKey", AccumulateWeightedAttributesByKey_IsValid);
		AccumulatePointWeightedAttributes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AccumulatePointWeightedAttributes");
		AccumulatePointWeightedAttributes_ParamsSize = NativeReflection.GetFunctionParamsSize(AccumulatePointWeightedAttributes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AccumulatePointWeightedAttributes_InPoint_PropertyAddress, AccumulatePointWeightedAttributes_FunctionAddress, "InPoint");
		AccumulatePointWeightedAttributes_InPoint_Offset = NativeReflectionCached.GetPropertyOffset(AccumulatePointWeightedAttributes_FunctionAddress, "InPoint");
		AccumulatePointWeightedAttributes_InPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(AccumulatePointWeightedAttributes_FunctionAddress, "InPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AccumulatePointWeightedAttributes_InMetadata_PropertyAddress, AccumulatePointWeightedAttributes_FunctionAddress, "InMetadata");
		AccumulatePointWeightedAttributes_InMetadata_Offset = NativeReflectionCached.GetPropertyOffset(AccumulatePointWeightedAttributes_FunctionAddress, "InMetadata");
		AccumulatePointWeightedAttributes_InMetadata_IsValid = NativeReflectionCached.ValidatePropertyClass(AccumulatePointWeightedAttributes_FunctionAddress, "InMetadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AccumulatePointWeightedAttributes_Weight_PropertyAddress, AccumulatePointWeightedAttributes_FunctionAddress, "Weight");
		AccumulatePointWeightedAttributes_Weight_Offset = NativeReflectionCached.GetPropertyOffset(AccumulatePointWeightedAttributes_FunctionAddress, "Weight");
		AccumulatePointWeightedAttributes_Weight_IsValid = NativeReflectionCached.ValidatePropertyClass(AccumulatePointWeightedAttributes_FunctionAddress, "Weight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AccumulatePointWeightedAttributes_bSetNonInterpolableAttributes_PropertyAddress, AccumulatePointWeightedAttributes_FunctionAddress, "bSetNonInterpolableAttributes");
		AccumulatePointWeightedAttributes_bSetNonInterpolableAttributes_Offset = NativeReflectionCached.GetPropertyOffset(AccumulatePointWeightedAttributes_FunctionAddress, "bSetNonInterpolableAttributes");
		AccumulatePointWeightedAttributes_bSetNonInterpolableAttributes_IsValid = NativeReflectionCached.ValidatePropertyClass(AccumulatePointWeightedAttributes_FunctionAddress, "bSetNonInterpolableAttributes", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AccumulatePointWeightedAttributes_OutPoint_PropertyAddress, AccumulatePointWeightedAttributes_FunctionAddress, "OutPoint");
		AccumulatePointWeightedAttributes_OutPoint_Offset = NativeReflectionCached.GetPropertyOffset(AccumulatePointWeightedAttributes_FunctionAddress, "OutPoint");
		AccumulatePointWeightedAttributes_OutPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(AccumulatePointWeightedAttributes_FunctionAddress, "OutPoint", Classes.FStructProperty);
		AccumulatePointWeightedAttributes_IsValid = AccumulatePointWeightedAttributes_FunctionAddress != IntPtr.Zero && AccumulatePointWeightedAttributes_InPoint_IsValid && AccumulatePointWeightedAttributes_InMetadata_IsValid && AccumulatePointWeightedAttributes_Weight_IsValid && AccumulatePointWeightedAttributes_bSetNonInterpolableAttributes_IsValid && AccumulatePointWeightedAttributes_OutPoint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadata:AccumulatePointWeightedAttributes", AccumulatePointWeightedAttributes_IsValid);
	}
}
