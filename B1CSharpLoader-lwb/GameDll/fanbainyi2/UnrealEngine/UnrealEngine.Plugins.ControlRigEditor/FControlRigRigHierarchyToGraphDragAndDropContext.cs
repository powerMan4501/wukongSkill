using System;
using System.Collections.Generic;
using UnrealEngine.Plugins.ControlRig;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigEditor;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ControlRigEditor.ControlRigRigHierarchyToGraphDragAndDropContext", "ControlRigEditor", UnrealModuleType.EnginePlugin)]
public struct FControlRigRigHierarchyToGraphDragAndDropContext
{
	private static bool DraggedElementKeys_IsValid;

	private static FFieldAddress DraggedElementKeys_PropertyAddress;

	private static int DraggedElementKeys_Offset;

	[UProperty(Flags = (PropFlags)4503599627371028uL)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigRigHierarchyToGraphDragAndDropContext:DraggedElementKeys")]
	public List<FRigElementKey> DraggedElementKeys;

	private static bool FControlRigRigHierarchyToGraphDragAndDropContext_IsValid;

	private static int FControlRigRigHierarchyToGraphDragAndDropContext_StructSize;

	public FControlRigRigHierarchyToGraphDragAndDropContext Copy()
	{
		FControlRigRigHierarchyToGraphDragAndDropContext result = this;
		if (DraggedElementKeys != null)
		{
			result.DraggedElementKeys = new List<FRigElementKey>(DraggedElementKeys);
		}
		return result;
	}

	public static FControlRigRigHierarchyToGraphDragAndDropContext FromNative(IntPtr nativeBuffer)
	{
		return new FControlRigRigHierarchyToGraphDragAndDropContext(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FControlRigRigHierarchyToGraphDragAndDropContext value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FControlRigRigHierarchyToGraphDragAndDropContext FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FControlRigRigHierarchyToGraphDragAndDropContext(nativeBuffer + arrayIndex * FControlRigRigHierarchyToGraphDragAndDropContext_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FControlRigRigHierarchyToGraphDragAndDropContext value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FControlRigRigHierarchyToGraphDragAndDropContext_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FControlRigRigHierarchyToGraphDragAndDropContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigEditor.ControlRigRigHierarchyToGraphDragAndDropContext");
		}
		else
		{
			new TArrayCopyMarshaler<FRigElementKey>(1, DraggedElementKeys_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).ToNative(IntPtr.Add(nativeStruct, DraggedElementKeys_Offset), DraggedElementKeys);
		}
	}

	public FControlRigRigHierarchyToGraphDragAndDropContext(IntPtr nativeStruct)
	{
		if (!FControlRigRigHierarchyToGraphDragAndDropContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigEditor.ControlRigRigHierarchyToGraphDragAndDropContext");
			DraggedElementKeys = null;
		}
		else
		{
			DraggedElementKeys = new TArrayCopyMarshaler<FRigElementKey>(1, DraggedElementKeys_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).FromNative(IntPtr.Add(nativeStruct, DraggedElementKeys_Offset));
		}
	}

	static FControlRigRigHierarchyToGraphDragAndDropContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FControlRigRigHierarchyToGraphDragAndDropContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FControlRigRigHierarchyToGraphDragAndDropContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRigEditor.ControlRigRigHierarchyToGraphDragAndDropContext");
		FControlRigRigHierarchyToGraphDragAndDropContext_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref DraggedElementKeys_PropertyAddress, intPtr, "DraggedElementKeys");
		DraggedElementKeys_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DraggedElementKeys");
		DraggedElementKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DraggedElementKeys", Classes.FArrayProperty);
		FControlRigRigHierarchyToGraphDragAndDropContext_IsValid = intPtr != IntPtr.Zero && DraggedElementKeys_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRigEditor.ControlRigRigHierarchyToGraphDragAndDropContext", FControlRigRigHierarchyToGraphDragAndDropContext_IsValid);
	}
}
