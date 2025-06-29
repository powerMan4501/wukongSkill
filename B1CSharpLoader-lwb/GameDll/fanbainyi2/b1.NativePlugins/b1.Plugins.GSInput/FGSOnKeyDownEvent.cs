using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1.Plugins.GSInput;

[UDelegate]
[UMetaPath("/Script/GSInput.GSOnKeyDownEvent__DelegateSignature")]
public class FGSOnKeyDownEvent : FMulticastDelegate<FGSOnKeyDownEvent.Signature>
{
	public delegate void Signature(FKeyEvent InKeyEvent);

	private static bool GSOnKeyDownEvent__DelegateSignature_IsValid;

	private static IntPtr GSOnKeyDownEvent__DelegateSignature_FunctionAddress;

	private static int GSOnKeyDownEvent__DelegateSignature_ParamsSize;

	private static bool GSOnKeyDownEvent__DelegateSignature_InKeyEvent_IsValid;

	private static FFieldAddress GSOnKeyDownEvent__DelegateSignature_InKeyEvent_PropertyAddress;

	private static int GSOnKeyDownEvent__DelegateSignature_InKeyEvent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnKeyDownEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnKeyDownEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSInput.GSOnKeyDownEvent__DelegateSignature");
		GSOnKeyDownEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnKeyDownEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnKeyDownEvent__DelegateSignature_InKeyEvent_PropertyAddress, GSOnKeyDownEvent__DelegateSignature_FunctionAddress, "InKeyEvent");
		GSOnKeyDownEvent__DelegateSignature_InKeyEvent_Offset = NativeReflectionCached.GetPropertyOffset(GSOnKeyDownEvent__DelegateSignature_FunctionAddress, "InKeyEvent");
		GSOnKeyDownEvent__DelegateSignature_InKeyEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnKeyDownEvent__DelegateSignature_FunctionAddress, "InKeyEvent", Classes.FStructProperty);
		GSOnKeyDownEvent__DelegateSignature_IsValid = GSOnKeyDownEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnKeyDownEvent__DelegateSignature_InKeyEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSOnKeyDownEvent__DelegateSignature", GSOnKeyDownEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FKeyEvent InKeyEvent)
	{
		if (!GSOnKeyDownEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSOnKeyDownEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnKeyDownEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnKeyDownEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(GSOnKeyDownEvent__DelegateSignature_InKeyEvent_PropertyAddress.Address, intPtr);
			StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, GSOnKeyDownEvent__DelegateSignature_InKeyEvent_Offset), 0, GSOnKeyDownEvent__DelegateSignature_InKeyEvent_PropertyAddress.Address, InKeyEvent);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(GSOnKeyDownEvent__DelegateSignature_InKeyEvent_PropertyAddress.Address, intPtr);
		}
	}
}
