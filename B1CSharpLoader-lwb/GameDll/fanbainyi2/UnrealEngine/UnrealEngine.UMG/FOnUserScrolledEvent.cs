using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnUserScrolledEvent__DelegateSignature")]
public class FOnUserScrolledEvent : FMulticastDelegate<FOnUserScrolledEvent.Signature>
{
	public delegate void Signature(float CurrentOffset);

	private static bool OnUserScrolledEvent__DelegateSignature_IsValid;

	private static IntPtr OnUserScrolledEvent__DelegateSignature_FunctionAddress;

	private static int OnUserScrolledEvent__DelegateSignature_ParamsSize;

	private static bool OnUserScrolledEvent__DelegateSignature_CurrentOffset_IsValid;

	private static FFieldAddress OnUserScrolledEvent__DelegateSignature_CurrentOffset_PropertyAddress;

	private static int OnUserScrolledEvent__DelegateSignature_CurrentOffset_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnUserScrolledEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnUserScrolledEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnUserScrolledEvent__DelegateSignature");
		OnUserScrolledEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnUserScrolledEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnUserScrolledEvent__DelegateSignature_CurrentOffset_PropertyAddress, OnUserScrolledEvent__DelegateSignature_FunctionAddress, "CurrentOffset");
		OnUserScrolledEvent__DelegateSignature_CurrentOffset_Offset = NativeReflectionCached.GetPropertyOffset(OnUserScrolledEvent__DelegateSignature_FunctionAddress, "CurrentOffset");
		OnUserScrolledEvent__DelegateSignature_CurrentOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(OnUserScrolledEvent__DelegateSignature_FunctionAddress, "CurrentOffset", Classes.FFloatProperty);
		OnUserScrolledEvent__DelegateSignature_IsValid = OnUserScrolledEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnUserScrolledEvent__DelegateSignature_CurrentOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnUserScrolledEvent__DelegateSignature", OnUserScrolledEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(float CurrentOffset)
	{
		if (!OnUserScrolledEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnUserScrolledEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnUserScrolledEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnUserScrolledEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnUserScrolledEvent__DelegateSignature_CurrentOffset_Offset), 0, OnUserScrolledEvent__DelegateSignature_CurrentOffset_PropertyAddress.Address, CurrentOffset);
			ProcessDelegate(intPtr);
		}
	}
}
