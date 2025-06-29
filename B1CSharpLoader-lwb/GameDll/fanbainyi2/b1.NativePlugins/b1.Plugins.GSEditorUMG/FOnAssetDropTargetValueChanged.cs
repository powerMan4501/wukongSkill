using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEditorUMG;

[UDelegate]
[UMetaPath("/Script/GSEditorUMG.OnAssetDropTargetValueChanged__DelegateSignature")]
public class FOnAssetDropTargetValueChanged : FMulticastDelegate<FOnAssetDropTargetValueChanged.Signature>
{
	public delegate void Signature();

	private static bool OnAssetDropTargetValueChanged__DelegateSignature_IsValid;

	private static IntPtr OnAssetDropTargetValueChanged__DelegateSignature_FunctionAddress;

	private static int OnAssetDropTargetValueChanged__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnAssetDropTargetValueChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnAssetDropTargetValueChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSEditorUMG.OnAssetDropTargetValueChanged__DelegateSignature");
		OnAssetDropTargetValueChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAssetDropTargetValueChanged__DelegateSignature_FunctionAddress);
		OnAssetDropTargetValueChanged__DelegateSignature_IsValid = OnAssetDropTargetValueChanged__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GSEditorUMG.OnAssetDropTargetValueChanged__DelegateSignature", OnAssetDropTargetValueChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnAssetDropTargetValueChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEditorUMG.OnAssetDropTargetValueChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnAssetDropTargetValueChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAssetDropTargetValueChanged__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
