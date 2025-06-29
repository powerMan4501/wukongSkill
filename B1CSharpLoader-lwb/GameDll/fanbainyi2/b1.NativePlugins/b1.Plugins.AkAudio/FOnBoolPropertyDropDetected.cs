using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UDelegate]
[UMetaPath("/Script/AkAudio.OnBoolPropertyDropDetected__DelegateSignature")]
public class FOnBoolPropertyDropDetected : FMulticastDelegate<FOnBoolPropertyDropDetected.Signature>
{
	public delegate void Signature(string PropertyDropped);

	private static bool OnBoolPropertyDropDetected__DelegateSignature_IsValid;

	private static IntPtr OnBoolPropertyDropDetected__DelegateSignature_FunctionAddress;

	private static int OnBoolPropertyDropDetected__DelegateSignature_ParamsSize;

	private static bool OnBoolPropertyDropDetected__DelegateSignature_PropertyDropped_IsValid;

	private static FFieldAddress OnBoolPropertyDropDetected__DelegateSignature_PropertyDropped_PropertyAddress;

	private static int OnBoolPropertyDropDetected__DelegateSignature_PropertyDropped_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnBoolPropertyDropDetected()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnBoolPropertyDropDetected__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AkAudio.OnBoolPropertyDropDetected__DelegateSignature");
		OnBoolPropertyDropDetected__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnBoolPropertyDropDetected__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnBoolPropertyDropDetected__DelegateSignature_PropertyDropped_PropertyAddress, OnBoolPropertyDropDetected__DelegateSignature_FunctionAddress, "PropertyDropped");
		OnBoolPropertyDropDetected__DelegateSignature_PropertyDropped_Offset = NativeReflectionCached.GetPropertyOffset(OnBoolPropertyDropDetected__DelegateSignature_FunctionAddress, "PropertyDropped");
		OnBoolPropertyDropDetected__DelegateSignature_PropertyDropped_IsValid = NativeReflectionCached.ValidatePropertyClass(OnBoolPropertyDropDetected__DelegateSignature_FunctionAddress, "PropertyDropped", Classes.FStrProperty);
		OnBoolPropertyDropDetected__DelegateSignature_IsValid = OnBoolPropertyDropDetected__DelegateSignature_FunctionAddress != IntPtr.Zero && OnBoolPropertyDropDetected__DelegateSignature_PropertyDropped_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.OnBoolPropertyDropDetected__DelegateSignature", OnBoolPropertyDropDetected__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(string PropertyDropped)
	{
		if (!OnBoolPropertyDropDetected__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.OnBoolPropertyDropDetected__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnBoolPropertyDropDetected__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnBoolPropertyDropDetected__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnBoolPropertyDropDetected__DelegateSignature_PropertyDropped_Offset), 0, OnBoolPropertyDropDetected__DelegateSignature_PropertyDropped_PropertyAddress.Address, PropertyDropped);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnBoolPropertyDropDetected__DelegateSignature_PropertyDropped_PropertyAddress.Address, intPtr);
		}
	}
}
