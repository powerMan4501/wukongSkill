namespace System.Security.Cryptography;

public struct ECParameters
{
	public ECPoint Q;

	public byte[] D;

	public ECCurve Curve;

	public void Validate()
	{
		bool flag = false;
		if (Q.X == null || Q.Y == null || Q.X.Length != Q.Y.Length)
		{
			flag = true;
		}
		if (!flag)
		{
			if (Curve.IsExplicit)
			{
				flag = D != null && D.Length != Curve.Order.Length;
			}
			else if (Curve.IsNamed)
			{
				flag = D != null && D.Length != Q.X.Length;
			}
		}
		if (flag)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_InvalidCurveKeyParameters"));
		}
		Curve.Validate();
	}
}
