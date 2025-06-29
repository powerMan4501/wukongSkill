using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ConstraintBrokenSignature__DelegateSignature")]
public class FConstraintBrokenSignature : FMulticastDelegate<FConstraintBrokenSignature.Signature>
{
	public delegate void Signature(int ConstraintIndex);

	private static bool ConstraintBrokenSignature__DelegateSignature_IsValid;

	private static IntPtr ConstraintBrokenSignature__DelegateSignature_FunctionAddress;

	private static int ConstraintBrokenSignature__DelegateSignature_ParamsSize;

	private static bool ConstraintBrokenSignature__DelegateSignature_ConstraintIndex_IsValid;

	private static FFieldAddress ConstraintBrokenSignature__DelegateSignature_ConstraintIndex_PropertyAddress;

	private static int ConstraintBrokenSignature__DelegateSignature_ConstraintIndex_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FConstraintBrokenSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ConstraintBrokenSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ConstraintBrokenSignature__DelegateSignature");
		ConstraintBrokenSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ConstraintBrokenSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConstraintBrokenSignature__DelegateSignature_ConstraintIndex_PropertyAddress, ConstraintBrokenSignature__DelegateSignature_FunctionAddress, "ConstraintIndex");
		ConstraintBrokenSignature__DelegateSignature_ConstraintIndex_Offset = NativeReflectionCached.GetPropertyOffset(ConstraintBrokenSignature__DelegateSignature_FunctionAddress, "ConstraintIndex");
		ConstraintBrokenSignature__DelegateSignature_ConstraintIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ConstraintBrokenSignature__DelegateSignature_FunctionAddress, "ConstraintIndex", Classes.FIntProperty);
		ConstraintBrokenSignature__DelegateSignature_IsValid = ConstraintBrokenSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ConstraintBrokenSignature__DelegateSignature_ConstraintIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ConstraintBrokenSignature__DelegateSignature", ConstraintBrokenSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(int ConstraintIndex)
	{
		if (!ConstraintBrokenSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ConstraintBrokenSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ConstraintBrokenSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConstraintBrokenSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConstraintBrokenSignature__DelegateSignature_ConstraintIndex_Offset), 0, ConstraintBrokenSignature__DelegateSignature_ConstraintIndex_PropertyAddress.Address, ConstraintIndex);
			ProcessDelegate(intPtr);
		}
	}
}
