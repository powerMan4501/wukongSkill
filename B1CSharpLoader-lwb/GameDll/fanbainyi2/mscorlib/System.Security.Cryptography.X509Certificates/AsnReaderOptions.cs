namespace System.Security.Cryptography.X509Certificates;

internal struct AsnReaderOptions
{
	private const int DefaultTwoDigitMax = 2049;

	private ushort _twoDigitYearMax;

	private bool _skipSetSortOrderVerification;

	public int UtcTimeTwoDigitYearMax
	{
		get
		{
			if (_twoDigitYearMax == 0)
			{
				return 2049;
			}
			return _twoDigitYearMax;
		}
		set
		{
			if (value < 1 || value > 9999)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			_twoDigitYearMax = (ushort)value;
		}
	}

	public bool SkipSetSortOrderVerification
	{
		get
		{
			return _skipSetSortOrderVerification;
		}
		set
		{
			_skipSetSortOrderVerification = value;
		}
	}
}
