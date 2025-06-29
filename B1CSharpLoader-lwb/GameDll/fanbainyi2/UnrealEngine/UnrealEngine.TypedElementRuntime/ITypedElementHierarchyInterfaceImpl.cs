using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.TypedElementFramework;

namespace UnrealEngine.TypedElementRuntime;

public sealed class ITypedElementHierarchyInterfaceImpl : IInterfaceImpl, ITypedElementHierarchyInterface, IInterface
{
	private static bool GetParentElement_IsValid;

	private IntPtr GetParentElement_InstanceFunctionAddress;

	private static IntPtr GetParentElement_FunctionAddress;

	private static int GetParentElement_ParamsSize;

	private static bool GetParentElement_InElementHandle_IsValid;

	private static FFieldAddress GetParentElement_InElementHandle_PropertyAddress;

	private static int GetParentElement_InElementHandle_Offset;

	private static bool GetParentElement_bAllowCreate_IsValid;

	private static FFieldAddress GetParentElement_bAllowCreate_PropertyAddress;

	private static int GetParentElement_bAllowCreate_Offset;

	private static bool GetParentElement_ReturnValue_IsValid;

	private static FFieldAddress GetParentElement_ReturnValue_PropertyAddress;

	private static int GetParentElement_ReturnValue_Offset;

	private static bool GetChildElements_IsValid;

	private IntPtr GetChildElements_InstanceFunctionAddress;

	private static IntPtr GetChildElements_FunctionAddress;

	private static int GetChildElements_ParamsSize;

	private static bool GetChildElements_InElementHandle_IsValid;

	private static FFieldAddress GetChildElements_InElementHandle_PropertyAddress;

	private static int GetChildElements_InElementHandle_Offset;

	private static bool GetChildElements_OutElementHandles_IsValid;

	private static FFieldAddress GetChildElements_OutElementHandles_PropertyAddress;

	private static int GetChildElements_OutElementHandles_Offset;

	private static bool GetChildElements_bAllowCreate_IsValid;

	private static FFieldAddress GetChildElements_bAllowCreate_PropertyAddress;

	private static int GetChildElements_bAllowCreate_Offset;

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementHierarchyInterface:GetParentElement")]
	public unsafe FScriptTypedElementHandle GetParentElement(FScriptTypedElementHandle InElementHandle, bool bAllowCreate = true)
	{
		CheckDestroyed();
		if (!GetParentElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementHierarchyInterface:GetParentElement");
			return default(FScriptTypedElementHandle);
		}
		if (GetParentElement_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetParentElement_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetParentElement");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParentElement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParentElement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetParentElement_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, GetParentElement_InElementHandle_Offset), 0, GetParentElement_InElementHandle_PropertyAddress.Address, InElementHandle);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetParentElement_bAllowCreate_Offset), 0, GetParentElement_bAllowCreate_PropertyAddress.Address, bAllowCreate);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParentElement_InstanceFunctionAddress, intPtr, GetParentElement_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetParentElement_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle result = FScriptTypedElementHandle.FromNative(IntPtr.Add(intPtr, GetParentElement_ReturnValue_Offset), 0, GetParentElement_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetParentElement_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementHierarchyInterface:GetChildElements")]
	public unsafe void GetChildElements(FScriptTypedElementHandle InElementHandle, out List<FScriptTypedElementHandle> OutElementHandles, bool bAllowCreate = true)
	{
		CheckDestroyed();
		if (!GetChildElements_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementHierarchyInterface:GetChildElements");
			OutElementHandles = null;
			return;
		}
		if (GetChildElements_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetChildElements_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetChildElements");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetChildElements_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetChildElements_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetChildElements_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, GetChildElements_InElementHandle_Offset), 0, GetChildElements_InElementHandle_PropertyAddress.Address, InElementHandle);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetChildElements_bAllowCreate_Offset), 0, GetChildElements_bAllowCreate_PropertyAddress.Address, bAllowCreate);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetChildElements_InstanceFunctionAddress, intPtr, GetChildElements_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetChildElements_InElementHandle_PropertyAddress.Address, intPtr);
		OutElementHandles = new TArrayCopyMarshaler<FScriptTypedElementHandle>(1, GetChildElements_OutElementHandles_PropertyAddress, CachedMarshalingDelegates<FScriptTypedElementHandle, FScriptTypedElementHandle>.FromNative, CachedMarshalingDelegates<FScriptTypedElementHandle, FScriptTypedElementHandle>.ToNative).FromNative(IntPtr.Add(intPtr, GetChildElements_OutElementHandles_Offset));
		NativeReflection.DestroyValue_InContainer(GetChildElements_OutElementHandles_PropertyAddress.Address, intPtr);
	}

	public override void ResetInterface()
	{
		GetParentElement_InstanceFunctionAddress = IntPtr.Zero;
		GetChildElements_InstanceFunctionAddress = IntPtr.Zero;
	}

	static ITypedElementHierarchyInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ITypedElementHierarchyInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ITypedElementHierarchyInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/TypedElementRuntime.TypedElementHierarchyInterface");
		GetParentElement_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetParentElement");
		GetParentElement_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParentElement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParentElement_InElementHandle_PropertyAddress, GetParentElement_FunctionAddress, "InElementHandle");
		GetParentElement_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(GetParentElement_FunctionAddress, "InElementHandle");
		GetParentElement_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentElement_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParentElement_bAllowCreate_PropertyAddress, GetParentElement_FunctionAddress, "bAllowCreate");
		GetParentElement_bAllowCreate_Offset = NativeReflectionCached.GetPropertyOffset(GetParentElement_FunctionAddress, "bAllowCreate");
		GetParentElement_bAllowCreate_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentElement_FunctionAddress, "bAllowCreate", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParentElement_ReturnValue_PropertyAddress, GetParentElement_FunctionAddress, "ReturnValue");
		GetParentElement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParentElement_FunctionAddress, "ReturnValue");
		GetParentElement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentElement_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetParentElement_IsValid = GetParentElement_FunctionAddress != IntPtr.Zero && GetParentElement_InElementHandle_IsValid && GetParentElement_bAllowCreate_IsValid && GetParentElement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementHierarchyInterface:GetParentElement", GetParentElement_IsValid);
		GetChildElements_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetChildElements");
		GetChildElements_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChildElements_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetChildElements_InElementHandle_PropertyAddress, GetChildElements_FunctionAddress, "InElementHandle");
		GetChildElements_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(GetChildElements_FunctionAddress, "InElementHandle");
		GetChildElements_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildElements_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChildElements_OutElementHandles_PropertyAddress, GetChildElements_FunctionAddress, "OutElementHandles");
		GetChildElements_OutElementHandles_Offset = NativeReflectionCached.GetPropertyOffset(GetChildElements_FunctionAddress, "OutElementHandles");
		GetChildElements_OutElementHandles_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildElements_FunctionAddress, "OutElementHandles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChildElements_bAllowCreate_PropertyAddress, GetChildElements_FunctionAddress, "bAllowCreate");
		GetChildElements_bAllowCreate_Offset = NativeReflectionCached.GetPropertyOffset(GetChildElements_FunctionAddress, "bAllowCreate");
		GetChildElements_bAllowCreate_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildElements_FunctionAddress, "bAllowCreate", Classes.FBoolProperty);
		GetChildElements_IsValid = GetChildElements_FunctionAddress != IntPtr.Zero && GetChildElements_InElementHandle_IsValid && GetChildElements_OutElementHandles_IsValid && GetChildElements_bAllowCreate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementHierarchyInterface:GetChildElements", GetChildElements_IsValid);
	}
}
