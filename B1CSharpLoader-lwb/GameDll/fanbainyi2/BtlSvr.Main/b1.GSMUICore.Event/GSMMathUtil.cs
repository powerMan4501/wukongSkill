using System;
using UnrealEngine.Runtime;

namespace b1.GSMUICore.Event;

public class GSMMathUtil
{
	private static readonly string GSTRACENAME = "GSMMathUtil";

	private static Random GSRan;

	public static void Init()
	{
		long ticks = DateTime.Now.Ticks;
		GSRan = new Random((int)(ticks & 0xFFFFFFFFu) | (int)(ticks >> 32));
	}

	public static int RandInt(int Min, int Max)
	{
		return GSRan.Next(Min, Max);
	}

	public static int RandMinOrAdd()
	{
		if (RandInt(0, 2) > 0)
		{
			return 1;
		}
		return -1;
	}

	public static FVector2D RandDirByRefMinus(FVector2D RefDir, float MinDegree, float MaxDegree)
	{
		float num = 0f - (MinDegree + RandFloat() * (MaxDegree - MinDegree));
		return RefDir.GetRotated(num);
	}

	public static FVector2D RandDirByRef(FVector2D RefDir, float MaxDegree)
	{
		float num = (float)RandMinOrAdd() * RandFloat() * MaxDegree;
		return RefDir.GetRotated(num);
	}

	public static float RandFloat()
	{
		return (float)GSRan.Next(0, 1000000000) / 1E+09f;
	}
}
