using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ComponentOnInputTouchEndSignature__DelegateSignature")]
public class FComponentOnInputTouchEndSignature : FMulticastDelegate<FComponentOnInputTouchEndSignature.Signature>
{
	public delegate void Signature(ETouchIndex FingerIndex, UPrimitiveComponent TouchedComponent);

	private static bool ComponentOnInputTouchEndSignature__DelegateSignature_IsValid;

	private static IntPtr ComponentOnInputTouchEndSignature__DelegateSignature_FunctionAddress;

	private static int ComponentOnInputTouchEndSignature__DelegateSignature_ParamsSize;

	private static bool ComponentOnInputTouchEndSignature__DelegateSignature_FingerIndex_IsValid;

	private static FFieldAddress ComponentOnInputTouchEndSignature__DelegateSignature_FingerIndex_PropertyAddress;

	private static int ComponentOnInputTouchEndSignature__DelegateSignature_FingerIndex_Offset;

	private static bool ComponentOnInputTouchEndSignature__DelegateSignature_TouchedComponent_IsValid;

	private static FFieldAddress ComponentOnInputTouchEndSignature__DelegateSignature_TouchedComponent_PropertyAddress;

	private static int ComponentOnInputTouchEndSignature__DelegateSignature_TouchedComponent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FComponentOnInputTouchEndSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ComponentOnInputTouchEndSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ComponentOnInputTouchEndSignature__DelegateSignature");
		ComponentOnInputTouchEndSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ComponentOnInputTouchEndSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComponentOnInputTouchEndSignature__DelegateSignature_FingerIndex_PropertyAddress, ComponentOnInputTouchEndSignature__DelegateSignature_FunctionAddress, "FingerIndex");
		ComponentOnInputTouchEndSignature__DelegateSignature_FingerIndex_Offset = NativeReflectionCached.GetPropertyOffset(ComponentOnInputTouchEndSignature__DelegateSignature_FunctionAddress, "FingerIndex");
		ComponentOnInputTouchEndSignature__DelegateSignature_FingerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentOnInputTouchEndSignature__DelegateSignature_FunctionAddress, "FingerIndex", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ComponentOnInputTouchEndSignature__DelegateSignature_TouchedComponent_PropertyAddress, ComponentOnInputTouchEndSignature__DelegateSignature_FunctionAddress, "TouchedComponent");
		ComponentOnInputTouchEndSignature__DelegateSignature_TouchedComponent_Offset = NativeReflectionCached.GetPropertyOffset(ComponentOnInputTouchEndSignature__DelegateSignature_FunctionAddress, "TouchedComponent");
		ComponentOnInputTouchEndSignature__DelegateSignature_TouchedComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentOnInputTouchEndSignature__DelegateSignature_FunctionAddress, "TouchedComponent", Classes.FObjectProperty);
		ComponentOnInputTouchEndSignature__DelegateSignature_IsValid = ComponentOnInputTouchEndSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ComponentOnInputTouchEndSignature__DelegateSignature_FingerIndex_IsValid && ComponentOnInputTouchEndSignature__DelegateSignature_TouchedComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ComponentOnInputTouchEndSignature__DelegateSignature", ComponentOnInputTouchEndSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(ETouchIndex FingerIndex, UPrimitiveComponent TouchedComponent)
	{
		if (!ComponentOnInputTouchEndSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ComponentOnInputTouchEndSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ComponentOnInputTouchEndSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComponentOnInputTouchEndSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<ETouchIndex>.ToNative(IntPtr.Add(intPtr, ComponentOnInputTouchEndSignature__DelegateSignature_FingerIndex_Offset), 0, ComponentOnInputTouchEndSignature__DelegateSignature_FingerIndex_PropertyAddress.Address, FingerIndex);
			UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, ComponentOnInputTouchEndSignature__DelegateSignature_TouchedComponent_Offset), 0, ComponentOnInputTouchEndSignature__DelegateSignature_TouchedComponent_PropertyAddress.Address, TouchedComponent);
			ProcessDelegate(intPtr);
		}
	}
}
