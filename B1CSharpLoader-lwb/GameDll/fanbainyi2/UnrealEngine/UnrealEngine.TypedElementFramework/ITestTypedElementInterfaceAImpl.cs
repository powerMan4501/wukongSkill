using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.TypedElementFramework;

public sealed class ITestTypedElementInterfaceAImpl : IInterfaceImpl, ITestTypedElementInterfaceA, IInterface
{
	private static bool SetDisplayName_IsValid;

	private IntPtr SetDisplayName_InstanceFunctionAddress;

	private static IntPtr SetDisplayName_FunctionAddress;

	private static int SetDisplayName_ParamsSize;

	private static bool SetDisplayName_InElementHandle_IsValid;

	private static FFieldAddress SetDisplayName_InElementHandle_PropertyAddress;

	private static int SetDisplayName_InElementHandle_Offset;

	private static bool SetDisplayName_InNewName_IsValid;

	private static FFieldAddress SetDisplayName_InNewName_PropertyAddress;

	private static int SetDisplayName_InNewName_Offset;

	private static bool SetDisplayName_bNotify_IsValid;

	private static FFieldAddress SetDisplayName_bNotify_PropertyAddress;

	private static int SetDisplayName_bNotify_Offset;

	private static bool SetDisplayName_ReturnValue_IsValid;

	private static FFieldAddress SetDisplayName_ReturnValue_PropertyAddress;

	private static int SetDisplayName_ReturnValue_Offset;

	private static bool GetDisplayName_IsValid;

	private IntPtr GetDisplayName_InstanceFunctionAddress;

	private static IntPtr GetDisplayName_FunctionAddress;

	private static int GetDisplayName_ParamsSize;

	private static bool GetDisplayName_InElementHandle_IsValid;

	private static FFieldAddress GetDisplayName_InElementHandle_PropertyAddress;

	private static int GetDisplayName_InElementHandle_Offset;

	private static bool GetDisplayName_ReturnValue_IsValid;

	private static FFieldAddress GetDisplayName_ReturnValue_PropertyAddress;

	private static int GetDisplayName_ReturnValue_Offset;

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementFramework.TestTypedElementInterfaceA:SetDisplayName")]
	public unsafe bool SetDisplayName(FScriptTypedElementHandle InElementHandle, FText InNewName, bool bNotify = true)
	{
		CheckDestroyed();
		if (!SetDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementFramework.TestTypedElementInterfaceA:SetDisplayName");
			return false;
		}
		if (SetDisplayName_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetDisplayName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetDisplayName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetDisplayName_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, SetDisplayName_InElementHandle_Offset), 0, SetDisplayName_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InitializeValue_InContainer(SetDisplayName_InNewName_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetDisplayName_InNewName_Offset), 0, SetDisplayName_InNewName_PropertyAddress.Address, InNewName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetDisplayName_bNotify_Offset), 0, SetDisplayName_bNotify_PropertyAddress.Address, bNotify);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDisplayName_InstanceFunctionAddress, intPtr, SetDisplayName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetDisplayName_InElementHandle_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetDisplayName_InNewName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetDisplayName_ReturnValue_Offset), 0, SetDisplayName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementFramework.TestTypedElementInterfaceA:GetDisplayName")]
	public unsafe string GetDisplayName(FScriptTypedElementHandle InElementHandle)
	{
		CheckDestroyed();
		if (!GetDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementFramework.TestTypedElementInterfaceA:GetDisplayName");
			return FStringMarshaler.DefaultString;
		}
		if (GetDisplayName_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetDisplayName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetDisplayName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetDisplayName_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, GetDisplayName_InElementHandle_Offset), 0, GetDisplayName_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDisplayName_InstanceFunctionAddress, intPtr, GetDisplayName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetDisplayName_InElementHandle_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetDisplayName_ReturnValue_Offset), 0, GetDisplayName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetDisplayName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	public override void ResetInterface()
	{
		SetDisplayName_InstanceFunctionAddress = IntPtr.Zero;
		GetDisplayName_InstanceFunctionAddress = IntPtr.Zero;
	}

	static ITestTypedElementInterfaceAImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ITestTypedElementInterfaceAImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ITestTypedElementInterfaceAImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/TypedElementFramework.TestTypedElementInterfaceA");
		SetDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDisplayName");
		SetDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDisplayName_InElementHandle_PropertyAddress, SetDisplayName_FunctionAddress, "InElementHandle");
		SetDisplayName_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(SetDisplayName_FunctionAddress, "InElementHandle");
		SetDisplayName_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDisplayName_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDisplayName_InNewName_PropertyAddress, SetDisplayName_FunctionAddress, "InNewName");
		SetDisplayName_InNewName_Offset = NativeReflectionCached.GetPropertyOffset(SetDisplayName_FunctionAddress, "InNewName");
		SetDisplayName_InNewName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDisplayName_FunctionAddress, "InNewName", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDisplayName_bNotify_PropertyAddress, SetDisplayName_FunctionAddress, "bNotify");
		SetDisplayName_bNotify_Offset = NativeReflectionCached.GetPropertyOffset(SetDisplayName_FunctionAddress, "bNotify");
		SetDisplayName_bNotify_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDisplayName_FunctionAddress, "bNotify", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDisplayName_ReturnValue_PropertyAddress, SetDisplayName_FunctionAddress, "ReturnValue");
		SetDisplayName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetDisplayName_FunctionAddress, "ReturnValue");
		SetDisplayName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDisplayName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetDisplayName_IsValid = SetDisplayName_FunctionAddress != IntPtr.Zero && SetDisplayName_InElementHandle_IsValid && SetDisplayName_InNewName_IsValid && SetDisplayName_bNotify_IsValid && SetDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementFramework.TestTypedElementInterfaceA:SetDisplayName", SetDisplayName_IsValid);
		GetDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDisplayName");
		GetDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayName_InElementHandle_PropertyAddress, GetDisplayName_FunctionAddress, "InElementHandle");
		GetDisplayName_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayName_FunctionAddress, "InElementHandle");
		GetDisplayName_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayName_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayName_ReturnValue_PropertyAddress, GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayName_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetDisplayName_IsValid = GetDisplayName_FunctionAddress != IntPtr.Zero && GetDisplayName_InElementHandle_IsValid && GetDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementFramework.TestTypedElementInterfaceA:GetDisplayName", GetDisplayName_IsValid);
	}
}
