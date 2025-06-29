using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/b1.BUE_BP_UnitDie__DelegateSignature")]
public class FBUE_BP_UnitDie : FMulticastDelegate<FBUE_BP_UnitDie.Signature>
{
	public delegate void Signature(AActor Attacker);

	private static bool BUE_BP_UnitDie__DelegateSignature_IsValid;

	private static IntPtr BUE_BP_UnitDie__DelegateSignature_FunctionAddress;

	private static int BUE_BP_UnitDie__DelegateSignature_ParamsSize;

	private static bool BUE_BP_UnitDie__DelegateSignature_Attacker_IsValid;

	private static FFieldAddress BUE_BP_UnitDie__DelegateSignature_Attacker_PropertyAddress;

	private static int BUE_BP_UnitDie__DelegateSignature_Attacker_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FBUE_BP_UnitDie()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		BUE_BP_UnitDie__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/b1.BUE_BP_UnitDie__DelegateSignature");
		BUE_BP_UnitDie__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(BUE_BP_UnitDie__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BUE_BP_UnitDie__DelegateSignature_Attacker_PropertyAddress, BUE_BP_UnitDie__DelegateSignature_FunctionAddress, "Attacker");
		BUE_BP_UnitDie__DelegateSignature_Attacker_Offset = NativeReflectionCached.GetPropertyOffset(BUE_BP_UnitDie__DelegateSignature_FunctionAddress, "Attacker");
		BUE_BP_UnitDie__DelegateSignature_Attacker_IsValid = NativeReflectionCached.ValidatePropertyClass(BUE_BP_UnitDie__DelegateSignature_FunctionAddress, "Attacker", Classes.FObjectProperty);
		BUE_BP_UnitDie__DelegateSignature_IsValid = BUE_BP_UnitDie__DelegateSignature_FunctionAddress != IntPtr.Zero && BUE_BP_UnitDie__DelegateSignature_Attacker_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUE_BP_UnitDie__DelegateSignature", BUE_BP_UnitDie__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(AActor Attacker)
	{
		if (!BUE_BP_UnitDie__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUE_BP_UnitDie__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(BUE_BP_UnitDie__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BUE_BP_UnitDie__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BUE_BP_UnitDie__DelegateSignature_Attacker_Offset), 0, BUE_BP_UnitDie__DelegateSignature_Attacker_PropertyAddress.Address, Attacker);
			ProcessDelegate(intPtr);
		}
	}
}
