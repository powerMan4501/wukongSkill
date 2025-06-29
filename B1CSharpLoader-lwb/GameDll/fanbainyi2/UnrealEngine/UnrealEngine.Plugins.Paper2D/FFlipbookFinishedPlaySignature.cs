using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UDelegate]
[UMetaPath("/Script/Paper2D.FlipbookFinishedPlaySignature__DelegateSignature")]
public class FFlipbookFinishedPlaySignature : FMulticastDelegate<FFlipbookFinishedPlaySignature.Signature>
{
	public delegate void Signature();

	private static bool FlipbookFinishedPlaySignature__DelegateSignature_IsValid;

	private static IntPtr FlipbookFinishedPlaySignature__DelegateSignature_FunctionAddress;

	private static int FlipbookFinishedPlaySignature__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FFlipbookFinishedPlaySignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		FlipbookFinishedPlaySignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Paper2D.FlipbookFinishedPlaySignature__DelegateSignature");
		FlipbookFinishedPlaySignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(FlipbookFinishedPlaySignature__DelegateSignature_FunctionAddress);
		FlipbookFinishedPlaySignature__DelegateSignature_IsValid = FlipbookFinishedPlaySignature__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.FlipbookFinishedPlaySignature__DelegateSignature", FlipbookFinishedPlaySignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!FlipbookFinishedPlaySignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.FlipbookFinishedPlaySignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(FlipbookFinishedPlaySignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FlipbookFinishedPlaySignature__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
