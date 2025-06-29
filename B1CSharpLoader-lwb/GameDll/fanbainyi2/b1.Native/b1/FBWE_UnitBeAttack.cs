using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/b1.BWE_UnitBeAttack__DelegateSignature")]
public class FBWE_UnitBeAttack : FMulticastDelegate<FBWE_UnitBeAttack.Signature>
{
	public delegate void Signature(int ResID);

	private static bool BWE_UnitBeAttack__DelegateSignature_IsValid;

	private static IntPtr BWE_UnitBeAttack__DelegateSignature_FunctionAddress;

	private static int BWE_UnitBeAttack__DelegateSignature_ParamsSize;

	private static bool BWE_UnitBeAttack__DelegateSignature_ResID_IsValid;

	private static FFieldAddress BWE_UnitBeAttack__DelegateSignature_ResID_PropertyAddress;

	private static int BWE_UnitBeAttack__DelegateSignature_ResID_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FBWE_UnitBeAttack()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		BWE_UnitBeAttack__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/b1.BWE_UnitBeAttack__DelegateSignature");
		BWE_UnitBeAttack__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(BWE_UnitBeAttack__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BWE_UnitBeAttack__DelegateSignature_ResID_PropertyAddress, BWE_UnitBeAttack__DelegateSignature_FunctionAddress, "ResID");
		BWE_UnitBeAttack__DelegateSignature_ResID_Offset = NativeReflectionCached.GetPropertyOffset(BWE_UnitBeAttack__DelegateSignature_FunctionAddress, "ResID");
		BWE_UnitBeAttack__DelegateSignature_ResID_IsValid = NativeReflectionCached.ValidatePropertyClass(BWE_UnitBeAttack__DelegateSignature_FunctionAddress, "ResID", Classes.FIntProperty);
		BWE_UnitBeAttack__DelegateSignature_IsValid = BWE_UnitBeAttack__DelegateSignature_FunctionAddress != IntPtr.Zero && BWE_UnitBeAttack__DelegateSignature_ResID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BWE_UnitBeAttack__DelegateSignature", BWE_UnitBeAttack__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(int ResID)
	{
		if (!BWE_UnitBeAttack__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BWE_UnitBeAttack__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(BWE_UnitBeAttack__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BWE_UnitBeAttack__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BWE_UnitBeAttack__DelegateSignature_ResID_Offset), 0, BWE_UnitBeAttack__DelegateSignature_ResID_PropertyAddress.Address, ResID);
			ProcessDelegate(intPtr);
		}
	}
}
