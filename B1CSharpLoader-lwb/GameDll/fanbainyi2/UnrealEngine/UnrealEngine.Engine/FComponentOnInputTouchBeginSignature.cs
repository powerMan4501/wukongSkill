using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ComponentOnInputTouchBeginSignature__DelegateSignature")]
public class FComponentOnInputTouchBeginSignature : FMulticastDelegate<FComponentOnInputTouchBeginSignature.Signature>
{
	public delegate void Signature(ETouchIndex FingerIndex, UPrimitiveComponent TouchedComponent);

	private static bool ComponentOnInputTouchBeginSignature__DelegateSignature_IsValid;

	private static IntPtr ComponentOnInputTouchBeginSignature__DelegateSignature_FunctionAddress;

	private static int ComponentOnInputTouchBeginSignature__DelegateSignature_ParamsSize;

	private static bool ComponentOnInputTouchBeginSignature__DelegateSignature_FingerIndex_IsValid;

	private static FFieldAddress ComponentOnInputTouchBeginSignature__DelegateSignature_FingerIndex_PropertyAddress;

	private static int ComponentOnInputTouchBeginSignature__DelegateSignature_FingerIndex_Offset;

	private static bool ComponentOnInputTouchBeginSignature__DelegateSignature_TouchedComponent_IsValid;

	private static FFieldAddress ComponentOnInputTouchBeginSignature__DelegateSignature_TouchedComponent_PropertyAddress;

	private static int ComponentOnInputTouchBeginSignature__DelegateSignature_TouchedComponent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FComponentOnInputTouchBeginSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ComponentOnInputTouchBeginSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ComponentOnInputTouchBeginSignature__DelegateSignature");
		ComponentOnInputTouchBeginSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ComponentOnInputTouchBeginSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComponentOnInputTouchBeginSignature__DelegateSignature_FingerIndex_PropertyAddress, ComponentOnInputTouchBeginSignature__DelegateSignature_FunctionAddress, "FingerIndex");
		ComponentOnInputTouchBeginSignature__DelegateSignature_FingerIndex_Offset = NativeReflectionCached.GetPropertyOffset(ComponentOnInputTouchBeginSignature__DelegateSignature_FunctionAddress, "FingerIndex");
		ComponentOnInputTouchBeginSignature__DelegateSignature_FingerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentOnInputTouchBeginSignature__DelegateSignature_FunctionAddress, "FingerIndex", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ComponentOnInputTouchBeginSignature__DelegateSignature_TouchedComponent_PropertyAddress, ComponentOnInputTouchBeginSignature__DelegateSignature_FunctionAddress, "TouchedComponent");
		ComponentOnInputTouchBeginSignature__DelegateSignature_TouchedComponent_Offset = NativeReflectionCached.GetPropertyOffset(ComponentOnInputTouchBeginSignature__DelegateSignature_FunctionAddress, "TouchedComponent");
		ComponentOnInputTouchBeginSignature__DelegateSignature_TouchedComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentOnInputTouchBeginSignature__DelegateSignature_FunctionAddress, "TouchedComponent", Classes.FObjectProperty);
		ComponentOnInputTouchBeginSignature__DelegateSignature_IsValid = ComponentOnInputTouchBeginSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ComponentOnInputTouchBeginSignature__DelegateSignature_FingerIndex_IsValid && ComponentOnInputTouchBeginSignature__DelegateSignature_TouchedComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ComponentOnInputTouchBeginSignature__DelegateSignature", ComponentOnInputTouchBeginSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(ETouchIndex FingerIndex, UPrimitiveComponent TouchedComponent)
	{
		if (!ComponentOnInputTouchBeginSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ComponentOnInputTouchBeginSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ComponentOnInputTouchBeginSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComponentOnInputTouchBeginSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<ETouchIndex>.ToNative(IntPtr.Add(intPtr, ComponentOnInputTouchBeginSignature__DelegateSignature_FingerIndex_Offset), 0, ComponentOnInputTouchBeginSignature__DelegateSignature_FingerIndex_PropertyAddress.Address, FingerIndex);
			UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, ComponentOnInputTouchBeginSignature__DelegateSignature_TouchedComponent_Offset), 0, ComponentOnInputTouchBeginSignature__DelegateSignature_TouchedComponent_PropertyAddress.Address, TouchedComponent);
			ProcessDelegate(intPtr);
		}
	}
}
