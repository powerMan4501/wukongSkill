using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UDelegate]
[UMetaPath("/Script/UnrealEd.OnEditPasteActorsBegin__DelegateSignature")]
public class FOnEditPasteActorsBegin : FMulticastDelegate<FOnEditPasteActorsBegin.Signature>
{
	public delegate void Signature();

	private static bool OnEditPasteActorsBegin__DelegateSignature_IsValid;

	private static IntPtr OnEditPasteActorsBegin__DelegateSignature_FunctionAddress;

	private static int OnEditPasteActorsBegin__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnEditPasteActorsBegin()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnEditPasteActorsBegin__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UnrealEd.OnEditPasteActorsBegin__DelegateSignature");
		OnEditPasteActorsBegin__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEditPasteActorsBegin__DelegateSignature_FunctionAddress);
		OnEditPasteActorsBegin__DelegateSignature_IsValid = OnEditPasteActorsBegin__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.OnEditPasteActorsBegin__DelegateSignature", OnEditPasteActorsBegin__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnEditPasteActorsBegin__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.OnEditPasteActorsBegin__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnEditPasteActorsBegin__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEditPasteActorsBegin__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
