using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[DisplayName("带条件播放特效")]
[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX_WithCondition")]
internal class BAN_GSPlayNiagaraFX_WithCondition : BAN_GSPlayNiagaraFX
{
	private static bool Condition_IsValid;

	private static int Condition_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[DisplayName("条件列表")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX_WithCondition:Condition")]
	public FPlayNiagaraConditions Condition
	{
		get
		{
			CheckDestroyed();
			if (!Condition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX_WithCondition:Condition");
				return default(FPlayNiagaraConditions);
			}
			return FPlayNiagaraConditions.FromNative(IntPtr.Add(base.Address, Condition_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Condition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX_WithCondition:Condition");
			}
			else
			{
				FPlayNiagaraConditions.ToNative(IntPtr.Add(base.Address, Condition_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX_WithCondition:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (ProcessCondition(NotifyParam.owner))
		{
			base.GSNotifyCS_Implementation(NotifyParam);
		}
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

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSPlayNiagaraFX_WithCondition:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib.BAN_GSPlayNiagaraFX_WithCondition bAN_GSPlayNiagaraFX_WithCondition = GCHelper.Find<GSDispLib.BAN_GSPlayNiagaraFX_WithCondition>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSPlayNiagaraFX_WithCondition.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSPlayNiagaraFX_WithCondition");
		Condition_Offset = NativeReflection.GetPropertyOffset(intPtr, "Condition");
		Condition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Condition", Classes.FStructProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSPlayNiagaraFX_WithCondition:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_GSPlayNiagaraFX_WithCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSDispLib.BAN_GSPlayNiagaraFX_WithCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSDispLib.BAN_GSPlayNiagaraFX_WithCondition));
	}
}
