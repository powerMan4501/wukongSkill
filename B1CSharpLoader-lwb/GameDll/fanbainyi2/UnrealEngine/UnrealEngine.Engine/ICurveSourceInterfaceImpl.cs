using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class ICurveSourceInterfaceImpl : IInterfaceImpl, ICurveSourceInterface, IInterface
{
	private static bool GetCurveValue_IsValid;

	private IntPtr GetCurveValue_InstanceFunctionAddress;

	private static IntPtr GetCurveValue_FunctionAddress;

	private static int GetCurveValue_ParamsSize;

	private static bool GetCurveValue_CurveName_IsValid;

	private static FFieldAddress GetCurveValue_CurveName_PropertyAddress;

	private static int GetCurveValue_CurveName_Offset;

	private static bool GetCurveValue_ReturnValue_IsValid;

	private static FFieldAddress GetCurveValue_ReturnValue_PropertyAddress;

	private static int GetCurveValue_ReturnValue_Offset;

	private static bool GetCurves_IsValid;

	private IntPtr GetCurves_InstanceFunctionAddress;

	private static IntPtr GetCurves_FunctionAddress;

	private static int GetCurves_ParamsSize;

	private static bool GetCurves_OutValues_IsValid;

	private static FFieldAddress GetCurves_OutValues_PropertyAddress;

	private static int GetCurves_OutValues_Offset;

	private static bool GetBindingName_IsValid;

	private IntPtr GetBindingName_InstanceFunctionAddress;

	private static IntPtr GetBindingName_FunctionAddress;

	private static int GetBindingName_ParamsSize;

	private static bool GetBindingName_ReturnValue_IsValid;

	private static FFieldAddress GetBindingName_ReturnValue_PropertyAddress;

	private static int GetBindingName_ReturnValue_Offset;

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/Engine.CurveSourceInterface:GetCurveValue")]
	public unsafe float GetCurveValue(FName CurveName)
	{
		CheckDestroyed();
		if (!GetCurveValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CurveSourceInterface:GetCurveValue");
			return 0f;
		}
		if (GetCurveValue_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetCurveValue_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetCurveValue");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurveValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurveValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetCurveValue_CurveName_Offset), 0, GetCurveValue_CurveName_PropertyAddress.Address, CurveName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurveValue_InstanceFunctionAddress, intPtr, GetCurveValue_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCurveValue_ReturnValue_Offset), 0, GetCurveValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/Engine.CurveSourceInterface:GetCurves")]
	public unsafe void GetCurves(out List<FNamedCurveValue> OutValues)
	{
		CheckDestroyed();
		if (!GetCurves_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CurveSourceInterface:GetCurves");
			OutValues = null;
			return;
		}
		if (GetCurves_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetCurves_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetCurves");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurves_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurves_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurves_InstanceFunctionAddress, intPtr, GetCurves_ParamsSize);
		OutValues = new TArrayCopyMarshaler<FNamedCurveValue>(1, GetCurves_OutValues_PropertyAddress, CachedMarshalingDelegates<FNamedCurveValue, FNamedCurveValue>.FromNative, CachedMarshalingDelegates<FNamedCurveValue, FNamedCurveValue>.ToNative).FromNative(IntPtr.Add(intPtr, GetCurves_OutValues_Offset));
		NativeReflection.DestroyValue_InContainer(GetCurves_OutValues_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/Engine.CurveSourceInterface:GetBindingName")]
	public unsafe FName GetBindingName()
	{
		CheckDestroyed();
		if (!GetBindingName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CurveSourceInterface:GetBindingName");
			return default(FName);
		}
		if (GetBindingName_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetBindingName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetBindingName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBindingName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBindingName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBindingName_InstanceFunctionAddress, intPtr, GetBindingName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetBindingName_ReturnValue_Offset), 0, GetBindingName_ReturnValue_PropertyAddress.Address);
	}

	public override void ResetInterface()
	{
		GetCurveValue_InstanceFunctionAddress = IntPtr.Zero;
		GetCurves_InstanceFunctionAddress = IntPtr.Zero;
		GetBindingName_InstanceFunctionAddress = IntPtr.Zero;
	}

	static ICurveSourceInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ICurveSourceInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ICurveSourceInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.CurveSourceInterface");
		GetCurveValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCurveValue");
		GetCurveValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurveValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurveValue_CurveName_PropertyAddress, GetCurveValue_FunctionAddress, "CurveName");
		GetCurveValue_CurveName_Offset = NativeReflectionCached.GetPropertyOffset(GetCurveValue_FunctionAddress, "CurveName");
		GetCurveValue_CurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurveValue_FunctionAddress, "CurveName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurveValue_ReturnValue_PropertyAddress, GetCurveValue_FunctionAddress, "ReturnValue");
		GetCurveValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurveValue_FunctionAddress, "ReturnValue");
		GetCurveValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurveValue_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCurveValue_IsValid = GetCurveValue_FunctionAddress != IntPtr.Zero && GetCurveValue_CurveName_IsValid && GetCurveValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CurveSourceInterface:GetCurveValue", GetCurveValue_IsValid);
		GetCurves_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCurves");
		GetCurves_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurves_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurves_OutValues_PropertyAddress, GetCurves_FunctionAddress, "OutValues");
		GetCurves_OutValues_Offset = NativeReflectionCached.GetPropertyOffset(GetCurves_FunctionAddress, "OutValues");
		GetCurves_OutValues_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurves_FunctionAddress, "OutValues", Classes.FArrayProperty);
		GetCurves_IsValid = GetCurves_FunctionAddress != IntPtr.Zero && GetCurves_OutValues_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CurveSourceInterface:GetCurves", GetCurves_IsValid);
		GetBindingName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetBindingName");
		GetBindingName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBindingName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBindingName_ReturnValue_PropertyAddress, GetBindingName_FunctionAddress, "ReturnValue");
		GetBindingName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBindingName_FunctionAddress, "ReturnValue");
		GetBindingName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBindingName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetBindingName_IsValid = GetBindingName_FunctionAddress != IntPtr.Zero && GetBindingName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CurveSourceInterface:GetBindingName", GetBindingName_IsValid);
	}
}
