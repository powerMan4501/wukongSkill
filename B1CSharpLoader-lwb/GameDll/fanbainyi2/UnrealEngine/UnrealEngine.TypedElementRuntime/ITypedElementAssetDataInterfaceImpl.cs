using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.TypedElementFramework;

namespace UnrealEngine.TypedElementRuntime;

public sealed class ITypedElementAssetDataInterfaceImpl : IInterfaceImpl, ITypedElementAssetDataInterface, IInterface
{
	private static bool GetAssetData_IsValid;

	private IntPtr GetAssetData_InstanceFunctionAddress;

	private static IntPtr GetAssetData_FunctionAddress;

	private static int GetAssetData_ParamsSize;

	private static bool GetAssetData_InElementHandle_IsValid;

	private static FFieldAddress GetAssetData_InElementHandle_PropertyAddress;

	private static int GetAssetData_InElementHandle_Offset;

	private static bool GetAssetData_ReturnValue_IsValid;

	private static FFieldAddress GetAssetData_ReturnValue_PropertyAddress;

	private static int GetAssetData_ReturnValue_Offset;

	private static bool GetAllReferencedAssetDatas_IsValid;

	private IntPtr GetAllReferencedAssetDatas_InstanceFunctionAddress;

	private static IntPtr GetAllReferencedAssetDatas_FunctionAddress;

	private static int GetAllReferencedAssetDatas_ParamsSize;

	private static bool GetAllReferencedAssetDatas_InElementHandle_IsValid;

	private static FFieldAddress GetAllReferencedAssetDatas_InElementHandle_PropertyAddress;

	private static int GetAllReferencedAssetDatas_InElementHandle_Offset;

	private static bool GetAllReferencedAssetDatas_ReturnValue_IsValid;

	private static FFieldAddress GetAllReferencedAssetDatas_ReturnValue_PropertyAddress;

	private static int GetAllReferencedAssetDatas_ReturnValue_Offset;

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementAssetDataInterface:GetAssetData")]
	public unsafe FAssetData GetAssetData(FScriptTypedElementHandle InElementHandle)
	{
		CheckDestroyed();
		if (!GetAssetData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementAssetDataInterface:GetAssetData");
			return default(FAssetData);
		}
		if (GetAssetData_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetAssetData_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetAssetData");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAssetData_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, GetAssetData_InElementHandle_Offset), 0, GetAssetData_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAssetData_InstanceFunctionAddress, intPtr, GetAssetData_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAssetData_InElementHandle_PropertyAddress.Address, intPtr);
		FAssetData result = FAssetData.FromNative(IntPtr.Add(intPtr, GetAssetData_ReturnValue_Offset), 0, GetAssetData_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAssetData_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementAssetDataInterface:GetAllReferencedAssetDatas")]
	public unsafe List<FAssetData> GetAllReferencedAssetDatas(FScriptTypedElementHandle InElementHandle)
	{
		CheckDestroyed();
		if (!GetAllReferencedAssetDatas_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementAssetDataInterface:GetAllReferencedAssetDatas");
			return null;
		}
		if (GetAllReferencedAssetDatas_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetAllReferencedAssetDatas_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetAllReferencedAssetDatas");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllReferencedAssetDatas_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllReferencedAssetDatas_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAllReferencedAssetDatas_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, GetAllReferencedAssetDatas_InElementHandle_Offset), 0, GetAllReferencedAssetDatas_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllReferencedAssetDatas_InstanceFunctionAddress, intPtr, GetAllReferencedAssetDatas_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAllReferencedAssetDatas_InElementHandle_PropertyAddress.Address, intPtr);
		List<FAssetData> result = new TArrayCopyMarshaler<FAssetData>(1, GetAllReferencedAssetDatas_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FAssetData, FAssetData>.FromNative, CachedMarshalingDelegates<FAssetData, FAssetData>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllReferencedAssetDatas_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllReferencedAssetDatas_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	public override void ResetInterface()
	{
		GetAssetData_InstanceFunctionAddress = IntPtr.Zero;
		GetAllReferencedAssetDatas_InstanceFunctionAddress = IntPtr.Zero;
	}

	static ITypedElementAssetDataInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ITypedElementAssetDataInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ITypedElementAssetDataInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/TypedElementRuntime.TypedElementAssetDataInterface");
		GetAssetData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAssetData");
		GetAssetData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetData_InElementHandle_PropertyAddress, GetAssetData_FunctionAddress, "InElementHandle");
		GetAssetData_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetData_FunctionAddress, "InElementHandle");
		GetAssetData_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetData_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetData_ReturnValue_PropertyAddress, GetAssetData_FunctionAddress, "ReturnValue");
		GetAssetData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetData_FunctionAddress, "ReturnValue");
		GetAssetData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetData_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetAssetData_IsValid = GetAssetData_FunctionAddress != IntPtr.Zero && GetAssetData_InElementHandle_IsValid && GetAssetData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementAssetDataInterface:GetAssetData", GetAssetData_IsValid);
		GetAllReferencedAssetDatas_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAllReferencedAssetDatas");
		GetAllReferencedAssetDatas_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllReferencedAssetDatas_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllReferencedAssetDatas_InElementHandle_PropertyAddress, GetAllReferencedAssetDatas_FunctionAddress, "InElementHandle");
		GetAllReferencedAssetDatas_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(GetAllReferencedAssetDatas_FunctionAddress, "InElementHandle");
		GetAllReferencedAssetDatas_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllReferencedAssetDatas_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllReferencedAssetDatas_ReturnValue_PropertyAddress, GetAllReferencedAssetDatas_FunctionAddress, "ReturnValue");
		GetAllReferencedAssetDatas_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllReferencedAssetDatas_FunctionAddress, "ReturnValue");
		GetAllReferencedAssetDatas_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllReferencedAssetDatas_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllReferencedAssetDatas_IsValid = GetAllReferencedAssetDatas_FunctionAddress != IntPtr.Zero && GetAllReferencedAssetDatas_InElementHandle_IsValid && GetAllReferencedAssetDatas_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementAssetDataInterface:GetAllReferencedAssetDatas", GetAllReferencedAssetDatas_IsValid);
	}
}
