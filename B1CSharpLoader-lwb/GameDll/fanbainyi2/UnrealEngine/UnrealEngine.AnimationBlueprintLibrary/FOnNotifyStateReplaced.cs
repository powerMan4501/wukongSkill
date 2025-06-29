using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimationBlueprintLibrary;

[UDelegate]
[UMetaPath("/Script/AnimationBlueprintLibrary.OnNotifyStateReplaced__DelegateSignature")]
public class FOnNotifyStateReplaced : FDelegate<FOnNotifyStateReplaced.Signature>
{
	public delegate void Signature(UAnimNotifyState OldNotifyState, UAnimNotifyState NewNotifyState);

	private static bool OnNotifyStateReplaced__DelegateSignature_IsValid;

	private static IntPtr OnNotifyStateReplaced__DelegateSignature_FunctionAddress;

	private static int OnNotifyStateReplaced__DelegateSignature_ParamsSize;

	private static bool OnNotifyStateReplaced__DelegateSignature_OldNotifyState_IsValid;

	private static FFieldAddress OnNotifyStateReplaced__DelegateSignature_OldNotifyState_PropertyAddress;

	private static int OnNotifyStateReplaced__DelegateSignature_OldNotifyState_Offset;

	private static bool OnNotifyStateReplaced__DelegateSignature_NewNotifyState_IsValid;

	private static FFieldAddress OnNotifyStateReplaced__DelegateSignature_NewNotifyState_PropertyAddress;

	private static int OnNotifyStateReplaced__DelegateSignature_NewNotifyState_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnNotifyStateReplaced()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnNotifyStateReplaced__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AnimationBlueprintLibrary.OnNotifyStateReplaced__DelegateSignature");
		OnNotifyStateReplaced__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNotifyStateReplaced__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnNotifyStateReplaced__DelegateSignature_OldNotifyState_PropertyAddress, OnNotifyStateReplaced__DelegateSignature_FunctionAddress, "OldNotifyState");
		OnNotifyStateReplaced__DelegateSignature_OldNotifyState_Offset = NativeReflectionCached.GetPropertyOffset(OnNotifyStateReplaced__DelegateSignature_FunctionAddress, "OldNotifyState");
		OnNotifyStateReplaced__DelegateSignature_OldNotifyState_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNotifyStateReplaced__DelegateSignature_FunctionAddress, "OldNotifyState", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnNotifyStateReplaced__DelegateSignature_NewNotifyState_PropertyAddress, OnNotifyStateReplaced__DelegateSignature_FunctionAddress, "NewNotifyState");
		OnNotifyStateReplaced__DelegateSignature_NewNotifyState_Offset = NativeReflectionCached.GetPropertyOffset(OnNotifyStateReplaced__DelegateSignature_FunctionAddress, "NewNotifyState");
		OnNotifyStateReplaced__DelegateSignature_NewNotifyState_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNotifyStateReplaced__DelegateSignature_FunctionAddress, "NewNotifyState", Classes.FObjectProperty);
		OnNotifyStateReplaced__DelegateSignature_IsValid = OnNotifyStateReplaced__DelegateSignature_FunctionAddress != IntPtr.Zero && OnNotifyStateReplaced__DelegateSignature_OldNotifyState_IsValid && OnNotifyStateReplaced__DelegateSignature_NewNotifyState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.OnNotifyStateReplaced__DelegateSignature", OnNotifyStateReplaced__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UAnimNotifyState OldNotifyState, UAnimNotifyState NewNotifyState)
	{
		if (!OnNotifyStateReplaced__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.OnNotifyStateReplaced__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnNotifyStateReplaced__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNotifyStateReplaced__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UAnimNotifyState>.ToNative(IntPtr.Add(intPtr, OnNotifyStateReplaced__DelegateSignature_OldNotifyState_Offset), 0, OnNotifyStateReplaced__DelegateSignature_OldNotifyState_PropertyAddress.Address, OldNotifyState);
			UObjectMarshaler<UAnimNotifyState>.ToNative(IntPtr.Add(intPtr, OnNotifyStateReplaced__DelegateSignature_NewNotifyState_Offset), 0, OnNotifyStateReplaced__DelegateSignature_NewNotifyState_PropertyAddress.Address, NewNotifyState);
			ProcessDelegate(intPtr);
		}
	}
}
