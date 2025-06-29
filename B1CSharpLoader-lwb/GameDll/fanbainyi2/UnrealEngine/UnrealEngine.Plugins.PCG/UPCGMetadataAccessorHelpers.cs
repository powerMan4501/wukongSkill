using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGMetadataAccessorHelpers : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetVectorAttributeByMetadataKey_IsValid;

	private static IntPtr SetVectorAttributeByMetadataKey_FunctionAddress;

	private static int SetVectorAttributeByMetadataKey_ParamsSize;

	private static bool SetVectorAttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress SetVectorAttributeByMetadataKey_Key_PropertyAddress;

	private static int SetVectorAttributeByMetadataKey_Key_Offset;

	private static bool SetVectorAttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress SetVectorAttributeByMetadataKey_Metadata_PropertyAddress;

	private static int SetVectorAttributeByMetadataKey_Metadata_Offset;

	private static bool SetVectorAttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress SetVectorAttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int SetVectorAttributeByMetadataKey_AttributeName_Offset;

	private static bool SetVectorAttributeByMetadataKey_Value_IsValid;

	private static FFieldAddress SetVectorAttributeByMetadataKey_Value_PropertyAddress;

	private static int SetVectorAttributeByMetadataKey_Value_Offset;

	private static bool SetVectorAttribute_IsValid;

	private static IntPtr SetVectorAttribute_FunctionAddress;

	private static int SetVectorAttribute_ParamsSize;

	private static bool SetVectorAttribute_Point_IsValid;

	private static FFieldAddress SetVectorAttribute_Point_PropertyAddress;

	private static int SetVectorAttribute_Point_Offset;

	private static bool SetVectorAttribute_Metadata_IsValid;

	private static FFieldAddress SetVectorAttribute_Metadata_PropertyAddress;

	private static int SetVectorAttribute_Metadata_Offset;

	private static bool SetVectorAttribute_AttributeName_IsValid;

	private static FFieldAddress SetVectorAttribute_AttributeName_PropertyAddress;

	private static int SetVectorAttribute_AttributeName_Offset;

	private static bool SetVectorAttribute_Value_IsValid;

	private static FFieldAddress SetVectorAttribute_Value_PropertyAddress;

	private static int SetVectorAttribute_Value_Offset;

	private static bool SetVector4AttributeByMetadataKey_IsValid;

	private static IntPtr SetVector4AttributeByMetadataKey_FunctionAddress;

	private static int SetVector4AttributeByMetadataKey_ParamsSize;

	private static bool SetVector4AttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress SetVector4AttributeByMetadataKey_Key_PropertyAddress;

	private static int SetVector4AttributeByMetadataKey_Key_Offset;

	private static bool SetVector4AttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress SetVector4AttributeByMetadataKey_Metadata_PropertyAddress;

	private static int SetVector4AttributeByMetadataKey_Metadata_Offset;

	private static bool SetVector4AttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress SetVector4AttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int SetVector4AttributeByMetadataKey_AttributeName_Offset;

	private static bool SetVector4AttributeByMetadataKey_Value_IsValid;

	private static FFieldAddress SetVector4AttributeByMetadataKey_Value_PropertyAddress;

	private static int SetVector4AttributeByMetadataKey_Value_Offset;

	private static bool SetVector4Attribute_IsValid;

	private static IntPtr SetVector4Attribute_FunctionAddress;

	private static int SetVector4Attribute_ParamsSize;

	private static bool SetVector4Attribute_Point_IsValid;

	private static FFieldAddress SetVector4Attribute_Point_PropertyAddress;

	private static int SetVector4Attribute_Point_Offset;

	private static bool SetVector4Attribute_Metadata_IsValid;

	private static FFieldAddress SetVector4Attribute_Metadata_PropertyAddress;

	private static int SetVector4Attribute_Metadata_Offset;

	private static bool SetVector4Attribute_AttributeName_IsValid;

	private static FFieldAddress SetVector4Attribute_AttributeName_PropertyAddress;

	private static int SetVector4Attribute_AttributeName_Offset;

	private static bool SetVector4Attribute_Value_IsValid;

	private static FFieldAddress SetVector4Attribute_Value_PropertyAddress;

	private static int SetVector4Attribute_Value_Offset;

	private static bool SetVector2AttributeByMetadataKey_IsValid;

	private static IntPtr SetVector2AttributeByMetadataKey_FunctionAddress;

	private static int SetVector2AttributeByMetadataKey_ParamsSize;

	private static bool SetVector2AttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress SetVector2AttributeByMetadataKey_Key_PropertyAddress;

	private static int SetVector2AttributeByMetadataKey_Key_Offset;

	private static bool SetVector2AttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress SetVector2AttributeByMetadataKey_Metadata_PropertyAddress;

	private static int SetVector2AttributeByMetadataKey_Metadata_Offset;

	private static bool SetVector2AttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress SetVector2AttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int SetVector2AttributeByMetadataKey_AttributeName_Offset;

	private static bool SetVector2AttributeByMetadataKey_Value_IsValid;

	private static FFieldAddress SetVector2AttributeByMetadataKey_Value_PropertyAddress;

	private static int SetVector2AttributeByMetadataKey_Value_Offset;

	private static bool SetVector2Attribute_IsValid;

	private static IntPtr SetVector2Attribute_FunctionAddress;

	private static int SetVector2Attribute_ParamsSize;

	private static bool SetVector2Attribute_Point_IsValid;

	private static FFieldAddress SetVector2Attribute_Point_PropertyAddress;

	private static int SetVector2Attribute_Point_Offset;

	private static bool SetVector2Attribute_Metadata_IsValid;

	private static FFieldAddress SetVector2Attribute_Metadata_PropertyAddress;

	private static int SetVector2Attribute_Metadata_Offset;

	private static bool SetVector2Attribute_AttributeName_IsValid;

	private static FFieldAddress SetVector2Attribute_AttributeName_PropertyAddress;

	private static int SetVector2Attribute_AttributeName_Offset;

	private static bool SetVector2Attribute_Value_IsValid;

	private static FFieldAddress SetVector2Attribute_Value_PropertyAddress;

	private static int SetVector2Attribute_Value_Offset;

	private static bool SetTransformAttributeByMetadataKey_IsValid;

	private static IntPtr SetTransformAttributeByMetadataKey_FunctionAddress;

	private static int SetTransformAttributeByMetadataKey_ParamsSize;

	private static bool SetTransformAttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress SetTransformAttributeByMetadataKey_Key_PropertyAddress;

	private static int SetTransformAttributeByMetadataKey_Key_Offset;

	private static bool SetTransformAttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress SetTransformAttributeByMetadataKey_Metadata_PropertyAddress;

	private static int SetTransformAttributeByMetadataKey_Metadata_Offset;

	private static bool SetTransformAttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress SetTransformAttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int SetTransformAttributeByMetadataKey_AttributeName_Offset;

	private static bool SetTransformAttributeByMetadataKey_Value_IsValid;

	private static FFieldAddress SetTransformAttributeByMetadataKey_Value_PropertyAddress;

	private static int SetTransformAttributeByMetadataKey_Value_Offset;

	private static bool SetTransformAttribute_IsValid;

	private static IntPtr SetTransformAttribute_FunctionAddress;

	private static int SetTransformAttribute_ParamsSize;

	private static bool SetTransformAttribute_Point_IsValid;

	private static FFieldAddress SetTransformAttribute_Point_PropertyAddress;

	private static int SetTransformAttribute_Point_Offset;

	private static bool SetTransformAttribute_Metadata_IsValid;

	private static FFieldAddress SetTransformAttribute_Metadata_PropertyAddress;

	private static int SetTransformAttribute_Metadata_Offset;

	private static bool SetTransformAttribute_AttributeName_IsValid;

	private static FFieldAddress SetTransformAttribute_AttributeName_PropertyAddress;

	private static int SetTransformAttribute_AttributeName_Offset;

	private static bool SetTransformAttribute_Value_IsValid;

	private static FFieldAddress SetTransformAttribute_Value_PropertyAddress;

	private static int SetTransformAttribute_Value_Offset;

	private static bool SetStringAttributeByMetadataKey_IsValid;

	private static IntPtr SetStringAttributeByMetadataKey_FunctionAddress;

	private static int SetStringAttributeByMetadataKey_ParamsSize;

	private static bool SetStringAttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress SetStringAttributeByMetadataKey_Key_PropertyAddress;

	private static int SetStringAttributeByMetadataKey_Key_Offset;

	private static bool SetStringAttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress SetStringAttributeByMetadataKey_Metadata_PropertyAddress;

	private static int SetStringAttributeByMetadataKey_Metadata_Offset;

	private static bool SetStringAttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress SetStringAttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int SetStringAttributeByMetadataKey_AttributeName_Offset;

	private static bool SetStringAttributeByMetadataKey_Value_IsValid;

	private static FFieldAddress SetStringAttributeByMetadataKey_Value_PropertyAddress;

	private static int SetStringAttributeByMetadataKey_Value_Offset;

	private static bool SetStringAttribute_IsValid;

	private static IntPtr SetStringAttribute_FunctionAddress;

	private static int SetStringAttribute_ParamsSize;

	private static bool SetStringAttribute_Point_IsValid;

	private static FFieldAddress SetStringAttribute_Point_PropertyAddress;

	private static int SetStringAttribute_Point_Offset;

	private static bool SetStringAttribute_Metadata_IsValid;

	private static FFieldAddress SetStringAttribute_Metadata_PropertyAddress;

	private static int SetStringAttribute_Metadata_Offset;

	private static bool SetStringAttribute_AttributeName_IsValid;

	private static FFieldAddress SetStringAttribute_AttributeName_PropertyAddress;

	private static int SetStringAttribute_AttributeName_Offset;

	private static bool SetStringAttribute_Value_IsValid;

	private static FFieldAddress SetStringAttribute_Value_PropertyAddress;

	private static int SetStringAttribute_Value_Offset;

	private static bool SetRotatorAttributeByMetadataKey_IsValid;

	private static IntPtr SetRotatorAttributeByMetadataKey_FunctionAddress;

	private static int SetRotatorAttributeByMetadataKey_ParamsSize;

	private static bool SetRotatorAttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress SetRotatorAttributeByMetadataKey_Key_PropertyAddress;

	private static int SetRotatorAttributeByMetadataKey_Key_Offset;

	private static bool SetRotatorAttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress SetRotatorAttributeByMetadataKey_Metadata_PropertyAddress;

	private static int SetRotatorAttributeByMetadataKey_Metadata_Offset;

	private static bool SetRotatorAttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress SetRotatorAttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int SetRotatorAttributeByMetadataKey_AttributeName_Offset;

	private static bool SetRotatorAttributeByMetadataKey_Value_IsValid;

	private static FFieldAddress SetRotatorAttributeByMetadataKey_Value_PropertyAddress;

	private static int SetRotatorAttributeByMetadataKey_Value_Offset;

	private static bool SetRotatorAttribute_IsValid;

	private static IntPtr SetRotatorAttribute_FunctionAddress;

	private static int SetRotatorAttribute_ParamsSize;

	private static bool SetRotatorAttribute_Point_IsValid;

	private static FFieldAddress SetRotatorAttribute_Point_PropertyAddress;

	private static int SetRotatorAttribute_Point_Offset;

	private static bool SetRotatorAttribute_Metadata_IsValid;

	private static FFieldAddress SetRotatorAttribute_Metadata_PropertyAddress;

	private static int SetRotatorAttribute_Metadata_Offset;

	private static bool SetRotatorAttribute_AttributeName_IsValid;

	private static FFieldAddress SetRotatorAttribute_AttributeName_PropertyAddress;

	private static int SetRotatorAttribute_AttributeName_Offset;

	private static bool SetRotatorAttribute_Value_IsValid;

	private static FFieldAddress SetRotatorAttribute_Value_PropertyAddress;

	private static int SetRotatorAttribute_Value_Offset;

	private static bool SetQuatAttributeByMetadataKey_IsValid;

	private static IntPtr SetQuatAttributeByMetadataKey_FunctionAddress;

	private static int SetQuatAttributeByMetadataKey_ParamsSize;

	private static bool SetQuatAttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress SetQuatAttributeByMetadataKey_Key_PropertyAddress;

	private static int SetQuatAttributeByMetadataKey_Key_Offset;

	private static bool SetQuatAttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress SetQuatAttributeByMetadataKey_Metadata_PropertyAddress;

	private static int SetQuatAttributeByMetadataKey_Metadata_Offset;

	private static bool SetQuatAttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress SetQuatAttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int SetQuatAttributeByMetadataKey_AttributeName_Offset;

	private static bool SetQuatAttributeByMetadataKey_Value_IsValid;

	private static FFieldAddress SetQuatAttributeByMetadataKey_Value_PropertyAddress;

	private static int SetQuatAttributeByMetadataKey_Value_Offset;

	private static bool SetQuatAttribute_IsValid;

	private static IntPtr SetQuatAttribute_FunctionAddress;

	private static int SetQuatAttribute_ParamsSize;

	private static bool SetQuatAttribute_Point_IsValid;

	private static FFieldAddress SetQuatAttribute_Point_PropertyAddress;

	private static int SetQuatAttribute_Point_Offset;

	private static bool SetQuatAttribute_Metadata_IsValid;

	private static FFieldAddress SetQuatAttribute_Metadata_PropertyAddress;

	private static int SetQuatAttribute_Metadata_Offset;

	private static bool SetQuatAttribute_AttributeName_IsValid;

	private static FFieldAddress SetQuatAttribute_AttributeName_PropertyAddress;

	private static int SetQuatAttribute_AttributeName_Offset;

	private static bool SetQuatAttribute_Value_IsValid;

	private static FFieldAddress SetQuatAttribute_Value_PropertyAddress;

	private static int SetQuatAttribute_Value_Offset;

	private static bool SetNameAttribute_IsValid;

	private static IntPtr SetNameAttribute_FunctionAddress;

	private static int SetNameAttribute_ParamsSize;

	private static bool SetNameAttribute_Point_IsValid;

	private static FFieldAddress SetNameAttribute_Point_PropertyAddress;

	private static int SetNameAttribute_Point_Offset;

	private static bool SetNameAttribute_Metadata_IsValid;

	private static FFieldAddress SetNameAttribute_Metadata_PropertyAddress;

	private static int SetNameAttribute_Metadata_Offset;

	private static bool SetNameAttribute_AttributeName_IsValid;

	private static FFieldAddress SetNameAttribute_AttributeName_PropertyAddress;

	private static int SetNameAttribute_AttributeName_Offset;

	private static bool SetNameAttribute_Value_IsValid;

	private static FFieldAddress SetNameAttribute_Value_PropertyAddress;

	private static int SetNameAttribute_Value_Offset;

	private static bool SetInteger64AttributeByMetadataKey_IsValid;

	private static IntPtr SetInteger64AttributeByMetadataKey_FunctionAddress;

	private static int SetInteger64AttributeByMetadataKey_ParamsSize;

	private static bool SetInteger64AttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress SetInteger64AttributeByMetadataKey_Key_PropertyAddress;

	private static int SetInteger64AttributeByMetadataKey_Key_Offset;

	private static bool SetInteger64AttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress SetInteger64AttributeByMetadataKey_Metadata_PropertyAddress;

	private static int SetInteger64AttributeByMetadataKey_Metadata_Offset;

	private static bool SetInteger64AttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress SetInteger64AttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int SetInteger64AttributeByMetadataKey_AttributeName_Offset;

	private static bool SetInteger64AttributeByMetadataKey_Value_IsValid;

	private static FFieldAddress SetInteger64AttributeByMetadataKey_Value_PropertyAddress;

	private static int SetInteger64AttributeByMetadataKey_Value_Offset;

	private static bool SetInteger64Attribute_IsValid;

	private static IntPtr SetInteger64Attribute_FunctionAddress;

	private static int SetInteger64Attribute_ParamsSize;

	private static bool SetInteger64Attribute_Point_IsValid;

	private static FFieldAddress SetInteger64Attribute_Point_PropertyAddress;

	private static int SetInteger64Attribute_Point_Offset;

	private static bool SetInteger64Attribute_Metadata_IsValid;

	private static FFieldAddress SetInteger64Attribute_Metadata_PropertyAddress;

	private static int SetInteger64Attribute_Metadata_Offset;

	private static bool SetInteger64Attribute_AttributeName_IsValid;

	private static FFieldAddress SetInteger64Attribute_AttributeName_PropertyAddress;

	private static int SetInteger64Attribute_AttributeName_Offset;

	private static bool SetInteger64Attribute_Value_IsValid;

	private static FFieldAddress SetInteger64Attribute_Value_PropertyAddress;

	private static int SetInteger64Attribute_Value_Offset;

	private static bool SetInteger32AttributeByMetadataKey_IsValid;

	private static IntPtr SetInteger32AttributeByMetadataKey_FunctionAddress;

	private static int SetInteger32AttributeByMetadataKey_ParamsSize;

	private static bool SetInteger32AttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress SetInteger32AttributeByMetadataKey_Key_PropertyAddress;

	private static int SetInteger32AttributeByMetadataKey_Key_Offset;

	private static bool SetInteger32AttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress SetInteger32AttributeByMetadataKey_Metadata_PropertyAddress;

	private static int SetInteger32AttributeByMetadataKey_Metadata_Offset;

	private static bool SetInteger32AttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress SetInteger32AttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int SetInteger32AttributeByMetadataKey_AttributeName_Offset;

	private static bool SetInteger32AttributeByMetadataKey_Value_IsValid;

	private static FFieldAddress SetInteger32AttributeByMetadataKey_Value_PropertyAddress;

	private static int SetInteger32AttributeByMetadataKey_Value_Offset;

	private static bool SetInteger32Attribute_IsValid;

	private static IntPtr SetInteger32Attribute_FunctionAddress;

	private static int SetInteger32Attribute_ParamsSize;

	private static bool SetInteger32Attribute_Point_IsValid;

	private static FFieldAddress SetInteger32Attribute_Point_PropertyAddress;

	private static int SetInteger32Attribute_Point_Offset;

	private static bool SetInteger32Attribute_Metadata_IsValid;

	private static FFieldAddress SetInteger32Attribute_Metadata_PropertyAddress;

	private static int SetInteger32Attribute_Metadata_Offset;

	private static bool SetInteger32Attribute_AttributeName_IsValid;

	private static FFieldAddress SetInteger32Attribute_AttributeName_PropertyAddress;

	private static int SetInteger32Attribute_AttributeName_Offset;

	private static bool SetInteger32Attribute_Value_IsValid;

	private static FFieldAddress SetInteger32Attribute_Value_PropertyAddress;

	private static int SetInteger32Attribute_Value_Offset;

	private static bool SetFloatAttributeByMetadataKey_IsValid;

	private static IntPtr SetFloatAttributeByMetadataKey_FunctionAddress;

	private static int SetFloatAttributeByMetadataKey_ParamsSize;

	private static bool SetFloatAttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress SetFloatAttributeByMetadataKey_Key_PropertyAddress;

	private static int SetFloatAttributeByMetadataKey_Key_Offset;

	private static bool SetFloatAttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress SetFloatAttributeByMetadataKey_Metadata_PropertyAddress;

	private static int SetFloatAttributeByMetadataKey_Metadata_Offset;

	private static bool SetFloatAttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress SetFloatAttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int SetFloatAttributeByMetadataKey_AttributeName_Offset;

	private static bool SetFloatAttributeByMetadataKey_Value_IsValid;

	private static FFieldAddress SetFloatAttributeByMetadataKey_Value_PropertyAddress;

	private static int SetFloatAttributeByMetadataKey_Value_Offset;

	private static bool SetFloatAttribute_IsValid;

	private static IntPtr SetFloatAttribute_FunctionAddress;

	private static int SetFloatAttribute_ParamsSize;

	private static bool SetFloatAttribute_Point_IsValid;

	private static FFieldAddress SetFloatAttribute_Point_PropertyAddress;

	private static int SetFloatAttribute_Point_Offset;

	private static bool SetFloatAttribute_Metadata_IsValid;

	private static FFieldAddress SetFloatAttribute_Metadata_PropertyAddress;

	private static int SetFloatAttribute_Metadata_Offset;

	private static bool SetFloatAttribute_AttributeName_IsValid;

	private static FFieldAddress SetFloatAttribute_AttributeName_PropertyAddress;

	private static int SetFloatAttribute_AttributeName_Offset;

	private static bool SetFloatAttribute_Value_IsValid;

	private static FFieldAddress SetFloatAttribute_Value_PropertyAddress;

	private static int SetFloatAttribute_Value_Offset;

	private static bool SetDoubleAttributeByMetadataKey_IsValid;

	private static IntPtr SetDoubleAttributeByMetadataKey_FunctionAddress;

	private static int SetDoubleAttributeByMetadataKey_ParamsSize;

	private static bool SetDoubleAttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress SetDoubleAttributeByMetadataKey_Key_PropertyAddress;

	private static int SetDoubleAttributeByMetadataKey_Key_Offset;

	private static bool SetDoubleAttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress SetDoubleAttributeByMetadataKey_Metadata_PropertyAddress;

	private static int SetDoubleAttributeByMetadataKey_Metadata_Offset;

	private static bool SetDoubleAttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress SetDoubleAttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int SetDoubleAttributeByMetadataKey_AttributeName_Offset;

	private static bool SetDoubleAttributeByMetadataKey_Value_IsValid;

	private static FFieldAddress SetDoubleAttributeByMetadataKey_Value_PropertyAddress;

	private static int SetDoubleAttributeByMetadataKey_Value_Offset;

	private static bool SetDoubleAttribute_IsValid;

	private static IntPtr SetDoubleAttribute_FunctionAddress;

	private static int SetDoubleAttribute_ParamsSize;

	private static bool SetDoubleAttribute_Point_IsValid;

	private static FFieldAddress SetDoubleAttribute_Point_PropertyAddress;

	private static int SetDoubleAttribute_Point_Offset;

	private static bool SetDoubleAttribute_Metadata_IsValid;

	private static FFieldAddress SetDoubleAttribute_Metadata_PropertyAddress;

	private static int SetDoubleAttribute_Metadata_Offset;

	private static bool SetDoubleAttribute_AttributeName_IsValid;

	private static FFieldAddress SetDoubleAttribute_AttributeName_PropertyAddress;

	private static int SetDoubleAttribute_AttributeName_Offset;

	private static bool SetDoubleAttribute_Value_IsValid;

	private static FFieldAddress SetDoubleAttribute_Value_PropertyAddress;

	private static int SetDoubleAttribute_Value_Offset;

	private static bool SetBoolAttributeByMetadataKey_IsValid;

	private static IntPtr SetBoolAttributeByMetadataKey_FunctionAddress;

	private static int SetBoolAttributeByMetadataKey_ParamsSize;

	private static bool SetBoolAttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress SetBoolAttributeByMetadataKey_Key_PropertyAddress;

	private static int SetBoolAttributeByMetadataKey_Key_Offset;

	private static bool SetBoolAttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress SetBoolAttributeByMetadataKey_Metadata_PropertyAddress;

	private static int SetBoolAttributeByMetadataKey_Metadata_Offset;

	private static bool SetBoolAttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress SetBoolAttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int SetBoolAttributeByMetadataKey_AttributeName_Offset;

	private static bool SetBoolAttributeByMetadataKey_Value_IsValid;

	private static FFieldAddress SetBoolAttributeByMetadataKey_Value_PropertyAddress;

	private static int SetBoolAttributeByMetadataKey_Value_Offset;

	private static bool SetBoolAttribute_IsValid;

	private static IntPtr SetBoolAttribute_FunctionAddress;

	private static int SetBoolAttribute_ParamsSize;

	private static bool SetBoolAttribute_Point_IsValid;

	private static FFieldAddress SetBoolAttribute_Point_PropertyAddress;

	private static int SetBoolAttribute_Point_Offset;

	private static bool SetBoolAttribute_Metadata_IsValid;

	private static FFieldAddress SetBoolAttribute_Metadata_PropertyAddress;

	private static int SetBoolAttribute_Metadata_Offset;

	private static bool SetBoolAttribute_AttributeName_IsValid;

	private static FFieldAddress SetBoolAttribute_AttributeName_PropertyAddress;

	private static int SetBoolAttribute_AttributeName_Offset;

	private static bool SetBoolAttribute_Value_IsValid;

	private static FFieldAddress SetBoolAttribute_Value_PropertyAddress;

	private static int SetBoolAttribute_Value_Offset;

	private static bool SetAttributeFromPropertyByMetadataKey_IsValid;

	private static IntPtr SetAttributeFromPropertyByMetadataKey_FunctionAddress;

	private static int SetAttributeFromPropertyByMetadataKey_ParamsSize;

	private static bool SetAttributeFromPropertyByMetadataKey_Key_IsValid;

	private static FFieldAddress SetAttributeFromPropertyByMetadataKey_Key_PropertyAddress;

	private static int SetAttributeFromPropertyByMetadataKey_Key_Offset;

	private static bool SetAttributeFromPropertyByMetadataKey_Metadata_IsValid;

	private static FFieldAddress SetAttributeFromPropertyByMetadataKey_Metadata_PropertyAddress;

	private static int SetAttributeFromPropertyByMetadataKey_Metadata_Offset;

	private static bool SetAttributeFromPropertyByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress SetAttributeFromPropertyByMetadataKey_AttributeName_PropertyAddress;

	private static int SetAttributeFromPropertyByMetadataKey_AttributeName_Offset;

	private static bool SetAttributeFromPropertyByMetadataKey_Object_IsValid;

	private static FFieldAddress SetAttributeFromPropertyByMetadataKey_Object_PropertyAddress;

	private static int SetAttributeFromPropertyByMetadataKey_Object_Offset;

	private static bool SetAttributeFromPropertyByMetadataKey_PropertyName_IsValid;

	private static FFieldAddress SetAttributeFromPropertyByMetadataKey_PropertyName_PropertyAddress;

	private static int SetAttributeFromPropertyByMetadataKey_PropertyName_Offset;

	private static bool SetAttributeFromPropertyByMetadataKey_ReturnValue_IsValid;

	private static FFieldAddress SetAttributeFromPropertyByMetadataKey_ReturnValue_PropertyAddress;

	private static int SetAttributeFromPropertyByMetadataKey_ReturnValue_Offset;

	private static bool InitializeMetadata_IsValid;

	private static IntPtr InitializeMetadata_FunctionAddress;

	private static int InitializeMetadata_ParamsSize;

	private static bool InitializeMetadata_Point_IsValid;

	private static FFieldAddress InitializeMetadata_Point_PropertyAddress;

	private static int InitializeMetadata_Point_Offset;

	private static bool InitializeMetadata_Metadata_IsValid;

	private static FFieldAddress InitializeMetadata_Metadata_PropertyAddress;

	private static int InitializeMetadata_Metadata_Offset;

	private static bool InitializeMetadata_ParentPoint_IsValid;

	private static FFieldAddress InitializeMetadata_ParentPoint_PropertyAddress;

	private static int InitializeMetadata_ParentPoint_Offset;

	private static bool InitializeMetadata_ParentMetadata_IsValid;

	private static FFieldAddress InitializeMetadata_ParentMetadata_PropertyAddress;

	private static int InitializeMetadata_ParentMetadata_Offset;

	private static bool HasAttributeSetByMetadataKey_IsValid;

	private static IntPtr HasAttributeSetByMetadataKey_FunctionAddress;

	private static int HasAttributeSetByMetadataKey_ParamsSize;

	private static bool HasAttributeSetByMetadataKey_Key_IsValid;

	private static FFieldAddress HasAttributeSetByMetadataKey_Key_PropertyAddress;

	private static int HasAttributeSetByMetadataKey_Key_Offset;

	private static bool HasAttributeSetByMetadataKey_Metadata_IsValid;

	private static FFieldAddress HasAttributeSetByMetadataKey_Metadata_PropertyAddress;

	private static int HasAttributeSetByMetadataKey_Metadata_Offset;

	private static bool HasAttributeSetByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress HasAttributeSetByMetadataKey_AttributeName_PropertyAddress;

	private static int HasAttributeSetByMetadataKey_AttributeName_Offset;

	private static bool HasAttributeSetByMetadataKey_ReturnValue_IsValid;

	private static FFieldAddress HasAttributeSetByMetadataKey_ReturnValue_PropertyAddress;

	private static int HasAttributeSetByMetadataKey_ReturnValue_Offset;

	private static bool HasAttributeSet_IsValid;

	private static IntPtr HasAttributeSet_FunctionAddress;

	private static int HasAttributeSet_ParamsSize;

	private static bool HasAttributeSet_Point_IsValid;

	private static FFieldAddress HasAttributeSet_Point_PropertyAddress;

	private static int HasAttributeSet_Point_Offset;

	private static bool HasAttributeSet_Metadata_IsValid;

	private static FFieldAddress HasAttributeSet_Metadata_PropertyAddress;

	private static int HasAttributeSet_Metadata_Offset;

	private static bool HasAttributeSet_AttributeName_IsValid;

	private static FFieldAddress HasAttributeSet_AttributeName_PropertyAddress;

	private static int HasAttributeSet_AttributeName_Offset;

	private static bool HasAttributeSet_ReturnValue_IsValid;

	private static FFieldAddress HasAttributeSet_ReturnValue_PropertyAddress;

	private static int HasAttributeSet_ReturnValue_Offset;

	private static bool GetVectorAttributeByMetadataKey_IsValid;

	private static IntPtr GetVectorAttributeByMetadataKey_FunctionAddress;

	private static int GetVectorAttributeByMetadataKey_ParamsSize;

	private static bool GetVectorAttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress GetVectorAttributeByMetadataKey_Key_PropertyAddress;

	private static int GetVectorAttributeByMetadataKey_Key_Offset;

	private static bool GetVectorAttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress GetVectorAttributeByMetadataKey_Metadata_PropertyAddress;

	private static int GetVectorAttributeByMetadataKey_Metadata_Offset;

	private static bool GetVectorAttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress GetVectorAttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int GetVectorAttributeByMetadataKey_AttributeName_Offset;

	private static bool GetVectorAttributeByMetadataKey_ReturnValue_IsValid;

	private static FFieldAddress GetVectorAttributeByMetadataKey_ReturnValue_PropertyAddress;

	private static int GetVectorAttributeByMetadataKey_ReturnValue_Offset;

	private static bool GetVectorAttribute_IsValid;

	private static IntPtr GetVectorAttribute_FunctionAddress;

	private static int GetVectorAttribute_ParamsSize;

	private static bool GetVectorAttribute_Point_IsValid;

	private static FFieldAddress GetVectorAttribute_Point_PropertyAddress;

	private static int GetVectorAttribute_Point_Offset;

	private static bool GetVectorAttribute_Metadata_IsValid;

	private static FFieldAddress GetVectorAttribute_Metadata_PropertyAddress;

	private static int GetVectorAttribute_Metadata_Offset;

	private static bool GetVectorAttribute_AttributeName_IsValid;

	private static FFieldAddress GetVectorAttribute_AttributeName_PropertyAddress;

	private static int GetVectorAttribute_AttributeName_Offset;

	private static bool GetVectorAttribute_ReturnValue_IsValid;

	private static FFieldAddress GetVectorAttribute_ReturnValue_PropertyAddress;

	private static int GetVectorAttribute_ReturnValue_Offset;

	private static bool GetVector4AttributeByMetadataKey_IsValid;

	private static IntPtr GetVector4AttributeByMetadataKey_FunctionAddress;

	private static int GetVector4AttributeByMetadataKey_ParamsSize;

	private static bool GetVector4AttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress GetVector4AttributeByMetadataKey_Key_PropertyAddress;

	private static int GetVector4AttributeByMetadataKey_Key_Offset;

	private static bool GetVector4AttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress GetVector4AttributeByMetadataKey_Metadata_PropertyAddress;

	private static int GetVector4AttributeByMetadataKey_Metadata_Offset;

	private static bool GetVector4AttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress GetVector4AttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int GetVector4AttributeByMetadataKey_AttributeName_Offset;

	private static bool GetVector4AttributeByMetadataKey_ReturnValue_IsValid;

	private static FFieldAddress GetVector4AttributeByMetadataKey_ReturnValue_PropertyAddress;

	private static int GetVector4AttributeByMetadataKey_ReturnValue_Offset;

	private static bool GetVector4Attribute_IsValid;

	private static IntPtr GetVector4Attribute_FunctionAddress;

	private static int GetVector4Attribute_ParamsSize;

	private static bool GetVector4Attribute_Point_IsValid;

	private static FFieldAddress GetVector4Attribute_Point_PropertyAddress;

	private static int GetVector4Attribute_Point_Offset;

	private static bool GetVector4Attribute_Metadata_IsValid;

	private static FFieldAddress GetVector4Attribute_Metadata_PropertyAddress;

	private static int GetVector4Attribute_Metadata_Offset;

	private static bool GetVector4Attribute_AttributeName_IsValid;

	private static FFieldAddress GetVector4Attribute_AttributeName_PropertyAddress;

	private static int GetVector4Attribute_AttributeName_Offset;

	private static bool GetVector4Attribute_ReturnValue_IsValid;

	private static FFieldAddress GetVector4Attribute_ReturnValue_PropertyAddress;

	private static int GetVector4Attribute_ReturnValue_Offset;

	private static bool GetVector2AttributeByMetadataKey_IsValid;

	private static IntPtr GetVector2AttributeByMetadataKey_FunctionAddress;

	private static int GetVector2AttributeByMetadataKey_ParamsSize;

	private static bool GetVector2AttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress GetVector2AttributeByMetadataKey_Key_PropertyAddress;

	private static int GetVector2AttributeByMetadataKey_Key_Offset;

	private static bool GetVector2AttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress GetVector2AttributeByMetadataKey_Metadata_PropertyAddress;

	private static int GetVector2AttributeByMetadataKey_Metadata_Offset;

	private static bool GetVector2AttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress GetVector2AttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int GetVector2AttributeByMetadataKey_AttributeName_Offset;

	private static bool GetVector2AttributeByMetadataKey_ReturnValue_IsValid;

	private static FFieldAddress GetVector2AttributeByMetadataKey_ReturnValue_PropertyAddress;

	private static int GetVector2AttributeByMetadataKey_ReturnValue_Offset;

	private static bool GetVector2Attribute_IsValid;

	private static IntPtr GetVector2Attribute_FunctionAddress;

	private static int GetVector2Attribute_ParamsSize;

	private static bool GetVector2Attribute_Point_IsValid;

	private static FFieldAddress GetVector2Attribute_Point_PropertyAddress;

	private static int GetVector2Attribute_Point_Offset;

	private static bool GetVector2Attribute_Metadata_IsValid;

	private static FFieldAddress GetVector2Attribute_Metadata_PropertyAddress;

	private static int GetVector2Attribute_Metadata_Offset;

	private static bool GetVector2Attribute_AttributeName_IsValid;

	private static FFieldAddress GetVector2Attribute_AttributeName_PropertyAddress;

	private static int GetVector2Attribute_AttributeName_Offset;

	private static bool GetVector2Attribute_ReturnValue_IsValid;

	private static FFieldAddress GetVector2Attribute_ReturnValue_PropertyAddress;

	private static int GetVector2Attribute_ReturnValue_Offset;

	private static bool GetTransformAttributeByMetadataKey_IsValid;

	private static IntPtr GetTransformAttributeByMetadataKey_FunctionAddress;

	private static int GetTransformAttributeByMetadataKey_ParamsSize;

	private static bool GetTransformAttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress GetTransformAttributeByMetadataKey_Key_PropertyAddress;

	private static int GetTransformAttributeByMetadataKey_Key_Offset;

	private static bool GetTransformAttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress GetTransformAttributeByMetadataKey_Metadata_PropertyAddress;

	private static int GetTransformAttributeByMetadataKey_Metadata_Offset;

	private static bool GetTransformAttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress GetTransformAttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int GetTransformAttributeByMetadataKey_AttributeName_Offset;

	private static bool GetTransformAttributeByMetadataKey_ReturnValue_IsValid;

	private static FFieldAddress GetTransformAttributeByMetadataKey_ReturnValue_PropertyAddress;

	private static int GetTransformAttributeByMetadataKey_ReturnValue_Offset;

	private static bool GetTransformAttribute_IsValid;

	private static IntPtr GetTransformAttribute_FunctionAddress;

	private static int GetTransformAttribute_ParamsSize;

	private static bool GetTransformAttribute_Point_IsValid;

	private static FFieldAddress GetTransformAttribute_Point_PropertyAddress;

	private static int GetTransformAttribute_Point_Offset;

	private static bool GetTransformAttribute_Metadata_IsValid;

	private static FFieldAddress GetTransformAttribute_Metadata_PropertyAddress;

	private static int GetTransformAttribute_Metadata_Offset;

	private static bool GetTransformAttribute_AttributeName_IsValid;

	private static FFieldAddress GetTransformAttribute_AttributeName_PropertyAddress;

	private static int GetTransformAttribute_AttributeName_Offset;

	private static bool GetTransformAttribute_ReturnValue_IsValid;

	private static FFieldAddress GetTransformAttribute_ReturnValue_PropertyAddress;

	private static int GetTransformAttribute_ReturnValue_Offset;

	private static bool GetStringAttributeByMetadataKey_IsValid;

	private static IntPtr GetStringAttributeByMetadataKey_FunctionAddress;

	private static int GetStringAttributeByMetadataKey_ParamsSize;

	private static bool GetStringAttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress GetStringAttributeByMetadataKey_Key_PropertyAddress;

	private static int GetStringAttributeByMetadataKey_Key_Offset;

	private static bool GetStringAttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress GetStringAttributeByMetadataKey_Metadata_PropertyAddress;

	private static int GetStringAttributeByMetadataKey_Metadata_Offset;

	private static bool GetStringAttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress GetStringAttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int GetStringAttributeByMetadataKey_AttributeName_Offset;

	private static bool GetStringAttributeByMetadataKey_ReturnValue_IsValid;

	private static FFieldAddress GetStringAttributeByMetadataKey_ReturnValue_PropertyAddress;

	private static int GetStringAttributeByMetadataKey_ReturnValue_Offset;

	private static bool GetStringAttribute_IsValid;

	private static IntPtr GetStringAttribute_FunctionAddress;

	private static int GetStringAttribute_ParamsSize;

	private static bool GetStringAttribute_Point_IsValid;

	private static FFieldAddress GetStringAttribute_Point_PropertyAddress;

	private static int GetStringAttribute_Point_Offset;

	private static bool GetStringAttribute_Metadata_IsValid;

	private static FFieldAddress GetStringAttribute_Metadata_PropertyAddress;

	private static int GetStringAttribute_Metadata_Offset;

	private static bool GetStringAttribute_AttributeName_IsValid;

	private static FFieldAddress GetStringAttribute_AttributeName_PropertyAddress;

	private static int GetStringAttribute_AttributeName_Offset;

	private static bool GetStringAttribute_ReturnValue_IsValid;

	private static FFieldAddress GetStringAttribute_ReturnValue_PropertyAddress;

	private static int GetStringAttribute_ReturnValue_Offset;

	private static bool GetRotatorAttributeByMetadataKey_IsValid;

	private static IntPtr GetRotatorAttributeByMetadataKey_FunctionAddress;

	private static int GetRotatorAttributeByMetadataKey_ParamsSize;

	private static bool GetRotatorAttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress GetRotatorAttributeByMetadataKey_Key_PropertyAddress;

	private static int GetRotatorAttributeByMetadataKey_Key_Offset;

	private static bool GetRotatorAttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress GetRotatorAttributeByMetadataKey_Metadata_PropertyAddress;

	private static int GetRotatorAttributeByMetadataKey_Metadata_Offset;

	private static bool GetRotatorAttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress GetRotatorAttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int GetRotatorAttributeByMetadataKey_AttributeName_Offset;

	private static bool GetRotatorAttributeByMetadataKey_ReturnValue_IsValid;

	private static FFieldAddress GetRotatorAttributeByMetadataKey_ReturnValue_PropertyAddress;

	private static int GetRotatorAttributeByMetadataKey_ReturnValue_Offset;

	private static bool GetRotatorAttribute_IsValid;

	private static IntPtr GetRotatorAttribute_FunctionAddress;

	private static int GetRotatorAttribute_ParamsSize;

	private static bool GetRotatorAttribute_Point_IsValid;

	private static FFieldAddress GetRotatorAttribute_Point_PropertyAddress;

	private static int GetRotatorAttribute_Point_Offset;

	private static bool GetRotatorAttribute_Metadata_IsValid;

	private static FFieldAddress GetRotatorAttribute_Metadata_PropertyAddress;

	private static int GetRotatorAttribute_Metadata_Offset;

	private static bool GetRotatorAttribute_AttributeName_IsValid;

	private static FFieldAddress GetRotatorAttribute_AttributeName_PropertyAddress;

	private static int GetRotatorAttribute_AttributeName_Offset;

	private static bool GetRotatorAttribute_ReturnValue_IsValid;

	private static FFieldAddress GetRotatorAttribute_ReturnValue_PropertyAddress;

	private static int GetRotatorAttribute_ReturnValue_Offset;

	private static bool GetQuatAttributeByMetadataKey_IsValid;

	private static IntPtr GetQuatAttributeByMetadataKey_FunctionAddress;

	private static int GetQuatAttributeByMetadataKey_ParamsSize;

	private static bool GetQuatAttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress GetQuatAttributeByMetadataKey_Key_PropertyAddress;

	private static int GetQuatAttributeByMetadataKey_Key_Offset;

	private static bool GetQuatAttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress GetQuatAttributeByMetadataKey_Metadata_PropertyAddress;

	private static int GetQuatAttributeByMetadataKey_Metadata_Offset;

	private static bool GetQuatAttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress GetQuatAttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int GetQuatAttributeByMetadataKey_AttributeName_Offset;

	private static bool GetQuatAttributeByMetadataKey_ReturnValue_IsValid;

	private static FFieldAddress GetQuatAttributeByMetadataKey_ReturnValue_PropertyAddress;

	private static int GetQuatAttributeByMetadataKey_ReturnValue_Offset;

	private static bool GetQuatAttribute_IsValid;

	private static IntPtr GetQuatAttribute_FunctionAddress;

	private static int GetQuatAttribute_ParamsSize;

	private static bool GetQuatAttribute_Point_IsValid;

	private static FFieldAddress GetQuatAttribute_Point_PropertyAddress;

	private static int GetQuatAttribute_Point_Offset;

	private static bool GetQuatAttribute_Metadata_IsValid;

	private static FFieldAddress GetQuatAttribute_Metadata_PropertyAddress;

	private static int GetQuatAttribute_Metadata_Offset;

	private static bool GetQuatAttribute_AttributeName_IsValid;

	private static FFieldAddress GetQuatAttribute_AttributeName_PropertyAddress;

	private static int GetQuatAttribute_AttributeName_Offset;

	private static bool GetQuatAttribute_ReturnValue_IsValid;

	private static FFieldAddress GetQuatAttribute_ReturnValue_PropertyAddress;

	private static int GetQuatAttribute_ReturnValue_Offset;

	private static bool GetNameAttribute_IsValid;

	private static IntPtr GetNameAttribute_FunctionAddress;

	private static int GetNameAttribute_ParamsSize;

	private static bool GetNameAttribute_Point_IsValid;

	private static FFieldAddress GetNameAttribute_Point_PropertyAddress;

	private static int GetNameAttribute_Point_Offset;

	private static bool GetNameAttribute_Metadata_IsValid;

	private static FFieldAddress GetNameAttribute_Metadata_PropertyAddress;

	private static int GetNameAttribute_Metadata_Offset;

	private static bool GetNameAttribute_AttributeName_IsValid;

	private static FFieldAddress GetNameAttribute_AttributeName_PropertyAddress;

	private static int GetNameAttribute_AttributeName_Offset;

	private static bool GetNameAttribute_ReturnValue_IsValid;

	private static FFieldAddress GetNameAttribute_ReturnValue_PropertyAddress;

	private static int GetNameAttribute_ReturnValue_Offset;

	private static bool GetInteger64AttributeByMetadataKey_IsValid;

	private static IntPtr GetInteger64AttributeByMetadataKey_FunctionAddress;

	private static int GetInteger64AttributeByMetadataKey_ParamsSize;

	private static bool GetInteger64AttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress GetInteger64AttributeByMetadataKey_Key_PropertyAddress;

	private static int GetInteger64AttributeByMetadataKey_Key_Offset;

	private static bool GetInteger64AttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress GetInteger64AttributeByMetadataKey_Metadata_PropertyAddress;

	private static int GetInteger64AttributeByMetadataKey_Metadata_Offset;

	private static bool GetInteger64AttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress GetInteger64AttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int GetInteger64AttributeByMetadataKey_AttributeName_Offset;

	private static bool GetInteger64AttributeByMetadataKey_ReturnValue_IsValid;

	private static FFieldAddress GetInteger64AttributeByMetadataKey_ReturnValue_PropertyAddress;

	private static int GetInteger64AttributeByMetadataKey_ReturnValue_Offset;

	private static bool GetInteger64Attribute_IsValid;

	private static IntPtr GetInteger64Attribute_FunctionAddress;

	private static int GetInteger64Attribute_ParamsSize;

	private static bool GetInteger64Attribute_Point_IsValid;

	private static FFieldAddress GetInteger64Attribute_Point_PropertyAddress;

	private static int GetInteger64Attribute_Point_Offset;

	private static bool GetInteger64Attribute_Metadata_IsValid;

	private static FFieldAddress GetInteger64Attribute_Metadata_PropertyAddress;

	private static int GetInteger64Attribute_Metadata_Offset;

	private static bool GetInteger64Attribute_AttributeName_IsValid;

	private static FFieldAddress GetInteger64Attribute_AttributeName_PropertyAddress;

	private static int GetInteger64Attribute_AttributeName_Offset;

	private static bool GetInteger64Attribute_ReturnValue_IsValid;

	private static FFieldAddress GetInteger64Attribute_ReturnValue_PropertyAddress;

	private static int GetInteger64Attribute_ReturnValue_Offset;

	private static bool GetInteger32AttributeByMetadataKey_IsValid;

	private static IntPtr GetInteger32AttributeByMetadataKey_FunctionAddress;

	private static int GetInteger32AttributeByMetadataKey_ParamsSize;

	private static bool GetInteger32AttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress GetInteger32AttributeByMetadataKey_Key_PropertyAddress;

	private static int GetInteger32AttributeByMetadataKey_Key_Offset;

	private static bool GetInteger32AttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress GetInteger32AttributeByMetadataKey_Metadata_PropertyAddress;

	private static int GetInteger32AttributeByMetadataKey_Metadata_Offset;

	private static bool GetInteger32AttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress GetInteger32AttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int GetInteger32AttributeByMetadataKey_AttributeName_Offset;

	private static bool GetInteger32AttributeByMetadataKey_ReturnValue_IsValid;

	private static FFieldAddress GetInteger32AttributeByMetadataKey_ReturnValue_PropertyAddress;

	private static int GetInteger32AttributeByMetadataKey_ReturnValue_Offset;

	private static bool GetInteger32Attribute_IsValid;

	private static IntPtr GetInteger32Attribute_FunctionAddress;

	private static int GetInteger32Attribute_ParamsSize;

	private static bool GetInteger32Attribute_Point_IsValid;

	private static FFieldAddress GetInteger32Attribute_Point_PropertyAddress;

	private static int GetInteger32Attribute_Point_Offset;

	private static bool GetInteger32Attribute_Metadata_IsValid;

	private static FFieldAddress GetInteger32Attribute_Metadata_PropertyAddress;

	private static int GetInteger32Attribute_Metadata_Offset;

	private static bool GetInteger32Attribute_AttributeName_IsValid;

	private static FFieldAddress GetInteger32Attribute_AttributeName_PropertyAddress;

	private static int GetInteger32Attribute_AttributeName_Offset;

	private static bool GetInteger32Attribute_ReturnValue_IsValid;

	private static FFieldAddress GetInteger32Attribute_ReturnValue_PropertyAddress;

	private static int GetInteger32Attribute_ReturnValue_Offset;

	private static bool GetFloatAttributeByMetadataKey_IsValid;

	private static IntPtr GetFloatAttributeByMetadataKey_FunctionAddress;

	private static int GetFloatAttributeByMetadataKey_ParamsSize;

	private static bool GetFloatAttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress GetFloatAttributeByMetadataKey_Key_PropertyAddress;

	private static int GetFloatAttributeByMetadataKey_Key_Offset;

	private static bool GetFloatAttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress GetFloatAttributeByMetadataKey_Metadata_PropertyAddress;

	private static int GetFloatAttributeByMetadataKey_Metadata_Offset;

	private static bool GetFloatAttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress GetFloatAttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int GetFloatAttributeByMetadataKey_AttributeName_Offset;

	private static bool GetFloatAttributeByMetadataKey_ReturnValue_IsValid;

	private static FFieldAddress GetFloatAttributeByMetadataKey_ReturnValue_PropertyAddress;

	private static int GetFloatAttributeByMetadataKey_ReturnValue_Offset;

	private static bool GetFloatAttribute_IsValid;

	private static IntPtr GetFloatAttribute_FunctionAddress;

	private static int GetFloatAttribute_ParamsSize;

	private static bool GetFloatAttribute_Point_IsValid;

	private static FFieldAddress GetFloatAttribute_Point_PropertyAddress;

	private static int GetFloatAttribute_Point_Offset;

	private static bool GetFloatAttribute_Metadata_IsValid;

	private static FFieldAddress GetFloatAttribute_Metadata_PropertyAddress;

	private static int GetFloatAttribute_Metadata_Offset;

	private static bool GetFloatAttribute_AttributeName_IsValid;

	private static FFieldAddress GetFloatAttribute_AttributeName_PropertyAddress;

	private static int GetFloatAttribute_AttributeName_Offset;

	private static bool GetFloatAttribute_ReturnValue_IsValid;

	private static FFieldAddress GetFloatAttribute_ReturnValue_PropertyAddress;

	private static int GetFloatAttribute_ReturnValue_Offset;

	private static bool GetDoubleAttributeByMetadataKey_IsValid;

	private static IntPtr GetDoubleAttributeByMetadataKey_FunctionAddress;

	private static int GetDoubleAttributeByMetadataKey_ParamsSize;

	private static bool GetDoubleAttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress GetDoubleAttributeByMetadataKey_Key_PropertyAddress;

	private static int GetDoubleAttributeByMetadataKey_Key_Offset;

	private static bool GetDoubleAttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress GetDoubleAttributeByMetadataKey_Metadata_PropertyAddress;

	private static int GetDoubleAttributeByMetadataKey_Metadata_Offset;

	private static bool GetDoubleAttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress GetDoubleAttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int GetDoubleAttributeByMetadataKey_AttributeName_Offset;

	private static bool GetDoubleAttributeByMetadataKey_ReturnValue_IsValid;

	private static FFieldAddress GetDoubleAttributeByMetadataKey_ReturnValue_PropertyAddress;

	private static int GetDoubleAttributeByMetadataKey_ReturnValue_Offset;

	private static bool GetDoubleAttribute_IsValid;

	private static IntPtr GetDoubleAttribute_FunctionAddress;

	private static int GetDoubleAttribute_ParamsSize;

	private static bool GetDoubleAttribute_Point_IsValid;

	private static FFieldAddress GetDoubleAttribute_Point_PropertyAddress;

	private static int GetDoubleAttribute_Point_Offset;

	private static bool GetDoubleAttribute_Metadata_IsValid;

	private static FFieldAddress GetDoubleAttribute_Metadata_PropertyAddress;

	private static int GetDoubleAttribute_Metadata_Offset;

	private static bool GetDoubleAttribute_AttributeName_IsValid;

	private static FFieldAddress GetDoubleAttribute_AttributeName_PropertyAddress;

	private static int GetDoubleAttribute_AttributeName_Offset;

	private static bool GetDoubleAttribute_ReturnValue_IsValid;

	private static FFieldAddress GetDoubleAttribute_ReturnValue_PropertyAddress;

	private static int GetDoubleAttribute_ReturnValue_Offset;

	private static bool GetBoolAttributeByMetadataKey_IsValid;

	private static IntPtr GetBoolAttributeByMetadataKey_FunctionAddress;

	private static int GetBoolAttributeByMetadataKey_ParamsSize;

	private static bool GetBoolAttributeByMetadataKey_Key_IsValid;

	private static FFieldAddress GetBoolAttributeByMetadataKey_Key_PropertyAddress;

	private static int GetBoolAttributeByMetadataKey_Key_Offset;

	private static bool GetBoolAttributeByMetadataKey_Metadata_IsValid;

	private static FFieldAddress GetBoolAttributeByMetadataKey_Metadata_PropertyAddress;

	private static int GetBoolAttributeByMetadataKey_Metadata_Offset;

	private static bool GetBoolAttributeByMetadataKey_AttributeName_IsValid;

	private static FFieldAddress GetBoolAttributeByMetadataKey_AttributeName_PropertyAddress;

	private static int GetBoolAttributeByMetadataKey_AttributeName_Offset;

	private static bool GetBoolAttributeByMetadataKey_ReturnValue_IsValid;

	private static FFieldAddress GetBoolAttributeByMetadataKey_ReturnValue_PropertyAddress;

	private static int GetBoolAttributeByMetadataKey_ReturnValue_Offset;

	private static bool GetBoolAttribute_IsValid;

	private static IntPtr GetBoolAttribute_FunctionAddress;

	private static int GetBoolAttribute_ParamsSize;

	private static bool GetBoolAttribute_Point_IsValid;

	private static FFieldAddress GetBoolAttribute_Point_PropertyAddress;

	private static int GetBoolAttribute_Point_Offset;

	private static bool GetBoolAttribute_Metadata_IsValid;

	private static FFieldAddress GetBoolAttribute_Metadata_PropertyAddress;

	private static int GetBoolAttribute_Metadata_Offset;

	private static bool GetBoolAttribute_AttributeName_IsValid;

	private static FFieldAddress GetBoolAttribute_AttributeName_PropertyAddress;

	private static int GetBoolAttribute_AttributeName_Offset;

	private static bool GetBoolAttribute_ReturnValue_IsValid;

	private static FFieldAddress GetBoolAttribute_ReturnValue_PropertyAddress;

	private static int GetBoolAttribute_ReturnValue_Offset;

	private static bool CopyPoint_IsValid;

	private static IntPtr CopyPoint_FunctionAddress;

	private static int CopyPoint_ParamsSize;

	private static bool CopyPoint_InPoint_IsValid;

	private static FFieldAddress CopyPoint_InPoint_PropertyAddress;

	private static int CopyPoint_InPoint_Offset;

	private static bool CopyPoint_OutPoint_IsValid;

	private static FFieldAddress CopyPoint_OutPoint_PropertyAddress;

	private static int CopyPoint_OutPoint_Offset;

	private static bool CopyPoint_bCopyMetadata_IsValid;

	private static FFieldAddress CopyPoint_bCopyMetadata_PropertyAddress;

	private static int CopyPoint_bCopyMetadata_Offset;

	private static bool CopyPoint_InMetadata_IsValid;

	private static FFieldAddress CopyPoint_InMetadata_PropertyAddress;

	private static int CopyPoint_InMetadata_Offset;

	private static bool CopyPoint_OutMetadata_IsValid;

	private static FFieldAddress CopyPoint_OutMetadata_PropertyAddress;

	private static int CopyPoint_OutMetadata_Offset;

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetVectorAttributeByMetadataKey")]
	public unsafe static void SetVectorAttributeByMetadataKey(ref long Key, UPCGMetadata Metadata, FName AttributeName, FVector Value)
	{
		if (!SetVectorAttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetVectorAttributeByMetadataKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVectorAttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVectorAttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, SetVectorAttributeByMetadataKey_Key_Offset), 0, SetVectorAttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetVectorAttributeByMetadataKey_Metadata_Offset), 0, SetVectorAttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVectorAttributeByMetadataKey_AttributeName_Offset), 0, SetVectorAttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetVectorAttributeByMetadataKey_Value_Offset), 0, SetVectorAttributeByMetadataKey_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetVectorAttributeByMetadataKey_FunctionAddress, intPtr, SetVectorAttributeByMetadataKey_ParamsSize);
		Key = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, SetVectorAttributeByMetadataKey_Key_Offset), 0, SetVectorAttributeByMetadataKey_Key_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetVectorAttribute")]
	public unsafe static void SetVectorAttribute(ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, FVector Value)
	{
		if (!SetVectorAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetVectorAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVectorAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVectorAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetVectorAttribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, SetVectorAttribute_Point_Offset), 0, SetVectorAttribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetVectorAttribute_Metadata_Offset), 0, SetVectorAttribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVectorAttribute_AttributeName_Offset), 0, SetVectorAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetVectorAttribute_Value_Offset), 0, SetVectorAttribute_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetVectorAttribute_FunctionAddress, intPtr, SetVectorAttribute_ParamsSize);
		Point = FPCGPoint.FromNative(IntPtr.Add(intPtr, SetVectorAttribute_Point_Offset), 0, SetVectorAttribute_Point_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetVector4AttributeByMetadataKey")]
	public unsafe static void SetVector4AttributeByMetadataKey(ref long Key, UPCGMetadata Metadata, FName AttributeName, FVector4 Value)
	{
		if (!SetVector4AttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetVector4AttributeByMetadataKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVector4AttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVector4AttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, SetVector4AttributeByMetadataKey_Key_Offset), 0, SetVector4AttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetVector4AttributeByMetadataKey_Metadata_Offset), 0, SetVector4AttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVector4AttributeByMetadataKey_AttributeName_Offset), 0, SetVector4AttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(intPtr, SetVector4AttributeByMetadataKey_Value_Offset), 0, SetVector4AttributeByMetadataKey_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetVector4AttributeByMetadataKey_FunctionAddress, intPtr, SetVector4AttributeByMetadataKey_ParamsSize);
		Key = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, SetVector4AttributeByMetadataKey_Key_Offset), 0, SetVector4AttributeByMetadataKey_Key_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetVector4Attribute")]
	public unsafe static void SetVector4Attribute(ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, FVector4 Value)
	{
		if (!SetVector4Attribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetVector4Attribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVector4Attribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVector4Attribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetVector4Attribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, SetVector4Attribute_Point_Offset), 0, SetVector4Attribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetVector4Attribute_Metadata_Offset), 0, SetVector4Attribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVector4Attribute_AttributeName_Offset), 0, SetVector4Attribute_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(intPtr, SetVector4Attribute_Value_Offset), 0, SetVector4Attribute_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetVector4Attribute_FunctionAddress, intPtr, SetVector4Attribute_ParamsSize);
		Point = FPCGPoint.FromNative(IntPtr.Add(intPtr, SetVector4Attribute_Point_Offset), 0, SetVector4Attribute_Point_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetVector2AttributeByMetadataKey")]
	public unsafe static void SetVector2AttributeByMetadataKey(ref long Key, UPCGMetadata Metadata, FName AttributeName, FVector2D Value)
	{
		if (!SetVector2AttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetVector2AttributeByMetadataKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVector2AttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVector2AttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, SetVector2AttributeByMetadataKey_Key_Offset), 0, SetVector2AttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetVector2AttributeByMetadataKey_Metadata_Offset), 0, SetVector2AttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVector2AttributeByMetadataKey_AttributeName_Offset), 0, SetVector2AttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetVector2AttributeByMetadataKey_Value_Offset), 0, SetVector2AttributeByMetadataKey_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetVector2AttributeByMetadataKey_FunctionAddress, intPtr, SetVector2AttributeByMetadataKey_ParamsSize);
		Key = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, SetVector2AttributeByMetadataKey_Key_Offset), 0, SetVector2AttributeByMetadataKey_Key_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetVector2Attribute")]
	public unsafe static void SetVector2Attribute(ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, FVector2D Value)
	{
		if (!SetVector2Attribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetVector2Attribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVector2Attribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVector2Attribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetVector2Attribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, SetVector2Attribute_Point_Offset), 0, SetVector2Attribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetVector2Attribute_Metadata_Offset), 0, SetVector2Attribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVector2Attribute_AttributeName_Offset), 0, SetVector2Attribute_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetVector2Attribute_Value_Offset), 0, SetVector2Attribute_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetVector2Attribute_FunctionAddress, intPtr, SetVector2Attribute_ParamsSize);
		Point = FPCGPoint.FromNative(IntPtr.Add(intPtr, SetVector2Attribute_Point_Offset), 0, SetVector2Attribute_Point_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetTransformAttributeByMetadataKey")]
	public unsafe static void SetTransformAttributeByMetadataKey(ref long Key, UPCGMetadata Metadata, FName AttributeName, FTransform Value)
	{
		if (!SetTransformAttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetTransformAttributeByMetadataKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTransformAttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTransformAttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, SetTransformAttributeByMetadataKey_Key_Offset), 0, SetTransformAttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetTransformAttributeByMetadataKey_Metadata_Offset), 0, SetTransformAttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetTransformAttributeByMetadataKey_AttributeName_Offset), 0, SetTransformAttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InitializeValue_InContainer(SetTransformAttributeByMetadataKey_Value_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetTransformAttributeByMetadataKey_Value_Offset), 0, SetTransformAttributeByMetadataKey_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetTransformAttributeByMetadataKey_FunctionAddress, intPtr, SetTransformAttributeByMetadataKey_ParamsSize);
		Key = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, SetTransformAttributeByMetadataKey_Key_Offset), 0, SetTransformAttributeByMetadataKey_Key_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetTransformAttribute")]
	public unsafe static void SetTransformAttribute(ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, FTransform Value)
	{
		if (!SetTransformAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetTransformAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTransformAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTransformAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetTransformAttribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, SetTransformAttribute_Point_Offset), 0, SetTransformAttribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetTransformAttribute_Metadata_Offset), 0, SetTransformAttribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetTransformAttribute_AttributeName_Offset), 0, SetTransformAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InitializeValue_InContainer(SetTransformAttribute_Value_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetTransformAttribute_Value_Offset), 0, SetTransformAttribute_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetTransformAttribute_FunctionAddress, intPtr, SetTransformAttribute_ParamsSize);
		Point = FPCGPoint.FromNative(IntPtr.Add(intPtr, SetTransformAttribute_Point_Offset), 0, SetTransformAttribute_Point_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetStringAttributeByMetadataKey")]
	public unsafe static void SetStringAttributeByMetadataKey(ref long Key, UPCGMetadata Metadata, FName AttributeName, string Value)
	{
		if (!SetStringAttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetStringAttributeByMetadataKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStringAttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStringAttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, SetStringAttributeByMetadataKey_Key_Offset), 0, SetStringAttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetStringAttributeByMetadataKey_Metadata_Offset), 0, SetStringAttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetStringAttributeByMetadataKey_AttributeName_Offset), 0, SetStringAttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetStringAttributeByMetadataKey_Value_Offset), 0, SetStringAttributeByMetadataKey_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStringAttributeByMetadataKey_FunctionAddress, intPtr, SetStringAttributeByMetadataKey_ParamsSize);
		Key = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, SetStringAttributeByMetadataKey_Key_Offset), 0, SetStringAttributeByMetadataKey_Key_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetStringAttributeByMetadataKey_Value_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetStringAttribute")]
	public unsafe static void SetStringAttribute(ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, string Value)
	{
		if (!SetStringAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetStringAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStringAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStringAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetStringAttribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, SetStringAttribute_Point_Offset), 0, SetStringAttribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetStringAttribute_Metadata_Offset), 0, SetStringAttribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetStringAttribute_AttributeName_Offset), 0, SetStringAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetStringAttribute_Value_Offset), 0, SetStringAttribute_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStringAttribute_FunctionAddress, intPtr, SetStringAttribute_ParamsSize);
		Point = FPCGPoint.FromNative(IntPtr.Add(intPtr, SetStringAttribute_Point_Offset), 0, SetStringAttribute_Point_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetStringAttribute_Value_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetRotatorAttributeByMetadataKey")]
	public unsafe static void SetRotatorAttributeByMetadataKey(ref long Key, UPCGMetadata Metadata, FName AttributeName, FRotator Value)
	{
		if (!SetRotatorAttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetRotatorAttributeByMetadataKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRotatorAttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRotatorAttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, SetRotatorAttributeByMetadataKey_Key_Offset), 0, SetRotatorAttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetRotatorAttributeByMetadataKey_Metadata_Offset), 0, SetRotatorAttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetRotatorAttributeByMetadataKey_AttributeName_Offset), 0, SetRotatorAttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetRotatorAttributeByMetadataKey_Value_Offset), 0, SetRotatorAttributeByMetadataKey_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetRotatorAttributeByMetadataKey_FunctionAddress, intPtr, SetRotatorAttributeByMetadataKey_ParamsSize);
		Key = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, SetRotatorAttributeByMetadataKey_Key_Offset), 0, SetRotatorAttributeByMetadataKey_Key_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetRotatorAttribute")]
	public unsafe static void SetRotatorAttribute(ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, FRotator Value)
	{
		if (!SetRotatorAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetRotatorAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRotatorAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRotatorAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetRotatorAttribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, SetRotatorAttribute_Point_Offset), 0, SetRotatorAttribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetRotatorAttribute_Metadata_Offset), 0, SetRotatorAttribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetRotatorAttribute_AttributeName_Offset), 0, SetRotatorAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetRotatorAttribute_Value_Offset), 0, SetRotatorAttribute_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetRotatorAttribute_FunctionAddress, intPtr, SetRotatorAttribute_ParamsSize);
		Point = FPCGPoint.FromNative(IntPtr.Add(intPtr, SetRotatorAttribute_Point_Offset), 0, SetRotatorAttribute_Point_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetQuatAttributeByMetadataKey")]
	public unsafe static void SetQuatAttributeByMetadataKey(ref long Key, UPCGMetadata Metadata, FName AttributeName, FQuat Value)
	{
		if (!SetQuatAttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetQuatAttributeByMetadataKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetQuatAttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetQuatAttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, SetQuatAttributeByMetadataKey_Key_Offset), 0, SetQuatAttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetQuatAttributeByMetadataKey_Metadata_Offset), 0, SetQuatAttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetQuatAttributeByMetadataKey_AttributeName_Offset), 0, SetQuatAttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InitializeValue_InContainer(SetQuatAttributeByMetadataKey_Value_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(intPtr, SetQuatAttributeByMetadataKey_Value_Offset), 0, SetQuatAttributeByMetadataKey_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetQuatAttributeByMetadataKey_FunctionAddress, intPtr, SetQuatAttributeByMetadataKey_ParamsSize);
		Key = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, SetQuatAttributeByMetadataKey_Key_Offset), 0, SetQuatAttributeByMetadataKey_Key_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetQuatAttribute")]
	public unsafe static void SetQuatAttribute(ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, FQuat Value)
	{
		if (!SetQuatAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetQuatAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetQuatAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetQuatAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetQuatAttribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, SetQuatAttribute_Point_Offset), 0, SetQuatAttribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetQuatAttribute_Metadata_Offset), 0, SetQuatAttribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetQuatAttribute_AttributeName_Offset), 0, SetQuatAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InitializeValue_InContainer(SetQuatAttribute_Value_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(intPtr, SetQuatAttribute_Value_Offset), 0, SetQuatAttribute_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetQuatAttribute_FunctionAddress, intPtr, SetQuatAttribute_ParamsSize);
		Point = FPCGPoint.FromNative(IntPtr.Add(intPtr, SetQuatAttribute_Point_Offset), 0, SetQuatAttribute_Point_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetNameAttribute")]
	public unsafe static void SetNameAttribute(ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, FName Value)
	{
		if (!SetNameAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetNameAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNameAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNameAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetNameAttribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, SetNameAttribute_Point_Offset), 0, SetNameAttribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetNameAttribute_Metadata_Offset), 0, SetNameAttribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNameAttribute_AttributeName_Offset), 0, SetNameAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNameAttribute_Value_Offset), 0, SetNameAttribute_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNameAttribute_FunctionAddress, intPtr, SetNameAttribute_ParamsSize);
		Point = FPCGPoint.FromNative(IntPtr.Add(intPtr, SetNameAttribute_Point_Offset), 0, SetNameAttribute_Point_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetInteger64AttributeByMetadataKey")]
	public unsafe static void SetInteger64AttributeByMetadataKey(ref long Key, UPCGMetadata Metadata, FName AttributeName, long Value)
	{
		if (!SetInteger64AttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetInteger64AttributeByMetadataKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInteger64AttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInteger64AttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, SetInteger64AttributeByMetadataKey_Key_Offset), 0, SetInteger64AttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetInteger64AttributeByMetadataKey_Metadata_Offset), 0, SetInteger64AttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetInteger64AttributeByMetadataKey_AttributeName_Offset), 0, SetInteger64AttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, SetInteger64AttributeByMetadataKey_Value_Offset), 0, SetInteger64AttributeByMetadataKey_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetInteger64AttributeByMetadataKey_FunctionAddress, intPtr, SetInteger64AttributeByMetadataKey_ParamsSize);
		Key = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, SetInteger64AttributeByMetadataKey_Key_Offset), 0, SetInteger64AttributeByMetadataKey_Key_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetInteger64Attribute")]
	public unsafe static void SetInteger64Attribute(ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, long Value)
	{
		if (!SetInteger64Attribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetInteger64Attribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInteger64Attribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInteger64Attribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetInteger64Attribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, SetInteger64Attribute_Point_Offset), 0, SetInteger64Attribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetInteger64Attribute_Metadata_Offset), 0, SetInteger64Attribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetInteger64Attribute_AttributeName_Offset), 0, SetInteger64Attribute_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, SetInteger64Attribute_Value_Offset), 0, SetInteger64Attribute_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetInteger64Attribute_FunctionAddress, intPtr, SetInteger64Attribute_ParamsSize);
		Point = FPCGPoint.FromNative(IntPtr.Add(intPtr, SetInteger64Attribute_Point_Offset), 0, SetInteger64Attribute_Point_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetInteger32AttributeByMetadataKey")]
	public unsafe static void SetInteger32AttributeByMetadataKey(ref long Key, UPCGMetadata Metadata, FName AttributeName, int Value)
	{
		if (!SetInteger32AttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetInteger32AttributeByMetadataKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInteger32AttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInteger32AttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, SetInteger32AttributeByMetadataKey_Key_Offset), 0, SetInteger32AttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetInteger32AttributeByMetadataKey_Metadata_Offset), 0, SetInteger32AttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetInteger32AttributeByMetadataKey_AttributeName_Offset), 0, SetInteger32AttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetInteger32AttributeByMetadataKey_Value_Offset), 0, SetInteger32AttributeByMetadataKey_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetInteger32AttributeByMetadataKey_FunctionAddress, intPtr, SetInteger32AttributeByMetadataKey_ParamsSize);
		Key = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, SetInteger32AttributeByMetadataKey_Key_Offset), 0, SetInteger32AttributeByMetadataKey_Key_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetInteger32Attribute")]
	public unsafe static void SetInteger32Attribute(ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, int Value)
	{
		if (!SetInteger32Attribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetInteger32Attribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInteger32Attribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInteger32Attribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetInteger32Attribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, SetInteger32Attribute_Point_Offset), 0, SetInteger32Attribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetInteger32Attribute_Metadata_Offset), 0, SetInteger32Attribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetInteger32Attribute_AttributeName_Offset), 0, SetInteger32Attribute_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetInteger32Attribute_Value_Offset), 0, SetInteger32Attribute_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetInteger32Attribute_FunctionAddress, intPtr, SetInteger32Attribute_ParamsSize);
		Point = FPCGPoint.FromNative(IntPtr.Add(intPtr, SetInteger32Attribute_Point_Offset), 0, SetInteger32Attribute_Point_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetFloatAttributeByMetadataKey")]
	public unsafe static void SetFloatAttributeByMetadataKey(ref long Key, UPCGMetadata Metadata, FName AttributeName, float Value)
	{
		if (!SetFloatAttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetFloatAttributeByMetadataKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFloatAttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFloatAttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, SetFloatAttributeByMetadataKey_Key_Offset), 0, SetFloatAttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetFloatAttributeByMetadataKey_Metadata_Offset), 0, SetFloatAttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetFloatAttributeByMetadataKey_AttributeName_Offset), 0, SetFloatAttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFloatAttributeByMetadataKey_Value_Offset), 0, SetFloatAttributeByMetadataKey_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetFloatAttributeByMetadataKey_FunctionAddress, intPtr, SetFloatAttributeByMetadataKey_ParamsSize);
		Key = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, SetFloatAttributeByMetadataKey_Key_Offset), 0, SetFloatAttributeByMetadataKey_Key_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetFloatAttribute")]
	public unsafe static void SetFloatAttribute(ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, float Value)
	{
		if (!SetFloatAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetFloatAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFloatAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFloatAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetFloatAttribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, SetFloatAttribute_Point_Offset), 0, SetFloatAttribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetFloatAttribute_Metadata_Offset), 0, SetFloatAttribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetFloatAttribute_AttributeName_Offset), 0, SetFloatAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFloatAttribute_Value_Offset), 0, SetFloatAttribute_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetFloatAttribute_FunctionAddress, intPtr, SetFloatAttribute_ParamsSize);
		Point = FPCGPoint.FromNative(IntPtr.Add(intPtr, SetFloatAttribute_Point_Offset), 0, SetFloatAttribute_Point_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetDoubleAttributeByMetadataKey")]
	public unsafe static void SetDoubleAttributeByMetadataKey(ref long Key, UPCGMetadata Metadata, FName AttributeName, double Value)
	{
		if (!SetDoubleAttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetDoubleAttributeByMetadataKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDoubleAttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDoubleAttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, SetDoubleAttributeByMetadataKey_Key_Offset), 0, SetDoubleAttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetDoubleAttributeByMetadataKey_Metadata_Offset), 0, SetDoubleAttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetDoubleAttributeByMetadataKey_AttributeName_Offset), 0, SetDoubleAttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(intPtr, SetDoubleAttributeByMetadataKey_Value_Offset), 0, SetDoubleAttributeByMetadataKey_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetDoubleAttributeByMetadataKey_FunctionAddress, intPtr, SetDoubleAttributeByMetadataKey_ParamsSize);
		Key = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, SetDoubleAttributeByMetadataKey_Key_Offset), 0, SetDoubleAttributeByMetadataKey_Key_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetDoubleAttribute")]
	public unsafe static void SetDoubleAttribute(ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, double Value)
	{
		if (!SetDoubleAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetDoubleAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDoubleAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDoubleAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetDoubleAttribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, SetDoubleAttribute_Point_Offset), 0, SetDoubleAttribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetDoubleAttribute_Metadata_Offset), 0, SetDoubleAttribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetDoubleAttribute_AttributeName_Offset), 0, SetDoubleAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(intPtr, SetDoubleAttribute_Value_Offset), 0, SetDoubleAttribute_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetDoubleAttribute_FunctionAddress, intPtr, SetDoubleAttribute_ParamsSize);
		Point = FPCGPoint.FromNative(IntPtr.Add(intPtr, SetDoubleAttribute_Point_Offset), 0, SetDoubleAttribute_Point_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetBoolAttributeByMetadataKey")]
	public unsafe static void SetBoolAttributeByMetadataKey(ref long Key, UPCGMetadata Metadata, FName AttributeName, bool Value)
	{
		if (!SetBoolAttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetBoolAttributeByMetadataKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBoolAttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBoolAttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, SetBoolAttributeByMetadataKey_Key_Offset), 0, SetBoolAttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetBoolAttributeByMetadataKey_Metadata_Offset), 0, SetBoolAttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetBoolAttributeByMetadataKey_AttributeName_Offset), 0, SetBoolAttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBoolAttributeByMetadataKey_Value_Offset), 0, SetBoolAttributeByMetadataKey_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBoolAttributeByMetadataKey_FunctionAddress, intPtr, SetBoolAttributeByMetadataKey_ParamsSize);
		Key = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, SetBoolAttributeByMetadataKey_Key_Offset), 0, SetBoolAttributeByMetadataKey_Key_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetBoolAttribute")]
	public unsafe static void SetBoolAttribute(ref FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName, bool Value)
	{
		if (!SetBoolAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetBoolAttribute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBoolAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBoolAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetBoolAttribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, SetBoolAttribute_Point_Offset), 0, SetBoolAttribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetBoolAttribute_Metadata_Offset), 0, SetBoolAttribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetBoolAttribute_AttributeName_Offset), 0, SetBoolAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBoolAttribute_Value_Offset), 0, SetBoolAttribute_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBoolAttribute_FunctionAddress, intPtr, SetBoolAttribute_ParamsSize);
		Point = FPCGPoint.FromNative(IntPtr.Add(intPtr, SetBoolAttribute_Point_Offset), 0, SetBoolAttribute_Point_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:SetAttributeFromPropertyByMetadataKey")]
	public unsafe static bool SetAttributeFromPropertyByMetadataKey(ref long Key, UPCGMetadata Metadata, FName AttributeName, UObject Object, FName PropertyName)
	{
		if (!SetAttributeFromPropertyByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:SetAttributeFromPropertyByMetadataKey");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAttributeFromPropertyByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAttributeFromPropertyByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, SetAttributeFromPropertyByMetadataKey_Key_Offset), 0, SetAttributeFromPropertyByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SetAttributeFromPropertyByMetadataKey_Metadata_Offset), 0, SetAttributeFromPropertyByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetAttributeFromPropertyByMetadataKey_AttributeName_Offset), 0, SetAttributeFromPropertyByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetAttributeFromPropertyByMetadataKey_Object_Offset), 0, SetAttributeFromPropertyByMetadataKey_Object_PropertyAddress.Address, Object);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetAttributeFromPropertyByMetadataKey_PropertyName_Offset), 0, SetAttributeFromPropertyByMetadataKey_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAttributeFromPropertyByMetadataKey_FunctionAddress, intPtr, SetAttributeFromPropertyByMetadataKey_ParamsSize);
		Key = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, SetAttributeFromPropertyByMetadataKey_Key_Offset), 0, SetAttributeFromPropertyByMetadataKey_Key_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetAttributeFromPropertyByMetadataKey_ReturnValue_Offset), 0, SetAttributeFromPropertyByMetadataKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:InitializeMetadata")]
	public unsafe static void InitializeMetadata(ref FPCGPoint Point, UPCGMetadata Metadata, FPCGPoint ParentPoint, UPCGMetadata ParentMetadata)
	{
		if (!InitializeMetadata_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:InitializeMetadata");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitializeMetadata_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitializeMetadata_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(InitializeMetadata_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, InitializeMetadata_Point_Offset), 0, InitializeMetadata_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, InitializeMetadata_Metadata_Offset), 0, InitializeMetadata_Metadata_PropertyAddress.Address, Metadata);
		NativeReflection.InitializeValue_InContainer(InitializeMetadata_ParentPoint_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, InitializeMetadata_ParentPoint_Offset), 0, InitializeMetadata_ParentPoint_PropertyAddress.Address, ParentPoint);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, InitializeMetadata_ParentMetadata_Offset), 0, InitializeMetadata_ParentMetadata_PropertyAddress.Address, ParentMetadata);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, InitializeMetadata_FunctionAddress, intPtr, InitializeMetadata_ParamsSize);
		Point = FPCGPoint.FromNative(IntPtr.Add(intPtr, InitializeMetadata_Point_Offset), 0, InitializeMetadata_Point_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:HasAttributeSetByMetadataKey")]
	public unsafe static bool HasAttributeSetByMetadataKey(long Key, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!HasAttributeSetByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:HasAttributeSetByMetadataKey");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasAttributeSetByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasAttributeSetByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, HasAttributeSetByMetadataKey_Key_Offset), 0, HasAttributeSetByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, HasAttributeSetByMetadataKey_Metadata_Offset), 0, HasAttributeSetByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, HasAttributeSetByMetadataKey_AttributeName_Offset), 0, HasAttributeSetByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, HasAttributeSetByMetadataKey_FunctionAddress, intPtr, HasAttributeSetByMetadataKey_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasAttributeSetByMetadataKey_ReturnValue_Offset), 0, HasAttributeSetByMetadataKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:HasAttributeSet")]
	public unsafe static bool HasAttributeSet(FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!HasAttributeSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:HasAttributeSet");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasAttributeSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasAttributeSet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(HasAttributeSet_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, HasAttributeSet_Point_Offset), 0, HasAttributeSet_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, HasAttributeSet_Metadata_Offset), 0, HasAttributeSet_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, HasAttributeSet_AttributeName_Offset), 0, HasAttributeSet_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, HasAttributeSet_FunctionAddress, intPtr, HasAttributeSet_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasAttributeSet_ReturnValue_Offset), 0, HasAttributeSet_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetVectorAttributeByMetadataKey")]
	public unsafe static FVector GetVectorAttributeByMetadataKey(long Key, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetVectorAttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetVectorAttributeByMetadataKey");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVectorAttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVectorAttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, GetVectorAttributeByMetadataKey_Key_Offset), 0, GetVectorAttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetVectorAttributeByMetadataKey_Metadata_Offset), 0, GetVectorAttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetVectorAttributeByMetadataKey_AttributeName_Offset), 0, GetVectorAttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVectorAttributeByMetadataKey_FunctionAddress, intPtr, GetVectorAttributeByMetadataKey_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetVectorAttributeByMetadataKey_ReturnValue_Offset), 0, GetVectorAttributeByMetadataKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetVectorAttribute")]
	public unsafe static FVector GetVectorAttribute(FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetVectorAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetVectorAttribute");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVectorAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVectorAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVectorAttribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, GetVectorAttribute_Point_Offset), 0, GetVectorAttribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetVectorAttribute_Metadata_Offset), 0, GetVectorAttribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetVectorAttribute_AttributeName_Offset), 0, GetVectorAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVectorAttribute_FunctionAddress, intPtr, GetVectorAttribute_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetVectorAttribute_ReturnValue_Offset), 0, GetVectorAttribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetVector4AttributeByMetadataKey")]
	public unsafe static FVector4 GetVector4AttributeByMetadataKey(long Key, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetVector4AttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetVector4AttributeByMetadataKey");
			return default(FVector4);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVector4AttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVector4AttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, GetVector4AttributeByMetadataKey_Key_Offset), 0, GetVector4AttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetVector4AttributeByMetadataKey_Metadata_Offset), 0, GetVector4AttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetVector4AttributeByMetadataKey_AttributeName_Offset), 0, GetVector4AttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVector4AttributeByMetadataKey_FunctionAddress, intPtr, GetVector4AttributeByMetadataKey_ParamsSize);
		return BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(intPtr, GetVector4AttributeByMetadataKey_ReturnValue_Offset), 0, GetVector4AttributeByMetadataKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetVector4Attribute")]
	public unsafe static FVector4 GetVector4Attribute(FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetVector4Attribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetVector4Attribute");
			return default(FVector4);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVector4Attribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVector4Attribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVector4Attribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, GetVector4Attribute_Point_Offset), 0, GetVector4Attribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetVector4Attribute_Metadata_Offset), 0, GetVector4Attribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetVector4Attribute_AttributeName_Offset), 0, GetVector4Attribute_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVector4Attribute_FunctionAddress, intPtr, GetVector4Attribute_ParamsSize);
		return BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(intPtr, GetVector4Attribute_ReturnValue_Offset), 0, GetVector4Attribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetVector2AttributeByMetadataKey")]
	public unsafe static FVector2D GetVector2AttributeByMetadataKey(long Key, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetVector2AttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetVector2AttributeByMetadataKey");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVector2AttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVector2AttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, GetVector2AttributeByMetadataKey_Key_Offset), 0, GetVector2AttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetVector2AttributeByMetadataKey_Metadata_Offset), 0, GetVector2AttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetVector2AttributeByMetadataKey_AttributeName_Offset), 0, GetVector2AttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVector2AttributeByMetadataKey_FunctionAddress, intPtr, GetVector2AttributeByMetadataKey_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetVector2AttributeByMetadataKey_ReturnValue_Offset), 0, GetVector2AttributeByMetadataKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetVector2Attribute")]
	public unsafe static FVector2D GetVector2Attribute(FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetVector2Attribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetVector2Attribute");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVector2Attribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVector2Attribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVector2Attribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, GetVector2Attribute_Point_Offset), 0, GetVector2Attribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetVector2Attribute_Metadata_Offset), 0, GetVector2Attribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetVector2Attribute_AttributeName_Offset), 0, GetVector2Attribute_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVector2Attribute_FunctionAddress, intPtr, GetVector2Attribute_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetVector2Attribute_ReturnValue_Offset), 0, GetVector2Attribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetTransformAttributeByMetadataKey")]
	public unsafe static FTransform GetTransformAttributeByMetadataKey(long Key, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetTransformAttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetTransformAttributeByMetadataKey");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTransformAttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTransformAttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, GetTransformAttributeByMetadataKey_Key_Offset), 0, GetTransformAttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetTransformAttributeByMetadataKey_Metadata_Offset), 0, GetTransformAttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetTransformAttributeByMetadataKey_AttributeName_Offset), 0, GetTransformAttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTransformAttributeByMetadataKey_FunctionAddress, intPtr, GetTransformAttributeByMetadataKey_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetTransformAttributeByMetadataKey_ReturnValue_Offset), 0, GetTransformAttributeByMetadataKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetTransformAttribute")]
	public unsafe static FTransform GetTransformAttribute(FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetTransformAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetTransformAttribute");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTransformAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTransformAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTransformAttribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, GetTransformAttribute_Point_Offset), 0, GetTransformAttribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetTransformAttribute_Metadata_Offset), 0, GetTransformAttribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetTransformAttribute_AttributeName_Offset), 0, GetTransformAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTransformAttribute_FunctionAddress, intPtr, GetTransformAttribute_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetTransformAttribute_ReturnValue_Offset), 0, GetTransformAttribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetStringAttributeByMetadataKey")]
	public unsafe static string GetStringAttributeByMetadataKey(long Key, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetStringAttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetStringAttributeByMetadataKey");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStringAttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStringAttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, GetStringAttributeByMetadataKey_Key_Offset), 0, GetStringAttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetStringAttributeByMetadataKey_Metadata_Offset), 0, GetStringAttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetStringAttributeByMetadataKey_AttributeName_Offset), 0, GetStringAttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStringAttributeByMetadataKey_FunctionAddress, intPtr, GetStringAttributeByMetadataKey_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetStringAttributeByMetadataKey_ReturnValue_Offset), 0, GetStringAttributeByMetadataKey_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetStringAttributeByMetadataKey_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetStringAttribute")]
	public unsafe static string GetStringAttribute(FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetStringAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetStringAttribute");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStringAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStringAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetStringAttribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, GetStringAttribute_Point_Offset), 0, GetStringAttribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetStringAttribute_Metadata_Offset), 0, GetStringAttribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetStringAttribute_AttributeName_Offset), 0, GetStringAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStringAttribute_FunctionAddress, intPtr, GetStringAttribute_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetStringAttribute_ReturnValue_Offset), 0, GetStringAttribute_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetStringAttribute_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetRotatorAttributeByMetadataKey")]
	public unsafe static FRotator GetRotatorAttributeByMetadataKey(long Key, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetRotatorAttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetRotatorAttributeByMetadataKey");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRotatorAttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRotatorAttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, GetRotatorAttributeByMetadataKey_Key_Offset), 0, GetRotatorAttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetRotatorAttributeByMetadataKey_Metadata_Offset), 0, GetRotatorAttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetRotatorAttributeByMetadataKey_AttributeName_Offset), 0, GetRotatorAttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRotatorAttributeByMetadataKey_FunctionAddress, intPtr, GetRotatorAttributeByMetadataKey_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetRotatorAttributeByMetadataKey_ReturnValue_Offset), 0, GetRotatorAttributeByMetadataKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetRotatorAttribute")]
	public unsafe static FRotator GetRotatorAttribute(FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetRotatorAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetRotatorAttribute");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRotatorAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRotatorAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetRotatorAttribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, GetRotatorAttribute_Point_Offset), 0, GetRotatorAttribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetRotatorAttribute_Metadata_Offset), 0, GetRotatorAttribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetRotatorAttribute_AttributeName_Offset), 0, GetRotatorAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRotatorAttribute_FunctionAddress, intPtr, GetRotatorAttribute_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetRotatorAttribute_ReturnValue_Offset), 0, GetRotatorAttribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetQuatAttributeByMetadataKey")]
	public unsafe static FQuat GetQuatAttributeByMetadataKey(long Key, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetQuatAttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetQuatAttributeByMetadataKey");
			return default(FQuat);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetQuatAttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetQuatAttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, GetQuatAttributeByMetadataKey_Key_Offset), 0, GetQuatAttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetQuatAttributeByMetadataKey_Metadata_Offset), 0, GetQuatAttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetQuatAttributeByMetadataKey_AttributeName_Offset), 0, GetQuatAttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetQuatAttributeByMetadataKey_FunctionAddress, intPtr, GetQuatAttributeByMetadataKey_ParamsSize);
		return BlittableTypeMarshaler<FQuat>.FromNative(IntPtr.Add(intPtr, GetQuatAttributeByMetadataKey_ReturnValue_Offset), 0, GetQuatAttributeByMetadataKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetQuatAttribute")]
	public unsafe static FQuat GetQuatAttribute(FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetQuatAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetQuatAttribute");
			return default(FQuat);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetQuatAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetQuatAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetQuatAttribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, GetQuatAttribute_Point_Offset), 0, GetQuatAttribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetQuatAttribute_Metadata_Offset), 0, GetQuatAttribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetQuatAttribute_AttributeName_Offset), 0, GetQuatAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetQuatAttribute_FunctionAddress, intPtr, GetQuatAttribute_ParamsSize);
		return BlittableTypeMarshaler<FQuat>.FromNative(IntPtr.Add(intPtr, GetQuatAttribute_ReturnValue_Offset), 0, GetQuatAttribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetNameAttribute")]
	public unsafe static FName GetNameAttribute(FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetNameAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetNameAttribute");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNameAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNameAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNameAttribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, GetNameAttribute_Point_Offset), 0, GetNameAttribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetNameAttribute_Metadata_Offset), 0, GetNameAttribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetNameAttribute_AttributeName_Offset), 0, GetNameAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNameAttribute_FunctionAddress, intPtr, GetNameAttribute_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetNameAttribute_ReturnValue_Offset), 0, GetNameAttribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetInteger64AttributeByMetadataKey")]
	public unsafe static long GetInteger64AttributeByMetadataKey(long Key, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetInteger64AttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetInteger64AttributeByMetadataKey");
			return 0L;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInteger64AttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInteger64AttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, GetInteger64AttributeByMetadataKey_Key_Offset), 0, GetInteger64AttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetInteger64AttributeByMetadataKey_Metadata_Offset), 0, GetInteger64AttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetInteger64AttributeByMetadataKey_AttributeName_Offset), 0, GetInteger64AttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInteger64AttributeByMetadataKey_FunctionAddress, intPtr, GetInteger64AttributeByMetadataKey_ParamsSize);
		return BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, GetInteger64AttributeByMetadataKey_ReturnValue_Offset), 0, GetInteger64AttributeByMetadataKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetInteger64Attribute")]
	public unsafe static long GetInteger64Attribute(FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetInteger64Attribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetInteger64Attribute");
			return 0L;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInteger64Attribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInteger64Attribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetInteger64Attribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, GetInteger64Attribute_Point_Offset), 0, GetInteger64Attribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetInteger64Attribute_Metadata_Offset), 0, GetInteger64Attribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetInteger64Attribute_AttributeName_Offset), 0, GetInteger64Attribute_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInteger64Attribute_FunctionAddress, intPtr, GetInteger64Attribute_ParamsSize);
		return BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, GetInteger64Attribute_ReturnValue_Offset), 0, GetInteger64Attribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetInteger32AttributeByMetadataKey")]
	public unsafe static int GetInteger32AttributeByMetadataKey(long Key, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetInteger32AttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetInteger32AttributeByMetadataKey");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInteger32AttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInteger32AttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, GetInteger32AttributeByMetadataKey_Key_Offset), 0, GetInteger32AttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetInteger32AttributeByMetadataKey_Metadata_Offset), 0, GetInteger32AttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetInteger32AttributeByMetadataKey_AttributeName_Offset), 0, GetInteger32AttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInteger32AttributeByMetadataKey_FunctionAddress, intPtr, GetInteger32AttributeByMetadataKey_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetInteger32AttributeByMetadataKey_ReturnValue_Offset), 0, GetInteger32AttributeByMetadataKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetInteger32Attribute")]
	public unsafe static int GetInteger32Attribute(FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetInteger32Attribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetInteger32Attribute");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInteger32Attribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInteger32Attribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetInteger32Attribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, GetInteger32Attribute_Point_Offset), 0, GetInteger32Attribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetInteger32Attribute_Metadata_Offset), 0, GetInteger32Attribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetInteger32Attribute_AttributeName_Offset), 0, GetInteger32Attribute_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInteger32Attribute_FunctionAddress, intPtr, GetInteger32Attribute_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetInteger32Attribute_ReturnValue_Offset), 0, GetInteger32Attribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetFloatAttributeByMetadataKey")]
	public unsafe static float GetFloatAttributeByMetadataKey(long Key, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetFloatAttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetFloatAttributeByMetadataKey");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFloatAttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFloatAttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, GetFloatAttributeByMetadataKey_Key_Offset), 0, GetFloatAttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetFloatAttributeByMetadataKey_Metadata_Offset), 0, GetFloatAttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetFloatAttributeByMetadataKey_AttributeName_Offset), 0, GetFloatAttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFloatAttributeByMetadataKey_FunctionAddress, intPtr, GetFloatAttributeByMetadataKey_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFloatAttributeByMetadataKey_ReturnValue_Offset), 0, GetFloatAttributeByMetadataKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetFloatAttribute")]
	public unsafe static float GetFloatAttribute(FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetFloatAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetFloatAttribute");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFloatAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFloatAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetFloatAttribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, GetFloatAttribute_Point_Offset), 0, GetFloatAttribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetFloatAttribute_Metadata_Offset), 0, GetFloatAttribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetFloatAttribute_AttributeName_Offset), 0, GetFloatAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFloatAttribute_FunctionAddress, intPtr, GetFloatAttribute_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFloatAttribute_ReturnValue_Offset), 0, GetFloatAttribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetDoubleAttributeByMetadataKey")]
	public unsafe static double GetDoubleAttributeByMetadataKey(long Key, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetDoubleAttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetDoubleAttributeByMetadataKey");
			return 0.0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDoubleAttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDoubleAttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, GetDoubleAttributeByMetadataKey_Key_Offset), 0, GetDoubleAttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetDoubleAttributeByMetadataKey_Metadata_Offset), 0, GetDoubleAttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetDoubleAttributeByMetadataKey_AttributeName_Offset), 0, GetDoubleAttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDoubleAttributeByMetadataKey_FunctionAddress, intPtr, GetDoubleAttributeByMetadataKey_ParamsSize);
		return BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(intPtr, GetDoubleAttributeByMetadataKey_ReturnValue_Offset), 0, GetDoubleAttributeByMetadataKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetDoubleAttribute")]
	public unsafe static double GetDoubleAttribute(FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetDoubleAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetDoubleAttribute");
			return 0.0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDoubleAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDoubleAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetDoubleAttribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, GetDoubleAttribute_Point_Offset), 0, GetDoubleAttribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetDoubleAttribute_Metadata_Offset), 0, GetDoubleAttribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetDoubleAttribute_AttributeName_Offset), 0, GetDoubleAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDoubleAttribute_FunctionAddress, intPtr, GetDoubleAttribute_ParamsSize);
		return BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(intPtr, GetDoubleAttribute_ReturnValue_Offset), 0, GetDoubleAttribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetBoolAttributeByMetadataKey")]
	public unsafe static bool GetBoolAttributeByMetadataKey(long Key, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetBoolAttributeByMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetBoolAttributeByMetadataKey");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoolAttributeByMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoolAttributeByMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, GetBoolAttributeByMetadataKey_Key_Offset), 0, GetBoolAttributeByMetadataKey_Key_PropertyAddress.Address, Key);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetBoolAttributeByMetadataKey_Metadata_Offset), 0, GetBoolAttributeByMetadataKey_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetBoolAttributeByMetadataKey_AttributeName_Offset), 0, GetBoolAttributeByMetadataKey_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBoolAttributeByMetadataKey_FunctionAddress, intPtr, GetBoolAttributeByMetadataKey_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBoolAttributeByMetadataKey_ReturnValue_Offset), 0, GetBoolAttributeByMetadataKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:GetBoolAttribute")]
	public unsafe static bool GetBoolAttribute(FPCGPoint Point, UPCGMetadata Metadata, FName AttributeName)
	{
		if (!GetBoolAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:GetBoolAttribute");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoolAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoolAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetBoolAttribute_Point_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, GetBoolAttribute_Point_Offset), 0, GetBoolAttribute_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, GetBoolAttribute_Metadata_Offset), 0, GetBoolAttribute_Metadata_PropertyAddress.Address, Metadata);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetBoolAttribute_AttributeName_Offset), 0, GetBoolAttribute_AttributeName_PropertyAddress.Address, AttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBoolAttribute_FunctionAddress, intPtr, GetBoolAttribute_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBoolAttribute_ReturnValue_Offset), 0, GetBoolAttribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGMetadataAccessorHelpers:CopyPoint")]
	public unsafe static void CopyPoint(FPCGPoint InPoint, out FPCGPoint OutPoint, bool bCopyMetadata, UPCGMetadata InMetadata, UPCGMetadata OutMetadata)
	{
		if (!CopyPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMetadataAccessorHelpers:CopyPoint");
			OutPoint = default(FPCGPoint);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CopyPoint_InPoint_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, CopyPoint_InPoint_Offset), 0, CopyPoint_InPoint_PropertyAddress.Address, InPoint);
		NativeReflection.InitializeValue_InContainer(CopyPoint_OutPoint_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CopyPoint_bCopyMetadata_Offset), 0, CopyPoint_bCopyMetadata_PropertyAddress.Address, bCopyMetadata);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, CopyPoint_InMetadata_Offset), 0, CopyPoint_InMetadata_PropertyAddress.Address, InMetadata);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, CopyPoint_OutMetadata_Offset), 0, CopyPoint_OutMetadata_PropertyAddress.Address, OutMetadata);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyPoint_FunctionAddress, intPtr, CopyPoint_ParamsSize);
		OutPoint = FPCGPoint.FromNative(IntPtr.Add(intPtr, CopyPoint_OutPoint_Offset), 0, CopyPoint_OutPoint_PropertyAddress.Address);
	}

	static UPCGMetadataAccessorHelpers()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGMetadataAccessorHelpers)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGMetadataAccessorHelpers));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/PCG.PCGMetadataAccessorHelpers");
		SetVectorAttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetVectorAttributeByMetadataKey");
		SetVectorAttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVectorAttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVectorAttributeByMetadataKey_Key_PropertyAddress, SetVectorAttributeByMetadataKey_FunctionAddress, "Key");
		SetVectorAttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorAttributeByMetadataKey_FunctionAddress, "Key");
		SetVectorAttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorAttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref SetVectorAttributeByMetadataKey_Metadata_PropertyAddress, SetVectorAttributeByMetadataKey_FunctionAddress, "Metadata");
		SetVectorAttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorAttributeByMetadataKey_FunctionAddress, "Metadata");
		SetVectorAttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorAttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVectorAttributeByMetadataKey_AttributeName_PropertyAddress, SetVectorAttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetVectorAttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorAttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetVectorAttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorAttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVectorAttributeByMetadataKey_Value_PropertyAddress, SetVectorAttributeByMetadataKey_FunctionAddress, "Value");
		SetVectorAttributeByMetadataKey_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorAttributeByMetadataKey_FunctionAddress, "Value");
		SetVectorAttributeByMetadataKey_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorAttributeByMetadataKey_FunctionAddress, "Value", Classes.FStructProperty);
		SetVectorAttributeByMetadataKey_IsValid = SetVectorAttributeByMetadataKey_FunctionAddress != IntPtr.Zero && SetVectorAttributeByMetadataKey_Key_IsValid && SetVectorAttributeByMetadataKey_Metadata_IsValid && SetVectorAttributeByMetadataKey_AttributeName_IsValid && SetVectorAttributeByMetadataKey_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetVectorAttributeByMetadataKey", SetVectorAttributeByMetadataKey_IsValid);
		SetVectorAttribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetVectorAttribute");
		SetVectorAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVectorAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVectorAttribute_Point_PropertyAddress, SetVectorAttribute_FunctionAddress, "Point");
		SetVectorAttribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorAttribute_FunctionAddress, "Point");
		SetVectorAttribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorAttribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVectorAttribute_Metadata_PropertyAddress, SetVectorAttribute_FunctionAddress, "Metadata");
		SetVectorAttribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorAttribute_FunctionAddress, "Metadata");
		SetVectorAttribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorAttribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVectorAttribute_AttributeName_PropertyAddress, SetVectorAttribute_FunctionAddress, "AttributeName");
		SetVectorAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorAttribute_FunctionAddress, "AttributeName");
		SetVectorAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVectorAttribute_Value_PropertyAddress, SetVectorAttribute_FunctionAddress, "Value");
		SetVectorAttribute_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorAttribute_FunctionAddress, "Value");
		SetVectorAttribute_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorAttribute_FunctionAddress, "Value", Classes.FStructProperty);
		SetVectorAttribute_IsValid = SetVectorAttribute_FunctionAddress != IntPtr.Zero && SetVectorAttribute_Point_IsValid && SetVectorAttribute_Metadata_IsValid && SetVectorAttribute_AttributeName_IsValid && SetVectorAttribute_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetVectorAttribute", SetVectorAttribute_IsValid);
		SetVector4AttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetVector4AttributeByMetadataKey");
		SetVector4AttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVector4AttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVector4AttributeByMetadataKey_Key_PropertyAddress, SetVector4AttributeByMetadataKey_FunctionAddress, "Key");
		SetVector4AttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetVector4AttributeByMetadataKey_FunctionAddress, "Key");
		SetVector4AttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector4AttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref SetVector4AttributeByMetadataKey_Metadata_PropertyAddress, SetVector4AttributeByMetadataKey_FunctionAddress, "Metadata");
		SetVector4AttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetVector4AttributeByMetadataKey_FunctionAddress, "Metadata");
		SetVector4AttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector4AttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVector4AttributeByMetadataKey_AttributeName_PropertyAddress, SetVector4AttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetVector4AttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetVector4AttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetVector4AttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector4AttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVector4AttributeByMetadataKey_Value_PropertyAddress, SetVector4AttributeByMetadataKey_FunctionAddress, "Value");
		SetVector4AttributeByMetadataKey_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetVector4AttributeByMetadataKey_FunctionAddress, "Value");
		SetVector4AttributeByMetadataKey_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector4AttributeByMetadataKey_FunctionAddress, "Value", Classes.FStructProperty);
		SetVector4AttributeByMetadataKey_IsValid = SetVector4AttributeByMetadataKey_FunctionAddress != IntPtr.Zero && SetVector4AttributeByMetadataKey_Key_IsValid && SetVector4AttributeByMetadataKey_Metadata_IsValid && SetVector4AttributeByMetadataKey_AttributeName_IsValid && SetVector4AttributeByMetadataKey_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetVector4AttributeByMetadataKey", SetVector4AttributeByMetadataKey_IsValid);
		SetVector4Attribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetVector4Attribute");
		SetVector4Attribute_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVector4Attribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVector4Attribute_Point_PropertyAddress, SetVector4Attribute_FunctionAddress, "Point");
		SetVector4Attribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(SetVector4Attribute_FunctionAddress, "Point");
		SetVector4Attribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector4Attribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVector4Attribute_Metadata_PropertyAddress, SetVector4Attribute_FunctionAddress, "Metadata");
		SetVector4Attribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetVector4Attribute_FunctionAddress, "Metadata");
		SetVector4Attribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector4Attribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVector4Attribute_AttributeName_PropertyAddress, SetVector4Attribute_FunctionAddress, "AttributeName");
		SetVector4Attribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetVector4Attribute_FunctionAddress, "AttributeName");
		SetVector4Attribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector4Attribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVector4Attribute_Value_PropertyAddress, SetVector4Attribute_FunctionAddress, "Value");
		SetVector4Attribute_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetVector4Attribute_FunctionAddress, "Value");
		SetVector4Attribute_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector4Attribute_FunctionAddress, "Value", Classes.FStructProperty);
		SetVector4Attribute_IsValid = SetVector4Attribute_FunctionAddress != IntPtr.Zero && SetVector4Attribute_Point_IsValid && SetVector4Attribute_Metadata_IsValid && SetVector4Attribute_AttributeName_IsValid && SetVector4Attribute_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetVector4Attribute", SetVector4Attribute_IsValid);
		SetVector2AttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetVector2AttributeByMetadataKey");
		SetVector2AttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVector2AttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVector2AttributeByMetadataKey_Key_PropertyAddress, SetVector2AttributeByMetadataKey_FunctionAddress, "Key");
		SetVector2AttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetVector2AttributeByMetadataKey_FunctionAddress, "Key");
		SetVector2AttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector2AttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref SetVector2AttributeByMetadataKey_Metadata_PropertyAddress, SetVector2AttributeByMetadataKey_FunctionAddress, "Metadata");
		SetVector2AttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetVector2AttributeByMetadataKey_FunctionAddress, "Metadata");
		SetVector2AttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector2AttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVector2AttributeByMetadataKey_AttributeName_PropertyAddress, SetVector2AttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetVector2AttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetVector2AttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetVector2AttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector2AttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVector2AttributeByMetadataKey_Value_PropertyAddress, SetVector2AttributeByMetadataKey_FunctionAddress, "Value");
		SetVector2AttributeByMetadataKey_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetVector2AttributeByMetadataKey_FunctionAddress, "Value");
		SetVector2AttributeByMetadataKey_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector2AttributeByMetadataKey_FunctionAddress, "Value", Classes.FStructProperty);
		SetVector2AttributeByMetadataKey_IsValid = SetVector2AttributeByMetadataKey_FunctionAddress != IntPtr.Zero && SetVector2AttributeByMetadataKey_Key_IsValid && SetVector2AttributeByMetadataKey_Metadata_IsValid && SetVector2AttributeByMetadataKey_AttributeName_IsValid && SetVector2AttributeByMetadataKey_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetVector2AttributeByMetadataKey", SetVector2AttributeByMetadataKey_IsValid);
		SetVector2Attribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetVector2Attribute");
		SetVector2Attribute_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVector2Attribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVector2Attribute_Point_PropertyAddress, SetVector2Attribute_FunctionAddress, "Point");
		SetVector2Attribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(SetVector2Attribute_FunctionAddress, "Point");
		SetVector2Attribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector2Attribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVector2Attribute_Metadata_PropertyAddress, SetVector2Attribute_FunctionAddress, "Metadata");
		SetVector2Attribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetVector2Attribute_FunctionAddress, "Metadata");
		SetVector2Attribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector2Attribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVector2Attribute_AttributeName_PropertyAddress, SetVector2Attribute_FunctionAddress, "AttributeName");
		SetVector2Attribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetVector2Attribute_FunctionAddress, "AttributeName");
		SetVector2Attribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector2Attribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVector2Attribute_Value_PropertyAddress, SetVector2Attribute_FunctionAddress, "Value");
		SetVector2Attribute_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetVector2Attribute_FunctionAddress, "Value");
		SetVector2Attribute_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector2Attribute_FunctionAddress, "Value", Classes.FStructProperty);
		SetVector2Attribute_IsValid = SetVector2Attribute_FunctionAddress != IntPtr.Zero && SetVector2Attribute_Point_IsValid && SetVector2Attribute_Metadata_IsValid && SetVector2Attribute_AttributeName_IsValid && SetVector2Attribute_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetVector2Attribute", SetVector2Attribute_IsValid);
		SetTransformAttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetTransformAttributeByMetadataKey");
		SetTransformAttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTransformAttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTransformAttributeByMetadataKey_Key_PropertyAddress, SetTransformAttributeByMetadataKey_FunctionAddress, "Key");
		SetTransformAttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetTransformAttributeByMetadataKey_FunctionAddress, "Key");
		SetTransformAttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTransformAttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref SetTransformAttributeByMetadataKey_Metadata_PropertyAddress, SetTransformAttributeByMetadataKey_FunctionAddress, "Metadata");
		SetTransformAttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetTransformAttributeByMetadataKey_FunctionAddress, "Metadata");
		SetTransformAttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTransformAttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTransformAttributeByMetadataKey_AttributeName_PropertyAddress, SetTransformAttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetTransformAttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetTransformAttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetTransformAttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTransformAttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTransformAttributeByMetadataKey_Value_PropertyAddress, SetTransformAttributeByMetadataKey_FunctionAddress, "Value");
		SetTransformAttributeByMetadataKey_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetTransformAttributeByMetadataKey_FunctionAddress, "Value");
		SetTransformAttributeByMetadataKey_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTransformAttributeByMetadataKey_FunctionAddress, "Value", Classes.FStructProperty);
		SetTransformAttributeByMetadataKey_IsValid = SetTransformAttributeByMetadataKey_FunctionAddress != IntPtr.Zero && SetTransformAttributeByMetadataKey_Key_IsValid && SetTransformAttributeByMetadataKey_Metadata_IsValid && SetTransformAttributeByMetadataKey_AttributeName_IsValid && SetTransformAttributeByMetadataKey_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetTransformAttributeByMetadataKey", SetTransformAttributeByMetadataKey_IsValid);
		SetTransformAttribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetTransformAttribute");
		SetTransformAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTransformAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTransformAttribute_Point_PropertyAddress, SetTransformAttribute_FunctionAddress, "Point");
		SetTransformAttribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(SetTransformAttribute_FunctionAddress, "Point");
		SetTransformAttribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTransformAttribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTransformAttribute_Metadata_PropertyAddress, SetTransformAttribute_FunctionAddress, "Metadata");
		SetTransformAttribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetTransformAttribute_FunctionAddress, "Metadata");
		SetTransformAttribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTransformAttribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTransformAttribute_AttributeName_PropertyAddress, SetTransformAttribute_FunctionAddress, "AttributeName");
		SetTransformAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetTransformAttribute_FunctionAddress, "AttributeName");
		SetTransformAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTransformAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTransformAttribute_Value_PropertyAddress, SetTransformAttribute_FunctionAddress, "Value");
		SetTransformAttribute_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetTransformAttribute_FunctionAddress, "Value");
		SetTransformAttribute_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTransformAttribute_FunctionAddress, "Value", Classes.FStructProperty);
		SetTransformAttribute_IsValid = SetTransformAttribute_FunctionAddress != IntPtr.Zero && SetTransformAttribute_Point_IsValid && SetTransformAttribute_Metadata_IsValid && SetTransformAttribute_AttributeName_IsValid && SetTransformAttribute_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetTransformAttribute", SetTransformAttribute_IsValid);
		SetStringAttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStringAttributeByMetadataKey");
		SetStringAttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStringAttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStringAttributeByMetadataKey_Key_PropertyAddress, SetStringAttributeByMetadataKey_FunctionAddress, "Key");
		SetStringAttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetStringAttributeByMetadataKey_FunctionAddress, "Key");
		SetStringAttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStringAttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref SetStringAttributeByMetadataKey_Metadata_PropertyAddress, SetStringAttributeByMetadataKey_FunctionAddress, "Metadata");
		SetStringAttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetStringAttributeByMetadataKey_FunctionAddress, "Metadata");
		SetStringAttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStringAttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStringAttributeByMetadataKey_AttributeName_PropertyAddress, SetStringAttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetStringAttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetStringAttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetStringAttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStringAttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStringAttributeByMetadataKey_Value_PropertyAddress, SetStringAttributeByMetadataKey_FunctionAddress, "Value");
		SetStringAttributeByMetadataKey_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetStringAttributeByMetadataKey_FunctionAddress, "Value");
		SetStringAttributeByMetadataKey_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStringAttributeByMetadataKey_FunctionAddress, "Value", Classes.FStrProperty);
		SetStringAttributeByMetadataKey_IsValid = SetStringAttributeByMetadataKey_FunctionAddress != IntPtr.Zero && SetStringAttributeByMetadataKey_Key_IsValid && SetStringAttributeByMetadataKey_Metadata_IsValid && SetStringAttributeByMetadataKey_AttributeName_IsValid && SetStringAttributeByMetadataKey_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetStringAttributeByMetadataKey", SetStringAttributeByMetadataKey_IsValid);
		SetStringAttribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStringAttribute");
		SetStringAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStringAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStringAttribute_Point_PropertyAddress, SetStringAttribute_FunctionAddress, "Point");
		SetStringAttribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(SetStringAttribute_FunctionAddress, "Point");
		SetStringAttribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStringAttribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStringAttribute_Metadata_PropertyAddress, SetStringAttribute_FunctionAddress, "Metadata");
		SetStringAttribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetStringAttribute_FunctionAddress, "Metadata");
		SetStringAttribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStringAttribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStringAttribute_AttributeName_PropertyAddress, SetStringAttribute_FunctionAddress, "AttributeName");
		SetStringAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetStringAttribute_FunctionAddress, "AttributeName");
		SetStringAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStringAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStringAttribute_Value_PropertyAddress, SetStringAttribute_FunctionAddress, "Value");
		SetStringAttribute_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetStringAttribute_FunctionAddress, "Value");
		SetStringAttribute_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStringAttribute_FunctionAddress, "Value", Classes.FStrProperty);
		SetStringAttribute_IsValid = SetStringAttribute_FunctionAddress != IntPtr.Zero && SetStringAttribute_Point_IsValid && SetStringAttribute_Metadata_IsValid && SetStringAttribute_AttributeName_IsValid && SetStringAttribute_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetStringAttribute", SetStringAttribute_IsValid);
		SetRotatorAttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetRotatorAttributeByMetadataKey");
		SetRotatorAttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRotatorAttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRotatorAttributeByMetadataKey_Key_PropertyAddress, SetRotatorAttributeByMetadataKey_FunctionAddress, "Key");
		SetRotatorAttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetRotatorAttributeByMetadataKey_FunctionAddress, "Key");
		SetRotatorAttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRotatorAttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref SetRotatorAttributeByMetadataKey_Metadata_PropertyAddress, SetRotatorAttributeByMetadataKey_FunctionAddress, "Metadata");
		SetRotatorAttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetRotatorAttributeByMetadataKey_FunctionAddress, "Metadata");
		SetRotatorAttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRotatorAttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRotatorAttributeByMetadataKey_AttributeName_PropertyAddress, SetRotatorAttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetRotatorAttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetRotatorAttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetRotatorAttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRotatorAttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRotatorAttributeByMetadataKey_Value_PropertyAddress, SetRotatorAttributeByMetadataKey_FunctionAddress, "Value");
		SetRotatorAttributeByMetadataKey_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetRotatorAttributeByMetadataKey_FunctionAddress, "Value");
		SetRotatorAttributeByMetadataKey_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRotatorAttributeByMetadataKey_FunctionAddress, "Value", Classes.FStructProperty);
		SetRotatorAttributeByMetadataKey_IsValid = SetRotatorAttributeByMetadataKey_FunctionAddress != IntPtr.Zero && SetRotatorAttributeByMetadataKey_Key_IsValid && SetRotatorAttributeByMetadataKey_Metadata_IsValid && SetRotatorAttributeByMetadataKey_AttributeName_IsValid && SetRotatorAttributeByMetadataKey_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetRotatorAttributeByMetadataKey", SetRotatorAttributeByMetadataKey_IsValid);
		SetRotatorAttribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetRotatorAttribute");
		SetRotatorAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRotatorAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRotatorAttribute_Point_PropertyAddress, SetRotatorAttribute_FunctionAddress, "Point");
		SetRotatorAttribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(SetRotatorAttribute_FunctionAddress, "Point");
		SetRotatorAttribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRotatorAttribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRotatorAttribute_Metadata_PropertyAddress, SetRotatorAttribute_FunctionAddress, "Metadata");
		SetRotatorAttribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetRotatorAttribute_FunctionAddress, "Metadata");
		SetRotatorAttribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRotatorAttribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRotatorAttribute_AttributeName_PropertyAddress, SetRotatorAttribute_FunctionAddress, "AttributeName");
		SetRotatorAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetRotatorAttribute_FunctionAddress, "AttributeName");
		SetRotatorAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRotatorAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRotatorAttribute_Value_PropertyAddress, SetRotatorAttribute_FunctionAddress, "Value");
		SetRotatorAttribute_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetRotatorAttribute_FunctionAddress, "Value");
		SetRotatorAttribute_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRotatorAttribute_FunctionAddress, "Value", Classes.FStructProperty);
		SetRotatorAttribute_IsValid = SetRotatorAttribute_FunctionAddress != IntPtr.Zero && SetRotatorAttribute_Point_IsValid && SetRotatorAttribute_Metadata_IsValid && SetRotatorAttribute_AttributeName_IsValid && SetRotatorAttribute_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetRotatorAttribute", SetRotatorAttribute_IsValid);
		SetQuatAttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetQuatAttributeByMetadataKey");
		SetQuatAttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(SetQuatAttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetQuatAttributeByMetadataKey_Key_PropertyAddress, SetQuatAttributeByMetadataKey_FunctionAddress, "Key");
		SetQuatAttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetQuatAttributeByMetadataKey_FunctionAddress, "Key");
		SetQuatAttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetQuatAttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref SetQuatAttributeByMetadataKey_Metadata_PropertyAddress, SetQuatAttributeByMetadataKey_FunctionAddress, "Metadata");
		SetQuatAttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetQuatAttributeByMetadataKey_FunctionAddress, "Metadata");
		SetQuatAttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetQuatAttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetQuatAttributeByMetadataKey_AttributeName_PropertyAddress, SetQuatAttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetQuatAttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetQuatAttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetQuatAttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetQuatAttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetQuatAttributeByMetadataKey_Value_PropertyAddress, SetQuatAttributeByMetadataKey_FunctionAddress, "Value");
		SetQuatAttributeByMetadataKey_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetQuatAttributeByMetadataKey_FunctionAddress, "Value");
		SetQuatAttributeByMetadataKey_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetQuatAttributeByMetadataKey_FunctionAddress, "Value", Classes.FStructProperty);
		SetQuatAttributeByMetadataKey_IsValid = SetQuatAttributeByMetadataKey_FunctionAddress != IntPtr.Zero && SetQuatAttributeByMetadataKey_Key_IsValid && SetQuatAttributeByMetadataKey_Metadata_IsValid && SetQuatAttributeByMetadataKey_AttributeName_IsValid && SetQuatAttributeByMetadataKey_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetQuatAttributeByMetadataKey", SetQuatAttributeByMetadataKey_IsValid);
		SetQuatAttribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetQuatAttribute");
		SetQuatAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(SetQuatAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetQuatAttribute_Point_PropertyAddress, SetQuatAttribute_FunctionAddress, "Point");
		SetQuatAttribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(SetQuatAttribute_FunctionAddress, "Point");
		SetQuatAttribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(SetQuatAttribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetQuatAttribute_Metadata_PropertyAddress, SetQuatAttribute_FunctionAddress, "Metadata");
		SetQuatAttribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetQuatAttribute_FunctionAddress, "Metadata");
		SetQuatAttribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetQuatAttribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetQuatAttribute_AttributeName_PropertyAddress, SetQuatAttribute_FunctionAddress, "AttributeName");
		SetQuatAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetQuatAttribute_FunctionAddress, "AttributeName");
		SetQuatAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetQuatAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetQuatAttribute_Value_PropertyAddress, SetQuatAttribute_FunctionAddress, "Value");
		SetQuatAttribute_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetQuatAttribute_FunctionAddress, "Value");
		SetQuatAttribute_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetQuatAttribute_FunctionAddress, "Value", Classes.FStructProperty);
		SetQuatAttribute_IsValid = SetQuatAttribute_FunctionAddress != IntPtr.Zero && SetQuatAttribute_Point_IsValid && SetQuatAttribute_Metadata_IsValid && SetQuatAttribute_AttributeName_IsValid && SetQuatAttribute_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetQuatAttribute", SetQuatAttribute_IsValid);
		SetNameAttribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNameAttribute");
		SetNameAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNameAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNameAttribute_Point_PropertyAddress, SetNameAttribute_FunctionAddress, "Point");
		SetNameAttribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(SetNameAttribute_FunctionAddress, "Point");
		SetNameAttribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNameAttribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNameAttribute_Metadata_PropertyAddress, SetNameAttribute_FunctionAddress, "Metadata");
		SetNameAttribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetNameAttribute_FunctionAddress, "Metadata");
		SetNameAttribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNameAttribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNameAttribute_AttributeName_PropertyAddress, SetNameAttribute_FunctionAddress, "AttributeName");
		SetNameAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetNameAttribute_FunctionAddress, "AttributeName");
		SetNameAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNameAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNameAttribute_Value_PropertyAddress, SetNameAttribute_FunctionAddress, "Value");
		SetNameAttribute_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetNameAttribute_FunctionAddress, "Value");
		SetNameAttribute_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNameAttribute_FunctionAddress, "Value", Classes.FNameProperty);
		SetNameAttribute_IsValid = SetNameAttribute_FunctionAddress != IntPtr.Zero && SetNameAttribute_Point_IsValid && SetNameAttribute_Metadata_IsValid && SetNameAttribute_AttributeName_IsValid && SetNameAttribute_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetNameAttribute", SetNameAttribute_IsValid);
		SetInteger64AttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetInteger64AttributeByMetadataKey");
		SetInteger64AttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInteger64AttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInteger64AttributeByMetadataKey_Key_PropertyAddress, SetInteger64AttributeByMetadataKey_FunctionAddress, "Key");
		SetInteger64AttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetInteger64AttributeByMetadataKey_FunctionAddress, "Key");
		SetInteger64AttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInteger64AttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref SetInteger64AttributeByMetadataKey_Metadata_PropertyAddress, SetInteger64AttributeByMetadataKey_FunctionAddress, "Metadata");
		SetInteger64AttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetInteger64AttributeByMetadataKey_FunctionAddress, "Metadata");
		SetInteger64AttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInteger64AttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInteger64AttributeByMetadataKey_AttributeName_PropertyAddress, SetInteger64AttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetInteger64AttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetInteger64AttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetInteger64AttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInteger64AttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInteger64AttributeByMetadataKey_Value_PropertyAddress, SetInteger64AttributeByMetadataKey_FunctionAddress, "Value");
		SetInteger64AttributeByMetadataKey_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetInteger64AttributeByMetadataKey_FunctionAddress, "Value");
		SetInteger64AttributeByMetadataKey_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInteger64AttributeByMetadataKey_FunctionAddress, "Value", Classes.FInt64Property);
		SetInteger64AttributeByMetadataKey_IsValid = SetInteger64AttributeByMetadataKey_FunctionAddress != IntPtr.Zero && SetInteger64AttributeByMetadataKey_Key_IsValid && SetInteger64AttributeByMetadataKey_Metadata_IsValid && SetInteger64AttributeByMetadataKey_AttributeName_IsValid && SetInteger64AttributeByMetadataKey_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetInteger64AttributeByMetadataKey", SetInteger64AttributeByMetadataKey_IsValid);
		SetInteger64Attribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetInteger64Attribute");
		SetInteger64Attribute_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInteger64Attribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInteger64Attribute_Point_PropertyAddress, SetInteger64Attribute_FunctionAddress, "Point");
		SetInteger64Attribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(SetInteger64Attribute_FunctionAddress, "Point");
		SetInteger64Attribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInteger64Attribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInteger64Attribute_Metadata_PropertyAddress, SetInteger64Attribute_FunctionAddress, "Metadata");
		SetInteger64Attribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetInteger64Attribute_FunctionAddress, "Metadata");
		SetInteger64Attribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInteger64Attribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInteger64Attribute_AttributeName_PropertyAddress, SetInteger64Attribute_FunctionAddress, "AttributeName");
		SetInteger64Attribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetInteger64Attribute_FunctionAddress, "AttributeName");
		SetInteger64Attribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInteger64Attribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInteger64Attribute_Value_PropertyAddress, SetInteger64Attribute_FunctionAddress, "Value");
		SetInteger64Attribute_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetInteger64Attribute_FunctionAddress, "Value");
		SetInteger64Attribute_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInteger64Attribute_FunctionAddress, "Value", Classes.FInt64Property);
		SetInteger64Attribute_IsValid = SetInteger64Attribute_FunctionAddress != IntPtr.Zero && SetInteger64Attribute_Point_IsValid && SetInteger64Attribute_Metadata_IsValid && SetInteger64Attribute_AttributeName_IsValid && SetInteger64Attribute_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetInteger64Attribute", SetInteger64Attribute_IsValid);
		SetInteger32AttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetInteger32AttributeByMetadataKey");
		SetInteger32AttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInteger32AttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInteger32AttributeByMetadataKey_Key_PropertyAddress, SetInteger32AttributeByMetadataKey_FunctionAddress, "Key");
		SetInteger32AttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetInteger32AttributeByMetadataKey_FunctionAddress, "Key");
		SetInteger32AttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInteger32AttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref SetInteger32AttributeByMetadataKey_Metadata_PropertyAddress, SetInteger32AttributeByMetadataKey_FunctionAddress, "Metadata");
		SetInteger32AttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetInteger32AttributeByMetadataKey_FunctionAddress, "Metadata");
		SetInteger32AttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInteger32AttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInteger32AttributeByMetadataKey_AttributeName_PropertyAddress, SetInteger32AttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetInteger32AttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetInteger32AttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetInteger32AttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInteger32AttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInteger32AttributeByMetadataKey_Value_PropertyAddress, SetInteger32AttributeByMetadataKey_FunctionAddress, "Value");
		SetInteger32AttributeByMetadataKey_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetInteger32AttributeByMetadataKey_FunctionAddress, "Value");
		SetInteger32AttributeByMetadataKey_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInteger32AttributeByMetadataKey_FunctionAddress, "Value", Classes.FIntProperty);
		SetInteger32AttributeByMetadataKey_IsValid = SetInteger32AttributeByMetadataKey_FunctionAddress != IntPtr.Zero && SetInteger32AttributeByMetadataKey_Key_IsValid && SetInteger32AttributeByMetadataKey_Metadata_IsValid && SetInteger32AttributeByMetadataKey_AttributeName_IsValid && SetInteger32AttributeByMetadataKey_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetInteger32AttributeByMetadataKey", SetInteger32AttributeByMetadataKey_IsValid);
		SetInteger32Attribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetInteger32Attribute");
		SetInteger32Attribute_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInteger32Attribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInteger32Attribute_Point_PropertyAddress, SetInteger32Attribute_FunctionAddress, "Point");
		SetInteger32Attribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(SetInteger32Attribute_FunctionAddress, "Point");
		SetInteger32Attribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInteger32Attribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInteger32Attribute_Metadata_PropertyAddress, SetInteger32Attribute_FunctionAddress, "Metadata");
		SetInteger32Attribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetInteger32Attribute_FunctionAddress, "Metadata");
		SetInteger32Attribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInteger32Attribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInteger32Attribute_AttributeName_PropertyAddress, SetInteger32Attribute_FunctionAddress, "AttributeName");
		SetInteger32Attribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetInteger32Attribute_FunctionAddress, "AttributeName");
		SetInteger32Attribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInteger32Attribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInteger32Attribute_Value_PropertyAddress, SetInteger32Attribute_FunctionAddress, "Value");
		SetInteger32Attribute_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetInteger32Attribute_FunctionAddress, "Value");
		SetInteger32Attribute_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInteger32Attribute_FunctionAddress, "Value", Classes.FIntProperty);
		SetInteger32Attribute_IsValid = SetInteger32Attribute_FunctionAddress != IntPtr.Zero && SetInteger32Attribute_Point_IsValid && SetInteger32Attribute_Metadata_IsValid && SetInteger32Attribute_AttributeName_IsValid && SetInteger32Attribute_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetInteger32Attribute", SetInteger32Attribute_IsValid);
		SetFloatAttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetFloatAttributeByMetadataKey");
		SetFloatAttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFloatAttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFloatAttributeByMetadataKey_Key_PropertyAddress, SetFloatAttributeByMetadataKey_FunctionAddress, "Key");
		SetFloatAttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatAttributeByMetadataKey_FunctionAddress, "Key");
		SetFloatAttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatAttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref SetFloatAttributeByMetadataKey_Metadata_PropertyAddress, SetFloatAttributeByMetadataKey_FunctionAddress, "Metadata");
		SetFloatAttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatAttributeByMetadataKey_FunctionAddress, "Metadata");
		SetFloatAttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatAttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFloatAttributeByMetadataKey_AttributeName_PropertyAddress, SetFloatAttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetFloatAttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatAttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetFloatAttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatAttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFloatAttributeByMetadataKey_Value_PropertyAddress, SetFloatAttributeByMetadataKey_FunctionAddress, "Value");
		SetFloatAttributeByMetadataKey_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatAttributeByMetadataKey_FunctionAddress, "Value");
		SetFloatAttributeByMetadataKey_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatAttributeByMetadataKey_FunctionAddress, "Value", Classes.FFloatProperty);
		SetFloatAttributeByMetadataKey_IsValid = SetFloatAttributeByMetadataKey_FunctionAddress != IntPtr.Zero && SetFloatAttributeByMetadataKey_Key_IsValid && SetFloatAttributeByMetadataKey_Metadata_IsValid && SetFloatAttributeByMetadataKey_AttributeName_IsValid && SetFloatAttributeByMetadataKey_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetFloatAttributeByMetadataKey", SetFloatAttributeByMetadataKey_IsValid);
		SetFloatAttribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetFloatAttribute");
		SetFloatAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFloatAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFloatAttribute_Point_PropertyAddress, SetFloatAttribute_FunctionAddress, "Point");
		SetFloatAttribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatAttribute_FunctionAddress, "Point");
		SetFloatAttribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatAttribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFloatAttribute_Metadata_PropertyAddress, SetFloatAttribute_FunctionAddress, "Metadata");
		SetFloatAttribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatAttribute_FunctionAddress, "Metadata");
		SetFloatAttribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatAttribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFloatAttribute_AttributeName_PropertyAddress, SetFloatAttribute_FunctionAddress, "AttributeName");
		SetFloatAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatAttribute_FunctionAddress, "AttributeName");
		SetFloatAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFloatAttribute_Value_PropertyAddress, SetFloatAttribute_FunctionAddress, "Value");
		SetFloatAttribute_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatAttribute_FunctionAddress, "Value");
		SetFloatAttribute_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatAttribute_FunctionAddress, "Value", Classes.FFloatProperty);
		SetFloatAttribute_IsValid = SetFloatAttribute_FunctionAddress != IntPtr.Zero && SetFloatAttribute_Point_IsValid && SetFloatAttribute_Metadata_IsValid && SetFloatAttribute_AttributeName_IsValid && SetFloatAttribute_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetFloatAttribute", SetFloatAttribute_IsValid);
		SetDoubleAttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetDoubleAttributeByMetadataKey");
		SetDoubleAttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDoubleAttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDoubleAttributeByMetadataKey_Key_PropertyAddress, SetDoubleAttributeByMetadataKey_FunctionAddress, "Key");
		SetDoubleAttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetDoubleAttributeByMetadataKey_FunctionAddress, "Key");
		SetDoubleAttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDoubleAttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref SetDoubleAttributeByMetadataKey_Metadata_PropertyAddress, SetDoubleAttributeByMetadataKey_FunctionAddress, "Metadata");
		SetDoubleAttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetDoubleAttributeByMetadataKey_FunctionAddress, "Metadata");
		SetDoubleAttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDoubleAttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDoubleAttributeByMetadataKey_AttributeName_PropertyAddress, SetDoubleAttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetDoubleAttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetDoubleAttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetDoubleAttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDoubleAttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDoubleAttributeByMetadataKey_Value_PropertyAddress, SetDoubleAttributeByMetadataKey_FunctionAddress, "Value");
		SetDoubleAttributeByMetadataKey_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetDoubleAttributeByMetadataKey_FunctionAddress, "Value");
		SetDoubleAttributeByMetadataKey_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDoubleAttributeByMetadataKey_FunctionAddress, "Value", Classes.FDoubleProperty);
		SetDoubleAttributeByMetadataKey_IsValid = SetDoubleAttributeByMetadataKey_FunctionAddress != IntPtr.Zero && SetDoubleAttributeByMetadataKey_Key_IsValid && SetDoubleAttributeByMetadataKey_Metadata_IsValid && SetDoubleAttributeByMetadataKey_AttributeName_IsValid && SetDoubleAttributeByMetadataKey_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetDoubleAttributeByMetadataKey", SetDoubleAttributeByMetadataKey_IsValid);
		SetDoubleAttribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetDoubleAttribute");
		SetDoubleAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDoubleAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDoubleAttribute_Point_PropertyAddress, SetDoubleAttribute_FunctionAddress, "Point");
		SetDoubleAttribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(SetDoubleAttribute_FunctionAddress, "Point");
		SetDoubleAttribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDoubleAttribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDoubleAttribute_Metadata_PropertyAddress, SetDoubleAttribute_FunctionAddress, "Metadata");
		SetDoubleAttribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetDoubleAttribute_FunctionAddress, "Metadata");
		SetDoubleAttribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDoubleAttribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDoubleAttribute_AttributeName_PropertyAddress, SetDoubleAttribute_FunctionAddress, "AttributeName");
		SetDoubleAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetDoubleAttribute_FunctionAddress, "AttributeName");
		SetDoubleAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDoubleAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDoubleAttribute_Value_PropertyAddress, SetDoubleAttribute_FunctionAddress, "Value");
		SetDoubleAttribute_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetDoubleAttribute_FunctionAddress, "Value");
		SetDoubleAttribute_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDoubleAttribute_FunctionAddress, "Value", Classes.FDoubleProperty);
		SetDoubleAttribute_IsValid = SetDoubleAttribute_FunctionAddress != IntPtr.Zero && SetDoubleAttribute_Point_IsValid && SetDoubleAttribute_Metadata_IsValid && SetDoubleAttribute_AttributeName_IsValid && SetDoubleAttribute_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetDoubleAttribute", SetDoubleAttribute_IsValid);
		SetBoolAttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBoolAttributeByMetadataKey");
		SetBoolAttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoolAttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBoolAttributeByMetadataKey_Key_PropertyAddress, SetBoolAttributeByMetadataKey_FunctionAddress, "Key");
		SetBoolAttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolAttributeByMetadataKey_FunctionAddress, "Key");
		SetBoolAttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolAttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref SetBoolAttributeByMetadataKey_Metadata_PropertyAddress, SetBoolAttributeByMetadataKey_FunctionAddress, "Metadata");
		SetBoolAttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolAttributeByMetadataKey_FunctionAddress, "Metadata");
		SetBoolAttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolAttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoolAttributeByMetadataKey_AttributeName_PropertyAddress, SetBoolAttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetBoolAttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolAttributeByMetadataKey_FunctionAddress, "AttributeName");
		SetBoolAttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolAttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoolAttributeByMetadataKey_Value_PropertyAddress, SetBoolAttributeByMetadataKey_FunctionAddress, "Value");
		SetBoolAttributeByMetadataKey_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolAttributeByMetadataKey_FunctionAddress, "Value");
		SetBoolAttributeByMetadataKey_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolAttributeByMetadataKey_FunctionAddress, "Value", Classes.FBoolProperty);
		SetBoolAttributeByMetadataKey_IsValid = SetBoolAttributeByMetadataKey_FunctionAddress != IntPtr.Zero && SetBoolAttributeByMetadataKey_Key_IsValid && SetBoolAttributeByMetadataKey_Metadata_IsValid && SetBoolAttributeByMetadataKey_AttributeName_IsValid && SetBoolAttributeByMetadataKey_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetBoolAttributeByMetadataKey", SetBoolAttributeByMetadataKey_IsValid);
		SetBoolAttribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBoolAttribute");
		SetBoolAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoolAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBoolAttribute_Point_PropertyAddress, SetBoolAttribute_FunctionAddress, "Point");
		SetBoolAttribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolAttribute_FunctionAddress, "Point");
		SetBoolAttribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolAttribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoolAttribute_Metadata_PropertyAddress, SetBoolAttribute_FunctionAddress, "Metadata");
		SetBoolAttribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolAttribute_FunctionAddress, "Metadata");
		SetBoolAttribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolAttribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoolAttribute_AttributeName_PropertyAddress, SetBoolAttribute_FunctionAddress, "AttributeName");
		SetBoolAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolAttribute_FunctionAddress, "AttributeName");
		SetBoolAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoolAttribute_Value_PropertyAddress, SetBoolAttribute_FunctionAddress, "Value");
		SetBoolAttribute_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolAttribute_FunctionAddress, "Value");
		SetBoolAttribute_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolAttribute_FunctionAddress, "Value", Classes.FBoolProperty);
		SetBoolAttribute_IsValid = SetBoolAttribute_FunctionAddress != IntPtr.Zero && SetBoolAttribute_Point_IsValid && SetBoolAttribute_Metadata_IsValid && SetBoolAttribute_AttributeName_IsValid && SetBoolAttribute_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetBoolAttribute", SetBoolAttribute_IsValid);
		SetAttributeFromPropertyByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAttributeFromPropertyByMetadataKey");
		SetAttributeFromPropertyByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAttributeFromPropertyByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAttributeFromPropertyByMetadataKey_Key_PropertyAddress, SetAttributeFromPropertyByMetadataKey_FunctionAddress, "Key");
		SetAttributeFromPropertyByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetAttributeFromPropertyByMetadataKey_FunctionAddress, "Key");
		SetAttributeFromPropertyByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAttributeFromPropertyByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref SetAttributeFromPropertyByMetadataKey_Metadata_PropertyAddress, SetAttributeFromPropertyByMetadataKey_FunctionAddress, "Metadata");
		SetAttributeFromPropertyByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(SetAttributeFromPropertyByMetadataKey_FunctionAddress, "Metadata");
		SetAttributeFromPropertyByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAttributeFromPropertyByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAttributeFromPropertyByMetadataKey_AttributeName_PropertyAddress, SetAttributeFromPropertyByMetadataKey_FunctionAddress, "AttributeName");
		SetAttributeFromPropertyByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetAttributeFromPropertyByMetadataKey_FunctionAddress, "AttributeName");
		SetAttributeFromPropertyByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAttributeFromPropertyByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAttributeFromPropertyByMetadataKey_Object_PropertyAddress, SetAttributeFromPropertyByMetadataKey_FunctionAddress, "Object");
		SetAttributeFromPropertyByMetadataKey_Object_Offset = NativeReflectionCached.GetPropertyOffset(SetAttributeFromPropertyByMetadataKey_FunctionAddress, "Object");
		SetAttributeFromPropertyByMetadataKey_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAttributeFromPropertyByMetadataKey_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAttributeFromPropertyByMetadataKey_PropertyName_PropertyAddress, SetAttributeFromPropertyByMetadataKey_FunctionAddress, "PropertyName");
		SetAttributeFromPropertyByMetadataKey_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(SetAttributeFromPropertyByMetadataKey_FunctionAddress, "PropertyName");
		SetAttributeFromPropertyByMetadataKey_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAttributeFromPropertyByMetadataKey_FunctionAddress, "PropertyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAttributeFromPropertyByMetadataKey_ReturnValue_PropertyAddress, SetAttributeFromPropertyByMetadataKey_FunctionAddress, "ReturnValue");
		SetAttributeFromPropertyByMetadataKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAttributeFromPropertyByMetadataKey_FunctionAddress, "ReturnValue");
		SetAttributeFromPropertyByMetadataKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAttributeFromPropertyByMetadataKey_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetAttributeFromPropertyByMetadataKey_IsValid = SetAttributeFromPropertyByMetadataKey_FunctionAddress != IntPtr.Zero && SetAttributeFromPropertyByMetadataKey_Key_IsValid && SetAttributeFromPropertyByMetadataKey_Metadata_IsValid && SetAttributeFromPropertyByMetadataKey_AttributeName_IsValid && SetAttributeFromPropertyByMetadataKey_Object_IsValid && SetAttributeFromPropertyByMetadataKey_PropertyName_IsValid && SetAttributeFromPropertyByMetadataKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:SetAttributeFromPropertyByMetadataKey", SetAttributeFromPropertyByMetadataKey_IsValid);
		InitializeMetadata_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InitializeMetadata");
		InitializeMetadata_ParamsSize = NativeReflection.GetFunctionParamsSize(InitializeMetadata_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitializeMetadata_Point_PropertyAddress, InitializeMetadata_FunctionAddress, "Point");
		InitializeMetadata_Point_Offset = NativeReflectionCached.GetPropertyOffset(InitializeMetadata_FunctionAddress, "Point");
		InitializeMetadata_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeMetadata_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializeMetadata_Metadata_PropertyAddress, InitializeMetadata_FunctionAddress, "Metadata");
		InitializeMetadata_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(InitializeMetadata_FunctionAddress, "Metadata");
		InitializeMetadata_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeMetadata_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializeMetadata_ParentPoint_PropertyAddress, InitializeMetadata_FunctionAddress, "ParentPoint");
		InitializeMetadata_ParentPoint_Offset = NativeReflectionCached.GetPropertyOffset(InitializeMetadata_FunctionAddress, "ParentPoint");
		InitializeMetadata_ParentPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeMetadata_FunctionAddress, "ParentPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializeMetadata_ParentMetadata_PropertyAddress, InitializeMetadata_FunctionAddress, "ParentMetadata");
		InitializeMetadata_ParentMetadata_Offset = NativeReflectionCached.GetPropertyOffset(InitializeMetadata_FunctionAddress, "ParentMetadata");
		InitializeMetadata_ParentMetadata_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeMetadata_FunctionAddress, "ParentMetadata", Classes.FObjectProperty);
		InitializeMetadata_IsValid = InitializeMetadata_FunctionAddress != IntPtr.Zero && InitializeMetadata_Point_IsValid && InitializeMetadata_Metadata_IsValid && InitializeMetadata_ParentPoint_IsValid && InitializeMetadata_ParentMetadata_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:InitializeMetadata", InitializeMetadata_IsValid);
		HasAttributeSetByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HasAttributeSetByMetadataKey");
		HasAttributeSetByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(HasAttributeSetByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasAttributeSetByMetadataKey_Key_PropertyAddress, HasAttributeSetByMetadataKey_FunctionAddress, "Key");
		HasAttributeSetByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(HasAttributeSetByMetadataKey_FunctionAddress, "Key");
		HasAttributeSetByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAttributeSetByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref HasAttributeSetByMetadataKey_Metadata_PropertyAddress, HasAttributeSetByMetadataKey_FunctionAddress, "Metadata");
		HasAttributeSetByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(HasAttributeSetByMetadataKey_FunctionAddress, "Metadata");
		HasAttributeSetByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAttributeSetByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref HasAttributeSetByMetadataKey_AttributeName_PropertyAddress, HasAttributeSetByMetadataKey_FunctionAddress, "AttributeName");
		HasAttributeSetByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(HasAttributeSetByMetadataKey_FunctionAddress, "AttributeName");
		HasAttributeSetByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAttributeSetByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref HasAttributeSetByMetadataKey_ReturnValue_PropertyAddress, HasAttributeSetByMetadataKey_FunctionAddress, "ReturnValue");
		HasAttributeSetByMetadataKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasAttributeSetByMetadataKey_FunctionAddress, "ReturnValue");
		HasAttributeSetByMetadataKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAttributeSetByMetadataKey_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasAttributeSetByMetadataKey_IsValid = HasAttributeSetByMetadataKey_FunctionAddress != IntPtr.Zero && HasAttributeSetByMetadataKey_Key_IsValid && HasAttributeSetByMetadataKey_Metadata_IsValid && HasAttributeSetByMetadataKey_AttributeName_IsValid && HasAttributeSetByMetadataKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:HasAttributeSetByMetadataKey", HasAttributeSetByMetadataKey_IsValid);
		HasAttributeSet_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HasAttributeSet");
		HasAttributeSet_ParamsSize = NativeReflection.GetFunctionParamsSize(HasAttributeSet_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasAttributeSet_Point_PropertyAddress, HasAttributeSet_FunctionAddress, "Point");
		HasAttributeSet_Point_Offset = NativeReflectionCached.GetPropertyOffset(HasAttributeSet_FunctionAddress, "Point");
		HasAttributeSet_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAttributeSet_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HasAttributeSet_Metadata_PropertyAddress, HasAttributeSet_FunctionAddress, "Metadata");
		HasAttributeSet_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(HasAttributeSet_FunctionAddress, "Metadata");
		HasAttributeSet_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAttributeSet_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref HasAttributeSet_AttributeName_PropertyAddress, HasAttributeSet_FunctionAddress, "AttributeName");
		HasAttributeSet_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(HasAttributeSet_FunctionAddress, "AttributeName");
		HasAttributeSet_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAttributeSet_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref HasAttributeSet_ReturnValue_PropertyAddress, HasAttributeSet_FunctionAddress, "ReturnValue");
		HasAttributeSet_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasAttributeSet_FunctionAddress, "ReturnValue");
		HasAttributeSet_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAttributeSet_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasAttributeSet_IsValid = HasAttributeSet_FunctionAddress != IntPtr.Zero && HasAttributeSet_Point_IsValid && HasAttributeSet_Metadata_IsValid && HasAttributeSet_AttributeName_IsValid && HasAttributeSet_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:HasAttributeSet", HasAttributeSet_IsValid);
		GetVectorAttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVectorAttributeByMetadataKey");
		GetVectorAttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVectorAttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVectorAttributeByMetadataKey_Key_PropertyAddress, GetVectorAttributeByMetadataKey_FunctionAddress, "Key");
		GetVectorAttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorAttributeByMetadataKey_FunctionAddress, "Key");
		GetVectorAttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorAttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref GetVectorAttributeByMetadataKey_Metadata_PropertyAddress, GetVectorAttributeByMetadataKey_FunctionAddress, "Metadata");
		GetVectorAttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorAttributeByMetadataKey_FunctionAddress, "Metadata");
		GetVectorAttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorAttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorAttributeByMetadataKey_AttributeName_PropertyAddress, GetVectorAttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetVectorAttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorAttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetVectorAttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorAttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorAttributeByMetadataKey_ReturnValue_PropertyAddress, GetVectorAttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetVectorAttributeByMetadataKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorAttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetVectorAttributeByMetadataKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorAttributeByMetadataKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVectorAttributeByMetadataKey_IsValid = GetVectorAttributeByMetadataKey_FunctionAddress != IntPtr.Zero && GetVectorAttributeByMetadataKey_Key_IsValid && GetVectorAttributeByMetadataKey_Metadata_IsValid && GetVectorAttributeByMetadataKey_AttributeName_IsValid && GetVectorAttributeByMetadataKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetVectorAttributeByMetadataKey", GetVectorAttributeByMetadataKey_IsValid);
		GetVectorAttribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVectorAttribute");
		GetVectorAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVectorAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVectorAttribute_Point_PropertyAddress, GetVectorAttribute_FunctionAddress, "Point");
		GetVectorAttribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorAttribute_FunctionAddress, "Point");
		GetVectorAttribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorAttribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorAttribute_Metadata_PropertyAddress, GetVectorAttribute_FunctionAddress, "Metadata");
		GetVectorAttribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorAttribute_FunctionAddress, "Metadata");
		GetVectorAttribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorAttribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorAttribute_AttributeName_PropertyAddress, GetVectorAttribute_FunctionAddress, "AttributeName");
		GetVectorAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorAttribute_FunctionAddress, "AttributeName");
		GetVectorAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorAttribute_ReturnValue_PropertyAddress, GetVectorAttribute_FunctionAddress, "ReturnValue");
		GetVectorAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorAttribute_FunctionAddress, "ReturnValue");
		GetVectorAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorAttribute_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVectorAttribute_IsValid = GetVectorAttribute_FunctionAddress != IntPtr.Zero && GetVectorAttribute_Point_IsValid && GetVectorAttribute_Metadata_IsValid && GetVectorAttribute_AttributeName_IsValid && GetVectorAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetVectorAttribute", GetVectorAttribute_IsValid);
		GetVector4AttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVector4AttributeByMetadataKey");
		GetVector4AttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVector4AttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVector4AttributeByMetadataKey_Key_PropertyAddress, GetVector4AttributeByMetadataKey_FunctionAddress, "Key");
		GetVector4AttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetVector4AttributeByMetadataKey_FunctionAddress, "Key");
		GetVector4AttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector4AttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref GetVector4AttributeByMetadataKey_Metadata_PropertyAddress, GetVector4AttributeByMetadataKey_FunctionAddress, "Metadata");
		GetVector4AttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetVector4AttributeByMetadataKey_FunctionAddress, "Metadata");
		GetVector4AttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector4AttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector4AttributeByMetadataKey_AttributeName_PropertyAddress, GetVector4AttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetVector4AttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetVector4AttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetVector4AttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector4AttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector4AttributeByMetadataKey_ReturnValue_PropertyAddress, GetVector4AttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetVector4AttributeByMetadataKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVector4AttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetVector4AttributeByMetadataKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector4AttributeByMetadataKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVector4AttributeByMetadataKey_IsValid = GetVector4AttributeByMetadataKey_FunctionAddress != IntPtr.Zero && GetVector4AttributeByMetadataKey_Key_IsValid && GetVector4AttributeByMetadataKey_Metadata_IsValid && GetVector4AttributeByMetadataKey_AttributeName_IsValid && GetVector4AttributeByMetadataKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetVector4AttributeByMetadataKey", GetVector4AttributeByMetadataKey_IsValid);
		GetVector4Attribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVector4Attribute");
		GetVector4Attribute_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVector4Attribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVector4Attribute_Point_PropertyAddress, GetVector4Attribute_FunctionAddress, "Point");
		GetVector4Attribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(GetVector4Attribute_FunctionAddress, "Point");
		GetVector4Attribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector4Attribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector4Attribute_Metadata_PropertyAddress, GetVector4Attribute_FunctionAddress, "Metadata");
		GetVector4Attribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetVector4Attribute_FunctionAddress, "Metadata");
		GetVector4Attribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector4Attribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector4Attribute_AttributeName_PropertyAddress, GetVector4Attribute_FunctionAddress, "AttributeName");
		GetVector4Attribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetVector4Attribute_FunctionAddress, "AttributeName");
		GetVector4Attribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector4Attribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector4Attribute_ReturnValue_PropertyAddress, GetVector4Attribute_FunctionAddress, "ReturnValue");
		GetVector4Attribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVector4Attribute_FunctionAddress, "ReturnValue");
		GetVector4Attribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector4Attribute_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVector4Attribute_IsValid = GetVector4Attribute_FunctionAddress != IntPtr.Zero && GetVector4Attribute_Point_IsValid && GetVector4Attribute_Metadata_IsValid && GetVector4Attribute_AttributeName_IsValid && GetVector4Attribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetVector4Attribute", GetVector4Attribute_IsValid);
		GetVector2AttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVector2AttributeByMetadataKey");
		GetVector2AttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVector2AttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVector2AttributeByMetadataKey_Key_PropertyAddress, GetVector2AttributeByMetadataKey_FunctionAddress, "Key");
		GetVector2AttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetVector2AttributeByMetadataKey_FunctionAddress, "Key");
		GetVector2AttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector2AttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref GetVector2AttributeByMetadataKey_Metadata_PropertyAddress, GetVector2AttributeByMetadataKey_FunctionAddress, "Metadata");
		GetVector2AttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetVector2AttributeByMetadataKey_FunctionAddress, "Metadata");
		GetVector2AttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector2AttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector2AttributeByMetadataKey_AttributeName_PropertyAddress, GetVector2AttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetVector2AttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetVector2AttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetVector2AttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector2AttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector2AttributeByMetadataKey_ReturnValue_PropertyAddress, GetVector2AttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetVector2AttributeByMetadataKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVector2AttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetVector2AttributeByMetadataKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector2AttributeByMetadataKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVector2AttributeByMetadataKey_IsValid = GetVector2AttributeByMetadataKey_FunctionAddress != IntPtr.Zero && GetVector2AttributeByMetadataKey_Key_IsValid && GetVector2AttributeByMetadataKey_Metadata_IsValid && GetVector2AttributeByMetadataKey_AttributeName_IsValid && GetVector2AttributeByMetadataKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetVector2AttributeByMetadataKey", GetVector2AttributeByMetadataKey_IsValid);
		GetVector2Attribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVector2Attribute");
		GetVector2Attribute_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVector2Attribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVector2Attribute_Point_PropertyAddress, GetVector2Attribute_FunctionAddress, "Point");
		GetVector2Attribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(GetVector2Attribute_FunctionAddress, "Point");
		GetVector2Attribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector2Attribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector2Attribute_Metadata_PropertyAddress, GetVector2Attribute_FunctionAddress, "Metadata");
		GetVector2Attribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetVector2Attribute_FunctionAddress, "Metadata");
		GetVector2Attribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector2Attribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector2Attribute_AttributeName_PropertyAddress, GetVector2Attribute_FunctionAddress, "AttributeName");
		GetVector2Attribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetVector2Attribute_FunctionAddress, "AttributeName");
		GetVector2Attribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector2Attribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector2Attribute_ReturnValue_PropertyAddress, GetVector2Attribute_FunctionAddress, "ReturnValue");
		GetVector2Attribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVector2Attribute_FunctionAddress, "ReturnValue");
		GetVector2Attribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector2Attribute_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVector2Attribute_IsValid = GetVector2Attribute_FunctionAddress != IntPtr.Zero && GetVector2Attribute_Point_IsValid && GetVector2Attribute_Metadata_IsValid && GetVector2Attribute_AttributeName_IsValid && GetVector2Attribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetVector2Attribute", GetVector2Attribute_IsValid);
		GetTransformAttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTransformAttributeByMetadataKey");
		GetTransformAttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTransformAttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAttributeByMetadataKey_Key_PropertyAddress, GetTransformAttributeByMetadataKey_FunctionAddress, "Key");
		GetTransformAttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAttributeByMetadataKey_FunctionAddress, "Key");
		GetTransformAttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAttributeByMetadataKey_Metadata_PropertyAddress, GetTransformAttributeByMetadataKey_FunctionAddress, "Metadata");
		GetTransformAttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAttributeByMetadataKey_FunctionAddress, "Metadata");
		GetTransformAttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAttributeByMetadataKey_AttributeName_PropertyAddress, GetTransformAttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetTransformAttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetTransformAttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAttributeByMetadataKey_ReturnValue_PropertyAddress, GetTransformAttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetTransformAttributeByMetadataKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetTransformAttributeByMetadataKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAttributeByMetadataKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTransformAttributeByMetadataKey_IsValid = GetTransformAttributeByMetadataKey_FunctionAddress != IntPtr.Zero && GetTransformAttributeByMetadataKey_Key_IsValid && GetTransformAttributeByMetadataKey_Metadata_IsValid && GetTransformAttributeByMetadataKey_AttributeName_IsValid && GetTransformAttributeByMetadataKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetTransformAttributeByMetadataKey", GetTransformAttributeByMetadataKey_IsValid);
		GetTransformAttribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTransformAttribute");
		GetTransformAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTransformAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAttribute_Point_PropertyAddress, GetTransformAttribute_FunctionAddress, "Point");
		GetTransformAttribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAttribute_FunctionAddress, "Point");
		GetTransformAttribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAttribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAttribute_Metadata_PropertyAddress, GetTransformAttribute_FunctionAddress, "Metadata");
		GetTransformAttribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAttribute_FunctionAddress, "Metadata");
		GetTransformAttribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAttribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAttribute_AttributeName_PropertyAddress, GetTransformAttribute_FunctionAddress, "AttributeName");
		GetTransformAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAttribute_FunctionAddress, "AttributeName");
		GetTransformAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAttribute_ReturnValue_PropertyAddress, GetTransformAttribute_FunctionAddress, "ReturnValue");
		GetTransformAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAttribute_FunctionAddress, "ReturnValue");
		GetTransformAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAttribute_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTransformAttribute_IsValid = GetTransformAttribute_FunctionAddress != IntPtr.Zero && GetTransformAttribute_Point_IsValid && GetTransformAttribute_Metadata_IsValid && GetTransformAttribute_AttributeName_IsValid && GetTransformAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetTransformAttribute", GetTransformAttribute_IsValid);
		GetStringAttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStringAttributeByMetadataKey");
		GetStringAttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStringAttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStringAttributeByMetadataKey_Key_PropertyAddress, GetStringAttributeByMetadataKey_FunctionAddress, "Key");
		GetStringAttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetStringAttributeByMetadataKey_FunctionAddress, "Key");
		GetStringAttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStringAttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref GetStringAttributeByMetadataKey_Metadata_PropertyAddress, GetStringAttributeByMetadataKey_FunctionAddress, "Metadata");
		GetStringAttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetStringAttributeByMetadataKey_FunctionAddress, "Metadata");
		GetStringAttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStringAttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStringAttributeByMetadataKey_AttributeName_PropertyAddress, GetStringAttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetStringAttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetStringAttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetStringAttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStringAttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStringAttributeByMetadataKey_ReturnValue_PropertyAddress, GetStringAttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetStringAttributeByMetadataKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStringAttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetStringAttributeByMetadataKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStringAttributeByMetadataKey_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetStringAttributeByMetadataKey_IsValid = GetStringAttributeByMetadataKey_FunctionAddress != IntPtr.Zero && GetStringAttributeByMetadataKey_Key_IsValid && GetStringAttributeByMetadataKey_Metadata_IsValid && GetStringAttributeByMetadataKey_AttributeName_IsValid && GetStringAttributeByMetadataKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetStringAttributeByMetadataKey", GetStringAttributeByMetadataKey_IsValid);
		GetStringAttribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStringAttribute");
		GetStringAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStringAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStringAttribute_Point_PropertyAddress, GetStringAttribute_FunctionAddress, "Point");
		GetStringAttribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(GetStringAttribute_FunctionAddress, "Point");
		GetStringAttribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStringAttribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStringAttribute_Metadata_PropertyAddress, GetStringAttribute_FunctionAddress, "Metadata");
		GetStringAttribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetStringAttribute_FunctionAddress, "Metadata");
		GetStringAttribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStringAttribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStringAttribute_AttributeName_PropertyAddress, GetStringAttribute_FunctionAddress, "AttributeName");
		GetStringAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetStringAttribute_FunctionAddress, "AttributeName");
		GetStringAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStringAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStringAttribute_ReturnValue_PropertyAddress, GetStringAttribute_FunctionAddress, "ReturnValue");
		GetStringAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStringAttribute_FunctionAddress, "ReturnValue");
		GetStringAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStringAttribute_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetStringAttribute_IsValid = GetStringAttribute_FunctionAddress != IntPtr.Zero && GetStringAttribute_Point_IsValid && GetStringAttribute_Metadata_IsValid && GetStringAttribute_AttributeName_IsValid && GetStringAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetStringAttribute", GetStringAttribute_IsValid);
		GetRotatorAttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRotatorAttributeByMetadataKey");
		GetRotatorAttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRotatorAttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRotatorAttributeByMetadataKey_Key_PropertyAddress, GetRotatorAttributeByMetadataKey_FunctionAddress, "Key");
		GetRotatorAttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetRotatorAttributeByMetadataKey_FunctionAddress, "Key");
		GetRotatorAttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotatorAttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref GetRotatorAttributeByMetadataKey_Metadata_PropertyAddress, GetRotatorAttributeByMetadataKey_FunctionAddress, "Metadata");
		GetRotatorAttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetRotatorAttributeByMetadataKey_FunctionAddress, "Metadata");
		GetRotatorAttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotatorAttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotatorAttributeByMetadataKey_AttributeName_PropertyAddress, GetRotatorAttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetRotatorAttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetRotatorAttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetRotatorAttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotatorAttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotatorAttributeByMetadataKey_ReturnValue_PropertyAddress, GetRotatorAttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetRotatorAttributeByMetadataKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRotatorAttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetRotatorAttributeByMetadataKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotatorAttributeByMetadataKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRotatorAttributeByMetadataKey_IsValid = GetRotatorAttributeByMetadataKey_FunctionAddress != IntPtr.Zero && GetRotatorAttributeByMetadataKey_Key_IsValid && GetRotatorAttributeByMetadataKey_Metadata_IsValid && GetRotatorAttributeByMetadataKey_AttributeName_IsValid && GetRotatorAttributeByMetadataKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetRotatorAttributeByMetadataKey", GetRotatorAttributeByMetadataKey_IsValid);
		GetRotatorAttribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRotatorAttribute");
		GetRotatorAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRotatorAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRotatorAttribute_Point_PropertyAddress, GetRotatorAttribute_FunctionAddress, "Point");
		GetRotatorAttribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(GetRotatorAttribute_FunctionAddress, "Point");
		GetRotatorAttribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotatorAttribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotatorAttribute_Metadata_PropertyAddress, GetRotatorAttribute_FunctionAddress, "Metadata");
		GetRotatorAttribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetRotatorAttribute_FunctionAddress, "Metadata");
		GetRotatorAttribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotatorAttribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotatorAttribute_AttributeName_PropertyAddress, GetRotatorAttribute_FunctionAddress, "AttributeName");
		GetRotatorAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetRotatorAttribute_FunctionAddress, "AttributeName");
		GetRotatorAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotatorAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotatorAttribute_ReturnValue_PropertyAddress, GetRotatorAttribute_FunctionAddress, "ReturnValue");
		GetRotatorAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRotatorAttribute_FunctionAddress, "ReturnValue");
		GetRotatorAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotatorAttribute_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRotatorAttribute_IsValid = GetRotatorAttribute_FunctionAddress != IntPtr.Zero && GetRotatorAttribute_Point_IsValid && GetRotatorAttribute_Metadata_IsValid && GetRotatorAttribute_AttributeName_IsValid && GetRotatorAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetRotatorAttribute", GetRotatorAttribute_IsValid);
		GetQuatAttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetQuatAttributeByMetadataKey");
		GetQuatAttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetQuatAttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetQuatAttributeByMetadataKey_Key_PropertyAddress, GetQuatAttributeByMetadataKey_FunctionAddress, "Key");
		GetQuatAttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetQuatAttributeByMetadataKey_FunctionAddress, "Key");
		GetQuatAttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQuatAttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref GetQuatAttributeByMetadataKey_Metadata_PropertyAddress, GetQuatAttributeByMetadataKey_FunctionAddress, "Metadata");
		GetQuatAttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetQuatAttributeByMetadataKey_FunctionAddress, "Metadata");
		GetQuatAttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQuatAttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetQuatAttributeByMetadataKey_AttributeName_PropertyAddress, GetQuatAttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetQuatAttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetQuatAttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetQuatAttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQuatAttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetQuatAttributeByMetadataKey_ReturnValue_PropertyAddress, GetQuatAttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetQuatAttributeByMetadataKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetQuatAttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetQuatAttributeByMetadataKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQuatAttributeByMetadataKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetQuatAttributeByMetadataKey_IsValid = GetQuatAttributeByMetadataKey_FunctionAddress != IntPtr.Zero && GetQuatAttributeByMetadataKey_Key_IsValid && GetQuatAttributeByMetadataKey_Metadata_IsValid && GetQuatAttributeByMetadataKey_AttributeName_IsValid && GetQuatAttributeByMetadataKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetQuatAttributeByMetadataKey", GetQuatAttributeByMetadataKey_IsValid);
		GetQuatAttribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetQuatAttribute");
		GetQuatAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(GetQuatAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetQuatAttribute_Point_PropertyAddress, GetQuatAttribute_FunctionAddress, "Point");
		GetQuatAttribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(GetQuatAttribute_FunctionAddress, "Point");
		GetQuatAttribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQuatAttribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetQuatAttribute_Metadata_PropertyAddress, GetQuatAttribute_FunctionAddress, "Metadata");
		GetQuatAttribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetQuatAttribute_FunctionAddress, "Metadata");
		GetQuatAttribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQuatAttribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetQuatAttribute_AttributeName_PropertyAddress, GetQuatAttribute_FunctionAddress, "AttributeName");
		GetQuatAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetQuatAttribute_FunctionAddress, "AttributeName");
		GetQuatAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQuatAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetQuatAttribute_ReturnValue_PropertyAddress, GetQuatAttribute_FunctionAddress, "ReturnValue");
		GetQuatAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetQuatAttribute_FunctionAddress, "ReturnValue");
		GetQuatAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQuatAttribute_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetQuatAttribute_IsValid = GetQuatAttribute_FunctionAddress != IntPtr.Zero && GetQuatAttribute_Point_IsValid && GetQuatAttribute_Metadata_IsValid && GetQuatAttribute_AttributeName_IsValid && GetQuatAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetQuatAttribute", GetQuatAttribute_IsValid);
		GetNameAttribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNameAttribute");
		GetNameAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNameAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNameAttribute_Point_PropertyAddress, GetNameAttribute_FunctionAddress, "Point");
		GetNameAttribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(GetNameAttribute_FunctionAddress, "Point");
		GetNameAttribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNameAttribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNameAttribute_Metadata_PropertyAddress, GetNameAttribute_FunctionAddress, "Metadata");
		GetNameAttribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetNameAttribute_FunctionAddress, "Metadata");
		GetNameAttribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNameAttribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNameAttribute_AttributeName_PropertyAddress, GetNameAttribute_FunctionAddress, "AttributeName");
		GetNameAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetNameAttribute_FunctionAddress, "AttributeName");
		GetNameAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNameAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNameAttribute_ReturnValue_PropertyAddress, GetNameAttribute_FunctionAddress, "ReturnValue");
		GetNameAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNameAttribute_FunctionAddress, "ReturnValue");
		GetNameAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNameAttribute_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetNameAttribute_IsValid = GetNameAttribute_FunctionAddress != IntPtr.Zero && GetNameAttribute_Point_IsValid && GetNameAttribute_Metadata_IsValid && GetNameAttribute_AttributeName_IsValid && GetNameAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetNameAttribute", GetNameAttribute_IsValid);
		GetInteger64AttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInteger64AttributeByMetadataKey");
		GetInteger64AttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInteger64AttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInteger64AttributeByMetadataKey_Key_PropertyAddress, GetInteger64AttributeByMetadataKey_FunctionAddress, "Key");
		GetInteger64AttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetInteger64AttributeByMetadataKey_FunctionAddress, "Key");
		GetInteger64AttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInteger64AttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref GetInteger64AttributeByMetadataKey_Metadata_PropertyAddress, GetInteger64AttributeByMetadataKey_FunctionAddress, "Metadata");
		GetInteger64AttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetInteger64AttributeByMetadataKey_FunctionAddress, "Metadata");
		GetInteger64AttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInteger64AttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInteger64AttributeByMetadataKey_AttributeName_PropertyAddress, GetInteger64AttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetInteger64AttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetInteger64AttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetInteger64AttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInteger64AttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInteger64AttributeByMetadataKey_ReturnValue_PropertyAddress, GetInteger64AttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetInteger64AttributeByMetadataKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInteger64AttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetInteger64AttributeByMetadataKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInteger64AttributeByMetadataKey_FunctionAddress, "ReturnValue", Classes.FInt64Property);
		GetInteger64AttributeByMetadataKey_IsValid = GetInteger64AttributeByMetadataKey_FunctionAddress != IntPtr.Zero && GetInteger64AttributeByMetadataKey_Key_IsValid && GetInteger64AttributeByMetadataKey_Metadata_IsValid && GetInteger64AttributeByMetadataKey_AttributeName_IsValid && GetInteger64AttributeByMetadataKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetInteger64AttributeByMetadataKey", GetInteger64AttributeByMetadataKey_IsValid);
		GetInteger64Attribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInteger64Attribute");
		GetInteger64Attribute_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInteger64Attribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInteger64Attribute_Point_PropertyAddress, GetInteger64Attribute_FunctionAddress, "Point");
		GetInteger64Attribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(GetInteger64Attribute_FunctionAddress, "Point");
		GetInteger64Attribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInteger64Attribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInteger64Attribute_Metadata_PropertyAddress, GetInteger64Attribute_FunctionAddress, "Metadata");
		GetInteger64Attribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetInteger64Attribute_FunctionAddress, "Metadata");
		GetInteger64Attribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInteger64Attribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInteger64Attribute_AttributeName_PropertyAddress, GetInteger64Attribute_FunctionAddress, "AttributeName");
		GetInteger64Attribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetInteger64Attribute_FunctionAddress, "AttributeName");
		GetInteger64Attribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInteger64Attribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInteger64Attribute_ReturnValue_PropertyAddress, GetInteger64Attribute_FunctionAddress, "ReturnValue");
		GetInteger64Attribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInteger64Attribute_FunctionAddress, "ReturnValue");
		GetInteger64Attribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInteger64Attribute_FunctionAddress, "ReturnValue", Classes.FInt64Property);
		GetInteger64Attribute_IsValid = GetInteger64Attribute_FunctionAddress != IntPtr.Zero && GetInteger64Attribute_Point_IsValid && GetInteger64Attribute_Metadata_IsValid && GetInteger64Attribute_AttributeName_IsValid && GetInteger64Attribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetInteger64Attribute", GetInteger64Attribute_IsValid);
		GetInteger32AttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInteger32AttributeByMetadataKey");
		GetInteger32AttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInteger32AttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInteger32AttributeByMetadataKey_Key_PropertyAddress, GetInteger32AttributeByMetadataKey_FunctionAddress, "Key");
		GetInteger32AttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetInteger32AttributeByMetadataKey_FunctionAddress, "Key");
		GetInteger32AttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInteger32AttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref GetInteger32AttributeByMetadataKey_Metadata_PropertyAddress, GetInteger32AttributeByMetadataKey_FunctionAddress, "Metadata");
		GetInteger32AttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetInteger32AttributeByMetadataKey_FunctionAddress, "Metadata");
		GetInteger32AttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInteger32AttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInteger32AttributeByMetadataKey_AttributeName_PropertyAddress, GetInteger32AttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetInteger32AttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetInteger32AttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetInteger32AttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInteger32AttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInteger32AttributeByMetadataKey_ReturnValue_PropertyAddress, GetInteger32AttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetInteger32AttributeByMetadataKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInteger32AttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetInteger32AttributeByMetadataKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInteger32AttributeByMetadataKey_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetInteger32AttributeByMetadataKey_IsValid = GetInteger32AttributeByMetadataKey_FunctionAddress != IntPtr.Zero && GetInteger32AttributeByMetadataKey_Key_IsValid && GetInteger32AttributeByMetadataKey_Metadata_IsValid && GetInteger32AttributeByMetadataKey_AttributeName_IsValid && GetInteger32AttributeByMetadataKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetInteger32AttributeByMetadataKey", GetInteger32AttributeByMetadataKey_IsValid);
		GetInteger32Attribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInteger32Attribute");
		GetInteger32Attribute_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInteger32Attribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInteger32Attribute_Point_PropertyAddress, GetInteger32Attribute_FunctionAddress, "Point");
		GetInteger32Attribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(GetInteger32Attribute_FunctionAddress, "Point");
		GetInteger32Attribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInteger32Attribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInteger32Attribute_Metadata_PropertyAddress, GetInteger32Attribute_FunctionAddress, "Metadata");
		GetInteger32Attribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetInteger32Attribute_FunctionAddress, "Metadata");
		GetInteger32Attribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInteger32Attribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInteger32Attribute_AttributeName_PropertyAddress, GetInteger32Attribute_FunctionAddress, "AttributeName");
		GetInteger32Attribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetInteger32Attribute_FunctionAddress, "AttributeName");
		GetInteger32Attribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInteger32Attribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInteger32Attribute_ReturnValue_PropertyAddress, GetInteger32Attribute_FunctionAddress, "ReturnValue");
		GetInteger32Attribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInteger32Attribute_FunctionAddress, "ReturnValue");
		GetInteger32Attribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInteger32Attribute_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetInteger32Attribute_IsValid = GetInteger32Attribute_FunctionAddress != IntPtr.Zero && GetInteger32Attribute_Point_IsValid && GetInteger32Attribute_Metadata_IsValid && GetInteger32Attribute_AttributeName_IsValid && GetInteger32Attribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetInteger32Attribute", GetInteger32Attribute_IsValid);
		GetFloatAttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFloatAttributeByMetadataKey");
		GetFloatAttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFloatAttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFloatAttributeByMetadataKey_Key_PropertyAddress, GetFloatAttributeByMetadataKey_FunctionAddress, "Key");
		GetFloatAttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatAttributeByMetadataKey_FunctionAddress, "Key");
		GetFloatAttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatAttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref GetFloatAttributeByMetadataKey_Metadata_PropertyAddress, GetFloatAttributeByMetadataKey_FunctionAddress, "Metadata");
		GetFloatAttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatAttributeByMetadataKey_FunctionAddress, "Metadata");
		GetFloatAttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatAttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloatAttributeByMetadataKey_AttributeName_PropertyAddress, GetFloatAttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetFloatAttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatAttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetFloatAttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatAttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloatAttributeByMetadataKey_ReturnValue_PropertyAddress, GetFloatAttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetFloatAttributeByMetadataKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatAttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetFloatAttributeByMetadataKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatAttributeByMetadataKey_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetFloatAttributeByMetadataKey_IsValid = GetFloatAttributeByMetadataKey_FunctionAddress != IntPtr.Zero && GetFloatAttributeByMetadataKey_Key_IsValid && GetFloatAttributeByMetadataKey_Metadata_IsValid && GetFloatAttributeByMetadataKey_AttributeName_IsValid && GetFloatAttributeByMetadataKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetFloatAttributeByMetadataKey", GetFloatAttributeByMetadataKey_IsValid);
		GetFloatAttribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFloatAttribute");
		GetFloatAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFloatAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFloatAttribute_Point_PropertyAddress, GetFloatAttribute_FunctionAddress, "Point");
		GetFloatAttribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatAttribute_FunctionAddress, "Point");
		GetFloatAttribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatAttribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloatAttribute_Metadata_PropertyAddress, GetFloatAttribute_FunctionAddress, "Metadata");
		GetFloatAttribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatAttribute_FunctionAddress, "Metadata");
		GetFloatAttribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatAttribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloatAttribute_AttributeName_PropertyAddress, GetFloatAttribute_FunctionAddress, "AttributeName");
		GetFloatAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatAttribute_FunctionAddress, "AttributeName");
		GetFloatAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloatAttribute_ReturnValue_PropertyAddress, GetFloatAttribute_FunctionAddress, "ReturnValue");
		GetFloatAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatAttribute_FunctionAddress, "ReturnValue");
		GetFloatAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatAttribute_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetFloatAttribute_IsValid = GetFloatAttribute_FunctionAddress != IntPtr.Zero && GetFloatAttribute_Point_IsValid && GetFloatAttribute_Metadata_IsValid && GetFloatAttribute_AttributeName_IsValid && GetFloatAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetFloatAttribute", GetFloatAttribute_IsValid);
		GetDoubleAttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDoubleAttributeByMetadataKey");
		GetDoubleAttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDoubleAttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDoubleAttributeByMetadataKey_Key_PropertyAddress, GetDoubleAttributeByMetadataKey_FunctionAddress, "Key");
		GetDoubleAttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetDoubleAttributeByMetadataKey_FunctionAddress, "Key");
		GetDoubleAttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDoubleAttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref GetDoubleAttributeByMetadataKey_Metadata_PropertyAddress, GetDoubleAttributeByMetadataKey_FunctionAddress, "Metadata");
		GetDoubleAttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetDoubleAttributeByMetadataKey_FunctionAddress, "Metadata");
		GetDoubleAttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDoubleAttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDoubleAttributeByMetadataKey_AttributeName_PropertyAddress, GetDoubleAttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetDoubleAttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetDoubleAttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetDoubleAttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDoubleAttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDoubleAttributeByMetadataKey_ReturnValue_PropertyAddress, GetDoubleAttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetDoubleAttributeByMetadataKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDoubleAttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetDoubleAttributeByMetadataKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDoubleAttributeByMetadataKey_FunctionAddress, "ReturnValue", Classes.FDoubleProperty);
		GetDoubleAttributeByMetadataKey_IsValid = GetDoubleAttributeByMetadataKey_FunctionAddress != IntPtr.Zero && GetDoubleAttributeByMetadataKey_Key_IsValid && GetDoubleAttributeByMetadataKey_Metadata_IsValid && GetDoubleAttributeByMetadataKey_AttributeName_IsValid && GetDoubleAttributeByMetadataKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetDoubleAttributeByMetadataKey", GetDoubleAttributeByMetadataKey_IsValid);
		GetDoubleAttribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDoubleAttribute");
		GetDoubleAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDoubleAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDoubleAttribute_Point_PropertyAddress, GetDoubleAttribute_FunctionAddress, "Point");
		GetDoubleAttribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(GetDoubleAttribute_FunctionAddress, "Point");
		GetDoubleAttribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDoubleAttribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDoubleAttribute_Metadata_PropertyAddress, GetDoubleAttribute_FunctionAddress, "Metadata");
		GetDoubleAttribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetDoubleAttribute_FunctionAddress, "Metadata");
		GetDoubleAttribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDoubleAttribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDoubleAttribute_AttributeName_PropertyAddress, GetDoubleAttribute_FunctionAddress, "AttributeName");
		GetDoubleAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetDoubleAttribute_FunctionAddress, "AttributeName");
		GetDoubleAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDoubleAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDoubleAttribute_ReturnValue_PropertyAddress, GetDoubleAttribute_FunctionAddress, "ReturnValue");
		GetDoubleAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDoubleAttribute_FunctionAddress, "ReturnValue");
		GetDoubleAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDoubleAttribute_FunctionAddress, "ReturnValue", Classes.FDoubleProperty);
		GetDoubleAttribute_IsValid = GetDoubleAttribute_FunctionAddress != IntPtr.Zero && GetDoubleAttribute_Point_IsValid && GetDoubleAttribute_Metadata_IsValid && GetDoubleAttribute_AttributeName_IsValid && GetDoubleAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetDoubleAttribute", GetDoubleAttribute_IsValid);
		GetBoolAttributeByMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBoolAttributeByMetadataKey");
		GetBoolAttributeByMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoolAttributeByMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoolAttributeByMetadataKey_Key_PropertyAddress, GetBoolAttributeByMetadataKey_FunctionAddress, "Key");
		GetBoolAttributeByMetadataKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetBoolAttributeByMetadataKey_FunctionAddress, "Key");
		GetBoolAttributeByMetadataKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoolAttributeByMetadataKey_FunctionAddress, "Key", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref GetBoolAttributeByMetadataKey_Metadata_PropertyAddress, GetBoolAttributeByMetadataKey_FunctionAddress, "Metadata");
		GetBoolAttributeByMetadataKey_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetBoolAttributeByMetadataKey_FunctionAddress, "Metadata");
		GetBoolAttributeByMetadataKey_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoolAttributeByMetadataKey_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoolAttributeByMetadataKey_AttributeName_PropertyAddress, GetBoolAttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetBoolAttributeByMetadataKey_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetBoolAttributeByMetadataKey_FunctionAddress, "AttributeName");
		GetBoolAttributeByMetadataKey_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoolAttributeByMetadataKey_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoolAttributeByMetadataKey_ReturnValue_PropertyAddress, GetBoolAttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetBoolAttributeByMetadataKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoolAttributeByMetadataKey_FunctionAddress, "ReturnValue");
		GetBoolAttributeByMetadataKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoolAttributeByMetadataKey_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetBoolAttributeByMetadataKey_IsValid = GetBoolAttributeByMetadataKey_FunctionAddress != IntPtr.Zero && GetBoolAttributeByMetadataKey_Key_IsValid && GetBoolAttributeByMetadataKey_Metadata_IsValid && GetBoolAttributeByMetadataKey_AttributeName_IsValid && GetBoolAttributeByMetadataKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetBoolAttributeByMetadataKey", GetBoolAttributeByMetadataKey_IsValid);
		GetBoolAttribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBoolAttribute");
		GetBoolAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoolAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoolAttribute_Point_PropertyAddress, GetBoolAttribute_FunctionAddress, "Point");
		GetBoolAttribute_Point_Offset = NativeReflectionCached.GetPropertyOffset(GetBoolAttribute_FunctionAddress, "Point");
		GetBoolAttribute_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoolAttribute_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoolAttribute_Metadata_PropertyAddress, GetBoolAttribute_FunctionAddress, "Metadata");
		GetBoolAttribute_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(GetBoolAttribute_FunctionAddress, "Metadata");
		GetBoolAttribute_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoolAttribute_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoolAttribute_AttributeName_PropertyAddress, GetBoolAttribute_FunctionAddress, "AttributeName");
		GetBoolAttribute_AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(GetBoolAttribute_FunctionAddress, "AttributeName");
		GetBoolAttribute_AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoolAttribute_FunctionAddress, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoolAttribute_ReturnValue_PropertyAddress, GetBoolAttribute_FunctionAddress, "ReturnValue");
		GetBoolAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoolAttribute_FunctionAddress, "ReturnValue");
		GetBoolAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoolAttribute_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetBoolAttribute_IsValid = GetBoolAttribute_FunctionAddress != IntPtr.Zero && GetBoolAttribute_Point_IsValid && GetBoolAttribute_Metadata_IsValid && GetBoolAttribute_AttributeName_IsValid && GetBoolAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:GetBoolAttribute", GetBoolAttribute_IsValid);
		CopyPoint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyPoint");
		CopyPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyPoint_InPoint_PropertyAddress, CopyPoint_FunctionAddress, "InPoint");
		CopyPoint_InPoint_Offset = NativeReflectionCached.GetPropertyOffset(CopyPoint_FunctionAddress, "InPoint");
		CopyPoint_InPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyPoint_FunctionAddress, "InPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyPoint_OutPoint_PropertyAddress, CopyPoint_FunctionAddress, "OutPoint");
		CopyPoint_OutPoint_Offset = NativeReflectionCached.GetPropertyOffset(CopyPoint_FunctionAddress, "OutPoint");
		CopyPoint_OutPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyPoint_FunctionAddress, "OutPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyPoint_bCopyMetadata_PropertyAddress, CopyPoint_FunctionAddress, "bCopyMetadata");
		CopyPoint_bCopyMetadata_Offset = NativeReflectionCached.GetPropertyOffset(CopyPoint_FunctionAddress, "bCopyMetadata");
		CopyPoint_bCopyMetadata_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyPoint_FunctionAddress, "bCopyMetadata", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyPoint_InMetadata_PropertyAddress, CopyPoint_FunctionAddress, "InMetadata");
		CopyPoint_InMetadata_Offset = NativeReflectionCached.GetPropertyOffset(CopyPoint_FunctionAddress, "InMetadata");
		CopyPoint_InMetadata_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyPoint_FunctionAddress, "InMetadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyPoint_OutMetadata_PropertyAddress, CopyPoint_FunctionAddress, "OutMetadata");
		CopyPoint_OutMetadata_Offset = NativeReflectionCached.GetPropertyOffset(CopyPoint_FunctionAddress, "OutMetadata");
		CopyPoint_OutMetadata_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyPoint_FunctionAddress, "OutMetadata", Classes.FObjectProperty);
		CopyPoint_IsValid = CopyPoint_FunctionAddress != IntPtr.Zero && CopyPoint_InPoint_IsValid && CopyPoint_OutPoint_IsValid && CopyPoint_bCopyMetadata_IsValid && CopyPoint_InMetadata_IsValid && CopyPoint_OutMetadata_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMetadataAccessorHelpers:CopyPoint", CopyPoint_IsValid);
	}
}
