using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UDelegate]
[UMetaPath("/Script/GSInput.GSOnInputTypeChangeEvent__DelegateSignature")]
public class FGSOnInputTypeChangeEvent : FMulticastDelegate<FGSOnInputTypeChangeEvent.Signature>
{
	public delegate void Signature(EGSInputType InputType);

	private static bool GSOnInputTypeChangeEvent__DelegateSignature_IsValid;

	private static IntPtr GSOnInputTypeChangeEvent__DelegateSignature_FunctionAddress;

	private static int GSOnInputTypeChangeEvent__DelegateSignature_ParamsSize;

	private static bool GSOnInputTypeChangeEvent__DelegateSignature_InputType_IsValid;

	private static FFieldAddress GSOnInputTypeChangeEvent__DelegateSignature_InputType_PropertyAddress;

	private static int GSOnInputTypeChangeEvent__DelegateSignature_InputType_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnInputTypeChangeEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnInputTypeChangeEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSInput.GSOnInputTypeChangeEvent__DelegateSignature");
		GSOnInputTypeChangeEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnInputTypeChangeEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnInputTypeChangeEvent__DelegateSignature_InputType_PropertyAddress, GSOnInputTypeChangeEvent__DelegateSignature_FunctionAddress, "InputType");
		GSOnInputTypeChangeEvent__DelegateSignature_InputType_Offset = NativeReflectionCached.GetPropertyOffset(GSOnInputTypeChangeEvent__DelegateSignature_FunctionAddress, "InputType");
		GSOnInputTypeChangeEvent__DelegateSignature_InputType_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnInputTypeChangeEvent__DelegateSignature_FunctionAddress, "InputType", Classes.FEnumProperty);
		GSOnInputTypeChangeEvent__DelegateSignature_IsValid = GSOnInputTypeChangeEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnInputTypeChangeEvent__DelegateSignature_InputType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSOnInputTypeChangeEvent__DelegateSignature", GSOnInputTypeChangeEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(EGSInputType InputType)
	{
		if (!GSOnInputTypeChangeEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSOnInputTypeChangeEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnInputTypeChangeEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnInputTypeChangeEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<EGSInputType>.ToNative(IntPtr.Add(intPtr, GSOnInputTypeChangeEvent__DelegateSignature_InputType_Offset), 0, GSOnInputTypeChangeEvent__DelegateSignature_InputType_PropertyAddress.Address, InputType);
			ProcessDelegate(intPtr);
		}
	}
}
