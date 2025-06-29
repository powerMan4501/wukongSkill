using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnVisibilityChangedEvent__DelegateSignature")]
public class FOnVisibilityChangedEvent : FMulticastDelegate<FOnVisibilityChangedEvent.Signature>
{
	public delegate void Signature(ESlateVisibility InVisibility);

	private static bool OnVisibilityChangedEvent__DelegateSignature_IsValid;

	private static IntPtr OnVisibilityChangedEvent__DelegateSignature_FunctionAddress;

	private static int OnVisibilityChangedEvent__DelegateSignature_ParamsSize;

	private static bool OnVisibilityChangedEvent__DelegateSignature_InVisibility_IsValid;

	private static FFieldAddress OnVisibilityChangedEvent__DelegateSignature_InVisibility_PropertyAddress;

	private static int OnVisibilityChangedEvent__DelegateSignature_InVisibility_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnVisibilityChangedEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnVisibilityChangedEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnVisibilityChangedEvent__DelegateSignature");
		OnVisibilityChangedEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnVisibilityChangedEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnVisibilityChangedEvent__DelegateSignature_InVisibility_PropertyAddress, OnVisibilityChangedEvent__DelegateSignature_FunctionAddress, "InVisibility");
		OnVisibilityChangedEvent__DelegateSignature_InVisibility_Offset = NativeReflectionCached.GetPropertyOffset(OnVisibilityChangedEvent__DelegateSignature_FunctionAddress, "InVisibility");
		OnVisibilityChangedEvent__DelegateSignature_InVisibility_IsValid = NativeReflectionCached.ValidatePropertyClass(OnVisibilityChangedEvent__DelegateSignature_FunctionAddress, "InVisibility", Classes.FEnumProperty);
		OnVisibilityChangedEvent__DelegateSignature_IsValid = OnVisibilityChangedEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnVisibilityChangedEvent__DelegateSignature_InVisibility_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnVisibilityChangedEvent__DelegateSignature", OnVisibilityChangedEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(ESlateVisibility InVisibility)
	{
		if (!OnVisibilityChangedEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnVisibilityChangedEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnVisibilityChangedEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnVisibilityChangedEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<ESlateVisibility>.ToNative(IntPtr.Add(intPtr, OnVisibilityChangedEvent__DelegateSignature_InVisibility_Offset), 0, OnVisibilityChangedEvent__DelegateSignature_InVisibility_PropertyAddress.Address, InVisibility);
			ProcessDelegate(intPtr);
		}
	}
}
