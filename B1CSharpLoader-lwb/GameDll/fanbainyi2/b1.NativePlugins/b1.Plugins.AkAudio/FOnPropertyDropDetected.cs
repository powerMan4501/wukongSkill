using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UDelegate]
[UMetaPath("/Script/AkAudio.OnPropertyDropDetected__DelegateSignature")]
public class FOnPropertyDropDetected : FMulticastDelegate<FOnPropertyDropDetected.Signature>
{
	public delegate void Signature(string PropertyDropped);

	private static bool OnPropertyDropDetected__DelegateSignature_IsValid;

	private static IntPtr OnPropertyDropDetected__DelegateSignature_FunctionAddress;

	private static int OnPropertyDropDetected__DelegateSignature_ParamsSize;

	private static bool OnPropertyDropDetected__DelegateSignature_PropertyDropped_IsValid;

	private static FFieldAddress OnPropertyDropDetected__DelegateSignature_PropertyDropped_PropertyAddress;

	private static int OnPropertyDropDetected__DelegateSignature_PropertyDropped_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnPropertyDropDetected()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnPropertyDropDetected__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AkAudio.OnPropertyDropDetected__DelegateSignature");
		OnPropertyDropDetected__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPropertyDropDetected__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPropertyDropDetected__DelegateSignature_PropertyDropped_PropertyAddress, OnPropertyDropDetected__DelegateSignature_FunctionAddress, "PropertyDropped");
		OnPropertyDropDetected__DelegateSignature_PropertyDropped_Offset = NativeReflectionCached.GetPropertyOffset(OnPropertyDropDetected__DelegateSignature_FunctionAddress, "PropertyDropped");
		OnPropertyDropDetected__DelegateSignature_PropertyDropped_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPropertyDropDetected__DelegateSignature_FunctionAddress, "PropertyDropped", Classes.FStrProperty);
		OnPropertyDropDetected__DelegateSignature_IsValid = OnPropertyDropDetected__DelegateSignature_FunctionAddress != IntPtr.Zero && OnPropertyDropDetected__DelegateSignature_PropertyDropped_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.OnPropertyDropDetected__DelegateSignature", OnPropertyDropDetected__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(string PropertyDropped)
	{
		if (!OnPropertyDropDetected__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.OnPropertyDropDetected__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnPropertyDropDetected__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPropertyDropDetected__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnPropertyDropDetected__DelegateSignature_PropertyDropped_Offset), 0, OnPropertyDropDetected__DelegateSignature_PropertyDropped_PropertyAddress.Address, PropertyDropped);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnPropertyDropDetected__DelegateSignature_PropertyDropped_PropertyAddress.Address, intPtr);
		}
	}
}
