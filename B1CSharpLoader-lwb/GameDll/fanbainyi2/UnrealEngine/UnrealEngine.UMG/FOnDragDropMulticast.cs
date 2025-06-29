using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnDragDropMulticast__DelegateSignature")]
public class FOnDragDropMulticast : FMulticastDelegate<FOnDragDropMulticast.Signature>
{
	public delegate void Signature(UDragDropOperation Operation);

	private static bool OnDragDropMulticast__DelegateSignature_IsValid;

	private static IntPtr OnDragDropMulticast__DelegateSignature_FunctionAddress;

	private static int OnDragDropMulticast__DelegateSignature_ParamsSize;

	private static bool OnDragDropMulticast__DelegateSignature_Operation_IsValid;

	private static FFieldAddress OnDragDropMulticast__DelegateSignature_Operation_PropertyAddress;

	private static int OnDragDropMulticast__DelegateSignature_Operation_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnDragDropMulticast()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnDragDropMulticast__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnDragDropMulticast__DelegateSignature");
		OnDragDropMulticast__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDragDropMulticast__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnDragDropMulticast__DelegateSignature_Operation_PropertyAddress, OnDragDropMulticast__DelegateSignature_FunctionAddress, "Operation");
		OnDragDropMulticast__DelegateSignature_Operation_Offset = NativeReflectionCached.GetPropertyOffset(OnDragDropMulticast__DelegateSignature_FunctionAddress, "Operation");
		OnDragDropMulticast__DelegateSignature_Operation_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDragDropMulticast__DelegateSignature_FunctionAddress, "Operation", Classes.FObjectProperty);
		OnDragDropMulticast__DelegateSignature_IsValid = OnDragDropMulticast__DelegateSignature_FunctionAddress != IntPtr.Zero && OnDragDropMulticast__DelegateSignature_Operation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnDragDropMulticast__DelegateSignature", OnDragDropMulticast__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UDragDropOperation Operation)
	{
		if (!OnDragDropMulticast__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnDragDropMulticast__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnDragDropMulticast__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDragDropMulticast__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UDragDropOperation>.ToNative(IntPtr.Add(intPtr, OnDragDropMulticast__DelegateSignature_Operation_Offset), 0, OnDragDropMulticast__DelegateSignature_Operation_PropertyAddress.Address, Operation);
			ProcessDelegate(intPtr);
		}
	}
}
