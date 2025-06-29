using b1.EventDelDefine;
using b1.Prediction;
using UnrealEngine.Engine;

namespace b1;

public class BUS_SimpleJumpComp : UActorCompBaseCS
{
	private BUC_SimpleJumpData SimpleJumpData;

	private IBUC_PropMgrData PropMgrData;

	public override void OnAttach()
	{
		SimpleJumpData = RequireWritableData<BUC_SimpleJumpData>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		base.BUSEventCollection.Evt_TriggerSimpleJump += new Del_Void_Bool(TriggerSimpleJump);
		base.BUSEventCollection.Evt_TriggerRootMotionJump.Predict += new GSDel_Void_IPK_Del.Del_Predict(OnTriggerRootMotionJump_Predict);
		base.BUSEventCollection.Evt_TriggerRootMotionJump.Cue += new GSDel_Void_IPK_Del.Del_Predict(OnTriggerRootMotionJump);
		base.BUSEventCollection.Evt_RootMotionJumpStart += new Del_Void(OnRootMotionJumpStart);
		base.BUSEventCollection.Evt_RootMotionJumpEnd += new Del_Void(OnRootMotionJumpEnd);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			UCharacterMovementComponent characterMovement = bGUCharacterCS.CharacterMovement;
			if (SimpleJumpData.bStartJump && !characterMovement.IsFalling())
			{
				SimpleJumpData.bStartJump = false;
			}
		}
	}

	private void TriggerSimpleJump(bool bStartJump)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (!(bGUCharacterCS == null) && bGUCharacterCS.ActorHasTag(B1GlobalFNames.PlayerSpiderTag))
		{
			bGUCharacterCS.Jump();
			SimpleJumpData.bStartJump = bStartJump;
		}
	}

	private void OnTriggerRootMotionJump_Predict(GSPredictionKey PredictionKey)
	{
		OnTriggerRootMotionJump(null);
	}

	private void OnTriggerRootMotionJump(GSPredictionKey PredictionKey)
	{
		if (PredictionKey == null)
		{
			OnTriggerRootMotionJump();
		}
	}

	private void OnTriggerRootMotionJump()
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (!(bGUCharacterCS == null) && !bGUCharacterCS.CharacterMovement.IsFalling())
		{
			SimpleJumpData.IsRootMotionJump = true;
		}
	}

	private void OnRootMotionJumpStart()
	{
		if (SimpleJumpData.MovementModeHandleID == 0)
		{
			base.BUSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 5, 0u, 0u, bSetDefaultProperty: false, "SimpleJumpComp");
			SimpleJumpData.MovementModeHandleID = PropMgrData.GetLastHandleID();
		}
		else
		{
			base.BUSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 5, SimpleJumpData.MovementModeHandleID, 0u, bSetDefaultProperty: false, "SimpleJumpComp");
		}
	}

	private void OnRootMotionJumpEnd()
	{
		base.BUSEventCollection.Evt_ResetProperty.Invoke(SimpleJumpData.MovementModeHandleID);
		SimpleJumpData.MovementModeHandleID = 0u;
		SimpleJumpData.IsRootMotionJump = false;
	}
}
