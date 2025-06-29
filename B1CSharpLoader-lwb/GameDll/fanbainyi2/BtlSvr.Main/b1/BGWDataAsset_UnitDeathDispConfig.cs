using System;
using System.Collections.Generic;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig")]
public class BGWDataAsset_UnitDeathDispConfig : UBGWDataAsset, b1.IBGWDataAssetHasAnimationReferences
{
	private static bool NormalDeadAMPath_IsValid;

	private static int NormalDeadAMPath_Offset;

	private static bool UnitResName_IsValid;

	private static int UnitResName_Offset;

	private static bool NormalDeadAMInfoList_IsValid;

	private static int NormalDeadAMInfoList_Offset;

	private static FFieldAddress NormalDeadAMInfoList_PropertyAddress;

	private TArrayReadWriteMarshaler<FNormalDeadAMInfo> NormalDeadAMInfoList_Marshaler;

	private static bool NormalDissolveDBC_IsValid;

	private static int NormalDissolveDBC_Offset;

	private static bool DeathDissolvePlayType_IsValid;

	private static int DeathDissolvePlayType_Offset;

	private static FFieldAddress DeathDissolvePlayType_PropertyAddress;

	private static bool BurnStateDotDeadMontage_IsValid;

	private static int BurnStateDotDeadMontage_Offset;

	private static bool PoisonStateDotDeadMontage_IsValid;

	private static int PoisonStateDotDeadMontage_Offset;

	private static bool FreezeStateDotDeadMontage_IsValid;

	private static int FreezeStateDotDeadMontage_Offset;

	private static bool ImmobilizingDeadMontage_IsValid;

	private static int ImmobilizingDeadMontage_Offset;

	private static bool OceanSeaDeadMontage_IsValid;

	private static int OceanSeaDeadMontage_Offset;

	private static bool InteractCricketDeadMontage_IsValid;

	private static int InteractCricketDeadMontage_Offset;

	private static bool SuicideDeadMontage_IsValid;

	private static int SuicideDeadMontage_Offset;

	private static bool AirDeadMontage_Fall_IsValid;

	private static int AirDeadMontage_Fall_Offset;

	private static bool AirDeadMontage_WithDirection_IsValid;

	private static int AirDeadMontage_WithDirection_Offset;

	private static bool FallDeadMontage_IsValid;

	private static int FallDeadMontage_Offset;

	private static bool NormalDeadAMList_IsValid;

	private static int NormalDeadAMList_Offset;

	private static FFieldAddress NormalDeadAMList_PropertyAddress;

	private TArrayReadWriteMarshaler<UAnimMontage> NormalDeadAMList_Marshaler;

	private static bool SetDefaultDBCAsset_IsValid;

	private static IntPtr SetDefaultDBCAsset_FunctionAddress;

	private static int SetDefaultDBCAsset_ParamsSize;

	private static bool SetDefaultDBCAsset__NormalDissolveDBC_IsValid;

	private static int SetDefaultDBCAsset__NormalDissolveDBC_Offset;

	private static bool SetDefaultDBCAsset_Burn_AbnormalStateDeadDBC_IsValid;

	private static int SetDefaultDBCAsset_Burn_AbnormalStateDeadDBC_Offset;

	private static bool SetDefaultDBCAsset_Burn_AbnormalStateDissolveDBC_IsValid;

	private static int SetDefaultDBCAsset_Burn_AbnormalStateDissolveDBC_Offset;

	private static bool SetDefaultDBCAsset_Thunder_AbnormalStateDeadDBC_IsValid;

	private static int SetDefaultDBCAsset_Thunder_AbnormalStateDeadDBC_Offset;

	private static bool SetDefaultDBCAsset_Thunder_AbnormalStateDissolveDBC_IsValid;

	private static int SetDefaultDBCAsset_Thunder_AbnormalStateDissolveDBC_Offset;

	private static bool SetDefaultDBCAsset_Poison_AbnormalStateDeadDBC_IsValid;

	private static int SetDefaultDBCAsset_Poison_AbnormalStateDeadDBC_Offset;

	private static bool SetDefaultDBCAsset_Poison_AbnormalStateDissolveDBC_IsValid;

	private static int SetDefaultDBCAsset_Poison_AbnormalStateDissolveDBC_Offset;

	private static bool SetDefaultDBCAsset_Freeze_AbnormalStateDeadDBC_IsValid;

	private static int SetDefaultDBCAsset_Freeze_AbnormalStateDeadDBC_Offset;

	private static bool SetDefaultDBCAsset_Freeze_AbnormalStateDissolveDBC_IsValid;

	private static int SetDefaultDBCAsset_Freeze_AbnormalStateDissolveDBC_Offset;

	private static bool SetDefaultDBCAsset_Yin_AbnormalStateDeadDBC_IsValid;

	private static int SetDefaultDBCAsset_Yin_AbnormalStateDeadDBC_Offset;

	private static bool SetDefaultDBCAsset_Yin_AbnormalStateDissolveDBC_IsValid;

	private static int SetDefaultDBCAsset_Yin_AbnormalStateDissolveDBC_Offset;

	private static bool SetDefaultDBCAsset_Yang_AbnormalStateDeadDBC_IsValid;

	private static int SetDefaultDBCAsset_Yang_AbnormalStateDeadDBC_Offset;

	private static bool SetDefaultDBCAsset_Yang_AbnormalStateDissolveDBC_IsValid;

	private static int SetDefaultDBCAsset_Yang_AbnormalStateDissolveDBC_Offset;

	[DisplayName("普通死亡动画目录路径")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("NormalDead")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:NormalDeadAMPath")]
	public string NormalDeadAMPath
	{
		get
		{
			CheckDestroyed();
			if (!NormalDeadAMPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:NormalDeadAMPath");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, NormalDeadAMPath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NormalDeadAMPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:NormalDeadAMPath");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, NormalDeadAMPath_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("单位资源名称")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("NormalDead")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:UnitResName")]
	public string UnitResName
	{
		get
		{
			CheckDestroyed();
			if (!UnitResName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:UnitResName");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, UnitResName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitResName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:UnitResName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, UnitResName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("NormalDead")]
	[DisplayName("普通死亡动画信息(按挡位区分)")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:NormalDeadAMInfoList")]
	public TArrayReadWrite<FNormalDeadAMInfo> NormalDeadAMInfoList
	{
		get
		{
			CheckDestroyed();
			if (!NormalDeadAMInfoList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:NormalDeadAMInfoList");
				return null;
			}
			if (NormalDeadAMInfoList_Marshaler == null)
			{
				NormalDeadAMInfoList_Marshaler = new TArrayReadWriteMarshaler<FNormalDeadAMInfo>(1, NormalDeadAMInfoList_PropertyAddress, CachedMarshalingDelegates<FNormalDeadAMInfo, FNormalDeadAMInfo>.FromNative, CachedMarshalingDelegates<FNormalDeadAMInfo, FNormalDeadAMInfo>.ToNative);
			}
			return NormalDeadAMInfoList_Marshaler.FromNative(IntPtr.Add(base.Address, NormalDeadAMInfoList_Offset));
		}
	}

	[EditAnywhere]
	[DisplayName("通用消散DBC")]
	[Category("NormalDead")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:NormalDissolveDBC")]
	public BUC_DispLibDispBaseConfigDataAsset NormalDissolveDBC
	{
		get
		{
			CheckDestroyed();
			if (!NormalDissolveDBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:NormalDissolveDBC");
				return null;
			}
			return UObjectMarshaler<BUC_DispLibDispBaseConfigDataAsset>.FromNative(IntPtr.Add(base.Address, NormalDissolveDBC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NormalDissolveDBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:NormalDissolveDBC");
			}
			else
			{
				UObjectMarshaler<BUC_DispLibDispBaseConfigDataAsset>.ToNative(IntPtr.Add(base.Address, NormalDissolveDBC_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("NormalDead")]
	[DisplayName("消散DBC播放方式")]
	[Tooltip("选择【死亡动画结束时】，也可以在中途通过NotifyState提前触发；触发【消散DBC】时会同时移除【异常DBC】")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:DeathDissolvePlayType")]
	public EDeathDissolvePlayType DeathDissolvePlayType
	{
		get
		{
			CheckDestroyed();
			if (!DeathDissolvePlayType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:DeathDissolvePlayType");
				return EDeathDissolvePlayType.DeadAMEnd;
			}
			return EnumMarshaler<EDeathDissolvePlayType>.FromNative(IntPtr.Add(base.Address, DeathDissolvePlayType_Offset), 0, DeathDissolvePlayType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DeathDissolvePlayType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:DeathDissolvePlayType");
			}
			else
			{
				EnumMarshaler<EDeathDissolvePlayType>.ToNative(IntPtr.Add(base.Address, DeathDissolvePlayType_Offset), 0, DeathDissolvePlayType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("AbnormalStateDead")]
	[DisplayName("火异常Dot死亡动画")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:BurnStateDotDeadMontage")]
	public UAnimMontage BurnStateDotDeadMontage
	{
		get
		{
			CheckDestroyed();
			if (!BurnStateDotDeadMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:BurnStateDotDeadMontage");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, BurnStateDotDeadMontage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BurnStateDotDeadMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:BurnStateDotDeadMontage");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, BurnStateDotDeadMontage_Offset), value);
			}
		}
	}

	[DisplayName("毒异常Dot死亡动画")]
	[UProperty]
	[BlueprintReadWrite]
	[Category("AbnormalStateDead")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:PoisonStateDotDeadMontage")]
	public UAnimMontage PoisonStateDotDeadMontage
	{
		get
		{
			CheckDestroyed();
			if (!PoisonStateDotDeadMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:PoisonStateDotDeadMontage");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, PoisonStateDotDeadMontage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PoisonStateDotDeadMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:PoisonStateDotDeadMontage");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, PoisonStateDotDeadMontage_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("AbnormalStateDead")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("冰异常Dot死亡动画")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:FreezeStateDotDeadMontage")]
	public UAnimMontage FreezeStateDotDeadMontage
	{
		get
		{
			CheckDestroyed();
			if (!FreezeStateDotDeadMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:FreezeStateDotDeadMontage");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, FreezeStateDotDeadMontage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FreezeStateDotDeadMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:FreezeStateDotDeadMontage");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, FreezeStateDotDeadMontage_Offset), value);
			}
		}
	}

	[Category("SpecialDead")]
	[UProperty]
	[DisplayName("定身死亡动画资源")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:ImmobilizingDeadMontage")]
	public UAnimMontage ImmobilizingDeadMontage
	{
		get
		{
			CheckDestroyed();
			if (!ImmobilizingDeadMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:ImmobilizingDeadMontage");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, ImmobilizingDeadMontage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImmobilizingDeadMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:ImmobilizingDeadMontage");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, ImmobilizingDeadMontage_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SpecialDead")]
	[DisplayName("被蜘蛛海淹没死亡动画资源")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:OceanSeaDeadMontage")]
	public UAnimMontage OceanSeaDeadMontage
	{
		get
		{
			CheckDestroyed();
			if (!OceanSeaDeadMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:OceanSeaDeadMontage");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, OceanSeaDeadMontage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OceanSeaDeadMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:OceanSeaDeadMontage");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, OceanSeaDeadMontage_Offset), value);
			}
		}
	}

	[DisplayName("交互蟋蟀拔须死亡动画资源")]
	[UProperty]
	[Category("SpecialDead")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:InteractCricketDeadMontage")]
	public UAnimMontage InteractCricketDeadMontage
	{
		get
		{
			CheckDestroyed();
			if (!InteractCricketDeadMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:InteractCricketDeadMontage");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, InteractCricketDeadMontage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractCricketDeadMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:InteractCricketDeadMontage");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, InteractCricketDeadMontage_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("自杀死亡动画资源")]
	[UProperty]
	[Category("SpecialDead")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:SuicideDeadMontage")]
	public UAnimMontage SuicideDeadMontage
	{
		get
		{
			CheckDestroyed();
			if (!SuicideDeadMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:SuicideDeadMontage");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, SuicideDeadMontage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SuicideDeadMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:SuicideDeadMontage");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, SuicideDeadMontage_Offset), value);
			}
		}
	}

	[DisplayName("空中死亡动画资源_原地坠落")]
	[Category("SpecialDead")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:AirDeadMontage_Fall")]
	public UAnimMontage AirDeadMontage_Fall
	{
		get
		{
			CheckDestroyed();
			if (!AirDeadMontage_Fall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:AirDeadMontage_Fall");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, AirDeadMontage_Fall_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AirDeadMontage_Fall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:AirDeadMontage_Fall");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, AirDeadMontage_Fall_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("空中死亡动画资源_带方向")]
	[UProperty]
	[BlueprintReadWrite]
	[Category("SpecialDead")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:AirDeadMontage_WithDirection")]
	public UAnimMontage AirDeadMontage_WithDirection
	{
		get
		{
			CheckDestroyed();
			if (!AirDeadMontage_WithDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:AirDeadMontage_WithDirection");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, AirDeadMontage_WithDirection_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AirDeadMontage_WithDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:AirDeadMontage_WithDirection");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, AirDeadMontage_WithDirection_Offset), value);
			}
		}
	}

	[Category("SpecialDead")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("坠落摔死动画")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:FallDeadMontage")]
	public UAnimMontage FallDeadMontage
	{
		get
		{
			CheckDestroyed();
			if (!FallDeadMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:FallDeadMontage");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, FallDeadMontage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FallDeadMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:FallDeadMontage");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, FallDeadMontage_Offset), value);
			}
		}
	}

	[Tooltip("预加载使用")]
	[DisplayName("普通死亡动画列表")]
	[Category("NormalDeadAMConfig")]
	[VisibleAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:NormalDeadAMList")]
	public TArrayReadWrite<UAnimMontage> NormalDeadAMList
	{
		get
		{
			CheckDestroyed();
			if (!NormalDeadAMList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:NormalDeadAMList");
				return null;
			}
			if (NormalDeadAMList_Marshaler == null)
			{
				NormalDeadAMList_Marshaler = new TArrayReadWriteMarshaler<UAnimMontage>(1, NormalDeadAMList_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative);
			}
			return NormalDeadAMList_Marshaler.FromNative(IntPtr.Add(base.Address, NormalDeadAMList_Offset));
		}
	}

	public void GetAnimationReferences(out List<UAnimSequenceBase> AnimMontages)
	{
		AnimMontages = new List<UAnimSequenceBase>();
		if (ImmobilizingDeadMontage != null)
		{
			AnimMontages.Add(ImmobilizingDeadMontage);
		}
		if (OceanSeaDeadMontage != null)
		{
			AnimMontages.Add(OceanSeaDeadMontage);
		}
		if (InteractCricketDeadMontage != null)
		{
			AnimMontages.Add(InteractCricketDeadMontage);
		}
		if (SuicideDeadMontage != null)
		{
			AnimMontages.Add(SuicideDeadMontage);
		}
		if (AirDeadMontage_Fall != null)
		{
			AnimMontages.Add(AirDeadMontage_Fall);
		}
		if (AirDeadMontage_WithDirection != null)
		{
			AnimMontages.Add(AirDeadMontage_WithDirection);
		}
		if (FallDeadMontage != null)
		{
			AnimMontages.Add(FallDeadMontage);
		}
		foreach (UAnimMontage normalDeadAM in NormalDeadAMList)
		{
			if (normalDeadAM != null)
			{
				AnimMontages.Add(normalDeadAM);
			}
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:SetDefaultDBCAsset")]
	public void SetDefaultDBCAsset(BUC_DispLibDispBaseConfigDataAsset _NormalDissolveDBC, BUC_DispLibDispBaseConfigDataAsset Burn_AbnormalStateDeadDBC, BUC_DispLibDispBaseConfigDataAsset Burn_AbnormalStateDissolveDBC, BUC_DispLibDispBaseConfigDataAsset Thunder_AbnormalStateDeadDBC, BUC_DispLibDispBaseConfigDataAsset Thunder_AbnormalStateDissolveDBC, BUC_DispLibDispBaseConfigDataAsset Poison_AbnormalStateDeadDBC, BUC_DispLibDispBaseConfigDataAsset Poison_AbnormalStateDissolveDBC, BUC_DispLibDispBaseConfigDataAsset Freeze_AbnormalStateDeadDBC, BUC_DispLibDispBaseConfigDataAsset Freeze_AbnormalStateDissolveDBC, BUC_DispLibDispBaseConfigDataAsset Yin_AbnormalStateDeadDBC, BUC_DispLibDispBaseConfigDataAsset Yin_AbnormalStateDissolveDBC, BUC_DispLibDispBaseConfigDataAsset Yang_AbnormalStateDeadDBC, BUC_DispLibDispBaseConfigDataAsset Yang_AbnormalStateDissolveDBC)
	{
		NormalDissolveDBC = _NormalDissolveDBC;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:SetDefaultDBCAsset")]
	private static void SetDefaultDBCAsset__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWDataAsset_UnitDeathDispConfig bGWDataAsset_UnitDeathDispConfig = GCHelper.Find<BGWDataAsset_UnitDeathDispConfig>(obj);
		BUC_DispLibDispBaseConfigDataAsset normalDissolveDBC = UObjectMarshaler<BUC_DispLibDispBaseConfigDataAsset>.FromNative(IntPtr.Add(buffer, SetDefaultDBCAsset__NormalDissolveDBC_Offset));
		BUC_DispLibDispBaseConfigDataAsset burn_AbnormalStateDeadDBC = UObjectMarshaler<BUC_DispLibDispBaseConfigDataAsset>.FromNative(IntPtr.Add(buffer, SetDefaultDBCAsset_Burn_AbnormalStateDeadDBC_Offset));
		BUC_DispLibDispBaseConfigDataAsset burn_AbnormalStateDissolveDBC = UObjectMarshaler<BUC_DispLibDispBaseConfigDataAsset>.FromNative(IntPtr.Add(buffer, SetDefaultDBCAsset_Burn_AbnormalStateDissolveDBC_Offset));
		BUC_DispLibDispBaseConfigDataAsset thunder_AbnormalStateDeadDBC = UObjectMarshaler<BUC_DispLibDispBaseConfigDataAsset>.FromNative(IntPtr.Add(buffer, SetDefaultDBCAsset_Thunder_AbnormalStateDeadDBC_Offset));
		BUC_DispLibDispBaseConfigDataAsset thunder_AbnormalStateDissolveDBC = UObjectMarshaler<BUC_DispLibDispBaseConfigDataAsset>.FromNative(IntPtr.Add(buffer, SetDefaultDBCAsset_Thunder_AbnormalStateDissolveDBC_Offset));
		BUC_DispLibDispBaseConfigDataAsset poison_AbnormalStateDeadDBC = UObjectMarshaler<BUC_DispLibDispBaseConfigDataAsset>.FromNative(IntPtr.Add(buffer, SetDefaultDBCAsset_Poison_AbnormalStateDeadDBC_Offset));
		BUC_DispLibDispBaseConfigDataAsset poison_AbnormalStateDissolveDBC = UObjectMarshaler<BUC_DispLibDispBaseConfigDataAsset>.FromNative(IntPtr.Add(buffer, SetDefaultDBCAsset_Poison_AbnormalStateDissolveDBC_Offset));
		BUC_DispLibDispBaseConfigDataAsset freeze_AbnormalStateDeadDBC = UObjectMarshaler<BUC_DispLibDispBaseConfigDataAsset>.FromNative(IntPtr.Add(buffer, SetDefaultDBCAsset_Freeze_AbnormalStateDeadDBC_Offset));
		BUC_DispLibDispBaseConfigDataAsset freeze_AbnormalStateDissolveDBC = UObjectMarshaler<BUC_DispLibDispBaseConfigDataAsset>.FromNative(IntPtr.Add(buffer, SetDefaultDBCAsset_Freeze_AbnormalStateDissolveDBC_Offset));
		BUC_DispLibDispBaseConfigDataAsset yin_AbnormalStateDeadDBC = UObjectMarshaler<BUC_DispLibDispBaseConfigDataAsset>.FromNative(IntPtr.Add(buffer, SetDefaultDBCAsset_Yin_AbnormalStateDeadDBC_Offset));
		BUC_DispLibDispBaseConfigDataAsset yin_AbnormalStateDissolveDBC = UObjectMarshaler<BUC_DispLibDispBaseConfigDataAsset>.FromNative(IntPtr.Add(buffer, SetDefaultDBCAsset_Yin_AbnormalStateDissolveDBC_Offset));
		BUC_DispLibDispBaseConfigDataAsset yang_AbnormalStateDeadDBC = UObjectMarshaler<BUC_DispLibDispBaseConfigDataAsset>.FromNative(IntPtr.Add(buffer, SetDefaultDBCAsset_Yang_AbnormalStateDeadDBC_Offset));
		BUC_DispLibDispBaseConfigDataAsset yang_AbnormalStateDissolveDBC = UObjectMarshaler<BUC_DispLibDispBaseConfigDataAsset>.FromNative(IntPtr.Add(buffer, SetDefaultDBCAsset_Yang_AbnormalStateDissolveDBC_Offset));
		bGWDataAsset_UnitDeathDispConfig.SetDefaultDBCAsset(normalDissolveDBC, burn_AbnormalStateDeadDBC, burn_AbnormalStateDissolveDBC, thunder_AbnormalStateDeadDBC, thunder_AbnormalStateDissolveDBC, poison_AbnormalStateDeadDBC, poison_AbnormalStateDissolveDBC, freeze_AbnormalStateDeadDBC, freeze_AbnormalStateDissolveDBC, yin_AbnormalStateDeadDBC, yin_AbnormalStateDissolveDBC, yang_AbnormalStateDeadDBC, yang_AbnormalStateDissolveDBC);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig");
		NormalDeadAMPath_Offset = NativeReflection.GetPropertyOffset(intPtr, "NormalDeadAMPath");
		NormalDeadAMPath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NormalDeadAMPath", Classes.FStrProperty);
		UnitResName_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitResName");
		UnitResName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitResName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref NormalDeadAMInfoList_PropertyAddress, intPtr, "NormalDeadAMInfoList");
		NormalDeadAMInfoList_Offset = NativeReflection.GetPropertyOffset(intPtr, "NormalDeadAMInfoList");
		NormalDeadAMInfoList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NormalDeadAMInfoList", Classes.FArrayProperty);
		NormalDissolveDBC_Offset = NativeReflection.GetPropertyOffset(intPtr, "NormalDissolveDBC");
		NormalDissolveDBC_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NormalDissolveDBC", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref DeathDissolvePlayType_PropertyAddress, intPtr, "DeathDissolvePlayType");
		DeathDissolvePlayType_Offset = NativeReflection.GetPropertyOffset(intPtr, "DeathDissolvePlayType");
		DeathDissolvePlayType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DeathDissolvePlayType", Classes.FEnumProperty);
		BurnStateDotDeadMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "BurnStateDotDeadMontage");
		BurnStateDotDeadMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BurnStateDotDeadMontage", Classes.FObjectProperty);
		PoisonStateDotDeadMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "PoisonStateDotDeadMontage");
		PoisonStateDotDeadMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PoisonStateDotDeadMontage", Classes.FObjectProperty);
		FreezeStateDotDeadMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "FreezeStateDotDeadMontage");
		FreezeStateDotDeadMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FreezeStateDotDeadMontage", Classes.FObjectProperty);
		ImmobilizingDeadMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "ImmobilizingDeadMontage");
		ImmobilizingDeadMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ImmobilizingDeadMontage", Classes.FObjectProperty);
		OceanSeaDeadMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "OceanSeaDeadMontage");
		OceanSeaDeadMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OceanSeaDeadMontage", Classes.FObjectProperty);
		InteractCricketDeadMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractCricketDeadMontage");
		InteractCricketDeadMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractCricketDeadMontage", Classes.FObjectProperty);
		SuicideDeadMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "SuicideDeadMontage");
		SuicideDeadMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SuicideDeadMontage", Classes.FObjectProperty);
		AirDeadMontage_Fall_Offset = NativeReflection.GetPropertyOffset(intPtr, "AirDeadMontage_Fall");
		AirDeadMontage_Fall_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AirDeadMontage_Fall", Classes.FObjectProperty);
		AirDeadMontage_WithDirection_Offset = NativeReflection.GetPropertyOffset(intPtr, "AirDeadMontage_WithDirection");
		AirDeadMontage_WithDirection_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AirDeadMontage_WithDirection", Classes.FObjectProperty);
		FallDeadMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "FallDeadMontage");
		FallDeadMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FallDeadMontage", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref NormalDeadAMList_PropertyAddress, intPtr, "NormalDeadAMList");
		NormalDeadAMList_Offset = NativeReflection.GetPropertyOffset(intPtr, "NormalDeadAMList");
		NormalDeadAMList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NormalDeadAMList", Classes.FArrayProperty);
		SetDefaultDBCAsset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDefaultDBCAsset");
		SetDefaultDBCAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDefaultDBCAsset_FunctionAddress);
		SetDefaultDBCAsset__NormalDissolveDBC_Offset = NativeReflection.GetPropertyOffset(SetDefaultDBCAsset_FunctionAddress, "_NormalDissolveDBC");
		SetDefaultDBCAsset__NormalDissolveDBC_IsValid = NativeReflection.ValidatePropertyClass(SetDefaultDBCAsset_FunctionAddress, "_NormalDissolveDBC", Classes.FObjectProperty);
		SetDefaultDBCAsset_Burn_AbnormalStateDeadDBC_Offset = NativeReflection.GetPropertyOffset(SetDefaultDBCAsset_FunctionAddress, "Burn_AbnormalStateDeadDBC");
		SetDefaultDBCAsset_Burn_AbnormalStateDeadDBC_IsValid = NativeReflection.ValidatePropertyClass(SetDefaultDBCAsset_FunctionAddress, "Burn_AbnormalStateDeadDBC", Classes.FObjectProperty);
		SetDefaultDBCAsset_Burn_AbnormalStateDissolveDBC_Offset = NativeReflection.GetPropertyOffset(SetDefaultDBCAsset_FunctionAddress, "Burn_AbnormalStateDissolveDBC");
		SetDefaultDBCAsset_Burn_AbnormalStateDissolveDBC_IsValid = NativeReflection.ValidatePropertyClass(SetDefaultDBCAsset_FunctionAddress, "Burn_AbnormalStateDissolveDBC", Classes.FObjectProperty);
		SetDefaultDBCAsset_Thunder_AbnormalStateDeadDBC_Offset = NativeReflection.GetPropertyOffset(SetDefaultDBCAsset_FunctionAddress, "Thunder_AbnormalStateDeadDBC");
		SetDefaultDBCAsset_Thunder_AbnormalStateDeadDBC_IsValid = NativeReflection.ValidatePropertyClass(SetDefaultDBCAsset_FunctionAddress, "Thunder_AbnormalStateDeadDBC", Classes.FObjectProperty);
		SetDefaultDBCAsset_Thunder_AbnormalStateDissolveDBC_Offset = NativeReflection.GetPropertyOffset(SetDefaultDBCAsset_FunctionAddress, "Thunder_AbnormalStateDissolveDBC");
		SetDefaultDBCAsset_Thunder_AbnormalStateDissolveDBC_IsValid = NativeReflection.ValidatePropertyClass(SetDefaultDBCAsset_FunctionAddress, "Thunder_AbnormalStateDissolveDBC", Classes.FObjectProperty);
		SetDefaultDBCAsset_Poison_AbnormalStateDeadDBC_Offset = NativeReflection.GetPropertyOffset(SetDefaultDBCAsset_FunctionAddress, "Poison_AbnormalStateDeadDBC");
		SetDefaultDBCAsset_Poison_AbnormalStateDeadDBC_IsValid = NativeReflection.ValidatePropertyClass(SetDefaultDBCAsset_FunctionAddress, "Poison_AbnormalStateDeadDBC", Classes.FObjectProperty);
		SetDefaultDBCAsset_Poison_AbnormalStateDissolveDBC_Offset = NativeReflection.GetPropertyOffset(SetDefaultDBCAsset_FunctionAddress, "Poison_AbnormalStateDissolveDBC");
		SetDefaultDBCAsset_Poison_AbnormalStateDissolveDBC_IsValid = NativeReflection.ValidatePropertyClass(SetDefaultDBCAsset_FunctionAddress, "Poison_AbnormalStateDissolveDBC", Classes.FObjectProperty);
		SetDefaultDBCAsset_Freeze_AbnormalStateDeadDBC_Offset = NativeReflection.GetPropertyOffset(SetDefaultDBCAsset_FunctionAddress, "Freeze_AbnormalStateDeadDBC");
		SetDefaultDBCAsset_Freeze_AbnormalStateDeadDBC_IsValid = NativeReflection.ValidatePropertyClass(SetDefaultDBCAsset_FunctionAddress, "Freeze_AbnormalStateDeadDBC", Classes.FObjectProperty);
		SetDefaultDBCAsset_Freeze_AbnormalStateDissolveDBC_Offset = NativeReflection.GetPropertyOffset(SetDefaultDBCAsset_FunctionAddress, "Freeze_AbnormalStateDissolveDBC");
		SetDefaultDBCAsset_Freeze_AbnormalStateDissolveDBC_IsValid = NativeReflection.ValidatePropertyClass(SetDefaultDBCAsset_FunctionAddress, "Freeze_AbnormalStateDissolveDBC", Classes.FObjectProperty);
		SetDefaultDBCAsset_Yin_AbnormalStateDeadDBC_Offset = NativeReflection.GetPropertyOffset(SetDefaultDBCAsset_FunctionAddress, "Yin_AbnormalStateDeadDBC");
		SetDefaultDBCAsset_Yin_AbnormalStateDeadDBC_IsValid = NativeReflection.ValidatePropertyClass(SetDefaultDBCAsset_FunctionAddress, "Yin_AbnormalStateDeadDBC", Classes.FObjectProperty);
		SetDefaultDBCAsset_Yin_AbnormalStateDissolveDBC_Offset = NativeReflection.GetPropertyOffset(SetDefaultDBCAsset_FunctionAddress, "Yin_AbnormalStateDissolveDBC");
		SetDefaultDBCAsset_Yin_AbnormalStateDissolveDBC_IsValid = NativeReflection.ValidatePropertyClass(SetDefaultDBCAsset_FunctionAddress, "Yin_AbnormalStateDissolveDBC", Classes.FObjectProperty);
		SetDefaultDBCAsset_Yang_AbnormalStateDeadDBC_Offset = NativeReflection.GetPropertyOffset(SetDefaultDBCAsset_FunctionAddress, "Yang_AbnormalStateDeadDBC");
		SetDefaultDBCAsset_Yang_AbnormalStateDeadDBC_IsValid = NativeReflection.ValidatePropertyClass(SetDefaultDBCAsset_FunctionAddress, "Yang_AbnormalStateDeadDBC", Classes.FObjectProperty);
		SetDefaultDBCAsset_Yang_AbnormalStateDissolveDBC_Offset = NativeReflection.GetPropertyOffset(SetDefaultDBCAsset_FunctionAddress, "Yang_AbnormalStateDissolveDBC");
		SetDefaultDBCAsset_Yang_AbnormalStateDissolveDBC_IsValid = NativeReflection.ValidatePropertyClass(SetDefaultDBCAsset_FunctionAddress, "Yang_AbnormalStateDissolveDBC", Classes.FObjectProperty);
		SetDefaultDBCAsset_IsValid = SetDefaultDBCAsset_FunctionAddress != IntPtr.Zero && SetDefaultDBCAsset__NormalDissolveDBC_IsValid && SetDefaultDBCAsset_Burn_AbnormalStateDeadDBC_IsValid && SetDefaultDBCAsset_Burn_AbnormalStateDissolveDBC_IsValid && SetDefaultDBCAsset_Thunder_AbnormalStateDeadDBC_IsValid && SetDefaultDBCAsset_Thunder_AbnormalStateDissolveDBC_IsValid && SetDefaultDBCAsset_Poison_AbnormalStateDeadDBC_IsValid && SetDefaultDBCAsset_Poison_AbnormalStateDissolveDBC_IsValid && SetDefaultDBCAsset_Freeze_AbnormalStateDeadDBC_IsValid && SetDefaultDBCAsset_Freeze_AbnormalStateDissolveDBC_IsValid && SetDefaultDBCAsset_Yin_AbnormalStateDeadDBC_IsValid && SetDefaultDBCAsset_Yin_AbnormalStateDissolveDBC_IsValid && SetDefaultDBCAsset_Yang_AbnormalStateDeadDBC_IsValid && SetDefaultDBCAsset_Yang_AbnormalStateDissolveDBC_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWDataAsset_UnitDeathDispConfig:SetDefaultDBCAsset", SetDefaultDBCAsset_IsValid);
	}

	static BGWDataAsset_UnitDeathDispConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_UnitDeathDispConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_UnitDeathDispConfig));
	}
}
