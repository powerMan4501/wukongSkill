using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnMenuOpenChangedEvent__DelegateSignature")]
public class FOnMenuOpenChangedEvent : FMulticastDelegate<FOnMenuOpenChangedEvent.Signature>
{
	public delegate void Signature(bool bIsOpen);

	private static bool OnMenuOpenChangedEvent__DelegateSignature_IsValid;

	private static IntPtr OnMenuOpenChangedEvent__DelegateSignature_FunctionAddress;

	private static int OnMenuOpenChangedEvent__DelegateSignature_ParamsSize;

	private static bool OnMenuOpenChangedEvent__DelegateSignature_bIsOpen_IsValid;

	private static FFieldAddress OnMenuOpenChangedEvent__DelegateSignature_bIsOpen_PropertyAddress;

	private static int OnMenuOpenChangedEvent__DelegateSignature_bIsOpen_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnMenuOpenChangedEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnMenuOpenChangedEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnMenuOpenChangedEvent__DelegateSignature");
		OnMenuOpenChangedEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMenuOpenChangedEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMenuOpenChangedEvent__DelegateSignature_bIsOpen_PropertyAddress, OnMenuOpenChangedEvent__DelegateSignature_FunctionAddress, "bIsOpen");
		OnMenuOpenChangedEvent__DelegateSignature_bIsOpen_Offset = NativeReflectionCached.GetPropertyOffset(OnMenuOpenChangedEvent__DelegateSignature_FunctionAddress, "bIsOpen");
		OnMenuOpenChangedEvent__DelegateSignature_bIsOpen_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMenuOpenChangedEvent__DelegateSignature_FunctionAddress, "bIsOpen", Classes.FBoolProperty);
		OnMenuOpenChangedEvent__DelegateSignature_IsValid = OnMenuOpenChangedEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnMenuOpenChangedEvent__DelegateSignature_bIsOpen_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnMenuOpenChangedEvent__DelegateSignature", OnMenuOpenChangedEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(bool bIsOpen)
	{
		if (!OnMenuOpenChangedEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnMenuOpenChangedEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnMenuOpenChangedEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMenuOpenChangedEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnMenuOpenChangedEvent__DelegateSignature_bIsOpen_Offset), 0, OnMenuOpenChangedEvent__DelegateSignature_bIsOpen_PropertyAddress.Address, bIsOpen);
			ProcessDelegate(intPtr);
		}
	}
}
