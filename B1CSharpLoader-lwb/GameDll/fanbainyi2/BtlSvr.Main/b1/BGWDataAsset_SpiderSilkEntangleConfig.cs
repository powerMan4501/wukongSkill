using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig")]
public class BGWDataAsset_SpiderSilkEntangleConfig : UBGWDataAsset
{
	private static bool NG_Template_IsValid;

	private static int NG_Template_Offset;

	private static bool DBC_Template_IsValid;

	private static int DBC_Template_Offset;

	private static bool MaxCount_IsValid;

	private static int MaxCount_Offset;

	private static bool CountThreshold_HardMove_IsValid;

	private static int CountThreshold_HardMove_Offset;

	private static bool HardMoveBuffID_IsValid;

	private static int HardMoveBuffID_Offset;

	private static bool bExitHardMoveWhenJump_IsValid;

	private static int bExitHardMoveWhenJump_Offset;

	private static FFieldAddress bExitHardMoveWhenJump_PropertyAddress;

	private static bool EntangleSkillEffectID_IsValid;

	private static int EntangleSkillEffectID_Offset;

	private static bool SkillAccCountMapping_IsValid;

	private static int SkillAccCountMapping_Offset;

	private static FFieldAddress SkillAccCountMapping_PropertyAddress;

	private TMapReadWriteMarshaler<int, float> SkillAccCountMapping_Marshaler;

	private static bool SpeedMonitorInterval_IsValid;

	private static int SpeedMonitorInterval_Offset;

	private static bool MappingCurve_Speed_IsValid;

	private static int MappingCurve_Speed_Offset;

	private static bool IncreaseCount_OnJump_IsValid;

	private static int IncreaseCount_OnJump_Offset;

	private static bool IncreaseCount_OnLand_IsValid;

	private static int IncreaseCount_OnLand_Offset;

	private static bool Mapping_NiagaraParam_IsValid;

	private static int Mapping_NiagaraParam_Offset;

	private static FFieldAddress Mapping_NiagaraParam_PropertyAddress;

	private TArrayReadWriteMarshaler<FSilkEntangleNiagaraParamMapping> Mapping_NiagaraParam_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("蛛丝特效")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:NG_Template")]
	public UNiagaraSystem NG_Template
	{
		get
		{
			CheckDestroyed();
			if (!NG_Template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:NG_Template");
				return null;
			}
			return UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(base.Address, NG_Template_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NG_Template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:NG_Template");
			}
			else
			{
				UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(base.Address, NG_Template_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("蛛丝特效DBC")]
	[Tooltip("特效的MetaString中需要填写'SpiderSilkEntangle'作为创建出来的NiagaraComp的Tag")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:DBC_Template")]
	public BGWDataAsset_B1DBC DBC_Template
	{
		get
		{
			CheckDestroyed();
			if (!DBC_Template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:DBC_Template");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_B1DBC>.FromNative(IntPtr.Add(base.Address, DBC_Template_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DBC_Template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:DBC_Template");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_B1DBC>.ToNative(IntPtr.Add(base.Address, DBC_Template_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("蛛丝数量上限")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:MaxCount")]
	public float MaxCount
	{
		get
		{
			CheckDestroyed();
			if (!MaxCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:MaxCount");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:MaxCount");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxCount_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("进入艰难移动的Count阈值")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:CountThreshold_HardMove")]
	public float CountThreshold_HardMove
	{
		get
		{
			CheckDestroyed();
			if (!CountThreshold_HardMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:CountThreshold_HardMove");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CountThreshold_HardMove_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CountThreshold_HardMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:CountThreshold_HardMove");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CountThreshold_HardMove_Offset), value);
			}
		}
	}

	[DisplayName("蛛丝艰难移动的BuffID")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:HardMoveBuffID")]
	public int HardMoveBuffID
	{
		get
		{
			CheckDestroyed();
			if (!HardMoveBuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:HardMoveBuffID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, HardMoveBuffID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HardMoveBuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:HardMoveBuffID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, HardMoveBuffID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("落地时会重新判断计数, 决定要不要重新加上艰难行走")]
	[DisplayName("跳跃时退出蛛丝艰难行走状态")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:bExitHardMoveWhenJump")]
	public bool bExitHardMoveWhenJump
	{
		get
		{
			CheckDestroyed();
			if (!bExitHardMoveWhenJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:bExitHardMoveWhenJump");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bExitHardMoveWhenJump_Offset), 0, bExitHardMoveWhenJump_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bExitHardMoveWhenJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:bExitHardMoveWhenJump");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bExitHardMoveWhenJump_Offset), 0, bExitHardMoveWhenJump_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("缠绕受击SkillEffectID")]
	[Tooltip("积累值满的时候会触发该Effect")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:EntangleSkillEffectID")]
	public int EntangleSkillEffectID
	{
		get
		{
			CheckDestroyed();
			if (!EntangleSkillEffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:EntangleSkillEffectID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EntangleSkillEffectID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EntangleSkillEffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:EntangleSkillEffectID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EntangleSkillEffectID_Offset), value);
			}
		}
	}

	[DisplayName("技能增加计数映射表")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:SkillAccCountMapping")]
	public TMapReadWrite<int, float> SkillAccCountMapping
	{
		get
		{
			CheckDestroyed();
			if (!SkillAccCountMapping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:SkillAccCountMapping");
				return null;
			}
			if (SkillAccCountMapping_Marshaler == null)
			{
				SkillAccCountMapping_Marshaler = new TMapReadWriteMarshaler<int, float>(1, SkillAccCountMapping_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return SkillAccCountMapping_Marshaler.FromNative(IntPtr.Add(base.Address, SkillAccCountMapping_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("速度监听间隔")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:SpeedMonitorInterval")]
	public float SpeedMonitorInterval
	{
		get
		{
			CheckDestroyed();
			if (!SpeedMonitorInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:SpeedMonitorInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpeedMonitorInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpeedMonitorInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:SpeedMonitorInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpeedMonitorInterval_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("速度->CountAcc映射曲线")]
	[Tooltip("曲线x轴是速度, y轴是计数增量")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:MappingCurve_Speed")]
	public UCurveFloat MappingCurve_Speed
	{
		get
		{
			CheckDestroyed();
			if (!MappingCurve_Speed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:MappingCurve_Speed");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, MappingCurve_Speed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MappingCurve_Speed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:MappingCurve_Speed");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, MappingCurve_Speed_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("跳跃增加计数量")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:IncreaseCount_OnJump")]
	public float IncreaseCount_OnJump
	{
		get
		{
			CheckDestroyed();
			if (!IncreaseCount_OnJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:IncreaseCount_OnJump");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IncreaseCount_OnJump_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IncreaseCount_OnJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:IncreaseCount_OnJump");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IncreaseCount_OnJump_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("落地增加计数量")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:IncreaseCount_OnLand")]
	public float IncreaseCount_OnLand
	{
		get
		{
			CheckDestroyed();
			if (!IncreaseCount_OnLand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:IncreaseCount_OnLand");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IncreaseCount_OnLand_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IncreaseCount_OnLand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:IncreaseCount_OnLand");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IncreaseCount_OnLand_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("key是Niagara参数名，曲线x轴是计数总数, y轴是NiagaraParam值")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:Mapping_NiagaraParam")]
	public TArrayReadWrite<FSilkEntangleNiagaraParamMapping> Mapping_NiagaraParam
	{
		get
		{
			CheckDestroyed();
			if (!Mapping_NiagaraParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig:Mapping_NiagaraParam");
				return null;
			}
			if (Mapping_NiagaraParam_Marshaler == null)
			{
				Mapping_NiagaraParam_Marshaler = new TArrayReadWriteMarshaler<FSilkEntangleNiagaraParamMapping>(1, Mapping_NiagaraParam_PropertyAddress, CachedMarshalingDelegates<FSilkEntangleNiagaraParamMapping, FSilkEntangleNiagaraParamMapping>.FromNative, CachedMarshalingDelegates<FSilkEntangleNiagaraParamMapping, FSilkEntangleNiagaraParamMapping>.ToNative);
			}
			return Mapping_NiagaraParam_Marshaler.FromNative(IntPtr.Add(base.Address, Mapping_NiagaraParam_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_SpiderSilkEntangleConfig");
		NG_Template_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NG_Template");
		NG_Template_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NG_Template", Classes.FObjectProperty);
		DBC_Template_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DBC_Template");
		DBC_Template_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DBC_Template", Classes.FObjectProperty);
		MaxCount_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxCount");
		MaxCount_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxCount", Classes.FFloatProperty);
		CountThreshold_HardMove_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CountThreshold_HardMove");
		CountThreshold_HardMove_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CountThreshold_HardMove", Classes.FFloatProperty);
		HardMoveBuffID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HardMoveBuffID");
		HardMoveBuffID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HardMoveBuffID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bExitHardMoveWhenJump_PropertyAddress, unrealStruct, "bExitHardMoveWhenJump");
		bExitHardMoveWhenJump_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bExitHardMoveWhenJump");
		bExitHardMoveWhenJump_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bExitHardMoveWhenJump", Classes.FBoolProperty);
		EntangleSkillEffectID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EntangleSkillEffectID");
		EntangleSkillEffectID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EntangleSkillEffectID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref SkillAccCountMapping_PropertyAddress, unrealStruct, "SkillAccCountMapping");
		SkillAccCountMapping_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SkillAccCountMapping");
		SkillAccCountMapping_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SkillAccCountMapping", Classes.FMapProperty);
		SpeedMonitorInterval_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpeedMonitorInterval");
		SpeedMonitorInterval_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpeedMonitorInterval", Classes.FFloatProperty);
		MappingCurve_Speed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MappingCurve_Speed");
		MappingCurve_Speed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MappingCurve_Speed", Classes.FObjectProperty);
		IncreaseCount_OnJump_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IncreaseCount_OnJump");
		IncreaseCount_OnJump_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IncreaseCount_OnJump", Classes.FFloatProperty);
		IncreaseCount_OnLand_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IncreaseCount_OnLand");
		IncreaseCount_OnLand_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IncreaseCount_OnLand", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref Mapping_NiagaraParam_PropertyAddress, unrealStruct, "Mapping_NiagaraParam");
		Mapping_NiagaraParam_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Mapping_NiagaraParam");
		Mapping_NiagaraParam_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Mapping_NiagaraParam", Classes.FArrayProperty);
	}

	static BGWDataAsset_SpiderSilkEntangleConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_SpiderSilkEntangleConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_SpiderSilkEntangleConfig));
	}
}
