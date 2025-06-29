using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UDelegate]
[UMetaPath("/Script/Niagara.OnNiagaraSystemFinished__DelegateSignature")]
public class FOnNiagaraSystemFinished : FMulticastDelegate<FOnNiagaraSystemFinished.Signature>
{
	public delegate void Signature(UNiagaraComponent PSystem);

	private static bool OnNiagaraSystemFinished__DelegateSignature_IsValid;

	private static IntPtr OnNiagaraSystemFinished__DelegateSignature_FunctionAddress;

	private static int OnNiagaraSystemFinished__DelegateSignature_ParamsSize;

	private static bool OnNiagaraSystemFinished__DelegateSignature_PSystem_IsValid;

	private static FFieldAddress OnNiagaraSystemFinished__DelegateSignature_PSystem_PropertyAddress;

	private static int OnNiagaraSystemFinished__DelegateSignature_PSystem_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnNiagaraSystemFinished()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnNiagaraSystemFinished__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Niagara.OnNiagaraSystemFinished__DelegateSignature");
		OnNiagaraSystemFinished__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNiagaraSystemFinished__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnNiagaraSystemFinished__DelegateSignature_PSystem_PropertyAddress, OnNiagaraSystemFinished__DelegateSignature_FunctionAddress, "PSystem");
		OnNiagaraSystemFinished__DelegateSignature_PSystem_Offset = NativeReflectionCached.GetPropertyOffset(OnNiagaraSystemFinished__DelegateSignature_FunctionAddress, "PSystem");
		OnNiagaraSystemFinished__DelegateSignature_PSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNiagaraSystemFinished__DelegateSignature_FunctionAddress, "PSystem", Classes.FObjectProperty);
		OnNiagaraSystemFinished__DelegateSignature_IsValid = OnNiagaraSystemFinished__DelegateSignature_FunctionAddress != IntPtr.Zero && OnNiagaraSystemFinished__DelegateSignature_PSystem_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.OnNiagaraSystemFinished__DelegateSignature", OnNiagaraSystemFinished__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UNiagaraComponent PSystem)
	{
		if (!OnNiagaraSystemFinished__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.OnNiagaraSystemFinished__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnNiagaraSystemFinished__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNiagaraSystemFinished__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, OnNiagaraSystemFinished__DelegateSignature_PSystem_Offset), 0, OnNiagaraSystemFinished__DelegateSignature_PSystem_PropertyAddress.Address, PSystem);
			ProcessDelegate(intPtr);
		}
	}
}
