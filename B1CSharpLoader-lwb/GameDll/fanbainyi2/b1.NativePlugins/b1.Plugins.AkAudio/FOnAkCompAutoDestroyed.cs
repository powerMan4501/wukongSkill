using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UDelegate]
[UMetaPath("/Script/AkAudio.OnAkCompAutoDestroyed__DelegateSignature")]
public class FOnAkCompAutoDestroyed : FMulticastDelegate<FOnAkCompAutoDestroyed.Signature>
{
	public delegate void Signature(UAkComponent AkComp);

	private static bool OnAkCompAutoDestroyed__DelegateSignature_IsValid;

	private static IntPtr OnAkCompAutoDestroyed__DelegateSignature_FunctionAddress;

	private static int OnAkCompAutoDestroyed__DelegateSignature_ParamsSize;

	private static bool OnAkCompAutoDestroyed__DelegateSignature_AkComp_IsValid;

	private static FFieldAddress OnAkCompAutoDestroyed__DelegateSignature_AkComp_PropertyAddress;

	private static int OnAkCompAutoDestroyed__DelegateSignature_AkComp_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnAkCompAutoDestroyed()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnAkCompAutoDestroyed__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AkAudio.OnAkCompAutoDestroyed__DelegateSignature");
		OnAkCompAutoDestroyed__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAkCompAutoDestroyed__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnAkCompAutoDestroyed__DelegateSignature_AkComp_PropertyAddress, OnAkCompAutoDestroyed__DelegateSignature_FunctionAddress, "AkComp");
		OnAkCompAutoDestroyed__DelegateSignature_AkComp_Offset = NativeReflectionCached.GetPropertyOffset(OnAkCompAutoDestroyed__DelegateSignature_FunctionAddress, "AkComp");
		OnAkCompAutoDestroyed__DelegateSignature_AkComp_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAkCompAutoDestroyed__DelegateSignature_FunctionAddress, "AkComp", Classes.FObjectProperty);
		OnAkCompAutoDestroyed__DelegateSignature_IsValid = OnAkCompAutoDestroyed__DelegateSignature_FunctionAddress != IntPtr.Zero && OnAkCompAutoDestroyed__DelegateSignature_AkComp_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.OnAkCompAutoDestroyed__DelegateSignature", OnAkCompAutoDestroyed__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UAkComponent AkComp)
	{
		if (!OnAkCompAutoDestroyed__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.OnAkCompAutoDestroyed__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnAkCompAutoDestroyed__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAkCompAutoDestroyed__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UAkComponent>.ToNative(IntPtr.Add(intPtr, OnAkCompAutoDestroyed__DelegateSignature_AkComp_Offset), 0, OnAkCompAutoDestroyed__DelegateSignature_AkComp_PropertyAddress.Address, AkComp);
			ProcessDelegate(intPtr);
		}
	}
}
