using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.TypedElementFramework;

namespace UnrealEngine.TypedElementRuntime;

public sealed class ITypedElementObjectInterfaceImpl : IInterfaceImpl, ITypedElementObjectInterface, IInterface
{
	private static bool GetObjectClass_IsValid;

	private IntPtr GetObjectClass_InstanceFunctionAddress;

	private static IntPtr GetObjectClass_FunctionAddress;

	private static int GetObjectClass_ParamsSize;

	private static bool GetObjectClass_InElementHandle_IsValid;

	private static FFieldAddress GetObjectClass_InElementHandle_PropertyAddress;

	private static int GetObjectClass_InElementHandle_Offset;

	private static bool GetObjectClass_ReturnValue_IsValid;

	private static FFieldAddress GetObjectClass_ReturnValue_PropertyAddress;

	private static int GetObjectClass_ReturnValue_Offset;

	private static bool GetObject_IsValid;

	private IntPtr GetObject_InstanceFunctionAddress;

	private static IntPtr GetObject_FunctionAddress;

	private static int GetObject_ParamsSize;

	private static bool GetObject_InElementHandle_IsValid;

	private static FFieldAddress GetObject_InElementHandle_PropertyAddress;

	private static int GetObject_InElementHandle_Offset;

	private static bool GetObject_ReturnValue_IsValid;

	private static FFieldAddress GetObject_ReturnValue_PropertyAddress;

	private static int GetObject_ReturnValue_Offset;

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementObjectInterface:GetObjectClass")]
	public unsafe TSubclassOf<UObject> GetObjectClass(FScriptTypedElementHandle InElementHandle)
	{
		CheckDestroyed();
		if (!GetObjectClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementObjectInterface:GetObjectClass");
			return default(TSubclassOf<UObject>);
		}
		if (GetObjectClass_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetObjectClass_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetObjectClass");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetObjectClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetObjectClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetObjectClass_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, GetObjectClass_InElementHandle_Offset), 0, GetObjectClass_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetObjectClass_InstanceFunctionAddress, intPtr, GetObjectClass_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetObjectClass_InElementHandle_PropertyAddress.Address, intPtr);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetObjectClass_ReturnValue_Offset), 0, GetObjectClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementObjectInterface:GetObject")]
	public unsafe UObject GetObject(FScriptTypedElementHandle InElementHandle)
	{
		CheckDestroyed();
		if (!GetObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementObjectInterface:GetObject");
			return null;
		}
		if (GetObject_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetObject_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetObject");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetObject_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, GetObject_InElementHandle_Offset), 0, GetObject_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetObject_InstanceFunctionAddress, intPtr, GetObject_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetObject_InElementHandle_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetObject_ReturnValue_Offset), 0, GetObject_ReturnValue_PropertyAddress.Address);
	}

	public override void ResetInterface()
	{
		GetObjectClass_InstanceFunctionAddress = IntPtr.Zero;
		GetObject_InstanceFunctionAddress = IntPtr.Zero;
	}

	static ITypedElementObjectInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ITypedElementObjectInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ITypedElementObjectInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/TypedElementRuntime.TypedElementObjectInterface");
		GetObjectClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetObjectClass");
		GetObjectClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetObjectClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetObjectClass_InElementHandle_PropertyAddress, GetObjectClass_FunctionAddress, "InElementHandle");
		GetObjectClass_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(GetObjectClass_FunctionAddress, "InElementHandle");
		GetObjectClass_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjectClass_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetObjectClass_ReturnValue_PropertyAddress, GetObjectClass_FunctionAddress, "ReturnValue");
		GetObjectClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetObjectClass_FunctionAddress, "ReturnValue");
		GetObjectClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjectClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetObjectClass_IsValid = GetObjectClass_FunctionAddress != IntPtr.Zero && GetObjectClass_InElementHandle_IsValid && GetObjectClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementObjectInterface:GetObjectClass", GetObjectClass_IsValid);
		GetObject_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetObject");
		GetObject_ParamsSize = NativeReflection.GetFunctionParamsSize(GetObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetObject_InElementHandle_PropertyAddress, GetObject_FunctionAddress, "InElementHandle");
		GetObject_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(GetObject_FunctionAddress, "InElementHandle");
		GetObject_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObject_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetObject_ReturnValue_PropertyAddress, GetObject_FunctionAddress, "ReturnValue");
		GetObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetObject_FunctionAddress, "ReturnValue");
		GetObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetObject_IsValid = GetObject_FunctionAddress != IntPtr.Zero && GetObject_InElementHandle_IsValid && GetObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementObjectInterface:GetObject", GetObject_IsValid);
	}
}
