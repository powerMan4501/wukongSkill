using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.KismetArrayLibrary", "Engine", UnrealModuleType.Engine)]
public class UKismetArrayLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool FilterArray_IsValid;

	private static IntPtr FilterArray_FunctionAddress;

	private static int FilterArray_ParamsSize;

	private static bool FilterArray_TargetArray_IsValid;

	private static FFieldAddress FilterArray_TargetArray_PropertyAddress;

	private static int FilterArray_TargetArray_Offset;

	private static bool FilterArray_FilterClass_IsValid;

	private static FFieldAddress FilterArray_FilterClass_PropertyAddress;

	private static int FilterArray_FilterClass_Offset;

	private static bool FilterArray_FilteredArray_IsValid;

	private static FFieldAddress FilterArray_FilteredArray_PropertyAddress;

	private static int FilterArray_FilteredArray_Offset;

	private static bool Array_Swap_IsValid;

	private static IntPtr Array_Swap_FunctionAddress;

	private static int Array_Swap_ParamsSize;

	private static bool Array_Swap_TargetArray_IsValid;

	private static FFieldAddress Array_Swap_TargetArray_PropertyAddress;

	private static int Array_Swap_TargetArray_Offset;

	private static bool Array_Swap_FirstIndex_IsValid;

	private static FFieldAddress Array_Swap_FirstIndex_PropertyAddress;

	private static int Array_Swap_FirstIndex_Offset;

	private static bool Array_Swap_SecondIndex_IsValid;

	private static FFieldAddress Array_Swap_SecondIndex_PropertyAddress;

	private static int Array_Swap_SecondIndex_Offset;

	private static bool Array_Shuffle_IsValid;

	private static IntPtr Array_Shuffle_FunctionAddress;

	private static int Array_Shuffle_ParamsSize;

	private static bool Array_Shuffle_TargetArray_IsValid;

	private static FFieldAddress Array_Shuffle_TargetArray_PropertyAddress;

	private static int Array_Shuffle_TargetArray_Offset;

	private static bool Array_Reverse_IsValid;

	private static IntPtr Array_Reverse_FunctionAddress;

	private static int Array_Reverse_ParamsSize;

	private static bool Array_Reverse_TargetArray_IsValid;

	private static FFieldAddress Array_Reverse_TargetArray_PropertyAddress;

	private static int Array_Reverse_TargetArray_Offset;

	private static bool Array_Resize_IsValid;

	private static IntPtr Array_Resize_FunctionAddress;

	private static int Array_Resize_ParamsSize;

	private static bool Array_Resize_TargetArray_IsValid;

	private static FFieldAddress Array_Resize_TargetArray_PropertyAddress;

	private static int Array_Resize_TargetArray_Offset;

	private static bool Array_Resize_Size_IsValid;

	private static FFieldAddress Array_Resize_Size_PropertyAddress;

	private static int Array_Resize_Size_Offset;

	private static bool Array_Remove_IsValid;

	private static IntPtr Array_Remove_FunctionAddress;

	private static int Array_Remove_ParamsSize;

	private static bool Array_Remove_TargetArray_IsValid;

	private static FFieldAddress Array_Remove_TargetArray_PropertyAddress;

	private static int Array_Remove_TargetArray_Offset;

	private static bool Array_Remove_IndexToRemove_IsValid;

	private static FFieldAddress Array_Remove_IndexToRemove_PropertyAddress;

	private static int Array_Remove_IndexToRemove_Offset;

	private static bool Array_Length_IsValid;

	private static IntPtr Array_Length_FunctionAddress;

	private static int Array_Length_ParamsSize;

	private static bool Array_Length_TargetArray_IsValid;

	private static FFieldAddress Array_Length_TargetArray_PropertyAddress;

	private static int Array_Length_TargetArray_Offset;

	private static bool Array_Length_ReturnValue_IsValid;

	private static FFieldAddress Array_Length_ReturnValue_PropertyAddress;

	private static int Array_Length_ReturnValue_Offset;

	private static bool Array_LastIndex_IsValid;

	private static IntPtr Array_LastIndex_FunctionAddress;

	private static int Array_LastIndex_ParamsSize;

	private static bool Array_LastIndex_TargetArray_IsValid;

	private static FFieldAddress Array_LastIndex_TargetArray_PropertyAddress;

	private static int Array_LastIndex_TargetArray_Offset;

	private static bool Array_LastIndex_ReturnValue_IsValid;

	private static FFieldAddress Array_LastIndex_ReturnValue_PropertyAddress;

	private static int Array_LastIndex_ReturnValue_Offset;

	private static bool Array_IsValidIndex_IsValid;

	private static IntPtr Array_IsValidIndex_FunctionAddress;

	private static int Array_IsValidIndex_ParamsSize;

	private static bool Array_IsValidIndex_TargetArray_IsValid;

	private static FFieldAddress Array_IsValidIndex_TargetArray_PropertyAddress;

	private static int Array_IsValidIndex_TargetArray_Offset;

	private static bool Array_IsValidIndex_IndexToTest_IsValid;

	private static FFieldAddress Array_IsValidIndex_IndexToTest_PropertyAddress;

	private static int Array_IsValidIndex_IndexToTest_Offset;

	private static bool Array_IsValidIndex_ReturnValue_IsValid;

	private static FFieldAddress Array_IsValidIndex_ReturnValue_PropertyAddress;

	private static int Array_IsValidIndex_ReturnValue_Offset;

	private static bool Array_IsNotEmpty_IsValid;

	private static IntPtr Array_IsNotEmpty_FunctionAddress;

	private static int Array_IsNotEmpty_ParamsSize;

	private static bool Array_IsNotEmpty_TargetArray_IsValid;

	private static FFieldAddress Array_IsNotEmpty_TargetArray_PropertyAddress;

	private static int Array_IsNotEmpty_TargetArray_Offset;

	private static bool Array_IsNotEmpty_ReturnValue_IsValid;

	private static FFieldAddress Array_IsNotEmpty_ReturnValue_PropertyAddress;

	private static int Array_IsNotEmpty_ReturnValue_Offset;

	private static bool Array_IsEmpty_IsValid;

	private static IntPtr Array_IsEmpty_FunctionAddress;

	private static int Array_IsEmpty_ParamsSize;

	private static bool Array_IsEmpty_TargetArray_IsValid;

	private static FFieldAddress Array_IsEmpty_TargetArray_PropertyAddress;

	private static int Array_IsEmpty_TargetArray_Offset;

	private static bool Array_IsEmpty_ReturnValue_IsValid;

	private static FFieldAddress Array_IsEmpty_ReturnValue_PropertyAddress;

	private static int Array_IsEmpty_ReturnValue_Offset;

	private static bool Array_Clear_IsValid;

	private static IntPtr Array_Clear_FunctionAddress;

	private static int Array_Clear_ParamsSize;

	private static bool Array_Clear_TargetArray_IsValid;

	private static FFieldAddress Array_Clear_TargetArray_PropertyAddress;

	private static int Array_Clear_TargetArray_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.KismetArrayLibrary:FilterArray")]
	public unsafe static void FilterArray(List<AActor> TargetArray, TSubclassOf<AActor> FilterClass, out List<AActor> FilteredArray)
	{
		if (!FilterArray_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetArrayLibrary:FilterArray");
			FilteredArray = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FilterArray_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FilterArray_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, FilterArray_TargetArray_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, FilterArray_TargetArray_Offset), TargetArray);
		TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, FilterArray_FilterClass_Offset), 0, FilterArray_FilterClass_PropertyAddress.Address, FilterClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FilterArray_FunctionAddress, intPtr, FilterArray_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FilterArray_TargetArray_PropertyAddress.Address, intPtr);
		FilteredArray = new TArrayCopyMarshaler<AActor>(1, FilterArray_FilteredArray_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, FilterArray_FilteredArray_Offset));
		NativeReflection.DestroyValue_InContainer(FilterArray_FilteredArray_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.KismetArrayLibrary:Array_Swap")]
	public unsafe static void Array_Swap(List<int> TargetArray, int FirstIndex, int SecondIndex)
	{
		if (!Array_Swap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetArrayLibrary:Array_Swap");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Array_Swap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Array_Swap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<int>(1, Array_Swap_TargetArray_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Array_Swap_TargetArray_Offset), TargetArray);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Array_Swap_FirstIndex_Offset), 0, Array_Swap_FirstIndex_PropertyAddress.Address, FirstIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Array_Swap_SecondIndex_Offset), 0, Array_Swap_SecondIndex_PropertyAddress.Address, SecondIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Array_Swap_FunctionAddress, intPtr, Array_Swap_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Array_Swap_TargetArray_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.KismetArrayLibrary:Array_Shuffle")]
	public unsafe static void Array_Shuffle(List<int> TargetArray)
	{
		if (!Array_Shuffle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetArrayLibrary:Array_Shuffle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Array_Shuffle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Array_Shuffle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<int>(1, Array_Shuffle_TargetArray_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Array_Shuffle_TargetArray_Offset), TargetArray);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Array_Shuffle_FunctionAddress, intPtr, Array_Shuffle_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Array_Shuffle_TargetArray_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.KismetArrayLibrary:Array_Reverse")]
	public unsafe static void Array_Reverse(List<int> TargetArray)
	{
		if (!Array_Reverse_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetArrayLibrary:Array_Reverse");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Array_Reverse_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Array_Reverse_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<int>(1, Array_Reverse_TargetArray_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Array_Reverse_TargetArray_Offset), TargetArray);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Array_Reverse_FunctionAddress, intPtr, Array_Reverse_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Array_Reverse_TargetArray_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.KismetArrayLibrary:Array_Resize")]
	public unsafe static void Array_Resize(List<int> TargetArray, int Size)
	{
		if (!Array_Resize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetArrayLibrary:Array_Resize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Array_Resize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Array_Resize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<int>(1, Array_Resize_TargetArray_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Array_Resize_TargetArray_Offset), TargetArray);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Array_Resize_Size_Offset), 0, Array_Resize_Size_PropertyAddress.Address, Size);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Array_Resize_FunctionAddress, intPtr, Array_Resize_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Array_Resize_TargetArray_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.KismetArrayLibrary:Array_Remove")]
	public unsafe static void Array_Remove(List<int> TargetArray, int IndexToRemove)
	{
		if (!Array_Remove_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetArrayLibrary:Array_Remove");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Array_Remove_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Array_Remove_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<int>(1, Array_Remove_TargetArray_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Array_Remove_TargetArray_Offset), TargetArray);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Array_Remove_IndexToRemove_Offset), 0, Array_Remove_IndexToRemove_PropertyAddress.Address, IndexToRemove);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Array_Remove_FunctionAddress, intPtr, Array_Remove_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Array_Remove_TargetArray_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetArrayLibrary:Array_Length")]
	public unsafe static int Array_Length(List<int> TargetArray)
	{
		if (!Array_Length_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetArrayLibrary:Array_Length");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Array_Length_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Array_Length_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<int>(1, Array_Length_TargetArray_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Array_Length_TargetArray_Offset), TargetArray);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Array_Length_FunctionAddress, intPtr, Array_Length_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Array_Length_TargetArray_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, Array_Length_ReturnValue_Offset), 0, Array_Length_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetArrayLibrary:Array_LastIndex")]
	public unsafe static int Array_LastIndex(List<int> TargetArray)
	{
		if (!Array_LastIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetArrayLibrary:Array_LastIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Array_LastIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Array_LastIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<int>(1, Array_LastIndex_TargetArray_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Array_LastIndex_TargetArray_Offset), TargetArray);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Array_LastIndex_FunctionAddress, intPtr, Array_LastIndex_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Array_LastIndex_TargetArray_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, Array_LastIndex_ReturnValue_Offset), 0, Array_LastIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetArrayLibrary:Array_IsValidIndex")]
	public unsafe static bool Array_IsValidIndex(List<int> TargetArray, int IndexToTest)
	{
		if (!Array_IsValidIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetArrayLibrary:Array_IsValidIndex");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Array_IsValidIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Array_IsValidIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<int>(1, Array_IsValidIndex_TargetArray_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Array_IsValidIndex_TargetArray_Offset), TargetArray);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Array_IsValidIndex_IndexToTest_Offset), 0, Array_IsValidIndex_IndexToTest_PropertyAddress.Address, IndexToTest);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Array_IsValidIndex_FunctionAddress, intPtr, Array_IsValidIndex_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Array_IsValidIndex_TargetArray_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Array_IsValidIndex_ReturnValue_Offset), 0, Array_IsValidIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetArrayLibrary:Array_IsNotEmpty")]
	public unsafe static bool Array_IsNotEmpty(List<int> TargetArray)
	{
		if (!Array_IsNotEmpty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetArrayLibrary:Array_IsNotEmpty");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Array_IsNotEmpty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Array_IsNotEmpty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<int>(1, Array_IsNotEmpty_TargetArray_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Array_IsNotEmpty_TargetArray_Offset), TargetArray);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Array_IsNotEmpty_FunctionAddress, intPtr, Array_IsNotEmpty_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Array_IsNotEmpty_TargetArray_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Array_IsNotEmpty_ReturnValue_Offset), 0, Array_IsNotEmpty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetArrayLibrary:Array_IsEmpty")]
	public unsafe static bool Array_IsEmpty(List<int> TargetArray)
	{
		if (!Array_IsEmpty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetArrayLibrary:Array_IsEmpty");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Array_IsEmpty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Array_IsEmpty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<int>(1, Array_IsEmpty_TargetArray_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Array_IsEmpty_TargetArray_Offset), TargetArray);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Array_IsEmpty_FunctionAddress, intPtr, Array_IsEmpty_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Array_IsEmpty_TargetArray_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Array_IsEmpty_ReturnValue_Offset), 0, Array_IsEmpty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.KismetArrayLibrary:Array_Clear")]
	public unsafe static void Array_Clear(List<int> TargetArray)
	{
		if (!Array_Clear_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetArrayLibrary:Array_Clear");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Array_Clear_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Array_Clear_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<int>(1, Array_Clear_TargetArray_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Array_Clear_TargetArray_Offset), TargetArray);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Array_Clear_FunctionAddress, intPtr, Array_Clear_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Array_Clear_TargetArray_PropertyAddress.Address, intPtr);
	}

	static UKismetArrayLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UKismetArrayLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UKismetArrayLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.KismetArrayLibrary");
		FilterArray_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FilterArray");
		FilterArray_ParamsSize = NativeReflection.GetFunctionParamsSize(FilterArray_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FilterArray_TargetArray_PropertyAddress, FilterArray_FunctionAddress, "TargetArray");
		FilterArray_TargetArray_Offset = NativeReflectionCached.GetPropertyOffset(FilterArray_FunctionAddress, "TargetArray");
		FilterArray_TargetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterArray_FunctionAddress, "TargetArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterArray_FilterClass_PropertyAddress, FilterArray_FunctionAddress, "FilterClass");
		FilterArray_FilterClass_Offset = NativeReflectionCached.GetPropertyOffset(FilterArray_FunctionAddress, "FilterClass");
		FilterArray_FilterClass_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterArray_FunctionAddress, "FilterClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterArray_FilteredArray_PropertyAddress, FilterArray_FunctionAddress, "FilteredArray");
		FilterArray_FilteredArray_Offset = NativeReflectionCached.GetPropertyOffset(FilterArray_FunctionAddress, "FilteredArray");
		FilterArray_FilteredArray_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterArray_FunctionAddress, "FilteredArray", Classes.FArrayProperty);
		FilterArray_IsValid = FilterArray_FunctionAddress != IntPtr.Zero && FilterArray_TargetArray_IsValid && FilterArray_FilterClass_IsValid && FilterArray_FilteredArray_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetArrayLibrary:FilterArray", FilterArray_IsValid);
		Array_Swap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Array_Swap");
		Array_Swap_ParamsSize = NativeReflection.GetFunctionParamsSize(Array_Swap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Array_Swap_TargetArray_PropertyAddress, Array_Swap_FunctionAddress, "TargetArray");
		Array_Swap_TargetArray_Offset = NativeReflectionCached.GetPropertyOffset(Array_Swap_FunctionAddress, "TargetArray");
		Array_Swap_TargetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(Array_Swap_FunctionAddress, "TargetArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Array_Swap_FirstIndex_PropertyAddress, Array_Swap_FunctionAddress, "FirstIndex");
		Array_Swap_FirstIndex_Offset = NativeReflectionCached.GetPropertyOffset(Array_Swap_FunctionAddress, "FirstIndex");
		Array_Swap_FirstIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(Array_Swap_FunctionAddress, "FirstIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Array_Swap_SecondIndex_PropertyAddress, Array_Swap_FunctionAddress, "SecondIndex");
		Array_Swap_SecondIndex_Offset = NativeReflectionCached.GetPropertyOffset(Array_Swap_FunctionAddress, "SecondIndex");
		Array_Swap_SecondIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(Array_Swap_FunctionAddress, "SecondIndex", Classes.FIntProperty);
		Array_Swap_IsValid = Array_Swap_FunctionAddress != IntPtr.Zero && Array_Swap_TargetArray_IsValid && Array_Swap_FirstIndex_IsValid && Array_Swap_SecondIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetArrayLibrary:Array_Swap", Array_Swap_IsValid);
		Array_Shuffle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Array_Shuffle");
		Array_Shuffle_ParamsSize = NativeReflection.GetFunctionParamsSize(Array_Shuffle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Array_Shuffle_TargetArray_PropertyAddress, Array_Shuffle_FunctionAddress, "TargetArray");
		Array_Shuffle_TargetArray_Offset = NativeReflectionCached.GetPropertyOffset(Array_Shuffle_FunctionAddress, "TargetArray");
		Array_Shuffle_TargetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(Array_Shuffle_FunctionAddress, "TargetArray", Classes.FArrayProperty);
		Array_Shuffle_IsValid = Array_Shuffle_FunctionAddress != IntPtr.Zero && Array_Shuffle_TargetArray_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetArrayLibrary:Array_Shuffle", Array_Shuffle_IsValid);
		Array_Reverse_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Array_Reverse");
		Array_Reverse_ParamsSize = NativeReflection.GetFunctionParamsSize(Array_Reverse_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Array_Reverse_TargetArray_PropertyAddress, Array_Reverse_FunctionAddress, "TargetArray");
		Array_Reverse_TargetArray_Offset = NativeReflectionCached.GetPropertyOffset(Array_Reverse_FunctionAddress, "TargetArray");
		Array_Reverse_TargetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(Array_Reverse_FunctionAddress, "TargetArray", Classes.FArrayProperty);
		Array_Reverse_IsValid = Array_Reverse_FunctionAddress != IntPtr.Zero && Array_Reverse_TargetArray_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetArrayLibrary:Array_Reverse", Array_Reverse_IsValid);
		Array_Resize_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Array_Resize");
		Array_Resize_ParamsSize = NativeReflection.GetFunctionParamsSize(Array_Resize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Array_Resize_TargetArray_PropertyAddress, Array_Resize_FunctionAddress, "TargetArray");
		Array_Resize_TargetArray_Offset = NativeReflectionCached.GetPropertyOffset(Array_Resize_FunctionAddress, "TargetArray");
		Array_Resize_TargetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(Array_Resize_FunctionAddress, "TargetArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Array_Resize_Size_PropertyAddress, Array_Resize_FunctionAddress, "Size");
		Array_Resize_Size_Offset = NativeReflectionCached.GetPropertyOffset(Array_Resize_FunctionAddress, "Size");
		Array_Resize_Size_IsValid = NativeReflectionCached.ValidatePropertyClass(Array_Resize_FunctionAddress, "Size", Classes.FIntProperty);
		Array_Resize_IsValid = Array_Resize_FunctionAddress != IntPtr.Zero && Array_Resize_TargetArray_IsValid && Array_Resize_Size_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetArrayLibrary:Array_Resize", Array_Resize_IsValid);
		Array_Remove_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Array_Remove");
		Array_Remove_ParamsSize = NativeReflection.GetFunctionParamsSize(Array_Remove_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Array_Remove_TargetArray_PropertyAddress, Array_Remove_FunctionAddress, "TargetArray");
		Array_Remove_TargetArray_Offset = NativeReflectionCached.GetPropertyOffset(Array_Remove_FunctionAddress, "TargetArray");
		Array_Remove_TargetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(Array_Remove_FunctionAddress, "TargetArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Array_Remove_IndexToRemove_PropertyAddress, Array_Remove_FunctionAddress, "IndexToRemove");
		Array_Remove_IndexToRemove_Offset = NativeReflectionCached.GetPropertyOffset(Array_Remove_FunctionAddress, "IndexToRemove");
		Array_Remove_IndexToRemove_IsValid = NativeReflectionCached.ValidatePropertyClass(Array_Remove_FunctionAddress, "IndexToRemove", Classes.FIntProperty);
		Array_Remove_IsValid = Array_Remove_FunctionAddress != IntPtr.Zero && Array_Remove_TargetArray_IsValid && Array_Remove_IndexToRemove_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetArrayLibrary:Array_Remove", Array_Remove_IsValid);
		Array_Length_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Array_Length");
		Array_Length_ParamsSize = NativeReflection.GetFunctionParamsSize(Array_Length_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Array_Length_TargetArray_PropertyAddress, Array_Length_FunctionAddress, "TargetArray");
		Array_Length_TargetArray_Offset = NativeReflectionCached.GetPropertyOffset(Array_Length_FunctionAddress, "TargetArray");
		Array_Length_TargetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(Array_Length_FunctionAddress, "TargetArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Array_Length_ReturnValue_PropertyAddress, Array_Length_FunctionAddress, "ReturnValue");
		Array_Length_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Array_Length_FunctionAddress, "ReturnValue");
		Array_Length_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Array_Length_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		Array_Length_IsValid = Array_Length_FunctionAddress != IntPtr.Zero && Array_Length_TargetArray_IsValid && Array_Length_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetArrayLibrary:Array_Length", Array_Length_IsValid);
		Array_LastIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Array_LastIndex");
		Array_LastIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(Array_LastIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Array_LastIndex_TargetArray_PropertyAddress, Array_LastIndex_FunctionAddress, "TargetArray");
		Array_LastIndex_TargetArray_Offset = NativeReflectionCached.GetPropertyOffset(Array_LastIndex_FunctionAddress, "TargetArray");
		Array_LastIndex_TargetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(Array_LastIndex_FunctionAddress, "TargetArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Array_LastIndex_ReturnValue_PropertyAddress, Array_LastIndex_FunctionAddress, "ReturnValue");
		Array_LastIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Array_LastIndex_FunctionAddress, "ReturnValue");
		Array_LastIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Array_LastIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		Array_LastIndex_IsValid = Array_LastIndex_FunctionAddress != IntPtr.Zero && Array_LastIndex_TargetArray_IsValid && Array_LastIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetArrayLibrary:Array_LastIndex", Array_LastIndex_IsValid);
		Array_IsValidIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Array_IsValidIndex");
		Array_IsValidIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(Array_IsValidIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Array_IsValidIndex_TargetArray_PropertyAddress, Array_IsValidIndex_FunctionAddress, "TargetArray");
		Array_IsValidIndex_TargetArray_Offset = NativeReflectionCached.GetPropertyOffset(Array_IsValidIndex_FunctionAddress, "TargetArray");
		Array_IsValidIndex_TargetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(Array_IsValidIndex_FunctionAddress, "TargetArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Array_IsValidIndex_IndexToTest_PropertyAddress, Array_IsValidIndex_FunctionAddress, "IndexToTest");
		Array_IsValidIndex_IndexToTest_Offset = NativeReflectionCached.GetPropertyOffset(Array_IsValidIndex_FunctionAddress, "IndexToTest");
		Array_IsValidIndex_IndexToTest_IsValid = NativeReflectionCached.ValidatePropertyClass(Array_IsValidIndex_FunctionAddress, "IndexToTest", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Array_IsValidIndex_ReturnValue_PropertyAddress, Array_IsValidIndex_FunctionAddress, "ReturnValue");
		Array_IsValidIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Array_IsValidIndex_FunctionAddress, "ReturnValue");
		Array_IsValidIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Array_IsValidIndex_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Array_IsValidIndex_IsValid = Array_IsValidIndex_FunctionAddress != IntPtr.Zero && Array_IsValidIndex_TargetArray_IsValid && Array_IsValidIndex_IndexToTest_IsValid && Array_IsValidIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetArrayLibrary:Array_IsValidIndex", Array_IsValidIndex_IsValid);
		Array_IsNotEmpty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Array_IsNotEmpty");
		Array_IsNotEmpty_ParamsSize = NativeReflection.GetFunctionParamsSize(Array_IsNotEmpty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Array_IsNotEmpty_TargetArray_PropertyAddress, Array_IsNotEmpty_FunctionAddress, "TargetArray");
		Array_IsNotEmpty_TargetArray_Offset = NativeReflectionCached.GetPropertyOffset(Array_IsNotEmpty_FunctionAddress, "TargetArray");
		Array_IsNotEmpty_TargetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(Array_IsNotEmpty_FunctionAddress, "TargetArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Array_IsNotEmpty_ReturnValue_PropertyAddress, Array_IsNotEmpty_FunctionAddress, "ReturnValue");
		Array_IsNotEmpty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Array_IsNotEmpty_FunctionAddress, "ReturnValue");
		Array_IsNotEmpty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Array_IsNotEmpty_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Array_IsNotEmpty_IsValid = Array_IsNotEmpty_FunctionAddress != IntPtr.Zero && Array_IsNotEmpty_TargetArray_IsValid && Array_IsNotEmpty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetArrayLibrary:Array_IsNotEmpty", Array_IsNotEmpty_IsValid);
		Array_IsEmpty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Array_IsEmpty");
		Array_IsEmpty_ParamsSize = NativeReflection.GetFunctionParamsSize(Array_IsEmpty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Array_IsEmpty_TargetArray_PropertyAddress, Array_IsEmpty_FunctionAddress, "TargetArray");
		Array_IsEmpty_TargetArray_Offset = NativeReflectionCached.GetPropertyOffset(Array_IsEmpty_FunctionAddress, "TargetArray");
		Array_IsEmpty_TargetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(Array_IsEmpty_FunctionAddress, "TargetArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Array_IsEmpty_ReturnValue_PropertyAddress, Array_IsEmpty_FunctionAddress, "ReturnValue");
		Array_IsEmpty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Array_IsEmpty_FunctionAddress, "ReturnValue");
		Array_IsEmpty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Array_IsEmpty_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Array_IsEmpty_IsValid = Array_IsEmpty_FunctionAddress != IntPtr.Zero && Array_IsEmpty_TargetArray_IsValid && Array_IsEmpty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetArrayLibrary:Array_IsEmpty", Array_IsEmpty_IsValid);
		Array_Clear_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Array_Clear");
		Array_Clear_ParamsSize = NativeReflection.GetFunctionParamsSize(Array_Clear_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Array_Clear_TargetArray_PropertyAddress, Array_Clear_FunctionAddress, "TargetArray");
		Array_Clear_TargetArray_Offset = NativeReflectionCached.GetPropertyOffset(Array_Clear_FunctionAddress, "TargetArray");
		Array_Clear_TargetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(Array_Clear_FunctionAddress, "TargetArray", Classes.FArrayProperty);
		Array_Clear_IsValid = Array_Clear_FunctionAddress != IntPtr.Zero && Array_Clear_TargetArray_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetArrayLibrary:Array_Clear", Array_Clear_IsValid);
	}
}
