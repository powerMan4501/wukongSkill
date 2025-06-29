using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FProperty
{
	[MonoNativeFunctionWrapper]
	public delegate int Del_Get_ArrayDim(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_ArrayDim(IntPtr instance, int value);

	[MonoNativeFunctionWrapper]
	public delegate int Del_Get_ElementSize(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_ElementSize(IntPtr instance, int value);

	[MonoNativeFunctionWrapper]
	public delegate EPropertyFlags Del_Get_PropertyFlags(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_PropertyFlags(IntPtr instance, EPropertyFlags value);

	[MonoNativeFunctionWrapper]
	public delegate ushort Del_Get_RepIndex(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_RepIndex(IntPtr instance, ushort value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_RepNotifyFunc(IntPtr instance, out FName result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_RepNotifyFunc(IntPtr instance, ref FName value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_PropertyLinkNext(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_PropertyLinkNext(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_NextRef(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_NextRef(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_DestructorLinkNext(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_DestructorLinkNext(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_PostConstructLinkNext(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_PostConstructLinkNext(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ImportSingleProperty(ref FScriptArray str, IntPtr destData, IntPtr objectStruct, IntPtr subobjectOuter, int portFlags, IntPtr warn, IntPtr definedProperties, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ExportCppDeclaration(IntPtr instance, IntPtr output, int declarationType, ref FScriptArray arrayDimOverride, uint additionalExportCPPFlags);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetCPPMacroType(IntPtr instance, ref FScriptArray extendedTypeText, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_PassCPPArgsByRef(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetNameCPP(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetCPPType(IntPtr instance, IntPtr extendedTypeText, uint cppExportFlags, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate int Del_GetOffset_ForDebug(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate int Del_GetOffset_ForUFunction(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate int Del_GetOffset_ForGC(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate int Del_GetOffset_ForInternal(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate int Del_GetOffset_ReplaceWith_ContainerPtrToValuePtr(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_LinkWithoutChangingOffset(IntPtr instance, IntPtr ar);

	[MonoNativeFunctionWrapper]
	public delegate int Del_Link(IntPtr instance, IntPtr ar);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Identical(IntPtr instance, IntPtr a, IntPtr b, uint portFlags);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Identical_InContainer(IntPtr instance, IntPtr a, IntPtr b, int arrayIndex, uint portFlags);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_NetSerializeItem(IntPtr instance, IntPtr ar, IntPtr map, IntPtr data, IntPtr metaData);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ExportTextItem(IntPtr instance, ref FScriptArray valueStr, IntPtr propertyValue, IntPtr defaultValue, IntPtr parent, int portFlags, IntPtr exportRootScope);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ImportText(IntPtr instance, ref FScriptArray buffer, IntPtr data, int portFlags, IntPtr ownerObject, IntPtr errorText, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ExportText_Direct(IntPtr instance, ref FScriptArray valueStr, IntPtr data, IntPtr delta, IntPtr parent, int portFlags, IntPtr exportRootScope);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ExportText_InContainer(IntPtr instance, int index, ref FScriptArray valueStr, IntPtr data, IntPtr delta, IntPtr parent, int portFlags, IntPtr exportRootScope);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ContainerUObjectPtrToValuePtr(IntPtr instance, IntPtr containerPtr, int arrayIndex);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ContainerVoidPtrToValuePtr(IntPtr instance, IntPtr containerPtr, int arrayIndex);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ContainerUObjectPtrToValuePtrForDefaults(IntPtr instance, IntPtr containerClass, IntPtr containerPtr, int arrayIndex);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ContainerVoidPtrToValuePtrForDefaults(IntPtr instance, IntPtr containerClass, IntPtr containerPtr, int arrayIndex);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsInContainer(IntPtr instance, int containerSize);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsInContainerStruct(IntPtr instance, IntPtr containerClass);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CopySingleValue(IntPtr instance, IntPtr dest, IntPtr src);

	[MonoNativeFunctionWrapper]
	public delegate uint Del_GetValueTypeHash(IntPtr instance, IntPtr src);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CopyCompleteValue(IntPtr instance, IntPtr dest, IntPtr src);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CopyCompleteValue_InContainer(IntPtr instance, IntPtr dest, IntPtr src);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CopySingleValueToScriptVM(IntPtr instance, IntPtr dest, IntPtr src);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CopyCompleteValueToScriptVM(IntPtr instance, IntPtr dest, IntPtr src);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CopySingleValueFromScriptVM(IntPtr instance, IntPtr dest, IntPtr src);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CopyCompleteValueFromScriptVM(IntPtr instance, IntPtr dest, IntPtr src);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ClearValue(IntPtr instance, IntPtr data);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ClearValue_InContainer(IntPtr instance, IntPtr data, int arrayIndex);

	[MonoNativeFunctionWrapper]
	public delegate void Del_DestroyValue(IntPtr instance, IntPtr dest);

	[MonoNativeFunctionWrapper]
	public delegate void Del_DestroyValue_InContainer(IntPtr instance, IntPtr dest);

	[MonoNativeFunctionWrapper]
	public delegate void Del_InitializeValue(IntPtr instance, IntPtr dest);

	[MonoNativeFunctionWrapper]
	public delegate void Del_InitializeValue_InContainer(IntPtr instance, IntPtr dest);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ValidateImportFlags(IntPtr instance, int portFlags, IntPtr errorText);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ShouldPort(IntPtr instance, uint portFlags);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetID(IntPtr instance, out FName result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_InstanceSubobjects(IntPtr instance, IntPtr data, IntPtr defaultData, IntPtr owner, IntPtr instanceGraph);

	[MonoNativeFunctionWrapper]
	public delegate int Del_GetMinAlignment(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ContainsObjectReference(IntPtr instance, IntPtr encounteredStructProps);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ContainsWeakObjectReference(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ContainsInstancedObjectProperty(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate int Del_GetSize(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ShouldSerializeValue(IntPtr instance, IntPtr ar);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ShouldDuplicateValue(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetOwnerProperty(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate EPropertyFlags Del_GetPropertyFlags(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetPropertyFlags(IntPtr instance, EPropertyFlags newFlags);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ClearPropertyFlags(IntPtr instance, EPropertyFlags newFlags);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_HasAnyPropertyFlags(IntPtr instance, EPropertyFlags flagsToCheck);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_HasAllPropertyFlags(IntPtr instance, EPropertyFlags flagsToCheck);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetRepOwner(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsEditorOnlyProperty(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_SameType(IntPtr instance, IntPtr other);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetName(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetFName(IntPtr instance, out FName result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetPathName(IntPtr instance, IntPtr stopOuter, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithUObjectOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithFPropertyOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructByCastFlags(IntPtr Outer, bool bUObjectOuter, EClassCastFlags CastFlags, ref FName InName, EObjectFlags InObjectFlags);

	public static Del_Get_ArrayDim Get_ArrayDim;

	public static Del_Set_ArrayDim Set_ArrayDim;

	public static Del_Get_ElementSize Get_ElementSize;

	public static Del_Set_ElementSize Set_ElementSize;

	public static Del_Get_PropertyFlags Get_PropertyFlags;

	public static Del_Set_PropertyFlags Set_PropertyFlags;

	public static Del_Get_RepIndex Get_RepIndex;

	public static Del_Set_RepIndex Set_RepIndex;

	public static Del_Get_RepNotifyFunc Get_RepNotifyFunc;

	public static Del_Set_RepNotifyFunc Set_RepNotifyFunc;

	public static Del_Get_PropertyLinkNext Get_PropertyLinkNext;

	public static Del_Set_PropertyLinkNext Set_PropertyLinkNext;

	public static Del_Get_NextRef Get_NextRef;

	public static Del_Set_NextRef Set_NextRef;

	public static Del_Get_DestructorLinkNext Get_DestructorLinkNext;

	public static Del_Set_DestructorLinkNext Set_DestructorLinkNext;

	public static Del_Get_PostConstructLinkNext Get_PostConstructLinkNext;

	public static Del_Set_PostConstructLinkNext Set_PostConstructLinkNext;

	public static Del_ImportSingleProperty ImportSingleProperty;

	public static Del_ExportCppDeclaration ExportCppDeclaration;

	public static Del_GetCPPMacroType GetCPPMacroType;

	public static Del_PassCPPArgsByRef PassCPPArgsByRef;

	public static Del_GetNameCPP GetNameCPP;

	public static Del_GetCPPType GetCPPType;

	public static Del_GetOffset_ForDebug GetOffset_ForDebug;

	public static Del_GetOffset_ForUFunction GetOffset_ForUFunction;

	public static Del_GetOffset_ForGC GetOffset_ForGC;

	public static Del_GetOffset_ForInternal GetOffset_ForInternal;

	public static Del_GetOffset_ReplaceWith_ContainerPtrToValuePtr GetOffset_ReplaceWith_ContainerPtrToValuePtr;

	public static Del_LinkWithoutChangingOffset LinkWithoutChangingOffset;

	public static Del_Link Link;

	public static Del_Identical Identical;

	public static Del_Identical_InContainer Identical_InContainer;

	public static Del_NetSerializeItem NetSerializeItem;

	public static Del_ExportTextItem ExportTextItem;

	public static Del_ImportText ImportText;

	public static Del_ExportText_Direct ExportText_Direct;

	public static Del_ExportText_InContainer ExportText_InContainer;

	public static Del_ContainerUObjectPtrToValuePtr ContainerUObjectPtrToValuePtr;

	public static Del_ContainerVoidPtrToValuePtr ContainerVoidPtrToValuePtr;

	public static Del_ContainerUObjectPtrToValuePtrForDefaults ContainerUObjectPtrToValuePtrForDefaults;

	public static Del_ContainerVoidPtrToValuePtrForDefaults ContainerVoidPtrToValuePtrForDefaults;

	public static Del_IsInContainer IsInContainer;

	public static Del_IsInContainerStruct IsInContainerStruct;

	public static Del_CopySingleValue CopySingleValue;

	public static Del_GetValueTypeHash GetValueTypeHash;

	public static Del_CopyCompleteValue CopyCompleteValue;

	public static Del_CopyCompleteValue_InContainer CopyCompleteValue_InContainer;

	public static Del_CopySingleValueToScriptVM CopySingleValueToScriptVM;

	public static Del_CopyCompleteValueToScriptVM CopyCompleteValueToScriptVM;

	public static Del_CopySingleValueFromScriptVM CopySingleValueFromScriptVM;

	public static Del_CopyCompleteValueFromScriptVM CopyCompleteValueFromScriptVM;

	public static Del_ClearValue ClearValue;

	public static Del_ClearValue_InContainer ClearValue_InContainer;

	public static Del_DestroyValue DestroyValue;

	public static Del_DestroyValue_InContainer DestroyValue_InContainer;

	public static Del_InitializeValue InitializeValue;

	public static Del_InitializeValue_InContainer InitializeValue_InContainer;

	public static Del_ValidateImportFlags ValidateImportFlags;

	public static Del_ShouldPort ShouldPort;

	public static Del_GetID GetID;

	public static Del_InstanceSubobjects InstanceSubobjects;

	public static Del_GetMinAlignment GetMinAlignment;

	public static Del_ContainsObjectReference ContainsObjectReference;

	public static Del_ContainsWeakObjectReference ContainsWeakObjectReference;

	public static Del_ContainsInstancedObjectProperty ContainsInstancedObjectProperty;

	public static Del_GetSize GetSize;

	public static Del_ShouldSerializeValue ShouldSerializeValue;

	public static Del_ShouldDuplicateValue ShouldDuplicateValue;

	public static Del_GetOwnerProperty GetOwnerProperty;

	public static Del_GetPropertyFlags GetPropertyFlags;

	public static Del_SetPropertyFlags SetPropertyFlags;

	public static Del_ClearPropertyFlags ClearPropertyFlags;

	public static Del_HasAnyPropertyFlags HasAnyPropertyFlags;

	public static Del_HasAllPropertyFlags HasAllPropertyFlags;

	public static Del_GetRepOwner GetRepOwner;

	public static Del_IsEditorOnlyProperty IsEditorOnlyProperty;

	public static Del_SameType SameType;

	public static Del_GetName GetName;

	public static Del_GetFName GetFName;

	public static Del_GetPathName GetPathName;

	public static Del_ConstructWithUObjectOuter ConstructWithUObjectOuter;

	public static Del_ConstructWithFPropertyOuter ConstructWithFPropertyOuter;

	public static Del_ConstructByCastFlags ConstructByCastFlags;
}
