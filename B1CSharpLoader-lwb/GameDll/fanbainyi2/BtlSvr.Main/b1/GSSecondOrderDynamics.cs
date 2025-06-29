using System;
using UnrealEngine.Runtime;

namespace b1;

public class GSSecondOrderDynamics
{
	private float XP;

	private float Y;

	private float YD;

	private float _W;

	private float _Z;

	private float _D;

	private float K1;

	private float K2;

	private float K3;

	public GSSecondOrderDynamics(float Frequency, float Damping, float InitResponse, float X0)
	{
		_W = (float)Math.PI * 2f * Frequency;
		_Z = Damping;
		_D = _W * FMath.Sqrt(FMath.Abs(_Z * _Z - 1f));
		K1 = _Z / ((float)Math.PI * Frequency);
		K2 = 1f / (_W * _W);
		K3 = InitResponse * _Z / _W;
		XP = X0;
		Y = X0;
		YD = 0f;
	}

	public float Update(float T, float X, float XD)
	{
		if (XD == 0f)
		{
			XD = (X - XP) / T;
			XP = X;
		}
		float num;
		if (_W * T < _Z)
		{
			_ = K1;
			num = FMath.Max(K2, T * T / 2f + T * K1 / 2f, T * K1);
		}
		else
		{
			float num2 = FMath.Exp((0f - _Z) * _W * T);
			float num3 = 2f * num2 * ((_Z <= 1f) ? FMath.Cos(T * _D) : ((float)Math.Cosh(T * _D)));
			float num4 = num2 * num2;
			float num5 = T / (1f + num4 - num3);
			num = T * num5;
		}
		Y += T * YD;
		YD += T * (X + K3 * XD - Y - K1 * YD) / num;
		return Y;
	}

	public float Update(float T, float Y, float X, float XD)
	{
		if (XD == 0f)
		{
			XD = (X - XP) / T;
			XP = X;
		}
		float num;
		if (_W * T < _Z)
		{
			_ = K1;
			num = FMath.Max(K2, T * T / 2f + T * K1 / 2f, T * K1);
		}
		else
		{
			float num2 = FMath.Exp((0f - _Z) * _W * T);
			float num3 = 2f * num2 * ((_Z <= 1f) ? FMath.Cos(T * _D) : ((float)Math.Cosh(T * _D)));
			float num4 = num2 * num2;
			float num5 = T / (1f + num4 - num3);
			num = T * num5;
		}
		Y += T * YD;
		YD += T * (X + K3 * XD - Y - K1 * YD) / num;
		return Y;
	}
}
