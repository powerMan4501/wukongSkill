using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Blutility;

[UDelegate]
[UMetaPath("/Script/Blutility.OnEditorUtilityPIEEvent__DelegateSignature")]
public class FOnEditorUtilityPIEEvent : FMulticastDelegate<FOnEditorUtilityPIEEvent.Signature>
{
	public delegate void Signature(bool bIsSimulating);

	private static bool OnEditorUtilityPIEEvent__DelegateSignature_IsValid;

	private static IntPtr OnEditorUtilityPIEEvent__DelegateSignature_FunctionAddress;

	private static int OnEditorUtilityPIEEvent__DelegateSignature_ParamsSize;

	private static bool OnEditorUtilityPIEEvent__DelegateSignature_bIsSimulating_IsValid;

	private static FFieldAddress OnEditorUtilityPIEEvent__DelegateSignature_bIsSimulating_PropertyAddress;

	private static int OnEditorUtilityPIEEvent__DelegateSignature_bIsSimulating_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnEditorUtilityPIEEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnEditorUtilityPIEEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Blutility.OnEditorUtilityPIEEvent__DelegateSignature");
		OnEditorUtilityPIEEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEditorUtilityPIEEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnEditorUtilityPIEEvent__DelegateSignature_bIsSimulating_PropertyAddress, OnEditorUtilityPIEEvent__DelegateSignature_FunctionAddress, "bIsSimulating");
		OnEditorUtilityPIEEvent__DelegateSignature_bIsSimulating_Offset = NativeReflectionCached.GetPropertyOffset(OnEditorUtilityPIEEvent__DelegateSignature_FunctionAddress, "bIsSimulating");
		OnEditorUtilityPIEEvent__DelegateSignature_bIsSimulating_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEditorUtilityPIEEvent__DelegateSignature_FunctionAddress, "bIsSimulating", Classes.FBoolProperty);
		OnEditorUtilityPIEEvent__DelegateSignature_IsValid = OnEditorUtilityPIEEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnEditorUtilityPIEEvent__DelegateSignature_bIsSimulating_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.OnEditorUtilityPIEEvent__DelegateSignature", OnEditorUtilityPIEEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(bool bIsSimulating)
	{
		if (!OnEditorUtilityPIEEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.OnEditorUtilityPIEEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnEditorUtilityPIEEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEditorUtilityPIEEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnEditorUtilityPIEEvent__DelegateSignature_bIsSimulating_Offset), 0, OnEditorUtilityPIEEvent__DelegateSignature_bIsSimulating_PropertyAddress.Address, bIsSimulating);
			ProcessDelegate(intPtr);
		}
	}
}
