using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_MagicFieldParamComp : UActorCompBaseCS
{
	private b1.BUC_MagicFieldParamData MagicFieldParamData;

	public override void OnAttach()
	{
		MagicFieldParamData = RequireWritableData<b1.BUC_MagicFieldParamData>();
		base.BUSEventCollection.Evt_SetMagicFieldDirection += new Del_SetMagicFieldDirection(OnSetMagicFieldDirection);
		base.BUSEventCollection.Evt_LeaveMagicField += new Del_Void_Actor(OnLeaveMagicField);
	}

	public override void PreBeginPlay()
	{
		InitData();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.BUSEventCollection.Evt_SetMagicFieldDirection -= new Del_SetMagicFieldDirection(OnSetMagicFieldDirection);
		base.BUSEventCollection.Evt_LeaveMagicField -= new Del_Void_Actor(OnLeaveMagicField);
	}

	private void InitData()
	{
		MagicFieldParamData.MagicFieldDirection = new Dictionary<int, b1.MagicFieldDirectionInfo>();
	}

	private void OnSetMagicFieldDirection(AActor MFActor, EMagicFieldDirectionUsage Usage, in FVector MFDirection)
	{
		b1.MagicFieldDirectionInfo value;
		if (MFActor.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("OnSetMagicFieldDirection MFActor.IsNullOrDestroyed");
		}
		else if (MagicFieldParamData.MagicFieldDirection.TryGetValue(AActorStatics.GetEntityHash(MFActor), out value))
		{
			value.Usage = Usage;
			value.Direction = MFDirection;
		}
		else
		{
			b1.MagicFieldDirectionInfo value2 = new b1.MagicFieldDirectionInfo(Usage, in MFDirection);
			MagicFieldParamData.MagicFieldDirection.Add(AActorStatics.GetEntityHash(MFActor), value2);
		}
	}

	private void OnLeaveMagicField(AActor MFActor)
	{
		if (MFActor.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("OnLeaveMagicField MFActor.IsNullOrDestroyed");
			return;
		}
		if (MagicFieldParamData == null || MagicFieldParamData.MagicFieldDirection == null)
		{
			BGW_LogUtil.LogError($"LeaveMagicFieldError :   {MFActor.GetFName()}     {GetOwner().GetFName()}");
			BGW_LogUtil.LogError($"Pos :   {MFActor.GetActorLocation()}     {GetOwner().GetActorLocation()}");
		}
		MagicFieldParamData.MagicFieldDirection.Remove(AActorStatics.GetEntityHash(MFActor));
	}
}
