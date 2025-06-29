using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.TypedElementFramework;

public sealed class ITestTypedElementInterfaceCImpl : IInterfaceImpl, ITestTypedElementInterfaceC, IInterface
{
	private static bool GetIsTested_IsValid;

	private IntPtr GetIsTested_InstanceFunctionAddress;

	private static IntPtr GetIsTested_FunctionAddress;

	private static int GetIsTested_ParamsSize;

	private static bool GetIsTested_InElementHandle_IsValid;

	private static FFieldAddress GetIsTested_InElementHandle_PropertyAddress;

	private static int GetIsTested_InElementHandle_Offset;

	private static bool GetIsTested_ReturnValue_IsValid;

	private static FFieldAddress GetIsTested_ReturnValue_PropertyAddress;

	private static int GetIsTested_ReturnValue_Offset;

	[UFunction(Flags = 1413612544u)]
	[UMetaPath("/Script/TypedElementFramework.TestTypedElementInterfaceC:GetIsTested")]
	public unsafe bool GetIsTested(FScriptTypedElementHandle InElementHandle)
	{
		CheckDestroyed();
		if (!GetIsTested_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementFramework.TestTypedElementInterfaceC:GetIsTested");
			return false;
		}
		if (GetIsTested_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetIsTested_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetIsTested");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsTested_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsTested_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetIsTested_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, GetIsTested_InElementHandle_Offset), 0, GetIsTested_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetIsTested_InstanceFunctionAddress, intPtr, GetIsTested_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetIsTested_InElementHandle_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsTested_ReturnValue_Offset), 0, GetIsTested_ReturnValue_PropertyAddress.Address);
	}

	public override void ResetInterface()
	{
		GetIsTested_InstanceFunctionAddress = IntPtr.Zero;
	}

	static ITestTypedElementInterfaceCImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ITestTypedElementInterfaceCImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ITestTypedElementInterfaceCImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/TypedElementFramework.TestTypedElementInterfaceC");
		GetIsTested_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetIsTested");
		GetIsTested_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsTested_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsTested_InElementHandle_PropertyAddress, GetIsTested_FunctionAddress, "InElementHandle");
		GetIsTested_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(GetIsTested_FunctionAddress, "InElementHandle");
		GetIsTested_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsTested_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIsTested_ReturnValue_PropertyAddress, GetIsTested_FunctionAddress, "ReturnValue");
		GetIsTested_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIsTested_FunctionAddress, "ReturnValue");
		GetIsTested_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsTested_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsTested_IsValid = GetIsTested_FunctionAddress != IntPtr.Zero && GetIsTested_InElementHandle_IsValid && GetIsTested_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementFramework.TestTypedElementInterfaceC:GetIsTested", GetIsTested_IsValid);
	}
}
