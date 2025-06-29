using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UDelegate]
[UMetaPath("/Script/GSInput.GSOnInputPreProcessEvent__DelegateSignature")]
public class FGSOnInputPreProcessEvent : FMulticastDelegate<FGSOnInputPreProcessEvent.Signature>
{
	public delegate void Signature(EGSInputType InputType);

	private static bool GSOnInputPreProcessEvent__DelegateSignature_IsValid;

	private static IntPtr GSOnInputPreProcessEvent__DelegateSignature_FunctionAddress;

	private static int GSOnInputPreProcessEvent__DelegateSignature_ParamsSize;

	private static bool GSOnInputPreProcessEvent__DelegateSignature_InputType_IsValid;

	private static FFieldAddress GSOnInputPreProcessEvent__DelegateSignature_InputType_PropertyAddress;

	private static int GSOnInputPreProcessEvent__DelegateSignature_InputType_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnInputPreProcessEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnInputPreProcessEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSInput.GSOnInputPreProcessEvent__DelegateSignature");
		GSOnInputPreProcessEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnInputPreProcessEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnInputPreProcessEvent__DelegateSignature_InputType_PropertyAddress, GSOnInputPreProcessEvent__DelegateSignature_FunctionAddress, "InputType");
		GSOnInputPreProcessEvent__DelegateSignature_InputType_Offset = NativeReflectionCached.GetPropertyOffset(GSOnInputPreProcessEvent__DelegateSignature_FunctionAddress, "InputType");
		GSOnInputPreProcessEvent__DelegateSignature_InputType_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnInputPreProcessEvent__DelegateSignature_FunctionAddress, "InputType", Classes.FEnumProperty);
		GSOnInputPreProcessEvent__DelegateSignature_IsValid = GSOnInputPreProcessEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnInputPreProcessEvent__DelegateSignature_InputType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSOnInputPreProcessEvent__DelegateSignature", GSOnInputPreProcessEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(EGSInputType InputType)
	{
		if (!GSOnInputPreProcessEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSOnInputPreProcessEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnInputPreProcessEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnInputPreProcessEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<EGSInputType>.ToNative(IntPtr.Add(intPtr, GSOnInputPreProcessEvent__DelegateSignature_InputType_Offset), 0, GSOnInputPreProcessEvent__DelegateSignature_InputType_PropertyAddress.Address, InputType);
			ProcessDelegate(intPtr);
		}
	}
}
