using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/UnrealExtent.OnGSUserScrolledEvent__DelegateSignature")]
public class FOnGSUserScrolledEvent : FMulticastDelegate<FOnGSUserScrolledEvent.Signature>
{
	public delegate void Signature(float CurrentOffset);

	private static bool OnGSUserScrolledEvent__DelegateSignature_IsValid;

	private static IntPtr OnGSUserScrolledEvent__DelegateSignature_FunctionAddress;

	private static int OnGSUserScrolledEvent__DelegateSignature_ParamsSize;

	private static bool OnGSUserScrolledEvent__DelegateSignature_CurrentOffset_IsValid;

	private static FFieldAddress OnGSUserScrolledEvent__DelegateSignature_CurrentOffset_PropertyAddress;

	private static int OnGSUserScrolledEvent__DelegateSignature_CurrentOffset_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnGSUserScrolledEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnGSUserScrolledEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UnrealExtent.OnGSUserScrolledEvent__DelegateSignature");
		OnGSUserScrolledEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGSUserScrolledEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnGSUserScrolledEvent__DelegateSignature_CurrentOffset_PropertyAddress, OnGSUserScrolledEvent__DelegateSignature_FunctionAddress, "CurrentOffset");
		OnGSUserScrolledEvent__DelegateSignature_CurrentOffset_Offset = NativeReflectionCached.GetPropertyOffset(OnGSUserScrolledEvent__DelegateSignature_FunctionAddress, "CurrentOffset");
		OnGSUserScrolledEvent__DelegateSignature_CurrentOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGSUserScrolledEvent__DelegateSignature_FunctionAddress, "CurrentOffset", Classes.FFloatProperty);
		OnGSUserScrolledEvent__DelegateSignature_IsValid = OnGSUserScrolledEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnGSUserScrolledEvent__DelegateSignature_CurrentOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.OnGSUserScrolledEvent__DelegateSignature", OnGSUserScrolledEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(float CurrentOffset)
	{
		if (!OnGSUserScrolledEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.OnGSUserScrolledEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnGSUserScrolledEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGSUserScrolledEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnGSUserScrolledEvent__DelegateSignature_CurrentOffset_Offset), 0, OnGSUserScrolledEvent__DelegateSignature_CurrentOffset_PropertyAddress.Address, CurrentOffset);
			ProcessDelegate(intPtr);
		}
	}
}
