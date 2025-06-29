using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnQuartzCommandEvent__DelegateSignature")]
public class FOnQuartzCommandEvent : FMulticastDelegate<FOnQuartzCommandEvent.Signature>
{
	public delegate void Signature(EQuartzCommandDelegateSubType EventType, FName Name);

	private static bool OnQuartzCommandEvent__DelegateSignature_IsValid;

	private static IntPtr OnQuartzCommandEvent__DelegateSignature_FunctionAddress;

	private static int OnQuartzCommandEvent__DelegateSignature_ParamsSize;

	private static bool OnQuartzCommandEvent__DelegateSignature_EventType_IsValid;

	private static FFieldAddress OnQuartzCommandEvent__DelegateSignature_EventType_PropertyAddress;

	private static int OnQuartzCommandEvent__DelegateSignature_EventType_Offset;

	private static bool OnQuartzCommandEvent__DelegateSignature_Name_IsValid;

	private static FFieldAddress OnQuartzCommandEvent__DelegateSignature_Name_PropertyAddress;

	private static int OnQuartzCommandEvent__DelegateSignature_Name_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnQuartzCommandEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnQuartzCommandEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnQuartzCommandEvent__DelegateSignature");
		OnQuartzCommandEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnQuartzCommandEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnQuartzCommandEvent__DelegateSignature_EventType_PropertyAddress, OnQuartzCommandEvent__DelegateSignature_FunctionAddress, "EventType");
		OnQuartzCommandEvent__DelegateSignature_EventType_Offset = NativeReflectionCached.GetPropertyOffset(OnQuartzCommandEvent__DelegateSignature_FunctionAddress, "EventType");
		OnQuartzCommandEvent__DelegateSignature_EventType_IsValid = NativeReflectionCached.ValidatePropertyClass(OnQuartzCommandEvent__DelegateSignature_FunctionAddress, "EventType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref OnQuartzCommandEvent__DelegateSignature_Name_PropertyAddress, OnQuartzCommandEvent__DelegateSignature_FunctionAddress, "Name");
		OnQuartzCommandEvent__DelegateSignature_Name_Offset = NativeReflectionCached.GetPropertyOffset(OnQuartzCommandEvent__DelegateSignature_FunctionAddress, "Name");
		OnQuartzCommandEvent__DelegateSignature_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(OnQuartzCommandEvent__DelegateSignature_FunctionAddress, "Name", Classes.FNameProperty);
		OnQuartzCommandEvent__DelegateSignature_IsValid = OnQuartzCommandEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnQuartzCommandEvent__DelegateSignature_EventType_IsValid && OnQuartzCommandEvent__DelegateSignature_Name_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnQuartzCommandEvent__DelegateSignature", OnQuartzCommandEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(EQuartzCommandDelegateSubType EventType, FName Name)
	{
		if (!OnQuartzCommandEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnQuartzCommandEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnQuartzCommandEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnQuartzCommandEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<EQuartzCommandDelegateSubType>.ToNative(IntPtr.Add(intPtr, OnQuartzCommandEvent__DelegateSignature_EventType_Offset), 0, OnQuartzCommandEvent__DelegateSignature_EventType_PropertyAddress.Address, EventType);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnQuartzCommandEvent__DelegateSignature_Name_Offset), 0, OnQuartzCommandEvent__DelegateSignature_Name_PropertyAddress.Address, Name);
			ProcessDelegate(intPtr);
		}
	}
}
