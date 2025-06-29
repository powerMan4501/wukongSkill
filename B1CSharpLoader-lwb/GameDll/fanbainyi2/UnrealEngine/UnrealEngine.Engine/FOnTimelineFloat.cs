using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnTimelineFloat__DelegateSignature")]
public class FOnTimelineFloat : FDelegate<FOnTimelineFloat.Signature>
{
	public delegate void Signature(float Output);

	private static bool OnTimelineFloat__DelegateSignature_IsValid;

	private static IntPtr OnTimelineFloat__DelegateSignature_FunctionAddress;

	private static int OnTimelineFloat__DelegateSignature_ParamsSize;

	private static bool OnTimelineFloat__DelegateSignature_Output_IsValid;

	private static FFieldAddress OnTimelineFloat__DelegateSignature_Output_PropertyAddress;

	private static int OnTimelineFloat__DelegateSignature_Output_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnTimelineFloat()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnTimelineFloat__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnTimelineFloat__DelegateSignature");
		OnTimelineFloat__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTimelineFloat__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnTimelineFloat__DelegateSignature_Output_PropertyAddress, OnTimelineFloat__DelegateSignature_FunctionAddress, "Output");
		OnTimelineFloat__DelegateSignature_Output_Offset = NativeReflectionCached.GetPropertyOffset(OnTimelineFloat__DelegateSignature_FunctionAddress, "Output");
		OnTimelineFloat__DelegateSignature_Output_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTimelineFloat__DelegateSignature_FunctionAddress, "Output", Classes.FFloatProperty);
		OnTimelineFloat__DelegateSignature_IsValid = OnTimelineFloat__DelegateSignature_FunctionAddress != IntPtr.Zero && OnTimelineFloat__DelegateSignature_Output_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnTimelineFloat__DelegateSignature", OnTimelineFloat__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(float Output)
	{
		if (!OnTimelineFloat__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnTimelineFloat__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnTimelineFloat__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTimelineFloat__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnTimelineFloat__DelegateSignature_Output_Offset), 0, OnTimelineFloat__DelegateSignature_Output_PropertyAddress.Address, Output);
			ProcessDelegate(intPtr);
		}
	}
}
