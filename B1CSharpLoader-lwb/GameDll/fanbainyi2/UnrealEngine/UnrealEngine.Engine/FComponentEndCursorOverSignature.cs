using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ComponentEndCursorOverSignature__DelegateSignature")]
public class FComponentEndCursorOverSignature : FMulticastDelegate<FComponentEndCursorOverSignature.Signature>
{
	public delegate void Signature(UPrimitiveComponent TouchedComponent);

	private static bool ComponentEndCursorOverSignature__DelegateSignature_IsValid;

	private static IntPtr ComponentEndCursorOverSignature__DelegateSignature_FunctionAddress;

	private static int ComponentEndCursorOverSignature__DelegateSignature_ParamsSize;

	private static bool ComponentEndCursorOverSignature__DelegateSignature_TouchedComponent_IsValid;

	private static FFieldAddress ComponentEndCursorOverSignature__DelegateSignature_TouchedComponent_PropertyAddress;

	private static int ComponentEndCursorOverSignature__DelegateSignature_TouchedComponent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FComponentEndCursorOverSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ComponentEndCursorOverSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ComponentEndCursorOverSignature__DelegateSignature");
		ComponentEndCursorOverSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ComponentEndCursorOverSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComponentEndCursorOverSignature__DelegateSignature_TouchedComponent_PropertyAddress, ComponentEndCursorOverSignature__DelegateSignature_FunctionAddress, "TouchedComponent");
		ComponentEndCursorOverSignature__DelegateSignature_TouchedComponent_Offset = NativeReflectionCached.GetPropertyOffset(ComponentEndCursorOverSignature__DelegateSignature_FunctionAddress, "TouchedComponent");
		ComponentEndCursorOverSignature__DelegateSignature_TouchedComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentEndCursorOverSignature__DelegateSignature_FunctionAddress, "TouchedComponent", Classes.FObjectProperty);
		ComponentEndCursorOverSignature__DelegateSignature_IsValid = ComponentEndCursorOverSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ComponentEndCursorOverSignature__DelegateSignature_TouchedComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ComponentEndCursorOverSignature__DelegateSignature", ComponentEndCursorOverSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UPrimitiveComponent TouchedComponent)
	{
		if (!ComponentEndCursorOverSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ComponentEndCursorOverSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ComponentEndCursorOverSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComponentEndCursorOverSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, ComponentEndCursorOverSignature__DelegateSignature_TouchedComponent_Offset), 0, ComponentEndCursorOverSignature__DelegateSignature_TouchedComponent_PropertyAddress.Address, TouchedComponent);
			ProcessDelegate(intPtr);
		}
	}
}
