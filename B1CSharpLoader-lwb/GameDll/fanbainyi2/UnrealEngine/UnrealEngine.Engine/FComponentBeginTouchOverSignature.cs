using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ComponentBeginTouchOverSignature__DelegateSignature")]
public class FComponentBeginTouchOverSignature : FMulticastDelegate<FComponentBeginTouchOverSignature.Signature>
{
	public delegate void Signature(ETouchIndex FingerIndex, UPrimitiveComponent TouchedComponent);

	private static bool ComponentBeginTouchOverSignature__DelegateSignature_IsValid;

	private static IntPtr ComponentBeginTouchOverSignature__DelegateSignature_FunctionAddress;

	private static int ComponentBeginTouchOverSignature__DelegateSignature_ParamsSize;

	private static bool ComponentBeginTouchOverSignature__DelegateSignature_FingerIndex_IsValid;

	private static FFieldAddress ComponentBeginTouchOverSignature__DelegateSignature_FingerIndex_PropertyAddress;

	private static int ComponentBeginTouchOverSignature__DelegateSignature_FingerIndex_Offset;

	private static bool ComponentBeginTouchOverSignature__DelegateSignature_TouchedComponent_IsValid;

	private static FFieldAddress ComponentBeginTouchOverSignature__DelegateSignature_TouchedComponent_PropertyAddress;

	private static int ComponentBeginTouchOverSignature__DelegateSignature_TouchedComponent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FComponentBeginTouchOverSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ComponentBeginTouchOverSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ComponentBeginTouchOverSignature__DelegateSignature");
		ComponentBeginTouchOverSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ComponentBeginTouchOverSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComponentBeginTouchOverSignature__DelegateSignature_FingerIndex_PropertyAddress, ComponentBeginTouchOverSignature__DelegateSignature_FunctionAddress, "FingerIndex");
		ComponentBeginTouchOverSignature__DelegateSignature_FingerIndex_Offset = NativeReflectionCached.GetPropertyOffset(ComponentBeginTouchOverSignature__DelegateSignature_FunctionAddress, "FingerIndex");
		ComponentBeginTouchOverSignature__DelegateSignature_FingerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentBeginTouchOverSignature__DelegateSignature_FunctionAddress, "FingerIndex", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ComponentBeginTouchOverSignature__DelegateSignature_TouchedComponent_PropertyAddress, ComponentBeginTouchOverSignature__DelegateSignature_FunctionAddress, "TouchedComponent");
		ComponentBeginTouchOverSignature__DelegateSignature_TouchedComponent_Offset = NativeReflectionCached.GetPropertyOffset(ComponentBeginTouchOverSignature__DelegateSignature_FunctionAddress, "TouchedComponent");
		ComponentBeginTouchOverSignature__DelegateSignature_TouchedComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentBeginTouchOverSignature__DelegateSignature_FunctionAddress, "TouchedComponent", Classes.FObjectProperty);
		ComponentBeginTouchOverSignature__DelegateSignature_IsValid = ComponentBeginTouchOverSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ComponentBeginTouchOverSignature__DelegateSignature_FingerIndex_IsValid && ComponentBeginTouchOverSignature__DelegateSignature_TouchedComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ComponentBeginTouchOverSignature__DelegateSignature", ComponentBeginTouchOverSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(ETouchIndex FingerIndex, UPrimitiveComponent TouchedComponent)
	{
		if (!ComponentBeginTouchOverSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ComponentBeginTouchOverSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ComponentBeginTouchOverSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComponentBeginTouchOverSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<ETouchIndex>.ToNative(IntPtr.Add(intPtr, ComponentBeginTouchOverSignature__DelegateSignature_FingerIndex_Offset), 0, ComponentBeginTouchOverSignature__DelegateSignature_FingerIndex_PropertyAddress.Address, FingerIndex);
			UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, ComponentBeginTouchOverSignature__DelegateSignature_TouchedComponent_Offset), 0, ComponentBeginTouchOverSignature__DelegateSignature_TouchedComponent_PropertyAddress.Address, TouchedComponent);
			ProcessDelegate(intPtr);
		}
	}
}
