using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1.Plugins.GSInput;

[UDelegate]
[UMetaPath("/Script/GSInput.GSOnKeyUpEvent__DelegateSignature")]
public class FGSOnKeyUpEvent : FMulticastDelegate<FGSOnKeyUpEvent.Signature>
{
	public delegate void Signature(FKeyEvent InKeyEvent);

	private static bool GSOnKeyUpEvent__DelegateSignature_IsValid;

	private static IntPtr GSOnKeyUpEvent__DelegateSignature_FunctionAddress;

	private static int GSOnKeyUpEvent__DelegateSignature_ParamsSize;

	private static bool GSOnKeyUpEvent__DelegateSignature_InKeyEvent_IsValid;

	private static FFieldAddress GSOnKeyUpEvent__DelegateSignature_InKeyEvent_PropertyAddress;

	private static int GSOnKeyUpEvent__DelegateSignature_InKeyEvent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnKeyUpEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnKeyUpEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSInput.GSOnKeyUpEvent__DelegateSignature");
		GSOnKeyUpEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnKeyUpEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnKeyUpEvent__DelegateSignature_InKeyEvent_PropertyAddress, GSOnKeyUpEvent__DelegateSignature_FunctionAddress, "InKeyEvent");
		GSOnKeyUpEvent__DelegateSignature_InKeyEvent_Offset = NativeReflectionCached.GetPropertyOffset(GSOnKeyUpEvent__DelegateSignature_FunctionAddress, "InKeyEvent");
		GSOnKeyUpEvent__DelegateSignature_InKeyEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnKeyUpEvent__DelegateSignature_FunctionAddress, "InKeyEvent", Classes.FStructProperty);
		GSOnKeyUpEvent__DelegateSignature_IsValid = GSOnKeyUpEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnKeyUpEvent__DelegateSignature_InKeyEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSOnKeyUpEvent__DelegateSignature", GSOnKeyUpEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FKeyEvent InKeyEvent)
	{
		if (!GSOnKeyUpEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSOnKeyUpEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnKeyUpEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnKeyUpEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(GSOnKeyUpEvent__DelegateSignature_InKeyEvent_PropertyAddress.Address, intPtr);
			StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, GSOnKeyUpEvent__DelegateSignature_InKeyEvent_Offset), 0, GSOnKeyUpEvent__DelegateSignature_InKeyEvent_PropertyAddress.Address, InKeyEvent);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(GSOnKeyUpEvent__DelegateSignature_InKeyEvent_PropertyAddress.Address, intPtr);
		}
	}
}
