using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UDelegate]
[UMetaPath("/Script/UnrealEd.OnEditPasteActorsEnd__DelegateSignature")]
public class FOnEditPasteActorsEnd : FMulticastDelegate<FOnEditPasteActorsEnd.Signature>
{
	public delegate void Signature();

	private static bool OnEditPasteActorsEnd__DelegateSignature_IsValid;

	private static IntPtr OnEditPasteActorsEnd__DelegateSignature_FunctionAddress;

	private static int OnEditPasteActorsEnd__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnEditPasteActorsEnd()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnEditPasteActorsEnd__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UnrealEd.OnEditPasteActorsEnd__DelegateSignature");
		OnEditPasteActorsEnd__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEditPasteActorsEnd__DelegateSignature_FunctionAddress);
		OnEditPasteActorsEnd__DelegateSignature_IsValid = OnEditPasteActorsEnd__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.OnEditPasteActorsEnd__DelegateSignature", OnEditPasteActorsEnd__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnEditPasteActorsEnd__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.OnEditPasteActorsEnd__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnEditPasteActorsEnd__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEditPasteActorsEnd__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
