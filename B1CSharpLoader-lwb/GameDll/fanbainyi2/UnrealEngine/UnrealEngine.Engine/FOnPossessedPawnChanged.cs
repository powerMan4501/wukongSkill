using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnPossessedPawnChanged__DelegateSignature")]
public class FOnPossessedPawnChanged : FMulticastDelegate<FOnPossessedPawnChanged.Signature>
{
	public delegate void Signature(APawn OldPawn, APawn NewPawn);

	private static bool OnPossessedPawnChanged__DelegateSignature_IsValid;

	private static IntPtr OnPossessedPawnChanged__DelegateSignature_FunctionAddress;

	private static int OnPossessedPawnChanged__DelegateSignature_ParamsSize;

	private static bool OnPossessedPawnChanged__DelegateSignature_OldPawn_IsValid;

	private static FFieldAddress OnPossessedPawnChanged__DelegateSignature_OldPawn_PropertyAddress;

	private static int OnPossessedPawnChanged__DelegateSignature_OldPawn_Offset;

	private static bool OnPossessedPawnChanged__DelegateSignature_NewPawn_IsValid;

	private static FFieldAddress OnPossessedPawnChanged__DelegateSignature_NewPawn_PropertyAddress;

	private static int OnPossessedPawnChanged__DelegateSignature_NewPawn_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnPossessedPawnChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnPossessedPawnChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnPossessedPawnChanged__DelegateSignature");
		OnPossessedPawnChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPossessedPawnChanged__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPossessedPawnChanged__DelegateSignature_OldPawn_PropertyAddress, OnPossessedPawnChanged__DelegateSignature_FunctionAddress, "OldPawn");
		OnPossessedPawnChanged__DelegateSignature_OldPawn_Offset = NativeReflectionCached.GetPropertyOffset(OnPossessedPawnChanged__DelegateSignature_FunctionAddress, "OldPawn");
		OnPossessedPawnChanged__DelegateSignature_OldPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPossessedPawnChanged__DelegateSignature_FunctionAddress, "OldPawn", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPossessedPawnChanged__DelegateSignature_NewPawn_PropertyAddress, OnPossessedPawnChanged__DelegateSignature_FunctionAddress, "NewPawn");
		OnPossessedPawnChanged__DelegateSignature_NewPawn_Offset = NativeReflectionCached.GetPropertyOffset(OnPossessedPawnChanged__DelegateSignature_FunctionAddress, "NewPawn");
		OnPossessedPawnChanged__DelegateSignature_NewPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPossessedPawnChanged__DelegateSignature_FunctionAddress, "NewPawn", Classes.FObjectProperty);
		OnPossessedPawnChanged__DelegateSignature_IsValid = OnPossessedPawnChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && OnPossessedPawnChanged__DelegateSignature_OldPawn_IsValid && OnPossessedPawnChanged__DelegateSignature_NewPawn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnPossessedPawnChanged__DelegateSignature", OnPossessedPawnChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(APawn OldPawn, APawn NewPawn)
	{
		if (!OnPossessedPawnChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnPossessedPawnChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnPossessedPawnChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPossessedPawnChanged__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, OnPossessedPawnChanged__DelegateSignature_OldPawn_Offset), 0, OnPossessedPawnChanged__DelegateSignature_OldPawn_PropertyAddress.Address, OldPawn);
			UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, OnPossessedPawnChanged__DelegateSignature_NewPawn_Offset), 0, OnPossessedPawnChanged__DelegateSignature_NewPawn_PropertyAddress.Address, NewPawn);
			ProcessDelegate(intPtr);
		}
	}
}
