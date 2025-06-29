using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ComponentEndTouchOverSignature__DelegateSignature")]
public class FComponentEndTouchOverSignature : FMulticastDelegate<FComponentEndTouchOverSignature.Signature>
{
	public delegate void Signature(ETouchIndex FingerIndex, UPrimitiveComponent TouchedComponent);

	private static bool ComponentEndTouchOverSignature__DelegateSignature_IsValid;

	private static IntPtr ComponentEndTouchOverSignature__DelegateSignature_FunctionAddress;

	private static int ComponentEndTouchOverSignature__DelegateSignature_ParamsSize;

	private static bool ComponentEndTouchOverSignature__DelegateSignature_FingerIndex_IsValid;

	private static FFieldAddress ComponentEndTouchOverSignature__DelegateSignature_FingerIndex_PropertyAddress;

	private static int ComponentEndTouchOverSignature__DelegateSignature_FingerIndex_Offset;

	private static bool ComponentEndTouchOverSignature__DelegateSignature_TouchedComponent_IsValid;

	private static FFieldAddress ComponentEndTouchOverSignature__DelegateSignature_TouchedComponent_PropertyAddress;

	private static int ComponentEndTouchOverSignature__DelegateSignature_TouchedComponent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FComponentEndTouchOverSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ComponentEndTouchOverSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ComponentEndTouchOverSignature__DelegateSignature");
		ComponentEndTouchOverSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ComponentEndTouchOverSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComponentEndTouchOverSignature__DelegateSignature_FingerIndex_PropertyAddress, ComponentEndTouchOverSignature__DelegateSignature_FunctionAddress, "FingerIndex");
		ComponentEndTouchOverSignature__DelegateSignature_FingerIndex_Offset = NativeReflectionCached.GetPropertyOffset(ComponentEndTouchOverSignature__DelegateSignature_FunctionAddress, "FingerIndex");
		ComponentEndTouchOverSignature__DelegateSignature_FingerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentEndTouchOverSignature__DelegateSignature_FunctionAddress, "FingerIndex", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ComponentEndTouchOverSignature__DelegateSignature_TouchedComponent_PropertyAddress, ComponentEndTouchOverSignature__DelegateSignature_FunctionAddress, "TouchedComponent");
		ComponentEndTouchOverSignature__DelegateSignature_TouchedComponent_Offset = NativeReflectionCached.GetPropertyOffset(ComponentEndTouchOverSignature__DelegateSignature_FunctionAddress, "TouchedComponent");
		ComponentEndTouchOverSignature__DelegateSignature_TouchedComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentEndTouchOverSignature__DelegateSignature_FunctionAddress, "TouchedComponent", Classes.FObjectProperty);
		ComponentEndTouchOverSignature__DelegateSignature_IsValid = ComponentEndTouchOverSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ComponentEndTouchOverSignature__DelegateSignature_FingerIndex_IsValid && ComponentEndTouchOverSignature__DelegateSignature_TouchedComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ComponentEndTouchOverSignature__DelegateSignature", ComponentEndTouchOverSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(ETouchIndex FingerIndex, UPrimitiveComponent TouchedComponent)
	{
		if (!ComponentEndTouchOverSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ComponentEndTouchOverSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ComponentEndTouchOverSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComponentEndTouchOverSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<ETouchIndex>.ToNative(IntPtr.Add(intPtr, ComponentEndTouchOverSignature__DelegateSignature_FingerIndex_Offset), 0, ComponentEndTouchOverSignature__DelegateSignature_FingerIndex_PropertyAddress.Address, FingerIndex);
			UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, ComponentEndTouchOverSignature__DelegateSignature_TouchedComponent_Offset), 0, ComponentEndTouchOverSignature__DelegateSignature_TouchedComponent_PropertyAddress.Address, TouchedComponent);
			ProcessDelegate(intPtr);
		}
	}
}
