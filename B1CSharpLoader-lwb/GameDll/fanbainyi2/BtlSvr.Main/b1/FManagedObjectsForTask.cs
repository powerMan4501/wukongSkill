using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ManagedObjectsForTask")]
public struct FManagedObjectsForTask
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("选择的单位列表")]
	[USharpPath("/Script/b1-Managed.ManagedObjectsForTask:TaskUnitCollection")]
	public List<FManagedTaskUnit> TaskUnitCollection;

	[BlueprintReadWrite]
	[DisplayName("选择的场景物件列表")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ManagedObjectsForTask:TaskObjCollection")]
	public List<FManagedTaskObj> TaskObjCollection;

	private static int ManagedObjectsForTask_StructSize;

	private static int ManagedObjectsForTask_IsValid;

	private static bool TaskUnitCollection_IsValid;

	private static int TaskUnitCollection_Offset;

	private static FFieldAddress TaskUnitCollection_PropertyAddress;

	private static bool TaskObjCollection_IsValid;

	private static int TaskObjCollection_Offset;

	private static FFieldAddress TaskObjCollection_PropertyAddress;

	public FManagedObjectsForTask Copy()
	{
		FManagedObjectsForTask result = this;
		if (TaskUnitCollection != null)
		{
			result.TaskUnitCollection = new List<FManagedTaskUnit>(TaskUnitCollection);
		}
		if (TaskObjCollection != null)
		{
			result.TaskObjCollection = new List<FManagedTaskObj>(TaskObjCollection);
		}
		return result;
	}

	public static FManagedObjectsForTask FromNative(IntPtr nativeBuffer)
	{
		return new FManagedObjectsForTask(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FManagedObjectsForTask value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FManagedObjectsForTask FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FManagedObjectsForTask(IntPtr.Add(nativeBuffer, arrayIndex * ManagedObjectsForTask_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FManagedObjectsForTask value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ManagedObjectsForTask_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ManagedObjectsForTask_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ManagedObjectsForTask");
			return;
		}
		new TArrayCopyMarshaler<FManagedTaskUnit>(1, TaskUnitCollection_PropertyAddress, CachedMarshalingDelegates<FManagedTaskUnit, FManagedTaskUnit>.FromNative, CachedMarshalingDelegates<FManagedTaskUnit, FManagedTaskUnit>.ToNative).ToNative(IntPtr.Add(nativeStruct, TaskUnitCollection_Offset), TaskUnitCollection);
		new TArrayCopyMarshaler<FManagedTaskObj>(1, TaskObjCollection_PropertyAddress, CachedMarshalingDelegates<FManagedTaskObj, FManagedTaskObj>.FromNative, CachedMarshalingDelegates<FManagedTaskObj, FManagedTaskObj>.ToNative).ToNative(IntPtr.Add(nativeStruct, TaskObjCollection_Offset), TaskObjCollection);
	}

	public FManagedObjectsForTask(IntPtr nativeStruct)
	{
		if (ManagedObjectsForTask_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ManagedObjectsForTask");
			TaskUnitCollection = null;
			TaskObjCollection = null;
		}
		else
		{
			TaskUnitCollection = new TArrayCopyMarshaler<FManagedTaskUnit>(1, TaskUnitCollection_PropertyAddress, CachedMarshalingDelegates<FManagedTaskUnit, FManagedTaskUnit>.FromNative, CachedMarshalingDelegates<FManagedTaskUnit, FManagedTaskUnit>.ToNative).FromNative(IntPtr.Add(nativeStruct, TaskUnitCollection_Offset));
			TaskObjCollection = new TArrayCopyMarshaler<FManagedTaskObj>(1, TaskObjCollection_PropertyAddress, CachedMarshalingDelegates<FManagedTaskObj, FManagedTaskObj>.FromNative, CachedMarshalingDelegates<FManagedTaskObj, FManagedTaskObj>.ToNative).FromNative(IntPtr.Add(nativeStruct, TaskObjCollection_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ManagedObjectsForTask");
		ManagedObjectsForTask_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref TaskUnitCollection_PropertyAddress, intPtr, "TaskUnitCollection");
		TaskUnitCollection_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskUnitCollection");
		TaskUnitCollection_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskUnitCollection", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref TaskObjCollection_PropertyAddress, intPtr, "TaskObjCollection");
		TaskObjCollection_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskObjCollection");
		TaskObjCollection_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskObjCollection", Classes.FArrayProperty);
		ManagedObjectsForTask_IsValid = ((intPtr != IntPtr.Zero && TaskUnitCollection_IsValid && TaskObjCollection_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ManagedObjectsForTask", (byte)ManagedObjectsForTask_IsValid != 0);
	}

	static FManagedObjectsForTask()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FManagedObjectsForTask)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FManagedObjectsForTask));
	}
}
