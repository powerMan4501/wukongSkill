using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Blutility;

[UDelegate]
[UMetaPath("/Script/Blutility.AsyncEditorWaitForGameWorldEvent__DelegateSignature")]
public class FAsyncEditorWaitForGameWorldEvent : FMulticastDelegate<FAsyncEditorWaitForGameWorldEvent.Signature>
{
	public delegate void Signature(UWorld World);

	private static bool AsyncEditorWaitForGameWorldEvent__DelegateSignature_IsValid;

	private static IntPtr AsyncEditorWaitForGameWorldEvent__DelegateSignature_FunctionAddress;

	private static int AsyncEditorWaitForGameWorldEvent__DelegateSignature_ParamsSize;

	private static bool AsyncEditorWaitForGameWorldEvent__DelegateSignature_World_IsValid;

	private static FFieldAddress AsyncEditorWaitForGameWorldEvent__DelegateSignature_World_PropertyAddress;

	private static int AsyncEditorWaitForGameWorldEvent__DelegateSignature_World_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FAsyncEditorWaitForGameWorldEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		AsyncEditorWaitForGameWorldEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Blutility.AsyncEditorWaitForGameWorldEvent__DelegateSignature");
		AsyncEditorWaitForGameWorldEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(AsyncEditorWaitForGameWorldEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsyncEditorWaitForGameWorldEvent__DelegateSignature_World_PropertyAddress, AsyncEditorWaitForGameWorldEvent__DelegateSignature_FunctionAddress, "World");
		AsyncEditorWaitForGameWorldEvent__DelegateSignature_World_Offset = NativeReflectionCached.GetPropertyOffset(AsyncEditorWaitForGameWorldEvent__DelegateSignature_FunctionAddress, "World");
		AsyncEditorWaitForGameWorldEvent__DelegateSignature_World_IsValid = NativeReflectionCached.ValidatePropertyClass(AsyncEditorWaitForGameWorldEvent__DelegateSignature_FunctionAddress, "World", Classes.FObjectProperty);
		AsyncEditorWaitForGameWorldEvent__DelegateSignature_IsValid = AsyncEditorWaitForGameWorldEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && AsyncEditorWaitForGameWorldEvent__DelegateSignature_World_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.AsyncEditorWaitForGameWorldEvent__DelegateSignature", AsyncEditorWaitForGameWorldEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UWorld World)
	{
		if (!AsyncEditorWaitForGameWorldEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.AsyncEditorWaitForGameWorldEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(AsyncEditorWaitForGameWorldEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsyncEditorWaitForGameWorldEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, AsyncEditorWaitForGameWorldEvent__DelegateSignature_World_Offset), 0, AsyncEditorWaitForGameWorldEvent__DelegateSignature_World_PropertyAddress.Address, World);
			ProcessDelegate(intPtr);
		}
	}
}
