using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.AnimDataModelModifiedDynamicEvent__DelegateSignature")]
public class FAnimDataModelModifiedDynamicEvent : FMulticastDelegate<FAnimDataModelModifiedDynamicEvent.Signature>
{
	public delegate void Signature(EAnimDataModelNotifyType NotifType, UAnimDataModel Model, FAnimDataModelNotifPayload Payload);

	private static bool AnimDataModelModifiedDynamicEvent__DelegateSignature_IsValid;

	private static IntPtr AnimDataModelModifiedDynamicEvent__DelegateSignature_FunctionAddress;

	private static int AnimDataModelModifiedDynamicEvent__DelegateSignature_ParamsSize;

	private static bool AnimDataModelModifiedDynamicEvent__DelegateSignature_NotifType_IsValid;

	private static FFieldAddress AnimDataModelModifiedDynamicEvent__DelegateSignature_NotifType_PropertyAddress;

	private static int AnimDataModelModifiedDynamicEvent__DelegateSignature_NotifType_Offset;

	private static bool AnimDataModelModifiedDynamicEvent__DelegateSignature_Model_IsValid;

	private static FFieldAddress AnimDataModelModifiedDynamicEvent__DelegateSignature_Model_PropertyAddress;

	private static int AnimDataModelModifiedDynamicEvent__DelegateSignature_Model_Offset;

	private static bool AnimDataModelModifiedDynamicEvent__DelegateSignature_Payload_IsValid;

	private static FFieldAddress AnimDataModelModifiedDynamicEvent__DelegateSignature_Payload_PropertyAddress;

	private static int AnimDataModelModifiedDynamicEvent__DelegateSignature_Payload_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FAnimDataModelModifiedDynamicEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		AnimDataModelModifiedDynamicEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.AnimDataModelModifiedDynamicEvent__DelegateSignature");
		AnimDataModelModifiedDynamicEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(AnimDataModelModifiedDynamicEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AnimDataModelModifiedDynamicEvent__DelegateSignature_NotifType_PropertyAddress, AnimDataModelModifiedDynamicEvent__DelegateSignature_FunctionAddress, "NotifType");
		AnimDataModelModifiedDynamicEvent__DelegateSignature_NotifType_Offset = NativeReflectionCached.GetPropertyOffset(AnimDataModelModifiedDynamicEvent__DelegateSignature_FunctionAddress, "NotifType");
		AnimDataModelModifiedDynamicEvent__DelegateSignature_NotifType_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimDataModelModifiedDynamicEvent__DelegateSignature_FunctionAddress, "NotifType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimDataModelModifiedDynamicEvent__DelegateSignature_Model_PropertyAddress, AnimDataModelModifiedDynamicEvent__DelegateSignature_FunctionAddress, "Model");
		AnimDataModelModifiedDynamicEvent__DelegateSignature_Model_Offset = NativeReflectionCached.GetPropertyOffset(AnimDataModelModifiedDynamicEvent__DelegateSignature_FunctionAddress, "Model");
		AnimDataModelModifiedDynamicEvent__DelegateSignature_Model_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimDataModelModifiedDynamicEvent__DelegateSignature_FunctionAddress, "Model", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimDataModelModifiedDynamicEvent__DelegateSignature_Payload_PropertyAddress, AnimDataModelModifiedDynamicEvent__DelegateSignature_FunctionAddress, "Payload");
		AnimDataModelModifiedDynamicEvent__DelegateSignature_Payload_Offset = NativeReflectionCached.GetPropertyOffset(AnimDataModelModifiedDynamicEvent__DelegateSignature_FunctionAddress, "Payload");
		AnimDataModelModifiedDynamicEvent__DelegateSignature_Payload_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimDataModelModifiedDynamicEvent__DelegateSignature_FunctionAddress, "Payload", Classes.FStructProperty);
		AnimDataModelModifiedDynamicEvent__DelegateSignature_IsValid = AnimDataModelModifiedDynamicEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && AnimDataModelModifiedDynamicEvent__DelegateSignature_NotifType_IsValid && AnimDataModelModifiedDynamicEvent__DelegateSignature_Model_IsValid && AnimDataModelModifiedDynamicEvent__DelegateSignature_Payload_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimDataModelModifiedDynamicEvent__DelegateSignature", AnimDataModelModifiedDynamicEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(EAnimDataModelNotifyType NotifType, UAnimDataModel Model, FAnimDataModelNotifPayload Payload)
	{
		if (!AnimDataModelModifiedDynamicEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimDataModelModifiedDynamicEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(AnimDataModelModifiedDynamicEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AnimDataModelModifiedDynamicEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<EAnimDataModelNotifyType>.ToNative(IntPtr.Add(intPtr, AnimDataModelModifiedDynamicEvent__DelegateSignature_NotifType_Offset), 0, AnimDataModelModifiedDynamicEvent__DelegateSignature_NotifType_PropertyAddress.Address, NotifType);
			UObjectMarshaler<UAnimDataModel>.ToNative(IntPtr.Add(intPtr, AnimDataModelModifiedDynamicEvent__DelegateSignature_Model_Offset), 0, AnimDataModelModifiedDynamicEvent__DelegateSignature_Model_PropertyAddress.Address, Model);
			NativeReflection.InitializeValue_InContainer(AnimDataModelModifiedDynamicEvent__DelegateSignature_Payload_PropertyAddress.Address, intPtr);
			FAnimDataModelNotifPayload.ToNative(IntPtr.Add(intPtr, AnimDataModelModifiedDynamicEvent__DelegateSignature_Payload_Offset), 0, AnimDataModelModifiedDynamicEvent__DelegateSignature_Payload_PropertyAddress.Address, Payload);
			ProcessDelegate(intPtr);
		}
	}
}
