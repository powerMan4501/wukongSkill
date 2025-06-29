using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.LevelSequence;

[UDelegate]
[UMetaPath("/Script/LevelSequence.OnLevelSequencePlayerCameraCutEvent__DelegateSignature")]
public class FOnLevelSequencePlayerCameraCutEvent : FMulticastDelegate<FOnLevelSequencePlayerCameraCutEvent.Signature>
{
	public delegate void Signature(UCameraComponent CameraComponent);

	private static bool OnLevelSequencePlayerCameraCutEvent__DelegateSignature_IsValid;

	private static IntPtr OnLevelSequencePlayerCameraCutEvent__DelegateSignature_FunctionAddress;

	private static int OnLevelSequencePlayerCameraCutEvent__DelegateSignature_ParamsSize;

	private static bool OnLevelSequencePlayerCameraCutEvent__DelegateSignature_CameraComponent_IsValid;

	private static FFieldAddress OnLevelSequencePlayerCameraCutEvent__DelegateSignature_CameraComponent_PropertyAddress;

	private static int OnLevelSequencePlayerCameraCutEvent__DelegateSignature_CameraComponent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnLevelSequencePlayerCameraCutEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnLevelSequencePlayerCameraCutEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/LevelSequence.OnLevelSequencePlayerCameraCutEvent__DelegateSignature");
		OnLevelSequencePlayerCameraCutEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLevelSequencePlayerCameraCutEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnLevelSequencePlayerCameraCutEvent__DelegateSignature_CameraComponent_PropertyAddress, OnLevelSequencePlayerCameraCutEvent__DelegateSignature_FunctionAddress, "CameraComponent");
		OnLevelSequencePlayerCameraCutEvent__DelegateSignature_CameraComponent_Offset = NativeReflectionCached.GetPropertyOffset(OnLevelSequencePlayerCameraCutEvent__DelegateSignature_FunctionAddress, "CameraComponent");
		OnLevelSequencePlayerCameraCutEvent__DelegateSignature_CameraComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnLevelSequencePlayerCameraCutEvent__DelegateSignature_FunctionAddress, "CameraComponent", Classes.FObjectProperty);
		OnLevelSequencePlayerCameraCutEvent__DelegateSignature_IsValid = OnLevelSequencePlayerCameraCutEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnLevelSequencePlayerCameraCutEvent__DelegateSignature_CameraComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.OnLevelSequencePlayerCameraCutEvent__DelegateSignature", OnLevelSequencePlayerCameraCutEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UCameraComponent CameraComponent)
	{
		if (!OnLevelSequencePlayerCameraCutEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.OnLevelSequencePlayerCameraCutEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnLevelSequencePlayerCameraCutEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLevelSequencePlayerCameraCutEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UCameraComponent>.ToNative(IntPtr.Add(intPtr, OnLevelSequencePlayerCameraCutEvent__DelegateSignature_CameraComponent_Offset), 0, OnLevelSequencePlayerCameraCutEvent__DelegateSignature_CameraComponent_PropertyAddress.Address, CameraComponent);
			ProcessDelegate(intPtr);
		}
	}
}
