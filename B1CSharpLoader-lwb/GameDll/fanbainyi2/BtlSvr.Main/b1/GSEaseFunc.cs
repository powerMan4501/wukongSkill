using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GSEaseFunc")]
public class GSEaseFunc : UBlueprintFunctionLibrary
{
	private static bool Sin_IsValid;

	private static IntPtr Sin_FunctionAddress;

	private static int Sin_ParamsSize;

	private static bool Sin_Start_IsValid;

	private static int Sin_Start_Offset;

	private static bool Sin_End_IsValid;

	private static int Sin_End_Offset;

	private static bool Sin_Alpha_IsValid;

	private static int Sin_Alpha_Offset;

	private static bool Sin_Param_IsValid;

	private static int Sin_Param_Offset;

	private static bool Sin_ReturnValue_IsValid;

	private static int Sin_ReturnValue_Offset;

	private static bool Ease_IsValid;

	private static IntPtr Ease_FunctionAddress;

	private static int Ease_ParamsSize;

	private static bool Ease_ENGSEasingFunc_IsValid;

	private static int Ease_ENGSEasingFunc_Offset;

	private static FFieldAddress Ease_ENGSEasingFunc_PropertyAddress;

	private static bool Ease_Start_IsValid;

	private static int Ease_Start_Offset;

	private static bool Ease_End_IsValid;

	private static int Ease_End_Offset;

	private static bool Ease_Alpha_IsValid;

	private static int Ease_Alpha_Offset;

	private static bool Ease_Param_IsValid;

	private static int Ease_Param_Offset;

	private static bool Ease_BlendExp_IsValid;

	private static int Ease_BlendExp_Offset;

	private static bool Ease_Steps_IsValid;

	private static int Ease_Steps_Offset;

	private static bool Ease_ReturnValue_IsValid;

	private static int Ease_ReturnValue_Offset;

	private static bool EaseColor_IsValid;

	private static IntPtr EaseColor_FunctionAddress;

	private static int EaseColor_ParamsSize;

	private static bool EaseColor_ENGSEasingFunc_IsValid;

	private static int EaseColor_ENGSEasingFunc_Offset;

	private static FFieldAddress EaseColor_ENGSEasingFunc_PropertyAddress;

	private static bool EaseColor_Start_IsValid;

	private static int EaseColor_Start_Offset;

	private static FFieldAddress EaseColor_Start_PropertyAddress;

	private static bool EaseColor_End_IsValid;

	private static int EaseColor_End_Offset;

	private static FFieldAddress EaseColor_End_PropertyAddress;

	private static bool EaseColor_Alpha_IsValid;

	private static int EaseColor_Alpha_Offset;

	private static bool EaseColor_Param_IsValid;

	private static int EaseColor_Param_Offset;

	private static bool EaseColor_BlendExp_IsValid;

	private static int EaseColor_BlendExp_Offset;

	private static bool EaseColor_Steps_IsValid;

	private static int EaseColor_Steps_Offset;

	private static bool EaseColor_ReturnValue_IsValid;

	private static int EaseColor_ReturnValue_Offset;

	private static FFieldAddress EaseColor_ReturnValue_PropertyAddress;

	private static bool EaseVector_IsValid;

	private static IntPtr EaseVector_FunctionAddress;

	private static int EaseVector_ParamsSize;

	private static bool EaseVector_ENGSEasingFunc_IsValid;

	private static int EaseVector_ENGSEasingFunc_Offset;

	private static FFieldAddress EaseVector_ENGSEasingFunc_PropertyAddress;

	private static bool EaseVector_Start_IsValid;

	private static int EaseVector_Start_Offset;

	private static FFieldAddress EaseVector_Start_PropertyAddress;

	private static bool EaseVector_End_IsValid;

	private static int EaseVector_End_Offset;

	private static FFieldAddress EaseVector_End_PropertyAddress;

	private static bool EaseVector_Alpha_IsValid;

	private static int EaseVector_Alpha_Offset;

	private static bool EaseVector_Param_IsValid;

	private static int EaseVector_Param_Offset;

	private static bool EaseVector_BlendExp_IsValid;

	private static int EaseVector_BlendExp_Offset;

	private static bool EaseVector_Steps_IsValid;

	private static int EaseVector_Steps_Offset;

	private static bool EaseVector_ReturnValue_IsValid;

	private static int EaseVector_ReturnValue_Offset;

	private static FFieldAddress EaseVector_ReturnValue_PropertyAddress;

	private static bool BackEaseIn_IsValid;

	private static IntPtr BackEaseIn_FunctionAddress;

	private static int BackEaseIn_ParamsSize;

	private static bool BackEaseIn_Start_IsValid;

	private static int BackEaseIn_Start_Offset;

	private static bool BackEaseIn_End_IsValid;

	private static int BackEaseIn_End_Offset;

	private static bool BackEaseIn_Alpha_IsValid;

	private static int BackEaseIn_Alpha_Offset;

	private static bool BackEaseIn_Param_IsValid;

	private static int BackEaseIn_Param_Offset;

	private static bool BackEaseIn_ReturnValue_IsValid;

	private static int BackEaseIn_ReturnValue_Offset;

	private static bool EaseRotator_IsValid;

	private static IntPtr EaseRotator_FunctionAddress;

	private static int EaseRotator_ParamsSize;

	private static bool EaseRotator_ENGSEasingFunc_IsValid;

	private static int EaseRotator_ENGSEasingFunc_Offset;

	private static FFieldAddress EaseRotator_ENGSEasingFunc_PropertyAddress;

	private static bool EaseRotator_Start_IsValid;

	private static int EaseRotator_Start_Offset;

	private static FFieldAddress EaseRotator_Start_PropertyAddress;

	private static bool EaseRotator_End_IsValid;

	private static int EaseRotator_End_Offset;

	private static FFieldAddress EaseRotator_End_PropertyAddress;

	private static bool EaseRotator_Alpha_IsValid;

	private static int EaseRotator_Alpha_Offset;

	private static bool EaseRotator_Param_IsValid;

	private static int EaseRotator_Param_Offset;

	private static bool EaseRotator_BlendExp_IsValid;

	private static int EaseRotator_BlendExp_Offset;

	private static bool EaseRotator_Steps_IsValid;

	private static int EaseRotator_Steps_Offset;

	private static bool EaseRotator_ReturnValue_IsValid;

	private static int EaseRotator_ReturnValue_Offset;

	private static FFieldAddress EaseRotator_ReturnValue_PropertyAddress;

	private static bool BackEaseOut_IsValid;

	private static IntPtr BackEaseOut_FunctionAddress;

	private static int BackEaseOut_ParamsSize;

	private static bool BackEaseOut_Start_IsValid;

	private static int BackEaseOut_Start_Offset;

	private static bool BackEaseOut_End_IsValid;

	private static int BackEaseOut_End_Offset;

	private static bool BackEaseOut_Alpha_IsValid;

	private static int BackEaseOut_Alpha_Offset;

	private static bool BackEaseOut_Param_IsValid;

	private static int BackEaseOut_Param_Offset;

	private static bool BackEaseOut_ReturnValue_IsValid;

	private static int BackEaseOut_ReturnValue_Offset;

	private static bool EaseInQuart_IsValid;

	private static IntPtr EaseInQuart_FunctionAddress;

	private static int EaseInQuart_ParamsSize;

	private static bool EaseInQuart_Start_IsValid;

	private static int EaseInQuart_Start_Offset;

	private static bool EaseInQuart_End_IsValid;

	private static int EaseInQuart_End_Offset;

	private static bool EaseInQuart_Alpha_IsValid;

	private static int EaseInQuart_Alpha_Offset;

	private static bool EaseInQuart_Param_IsValid;

	private static int EaseInQuart_Param_Offset;

	private static bool EaseInQuart_ReturnValue_IsValid;

	private static int EaseInQuart_ReturnValue_Offset;

	private static bool EaseTransform_IsValid;

	private static IntPtr EaseTransform_FunctionAddress;

	private static int EaseTransform_ParamsSize;

	private static bool EaseTransform_ENGSEasingFunc_IsValid;

	private static int EaseTransform_ENGSEasingFunc_Offset;

	private static FFieldAddress EaseTransform_ENGSEasingFunc_PropertyAddress;

	private static bool EaseTransform_Start_IsValid;

	private static int EaseTransform_Start_Offset;

	private static FFieldAddress EaseTransform_Start_PropertyAddress;

	private static bool EaseTransform_End_IsValid;

	private static int EaseTransform_End_Offset;

	private static FFieldAddress EaseTransform_End_PropertyAddress;

	private static bool EaseTransform_Alpha_IsValid;

	private static int EaseTransform_Alpha_Offset;

	private static bool EaseTransform_Param_IsValid;

	private static int EaseTransform_Param_Offset;

	private static bool EaseTransform_BlendExp_IsValid;

	private static int EaseTransform_BlendExp_Offset;

	private static bool EaseTransform_Steps_IsValid;

	private static int EaseTransform_Steps_Offset;

	private static bool EaseTransform_ReturnValue_IsValid;

	private static int EaseTransform_ReturnValue_Offset;

	private static FFieldAddress EaseTransform_ReturnValue_PropertyAddress;

	private static bool BackEaseInOut_IsValid;

	private static IntPtr BackEaseInOut_FunctionAddress;

	private static int BackEaseInOut_ParamsSize;

	private static bool BackEaseInOut_Start_IsValid;

	private static int BackEaseInOut_Start_Offset;

	private static bool BackEaseInOut_End_IsValid;

	private static int BackEaseInOut_End_Offset;

	private static bool BackEaseInOut_Alpha_IsValid;

	private static int BackEaseInOut_Alpha_Offset;

	private static bool BackEaseInOut_Param_IsValid;

	private static int BackEaseInOut_Param_Offset;

	private static bool BackEaseInOut_ReturnValue_IsValid;

	private static int BackEaseInOut_ReturnValue_Offset;

	private static bool EaseInOutQuint_IsValid;

	private static IntPtr EaseInOutQuint_FunctionAddress;

	private static int EaseInOutQuint_ParamsSize;

	private static bool EaseInOutQuint_Start_IsValid;

	private static int EaseInOutQuint_Start_Offset;

	private static bool EaseInOutQuint_End_IsValid;

	private static int EaseInOutQuint_End_Offset;

	private static bool EaseInOutQuint_Alpha_IsValid;

	private static int EaseInOutQuint_Alpha_Offset;

	private static bool EaseInOutQuint_Param_IsValid;

	private static int EaseInOutQuint_Param_Offset;

	private static bool EaseInOutQuint_ReturnValue_IsValid;

	private static int EaseInOutQuint_ReturnValue_Offset;

	[BlueprintCallable]
	[Category("EaseFunc")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSEaseFunc:Ease")]
	public static float Ease(ENGSEasingFunc ENGSEasingFunc, float Start, float End, float Alpha, float Param = 1.70158f, float BlendExp = 2f, int Steps = 2)
	{
		return ENGSEasingFunc switch
		{
			ENGSEasingFunc.BackEaseIn => BackEaseIn(Start, End, Alpha, Param), 
			ENGSEasingFunc.BackEaseOut => BackEaseOut(Start, End, Alpha, Param), 
			ENGSEasingFunc.BackEaseInOut => BackEaseInOut(Start, End, Alpha, Param), 
			ENGSEasingFunc.Sin => Sin(Start, End, Alpha, Param), 
			ENGSEasingFunc.EaseInQuart => EaseInQuart(Start, End, Alpha, Param), 
			ENGSEasingFunc.EaseInOutQuint => EaseInOutQuint(Start, End, Alpha, Param), 
			_ => GSEaseFuncInUE.GSMathEase(Start, End, Alpha, (EEasingFunc)ENGSEasingFunc, BlendExp, Steps), 
		};
	}

	[UFunction]
	[BlueprintCallable]
	[Category("EaseFunc")]
	[USharpPath("/Script/b1-Managed.GSEaseFunc:EaseVector")]
	public static FVector EaseVector(ENGSEasingFunc ENGSEasingFunc, FVector Start, FVector End, float Alpha, float Param = 1.70158f, float BlendExp = 2f, int Steps = 2)
	{
		if (Alpha == 0f)
		{
			return Start;
		}
		if (Alpha == 1f)
		{
			return End;
		}
		return new FVector
		{
			X = Ease(ENGSEasingFunc, Start.X, End.X, Alpha, Param, BlendExp, Steps),
			Y = Ease(ENGSEasingFunc, Start.Y, End.Y, Alpha, Param, BlendExp, Steps),
			Z = Ease(ENGSEasingFunc, Start.Z, End.Z, Alpha, Param, BlendExp, Steps)
		};
	}

	[Category("EaseFunc")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSEaseFunc:EaseColor")]
	public static FColor EaseColor(ENGSEasingFunc ENGSEasingFunc, FColor Start, FColor End, float Alpha, float Param = 1.70158f, float BlendExp = 2f, int Steps = 2)
	{
		if (Alpha == 0f)
		{
			return Start;
		}
		if (Alpha == 1f)
		{
			return End;
		}
		return new FColor
		{
			R = (byte)Ease(ENGSEasingFunc, (int)Start.R, (int)End.R, Alpha, Param, BlendExp, Steps),
			G = (byte)Ease(ENGSEasingFunc, (int)Start.G, (int)End.G, Alpha, Param, BlendExp, Steps),
			B = (byte)Ease(ENGSEasingFunc, (int)Start.B, (int)End.B, Alpha, Param, BlendExp, Steps)
		};
	}

	[Category("EaseFunc")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSEaseFunc:EaseRotator")]
	public static FRotator EaseRotator(ENGSEasingFunc ENGSEasingFunc, FRotator Start, FRotator End, float Alpha, float Param = 1.70158f, float BlendExp = 2f, int Steps = 2)
	{
		if (Alpha == 0f)
		{
			return Start;
		}
		if (Alpha == 1f)
		{
			return End;
		}
		float slerp = Ease(ENGSEasingFunc, 0f, 1f, Alpha, Param, BlendExp, Steps);
		FQuat quat = new FQuat(Start);
		FQuat quat2 = new FQuat(End);
		return FQuat.Slerp(quat, quat2, slerp).Rotator();
	}

	[BlueprintCallable]
	[Category("EaseFunc")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSEaseFunc:EaseTransform")]
	public static FTransform EaseTransform(ENGSEasingFunc ENGSEasingFunc, FTransform Start, FTransform End, float Alpha, float Param = 1.70158f, float BlendExp = 2f, int Steps = 2)
	{
		if (Alpha == 0f)
		{
			return Start;
		}
		if (Alpha == 1f)
		{
			return End;
		}
		FTransform result = new FTransform
		{
			Scale3D = Start.Scale3D,
			Translation = Start.Translation,
			Rotation = Start.Rotation
		};
		if (Start.Scale3D != End.Scale3D)
		{
			FVector scale3D = EaseVector(ENGSEasingFunc, Start.Scale3D, End.Scale3D, Alpha, Param, BlendExp, Steps);
			result.SetScale3D(scale3D);
		}
		if (Start.Translation != End.Translation)
		{
			FVector translation = EaseVector(ENGSEasingFunc, Start.Translation, End.Translation, Alpha, Param, BlendExp, Steps);
			result.SetTranslation(translation);
		}
		if (Start.Rotator() != End.Rotator())
		{
			FRotator r = EaseRotator(ENGSEasingFunc, Start.Rotator(), End.Rotator(), Alpha, Param, BlendExp, Steps);
			result.SetRotation(new FQuat(r));
		}
		return result;
	}

	[BlueprintCallable]
	[UFunction]
	[Category("EaseFunc")]
	[USharpPath("/Script/b1-Managed.GSEaseFunc:BackEaseIn")]
	public static float BackEaseIn(float Start, float End, float Alpha, float Param = 1.70158f)
	{
		return End * Alpha * Alpha * ((Param + 1f) * Alpha - Param) + Start;
	}

	[UFunction]
	[Category("EaseFunc")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSEaseFunc:BackEaseOut")]
	public static float BackEaseOut(float Start, float End, float Alpha, float Param = 1.70158f)
	{
		return End * ((Alpha -= 1f) * Alpha * ((Param + 1f) * Alpha + Param) + 1f) + Start;
	}

	[Category("EaseFunc")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSEaseFunc:BackEaseInOut")]
	public static float BackEaseInOut(float Start, float End, float Alpha, float Param = 1.70158f)
	{
		if ((Alpha *= 2f) < 1f)
		{
			return End / 2f * (Alpha * Alpha * (((Param *= 1.525f) + 1f) * Alpha - Param)) + Start;
		}
		return End / 2f * ((Alpha -= 2f) * Alpha * (((Param *= 1.525f) + 1f) * Alpha + Param) + 2f) + Start;
	}

	[UFunction]
	[Category("EaseFunc")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSEaseFunc:Sin")]
	public static float Sin(float Start, float End, float Alpha, float Param = 1f)
	{
		return (float)((double)End * Math.Sin((double)Alpha * Math.PI * (double)Param) + (double)Start);
	}

	[Category("EaseFunc")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSEaseFunc:EaseInQuart")]
	public static float EaseInQuart(float Start, float End, float Alpha, float Param = 2f)
	{
		return (float)Math.Pow(Alpha, Param) * End + Start;
	}

	[Category("EaseFunc")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSEaseFunc:EaseInOutQuint")]
	public static float EaseInOutQuint(float Start, float End, float Alpha, float Param = 2f)
	{
		return (float)(((double)Alpha < 0.5) ? (16.0 * Math.Pow(Alpha, 5.0)) : (1.0 - Math.Pow(-2f * Alpha + 2f, 5.0) / 2.0));
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEaseFunc:Sin")]
	private static void Sin__Invoker(IntPtr buffer, IntPtr obj)
	{
		float start = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, Sin_Start_Offset));
		float end = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, Sin_End_Offset));
		float alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, Sin_Alpha_Offset));
		float param = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, Sin_Param_Offset));
		float value = Sin(start, end, alpha, param);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, Sin_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEaseFunc:Ease")]
	private static void Ease__Invoker(IntPtr buffer, IntPtr obj)
	{
		ENGSEasingFunc eNGSEasingFunc = EnumMarshaler<ENGSEasingFunc>.FromNative(IntPtr.Add(buffer, Ease_ENGSEasingFunc_Offset), 0, Ease_ENGSEasingFunc_PropertyAddress.Address);
		float start = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, Ease_Start_Offset));
		float end = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, Ease_End_Offset));
		float alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, Ease_Alpha_Offset));
		float param = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, Ease_Param_Offset));
		float blendExp = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, Ease_BlendExp_Offset));
		int steps = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, Ease_Steps_Offset));
		float value = Ease(eNGSEasingFunc, start, end, alpha, param, blendExp, steps);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, Ease_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEaseFunc:EaseColor")]
	private static void EaseColor__Invoker(IntPtr buffer, IntPtr obj)
	{
		ENGSEasingFunc eNGSEasingFunc = EnumMarshaler<ENGSEasingFunc>.FromNative(IntPtr.Add(buffer, EaseColor_ENGSEasingFunc_Offset), 0, EaseColor_ENGSEasingFunc_PropertyAddress.Address);
		FColor start = BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(buffer, EaseColor_Start_Offset));
		FColor end = BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(buffer, EaseColor_End_Offset));
		float alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, EaseColor_Alpha_Offset));
		float param = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, EaseColor_Param_Offset));
		float blendExp = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, EaseColor_BlendExp_Offset));
		int steps = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, EaseColor_Steps_Offset));
		FColor value = EaseColor(eNGSEasingFunc, start, end, alpha, param, blendExp, steps);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(buffer, EaseColor_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEaseFunc:EaseVector")]
	private static void EaseVector__Invoker(IntPtr buffer, IntPtr obj)
	{
		ENGSEasingFunc eNGSEasingFunc = EnumMarshaler<ENGSEasingFunc>.FromNative(IntPtr.Add(buffer, EaseVector_ENGSEasingFunc_Offset), 0, EaseVector_ENGSEasingFunc_PropertyAddress.Address);
		FVector start = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, EaseVector_Start_Offset));
		FVector end = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, EaseVector_End_Offset));
		float alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, EaseVector_Alpha_Offset));
		float param = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, EaseVector_Param_Offset));
		float blendExp = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, EaseVector_BlendExp_Offset));
		int steps = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, EaseVector_Steps_Offset));
		FVector value = EaseVector(eNGSEasingFunc, start, end, alpha, param, blendExp, steps);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(buffer, EaseVector_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEaseFunc:BackEaseIn")]
	private static void BackEaseIn__Invoker(IntPtr buffer, IntPtr obj)
	{
		float start = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BackEaseIn_Start_Offset));
		float end = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BackEaseIn_End_Offset));
		float alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BackEaseIn_Alpha_Offset));
		float param = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BackEaseIn_Param_Offset));
		float value = BackEaseIn(start, end, alpha, param);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, BackEaseIn_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEaseFunc:EaseRotator")]
	private static void EaseRotator__Invoker(IntPtr buffer, IntPtr obj)
	{
		ENGSEasingFunc eNGSEasingFunc = EnumMarshaler<ENGSEasingFunc>.FromNative(IntPtr.Add(buffer, EaseRotator_ENGSEasingFunc_Offset), 0, EaseRotator_ENGSEasingFunc_PropertyAddress.Address);
		FRotator start = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(buffer, EaseRotator_Start_Offset));
		FRotator end = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(buffer, EaseRotator_End_Offset));
		float alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, EaseRotator_Alpha_Offset));
		float param = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, EaseRotator_Param_Offset));
		float blendExp = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, EaseRotator_BlendExp_Offset));
		int steps = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, EaseRotator_Steps_Offset));
		FRotator value = EaseRotator(eNGSEasingFunc, start, end, alpha, param, blendExp, steps);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(buffer, EaseRotator_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEaseFunc:BackEaseOut")]
	private static void BackEaseOut__Invoker(IntPtr buffer, IntPtr obj)
	{
		float start = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BackEaseOut_Start_Offset));
		float end = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BackEaseOut_End_Offset));
		float alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BackEaseOut_Alpha_Offset));
		float param = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BackEaseOut_Param_Offset));
		float value = BackEaseOut(start, end, alpha, param);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, BackEaseOut_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEaseFunc:EaseInQuart")]
	private static void EaseInQuart__Invoker(IntPtr buffer, IntPtr obj)
	{
		float start = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, EaseInQuart_Start_Offset));
		float end = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, EaseInQuart_End_Offset));
		float alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, EaseInQuart_Alpha_Offset));
		float param = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, EaseInQuart_Param_Offset));
		float value = EaseInQuart(start, end, alpha, param);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, EaseInQuart_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEaseFunc:EaseTransform")]
	private static void EaseTransform__Invoker(IntPtr buffer, IntPtr obj)
	{
		ENGSEasingFunc eNGSEasingFunc = EnumMarshaler<ENGSEasingFunc>.FromNative(IntPtr.Add(buffer, EaseTransform_ENGSEasingFunc_Offset), 0, EaseTransform_ENGSEasingFunc_PropertyAddress.Address);
		FTransform start = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, EaseTransform_Start_Offset));
		FTransform end = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, EaseTransform_End_Offset));
		float alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, EaseTransform_Alpha_Offset));
		float param = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, EaseTransform_Param_Offset));
		float blendExp = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, EaseTransform_BlendExp_Offset));
		int steps = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, EaseTransform_Steps_Offset));
		FTransform value = EaseTransform(eNGSEasingFunc, start, end, alpha, param, blendExp, steps);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(buffer, EaseTransform_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEaseFunc:BackEaseInOut")]
	private static void BackEaseInOut__Invoker(IntPtr buffer, IntPtr obj)
	{
		float start = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BackEaseInOut_Start_Offset));
		float end = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BackEaseInOut_End_Offset));
		float alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BackEaseInOut_Alpha_Offset));
		float param = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BackEaseInOut_Param_Offset));
		float value = BackEaseInOut(start, end, alpha, param);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, BackEaseInOut_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEaseFunc:EaseInOutQuint")]
	private static void EaseInOutQuint__Invoker(IntPtr buffer, IntPtr obj)
	{
		float start = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, EaseInOutQuint_Start_Offset));
		float end = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, EaseInOutQuint_End_Offset));
		float alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, EaseInOutQuint_Alpha_Offset));
		float param = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, EaseInOutQuint_Param_Offset));
		float value = EaseInOutQuint(start, end, alpha, param);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, EaseInOutQuint_ReturnValue_Offset), value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.GSEaseFunc");
		Sin_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Sin");
		Sin_ParamsSize = NativeReflection.GetFunctionParamsSize(Sin_FunctionAddress);
		Sin_Start_Offset = NativeReflection.GetPropertyOffset(Sin_FunctionAddress, "Start");
		Sin_Start_IsValid = NativeReflection.ValidatePropertyClass(Sin_FunctionAddress, "Start", Classes.FFloatProperty);
		Sin_End_Offset = NativeReflection.GetPropertyOffset(Sin_FunctionAddress, "End");
		Sin_End_IsValid = NativeReflection.ValidatePropertyClass(Sin_FunctionAddress, "End", Classes.FFloatProperty);
		Sin_Alpha_Offset = NativeReflection.GetPropertyOffset(Sin_FunctionAddress, "Alpha");
		Sin_Alpha_IsValid = NativeReflection.ValidatePropertyClass(Sin_FunctionAddress, "Alpha", Classes.FFloatProperty);
		Sin_Param_Offset = NativeReflection.GetPropertyOffset(Sin_FunctionAddress, "Param");
		Sin_Param_IsValid = NativeReflection.ValidatePropertyClass(Sin_FunctionAddress, "Param", Classes.FFloatProperty);
		Sin_ReturnValue_Offset = NativeReflection.GetPropertyOffset(Sin_FunctionAddress, "ReturnValue");
		Sin_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(Sin_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		Sin_IsValid = Sin_FunctionAddress != IntPtr.Zero && Sin_Start_IsValid && Sin_End_IsValid && Sin_Alpha_IsValid && Sin_Param_IsValid && Sin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEaseFunc:Sin", Sin_IsValid);
		Ease_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Ease");
		Ease_ParamsSize = NativeReflection.GetFunctionParamsSize(Ease_FunctionAddress);
		NativeReflection.GetPropertyRef(ref Ease_ENGSEasingFunc_PropertyAddress, Ease_FunctionAddress, "ENGSEasingFunc");
		Ease_ENGSEasingFunc_Offset = NativeReflection.GetPropertyOffset(Ease_FunctionAddress, "ENGSEasingFunc");
		Ease_ENGSEasingFunc_IsValid = NativeReflection.ValidatePropertyClass(Ease_FunctionAddress, "ENGSEasingFunc", Classes.FEnumProperty);
		Ease_Start_Offset = NativeReflection.GetPropertyOffset(Ease_FunctionAddress, "Start");
		Ease_Start_IsValid = NativeReflection.ValidatePropertyClass(Ease_FunctionAddress, "Start", Classes.FFloatProperty);
		Ease_End_Offset = NativeReflection.GetPropertyOffset(Ease_FunctionAddress, "End");
		Ease_End_IsValid = NativeReflection.ValidatePropertyClass(Ease_FunctionAddress, "End", Classes.FFloatProperty);
		Ease_Alpha_Offset = NativeReflection.GetPropertyOffset(Ease_FunctionAddress, "Alpha");
		Ease_Alpha_IsValid = NativeReflection.ValidatePropertyClass(Ease_FunctionAddress, "Alpha", Classes.FFloatProperty);
		Ease_Param_Offset = NativeReflection.GetPropertyOffset(Ease_FunctionAddress, "Param");
		Ease_Param_IsValid = NativeReflection.ValidatePropertyClass(Ease_FunctionAddress, "Param", Classes.FFloatProperty);
		Ease_BlendExp_Offset = NativeReflection.GetPropertyOffset(Ease_FunctionAddress, "BlendExp");
		Ease_BlendExp_IsValid = NativeReflection.ValidatePropertyClass(Ease_FunctionAddress, "BlendExp", Classes.FFloatProperty);
		Ease_Steps_Offset = NativeReflection.GetPropertyOffset(Ease_FunctionAddress, "Steps");
		Ease_Steps_IsValid = NativeReflection.ValidatePropertyClass(Ease_FunctionAddress, "Steps", Classes.FIntProperty);
		Ease_ReturnValue_Offset = NativeReflection.GetPropertyOffset(Ease_FunctionAddress, "ReturnValue");
		Ease_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(Ease_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		Ease_IsValid = Ease_FunctionAddress != IntPtr.Zero && Ease_ENGSEasingFunc_IsValid && Ease_Start_IsValid && Ease_End_IsValid && Ease_Alpha_IsValid && Ease_Param_IsValid && Ease_BlendExp_IsValid && Ease_Steps_IsValid && Ease_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEaseFunc:Ease", Ease_IsValid);
		EaseColor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EaseColor");
		EaseColor_ParamsSize = NativeReflection.GetFunctionParamsSize(EaseColor_FunctionAddress);
		NativeReflection.GetPropertyRef(ref EaseColor_ENGSEasingFunc_PropertyAddress, EaseColor_FunctionAddress, "ENGSEasingFunc");
		EaseColor_ENGSEasingFunc_Offset = NativeReflection.GetPropertyOffset(EaseColor_FunctionAddress, "ENGSEasingFunc");
		EaseColor_ENGSEasingFunc_IsValid = NativeReflection.ValidatePropertyClass(EaseColor_FunctionAddress, "ENGSEasingFunc", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref EaseColor_Start_PropertyAddress, EaseColor_FunctionAddress, "Start");
		EaseColor_Start_Offset = NativeReflection.GetPropertyOffset(EaseColor_FunctionAddress, "Start");
		EaseColor_Start_IsValid = NativeReflection.ValidatePropertyClass(EaseColor_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref EaseColor_End_PropertyAddress, EaseColor_FunctionAddress, "End");
		EaseColor_End_Offset = NativeReflection.GetPropertyOffset(EaseColor_FunctionAddress, "End");
		EaseColor_End_IsValid = NativeReflection.ValidatePropertyClass(EaseColor_FunctionAddress, "End", Classes.FStructProperty);
		EaseColor_Alpha_Offset = NativeReflection.GetPropertyOffset(EaseColor_FunctionAddress, "Alpha");
		EaseColor_Alpha_IsValid = NativeReflection.ValidatePropertyClass(EaseColor_FunctionAddress, "Alpha", Classes.FFloatProperty);
		EaseColor_Param_Offset = NativeReflection.GetPropertyOffset(EaseColor_FunctionAddress, "Param");
		EaseColor_Param_IsValid = NativeReflection.ValidatePropertyClass(EaseColor_FunctionAddress, "Param", Classes.FFloatProperty);
		EaseColor_BlendExp_Offset = NativeReflection.GetPropertyOffset(EaseColor_FunctionAddress, "BlendExp");
		EaseColor_BlendExp_IsValid = NativeReflection.ValidatePropertyClass(EaseColor_FunctionAddress, "BlendExp", Classes.FFloatProperty);
		EaseColor_Steps_Offset = NativeReflection.GetPropertyOffset(EaseColor_FunctionAddress, "Steps");
		EaseColor_Steps_IsValid = NativeReflection.ValidatePropertyClass(EaseColor_FunctionAddress, "Steps", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref EaseColor_ReturnValue_PropertyAddress, EaseColor_FunctionAddress, "ReturnValue");
		EaseColor_ReturnValue_Offset = NativeReflection.GetPropertyOffset(EaseColor_FunctionAddress, "ReturnValue");
		EaseColor_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(EaseColor_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		EaseColor_IsValid = EaseColor_FunctionAddress != IntPtr.Zero && EaseColor_ENGSEasingFunc_IsValid && EaseColor_Start_IsValid && EaseColor_End_IsValid && EaseColor_Alpha_IsValid && EaseColor_Param_IsValid && EaseColor_BlendExp_IsValid && EaseColor_Steps_IsValid && EaseColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEaseFunc:EaseColor", EaseColor_IsValid);
		EaseVector_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EaseVector");
		EaseVector_ParamsSize = NativeReflection.GetFunctionParamsSize(EaseVector_FunctionAddress);
		NativeReflection.GetPropertyRef(ref EaseVector_ENGSEasingFunc_PropertyAddress, EaseVector_FunctionAddress, "ENGSEasingFunc");
		EaseVector_ENGSEasingFunc_Offset = NativeReflection.GetPropertyOffset(EaseVector_FunctionAddress, "ENGSEasingFunc");
		EaseVector_ENGSEasingFunc_IsValid = NativeReflection.ValidatePropertyClass(EaseVector_FunctionAddress, "ENGSEasingFunc", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref EaseVector_Start_PropertyAddress, EaseVector_FunctionAddress, "Start");
		EaseVector_Start_Offset = NativeReflection.GetPropertyOffset(EaseVector_FunctionAddress, "Start");
		EaseVector_Start_IsValid = NativeReflection.ValidatePropertyClass(EaseVector_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref EaseVector_End_PropertyAddress, EaseVector_FunctionAddress, "End");
		EaseVector_End_Offset = NativeReflection.GetPropertyOffset(EaseVector_FunctionAddress, "End");
		EaseVector_End_IsValid = NativeReflection.ValidatePropertyClass(EaseVector_FunctionAddress, "End", Classes.FStructProperty);
		EaseVector_Alpha_Offset = NativeReflection.GetPropertyOffset(EaseVector_FunctionAddress, "Alpha");
		EaseVector_Alpha_IsValid = NativeReflection.ValidatePropertyClass(EaseVector_FunctionAddress, "Alpha", Classes.FFloatProperty);
		EaseVector_Param_Offset = NativeReflection.GetPropertyOffset(EaseVector_FunctionAddress, "Param");
		EaseVector_Param_IsValid = NativeReflection.ValidatePropertyClass(EaseVector_FunctionAddress, "Param", Classes.FFloatProperty);
		EaseVector_BlendExp_Offset = NativeReflection.GetPropertyOffset(EaseVector_FunctionAddress, "BlendExp");
		EaseVector_BlendExp_IsValid = NativeReflection.ValidatePropertyClass(EaseVector_FunctionAddress, "BlendExp", Classes.FFloatProperty);
		EaseVector_Steps_Offset = NativeReflection.GetPropertyOffset(EaseVector_FunctionAddress, "Steps");
		EaseVector_Steps_IsValid = NativeReflection.ValidatePropertyClass(EaseVector_FunctionAddress, "Steps", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref EaseVector_ReturnValue_PropertyAddress, EaseVector_FunctionAddress, "ReturnValue");
		EaseVector_ReturnValue_Offset = NativeReflection.GetPropertyOffset(EaseVector_FunctionAddress, "ReturnValue");
		EaseVector_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(EaseVector_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		EaseVector_IsValid = EaseVector_FunctionAddress != IntPtr.Zero && EaseVector_ENGSEasingFunc_IsValid && EaseVector_Start_IsValid && EaseVector_End_IsValid && EaseVector_Alpha_IsValid && EaseVector_Param_IsValid && EaseVector_BlendExp_IsValid && EaseVector_Steps_IsValid && EaseVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEaseFunc:EaseVector", EaseVector_IsValid);
		BackEaseIn_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BackEaseIn");
		BackEaseIn_ParamsSize = NativeReflection.GetFunctionParamsSize(BackEaseIn_FunctionAddress);
		BackEaseIn_Start_Offset = NativeReflection.GetPropertyOffset(BackEaseIn_FunctionAddress, "Start");
		BackEaseIn_Start_IsValid = NativeReflection.ValidatePropertyClass(BackEaseIn_FunctionAddress, "Start", Classes.FFloatProperty);
		BackEaseIn_End_Offset = NativeReflection.GetPropertyOffset(BackEaseIn_FunctionAddress, "End");
		BackEaseIn_End_IsValid = NativeReflection.ValidatePropertyClass(BackEaseIn_FunctionAddress, "End", Classes.FFloatProperty);
		BackEaseIn_Alpha_Offset = NativeReflection.GetPropertyOffset(BackEaseIn_FunctionAddress, "Alpha");
		BackEaseIn_Alpha_IsValid = NativeReflection.ValidatePropertyClass(BackEaseIn_FunctionAddress, "Alpha", Classes.FFloatProperty);
		BackEaseIn_Param_Offset = NativeReflection.GetPropertyOffset(BackEaseIn_FunctionAddress, "Param");
		BackEaseIn_Param_IsValid = NativeReflection.ValidatePropertyClass(BackEaseIn_FunctionAddress, "Param", Classes.FFloatProperty);
		BackEaseIn_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BackEaseIn_FunctionAddress, "ReturnValue");
		BackEaseIn_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BackEaseIn_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		BackEaseIn_IsValid = BackEaseIn_FunctionAddress != IntPtr.Zero && BackEaseIn_Start_IsValid && BackEaseIn_End_IsValid && BackEaseIn_Alpha_IsValid && BackEaseIn_Param_IsValid && BackEaseIn_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEaseFunc:BackEaseIn", BackEaseIn_IsValid);
		EaseRotator_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EaseRotator");
		EaseRotator_ParamsSize = NativeReflection.GetFunctionParamsSize(EaseRotator_FunctionAddress);
		NativeReflection.GetPropertyRef(ref EaseRotator_ENGSEasingFunc_PropertyAddress, EaseRotator_FunctionAddress, "ENGSEasingFunc");
		EaseRotator_ENGSEasingFunc_Offset = NativeReflection.GetPropertyOffset(EaseRotator_FunctionAddress, "ENGSEasingFunc");
		EaseRotator_ENGSEasingFunc_IsValid = NativeReflection.ValidatePropertyClass(EaseRotator_FunctionAddress, "ENGSEasingFunc", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref EaseRotator_Start_PropertyAddress, EaseRotator_FunctionAddress, "Start");
		EaseRotator_Start_Offset = NativeReflection.GetPropertyOffset(EaseRotator_FunctionAddress, "Start");
		EaseRotator_Start_IsValid = NativeReflection.ValidatePropertyClass(EaseRotator_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref EaseRotator_End_PropertyAddress, EaseRotator_FunctionAddress, "End");
		EaseRotator_End_Offset = NativeReflection.GetPropertyOffset(EaseRotator_FunctionAddress, "End");
		EaseRotator_End_IsValid = NativeReflection.ValidatePropertyClass(EaseRotator_FunctionAddress, "End", Classes.FStructProperty);
		EaseRotator_Alpha_Offset = NativeReflection.GetPropertyOffset(EaseRotator_FunctionAddress, "Alpha");
		EaseRotator_Alpha_IsValid = NativeReflection.ValidatePropertyClass(EaseRotator_FunctionAddress, "Alpha", Classes.FFloatProperty);
		EaseRotator_Param_Offset = NativeReflection.GetPropertyOffset(EaseRotator_FunctionAddress, "Param");
		EaseRotator_Param_IsValid = NativeReflection.ValidatePropertyClass(EaseRotator_FunctionAddress, "Param", Classes.FFloatProperty);
		EaseRotator_BlendExp_Offset = NativeReflection.GetPropertyOffset(EaseRotator_FunctionAddress, "BlendExp");
		EaseRotator_BlendExp_IsValid = NativeReflection.ValidatePropertyClass(EaseRotator_FunctionAddress, "BlendExp", Classes.FFloatProperty);
		EaseRotator_Steps_Offset = NativeReflection.GetPropertyOffset(EaseRotator_FunctionAddress, "Steps");
		EaseRotator_Steps_IsValid = NativeReflection.ValidatePropertyClass(EaseRotator_FunctionAddress, "Steps", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref EaseRotator_ReturnValue_PropertyAddress, EaseRotator_FunctionAddress, "ReturnValue");
		EaseRotator_ReturnValue_Offset = NativeReflection.GetPropertyOffset(EaseRotator_FunctionAddress, "ReturnValue");
		EaseRotator_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(EaseRotator_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		EaseRotator_IsValid = EaseRotator_FunctionAddress != IntPtr.Zero && EaseRotator_ENGSEasingFunc_IsValid && EaseRotator_Start_IsValid && EaseRotator_End_IsValid && EaseRotator_Alpha_IsValid && EaseRotator_Param_IsValid && EaseRotator_BlendExp_IsValid && EaseRotator_Steps_IsValid && EaseRotator_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEaseFunc:EaseRotator", EaseRotator_IsValid);
		BackEaseOut_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BackEaseOut");
		BackEaseOut_ParamsSize = NativeReflection.GetFunctionParamsSize(BackEaseOut_FunctionAddress);
		BackEaseOut_Start_Offset = NativeReflection.GetPropertyOffset(BackEaseOut_FunctionAddress, "Start");
		BackEaseOut_Start_IsValid = NativeReflection.ValidatePropertyClass(BackEaseOut_FunctionAddress, "Start", Classes.FFloatProperty);
		BackEaseOut_End_Offset = NativeReflection.GetPropertyOffset(BackEaseOut_FunctionAddress, "End");
		BackEaseOut_End_IsValid = NativeReflection.ValidatePropertyClass(BackEaseOut_FunctionAddress, "End", Classes.FFloatProperty);
		BackEaseOut_Alpha_Offset = NativeReflection.GetPropertyOffset(BackEaseOut_FunctionAddress, "Alpha");
		BackEaseOut_Alpha_IsValid = NativeReflection.ValidatePropertyClass(BackEaseOut_FunctionAddress, "Alpha", Classes.FFloatProperty);
		BackEaseOut_Param_Offset = NativeReflection.GetPropertyOffset(BackEaseOut_FunctionAddress, "Param");
		BackEaseOut_Param_IsValid = NativeReflection.ValidatePropertyClass(BackEaseOut_FunctionAddress, "Param", Classes.FFloatProperty);
		BackEaseOut_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BackEaseOut_FunctionAddress, "ReturnValue");
		BackEaseOut_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BackEaseOut_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		BackEaseOut_IsValid = BackEaseOut_FunctionAddress != IntPtr.Zero && BackEaseOut_Start_IsValid && BackEaseOut_End_IsValid && BackEaseOut_Alpha_IsValid && BackEaseOut_Param_IsValid && BackEaseOut_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEaseFunc:BackEaseOut", BackEaseOut_IsValid);
		EaseInQuart_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EaseInQuart");
		EaseInQuart_ParamsSize = NativeReflection.GetFunctionParamsSize(EaseInQuart_FunctionAddress);
		EaseInQuart_Start_Offset = NativeReflection.GetPropertyOffset(EaseInQuart_FunctionAddress, "Start");
		EaseInQuart_Start_IsValid = NativeReflection.ValidatePropertyClass(EaseInQuart_FunctionAddress, "Start", Classes.FFloatProperty);
		EaseInQuart_End_Offset = NativeReflection.GetPropertyOffset(EaseInQuart_FunctionAddress, "End");
		EaseInQuart_End_IsValid = NativeReflection.ValidatePropertyClass(EaseInQuart_FunctionAddress, "End", Classes.FFloatProperty);
		EaseInQuart_Alpha_Offset = NativeReflection.GetPropertyOffset(EaseInQuart_FunctionAddress, "Alpha");
		EaseInQuart_Alpha_IsValid = NativeReflection.ValidatePropertyClass(EaseInQuart_FunctionAddress, "Alpha", Classes.FFloatProperty);
		EaseInQuart_Param_Offset = NativeReflection.GetPropertyOffset(EaseInQuart_FunctionAddress, "Param");
		EaseInQuart_Param_IsValid = NativeReflection.ValidatePropertyClass(EaseInQuart_FunctionAddress, "Param", Classes.FFloatProperty);
		EaseInQuart_ReturnValue_Offset = NativeReflection.GetPropertyOffset(EaseInQuart_FunctionAddress, "ReturnValue");
		EaseInQuart_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(EaseInQuart_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		EaseInQuart_IsValid = EaseInQuart_FunctionAddress != IntPtr.Zero && EaseInQuart_Start_IsValid && EaseInQuart_End_IsValid && EaseInQuart_Alpha_IsValid && EaseInQuart_Param_IsValid && EaseInQuart_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEaseFunc:EaseInQuart", EaseInQuart_IsValid);
		EaseTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EaseTransform");
		EaseTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(EaseTransform_FunctionAddress);
		NativeReflection.GetPropertyRef(ref EaseTransform_ENGSEasingFunc_PropertyAddress, EaseTransform_FunctionAddress, "ENGSEasingFunc");
		EaseTransform_ENGSEasingFunc_Offset = NativeReflection.GetPropertyOffset(EaseTransform_FunctionAddress, "ENGSEasingFunc");
		EaseTransform_ENGSEasingFunc_IsValid = NativeReflection.ValidatePropertyClass(EaseTransform_FunctionAddress, "ENGSEasingFunc", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref EaseTransform_Start_PropertyAddress, EaseTransform_FunctionAddress, "Start");
		EaseTransform_Start_Offset = NativeReflection.GetPropertyOffset(EaseTransform_FunctionAddress, "Start");
		EaseTransform_Start_IsValid = NativeReflection.ValidatePropertyClass(EaseTransform_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref EaseTransform_End_PropertyAddress, EaseTransform_FunctionAddress, "End");
		EaseTransform_End_Offset = NativeReflection.GetPropertyOffset(EaseTransform_FunctionAddress, "End");
		EaseTransform_End_IsValid = NativeReflection.ValidatePropertyClass(EaseTransform_FunctionAddress, "End", Classes.FStructProperty);
		EaseTransform_Alpha_Offset = NativeReflection.GetPropertyOffset(EaseTransform_FunctionAddress, "Alpha");
		EaseTransform_Alpha_IsValid = NativeReflection.ValidatePropertyClass(EaseTransform_FunctionAddress, "Alpha", Classes.FFloatProperty);
		EaseTransform_Param_Offset = NativeReflection.GetPropertyOffset(EaseTransform_FunctionAddress, "Param");
		EaseTransform_Param_IsValid = NativeReflection.ValidatePropertyClass(EaseTransform_FunctionAddress, "Param", Classes.FFloatProperty);
		EaseTransform_BlendExp_Offset = NativeReflection.GetPropertyOffset(EaseTransform_FunctionAddress, "BlendExp");
		EaseTransform_BlendExp_IsValid = NativeReflection.ValidatePropertyClass(EaseTransform_FunctionAddress, "BlendExp", Classes.FFloatProperty);
		EaseTransform_Steps_Offset = NativeReflection.GetPropertyOffset(EaseTransform_FunctionAddress, "Steps");
		EaseTransform_Steps_IsValid = NativeReflection.ValidatePropertyClass(EaseTransform_FunctionAddress, "Steps", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref EaseTransform_ReturnValue_PropertyAddress, EaseTransform_FunctionAddress, "ReturnValue");
		EaseTransform_ReturnValue_Offset = NativeReflection.GetPropertyOffset(EaseTransform_FunctionAddress, "ReturnValue");
		EaseTransform_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(EaseTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		EaseTransform_IsValid = EaseTransform_FunctionAddress != IntPtr.Zero && EaseTransform_ENGSEasingFunc_IsValid && EaseTransform_Start_IsValid && EaseTransform_End_IsValid && EaseTransform_Alpha_IsValid && EaseTransform_Param_IsValid && EaseTransform_BlendExp_IsValid && EaseTransform_Steps_IsValid && EaseTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEaseFunc:EaseTransform", EaseTransform_IsValid);
		BackEaseInOut_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BackEaseInOut");
		BackEaseInOut_ParamsSize = NativeReflection.GetFunctionParamsSize(BackEaseInOut_FunctionAddress);
		BackEaseInOut_Start_Offset = NativeReflection.GetPropertyOffset(BackEaseInOut_FunctionAddress, "Start");
		BackEaseInOut_Start_IsValid = NativeReflection.ValidatePropertyClass(BackEaseInOut_FunctionAddress, "Start", Classes.FFloatProperty);
		BackEaseInOut_End_Offset = NativeReflection.GetPropertyOffset(BackEaseInOut_FunctionAddress, "End");
		BackEaseInOut_End_IsValid = NativeReflection.ValidatePropertyClass(BackEaseInOut_FunctionAddress, "End", Classes.FFloatProperty);
		BackEaseInOut_Alpha_Offset = NativeReflection.GetPropertyOffset(BackEaseInOut_FunctionAddress, "Alpha");
		BackEaseInOut_Alpha_IsValid = NativeReflection.ValidatePropertyClass(BackEaseInOut_FunctionAddress, "Alpha", Classes.FFloatProperty);
		BackEaseInOut_Param_Offset = NativeReflection.GetPropertyOffset(BackEaseInOut_FunctionAddress, "Param");
		BackEaseInOut_Param_IsValid = NativeReflection.ValidatePropertyClass(BackEaseInOut_FunctionAddress, "Param", Classes.FFloatProperty);
		BackEaseInOut_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BackEaseInOut_FunctionAddress, "ReturnValue");
		BackEaseInOut_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BackEaseInOut_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		BackEaseInOut_IsValid = BackEaseInOut_FunctionAddress != IntPtr.Zero && BackEaseInOut_Start_IsValid && BackEaseInOut_End_IsValid && BackEaseInOut_Alpha_IsValid && BackEaseInOut_Param_IsValid && BackEaseInOut_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEaseFunc:BackEaseInOut", BackEaseInOut_IsValid);
		EaseInOutQuint_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EaseInOutQuint");
		EaseInOutQuint_ParamsSize = NativeReflection.GetFunctionParamsSize(EaseInOutQuint_FunctionAddress);
		EaseInOutQuint_Start_Offset = NativeReflection.GetPropertyOffset(EaseInOutQuint_FunctionAddress, "Start");
		EaseInOutQuint_Start_IsValid = NativeReflection.ValidatePropertyClass(EaseInOutQuint_FunctionAddress, "Start", Classes.FFloatProperty);
		EaseInOutQuint_End_Offset = NativeReflection.GetPropertyOffset(EaseInOutQuint_FunctionAddress, "End");
		EaseInOutQuint_End_IsValid = NativeReflection.ValidatePropertyClass(EaseInOutQuint_FunctionAddress, "End", Classes.FFloatProperty);
		EaseInOutQuint_Alpha_Offset = NativeReflection.GetPropertyOffset(EaseInOutQuint_FunctionAddress, "Alpha");
		EaseInOutQuint_Alpha_IsValid = NativeReflection.ValidatePropertyClass(EaseInOutQuint_FunctionAddress, "Alpha", Classes.FFloatProperty);
		EaseInOutQuint_Param_Offset = NativeReflection.GetPropertyOffset(EaseInOutQuint_FunctionAddress, "Param");
		EaseInOutQuint_Param_IsValid = NativeReflection.ValidatePropertyClass(EaseInOutQuint_FunctionAddress, "Param", Classes.FFloatProperty);
		EaseInOutQuint_ReturnValue_Offset = NativeReflection.GetPropertyOffset(EaseInOutQuint_FunctionAddress, "ReturnValue");
		EaseInOutQuint_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(EaseInOutQuint_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		EaseInOutQuint_IsValid = EaseInOutQuint_FunctionAddress != IntPtr.Zero && EaseInOutQuint_Start_IsValid && EaseInOutQuint_End_IsValid && EaseInOutQuint_Alpha_IsValid && EaseInOutQuint_Param_IsValid && EaseInOutQuint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEaseFunc:EaseInOutQuint", EaseInOutQuint_IsValid);
	}

	static GSEaseFunc()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSEaseFunc)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSEaseFunc));
	}
}
