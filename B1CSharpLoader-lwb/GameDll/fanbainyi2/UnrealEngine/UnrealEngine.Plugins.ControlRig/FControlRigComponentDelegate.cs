using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UDelegate]
[UMetaPath("/Script/ControlRig.ControlRigComponentDelegate__DelegateSignature")]
public class FControlRigComponentDelegate : FMulticastDelegate<FControlRigComponentDelegate.Signature>
{
	public delegate void Signature(UControlRigComponent Component);

	private static bool ControlRigComponentDelegate__DelegateSignature_IsValid;

	private static IntPtr ControlRigComponentDelegate__DelegateSignature_FunctionAddress;

	private static int ControlRigComponentDelegate__DelegateSignature_ParamsSize;

	private static bool ControlRigComponentDelegate__DelegateSignature_Component_IsValid;

	private static FFieldAddress ControlRigComponentDelegate__DelegateSignature_Component_PropertyAddress;

	private static int ControlRigComponentDelegate__DelegateSignature_Component_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FControlRigComponentDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ControlRigComponentDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/ControlRig.ControlRigComponentDelegate__DelegateSignature");
		ControlRigComponentDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ControlRigComponentDelegate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ControlRigComponentDelegate__DelegateSignature_Component_PropertyAddress, ControlRigComponentDelegate__DelegateSignature_FunctionAddress, "Component");
		ControlRigComponentDelegate__DelegateSignature_Component_Offset = NativeReflectionCached.GetPropertyOffset(ControlRigComponentDelegate__DelegateSignature_FunctionAddress, "Component");
		ControlRigComponentDelegate__DelegateSignature_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(ControlRigComponentDelegate__DelegateSignature_FunctionAddress, "Component", Classes.FObjectProperty);
		ControlRigComponentDelegate__DelegateSignature_IsValid = ControlRigComponentDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && ControlRigComponentDelegate__DelegateSignature_Component_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigComponentDelegate__DelegateSignature", ControlRigComponentDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UControlRigComponent Component)
	{
		if (!ControlRigComponentDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigComponentDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ControlRigComponentDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ControlRigComponentDelegate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UControlRigComponent>.ToNative(IntPtr.Add(intPtr, ControlRigComponentDelegate__DelegateSignature_Component_Offset), 0, ControlRigComponentDelegate__DelegateSignature_Component_PropertyAddress.Address, Component);
			ProcessDelegate(intPtr);
		}
	}
}
