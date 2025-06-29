using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnAsyncHandleSaveGame__DelegateSignature")]
public class FOnAsyncHandleSaveGame : FMulticastDelegate<FOnAsyncHandleSaveGame.Signature>
{
	public delegate void Signature(USaveGame SaveGame, bool bSuccess);

	private static bool OnAsyncHandleSaveGame__DelegateSignature_IsValid;

	private static IntPtr OnAsyncHandleSaveGame__DelegateSignature_FunctionAddress;

	private static int OnAsyncHandleSaveGame__DelegateSignature_ParamsSize;

	private static bool OnAsyncHandleSaveGame__DelegateSignature_SaveGame_IsValid;

	private static FFieldAddress OnAsyncHandleSaveGame__DelegateSignature_SaveGame_PropertyAddress;

	private static int OnAsyncHandleSaveGame__DelegateSignature_SaveGame_Offset;

	private static bool OnAsyncHandleSaveGame__DelegateSignature_bSuccess_IsValid;

	private static FFieldAddress OnAsyncHandleSaveGame__DelegateSignature_bSuccess_PropertyAddress;

	private static int OnAsyncHandleSaveGame__DelegateSignature_bSuccess_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnAsyncHandleSaveGame()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnAsyncHandleSaveGame__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnAsyncHandleSaveGame__DelegateSignature");
		OnAsyncHandleSaveGame__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAsyncHandleSaveGame__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnAsyncHandleSaveGame__DelegateSignature_SaveGame_PropertyAddress, OnAsyncHandleSaveGame__DelegateSignature_FunctionAddress, "SaveGame");
		OnAsyncHandleSaveGame__DelegateSignature_SaveGame_Offset = NativeReflectionCached.GetPropertyOffset(OnAsyncHandleSaveGame__DelegateSignature_FunctionAddress, "SaveGame");
		OnAsyncHandleSaveGame__DelegateSignature_SaveGame_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAsyncHandleSaveGame__DelegateSignature_FunctionAddress, "SaveGame", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnAsyncHandleSaveGame__DelegateSignature_bSuccess_PropertyAddress, OnAsyncHandleSaveGame__DelegateSignature_FunctionAddress, "bSuccess");
		OnAsyncHandleSaveGame__DelegateSignature_bSuccess_Offset = NativeReflectionCached.GetPropertyOffset(OnAsyncHandleSaveGame__DelegateSignature_FunctionAddress, "bSuccess");
		OnAsyncHandleSaveGame__DelegateSignature_bSuccess_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAsyncHandleSaveGame__DelegateSignature_FunctionAddress, "bSuccess", Classes.FBoolProperty);
		OnAsyncHandleSaveGame__DelegateSignature_IsValid = OnAsyncHandleSaveGame__DelegateSignature_FunctionAddress != IntPtr.Zero && OnAsyncHandleSaveGame__DelegateSignature_SaveGame_IsValid && OnAsyncHandleSaveGame__DelegateSignature_bSuccess_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnAsyncHandleSaveGame__DelegateSignature", OnAsyncHandleSaveGame__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(USaveGame SaveGame, bool bSuccess)
	{
		if (!OnAsyncHandleSaveGame__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnAsyncHandleSaveGame__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnAsyncHandleSaveGame__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAsyncHandleSaveGame__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<USaveGame>.ToNative(IntPtr.Add(intPtr, OnAsyncHandleSaveGame__DelegateSignature_SaveGame_Offset), 0, OnAsyncHandleSaveGame__DelegateSignature_SaveGame_PropertyAddress.Address, SaveGame);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnAsyncHandleSaveGame__DelegateSignature_bSuccess_Offset), 0, OnAsyncHandleSaveGame__DelegateSignature_bSuccess_PropertyAddress.Address, bSuccess);
			ProcessDelegate(intPtr);
		}
	}
}
