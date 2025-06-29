using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimationBlueprintLibrary;

[UDelegate]
[UMetaPath("/Script/AnimationBlueprintLibrary.OnNotifyReplaced__DelegateSignature")]
public class FOnNotifyReplaced : FDelegate<FOnNotifyReplaced.Signature>
{
	public delegate void Signature(UAnimNotify OldNotify, UAnimNotify NewNotify);

	private static bool OnNotifyReplaced__DelegateSignature_IsValid;

	private static IntPtr OnNotifyReplaced__DelegateSignature_FunctionAddress;

	private static int OnNotifyReplaced__DelegateSignature_ParamsSize;

	private static bool OnNotifyReplaced__DelegateSignature_OldNotify_IsValid;

	private static FFieldAddress OnNotifyReplaced__DelegateSignature_OldNotify_PropertyAddress;

	private static int OnNotifyReplaced__DelegateSignature_OldNotify_Offset;

	private static bool OnNotifyReplaced__DelegateSignature_NewNotify_IsValid;

	private static FFieldAddress OnNotifyReplaced__DelegateSignature_NewNotify_PropertyAddress;

	private static int OnNotifyReplaced__DelegateSignature_NewNotify_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnNotifyReplaced()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnNotifyReplaced__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AnimationBlueprintLibrary.OnNotifyReplaced__DelegateSignature");
		OnNotifyReplaced__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNotifyReplaced__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnNotifyReplaced__DelegateSignature_OldNotify_PropertyAddress, OnNotifyReplaced__DelegateSignature_FunctionAddress, "OldNotify");
		OnNotifyReplaced__DelegateSignature_OldNotify_Offset = NativeReflectionCached.GetPropertyOffset(OnNotifyReplaced__DelegateSignature_FunctionAddress, "OldNotify");
		OnNotifyReplaced__DelegateSignature_OldNotify_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNotifyReplaced__DelegateSignature_FunctionAddress, "OldNotify", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnNotifyReplaced__DelegateSignature_NewNotify_PropertyAddress, OnNotifyReplaced__DelegateSignature_FunctionAddress, "NewNotify");
		OnNotifyReplaced__DelegateSignature_NewNotify_Offset = NativeReflectionCached.GetPropertyOffset(OnNotifyReplaced__DelegateSignature_FunctionAddress, "NewNotify");
		OnNotifyReplaced__DelegateSignature_NewNotify_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNotifyReplaced__DelegateSignature_FunctionAddress, "NewNotify", Classes.FObjectProperty);
		OnNotifyReplaced__DelegateSignature_IsValid = OnNotifyReplaced__DelegateSignature_FunctionAddress != IntPtr.Zero && OnNotifyReplaced__DelegateSignature_OldNotify_IsValid && OnNotifyReplaced__DelegateSignature_NewNotify_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.OnNotifyReplaced__DelegateSignature", OnNotifyReplaced__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UAnimNotify OldNotify, UAnimNotify NewNotify)
	{
		if (!OnNotifyReplaced__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.OnNotifyReplaced__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnNotifyReplaced__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNotifyReplaced__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UAnimNotify>.ToNative(IntPtr.Add(intPtr, OnNotifyReplaced__DelegateSignature_OldNotify_Offset), 0, OnNotifyReplaced__DelegateSignature_OldNotify_PropertyAddress.Address, OldNotify);
			UObjectMarshaler<UAnimNotify>.ToNative(IntPtr.Add(intPtr, OnNotifyReplaced__DelegateSignature_NewNotify_Offset), 0, OnNotifyReplaced__DelegateSignature_NewNotify_PropertyAddress.Address, NewNotify);
			ProcessDelegate(intPtr);
		}
	}
}
