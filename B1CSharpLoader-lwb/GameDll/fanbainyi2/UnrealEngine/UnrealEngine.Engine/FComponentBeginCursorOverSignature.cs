using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ComponentBeginCursorOverSignature__DelegateSignature")]
public class FComponentBeginCursorOverSignature : FMulticastDelegate<FComponentBeginCursorOverSignature.Signature>
{
	public delegate void Signature(UPrimitiveComponent TouchedComponent);

	private static bool ComponentBeginCursorOverSignature__DelegateSignature_IsValid;

	private static IntPtr ComponentBeginCursorOverSignature__DelegateSignature_FunctionAddress;

	private static int ComponentBeginCursorOverSignature__DelegateSignature_ParamsSize;

	private static bool ComponentBeginCursorOverSignature__DelegateSignature_TouchedComponent_IsValid;

	private static FFieldAddress ComponentBeginCursorOverSignature__DelegateSignature_TouchedComponent_PropertyAddress;

	private static int ComponentBeginCursorOverSignature__DelegateSignature_TouchedComponent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FComponentBeginCursorOverSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ComponentBeginCursorOverSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ComponentBeginCursorOverSignature__DelegateSignature");
		ComponentBeginCursorOverSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ComponentBeginCursorOverSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComponentBeginCursorOverSignature__DelegateSignature_TouchedComponent_PropertyAddress, ComponentBeginCursorOverSignature__DelegateSignature_FunctionAddress, "TouchedComponent");
		ComponentBeginCursorOverSignature__DelegateSignature_TouchedComponent_Offset = NativeReflectionCached.GetPropertyOffset(ComponentBeginCursorOverSignature__DelegateSignature_FunctionAddress, "TouchedComponent");
		ComponentBeginCursorOverSignature__DelegateSignature_TouchedComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentBeginCursorOverSignature__DelegateSignature_FunctionAddress, "TouchedComponent", Classes.FObjectProperty);
		ComponentBeginCursorOverSignature__DelegateSignature_IsValid = ComponentBeginCursorOverSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ComponentBeginCursorOverSignature__DelegateSignature_TouchedComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ComponentBeginCursorOverSignature__DelegateSignature", ComponentBeginCursorOverSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UPrimitiveComponent TouchedComponent)
	{
		if (!ComponentBeginCursorOverSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ComponentBeginCursorOverSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ComponentBeginCursorOverSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComponentBeginCursorOverSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, ComponentBeginCursorOverSignature__DelegateSignature_TouchedComponent_Offset), 0, ComponentBeginCursorOverSignature__DelegateSignature_TouchedComponent_PropertyAddress.Address, TouchedComponent);
			ProcessDelegate(intPtr);
		}
	}
}
