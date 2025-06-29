namespace b1;

public class FPlayerStateParamCollection
{
	public const int ParamCount = 39;

	public string[] AllParams { get; }

	public string OverrideLevelNumericalStrength
	{
		set
		{
			if (AllParams.Length != 0)
			{
				AllParams[0] = value;
			}
		}
	}

	public string PhantomRushImperceptibleState
	{
		set
		{
			if (AllParams.Length > 1)
			{
				AllParams[1] = value;
			}
		}
	}

	public string DaShengStage
	{
		set
		{
			if (AllParams.Length > 2)
			{
				AllParams[2] = value;
			}
		}
	}

	public string MMState
	{
		set
		{
			if (AllParams.Length > 3)
			{
				AllParams[3] = value;
			}
		}
	}

	public string HP
	{
		set
		{
			if (AllParams.Length > 4)
			{
				AllParams[4] = value;
			}
		}
	}

	public string Stamina
	{
		set
		{
			if (AllParams.Length > 5)
			{
				AllParams[5] = value;
			}
		}
	}

	public string TransEnergy
	{
		set
		{
			if (AllParams.Length > 6)
			{
				AllParams[6] = value;
			}
		}
	}

	public string FaBaoEnergy
	{
		set
		{
			if (AllParams.Length > 7)
			{
				AllParams[7] = value;
			}
		}
	}

	public string VigorEnergy
	{
		set
		{
			if (AllParams.Length > 8)
			{
				AllParams[8] = value;
			}
		}
	}

	public string SkillSuperArmor
	{
		set
		{
			if (AllParams.Length > 9)
			{
				AllParams[9] = value;
			}
		}
	}

	public string MoveMode
	{
		set
		{
			if (AllParams.Length > 10)
			{
				AllParams[10] = value;
			}
		}
	}

	public string MovementMode
	{
		set
		{
			if (AllParams.Length > 11)
			{
				AllParams[11] = value;
			}
		}
	}

	public string BattleState
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

	public string CurrentSpells
	{
		set
		{
			if (AllParams.Length > 14)
			{
				AllParams[14] = value;
			}
		}
	}

	public string IceAbnormal
	{
		set
		{
			if (AllParams.Length > 15)
			{
				AllParams[15] = value;
			}
		}
	}

	public string FireAbnormal
	{
		set
		{
			if (AllParams.Length > 16)
			{
				AllParams[16] = value;
			}
		}
	}

	public string PoisonAbnormal
	{
		set
		{
			if (AllParams.Length > 17)
			{
				AllParams[17] = value;
			}
		}
	}

	public string ThunderAbnormal
	{
		set
		{
			if (AllParams.Length > 18)
			{
				AllParams[18] = value;
			}
		}
	}

	public string YinAbnormal
	{
		set
		{
			if (AllParams.Length > 19)
			{
				AllParams[19] = value;
			}
		}
	}

	public string YangAbnormal
	{
		set
		{
			if (AllParams.Length > 20)
			{
				AllParams[20] = value;
			}
		}
	}

	public string ChargeLevel
	{
		set
		{
			if (AllParams.Length > 21)
			{
				AllParams[21] = value;
			}
		}
	}

	public string Charging
	{
		set
		{
			if (AllParams.Length > 22)
			{
				AllParams[22] = value;
			}
		}
	}

	public string SurfaceType
	{
		set
		{
			if (AllParams.Length > 23)
			{
				AllParams[23] = value;
			}
		}
	}

	public string BlindSlot
	{
		set
		{
			if (AllParams.Length > 24)
			{
				AllParams[24] = value;
			}
		}
	}

	public string CameraGroupID
	{
		set
		{
			if (AllParams.Length > 25)
			{
				AllParams[25] = value;
			}
		}
	}

	public string CameraID
	{
		set
		{
			if (AllParams.Length > 26)
			{
				AllParams[26] = value;
			}
		}
	}

	public string WeakPerform
	{
		set
		{
			if (AllParams.Length > 27)
			{
				AllParams[27] = value;
			}
		}
	}

	public string HairCD
	{
		set
		{
			if (AllParams.Length > 28)
			{
				AllParams[28] = value;
			}
		}
	}

	public string Ice
	{
		set
		{
			if (AllParams.Length > 29)
			{
				AllParams[29] = value;
			}
		}
	}

	public string Fire
	{
		set
		{
			if (AllParams.Length > 30)
			{
				AllParams[30] = value;
			}
		}
	}

	public string Poison
	{
		set
		{
			if (AllParams.Length > 31)
			{
				AllParams[31] = value;
			}
		}
	}

	public string Thunder
	{
		set
		{
			if (AllParams.Length > 32)
			{
				AllParams[32] = value;
			}
		}
	}

	public string StickPotential
	{
		set
		{
			if (AllParams.Length > 33)
			{
				AllParams[33] = value;
			}
		}
	}

	public string CurrentSkillID
	{
		set
		{
			if (AllParams.Length > 34)
			{
				AllParams[34] = value;
			}
		}
	}

	public string HeightAboveFloor
	{
		set
		{
			if (AllParams.Length > 35)
			{
				AllParams[35] = value;
			}
		}
	}

	public string CurrentPlayingMontage
	{
		set
		{
			if (AllParams.Length > 36)
			{
				AllParams[36] = value;
			}
		}
	}

	public string CurrentStateLibBase
	{
		set
		{
			if (AllParams.Length > 37)
			{
				AllParams[37] = value;
			}
		}
	}

	public string CurrentStateLibMod
	{
		set
		{
			if (AllParams.Length > 38)
			{
				AllParams[38] = value;
			}
		}
	}

	public FPlayerStateParamCollection()
	{
		AllParams = new string[39];
	}
}
