using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.PawnControllerChangedSignature__DelegateSignature")]
public class FPawnControllerChangedSignature : FMulticastDelegate<FPawnControllerChangedSignature.Signature>
{
	public delegate void Signature(APawn Pawn, AController OldController, AController NewController);

	private static bool PawnControllerChangedSignature__DelegateSignature_IsValid;

	private static IntPtr PawnControllerChangedSignature__DelegateSignature_FunctionAddress;

	private static int PawnControllerChangedSignature__DelegateSignature_ParamsSize;

	private static bool PawnControllerChangedSignature__DelegateSignature_Pawn_IsValid;

	private static FFieldAddress PawnControllerChangedSignature__DelegateSignature_Pawn_PropertyAddress;

	private static int PawnControllerChangedSignature__DelegateSignature_Pawn_Offset;

	private static bool PawnControllerChangedSignature__DelegateSignature_OldController_IsValid;

	private static FFieldAddress PawnControllerChangedSignature__DelegateSignature_OldController_PropertyAddress;

	private static int PawnControllerChangedSignature__DelegateSignature_OldController_Offset;

	private static bool PawnControllerChangedSignature__DelegateSignature_NewController_IsValid;

	private static FFieldAddress PawnControllerChangedSignature__DelegateSignature_NewController_PropertyAddress;

	private static int PawnControllerChangedSignature__DelegateSignature_NewController_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FPawnControllerChangedSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		PawnControllerChangedSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.PawnControllerChangedSignature__DelegateSignature");
		PawnControllerChangedSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(PawnControllerChangedSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PawnControllerChangedSignature__DelegateSignature_Pawn_PropertyAddress, PawnControllerChangedSignature__DelegateSignature_FunctionAddress, "Pawn");
		PawnControllerChangedSignature__DelegateSignature_Pawn_Offset = NativeReflectionCached.GetPropertyOffset(PawnControllerChangedSignature__DelegateSignature_FunctionAddress, "Pawn");
		PawnControllerChangedSignature__DelegateSignature_Pawn_IsValid = NativeReflectionCached.ValidatePropertyClass(PawnControllerChangedSignature__DelegateSignature_FunctionAddress, "Pawn", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PawnControllerChangedSignature__DelegateSignature_OldController_PropertyAddress, PawnControllerChangedSignature__DelegateSignature_FunctionAddress, "OldController");
		PawnControllerChangedSignature__DelegateSignature_OldController_Offset = NativeReflectionCached.GetPropertyOffset(PawnControllerChangedSignature__DelegateSignature_FunctionAddress, "OldController");
		PawnControllerChangedSignature__DelegateSignature_OldController_IsValid = NativeReflectionCached.ValidatePropertyClass(PawnControllerChangedSignature__DelegateSignature_FunctionAddress, "OldController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PawnControllerChangedSignature__DelegateSignature_NewController_PropertyAddress, PawnControllerChangedSignature__DelegateSignature_FunctionAddress, "NewController");
		PawnControllerChangedSignature__DelegateSignature_NewController_Offset = NativeReflectionCached.GetPropertyOffset(PawnControllerChangedSignature__DelegateSignature_FunctionAddress, "NewController");
		PawnControllerChangedSignature__DelegateSignature_NewController_IsValid = NativeReflectionCached.ValidatePropertyClass(PawnControllerChangedSignature__DelegateSignature_FunctionAddress, "NewController", Classes.FObjectProperty);
		PawnControllerChangedSignature__DelegateSignature_IsValid = PawnControllerChangedSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && PawnControllerChangedSignature__DelegateSignature_Pawn_IsValid && PawnControllerChangedSignature__DelegateSignature_OldController_IsValid && PawnControllerChangedSignature__DelegateSignature_NewController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PawnControllerChangedSignature__DelegateSignature", PawnControllerChangedSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(APawn Pawn, AController OldController, AController NewController)
	{
		if (!PawnControllerChangedSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PawnControllerChangedSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(PawnControllerChangedSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PawnControllerChangedSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, PawnControllerChangedSignature__DelegateSignature_Pawn_Offset), 0, PawnControllerChangedSignature__DelegateSignature_Pawn_PropertyAddress.Address, Pawn);
			UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, PawnControllerChangedSignature__DelegateSignature_OldController_Offset), 0, PawnControllerChangedSignature__DelegateSignature_OldController_PropertyAddress.Address, OldController);
			UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, PawnControllerChangedSignature__DelegateSignature_NewController_Offset), 0, PawnControllerChangedSignature__DelegateSignature_NewController_PropertyAddress.Address, NewController);
			ProcessDelegate(intPtr);
		}
	}
}
