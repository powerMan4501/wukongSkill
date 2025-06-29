using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/b1.BGUFuncLibData", "b1", UnrealModuleType.Game)]
public class UBGUFuncLibData : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool BGUSetTagVector_IsValid;

	private static IntPtr BGUSetTagVector_FunctionAddress;

	private static int BGUSetTagVector_ParamsSize;

	private static bool BGUSetTagVector_Unit_IsValid;

	private static FFieldAddress BGUSetTagVector_Unit_PropertyAddress;

	private static int BGUSetTagVector_Unit_Offset;

	private static bool BGUSetTagVector_Tag_IsValid;

	private static FFieldAddress BGUSetTagVector_Tag_PropertyAddress;

	private static int BGUSetTagVector_Tag_Offset;

	private static bool BGUSetTagVector_Val_IsValid;

	private static FFieldAddress BGUSetTagVector_Val_PropertyAddress;

	private static int BGUSetTagVector_Val_Offset;

	private static bool BGUSetTagObject_IsValid;

	private static IntPtr BGUSetTagObject_FunctionAddress;

	private static int BGUSetTagObject_ParamsSize;

	private static bool BGUSetTagObject_Unit_IsValid;

	private static FFieldAddress BGUSetTagObject_Unit_PropertyAddress;

	private static int BGUSetTagObject_Unit_Offset;

	private static bool BGUSetTagObject_Tag_IsValid;

	private static FFieldAddress BGUSetTagObject_Tag_PropertyAddress;

	private static int BGUSetTagObject_Tag_Offset;

	private static bool BGUSetTagObject_Val_IsValid;

	private static FFieldAddress BGUSetTagObject_Val_PropertyAddress;

	private static int BGUSetTagObject_Val_Offset;

	private static bool BGUSetTagNameWithGameplayTag_IsValid;

	private static IntPtr BGUSetTagNameWithGameplayTag_FunctionAddress;

	private static int BGUSetTagNameWithGameplayTag_ParamsSize;

	private static bool BGUSetTagNameWithGameplayTag_Unit_IsValid;

	private static FFieldAddress BGUSetTagNameWithGameplayTag_Unit_PropertyAddress;

	private static int BGUSetTagNameWithGameplayTag_Unit_Offset;

	private static bool BGUSetTagNameWithGameplayTag_Tag_IsValid;

	private static FFieldAddress BGUSetTagNameWithGameplayTag_Tag_PropertyAddress;

	private static int BGUSetTagNameWithGameplayTag_Tag_Offset;

	private static bool BGUSetTagNameWithGameplayTag_Val_IsValid;

	private static FFieldAddress BGUSetTagNameWithGameplayTag_Val_PropertyAddress;

	private static int BGUSetTagNameWithGameplayTag_Val_Offset;

	private static bool BGUSetTagName_IsValid;

	private static IntPtr BGUSetTagName_FunctionAddress;

	private static int BGUSetTagName_ParamsSize;

	private static bool BGUSetTagName_Unit_IsValid;

	private static FFieldAddress BGUSetTagName_Unit_PropertyAddress;

	private static int BGUSetTagName_Unit_Offset;

	private static bool BGUSetTagName_Tag_IsValid;

	private static FFieldAddress BGUSetTagName_Tag_PropertyAddress;

	private static int BGUSetTagName_Tag_Offset;

	private static bool BGUSetTagName_Val_IsValid;

	private static FFieldAddress BGUSetTagName_Val_PropertyAddress;

	private static int BGUSetTagName_Val_Offset;

	private static bool BGUSetTagIntByName_IsValid;

	private static IntPtr BGUSetTagIntByName_FunctionAddress;

	private static int BGUSetTagIntByName_ParamsSize;

	private static bool BGUSetTagIntByName_Unit_IsValid;

	private static FFieldAddress BGUSetTagIntByName_Unit_PropertyAddress;

	private static int BGUSetTagIntByName_Unit_Offset;

	private static bool BGUSetTagIntByName_TagName_IsValid;

	private static FFieldAddress BGUSetTagIntByName_TagName_PropertyAddress;

	private static int BGUSetTagIntByName_TagName_Offset;

	private static bool BGUSetTagIntByName_Val_IsValid;

	private static FFieldAddress BGUSetTagIntByName_Val_PropertyAddress;

	private static int BGUSetTagIntByName_Val_Offset;

	private static bool BGUSetTagInt_IsValid;

	private static IntPtr BGUSetTagInt_FunctionAddress;

	private static int BGUSetTagInt_ParamsSize;

	private static bool BGUSetTagInt_Unit_IsValid;

	private static FFieldAddress BGUSetTagInt_Unit_PropertyAddress;

	private static int BGUSetTagInt_Unit_Offset;

	private static bool BGUSetTagInt_Tag_IsValid;

	private static FFieldAddress BGUSetTagInt_Tag_PropertyAddress;

	private static int BGUSetTagInt_Tag_Offset;

	private static bool BGUSetTagInt_Val_IsValid;

	private static FFieldAddress BGUSetTagInt_Val_PropertyAddress;

	private static int BGUSetTagInt_Val_Offset;

	private static bool BGUSetTagFloatByName_IsValid;

	private static IntPtr BGUSetTagFloatByName_FunctionAddress;

	private static int BGUSetTagFloatByName_ParamsSize;

	private static bool BGUSetTagFloatByName_Unit_IsValid;

	private static FFieldAddress BGUSetTagFloatByName_Unit_PropertyAddress;

	private static int BGUSetTagFloatByName_Unit_Offset;

	private static bool BGUSetTagFloatByName_TagName_IsValid;

	private static FFieldAddress BGUSetTagFloatByName_TagName_PropertyAddress;

	private static int BGUSetTagFloatByName_TagName_Offset;

	private static bool BGUSetTagFloatByName_Val_IsValid;

	private static FFieldAddress BGUSetTagFloatByName_Val_PropertyAddress;

	private static int BGUSetTagFloatByName_Val_Offset;

	private static bool BGUSetTagFloat_IsValid;

	private static IntPtr BGUSetTagFloat_FunctionAddress;

	private static int BGUSetTagFloat_ParamsSize;

	private static bool BGUSetTagFloat_Unit_IsValid;

	private static FFieldAddress BGUSetTagFloat_Unit_PropertyAddress;

	private static int BGUSetTagFloat_Unit_Offset;

	private static bool BGUSetTagFloat_Tag_IsValid;

	private static FFieldAddress BGUSetTagFloat_Tag_PropertyAddress;

	private static int BGUSetTagFloat_Tag_Offset;

	private static bool BGUSetTagFloat_Val_IsValid;

	private static FFieldAddress BGUSetTagFloat_Val_PropertyAddress;

	private static int BGUSetTagFloat_Val_Offset;

	private static bool BGUSetTagEnum_IsValid;

	private static IntPtr BGUSetTagEnum_FunctionAddress;

	private static int BGUSetTagEnum_ParamsSize;

	private static bool BGUSetTagEnum_Unit_IsValid;

	private static FFieldAddress BGUSetTagEnum_Unit_PropertyAddress;

	private static int BGUSetTagEnum_Unit_Offset;

	private static bool BGUSetTagEnum_Tag_IsValid;

	private static FFieldAddress BGUSetTagEnum_Tag_PropertyAddress;

	private static int BGUSetTagEnum_Tag_Offset;

	private static bool BGUSetTagEnum_Val_IsValid;

	private static FFieldAddress BGUSetTagEnum_Val_PropertyAddress;

	private static int BGUSetTagEnum_Val_Offset;

	private static bool BGUGetTagVector_IsValid;

	private static IntPtr BGUGetTagVector_FunctionAddress;

	private static int BGUGetTagVector_ParamsSize;

	private static bool BGUGetTagVector_Unit_IsValid;

	private static FFieldAddress BGUGetTagVector_Unit_PropertyAddress;

	private static int BGUGetTagVector_Unit_Offset;

	private static bool BGUGetTagVector_Tag_IsValid;

	private static FFieldAddress BGUGetTagVector_Tag_PropertyAddress;

	private static int BGUGetTagVector_Tag_Offset;

	private static bool BGUGetTagVector_IsValid_IsValid;

	private static FFieldAddress BGUGetTagVector_IsValid_PropertyAddress;

	private static int BGUGetTagVector_IsValid_Offset;

	private static bool BGUGetTagVector_Out_IsValid;

	private static FFieldAddress BGUGetTagVector_Out_PropertyAddress;

	private static int BGUGetTagVector_Out_Offset;

	private static bool BGUGetTagObject_IsValid;

	private static IntPtr BGUGetTagObject_FunctionAddress;

	private static int BGUGetTagObject_ParamsSize;

	private static bool BGUGetTagObject_Unit_IsValid;

	private static FFieldAddress BGUGetTagObject_Unit_PropertyAddress;

	private static int BGUGetTagObject_Unit_Offset;

	private static bool BGUGetTagObject_Tag_IsValid;

	private static FFieldAddress BGUGetTagObject_Tag_PropertyAddress;

	private static int BGUGetTagObject_Tag_Offset;

	private static bool BGUGetTagObject_ReturnValue_IsValid;

	private static FFieldAddress BGUGetTagObject_ReturnValue_PropertyAddress;

	private static int BGUGetTagObject_ReturnValue_Offset;

	private static bool BGUGetTagName_IsValid;

	private static IntPtr BGUGetTagName_FunctionAddress;

	private static int BGUGetTagName_ParamsSize;

	private static bool BGUGetTagName_Unit_IsValid;

	private static FFieldAddress BGUGetTagName_Unit_PropertyAddress;

	private static int BGUGetTagName_Unit_Offset;

	private static bool BGUGetTagName_Tag_IsValid;

	private static FFieldAddress BGUGetTagName_Tag_PropertyAddress;

	private static int BGUGetTagName_Tag_Offset;

	private static bool BGUGetTagName_IsValid_IsValid;

	private static FFieldAddress BGUGetTagName_IsValid_PropertyAddress;

	private static int BGUGetTagName_IsValid_Offset;

	private static bool BGUGetTagName_Out_IsValid;

	private static FFieldAddress BGUGetTagName_Out_PropertyAddress;

	private static int BGUGetTagName_Out_Offset;

	private static bool BGUGetTagIntByName_IsValid;

	private static IntPtr BGUGetTagIntByName_FunctionAddress;

	private static int BGUGetTagIntByName_ParamsSize;

	private static bool BGUGetTagIntByName_Unit_IsValid;

	private static FFieldAddress BGUGetTagIntByName_Unit_PropertyAddress;

	private static int BGUGetTagIntByName_Unit_Offset;

	private static bool BGUGetTagIntByName_TagName_IsValid;

	private static FFieldAddress BGUGetTagIntByName_TagName_PropertyAddress;

	private static int BGUGetTagIntByName_TagName_Offset;

	private static bool BGUGetTagIntByName_IsValid_IsValid;

	private static FFieldAddress BGUGetTagIntByName_IsValid_PropertyAddress;

	private static int BGUGetTagIntByName_IsValid_Offset;

	private static bool BGUGetTagIntByName_Out_IsValid;

	private static FFieldAddress BGUGetTagIntByName_Out_PropertyAddress;

	private static int BGUGetTagIntByName_Out_Offset;

	private static bool BGUGetTagInt_IsValid;

	private static IntPtr BGUGetTagInt_FunctionAddress;

	private static int BGUGetTagInt_ParamsSize;

	private static bool BGUGetTagInt_Unit_IsValid;

	private static FFieldAddress BGUGetTagInt_Unit_PropertyAddress;

	private static int BGUGetTagInt_Unit_Offset;

	private static bool BGUGetTagInt_Tag_IsValid;

	private static FFieldAddress BGUGetTagInt_Tag_PropertyAddress;

	private static int BGUGetTagInt_Tag_Offset;

	private static bool BGUGetTagInt_IsValid_IsValid;

	private static FFieldAddress BGUGetTagInt_IsValid_PropertyAddress;

	private static int BGUGetTagInt_IsValid_Offset;

	private static bool BGUGetTagInt_Out_IsValid;

	private static FFieldAddress BGUGetTagInt_Out_PropertyAddress;

	private static int BGUGetTagInt_Out_Offset;

	private static bool BGUGetTagFloatByName_IsValid;

	private static IntPtr BGUGetTagFloatByName_FunctionAddress;

	private static int BGUGetTagFloatByName_ParamsSize;

	private static bool BGUGetTagFloatByName_Unit_IsValid;

	private static FFieldAddress BGUGetTagFloatByName_Unit_PropertyAddress;

	private static int BGUGetTagFloatByName_Unit_Offset;

	private static bool BGUGetTagFloatByName_TagName_IsValid;

	private static FFieldAddress BGUGetTagFloatByName_TagName_PropertyAddress;

	private static int BGUGetTagFloatByName_TagName_Offset;

	private static bool BGUGetTagFloatByName_IsValid_IsValid;

	private static FFieldAddress BGUGetTagFloatByName_IsValid_PropertyAddress;

	private static int BGUGetTagFloatByName_IsValid_Offset;

	private static bool BGUGetTagFloatByName_Out_IsValid;

	private static FFieldAddress BGUGetTagFloatByName_Out_PropertyAddress;

	private static int BGUGetTagFloatByName_Out_Offset;

	private static bool BGUGetTagFloat_IsValid;

	private static IntPtr BGUGetTagFloat_FunctionAddress;

	private static int BGUGetTagFloat_ParamsSize;

	private static bool BGUGetTagFloat_Unit_IsValid;

	private static FFieldAddress BGUGetTagFloat_Unit_PropertyAddress;

	private static int BGUGetTagFloat_Unit_Offset;

	private static bool BGUGetTagFloat_Tag_IsValid;

	private static FFieldAddress BGUGetTagFloat_Tag_PropertyAddress;

	private static int BGUGetTagFloat_Tag_Offset;

	private static bool BGUGetTagFloat_IsValid_IsValid;

	private static FFieldAddress BGUGetTagFloat_IsValid_PropertyAddress;

	private static int BGUGetTagFloat_IsValid_Offset;

	private static bool BGUGetTagFloat_Out_IsValid;

	private static FFieldAddress BGUGetTagFloat_Out_PropertyAddress;

	private static int BGUGetTagFloat_Out_Offset;

	private static bool BGUGetTagEnum_IsValid;

	private static IntPtr BGUGetTagEnum_FunctionAddress;

	private static int BGUGetTagEnum_ParamsSize;

	private static bool BGUGetTagEnum_Unit_IsValid;

	private static FFieldAddress BGUGetTagEnum_Unit_PropertyAddress;

	private static int BGUGetTagEnum_Unit_Offset;

	private static bool BGUGetTagEnum_Tag_IsValid;

	private static FFieldAddress BGUGetTagEnum_Tag_PropertyAddress;

	private static int BGUGetTagEnum_Tag_Offset;

	private static bool BGUGetTagEnum_IsValid_IsValid;

	private static FFieldAddress BGUGetTagEnum_IsValid_PropertyAddress;

	private static int BGUGetTagEnum_IsValid_Offset;

	private static bool BGUGetTagEnum_Out_IsValid;

	private static FFieldAddress BGUGetTagEnum_Out_PropertyAddress;

	private static int BGUGetTagEnum_Out_Offset;

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFuncLibData:BGUSetTagVector")]
	public unsafe static void BGUSetTagVector(AActor Unit, FGameplayTag Tag, FVector Val)
	{
		if (!BGUSetTagVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibData:BGUSetTagVector");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSetTagVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSetTagVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUSetTagVector_Unit_Offset), 0, BGUSetTagVector_Unit_PropertyAddress.Address, Unit);
		NativeReflection.InitializeValue_InContainer(BGUSetTagVector_Tag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, BGUSetTagVector_Tag_Offset), 0, BGUSetTagVector_Tag_PropertyAddress.Address, Tag);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUSetTagVector_Val_Offset), 0, BGUSetTagVector_Val_PropertyAddress.Address, Val);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSetTagVector_FunctionAddress, intPtr, BGUSetTagVector_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFuncLibData:BGUSetTagObject")]
	public unsafe static void BGUSetTagObject(AActor Unit, FGameplayTag Tag, UObject Val)
	{
		if (!BGUSetTagObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibData:BGUSetTagObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSetTagObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSetTagObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUSetTagObject_Unit_Offset), 0, BGUSetTagObject_Unit_PropertyAddress.Address, Unit);
		NativeReflection.InitializeValue_InContainer(BGUSetTagObject_Tag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, BGUSetTagObject_Tag_Offset), 0, BGUSetTagObject_Tag_PropertyAddress.Address, Tag);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUSetTagObject_Val_Offset), 0, BGUSetTagObject_Val_PropertyAddress.Address, Val);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSetTagObject_FunctionAddress, intPtr, BGUSetTagObject_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFuncLibData:BGUSetTagNameWithGameplayTag")]
	public unsafe static void BGUSetTagNameWithGameplayTag(AActor Unit, FGameplayTag Tag, FGameplayTag Val)
	{
		if (!BGUSetTagNameWithGameplayTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibData:BGUSetTagNameWithGameplayTag");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSetTagNameWithGameplayTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSetTagNameWithGameplayTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUSetTagNameWithGameplayTag_Unit_Offset), 0, BGUSetTagNameWithGameplayTag_Unit_PropertyAddress.Address, Unit);
		NativeReflection.InitializeValue_InContainer(BGUSetTagNameWithGameplayTag_Tag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, BGUSetTagNameWithGameplayTag_Tag_Offset), 0, BGUSetTagNameWithGameplayTag_Tag_PropertyAddress.Address, Tag);
		NativeReflection.InitializeValue_InContainer(BGUSetTagNameWithGameplayTag_Val_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, BGUSetTagNameWithGameplayTag_Val_Offset), 0, BGUSetTagNameWithGameplayTag_Val_PropertyAddress.Address, Val);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSetTagNameWithGameplayTag_FunctionAddress, intPtr, BGUSetTagNameWithGameplayTag_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFuncLibData:BGUSetTagName")]
	public unsafe static void BGUSetTagName(AActor Unit, FGameplayTag Tag, FName Val)
	{
		if (!BGUSetTagName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibData:BGUSetTagName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSetTagName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSetTagName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUSetTagName_Unit_Offset), 0, BGUSetTagName_Unit_PropertyAddress.Address, Unit);
		NativeReflection.InitializeValue_InContainer(BGUSetTagName_Tag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, BGUSetTagName_Tag_Offset), 0, BGUSetTagName_Tag_PropertyAddress.Address, Tag);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUSetTagName_Val_Offset), 0, BGUSetTagName_Val_PropertyAddress.Address, Val);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSetTagName_FunctionAddress, intPtr, BGUSetTagName_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFuncLibData:BGUSetTagIntByName")]
	public unsafe static void BGUSetTagIntByName(AActor Unit, FName TagName, float Val)
	{
		if (!BGUSetTagIntByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibData:BGUSetTagIntByName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSetTagIntByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSetTagIntByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUSetTagIntByName_Unit_Offset), 0, BGUSetTagIntByName_Unit_PropertyAddress.Address, Unit);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUSetTagIntByName_TagName_Offset), 0, BGUSetTagIntByName_TagName_PropertyAddress.Address, TagName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUSetTagIntByName_Val_Offset), 0, BGUSetTagIntByName_Val_PropertyAddress.Address, Val);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSetTagIntByName_FunctionAddress, intPtr, BGUSetTagIntByName_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFuncLibData:BGUSetTagInt")]
	public unsafe static void BGUSetTagInt(AActor Unit, FGameplayTag Tag, int Val)
	{
		if (!BGUSetTagInt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibData:BGUSetTagInt");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSetTagInt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSetTagInt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUSetTagInt_Unit_Offset), 0, BGUSetTagInt_Unit_PropertyAddress.Address, Unit);
		NativeReflection.InitializeValue_InContainer(BGUSetTagInt_Tag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, BGUSetTagInt_Tag_Offset), 0, BGUSetTagInt_Tag_PropertyAddress.Address, Tag);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGUSetTagInt_Val_Offset), 0, BGUSetTagInt_Val_PropertyAddress.Address, Val);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSetTagInt_FunctionAddress, intPtr, BGUSetTagInt_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFuncLibData:BGUSetTagFloatByName")]
	public unsafe static void BGUSetTagFloatByName(AActor Unit, FName TagName, float Val)
	{
		if (!BGUSetTagFloatByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibData:BGUSetTagFloatByName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSetTagFloatByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSetTagFloatByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUSetTagFloatByName_Unit_Offset), 0, BGUSetTagFloatByName_Unit_PropertyAddress.Address, Unit);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUSetTagFloatByName_TagName_Offset), 0, BGUSetTagFloatByName_TagName_PropertyAddress.Address, TagName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUSetTagFloatByName_Val_Offset), 0, BGUSetTagFloatByName_Val_PropertyAddress.Address, Val);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSetTagFloatByName_FunctionAddress, intPtr, BGUSetTagFloatByName_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFuncLibData:BGUSetTagFloat")]
	public unsafe static void BGUSetTagFloat(AActor Unit, FGameplayTag Tag, float Val)
	{
		if (!BGUSetTagFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibData:BGUSetTagFloat");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSetTagFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSetTagFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUSetTagFloat_Unit_Offset), 0, BGUSetTagFloat_Unit_PropertyAddress.Address, Unit);
		NativeReflection.InitializeValue_InContainer(BGUSetTagFloat_Tag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, BGUSetTagFloat_Tag_Offset), 0, BGUSetTagFloat_Tag_PropertyAddress.Address, Tag);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUSetTagFloat_Val_Offset), 0, BGUSetTagFloat_Val_PropertyAddress.Address, Val);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSetTagFloat_FunctionAddress, intPtr, BGUSetTagFloat_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFuncLibData:BGUSetTagEnum")]
	public unsafe static void BGUSetTagEnum(AActor Unit, FGameplayTag Tag, byte Val)
	{
		if (!BGUSetTagEnum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibData:BGUSetTagEnum");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSetTagEnum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSetTagEnum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUSetTagEnum_Unit_Offset), 0, BGUSetTagEnum_Unit_PropertyAddress.Address, Unit);
		NativeReflection.InitializeValue_InContainer(BGUSetTagEnum_Tag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, BGUSetTagEnum_Tag_Offset), 0, BGUSetTagEnum_Tag_PropertyAddress.Address, Tag);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, BGUSetTagEnum_Val_Offset), 0, BGUSetTagEnum_Val_PropertyAddress.Address, Val);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSetTagEnum_FunctionAddress, intPtr, BGUSetTagEnum_ParamsSize);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/b1.BGUFuncLibData:BGUGetTagVector")]
	public unsafe static void BGUGetTagVector(AActor Unit, FGameplayTag Tag, out bool IsValid, out FVector Out)
	{
		if (!BGUGetTagVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibData:BGUGetTagVector");
			IsValid = false;
			Out = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetTagVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetTagVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUGetTagVector_Unit_Offset), 0, BGUGetTagVector_Unit_PropertyAddress.Address, Unit);
		NativeReflection.InitializeValue_InContainer(BGUGetTagVector_Tag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, BGUGetTagVector_Tag_Offset), 0, BGUGetTagVector_Tag_PropertyAddress.Address, Tag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetTagVector_FunctionAddress, intPtr, BGUGetTagVector_ParamsSize);
		IsValid = BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUGetTagVector_IsValid_Offset), 0, BGUGetTagVector_IsValid_PropertyAddress.Address);
		Out = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, BGUGetTagVector_Out_Offset), 0, BGUGetTagVector_Out_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/b1.BGUFuncLibData:BGUGetTagObject")]
	public unsafe static UObject BGUGetTagObject(AActor Unit, FGameplayTag Tag)
	{
		if (!BGUGetTagObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibData:BGUGetTagObject");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetTagObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetTagObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUGetTagObject_Unit_Offset), 0, BGUGetTagObject_Unit_PropertyAddress.Address, Unit);
		NativeReflection.InitializeValue_InContainer(BGUGetTagObject_Tag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, BGUGetTagObject_Tag_Offset), 0, BGUGetTagObject_Tag_PropertyAddress.Address, Tag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetTagObject_FunctionAddress, intPtr, BGUGetTagObject_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, BGUGetTagObject_ReturnValue_Offset), 0, BGUGetTagObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/b1.BGUFuncLibData:BGUGetTagName")]
	public unsafe static void BGUGetTagName(AActor Unit, FGameplayTag Tag, out bool IsValid, out FName Out)
	{
		if (!BGUGetTagName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibData:BGUGetTagName");
			IsValid = false;
			Out = default(FName);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetTagName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetTagName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUGetTagName_Unit_Offset), 0, BGUGetTagName_Unit_PropertyAddress.Address, Unit);
		NativeReflection.InitializeValue_InContainer(BGUGetTagName_Tag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, BGUGetTagName_Tag_Offset), 0, BGUGetTagName_Tag_PropertyAddress.Address, Tag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetTagName_FunctionAddress, intPtr, BGUGetTagName_ParamsSize);
		IsValid = BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUGetTagName_IsValid_Offset), 0, BGUGetTagName_IsValid_PropertyAddress.Address);
		Out = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, BGUGetTagName_Out_Offset), 0, BGUGetTagName_Out_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/b1.BGUFuncLibData:BGUGetTagIntByName")]
	public unsafe static void BGUGetTagIntByName(AActor Unit, FName TagName, out bool IsValid, out int Out)
	{
		if (!BGUGetTagIntByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibData:BGUGetTagIntByName");
			IsValid = false;
			Out = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetTagIntByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetTagIntByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUGetTagIntByName_Unit_Offset), 0, BGUGetTagIntByName_Unit_PropertyAddress.Address, Unit);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUGetTagIntByName_TagName_Offset), 0, BGUGetTagIntByName_TagName_PropertyAddress.Address, TagName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetTagIntByName_FunctionAddress, intPtr, BGUGetTagIntByName_ParamsSize);
		IsValid = BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUGetTagIntByName_IsValid_Offset), 0, BGUGetTagIntByName_IsValid_PropertyAddress.Address);
		Out = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BGUGetTagIntByName_Out_Offset), 0, BGUGetTagIntByName_Out_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/b1.BGUFuncLibData:BGUGetTagInt")]
	public unsafe static void BGUGetTagInt(AActor Unit, FGameplayTag Tag, out bool IsValid, out int Out)
	{
		if (!BGUGetTagInt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibData:BGUGetTagInt");
			IsValid = false;
			Out = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetTagInt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetTagInt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUGetTagInt_Unit_Offset), 0, BGUGetTagInt_Unit_PropertyAddress.Address, Unit);
		NativeReflection.InitializeValue_InContainer(BGUGetTagInt_Tag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, BGUGetTagInt_Tag_Offset), 0, BGUGetTagInt_Tag_PropertyAddress.Address, Tag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetTagInt_FunctionAddress, intPtr, BGUGetTagInt_ParamsSize);
		IsValid = BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUGetTagInt_IsValid_Offset), 0, BGUGetTagInt_IsValid_PropertyAddress.Address);
		Out = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BGUGetTagInt_Out_Offset), 0, BGUGetTagInt_Out_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/b1.BGUFuncLibData:BGUGetTagFloatByName")]
	public unsafe static void BGUGetTagFloatByName(AActor Unit, FName TagName, out bool IsValid, out float Out)
	{
		if (!BGUGetTagFloatByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibData:BGUGetTagFloatByName");
			IsValid = false;
			Out = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetTagFloatByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetTagFloatByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUGetTagFloatByName_Unit_Offset), 0, BGUGetTagFloatByName_Unit_PropertyAddress.Address, Unit);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUGetTagFloatByName_TagName_Offset), 0, BGUGetTagFloatByName_TagName_PropertyAddress.Address, TagName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetTagFloatByName_FunctionAddress, intPtr, BGUGetTagFloatByName_ParamsSize);
		IsValid = BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUGetTagFloatByName_IsValid_Offset), 0, BGUGetTagFloatByName_IsValid_PropertyAddress.Address);
		Out = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUGetTagFloatByName_Out_Offset), 0, BGUGetTagFloatByName_Out_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/b1.BGUFuncLibData:BGUGetTagFloat")]
	public unsafe static void BGUGetTagFloat(AActor Unit, FGameplayTag Tag, out bool IsValid, out float Out)
	{
		if (!BGUGetTagFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibData:BGUGetTagFloat");
			IsValid = false;
			Out = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetTagFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetTagFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUGetTagFloat_Unit_Offset), 0, BGUGetTagFloat_Unit_PropertyAddress.Address, Unit);
		NativeReflection.InitializeValue_InContainer(BGUGetTagFloat_Tag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, BGUGetTagFloat_Tag_Offset), 0, BGUGetTagFloat_Tag_PropertyAddress.Address, Tag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetTagFloat_FunctionAddress, intPtr, BGUGetTagFloat_ParamsSize);
		IsValid = BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUGetTagFloat_IsValid_Offset), 0, BGUGetTagFloat_IsValid_PropertyAddress.Address);
		Out = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUGetTagFloat_Out_Offset), 0, BGUGetTagFloat_Out_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/b1.BGUFuncLibData:BGUGetTagEnum")]
	public unsafe static void BGUGetTagEnum(AActor Unit, FGameplayTag Tag, out bool IsValid, out byte Out)
	{
		if (!BGUGetTagEnum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibData:BGUGetTagEnum");
			IsValid = false;
			Out = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetTagEnum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetTagEnum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUGetTagEnum_Unit_Offset), 0, BGUGetTagEnum_Unit_PropertyAddress.Address, Unit);
		NativeReflection.InitializeValue_InContainer(BGUGetTagEnum_Tag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, BGUGetTagEnum_Tag_Offset), 0, BGUGetTagEnum_Tag_PropertyAddress.Address, Tag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetTagEnum_FunctionAddress, intPtr, BGUGetTagEnum_ParamsSize);
		IsValid = BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUGetTagEnum_IsValid_Offset), 0, BGUGetTagEnum_IsValid_PropertyAddress.Address);
		Out = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(intPtr, BGUGetTagEnum_Out_Offset), 0, BGUGetTagEnum_Out_PropertyAddress.Address);
	}

	static UBGUFuncLibData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUFuncLibData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUFuncLibData));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.BGUFuncLibData");
		BGUSetTagVector_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSetTagVector");
		BGUSetTagVector_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetTagVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagVector_Unit_PropertyAddress, BGUSetTagVector_FunctionAddress, "Unit");
		BGUSetTagVector_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagVector_FunctionAddress, "Unit");
		BGUSetTagVector_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagVector_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagVector_Tag_PropertyAddress, BGUSetTagVector_FunctionAddress, "Tag");
		BGUSetTagVector_Tag_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagVector_FunctionAddress, "Tag");
		BGUSetTagVector_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagVector_FunctionAddress, "Tag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagVector_Val_PropertyAddress, BGUSetTagVector_FunctionAddress, "Val");
		BGUSetTagVector_Val_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagVector_FunctionAddress, "Val");
		BGUSetTagVector_Val_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagVector_FunctionAddress, "Val", Classes.FStructProperty);
		BGUSetTagVector_IsValid = BGUSetTagVector_FunctionAddress != IntPtr.Zero && BGUSetTagVector_Unit_IsValid && BGUSetTagVector_Tag_IsValid && BGUSetTagVector_Val_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibData:BGUSetTagVector", BGUSetTagVector_IsValid);
		BGUSetTagObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSetTagObject");
		BGUSetTagObject_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetTagObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagObject_Unit_PropertyAddress, BGUSetTagObject_FunctionAddress, "Unit");
		BGUSetTagObject_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagObject_FunctionAddress, "Unit");
		BGUSetTagObject_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagObject_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagObject_Tag_PropertyAddress, BGUSetTagObject_FunctionAddress, "Tag");
		BGUSetTagObject_Tag_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagObject_FunctionAddress, "Tag");
		BGUSetTagObject_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagObject_FunctionAddress, "Tag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagObject_Val_PropertyAddress, BGUSetTagObject_FunctionAddress, "Val");
		BGUSetTagObject_Val_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagObject_FunctionAddress, "Val");
		BGUSetTagObject_Val_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagObject_FunctionAddress, "Val", Classes.FObjectProperty);
		BGUSetTagObject_IsValid = BGUSetTagObject_FunctionAddress != IntPtr.Zero && BGUSetTagObject_Unit_IsValid && BGUSetTagObject_Tag_IsValid && BGUSetTagObject_Val_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibData:BGUSetTagObject", BGUSetTagObject_IsValid);
		BGUSetTagNameWithGameplayTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSetTagNameWithGameplayTag");
		BGUSetTagNameWithGameplayTag_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetTagNameWithGameplayTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagNameWithGameplayTag_Unit_PropertyAddress, BGUSetTagNameWithGameplayTag_FunctionAddress, "Unit");
		BGUSetTagNameWithGameplayTag_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagNameWithGameplayTag_FunctionAddress, "Unit");
		BGUSetTagNameWithGameplayTag_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagNameWithGameplayTag_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagNameWithGameplayTag_Tag_PropertyAddress, BGUSetTagNameWithGameplayTag_FunctionAddress, "Tag");
		BGUSetTagNameWithGameplayTag_Tag_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagNameWithGameplayTag_FunctionAddress, "Tag");
		BGUSetTagNameWithGameplayTag_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagNameWithGameplayTag_FunctionAddress, "Tag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagNameWithGameplayTag_Val_PropertyAddress, BGUSetTagNameWithGameplayTag_FunctionAddress, "Val");
		BGUSetTagNameWithGameplayTag_Val_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagNameWithGameplayTag_FunctionAddress, "Val");
		BGUSetTagNameWithGameplayTag_Val_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagNameWithGameplayTag_FunctionAddress, "Val", Classes.FStructProperty);
		BGUSetTagNameWithGameplayTag_IsValid = BGUSetTagNameWithGameplayTag_FunctionAddress != IntPtr.Zero && BGUSetTagNameWithGameplayTag_Unit_IsValid && BGUSetTagNameWithGameplayTag_Tag_IsValid && BGUSetTagNameWithGameplayTag_Val_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibData:BGUSetTagNameWithGameplayTag", BGUSetTagNameWithGameplayTag_IsValid);
		BGUSetTagName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSetTagName");
		BGUSetTagName_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetTagName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagName_Unit_PropertyAddress, BGUSetTagName_FunctionAddress, "Unit");
		BGUSetTagName_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagName_FunctionAddress, "Unit");
		BGUSetTagName_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagName_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagName_Tag_PropertyAddress, BGUSetTagName_FunctionAddress, "Tag");
		BGUSetTagName_Tag_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagName_FunctionAddress, "Tag");
		BGUSetTagName_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagName_FunctionAddress, "Tag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagName_Val_PropertyAddress, BGUSetTagName_FunctionAddress, "Val");
		BGUSetTagName_Val_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagName_FunctionAddress, "Val");
		BGUSetTagName_Val_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagName_FunctionAddress, "Val", Classes.FNameProperty);
		BGUSetTagName_IsValid = BGUSetTagName_FunctionAddress != IntPtr.Zero && BGUSetTagName_Unit_IsValid && BGUSetTagName_Tag_IsValid && BGUSetTagName_Val_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibData:BGUSetTagName", BGUSetTagName_IsValid);
		BGUSetTagIntByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSetTagIntByName");
		BGUSetTagIntByName_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetTagIntByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagIntByName_Unit_PropertyAddress, BGUSetTagIntByName_FunctionAddress, "Unit");
		BGUSetTagIntByName_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagIntByName_FunctionAddress, "Unit");
		BGUSetTagIntByName_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagIntByName_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagIntByName_TagName_PropertyAddress, BGUSetTagIntByName_FunctionAddress, "TagName");
		BGUSetTagIntByName_TagName_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagIntByName_FunctionAddress, "TagName");
		BGUSetTagIntByName_TagName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagIntByName_FunctionAddress, "TagName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagIntByName_Val_PropertyAddress, BGUSetTagIntByName_FunctionAddress, "Val");
		BGUSetTagIntByName_Val_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagIntByName_FunctionAddress, "Val");
		BGUSetTagIntByName_Val_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagIntByName_FunctionAddress, "Val", Classes.FFloatProperty);
		BGUSetTagIntByName_IsValid = BGUSetTagIntByName_FunctionAddress != IntPtr.Zero && BGUSetTagIntByName_Unit_IsValid && BGUSetTagIntByName_TagName_IsValid && BGUSetTagIntByName_Val_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibData:BGUSetTagIntByName", BGUSetTagIntByName_IsValid);
		BGUSetTagInt_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSetTagInt");
		BGUSetTagInt_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetTagInt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagInt_Unit_PropertyAddress, BGUSetTagInt_FunctionAddress, "Unit");
		BGUSetTagInt_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagInt_FunctionAddress, "Unit");
		BGUSetTagInt_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagInt_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagInt_Tag_PropertyAddress, BGUSetTagInt_FunctionAddress, "Tag");
		BGUSetTagInt_Tag_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagInt_FunctionAddress, "Tag");
		BGUSetTagInt_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagInt_FunctionAddress, "Tag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagInt_Val_PropertyAddress, BGUSetTagInt_FunctionAddress, "Val");
		BGUSetTagInt_Val_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagInt_FunctionAddress, "Val");
		BGUSetTagInt_Val_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagInt_FunctionAddress, "Val", Classes.FIntProperty);
		BGUSetTagInt_IsValid = BGUSetTagInt_FunctionAddress != IntPtr.Zero && BGUSetTagInt_Unit_IsValid && BGUSetTagInt_Tag_IsValid && BGUSetTagInt_Val_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibData:BGUSetTagInt", BGUSetTagInt_IsValid);
		BGUSetTagFloatByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSetTagFloatByName");
		BGUSetTagFloatByName_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetTagFloatByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagFloatByName_Unit_PropertyAddress, BGUSetTagFloatByName_FunctionAddress, "Unit");
		BGUSetTagFloatByName_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagFloatByName_FunctionAddress, "Unit");
		BGUSetTagFloatByName_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagFloatByName_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagFloatByName_TagName_PropertyAddress, BGUSetTagFloatByName_FunctionAddress, "TagName");
		BGUSetTagFloatByName_TagName_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagFloatByName_FunctionAddress, "TagName");
		BGUSetTagFloatByName_TagName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagFloatByName_FunctionAddress, "TagName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagFloatByName_Val_PropertyAddress, BGUSetTagFloatByName_FunctionAddress, "Val");
		BGUSetTagFloatByName_Val_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagFloatByName_FunctionAddress, "Val");
		BGUSetTagFloatByName_Val_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagFloatByName_FunctionAddress, "Val", Classes.FFloatProperty);
		BGUSetTagFloatByName_IsValid = BGUSetTagFloatByName_FunctionAddress != IntPtr.Zero && BGUSetTagFloatByName_Unit_IsValid && BGUSetTagFloatByName_TagName_IsValid && BGUSetTagFloatByName_Val_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibData:BGUSetTagFloatByName", BGUSetTagFloatByName_IsValid);
		BGUSetTagFloat_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSetTagFloat");
		BGUSetTagFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetTagFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagFloat_Unit_PropertyAddress, BGUSetTagFloat_FunctionAddress, "Unit");
		BGUSetTagFloat_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagFloat_FunctionAddress, "Unit");
		BGUSetTagFloat_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagFloat_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagFloat_Tag_PropertyAddress, BGUSetTagFloat_FunctionAddress, "Tag");
		BGUSetTagFloat_Tag_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagFloat_FunctionAddress, "Tag");
		BGUSetTagFloat_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagFloat_FunctionAddress, "Tag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagFloat_Val_PropertyAddress, BGUSetTagFloat_FunctionAddress, "Val");
		BGUSetTagFloat_Val_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagFloat_FunctionAddress, "Val");
		BGUSetTagFloat_Val_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagFloat_FunctionAddress, "Val", Classes.FFloatProperty);
		BGUSetTagFloat_IsValid = BGUSetTagFloat_FunctionAddress != IntPtr.Zero && BGUSetTagFloat_Unit_IsValid && BGUSetTagFloat_Tag_IsValid && BGUSetTagFloat_Val_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibData:BGUSetTagFloat", BGUSetTagFloat_IsValid);
		BGUSetTagEnum_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSetTagEnum");
		BGUSetTagEnum_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetTagEnum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagEnum_Unit_PropertyAddress, BGUSetTagEnum_FunctionAddress, "Unit");
		BGUSetTagEnum_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagEnum_FunctionAddress, "Unit");
		BGUSetTagEnum_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagEnum_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagEnum_Tag_PropertyAddress, BGUSetTagEnum_FunctionAddress, "Tag");
		BGUSetTagEnum_Tag_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagEnum_FunctionAddress, "Tag");
		BGUSetTagEnum_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagEnum_FunctionAddress, "Tag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTagEnum_Val_PropertyAddress, BGUSetTagEnum_FunctionAddress, "Val");
		BGUSetTagEnum_Val_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTagEnum_FunctionAddress, "Val");
		BGUSetTagEnum_Val_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTagEnum_FunctionAddress, "Val", Classes.FByteProperty);
		BGUSetTagEnum_IsValid = BGUSetTagEnum_FunctionAddress != IntPtr.Zero && BGUSetTagEnum_Unit_IsValid && BGUSetTagEnum_Tag_IsValid && BGUSetTagEnum_Val_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibData:BGUSetTagEnum", BGUSetTagEnum_IsValid);
		BGUGetTagVector_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetTagVector");
		BGUGetTagVector_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetTagVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagVector_Unit_PropertyAddress, BGUGetTagVector_FunctionAddress, "Unit");
		BGUGetTagVector_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagVector_FunctionAddress, "Unit");
		BGUGetTagVector_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagVector_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagVector_Tag_PropertyAddress, BGUGetTagVector_FunctionAddress, "Tag");
		BGUGetTagVector_Tag_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagVector_FunctionAddress, "Tag");
		BGUGetTagVector_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagVector_FunctionAddress, "Tag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagVector_IsValid_PropertyAddress, BGUGetTagVector_FunctionAddress, "IsValid");
		BGUGetTagVector_IsValid_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagVector_FunctionAddress, "IsValid");
		BGUGetTagVector_IsValid_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagVector_FunctionAddress, "IsValid", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagVector_Out_PropertyAddress, BGUGetTagVector_FunctionAddress, "Out");
		BGUGetTagVector_Out_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagVector_FunctionAddress, "Out");
		BGUGetTagVector_Out_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagVector_FunctionAddress, "Out", Classes.FStructProperty);
		BGUGetTagVector_IsValid = BGUGetTagVector_FunctionAddress != IntPtr.Zero && BGUGetTagVector_Unit_IsValid && BGUGetTagVector_Tag_IsValid && BGUGetTagVector_IsValid_IsValid && BGUGetTagVector_Out_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibData:BGUGetTagVector", BGUGetTagVector_IsValid);
		BGUGetTagObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetTagObject");
		BGUGetTagObject_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetTagObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagObject_Unit_PropertyAddress, BGUGetTagObject_FunctionAddress, "Unit");
		BGUGetTagObject_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagObject_FunctionAddress, "Unit");
		BGUGetTagObject_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagObject_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagObject_Tag_PropertyAddress, BGUGetTagObject_FunctionAddress, "Tag");
		BGUGetTagObject_Tag_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagObject_FunctionAddress, "Tag");
		BGUGetTagObject_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagObject_FunctionAddress, "Tag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagObject_ReturnValue_PropertyAddress, BGUGetTagObject_FunctionAddress, "ReturnValue");
		BGUGetTagObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagObject_FunctionAddress, "ReturnValue");
		BGUGetTagObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BGUGetTagObject_IsValid = BGUGetTagObject_FunctionAddress != IntPtr.Zero && BGUGetTagObject_Unit_IsValid && BGUGetTagObject_Tag_IsValid && BGUGetTagObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibData:BGUGetTagObject", BGUGetTagObject_IsValid);
		BGUGetTagName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetTagName");
		BGUGetTagName_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetTagName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagName_Unit_PropertyAddress, BGUGetTagName_FunctionAddress, "Unit");
		BGUGetTagName_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagName_FunctionAddress, "Unit");
		BGUGetTagName_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagName_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagName_Tag_PropertyAddress, BGUGetTagName_FunctionAddress, "Tag");
		BGUGetTagName_Tag_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagName_FunctionAddress, "Tag");
		BGUGetTagName_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagName_FunctionAddress, "Tag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagName_IsValid_PropertyAddress, BGUGetTagName_FunctionAddress, "IsValid");
		BGUGetTagName_IsValid_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagName_FunctionAddress, "IsValid");
		BGUGetTagName_IsValid_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagName_FunctionAddress, "IsValid", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagName_Out_PropertyAddress, BGUGetTagName_FunctionAddress, "Out");
		BGUGetTagName_Out_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagName_FunctionAddress, "Out");
		BGUGetTagName_Out_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagName_FunctionAddress, "Out", Classes.FNameProperty);
		BGUGetTagName_IsValid = BGUGetTagName_FunctionAddress != IntPtr.Zero && BGUGetTagName_Unit_IsValid && BGUGetTagName_Tag_IsValid && BGUGetTagName_IsValid_IsValid && BGUGetTagName_Out_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibData:BGUGetTagName", BGUGetTagName_IsValid);
		BGUGetTagIntByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetTagIntByName");
		BGUGetTagIntByName_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetTagIntByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagIntByName_Unit_PropertyAddress, BGUGetTagIntByName_FunctionAddress, "Unit");
		BGUGetTagIntByName_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagIntByName_FunctionAddress, "Unit");
		BGUGetTagIntByName_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagIntByName_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagIntByName_TagName_PropertyAddress, BGUGetTagIntByName_FunctionAddress, "TagName");
		BGUGetTagIntByName_TagName_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagIntByName_FunctionAddress, "TagName");
		BGUGetTagIntByName_TagName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagIntByName_FunctionAddress, "TagName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagIntByName_IsValid_PropertyAddress, BGUGetTagIntByName_FunctionAddress, "IsValid");
		BGUGetTagIntByName_IsValid_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagIntByName_FunctionAddress, "IsValid");
		BGUGetTagIntByName_IsValid_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagIntByName_FunctionAddress, "IsValid", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagIntByName_Out_PropertyAddress, BGUGetTagIntByName_FunctionAddress, "Out");
		BGUGetTagIntByName_Out_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagIntByName_FunctionAddress, "Out");
		BGUGetTagIntByName_Out_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagIntByName_FunctionAddress, "Out", Classes.FIntProperty);
		BGUGetTagIntByName_IsValid = BGUGetTagIntByName_FunctionAddress != IntPtr.Zero && BGUGetTagIntByName_Unit_IsValid && BGUGetTagIntByName_TagName_IsValid && BGUGetTagIntByName_IsValid_IsValid && BGUGetTagIntByName_Out_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibData:BGUGetTagIntByName", BGUGetTagIntByName_IsValid);
		BGUGetTagInt_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetTagInt");
		BGUGetTagInt_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetTagInt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagInt_Unit_PropertyAddress, BGUGetTagInt_FunctionAddress, "Unit");
		BGUGetTagInt_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagInt_FunctionAddress, "Unit");
		BGUGetTagInt_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagInt_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagInt_Tag_PropertyAddress, BGUGetTagInt_FunctionAddress, "Tag");
		BGUGetTagInt_Tag_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagInt_FunctionAddress, "Tag");
		BGUGetTagInt_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagInt_FunctionAddress, "Tag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagInt_IsValid_PropertyAddress, BGUGetTagInt_FunctionAddress, "IsValid");
		BGUGetTagInt_IsValid_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagInt_FunctionAddress, "IsValid");
		BGUGetTagInt_IsValid_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagInt_FunctionAddress, "IsValid", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagInt_Out_PropertyAddress, BGUGetTagInt_FunctionAddress, "Out");
		BGUGetTagInt_Out_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagInt_FunctionAddress, "Out");
		BGUGetTagInt_Out_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagInt_FunctionAddress, "Out", Classes.FIntProperty);
		BGUGetTagInt_IsValid = BGUGetTagInt_FunctionAddress != IntPtr.Zero && BGUGetTagInt_Unit_IsValid && BGUGetTagInt_Tag_IsValid && BGUGetTagInt_IsValid_IsValid && BGUGetTagInt_Out_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibData:BGUGetTagInt", BGUGetTagInt_IsValid);
		BGUGetTagFloatByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetTagFloatByName");
		BGUGetTagFloatByName_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetTagFloatByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagFloatByName_Unit_PropertyAddress, BGUGetTagFloatByName_FunctionAddress, "Unit");
		BGUGetTagFloatByName_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagFloatByName_FunctionAddress, "Unit");
		BGUGetTagFloatByName_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagFloatByName_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagFloatByName_TagName_PropertyAddress, BGUGetTagFloatByName_FunctionAddress, "TagName");
		BGUGetTagFloatByName_TagName_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagFloatByName_FunctionAddress, "TagName");
		BGUGetTagFloatByName_TagName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagFloatByName_FunctionAddress, "TagName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagFloatByName_IsValid_PropertyAddress, BGUGetTagFloatByName_FunctionAddress, "IsValid");
		BGUGetTagFloatByName_IsValid_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagFloatByName_FunctionAddress, "IsValid");
		BGUGetTagFloatByName_IsValid_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagFloatByName_FunctionAddress, "IsValid", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagFloatByName_Out_PropertyAddress, BGUGetTagFloatByName_FunctionAddress, "Out");
		BGUGetTagFloatByName_Out_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagFloatByName_FunctionAddress, "Out");
		BGUGetTagFloatByName_Out_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagFloatByName_FunctionAddress, "Out", Classes.FFloatProperty);
		BGUGetTagFloatByName_IsValid = BGUGetTagFloatByName_FunctionAddress != IntPtr.Zero && BGUGetTagFloatByName_Unit_IsValid && BGUGetTagFloatByName_TagName_IsValid && BGUGetTagFloatByName_IsValid_IsValid && BGUGetTagFloatByName_Out_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibData:BGUGetTagFloatByName", BGUGetTagFloatByName_IsValid);
		BGUGetTagFloat_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetTagFloat");
		BGUGetTagFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetTagFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagFloat_Unit_PropertyAddress, BGUGetTagFloat_FunctionAddress, "Unit");
		BGUGetTagFloat_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagFloat_FunctionAddress, "Unit");
		BGUGetTagFloat_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagFloat_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagFloat_Tag_PropertyAddress, BGUGetTagFloat_FunctionAddress, "Tag");
		BGUGetTagFloat_Tag_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagFloat_FunctionAddress, "Tag");
		BGUGetTagFloat_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagFloat_FunctionAddress, "Tag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagFloat_IsValid_PropertyAddress, BGUGetTagFloat_FunctionAddress, "IsValid");
		BGUGetTagFloat_IsValid_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagFloat_FunctionAddress, "IsValid");
		BGUGetTagFloat_IsValid_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagFloat_FunctionAddress, "IsValid", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagFloat_Out_PropertyAddress, BGUGetTagFloat_FunctionAddress, "Out");
		BGUGetTagFloat_Out_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagFloat_FunctionAddress, "Out");
		BGUGetTagFloat_Out_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagFloat_FunctionAddress, "Out", Classes.FFloatProperty);
		BGUGetTagFloat_IsValid = BGUGetTagFloat_FunctionAddress != IntPtr.Zero && BGUGetTagFloat_Unit_IsValid && BGUGetTagFloat_Tag_IsValid && BGUGetTagFloat_IsValid_IsValid && BGUGetTagFloat_Out_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibData:BGUGetTagFloat", BGUGetTagFloat_IsValid);
		BGUGetTagEnum_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetTagEnum");
		BGUGetTagEnum_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetTagEnum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagEnum_Unit_PropertyAddress, BGUGetTagEnum_FunctionAddress, "Unit");
		BGUGetTagEnum_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagEnum_FunctionAddress, "Unit");
		BGUGetTagEnum_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagEnum_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagEnum_Tag_PropertyAddress, BGUGetTagEnum_FunctionAddress, "Tag");
		BGUGetTagEnum_Tag_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagEnum_FunctionAddress, "Tag");
		BGUGetTagEnum_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagEnum_FunctionAddress, "Tag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagEnum_IsValid_PropertyAddress, BGUGetTagEnum_FunctionAddress, "IsValid");
		BGUGetTagEnum_IsValid_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagEnum_FunctionAddress, "IsValid");
		BGUGetTagEnum_IsValid_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagEnum_FunctionAddress, "IsValid", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTagEnum_Out_PropertyAddress, BGUGetTagEnum_FunctionAddress, "Out");
		BGUGetTagEnum_Out_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTagEnum_FunctionAddress, "Out");
		BGUGetTagEnum_Out_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTagEnum_FunctionAddress, "Out", Classes.FByteProperty);
		BGUGetTagEnum_IsValid = BGUGetTagEnum_FunctionAddress != IntPtr.Zero && BGUGetTagEnum_Unit_IsValid && BGUGetTagEnum_Tag_IsValid && BGUGetTagEnum_IsValid_IsValid && BGUGetTagEnum_Out_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibData:BGUGetTagEnum", BGUGetTagEnum_IsValid);
	}
}
