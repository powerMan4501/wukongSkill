using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnWidgetAnimationPlaybackStatusChanged__DelegateSignature")]
public class FOnWidgetAnimationPlaybackStatusChanged : FMulticastDelegate<FOnWidgetAnimationPlaybackStatusChanged.Signature>
{
	public delegate void Signature();

	private static bool OnWidgetAnimationPlaybackStatusChanged__DelegateSignature_IsValid;

	private static IntPtr OnWidgetAnimationPlaybackStatusChanged__DelegateSignature_FunctionAddress;

	private static int OnWidgetAnimationPlaybackStatusChanged__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnWidgetAnimationPlaybackStatusChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnWidgetAnimationPlaybackStatusChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnWidgetAnimationPlaybackStatusChanged__DelegateSignature");
		OnWidgetAnimationPlaybackStatusChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWidgetAnimationPlaybackStatusChanged__DelegateSignature_FunctionAddress);
		OnWidgetAnimationPlaybackStatusChanged__DelegateSignature_IsValid = OnWidgetAnimationPlaybackStatusChanged__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnWidgetAnimationPlaybackStatusChanged__DelegateSignature", OnWidgetAnimationPlaybackStatusChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnWidgetAnimationPlaybackStatusChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnWidgetAnimationPlaybackStatusChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnWidgetAnimationPlaybackStatusChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWidgetAnimationPlaybackStatusChanged__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
