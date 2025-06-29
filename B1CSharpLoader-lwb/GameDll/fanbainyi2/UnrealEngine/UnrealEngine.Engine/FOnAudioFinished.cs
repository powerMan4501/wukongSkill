using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnAudioFinished__DelegateSignature")]
public class FOnAudioFinished : FMulticastDelegate<FOnAudioFinished.Signature>
{
	public delegate void Signature();

	private static bool OnAudioFinished__DelegateSignature_IsValid;

	private static IntPtr OnAudioFinished__DelegateSignature_FunctionAddress;

	private static int OnAudioFinished__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnAudioFinished()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnAudioFinished__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnAudioFinished__DelegateSignature");
		OnAudioFinished__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAudioFinished__DelegateSignature_FunctionAddress);
		OnAudioFinished__DelegateSignature_IsValid = OnAudioFinished__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnAudioFinished__DelegateSignature", OnAudioFinished__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnAudioFinished__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnAudioFinished__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnAudioFinished__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAudioFinished__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
