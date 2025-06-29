using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.PlayMontageAnimNotifyDelegate__DelegateSignature")]
public class FPlayMontageAnimNotifyDelegate : FMulticastDelegate<FPlayMontageAnimNotifyDelegate.Signature>
{
	public delegate void Signature(FName NotifyName, FBranchingPointNotifyPayload BranchingPointPayload);

	private static bool PlayMontageAnimNotifyDelegate__DelegateSignature_IsValid;

	private static IntPtr PlayMontageAnimNotifyDelegate__DelegateSignature_FunctionAddress;

	private static int PlayMontageAnimNotifyDelegate__DelegateSignature_ParamsSize;

	private static bool PlayMontageAnimNotifyDelegate__DelegateSignature_NotifyName_IsValid;

	private static FFieldAddress PlayMontageAnimNotifyDelegate__DelegateSignature_NotifyName_PropertyAddress;

	private static int PlayMontageAnimNotifyDelegate__DelegateSignature_NotifyName_Offset;

	private static bool PlayMontageAnimNotifyDelegate__DelegateSignature_BranchingPointPayload_IsValid;

	private static FFieldAddress PlayMontageAnimNotifyDelegate__DelegateSignature_BranchingPointPayload_PropertyAddress;

	private static int PlayMontageAnimNotifyDelegate__DelegateSignature_BranchingPointPayload_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FPlayMontageAnimNotifyDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		PlayMontageAnimNotifyDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.PlayMontageAnimNotifyDelegate__DelegateSignature");
		PlayMontageAnimNotifyDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayMontageAnimNotifyDelegate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayMontageAnimNotifyDelegate__DelegateSignature_NotifyName_PropertyAddress, PlayMontageAnimNotifyDelegate__DelegateSignature_FunctionAddress, "NotifyName");
		PlayMontageAnimNotifyDelegate__DelegateSignature_NotifyName_Offset = NativeReflectionCached.GetPropertyOffset(PlayMontageAnimNotifyDelegate__DelegateSignature_FunctionAddress, "NotifyName");
		PlayMontageAnimNotifyDelegate__DelegateSignature_NotifyName_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayMontageAnimNotifyDelegate__DelegateSignature_FunctionAddress, "NotifyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayMontageAnimNotifyDelegate__DelegateSignature_BranchingPointPayload_PropertyAddress, PlayMontageAnimNotifyDelegate__DelegateSignature_FunctionAddress, "BranchingPointPayload");
		PlayMontageAnimNotifyDelegate__DelegateSignature_BranchingPointPayload_Offset = NativeReflectionCached.GetPropertyOffset(PlayMontageAnimNotifyDelegate__DelegateSignature_FunctionAddress, "BranchingPointPayload");
		PlayMontageAnimNotifyDelegate__DelegateSignature_BranchingPointPayload_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayMontageAnimNotifyDelegate__DelegateSignature_FunctionAddress, "BranchingPointPayload", Classes.FStructProperty);
		PlayMontageAnimNotifyDelegate__DelegateSignature_IsValid = PlayMontageAnimNotifyDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && PlayMontageAnimNotifyDelegate__DelegateSignature_NotifyName_IsValid && PlayMontageAnimNotifyDelegate__DelegateSignature_BranchingPointPayload_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayMontageAnimNotifyDelegate__DelegateSignature", PlayMontageAnimNotifyDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FName NotifyName, FBranchingPointNotifyPayload BranchingPointPayload)
	{
		if (!PlayMontageAnimNotifyDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayMontageAnimNotifyDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(PlayMontageAnimNotifyDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayMontageAnimNotifyDelegate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, PlayMontageAnimNotifyDelegate__DelegateSignature_NotifyName_Offset), 0, PlayMontageAnimNotifyDelegate__DelegateSignature_NotifyName_PropertyAddress.Address, NotifyName);
			NativeReflection.InitializeValue_InContainer(PlayMontageAnimNotifyDelegate__DelegateSignature_BranchingPointPayload_PropertyAddress.Address, intPtr);
			FBranchingPointNotifyPayload.ToNative(IntPtr.Add(intPtr, PlayMontageAnimNotifyDelegate__DelegateSignature_BranchingPointPayload_Offset), 0, PlayMontageAnimNotifyDelegate__DelegateSignature_BranchingPointPayload_PropertyAddress.Address, BranchingPointPayload);
			ProcessDelegate(intPtr);
		}
	}
}
