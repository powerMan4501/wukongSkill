using UnrealEngine.Engine;

namespace b1.BGU.BUAnim;

public static class BUAnimUtil
{
	public static void GetDirAnimBlendVals(float MoveDir, UAnimSequence SeqFwd, UAnimSequence SeqBwd, UAnimSequence SeqLeft, UAnimSequence SeqRight, out UAnimSequence SeqA, out UAnimSequence SeqB, out float BlendVal)
	{
		if (MoveDir >= -180f && MoveDir <= -90f)
		{
			SeqA = SeqBwd;
			SeqB = SeqLeft;
			BlendVal = (MoveDir + 180f) / 90f;
		}
		else if (MoveDir >= -90f && MoveDir <= 0f)
		{
			SeqA = SeqLeft;
			SeqB = SeqFwd;
			BlendVal = (MoveDir + 90f) / 90f;
		}
		else if (MoveDir >= 0f && MoveDir <= 90f)
		{
			SeqA = SeqFwd;
			SeqB = SeqRight;
			BlendVal = MoveDir / 90f;
		}
		else
		{
			SeqA = SeqRight;
			SeqB = SeqBwd;
			BlendVal = (MoveDir - 90f) / 90f;
		}
	}

	public static ECardinalDir GetCardinalDirFromDirection(float Dir)
	{
		if (Dir >= -30f && Dir <= 30f)
		{
			return ECardinalDir.Default;
		}
		if (Dir >= 30f && Dir <= 135f)
		{
			return ECardinalDir.E;
		}
		if (Dir >= -135f && Dir <= -30f)
		{
			return ECardinalDir.W;
		}
		return ECardinalDir.S;
	}

	public static void GetOrientWarpAngle(float MoveDir, out float OrientWarpAngle, out ECardinalDir DirEnum)
	{
		DirEnum = GetCardinalDirFromDirection(MoveDir);
		OrientWarpAngle = MoveDir + 90f;
	}

	public static float CalcOrientWarpAngle(float JogDir, ECardinalDir AnimDir)
	{
		float num = JogDir;
		return UMathLibrary.NormalizeAxis(AnimDir switch
		{
			ECardinalDir.E => JogDir - 90f, 
			ECardinalDir.S => JogDir - 180f, 
			ECardinalDir.W => JogDir + 90f, 
			_ => JogDir, 
		});
	}
}
