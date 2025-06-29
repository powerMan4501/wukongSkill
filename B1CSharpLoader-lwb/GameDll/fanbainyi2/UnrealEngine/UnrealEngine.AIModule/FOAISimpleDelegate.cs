using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UDelegate]
[UMetaPath("/Script/AIModule.OAISimpleDelegate__DelegateSignature")]
public class FOAISimpleDelegate : FMulticastDelegate<FOAISimpleDelegate.Signature>
{
	public delegate void Signature(EPathFollowingResult MovementResult);

	private static bool OAISimpleDelegate__DelegateSignature_IsValid;

	private static IntPtr OAISimpleDelegate__DelegateSignature_FunctionAddress;

	private static int OAISimpleDelegate__DelegateSignature_ParamsSize;

	private static bool OAISimpleDelegate__DelegateSignature_MovementResult_IsValid;

	private static FFieldAddress OAISimpleDelegate__DelegateSignature_MovementResult_PropertyAddress;

	private static int OAISimpleDelegate__DelegateSignature_MovementResult_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOAISimpleDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OAISimpleDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AIModule.OAISimpleDelegate__DelegateSignature");
		OAISimpleDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OAISimpleDelegate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OAISimpleDelegate__DelegateSignature_MovementResult_PropertyAddress, OAISimpleDelegate__DelegateSignature_FunctionAddress, "MovementResult");
		OAISimpleDelegate__DelegateSignature_MovementResult_Offset = NativeReflectionCached.GetPropertyOffset(OAISimpleDelegate__DelegateSignature_FunctionAddress, "MovementResult");
		OAISimpleDelegate__DelegateSignature_MovementResult_IsValid = NativeReflectionCached.ValidatePropertyClass(OAISimpleDelegate__DelegateSignature_FunctionAddress, "MovementResult", Classes.FByteProperty);
		OAISimpleDelegate__DelegateSignature_IsValid = OAISimpleDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && OAISimpleDelegate__DelegateSignature_MovementResult_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.OAISimpleDelegate__DelegateSignature", OAISimpleDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(EPathFollowingResult MovementResult)
	{
		if (!OAISimpleDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.OAISimpleDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OAISimpleDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OAISimpleDelegate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<EPathFollowingResult>.ToNative(IntPtr.Add(intPtr, OAISimpleDelegate__DelegateSignature_MovementResult_Offset), 0, OAISimpleDelegate__DelegateSignature_MovementResult_PropertyAddress.Address, MovementResult);
			ProcessDelegate(intPtr);
		}
	}
}
