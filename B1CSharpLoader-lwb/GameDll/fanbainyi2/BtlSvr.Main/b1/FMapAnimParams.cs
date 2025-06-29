using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.MapAnimParams")]
public struct FMapAnimParams
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("表演计算上限")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MapAnimParams:AnimCountLimit")]
	public int AnimCountLimit;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("动画最小时长")]
	[USharpPath("/Script/b1-Managed.MapAnimParams:AnimMinTime")]
	public float AnimMinTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("动画最大时长")]
	[USharpPath("/Script/b1-Managed.MapAnimParams:AnimMaxTime")]
	public float AnimMaxTime;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("时长EaseFunc参数")]
	[USharpPath("/Script/b1-Managed.MapAnimParams:TimeEaseFuncParams")]
	public FEaseFuncParams TimeEaseFuncParams;

	[EditAnywhere]
	[DisplayName("动画EaseFunc参数")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MapAnimParams:EaseFuncParams")]
	public FEaseFuncParams EaseFuncParams;

	private static int MapAnimParams_StructSize;

	private static int MapAnimParams_IsValid;

	private static bool AnimCountLimit_IsValid;

	private static int AnimCountLimit_Offset;

	private static bool AnimMinTime_IsValid;

	private static int AnimMinTime_Offset;

	private static bool AnimMaxTime_IsValid;

	private static int AnimMaxTime_Offset;

	private static bool TimeEaseFuncParams_IsValid;

	private static int TimeEaseFuncParams_Offset;

	private static bool EaseFuncParams_IsValid;

	private static int EaseFuncParams_Offset;

	public FMapAnimParams(int InAnimCountLimit = 10, float InAnimMinTime = 0.03f, float InAnimMaxTime = 0.6f)
	{
		AnimCountLimit = InAnimCountLimit;
		AnimMinTime = InAnimMinTime;
		AnimMaxTime = InAnimMaxTime;
		TimeEaseFuncParams = default(FEaseFuncParams);
		EaseFuncParams = default(FEaseFuncParams);
	}

	public FMapAnimParams Copy()
	{
		return this;
	}

	public static FMapAnimParams FromNative(IntPtr nativeBuffer)
	{
		return new FMapAnimParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMapAnimParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMapAnimParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMapAnimParams(IntPtr.Add(nativeBuffer, arrayIndex * MapAnimParams_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMapAnimParams value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MapAnimParams_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MapAnimParams_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MapAnimParams");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, AnimCountLimit_Offset), AnimCountLimit);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AnimMinTime_Offset), AnimMinTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AnimMaxTime_Offset), AnimMaxTime);
		FEaseFuncParams.ToNative(IntPtr.Add(nativeStruct, TimeEaseFuncParams_Offset), TimeEaseFuncParams);
		FEaseFuncParams.ToNative(IntPtr.Add(nativeStruct, EaseFuncParams_Offset), EaseFuncParams);
	}

	public FMapAnimParams(IntPtr nativeStruct)
	{
		if (MapAnimParams_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MapAnimParams");
			AnimCountLimit = 0;
			AnimMinTime = 0f;
			AnimMaxTime = 0f;
			TimeEaseFuncParams = default(FEaseFuncParams);
			EaseFuncParams = default(FEaseFuncParams);
		}
		else
		{
			AnimCountLimit = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, AnimCountLimit_Offset));
			AnimMinTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AnimMinTime_Offset));
			AnimMaxTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AnimMaxTime_Offset));
			TimeEaseFuncParams = FEaseFuncParams.FromNative(IntPtr.Add(nativeStruct, TimeEaseFuncParams_Offset));
			EaseFuncParams = FEaseFuncParams.FromNative(IntPtr.Add(nativeStruct, EaseFuncParams_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MapAnimParams");
		MapAnimParams_StructSize = NativeReflection.GetStructSize(intPtr);
		AnimCountLimit_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimCountLimit");
		AnimCountLimit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimCountLimit", Classes.FIntProperty);
		AnimMinTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimMinTime");
		AnimMinTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimMinTime", Classes.FFloatProperty);
		AnimMaxTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimMaxTime");
		AnimMaxTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimMaxTime", Classes.FFloatProperty);
		TimeEaseFuncParams_Offset = NativeReflection.GetPropertyOffset(intPtr, "TimeEaseFuncParams");
		TimeEaseFuncParams_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TimeEaseFuncParams", Classes.FStructProperty);
		EaseFuncParams_Offset = NativeReflection.GetPropertyOffset(intPtr, "EaseFuncParams");
		EaseFuncParams_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EaseFuncParams", Classes.FStructProperty);
		MapAnimParams_IsValid = ((intPtr != IntPtr.Zero && AnimCountLimit_IsValid && AnimMinTime_IsValid && AnimMaxTime_IsValid && TimeEaseFuncParams_IsValid && EaseFuncParams_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MapAnimParams", (byte)MapAnimParams_IsValid != 0);
	}

	static FMapAnimParams()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FMapAnimParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMapAnimParams));
	}
}
