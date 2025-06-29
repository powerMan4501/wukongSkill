using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.GSAnimationKeyBlender;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public class UGSAnimKeyStateBlender : UObject
{
	private static bool AKObjSTList_IsValid;

	private static FFieldAddress AKObjSTList_PropertyAddress;

	private static int AKObjSTList_Offset;

	private TArrayReadOnlyMarshaler<FGSAnimKeyObjST> AKObjSTList_MarshalerCached;

	private static bool IsTicking_IsValid;

	private static FFieldAddress IsTicking_PropertyAddress;

	private static int IsTicking_Offset;

	private static bool OnAKBStateBegin_IsValid;

	private static int OnAKBStateBegin_Offset;

	private FGSOnAKBStateBegin OnAKBStateBegin_DelegateCached;

	private static bool OnAKBStateEnd_IsValid;

	private static int OnAKBStateEnd_Offset;

	private FGSOnAKBStateEnd OnAKBStateEnd_DelegateCached;

	private static bool OnAKBStateInterupt_IsValid;

	private static int OnAKBStateInterupt_Offset;

	private FGSOnAKBStateInterupt OnAKBStateInterupt_DelegateCached;

	private static bool ToState_IsValid;

	private static IntPtr ToState_FunctionAddress;

	private static int ToState_ParamsSize;

	private static bool ToState_TargetStateName_IsValid;

	private static FFieldAddress ToState_TargetStateName_PropertyAddress;

	private static int ToState_TargetStateName_Offset;

	private static bool ToState_InStateDelayEasingTime_IsValid;

	private static FFieldAddress ToState_InStateDelayEasingTime_PropertyAddress;

	private static int ToState_InStateDelayEasingTime_Offset;

	private static bool ToState_InStateOverideEasingTime_IsValid;

	private static FFieldAddress ToState_InStateOverideEasingTime_PropertyAddress;

	private static int ToState_InStateOverideEasingTime_Offset;

	private static bool IsInBlending_IsValid;

	private static IntPtr IsInBlending_FunctionAddress;

	private static int IsInBlending_ParamsSize;

	private static bool IsInBlending_ReturnValue_IsValid;

	private static FFieldAddress IsInBlending_ReturnValue_PropertyAddress;

	private static int IsInBlending_ReturnValue_Offset;

	private static bool InitSetWidgetAnimation_IsValid;

	private static IntPtr InitSetWidgetAnimation_FunctionAddress;

	private static int InitSetWidgetAnimation_ParamsSize;

	private static bool InitSetWidgetAnimation_InRefUserWidget_IsValid;

	private static FFieldAddress InitSetWidgetAnimation_InRefUserWidget_PropertyAddress;

	private static int InitSetWidgetAnimation_InRefUserWidget_Offset;

	private static bool InitSetWidgetAnimation_InWidgetAnimation_IsValid;

	private static FFieldAddress InitSetWidgetAnimation_InWidgetAnimation_PropertyAddress;

	private static int InitSetWidgetAnimation_InWidgetAnimation_Offset;

	private static bool InitSetWidgetAnimation_InIsStrictStateMatchCfg_IsValid;

	private static FFieldAddress InitSetWidgetAnimation_InIsStrictStateMatchCfg_PropertyAddress;

	private static int InitSetWidgetAnimation_InIsStrictStateMatchCfg_Offset;

	private static bool InitSetWidgetAnimation_InIsAlwaysUsingEndStateAsChanging_IsValid;

	private static FFieldAddress InitSetWidgetAnimation_InIsAlwaysUsingEndStateAsChanging_PropertyAddress;

	private static int InitSetWidgetAnimation_InIsAlwaysUsingEndStateAsChanging_Offset;

	private static bool InitSetLevelSequence_IsValid;

	private static IntPtr InitSetLevelSequence_FunctionAddress;

	private static int InitSetLevelSequence_ParamsSize;

	private static bool InitSetLevelSequence_InRefObject_IsValid;

	private static FFieldAddress InitSetLevelSequence_InRefObject_PropertyAddress;

	private static int InitSetLevelSequence_InRefObject_Offset;

	private static bool InitSetLevelSequence_InLevelSequence_IsValid;

	private static FFieldAddress InitSetLevelSequence_InLevelSequence_PropertyAddress;

	private static int InitSetLevelSequence_InLevelSequence_Offset;

	private static bool InitSetLevelSequence_InIsStrictStateMatchCfg_IsValid;

	private static FFieldAddress InitSetLevelSequence_InIsStrictStateMatchCfg_PropertyAddress;

	private static int InitSetLevelSequence_InIsStrictStateMatchCfg_Offset;

	private static bool InitSetLevelSequence_InIsAlwaysUsingEndStateAsChanging_IsValid;

	private static FFieldAddress InitSetLevelSequence_InIsAlwaysUsingEndStateAsChanging_PropertyAddress;

	private static int InitSetLevelSequence_InIsAlwaysUsingEndStateAsChanging_Offset;

	private static bool InitSetDefaultEasingCfg_IsValid;

	private static IntPtr InitSetDefaultEasingCfg_FunctionAddress;

	private static int InitSetDefaultEasingCfg_ParamsSize;

	private static bool InitSetDefaultEasingCfg_InEasingTime_IsValid;

	private static FFieldAddress InitSetDefaultEasingCfg_InEasingTime_PropertyAddress;

	private static int InitSetDefaultEasingCfg_InEasingTime_Offset;

	private static bool InitSetDefaultEasingCfg_InEasingFunc_IsValid;

	private static FFieldAddress InitSetDefaultEasingCfg_InEasingFunc_PropertyAddress;

	private static int InitSetDefaultEasingCfg_InEasingFunc_Offset;

	private static bool InitSetDefaultEasingCfg_InEasingBlendExp_IsValid;

	private static FFieldAddress InitSetDefaultEasingCfg_InEasingBlendExp_PropertyAddress;

	private static int InitSetDefaultEasingCfg_InEasingBlendExp_Offset;

	private static bool InitSetDefaultEasingCfg_InEasingSteps_IsValid;

	private static FFieldAddress InitSetDefaultEasingCfg_InEasingSteps_PropertyAddress;

	private static int InitSetDefaultEasingCfg_InEasingSteps_Offset;

	private static bool InitSetDefaultEasingCfg_InEnumValEasingType_IsValid;

	private static FFieldAddress InitSetDefaultEasingCfg_InEnumValEasingType_PropertyAddress;

	private static int InitSetDefaultEasingCfg_InEnumValEasingType_Offset;

	private static bool InitSetDefaultEasingCfg_InBoolValEasingType_IsValid;

	private static FFieldAddress InitSetDefaultEasingCfg_InBoolValEasingType_PropertyAddress;

	private static int InitSetDefaultEasingCfg_InBoolValEasingType_Offset;

	private static bool InitSetDefaultEasingCfg_InDelayEasingTime_IsValid;

	private static FFieldAddress InitSetDefaultEasingCfg_InDelayEasingTime_PropertyAddress;

	private static int InitSetDefaultEasingCfg_InDelayEasingTime_Offset;

	private static bool InitResetState_IsValid;

	private static IntPtr InitResetState_FunctionAddress;

	private static int InitResetState_ParamsSize;

	private static bool InitAddStateToStateEasingCfg_IsValid;

	private static IntPtr InitAddStateToStateEasingCfg_FunctionAddress;

	private static int InitAddStateToStateEasingCfg_ParamsSize;

	private static bool InitAddStateToStateEasingCfg_FromStateName_IsValid;

	private static FFieldAddress InitAddStateToStateEasingCfg_FromStateName_PropertyAddress;

	private static int InitAddStateToStateEasingCfg_FromStateName_Offset;

	private static bool InitAddStateToStateEasingCfg_ToStateName_IsValid;

	private static FFieldAddress InitAddStateToStateEasingCfg_ToStateName_PropertyAddress;

	private static int InitAddStateToStateEasingCfg_ToStateName_Offset;

	private static bool InitAddStateToStateEasingCfg_InEasingTime_IsValid;

	private static FFieldAddress InitAddStateToStateEasingCfg_InEasingTime_PropertyAddress;

	private static int InitAddStateToStateEasingCfg_InEasingTime_Offset;

	private static bool InitAddStateToStateEasingCfg_InEasingFunc_IsValid;

	private static FFieldAddress InitAddStateToStateEasingCfg_InEasingFunc_PropertyAddress;

	private static int InitAddStateToStateEasingCfg_InEasingFunc_Offset;

	private static bool InitAddStateToStateEasingCfg_InEasingBlendExp_IsValid;

	private static FFieldAddress InitAddStateToStateEasingCfg_InEasingBlendExp_PropertyAddress;

	private static int InitAddStateToStateEasingCfg_InEasingBlendExp_Offset;

	private static bool InitAddStateToStateEasingCfg_InEasingSteps_IsValid;

	private static FFieldAddress InitAddStateToStateEasingCfg_InEasingSteps_PropertyAddress;

	private static int InitAddStateToStateEasingCfg_InEasingSteps_Offset;

	private static bool InitAddStateToStateEasingCfg_InEnumValEasingType_IsValid;

	private static FFieldAddress InitAddStateToStateEasingCfg_InEnumValEasingType_PropertyAddress;

	private static int InitAddStateToStateEasingCfg_InEnumValEasingType_Offset;

	private static bool InitAddStateToStateEasingCfg_InBoolValEasingType_IsValid;

	private static FFieldAddress InitAddStateToStateEasingCfg_InBoolValEasingType_PropertyAddress;

	private static int InitAddStateToStateEasingCfg_InBoolValEasingType_Offset;

	private static bool InitAddStateToStateEasingCfg_InDelayEasingTime_IsValid;

	private static FFieldAddress InitAddStateToStateEasingCfg_InDelayEasingTime_PropertyAddress;

	private static int InitAddStateToStateEasingCfg_InDelayEasingTime_Offset;

	private static bool GetRefObject_IsValid;

	private static IntPtr GetRefObject_FunctionAddress;

	private static int GetRefObject_ParamsSize;

	private static bool GetRefObject_ReturnValue_IsValid;

	private static FFieldAddress GetRefObject_ReturnValue_PropertyAddress;

	private static int GetRefObject_ReturnValue_Offset;

	private static bool GetPredicToStateCfgEasingTime_IsValid;

	private static IntPtr GetPredicToStateCfgEasingTime_FunctionAddress;

	private static int GetPredicToStateCfgEasingTime_ParamsSize;

	private static bool GetPredicToStateCfgEasingTime_TargetStateName_IsValid;

	private static FFieldAddress GetPredicToStateCfgEasingTime_TargetStateName_PropertyAddress;

	private static int GetPredicToStateCfgEasingTime_TargetStateName_Offset;

	private static bool GetPredicToStateCfgEasingTime_OutDelayEasingTime_IsValid;

	private static FFieldAddress GetPredicToStateCfgEasingTime_OutDelayEasingTime_PropertyAddress;

	private static int GetPredicToStateCfgEasingTime_OutDelayEasingTime_Offset;

	private static bool GetPredicToStateCfgEasingTime_ReturnValue_IsValid;

	private static FFieldAddress GetPredicToStateCfgEasingTime_ReturnValue_PropertyAddress;

	private static int GetPredicToStateCfgEasingTime_ReturnValue_Offset;

	private static bool GetGSDisplayName_IsValid;

	private static IntPtr GetGSDisplayName_FunctionAddress;

	private static int GetGSDisplayName_ParamsSize;

	private static bool GetGSDisplayName_ReturnValue_IsValid;

	private static FFieldAddress GetGSDisplayName_ReturnValue_PropertyAddress;

	private static int GetGSDisplayName_ReturnValue_Offset;

	private static bool GetGSAnimOrSeqDisplayName_IsValid;

	private static IntPtr GetGSAnimOrSeqDisplayName_FunctionAddress;

	private static int GetGSAnimOrSeqDisplayName_ParamsSize;

	private static bool GetGSAnimOrSeqDisplayName_ReturnValue_IsValid;

	private static FFieldAddress GetGSAnimOrSeqDisplayName_ReturnValue_PropertyAddress;

	private static int GetGSAnimOrSeqDisplayName_ReturnValue_Offset;

	private static bool GetEndStateName_IsValid;

	private static IntPtr GetEndStateName_FunctionAddress;

	private static int GetEndStateName_ParamsSize;

	private static bool GetEndStateName_ReturnValue_IsValid;

	private static FFieldAddress GetEndStateName_ReturnValue_PropertyAddress;

	private static int GetEndStateName_ReturnValue_Offset;

	private static bool GetCurrentStateName_IsValid;

	private static IntPtr GetCurrentStateName_FunctionAddress;

	private static int GetCurrentStateName_ParamsSize;

	private static bool GetCurrentStateName_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentStateName_ReturnValue_PropertyAddress;

	private static int GetCurrentStateName_ReturnValue_Offset;

	private static bool GetBeginStateName_IsValid;

	private static IntPtr GetBeginStateName_FunctionAddress;

	private static int GetBeginStateName_ParamsSize;

	private static bool GetBeginStateName_ReturnValue_IsValid;

	private static FFieldAddress GetBeginStateName_ReturnValue_PropertyAddress;

	private static int GetBeginStateName_ReturnValue_Offset;

	private static bool GetAKBObjSTListNum_IsValid;

	private static IntPtr GetAKBObjSTListNum_FunctionAddress;

	private static int GetAKBObjSTListNum_ParamsSize;

	private static bool GetAKBObjSTListNum_ReturnValue_IsValid;

	private static FFieldAddress GetAKBObjSTListNum_ReturnValue_PropertyAddress;

	private static int GetAKBObjSTListNum_ReturnValue_Offset;

	private static bool ForceSetStateImmediately_IsValid;

	private static IntPtr ForceSetStateImmediately_FunctionAddress;

	private static int ForceSetStateImmediately_ParamsSize;

	private static bool ForceSetStateImmediately_TargetStateName_IsValid;

	private static FFieldAddress ForceSetStateImmediately_TargetStateName_PropertyAddress;

	private static int ForceSetStateImmediately_TargetStateName_Offset;

	private static bool EasingToEndState_IsValid;

	private static IntPtr EasingToEndState_FunctionAddress;

	private static int EasingToEndState_ParamsSize;

	private static bool EasingToEndState_Alpha_IsValid;

	private static FFieldAddress EasingToEndState_Alpha_PropertyAddress;

	private static int EasingToEndState_Alpha_Offset;

	private static bool EasingToEndState_IsFromForceSetStateImmediately_IsValid;

	private static FFieldAddress EasingToEndState_IsFromForceSetStateImmediately_PropertyAddress;

	private static int EasingToEndState_IsFromForceSetStateImmediately_Offset;

	private static bool DoTick_IsValid;

	private static IntPtr DoTick_FunctionAddress;

	private static int DoTick_ParamsSize;

	private static bool DoTick_DeltaTime_IsValid;

	private static FFieldAddress DoTick_DeltaTime_PropertyAddress;

	private static int DoTick_DeltaTime_Offset;

	private static bool DoDebug_IsValid;

	private static IntPtr DoDebug_FunctionAddress;

	private static int DoDebug_ParamsSize;

	private static bool BeforeInitAddBindingActor_IsValid;

	private static IntPtr BeforeInitAddBindingActor_FunctionAddress;

	private static int BeforeInitAddBindingActor_ParamsSize;

	private static bool BeforeInitAddBindingActor_RefLevelSequenceActor_IsValid;

	private static FFieldAddress BeforeInitAddBindingActor_RefLevelSequenceActor_PropertyAddress;

	private static int BeforeInitAddBindingActor_RefLevelSequenceActor_Offset;

	private static bool BeforeInitAddBindingActor_BindingActorTagName_IsValid;

	private static FFieldAddress BeforeInitAddBindingActor_BindingActorTagName_PropertyAddress;

	private static int BeforeInitAddBindingActor_BindingActorTagName_Offset;

	private static bool BeforeInitAddBindingActor_InActor_IsValid;

	private static FFieldAddress BeforeInitAddBindingActor_InActor_PropertyAddress;

	private static int BeforeInitAddBindingActor_InActor_Offset;

	[UProperty(Flags = (PropFlags)4503599627510293uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:AKObjSTList")]
	public TArrayReadOnly<FGSAnimKeyObjST> AKObjSTList
	{
		get
		{
			CheckDestroyed();
			if (!AKObjSTList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:AKObjSTList");
				return null;
			}
			if (AKObjSTList_MarshalerCached == null)
			{
				AKObjSTList_MarshalerCached = new TArrayReadOnlyMarshaler<FGSAnimKeyObjST>(1, AKObjSTList_PropertyAddress, CachedMarshalingDelegates<FGSAnimKeyObjST, FGSAnimKeyObjST>.FromNative, CachedMarshalingDelegates<FGSAnimKeyObjST, FGSAnimKeyObjST>.ToNative);
			}
			return AKObjSTList_MarshalerCached.FromNative(IntPtr.Add(base.Address, AKObjSTList_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234414101uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:IsTicking")]
	public bool IsTicking
	{
		get
		{
			CheckDestroyed();
			if (!IsTicking_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:IsTicking");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsTicking_Offset), 0, IsTicking_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsTicking_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:IsTicking");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsTicking_Offset), 0, IsTicking_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896461825uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:OnAKBStateBegin")]
	public FGSOnAKBStateBegin OnAKBStateBegin
	{
		get
		{
			CheckDestroyed();
			if (!OnAKBStateBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:OnAKBStateBegin");
				return new FGSOnAKBStateBegin();
			}
			if (OnAKBStateBegin_DelegateCached == null)
			{
				OnAKBStateBegin_DelegateCached = new FGSOnAKBStateBegin();
				OnAKBStateBegin_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnAKBStateBegin_Offset));
			}
			return OnAKBStateBegin_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896461825uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:OnAKBStateEnd")]
	public FGSOnAKBStateEnd OnAKBStateEnd
	{
		get
		{
			CheckDestroyed();
			if (!OnAKBStateEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:OnAKBStateEnd");
				return new FGSOnAKBStateEnd();
			}
			if (OnAKBStateEnd_DelegateCached == null)
			{
				OnAKBStateEnd_DelegateCached = new FGSOnAKBStateEnd();
				OnAKBStateEnd_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnAKBStateEnd_Offset));
			}
			return OnAKBStateEnd_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896461825uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:OnAKBStateInterupt")]
	public FGSOnAKBStateInterupt OnAKBStateInterupt
	{
		get
		{
			CheckDestroyed();
			if (!OnAKBStateInterupt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:OnAKBStateInterupt");
				return new FGSOnAKBStateInterupt();
			}
			if (OnAKBStateInterupt_DelegateCached == null)
			{
				OnAKBStateInterupt_DelegateCached = new FGSOnAKBStateInterupt();
				OnAKBStateInterupt_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnAKBStateInterupt_Offset));
			}
			return OnAKBStateInterupt_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:ToState")]
	public unsafe void ToState(FName TargetStateName, float InStateDelayEasingTime = 0f, float InStateOverideEasingTime = -1f)
	{
		CheckDestroyed();
		if (!ToState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:ToState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ToState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ToState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ToState_TargetStateName_Offset), 0, ToState_TargetStateName_PropertyAddress.Address, TargetStateName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ToState_InStateDelayEasingTime_Offset), 0, ToState_InStateDelayEasingTime_PropertyAddress.Address, InStateDelayEasingTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ToState_InStateOverideEasingTime_Offset), 0, ToState_InStateOverideEasingTime_PropertyAddress.Address, InStateOverideEasingTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, ToState_FunctionAddress, intPtr, ToState_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:IsInBlending")]
	public unsafe bool IsInBlending()
	{
		CheckDestroyed();
		if (!IsInBlending_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:IsInBlending");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInBlending_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInBlending_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsInBlending_FunctionAddress, intPtr, IsInBlending_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInBlending_ReturnValue_Offset), 0, IsInBlending_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:InitSetWidgetAnimation")]
	public unsafe void InitSetWidgetAnimation(UUserWidget InRefUserWidget, UWidgetAnimation InWidgetAnimation, bool InIsStrictStateMatchCfg = false, bool InIsAlwaysUsingEndStateAsChanging = false)
	{
		CheckDestroyed();
		if (!InitSetWidgetAnimation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:InitSetWidgetAnimation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitSetWidgetAnimation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitSetWidgetAnimation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, InitSetWidgetAnimation_InRefUserWidget_Offset), 0, InitSetWidgetAnimation_InRefUserWidget_PropertyAddress.Address, InRefUserWidget);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, InitSetWidgetAnimation_InWidgetAnimation_Offset), 0, InitSetWidgetAnimation_InWidgetAnimation_PropertyAddress.Address, InWidgetAnimation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, InitSetWidgetAnimation_InIsStrictStateMatchCfg_Offset), 0, InitSetWidgetAnimation_InIsStrictStateMatchCfg_PropertyAddress.Address, InIsStrictStateMatchCfg);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, InitSetWidgetAnimation_InIsAlwaysUsingEndStateAsChanging_Offset), 0, InitSetWidgetAnimation_InIsAlwaysUsingEndStateAsChanging_PropertyAddress.Address, InIsAlwaysUsingEndStateAsChanging);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitSetWidgetAnimation_FunctionAddress, intPtr, InitSetWidgetAnimation_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:InitSetLevelSequence")]
	public unsafe void InitSetLevelSequence(UObject InRefObject, ULevelSequence InLevelSequence, bool InIsStrictStateMatchCfg = false, bool InIsAlwaysUsingEndStateAsChanging = false)
	{
		CheckDestroyed();
		if (!InitSetLevelSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:InitSetLevelSequence");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitSetLevelSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitSetLevelSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, InitSetLevelSequence_InRefObject_Offset), 0, InitSetLevelSequence_InRefObject_PropertyAddress.Address, InRefObject);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, InitSetLevelSequence_InLevelSequence_Offset), 0, InitSetLevelSequence_InLevelSequence_PropertyAddress.Address, InLevelSequence);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, InitSetLevelSequence_InIsStrictStateMatchCfg_Offset), 0, InitSetLevelSequence_InIsStrictStateMatchCfg_PropertyAddress.Address, InIsStrictStateMatchCfg);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, InitSetLevelSequence_InIsAlwaysUsingEndStateAsChanging_Offset), 0, InitSetLevelSequence_InIsAlwaysUsingEndStateAsChanging_PropertyAddress.Address, InIsAlwaysUsingEndStateAsChanging);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitSetLevelSequence_FunctionAddress, intPtr, InitSetLevelSequence_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:InitSetDefaultEasingCfg")]
	public unsafe void InitSetDefaultEasingCfg(float InEasingTime, EEasingFunc InEasingFunc, float InEasingBlendExp, int InEasingSteps, EGSAnimKBEnumBoolEasing InEnumValEasingType = EGSAnimKBEnumBoolEasing.GSEnd, EGSAnimKBEnumBoolEasing InBoolValEasingType = EGSAnimKBEnumBoolEasing.GSEnd, float InDelayEasingTime = 0f)
	{
		CheckDestroyed();
		if (!InitSetDefaultEasingCfg_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:InitSetDefaultEasingCfg");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitSetDefaultEasingCfg_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitSetDefaultEasingCfg_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, InitSetDefaultEasingCfg_InEasingTime_Offset), 0, InitSetDefaultEasingCfg_InEasingTime_PropertyAddress.Address, InEasingTime);
		EnumMarshaler<EEasingFunc>.ToNative(IntPtr.Add(intPtr, InitSetDefaultEasingCfg_InEasingFunc_Offset), 0, InitSetDefaultEasingCfg_InEasingFunc_PropertyAddress.Address, InEasingFunc);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, InitSetDefaultEasingCfg_InEasingBlendExp_Offset), 0, InitSetDefaultEasingCfg_InEasingBlendExp_PropertyAddress.Address, InEasingBlendExp);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, InitSetDefaultEasingCfg_InEasingSteps_Offset), 0, InitSetDefaultEasingCfg_InEasingSteps_PropertyAddress.Address, InEasingSteps);
		EnumMarshaler<EGSAnimKBEnumBoolEasing>.ToNative(IntPtr.Add(intPtr, InitSetDefaultEasingCfg_InEnumValEasingType_Offset), 0, InitSetDefaultEasingCfg_InEnumValEasingType_PropertyAddress.Address, InEnumValEasingType);
		EnumMarshaler<EGSAnimKBEnumBoolEasing>.ToNative(IntPtr.Add(intPtr, InitSetDefaultEasingCfg_InBoolValEasingType_Offset), 0, InitSetDefaultEasingCfg_InBoolValEasingType_PropertyAddress.Address, InBoolValEasingType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, InitSetDefaultEasingCfg_InDelayEasingTime_Offset), 0, InitSetDefaultEasingCfg_InDelayEasingTime_PropertyAddress.Address, InDelayEasingTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitSetDefaultEasingCfg_FunctionAddress, intPtr, InitSetDefaultEasingCfg_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:InitResetState")]
	public unsafe void InitResetState()
	{
		CheckDestroyed();
		if (!InitResetState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:InitResetState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitResetState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitResetState_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: InitResetState_FunctionAddress, argsSize: InitResetState_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:InitAddStateToStateEasingCfg")]
	public unsafe void InitAddStateToStateEasingCfg(FName FromStateName, FName ToStateName, float InEasingTime, EEasingFunc InEasingFunc, float InEasingBlendExp, int InEasingSteps, EGSAnimKBEnumBoolEasing InEnumValEasingType = EGSAnimKBEnumBoolEasing.GSEnd, EGSAnimKBEnumBoolEasing InBoolValEasingType = EGSAnimKBEnumBoolEasing.GSEnd, float InDelayEasingTime = 0f)
	{
		CheckDestroyed();
		if (!InitAddStateToStateEasingCfg_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:InitAddStateToStateEasingCfg");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitAddStateToStateEasingCfg_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitAddStateToStateEasingCfg_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, InitAddStateToStateEasingCfg_FromStateName_Offset), 0, InitAddStateToStateEasingCfg_FromStateName_PropertyAddress.Address, FromStateName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, InitAddStateToStateEasingCfg_ToStateName_Offset), 0, InitAddStateToStateEasingCfg_ToStateName_PropertyAddress.Address, ToStateName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, InitAddStateToStateEasingCfg_InEasingTime_Offset), 0, InitAddStateToStateEasingCfg_InEasingTime_PropertyAddress.Address, InEasingTime);
		EnumMarshaler<EEasingFunc>.ToNative(IntPtr.Add(intPtr, InitAddStateToStateEasingCfg_InEasingFunc_Offset), 0, InitAddStateToStateEasingCfg_InEasingFunc_PropertyAddress.Address, InEasingFunc);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, InitAddStateToStateEasingCfg_InEasingBlendExp_Offset), 0, InitAddStateToStateEasingCfg_InEasingBlendExp_PropertyAddress.Address, InEasingBlendExp);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, InitAddStateToStateEasingCfg_InEasingSteps_Offset), 0, InitAddStateToStateEasingCfg_InEasingSteps_PropertyAddress.Address, InEasingSteps);
		EnumMarshaler<EGSAnimKBEnumBoolEasing>.ToNative(IntPtr.Add(intPtr, InitAddStateToStateEasingCfg_InEnumValEasingType_Offset), 0, InitAddStateToStateEasingCfg_InEnumValEasingType_PropertyAddress.Address, InEnumValEasingType);
		EnumMarshaler<EGSAnimKBEnumBoolEasing>.ToNative(IntPtr.Add(intPtr, InitAddStateToStateEasingCfg_InBoolValEasingType_Offset), 0, InitAddStateToStateEasingCfg_InBoolValEasingType_PropertyAddress.Address, InBoolValEasingType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, InitAddStateToStateEasingCfg_InDelayEasingTime_Offset), 0, InitAddStateToStateEasingCfg_InDelayEasingTime_PropertyAddress.Address, InDelayEasingTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitAddStateToStateEasingCfg_FunctionAddress, intPtr, InitAddStateToStateEasingCfg_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetRefObject")]
	public unsafe UObject GetRefObject()
	{
		CheckDestroyed();
		if (!GetRefObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetRefObject");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRefObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRefObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRefObject_FunctionAddress, intPtr, GetRefObject_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetRefObject_ReturnValue_Offset), 0, GetRefObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetPredicToStateCfgEasingTime")]
	public unsafe float GetPredicToStateCfgEasingTime(FName TargetStateName, out float OutDelayEasingTime)
	{
		CheckDestroyed();
		if (!GetPredicToStateCfgEasingTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetPredicToStateCfgEasingTime");
			OutDelayEasingTime = 0f;
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPredicToStateCfgEasingTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPredicToStateCfgEasingTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetPredicToStateCfgEasingTime_TargetStateName_Offset), 0, GetPredicToStateCfgEasingTime_TargetStateName_PropertyAddress.Address, TargetStateName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPredicToStateCfgEasingTime_FunctionAddress, intPtr, GetPredicToStateCfgEasingTime_ParamsSize);
		OutDelayEasingTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPredicToStateCfgEasingTime_OutDelayEasingTime_Offset), 0, GetPredicToStateCfgEasingTime_OutDelayEasingTime_PropertyAddress.Address);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPredicToStateCfgEasingTime_ReturnValue_Offset), 0, GetPredicToStateCfgEasingTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1946289153u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetGSDisplayName")]
	public unsafe string GetGSDisplayName()
	{
		CheckDestroyed();
		if (!GetGSDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetGSDisplayName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGSDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGSDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGSDisplayName_FunctionAddress, intPtr, GetGSDisplayName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetGSDisplayName_ReturnValue_Offset), 0, GetGSDisplayName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetGSDisplayName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1946289153u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetGSAnimOrSeqDisplayName")]
	public unsafe string GetGSAnimOrSeqDisplayName()
	{
		CheckDestroyed();
		if (!GetGSAnimOrSeqDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetGSAnimOrSeqDisplayName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGSAnimOrSeqDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGSAnimOrSeqDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGSAnimOrSeqDisplayName_FunctionAddress, intPtr, GetGSAnimOrSeqDisplayName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetGSAnimOrSeqDisplayName_ReturnValue_Offset), 0, GetGSAnimOrSeqDisplayName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetGSAnimOrSeqDisplayName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetEndStateName")]
	public unsafe FName GetEndStateName()
	{
		CheckDestroyed();
		if (!GetEndStateName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetEndStateName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEndStateName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEndStateName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEndStateName_FunctionAddress, intPtr, GetEndStateName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetEndStateName_ReturnValue_Offset), 0, GetEndStateName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetCurrentStateName")]
	public unsafe FName GetCurrentStateName()
	{
		CheckDestroyed();
		if (!GetCurrentStateName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetCurrentStateName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentStateName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentStateName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentStateName_FunctionAddress, intPtr, GetCurrentStateName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetCurrentStateName_ReturnValue_Offset), 0, GetCurrentStateName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetBeginStateName")]
	public unsafe FName GetBeginStateName()
	{
		CheckDestroyed();
		if (!GetBeginStateName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetBeginStateName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBeginStateName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBeginStateName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBeginStateName_FunctionAddress, intPtr, GetBeginStateName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetBeginStateName_ReturnValue_Offset), 0, GetBeginStateName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetAKBObjSTListNum")]
	public unsafe int GetAKBObjSTListNum()
	{
		CheckDestroyed();
		if (!GetAKBObjSTListNum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetAKBObjSTListNum");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAKBObjSTListNum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAKBObjSTListNum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAKBObjSTListNum_FunctionAddress, intPtr, GetAKBObjSTListNum_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetAKBObjSTListNum_ReturnValue_Offset), 0, GetAKBObjSTListNum_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:ForceSetStateImmediately")]
	public unsafe void ForceSetStateImmediately(FName TargetStateName)
	{
		CheckDestroyed();
		if (!ForceSetStateImmediately_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:ForceSetStateImmediately");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceSetStateImmediately_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceSetStateImmediately_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ForceSetStateImmediately_TargetStateName_Offset), 0, ForceSetStateImmediately_TargetStateName_PropertyAddress.Address, TargetStateName);
		NativeReflection.InvokeFunctionOptimized(base.Address, ForceSetStateImmediately_FunctionAddress, intPtr, ForceSetStateImmediately_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:EasingToEndState")]
	public unsafe void EasingToEndState(float Alpha, bool IsFromForceSetStateImmediately)
	{
		CheckDestroyed();
		if (!EasingToEndState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:EasingToEndState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EasingToEndState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EasingToEndState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, EasingToEndState_Alpha_Offset), 0, EasingToEndState_Alpha_PropertyAddress.Address, Alpha);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EasingToEndState_IsFromForceSetStateImmediately_Offset), 0, EasingToEndState_IsFromForceSetStateImmediately_PropertyAddress.Address, IsFromForceSetStateImmediately);
		NativeReflection.InvokeFunctionOptimized(base.Address, EasingToEndState_FunctionAddress, intPtr, EasingToEndState_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:DoTick")]
	public unsafe void DoTick(float DeltaTime)
	{
		CheckDestroyed();
		if (!DoTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:DoTick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DoTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DoTick_DeltaTime_Offset), 0, DoTick_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, DoTick_FunctionAddress, intPtr, DoTick_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:DoDebug")]
	public unsafe void DoDebug()
	{
		CheckDestroyed();
		if (!DoDebug_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:DoDebug");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DoDebug_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoDebug_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: DoDebug_FunctionAddress, argsSize: DoDebug_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:BeforeInitAddBindingActor")]
	public unsafe void BeforeInitAddBindingActor(ALevelSequenceActor RefLevelSequenceActor, FName BindingActorTagName, AActor InActor)
	{
		CheckDestroyed();
		if (!BeforeInitAddBindingActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:BeforeInitAddBindingActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeforeInitAddBindingActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeforeInitAddBindingActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ALevelSequenceActor>.ToNative(IntPtr.Add(intPtr, BeforeInitAddBindingActor_RefLevelSequenceActor_Offset), 0, BeforeInitAddBindingActor_RefLevelSequenceActor_PropertyAddress.Address, RefLevelSequenceActor);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BeforeInitAddBindingActor_BindingActorTagName_Offset), 0, BeforeInitAddBindingActor_BindingActorTagName_PropertyAddress.Address, BindingActorTagName);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BeforeInitAddBindingActor_InActor_Offset), 0, BeforeInitAddBindingActor_InActor_PropertyAddress.Address, InActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, BeforeInitAddBindingActor_FunctionAddress, intPtr, BeforeInitAddBindingActor_ParamsSize);
	}

	static UGSAnimKeyStateBlender()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSAnimKeyStateBlender)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSAnimKeyStateBlender));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender");
		NativeReflectionCached.GetPropertyRef(ref AKObjSTList_PropertyAddress, intPtr, "AKObjSTList");
		AKObjSTList_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AKObjSTList");
		AKObjSTList_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AKObjSTList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IsTicking_PropertyAddress, intPtr, "IsTicking");
		IsTicking_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsTicking");
		IsTicking_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsTicking", Classes.FBoolProperty);
		OnAKBStateBegin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnAKBStateBegin");
		OnAKBStateBegin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnAKBStateBegin", Classes.FMulticastDelegateProperty);
		OnAKBStateEnd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnAKBStateEnd");
		OnAKBStateEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnAKBStateEnd", Classes.FMulticastDelegateProperty);
		OnAKBStateInterupt_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnAKBStateInterupt");
		OnAKBStateInterupt_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnAKBStateInterupt", Classes.FMulticastDelegateProperty);
		ToState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ToState");
		ToState_ParamsSize = NativeReflection.GetFunctionParamsSize(ToState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ToState_TargetStateName_PropertyAddress, ToState_FunctionAddress, "TargetStateName");
		ToState_TargetStateName_Offset = NativeReflectionCached.GetPropertyOffset(ToState_FunctionAddress, "TargetStateName");
		ToState_TargetStateName_IsValid = NativeReflectionCached.ValidatePropertyClass(ToState_FunctionAddress, "TargetStateName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ToState_InStateDelayEasingTime_PropertyAddress, ToState_FunctionAddress, "InStateDelayEasingTime");
		ToState_InStateDelayEasingTime_Offset = NativeReflectionCached.GetPropertyOffset(ToState_FunctionAddress, "InStateDelayEasingTime");
		ToState_InStateDelayEasingTime_IsValid = NativeReflectionCached.ValidatePropertyClass(ToState_FunctionAddress, "InStateDelayEasingTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ToState_InStateOverideEasingTime_PropertyAddress, ToState_FunctionAddress, "InStateOverideEasingTime");
		ToState_InStateOverideEasingTime_Offset = NativeReflectionCached.GetPropertyOffset(ToState_FunctionAddress, "InStateOverideEasingTime");
		ToState_InStateOverideEasingTime_IsValid = NativeReflectionCached.ValidatePropertyClass(ToState_FunctionAddress, "InStateOverideEasingTime", Classes.FFloatProperty);
		ToState_IsValid = ToState_FunctionAddress != IntPtr.Zero && ToState_TargetStateName_IsValid && ToState_InStateDelayEasingTime_IsValid && ToState_InStateOverideEasingTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:ToState", ToState_IsValid);
		IsInBlending_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsInBlending");
		IsInBlending_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInBlending_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInBlending_ReturnValue_PropertyAddress, IsInBlending_FunctionAddress, "ReturnValue");
		IsInBlending_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInBlending_FunctionAddress, "ReturnValue");
		IsInBlending_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInBlending_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInBlending_IsValid = IsInBlending_FunctionAddress != IntPtr.Zero && IsInBlending_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:IsInBlending", IsInBlending_IsValid);
		InitSetWidgetAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitSetWidgetAnimation");
		InitSetWidgetAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(InitSetWidgetAnimation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitSetWidgetAnimation_InRefUserWidget_PropertyAddress, InitSetWidgetAnimation_FunctionAddress, "InRefUserWidget");
		InitSetWidgetAnimation_InRefUserWidget_Offset = NativeReflectionCached.GetPropertyOffset(InitSetWidgetAnimation_FunctionAddress, "InRefUserWidget");
		InitSetWidgetAnimation_InRefUserWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(InitSetWidgetAnimation_FunctionAddress, "InRefUserWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref InitSetWidgetAnimation_InWidgetAnimation_PropertyAddress, InitSetWidgetAnimation_FunctionAddress, "InWidgetAnimation");
		InitSetWidgetAnimation_InWidgetAnimation_Offset = NativeReflectionCached.GetPropertyOffset(InitSetWidgetAnimation_FunctionAddress, "InWidgetAnimation");
		InitSetWidgetAnimation_InWidgetAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(InitSetWidgetAnimation_FunctionAddress, "InWidgetAnimation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref InitSetWidgetAnimation_InIsStrictStateMatchCfg_PropertyAddress, InitSetWidgetAnimation_FunctionAddress, "InIsStrictStateMatchCfg");
		InitSetWidgetAnimation_InIsStrictStateMatchCfg_Offset = NativeReflectionCached.GetPropertyOffset(InitSetWidgetAnimation_FunctionAddress, "InIsStrictStateMatchCfg");
		InitSetWidgetAnimation_InIsStrictStateMatchCfg_IsValid = NativeReflectionCached.ValidatePropertyClass(InitSetWidgetAnimation_FunctionAddress, "InIsStrictStateMatchCfg", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref InitSetWidgetAnimation_InIsAlwaysUsingEndStateAsChanging_PropertyAddress, InitSetWidgetAnimation_FunctionAddress, "InIsAlwaysUsingEndStateAsChanging");
		InitSetWidgetAnimation_InIsAlwaysUsingEndStateAsChanging_Offset = NativeReflectionCached.GetPropertyOffset(InitSetWidgetAnimation_FunctionAddress, "InIsAlwaysUsingEndStateAsChanging");
		InitSetWidgetAnimation_InIsAlwaysUsingEndStateAsChanging_IsValid = NativeReflectionCached.ValidatePropertyClass(InitSetWidgetAnimation_FunctionAddress, "InIsAlwaysUsingEndStateAsChanging", Classes.FBoolProperty);
		InitSetWidgetAnimation_IsValid = InitSetWidgetAnimation_FunctionAddress != IntPtr.Zero && InitSetWidgetAnimation_InRefUserWidget_IsValid && InitSetWidgetAnimation_InWidgetAnimation_IsValid && InitSetWidgetAnimation_InIsStrictStateMatchCfg_IsValid && InitSetWidgetAnimation_InIsAlwaysUsingEndStateAsChanging_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:InitSetWidgetAnimation", InitSetWidgetAnimation_IsValid);
		InitSetLevelSequence_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitSetLevelSequence");
		InitSetLevelSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(InitSetLevelSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitSetLevelSequence_InRefObject_PropertyAddress, InitSetLevelSequence_FunctionAddress, "InRefObject");
		InitSetLevelSequence_InRefObject_Offset = NativeReflectionCached.GetPropertyOffset(InitSetLevelSequence_FunctionAddress, "InRefObject");
		InitSetLevelSequence_InRefObject_IsValid = NativeReflectionCached.ValidatePropertyClass(InitSetLevelSequence_FunctionAddress, "InRefObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref InitSetLevelSequence_InLevelSequence_PropertyAddress, InitSetLevelSequence_FunctionAddress, "InLevelSequence");
		InitSetLevelSequence_InLevelSequence_Offset = NativeReflectionCached.GetPropertyOffset(InitSetLevelSequence_FunctionAddress, "InLevelSequence");
		InitSetLevelSequence_InLevelSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(InitSetLevelSequence_FunctionAddress, "InLevelSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref InitSetLevelSequence_InIsStrictStateMatchCfg_PropertyAddress, InitSetLevelSequence_FunctionAddress, "InIsStrictStateMatchCfg");
		InitSetLevelSequence_InIsStrictStateMatchCfg_Offset = NativeReflectionCached.GetPropertyOffset(InitSetLevelSequence_FunctionAddress, "InIsStrictStateMatchCfg");
		InitSetLevelSequence_InIsStrictStateMatchCfg_IsValid = NativeReflectionCached.ValidatePropertyClass(InitSetLevelSequence_FunctionAddress, "InIsStrictStateMatchCfg", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref InitSetLevelSequence_InIsAlwaysUsingEndStateAsChanging_PropertyAddress, InitSetLevelSequence_FunctionAddress, "InIsAlwaysUsingEndStateAsChanging");
		InitSetLevelSequence_InIsAlwaysUsingEndStateAsChanging_Offset = NativeReflectionCached.GetPropertyOffset(InitSetLevelSequence_FunctionAddress, "InIsAlwaysUsingEndStateAsChanging");
		InitSetLevelSequence_InIsAlwaysUsingEndStateAsChanging_IsValid = NativeReflectionCached.ValidatePropertyClass(InitSetLevelSequence_FunctionAddress, "InIsAlwaysUsingEndStateAsChanging", Classes.FBoolProperty);
		InitSetLevelSequence_IsValid = InitSetLevelSequence_FunctionAddress != IntPtr.Zero && InitSetLevelSequence_InRefObject_IsValid && InitSetLevelSequence_InLevelSequence_IsValid && InitSetLevelSequence_InIsStrictStateMatchCfg_IsValid && InitSetLevelSequence_InIsAlwaysUsingEndStateAsChanging_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:InitSetLevelSequence", InitSetLevelSequence_IsValid);
		InitSetDefaultEasingCfg_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitSetDefaultEasingCfg");
		InitSetDefaultEasingCfg_ParamsSize = NativeReflection.GetFunctionParamsSize(InitSetDefaultEasingCfg_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitSetDefaultEasingCfg_InEasingTime_PropertyAddress, InitSetDefaultEasingCfg_FunctionAddress, "InEasingTime");
		InitSetDefaultEasingCfg_InEasingTime_Offset = NativeReflectionCached.GetPropertyOffset(InitSetDefaultEasingCfg_FunctionAddress, "InEasingTime");
		InitSetDefaultEasingCfg_InEasingTime_IsValid = NativeReflectionCached.ValidatePropertyClass(InitSetDefaultEasingCfg_FunctionAddress, "InEasingTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref InitSetDefaultEasingCfg_InEasingFunc_PropertyAddress, InitSetDefaultEasingCfg_FunctionAddress, "InEasingFunc");
		InitSetDefaultEasingCfg_InEasingFunc_Offset = NativeReflectionCached.GetPropertyOffset(InitSetDefaultEasingCfg_FunctionAddress, "InEasingFunc");
		InitSetDefaultEasingCfg_InEasingFunc_IsValid = NativeReflectionCached.ValidatePropertyClass(InitSetDefaultEasingCfg_FunctionAddress, "InEasingFunc", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref InitSetDefaultEasingCfg_InEasingBlendExp_PropertyAddress, InitSetDefaultEasingCfg_FunctionAddress, "InEasingBlendExp");
		InitSetDefaultEasingCfg_InEasingBlendExp_Offset = NativeReflectionCached.GetPropertyOffset(InitSetDefaultEasingCfg_FunctionAddress, "InEasingBlendExp");
		InitSetDefaultEasingCfg_InEasingBlendExp_IsValid = NativeReflectionCached.ValidatePropertyClass(InitSetDefaultEasingCfg_FunctionAddress, "InEasingBlendExp", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref InitSetDefaultEasingCfg_InEasingSteps_PropertyAddress, InitSetDefaultEasingCfg_FunctionAddress, "InEasingSteps");
		InitSetDefaultEasingCfg_InEasingSteps_Offset = NativeReflectionCached.GetPropertyOffset(InitSetDefaultEasingCfg_FunctionAddress, "InEasingSteps");
		InitSetDefaultEasingCfg_InEasingSteps_IsValid = NativeReflectionCached.ValidatePropertyClass(InitSetDefaultEasingCfg_FunctionAddress, "InEasingSteps", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref InitSetDefaultEasingCfg_InEnumValEasingType_PropertyAddress, InitSetDefaultEasingCfg_FunctionAddress, "InEnumValEasingType");
		InitSetDefaultEasingCfg_InEnumValEasingType_Offset = NativeReflectionCached.GetPropertyOffset(InitSetDefaultEasingCfg_FunctionAddress, "InEnumValEasingType");
		InitSetDefaultEasingCfg_InEnumValEasingType_IsValid = NativeReflectionCached.ValidatePropertyClass(InitSetDefaultEasingCfg_FunctionAddress, "InEnumValEasingType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref InitSetDefaultEasingCfg_InBoolValEasingType_PropertyAddress, InitSetDefaultEasingCfg_FunctionAddress, "InBoolValEasingType");
		InitSetDefaultEasingCfg_InBoolValEasingType_Offset = NativeReflectionCached.GetPropertyOffset(InitSetDefaultEasingCfg_FunctionAddress, "InBoolValEasingType");
		InitSetDefaultEasingCfg_InBoolValEasingType_IsValid = NativeReflectionCached.ValidatePropertyClass(InitSetDefaultEasingCfg_FunctionAddress, "InBoolValEasingType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref InitSetDefaultEasingCfg_InDelayEasingTime_PropertyAddress, InitSetDefaultEasingCfg_FunctionAddress, "InDelayEasingTime");
		InitSetDefaultEasingCfg_InDelayEasingTime_Offset = NativeReflectionCached.GetPropertyOffset(InitSetDefaultEasingCfg_FunctionAddress, "InDelayEasingTime");
		InitSetDefaultEasingCfg_InDelayEasingTime_IsValid = NativeReflectionCached.ValidatePropertyClass(InitSetDefaultEasingCfg_FunctionAddress, "InDelayEasingTime", Classes.FFloatProperty);
		InitSetDefaultEasingCfg_IsValid = InitSetDefaultEasingCfg_FunctionAddress != IntPtr.Zero && InitSetDefaultEasingCfg_InEasingTime_IsValid && InitSetDefaultEasingCfg_InEasingFunc_IsValid && InitSetDefaultEasingCfg_InEasingBlendExp_IsValid && InitSetDefaultEasingCfg_InEasingSteps_IsValid && InitSetDefaultEasingCfg_InEnumValEasingType_IsValid && InitSetDefaultEasingCfg_InBoolValEasingType_IsValid && InitSetDefaultEasingCfg_InDelayEasingTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:InitSetDefaultEasingCfg", InitSetDefaultEasingCfg_IsValid);
		InitResetState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitResetState");
		InitResetState_ParamsSize = NativeReflection.GetFunctionParamsSize(InitResetState_FunctionAddress);
		InitResetState_IsValid = InitResetState_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:InitResetState", InitResetState_IsValid);
		InitAddStateToStateEasingCfg_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitAddStateToStateEasingCfg");
		InitAddStateToStateEasingCfg_ParamsSize = NativeReflection.GetFunctionParamsSize(InitAddStateToStateEasingCfg_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitAddStateToStateEasingCfg_FromStateName_PropertyAddress, InitAddStateToStateEasingCfg_FunctionAddress, "FromStateName");
		InitAddStateToStateEasingCfg_FromStateName_Offset = NativeReflectionCached.GetPropertyOffset(InitAddStateToStateEasingCfg_FunctionAddress, "FromStateName");
		InitAddStateToStateEasingCfg_FromStateName_IsValid = NativeReflectionCached.ValidatePropertyClass(InitAddStateToStateEasingCfg_FunctionAddress, "FromStateName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref InitAddStateToStateEasingCfg_ToStateName_PropertyAddress, InitAddStateToStateEasingCfg_FunctionAddress, "ToStateName");
		InitAddStateToStateEasingCfg_ToStateName_Offset = NativeReflectionCached.GetPropertyOffset(InitAddStateToStateEasingCfg_FunctionAddress, "ToStateName");
		InitAddStateToStateEasingCfg_ToStateName_IsValid = NativeReflectionCached.ValidatePropertyClass(InitAddStateToStateEasingCfg_FunctionAddress, "ToStateName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref InitAddStateToStateEasingCfg_InEasingTime_PropertyAddress, InitAddStateToStateEasingCfg_FunctionAddress, "InEasingTime");
		InitAddStateToStateEasingCfg_InEasingTime_Offset = NativeReflectionCached.GetPropertyOffset(InitAddStateToStateEasingCfg_FunctionAddress, "InEasingTime");
		InitAddStateToStateEasingCfg_InEasingTime_IsValid = NativeReflectionCached.ValidatePropertyClass(InitAddStateToStateEasingCfg_FunctionAddress, "InEasingTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref InitAddStateToStateEasingCfg_InEasingFunc_PropertyAddress, InitAddStateToStateEasingCfg_FunctionAddress, "InEasingFunc");
		InitAddStateToStateEasingCfg_InEasingFunc_Offset = NativeReflectionCached.GetPropertyOffset(InitAddStateToStateEasingCfg_FunctionAddress, "InEasingFunc");
		InitAddStateToStateEasingCfg_InEasingFunc_IsValid = NativeReflectionCached.ValidatePropertyClass(InitAddStateToStateEasingCfg_FunctionAddress, "InEasingFunc", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref InitAddStateToStateEasingCfg_InEasingBlendExp_PropertyAddress, InitAddStateToStateEasingCfg_FunctionAddress, "InEasingBlendExp");
		InitAddStateToStateEasingCfg_InEasingBlendExp_Offset = NativeReflectionCached.GetPropertyOffset(InitAddStateToStateEasingCfg_FunctionAddress, "InEasingBlendExp");
		InitAddStateToStateEasingCfg_InEasingBlendExp_IsValid = NativeReflectionCached.ValidatePropertyClass(InitAddStateToStateEasingCfg_FunctionAddress, "InEasingBlendExp", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref InitAddStateToStateEasingCfg_InEasingSteps_PropertyAddress, InitAddStateToStateEasingCfg_FunctionAddress, "InEasingSteps");
		InitAddStateToStateEasingCfg_InEasingSteps_Offset = NativeReflectionCached.GetPropertyOffset(InitAddStateToStateEasingCfg_FunctionAddress, "InEasingSteps");
		InitAddStateToStateEasingCfg_InEasingSteps_IsValid = NativeReflectionCached.ValidatePropertyClass(InitAddStateToStateEasingCfg_FunctionAddress, "InEasingSteps", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref InitAddStateToStateEasingCfg_InEnumValEasingType_PropertyAddress, InitAddStateToStateEasingCfg_FunctionAddress, "InEnumValEasingType");
		InitAddStateToStateEasingCfg_InEnumValEasingType_Offset = NativeReflectionCached.GetPropertyOffset(InitAddStateToStateEasingCfg_FunctionAddress, "InEnumValEasingType");
		InitAddStateToStateEasingCfg_InEnumValEasingType_IsValid = NativeReflectionCached.ValidatePropertyClass(InitAddStateToStateEasingCfg_FunctionAddress, "InEnumValEasingType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref InitAddStateToStateEasingCfg_InBoolValEasingType_PropertyAddress, InitAddStateToStateEasingCfg_FunctionAddress, "InBoolValEasingType");
		InitAddStateToStateEasingCfg_InBoolValEasingType_Offset = NativeReflectionCached.GetPropertyOffset(InitAddStateToStateEasingCfg_FunctionAddress, "InBoolValEasingType");
		InitAddStateToStateEasingCfg_InBoolValEasingType_IsValid = NativeReflectionCached.ValidatePropertyClass(InitAddStateToStateEasingCfg_FunctionAddress, "InBoolValEasingType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref InitAddStateToStateEasingCfg_InDelayEasingTime_PropertyAddress, InitAddStateToStateEasingCfg_FunctionAddress, "InDelayEasingTime");
		InitAddStateToStateEasingCfg_InDelayEasingTime_Offset = NativeReflectionCached.GetPropertyOffset(InitAddStateToStateEasingCfg_FunctionAddress, "InDelayEasingTime");
		InitAddStateToStateEasingCfg_InDelayEasingTime_IsValid = NativeReflectionCached.ValidatePropertyClass(InitAddStateToStateEasingCfg_FunctionAddress, "InDelayEasingTime", Classes.FFloatProperty);
		InitAddStateToStateEasingCfg_IsValid = InitAddStateToStateEasingCfg_FunctionAddress != IntPtr.Zero && InitAddStateToStateEasingCfg_FromStateName_IsValid && InitAddStateToStateEasingCfg_ToStateName_IsValid && InitAddStateToStateEasingCfg_InEasingTime_IsValid && InitAddStateToStateEasingCfg_InEasingFunc_IsValid && InitAddStateToStateEasingCfg_InEasingBlendExp_IsValid && InitAddStateToStateEasingCfg_InEasingSteps_IsValid && InitAddStateToStateEasingCfg_InEnumValEasingType_IsValid && InitAddStateToStateEasingCfg_InBoolValEasingType_IsValid && InitAddStateToStateEasingCfg_InDelayEasingTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:InitAddStateToStateEasingCfg", InitAddStateToStateEasingCfg_IsValid);
		GetRefObject_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRefObject");
		GetRefObject_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRefObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRefObject_ReturnValue_PropertyAddress, GetRefObject_FunctionAddress, "ReturnValue");
		GetRefObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRefObject_FunctionAddress, "ReturnValue");
		GetRefObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRefObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetRefObject_IsValid = GetRefObject_FunctionAddress != IntPtr.Zero && GetRefObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetRefObject", GetRefObject_IsValid);
		GetPredicToStateCfgEasingTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPredicToStateCfgEasingTime");
		GetPredicToStateCfgEasingTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPredicToStateCfgEasingTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPredicToStateCfgEasingTime_TargetStateName_PropertyAddress, GetPredicToStateCfgEasingTime_FunctionAddress, "TargetStateName");
		GetPredicToStateCfgEasingTime_TargetStateName_Offset = NativeReflectionCached.GetPropertyOffset(GetPredicToStateCfgEasingTime_FunctionAddress, "TargetStateName");
		GetPredicToStateCfgEasingTime_TargetStateName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPredicToStateCfgEasingTime_FunctionAddress, "TargetStateName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPredicToStateCfgEasingTime_OutDelayEasingTime_PropertyAddress, GetPredicToStateCfgEasingTime_FunctionAddress, "OutDelayEasingTime");
		GetPredicToStateCfgEasingTime_OutDelayEasingTime_Offset = NativeReflectionCached.GetPropertyOffset(GetPredicToStateCfgEasingTime_FunctionAddress, "OutDelayEasingTime");
		GetPredicToStateCfgEasingTime_OutDelayEasingTime_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPredicToStateCfgEasingTime_FunctionAddress, "OutDelayEasingTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPredicToStateCfgEasingTime_ReturnValue_PropertyAddress, GetPredicToStateCfgEasingTime_FunctionAddress, "ReturnValue");
		GetPredicToStateCfgEasingTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPredicToStateCfgEasingTime_FunctionAddress, "ReturnValue");
		GetPredicToStateCfgEasingTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPredicToStateCfgEasingTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPredicToStateCfgEasingTime_IsValid = GetPredicToStateCfgEasingTime_FunctionAddress != IntPtr.Zero && GetPredicToStateCfgEasingTime_TargetStateName_IsValid && GetPredicToStateCfgEasingTime_OutDelayEasingTime_IsValid && GetPredicToStateCfgEasingTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetPredicToStateCfgEasingTime", GetPredicToStateCfgEasingTime_IsValid);
		GetGSDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetGSDisplayName");
		GetGSDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGSDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGSDisplayName_ReturnValue_PropertyAddress, GetGSDisplayName_FunctionAddress, "ReturnValue");
		GetGSDisplayName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGSDisplayName_FunctionAddress, "ReturnValue");
		GetGSDisplayName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGSDisplayName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetGSDisplayName_IsValid = GetGSDisplayName_FunctionAddress != IntPtr.Zero && GetGSDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetGSDisplayName", GetGSDisplayName_IsValid);
		GetGSAnimOrSeqDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetGSAnimOrSeqDisplayName");
		GetGSAnimOrSeqDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGSAnimOrSeqDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGSAnimOrSeqDisplayName_ReturnValue_PropertyAddress, GetGSAnimOrSeqDisplayName_FunctionAddress, "ReturnValue");
		GetGSAnimOrSeqDisplayName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGSAnimOrSeqDisplayName_FunctionAddress, "ReturnValue");
		GetGSAnimOrSeqDisplayName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGSAnimOrSeqDisplayName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetGSAnimOrSeqDisplayName_IsValid = GetGSAnimOrSeqDisplayName_FunctionAddress != IntPtr.Zero && GetGSAnimOrSeqDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetGSAnimOrSeqDisplayName", GetGSAnimOrSeqDisplayName_IsValid);
		GetEndStateName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetEndStateName");
		GetEndStateName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEndStateName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEndStateName_ReturnValue_PropertyAddress, GetEndStateName_FunctionAddress, "ReturnValue");
		GetEndStateName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEndStateName_FunctionAddress, "ReturnValue");
		GetEndStateName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEndStateName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetEndStateName_IsValid = GetEndStateName_FunctionAddress != IntPtr.Zero && GetEndStateName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetEndStateName", GetEndStateName_IsValid);
		GetCurrentStateName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurrentStateName");
		GetCurrentStateName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentStateName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentStateName_ReturnValue_PropertyAddress, GetCurrentStateName_FunctionAddress, "ReturnValue");
		GetCurrentStateName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentStateName_FunctionAddress, "ReturnValue");
		GetCurrentStateName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentStateName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetCurrentStateName_IsValid = GetCurrentStateName_FunctionAddress != IntPtr.Zero && GetCurrentStateName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetCurrentStateName", GetCurrentStateName_IsValid);
		GetBeginStateName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBeginStateName");
		GetBeginStateName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBeginStateName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBeginStateName_ReturnValue_PropertyAddress, GetBeginStateName_FunctionAddress, "ReturnValue");
		GetBeginStateName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBeginStateName_FunctionAddress, "ReturnValue");
		GetBeginStateName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeginStateName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetBeginStateName_IsValid = GetBeginStateName_FunctionAddress != IntPtr.Zero && GetBeginStateName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetBeginStateName", GetBeginStateName_IsValid);
		GetAKBObjSTListNum_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAKBObjSTListNum");
		GetAKBObjSTListNum_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAKBObjSTListNum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAKBObjSTListNum_ReturnValue_PropertyAddress, GetAKBObjSTListNum_FunctionAddress, "ReturnValue");
		GetAKBObjSTListNum_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAKBObjSTListNum_FunctionAddress, "ReturnValue");
		GetAKBObjSTListNum_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAKBObjSTListNum_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetAKBObjSTListNum_IsValid = GetAKBObjSTListNum_FunctionAddress != IntPtr.Zero && GetAKBObjSTListNum_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:GetAKBObjSTListNum", GetAKBObjSTListNum_IsValid);
		ForceSetStateImmediately_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ForceSetStateImmediately");
		ForceSetStateImmediately_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceSetStateImmediately_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ForceSetStateImmediately_TargetStateName_PropertyAddress, ForceSetStateImmediately_FunctionAddress, "TargetStateName");
		ForceSetStateImmediately_TargetStateName_Offset = NativeReflectionCached.GetPropertyOffset(ForceSetStateImmediately_FunctionAddress, "TargetStateName");
		ForceSetStateImmediately_TargetStateName_IsValid = NativeReflectionCached.ValidatePropertyClass(ForceSetStateImmediately_FunctionAddress, "TargetStateName", Classes.FNameProperty);
		ForceSetStateImmediately_IsValid = ForceSetStateImmediately_FunctionAddress != IntPtr.Zero && ForceSetStateImmediately_TargetStateName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:ForceSetStateImmediately", ForceSetStateImmediately_IsValid);
		EasingToEndState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EasingToEndState");
		EasingToEndState_ParamsSize = NativeReflection.GetFunctionParamsSize(EasingToEndState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EasingToEndState_Alpha_PropertyAddress, EasingToEndState_FunctionAddress, "Alpha");
		EasingToEndState_Alpha_Offset = NativeReflectionCached.GetPropertyOffset(EasingToEndState_FunctionAddress, "Alpha");
		EasingToEndState_Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(EasingToEndState_FunctionAddress, "Alpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EasingToEndState_IsFromForceSetStateImmediately_PropertyAddress, EasingToEndState_FunctionAddress, "IsFromForceSetStateImmediately");
		EasingToEndState_IsFromForceSetStateImmediately_Offset = NativeReflectionCached.GetPropertyOffset(EasingToEndState_FunctionAddress, "IsFromForceSetStateImmediately");
		EasingToEndState_IsFromForceSetStateImmediately_IsValid = NativeReflectionCached.ValidatePropertyClass(EasingToEndState_FunctionAddress, "IsFromForceSetStateImmediately", Classes.FBoolProperty);
		EasingToEndState_IsValid = EasingToEndState_FunctionAddress != IntPtr.Zero && EasingToEndState_Alpha_IsValid && EasingToEndState_IsFromForceSetStateImmediately_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:EasingToEndState", EasingToEndState_IsValid);
		DoTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoTick");
		DoTick_ParamsSize = NativeReflection.GetFunctionParamsSize(DoTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DoTick_DeltaTime_PropertyAddress, DoTick_FunctionAddress, "DeltaTime");
		DoTick_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(DoTick_FunctionAddress, "DeltaTime");
		DoTick_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(DoTick_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		DoTick_IsValid = DoTick_FunctionAddress != IntPtr.Zero && DoTick_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:DoTick", DoTick_IsValid);
		DoDebug_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoDebug");
		DoDebug_ParamsSize = NativeReflection.GetFunctionParamsSize(DoDebug_FunctionAddress);
		DoDebug_IsValid = DoDebug_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:DoDebug", DoDebug_IsValid);
		BeforeInitAddBindingActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeforeInitAddBindingActor");
		BeforeInitAddBindingActor_ParamsSize = NativeReflection.GetFunctionParamsSize(BeforeInitAddBindingActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BeforeInitAddBindingActor_RefLevelSequenceActor_PropertyAddress, BeforeInitAddBindingActor_FunctionAddress, "RefLevelSequenceActor");
		BeforeInitAddBindingActor_RefLevelSequenceActor_Offset = NativeReflectionCached.GetPropertyOffset(BeforeInitAddBindingActor_FunctionAddress, "RefLevelSequenceActor");
		BeforeInitAddBindingActor_RefLevelSequenceActor_IsValid = NativeReflectionCached.ValidatePropertyClass(BeforeInitAddBindingActor_FunctionAddress, "RefLevelSequenceActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BeforeInitAddBindingActor_BindingActorTagName_PropertyAddress, BeforeInitAddBindingActor_FunctionAddress, "BindingActorTagName");
		BeforeInitAddBindingActor_BindingActorTagName_Offset = NativeReflectionCached.GetPropertyOffset(BeforeInitAddBindingActor_FunctionAddress, "BindingActorTagName");
		BeforeInitAddBindingActor_BindingActorTagName_IsValid = NativeReflectionCached.ValidatePropertyClass(BeforeInitAddBindingActor_FunctionAddress, "BindingActorTagName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BeforeInitAddBindingActor_InActor_PropertyAddress, BeforeInitAddBindingActor_FunctionAddress, "InActor");
		BeforeInitAddBindingActor_InActor_Offset = NativeReflectionCached.GetPropertyOffset(BeforeInitAddBindingActor_FunctionAddress, "InActor");
		BeforeInitAddBindingActor_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(BeforeInitAddBindingActor_FunctionAddress, "InActor", Classes.FObjectProperty);
		BeforeInitAddBindingActor_IsValid = BeforeInitAddBindingActor_FunctionAddress != IntPtr.Zero && BeforeInitAddBindingActor_RefLevelSequenceActor_IsValid && BeforeInitAddBindingActor_BindingActorTagName_IsValid && BeforeInitAddBindingActor_InActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlender:BeforeInitAddBindingActor", BeforeInitAddBindingActor_IsValid);
	}
}
