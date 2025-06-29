using UnrealEngine.Runtime;

namespace b1;

public static class PerlinNoise
{
	private static int[] perm = new int[257]
	{
		151, 160, 137, 91, 90, 15, 131, 13, 201, 95,
		96, 53, 194, 233, 7, 225, 140, 36, 103, 30,
		69, 142, 8, 99, 37, 240, 21, 10, 23, 190,
		6, 148, 247, 120, 234, 75, 0, 26, 197, 62,
		94, 252, 219, 203, 117, 35, 11, 32, 57, 177,
		33, 88, 237, 149, 56, 87, 174, 20, 125, 136,
		171, 168, 68, 175, 74, 165, 71, 134, 139, 48,
		27, 166, 77, 146, 158, 231, 83, 111, 229, 122,
		60, 211, 133, 230, 220, 105, 92, 41, 55, 46,
		245, 40, 244, 102, 143, 54, 65, 25, 63, 161,
		1, 216, 80, 73, 209, 76, 132, 187, 208, 89,
		18, 169, 200, 196, 135, 130, 116, 188, 159, 86,
		164, 100, 109, 198, 173, 186, 3, 64, 52, 217,
		226, 250, 124, 123, 5, 202, 38, 147, 118, 126,
		255, 82, 85, 212, 207, 206, 59, 227, 47, 16,
		58, 17, 182, 189, 28, 42, 223, 183, 170, 213,
		119, 248, 152, 2, 44, 154, 163, 70, 221, 153,
		101, 155, 167, 43, 172, 9, 129, 22, 39, 253,
		19, 98, 108, 110, 79, 113, 224, 232, 178, 185,
		112, 104, 218, 246, 97, 228, 251, 34, 242, 193,
		238, 210, 144, 12, 191, 179, 162, 241, 81, 51,
		145, 235, 249, 14, 239, 107, 49, 192, 214, 31,
		181, 199, 106, 157, 184, 84, 204, 176, 115, 121,
		50, 45, 127, 4, 150, 254, 138, 236, 205, 93,
		222, 114, 67, 29, 24, 72, 243, 141, 128, 195,
		78, 66, 215, 61, 156, 180, 151
	};

	public static float Noise(float x)
	{
		int num = FMath.FloorToInt(x) & 0xFF;
		x -= (float)FMath.FloorToInt(x);
		return Lerp(Fade(x), Grad(perm[num], x), Grad(perm[num + 1], x - 1f)) * 2f;
	}

	public static float Noise(float x, float y)
	{
		int num = FMath.FloorToInt(x) & 0xFF;
		int num2 = FMath.FloorToInt(y) & 0xFF;
		x -= (float)FMath.FloorToInt(x);
		y -= (float)FMath.FloorToInt(y);
		float t = Fade(x);
		float t2 = Fade(y);
		int num3 = (perm[num] + num2) & 0xFF;
		int num4 = (perm[num + 1] + num2) & 0xFF;
		return Lerp(t2, Lerp(t, Grad(perm[num3], x, y), Grad(perm[num4], x - 1f, y)), Lerp(t, Grad(perm[num3 + 1], x, y - 1f), Grad(perm[num4 + 1], x - 1f, y - 1f)));
	}

	public static float Noise(FVector2D coord)
	{
		return Noise(coord.X, coord.Y);
	}

	public static float Noise(float x, float y, float z)
	{
		int num = FMath.FloorToInt(x) & 0xFF;
		int num2 = FMath.FloorToInt(y) & 0xFF;
		int num3 = FMath.FloorToInt(z) & 0xFF;
		x -= (float)FMath.FloorToInt(x);
		y -= (float)FMath.FloorToInt(y);
		z -= (float)FMath.FloorToInt(z);
		float t = Fade(x);
		float t2 = Fade(y);
		float t3 = Fade(z);
		int num4 = (perm[num] + num2) & 0xFF;
		int num5 = (perm[num + 1] + num2) & 0xFF;
		int num6 = (perm[num4] + num3) & 0xFF;
		int num7 = (perm[num5] + num3) & 0xFF;
		int num8 = (perm[num4 + 1] + num3) & 0xFF;
		int num9 = (perm[num5 + 1] + num3) & 0xFF;
		return Lerp(t3, Lerp(t2, Lerp(t, Grad(perm[num6], x, y, z), Grad(perm[num7], x - 1f, y, z)), Lerp(t, Grad(perm[num8], x, y - 1f, z), Grad(perm[num9], x - 1f, y - 1f, z))), Lerp(t2, Lerp(t, Grad(perm[num6 + 1], x, y, z - 1f), Grad(perm[num7 + 1], x - 1f, y, z - 1f)), Lerp(t, Grad(perm[num8 + 1], x, y - 1f, z - 1f), Grad(perm[num9 + 1], x - 1f, y - 1f, z - 1f))));
	}

	public static float Noise(FVector coord)
	{
		return Noise(coord.X, coord.Y, coord.Z);
	}

	public static float Fbm(float x, int octave)
	{
		float num = 0f;
		float num2 = 0.5f;
		for (int i = 0; i < octave; i++)
		{
			num += num2 * Noise(x);
			x *= 2f;
			num2 *= 0.5f;
		}
		return num;
	}

	public static float Fbm(FVector2D coord, int octave)
	{
		float num = 0f;
		float num2 = 0.5f;
		for (int i = 0; i < octave; i++)
		{
			num += num2 * Noise(coord);
			coord *= 2.0;
			num2 *= 0.5f;
		}
		return num;
	}

	public static float Fbm(float x, float y, int octave)
	{
		return Fbm(new FVector2D(x, y), octave);
	}

	public static float Fbm(FVector coord, int octave)
	{
		float num = 0f;
		float num2 = 0.5f;
		for (int i = 0; i < octave; i++)
		{
			num += num2 * Noise(coord);
			coord *= 2.0;
			num2 *= 0.5f;
		}
		return num;
	}

	public static float Fbm(float x, float y, float z, int octave)
	{
		return Fbm(new FVector(x, y, z), octave);
	}

	private static float Fade(float t)
	{
		return t * t * t * (t * (t * 6f - 15f) + 10f);
	}

	private static float Lerp(float t, float a, float b)
	{
		return a + t * (b - a);
	}

	private static float Grad(int hash, float x)
	{
		if ((hash & 1) != 0)
		{
			return 0f - x;
		}
		return x;
	}

	private static float Grad(int hash, float x, float y)
	{
		return (((hash & 1) == 0) ? x : (0f - x)) + (((hash & 2) == 0) ? y : (0f - y));
	}

	private static float Grad(int hash, float x, float y, float z)
	{
		int num = hash & 0xF;
		float num2 = ((num < 8) ? x : y);
		float num3 = ((num < 4) ? y : ((num == 12 || num == 14) ? x : z));
		return (((num & 1) == 0) ? num2 : (0f - num2)) + (((num & 2) == 0) ? num3 : (0f - num3));
	}
}
