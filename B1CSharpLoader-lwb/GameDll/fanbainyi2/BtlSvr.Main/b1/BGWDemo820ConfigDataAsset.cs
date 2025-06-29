using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDemo820ConfigDataAsset")]
public class BGWDemo820ConfigDataAsset : UBGWDataAsset
{
	private static bool OpenLevelInfo_IsValid;

	private static int OpenLevelInfo_Offset;

	private static FFieldAddress OpenLevelInfo_PropertyAddress;

	private TArrayReadWriteMarshaler<FDemo820LevelInfo> OpenLevelInfo_Marshaler;

	private static bool OverSeaOpenLevelInfo_IsValid;

	private static int OverSeaOpenLevelInfo_Offset;

	private static FFieldAddress OverSeaOpenLevelInfo_PropertyAddress;

	private TArrayReadWriteMarshaler<FDemo820LevelInfo> OverSeaOpenLevelInfo_Marshaler;

	private static bool OpenLevelIdIdx_IsValid;

	private static int OpenLevelIdIdx_Offset;

	private static FFieldAddress OpenLevelIdIdx_PropertyAddress;

	private TMapReadWriteMarshaler<int, int> OpenLevelIdIdx_Marshaler;

	private static bool TimeInfo_IsValid;

	private static int TimeInfo_Offset;

	private static bool OverSeaTimeInfo_IsValid;

	private static int OverSeaTimeInfo_Offset;

	private static bool SaveTimeDelay_IsValid;

	private static int SaveTimeDelay_Offset;

	private static bool ChangeLevelCameraTime_IsValid;

	private static int ChangeLevelCameraTime_Offset;

	private static bool PassLevelCurve_IsValid;

	private static int PassLevelCurve_Offset;

	private static bool CurveTimeMax_IsValid;

	private static int CurveTimeMax_Offset;

	private static bool DelayTimeBossList_IsValid;

	private static int DelayTimeBossList_Offset;

	private static FFieldAddress DelayTimeBossList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> DelayTimeBossList_Marshaler;

	private static bool BossHpPercent_IsValid;

	private static int BossHpPercent_Offset;

	private static bool BossDelayTime_IsValid;

	private static int BossDelayTime_Offset;

	[DisplayName("开放的关卡Id")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDemo820ConfigDataAsset:OpenLevelInfo")]
	public TArrayReadWrite<FDemo820LevelInfo> OpenLevelInfo
	{
		get
		{
			CheckDestroyed();
			if (!OpenLevelInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDemo820ConfigDataAsset:OpenLevelInfo");
				return null;
			}
			if (OpenLevelInfo_Marshaler == null)
			{
				OpenLevelInfo_Marshaler = new TArrayReadWriteMarshaler<FDemo820LevelInfo>(1, OpenLevelInfo_PropertyAddress, CachedMarshalingDelegates<FDemo820LevelInfo, FDemo820LevelInfo>.FromNative, CachedMarshalingDelegates<FDemo820LevelInfo, FDemo820LevelInfo>.ToNative);
			}
			return OpenLevelInfo_Marshaler.FromNative(IntPtr.Add(base.Address, OpenLevelInfo_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("海外版开放的关卡Id")]
	[USharpPath("/Script/b1-Managed.BGWDemo820ConfigDataAsset:OverSeaOpenLevelInfo")]
	public TArrayReadWrite<FDemo820LevelInfo> OverSeaOpenLevelInfo
	{
		get
		{
			CheckDestroyed();
			if (!OverSeaOpenLevelInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDemo820ConfigDataAsset:OverSeaOpenLevelInfo");
				return null;
			}
			if (OverSeaOpenLevelInfo_Marshaler == null)
			{
				OverSeaOpenLevelInfo_Marshaler = new TArrayReadWriteMarshaler<FDemo820LevelInfo>(1, OverSeaOpenLevelInfo_PropertyAddress, CachedMarshalingDelegates<FDemo820LevelInfo, FDemo820LevelInfo>.FromNative, CachedMarshalingDelegates<FDemo820LevelInfo, FDemo820LevelInfo>.ToNative);
			}
			return OverSeaOpenLevelInfo_Marshaler.FromNative(IntPtr.Add(base.Address, OverSeaOpenLevelInfo_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("关卡Id对应Idx")]
	[USharpPath("/Script/b1-Managed.BGWDemo820ConfigDataAsset:OpenLevelIdIdx")]
	public TMapReadWrite<int, int> OpenLevelIdIdx
	{
		get
		{
			CheckDestroyed();
			if (!OpenLevelIdIdx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDemo820ConfigDataAsset:OpenLevelIdIdx");
				return null;
			}
			if (OpenLevelIdIdx_Marshaler == null)
			{
				OpenLevelIdIdx_Marshaler = new TMapReadWriteMarshaler<int, int>(1, OpenLevelIdIdx_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return OpenLevelIdIdx_Marshaler.FromNative(IntPtr.Add(base.Address, OpenLevelIdIdx_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("时间配置")]
	[USharpPath("/Script/b1-Managed.BGWDemo820ConfigDataAsset:TimeInfo")]
	public FDemo820TimeInfo TimeInfo
	{
		get
		{
			CheckDestroyed();
			if (!TimeInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDemo820ConfigDataAsset:TimeInfo");
				return default(FDemo820TimeInfo);
			}
			return FDemo820TimeInfo.FromNative(IntPtr.Add(base.Address, TimeInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TimeInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDemo820ConfigDataAsset:TimeInfo");
			}
			else
			{
				FDemo820TimeInfo.ToNative(IntPtr.Add(base.Address, TimeInfo_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("海外版时间配置")]
	[USharpPath("/Script/b1-Managed.BGWDemo820ConfigDataAsset:OverSeaTimeInfo")]
	public FDemo820TimeInfo OverSeaTimeInfo
	{
		get
		{
			CheckDestroyed();
			if (!OverSeaTimeInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDemo820ConfigDataAsset:OverSeaTimeInfo");
				return default(FDemo820TimeInfo);
			}
			return FDemo820TimeInfo.FromNative(IntPtr.Add(base.Address, OverSeaTimeInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverSeaTimeInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDemo820ConfigDataAsset:OverSeaTimeInfo");
			}
			else
			{
				FDemo820TimeInfo.ToNative(IntPtr.Add(base.Address, OverSeaTimeInfo_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("游玩时间记录时间间隔(秒)")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDemo820ConfigDataAsset:SaveTimeDelay")]
	public float SaveTimeDelay
	{
		get
		{
			CheckDestroyed();
			if (!SaveTimeDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDemo820ConfigDataAsset:SaveTimeDelay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SaveTimeDelay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SaveTimeDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDemo820ConfigDataAsset:SaveTimeDelay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SaveTimeDelay_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("关卡切换镜头窗口时间")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDemo820ConfigDataAsset:ChangeLevelCameraTime")]
	public float ChangeLevelCameraTime
	{
		get
		{
			CheckDestroyed();
			if (!ChangeLevelCameraTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDemo820ConfigDataAsset:ChangeLevelCameraTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ChangeLevelCameraTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChangeLevelCameraTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDemo820ConfigDataAsset:ChangeLevelCameraTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ChangeLevelCameraTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("通关时缓曲线")]
	[USharpPath("/Script/b1-Managed.BGWDemo820ConfigDataAsset:PassLevelCurve")]
	public UCurveFloat PassLevelCurve
	{
		get
		{
			CheckDestroyed();
			if (!PassLevelCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDemo820ConfigDataAsset:PassLevelCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, PassLevelCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PassLevelCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDemo820ConfigDataAsset:PassLevelCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, PassLevelCurve_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Tooltip("时缓最大时间")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDemo820ConfigDataAsset:CurveTimeMax")]
	public float CurveTimeMax
	{
		get
		{
			CheckDestroyed();
			if (!CurveTimeMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDemo820ConfigDataAsset:CurveTimeMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CurveTimeMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurveTimeMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDemo820ConfigDataAsset:CurveTimeMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CurveTimeMax_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Tooltip("Boss延时白名单")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDemo820ConfigDataAsset:DelayTimeBossList")]
	public TArrayReadWrite<int> DelayTimeBossList
	{
		get
		{
			CheckDestroyed();
			if (!DelayTimeBossList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDemo820ConfigDataAsset:DelayTimeBossList");
				return null;
			}
			if (DelayTimeBossList_Marshaler == null)
			{
				DelayTimeBossList_Marshaler = new TArrayReadWriteMarshaler<int>(1, DelayTimeBossList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return DelayTimeBossList_Marshaler.FromNative(IntPtr.Add(base.Address, DelayTimeBossList_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("Boss血量百分比")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDemo820ConfigDataAsset:BossHpPercent")]
	public float BossHpPercent
	{
		get
		{
			CheckDestroyed();
			if (!BossHpPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDemo820ConfigDataAsset:BossHpPercent");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BossHpPercent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BossHpPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDemo820ConfigDataAsset:BossHpPercent");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BossHpPercent_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Tooltip("Boss战延时时间")]
	[USharpPath("/Script/b1-Managed.BGWDemo820ConfigDataAsset:BossDelayTime")]
	public float BossDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!BossDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDemo820ConfigDataAsset:BossDelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BossDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BossDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDemo820ConfigDataAsset:BossDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BossDelayTime_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDemo820ConfigDataAsset");
		NativeReflection.GetPropertyRef(ref OpenLevelInfo_PropertyAddress, unrealStruct, "OpenLevelInfo");
		OpenLevelInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OpenLevelInfo");
		OpenLevelInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OpenLevelInfo", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref OverSeaOpenLevelInfo_PropertyAddress, unrealStruct, "OverSeaOpenLevelInfo");
		OverSeaOpenLevelInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OverSeaOpenLevelInfo");
		OverSeaOpenLevelInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OverSeaOpenLevelInfo", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref OpenLevelIdIdx_PropertyAddress, unrealStruct, "OpenLevelIdIdx");
		OpenLevelIdIdx_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OpenLevelIdIdx");
		OpenLevelIdIdx_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OpenLevelIdIdx", Classes.FMapProperty);
		TimeInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TimeInfo");
		TimeInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TimeInfo", Classes.FStructProperty);
		OverSeaTimeInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OverSeaTimeInfo");
		OverSeaTimeInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OverSeaTimeInfo", Classes.FStructProperty);
		SaveTimeDelay_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SaveTimeDelay");
		SaveTimeDelay_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SaveTimeDelay", Classes.FFloatProperty);
		ChangeLevelCameraTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ChangeLevelCameraTime");
		ChangeLevelCameraTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ChangeLevelCameraTime", Classes.FFloatProperty);
		PassLevelCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PassLevelCurve");
		PassLevelCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PassLevelCurve", Classes.FObjectProperty);
		CurveTimeMax_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CurveTimeMax");
		CurveTimeMax_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CurveTimeMax", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref DelayTimeBossList_PropertyAddress, unrealStruct, "DelayTimeBossList");
		DelayTimeBossList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DelayTimeBossList");
		DelayTimeBossList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DelayTimeBossList", Classes.FArrayProperty);
		BossHpPercent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BossHpPercent");
		BossHpPercent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BossHpPercent", Classes.FFloatProperty);
		BossDelayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BossDelayTime");
		BossDelayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BossDelayTime", Classes.FFloatProperty);
	}

	static BGWDemo820ConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDemo820ConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDemo820ConfigDataAsset));
	}
}
