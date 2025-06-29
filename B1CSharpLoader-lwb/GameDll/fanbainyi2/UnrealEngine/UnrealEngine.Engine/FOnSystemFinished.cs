using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnSystemFinished__DelegateSignature")]
public class FOnSystemFinished : FMulticastDelegate<FOnSystemFinished.Signature>
{
	public delegate void Signature(UParticleSystemComponent PSystem);

	private static bool OnSystemFinished__DelegateSignature_IsValid;

	private static IntPtr OnSystemFinished__DelegateSignature_FunctionAddress;

	private static int OnSystemFinished__DelegateSignature_ParamsSize;

	private static bool OnSystemFinished__DelegateSignature_PSystem_IsValid;

	private static FFieldAddress OnSystemFinished__DelegateSignature_PSystem_PropertyAddress;

	private static int OnSystemFinished__DelegateSignature_PSystem_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnSystemFinished()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnSystemFinished__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnSystemFinished__DelegateSignature");
		OnSystemFinished__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSystemFinished__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnSystemFinished__DelegateSignature_PSystem_PropertyAddress, OnSystemFinished__DelegateSignature_FunctionAddress, "PSystem");
		OnSystemFinished__DelegateSignature_PSystem_Offset = NativeReflectionCached.GetPropertyOffset(OnSystemFinished__DelegateSignature_FunctionAddress, "PSystem");
		OnSystemFinished__DelegateSignature_PSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSystemFinished__DelegateSignature_FunctionAddress, "PSystem", Classes.FObjectProperty);
		OnSystemFinished__DelegateSignature_IsValid = OnSystemFinished__DelegateSignature_FunctionAddress != IntPtr.Zero && OnSystemFinished__DelegateSignature_PSystem_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnSystemFinished__DelegateSignature", OnSystemFinished__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UParticleSystemComponent PSystem)
	{
		if (!OnSystemFinished__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnSystemFinished__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnSystemFinished__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSystemFinished__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UParticleSystemComponent>.ToNative(IntPtr.Add(intPtr, OnSystemFinished__DelegateSignature_PSystem_Offset), 0, OnSystemFinished__DelegateSignature_PSystem_PropertyAddress.Address, PSystem);
			ProcessDelegate(intPtr);
		}
	}
}
