using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1.Plugins.GSInput;

[UDelegate]
[UMetaPath("/Script/GSInput.GSOnAnalogInputEvent__DelegateSignature")]
public class FGSOnAnalogInputEvent : FMulticastDelegate<FGSOnAnalogInputEvent.Signature>
{
	public delegate void Signature(FAnalogInputEvent InAnalogInputEvent);

	private static bool GSOnAnalogInputEvent__DelegateSignature_IsValid;

	private static IntPtr GSOnAnalogInputEvent__DelegateSignature_FunctionAddress;

	private static int GSOnAnalogInputEvent__DelegateSignature_ParamsSize;

	private static bool GSOnAnalogInputEvent__DelegateSignature_InAnalogInputEvent_IsValid;

	private static FFieldAddress GSOnAnalogInputEvent__DelegateSignature_InAnalogInputEvent_PropertyAddress;

	private static int GSOnAnalogInputEvent__DelegateSignature_InAnalogInputEvent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnAnalogInputEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnAnalogInputEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSInput.GSOnAnalogInputEvent__DelegateSignature");
		GSOnAnalogInputEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnAnalogInputEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnAnalogInputEvent__DelegateSignature_InAnalogInputEvent_PropertyAddress, GSOnAnalogInputEvent__DelegateSignature_FunctionAddress, "InAnalogInputEvent");
		GSOnAnalogInputEvent__DelegateSignature_InAnalogInputEvent_Offset = NativeReflectionCached.GetPropertyOffset(GSOnAnalogInputEvent__DelegateSignature_FunctionAddress, "InAnalogInputEvent");
		GSOnAnalogInputEvent__DelegateSignature_InAnalogInputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnAnalogInputEvent__DelegateSignature_FunctionAddress, "InAnalogInputEvent", Classes.FStructProperty);
		GSOnAnalogInputEvent__DelegateSignature_IsValid = GSOnAnalogInputEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnAnalogInputEvent__DelegateSignature_InAnalogInputEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSOnAnalogInputEvent__DelegateSignature", GSOnAnalogInputEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FAnalogInputEvent InAnalogInputEvent)
	{
		if (!GSOnAnalogInputEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSOnAnalogInputEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnAnalogInputEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnAnalogInputEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(GSOnAnalogInputEvent__DelegateSignature_InAnalogInputEvent_PropertyAddress.Address, intPtr);
			StructAsClassMarshaler<FAnalogInputEvent>.ToNative(IntPtr.Add(intPtr, GSOnAnalogInputEvent__DelegateSignature_InAnalogInputEvent_Offset), 0, GSOnAnalogInputEvent__DelegateSignature_InAnalogInputEvent_PropertyAddress.Address, InAnalogInputEvent);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(GSOnAnalogInputEvent__DelegateSignature_InAnalogInputEvent_PropertyAddress.Address, intPtr);
		}
	}
}
