using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Google.Protobuf;
using GSE.OnlineBase;
using Gssdk;

namespace GSE.GSSdk;

public class GSSDKReport
{
	private static ReportMonitorReq MonitorRequest = new ReportMonitorReq();

	private static ReportEventReq EventRequest = new ReportEventReq
	{
		UserKey = new ReportUserKey()
	};

	private static ReportUploadFilesReq UploadFilesReq = new ReportUploadFilesReq
	{
		UserKey = new ReportUserKey()
	};

	private static ReportTrackReq EventTrackingRequest = new ReportTrackReq();

	private static bool bTrackUserFlag = false;

	private static DateTime LastTickCheckFlushTime = DateTime.Now;

	private static List<BucketCfg> keyBuckets = new List<BucketCfg>();

	private static ConcurrentQueue<ReportEventItemRaw> LocalRportEventQueueRaw = new ConcurrentQueue<ReportEventItemRaw>();

	private static bool DisableAnyReportFlag = false;

	public static int ForceFlushCheckIntervalSeconds = 60;

	public static bool DisableMonitorReport = false;

	public static int EventBatchMergeLimit { get; private set; } = 300;

	public static List<string> MonitorEnvKeyValues
	{
		get
		{
			List<string> list = new List<string>();
			for (int i = 0; i < MonitorRequest.EnvKvs.Count; i++)
			{
				list.Add(MonitorRequest.EnvKvs[i].Key + "=" + MonitorRequest.EnvKvs[i].Val);
			}
			return list;
		}
	}

	public static void DisableNetReport(bool DisableFlag = false)
	{
		GSSDKReportQueue.DisableHttpReport = DisableFlag;
	}

	public static bool DisableAnyReport(bool DisableFlag = false)
	{
		if (DisableFlag != DisableAnyReportFlag)
		{
			DisableAnyReportFlag = DisableFlag;
			return true;
		}
		return false;
	}

	public static void InitReport(HttpPostAsyncProxy PostProxy = null, int MergeBatchNum = 300, int MergeBatchIntervalSeconds = 60)
	{
		GSSDKReportQueue.InitQueueWorker("xl", EnableLocalStore: true, LocalRportEventQueueRaw, PostProxy);
		SetTrackEventBatchMergeLimit(MergeBatchNum);
		ForceFlushCheckIntervalSeconds = MergeBatchIntervalSeconds;
	}

	private static int GetReportMsgQueueTotalNum()
	{
		return MonitorRequest.AddList.Count + MonitorRequest.SetList.Count + EventRequest.EventList.Count + EventTrackingRequest.Tracks.Count + UploadFilesReq.UploadFiles.Count;
	}

	public static void SetTrackEventBatchMergeLimit(int i)
	{
		EventBatchMergeLimit = i;
		LogHelper.LogWarn("report set EventBatchMergeLimit to {0}", EventBatchMergeLimit);
	}

	public static void TickCheckUpdate(bool bSyncFlush = false)
	{
		DateTime now = DateTime.Now;
		int reportMsgQueueTotalNum = GetReportMsgQueueTotalNum();
		if (!bSyncFlush && EventBatchMergeLimit > 0 && reportMsgQueueTotalNum > EventBatchMergeLimit)
		{
			bSyncFlush = true;
		}
		if (now < LastTickCheckFlushTime.AddSeconds(ForceFlushCheckIntervalSeconds) && !bSyncFlush)
		{
			return;
		}
		MonitorAdd(MonEvtCatogray.OSS, "LoadBytes", GSSDKReportQueue.FetchDeletaLoadBytes(), null);
		MonitorAdd(MonEvtCatogray.OSS, "SaveBytes", GSSDKReportQueue.FetchDeltaSaveBytes(), null);
		MonitorAdd(MonEvtCatogray.OSS, "HttpSendBytes", GSSDKReportQueue.FetchDeltaHttpBytes(), null);
		MonitorAdd(MonEvtCatogray.OSS, "HttpSendReqs", GSSDKReportQueue.FetchDeltaHttpReqs(), null);
		MonitorAdd(MonEvtCatogray.OSS, "HttpSendFailReqs", GSSDKReportQueue.FetchDeltaHttpFailReqs(), null);
		LastTickCheckFlushTime = now;
		if (DisableAnyReportFlag)
		{
			MonitorRequest.AddList.Clear();
			EventRequest.EventList.Clear();
			UploadFilesReq.UploadFiles.Clear();
			EventTrackingRequest.Tracks.Clear();
			return;
		}
		if (bTrackUserFlag)
		{
			bTrackUserFlag = false;
			LocalRportEventQueueRaw.Enqueue(new ReportEventItemRaw
			{
				api = "User",
				UserReq = new ReportUserReq
				{
					UserKey = GSSDKEnv.UserKey,
					Info = GSSDKEnv.UserInfo
				}
			});
		}
		if (MonitorRequest.AddList.Count + MonitorRequest.SetList.Count > 0)
		{
			LocalRportEventQueueRaw.Enqueue(new ReportEventItemRaw
			{
				api = "Monitor",
				MonitorReq = new ReportMonitorReq(MonitorRequest)
			});
			MonitorRequest.AddList.Clear();
			MonitorRequest.SetList.Clear();
		}
		if (EventRequest.EventList.Count > 0)
		{
			EventRequest.UserKey = GSSDKEnv.UserKey;
			LocalRportEventQueueRaw.Enqueue(new ReportEventItemRaw
			{
				api = "Event",
				EventReq = new ReportEventReq(EventRequest)
			});
			EventRequest.EventList.Clear();
		}
		if (EventTrackingRequest.Tracks.Count > 0)
		{
			LocalRportEventQueueRaw.Enqueue(new ReportEventItemRaw
			{
				api = "Track",
				TrackReq = new ReportTrackReq(EventTrackingRequest)
			});
			EventTrackingRequest.Tracks.Clear();
		}
		if (UploadFilesReq.UploadFiles.Count > 0)
		{
			UploadFilesReq.UserKey = GSSDKEnv.UserKey;
			LocalRportEventQueueRaw.Enqueue(new ReportEventItemRaw
			{
				api = "UploadFiles",
				UpdateFilesReq = new ReportUploadFilesReq(UploadFilesReq)
			});
			UploadFilesReq.UploadFiles.Clear();
		}
	}

	private static string CalcBucket(long val, double[] buckets)
	{
		for (int i = 0; i < buckets.Length; i++)
		{
			if (val <= (long)(buckets[i] * 1000.0))
			{
				return $"{buckets[i]}";
			}
		}
		return "+Inf";
	}

	private static string GetBucketByKeyAndValue(string key, long val, double[] buckets)
	{
		for (int i = 0; i < keyBuckets.Count; i++)
		{
			if (keyBuckets[i].key == key)
			{
				return CalcBucket(val, keyBuckets[i].buckets);
			}
		}
		BucketCfg item = new BucketCfg
		{
			key = key,
			buckets = buckets
		};
		keyBuckets.Add(item);
		for (int j = 0; j < keyBuckets.Count; j++)
		{
			if (keyBuckets[j].key == key)
			{
				return CalcBucket(val, keyBuckets[j].buckets);
			}
		}
		return "+Inf";
	}

	public static void TrackUser()
	{
		bTrackUserFlag = true;
	}

	private static ReportUserEvent CreateUserEvent()
	{
		return new ReportUserEvent
		{
			Time = LocalTime.GetUnixTimeStamp()
		};
	}

	public static void TrackEvent(string EventName, long EventRet = 0L, string KVPairs = null)
	{
		ReportUserEvent reportUserEvent = CreateUserEvent();
		reportUserEvent.EvtType = ReportEvtType.CustomName;
		reportUserEvent.EvtName = EventName;
		reportUserEvent.EvtResult = EventRet;
		if (KVPairs != null)
		{
			if (KVPairs.Contains("="))
			{
				string[] array = KVPairs.Split(',');
				for (int i = 0; i < array.Length; i++)
				{
					string[] array2 = array[i].Split('=');
					if (array2 != null && array2.Length == 2)
					{
						reportUserEvent.EvtProps.Add(new ReportMonitorKeyVal
						{
							Key = array2[0],
							Val = array2[1]
						});
					}
				}
			}
			else
			{
				reportUserEvent.EvtStrParam = KVPairs;
			}
		}
		EventRequest.EventList.Add(reportUserEvent);
	}

	public static void TrackEvent(ReportEvtType EvtType, long EventRet = 0L, string KVPairs = null)
	{
		TrackEvent(EvtType.ToString(), EventRet, KVPairs);
	}

	public static void TrackMetricEvent(string EventName, long Sum, long Count, long Min, long Max, string KVPairs = null)
	{
		ReportUserEvent reportUserEvent = CreateUserEvent();
		reportUserEvent.EvtType = ReportEvtType.CustomName;
		reportUserEvent.EvtName = EventName;
		reportUserEvent.EvtResult = 0L;
		reportUserEvent.EvtMetricSum = Sum;
		reportUserEvent.EvtMetricMin = Min;
		reportUserEvent.EvtMetricMax = Max;
		reportUserEvent.EvtMetricNum = Count;
		if (KVPairs != null)
		{
			if (KVPairs.Contains("="))
			{
				string[] array = KVPairs.Split(',');
				for (int i = 0; i < array.Length; i++)
				{
					string[] array2 = array[i].Split('=');
					if (array2 != null && array2.Length == 2)
					{
						reportUserEvent.EvtProps.Add(new ReportMonitorKeyVal
						{
							Key = array2[0],
							Val = array2[1]
						});
					}
				}
			}
			else
			{
				reportUserEvent.EvtStrParam = KVPairs;
			}
		}
		EventRequest.EventList.Add(reportUserEvent);
	}

	public static void MonitorClearEnv()
	{
		MonitorRequest.EnvKvs.Clear();
	}

	public static void MonitorEnvAdd(string key, string val)
	{
		for (int i = 0; i < MonitorRequest.EnvKvs.Count; i++)
		{
			if (MonitorRequest.EnvKvs[i].Key == key)
			{
				MonitorRequest.EnvKvs[i].Val = val;
				return;
			}
		}
		MonitorRequest.EnvKvs.Add(new ReportMonitorKeyVal
		{
			Key = key,
			Val = val
		});
	}

	public static void MonitorAdd(MonEvtCatogray cat, string event_key, long add_val = 1L, string event_args_fmt = null, params object[] event_args_fmt_args)
	{
		if (DisableMonitorReport || add_val == 0L)
		{
			return;
		}
		if (cat != MonEvtCatogray.None)
		{
			event_key = cat.ToString() + "_" + event_key;
		}
		string text = null;
		if (event_args_fmt != null)
		{
			text = string.Format(event_args_fmt, event_args_fmt_args);
		}
		for (int i = 0; i < MonitorRequest.AddList.Count; i++)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int j = 0; j < MonitorRequest.AddList[i].EnvKvs.Count; j++)
			{
				if (j > 0)
				{
					stringBuilder.Append(",");
				}
				stringBuilder.Append(MonitorRequest.AddList[i].EnvKvs[j].Key + "=" + MonitorRequest.AddList[i].EnvKvs[j].Val);
			}
			if (MonitorRequest.AddList[i].AddEvtKey == event_key && ((text != null && stringBuilder.Length > 0 && stringBuilder.ToString() == text) || (text == null && stringBuilder.Length == 0)))
			{
				MonitorRequest.AddList[i].AddEvtVal += add_val;
				return;
			}
		}
		ReportMonitorAdd reportMonitorAdd = new ReportMonitorAdd
		{
			AddEvtVal = add_val,
			AddEvtKey = event_key,
			Time = LocalTime.GetUnixTimeStamp()
		};
		if (text != null)
		{
			string[] array = text.Split(',');
			for (int k = 0; k < array.Length; k++)
			{
				string[] array2 = array[k].Split('=');
				if (array2.Length == 2)
				{
					reportMonitorAdd.EnvKvs.Add(new ReportMonitorKeyVal
					{
						Key = array2[0],
						Val = array2[1]
					});
				}
			}
		}
		MonitorRequest.AddList.Add(reportMonitorAdd);
	}

	private static void MonitorSampleByBucket(string key, long val, double[] buckets = null, string fmt = null, params object[] args)
	{
		if (buckets.Length != 0)
		{
			string bucketByKeyAndValue = GetBucketByKeyAndValue(key, val, buckets);
			string event_key = key + "_bucket";
			fmt = ((fmt == null) ? ("le=" + bucketByKeyAndValue) : (fmt + ",le=" + bucketByKeyAndValue));
			MonitorAdd(MonEvtCatogray.None, event_key, 1L, fmt, args);
		}
	}

	public static void MonitorSample(MonEvtCatogray cat, string key, long val, bool bAggregate = true, double[] buckets = null, string fmt = null, params object[] args)
	{
		if (DisableMonitorReport)
		{
			return;
		}
		string text = null;
		if (fmt != null)
		{
			text = string.Format(fmt, args);
		}
		if (cat != MonEvtCatogray.None)
		{
			key = cat.ToString() + "_" + key;
		}
		for (int i = 0; i < MonitorRequest.SetList.Count; i++)
		{
			if (buckets != null && buckets.Length != 0)
			{
				MonitorSampleByBucket(key, val, buckets, fmt, args);
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int j = 0; j < MonitorRequest.SetList[i].EnvKvs.Count; j++)
			{
				if (j > 0)
				{
					stringBuilder.Append(",");
				}
				stringBuilder.Append(MonitorRequest.SetList[i].EnvKvs[j].Key + "=" + MonitorRequest.SetList[i].EnvKvs[j].Val);
			}
			if (MonitorRequest.SetList[i].SetEvtKey == key && ((text != null && stringBuilder.Length > 0 && stringBuilder.ToString() == text) || (text == null && stringBuilder.Length == 0)))
			{
				MonitorRequest.SetList[i].SetEvtVal = val;
				MonitorRequest.SetList[i].SetEvtValSum += val;
				if (MonitorRequest.SetList[i].SetEvtValNum > 0)
				{
					MonitorRequest.SetList[i].SetEvtValNum++;
				}
				else
				{
					MonitorRequest.SetList[i].SetEvtValNum--;
				}
				if (val > MonitorRequest.SetList[i].SetEvtValMax)
				{
					MonitorRequest.SetList[i].SetEvtValMax = val;
				}
				if (val < MonitorRequest.SetList[i].SetEvtValMin)
				{
					MonitorRequest.SetList[i].SetEvtValMin = val;
				}
				return;
			}
		}
		ReportMonitorSet reportMonitorSet = new ReportMonitorSet
		{
			SetEvtKey = key,
			SetEvtVal = val,
			SetEvtValSum = val,
			SetEvtValMax = val,
			SetEvtValMin = val,
			SetEvtValNum = 1L,
			Time = LocalTime.GetUnixTimeStamp()
		};
		if (!bAggregate)
		{
			reportMonitorSet.SetEvtValNum = -1L;
		}
		if (text != null)
		{
			string[] array = text.Split(',');
			for (int k = 0; k < array.Length; k++)
			{
				string[] array2 = array[k].Split('=');
				if (array2.Length == 2)
				{
					reportMonitorSet.EnvKvs.Add(new ReportMonitorKeyVal
					{
						Key = array2[0],
						Val = array2[1]
					});
				}
			}
		}
		MonitorRequest.SetList.Add(reportMonitorSet);
	}

	public static void ReportEvent(string EventName, long EventRet = 0L, string Format = null, params string[] Args)
	{
		ReportUserEvent reportUserEvent = CreateUserEvent();
		reportUserEvent.EvtName = EventName;
		reportUserEvent.EvtResult = EventRet;
		if (Format != null)
		{
			if (Format.Contains("="))
			{
				object[] args = Args;
				string[] array = string.Format(Format, args).Split(',');
				for (int i = 0; i < array.Length; i++)
				{
					string[] array2 = array[i].Split('=');
					if (array2 != null && array2.Length == 2)
					{
						reportUserEvent.EvtProps.Add(new ReportMonitorKeyVal
						{
							Key = array2[0],
							Val = array2[1]
						});
					}
				}
			}
			else
			{
				object[] args = Args;
				reportUserEvent.EvtStrParam = string.Format(Format, args);
			}
		}
		ReportEventReq reportEventReq = new ReportEventReq
		{
			UserKey = new ReportUserKey()
		};
		reportEventReq.UserKey.Aid = GSSDKEnv.UserInfo.AuthInfo.Aid;
		reportEventReq.UserKey.DeviceId = GSSDKEnv.UserInfo.DeviceInfo.DeviceId;
		reportEventReq.UserKey.Roleid = GSSDKEnv.UserInfo.AuthInfo.Roleid;
		reportEventReq.EventList.Add(reportUserEvent);
		LocalRportEventQueueRaw.Enqueue(new ReportEventItemRaw
		{
			api = "Event",
			EventReq = new ReportEventReq(reportEventReq)
		});
	}

	public static void TrackDataEvent(string EventName, ReportTrackMisc[] miscs = null, string Format = null, params string[] Args)
	{
		ReportTrack reportTrack = new ReportTrack();
		if (miscs != null && miscs.Length != 0)
		{
			reportTrack.RoleEx.AddRange(miscs);
		}
		reportTrack.EvtName = EventName;
		reportTrack.Time = LocalTime.GetUnixTimeStamp();
		if (Format != null)
		{
			reportTrack.EvtContent = string.Format(Format, Args);
		}
		else
		{
			reportTrack.EvtContent = Args[0];
		}
		EventTrackingRequest.Tracks.Add(reportTrack);
	}

	public static void UploadSmallBlobFiles(string[] FilePathList)
	{
		for (int i = 0; i < FilePathList.Length; i++)
		{
			if (File.Exists(FilePathList[i]))
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(FilePathList[i]);
				try
				{
					FileStream stream = new FileStream(FilePathList[i], FileMode.Open, FileAccess.Read);
					UploadFilesReq.UploadFiles.Add(new ReportUploadFileOne
					{
						KeyName = fileNameWithoutExtension,
						ValContent = ByteString.FromStream(stream)
					});
				}
				catch (Exception ex)
				{
					LogHelper.LogError("upload file:" + FilePathList[i] + " error:" + ex.Message);
				}
			}
		}
	}

	public static void TrackDataEvent(string EventName, string Format, params string[] Args)
	{
		ReportTrack reportTrack = new ReportTrack();
		reportTrack.EvtName = EventName;
		reportTrack.Time = LocalTime.GetUnixTimeStamp();
		if (Args.Length != 0)
		{
			reportTrack.EvtContent = string.Format(Format, Args);
		}
		else
		{
			reportTrack.EvtContent = Format;
		}
		EventTrackingRequest.Tracks.Add(reportTrack);
	}
}
