using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.CharacterMovementUpdatedSignature__DelegateSignature")]
public class FCharacterMovementUpdatedSignature : FMulticastDelegate<FCharacterMovementUpdatedSignature.Signature>
{
	public delegate void Signature(float DeltaSeconds, FVector OldLocation, FVector OldVelocity);

	private static bool CharacterMovementUpdatedSignature__DelegateSignature_IsValid;

	private static IntPtr CharacterMovementUpdatedSignature__DelegateSignature_FunctionAddress;

	private static int CharacterMovementUpdatedSignature__DelegateSignature_ParamsSize;

	private static bool CharacterMovementUpdatedSignature__DelegateSignature_DeltaSeconds_IsValid;

	private static FFieldAddress CharacterMovementUpdatedSignature__DelegateSignature_DeltaSeconds_PropertyAddress;

	private static int CharacterMovementUpdatedSignature__DelegateSignature_DeltaSeconds_Offset;

	private static bool CharacterMovementUpdatedSignature__DelegateSignature_OldLocation_IsValid;

	private static FFieldAddress CharacterMovementUpdatedSignature__DelegateSignature_OldLocation_PropertyAddress;

	private static int CharacterMovementUpdatedSignature__DelegateSignature_OldLocation_Offset;

	private static bool CharacterMovementUpdatedSignature__DelegateSignature_OldVelocity_IsValid;

	private static FFieldAddress CharacterMovementUpdatedSignature__DelegateSignature_OldVelocity_PropertyAddress;

	private static int CharacterMovementUpdatedSignature__DelegateSignature_OldVelocity_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FCharacterMovementUpdatedSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		CharacterMovementUpdatedSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.CharacterMovementUpdatedSignature__DelegateSignature");
		CharacterMovementUpdatedSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(CharacterMovementUpdatedSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CharacterMovementUpdatedSignature__DelegateSignature_DeltaSeconds_PropertyAddress, CharacterMovementUpdatedSignature__DelegateSignature_FunctionAddress, "DeltaSeconds");
		CharacterMovementUpdatedSignature__DelegateSignature_DeltaSeconds_Offset = NativeReflectionCached.GetPropertyOffset(CharacterMovementUpdatedSignature__DelegateSignature_FunctionAddress, "DeltaSeconds");
		CharacterMovementUpdatedSignature__DelegateSignature_DeltaSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(CharacterMovementUpdatedSignature__DelegateSignature_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CharacterMovementUpdatedSignature__DelegateSignature_OldLocation_PropertyAddress, CharacterMovementUpdatedSignature__DelegateSignature_FunctionAddress, "OldLocation");
		CharacterMovementUpdatedSignature__DelegateSignature_OldLocation_Offset = NativeReflectionCached.GetPropertyOffset(CharacterMovementUpdatedSignature__DelegateSignature_FunctionAddress, "OldLocation");
		CharacterMovementUpdatedSignature__DelegateSignature_OldLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(CharacterMovementUpdatedSignature__DelegateSignature_FunctionAddress, "OldLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CharacterMovementUpdatedSignature__DelegateSignature_OldVelocity_PropertyAddress, CharacterMovementUpdatedSignature__DelegateSignature_FunctionAddress, "OldVelocity");
		CharacterMovementUpdatedSignature__DelegateSignature_OldVelocity_Offset = NativeReflectionCached.GetPropertyOffset(CharacterMovementUpdatedSignature__DelegateSignature_FunctionAddress, "OldVelocity");
		CharacterMovementUpdatedSignature__DelegateSignature_OldVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(CharacterMovementUpdatedSignature__DelegateSignature_FunctionAddress, "OldVelocity", Classes.FStructProperty);
		CharacterMovementUpdatedSignature__DelegateSignature_IsValid = CharacterMovementUpdatedSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && CharacterMovementUpdatedSignature__DelegateSignature_DeltaSeconds_IsValid && CharacterMovementUpdatedSignature__DelegateSignature_OldLocation_IsValid && CharacterMovementUpdatedSignature__DelegateSignature_OldVelocity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterMovementUpdatedSignature__DelegateSignature", CharacterMovementUpdatedSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(float DeltaSeconds, FVector OldLocation, FVector OldVelocity)
	{
		if (!CharacterMovementUpdatedSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterMovementUpdatedSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(CharacterMovementUpdatedSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CharacterMovementUpdatedSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CharacterMovementUpdatedSignature__DelegateSignature_DeltaSeconds_Offset), 0, CharacterMovementUpdatedSignature__DelegateSignature_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
			BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CharacterMovementUpdatedSignature__DelegateSignature_OldLocation_Offset), 0, CharacterMovementUpdatedSignature__DelegateSignature_OldLocation_PropertyAddress.Address, OldLocation);
			BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CharacterMovementUpdatedSignature__DelegateSignature_OldVelocity_Offset), 0, CharacterMovementUpdatedSignature__DelegateSignature_OldVelocity_PropertyAddress.Address, OldVelocity);
			ProcessDelegate(intPtr);
		}
	}
}
