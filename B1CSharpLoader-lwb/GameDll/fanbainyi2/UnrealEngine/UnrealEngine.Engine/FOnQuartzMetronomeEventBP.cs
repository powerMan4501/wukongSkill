using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnQuartzMetronomeEventBP__DelegateSignature")]
public class FOnQuartzMetronomeEventBP : FDelegate<FOnQuartzMetronomeEventBP.Signature>
{
	public delegate void Signature(FName ClockName, EQuartzCommandQuantization QuantizationType, int NumBars, int Beat, float BeatFraction);

	private static bool OnQuartzMetronomeEventBP__DelegateSignature_IsValid;

	private static IntPtr OnQuartzMetronomeEventBP__DelegateSignature_FunctionAddress;

	private static int OnQuartzMetronomeEventBP__DelegateSignature_ParamsSize;

	private static bool OnQuartzMetronomeEventBP__DelegateSignature_ClockName_IsValid;

	private static FFieldAddress OnQuartzMetronomeEventBP__DelegateSignature_ClockName_PropertyAddress;

	private static int OnQuartzMetronomeEventBP__DelegateSignature_ClockName_Offset;

	private static bool OnQuartzMetronomeEventBP__DelegateSignature_QuantizationType_IsValid;

	private static FFieldAddress OnQuartzMetronomeEventBP__DelegateSignature_QuantizationType_PropertyAddress;

	private static int OnQuartzMetronomeEventBP__DelegateSignature_QuantizationType_Offset;

	private static bool OnQuartzMetronomeEventBP__DelegateSignature_NumBars_IsValid;

	private static FFieldAddress OnQuartzMetronomeEventBP__DelegateSignature_NumBars_PropertyAddress;

	private static int OnQuartzMetronomeEventBP__DelegateSignature_NumBars_Offset;

	private static bool OnQuartzMetronomeEventBP__DelegateSignature_Beat_IsValid;

	private static FFieldAddress OnQuartzMetronomeEventBP__DelegateSignature_Beat_PropertyAddress;

	private static int OnQuartzMetronomeEventBP__DelegateSignature_Beat_Offset;

	private static bool OnQuartzMetronomeEventBP__DelegateSignature_BeatFraction_IsValid;

	private static FFieldAddress OnQuartzMetronomeEventBP__DelegateSignature_BeatFraction_PropertyAddress;

	private static int OnQuartzMetronomeEventBP__DelegateSignature_BeatFraction_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnQuartzMetronomeEventBP()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnQuartzMetronomeEventBP__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnQuartzMetronomeEventBP__DelegateSignature");
		OnQuartzMetronomeEventBP__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnQuartzMetronomeEventBP__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnQuartzMetronomeEventBP__DelegateSignature_ClockName_PropertyAddress, OnQuartzMetronomeEventBP__DelegateSignature_FunctionAddress, "ClockName");
		OnQuartzMetronomeEventBP__DelegateSignature_ClockName_Offset = NativeReflectionCached.GetPropertyOffset(OnQuartzMetronomeEventBP__DelegateSignature_FunctionAddress, "ClockName");
		OnQuartzMetronomeEventBP__DelegateSignature_ClockName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnQuartzMetronomeEventBP__DelegateSignature_FunctionAddress, "ClockName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref OnQuartzMetronomeEventBP__DelegateSignature_QuantizationType_PropertyAddress, OnQuartzMetronomeEventBP__DelegateSignature_FunctionAddress, "QuantizationType");
		OnQuartzMetronomeEventBP__DelegateSignature_QuantizationType_Offset = NativeReflectionCached.GetPropertyOffset(OnQuartzMetronomeEventBP__DelegateSignature_FunctionAddress, "QuantizationType");
		OnQuartzMetronomeEventBP__DelegateSignature_QuantizationType_IsValid = NativeReflectionCached.ValidatePropertyClass(OnQuartzMetronomeEventBP__DelegateSignature_FunctionAddress, "QuantizationType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref OnQuartzMetronomeEventBP__DelegateSignature_NumBars_PropertyAddress, OnQuartzMetronomeEventBP__DelegateSignature_FunctionAddress, "NumBars");
		OnQuartzMetronomeEventBP__DelegateSignature_NumBars_Offset = NativeReflectionCached.GetPropertyOffset(OnQuartzMetronomeEventBP__DelegateSignature_FunctionAddress, "NumBars");
		OnQuartzMetronomeEventBP__DelegateSignature_NumBars_IsValid = NativeReflectionCached.ValidatePropertyClass(OnQuartzMetronomeEventBP__DelegateSignature_FunctionAddress, "NumBars", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OnQuartzMetronomeEventBP__DelegateSignature_Beat_PropertyAddress, OnQuartzMetronomeEventBP__DelegateSignature_FunctionAddress, "Beat");
		OnQuartzMetronomeEventBP__DelegateSignature_Beat_Offset = NativeReflectionCached.GetPropertyOffset(OnQuartzMetronomeEventBP__DelegateSignature_FunctionAddress, "Beat");
		OnQuartzMetronomeEventBP__DelegateSignature_Beat_IsValid = NativeReflectionCached.ValidatePropertyClass(OnQuartzMetronomeEventBP__DelegateSignature_FunctionAddress, "Beat", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OnQuartzMetronomeEventBP__DelegateSignature_BeatFraction_PropertyAddress, OnQuartzMetronomeEventBP__DelegateSignature_FunctionAddress, "BeatFraction");
		OnQuartzMetronomeEventBP__DelegateSignature_BeatFraction_Offset = NativeReflectionCached.GetPropertyOffset(OnQuartzMetronomeEventBP__DelegateSignature_FunctionAddress, "BeatFraction");
		OnQuartzMetronomeEventBP__DelegateSignature_BeatFraction_IsValid = NativeReflectionCached.ValidatePropertyClass(OnQuartzMetronomeEventBP__DelegateSignature_FunctionAddress, "BeatFraction", Classes.FFloatProperty);
		OnQuartzMetronomeEventBP__DelegateSignature_IsValid = OnQuartzMetronomeEventBP__DelegateSignature_FunctionAddress != IntPtr.Zero && OnQuartzMetronomeEventBP__DelegateSignature_ClockName_IsValid && OnQuartzMetronomeEventBP__DelegateSignature_QuantizationType_IsValid && OnQuartzMetronomeEventBP__DelegateSignature_NumBars_IsValid && OnQuartzMetronomeEventBP__DelegateSignature_Beat_IsValid && OnQuartzMetronomeEventBP__DelegateSignature_BeatFraction_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnQuartzMetronomeEventBP__DelegateSignature", OnQuartzMetronomeEventBP__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FName ClockName, EQuartzCommandQuantization QuantizationType, int NumBars, int Beat, float BeatFraction)
	{
		if (!OnQuartzMetronomeEventBP__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnQuartzMetronomeEventBP__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnQuartzMetronomeEventBP__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnQuartzMetronomeEventBP__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnQuartzMetronomeEventBP__DelegateSignature_ClockName_Offset), 0, OnQuartzMetronomeEventBP__DelegateSignature_ClockName_PropertyAddress.Address, ClockName);
			EnumMarshaler<EQuartzCommandQuantization>.ToNative(IntPtr.Add(intPtr, OnQuartzMetronomeEventBP__DelegateSignature_QuantizationType_Offset), 0, OnQuartzMetronomeEventBP__DelegateSignature_QuantizationType_PropertyAddress.Address, QuantizationType);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnQuartzMetronomeEventBP__DelegateSignature_NumBars_Offset), 0, OnQuartzMetronomeEventBP__DelegateSignature_NumBars_PropertyAddress.Address, NumBars);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnQuartzMetronomeEventBP__DelegateSignature_Beat_Offset), 0, OnQuartzMetronomeEventBP__DelegateSignature_Beat_PropertyAddress.Address, Beat);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnQuartzMetronomeEventBP__DelegateSignature_BeatFraction_Offset), 0, OnQuartzMetronomeEventBP__DelegateSignature_BeatFraction_PropertyAddress.Address, BeatFraction);
			ProcessDelegate(intPtr);
		}
	}
}
