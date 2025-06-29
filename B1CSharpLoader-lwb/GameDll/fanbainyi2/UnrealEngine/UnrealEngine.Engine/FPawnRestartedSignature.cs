using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.PawnRestartedSignature__DelegateSignature")]
public class FPawnRestartedSignature : FMulticastDelegate<FPawnRestartedSignature.Signature>
{
	public delegate void Signature(APawn Pawn);

	private static bool PawnRestartedSignature__DelegateSignature_IsValid;

	private static IntPtr PawnRestartedSignature__DelegateSignature_FunctionAddress;

	private static int PawnRestartedSignature__DelegateSignature_ParamsSize;

	private static bool PawnRestartedSignature__DelegateSignature_Pawn_IsValid;

	private static FFieldAddress PawnRestartedSignature__DelegateSignature_Pawn_PropertyAddress;

	private static int PawnRestartedSignature__DelegateSignature_Pawn_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FPawnRestartedSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		PawnRestartedSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.PawnRestartedSignature__DelegateSignature");
		PawnRestartedSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(PawnRestartedSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PawnRestartedSignature__DelegateSignature_Pawn_PropertyAddress, PawnRestartedSignature__DelegateSignature_FunctionAddress, "Pawn");
		PawnRestartedSignature__DelegateSignature_Pawn_Offset = NativeReflectionCached.GetPropertyOffset(PawnRestartedSignature__DelegateSignature_FunctionAddress, "Pawn");
		PawnRestartedSignature__DelegateSignature_Pawn_IsValid = NativeReflectionCached.ValidatePropertyClass(PawnRestartedSignature__DelegateSignature_FunctionAddress, "Pawn", Classes.FObjectProperty);
		PawnRestartedSignature__DelegateSignature_IsValid = PawnRestartedSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && PawnRestartedSignature__DelegateSignature_Pawn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PawnRestartedSignature__DelegateSignature", PawnRestartedSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(APawn Pawn)
	{
		if (!PawnRestartedSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PawnRestartedSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(PawnRestartedSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PawnRestartedSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, PawnRestartedSignature__DelegateSignature_Pawn_Offset), 0, PawnRestartedSignature__DelegateSignature_Pawn_PropertyAddress.Address, Pawn);
			ProcessDelegate(intPtr);
		}
	}
}
