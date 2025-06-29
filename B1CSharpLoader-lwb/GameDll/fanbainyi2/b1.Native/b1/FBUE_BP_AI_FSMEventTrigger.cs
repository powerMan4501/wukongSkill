using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/b1.BUE_BP_AI_FSMEventTrigger__DelegateSignature")]
public class FBUE_BP_AI_FSMEventTrigger : FMulticastDelegate<FBUE_BP_AI_FSMEventTrigger.Signature>
{
	public delegate void Signature(EBGUFSMEventName EventID);

	private static bool BUE_BP_AI_FSMEventTrigger__DelegateSignature_IsValid;

	private static IntPtr BUE_BP_AI_FSMEventTrigger__DelegateSignature_FunctionAddress;

	private static int BUE_BP_AI_FSMEventTrigger__DelegateSignature_ParamsSize;

	private static bool BUE_BP_AI_FSMEventTrigger__DelegateSignature_EventID_IsValid;

	private static FFieldAddress BUE_BP_AI_FSMEventTrigger__DelegateSignature_EventID_PropertyAddress;

	private static int BUE_BP_AI_FSMEventTrigger__DelegateSignature_EventID_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FBUE_BP_AI_FSMEventTrigger()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		BUE_BP_AI_FSMEventTrigger__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/b1.BUE_BP_AI_FSMEventTrigger__DelegateSignature");
		BUE_BP_AI_FSMEventTrigger__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(BUE_BP_AI_FSMEventTrigger__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BUE_BP_AI_FSMEventTrigger__DelegateSignature_EventID_PropertyAddress, BUE_BP_AI_FSMEventTrigger__DelegateSignature_FunctionAddress, "EventID");
		BUE_BP_AI_FSMEventTrigger__DelegateSignature_EventID_Offset = NativeReflectionCached.GetPropertyOffset(BUE_BP_AI_FSMEventTrigger__DelegateSignature_FunctionAddress, "EventID");
		BUE_BP_AI_FSMEventTrigger__DelegateSignature_EventID_IsValid = NativeReflectionCached.ValidatePropertyClass(BUE_BP_AI_FSMEventTrigger__DelegateSignature_FunctionAddress, "EventID", Classes.FEnumProperty);
		BUE_BP_AI_FSMEventTrigger__DelegateSignature_IsValid = BUE_BP_AI_FSMEventTrigger__DelegateSignature_FunctionAddress != IntPtr.Zero && BUE_BP_AI_FSMEventTrigger__DelegateSignature_EventID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUE_BP_AI_FSMEventTrigger__DelegateSignature", BUE_BP_AI_FSMEventTrigger__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(EBGUFSMEventName EventID)
	{
		if (!BUE_BP_AI_FSMEventTrigger__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUE_BP_AI_FSMEventTrigger__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(BUE_BP_AI_FSMEventTrigger__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BUE_BP_AI_FSMEventTrigger__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<EBGUFSMEventName>.ToNative(IntPtr.Add(intPtr, BUE_BP_AI_FSMEventTrigger__DelegateSignature_EventID_Offset), 0, BUE_BP_AI_FSMEventTrigger__DelegateSignature_EventID_PropertyAddress.Address, EventID);
			ProcessDelegate(intPtr);
		}
	}
}
