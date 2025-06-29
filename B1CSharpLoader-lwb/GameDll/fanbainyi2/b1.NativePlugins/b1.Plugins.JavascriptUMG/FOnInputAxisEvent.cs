using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptUMG;

[UDelegate]
[UMetaPath("/Script/JavascriptUMG.OnInputAxisEvent__DelegateSignature")]
public class FOnInputAxisEvent : FMulticastDelegate<FOnInputAxisEvent.Signature>
{
	public delegate void Signature(float Axis, FName AxisName);

	private static bool OnInputAxisEvent__DelegateSignature_IsValid;

	private static IntPtr OnInputAxisEvent__DelegateSignature_FunctionAddress;

	private static int OnInputAxisEvent__DelegateSignature_ParamsSize;

	private static bool OnInputAxisEvent__DelegateSignature_Axis_IsValid;

	private static FFieldAddress OnInputAxisEvent__DelegateSignature_Axis_PropertyAddress;

	private static int OnInputAxisEvent__DelegateSignature_Axis_Offset;

	private static bool OnInputAxisEvent__DelegateSignature_AxisName_IsValid;

	private static FFieldAddress OnInputAxisEvent__DelegateSignature_AxisName_PropertyAddress;

	private static int OnInputAxisEvent__DelegateSignature_AxisName_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnInputAxisEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnInputAxisEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.OnInputAxisEvent__DelegateSignature");
		OnInputAxisEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInputAxisEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnInputAxisEvent__DelegateSignature_Axis_PropertyAddress, OnInputAxisEvent__DelegateSignature_FunctionAddress, "Axis");
		OnInputAxisEvent__DelegateSignature_Axis_Offset = NativeReflectionCached.GetPropertyOffset(OnInputAxisEvent__DelegateSignature_FunctionAddress, "Axis");
		OnInputAxisEvent__DelegateSignature_Axis_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputAxisEvent__DelegateSignature_FunctionAddress, "Axis", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OnInputAxisEvent__DelegateSignature_AxisName_PropertyAddress, OnInputAxisEvent__DelegateSignature_FunctionAddress, "AxisName");
		OnInputAxisEvent__DelegateSignature_AxisName_Offset = NativeReflectionCached.GetPropertyOffset(OnInputAxisEvent__DelegateSignature_FunctionAddress, "AxisName");
		OnInputAxisEvent__DelegateSignature_AxisName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputAxisEvent__DelegateSignature_FunctionAddress, "AxisName", Classes.FNameProperty);
		OnInputAxisEvent__DelegateSignature_IsValid = OnInputAxisEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnInputAxisEvent__DelegateSignature_Axis_IsValid && OnInputAxisEvent__DelegateSignature_AxisName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.OnInputAxisEvent__DelegateSignature", OnInputAxisEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(float Axis, FName AxisName)
	{
		if (!OnInputAxisEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.OnInputAxisEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnInputAxisEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputAxisEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnInputAxisEvent__DelegateSignature_Axis_Offset), 0, OnInputAxisEvent__DelegateSignature_Axis_PropertyAddress.Address, Axis);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnInputAxisEvent__DelegateSignature_AxisName_Offset), 0, OnInputAxisEvent__DelegateSignature_AxisName_PropertyAddress.Address, AxisName);
			ProcessDelegate(intPtr);
		}
	}
}
