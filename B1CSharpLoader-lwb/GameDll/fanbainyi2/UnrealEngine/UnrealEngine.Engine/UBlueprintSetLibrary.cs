using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.BlueprintSetLibrary", "Engine", UnrealModuleType.Engine)]
public class UBlueprintSetLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool Set_Union_IsValid;

	private static IntPtr Set_Union_FunctionAddress;

	private static int Set_Union_ParamsSize;

	private static bool Set_Union_A_IsValid;

	private static FFieldAddress Set_Union_A_PropertyAddress;

	private static int Set_Union_A_Offset;

	private static bool Set_Union_B_IsValid;

	private static FFieldAddress Set_Union_B_PropertyAddress;

	private static int Set_Union_B_Offset;

	private static bool Set_Union_Result_IsValid;

	private static FFieldAddress Set_Union_Result_PropertyAddress;

	private static int Set_Union_Result_Offset;

	private static bool Set_ToArray_IsValid;

	private static IntPtr Set_ToArray_FunctionAddress;

	private static int Set_ToArray_ParamsSize;

	private static bool Set_ToArray_A_IsValid;

	private static FFieldAddress Set_ToArray_A_PropertyAddress;

	private static int Set_ToArray_A_Offset;

	private static bool Set_ToArray_Result_IsValid;

	private static FFieldAddress Set_ToArray_Result_PropertyAddress;

	private static int Set_ToArray_Result_Offset;

	private static bool Set_RemoveItems_IsValid;

	private static IntPtr Set_RemoveItems_FunctionAddress;

	private static int Set_RemoveItems_ParamsSize;

	private static bool Set_RemoveItems_TargetSet_IsValid;

	private static FFieldAddress Set_RemoveItems_TargetSet_PropertyAddress;

	private static int Set_RemoveItems_TargetSet_Offset;

	private static bool Set_RemoveItems_Items_IsValid;

	private static FFieldAddress Set_RemoveItems_Items_PropertyAddress;

	private static int Set_RemoveItems_Items_Offset;

	private static bool Set_Remove_IsValid;

	private static IntPtr Set_Remove_FunctionAddress;

	private static int Set_Remove_ParamsSize;

	private static bool Set_Remove_TargetSet_IsValid;

	private static FFieldAddress Set_Remove_TargetSet_PropertyAddress;

	private static int Set_Remove_TargetSet_Offset;

	private static bool Set_Remove_Item_IsValid;

	private static FFieldAddress Set_Remove_Item_PropertyAddress;

	private static int Set_Remove_Item_Offset;

	private static bool Set_Remove_ReturnValue_IsValid;

	private static FFieldAddress Set_Remove_ReturnValue_PropertyAddress;

	private static int Set_Remove_ReturnValue_Offset;

	private static bool Set_Length_IsValid;

	private static IntPtr Set_Length_FunctionAddress;

	private static int Set_Length_ParamsSize;

	private static bool Set_Length_TargetSet_IsValid;

	private static FFieldAddress Set_Length_TargetSet_PropertyAddress;

	private static int Set_Length_TargetSet_Offset;

	private static bool Set_Length_ReturnValue_IsValid;

	private static FFieldAddress Set_Length_ReturnValue_PropertyAddress;

	private static int Set_Length_ReturnValue_Offset;

	private static bool Set_IsNotEmpty_IsValid;

	private static IntPtr Set_IsNotEmpty_FunctionAddress;

	private static int Set_IsNotEmpty_ParamsSize;

	private static bool Set_IsNotEmpty_TargetSet_IsValid;

	private static FFieldAddress Set_IsNotEmpty_TargetSet_PropertyAddress;

	private static int Set_IsNotEmpty_TargetSet_Offset;

	private static bool Set_IsNotEmpty_ReturnValue_IsValid;

	private static FFieldAddress Set_IsNotEmpty_ReturnValue_PropertyAddress;

	private static int Set_IsNotEmpty_ReturnValue_Offset;

	private static bool Set_IsEmpty_IsValid;

	private static IntPtr Set_IsEmpty_FunctionAddress;

	private static int Set_IsEmpty_ParamsSize;

	private static bool Set_IsEmpty_TargetSet_IsValid;

	private static FFieldAddress Set_IsEmpty_TargetSet_PropertyAddress;

	private static int Set_IsEmpty_TargetSet_Offset;

	private static bool Set_IsEmpty_ReturnValue_IsValid;

	private static FFieldAddress Set_IsEmpty_ReturnValue_PropertyAddress;

	private static int Set_IsEmpty_ReturnValue_Offset;

	private static bool Set_Intersection_IsValid;

	private static IntPtr Set_Intersection_FunctionAddress;

	private static int Set_Intersection_ParamsSize;

	private static bool Set_Intersection_A_IsValid;

	private static FFieldAddress Set_Intersection_A_PropertyAddress;

	private static int Set_Intersection_A_Offset;

	private static bool Set_Intersection_B_IsValid;

	private static FFieldAddress Set_Intersection_B_PropertyAddress;

	private static int Set_Intersection_B_Offset;

	private static bool Set_Intersection_Result_IsValid;

	private static FFieldAddress Set_Intersection_Result_PropertyAddress;

	private static int Set_Intersection_Result_Offset;

	private static bool Set_Difference_IsValid;

	private static IntPtr Set_Difference_FunctionAddress;

	private static int Set_Difference_ParamsSize;

	private static bool Set_Difference_A_IsValid;

	private static FFieldAddress Set_Difference_A_PropertyAddress;

	private static int Set_Difference_A_Offset;

	private static bool Set_Difference_B_IsValid;

	private static FFieldAddress Set_Difference_B_PropertyAddress;

	private static int Set_Difference_B_Offset;

	private static bool Set_Difference_Result_IsValid;

	private static FFieldAddress Set_Difference_Result_PropertyAddress;

	private static int Set_Difference_Result_Offset;

	private static bool Set_Contains_IsValid;

	private static IntPtr Set_Contains_FunctionAddress;

	private static int Set_Contains_ParamsSize;

	private static bool Set_Contains_TargetSet_IsValid;

	private static FFieldAddress Set_Contains_TargetSet_PropertyAddress;

	private static int Set_Contains_TargetSet_Offset;

	private static bool Set_Contains_ItemToFind_IsValid;

	private static FFieldAddress Set_Contains_ItemToFind_PropertyAddress;

	private static int Set_Contains_ItemToFind_Offset;

	private static bool Set_Contains_ReturnValue_IsValid;

	private static FFieldAddress Set_Contains_ReturnValue_PropertyAddress;

	private static int Set_Contains_ReturnValue_Offset;

	private static bool Set_Clear_IsValid;

	private static IntPtr Set_Clear_FunctionAddress;

	private static int Set_Clear_ParamsSize;

	private static bool Set_Clear_TargetSet_IsValid;

	private static FFieldAddress Set_Clear_TargetSet_PropertyAddress;

	private static int Set_Clear_TargetSet_Offset;

	private static bool Set_AddItems_IsValid;

	private static IntPtr Set_AddItems_FunctionAddress;

	private static int Set_AddItems_ParamsSize;

	private static bool Set_AddItems_TargetSet_IsValid;

	private static FFieldAddress Set_AddItems_TargetSet_PropertyAddress;

	private static int Set_AddItems_TargetSet_Offset;

	private static bool Set_AddItems_NewItems_IsValid;

	private static FFieldAddress Set_AddItems_NewItems_PropertyAddress;

	private static int Set_AddItems_NewItems_Offset;

	private static bool Set_Add_IsValid;

	private static IntPtr Set_Add_FunctionAddress;

	private static int Set_Add_ParamsSize;

	private static bool Set_Add_TargetSet_IsValid;

	private static FFieldAddress Set_Add_TargetSet_PropertyAddress;

	private static int Set_Add_TargetSet_Offset;

	private static bool Set_Add_NewItem_IsValid;

	private static FFieldAddress Set_Add_NewItem_PropertyAddress;

	private static int Set_Add_NewItem_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.BlueprintSetLibrary:Set_Union")]
	public unsafe static void Set_Union(HashSet<int> A, HashSet<int> B, out HashSet<int> Result)
	{
		if (!Set_Union_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintSetLibrary:Set_Union");
			Result = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Set_Union_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Set_Union_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Set_Union_A_PropertyAddress.Address, intPtr);
		new TSetCopyMarshaler<int>(1, Set_Union_A_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Set_Union_A_Offset), A);
		NativeReflection.InitializeValue_InContainer(Set_Union_B_PropertyAddress.Address, intPtr);
		new TSetCopyMarshaler<int>(1, Set_Union_B_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Set_Union_B_Offset), B);
		NativeReflection.InitializeValue_InContainer(Set_Union_Result_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Set_Union_FunctionAddress, intPtr, Set_Union_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Set_Union_A_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(Set_Union_B_PropertyAddress.Address, intPtr);
		Result = new TSetCopyMarshaler<int>(1, Set_Union_Result_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, Set_Union_Result_Offset));
		NativeReflection.DestroyValue_InContainer(Set_Union_Result_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.BlueprintSetLibrary:Set_ToArray")]
	public unsafe static void Set_ToArray(HashSet<int> A, out List<int> Result)
	{
		if (!Set_ToArray_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintSetLibrary:Set_ToArray");
			Result = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Set_ToArray_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Set_ToArray_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Set_ToArray_A_PropertyAddress.Address, intPtr);
		new TSetCopyMarshaler<int>(1, Set_ToArray_A_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Set_ToArray_A_Offset), A);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Set_ToArray_FunctionAddress, intPtr, Set_ToArray_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Set_ToArray_A_PropertyAddress.Address, intPtr);
		Result = new TArrayCopyMarshaler<int>(1, Set_ToArray_Result_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, Set_ToArray_Result_Offset));
		NativeReflection.DestroyValue_InContainer(Set_ToArray_Result_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.BlueprintSetLibrary:Set_RemoveItems")]
	public unsafe static void Set_RemoveItems(HashSet<int> TargetSet, List<int> Items)
	{
		if (!Set_RemoveItems_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintSetLibrary:Set_RemoveItems");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Set_RemoveItems_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Set_RemoveItems_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Set_RemoveItems_TargetSet_PropertyAddress.Address, intPtr);
		new TSetCopyMarshaler<int>(1, Set_RemoveItems_TargetSet_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Set_RemoveItems_TargetSet_Offset), TargetSet);
		new TArrayCopyMarshaler<int>(1, Set_RemoveItems_Items_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Set_RemoveItems_Items_Offset), Items);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Set_RemoveItems_FunctionAddress, intPtr, Set_RemoveItems_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Set_RemoveItems_TargetSet_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(Set_RemoveItems_Items_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.BlueprintSetLibrary:Set_Remove")]
	public unsafe static bool Set_Remove(HashSet<int> TargetSet, int Item)
	{
		if (!Set_Remove_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintSetLibrary:Set_Remove");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Set_Remove_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Set_Remove_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Set_Remove_TargetSet_PropertyAddress.Address, intPtr);
		new TSetCopyMarshaler<int>(1, Set_Remove_TargetSet_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Set_Remove_TargetSet_Offset), TargetSet);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Set_Remove_Item_Offset), 0, Set_Remove_Item_PropertyAddress.Address, Item);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Set_Remove_FunctionAddress, intPtr, Set_Remove_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Set_Remove_TargetSet_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Set_Remove_ReturnValue_Offset), 0, Set_Remove_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.BlueprintSetLibrary:Set_Length")]
	public unsafe static int Set_Length(HashSet<int> TargetSet)
	{
		if (!Set_Length_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintSetLibrary:Set_Length");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Set_Length_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Set_Length_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Set_Length_TargetSet_PropertyAddress.Address, intPtr);
		new TSetCopyMarshaler<int>(1, Set_Length_TargetSet_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Set_Length_TargetSet_Offset), TargetSet);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Set_Length_FunctionAddress, intPtr, Set_Length_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Set_Length_TargetSet_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, Set_Length_ReturnValue_Offset), 0, Set_Length_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.BlueprintSetLibrary:Set_IsNotEmpty")]
	public unsafe static bool Set_IsNotEmpty(HashSet<int> TargetSet)
	{
		if (!Set_IsNotEmpty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintSetLibrary:Set_IsNotEmpty");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Set_IsNotEmpty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Set_IsNotEmpty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Set_IsNotEmpty_TargetSet_PropertyAddress.Address, intPtr);
		new TSetCopyMarshaler<int>(1, Set_IsNotEmpty_TargetSet_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Set_IsNotEmpty_TargetSet_Offset), TargetSet);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Set_IsNotEmpty_FunctionAddress, intPtr, Set_IsNotEmpty_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Set_IsNotEmpty_TargetSet_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Set_IsNotEmpty_ReturnValue_Offset), 0, Set_IsNotEmpty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.BlueprintSetLibrary:Set_IsEmpty")]
	public unsafe static bool Set_IsEmpty(HashSet<int> TargetSet)
	{
		if (!Set_IsEmpty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintSetLibrary:Set_IsEmpty");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Set_IsEmpty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Set_IsEmpty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Set_IsEmpty_TargetSet_PropertyAddress.Address, intPtr);
		new TSetCopyMarshaler<int>(1, Set_IsEmpty_TargetSet_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Set_IsEmpty_TargetSet_Offset), TargetSet);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Set_IsEmpty_FunctionAddress, intPtr, Set_IsEmpty_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Set_IsEmpty_TargetSet_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Set_IsEmpty_ReturnValue_Offset), 0, Set_IsEmpty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.BlueprintSetLibrary:Set_Intersection")]
	public unsafe static void Set_Intersection(HashSet<int> A, HashSet<int> B, out HashSet<int> Result)
	{
		if (!Set_Intersection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintSetLibrary:Set_Intersection");
			Result = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Set_Intersection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Set_Intersection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Set_Intersection_A_PropertyAddress.Address, intPtr);
		new TSetCopyMarshaler<int>(1, Set_Intersection_A_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Set_Intersection_A_Offset), A);
		NativeReflection.InitializeValue_InContainer(Set_Intersection_B_PropertyAddress.Address, intPtr);
		new TSetCopyMarshaler<int>(1, Set_Intersection_B_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Set_Intersection_B_Offset), B);
		NativeReflection.InitializeValue_InContainer(Set_Intersection_Result_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Set_Intersection_FunctionAddress, intPtr, Set_Intersection_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Set_Intersection_A_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(Set_Intersection_B_PropertyAddress.Address, intPtr);
		Result = new TSetCopyMarshaler<int>(1, Set_Intersection_Result_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, Set_Intersection_Result_Offset));
		NativeReflection.DestroyValue_InContainer(Set_Intersection_Result_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.BlueprintSetLibrary:Set_Difference")]
	public unsafe static void Set_Difference(HashSet<int> A, HashSet<int> B, out HashSet<int> Result)
	{
		if (!Set_Difference_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintSetLibrary:Set_Difference");
			Result = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Set_Difference_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Set_Difference_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Set_Difference_A_PropertyAddress.Address, intPtr);
		new TSetCopyMarshaler<int>(1, Set_Difference_A_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Set_Difference_A_Offset), A);
		NativeReflection.InitializeValue_InContainer(Set_Difference_B_PropertyAddress.Address, intPtr);
		new TSetCopyMarshaler<int>(1, Set_Difference_B_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Set_Difference_B_Offset), B);
		NativeReflection.InitializeValue_InContainer(Set_Difference_Result_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Set_Difference_FunctionAddress, intPtr, Set_Difference_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Set_Difference_A_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(Set_Difference_B_PropertyAddress.Address, intPtr);
		Result = new TSetCopyMarshaler<int>(1, Set_Difference_Result_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, Set_Difference_Result_Offset));
		NativeReflection.DestroyValue_InContainer(Set_Difference_Result_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.BlueprintSetLibrary:Set_Contains")]
	public unsafe static bool Set_Contains(HashSet<int> TargetSet, int ItemToFind)
	{
		if (!Set_Contains_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintSetLibrary:Set_Contains");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Set_Contains_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Set_Contains_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Set_Contains_TargetSet_PropertyAddress.Address, intPtr);
		new TSetCopyMarshaler<int>(1, Set_Contains_TargetSet_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Set_Contains_TargetSet_Offset), TargetSet);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Set_Contains_ItemToFind_Offset), 0, Set_Contains_ItemToFind_PropertyAddress.Address, ItemToFind);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Set_Contains_FunctionAddress, intPtr, Set_Contains_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Set_Contains_TargetSet_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Set_Contains_ReturnValue_Offset), 0, Set_Contains_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.BlueprintSetLibrary:Set_Clear")]
	public unsafe static void Set_Clear(HashSet<int> TargetSet)
	{
		if (!Set_Clear_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintSetLibrary:Set_Clear");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Set_Clear_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Set_Clear_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Set_Clear_TargetSet_PropertyAddress.Address, intPtr);
		new TSetCopyMarshaler<int>(1, Set_Clear_TargetSet_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Set_Clear_TargetSet_Offset), TargetSet);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Set_Clear_FunctionAddress, intPtr, Set_Clear_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Set_Clear_TargetSet_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.BlueprintSetLibrary:Set_AddItems")]
	public unsafe static void Set_AddItems(HashSet<int> TargetSet, List<int> NewItems)
	{
		if (!Set_AddItems_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintSetLibrary:Set_AddItems");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Set_AddItems_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Set_AddItems_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Set_AddItems_TargetSet_PropertyAddress.Address, intPtr);
		new TSetCopyMarshaler<int>(1, Set_AddItems_TargetSet_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Set_AddItems_TargetSet_Offset), TargetSet);
		new TArrayCopyMarshaler<int>(1, Set_AddItems_NewItems_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Set_AddItems_NewItems_Offset), NewItems);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Set_AddItems_FunctionAddress, intPtr, Set_AddItems_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Set_AddItems_TargetSet_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(Set_AddItems_NewItems_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.BlueprintSetLibrary:Set_Add")]
	public unsafe static void Set_Add(HashSet<int> TargetSet, int NewItem)
	{
		if (!Set_Add_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintSetLibrary:Set_Add");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Set_Add_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Set_Add_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Set_Add_TargetSet_PropertyAddress.Address, intPtr);
		new TSetCopyMarshaler<int>(1, Set_Add_TargetSet_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Set_Add_TargetSet_Offset), TargetSet);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Set_Add_NewItem_Offset), 0, Set_Add_NewItem_PropertyAddress.Address, NewItem);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Set_Add_FunctionAddress, intPtr, Set_Add_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Set_Add_TargetSet_PropertyAddress.Address, intPtr);
	}

	static UBlueprintSetLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBlueprintSetLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBlueprintSetLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.BlueprintSetLibrary");
		Set_Union_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Set_Union");
		Set_Union_ParamsSize = NativeReflection.GetFunctionParamsSize(Set_Union_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Set_Union_A_PropertyAddress, Set_Union_FunctionAddress, "A");
		Set_Union_A_Offset = NativeReflectionCached.GetPropertyOffset(Set_Union_FunctionAddress, "A");
		Set_Union_A_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_Union_FunctionAddress, "A", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref Set_Union_B_PropertyAddress, Set_Union_FunctionAddress, "B");
		Set_Union_B_Offset = NativeReflectionCached.GetPropertyOffset(Set_Union_FunctionAddress, "B");
		Set_Union_B_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_Union_FunctionAddress, "B", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref Set_Union_Result_PropertyAddress, Set_Union_FunctionAddress, "Result");
		Set_Union_Result_Offset = NativeReflectionCached.GetPropertyOffset(Set_Union_FunctionAddress, "Result");
		Set_Union_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_Union_FunctionAddress, "Result", Classes.FSetProperty);
		Set_Union_IsValid = Set_Union_FunctionAddress != IntPtr.Zero && Set_Union_A_IsValid && Set_Union_B_IsValid && Set_Union_Result_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintSetLibrary:Set_Union", Set_Union_IsValid);
		Set_ToArray_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Set_ToArray");
		Set_ToArray_ParamsSize = NativeReflection.GetFunctionParamsSize(Set_ToArray_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Set_ToArray_A_PropertyAddress, Set_ToArray_FunctionAddress, "A");
		Set_ToArray_A_Offset = NativeReflectionCached.GetPropertyOffset(Set_ToArray_FunctionAddress, "A");
		Set_ToArray_A_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_ToArray_FunctionAddress, "A", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref Set_ToArray_Result_PropertyAddress, Set_ToArray_FunctionAddress, "Result");
		Set_ToArray_Result_Offset = NativeReflectionCached.GetPropertyOffset(Set_ToArray_FunctionAddress, "Result");
		Set_ToArray_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_ToArray_FunctionAddress, "Result", Classes.FArrayProperty);
		Set_ToArray_IsValid = Set_ToArray_FunctionAddress != IntPtr.Zero && Set_ToArray_A_IsValid && Set_ToArray_Result_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintSetLibrary:Set_ToArray", Set_ToArray_IsValid);
		Set_RemoveItems_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Set_RemoveItems");
		Set_RemoveItems_ParamsSize = NativeReflection.GetFunctionParamsSize(Set_RemoveItems_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Set_RemoveItems_TargetSet_PropertyAddress, Set_RemoveItems_FunctionAddress, "TargetSet");
		Set_RemoveItems_TargetSet_Offset = NativeReflectionCached.GetPropertyOffset(Set_RemoveItems_FunctionAddress, "TargetSet");
		Set_RemoveItems_TargetSet_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_RemoveItems_FunctionAddress, "TargetSet", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref Set_RemoveItems_Items_PropertyAddress, Set_RemoveItems_FunctionAddress, "Items");
		Set_RemoveItems_Items_Offset = NativeReflectionCached.GetPropertyOffset(Set_RemoveItems_FunctionAddress, "Items");
		Set_RemoveItems_Items_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_RemoveItems_FunctionAddress, "Items", Classes.FArrayProperty);
		Set_RemoveItems_IsValid = Set_RemoveItems_FunctionAddress != IntPtr.Zero && Set_RemoveItems_TargetSet_IsValid && Set_RemoveItems_Items_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintSetLibrary:Set_RemoveItems", Set_RemoveItems_IsValid);
		Set_Remove_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Set_Remove");
		Set_Remove_ParamsSize = NativeReflection.GetFunctionParamsSize(Set_Remove_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Set_Remove_TargetSet_PropertyAddress, Set_Remove_FunctionAddress, "TargetSet");
		Set_Remove_TargetSet_Offset = NativeReflectionCached.GetPropertyOffset(Set_Remove_FunctionAddress, "TargetSet");
		Set_Remove_TargetSet_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_Remove_FunctionAddress, "TargetSet", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref Set_Remove_Item_PropertyAddress, Set_Remove_FunctionAddress, "Item");
		Set_Remove_Item_Offset = NativeReflectionCached.GetPropertyOffset(Set_Remove_FunctionAddress, "Item");
		Set_Remove_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_Remove_FunctionAddress, "Item", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Set_Remove_ReturnValue_PropertyAddress, Set_Remove_FunctionAddress, "ReturnValue");
		Set_Remove_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Set_Remove_FunctionAddress, "ReturnValue");
		Set_Remove_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_Remove_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Set_Remove_IsValid = Set_Remove_FunctionAddress != IntPtr.Zero && Set_Remove_TargetSet_IsValid && Set_Remove_Item_IsValid && Set_Remove_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintSetLibrary:Set_Remove", Set_Remove_IsValid);
		Set_Length_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Set_Length");
		Set_Length_ParamsSize = NativeReflection.GetFunctionParamsSize(Set_Length_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Set_Length_TargetSet_PropertyAddress, Set_Length_FunctionAddress, "TargetSet");
		Set_Length_TargetSet_Offset = NativeReflectionCached.GetPropertyOffset(Set_Length_FunctionAddress, "TargetSet");
		Set_Length_TargetSet_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_Length_FunctionAddress, "TargetSet", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref Set_Length_ReturnValue_PropertyAddress, Set_Length_FunctionAddress, "ReturnValue");
		Set_Length_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Set_Length_FunctionAddress, "ReturnValue");
		Set_Length_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_Length_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		Set_Length_IsValid = Set_Length_FunctionAddress != IntPtr.Zero && Set_Length_TargetSet_IsValid && Set_Length_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintSetLibrary:Set_Length", Set_Length_IsValid);
		Set_IsNotEmpty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Set_IsNotEmpty");
		Set_IsNotEmpty_ParamsSize = NativeReflection.GetFunctionParamsSize(Set_IsNotEmpty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Set_IsNotEmpty_TargetSet_PropertyAddress, Set_IsNotEmpty_FunctionAddress, "TargetSet");
		Set_IsNotEmpty_TargetSet_Offset = NativeReflectionCached.GetPropertyOffset(Set_IsNotEmpty_FunctionAddress, "TargetSet");
		Set_IsNotEmpty_TargetSet_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_IsNotEmpty_FunctionAddress, "TargetSet", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref Set_IsNotEmpty_ReturnValue_PropertyAddress, Set_IsNotEmpty_FunctionAddress, "ReturnValue");
		Set_IsNotEmpty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Set_IsNotEmpty_FunctionAddress, "ReturnValue");
		Set_IsNotEmpty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_IsNotEmpty_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Set_IsNotEmpty_IsValid = Set_IsNotEmpty_FunctionAddress != IntPtr.Zero && Set_IsNotEmpty_TargetSet_IsValid && Set_IsNotEmpty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintSetLibrary:Set_IsNotEmpty", Set_IsNotEmpty_IsValid);
		Set_IsEmpty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Set_IsEmpty");
		Set_IsEmpty_ParamsSize = NativeReflection.GetFunctionParamsSize(Set_IsEmpty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Set_IsEmpty_TargetSet_PropertyAddress, Set_IsEmpty_FunctionAddress, "TargetSet");
		Set_IsEmpty_TargetSet_Offset = NativeReflectionCached.GetPropertyOffset(Set_IsEmpty_FunctionAddress, "TargetSet");
		Set_IsEmpty_TargetSet_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_IsEmpty_FunctionAddress, "TargetSet", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref Set_IsEmpty_ReturnValue_PropertyAddress, Set_IsEmpty_FunctionAddress, "ReturnValue");
		Set_IsEmpty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Set_IsEmpty_FunctionAddress, "ReturnValue");
		Set_IsEmpty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_IsEmpty_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Set_IsEmpty_IsValid = Set_IsEmpty_FunctionAddress != IntPtr.Zero && Set_IsEmpty_TargetSet_IsValid && Set_IsEmpty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintSetLibrary:Set_IsEmpty", Set_IsEmpty_IsValid);
		Set_Intersection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Set_Intersection");
		Set_Intersection_ParamsSize = NativeReflection.GetFunctionParamsSize(Set_Intersection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Set_Intersection_A_PropertyAddress, Set_Intersection_FunctionAddress, "A");
		Set_Intersection_A_Offset = NativeReflectionCached.GetPropertyOffset(Set_Intersection_FunctionAddress, "A");
		Set_Intersection_A_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_Intersection_FunctionAddress, "A", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref Set_Intersection_B_PropertyAddress, Set_Intersection_FunctionAddress, "B");
		Set_Intersection_B_Offset = NativeReflectionCached.GetPropertyOffset(Set_Intersection_FunctionAddress, "B");
		Set_Intersection_B_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_Intersection_FunctionAddress, "B", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref Set_Intersection_Result_PropertyAddress, Set_Intersection_FunctionAddress, "Result");
		Set_Intersection_Result_Offset = NativeReflectionCached.GetPropertyOffset(Set_Intersection_FunctionAddress, "Result");
		Set_Intersection_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_Intersection_FunctionAddress, "Result", Classes.FSetProperty);
		Set_Intersection_IsValid = Set_Intersection_FunctionAddress != IntPtr.Zero && Set_Intersection_A_IsValid && Set_Intersection_B_IsValid && Set_Intersection_Result_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintSetLibrary:Set_Intersection", Set_Intersection_IsValid);
		Set_Difference_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Set_Difference");
		Set_Difference_ParamsSize = NativeReflection.GetFunctionParamsSize(Set_Difference_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Set_Difference_A_PropertyAddress, Set_Difference_FunctionAddress, "A");
		Set_Difference_A_Offset = NativeReflectionCached.GetPropertyOffset(Set_Difference_FunctionAddress, "A");
		Set_Difference_A_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_Difference_FunctionAddress, "A", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref Set_Difference_B_PropertyAddress, Set_Difference_FunctionAddress, "B");
		Set_Difference_B_Offset = NativeReflectionCached.GetPropertyOffset(Set_Difference_FunctionAddress, "B");
		Set_Difference_B_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_Difference_FunctionAddress, "B", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref Set_Difference_Result_PropertyAddress, Set_Difference_FunctionAddress, "Result");
		Set_Difference_Result_Offset = NativeReflectionCached.GetPropertyOffset(Set_Difference_FunctionAddress, "Result");
		Set_Difference_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_Difference_FunctionAddress, "Result", Classes.FSetProperty);
		Set_Difference_IsValid = Set_Difference_FunctionAddress != IntPtr.Zero && Set_Difference_A_IsValid && Set_Difference_B_IsValid && Set_Difference_Result_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintSetLibrary:Set_Difference", Set_Difference_IsValid);
		Set_Contains_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Set_Contains");
		Set_Contains_ParamsSize = NativeReflection.GetFunctionParamsSize(Set_Contains_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Set_Contains_TargetSet_PropertyAddress, Set_Contains_FunctionAddress, "TargetSet");
		Set_Contains_TargetSet_Offset = NativeReflectionCached.GetPropertyOffset(Set_Contains_FunctionAddress, "TargetSet");
		Set_Contains_TargetSet_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_Contains_FunctionAddress, "TargetSet", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref Set_Contains_ItemToFind_PropertyAddress, Set_Contains_FunctionAddress, "ItemToFind");
		Set_Contains_ItemToFind_Offset = NativeReflectionCached.GetPropertyOffset(Set_Contains_FunctionAddress, "ItemToFind");
		Set_Contains_ItemToFind_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_Contains_FunctionAddress, "ItemToFind", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Set_Contains_ReturnValue_PropertyAddress, Set_Contains_FunctionAddress, "ReturnValue");
		Set_Contains_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Set_Contains_FunctionAddress, "ReturnValue");
		Set_Contains_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_Contains_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Set_Contains_IsValid = Set_Contains_FunctionAddress != IntPtr.Zero && Set_Contains_TargetSet_IsValid && Set_Contains_ItemToFind_IsValid && Set_Contains_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintSetLibrary:Set_Contains", Set_Contains_IsValid);
		Set_Clear_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Set_Clear");
		Set_Clear_ParamsSize = NativeReflection.GetFunctionParamsSize(Set_Clear_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Set_Clear_TargetSet_PropertyAddress, Set_Clear_FunctionAddress, "TargetSet");
		Set_Clear_TargetSet_Offset = NativeReflectionCached.GetPropertyOffset(Set_Clear_FunctionAddress, "TargetSet");
		Set_Clear_TargetSet_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_Clear_FunctionAddress, "TargetSet", Classes.FSetProperty);
		Set_Clear_IsValid = Set_Clear_FunctionAddress != IntPtr.Zero && Set_Clear_TargetSet_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintSetLibrary:Set_Clear", Set_Clear_IsValid);
		Set_AddItems_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Set_AddItems");
		Set_AddItems_ParamsSize = NativeReflection.GetFunctionParamsSize(Set_AddItems_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Set_AddItems_TargetSet_PropertyAddress, Set_AddItems_FunctionAddress, "TargetSet");
		Set_AddItems_TargetSet_Offset = NativeReflectionCached.GetPropertyOffset(Set_AddItems_FunctionAddress, "TargetSet");
		Set_AddItems_TargetSet_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_AddItems_FunctionAddress, "TargetSet", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref Set_AddItems_NewItems_PropertyAddress, Set_AddItems_FunctionAddress, "NewItems");
		Set_AddItems_NewItems_Offset = NativeReflectionCached.GetPropertyOffset(Set_AddItems_FunctionAddress, "NewItems");
		Set_AddItems_NewItems_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_AddItems_FunctionAddress, "NewItems", Classes.FArrayProperty);
		Set_AddItems_IsValid = Set_AddItems_FunctionAddress != IntPtr.Zero && Set_AddItems_TargetSet_IsValid && Set_AddItems_NewItems_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintSetLibrary:Set_AddItems", Set_AddItems_IsValid);
		Set_Add_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Set_Add");
		Set_Add_ParamsSize = NativeReflection.GetFunctionParamsSize(Set_Add_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Set_Add_TargetSet_PropertyAddress, Set_Add_FunctionAddress, "TargetSet");
		Set_Add_TargetSet_Offset = NativeReflectionCached.GetPropertyOffset(Set_Add_FunctionAddress, "TargetSet");
		Set_Add_TargetSet_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_Add_FunctionAddress, "TargetSet", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref Set_Add_NewItem_PropertyAddress, Set_Add_FunctionAddress, "NewItem");
		Set_Add_NewItem_Offset = NativeReflectionCached.GetPropertyOffset(Set_Add_FunctionAddress, "NewItem");
		Set_Add_NewItem_IsValid = NativeReflectionCached.ValidatePropertyClass(Set_Add_FunctionAddress, "NewItem", Classes.FIntProperty);
		Set_Add_IsValid = Set_Add_FunctionAddress != IntPtr.Zero && Set_Add_TargetSet_IsValid && Set_Add_NewItem_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintSetLibrary:Set_Add", Set_Add_IsValid);
	}
}
