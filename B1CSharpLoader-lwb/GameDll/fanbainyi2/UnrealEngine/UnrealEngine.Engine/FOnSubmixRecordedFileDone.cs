using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnSubmixRecordedFileDone__DelegateSignature")]
public class FOnSubmixRecordedFileDone : FMulticastDelegate<FOnSubmixRecordedFileDone.Signature>
{
	public delegate void Signature(USoundWave ResultingSoundWave);

	private static bool OnSubmixRecordedFileDone__DelegateSignature_IsValid;

	private static IntPtr OnSubmixRecordedFileDone__DelegateSignature_FunctionAddress;

	private static int OnSubmixRecordedFileDone__DelegateSignature_ParamsSize;

	private static bool OnSubmixRecordedFileDone__DelegateSignature_ResultingSoundWave_IsValid;

	private static FFieldAddress OnSubmixRecordedFileDone__DelegateSignature_ResultingSoundWave_PropertyAddress;

	private static int OnSubmixRecordedFileDone__DelegateSignature_ResultingSoundWave_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnSubmixRecordedFileDone()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnSubmixRecordedFileDone__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnSubmixRecordedFileDone__DelegateSignature");
		OnSubmixRecordedFileDone__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSubmixRecordedFileDone__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnSubmixRecordedFileDone__DelegateSignature_ResultingSoundWave_PropertyAddress, OnSubmixRecordedFileDone__DelegateSignature_FunctionAddress, "ResultingSoundWave");
		OnSubmixRecordedFileDone__DelegateSignature_ResultingSoundWave_Offset = NativeReflectionCached.GetPropertyOffset(OnSubmixRecordedFileDone__DelegateSignature_FunctionAddress, "ResultingSoundWave");
		OnSubmixRecordedFileDone__DelegateSignature_ResultingSoundWave_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSubmixRecordedFileDone__DelegateSignature_FunctionAddress, "ResultingSoundWave", Classes.FObjectProperty);
		OnSubmixRecordedFileDone__DelegateSignature_IsValid = OnSubmixRecordedFileDone__DelegateSignature_FunctionAddress != IntPtr.Zero && OnSubmixRecordedFileDone__DelegateSignature_ResultingSoundWave_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnSubmixRecordedFileDone__DelegateSignature", OnSubmixRecordedFileDone__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(USoundWave ResultingSoundWave)
	{
		if (!OnSubmixRecordedFileDone__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnSubmixRecordedFileDone__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnSubmixRecordedFileDone__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSubmixRecordedFileDone__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<USoundWave>.ToNative(IntPtr.Add(intPtr, OnSubmixRecordedFileDone__DelegateSignature_ResultingSoundWave_Offset), 0, OnSubmixRecordedFileDone__DelegateSignature_ResultingSoundWave_PropertyAddress.Address, ResultingSoundWave);
			ProcessDelegate(intPtr);
		}
	}
}
