using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.MovementModeChangedSignature__DelegateSignature")]
public class FMovementModeChangedSignature : FMulticastDelegate<FMovementModeChangedSignature.Signature>
{
	public delegate void Signature(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode);

	private static bool MovementModeChangedSignature__DelegateSignature_IsValid;

	private static IntPtr MovementModeChangedSignature__DelegateSignature_FunctionAddress;

	private static int MovementModeChangedSignature__DelegateSignature_ParamsSize;

	private static bool MovementModeChangedSignature__DelegateSignature_Character_IsValid;

	private static FFieldAddress MovementModeChangedSignature__DelegateSignature_Character_PropertyAddress;

	private static int MovementModeChangedSignature__DelegateSignature_Character_Offset;

	private static bool MovementModeChangedSignature__DelegateSignature_PrevMovementMode_IsValid;

	private static FFieldAddress MovementModeChangedSignature__DelegateSignature_PrevMovementMode_PropertyAddress;

	private static int MovementModeChangedSignature__DelegateSignature_PrevMovementMode_Offset;

	private static bool MovementModeChangedSignature__DelegateSignature_PreviousCustomMode_IsValid;

	private static FFieldAddress MovementModeChangedSignature__DelegateSignature_PreviousCustomMode_PropertyAddress;

	private static int MovementModeChangedSignature__DelegateSignature_PreviousCustomMode_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FMovementModeChangedSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		MovementModeChangedSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.MovementModeChangedSignature__DelegateSignature");
		MovementModeChangedSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(MovementModeChangedSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MovementModeChangedSignature__DelegateSignature_Character_PropertyAddress, MovementModeChangedSignature__DelegateSignature_FunctionAddress, "Character");
		MovementModeChangedSignature__DelegateSignature_Character_Offset = NativeReflectionCached.GetPropertyOffset(MovementModeChangedSignature__DelegateSignature_FunctionAddress, "Character");
		MovementModeChangedSignature__DelegateSignature_Character_IsValid = NativeReflectionCached.ValidatePropertyClass(MovementModeChangedSignature__DelegateSignature_FunctionAddress, "Character", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MovementModeChangedSignature__DelegateSignature_PrevMovementMode_PropertyAddress, MovementModeChangedSignature__DelegateSignature_FunctionAddress, "PrevMovementMode");
		MovementModeChangedSignature__DelegateSignature_PrevMovementMode_Offset = NativeReflectionCached.GetPropertyOffset(MovementModeChangedSignature__DelegateSignature_FunctionAddress, "PrevMovementMode");
		MovementModeChangedSignature__DelegateSignature_PrevMovementMode_IsValid = NativeReflectionCached.ValidatePropertyClass(MovementModeChangedSignature__DelegateSignature_FunctionAddress, "PrevMovementMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref MovementModeChangedSignature__DelegateSignature_PreviousCustomMode_PropertyAddress, MovementModeChangedSignature__DelegateSignature_FunctionAddress, "PreviousCustomMode");
		MovementModeChangedSignature__DelegateSignature_PreviousCustomMode_Offset = NativeReflectionCached.GetPropertyOffset(MovementModeChangedSignature__DelegateSignature_FunctionAddress, "PreviousCustomMode");
		MovementModeChangedSignature__DelegateSignature_PreviousCustomMode_IsValid = NativeReflectionCached.ValidatePropertyClass(MovementModeChangedSignature__DelegateSignature_FunctionAddress, "PreviousCustomMode", Classes.FByteProperty);
		MovementModeChangedSignature__DelegateSignature_IsValid = MovementModeChangedSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && MovementModeChangedSignature__DelegateSignature_Character_IsValid && MovementModeChangedSignature__DelegateSignature_PrevMovementMode_IsValid && MovementModeChangedSignature__DelegateSignature_PreviousCustomMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MovementModeChangedSignature__DelegateSignature", MovementModeChangedSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode)
	{
		if (!MovementModeChangedSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MovementModeChangedSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(MovementModeChangedSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MovementModeChangedSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(intPtr, MovementModeChangedSignature__DelegateSignature_Character_Offset), 0, MovementModeChangedSignature__DelegateSignature_Character_PropertyAddress.Address, Character);
			EnumMarshaler<EMovementMode>.ToNative(IntPtr.Add(intPtr, MovementModeChangedSignature__DelegateSignature_PrevMovementMode_Offset), 0, MovementModeChangedSignature__DelegateSignature_PrevMovementMode_PropertyAddress.Address, PrevMovementMode);
			BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, MovementModeChangedSignature__DelegateSignature_PreviousCustomMode_Offset), 0, MovementModeChangedSignature__DelegateSignature_PreviousCustomMode_PropertyAddress.Address, PreviousCustomMode);
			ProcessDelegate(intPtr);
		}
	}
}
