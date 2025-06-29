using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVM;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/RigVM.RigVM", "RigVM", UnrealModuleType.Engine)]
public class URigVM : UObject
{
	private static bool SetParameterValueVector2D_IsValid;

	private static IntPtr SetParameterValueVector2D_FunctionAddress;

	private static int SetParameterValueVector2D_ParamsSize;

	private static bool SetParameterValueVector2D_InParameterName_IsValid;

	private static FFieldAddress SetParameterValueVector2D_InParameterName_PropertyAddress;

	private static int SetParameterValueVector2D_InParameterName_Offset;

	private static bool SetParameterValueVector2D_InValue_IsValid;

	private static FFieldAddress SetParameterValueVector2D_InValue_PropertyAddress;

	private static int SetParameterValueVector2D_InValue_Offset;

	private static bool SetParameterValueVector2D_InArrayIndex_IsValid;

	private static FFieldAddress SetParameterValueVector2D_InArrayIndex_PropertyAddress;

	private static int SetParameterValueVector2D_InArrayIndex_Offset;

	private static bool SetParameterValueVector_IsValid;

	private static IntPtr SetParameterValueVector_FunctionAddress;

	private static int SetParameterValueVector_ParamsSize;

	private static bool SetParameterValueVector_InParameterName_IsValid;

	private static FFieldAddress SetParameterValueVector_InParameterName_PropertyAddress;

	private static int SetParameterValueVector_InParameterName_Offset;

	private static bool SetParameterValueVector_InValue_IsValid;

	private static FFieldAddress SetParameterValueVector_InValue_PropertyAddress;

	private static int SetParameterValueVector_InValue_Offset;

	private static bool SetParameterValueVector_InArrayIndex_IsValid;

	private static FFieldAddress SetParameterValueVector_InArrayIndex_PropertyAddress;

	private static int SetParameterValueVector_InArrayIndex_Offset;

	private static bool SetParameterValueTransform_IsValid;

	private static IntPtr SetParameterValueTransform_FunctionAddress;

	private static int SetParameterValueTransform_ParamsSize;

	private static bool SetParameterValueTransform_InParameterName_IsValid;

	private static FFieldAddress SetParameterValueTransform_InParameterName_PropertyAddress;

	private static int SetParameterValueTransform_InParameterName_Offset;

	private static bool SetParameterValueTransform_InValue_IsValid;

	private static FFieldAddress SetParameterValueTransform_InValue_PropertyAddress;

	private static int SetParameterValueTransform_InValue_Offset;

	private static bool SetParameterValueTransform_InArrayIndex_IsValid;

	private static FFieldAddress SetParameterValueTransform_InArrayIndex_PropertyAddress;

	private static int SetParameterValueTransform_InArrayIndex_Offset;

	private static bool SetParameterValueString_IsValid;

	private static IntPtr SetParameterValueString_FunctionAddress;

	private static int SetParameterValueString_ParamsSize;

	private static bool SetParameterValueString_InParameterName_IsValid;

	private static FFieldAddress SetParameterValueString_InParameterName_PropertyAddress;

	private static int SetParameterValueString_InParameterName_Offset;

	private static bool SetParameterValueString_InValue_IsValid;

	private static FFieldAddress SetParameterValueString_InValue_PropertyAddress;

	private static int SetParameterValueString_InValue_Offset;

	private static bool SetParameterValueString_InArrayIndex_IsValid;

	private static FFieldAddress SetParameterValueString_InArrayIndex_PropertyAddress;

	private static int SetParameterValueString_InArrayIndex_Offset;

	private static bool SetParameterValueQuat_IsValid;

	private static IntPtr SetParameterValueQuat_FunctionAddress;

	private static int SetParameterValueQuat_ParamsSize;

	private static bool SetParameterValueQuat_InParameterName_IsValid;

	private static FFieldAddress SetParameterValueQuat_InParameterName_PropertyAddress;

	private static int SetParameterValueQuat_InParameterName_Offset;

	private static bool SetParameterValueQuat_InValue_IsValid;

	private static FFieldAddress SetParameterValueQuat_InValue_PropertyAddress;

	private static int SetParameterValueQuat_InValue_Offset;

	private static bool SetParameterValueQuat_InArrayIndex_IsValid;

	private static FFieldAddress SetParameterValueQuat_InArrayIndex_PropertyAddress;

	private static int SetParameterValueQuat_InArrayIndex_Offset;

	private static bool SetParameterValueName_IsValid;

	private static IntPtr SetParameterValueName_FunctionAddress;

	private static int SetParameterValueName_ParamsSize;

	private static bool SetParameterValueName_InParameterName_IsValid;

	private static FFieldAddress SetParameterValueName_InParameterName_PropertyAddress;

	private static int SetParameterValueName_InParameterName_Offset;

	private static bool SetParameterValueName_InValue_IsValid;

	private static FFieldAddress SetParameterValueName_InValue_PropertyAddress;

	private static int SetParameterValueName_InValue_Offset;

	private static bool SetParameterValueName_InArrayIndex_IsValid;

	private static FFieldAddress SetParameterValueName_InArrayIndex_PropertyAddress;

	private static int SetParameterValueName_InArrayIndex_Offset;

	private static bool SetParameterValueInt_IsValid;

	private static IntPtr SetParameterValueInt_FunctionAddress;

	private static int SetParameterValueInt_ParamsSize;

	private static bool SetParameterValueInt_InParameterName_IsValid;

	private static FFieldAddress SetParameterValueInt_InParameterName_PropertyAddress;

	private static int SetParameterValueInt_InParameterName_Offset;

	private static bool SetParameterValueInt_InValue_IsValid;

	private static FFieldAddress SetParameterValueInt_InValue_PropertyAddress;

	private static int SetParameterValueInt_InValue_Offset;

	private static bool SetParameterValueInt_InArrayIndex_IsValid;

	private static FFieldAddress SetParameterValueInt_InArrayIndex_PropertyAddress;

	private static int SetParameterValueInt_InArrayIndex_Offset;

	private static bool SetParameterValueFloat_IsValid;

	private static IntPtr SetParameterValueFloat_FunctionAddress;

	private static int SetParameterValueFloat_ParamsSize;

	private static bool SetParameterValueFloat_InParameterName_IsValid;

	private static FFieldAddress SetParameterValueFloat_InParameterName_PropertyAddress;

	private static int SetParameterValueFloat_InParameterName_Offset;

	private static bool SetParameterValueFloat_InValue_IsValid;

	private static FFieldAddress SetParameterValueFloat_InValue_PropertyAddress;

	private static int SetParameterValueFloat_InValue_Offset;

	private static bool SetParameterValueFloat_InArrayIndex_IsValid;

	private static FFieldAddress SetParameterValueFloat_InArrayIndex_PropertyAddress;

	private static int SetParameterValueFloat_InArrayIndex_Offset;

	private static bool SetParameterValueDouble_IsValid;

	private static IntPtr SetParameterValueDouble_FunctionAddress;

	private static int SetParameterValueDouble_ParamsSize;

	private static bool SetParameterValueDouble_InParameterName_IsValid;

	private static FFieldAddress SetParameterValueDouble_InParameterName_PropertyAddress;

	private static int SetParameterValueDouble_InParameterName_Offset;

	private static bool SetParameterValueDouble_InValue_IsValid;

	private static FFieldAddress SetParameterValueDouble_InValue_PropertyAddress;

	private static int SetParameterValueDouble_InValue_Offset;

	private static bool SetParameterValueDouble_InArrayIndex_IsValid;

	private static FFieldAddress SetParameterValueDouble_InArrayIndex_PropertyAddress;

	private static int SetParameterValueDouble_InArrayIndex_Offset;

	private static bool SetParameterValueBool_IsValid;

	private static IntPtr SetParameterValueBool_FunctionAddress;

	private static int SetParameterValueBool_ParamsSize;

	private static bool SetParameterValueBool_InParameterName_IsValid;

	private static FFieldAddress SetParameterValueBool_InParameterName_PropertyAddress;

	private static int SetParameterValueBool_InParameterName_Offset;

	private static bool SetParameterValueBool_InValue_IsValid;

	private static FFieldAddress SetParameterValueBool_InValue_PropertyAddress;

	private static int SetParameterValueBool_InValue_Offset;

	private static bool SetParameterValueBool_InArrayIndex_IsValid;

	private static FFieldAddress SetParameterValueBool_InArrayIndex_PropertyAddress;

	private static int SetParameterValueBool_InArrayIndex_Offset;

	private static bool GetParameterValueVector2D_IsValid;

	private static IntPtr GetParameterValueVector2D_FunctionAddress;

	private static int GetParameterValueVector2D_ParamsSize;

	private static bool GetParameterValueVector2D_InParameterName_IsValid;

	private static FFieldAddress GetParameterValueVector2D_InParameterName_PropertyAddress;

	private static int GetParameterValueVector2D_InParameterName_Offset;

	private static bool GetParameterValueVector2D_InArrayIndex_IsValid;

	private static FFieldAddress GetParameterValueVector2D_InArrayIndex_PropertyAddress;

	private static int GetParameterValueVector2D_InArrayIndex_Offset;

	private static bool GetParameterValueVector2D_ReturnValue_IsValid;

	private static FFieldAddress GetParameterValueVector2D_ReturnValue_PropertyAddress;

	private static int GetParameterValueVector2D_ReturnValue_Offset;

	private static bool GetParameterValueVector_IsValid;

	private static IntPtr GetParameterValueVector_FunctionAddress;

	private static int GetParameterValueVector_ParamsSize;

	private static bool GetParameterValueVector_InParameterName_IsValid;

	private static FFieldAddress GetParameterValueVector_InParameterName_PropertyAddress;

	private static int GetParameterValueVector_InParameterName_Offset;

	private static bool GetParameterValueVector_InArrayIndex_IsValid;

	private static FFieldAddress GetParameterValueVector_InArrayIndex_PropertyAddress;

	private static int GetParameterValueVector_InArrayIndex_Offset;

	private static bool GetParameterValueVector_ReturnValue_IsValid;

	private static FFieldAddress GetParameterValueVector_ReturnValue_PropertyAddress;

	private static int GetParameterValueVector_ReturnValue_Offset;

	private static bool GetParameterValueTransform_IsValid;

	private static IntPtr GetParameterValueTransform_FunctionAddress;

	private static int GetParameterValueTransform_ParamsSize;

	private static bool GetParameterValueTransform_InParameterName_IsValid;

	private static FFieldAddress GetParameterValueTransform_InParameterName_PropertyAddress;

	private static int GetParameterValueTransform_InParameterName_Offset;

	private static bool GetParameterValueTransform_InArrayIndex_IsValid;

	private static FFieldAddress GetParameterValueTransform_InArrayIndex_PropertyAddress;

	private static int GetParameterValueTransform_InArrayIndex_Offset;

	private static bool GetParameterValueTransform_ReturnValue_IsValid;

	private static FFieldAddress GetParameterValueTransform_ReturnValue_PropertyAddress;

	private static int GetParameterValueTransform_ReturnValue_Offset;

	private static bool GetParameterValueString_IsValid;

	private static IntPtr GetParameterValueString_FunctionAddress;

	private static int GetParameterValueString_ParamsSize;

	private static bool GetParameterValueString_InParameterName_IsValid;

	private static FFieldAddress GetParameterValueString_InParameterName_PropertyAddress;

	private static int GetParameterValueString_InParameterName_Offset;

	private static bool GetParameterValueString_InArrayIndex_IsValid;

	private static FFieldAddress GetParameterValueString_InArrayIndex_PropertyAddress;

	private static int GetParameterValueString_InArrayIndex_Offset;

	private static bool GetParameterValueString_ReturnValue_IsValid;

	private static FFieldAddress GetParameterValueString_ReturnValue_PropertyAddress;

	private static int GetParameterValueString_ReturnValue_Offset;

	private static bool GetParameterValueQuat_IsValid;

	private static IntPtr GetParameterValueQuat_FunctionAddress;

	private static int GetParameterValueQuat_ParamsSize;

	private static bool GetParameterValueQuat_InParameterName_IsValid;

	private static FFieldAddress GetParameterValueQuat_InParameterName_PropertyAddress;

	private static int GetParameterValueQuat_InParameterName_Offset;

	private static bool GetParameterValueQuat_InArrayIndex_IsValid;

	private static FFieldAddress GetParameterValueQuat_InArrayIndex_PropertyAddress;

	private static int GetParameterValueQuat_InArrayIndex_Offset;

	private static bool GetParameterValueQuat_ReturnValue_IsValid;

	private static FFieldAddress GetParameterValueQuat_ReturnValue_PropertyAddress;

	private static int GetParameterValueQuat_ReturnValue_Offset;

	private static bool GetParameterValueName_IsValid;

	private static IntPtr GetParameterValueName_FunctionAddress;

	private static int GetParameterValueName_ParamsSize;

	private static bool GetParameterValueName_InParameterName_IsValid;

	private static FFieldAddress GetParameterValueName_InParameterName_PropertyAddress;

	private static int GetParameterValueName_InParameterName_Offset;

	private static bool GetParameterValueName_InArrayIndex_IsValid;

	private static FFieldAddress GetParameterValueName_InArrayIndex_PropertyAddress;

	private static int GetParameterValueName_InArrayIndex_Offset;

	private static bool GetParameterValueName_ReturnValue_IsValid;

	private static FFieldAddress GetParameterValueName_ReturnValue_PropertyAddress;

	private static int GetParameterValueName_ReturnValue_Offset;

	private static bool GetParameterValueInt_IsValid;

	private static IntPtr GetParameterValueInt_FunctionAddress;

	private static int GetParameterValueInt_ParamsSize;

	private static bool GetParameterValueInt_InParameterName_IsValid;

	private static FFieldAddress GetParameterValueInt_InParameterName_PropertyAddress;

	private static int GetParameterValueInt_InParameterName_Offset;

	private static bool GetParameterValueInt_InArrayIndex_IsValid;

	private static FFieldAddress GetParameterValueInt_InArrayIndex_PropertyAddress;

	private static int GetParameterValueInt_InArrayIndex_Offset;

	private static bool GetParameterValueInt_ReturnValue_IsValid;

	private static FFieldAddress GetParameterValueInt_ReturnValue_PropertyAddress;

	private static int GetParameterValueInt_ReturnValue_Offset;

	private static bool GetParameterValueFloat_IsValid;

	private static IntPtr GetParameterValueFloat_FunctionAddress;

	private static int GetParameterValueFloat_ParamsSize;

	private static bool GetParameterValueFloat_InParameterName_IsValid;

	private static FFieldAddress GetParameterValueFloat_InParameterName_PropertyAddress;

	private static int GetParameterValueFloat_InParameterName_Offset;

	private static bool GetParameterValueFloat_InArrayIndex_IsValid;

	private static FFieldAddress GetParameterValueFloat_InArrayIndex_PropertyAddress;

	private static int GetParameterValueFloat_InArrayIndex_Offset;

	private static bool GetParameterValueFloat_ReturnValue_IsValid;

	private static FFieldAddress GetParameterValueFloat_ReturnValue_PropertyAddress;

	private static int GetParameterValueFloat_ReturnValue_Offset;

	private static bool GetParameterValueDouble_IsValid;

	private static IntPtr GetParameterValueDouble_FunctionAddress;

	private static int GetParameterValueDouble_ParamsSize;

	private static bool GetParameterValueDouble_InParameterName_IsValid;

	private static FFieldAddress GetParameterValueDouble_InParameterName_PropertyAddress;

	private static int GetParameterValueDouble_InParameterName_Offset;

	private static bool GetParameterValueDouble_InArrayIndex_IsValid;

	private static FFieldAddress GetParameterValueDouble_InArrayIndex_PropertyAddress;

	private static int GetParameterValueDouble_InArrayIndex_Offset;

	private static bool GetParameterValueDouble_ReturnValue_IsValid;

	private static FFieldAddress GetParameterValueDouble_ReturnValue_PropertyAddress;

	private static int GetParameterValueDouble_ReturnValue_Offset;

	private static bool GetParameterValueBool_IsValid;

	private static IntPtr GetParameterValueBool_FunctionAddress;

	private static int GetParameterValueBool_ParamsSize;

	private static bool GetParameterValueBool_InParameterName_IsValid;

	private static FFieldAddress GetParameterValueBool_InParameterName_PropertyAddress;

	private static int GetParameterValueBool_InParameterName_Offset;

	private static bool GetParameterValueBool_InArrayIndex_IsValid;

	private static FFieldAddress GetParameterValueBool_InArrayIndex_PropertyAddress;

	private static int GetParameterValueBool_InArrayIndex_Offset;

	private static bool GetParameterValueBool_ReturnValue_IsValid;

	private static FFieldAddress GetParameterValueBool_ReturnValue_PropertyAddress;

	private static int GetParameterValueBool_ReturnValue_Offset;

	private static bool Execute_IsValid;

	private static IntPtr Execute_FunctionAddress;

	private static int Execute_ParamsSize;

	private static bool Execute_InEntryName_IsValid;

	private static FFieldAddress Execute_InEntryName_PropertyAddress;

	private static int Execute_InEntryName_Offset;

	private static bool Execute_ReturnValue_IsValid;

	private static FFieldAddress Execute_ReturnValue_PropertyAddress;

	private static int Execute_ReturnValue_Offset;

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/RigVM.RigVM:SetParameterValueVector2D")]
	public unsafe void SetParameterValueVector2D(FName InParameterName, FVector2D InValue, int InArrayIndex = 0)
	{
		CheckDestroyed();
		if (!SetParameterValueVector2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVM.RigVM:SetParameterValueVector2D");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetParameterValueVector2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetParameterValueVector2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetParameterValueVector2D_InParameterName_Offset), 0, SetParameterValueVector2D_InParameterName_PropertyAddress.Address, InParameterName);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetParameterValueVector2D_InValue_Offset), 0, SetParameterValueVector2D_InValue_PropertyAddress.Address, InValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetParameterValueVector2D_InArrayIndex_Offset), 0, SetParameterValueVector2D_InArrayIndex_PropertyAddress.Address, InArrayIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetParameterValueVector2D_FunctionAddress, intPtr, SetParameterValueVector2D_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/RigVM.RigVM:SetParameterValueVector")]
	public unsafe void SetParameterValueVector(FName InParameterName, FVector InValue, int InArrayIndex = 0)
	{
		CheckDestroyed();
		if (!SetParameterValueVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVM.RigVM:SetParameterValueVector");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetParameterValueVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetParameterValueVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetParameterValueVector_InParameterName_Offset), 0, SetParameterValueVector_InParameterName_PropertyAddress.Address, InParameterName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetParameterValueVector_InValue_Offset), 0, SetParameterValueVector_InValue_PropertyAddress.Address, InValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetParameterValueVector_InArrayIndex_Offset), 0, SetParameterValueVector_InArrayIndex_PropertyAddress.Address, InArrayIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetParameterValueVector_FunctionAddress, intPtr, SetParameterValueVector_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/RigVM.RigVM:SetParameterValueTransform")]
	public unsafe void SetParameterValueTransform(FName InParameterName, FTransform InValue, int InArrayIndex = 0)
	{
		CheckDestroyed();
		if (!SetParameterValueTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVM.RigVM:SetParameterValueTransform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetParameterValueTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetParameterValueTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetParameterValueTransform_InParameterName_Offset), 0, SetParameterValueTransform_InParameterName_PropertyAddress.Address, InParameterName);
		NativeReflection.InitializeValue_InContainer(SetParameterValueTransform_InValue_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetParameterValueTransform_InValue_Offset), 0, SetParameterValueTransform_InValue_PropertyAddress.Address, InValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetParameterValueTransform_InArrayIndex_Offset), 0, SetParameterValueTransform_InArrayIndex_PropertyAddress.Address, InArrayIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetParameterValueTransform_FunctionAddress, intPtr, SetParameterValueTransform_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVM.RigVM:SetParameterValueString")]
	public unsafe void SetParameterValueString(FName InParameterName, string InValue, int InArrayIndex = 0)
	{
		CheckDestroyed();
		if (!SetParameterValueString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVM.RigVM:SetParameterValueString");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetParameterValueString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetParameterValueString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetParameterValueString_InParameterName_Offset), 0, SetParameterValueString_InParameterName_PropertyAddress.Address, InParameterName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetParameterValueString_InValue_Offset), 0, SetParameterValueString_InValue_PropertyAddress.Address, InValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetParameterValueString_InArrayIndex_Offset), 0, SetParameterValueString_InArrayIndex_PropertyAddress.Address, InArrayIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetParameterValueString_FunctionAddress, intPtr, SetParameterValueString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetParameterValueString_InValue_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/RigVM.RigVM:SetParameterValueQuat")]
	public unsafe void SetParameterValueQuat(FName InParameterName, FQuat InValue, int InArrayIndex = 0)
	{
		CheckDestroyed();
		if (!SetParameterValueQuat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVM.RigVM:SetParameterValueQuat");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetParameterValueQuat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetParameterValueQuat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetParameterValueQuat_InParameterName_Offset), 0, SetParameterValueQuat_InParameterName_PropertyAddress.Address, InParameterName);
		NativeReflection.InitializeValue_InContainer(SetParameterValueQuat_InValue_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(intPtr, SetParameterValueQuat_InValue_Offset), 0, SetParameterValueQuat_InValue_PropertyAddress.Address, InValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetParameterValueQuat_InArrayIndex_Offset), 0, SetParameterValueQuat_InArrayIndex_PropertyAddress.Address, InArrayIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetParameterValueQuat_FunctionAddress, intPtr, SetParameterValueQuat_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVM.RigVM:SetParameterValueName")]
	public unsafe void SetParameterValueName(FName InParameterName, FName InValue, int InArrayIndex = 0)
	{
		CheckDestroyed();
		if (!SetParameterValueName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVM.RigVM:SetParameterValueName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetParameterValueName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetParameterValueName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetParameterValueName_InParameterName_Offset), 0, SetParameterValueName_InParameterName_PropertyAddress.Address, InParameterName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetParameterValueName_InValue_Offset), 0, SetParameterValueName_InValue_PropertyAddress.Address, InValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetParameterValueName_InArrayIndex_Offset), 0, SetParameterValueName_InArrayIndex_PropertyAddress.Address, InArrayIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetParameterValueName_FunctionAddress, intPtr, SetParameterValueName_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVM.RigVM:SetParameterValueInt")]
	public unsafe void SetParameterValueInt(FName InParameterName, int InValue, int InArrayIndex = 0)
	{
		CheckDestroyed();
		if (!SetParameterValueInt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVM.RigVM:SetParameterValueInt");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetParameterValueInt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetParameterValueInt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetParameterValueInt_InParameterName_Offset), 0, SetParameterValueInt_InParameterName_PropertyAddress.Address, InParameterName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetParameterValueInt_InValue_Offset), 0, SetParameterValueInt_InValue_PropertyAddress.Address, InValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetParameterValueInt_InArrayIndex_Offset), 0, SetParameterValueInt_InArrayIndex_PropertyAddress.Address, InArrayIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetParameterValueInt_FunctionAddress, intPtr, SetParameterValueInt_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVM.RigVM:SetParameterValueFloat")]
	public unsafe void SetParameterValueFloat(FName InParameterName, float InValue, int InArrayIndex = 0)
	{
		CheckDestroyed();
		if (!SetParameterValueFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVM.RigVM:SetParameterValueFloat");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetParameterValueFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetParameterValueFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetParameterValueFloat_InParameterName_Offset), 0, SetParameterValueFloat_InParameterName_PropertyAddress.Address, InParameterName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetParameterValueFloat_InValue_Offset), 0, SetParameterValueFloat_InValue_PropertyAddress.Address, InValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetParameterValueFloat_InArrayIndex_Offset), 0, SetParameterValueFloat_InArrayIndex_PropertyAddress.Address, InArrayIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetParameterValueFloat_FunctionAddress, intPtr, SetParameterValueFloat_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVM.RigVM:SetParameterValueDouble")]
	public unsafe void SetParameterValueDouble(FName InParameterName, double InValue, int InArrayIndex = 0)
	{
		CheckDestroyed();
		if (!SetParameterValueDouble_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVM.RigVM:SetParameterValueDouble");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetParameterValueDouble_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetParameterValueDouble_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetParameterValueDouble_InParameterName_Offset), 0, SetParameterValueDouble_InParameterName_PropertyAddress.Address, InParameterName);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(intPtr, SetParameterValueDouble_InValue_Offset), 0, SetParameterValueDouble_InValue_PropertyAddress.Address, InValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetParameterValueDouble_InArrayIndex_Offset), 0, SetParameterValueDouble_InArrayIndex_PropertyAddress.Address, InArrayIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetParameterValueDouble_FunctionAddress, intPtr, SetParameterValueDouble_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVM.RigVM:SetParameterValueBool")]
	public unsafe void SetParameterValueBool(FName InParameterName, bool InValue, int InArrayIndex = 0)
	{
		CheckDestroyed();
		if (!SetParameterValueBool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVM.RigVM:SetParameterValueBool");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetParameterValueBool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetParameterValueBool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetParameterValueBool_InParameterName_Offset), 0, SetParameterValueBool_InParameterName_PropertyAddress.Address, InParameterName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetParameterValueBool_InValue_Offset), 0, SetParameterValueBool_InValue_PropertyAddress.Address, InValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetParameterValueBool_InArrayIndex_Offset), 0, SetParameterValueBool_InArrayIndex_PropertyAddress.Address, InArrayIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetParameterValueBool_FunctionAddress, intPtr, SetParameterValueBool_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/RigVM.RigVM:GetParameterValueVector2D")]
	public unsafe FVector2D GetParameterValueVector2D(FName InParameterName, int InArrayIndex = 0)
	{
		CheckDestroyed();
		if (!GetParameterValueVector2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVM.RigVM:GetParameterValueVector2D");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParameterValueVector2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParameterValueVector2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetParameterValueVector2D_InParameterName_Offset), 0, GetParameterValueVector2D_InParameterName_PropertyAddress.Address, InParameterName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetParameterValueVector2D_InArrayIndex_Offset), 0, GetParameterValueVector2D_InArrayIndex_PropertyAddress.Address, InArrayIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParameterValueVector2D_FunctionAddress, intPtr, GetParameterValueVector2D_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetParameterValueVector2D_ReturnValue_Offset), 0, GetParameterValueVector2D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/RigVM.RigVM:GetParameterValueVector")]
	public unsafe FVector GetParameterValueVector(FName InParameterName, int InArrayIndex = 0)
	{
		CheckDestroyed();
		if (!GetParameterValueVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVM.RigVM:GetParameterValueVector");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParameterValueVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParameterValueVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetParameterValueVector_InParameterName_Offset), 0, GetParameterValueVector_InParameterName_PropertyAddress.Address, InParameterName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetParameterValueVector_InArrayIndex_Offset), 0, GetParameterValueVector_InArrayIndex_PropertyAddress.Address, InArrayIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParameterValueVector_FunctionAddress, intPtr, GetParameterValueVector_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetParameterValueVector_ReturnValue_Offset), 0, GetParameterValueVector_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/RigVM.RigVM:GetParameterValueTransform")]
	public unsafe FTransform GetParameterValueTransform(FName InParameterName, int InArrayIndex = 0)
	{
		CheckDestroyed();
		if (!GetParameterValueTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVM.RigVM:GetParameterValueTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParameterValueTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParameterValueTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetParameterValueTransform_InParameterName_Offset), 0, GetParameterValueTransform_InParameterName_PropertyAddress.Address, InParameterName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetParameterValueTransform_InArrayIndex_Offset), 0, GetParameterValueTransform_InArrayIndex_PropertyAddress.Address, InArrayIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParameterValueTransform_FunctionAddress, intPtr, GetParameterValueTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetParameterValueTransform_ReturnValue_Offset), 0, GetParameterValueTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVM.RigVM:GetParameterValueString")]
	public unsafe string GetParameterValueString(FName InParameterName, int InArrayIndex = 0)
	{
		CheckDestroyed();
		if (!GetParameterValueString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVM.RigVM:GetParameterValueString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParameterValueString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParameterValueString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetParameterValueString_InParameterName_Offset), 0, GetParameterValueString_InParameterName_PropertyAddress.Address, InParameterName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetParameterValueString_InArrayIndex_Offset), 0, GetParameterValueString_InArrayIndex_PropertyAddress.Address, InArrayIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParameterValueString_FunctionAddress, intPtr, GetParameterValueString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetParameterValueString_ReturnValue_Offset), 0, GetParameterValueString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetParameterValueString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/RigVM.RigVM:GetParameterValueQuat")]
	public unsafe FQuat GetParameterValueQuat(FName InParameterName, int InArrayIndex = 0)
	{
		CheckDestroyed();
		if (!GetParameterValueQuat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVM.RigVM:GetParameterValueQuat");
			return default(FQuat);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParameterValueQuat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParameterValueQuat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetParameterValueQuat_InParameterName_Offset), 0, GetParameterValueQuat_InParameterName_PropertyAddress.Address, InParameterName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetParameterValueQuat_InArrayIndex_Offset), 0, GetParameterValueQuat_InArrayIndex_PropertyAddress.Address, InArrayIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParameterValueQuat_FunctionAddress, intPtr, GetParameterValueQuat_ParamsSize);
		return BlittableTypeMarshaler<FQuat>.FromNative(IntPtr.Add(intPtr, GetParameterValueQuat_ReturnValue_Offset), 0, GetParameterValueQuat_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVM.RigVM:GetParameterValueName")]
	public unsafe FName GetParameterValueName(FName InParameterName, int InArrayIndex = 0)
	{
		CheckDestroyed();
		if (!GetParameterValueName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVM.RigVM:GetParameterValueName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParameterValueName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParameterValueName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetParameterValueName_InParameterName_Offset), 0, GetParameterValueName_InParameterName_PropertyAddress.Address, InParameterName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetParameterValueName_InArrayIndex_Offset), 0, GetParameterValueName_InArrayIndex_PropertyAddress.Address, InArrayIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParameterValueName_FunctionAddress, intPtr, GetParameterValueName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetParameterValueName_ReturnValue_Offset), 0, GetParameterValueName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVM.RigVM:GetParameterValueInt")]
	public unsafe int GetParameterValueInt(FName InParameterName, int InArrayIndex = 0)
	{
		CheckDestroyed();
		if (!GetParameterValueInt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVM.RigVM:GetParameterValueInt");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParameterValueInt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParameterValueInt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetParameterValueInt_InParameterName_Offset), 0, GetParameterValueInt_InParameterName_PropertyAddress.Address, InParameterName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetParameterValueInt_InArrayIndex_Offset), 0, GetParameterValueInt_InArrayIndex_PropertyAddress.Address, InArrayIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParameterValueInt_FunctionAddress, intPtr, GetParameterValueInt_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetParameterValueInt_ReturnValue_Offset), 0, GetParameterValueInt_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVM.RigVM:GetParameterValueFloat")]
	public unsafe float GetParameterValueFloat(FName InParameterName, int InArrayIndex = 0)
	{
		CheckDestroyed();
		if (!GetParameterValueFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVM.RigVM:GetParameterValueFloat");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParameterValueFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParameterValueFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetParameterValueFloat_InParameterName_Offset), 0, GetParameterValueFloat_InParameterName_PropertyAddress.Address, InParameterName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetParameterValueFloat_InArrayIndex_Offset), 0, GetParameterValueFloat_InArrayIndex_PropertyAddress.Address, InArrayIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParameterValueFloat_FunctionAddress, intPtr, GetParameterValueFloat_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetParameterValueFloat_ReturnValue_Offset), 0, GetParameterValueFloat_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVM.RigVM:GetParameterValueDouble")]
	public unsafe double GetParameterValueDouble(FName InParameterName, int InArrayIndex = 0)
	{
		CheckDestroyed();
		if (!GetParameterValueDouble_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVM.RigVM:GetParameterValueDouble");
			return 0.0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParameterValueDouble_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParameterValueDouble_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetParameterValueDouble_InParameterName_Offset), 0, GetParameterValueDouble_InParameterName_PropertyAddress.Address, InParameterName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetParameterValueDouble_InArrayIndex_Offset), 0, GetParameterValueDouble_InArrayIndex_PropertyAddress.Address, InArrayIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParameterValueDouble_FunctionAddress, intPtr, GetParameterValueDouble_ParamsSize);
		return BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(intPtr, GetParameterValueDouble_ReturnValue_Offset), 0, GetParameterValueDouble_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVM.RigVM:GetParameterValueBool")]
	public unsafe bool GetParameterValueBool(FName InParameterName, int InArrayIndex = 0)
	{
		CheckDestroyed();
		if (!GetParameterValueBool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVM.RigVM:GetParameterValueBool");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParameterValueBool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParameterValueBool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetParameterValueBool_InParameterName_Offset), 0, GetParameterValueBool_InParameterName_PropertyAddress.Address, InParameterName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetParameterValueBool_InArrayIndex_Offset), 0, GetParameterValueBool_InArrayIndex_PropertyAddress.Address, InArrayIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParameterValueBool_FunctionAddress, intPtr, GetParameterValueBool_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetParameterValueBool_ReturnValue_Offset), 0, GetParameterValueBool_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVM.RigVM:Execute")]
	public unsafe bool Execute(FName InEntryName)
	{
		CheckDestroyed();
		if (!Execute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVM.RigVM:Execute");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Execute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Execute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Execute_InEntryName_Offset), 0, Execute_InEntryName_PropertyAddress.Address, InEntryName);
		NativeReflection.InvokeFunctionOptimized(base.Address, Execute_FunctionAddress, intPtr, Execute_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Execute_ReturnValue_Offset), 0, Execute_ReturnValue_PropertyAddress.Address);
	}

	static URigVM()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URigVM)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URigVM));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/RigVM.RigVM");
		SetParameterValueVector2D_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetParameterValueVector2D");
		SetParameterValueVector2D_ParamsSize = NativeReflection.GetFunctionParamsSize(SetParameterValueVector2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueVector2D_InParameterName_PropertyAddress, SetParameterValueVector2D_FunctionAddress, "InParameterName");
		SetParameterValueVector2D_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueVector2D_FunctionAddress, "InParameterName");
		SetParameterValueVector2D_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueVector2D_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueVector2D_InValue_PropertyAddress, SetParameterValueVector2D_FunctionAddress, "InValue");
		SetParameterValueVector2D_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueVector2D_FunctionAddress, "InValue");
		SetParameterValueVector2D_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueVector2D_FunctionAddress, "InValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueVector2D_InArrayIndex_PropertyAddress, SetParameterValueVector2D_FunctionAddress, "InArrayIndex");
		SetParameterValueVector2D_InArrayIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueVector2D_FunctionAddress, "InArrayIndex");
		SetParameterValueVector2D_InArrayIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueVector2D_FunctionAddress, "InArrayIndex", Classes.FIntProperty);
		SetParameterValueVector2D_IsValid = SetParameterValueVector2D_FunctionAddress != IntPtr.Zero && SetParameterValueVector2D_InParameterName_IsValid && SetParameterValueVector2D_InValue_IsValid && SetParameterValueVector2D_InArrayIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVM.RigVM:SetParameterValueVector2D", SetParameterValueVector2D_IsValid);
		SetParameterValueVector_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetParameterValueVector");
		SetParameterValueVector_ParamsSize = NativeReflection.GetFunctionParamsSize(SetParameterValueVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueVector_InParameterName_PropertyAddress, SetParameterValueVector_FunctionAddress, "InParameterName");
		SetParameterValueVector_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueVector_FunctionAddress, "InParameterName");
		SetParameterValueVector_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueVector_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueVector_InValue_PropertyAddress, SetParameterValueVector_FunctionAddress, "InValue");
		SetParameterValueVector_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueVector_FunctionAddress, "InValue");
		SetParameterValueVector_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueVector_FunctionAddress, "InValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueVector_InArrayIndex_PropertyAddress, SetParameterValueVector_FunctionAddress, "InArrayIndex");
		SetParameterValueVector_InArrayIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueVector_FunctionAddress, "InArrayIndex");
		SetParameterValueVector_InArrayIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueVector_FunctionAddress, "InArrayIndex", Classes.FIntProperty);
		SetParameterValueVector_IsValid = SetParameterValueVector_FunctionAddress != IntPtr.Zero && SetParameterValueVector_InParameterName_IsValid && SetParameterValueVector_InValue_IsValid && SetParameterValueVector_InArrayIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVM.RigVM:SetParameterValueVector", SetParameterValueVector_IsValid);
		SetParameterValueTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetParameterValueTransform");
		SetParameterValueTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetParameterValueTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueTransform_InParameterName_PropertyAddress, SetParameterValueTransform_FunctionAddress, "InParameterName");
		SetParameterValueTransform_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueTransform_FunctionAddress, "InParameterName");
		SetParameterValueTransform_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueTransform_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueTransform_InValue_PropertyAddress, SetParameterValueTransform_FunctionAddress, "InValue");
		SetParameterValueTransform_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueTransform_FunctionAddress, "InValue");
		SetParameterValueTransform_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueTransform_FunctionAddress, "InValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueTransform_InArrayIndex_PropertyAddress, SetParameterValueTransform_FunctionAddress, "InArrayIndex");
		SetParameterValueTransform_InArrayIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueTransform_FunctionAddress, "InArrayIndex");
		SetParameterValueTransform_InArrayIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueTransform_FunctionAddress, "InArrayIndex", Classes.FIntProperty);
		SetParameterValueTransform_IsValid = SetParameterValueTransform_FunctionAddress != IntPtr.Zero && SetParameterValueTransform_InParameterName_IsValid && SetParameterValueTransform_InValue_IsValid && SetParameterValueTransform_InArrayIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVM.RigVM:SetParameterValueTransform", SetParameterValueTransform_IsValid);
		SetParameterValueString_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetParameterValueString");
		SetParameterValueString_ParamsSize = NativeReflection.GetFunctionParamsSize(SetParameterValueString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueString_InParameterName_PropertyAddress, SetParameterValueString_FunctionAddress, "InParameterName");
		SetParameterValueString_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueString_FunctionAddress, "InParameterName");
		SetParameterValueString_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueString_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueString_InValue_PropertyAddress, SetParameterValueString_FunctionAddress, "InValue");
		SetParameterValueString_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueString_FunctionAddress, "InValue");
		SetParameterValueString_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueString_FunctionAddress, "InValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueString_InArrayIndex_PropertyAddress, SetParameterValueString_FunctionAddress, "InArrayIndex");
		SetParameterValueString_InArrayIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueString_FunctionAddress, "InArrayIndex");
		SetParameterValueString_InArrayIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueString_FunctionAddress, "InArrayIndex", Classes.FIntProperty);
		SetParameterValueString_IsValid = SetParameterValueString_FunctionAddress != IntPtr.Zero && SetParameterValueString_InParameterName_IsValid && SetParameterValueString_InValue_IsValid && SetParameterValueString_InArrayIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVM.RigVM:SetParameterValueString", SetParameterValueString_IsValid);
		SetParameterValueQuat_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetParameterValueQuat");
		SetParameterValueQuat_ParamsSize = NativeReflection.GetFunctionParamsSize(SetParameterValueQuat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueQuat_InParameterName_PropertyAddress, SetParameterValueQuat_FunctionAddress, "InParameterName");
		SetParameterValueQuat_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueQuat_FunctionAddress, "InParameterName");
		SetParameterValueQuat_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueQuat_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueQuat_InValue_PropertyAddress, SetParameterValueQuat_FunctionAddress, "InValue");
		SetParameterValueQuat_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueQuat_FunctionAddress, "InValue");
		SetParameterValueQuat_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueQuat_FunctionAddress, "InValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueQuat_InArrayIndex_PropertyAddress, SetParameterValueQuat_FunctionAddress, "InArrayIndex");
		SetParameterValueQuat_InArrayIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueQuat_FunctionAddress, "InArrayIndex");
		SetParameterValueQuat_InArrayIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueQuat_FunctionAddress, "InArrayIndex", Classes.FIntProperty);
		SetParameterValueQuat_IsValid = SetParameterValueQuat_FunctionAddress != IntPtr.Zero && SetParameterValueQuat_InParameterName_IsValid && SetParameterValueQuat_InValue_IsValid && SetParameterValueQuat_InArrayIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVM.RigVM:SetParameterValueQuat", SetParameterValueQuat_IsValid);
		SetParameterValueName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetParameterValueName");
		SetParameterValueName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetParameterValueName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueName_InParameterName_PropertyAddress, SetParameterValueName_FunctionAddress, "InParameterName");
		SetParameterValueName_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueName_FunctionAddress, "InParameterName");
		SetParameterValueName_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueName_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueName_InValue_PropertyAddress, SetParameterValueName_FunctionAddress, "InValue");
		SetParameterValueName_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueName_FunctionAddress, "InValue");
		SetParameterValueName_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueName_FunctionAddress, "InValue", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueName_InArrayIndex_PropertyAddress, SetParameterValueName_FunctionAddress, "InArrayIndex");
		SetParameterValueName_InArrayIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueName_FunctionAddress, "InArrayIndex");
		SetParameterValueName_InArrayIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueName_FunctionAddress, "InArrayIndex", Classes.FIntProperty);
		SetParameterValueName_IsValid = SetParameterValueName_FunctionAddress != IntPtr.Zero && SetParameterValueName_InParameterName_IsValid && SetParameterValueName_InValue_IsValid && SetParameterValueName_InArrayIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVM.RigVM:SetParameterValueName", SetParameterValueName_IsValid);
		SetParameterValueInt_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetParameterValueInt");
		SetParameterValueInt_ParamsSize = NativeReflection.GetFunctionParamsSize(SetParameterValueInt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueInt_InParameterName_PropertyAddress, SetParameterValueInt_FunctionAddress, "InParameterName");
		SetParameterValueInt_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueInt_FunctionAddress, "InParameterName");
		SetParameterValueInt_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueInt_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueInt_InValue_PropertyAddress, SetParameterValueInt_FunctionAddress, "InValue");
		SetParameterValueInt_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueInt_FunctionAddress, "InValue");
		SetParameterValueInt_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueInt_FunctionAddress, "InValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueInt_InArrayIndex_PropertyAddress, SetParameterValueInt_FunctionAddress, "InArrayIndex");
		SetParameterValueInt_InArrayIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueInt_FunctionAddress, "InArrayIndex");
		SetParameterValueInt_InArrayIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueInt_FunctionAddress, "InArrayIndex", Classes.FIntProperty);
		SetParameterValueInt_IsValid = SetParameterValueInt_FunctionAddress != IntPtr.Zero && SetParameterValueInt_InParameterName_IsValid && SetParameterValueInt_InValue_IsValid && SetParameterValueInt_InArrayIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVM.RigVM:SetParameterValueInt", SetParameterValueInt_IsValid);
		SetParameterValueFloat_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetParameterValueFloat");
		SetParameterValueFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(SetParameterValueFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueFloat_InParameterName_PropertyAddress, SetParameterValueFloat_FunctionAddress, "InParameterName");
		SetParameterValueFloat_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueFloat_FunctionAddress, "InParameterName");
		SetParameterValueFloat_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueFloat_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueFloat_InValue_PropertyAddress, SetParameterValueFloat_FunctionAddress, "InValue");
		SetParameterValueFloat_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueFloat_FunctionAddress, "InValue");
		SetParameterValueFloat_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueFloat_FunctionAddress, "InValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueFloat_InArrayIndex_PropertyAddress, SetParameterValueFloat_FunctionAddress, "InArrayIndex");
		SetParameterValueFloat_InArrayIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueFloat_FunctionAddress, "InArrayIndex");
		SetParameterValueFloat_InArrayIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueFloat_FunctionAddress, "InArrayIndex", Classes.FIntProperty);
		SetParameterValueFloat_IsValid = SetParameterValueFloat_FunctionAddress != IntPtr.Zero && SetParameterValueFloat_InParameterName_IsValid && SetParameterValueFloat_InValue_IsValid && SetParameterValueFloat_InArrayIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVM.RigVM:SetParameterValueFloat", SetParameterValueFloat_IsValid);
		SetParameterValueDouble_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetParameterValueDouble");
		SetParameterValueDouble_ParamsSize = NativeReflection.GetFunctionParamsSize(SetParameterValueDouble_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueDouble_InParameterName_PropertyAddress, SetParameterValueDouble_FunctionAddress, "InParameterName");
		SetParameterValueDouble_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueDouble_FunctionAddress, "InParameterName");
		SetParameterValueDouble_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueDouble_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueDouble_InValue_PropertyAddress, SetParameterValueDouble_FunctionAddress, "InValue");
		SetParameterValueDouble_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueDouble_FunctionAddress, "InValue");
		SetParameterValueDouble_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueDouble_FunctionAddress, "InValue", Classes.FDoubleProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueDouble_InArrayIndex_PropertyAddress, SetParameterValueDouble_FunctionAddress, "InArrayIndex");
		SetParameterValueDouble_InArrayIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueDouble_FunctionAddress, "InArrayIndex");
		SetParameterValueDouble_InArrayIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueDouble_FunctionAddress, "InArrayIndex", Classes.FIntProperty);
		SetParameterValueDouble_IsValid = SetParameterValueDouble_FunctionAddress != IntPtr.Zero && SetParameterValueDouble_InParameterName_IsValid && SetParameterValueDouble_InValue_IsValid && SetParameterValueDouble_InArrayIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVM.RigVM:SetParameterValueDouble", SetParameterValueDouble_IsValid);
		SetParameterValueBool_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetParameterValueBool");
		SetParameterValueBool_ParamsSize = NativeReflection.GetFunctionParamsSize(SetParameterValueBool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueBool_InParameterName_PropertyAddress, SetParameterValueBool_FunctionAddress, "InParameterName");
		SetParameterValueBool_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueBool_FunctionAddress, "InParameterName");
		SetParameterValueBool_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueBool_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueBool_InValue_PropertyAddress, SetParameterValueBool_FunctionAddress, "InValue");
		SetParameterValueBool_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueBool_FunctionAddress, "InValue");
		SetParameterValueBool_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueBool_FunctionAddress, "InValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParameterValueBool_InArrayIndex_PropertyAddress, SetParameterValueBool_FunctionAddress, "InArrayIndex");
		SetParameterValueBool_InArrayIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetParameterValueBool_FunctionAddress, "InArrayIndex");
		SetParameterValueBool_InArrayIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameterValueBool_FunctionAddress, "InArrayIndex", Classes.FIntProperty);
		SetParameterValueBool_IsValid = SetParameterValueBool_FunctionAddress != IntPtr.Zero && SetParameterValueBool_InParameterName_IsValid && SetParameterValueBool_InValue_IsValid && SetParameterValueBool_InArrayIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVM.RigVM:SetParameterValueBool", SetParameterValueBool_IsValid);
		GetParameterValueVector2D_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetParameterValueVector2D");
		GetParameterValueVector2D_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParameterValueVector2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueVector2D_InParameterName_PropertyAddress, GetParameterValueVector2D_FunctionAddress, "InParameterName");
		GetParameterValueVector2D_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueVector2D_FunctionAddress, "InParameterName");
		GetParameterValueVector2D_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueVector2D_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueVector2D_InArrayIndex_PropertyAddress, GetParameterValueVector2D_FunctionAddress, "InArrayIndex");
		GetParameterValueVector2D_InArrayIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueVector2D_FunctionAddress, "InArrayIndex");
		GetParameterValueVector2D_InArrayIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueVector2D_FunctionAddress, "InArrayIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueVector2D_ReturnValue_PropertyAddress, GetParameterValueVector2D_FunctionAddress, "ReturnValue");
		GetParameterValueVector2D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueVector2D_FunctionAddress, "ReturnValue");
		GetParameterValueVector2D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueVector2D_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetParameterValueVector2D_IsValid = GetParameterValueVector2D_FunctionAddress != IntPtr.Zero && GetParameterValueVector2D_InParameterName_IsValid && GetParameterValueVector2D_InArrayIndex_IsValid && GetParameterValueVector2D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVM.RigVM:GetParameterValueVector2D", GetParameterValueVector2D_IsValid);
		GetParameterValueVector_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetParameterValueVector");
		GetParameterValueVector_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParameterValueVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueVector_InParameterName_PropertyAddress, GetParameterValueVector_FunctionAddress, "InParameterName");
		GetParameterValueVector_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueVector_FunctionAddress, "InParameterName");
		GetParameterValueVector_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueVector_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueVector_InArrayIndex_PropertyAddress, GetParameterValueVector_FunctionAddress, "InArrayIndex");
		GetParameterValueVector_InArrayIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueVector_FunctionAddress, "InArrayIndex");
		GetParameterValueVector_InArrayIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueVector_FunctionAddress, "InArrayIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueVector_ReturnValue_PropertyAddress, GetParameterValueVector_FunctionAddress, "ReturnValue");
		GetParameterValueVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueVector_FunctionAddress, "ReturnValue");
		GetParameterValueVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueVector_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetParameterValueVector_IsValid = GetParameterValueVector_FunctionAddress != IntPtr.Zero && GetParameterValueVector_InParameterName_IsValid && GetParameterValueVector_InArrayIndex_IsValid && GetParameterValueVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVM.RigVM:GetParameterValueVector", GetParameterValueVector_IsValid);
		GetParameterValueTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetParameterValueTransform");
		GetParameterValueTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParameterValueTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueTransform_InParameterName_PropertyAddress, GetParameterValueTransform_FunctionAddress, "InParameterName");
		GetParameterValueTransform_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueTransform_FunctionAddress, "InParameterName");
		GetParameterValueTransform_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueTransform_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueTransform_InArrayIndex_PropertyAddress, GetParameterValueTransform_FunctionAddress, "InArrayIndex");
		GetParameterValueTransform_InArrayIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueTransform_FunctionAddress, "InArrayIndex");
		GetParameterValueTransform_InArrayIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueTransform_FunctionAddress, "InArrayIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueTransform_ReturnValue_PropertyAddress, GetParameterValueTransform_FunctionAddress, "ReturnValue");
		GetParameterValueTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueTransform_FunctionAddress, "ReturnValue");
		GetParameterValueTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetParameterValueTransform_IsValid = GetParameterValueTransform_FunctionAddress != IntPtr.Zero && GetParameterValueTransform_InParameterName_IsValid && GetParameterValueTransform_InArrayIndex_IsValid && GetParameterValueTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVM.RigVM:GetParameterValueTransform", GetParameterValueTransform_IsValid);
		GetParameterValueString_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetParameterValueString");
		GetParameterValueString_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParameterValueString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueString_InParameterName_PropertyAddress, GetParameterValueString_FunctionAddress, "InParameterName");
		GetParameterValueString_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueString_FunctionAddress, "InParameterName");
		GetParameterValueString_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueString_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueString_InArrayIndex_PropertyAddress, GetParameterValueString_FunctionAddress, "InArrayIndex");
		GetParameterValueString_InArrayIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueString_FunctionAddress, "InArrayIndex");
		GetParameterValueString_InArrayIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueString_FunctionAddress, "InArrayIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueString_ReturnValue_PropertyAddress, GetParameterValueString_FunctionAddress, "ReturnValue");
		GetParameterValueString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueString_FunctionAddress, "ReturnValue");
		GetParameterValueString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetParameterValueString_IsValid = GetParameterValueString_FunctionAddress != IntPtr.Zero && GetParameterValueString_InParameterName_IsValid && GetParameterValueString_InArrayIndex_IsValid && GetParameterValueString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVM.RigVM:GetParameterValueString", GetParameterValueString_IsValid);
		GetParameterValueQuat_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetParameterValueQuat");
		GetParameterValueQuat_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParameterValueQuat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueQuat_InParameterName_PropertyAddress, GetParameterValueQuat_FunctionAddress, "InParameterName");
		GetParameterValueQuat_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueQuat_FunctionAddress, "InParameterName");
		GetParameterValueQuat_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueQuat_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueQuat_InArrayIndex_PropertyAddress, GetParameterValueQuat_FunctionAddress, "InArrayIndex");
		GetParameterValueQuat_InArrayIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueQuat_FunctionAddress, "InArrayIndex");
		GetParameterValueQuat_InArrayIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueQuat_FunctionAddress, "InArrayIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueQuat_ReturnValue_PropertyAddress, GetParameterValueQuat_FunctionAddress, "ReturnValue");
		GetParameterValueQuat_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueQuat_FunctionAddress, "ReturnValue");
		GetParameterValueQuat_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueQuat_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetParameterValueQuat_IsValid = GetParameterValueQuat_FunctionAddress != IntPtr.Zero && GetParameterValueQuat_InParameterName_IsValid && GetParameterValueQuat_InArrayIndex_IsValid && GetParameterValueQuat_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVM.RigVM:GetParameterValueQuat", GetParameterValueQuat_IsValid);
		GetParameterValueName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetParameterValueName");
		GetParameterValueName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParameterValueName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueName_InParameterName_PropertyAddress, GetParameterValueName_FunctionAddress, "InParameterName");
		GetParameterValueName_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueName_FunctionAddress, "InParameterName");
		GetParameterValueName_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueName_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueName_InArrayIndex_PropertyAddress, GetParameterValueName_FunctionAddress, "InArrayIndex");
		GetParameterValueName_InArrayIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueName_FunctionAddress, "InArrayIndex");
		GetParameterValueName_InArrayIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueName_FunctionAddress, "InArrayIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueName_ReturnValue_PropertyAddress, GetParameterValueName_FunctionAddress, "ReturnValue");
		GetParameterValueName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueName_FunctionAddress, "ReturnValue");
		GetParameterValueName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetParameterValueName_IsValid = GetParameterValueName_FunctionAddress != IntPtr.Zero && GetParameterValueName_InParameterName_IsValid && GetParameterValueName_InArrayIndex_IsValid && GetParameterValueName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVM.RigVM:GetParameterValueName", GetParameterValueName_IsValid);
		GetParameterValueInt_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetParameterValueInt");
		GetParameterValueInt_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParameterValueInt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueInt_InParameterName_PropertyAddress, GetParameterValueInt_FunctionAddress, "InParameterName");
		GetParameterValueInt_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueInt_FunctionAddress, "InParameterName");
		GetParameterValueInt_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueInt_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueInt_InArrayIndex_PropertyAddress, GetParameterValueInt_FunctionAddress, "InArrayIndex");
		GetParameterValueInt_InArrayIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueInt_FunctionAddress, "InArrayIndex");
		GetParameterValueInt_InArrayIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueInt_FunctionAddress, "InArrayIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueInt_ReturnValue_PropertyAddress, GetParameterValueInt_FunctionAddress, "ReturnValue");
		GetParameterValueInt_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueInt_FunctionAddress, "ReturnValue");
		GetParameterValueInt_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueInt_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetParameterValueInt_IsValid = GetParameterValueInt_FunctionAddress != IntPtr.Zero && GetParameterValueInt_InParameterName_IsValid && GetParameterValueInt_InArrayIndex_IsValid && GetParameterValueInt_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVM.RigVM:GetParameterValueInt", GetParameterValueInt_IsValid);
		GetParameterValueFloat_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetParameterValueFloat");
		GetParameterValueFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParameterValueFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueFloat_InParameterName_PropertyAddress, GetParameterValueFloat_FunctionAddress, "InParameterName");
		GetParameterValueFloat_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueFloat_FunctionAddress, "InParameterName");
		GetParameterValueFloat_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueFloat_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueFloat_InArrayIndex_PropertyAddress, GetParameterValueFloat_FunctionAddress, "InArrayIndex");
		GetParameterValueFloat_InArrayIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueFloat_FunctionAddress, "InArrayIndex");
		GetParameterValueFloat_InArrayIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueFloat_FunctionAddress, "InArrayIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueFloat_ReturnValue_PropertyAddress, GetParameterValueFloat_FunctionAddress, "ReturnValue");
		GetParameterValueFloat_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueFloat_FunctionAddress, "ReturnValue");
		GetParameterValueFloat_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueFloat_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetParameterValueFloat_IsValid = GetParameterValueFloat_FunctionAddress != IntPtr.Zero && GetParameterValueFloat_InParameterName_IsValid && GetParameterValueFloat_InArrayIndex_IsValid && GetParameterValueFloat_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVM.RigVM:GetParameterValueFloat", GetParameterValueFloat_IsValid);
		GetParameterValueDouble_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetParameterValueDouble");
		GetParameterValueDouble_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParameterValueDouble_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueDouble_InParameterName_PropertyAddress, GetParameterValueDouble_FunctionAddress, "InParameterName");
		GetParameterValueDouble_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueDouble_FunctionAddress, "InParameterName");
		GetParameterValueDouble_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueDouble_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueDouble_InArrayIndex_PropertyAddress, GetParameterValueDouble_FunctionAddress, "InArrayIndex");
		GetParameterValueDouble_InArrayIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueDouble_FunctionAddress, "InArrayIndex");
		GetParameterValueDouble_InArrayIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueDouble_FunctionAddress, "InArrayIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueDouble_ReturnValue_PropertyAddress, GetParameterValueDouble_FunctionAddress, "ReturnValue");
		GetParameterValueDouble_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueDouble_FunctionAddress, "ReturnValue");
		GetParameterValueDouble_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueDouble_FunctionAddress, "ReturnValue", Classes.FDoubleProperty);
		GetParameterValueDouble_IsValid = GetParameterValueDouble_FunctionAddress != IntPtr.Zero && GetParameterValueDouble_InParameterName_IsValid && GetParameterValueDouble_InArrayIndex_IsValid && GetParameterValueDouble_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVM.RigVM:GetParameterValueDouble", GetParameterValueDouble_IsValid);
		GetParameterValueBool_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetParameterValueBool");
		GetParameterValueBool_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParameterValueBool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueBool_InParameterName_PropertyAddress, GetParameterValueBool_FunctionAddress, "InParameterName");
		GetParameterValueBool_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueBool_FunctionAddress, "InParameterName");
		GetParameterValueBool_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueBool_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueBool_InArrayIndex_PropertyAddress, GetParameterValueBool_FunctionAddress, "InArrayIndex");
		GetParameterValueBool_InArrayIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueBool_FunctionAddress, "InArrayIndex");
		GetParameterValueBool_InArrayIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueBool_FunctionAddress, "InArrayIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterValueBool_ReturnValue_PropertyAddress, GetParameterValueBool_FunctionAddress, "ReturnValue");
		GetParameterValueBool_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterValueBool_FunctionAddress, "ReturnValue");
		GetParameterValueBool_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterValueBool_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetParameterValueBool_IsValid = GetParameterValueBool_FunctionAddress != IntPtr.Zero && GetParameterValueBool_InParameterName_IsValid && GetParameterValueBool_InArrayIndex_IsValid && GetParameterValueBool_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVM.RigVM:GetParameterValueBool", GetParameterValueBool_IsValid);
		Execute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Execute");
		Execute_ParamsSize = NativeReflection.GetFunctionParamsSize(Execute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Execute_InEntryName_PropertyAddress, Execute_FunctionAddress, "InEntryName");
		Execute_InEntryName_Offset = NativeReflectionCached.GetPropertyOffset(Execute_FunctionAddress, "InEntryName");
		Execute_InEntryName_IsValid = NativeReflectionCached.ValidatePropertyClass(Execute_FunctionAddress, "InEntryName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Execute_ReturnValue_PropertyAddress, Execute_FunctionAddress, "ReturnValue");
		Execute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Execute_FunctionAddress, "ReturnValue");
		Execute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Execute_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Execute_IsValid = Execute_FunctionAddress != IntPtr.Zero && Execute_InEntryName_IsValid && Execute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVM.RigVM:Execute", Execute_IsValid);
	}
}
