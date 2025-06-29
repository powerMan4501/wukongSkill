using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

public class FStraightParams
{
	public string[] AllParams { get; }

	public FVector TargetRef_CurrentValue
	{
		set
		{
			if (AllParams.Length != 0)
			{
				AllParams[0] = value.ToString();
			}
		}
	}

	public FVector TargetRef_CurveStep_Before
	{
		set
		{
			if (AllParams.Length > 1)
			{
				AllParams[1] = value.ToString();
			}
		}
	}

	public FVector TargetRef_CurveStep_After
	{
		set
		{
			if (AllParams.Length > 2)
			{
				AllParams[2] = value.ToString();
			}
		}
	}

	public float TargetRef_CurveStep_Input_P2TDistance
	{
		set
		{
			if (AllParams.Length > 3)
			{
				AllParams[3] = value.ToString("F2");
			}
		}
	}

	public FVector TargetRef_OffsetStep_Before
	{
		set
		{
			if (AllParams.Length > 4)
			{
				AllParams[4] = value.ToString();
			}
		}
	}

	public FVector TargetRef_OffsetStep_After
	{
		set
		{
			if (AllParams.Length > 5)
			{
				AllParams[5] = value.ToString();
			}
		}
	}

	public float TargetRef_OffsetStep_Input_StraightTargetRefHeightOffset
	{
		set
		{
			if (AllParams.Length > 6)
			{
				AllParams[6] = value.ToString("F2");
			}
		}
	}

	public float TargetRef_OffsetStep_Input_StraightTargetRefHeightOffsetSpeed
	{
		set
		{
			if (AllParams.Length > 7)
			{
				AllParams[7] = value.ToString("F2");
			}
		}
	}

	public FVector TargetRef_OffsetStep_Procedure_TargetRefPos
	{
		set
		{
			if (AllParams.Length > 8)
			{
				AllParams[8] = value.ToString();
			}
		}
	}

	public FVector TargetRef_Threshold_Before
	{
		set
		{
			if (AllParams.Length > 9)
			{
				AllParams[9] = value.ToString();
			}
		}
	}

	public FVector TargetRef_Threshold_After
	{
		set
		{
			if (AllParams.Length > 10)
			{
				AllParams[10] = value.ToString();
			}
		}
	}

	public ECamRefType TargetRef_Threshold_Input_CamRefType
	{
		set
		{
			if (AllParams.Length > 11)
			{
				AllParams[11] = value.ToString();
			}
		}
	}

	public float TargetRef_Threshold_Input_StraightHeightThreshold
	{
		set
		{
			if (AllParams.Length > 12)
			{
				AllParams[12] = value.ToString("F2");
			}
		}
	}

	public FVector TargetRef_Threshold_Input_SoulFocusPos
	{
		set
		{
			if (AllParams.Length > 13)
			{
				AllParams[13] = value.ToString();
			}
		}
	}

	public float TargetRef_Threshold_Procedure_HeightDistance
	{
		set
		{
			if (AllParams.Length > 14)
			{
				AllParams[14] = value.ToString("F2");
			}
		}
	}

	public FVector TargetRef_SlowTrace_Before
	{
		set
		{
			if (AllParams.Length > 15)
			{
				AllParams[15] = value.ToString();
			}
		}
	}

	public FVector TargetRef_SlowTrace_After
	{
		set
		{
			if (AllParams.Length > 16)
			{
				AllParams[16] = value.ToString();
			}
		}
	}

	public ESlowTraceSolution TargetRef_SlowTrace_Input_StraightTraceSolution
	{
		set
		{
			if (AllParams.Length > 17)
			{
				AllParams[17] = value.ToString();
			}
		}
	}

	public float TargetRef_SlowTrace_Input_StraightSlowTraceTargetRefMaxYaw
	{
		set
		{
			if (AllParams.Length > 18)
			{
				AllParams[18] = value.ToString("F2");
			}
		}
	}

	public float TargetRef_SlowTrace_Input_StraightMaxTraceTargetRefDist
	{
		set
		{
			if (AllParams.Length > 19)
			{
				AllParams[19] = value.ToString("F2");
			}
		}
	}

	public float TargetRef_SlowTrace_Input_StraightTraceTargetRefSpeed
	{
		set
		{
			if (AllParams.Length > 20)
			{
				AllParams[20] = value.ToString("F2");
			}
		}
	}

	public FVector CameraRef_CurrentValue
	{
		set
		{
			if (AllParams.Length > 21)
			{
				AllParams[21] = value.ToString();
			}
		}
	}

	public FVector CameraRef_CalcWithRefType_Before
	{
		set
		{
			if (AllParams.Length > 22)
			{
				AllParams[22] = value.ToString();
			}
		}
	}

	public FVector CameraRef_CalcWithRefType_After
	{
		set
		{
			if (AllParams.Length > 23)
			{
				AllParams[23] = value.ToString();
			}
		}
	}

	public ECamRefType CameraRef_CalcWithRefType_Input_CamRefType
	{
		set
		{
			if (AllParams.Length > 24)
			{
				AllParams[24] = value.ToString();
			}
		}
	}

	public FVector CameraRef_CalcWithRefType_Procedure_PlayerRef
	{
		set
		{
			if (AllParams.Length > 25)
			{
				AllParams[25] = value.ToString();
			}
		}
	}

	public FVector CameraRef_CalcWithRefType_Procedure_TargetRef
	{
		set
		{
			if (AllParams.Length > 26)
			{
				AllParams[26] = value.ToString();
			}
		}
	}

	public FVector CameraRef_HeightScale_Before
	{
		set
		{
			if (AllParams.Length > 27)
			{
				AllParams[27] = value.ToString();
			}
		}
	}

	public FVector CameraRef_HeightScale_After
	{
		set
		{
			if (AllParams.Length > 28)
			{
				AllParams[28] = value.ToString();
			}
		}
	}

	public ECamRefType CameraRef_HeightScale_Input_CamRefType
	{
		set
		{
			if (AllParams.Length > 29)
			{
				AllParams[29] = value.ToString();
			}
		}
	}

	public float CameraRef_HeightScale_Input_StraightHeightScaleFactor
	{
		set
		{
			if (AllParams.Length > 30)
			{
				AllParams[30] = value.ToString("F2");
			}
		}
	}

	public float CameraRef_HeightScale_Input_StraightClosestDist
	{
		set
		{
			if (AllParams.Length > 31)
			{
				AllParams[31] = value.ToString("F2");
			}
		}
	}

	public float CameraRef_HeightScale_Input_StraightHeightScaleFurthestDist
	{
		set
		{
			if (AllParams.Length > 32)
			{
				AllParams[32] = value.ToString("F2");
			}
		}
	}

	public float CameraRef_HeightScale_Procedure_HeightScale
	{
		set
		{
			if (AllParams.Length > 33)
			{
				AllParams[33] = value.ToString("F2");
			}
		}
	}

	public float CameraRef_HeightScale_Procedure_P2TDistance
	{
		set
		{
			if (AllParams.Length > 34)
			{
				AllParams[34] = value.ToString("F2");
			}
		}
	}

	public FRotator CameraRotation_CurrentValue
	{
		set
		{
			if (AllParams.Length > 35)
			{
				AllParams[35] = value.ToCompactString();
			}
		}
	}

	public FRotator CameraRotation_MakeRotFromX_Before
	{
		set
		{
			if (AllParams.Length > 36)
			{
				AllParams[36] = value.ToCompactString();
			}
		}
	}

	public FRotator CameraRotation_MakeRotFromX_After
	{
		set
		{
			if (AllParams.Length > 37)
			{
				AllParams[37] = value.ToCompactString();
			}
		}
	}

	public FVector CameraRotation_MakeRotFromX_Input_CameraRefPos
	{
		set
		{
			if (AllParams.Length > 38)
			{
				AllParams[38] = value.ToString();
			}
		}
	}

	public FVector CameraRotation_MakeRotFromX_Input_PlayerRefPos
	{
		set
		{
			if (AllParams.Length > 39)
			{
				AllParams[39] = value.ToString();
			}
		}
	}

	public FRotator CameraRotation_Clamp_Before
	{
		set
		{
			if (AllParams.Length > 40)
			{
				AllParams[40] = value.ToCompactString();
			}
		}
	}

	public FRotator CameraRotation_Clamp_After
	{
		set
		{
			if (AllParams.Length > 41)
			{
				AllParams[41] = value.ToCompactString();
			}
		}
	}

	public float CameraRotation_Clamp_Input_StraightMinPitch
	{
		set
		{
			if (AllParams.Length > 42)
			{
				AllParams[42] = value.ToString("F2");
			}
		}
	}

	public float CameraRotation_Clamp_Input_StraightMaxPitch
	{
		set
		{
			if (AllParams.Length > 43)
			{
				AllParams[43] = value.ToString("F2");
			}
		}
	}

	public FRotator CameraRotation_SlowTrace_Before
	{
		set
		{
			if (AllParams.Length > 44)
			{
				AllParams[44] = value.ToCompactString();
			}
		}
	}

	public FRotator CameraRotation_SlowTrace_After
	{
		set
		{
			if (AllParams.Length > 45)
			{
				AllParams[45] = value.ToCompactString();
			}
		}
	}

	public ESlowTraceSolution CameraRotation_SlowTrace_Input_StraightTraceSolution
	{
		set
		{
			if (AllParams.Length > 46)
			{
				AllParams[46] = value.ToString();
			}
		}
	}

	public float CameraRotation_SlowTrace_Input_StraightSlowTraceTargetRefMaxYaw
	{
		set
		{
			if (AllParams.Length > 47)
			{
				AllParams[47] = value.ToString("F2");
			}
		}
	}

	public float CameraRotation_SlowTrace_Input_StraightYawTraceSpeed
	{
		set
		{
			if (AllParams.Length > 48)
			{
				AllParams[48] = value.ToString("F2");
			}
		}
	}

	public float CameraRotation_SlowTrace_Input_StraightPitchTraceSpeed
	{
		set
		{
			if (AllParams.Length > 49)
			{
				AllParams[49] = value.ToString("F2");
			}
		}
	}

	public FStraightParams()
	{
		AllParams = new string[50];
	}
}
