using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_SpiderSilkEntangleComp : UActorCompBaseCS
{
	private BUC_SpiderSilkEntangleData SpiderSilkEntangleData { get; set; }

	private IBUC_MovementData MovementData { get; set; }

	public override void OnAttach()
	{
		SpiderSilkEntangleData = RequireWritableData<BUC_SpiderSilkEntangleData>();
		MovementData = RequireReadOnlyData<IBUC_MovementData, BUC_MovementData>();
		base.BUSEventCollection.Evt_OnSpiderSkillEntangleStiffEnded += new Del_Void(OnSpiderSkillEntangleStiffEnded);
		base.BUSEventCollection.Evt_OnSpiderSilkEntangleStateEnter += new Del_OnSpiderSilkEntangleStateEnter(OnSpiderSilkEntangleStateEnter);
		base.BUSEventCollection.Evt_OnSpiderSilkEntangleStateExit += new Del_Void(OnSpiderSilkEntangleStateExit);
	}

	public override void OnBeginPlay()
	{
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		CheckSpeed(DeltaTime);
	}

	private void CheckSpeed(float DeltaTime)
	{
		if (IsCheckSpeedEnable())
		{
			SpiderSilkEntangleData.SpeedMonitor_Interval_Timer += DeltaTime;
			float num = 0f;
			while (SpiderSilkEntangleData.SpeedMonitor_Interval_Timer > SpiderSilkEntangleData.SpiderSilkEntangleConfig.SpeedMonitorInterval)
			{
				float inTime = OwnerAsCharacterCS.GetVelocity().Size2D();
				float floatValue = SpiderSilkEntangleData.SpiderSilkEntangleConfig.MappingCurve_Speed.GetFloatValue(inTime);
				num += floatValue;
				SpiderSilkEntangleData.SpeedMonitor_Interval_Timer -= SpiderSilkEntangleData.SpiderSilkEntangleConfig.SpeedMonitorInterval;
			}
			if (MathLib.Abs(num) > 1E-08f)
			{
				OnCountChanged(num);
			}
		}
	}

	private bool IsCheckSpeedEnable()
	{
		EBGUMoveMode moveType = MovementData.GetMoveType();
		if (moveType != EBGUMoveMode.Normal && moveType != EBGUMoveMode.SideWalk)
		{
			return false;
		}
		if (SpiderSilkEntangleData.SpiderSilkEntangleConfig == null || SpiderSilkEntangleData.SpiderSilkEntangleConfig.SpeedMonitorInterval <= 0f || SpiderSilkEntangleData.SpiderSilkEntangleConfig.MappingCurve_Speed == null)
		{
			return false;
		}
		return true;
	}

	private void ClearCount()
	{
		if (SpiderSilkEntangleData.SpiderSilkEntangleConfig != null)
		{
			OnCountChanged(0f - SpiderSilkEntangleData.SpiderSilkEntangleConfig.MaxCount);
		}
	}

	private void OnCountChanged(float ChangeValue)
	{
		if (MathLib.Abs(ChangeValue) <= 1E-08f)
		{
			return;
		}
		SpiderSilkEntangleData.AddCount(ChangeValue);
		float count = SpiderSilkEntangleData.GetCount();
		if (SpiderSilkEntangleData.NiagaraComp != null)
		{
			foreach (FSilkEntangleNiagaraParamMapping item in SpiderSilkEntangleData.SpiderSilkEntangleConfig.Mapping_NiagaraParam)
			{
				float num = 0f;
				num = ((!(item.MappingCurve_CountTotal == null)) ? item.MappingCurve_CountTotal.GetFloatValue(count) : (count * item.Ratio));
				SpiderSilkEntangleData.NiagaraComp.SetIntParameter(item.NiagaraParamName, (int)num);
			}
		}
		if (!SpiderSilkEntangleData.bHandleSpiderSilkyHardMovingBuff && SpiderSilkEntangleData.GetCount() >= SpiderSilkEntangleData.SpiderSilkEntangleConfig.CountThreshold_HardMove)
		{
			EnterHardMoving();
		}
		else if (SpiderSilkEntangleData.bHandleSpiderSilkyHardMovingBuff && SpiderSilkEntangleData.GetCount() < SpiderSilkEntangleData.SpiderSilkEntangleConfig.CountThreshold_HardMove)
		{
			ExitHardMoving();
		}
		if (SpiderSilkEntangleData.GetCount() >= SpiderSilkEntangleData.SpiderSilkEntangleConfig.MaxCount)
		{
			OnCountAccToMax();
		}
	}

	private void OnCountAccToMax()
	{
		if (SpiderSilkEntangleData.SpiderSilkEntangleConfig != null)
		{
			base.BUSEventCollection?.Evt_TriggerSkillEffect.Invoke(SpiderSilkEntangleData.SpiderSilkEntangleConfig.EntangleSkillEffectID, default(FEffectInstReq));
		}
	}

	private void OnSpiderSkillEntangleStiffEnded()
	{
		if (SpiderSilkEntangleData.bInSpiderSilkEntangleState)
		{
			ClearCount();
		}
	}

	private void OnSpiderSilkEntangleStateEnter(BGWDataAsset_SpiderSilkEntangleConfig SpiderSilkEntangleConfig)
	{
		if (SpiderSilkEntangleConfig != null)
		{
			SpiderSilkEntangleData.bInSpiderSilkEntangleState = true;
			SetCanTick(Val: true);
			SpiderSilkEntangleData.SpiderSilkEntangleConfig = SpiderSilkEntangleConfig;
			SpiderSilkEntangleData.SpeedMonitor_Interval_Timer = 0f;
			BindListener();
			SpiderSilkEntangleData.NiagaraComp = UNiagaraFunctionLibrary.SpawnSystemAttached(SpiderSilkEntangleConfig.NG_Template, OwnerAsCharacterCS.Mesh, B1GlobalFNames.Root, FVector.ZeroVector, FRotator.ZeroRotator, EAttachLocation.KeepRelativeOffset, bAutoDestroy: true, bAutoActivate: true, ENCPoolMethod.ManualRelease, bPreCullCheck: false);
		}
	}

	private void OnSpiderSilkEntangleStateExit()
	{
		if (SpiderSilkEntangleData.bInSpiderSilkEntangleState)
		{
			ClearCount();
			SpiderSilkEntangleData.bInSpiderSilkEntangleState = false;
			SetCanTick(Val: false);
			SpiderSilkEntangleData.SpiderSilkEntangleConfig = null;
			UnbindListener();
			if (SpiderSilkEntangleData.NiagaraComp != null)
			{
				SpiderSilkEntangleData.NiagaraComp.Deactivate();
				SpiderSilkEntangleData.NiagaraComp.SetVisibility(bNewVisibility: false);
				SpiderSilkEntangleData.NiagaraComp = null;
			}
		}
	}

	public void BindListener()
	{
		if (base.BUSEventCollection != null)
		{
			base.BUSEventCollection.Evt_UnitCastSkillSuccess += new Del_UnitCastSkillSuccess(OnUnitCastSkillSuccess);
			base.BUSEventCollection.Evt_OnLanded += new Del_Void(OnLanded);
			base.BUSEventCollection.Evt_OnJumpStart += new Del_Void_Vector(OnJumpStart);
		}
	}

	public void UnbindListener()
	{
		if (base.BUSEventCollection != null)
		{
			base.BUSEventCollection.Evt_UnitCastSkillSuccess -= new Del_UnitCastSkillSuccess(OnUnitCastSkillSuccess);
			base.BUSEventCollection.Evt_OnLanded -= new Del_Void(OnLanded);
			base.BUSEventCollection.Evt_OnJumpStart -= new Del_Void_Vector(OnJumpStart);
		}
	}

	private void OnJumpStart(FVector JumpDir)
	{
		if (SpiderSilkEntangleData.SpiderSilkEntangleConfig != null)
		{
			OnCountChanged(SpiderSilkEntangleData.SpiderSilkEntangleConfig.IncreaseCount_OnJump);
			if (SpiderSilkEntangleData.SpiderSilkEntangleConfig.bExitHardMoveWhenJump)
			{
				ExitHardMoving();
			}
		}
	}

	private void OnLanded()
	{
		if (SpiderSilkEntangleData.SpiderSilkEntangleConfig != null)
		{
			OnCountChanged(SpiderSilkEntangleData.SpiderSilkEntangleConfig.IncreaseCount_OnLand);
		}
	}

	private void OnUnitCastSkillSuccess(int MappingSkillID, int OriSkillID, ECastSkillSourceType SourceType)
	{
		if (SpiderSilkEntangleData.SpiderSilkEntangleConfig != null && SpiderSilkEntangleData.SpiderSilkEntangleConfig.SkillAccCountMapping.TryGetValue(MappingSkillID, out var value))
		{
			OnCountChanged(value);
		}
	}

	private void EnterHardMoving()
	{
		if (!SpiderSilkEntangleData.bHandleSpiderSilkyHardMovingBuff && SpiderSilkEntangleData.SpiderSilkEntangleConfig.HardMoveBuffID > 0)
		{
			base.BUSEventCollection?.Evt_BuffAdd.Invoke(SpiderSilkEntangleData.SpiderSilkEntangleConfig.HardMoveBuffID, Owner, Owner, -1f, EBuffSourceType.SpiderSilkEntangle);
			SpiderSilkEntangleData.bHandleSpiderSilkyHardMovingBuff = true;
		}
	}

	private void ExitHardMoving()
	{
		if (SpiderSilkEntangleData.bHandleSpiderSilkyHardMovingBuff && SpiderSilkEntangleData.SpiderSilkEntangleConfig.HardMoveBuffID > 0)
		{
			base.BUSEventCollection?.Evt_BuffRemove.Invoke(SpiderSilkEntangleData.SpiderSilkEntangleConfig.HardMoveBuffID, EBuffEffectTriggerType.None, 1);
			SpiderSilkEntangleData.bHandleSpiderSilkyHardMovingBuff = false;
		}
	}
}
