using System;
using System.Collections.Generic;
using System.Linq;
using Google.Protobuf.Collections;

namespace b1;

public static class RandomUtil
{
	private static Random sRandomObj = new Random();

	public static int RangeRand(int Left, int Right)
	{
		if (Right < Left)
		{
			throw new Exception($"RightValue:{Right} is less then LeftValue:{Left}");
		}
		return sRandomObj.Next(Left, Right + 1);
	}

	public static bool RandomSuccess(int RandomRate, int Weight = 10000)
	{
		int num = RangeRand(1, Weight);
		if (num >= 1 && num <= RandomRate)
		{
			return true;
		}
		return false;
	}

	public static T RangeOneByWeight<T>(List<T> RandomPools, Func<T, int> funcGetWeight)
	{
		int num = 0;
		foreach (T RandomPool in RandomPools)
		{
			num += funcGetWeight(RandomPool);
		}
		if (num <= 0)
		{
			return default(T);
		}
		int num2 = RangeRand(1, num);
		int num3 = 1;
		foreach (T RandomPool2 in RandomPools)
		{
			int num4 = num3 + funcGetWeight(RandomPool2);
			if (num2 >= num3 && num2 < num4)
			{
				return RandomPool2;
			}
			num3 = num4;
		}
		return default(T);
	}

	public static T RangeOneByWeight<T>(RepeatedField<T> RandomPools, Func<T, int> funcGetWeight)
	{
		return RangeOneByWeight(RandomPools.ToList(), funcGetWeight);
	}
}
