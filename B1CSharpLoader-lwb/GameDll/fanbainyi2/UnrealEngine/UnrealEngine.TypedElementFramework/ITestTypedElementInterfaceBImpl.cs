using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.TypedElementFramework;

public sealed class ITestTypedElementInterfaceBImpl : IInterfaceImpl, ITestTypedElementInterfaceB, IInterface
{
	private static bool MarkAsTested_IsValid;

	private IntPtr MarkAsTested_InstanceFunctionAddress;

	private static IntPtr MarkAsTested_FunctionAddress;

	private static int MarkAsTested_ParamsSize;

	private static bool MarkAsTested_InElementHandle_IsValid;

	private static FFieldAddress MarkAsTested_InElementHandle_PropertyAddress;

	private static int MarkAsTested_InElementHandle_Offset;

	private static bool MarkAsTested_ReturnValue_IsValid;

	private static FFieldAddress MarkAsTested_ReturnValue_PropertyAddress;

	private static int MarkAsTested_ReturnValue_Offset;

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementFramework.TestTypedElementInterfaceB:MarkAsTested")]
	public unsafe bool MarkAsTested(FScriptTypedElementHandle InElementHandle)
	{
		CheckDestroyed();
		if (!MarkAsTested_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementFramework.TestTypedElementInterfaceB:MarkAsTested");
			return false;
		}
		if (MarkAsTested_InstanceFunctionAddress == IntPtr.Zero)
		{
			MarkAsTested_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "MarkAsTested");
		}
		byte* ptr = stackalloc byte[(int)(uint)(MarkAsTested_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MarkAsTested_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(MarkAsTested_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, MarkAsTested_InElementHandle_Offset), 0, MarkAsTested_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InvokeFunctionOptimized(base.Address, MarkAsTested_InstanceFunctionAddress, intPtr, MarkAsTested_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MarkAsTested_InElementHandle_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MarkAsTested_ReturnValue_Offset), 0, MarkAsTested_ReturnValue_PropertyAddress.Address);
	}

	public override void ResetInterface()
	{
		MarkAsTested_InstanceFunctionAddress = IntPtr.Zero;
	}

	static ITestTypedElementInterfaceBImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ITestTypedElementInterfaceBImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ITestTypedElementInterfaceBImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/TypedElementFramework.TestTypedElementInterfaceB");
		MarkAsTested_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "MarkAsTested");
		MarkAsTested_ParamsSize = NativeReflection.GetFunctionParamsSize(MarkAsTested_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MarkAsTested_InElementHandle_PropertyAddress, MarkAsTested_FunctionAddress, "InElementHandle");
		MarkAsTested_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(MarkAsTested_FunctionAddress, "InElementHandle");
		MarkAsTested_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(MarkAsTested_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MarkAsTested_ReturnValue_PropertyAddress, MarkAsTested_FunctionAddress, "ReturnValue");
		MarkAsTested_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MarkAsTested_FunctionAddress, "ReturnValue");
		MarkAsTested_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MarkAsTested_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MarkAsTested_IsValid = MarkAsTested_FunctionAddress != IntPtr.Zero && MarkAsTested_InElementHandle_IsValid && MarkAsTested_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementFramework.TestTypedElementInterfaceB:MarkAsTested", MarkAsTested_IsValid);
	}
}
