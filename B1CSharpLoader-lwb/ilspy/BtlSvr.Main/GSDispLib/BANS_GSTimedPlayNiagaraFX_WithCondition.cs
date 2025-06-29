using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[DisplayName("带条件播放特效")]
[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX_WithCondition")]
internal class BANS_GSTimedPlayNiagaraFX_WithCondition : GSDispLib.BANS_GSTimedPlayNiagaraFX
{
	private static bool Condition_IsValid;

	private static int Condition_Offset;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("条件列表")]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX_WithCondition:Condition")]
	public FPlayNiagaraConditions Condition
	{
		get
		{
			CheckDestroyed();
			if (!Condition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX_WithCondition:Condition");
				return default(FPlayNiagaraConditions);
			}
			return FPlayNiagaraConditions.FromNative(IntPtr.Add(base.Address, Condition_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Condition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX_WithCondition:Condition");
			}
			else
			{
				FPlayNiagaraConditions.ToNative(IntPtr.Add(base.Address, Condition_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX_WithCondition:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (ProcessCondition(NotifyParam.owner))
		{
			base.GSNotifyBeginCS_Implementation(NotifyParam, TotalDuration);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX_WithCondition:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		base.GSNotifyEndCS_Implementation(NotifyParam);
	}

	private bool ProcessCondition(AActor Owner)
	{
		if (DispLibDispWorld.GetPlayingEnv(Owner) == DispLibPlayingEnv.EditorCustomScene)
		{
			if (Condition.bForDebug)
			{
				return true;
			}
			return false;
		}
		if (Condition.Conditions.Count > 0 && BGUFunctionLibraryCS.CheckConditions(Owner, Condition.UnitType, Condition.Conditions, Condition.ConditionalRelation, Condition.IsReverseCondition) != 1)
		{
			return false;
		}
		return true;
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX_WithCondition:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib.BANS_GSTimedPlayNiagaraFX_WithCondition bANS_GSTimedPlayNiagaraFX_WithCondition = GCHelper.Find<GSDispLib.BANS_GSTimedPlayNiagaraFX_WithCondition>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSTimedPlayNiagaraFX_WithCondition.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX_WithCondition:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib.BANS_GSTimedPlayNiagaraFX_WithCondition bANS_GSTimedPlayNiagaraFX_WithCondition = GCHelper.Find<GSDispLib.BANS_GSTimedPlayNiagaraFX_WithCondition>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSTimedPlayNiagaraFX_WithCondition.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX_WithCondition");
		Condition_Offset = NativeReflection.GetPropertyOffset(intPtr, "Condition");
		Condition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Condition", Classes.FStructProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX_WithCondition:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX_WithCondition:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSTimedPlayNiagaraFX_WithCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSDispLib.BANS_GSTimedPlayNiagaraFX_WithCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSDispLib.BANS_GSTimedPlayNiagaraFX_WithCondition));
	}
}
