using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnPawnControllerChanged__DelegateSignature")]
public class FOnPawnControllerChanged : FMulticastDelegate<FOnPawnControllerChanged.Signature>
{
	public delegate void Signature(APawn Pawn, AController Controller);

	private static bool OnPawnControllerChanged__DelegateSignature_IsValid;

	private static IntPtr OnPawnControllerChanged__DelegateSignature_FunctionAddress;

	private static int OnPawnControllerChanged__DelegateSignature_ParamsSize;

	private static bool OnPawnControllerChanged__DelegateSignature_Pawn_IsValid;

	private static FFieldAddress OnPawnControllerChanged__DelegateSignature_Pawn_PropertyAddress;

	private static int OnPawnControllerChanged__DelegateSignature_Pawn_Offset;

	private static bool OnPawnControllerChanged__DelegateSignature_Controller_IsValid;

	private static FFieldAddress OnPawnControllerChanged__DelegateSignature_Controller_PropertyAddress;

	private static int OnPawnControllerChanged__DelegateSignature_Controller_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnPawnControllerChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnPawnControllerChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnPawnControllerChanged__DelegateSignature");
		OnPawnControllerChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPawnControllerChanged__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPawnControllerChanged__DelegateSignature_Pawn_PropertyAddress, OnPawnControllerChanged__DelegateSignature_FunctionAddress, "Pawn");
		OnPawnControllerChanged__DelegateSignature_Pawn_Offset = NativeReflectionCached.GetPropertyOffset(OnPawnControllerChanged__DelegateSignature_FunctionAddress, "Pawn");
		OnPawnControllerChanged__DelegateSignature_Pawn_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPawnControllerChanged__DelegateSignature_FunctionAddress, "Pawn", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPawnControllerChanged__DelegateSignature_Controller_PropertyAddress, OnPawnControllerChanged__DelegateSignature_FunctionAddress, "Controller");
		OnPawnControllerChanged__DelegateSignature_Controller_Offset = NativeReflectionCached.GetPropertyOffset(OnPawnControllerChanged__DelegateSignature_FunctionAddress, "Controller");
		OnPawnControllerChanged__DelegateSignature_Controller_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPawnControllerChanged__DelegateSignature_FunctionAddress, "Controller", Classes.FObjectProperty);
		OnPawnControllerChanged__DelegateSignature_IsValid = OnPawnControllerChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && OnPawnControllerChanged__DelegateSignature_Pawn_IsValid && OnPawnControllerChanged__DelegateSignature_Controller_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnPawnControllerChanged__DelegateSignature", OnPawnControllerChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(APawn Pawn, AController Controller)
	{
		if (!OnPawnControllerChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnPawnControllerChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnPawnControllerChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPawnControllerChanged__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, OnPawnControllerChanged__DelegateSignature_Pawn_Offset), 0, OnPawnControllerChanged__DelegateSignature_Pawn_PropertyAddress.Address, Pawn);
			UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, OnPawnControllerChanged__DelegateSignature_Controller_Offset), 0, OnPawnControllerChanged__DelegateSignature_Controller_PropertyAddress.Address, Controller);
			ProcessDelegate(intPtr);
		}
	}
}
