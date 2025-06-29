using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnPlayerStatePawnSet__DelegateSignature")]
public class FOnPlayerStatePawnSet : FMulticastDelegate<FOnPlayerStatePawnSet.Signature>
{
	public delegate void Signature(APlayerState Player, APawn NewPawn, APawn OldPawn);

	private static bool OnPlayerStatePawnSet__DelegateSignature_IsValid;

	private static IntPtr OnPlayerStatePawnSet__DelegateSignature_FunctionAddress;

	private static int OnPlayerStatePawnSet__DelegateSignature_ParamsSize;

	private static bool OnPlayerStatePawnSet__DelegateSignature_Player_IsValid;

	private static FFieldAddress OnPlayerStatePawnSet__DelegateSignature_Player_PropertyAddress;

	private static int OnPlayerStatePawnSet__DelegateSignature_Player_Offset;

	private static bool OnPlayerStatePawnSet__DelegateSignature_NewPawn_IsValid;

	private static FFieldAddress OnPlayerStatePawnSet__DelegateSignature_NewPawn_PropertyAddress;

	private static int OnPlayerStatePawnSet__DelegateSignature_NewPawn_Offset;

	private static bool OnPlayerStatePawnSet__DelegateSignature_OldPawn_IsValid;

	private static FFieldAddress OnPlayerStatePawnSet__DelegateSignature_OldPawn_PropertyAddress;

	private static int OnPlayerStatePawnSet__DelegateSignature_OldPawn_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnPlayerStatePawnSet()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnPlayerStatePawnSet__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnPlayerStatePawnSet__DelegateSignature");
		OnPlayerStatePawnSet__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPlayerStatePawnSet__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPlayerStatePawnSet__DelegateSignature_Player_PropertyAddress, OnPlayerStatePawnSet__DelegateSignature_FunctionAddress, "Player");
		OnPlayerStatePawnSet__DelegateSignature_Player_Offset = NativeReflectionCached.GetPropertyOffset(OnPlayerStatePawnSet__DelegateSignature_FunctionAddress, "Player");
		OnPlayerStatePawnSet__DelegateSignature_Player_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPlayerStatePawnSet__DelegateSignature_FunctionAddress, "Player", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPlayerStatePawnSet__DelegateSignature_NewPawn_PropertyAddress, OnPlayerStatePawnSet__DelegateSignature_FunctionAddress, "NewPawn");
		OnPlayerStatePawnSet__DelegateSignature_NewPawn_Offset = NativeReflectionCached.GetPropertyOffset(OnPlayerStatePawnSet__DelegateSignature_FunctionAddress, "NewPawn");
		OnPlayerStatePawnSet__DelegateSignature_NewPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPlayerStatePawnSet__DelegateSignature_FunctionAddress, "NewPawn", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPlayerStatePawnSet__DelegateSignature_OldPawn_PropertyAddress, OnPlayerStatePawnSet__DelegateSignature_FunctionAddress, "OldPawn");
		OnPlayerStatePawnSet__DelegateSignature_OldPawn_Offset = NativeReflectionCached.GetPropertyOffset(OnPlayerStatePawnSet__DelegateSignature_FunctionAddress, "OldPawn");
		OnPlayerStatePawnSet__DelegateSignature_OldPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPlayerStatePawnSet__DelegateSignature_FunctionAddress, "OldPawn", Classes.FObjectProperty);
		OnPlayerStatePawnSet__DelegateSignature_IsValid = OnPlayerStatePawnSet__DelegateSignature_FunctionAddress != IntPtr.Zero && OnPlayerStatePawnSet__DelegateSignature_Player_IsValid && OnPlayerStatePawnSet__DelegateSignature_NewPawn_IsValid && OnPlayerStatePawnSet__DelegateSignature_OldPawn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnPlayerStatePawnSet__DelegateSignature", OnPlayerStatePawnSet__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(APlayerState Player, APawn NewPawn, APawn OldPawn)
	{
		if (!OnPlayerStatePawnSet__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnPlayerStatePawnSet__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnPlayerStatePawnSet__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPlayerStatePawnSet__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<APlayerState>.ToNative(IntPtr.Add(intPtr, OnPlayerStatePawnSet__DelegateSignature_Player_Offset), 0, OnPlayerStatePawnSet__DelegateSignature_Player_PropertyAddress.Address, Player);
			UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, OnPlayerStatePawnSet__DelegateSignature_NewPawn_Offset), 0, OnPlayerStatePawnSet__DelegateSignature_NewPawn_PropertyAddress.Address, NewPawn);
			UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, OnPlayerStatePawnSet__DelegateSignature_OldPawn_Offset), 0, OnPlayerStatePawnSet__DelegateSignature_OldPawn_PropertyAddress.Address, OldPawn);
			ProcessDelegate(intPtr);
		}
	}
}
