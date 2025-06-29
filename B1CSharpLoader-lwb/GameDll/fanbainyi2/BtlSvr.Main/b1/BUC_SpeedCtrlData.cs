using System;
using b1.ECS;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUC_SpeedCtrlData : IBUC_SpeedCtrlData, IEntitySafeData
{
	public float MaxAcceleration;

	public float MoveSpeedAddValue;

	private unsafe BUC_SpeedCtrlData_Raw* Target;

	public uint MaxCustomMovementSpeedHandleID { get; set; }

	public uint MaxFlySpeedHandleID { get; set; }

	public uint MaxSwimSpeedHandleID { get; set; }

	public uint MaxWalkSpeedCrouchedHandleID { get; set; }

	public uint MaxWalkSpeedHandleID { get; set; }

	public unsafe void SetPtr(IntPtr Ptr)
	{
		Target = (BUC_SpeedCtrlData_Raw*)(void*)Ptr;
	}

	public unsafe float GetFinalSpeedCtrlRate()
	{
		float num = 1f;
		for (int i = 0; i < 2; i++)
		{
			num *= Target->SpeedRates[i];
		}
		return num;
	}

	public unsafe void SetSpeedRateCtrl(int CtrlID, float SpeedRate)
	{
		if (2 > CtrlID)
		{
			Target->SpeedRates[CtrlID] = SpeedRate;
		}
	}

	public unsafe void SetSpeedInfo(int ResID, int OverrideID, AActor Owner)
	{
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(ResID);
		if (!BGW_LogUtil.LogIfNull(unitCommDesc, "Find UnitCommDesc failed! ResID: ", ResID))
		{
			if (unitCommDesc != null)
			{
				Target->MoveSpeedFastBase = (Target->MoveSpeedFast = unitCommDesc.MoveSpeedFast);
				Target->MoveSpeedNormalBase = (Target->MoveSpeedNormal = unitCommDesc.MoveSpeedNormal);
				Target->MoveSpeedSlowBase = (Target->MoveSpeedSlow = unitCommDesc.MoveSpeedSlow);
			}
			else
			{
				Target->MoveSpeedFastBase = (Target->MoveSpeedFast = 600f);
				Target->MoveSpeedNormalBase = (Target->MoveSpeedNormal = 600f);
				Target->MoveSpeedSlowBase = (Target->MoveSpeedSlow = 600f);
			}
			FUStPlayerCommDesc playerCommDesc = BGW_GameDB.GetPlayerCommDesc(ResID, Owner);
			if (playerCommDesc != null)
			{
				Target->JumpSpeedNormal = playerCommDesc.JumpSpeedNormal;
				Target->JumpSpeedFast = playerCommDesc.JumpSpeedFast;
				Target->MoveBackSpeedRate = playerCommDesc.MoveBackSpeedRate;
			}
			else
			{
				Target->JumpSpeedNormal = 600f;
				Target->JumpSpeedFast = 600f;
				Target->MoveBackSpeedRate = 1f;
			}
			for (int i = 0; i < 2; i++)
			{
				Target->SpeedRates[i] = 1f;
			}
		}
	}

	public unsafe void SetSpeedInfo(float FastSpdRatio, float NormalSpdRatio, float SlowSpdRatio)
	{
		Target->MoveSpeedFast = Target->MoveSpeedFastBase * (1f + FastSpdRatio / 10000f);
		Target->MoveSpeedNormal = Target->MoveSpeedNormalBase * (1f + NormalSpdRatio / 10000f);
		Target->MoveSpeedSlow = Target->MoveSpeedSlowBase * (1f + SlowSpdRatio / 10000f);
		for (int i = 0; i < 2; i++)
		{
			Target->SpeedRates[i] = 1f;
		}
	}

	public unsafe void SetSpeedInfoBase(float FastSpdBase, float NormalSpdBase, float SlowSpdBase)
	{
		Target->MoveSpeedFast = (Target->MoveSpeedFastBase = FastSpdBase);
		Target->MoveSpeedNormal = (Target->MoveSpeedNormalBase = NormalSpdBase);
		Target->MoveSpeedSlow = (Target->MoveSpeedSlowBase = SlowSpdBase);
	}

	public unsafe float GetMoveSpeedFast()
	{
		return Target->MoveSpeedFast;
	}

	public unsafe float GetMoveSpeedNormal()
	{
		return Target->MoveSpeedNormal;
	}

	public unsafe float GetMoveSpeedSlow()
	{
		return Target->MoveSpeedSlow;
	}

	public unsafe float GetJumpSpeedFast()
	{
		return Target->JumpSpeedFast;
	}

	public unsafe float GetJumpSpeedNormal()
	{
		return Target->JumpSpeedNormal;
	}

	public unsafe float GetMoveBackSpeedRate()
	{
		return Target->MoveBackSpeedRate;
	}
}
