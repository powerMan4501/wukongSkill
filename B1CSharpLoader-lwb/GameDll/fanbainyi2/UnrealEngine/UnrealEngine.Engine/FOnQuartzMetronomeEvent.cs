using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnQuartzMetronomeEvent__DelegateSignature")]
public class FOnQuartzMetronomeEvent : FMulticastDelegate<FOnQuartzMetronomeEvent.Signature>
{
	public delegate void Signature(FName ClockName, EQuartzCommandQuantization QuantizationType, int NumBars, int Beat, float BeatFraction);

	private static bool OnQuartzMetronomeEvent__DelegateSignature_IsValid;

	private static IntPtr OnQuartzMetronomeEvent__DelegateSignature_FunctionAddress;

	private static int OnQuartzMetronomeEvent__DelegateSignature_ParamsSize;

	private static bool OnQuartzMetronomeEvent__DelegateSignature_ClockName_IsValid;

	private static FFieldAddress OnQuartzMetronomeEvent__DelegateSignature_ClockName_PropertyAddress;

	private static int OnQuartzMetronomeEvent__DelegateSignature_ClockName_Offset;

	private static bool OnQuartzMetronomeEvent__DelegateSignature_QuantizationType_IsValid;

	private static FFieldAddress OnQuartzMetronomeEvent__DelegateSignature_QuantizationType_PropertyAddress;

	private static int OnQuartzMetronomeEvent__DelegateSignature_QuantizationType_Offset;

	private static bool OnQuartzMetronomeEvent__DelegateSignature_NumBars_IsValid;

	private static FFieldAddress OnQuartzMetronomeEvent__DelegateSignature_NumBars_PropertyAddress;

	private static int OnQuartzMetronomeEvent__DelegateSignature_NumBars_Offset;

	private static bool OnQuartzMetronomeEvent__DelegateSignature_Beat_IsValid;

	private static FFieldAddress OnQuartzMetronomeEvent__DelegateSignature_Beat_PropertyAddress;

	private static int OnQuartzMetronomeEvent__DelegateSignature_Beat_Offset;

	private static bool OnQuartzMetronomeEvent__DelegateSignature_BeatFraction_IsValid;

	private static FFieldAddress OnQuartzMetronomeEvent__DelegateSignature_BeatFraction_PropertyAddress;

	private static int OnQuartzMetronomeEvent__DelegateSignature_BeatFraction_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnQuartzMetronomeEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnQuartzMetronomeEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnQuartzMetronomeEvent__DelegateSignature");
		OnQuartzMetronomeEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnQuartzMetronomeEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnQuartzMetronomeEvent__DelegateSignature_ClockName_PropertyAddress, OnQuartzMetronomeEvent__DelegateSignature_FunctionAddress, "ClockName");
		OnQuartzMetronomeEvent__DelegateSignature_ClockName_Offset = NativeReflectionCached.GetPropertyOffset(OnQuartzMetronomeEvent__DelegateSignature_FunctionAddress, "ClockName");
		OnQuartzMetronomeEvent__DelegateSignature_ClockName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnQuartzMetronomeEvent__DelegateSignature_FunctionAddress, "ClockName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref OnQuartzMetronomeEvent__DelegateSignature_QuantizationType_PropertyAddress, OnQuartzMetronomeEvent__DelegateSignature_FunctionAddress, "QuantizationType");
		OnQuartzMetronomeEvent__DelegateSignature_QuantizationType_Offset = NativeReflectionCached.GetPropertyOffset(OnQuartzMetronomeEvent__DelegateSignature_FunctionAddress, "QuantizationType");
		OnQuartzMetronomeEvent__DelegateSignature_QuantizationType_IsValid = NativeReflectionCached.ValidatePropertyClass(OnQuartzMetronomeEvent__DelegateSignature_FunctionAddress, "QuantizationType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref OnQuartzMetronomeEvent__DelegateSignature_NumBars_PropertyAddress, OnQuartzMetronomeEvent__DelegateSignature_FunctionAddress, "NumBars");
		OnQuartzMetronomeEvent__DelegateSignature_NumBars_Offset = NativeReflectionCached.GetPropertyOffset(OnQuartzMetronomeEvent__DelegateSignature_FunctionAddress, "NumBars");
		OnQuartzMetronomeEvent__DelegateSignature_NumBars_IsValid = NativeReflectionCached.ValidatePropertyClass(OnQuartzMetronomeEvent__DelegateSignature_FunctionAddress, "NumBars", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OnQuartzMetronomeEvent__DelegateSignature_Beat_PropertyAddress, OnQuartzMetronomeEvent__DelegateSignature_FunctionAddress, "Beat");
		OnQuartzMetronomeEvent__DelegateSignature_Beat_Offset = NativeReflectionCached.GetPropertyOffset(OnQuartzMetronomeEvent__DelegateSignature_FunctionAddress, "Beat");
		OnQuartzMetronomeEvent__DelegateSignature_Beat_IsValid = NativeReflectionCached.ValidatePropertyClass(OnQuartzMetronomeEvent__DelegateSignature_FunctionAddress, "Beat", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OnQuartzMetronomeEvent__DelegateSignature_BeatFraction_PropertyAddress, OnQuartzMetronomeEvent__DelegateSignature_FunctionAddress, "BeatFraction");
		OnQuartzMetronomeEvent__DelegateSignature_BeatFraction_Offset = NativeReflectionCached.GetPropertyOffset(OnQuartzMetronomeEvent__DelegateSignature_FunctionAddress, "BeatFraction");
		OnQuartzMetronomeEvent__DelegateSignature_BeatFraction_IsValid = NativeReflectionCached.ValidatePropertyClass(OnQuartzMetronomeEvent__DelegateSignature_FunctionAddress, "BeatFraction", Classes.FFloatProperty);
		OnQuartzMetronomeEvent__DelegateSignature_IsValid = OnQuartzMetronomeEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnQuartzMetronomeEvent__DelegateSignature_ClockName_IsValid && OnQuartzMetronomeEvent__DelegateSignature_QuantizationType_IsValid && OnQuartzMetronomeEvent__DelegateSignature_NumBars_IsValid && OnQuartzMetronomeEvent__DelegateSignature_Beat_IsValid && OnQuartzMetronomeEvent__DelegateSignature_BeatFraction_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnQuartzMetronomeEvent__DelegateSignature", OnQuartzMetronomeEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FName ClockName, EQuartzCommandQuantization QuantizationType, int NumBars, int Beat, float BeatFraction)
	{
		if (!OnQuartzMetronomeEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnQuartzMetronomeEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnQuartzMetronomeEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnQuartzMetronomeEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnQuartzMetronomeEvent__DelegateSignature_ClockName_Offset), 0, OnQuartzMetronomeEvent__DelegateSignature_ClockName_PropertyAddress.Address, ClockName);
			EnumMarshaler<EQuartzCommandQuantization>.ToNative(IntPtr.Add(intPtr, OnQuartzMetronomeEvent__DelegateSignature_QuantizationType_Offset), 0, OnQuartzMetronomeEvent__DelegateSignature_QuantizationType_PropertyAddress.Address, QuantizationType);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnQuartzMetronomeEvent__DelegateSignature_NumBars_Offset), 0, OnQuartzMetronomeEvent__DelegateSignature_NumBars_PropertyAddress.Address, NumBars);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnQuartzMetronomeEvent__DelegateSignature_Beat_Offset), 0, OnQuartzMetronomeEvent__DelegateSignature_Beat_PropertyAddress.Address, Beat);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnQuartzMetronomeEvent__DelegateSignature_BeatFraction_Offset), 0, OnQuartzMetronomeEvent__DelegateSignature_BeatFraction_PropertyAddress.Address, BeatFraction);
			ProcessDelegate(intPtr);
		}
	}
}
