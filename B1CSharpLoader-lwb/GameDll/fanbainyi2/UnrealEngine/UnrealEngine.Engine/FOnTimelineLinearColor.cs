using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnTimelineLinearColor__DelegateSignature")]
public class FOnTimelineLinearColor : FDelegate<FOnTimelineLinearColor.Signature>
{
	public delegate void Signature(FLinearColor Output);

	private static bool OnTimelineLinearColor__DelegateSignature_IsValid;

	private static IntPtr OnTimelineLinearColor__DelegateSignature_FunctionAddress;

	private static int OnTimelineLinearColor__DelegateSignature_ParamsSize;

	private static bool OnTimelineLinearColor__DelegateSignature_Output_IsValid;

	private static FFieldAddress OnTimelineLinearColor__DelegateSignature_Output_PropertyAddress;

	private static int OnTimelineLinearColor__DelegateSignature_Output_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnTimelineLinearColor()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnTimelineLinearColor__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnTimelineLinearColor__DelegateSignature");
		OnTimelineLinearColor__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTimelineLinearColor__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnTimelineLinearColor__DelegateSignature_Output_PropertyAddress, OnTimelineLinearColor__DelegateSignature_FunctionAddress, "Output");
		OnTimelineLinearColor__DelegateSignature_Output_Offset = NativeReflectionCached.GetPropertyOffset(OnTimelineLinearColor__DelegateSignature_FunctionAddress, "Output");
		OnTimelineLinearColor__DelegateSignature_Output_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTimelineLinearColor__DelegateSignature_FunctionAddress, "Output", Classes.FStructProperty);
		OnTimelineLinearColor__DelegateSignature_IsValid = OnTimelineLinearColor__DelegateSignature_FunctionAddress != IntPtr.Zero && OnTimelineLinearColor__DelegateSignature_Output_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnTimelineLinearColor__DelegateSignature", OnTimelineLinearColor__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FLinearColor Output)
	{
		if (!OnTimelineLinearColor__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnTimelineLinearColor__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnTimelineLinearColor__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTimelineLinearColor__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, OnTimelineLinearColor__DelegateSignature_Output_Offset), 0, OnTimelineLinearColor__DelegateSignature_Output_PropertyAddress.Address, Output);
			ProcessDelegate(intPtr);
		}
	}
}
