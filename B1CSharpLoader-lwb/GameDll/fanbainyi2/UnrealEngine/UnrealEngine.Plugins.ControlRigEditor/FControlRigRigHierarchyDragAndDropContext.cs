using System;
using System.Collections.Generic;
using UnrealEngine.Plugins.ControlRig;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigEditor;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ControlRigEditor.ControlRigRigHierarchyDragAndDropContext", "ControlRigEditor", UnrealModuleType.EnginePlugin)]
public struct FControlRigRigHierarchyDragAndDropContext
{
	private static bool DraggedElementKeys_IsValid;

	private static FFieldAddress DraggedElementKeys_PropertyAddress;

	private static int DraggedElementKeys_Offset;

	[UProperty(Flags = (PropFlags)4503599627371028uL)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigRigHierarchyDragAndDropContext:DraggedElementKeys")]
	public List<FRigElementKey> DraggedElementKeys;

	private static bool TargetElementKey_IsValid;

	private static int TargetElementKey_Offset;

	[UProperty(Flags = (PropFlags)6755468160532500uL)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigRigHierarchyDragAndDropContext:TargetElementKey")]
	public FRigElementKey TargetElementKey;

	private static bool FControlRigRigHierarchyDragAndDropContext_IsValid;

	private static int FControlRigRigHierarchyDragAndDropContext_StructSize;

	public FControlRigRigHierarchyDragAndDropContext Copy()
	{
		FControlRigRigHierarchyDragAndDropContext result = this;
		if (DraggedElementKeys != null)
		{
			result.DraggedElementKeys = new List<FRigElementKey>(DraggedElementKeys);
		}
		return result;
	}

	public static FControlRigRigHierarchyDragAndDropContext FromNative(IntPtr nativeBuffer)
	{
		return new FControlRigRigHierarchyDragAndDropContext(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FControlRigRigHierarchyDragAndDropContext value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FControlRigRigHierarchyDragAndDropContext FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FControlRigRigHierarchyDragAndDropContext(nativeBuffer + arrayIndex * FControlRigRigHierarchyDragAndDropContext_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FControlRigRigHierarchyDragAndDropContext value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FControlRigRigHierarchyDragAndDropContext_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FControlRigRigHierarchyDragAndDropContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigEditor.ControlRigRigHierarchyDragAndDropContext");
			return;
		}
		new TArrayCopyMarshaler<FRigElementKey>(1, DraggedElementKeys_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).ToNative(IntPtr.Add(nativeStruct, DraggedElementKeys_Offset), DraggedElementKeys);
		FRigElementKey.ToNative(IntPtr.Add(nativeStruct, TargetElementKey_Offset), TargetElementKey);
	}

	public FControlRigRigHierarchyDragAndDropContext(IntPtr nativeStruct)
	{
		if (!FControlRigRigHierarchyDragAndDropContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigEditor.ControlRigRigHierarchyDragAndDropContext");
			DraggedElementKeys = null;
			TargetElementKey = default(FRigElementKey);
		}
		else
		{
			DraggedElementKeys = new TArrayCopyMarshaler<FRigElementKey>(1, DraggedElementKeys_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).FromNative(IntPtr.Add(nativeStruct, DraggedElementKeys_Offset));
			TargetElementKey = FRigElementKey.FromNative(IntPtr.Add(nativeStruct, TargetElementKey_Offset));
		}
	}

	static FControlRigRigHierarchyDragAndDropContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FControlRigRigHierarchyDragAndDropContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FControlRigRigHierarchyDragAndDropContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRigEditor.ControlRigRigHierarchyDragAndDropContext");
		FControlRigRigHierarchyDragAndDropContext_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref DraggedElementKeys_PropertyAddress, intPtr, "DraggedElementKeys");
		DraggedElementKeys_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DraggedElementKeys");
		DraggedElementKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DraggedElementKeys", Classes.FArrayProperty);
		TargetElementKey_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetElementKey");
		TargetElementKey_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetElementKey", Classes.FStructProperty);
		FControlRigRigHierarchyDragAndDropContext_IsValid = intPtr != IntPtr.Zero && DraggedElementKeys_IsValid && TargetElementKey_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRigEditor.ControlRigRigHierarchyDragAndDropContext", FControlRigRigHierarchyDragAndDropContext_IsValid);
	}
}
