using System;
using System.Collections.Generic;
using b1.Plugins.GSAnimationKeyBlender;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUSeqAKBActor")]
public class BGUSeqAKBActor : ALevelSequenceActor
{
	private List<Tuple<FName, AActor>> BindingList;

	public static bool s_IsMoreLog;

	private static bool DefaultEasingTime_IsValid;

	private static int DefaultEasingTime_Offset;

	private static bool DefaultEasingFunc_IsValid;

	private static int DefaultEasingFunc_Offset;

	private static FFieldAddress DefaultEasingFunc_PropertyAddress;

	private static bool DefaultEasingBlendExp_IsValid;

	private static int DefaultEasingBlendExp_Offset;

	private static bool DefaultEasingSteps_IsValid;

	private static int DefaultEasingSteps_Offset;

	private static bool DefaultDelayEasingTime_IsValid;

	private static int DefaultDelayEasingTime_Offset;

	private static bool DefaultEnumValEasingType_IsValid;

	private static int DefaultEnumValEasingType_Offset;

	private static FFieldAddress DefaultEnumValEasingType_PropertyAddress;

	private static bool DefaultBoolValEasingType_IsValid;

	private static int DefaultBoolValEasingType_Offset;

	private static FFieldAddress DefaultBoolValEasingType_PropertyAddress;

	private static bool IsStrictStateMatchCfg_IsValid;

	private static int IsStrictStateMatchCfg_Offset;

	private static FFieldAddress IsStrictStateMatchCfg_PropertyAddress;

	private static bool IsAlwaysUsingEndStateAsChanging_IsValid;

	private static int IsAlwaysUsingEndStateAsChanging_Offset;

	private static FFieldAddress IsAlwaysUsingEndStateAsChanging_PropertyAddress;

	private static bool GSBlendCfgList_IsValid;

	private static int GSBlendCfgList_Offset;

	private static FFieldAddress GSBlendCfgList_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSSeqAnimKeyStateBlendCfg> GSBlendCfgList_Marshaler;

	private static bool GSAnimKeyStateBlenderObj_IsValid;

	private static int GSAnimKeyStateBlenderObj_Offset;

	private static bool DoTick_IsValid;

	private static IntPtr DoTick_FunctionAddress;

	private static int DoTick_ParamsSize;

	private static bool DoTick_DeltaSeconds_IsValid;

	private static int DoTick_DeltaSeconds_Offset;

	private static bool GSInit_IsValid;

	private static IntPtr GSInit_FunctionAddress;

	private static int GSInit_ParamsSize;

	private static bool ToState_IsValid;

	private static IntPtr ToState_FunctionAddress;

	private static int ToState_ParamsSize;

	private static bool ToState_TargetState_IsValid;

	private static int ToState_TargetState_Offset;

	private static bool ToState_InStateDelayEasingTime_IsValid;

	private static int ToState_InStateDelayEasingTime_Offset;

	private static bool ToState_InStateOverideEasingTime_IsValid;

	private static int ToState_InStateOverideEasingTime_Offset;

	private static bool OnAKBStateEndFunc_IsValid;

	private static IntPtr OnAKBStateEndFunc_FunctionAddress;

	private static int OnAKBStateEndFunc_ParamsSize;

	private static bool OnAKBStateEndFunc_BegineState_IsValid;

	private static int OnAKBStateEndFunc_BegineState_Offset;

	private static bool OnAKBStateEndFunc_EndState_IsValid;

	private static int OnAKBStateEndFunc_EndState_Offset;

	private static bool OnAKBStateEndFunc_IsForceImSet_IsValid;

	private static int OnAKBStateEndFunc_IsForceImSet_Offset;

	private static FFieldAddress OnAKBStateEndFunc_IsForceImSet_PropertyAddress;

	private static bool OnAKBStateBeginFunc_IsValid;

	private static IntPtr OnAKBStateBeginFunc_FunctionAddress;

	private static int OnAKBStateBeginFunc_ParamsSize;

	private static bool OnAKBStateBeginFunc_BegineState_IsValid;

	private static int OnAKBStateBeginFunc_BegineState_Offset;

	private static bool OnAKBStateBeginFunc_EndState_IsValid;

	private static int OnAKBStateBeginFunc_EndState_Offset;

	private static bool OnAKBStateBeginFunc_IsForceImSet_IsValid;

	private static int OnAKBStateBeginFunc_IsForceImSet_Offset;

	private static FFieldAddress OnAKBStateBeginFunc_IsForceImSet_PropertyAddress;

	private static bool WoodTestAnimKeyState_IsValid;

	private static IntPtr WoodTestAnimKeyState_FunctionAddress;

	private static int WoodTestAnimKeyState_ParamsSize;

	private static bool WoodTestAnimKeyState_AnimName_IsValid;

	private static int WoodTestAnimKeyState_AnimName_Offset;

	private static FFieldAddress WoodTestAnimKeyState_AnimName_PropertyAddress;

	private static bool WoodTestAnimKeyState_TargetState_IsValid;

	private static int WoodTestAnimKeyState_TargetState_Offset;

	private static FFieldAddress WoodTestAnimKeyState_TargetState_PropertyAddress;

	private static bool WoodTestAnimKeyState_InStateDelayEasingTime_IsValid;

	private static int WoodTestAnimKeyState_InStateDelayEasingTime_Offset;

	private static bool WoodTestAnimKeyState_IsForce_IsValid;

	private static int WoodTestAnimKeyState_IsForce_Offset;

	private static FFieldAddress WoodTestAnimKeyState_IsForce_PropertyAddress;

	private static bool OnAKBStateInteruptFunc_IsValid;

	private static IntPtr OnAKBStateInteruptFunc_FunctionAddress;

	private static int OnAKBStateInteruptFunc_ParamsSize;

	private static bool OnAKBStateInteruptFunc_BegineState_IsValid;

	private static int OnAKBStateInteruptFunc_BegineState_Offset;

	private static bool OnAKBStateInteruptFunc_EndState_IsValid;

	private static int OnAKBStateInteruptFunc_EndState_Offset;

	private static bool OnAKBStateInteruptFunc_IsForceImSet_IsValid;

	private static int OnAKBStateInteruptFunc_IsForceImSet_Offset;

	private static FFieldAddress OnAKBStateInteruptFunc_IsForceImSet_PropertyAddress;

	private static bool GSBeforeInitAddBindingActor_IsValid;

	private static IntPtr GSBeforeInitAddBindingActor_FunctionAddress;

	private static int GSBeforeInitAddBindingActor_ParamsSize;

	private static bool GSBeforeInitAddBindingActor_BindingActorTagName_IsValid;

	private static int GSBeforeInitAddBindingActor_BindingActorTagName_Offset;

	private static bool GSBeforeInitAddBindingActor_InActor_IsValid;

	private static int GSBeforeInitAddBindingActor_InActor_Offset;

	private static bool GetPredicToStateCfgEasingTime_IsValid;

	private static IntPtr GetPredicToStateCfgEasingTime_FunctionAddress;

	private static int GetPredicToStateCfgEasingTime_ParamsSize;

	private static bool GetPredicToStateCfgEasingTime_TargetState_IsValid;

	private static int GetPredicToStateCfgEasingTime_TargetState_Offset;

	private static bool GetPredicToStateCfgEasingTime_PredicCfgEasingTime_IsValid;

	private static int GetPredicToStateCfgEasingTime_PredicCfgEasingTime_Offset;

	private static bool GetPredicToStateCfgEasingTime_PredicCfgDelayEasingTime_IsValid;

	private static int GetPredicToStateCfgEasingTime_PredicCfgDelayEasingTime_Offset;

	[BlueprintReadWrite]
	[DisplayName("默认的切换表演时间")]
	[UProperty]
	[Category("GSBlendConfig")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUSeqAKBActor:DefaultEasingTime")]
	public float DefaultEasingTime
	{
		get
		{
			CheckDestroyed();
			if (!DefaultEasingTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSeqAKBActor:DefaultEasingTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DefaultEasingTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultEasingTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSeqAKBActor:DefaultEasingTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DefaultEasingTime_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("默认的切换融合方式")]
	[Category("GSBlendConfig")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUSeqAKBActor:DefaultEasingFunc")]
	public EEasingFunc DefaultEasingFunc
	{
		get
		{
			CheckDestroyed();
			if (!DefaultEasingFunc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSeqAKBActor:DefaultEasingFunc");
				return EEasingFunc.Linear;
			}
			return EnumMarshaler<EEasingFunc>.FromNative(IntPtr.Add(base.Address, DefaultEasingFunc_Offset), 0, DefaultEasingFunc_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DefaultEasingFunc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSeqAKBActor:DefaultEasingFunc");
			}
			else
			{
				EnumMarshaler<EEasingFunc>.ToNative(IntPtr.Add(base.Address, DefaultEasingFunc_Offset), 0, DefaultEasingFunc_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UMeta(MDFunc.AdvancedDisplay)]
	[UMeta(MD.ToolTip, "建议非必要不改这个值,是控制融合曲线的参数,保持为2.0")]
	[DisplayName("默认的切换融合方式_参数Exp")]
	[Category("GSBlendConfig|Advanced")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSeqAKBActor:DefaultEasingBlendExp")]
	public float DefaultEasingBlendExp
	{
		get
		{
			CheckDestroyed();
			if (!DefaultEasingBlendExp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSeqAKBActor:DefaultEasingBlendExp");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DefaultEasingBlendExp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultEasingBlendExp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSeqAKBActor:DefaultEasingBlendExp");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DefaultEasingBlendExp_Offset), value);
			}
		}
	}

	[UMeta(MDFunc.AdvancedDisplay)]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSBlendConfig|Advanced")]
	[DisplayName("默认的切换融合方式_参数Steps")]
	[UMeta(MD.ToolTip, "只有融合方式为Step时,这个参数才生效,建议谨慎修改")]
	[USharpPath("/Script/b1-Managed.BGUSeqAKBActor:DefaultEasingSteps")]
	public int DefaultEasingSteps
	{
		get
		{
			CheckDestroyed();
			if (!DefaultEasingSteps_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSeqAKBActor:DefaultEasingSteps");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DefaultEasingSteps_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultEasingSteps_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSeqAKBActor:DefaultEasingSteps");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DefaultEasingSteps_Offset), value);
			}
		}
	}

	[Category("GSBlendConfig|Advanced")]
	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MD.ToolTip, "必须小于_默认的切换表演时间，是指切换开始前的多少秒什么也不干")]
	[UMeta(MDFunc.AdvancedDisplay)]
	[DisplayName("切换表演时间_延后时间")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUSeqAKBActor:DefaultDelayEasingTime")]
	public float DefaultDelayEasingTime
	{
		get
		{
			CheckDestroyed();
			if (!DefaultDelayEasingTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSeqAKBActor:DefaultDelayEasingTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DefaultDelayEasingTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultDelayEasingTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSeqAKBActor:DefaultDelayEasingTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DefaultDelayEasingTime_Offset), value);
			}
		}
	}

	[UMeta(MDFunc.AdvancedDisplay)]
	[DisplayName("默认的Enum属性赋值时机")]
	[Category("GSBlendConfig|Advanced")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSeqAKBActor:DefaultEnumValEasingType")]
	public EGSAnimKBEnumBoolEasing DefaultEnumValEasingType
	{
		get
		{
			CheckDestroyed();
			if (!DefaultEnumValEasingType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSeqAKBActor:DefaultEnumValEasingType");
				return EGSAnimKBEnumBoolEasing.GSEnd;
			}
			return EnumMarshaler<EGSAnimKBEnumBoolEasing>.FromNative(IntPtr.Add(base.Address, DefaultEnumValEasingType_Offset), 0, DefaultEnumValEasingType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DefaultEnumValEasingType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSeqAKBActor:DefaultEnumValEasingType");
			}
			else
			{
				EnumMarshaler<EGSAnimKBEnumBoolEasing>.ToNative(IntPtr.Add(base.Address, DefaultEnumValEasingType_Offset), 0, DefaultEnumValEasingType_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDFunc.AdvancedDisplay)]
	[DisplayName("默认的Bool属性赋值时机")]
	[Category("GSBlendConfig|Advanced")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSeqAKBActor:DefaultBoolValEasingType")]
	public EGSAnimKBEnumBoolEasing DefaultBoolValEasingType
	{
		get
		{
			CheckDestroyed();
			if (!DefaultBoolValEasingType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSeqAKBActor:DefaultBoolValEasingType");
				return EGSAnimKBEnumBoolEasing.GSEnd;
			}
			return EnumMarshaler<EGSAnimKBEnumBoolEasing>.FromNative(IntPtr.Add(base.Address, DefaultBoolValEasingType_Offset), 0, DefaultBoolValEasingType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DefaultBoolValEasingType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSeqAKBActor:DefaultBoolValEasingType");
			}
			else
			{
				EnumMarshaler<EGSAnimKBEnumBoolEasing>.ToNative(IntPtr.Add(base.Address, DefaultBoolValEasingType_Offset), 0, DefaultBoolValEasingType_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("是否为严格的规则匹配(没有配置的state规则就不执行)")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSBlendConfig")]
	[USharpPath("/Script/b1-Managed.BGUSeqAKBActor:IsStrictStateMatchCfg")]
	public bool IsStrictStateMatchCfg
	{
		get
		{
			CheckDestroyed();
			if (!IsStrictStateMatchCfg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSeqAKBActor:IsStrictStateMatchCfg");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsStrictStateMatchCfg_Offset), 0, IsStrictStateMatchCfg_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsStrictStateMatchCfg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSeqAKBActor:IsStrictStateMatchCfg");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsStrictStateMatchCfg_Offset), 0, IsStrictStateMatchCfg_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSBlendConfig")]
	[DisplayName("在Changing状态时,若触发到下一个State, 是否强制EndState来作为BeginState")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSeqAKBActor:IsAlwaysUsingEndStateAsChanging")]
	public bool IsAlwaysUsingEndStateAsChanging
	{
		get
		{
			CheckDestroyed();
			if (!IsAlwaysUsingEndStateAsChanging_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSeqAKBActor:IsAlwaysUsingEndStateAsChanging");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsAlwaysUsingEndStateAsChanging_Offset), 0, IsAlwaysUsingEndStateAsChanging_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsAlwaysUsingEndStateAsChanging_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSeqAKBActor:IsAlwaysUsingEndStateAsChanging");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsAlwaysUsingEndStateAsChanging_Offset), 0, IsAlwaysUsingEndStateAsChanging_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSBlendConfig")]
	[DisplayName("每个状态间切换的融合配置")]
	[USharpPath("/Script/b1-Managed.BGUSeqAKBActor:GSBlendCfgList")]
	public TArrayReadWrite<FGSSeqAnimKeyStateBlendCfg> GSBlendCfgList
	{
		get
		{
			CheckDestroyed();
			if (!GSBlendCfgList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSeqAKBActor:GSBlendCfgList");
				return null;
			}
			if (GSBlendCfgList_Marshaler == null)
			{
				GSBlendCfgList_Marshaler = new TArrayReadWriteMarshaler<FGSSeqAnimKeyStateBlendCfg>(1, GSBlendCfgList_PropertyAddress, CachedMarshalingDelegates<FGSSeqAnimKeyStateBlendCfg, FGSSeqAnimKeyStateBlendCfg>.FromNative, CachedMarshalingDelegates<FGSSeqAnimKeyStateBlendCfg, FGSSeqAnimKeyStateBlendCfg>.ToNative);
			}
			return GSBlendCfgList_Marshaler.FromNative(IntPtr.Add(base.Address, GSBlendCfgList_Offset));
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSeqAKBActor:GSAnimKeyStateBlenderObj")]
	private UGSAnimKeyStateBlender GSAnimKeyStateBlenderObj
	{
		get
		{
			CheckDestroyed();
			if (!GSAnimKeyStateBlenderObj_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSeqAKBActor:GSAnimKeyStateBlenderObj");
				return null;
			}
			return UObjectMarshaler<UGSAnimKeyStateBlender>.FromNative(IntPtr.Add(base.Address, GSAnimKeyStateBlenderObj_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSAnimKeyStateBlenderObj_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSeqAKBActor:GSAnimKeyStateBlenderObj");
			}
			else
			{
				UObjectMarshaler<UGSAnimKeyStateBlender>.ToNative(IntPtr.Add(base.Address, GSAnimKeyStateBlenderObj_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		BindingList = new List<Tuple<FName, AActor>>();
		IsStrictStateMatchCfg = false;
		IsAlwaysUsingEndStateAsChanging = false;
		DefaultEasingTime = 1f;
		DefaultDelayEasingTime = 0f;
		DefaultEasingFunc = EEasingFunc.EaseInOut;
		DefaultEasingBlendExp = 2f;
		DefaultEasingSteps = 2;
		DefaultEnumValEasingType = EGSAnimKBEnumBoolEasing.GSEnd;
		DefaultBoolValEasingType = EGSAnimKBEnumBoolEasing.GSEnd;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUSeqAKBActor:OnAKBStateEndFunc")]
	public void OnAKBStateEndFunc(FName BegineState, FName EndState, bool IsForceImSet)
	{
		_ = DebugConfig.IsDebugAKB;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUSeqAKBActor:OnAKBStateBeginFunc")]
	public void OnAKBStateBeginFunc(FName BegineState, FName EndState, bool IsForceImSet)
	{
		_ = DebugConfig.IsDebugAKB;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUSeqAKBActor:OnAKBStateInteruptFunc")]
	public void OnAKBStateInteruptFunc(FName BegineState, FName EndState, bool IsForceImSet)
	{
		_ = DebugConfig.IsDebugAKB;
	}

	private void TestBindFunc()
	{
		GSAnimKeyStateBlenderObj.OnAKBStateBegin.Bind(OnAKBStateBeginFunc);
		GSAnimKeyStateBlenderObj.OnAKBStateInterupt.Bind(OnAKBStateInteruptFunc);
		GSAnimKeyStateBlenderObj.OnAKBStateEnd.Bind(OnAKBStateEndFunc);
	}

	public void BindDelegateToOnAKBStateBegin(FGSOnAKBStateBegin.Signature OnAKBStateBeginDelegate)
	{
		GSAnimKeyStateBlenderObj.OnAKBStateBegin.Bind(OnAKBStateBeginDelegate);
	}

	public void BindDelegateToOnAKBStateInterupt(FGSOnAKBStateInterupt.Signature OnAKBStateInteruptDelegate)
	{
		GSAnimKeyStateBlenderObj.OnAKBStateInterupt.Bind(OnAKBStateInteruptDelegate);
	}

	public void BindDelegateToOnAKBStateEnd(FGSOnAKBStateEnd.Signature OnAKBStateEndDelegate)
	{
		GSAnimKeyStateBlenderObj.OnAKBStateEnd.Bind(OnAKBStateEndDelegate);
	}

	private void ConstructAnimKeyStateBlender()
	{
		_ = DebugConfig.IsDebugAKB;
		GSAnimKeyStateBlenderObj = UGSE_UMGFuncLib.CreateGSAnimKeyStateBlender(this);
		if (BindingList.Count > 0)
		{
			for (int i = 0; i < BindingList.Count; i++)
			{
				GSAnimKeyStateBlenderObj.BeforeInitAddBindingActor(this, BindingList[i].Item1, BindingList[i].Item2);
			}
		}
		BindingList.Clear();
		GSAnimKeyStateBlenderObj.InitSetLevelSequence(this, base.LevelSequenceAsset, IsStrictStateMatchCfg, IsAlwaysUsingEndStateAsChanging);
		GSAnimKeyStateBlenderObj.InitSetDefaultEasingCfg(DefaultEasingTime, DefaultEasingFunc, DefaultEasingBlendExp, DefaultEasingSteps, DefaultEnumValEasingType, DefaultBoolValEasingType, DefaultDelayEasingTime);
		TestBindFunc();
		for (int j = 0; j < GSBlendCfgList.Count; j++)
		{
			float inEasingBlendExp = DefaultEasingBlendExp;
			if (GSBlendCfgList[j].NeedEasingBlendExp)
			{
				inEasingBlendExp = GSBlendCfgList[j].EasingBlendExp;
			}
			int inEasingSteps = DefaultEasingSteps;
			if (GSBlendCfgList[j].NeedEasingSteps)
			{
				inEasingSteps = GSBlendCfgList[j].EasingSteps;
			}
			GSAnimKeyStateBlenderObj.InitAddStateToStateEasingCfg(new FName(GSBlendCfgList[j].FromStateName), new FName(GSBlendCfgList[j].ToStateName), GSBlendCfgList[j].EasingTime, GSBlendCfgList[j].EasingFunc, inEasingBlendExp, inEasingSteps, GSBlendCfgList[j].EnumValEasingType, GSBlendCfgList[j].BoolValEasingType, GSBlendCfgList[j].DelayEasingTime);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUSeqAKBActor:GSBeforeInitAddBindingActor")]
	public void GSBeforeInitAddBindingActor(FName BindingActorTagName, AActor InActor)
	{
		BindingList.Add(new Tuple<FName, AActor>(BindingActorTagName, InActor));
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUSeqAKBActor:GSInit")]
	public void GSInit()
	{
		ConstructAnimKeyStateBlender();
	}

	public void ForceSetStateImmediately(FName TargetState)
	{
		_ = DebugConfig.IsDebugAKB;
		if (GSAnimKeyStateBlenderObj.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("GSAnimKeyStateBlenderObj Invalid");
		}
		else
		{
			GSAnimKeyStateBlenderObj.ForceSetStateImmediately(TargetState);
		}
	}

	public FName GetCurrentStateName()
	{
		return GSAnimKeyStateBlenderObj.GetCurrentStateName();
	}

	public FName GetBeginStateName()
	{
		return GSAnimKeyStateBlenderObj.GetBeginStateName();
	}

	public FName GetEndStateName()
	{
		return GSAnimKeyStateBlenderObj.GetEndStateName();
	}

	public bool IsInBlending()
	{
		return GSAnimKeyStateBlenderObj.IsInBlending();
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUSeqAKBActor:GetPredicToStateCfgEasingTime")]
	public void GetPredicToStateCfgEasingTime(FName TargetState, out float PredicCfgEasingTime, out float PredicCfgDelayEasingTime)
	{
		_ = DebugConfig.IsDebugAKB;
		PredicCfgEasingTime = GSAnimKeyStateBlenderObj.GetPredicToStateCfgEasingTime(TargetState, out PredicCfgDelayEasingTime);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUSeqAKBActor:ToState")]
	public void ToState(FName TargetState, float InStateDelayEasingTime = 0f, float InStateOverideEasingTime = -1f)
	{
		_ = DebugConfig.IsDebugAKB;
		if (GSAnimKeyStateBlenderObj.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("GSAnimKeyStateBlenderObj Invalid");
		}
		else
		{
			GSAnimKeyStateBlenderObj.ToState(TargetState, InStateDelayEasingTime, InStateOverideEasingTime);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUSeqAKBActor:WoodTestAnimKeyState")]
	public void WoodTestAnimKeyState(string AnimName, string TargetState, float InStateDelayEasingTime, bool IsForce)
	{
		UGSAnimKeyStateBlender gSAnimKeyStateBlenderObj = GSAnimKeyStateBlenderObj;
		if (!gSAnimKeyStateBlenderObj.IsNullOrDestroyed())
		{
			if (IsForce)
			{
				gSAnimKeyStateBlenderObj.ForceSetStateImmediately(new FName(TargetState));
			}
			else
			{
				gSAnimKeyStateBlenderObj.ToState(new FName(TargetState), InStateDelayEasingTime);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUSeqAKBActor:DoTick")]
	public void DoTick(float DeltaSeconds)
	{
		if (!GSAnimKeyStateBlenderObj.IsNullOrDestroyed())
		{
			GSAnimKeyStateBlenderObj?.DoTick(DeltaSeconds);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSeqAKBActor:DoTick")]
	private static void DoTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSeqAKBActor bGUSeqAKBActor = GCHelper.Find<BGUSeqAKBActor>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, DoTick_DeltaSeconds_Offset));
		bGUSeqAKBActor.DoTick(deltaSeconds);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSeqAKBActor:GSInit")]
	private static void GSInit__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSeqAKBActor bGUSeqAKBActor = GCHelper.Find<BGUSeqAKBActor>(obj);
		bGUSeqAKBActor.GSInit();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSeqAKBActor:ToState")]
	private static void ToState__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSeqAKBActor bGUSeqAKBActor = GCHelper.Find<BGUSeqAKBActor>(obj);
		FName targetState = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, ToState_TargetState_Offset));
		float inStateDelayEasingTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ToState_InStateDelayEasingTime_Offset));
		float inStateOverideEasingTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ToState_InStateOverideEasingTime_Offset));
		bGUSeqAKBActor.ToState(targetState, inStateDelayEasingTime, inStateOverideEasingTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSeqAKBActor:OnAKBStateEndFunc")]
	private static void OnAKBStateEndFunc__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSeqAKBActor bGUSeqAKBActor = GCHelper.Find<BGUSeqAKBActor>(obj);
		FName begineState = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, OnAKBStateEndFunc_BegineState_Offset));
		FName endState = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, OnAKBStateEndFunc_EndState_Offset));
		bool isForceImSet = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnAKBStateEndFunc_IsForceImSet_Offset), 0, OnAKBStateEndFunc_IsForceImSet_PropertyAddress.Address);
		bGUSeqAKBActor.OnAKBStateEndFunc(begineState, endState, isForceImSet);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSeqAKBActor:OnAKBStateBeginFunc")]
	private static void OnAKBStateBeginFunc__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSeqAKBActor bGUSeqAKBActor = GCHelper.Find<BGUSeqAKBActor>(obj);
		FName begineState = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, OnAKBStateBeginFunc_BegineState_Offset));
		FName endState = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, OnAKBStateBeginFunc_EndState_Offset));
		bool isForceImSet = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnAKBStateBeginFunc_IsForceImSet_Offset), 0, OnAKBStateBeginFunc_IsForceImSet_PropertyAddress.Address);
		bGUSeqAKBActor.OnAKBStateBeginFunc(begineState, endState, isForceImSet);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSeqAKBActor:WoodTestAnimKeyState")]
	private static void WoodTestAnimKeyState__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSeqAKBActor bGUSeqAKBActor = GCHelper.Find<BGUSeqAKBActor>(obj);
		string animName = FStringMarshaler.FromNative(IntPtr.Add(buffer, WoodTestAnimKeyState_AnimName_Offset));
		string targetState = FStringMarshaler.FromNative(IntPtr.Add(buffer, WoodTestAnimKeyState_TargetState_Offset));
		float inStateDelayEasingTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, WoodTestAnimKeyState_InStateDelayEasingTime_Offset));
		bool isForce = BoolMarshaler.FromNative(IntPtr.Add(buffer, WoodTestAnimKeyState_IsForce_Offset), 0, WoodTestAnimKeyState_IsForce_PropertyAddress.Address);
		bGUSeqAKBActor.WoodTestAnimKeyState(animName, targetState, inStateDelayEasingTime, isForce);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSeqAKBActor:OnAKBStateInteruptFunc")]
	private static void OnAKBStateInteruptFunc__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSeqAKBActor bGUSeqAKBActor = GCHelper.Find<BGUSeqAKBActor>(obj);
		FName begineState = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, OnAKBStateInteruptFunc_BegineState_Offset));
		FName endState = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, OnAKBStateInteruptFunc_EndState_Offset));
		bool isForceImSet = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnAKBStateInteruptFunc_IsForceImSet_Offset), 0, OnAKBStateInteruptFunc_IsForceImSet_PropertyAddress.Address);
		bGUSeqAKBActor.OnAKBStateInteruptFunc(begineState, endState, isForceImSet);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSeqAKBActor:GSBeforeInitAddBindingActor")]
	private static void GSBeforeInitAddBindingActor__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSeqAKBActor bGUSeqAKBActor = GCHelper.Find<BGUSeqAKBActor>(obj);
		FName bindingActorTagName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, GSBeforeInitAddBindingActor_BindingActorTagName_Offset));
		AActor inActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GSBeforeInitAddBindingActor_InActor_Offset));
		bGUSeqAKBActor.GSBeforeInitAddBindingActor(bindingActorTagName, inActor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSeqAKBActor:GetPredicToStateCfgEasingTime")]
	private static void GetPredicToStateCfgEasingTime__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSeqAKBActor bGUSeqAKBActor = GCHelper.Find<BGUSeqAKBActor>(obj);
		FName targetState = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, GetPredicToStateCfgEasingTime_TargetState_Offset));
		bGUSeqAKBActor.GetPredicToStateCfgEasingTime(targetState, out var PredicCfgEasingTime, out var PredicCfgDelayEasingTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, GetPredicToStateCfgEasingTime_PredicCfgEasingTime_Offset), PredicCfgEasingTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, GetPredicToStateCfgEasingTime_PredicCfgDelayEasingTime_Offset), PredicCfgDelayEasingTime);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUSeqAKBActor");
		DefaultEasingTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultEasingTime");
		DefaultEasingTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultEasingTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref DefaultEasingFunc_PropertyAddress, intPtr, "DefaultEasingFunc");
		DefaultEasingFunc_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultEasingFunc");
		DefaultEasingFunc_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultEasingFunc", Classes.FEnumProperty);
		DefaultEasingBlendExp_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultEasingBlendExp");
		DefaultEasingBlendExp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultEasingBlendExp", Classes.FFloatProperty);
		DefaultEasingSteps_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultEasingSteps");
		DefaultEasingSteps_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultEasingSteps", Classes.FIntProperty);
		DefaultDelayEasingTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultDelayEasingTime");
		DefaultDelayEasingTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultDelayEasingTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref DefaultEnumValEasingType_PropertyAddress, intPtr, "DefaultEnumValEasingType");
		DefaultEnumValEasingType_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultEnumValEasingType");
		DefaultEnumValEasingType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultEnumValEasingType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref DefaultBoolValEasingType_PropertyAddress, intPtr, "DefaultBoolValEasingType");
		DefaultBoolValEasingType_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultBoolValEasingType");
		DefaultBoolValEasingType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultBoolValEasingType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsStrictStateMatchCfg_PropertyAddress, intPtr, "IsStrictStateMatchCfg");
		IsStrictStateMatchCfg_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsStrictStateMatchCfg");
		IsStrictStateMatchCfg_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsStrictStateMatchCfg", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsAlwaysUsingEndStateAsChanging_PropertyAddress, intPtr, "IsAlwaysUsingEndStateAsChanging");
		IsAlwaysUsingEndStateAsChanging_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsAlwaysUsingEndStateAsChanging");
		IsAlwaysUsingEndStateAsChanging_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsAlwaysUsingEndStateAsChanging", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref GSBlendCfgList_PropertyAddress, intPtr, "GSBlendCfgList");
		GSBlendCfgList_Offset = NativeReflection.GetPropertyOffset(intPtr, "GSBlendCfgList");
		GSBlendCfgList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GSBlendCfgList", Classes.FArrayProperty);
		GSAnimKeyStateBlenderObj_Offset = NativeReflection.GetPropertyOffset(intPtr, "GSAnimKeyStateBlenderObj");
		GSAnimKeyStateBlenderObj_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GSAnimKeyStateBlenderObj", Classes.FObjectProperty);
		DoTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoTick");
		DoTick_ParamsSize = NativeReflection.GetFunctionParamsSize(DoTick_FunctionAddress);
		DoTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(DoTick_FunctionAddress, "DeltaSeconds");
		DoTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(DoTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		DoTick_IsValid = DoTick_FunctionAddress != IntPtr.Zero && DoTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSeqAKBActor:DoTick", DoTick_IsValid);
		GSInit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSInit");
		GSInit_ParamsSize = NativeReflection.GetFunctionParamsSize(GSInit_FunctionAddress);
		GSInit_IsValid = GSInit_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSeqAKBActor:GSInit", GSInit_IsValid);
		ToState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ToState");
		ToState_ParamsSize = NativeReflection.GetFunctionParamsSize(ToState_FunctionAddress);
		ToState_TargetState_Offset = NativeReflection.GetPropertyOffset(ToState_FunctionAddress, "TargetState");
		ToState_TargetState_IsValid = NativeReflection.ValidatePropertyClass(ToState_FunctionAddress, "TargetState", Classes.FNameProperty);
		ToState_InStateDelayEasingTime_Offset = NativeReflection.GetPropertyOffset(ToState_FunctionAddress, "InStateDelayEasingTime");
		ToState_InStateDelayEasingTime_IsValid = NativeReflection.ValidatePropertyClass(ToState_FunctionAddress, "InStateDelayEasingTime", Classes.FFloatProperty);
		ToState_InStateOverideEasingTime_Offset = NativeReflection.GetPropertyOffset(ToState_FunctionAddress, "InStateOverideEasingTime");
		ToState_InStateOverideEasingTime_IsValid = NativeReflection.ValidatePropertyClass(ToState_FunctionAddress, "InStateOverideEasingTime", Classes.FFloatProperty);
		ToState_IsValid = ToState_FunctionAddress != IntPtr.Zero && ToState_TargetState_IsValid && ToState_InStateDelayEasingTime_IsValid && ToState_InStateOverideEasingTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSeqAKBActor:ToState", ToState_IsValid);
		OnAKBStateEndFunc_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnAKBStateEndFunc");
		OnAKBStateEndFunc_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAKBStateEndFunc_FunctionAddress);
		OnAKBStateEndFunc_BegineState_Offset = NativeReflection.GetPropertyOffset(OnAKBStateEndFunc_FunctionAddress, "BegineState");
		OnAKBStateEndFunc_BegineState_IsValid = NativeReflection.ValidatePropertyClass(OnAKBStateEndFunc_FunctionAddress, "BegineState", Classes.FNameProperty);
		OnAKBStateEndFunc_EndState_Offset = NativeReflection.GetPropertyOffset(OnAKBStateEndFunc_FunctionAddress, "EndState");
		OnAKBStateEndFunc_EndState_IsValid = NativeReflection.ValidatePropertyClass(OnAKBStateEndFunc_FunctionAddress, "EndState", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref OnAKBStateEndFunc_IsForceImSet_PropertyAddress, OnAKBStateEndFunc_FunctionAddress, "IsForceImSet");
		OnAKBStateEndFunc_IsForceImSet_Offset = NativeReflection.GetPropertyOffset(OnAKBStateEndFunc_FunctionAddress, "IsForceImSet");
		OnAKBStateEndFunc_IsForceImSet_IsValid = NativeReflection.ValidatePropertyClass(OnAKBStateEndFunc_FunctionAddress, "IsForceImSet", Classes.FBoolProperty);
		OnAKBStateEndFunc_IsValid = OnAKBStateEndFunc_FunctionAddress != IntPtr.Zero && OnAKBStateEndFunc_BegineState_IsValid && OnAKBStateEndFunc_EndState_IsValid && OnAKBStateEndFunc_IsForceImSet_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSeqAKBActor:OnAKBStateEndFunc", OnAKBStateEndFunc_IsValid);
		OnAKBStateBeginFunc_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnAKBStateBeginFunc");
		OnAKBStateBeginFunc_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAKBStateBeginFunc_FunctionAddress);
		OnAKBStateBeginFunc_BegineState_Offset = NativeReflection.GetPropertyOffset(OnAKBStateBeginFunc_FunctionAddress, "BegineState");
		OnAKBStateBeginFunc_BegineState_IsValid = NativeReflection.ValidatePropertyClass(OnAKBStateBeginFunc_FunctionAddress, "BegineState", Classes.FNameProperty);
		OnAKBStateBeginFunc_EndState_Offset = NativeReflection.GetPropertyOffset(OnAKBStateBeginFunc_FunctionAddress, "EndState");
		OnAKBStateBeginFunc_EndState_IsValid = NativeReflection.ValidatePropertyClass(OnAKBStateBeginFunc_FunctionAddress, "EndState", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref OnAKBStateBeginFunc_IsForceImSet_PropertyAddress, OnAKBStateBeginFunc_FunctionAddress, "IsForceImSet");
		OnAKBStateBeginFunc_IsForceImSet_Offset = NativeReflection.GetPropertyOffset(OnAKBStateBeginFunc_FunctionAddress, "IsForceImSet");
		OnAKBStateBeginFunc_IsForceImSet_IsValid = NativeReflection.ValidatePropertyClass(OnAKBStateBeginFunc_FunctionAddress, "IsForceImSet", Classes.FBoolProperty);
		OnAKBStateBeginFunc_IsValid = OnAKBStateBeginFunc_FunctionAddress != IntPtr.Zero && OnAKBStateBeginFunc_BegineState_IsValid && OnAKBStateBeginFunc_EndState_IsValid && OnAKBStateBeginFunc_IsForceImSet_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSeqAKBActor:OnAKBStateBeginFunc", OnAKBStateBeginFunc_IsValid);
		WoodTestAnimKeyState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "WoodTestAnimKeyState");
		WoodTestAnimKeyState_ParamsSize = NativeReflection.GetFunctionParamsSize(WoodTestAnimKeyState_FunctionAddress);
		NativeReflection.GetPropertyRef(ref WoodTestAnimKeyState_AnimName_PropertyAddress, WoodTestAnimKeyState_FunctionAddress, "AnimName");
		WoodTestAnimKeyState_AnimName_Offset = NativeReflection.GetPropertyOffset(WoodTestAnimKeyState_FunctionAddress, "AnimName");
		WoodTestAnimKeyState_AnimName_IsValid = NativeReflection.ValidatePropertyClass(WoodTestAnimKeyState_FunctionAddress, "AnimName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref WoodTestAnimKeyState_TargetState_PropertyAddress, WoodTestAnimKeyState_FunctionAddress, "TargetState");
		WoodTestAnimKeyState_TargetState_Offset = NativeReflection.GetPropertyOffset(WoodTestAnimKeyState_FunctionAddress, "TargetState");
		WoodTestAnimKeyState_TargetState_IsValid = NativeReflection.ValidatePropertyClass(WoodTestAnimKeyState_FunctionAddress, "TargetState", Classes.FStrProperty);
		WoodTestAnimKeyState_InStateDelayEasingTime_Offset = NativeReflection.GetPropertyOffset(WoodTestAnimKeyState_FunctionAddress, "InStateDelayEasingTime");
		WoodTestAnimKeyState_InStateDelayEasingTime_IsValid = NativeReflection.ValidatePropertyClass(WoodTestAnimKeyState_FunctionAddress, "InStateDelayEasingTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref WoodTestAnimKeyState_IsForce_PropertyAddress, WoodTestAnimKeyState_FunctionAddress, "IsForce");
		WoodTestAnimKeyState_IsForce_Offset = NativeReflection.GetPropertyOffset(WoodTestAnimKeyState_FunctionAddress, "IsForce");
		WoodTestAnimKeyState_IsForce_IsValid = NativeReflection.ValidatePropertyClass(WoodTestAnimKeyState_FunctionAddress, "IsForce", Classes.FBoolProperty);
		WoodTestAnimKeyState_IsValid = WoodTestAnimKeyState_FunctionAddress != IntPtr.Zero && WoodTestAnimKeyState_AnimName_IsValid && WoodTestAnimKeyState_TargetState_IsValid && WoodTestAnimKeyState_InStateDelayEasingTime_IsValid && WoodTestAnimKeyState_IsForce_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSeqAKBActor:WoodTestAnimKeyState", WoodTestAnimKeyState_IsValid);
		OnAKBStateInteruptFunc_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnAKBStateInteruptFunc");
		OnAKBStateInteruptFunc_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAKBStateInteruptFunc_FunctionAddress);
		OnAKBStateInteruptFunc_BegineState_Offset = NativeReflection.GetPropertyOffset(OnAKBStateInteruptFunc_FunctionAddress, "BegineState");
		OnAKBStateInteruptFunc_BegineState_IsValid = NativeReflection.ValidatePropertyClass(OnAKBStateInteruptFunc_FunctionAddress, "BegineState", Classes.FNameProperty);
		OnAKBStateInteruptFunc_EndState_Offset = NativeReflection.GetPropertyOffset(OnAKBStateInteruptFunc_FunctionAddress, "EndState");
		OnAKBStateInteruptFunc_EndState_IsValid = NativeReflection.ValidatePropertyClass(OnAKBStateInteruptFunc_FunctionAddress, "EndState", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref OnAKBStateInteruptFunc_IsForceImSet_PropertyAddress, OnAKBStateInteruptFunc_FunctionAddress, "IsForceImSet");
		OnAKBStateInteruptFunc_IsForceImSet_Offset = NativeReflection.GetPropertyOffset(OnAKBStateInteruptFunc_FunctionAddress, "IsForceImSet");
		OnAKBStateInteruptFunc_IsForceImSet_IsValid = NativeReflection.ValidatePropertyClass(OnAKBStateInteruptFunc_FunctionAddress, "IsForceImSet", Classes.FBoolProperty);
		OnAKBStateInteruptFunc_IsValid = OnAKBStateInteruptFunc_FunctionAddress != IntPtr.Zero && OnAKBStateInteruptFunc_BegineState_IsValid && OnAKBStateInteruptFunc_EndState_IsValid && OnAKBStateInteruptFunc_IsForceImSet_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSeqAKBActor:OnAKBStateInteruptFunc", OnAKBStateInteruptFunc_IsValid);
		GSBeforeInitAddBindingActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSBeforeInitAddBindingActor");
		GSBeforeInitAddBindingActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GSBeforeInitAddBindingActor_FunctionAddress);
		GSBeforeInitAddBindingActor_BindingActorTagName_Offset = NativeReflection.GetPropertyOffset(GSBeforeInitAddBindingActor_FunctionAddress, "BindingActorTagName");
		GSBeforeInitAddBindingActor_BindingActorTagName_IsValid = NativeReflection.ValidatePropertyClass(GSBeforeInitAddBindingActor_FunctionAddress, "BindingActorTagName", Classes.FNameProperty);
		GSBeforeInitAddBindingActor_InActor_Offset = NativeReflection.GetPropertyOffset(GSBeforeInitAddBindingActor_FunctionAddress, "InActor");
		GSBeforeInitAddBindingActor_InActor_IsValid = NativeReflection.ValidatePropertyClass(GSBeforeInitAddBindingActor_FunctionAddress, "InActor", Classes.FObjectProperty);
		GSBeforeInitAddBindingActor_IsValid = GSBeforeInitAddBindingActor_FunctionAddress != IntPtr.Zero && GSBeforeInitAddBindingActor_BindingActorTagName_IsValid && GSBeforeInitAddBindingActor_InActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSeqAKBActor:GSBeforeInitAddBindingActor", GSBeforeInitAddBindingActor_IsValid);
		GetPredicToStateCfgEasingTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPredicToStateCfgEasingTime");
		GetPredicToStateCfgEasingTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPredicToStateCfgEasingTime_FunctionAddress);
		GetPredicToStateCfgEasingTime_TargetState_Offset = NativeReflection.GetPropertyOffset(GetPredicToStateCfgEasingTime_FunctionAddress, "TargetState");
		GetPredicToStateCfgEasingTime_TargetState_IsValid = NativeReflection.ValidatePropertyClass(GetPredicToStateCfgEasingTime_FunctionAddress, "TargetState", Classes.FNameProperty);
		GetPredicToStateCfgEasingTime_PredicCfgEasingTime_Offset = NativeReflection.GetPropertyOffset(GetPredicToStateCfgEasingTime_FunctionAddress, "PredicCfgEasingTime");
		GetPredicToStateCfgEasingTime_PredicCfgEasingTime_IsValid = NativeReflection.ValidatePropertyClass(GetPredicToStateCfgEasingTime_FunctionAddress, "PredicCfgEasingTime", Classes.FFloatProperty);
		GetPredicToStateCfgEasingTime_PredicCfgDelayEasingTime_Offset = NativeReflection.GetPropertyOffset(GetPredicToStateCfgEasingTime_FunctionAddress, "PredicCfgDelayEasingTime");
		GetPredicToStateCfgEasingTime_PredicCfgDelayEasingTime_IsValid = NativeReflection.ValidatePropertyClass(GetPredicToStateCfgEasingTime_FunctionAddress, "PredicCfgDelayEasingTime", Classes.FFloatProperty);
		GetPredicToStateCfgEasingTime_IsValid = GetPredicToStateCfgEasingTime_FunctionAddress != IntPtr.Zero && GetPredicToStateCfgEasingTime_TargetState_IsValid && GetPredicToStateCfgEasingTime_PredicCfgEasingTime_IsValid && GetPredicToStateCfgEasingTime_PredicCfgDelayEasingTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSeqAKBActor:GetPredicToStateCfgEasingTime", GetPredicToStateCfgEasingTime_IsValid);
	}

	static BGUSeqAKBActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUSeqAKBActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUSeqAKBActor));
	}
}
