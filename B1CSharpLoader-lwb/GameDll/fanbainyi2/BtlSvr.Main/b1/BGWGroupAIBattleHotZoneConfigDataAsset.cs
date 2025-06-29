using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset")]
public class BGWGroupAIBattleHotZoneConfigDataAsset : UBGWDataAsset
{
	private static bool BattleCirclePointRingNum_IsValid;

	private static int BattleCirclePointRingNum_Offset;

	private static bool BattleCirclePointAngleInterval_IsValid;

	private static int BattleCirclePointAngleInterval_Offset;

	private static bool MeleeAttackCircleCustomInfo_IsValid;

	private static int MeleeAttackCircleCustomInfo_Offset;

	private static bool ShortBattleCircleCustomInfo_IsValid;

	private static int ShortBattleCircleCustomInfo_Offset;

	private static bool RangeAttackCircleCustomInfo_IsValid;

	private static int RangeAttackCircleCustomInfo_Offset;

	private static bool MiddleBattleCircleCustomInfo_IsValid;

	private static int MiddleBattleCircleCustomInfo_Offset;

	private static bool LongBattleCircleCustomInfo_IsValid;

	private static int LongBattleCircleCustomInfo_Offset;

	private static bool ShortBattleCircleRadius_IsValid;

	private static int ShortBattleCircleRadius_Offset;

	private static bool MiddleBattleCircleRadius_IsValid;

	private static int MiddleBattleCircleRadius_Offset;

	private static bool LongBattleCircleRadius_IsValid;

	private static int LongBattleCircleRadius_Offset;

	private static bool MeleeAttackHotZoneInnerRadius_IsValid;

	private static int MeleeAttackHotZoneInnerRadius_Offset;

	private static bool MeleeAttackHotZoneOneSideAngle_IsValid;

	private static int MeleeAttackHotZoneOneSideAngle_Offset;

	private static bool RangeAttackHotZoneOneSideAngle_IsValid;

	private static int RangeAttackHotZoneOneSideAngle_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("HotZonePointConfig|Default")]
	[DisplayName("站点圈点环数")]
	[Tooltip("决定一个区域内有几环点")]
	[UMeta(MDProp.ClampMin, 0)]
	[USharpPath("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:BattleCirclePointRingNum")]
	public int BattleCirclePointRingNum
	{
		get
		{
			CheckDestroyed();
			if (!BattleCirclePointRingNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:BattleCirclePointRingNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BattleCirclePointRingNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BattleCirclePointRingNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:BattleCirclePointRingNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BattleCirclePointRingNum_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, 0)]
	[Tooltip("单位：°；决定一环点的密度")]
	[UMeta(MDProp.ClampMax, 360)]
	[Category("HotZonePointConfig|Default")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("站点圈角度间隔")]
	[USharpPath("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:BattleCirclePointAngleInterval")]
	public int BattleCirclePointAngleInterval
	{
		get
		{
			CheckDestroyed();
			if (!BattleCirclePointAngleInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:BattleCirclePointAngleInterval");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BattleCirclePointAngleInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BattleCirclePointAngleInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:BattleCirclePointAngleInterval");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BattleCirclePointAngleInterval_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("HotZonePointConfig|CustomInfo")]
	[DisplayName("MeleeAttack自定义圈信息")]
	[USharpPath("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:MeleeAttackCircleCustomInfo")]
	public FGroupAIHotZoneCircleCustomInfo MeleeAttackCircleCustomInfo
	{
		get
		{
			CheckDestroyed();
			if (!MeleeAttackCircleCustomInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:MeleeAttackCircleCustomInfo");
				return default(FGroupAIHotZoneCircleCustomInfo);
			}
			return FGroupAIHotZoneCircleCustomInfo.FromNative(IntPtr.Add(base.Address, MeleeAttackCircleCustomInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MeleeAttackCircleCustomInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:MeleeAttackCircleCustomInfo");
			}
			else
			{
				FGroupAIHotZoneCircleCustomInfo.ToNative(IntPtr.Add(base.Address, MeleeAttackCircleCustomInfo_Offset), value);
			}
		}
	}

	[DisplayName("ShortBattleCircle自定义圈信息")]
	[Category("HotZonePointConfig|CustomInfo")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:ShortBattleCircleCustomInfo")]
	public FGroupAIHotZoneCircleCustomInfo ShortBattleCircleCustomInfo
	{
		get
		{
			CheckDestroyed();
			if (!ShortBattleCircleCustomInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:ShortBattleCircleCustomInfo");
				return default(FGroupAIHotZoneCircleCustomInfo);
			}
			return FGroupAIHotZoneCircleCustomInfo.FromNative(IntPtr.Add(base.Address, ShortBattleCircleCustomInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShortBattleCircleCustomInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:ShortBattleCircleCustomInfo");
			}
			else
			{
				FGroupAIHotZoneCircleCustomInfo.ToNative(IntPtr.Add(base.Address, ShortBattleCircleCustomInfo_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("HotZonePointConfig|CustomInfo")]
	[DisplayName("RangeAttack自定义圈信息")]
	[USharpPath("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:RangeAttackCircleCustomInfo")]
	public FGroupAIHotZoneCircleCustomInfo RangeAttackCircleCustomInfo
	{
		get
		{
			CheckDestroyed();
			if (!RangeAttackCircleCustomInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:RangeAttackCircleCustomInfo");
				return default(FGroupAIHotZoneCircleCustomInfo);
			}
			return FGroupAIHotZoneCircleCustomInfo.FromNative(IntPtr.Add(base.Address, RangeAttackCircleCustomInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RangeAttackCircleCustomInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:RangeAttackCircleCustomInfo");
			}
			else
			{
				FGroupAIHotZoneCircleCustomInfo.ToNative(IntPtr.Add(base.Address, RangeAttackCircleCustomInfo_Offset), value);
			}
		}
	}

	[DisplayName("MiddleBattleCircle自定义圈信息")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("HotZonePointConfig|CustomInfo")]
	[USharpPath("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:MiddleBattleCircleCustomInfo")]
	public FGroupAIHotZoneCircleCustomInfo MiddleBattleCircleCustomInfo
	{
		get
		{
			CheckDestroyed();
			if (!MiddleBattleCircleCustomInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:MiddleBattleCircleCustomInfo");
				return default(FGroupAIHotZoneCircleCustomInfo);
			}
			return FGroupAIHotZoneCircleCustomInfo.FromNative(IntPtr.Add(base.Address, MiddleBattleCircleCustomInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MiddleBattleCircleCustomInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:MiddleBattleCircleCustomInfo");
			}
			else
			{
				FGroupAIHotZoneCircleCustomInfo.ToNative(IntPtr.Add(base.Address, MiddleBattleCircleCustomInfo_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("HotZonePointConfig|CustomInfo")]
	[DisplayName("LongBattleCircle自定义圈信息")]
	[USharpPath("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:LongBattleCircleCustomInfo")]
	public FGroupAIHotZoneCircleCustomInfo LongBattleCircleCustomInfo
	{
		get
		{
			CheckDestroyed();
			if (!LongBattleCircleCustomInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:LongBattleCircleCustomInfo");
				return default(FGroupAIHotZoneCircleCustomInfo);
			}
			return FGroupAIHotZoneCircleCustomInfo.FromNative(IntPtr.Add(base.Address, LongBattleCircleCustomInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LongBattleCircleCustomInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:LongBattleCircleCustomInfo");
			}
			else
			{
				FGroupAIHotZoneCircleCustomInfo.ToNative(IntPtr.Add(base.Address, LongBattleCircleCustomInfo_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, 0)]
	[Tooltip("单位：厘米")]
	[Category("HotZoneConfig")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("近距离战斗半径")]
	[USharpPath("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:ShortBattleCircleRadius")]
	public int ShortBattleCircleRadius
	{
		get
		{
			CheckDestroyed();
			if (!ShortBattleCircleRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:ShortBattleCircleRadius");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ShortBattleCircleRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShortBattleCircleRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:ShortBattleCircleRadius");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ShortBattleCircleRadius_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, 0)]
	[Tooltip("单位：厘米")]
	[Category("HotZoneConfig")]
	[BlueprintReadWrite]
	[DisplayName("中距离战斗半径")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:MiddleBattleCircleRadius")]
	public int MiddleBattleCircleRadius
	{
		get
		{
			CheckDestroyed();
			if (!MiddleBattleCircleRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:MiddleBattleCircleRadius");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MiddleBattleCircleRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MiddleBattleCircleRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:MiddleBattleCircleRadius");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MiddleBattleCircleRadius_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("HotZoneConfig")]
	[DisplayName("远距离战斗半径")]
	[Tooltip("单位：厘米")]
	[UMeta(MDProp.ClampMin, 0)]
	[USharpPath("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:LongBattleCircleRadius")]
	public int LongBattleCircleRadius
	{
		get
		{
			CheckDestroyed();
			if (!LongBattleCircleRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:LongBattleCircleRadius");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LongBattleCircleRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LongBattleCircleRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:LongBattleCircleRadius");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LongBattleCircleRadius_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, 0)]
	[Tooltip("单位：厘米")]
	[EditAnywhere]
	[Category("HotZoneConfig")]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("近战热区内半径")]
	[USharpPath("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:MeleeAttackHotZoneInnerRadius")]
	public int MeleeAttackHotZoneInnerRadius
	{
		get
		{
			CheckDestroyed();
			if (!MeleeAttackHotZoneInnerRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:MeleeAttackHotZoneInnerRadius");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MeleeAttackHotZoneInnerRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MeleeAttackHotZoneInnerRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:MeleeAttackHotZoneInnerRadius");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MeleeAttackHotZoneInnerRadius_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMax, 180)]
	[UMeta(MDProp.ClampMin, 0)]
	[BlueprintReadWrite]
	[DisplayName("近战热区单边夹角")]
	[Category("HotZoneConfig")]
	[EditAnywhere]
	[UProperty]
	[Tooltip("单位：°, 是在")]
	[USharpPath("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:MeleeAttackHotZoneOneSideAngle")]
	public int MeleeAttackHotZoneOneSideAngle
	{
		get
		{
			CheckDestroyed();
			if (!MeleeAttackHotZoneOneSideAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:MeleeAttackHotZoneOneSideAngle");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MeleeAttackHotZoneOneSideAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MeleeAttackHotZoneOneSideAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:MeleeAttackHotZoneOneSideAngle");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MeleeAttackHotZoneOneSideAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("HotZoneConfig")]
	[DisplayName("远程热区单边夹角")]
	[Tooltip("单位：°")]
	[UMeta(MDProp.ClampMin, 0)]
	[UMeta(MDProp.ClampMax, 180)]
	[USharpPath("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:RangeAttackHotZoneOneSideAngle")]
	public int RangeAttackHotZoneOneSideAngle
	{
		get
		{
			CheckDestroyed();
			if (!RangeAttackHotZoneOneSideAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:RangeAttackHotZoneOneSideAngle");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RangeAttackHotZoneOneSideAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RangeAttackHotZoneOneSideAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset:RangeAttackHotZoneOneSideAngle");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RangeAttackHotZoneOneSideAngle_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWGroupAIBattleHotZoneConfigDataAsset");
		BattleCirclePointRingNum_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BattleCirclePointRingNum");
		BattleCirclePointRingNum_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BattleCirclePointRingNum", Classes.FIntProperty);
		BattleCirclePointAngleInterval_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BattleCirclePointAngleInterval");
		BattleCirclePointAngleInterval_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BattleCirclePointAngleInterval", Classes.FIntProperty);
		MeleeAttackCircleCustomInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MeleeAttackCircleCustomInfo");
		MeleeAttackCircleCustomInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MeleeAttackCircleCustomInfo", Classes.FStructProperty);
		ShortBattleCircleCustomInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ShortBattleCircleCustomInfo");
		ShortBattleCircleCustomInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ShortBattleCircleCustomInfo", Classes.FStructProperty);
		RangeAttackCircleCustomInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RangeAttackCircleCustomInfo");
		RangeAttackCircleCustomInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RangeAttackCircleCustomInfo", Classes.FStructProperty);
		MiddleBattleCircleCustomInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MiddleBattleCircleCustomInfo");
		MiddleBattleCircleCustomInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MiddleBattleCircleCustomInfo", Classes.FStructProperty);
		LongBattleCircleCustomInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LongBattleCircleCustomInfo");
		LongBattleCircleCustomInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LongBattleCircleCustomInfo", Classes.FStructProperty);
		ShortBattleCircleRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ShortBattleCircleRadius");
		ShortBattleCircleRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ShortBattleCircleRadius", Classes.FIntProperty);
		MiddleBattleCircleRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MiddleBattleCircleRadius");
		MiddleBattleCircleRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MiddleBattleCircleRadius", Classes.FIntProperty);
		LongBattleCircleRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LongBattleCircleRadius");
		LongBattleCircleRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LongBattleCircleRadius", Classes.FIntProperty);
		MeleeAttackHotZoneInnerRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MeleeAttackHotZoneInnerRadius");
		MeleeAttackHotZoneInnerRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MeleeAttackHotZoneInnerRadius", Classes.FIntProperty);
		MeleeAttackHotZoneOneSideAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MeleeAttackHotZoneOneSideAngle");
		MeleeAttackHotZoneOneSideAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MeleeAttackHotZoneOneSideAngle", Classes.FIntProperty);
		RangeAttackHotZoneOneSideAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RangeAttackHotZoneOneSideAngle");
		RangeAttackHotZoneOneSideAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RangeAttackHotZoneOneSideAngle", Classes.FIntProperty);
	}

	static BGWGroupAIBattleHotZoneConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWGroupAIBattleHotZoneConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWGroupAIBattleHotZoneConfigDataAsset));
	}
}
