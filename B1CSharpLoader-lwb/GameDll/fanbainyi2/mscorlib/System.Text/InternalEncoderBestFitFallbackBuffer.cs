using System.Security;
using System.Threading;

namespace System.Text;

internal sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer
{
	private char cBestFit;

	private InternalEncoderBestFitFallback oFallback;

	private int iCount = -1;

	private int iSize;

	private static object s_InternalSyncObject;

	private static object InternalSyncObject
	{
		get
		{
			if (s_InternalSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange<object>(ref s_InternalSyncObject, value, (object)null);
			}
			return s_InternalSyncObject;
		}
	}

	public override int Remaining
	{
		get
		{
			if (iCount <= 0)
			{
				return 0;
			}
			return iCount;
		}
	}

	public InternalEncoderBestFitFallbackBuffer(InternalEncoderBestFitFallback fallback)
	{
		oFallback = fallback;
		if (oFallback.arrayBestFit != null)
		{
			return;
		}
		lock (InternalSyncObject)
		{
			if (oFallback.arrayBestFit == null)
			{
				oFallback.arrayBestFit = fallback.encoding.GetBestFitUnicodeToBytesData();
			}
		}
	}

	public override bool Fallback(char charUnknown, int index)
	{
		iCount = (iSize = 1);
		cBestFit = TryBestFit(charUnknown);
		if (cBestFit == '\0')
		{
			cBestFit = '?';
		}
		return true;
	}

	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
	{
		if (!char.IsHighSurrogate(charUnknownHigh))
		{
			throw new ArgumentOutOfRangeException("charUnknownHigh", Environment.GetResourceString("ArgumentOutOfRange_Range", 55296, 56319));
		}
		if (!char.IsLowSurrogate(charUnknownLow))
		{
			throw new ArgumentOutOfRangeException("CharUnknownLow", Environment.GetResourceString("ArgumentOutOfRange_Range", 56320, 57343));
		}
		cBestFit = '?';
		iCount = (iSize = 2);
		return true;
	}

	public override char GetNextChar()
	{
		iCount--;
		if (iCount < 0)
		{
			return '\0';
		}
		if (iCount == int.MaxValue)
		{
			iCount = -1;
			return '\0';
		}
		return cBestFit;
	}

	public override bool MovePrevious()
	{
		if (iCount >= 0)
		{
			iCount++;
		}
		if (iCount >= 0)
		{
			return iCount <= iSize;
		}
		return false;
	}

	[SecuritySafeCritical]
	public unsafe override void Reset()
	{
		iCount = -1;
		charStart = null;
		bFallingBack = false;
	}

	private char TryBestFit(char cUnknown)
	{
		int num = 0;
		int num2 = oFallback.arrayBestFit.Length;
		int num3;
		while ((num3 = num2 - num) > 6)
		{
			int num4 = (num3 / 2 + num) & 0xFFFE;
			char c = oFallback.arrayBestFit[num4];
			if (c == cUnknown)
			{
				return oFallback.arrayBestFit[num4 + 1];
			}
			if (c < cUnknown)
			{
				num = num4;
			}
			else
			{
				num2 = num4;
			}
		}
		for (int num4 = num; num4 < num2; num4 += 2)
		{
			if (oFallback.arrayBestFit[num4] == cUnknown)
			{
				return oFallback.arrayBestFit[num4 + 1];
			}
		}
		return '\0';
	}
}
