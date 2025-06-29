using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnTimelineVector__DelegateSignature")]
public class FOnTimelineVector : FDelegate<FOnTimelineVector.Signature>
{
	public delegate void Signature(FVector Output);

	private static bool OnTimelineVector__DelegateSignature_IsValid;

	private static IntPtr OnTimelineVector__DelegateSignature_FunctionAddress;

	private static int OnTimelineVector__DelegateSignature_ParamsSize;

	private static bool OnTimelineVector__DelegateSignature_Output_IsValid;

	private static FFieldAddress OnTimelineVector__DelegateSignature_Output_PropertyAddress;

	private static int OnTimelineVector__DelegateSignature_Output_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnTimelineVector()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnTimelineVector__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnTimelineVector__DelegateSignature");
		OnTimelineVector__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTimelineVector__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnTimelineVector__DelegateSignature_Output_PropertyAddress, OnTimelineVector__DelegateSignature_FunctionAddress, "Output");
		OnTimelineVector__DelegateSignature_Output_Offset = NativeReflectionCached.GetPropertyOffset(OnTimelineVector__DelegateSignature_FunctionAddress, "Output");
		OnTimelineVector__DelegateSignature_Output_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTimelineVector__DelegateSignature_FunctionAddress, "Output", Classes.FStructProperty);
		OnTimelineVector__DelegateSignature_IsValid = OnTimelineVector__DelegateSignature_FunctionAddress != IntPtr.Zero && OnTimelineVector__DelegateSignature_Output_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnTimelineVector__DelegateSignature", OnTimelineVector__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FVector Output)
	{
		if (!OnTimelineVector__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnTimelineVector__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnTimelineVector__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTimelineVector__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnTimelineVector__DelegateSignature_Output_Offset), 0, OnTimelineVector__DelegateSignature_Output_PropertyAddress.Address, Output);
			ProcessDelegate(intPtr);
		}
	}
}
