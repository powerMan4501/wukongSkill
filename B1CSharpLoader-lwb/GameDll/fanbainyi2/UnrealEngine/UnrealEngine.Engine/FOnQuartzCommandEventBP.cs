using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnQuartzCommandEventBP__DelegateSignature")]
public class FOnQuartzCommandEventBP : FDelegate<FOnQuartzCommandEventBP.Signature>
{
	public delegate void Signature(EQuartzCommandDelegateSubType EventType, FName Name);

	private static bool OnQuartzCommandEventBP__DelegateSignature_IsValid;

	private static IntPtr OnQuartzCommandEventBP__DelegateSignature_FunctionAddress;

	private static int OnQuartzCommandEventBP__DelegateSignature_ParamsSize;

	private static bool OnQuartzCommandEventBP__DelegateSignature_EventType_IsValid;

	private static FFieldAddress OnQuartzCommandEventBP__DelegateSignature_EventType_PropertyAddress;

	private static int OnQuartzCommandEventBP__DelegateSignature_EventType_Offset;

	private static bool OnQuartzCommandEventBP__DelegateSignature_Name_IsValid;

	private static FFieldAddress OnQuartzCommandEventBP__DelegateSignature_Name_PropertyAddress;

	private static int OnQuartzCommandEventBP__DelegateSignature_Name_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnQuartzCommandEventBP()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnQuartzCommandEventBP__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnQuartzCommandEventBP__DelegateSignature");
		OnQuartzCommandEventBP__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnQuartzCommandEventBP__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnQuartzCommandEventBP__DelegateSignature_EventType_PropertyAddress, OnQuartzCommandEventBP__DelegateSignature_FunctionAddress, "EventType");
		OnQuartzCommandEventBP__DelegateSignature_EventType_Offset = NativeReflectionCached.GetPropertyOffset(OnQuartzCommandEventBP__DelegateSignature_FunctionAddress, "EventType");
		OnQuartzCommandEventBP__DelegateSignature_EventType_IsValid = NativeReflectionCached.ValidatePropertyClass(OnQuartzCommandEventBP__DelegateSignature_FunctionAddress, "EventType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref OnQuartzCommandEventBP__DelegateSignature_Name_PropertyAddress, OnQuartzCommandEventBP__DelegateSignature_FunctionAddress, "Name");
		OnQuartzCommandEventBP__DelegateSignature_Name_Offset = NativeReflectionCached.GetPropertyOffset(OnQuartzCommandEventBP__DelegateSignature_FunctionAddress, "Name");
		OnQuartzCommandEventBP__DelegateSignature_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(OnQuartzCommandEventBP__DelegateSignature_FunctionAddress, "Name", Classes.FNameProperty);
		OnQuartzCommandEventBP__DelegateSignature_IsValid = OnQuartzCommandEventBP__DelegateSignature_FunctionAddress != IntPtr.Zero && OnQuartzCommandEventBP__DelegateSignature_EventType_IsValid && OnQuartzCommandEventBP__DelegateSignature_Name_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnQuartzCommandEventBP__DelegateSignature", OnQuartzCommandEventBP__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(EQuartzCommandDelegateSubType EventType, FName Name)
	{
		if (!OnQuartzCommandEventBP__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnQuartzCommandEventBP__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnQuartzCommandEventBP__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnQuartzCommandEventBP__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<EQuartzCommandDelegateSubType>.ToNative(IntPtr.Add(intPtr, OnQuartzCommandEventBP__DelegateSignature_EventType_Offset), 0, OnQuartzCommandEventBP__DelegateSignature_EventType_PropertyAddress.Address, EventType);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnQuartzCommandEventBP__DelegateSignature_Name_Offset), 0, OnQuartzCommandEventBP__DelegateSignature_Name_PropertyAddress.Address, Name);
			ProcessDelegate(intPtr);
		}
	}
}
