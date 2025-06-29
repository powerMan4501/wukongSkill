using UnrealEngine.Runtime;

namespace b1;

public class FPlayGoDownloadDetails
{
	private class FLeftTimeProvider
	{
		private const double UpdateDuration = 5.0;

		private float _lastDownloadSize;

		private double _lastUpdateDownloadTime;

		private float _lastReturnLeftTime;

		public float GetLeftTime(FPlayGoDownloadDetails Details, double CurrentTime)
		{
			if (FMath.IsNearlyEqual(_lastUpdateDownloadTime, 0.0) || FMath.IsNearlyEqual(_lastDownloadSize, 0f))
			{
				UpdateData();
				_lastReturnLeftTime = float.MaxValue;
				return float.MaxValue;
			}
			double num = CurrentTime - _lastUpdateDownloadTime;
			if (num > 5.0 || FMath.IsNearlyEqual(float.MaxValue, _lastReturnLeftTime))
			{
				float num2 = Details.DownloadedSize - _lastDownloadSize;
				UpdateData();
				if (FMath.IsNearlyZero(num2))
				{
					_lastReturnLeftTime = float.MaxValue;
					return _lastReturnLeftTime;
				}
				float num3 = Details.TotalSize - Details.DownloadedSize;
				return _lastReturnLeftTime = (float)num * (num3 / num2);
			}
			return _lastReturnLeftTime;
			void UpdateData()
			{
				_lastUpdateDownloadTime = CurrentTime;
				_lastDownloadSize = Details.DownloadedSize;
			}
		}
	}

	public float DownloadedSize;

	public float TotalSize;

	public float DownloadedPercentage;

	public float LeftTime;

	private readonly FLeftTimeProvider _leftTimeProvider = new FLeftTimeProvider();

	public void Update(long InProgressSize, long InTotalSize, double CurrentTime)
	{
		DownloadedSize = ConvertBytesToGigaBytes(InProgressSize);
		TotalSize = ConvertBytesToGigaBytes(InTotalSize);
		DownloadedPercentage = ((InTotalSize > 0) ? ((float)InProgressSize / (float)InTotalSize) : 0f);
		LeftTime = _leftTimeProvider.GetLeftTime(this, CurrentTime);
	}

	private static float ConvertBytesToGigaBytes(long InBytes)
	{
		return (float)InBytes / FMath.Pow(2f, 30f);
	}
}
