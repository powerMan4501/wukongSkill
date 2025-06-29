namespace b1;

public class FMonsterStateParamCollection
{
	public const int ParamCount = 50;

	public string[] AllParams { get; }

	public float Distance
	{
		set
		{
			if (AllParams.Length != 0)
			{
				AllParams[0] = value.ToString("F3");
			}
		}
	}

	public float Angle
	{
		set
		{
			if (AllParams.Length > 1)
			{
				AllParams[1] = value.ToString("F3");
			}
		}
	}

	public int ResID
	{
		set
		{
			if (AllParams.Length > 2)
			{
				AllParams[2] = value.ToString();
			}
		}
	}

	public int BattleExtendID
	{
		set
		{
			if (AllParams.Length > 3)
			{
				AllParams[3] = value.ToString();
			}
		}
	}

	public int LevelNumericalStrength
	{
		set
		{
			if (AllParams.Length > 4)
			{
				AllParams[4] = value.ToString();
			}
		}
	}

	public string MMState
	{
		set
		{
			if (AllParams.Length > 5)
			{
				AllParams[5] = value;
			}
		}
	}

	public string HP
	{
		set
		{
			if (AllParams.Length > 6)
			{
				AllParams[6] = value;
			}
		}
	}

	public string Atk
	{
		set
		{
			if (AllParams.Length > 7)
			{
				AllParams[7] = value;
			}
		}
	}

	public string SkillSuperArmor
	{
		set
		{
			if (AllParams.Length > 8)
			{
				AllParams[8] = value;
			}
		}
	}

	public string MoveMode
	{
		set
		{
			if (AllParams.Length > 9)
			{
				AllParams[9] = value;
			}
		}
	}

	public string MovementMode
	{
		set
		{
			if (AllParams.Length > 10)
			{
				AllParams[10] = value;
			}
		}
	}

	public string BattleState
	{
		set
		{
			if (AllParams.Length > 11)
			{
				AllParams[11] = value;
			}
		}
	}

	public string BlindSlot
	{
		set
		{
			if (AllParams.Length > 12)
			{
				AllParams[12] = value;
			}
		}
	}

	public string BeAttackInfoID
	{
		set
		{
			if (AllParams.Length > 13)
			{
				AllParams[13] = value;
			}
		}
	}

	public string PartRuleID
	{
		set
		{
			if (AllParams.Length > 14)
			{
				AllParams[14] = value;
			}
		}
	}

	public string DeadInfoID
	{
		set
		{
			if (AllParams.Length > 15)
			{
				AllParams[15] = value;
			}
		}
	}

	public string IceAbnormal
	{
		set
		{
			if (AllParams.Length > 16)
			{
				AllParams[16] = value;
			}
		}
	}

	public string FireAbnormal
	{
		set
		{
			if (AllParams.Length > 17)
			{
				AllParams[17] = value;
			}
		}
	}

	public string PoisonAbnormal
	{
		set
		{
			if (AllParams.Length > 18)
			{
				AllParams[18] = value;
			}
		}
	}

	public string ThunderAbnormal
	{
		set
		{
			if (AllParams.Length > 19)
			{
				AllParams[19] = value;
			}
		}
	}

	public string YinAbnormal
	{
		set
		{
			if (AllParams.Length > 20)
			{
				AllParams[20] = value;
			}
		}
	}

	public string YangAbnormal
	{
		set
		{
			if (AllParams.Length > 21)
			{
				AllParams[21] = value;
			}
		}
	}

	public string BlockCount
	{
		set
		{
			if (AllParams.Length > 22)
			{
				AllParams[22] = value;
			}
		}
	}

	public string BlockBreaking
	{
		set
		{
			if (AllParams.Length > 23)
			{
				AllParams[23] = value;
			}
		}
	}

	public string BlockResetCount
	{
		set
		{
			if (AllParams.Length > 24)
			{
				AllParams[24] = value;
			}
		}
	}

	public string StiffBackCount
	{
		set
		{
			if (AllParams.Length > 25)
			{
				AllParams[25] = value;
			}
		}
	}

	public string ChargeSkillPhase
	{
		set
		{
			if (AllParams.Length > 26)
			{
				AllParams[26] = value;
			}
		}
	}

	public string IceBreak
	{
		set
		{
			if (AllParams.Length > 27)
			{
				AllParams[27] = value;
			}
		}
	}

	public string FireBreak
	{
		set
		{
			if (AllParams.Length > 28)
			{
				AllParams[28] = value;
			}
		}
	}

	public string PoisonBreak
	{
		set
		{
			if (AllParams.Length > 29)
			{
				AllParams[29] = value;
			}
		}
	}

	public string ThunderBreak
	{
		set
		{
			if (AllParams.Length > 30)
			{
				AllParams[30] = value;
			}
		}
	}

	public string SurfaceType
	{
		set
		{
			if (AllParams.Length > 31)
			{
				AllParams[31] = value;
			}
		}
	}

	public string CurrentSkillID
	{
		set
		{
			if (AllParams.Length > 32)
			{
				AllParams[32] = value;
			}
		}
	}

	public string CurrentPlayingMontage
	{
		set
		{
			if (AllParams.Length > 33)
			{
				AllParams[33] = value;
			}
		}
	}

	public string CurrentTeamID
	{
		set
		{
			if (AllParams.Length > 34)
			{
				AllParams[34] = value;
			}
		}
	}

	public string CurrentStateLibBase
	{
		set
		{
			if (AllParams.Length > 35)
			{
				AllParams[35] = value;
			}
		}
	}

	public string CurrentStateLibMod
	{
		set
		{
			if (AllParams.Length > 36)
			{
				AllParams[36] = value;
			}
		}
	}

	public bool UROState
	{
		set
		{
			if (AllParams.Length > 37)
			{
				AllParams[37] = value.ToString();
			}
		}
	}

	public EAINodeActionType CurrentAINode
	{
		set
		{
			if (AllParams.Length > 38)
			{
				AllParams[38] = value.ToString();
			}
		}
	}

	public string CurrentHatredTarget
	{
		set
		{
			if (AllParams.Length > 39)
			{
				AllParams[39] = value;
			}
		}
	}

	public string AITarget
	{
		set
		{
			if (AllParams.Length > 40)
			{
				AllParams[40] = value;
			}
		}
	}

	public string SkillBaseTarget
	{
		set
		{
			if (AllParams.Length > 41)
			{
				AllParams[41] = value;
			}
		}
	}

	public string ComboTarget
	{
		set
		{
			if (AllParams.Length > 42)
			{
				AllParams[42] = value;
			}
		}
	}

	public string AOTarget
	{
		set
		{
			if (AllParams.Length > 43)
			{
				AllParams[43] = value;
			}
		}
	}

	public string MoveToTarget
	{
		set
		{
			if (AllParams.Length > 44)
			{
				AllParams[44] = value;
			}
		}
	}

	public string CurrentFsmState
	{
		set
		{
			if (AllParams.Length > 45)
			{
				AllParams[45] = value;
			}
		}
	}

	public string CurrentFsmSolver
	{
		set
		{
			if (AllParams.Length > 46)
			{
				AllParams[46] = value;
			}
		}
	}

	public string CurrentOwningLevel
	{
		set
		{
			if (AllParams.Length > 47)
			{
				AllParams[47] = value;
			}
		}
	}

	public string CurrentHPFixedDM
	{
		set
		{
			if (AllParams.Length > 48)
			{
				AllParams[48] = value;
			}
		}
	}

	public string CurrentQualityType
	{
		set
		{
			if (AllParams.Length > 49)
			{
				AllParams[49] = value;
			}
		}
	}

	public FMonsterStateParamCollection()
	{
		AllParams = new string[50];
	}
}
