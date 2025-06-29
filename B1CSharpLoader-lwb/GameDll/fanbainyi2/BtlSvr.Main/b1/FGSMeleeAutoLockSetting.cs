using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FGSMeleeAutoLockSetting")]
public struct FGSMeleeAutoLockSetting
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("自动接近触发距离")]
	[Tooltip("必须在这个范围内的单位才会选择触发自动接近")]
	[USharpPath("/Script/b1-Managed.FGSMeleeAutoLockSetting:Range")]
	public float Range;

	[Tooltip("双边角度，最大360")]
	[DisplayName("自动接近触发角度")]
	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MDProp.ClampMax, "360")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSMeleeAutoLockSetting:AngleMax")]
	public float AngleMax;

	[BlueprintReadWrite]
	[DisplayName("自动接近转向速度")]
	[UMeta(MDProp.ClampMin, "0")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSMeleeAutoLockSetting:TurnSpeed")]
	public float TurnSpeed;

	[Tooltip("在已经有自动接近的目标下，会更优先考虑这个单位")]
	[DisplayName("自动接近重选其他单位容忍距离")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSMeleeAutoLockSetting:PreferActorDistTolerance")]
	public float PreferActorDistTolerance;

	public float DistScoreRating;

	public float HeightScoreRating;

	public float AngleScoreRating;

	public float Z_Limit;

	public float PelvisExtraScore;

	public bool AutoLockPreferPelvis;

	private static int FGSMeleeAutoLockSetting_StructSize;

	private static int FGSMeleeAutoLockSetting_IsValid;

	private static bool Range_IsValid;

	private static int Range_Offset;

	private static bool AngleMax_IsValid;

	private static int AngleMax_Offset;

	private static bool TurnSpeed_IsValid;

	private static int TurnSpeed_Offset;

	private static bool PreferActorDistTolerance_IsValid;

	private static int PreferActorDistTolerance_Offset;

	public FGSMeleeAutoLockSetting(FGSMeleeAutoLockSetting Other)
	{
		Range = Other.Range;
		AngleMax = Other.AngleMax;
		TurnSpeed = Other.TurnSpeed;
		PreferActorDistTolerance = Other.PreferActorDistTolerance;
		DistScoreRating = Other.DistScoreRating;
		HeightScoreRating = Other.HeightScoreRating;
		AngleScoreRating = Other.AngleScoreRating;
		Z_Limit = Other.Z_Limit;
		AutoLockPreferPelvis = Other.AutoLockPreferPelvis;
		PelvisExtraScore = Other.PelvisExtraScore;
	}

	public FGSMeleeAutoLockSetting(float _Range, float _AngleMax, float _TurnSpeed, float _PreferActorDistTolerance, float _DistScoreRating, float _HeightScoreRating, float _AngleScoreRating, float _Z_Limit, float _PelvisExtraScore, bool _AutoLockPreferPelvis)
	{
		Range = _Range;
		AngleMax = _AngleMax;
		TurnSpeed = _TurnSpeed;
		PreferActorDistTolerance = _PreferActorDistTolerance;
		DistScoreRating = _DistScoreRating;
		HeightScoreRating = _HeightScoreRating;
		AngleScoreRating = _AngleScoreRating;
		Z_Limit = _Z_Limit;
		AutoLockPreferPelvis = _AutoLockPreferPelvis;
		PelvisExtraScore = _PelvisExtraScore;
	}

	public FGSMeleeAutoLockSetting Copy()
	{
		return this;
	}

	public static FGSMeleeAutoLockSetting FromNative(IntPtr nativeBuffer)
	{
		return new FGSMeleeAutoLockSetting(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSMeleeAutoLockSetting value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSMeleeAutoLockSetting FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSMeleeAutoLockSetting(IntPtr.Add(nativeBuffer, arrayIndex * FGSMeleeAutoLockSetting_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSMeleeAutoLockSetting value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSMeleeAutoLockSetting_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSMeleeAutoLockSetting_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSMeleeAutoLockSetting");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Range_Offset), Range);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AngleMax_Offset), AngleMax);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TurnSpeed_Offset), TurnSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PreferActorDistTolerance_Offset), PreferActorDistTolerance);
	}

	public FGSMeleeAutoLockSetting(IntPtr nativeStruct)
	{
		if (FGSMeleeAutoLockSetting_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSMeleeAutoLockSetting");
			Range = 0f;
			AngleMax = 0f;
			TurnSpeed = 0f;
			PreferActorDistTolerance = 0f;
		}
		else
		{
			Range = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Range_Offset));
			AngleMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AngleMax_Offset));
			TurnSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TurnSpeed_Offset));
			PreferActorDistTolerance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PreferActorDistTolerance_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSMeleeAutoLockSetting");
		FGSMeleeAutoLockSetting_StructSize = NativeReflection.GetStructSize(intPtr);
		Range_Offset = NativeReflection.GetPropertyOffset(intPtr, "Range");
		Range_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Range", Classes.FFloatProperty);
		AngleMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "AngleMax");
		AngleMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AngleMax", Classes.FFloatProperty);
		TurnSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "TurnSpeed");
		TurnSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TurnSpeed", Classes.FFloatProperty);
		PreferActorDistTolerance_Offset = NativeReflection.GetPropertyOffset(intPtr, "PreferActorDistTolerance");
		PreferActorDistTolerance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PreferActorDistTolerance", Classes.FFloatProperty);
		FGSMeleeAutoLockSetting_IsValid = ((intPtr != IntPtr.Zero && Range_IsValid && AngleMax_IsValid && TurnSpeed_IsValid && PreferActorDistTolerance_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSMeleeAutoLockSetting", (byte)FGSMeleeAutoLockSetting_IsValid != 0);
	}

	static FGSMeleeAutoLockSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSMeleeAutoLockSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSMeleeAutoLockSetting));
	}
}
