using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.BlueprintMapLibrary", "Engine", UnrealModuleType.Engine)]
public class UBlueprintMapLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool Map_Values_IsValid;

	private static IntPtr Map_Values_FunctionAddress;

	private static int Map_Values_ParamsSize;

	private static bool Map_Values_TargetMap_IsValid;

	private static FFieldAddress Map_Values_TargetMap_PropertyAddress;

	private static int Map_Values_TargetMap_Offset;

	private static bool Map_Values_Values_IsValid;

	private static FFieldAddress Map_Values_Values_PropertyAddress;

	private static int Map_Values_Values_Offset;

	private static bool Map_Remove_IsValid;

	private static IntPtr Map_Remove_FunctionAddress;

	private static int Map_Remove_ParamsSize;

	private static bool Map_Remove_TargetMap_IsValid;

	private static FFieldAddress Map_Remove_TargetMap_PropertyAddress;

	private static int Map_Remove_TargetMap_Offset;

	private static bool Map_Remove_Key_IsValid;

	private static FFieldAddress Map_Remove_Key_PropertyAddress;

	private static int Map_Remove_Key_Offset;

	private static bool Map_Remove_ReturnValue_IsValid;

	private static FFieldAddress Map_Remove_ReturnValue_PropertyAddress;

	private static int Map_Remove_ReturnValue_Offset;

	private static bool Map_Length_IsValid;

	private static IntPtr Map_Length_FunctionAddress;

	private static int Map_Length_ParamsSize;

	private static bool Map_Length_TargetMap_IsValid;

	private static FFieldAddress Map_Length_TargetMap_PropertyAddress;

	private static int Map_Length_TargetMap_Offset;

	private static bool Map_Length_ReturnValue_IsValid;

	private static FFieldAddress Map_Length_ReturnValue_PropertyAddress;

	private static int Map_Length_ReturnValue_Offset;

	private static bool Map_Keys_IsValid;

	private static IntPtr Map_Keys_FunctionAddress;

	private static int Map_Keys_ParamsSize;

	private static bool Map_Keys_TargetMap_IsValid;

	private static FFieldAddress Map_Keys_TargetMap_PropertyAddress;

	private static int Map_Keys_TargetMap_Offset;

	private static bool Map_Keys_Keys_IsValid;

	private static FFieldAddress Map_Keys_Keys_PropertyAddress;

	private static int Map_Keys_Keys_Offset;

	private static bool Map_IsNotEmpty_IsValid;

	private static IntPtr Map_IsNotEmpty_FunctionAddress;

	private static int Map_IsNotEmpty_ParamsSize;

	private static bool Map_IsNotEmpty_TargetMap_IsValid;

	private static FFieldAddress Map_IsNotEmpty_TargetMap_PropertyAddress;

	private static int Map_IsNotEmpty_TargetMap_Offset;

	private static bool Map_IsNotEmpty_ReturnValue_IsValid;

	private static FFieldAddress Map_IsNotEmpty_ReturnValue_PropertyAddress;

	private static int Map_IsNotEmpty_ReturnValue_Offset;

	private static bool Map_IsEmpty_IsValid;

	private static IntPtr Map_IsEmpty_FunctionAddress;

	private static int Map_IsEmpty_ParamsSize;

	private static bool Map_IsEmpty_TargetMap_IsValid;

	private static FFieldAddress Map_IsEmpty_TargetMap_PropertyAddress;

	private static int Map_IsEmpty_TargetMap_Offset;

	private static bool Map_IsEmpty_ReturnValue_IsValid;

	private static FFieldAddress Map_IsEmpty_ReturnValue_PropertyAddress;

	private static int Map_IsEmpty_ReturnValue_Offset;

	private static bool Map_Find_IsValid;

	private static IntPtr Map_Find_FunctionAddress;

	private static int Map_Find_ParamsSize;

	private static bool Map_Find_TargetMap_IsValid;

	private static FFieldAddress Map_Find_TargetMap_PropertyAddress;

	private static int Map_Find_TargetMap_Offset;

	private static bool Map_Find_Key_IsValid;

	private static FFieldAddress Map_Find_Key_PropertyAddress;

	private static int Map_Find_Key_Offset;

	private static bool Map_Find_Value_IsValid;

	private static FFieldAddress Map_Find_Value_PropertyAddress;

	private static int Map_Find_Value_Offset;

	private static bool Map_Find_ReturnValue_IsValid;

	private static FFieldAddress Map_Find_ReturnValue_PropertyAddress;

	private static int Map_Find_ReturnValue_Offset;

	private static bool Map_Contains_IsValid;

	private static IntPtr Map_Contains_FunctionAddress;

	private static int Map_Contains_ParamsSize;

	private static bool Map_Contains_TargetMap_IsValid;

	private static FFieldAddress Map_Contains_TargetMap_PropertyAddress;

	private static int Map_Contains_TargetMap_Offset;

	private static bool Map_Contains_Key_IsValid;

	private static FFieldAddress Map_Contains_Key_PropertyAddress;

	private static int Map_Contains_Key_Offset;

	private static bool Map_Contains_ReturnValue_IsValid;

	private static FFieldAddress Map_Contains_ReturnValue_PropertyAddress;

	private static int Map_Contains_ReturnValue_Offset;

	private static bool Map_Clear_IsValid;

	private static IntPtr Map_Clear_FunctionAddress;

	private static int Map_Clear_ParamsSize;

	private static bool Map_Clear_TargetMap_IsValid;

	private static FFieldAddress Map_Clear_TargetMap_PropertyAddress;

	private static int Map_Clear_TargetMap_Offset;

	private static bool Map_Add_IsValid;

	private static IntPtr Map_Add_FunctionAddress;

	private static int Map_Add_ParamsSize;

	private static bool Map_Add_TargetMap_IsValid;

	private static FFieldAddress Map_Add_TargetMap_PropertyAddress;

	private static int Map_Add_TargetMap_Offset;

	private static bool Map_Add_Key_IsValid;

	private static FFieldAddress Map_Add_Key_PropertyAddress;

	private static int Map_Add_Key_Offset;

	private static bool Map_Add_Value_IsValid;

	private static FFieldAddress Map_Add_Value_PropertyAddress;

	private static int Map_Add_Value_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.BlueprintMapLibrary:Map_Values")]
	public unsafe static void Map_Values(Dictionary<int, int> TargetMap, ref List<int> Values)
	{
		if (!Map_Values_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintMapLibrary:Map_Values");
			Values = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Map_Values_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Map_Values_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Map_Values_TargetMap_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<int, int>(1, Map_Values_TargetMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Map_Values_TargetMap_Offset), TargetMap);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Map_Values_FunctionAddress, intPtr, Map_Values_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Map_Values_TargetMap_PropertyAddress.Address, intPtr);
		Values = new TArrayCopyMarshaler<int>(1, Map_Values_Values_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, Map_Values_Values_Offset));
		NativeReflection.DestroyValue_InContainer(Map_Values_Values_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.BlueprintMapLibrary:Map_Remove")]
	public unsafe static bool Map_Remove(Dictionary<int, int> TargetMap, int Key)
	{
		if (!Map_Remove_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintMapLibrary:Map_Remove");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Map_Remove_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Map_Remove_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Map_Remove_TargetMap_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<int, int>(1, Map_Remove_TargetMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Map_Remove_TargetMap_Offset), TargetMap);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Map_Remove_Key_Offset), 0, Map_Remove_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Map_Remove_FunctionAddress, intPtr, Map_Remove_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Map_Remove_TargetMap_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Map_Remove_ReturnValue_Offset), 0, Map_Remove_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.BlueprintMapLibrary:Map_Length")]
	public unsafe static int Map_Length(Dictionary<int, int> TargetMap)
	{
		if (!Map_Length_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintMapLibrary:Map_Length");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Map_Length_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Map_Length_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Map_Length_TargetMap_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<int, int>(1, Map_Length_TargetMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Map_Length_TargetMap_Offset), TargetMap);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Map_Length_FunctionAddress, intPtr, Map_Length_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Map_Length_TargetMap_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, Map_Length_ReturnValue_Offset), 0, Map_Length_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.BlueprintMapLibrary:Map_Keys")]
	public unsafe static void Map_Keys(Dictionary<int, int> TargetMap, ref List<int> Keys)
	{
		if (!Map_Keys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintMapLibrary:Map_Keys");
			Keys = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Map_Keys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Map_Keys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Map_Keys_TargetMap_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<int, int>(1, Map_Keys_TargetMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Map_Keys_TargetMap_Offset), TargetMap);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Map_Keys_FunctionAddress, intPtr, Map_Keys_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Map_Keys_TargetMap_PropertyAddress.Address, intPtr);
		Keys = new TArrayCopyMarshaler<int>(1, Map_Keys_Keys_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, Map_Keys_Keys_Offset));
		NativeReflection.DestroyValue_InContainer(Map_Keys_Keys_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.BlueprintMapLibrary:Map_IsNotEmpty")]
	public unsafe static bool Map_IsNotEmpty(Dictionary<int, int> TargetMap)
	{
		if (!Map_IsNotEmpty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintMapLibrary:Map_IsNotEmpty");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Map_IsNotEmpty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Map_IsNotEmpty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Map_IsNotEmpty_TargetMap_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<int, int>(1, Map_IsNotEmpty_TargetMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Map_IsNotEmpty_TargetMap_Offset), TargetMap);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Map_IsNotEmpty_FunctionAddress, intPtr, Map_IsNotEmpty_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Map_IsNotEmpty_TargetMap_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Map_IsNotEmpty_ReturnValue_Offset), 0, Map_IsNotEmpty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.BlueprintMapLibrary:Map_IsEmpty")]
	public unsafe static bool Map_IsEmpty(Dictionary<int, int> TargetMap)
	{
		if (!Map_IsEmpty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintMapLibrary:Map_IsEmpty");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Map_IsEmpty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Map_IsEmpty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Map_IsEmpty_TargetMap_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<int, int>(1, Map_IsEmpty_TargetMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Map_IsEmpty_TargetMap_Offset), TargetMap);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Map_IsEmpty_FunctionAddress, intPtr, Map_IsEmpty_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Map_IsEmpty_TargetMap_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Map_IsEmpty_ReturnValue_Offset), 0, Map_IsEmpty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.BlueprintMapLibrary:Map_Find")]
	public unsafe static bool Map_Find(Dictionary<int, int> TargetMap, int Key, ref int Value)
	{
		if (!Map_Find_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintMapLibrary:Map_Find");
			Value = 0;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Map_Find_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Map_Find_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Map_Find_TargetMap_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<int, int>(1, Map_Find_TargetMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Map_Find_TargetMap_Offset), TargetMap);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Map_Find_Key_Offset), 0, Map_Find_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Map_Find_FunctionAddress, intPtr, Map_Find_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Map_Find_TargetMap_PropertyAddress.Address, intPtr);
		Value = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, Map_Find_Value_Offset), 0, Map_Find_Value_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Map_Find_ReturnValue_Offset), 0, Map_Find_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.BlueprintMapLibrary:Map_Contains")]
	public unsafe static bool Map_Contains(Dictionary<int, int> TargetMap, int Key)
	{
		if (!Map_Contains_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintMapLibrary:Map_Contains");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Map_Contains_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Map_Contains_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Map_Contains_TargetMap_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<int, int>(1, Map_Contains_TargetMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Map_Contains_TargetMap_Offset), TargetMap);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Map_Contains_Key_Offset), 0, Map_Contains_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Map_Contains_FunctionAddress, intPtr, Map_Contains_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Map_Contains_TargetMap_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Map_Contains_ReturnValue_Offset), 0, Map_Contains_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.BlueprintMapLibrary:Map_Clear")]
	public unsafe static void Map_Clear(Dictionary<int, int> TargetMap)
	{
		if (!Map_Clear_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintMapLibrary:Map_Clear");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Map_Clear_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Map_Clear_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Map_Clear_TargetMap_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<int, int>(1, Map_Clear_TargetMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Map_Clear_TargetMap_Offset), TargetMap);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Map_Clear_FunctionAddress, intPtr, Map_Clear_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Map_Clear_TargetMap_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.BlueprintMapLibrary:Map_Add")]
	public unsafe static void Map_Add(Dictionary<int, int> TargetMap, int Key, int Value)
	{
		if (!Map_Add_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintMapLibrary:Map_Add");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Map_Add_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Map_Add_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Map_Add_TargetMap_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<int, int>(1, Map_Add_TargetMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, Map_Add_TargetMap_Offset), TargetMap);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Map_Add_Key_Offset), 0, Map_Add_Key_PropertyAddress.Address, Key);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Map_Add_Value_Offset), 0, Map_Add_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Map_Add_FunctionAddress, intPtr, Map_Add_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Map_Add_TargetMap_PropertyAddress.Address, intPtr);
	}

	static UBlueprintMapLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBlueprintMapLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBlueprintMapLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.BlueprintMapLibrary");
		Map_Values_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Map_Values");
		Map_Values_ParamsSize = NativeReflection.GetFunctionParamsSize(Map_Values_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Map_Values_TargetMap_PropertyAddress, Map_Values_FunctionAddress, "TargetMap");
		Map_Values_TargetMap_Offset = NativeReflectionCached.GetPropertyOffset(Map_Values_FunctionAddress, "TargetMap");
		Map_Values_TargetMap_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_Values_FunctionAddress, "TargetMap", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref Map_Values_Values_PropertyAddress, Map_Values_FunctionAddress, "Values");
		Map_Values_Values_Offset = NativeReflectionCached.GetPropertyOffset(Map_Values_FunctionAddress, "Values");
		Map_Values_Values_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_Values_FunctionAddress, "Values", Classes.FArrayProperty);
		Map_Values_IsValid = Map_Values_FunctionAddress != IntPtr.Zero && Map_Values_TargetMap_IsValid && Map_Values_Values_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintMapLibrary:Map_Values", Map_Values_IsValid);
		Map_Remove_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Map_Remove");
		Map_Remove_ParamsSize = NativeReflection.GetFunctionParamsSize(Map_Remove_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Map_Remove_TargetMap_PropertyAddress, Map_Remove_FunctionAddress, "TargetMap");
		Map_Remove_TargetMap_Offset = NativeReflectionCached.GetPropertyOffset(Map_Remove_FunctionAddress, "TargetMap");
		Map_Remove_TargetMap_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_Remove_FunctionAddress, "TargetMap", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref Map_Remove_Key_PropertyAddress, Map_Remove_FunctionAddress, "Key");
		Map_Remove_Key_Offset = NativeReflectionCached.GetPropertyOffset(Map_Remove_FunctionAddress, "Key");
		Map_Remove_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_Remove_FunctionAddress, "Key", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Map_Remove_ReturnValue_PropertyAddress, Map_Remove_FunctionAddress, "ReturnValue");
		Map_Remove_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Map_Remove_FunctionAddress, "ReturnValue");
		Map_Remove_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_Remove_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Map_Remove_IsValid = Map_Remove_FunctionAddress != IntPtr.Zero && Map_Remove_TargetMap_IsValid && Map_Remove_Key_IsValid && Map_Remove_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintMapLibrary:Map_Remove", Map_Remove_IsValid);
		Map_Length_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Map_Length");
		Map_Length_ParamsSize = NativeReflection.GetFunctionParamsSize(Map_Length_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Map_Length_TargetMap_PropertyAddress, Map_Length_FunctionAddress, "TargetMap");
		Map_Length_TargetMap_Offset = NativeReflectionCached.GetPropertyOffset(Map_Length_FunctionAddress, "TargetMap");
		Map_Length_TargetMap_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_Length_FunctionAddress, "TargetMap", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref Map_Length_ReturnValue_PropertyAddress, Map_Length_FunctionAddress, "ReturnValue");
		Map_Length_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Map_Length_FunctionAddress, "ReturnValue");
		Map_Length_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_Length_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		Map_Length_IsValid = Map_Length_FunctionAddress != IntPtr.Zero && Map_Length_TargetMap_IsValid && Map_Length_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintMapLibrary:Map_Length", Map_Length_IsValid);
		Map_Keys_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Map_Keys");
		Map_Keys_ParamsSize = NativeReflection.GetFunctionParamsSize(Map_Keys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Map_Keys_TargetMap_PropertyAddress, Map_Keys_FunctionAddress, "TargetMap");
		Map_Keys_TargetMap_Offset = NativeReflectionCached.GetPropertyOffset(Map_Keys_FunctionAddress, "TargetMap");
		Map_Keys_TargetMap_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_Keys_FunctionAddress, "TargetMap", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref Map_Keys_Keys_PropertyAddress, Map_Keys_FunctionAddress, "Keys");
		Map_Keys_Keys_Offset = NativeReflectionCached.GetPropertyOffset(Map_Keys_FunctionAddress, "Keys");
		Map_Keys_Keys_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_Keys_FunctionAddress, "Keys", Classes.FArrayProperty);
		Map_Keys_IsValid = Map_Keys_FunctionAddress != IntPtr.Zero && Map_Keys_TargetMap_IsValid && Map_Keys_Keys_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintMapLibrary:Map_Keys", Map_Keys_IsValid);
		Map_IsNotEmpty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Map_IsNotEmpty");
		Map_IsNotEmpty_ParamsSize = NativeReflection.GetFunctionParamsSize(Map_IsNotEmpty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Map_IsNotEmpty_TargetMap_PropertyAddress, Map_IsNotEmpty_FunctionAddress, "TargetMap");
		Map_IsNotEmpty_TargetMap_Offset = NativeReflectionCached.GetPropertyOffset(Map_IsNotEmpty_FunctionAddress, "TargetMap");
		Map_IsNotEmpty_TargetMap_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_IsNotEmpty_FunctionAddress, "TargetMap", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref Map_IsNotEmpty_ReturnValue_PropertyAddress, Map_IsNotEmpty_FunctionAddress, "ReturnValue");
		Map_IsNotEmpty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Map_IsNotEmpty_FunctionAddress, "ReturnValue");
		Map_IsNotEmpty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_IsNotEmpty_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Map_IsNotEmpty_IsValid = Map_IsNotEmpty_FunctionAddress != IntPtr.Zero && Map_IsNotEmpty_TargetMap_IsValid && Map_IsNotEmpty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintMapLibrary:Map_IsNotEmpty", Map_IsNotEmpty_IsValid);
		Map_IsEmpty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Map_IsEmpty");
		Map_IsEmpty_ParamsSize = NativeReflection.GetFunctionParamsSize(Map_IsEmpty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Map_IsEmpty_TargetMap_PropertyAddress, Map_IsEmpty_FunctionAddress, "TargetMap");
		Map_IsEmpty_TargetMap_Offset = NativeReflectionCached.GetPropertyOffset(Map_IsEmpty_FunctionAddress, "TargetMap");
		Map_IsEmpty_TargetMap_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_IsEmpty_FunctionAddress, "TargetMap", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref Map_IsEmpty_ReturnValue_PropertyAddress, Map_IsEmpty_FunctionAddress, "ReturnValue");
		Map_IsEmpty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Map_IsEmpty_FunctionAddress, "ReturnValue");
		Map_IsEmpty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_IsEmpty_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Map_IsEmpty_IsValid = Map_IsEmpty_FunctionAddress != IntPtr.Zero && Map_IsEmpty_TargetMap_IsValid && Map_IsEmpty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintMapLibrary:Map_IsEmpty", Map_IsEmpty_IsValid);
		Map_Find_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Map_Find");
		Map_Find_ParamsSize = NativeReflection.GetFunctionParamsSize(Map_Find_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Map_Find_TargetMap_PropertyAddress, Map_Find_FunctionAddress, "TargetMap");
		Map_Find_TargetMap_Offset = NativeReflectionCached.GetPropertyOffset(Map_Find_FunctionAddress, "TargetMap");
		Map_Find_TargetMap_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_Find_FunctionAddress, "TargetMap", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref Map_Find_Key_PropertyAddress, Map_Find_FunctionAddress, "Key");
		Map_Find_Key_Offset = NativeReflectionCached.GetPropertyOffset(Map_Find_FunctionAddress, "Key");
		Map_Find_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_Find_FunctionAddress, "Key", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Map_Find_Value_PropertyAddress, Map_Find_FunctionAddress, "Value");
		Map_Find_Value_Offset = NativeReflectionCached.GetPropertyOffset(Map_Find_FunctionAddress, "Value");
		Map_Find_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_Find_FunctionAddress, "Value", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Map_Find_ReturnValue_PropertyAddress, Map_Find_FunctionAddress, "ReturnValue");
		Map_Find_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Map_Find_FunctionAddress, "ReturnValue");
		Map_Find_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_Find_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Map_Find_IsValid = Map_Find_FunctionAddress != IntPtr.Zero && Map_Find_TargetMap_IsValid && Map_Find_Key_IsValid && Map_Find_Value_IsValid && Map_Find_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintMapLibrary:Map_Find", Map_Find_IsValid);
		Map_Contains_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Map_Contains");
		Map_Contains_ParamsSize = NativeReflection.GetFunctionParamsSize(Map_Contains_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Map_Contains_TargetMap_PropertyAddress, Map_Contains_FunctionAddress, "TargetMap");
		Map_Contains_TargetMap_Offset = NativeReflectionCached.GetPropertyOffset(Map_Contains_FunctionAddress, "TargetMap");
		Map_Contains_TargetMap_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_Contains_FunctionAddress, "TargetMap", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref Map_Contains_Key_PropertyAddress, Map_Contains_FunctionAddress, "Key");
		Map_Contains_Key_Offset = NativeReflectionCached.GetPropertyOffset(Map_Contains_FunctionAddress, "Key");
		Map_Contains_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_Contains_FunctionAddress, "Key", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Map_Contains_ReturnValue_PropertyAddress, Map_Contains_FunctionAddress, "ReturnValue");
		Map_Contains_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Map_Contains_FunctionAddress, "ReturnValue");
		Map_Contains_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_Contains_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Map_Contains_IsValid = Map_Contains_FunctionAddress != IntPtr.Zero && Map_Contains_TargetMap_IsValid && Map_Contains_Key_IsValid && Map_Contains_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintMapLibrary:Map_Contains", Map_Contains_IsValid);
		Map_Clear_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Map_Clear");
		Map_Clear_ParamsSize = NativeReflection.GetFunctionParamsSize(Map_Clear_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Map_Clear_TargetMap_PropertyAddress, Map_Clear_FunctionAddress, "TargetMap");
		Map_Clear_TargetMap_Offset = NativeReflectionCached.GetPropertyOffset(Map_Clear_FunctionAddress, "TargetMap");
		Map_Clear_TargetMap_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_Clear_FunctionAddress, "TargetMap", Classes.FMapProperty);
		Map_Clear_IsValid = Map_Clear_FunctionAddress != IntPtr.Zero && Map_Clear_TargetMap_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintMapLibrary:Map_Clear", Map_Clear_IsValid);
		Map_Add_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Map_Add");
		Map_Add_ParamsSize = NativeReflection.GetFunctionParamsSize(Map_Add_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Map_Add_TargetMap_PropertyAddress, Map_Add_FunctionAddress, "TargetMap");
		Map_Add_TargetMap_Offset = NativeReflectionCached.GetPropertyOffset(Map_Add_FunctionAddress, "TargetMap");
		Map_Add_TargetMap_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_Add_FunctionAddress, "TargetMap", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref Map_Add_Key_PropertyAddress, Map_Add_FunctionAddress, "Key");
		Map_Add_Key_Offset = NativeReflectionCached.GetPropertyOffset(Map_Add_FunctionAddress, "Key");
		Map_Add_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_Add_FunctionAddress, "Key", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Map_Add_Value_PropertyAddress, Map_Add_FunctionAddress, "Value");
		Map_Add_Value_Offset = NativeReflectionCached.GetPropertyOffset(Map_Add_FunctionAddress, "Value");
		Map_Add_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(Map_Add_FunctionAddress, "Value", Classes.FIntProperty);
		Map_Add_IsValid = Map_Add_FunctionAddress != IntPtr.Zero && Map_Add_TargetMap_IsValid && Map_Add_Key_IsValid && Map_Add_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintMapLibrary:Map_Add", Map_Add_IsValid);
	}
}
