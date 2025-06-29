using System.Collections.Generic;
using GSE.OnlineBase;

namespace GSE.GSSdk;

public class GSSDKPerf
{
	private static MetricStastic MetricStat = new MetricStastic();

	private static float TickElapseTime = 1f;

	private static int TickSecondsLowHz = 1;

	public static bool DisablePerf = false;

	public static void TickCheckUpdate(bool bForceSync, float DeltaTime)
	{
		if (DisablePerf)
		{
			return;
		}
		TickElapseTime -= DeltaTime;
		if (TickElapseTime < 0f || bForceSync)
		{
			TickElapseTime = TickSecondsLowHz;
			IList<Metric> list = MetricStat.TickCollectSeconds(bForceSync, TickSecondsLowHz);
			for (int i = 0; i < list.Count; i++)
			{
				Metric metric = list[i];
				GSSDKReport.TrackMetricEvent(metric.Key, metric.Sum, metric.Count, metric.Min, metric.Max, metric.Param);
			}
		}
	}

	public static void Sample(string Key, double Val, int SampleIntervalSecond, double[] buckets = null, string Fmt = null, params object[] Args)
	{
		if (!DisablePerf)
		{
			long val = (long)(Val * 1000.0);
			GSSDKReport.MonitorSample(MonEvtCatogray.None, Key, val, SampleIntervalSecond >= 0, buckets, null);
			if (Fmt != null)
			{
				string param = string.Format(Fmt, Args);
				MetricStat.Sample(Key, val, param, SampleIntervalSecond);
			}
			else
			{
				MetricStat.Sample(Key, val, null, SampleIntervalSecond);
			}
		}
	}
}
