using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScriptingEditor;

[UDelegate]
[UMetaPath("/Script/SequencerScriptingEditor.OnRenderMovieStopped__DelegateSignature")]
public class FOnRenderMovieStopped : FDelegate<FOnRenderMovieStopped.Signature>
{
	public delegate void Signature(bool bSuccess);

	private static bool OnRenderMovieStopped__DelegateSignature_IsValid;

	private static IntPtr OnRenderMovieStopped__DelegateSignature_FunctionAddress;

	private static int OnRenderMovieStopped__DelegateSignature_ParamsSize;

	private static bool OnRenderMovieStopped__DelegateSignature_bSuccess_IsValid;

	private static FFieldAddress OnRenderMovieStopped__DelegateSignature_bSuccess_PropertyAddress;

	private static int OnRenderMovieStopped__DelegateSignature_bSuccess_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnRenderMovieStopped()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnRenderMovieStopped__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/SequencerScriptingEditor.OnRenderMovieStopped__DelegateSignature");
		OnRenderMovieStopped__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRenderMovieStopped__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnRenderMovieStopped__DelegateSignature_bSuccess_PropertyAddress, OnRenderMovieStopped__DelegateSignature_FunctionAddress, "bSuccess");
		OnRenderMovieStopped__DelegateSignature_bSuccess_Offset = NativeReflectionCached.GetPropertyOffset(OnRenderMovieStopped__DelegateSignature_FunctionAddress, "bSuccess");
		OnRenderMovieStopped__DelegateSignature_bSuccess_IsValid = NativeReflectionCached.ValidatePropertyClass(OnRenderMovieStopped__DelegateSignature_FunctionAddress, "bSuccess", Classes.FBoolProperty);
		OnRenderMovieStopped__DelegateSignature_IsValid = OnRenderMovieStopped__DelegateSignature_FunctionAddress != IntPtr.Zero && OnRenderMovieStopped__DelegateSignature_bSuccess_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScriptingEditor.OnRenderMovieStopped__DelegateSignature", OnRenderMovieStopped__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(bool bSuccess)
	{
		if (!OnRenderMovieStopped__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScriptingEditor.OnRenderMovieStopped__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnRenderMovieStopped__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRenderMovieStopped__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnRenderMovieStopped__DelegateSignature_bSuccess_Offset), 0, OnRenderMovieStopped__DelegateSignature_bSuccess_PropertyAddress.Address, bSuccess);
			ProcessDelegate(intPtr);
		}
	}
}
