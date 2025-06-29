using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using GSE.OnlineBase;
using Gssdk;
using UnrealEngine.Runtime;

namespace GSE.GSSdk;

public class GSSDKReportQueue
{
	private static ReportEventWorkerParam QueueWorkerParam = new ReportEventWorkerParam();

	private static string LocalStoreDir;

	private static Task QueueStoreTask = null;

	private static CancellationTokenSource QueueTaskCancellation = null;

	public static bool DisableHttpReport = false;

	private static FileManager FileManager = null;

	private static int BakupQueueFileMaxCount = 20;

	public static int MaxOneQueueFileSize = 4194304;

	public static bool UseUnrealHttpPostProxy = true;

	private static string userid = "0";

	private static int MaxReportHttpFailRetryTimes = 2;

	private static string[] HttpContentHeaders = new string[1] { "Content-Type:application/octet-stream" };

	private static long FetchedHttpBytes = 0L;

	private static long FetchedLoadBytes = 0L;

	private static long FetchedSaveBytes = 0L;

	private static long FetchSendHttpReqs = 0L;

	private static long FetchSendHttpFailReqs = 0L;

	private static volatile bool OSSReportUseGZip = true;

	public static int SaveQueueIntervalSeconds = 30;

	public static int LoadQueueIntervalSeconds = 120;

	public static long TotalSentBytesForHttp { get; private set; } = 0L;

	public static long TotalLoadBytesForItems { get; private set; } = 0L;

	public static long TotalSaveBytesForItems { get; private set; } = 0L;

	public static long TotalSentReqsForHttp { get; private set; } = 0L;

	public static long TotalSentReqsForHttpFail { get; private set; } = 0L;

	public static void InitFileManager()
	{
		IFileOperationStrategy strategy;
		if (IConsoleManager.Get().FindConsoleVariable("DebugConfig.FileIOStrategy").GetString() == "UGSFileHelper")
		{
			strategy = new UGSFileOperationStrategy();
			LocalStoreDir = "/Download/report";
		}
		else
		{
			strategy = new CSharpFileOperationStrategy();
			LocalStoreDir = Path.Combine(FPaths.ProjectPersistentDownloadDir, "report");
		}
		if (GSSDKEnv.UserInfo.ClientSetting.PlayMode.Contains("bench"))
		{
			LocalStoreDir = LocalStoreDir.Replace("report", "breport");
		}
		FileManager = new FileManager(strategy);
	}

	public static void InitQueueWorker(string UserId, bool EnableLocalStore, ConcurrentQueue<ReportEventItemRaw> QueueRaw, HttpPostAsyncProxy Proxy = null)
	{
		SetUserId(UserId);
		InitFileManager();
		LogHelper.LogWarn($"report queue gssdk report queue InitQueueWorker {EnableLocalStore} dir:{LocalStoreDir}");
		if (!FileManager.DirExists(LocalStoreDir))
		{
			FileManager.CreateDirectory(LocalStoreDir);
		}
		QueueTaskCancellation = new CancellationTokenSource();
		QueueWorkerParam.EvtQueueRaw = QueueRaw;
		QueueWorkerParam.EnableLocalStore = EnableLocalStore;
		QueueWorkerParam.CancelToken = QueueTaskCancellation.Token;
		QueueWorkerParam.PostProxy = Proxy;
		QueueStoreTask = Task.Run(delegate
		{
			DoEventReportInWorkerThread(QueueWorkerParam);
		}, QueueTaskCancellation.Token);
	}

	public static void Stop()
	{
		LogHelper.LogWarn("report queue ThreadReport stoping ...");
		if (QueueTaskCancellation != null)
		{
			QueueTaskCancellation.Cancel();
			QueueTaskCancellation = null;
		}
		if (QueueStoreTask == null)
		{
			return;
		}
		try
		{
			if (!QueueStoreTask.Wait(TimeSpan.FromMilliseconds(300.0)))
			{
				LogHelper.LogWarn("report queue wait queue store task finish fail !");
			}
			LogHelper.LogWarn("report queue wait queue store task finish success !");
		}
		catch (AggregateException ex)
		{
			if (ex.InnerExceptions.Any((Exception e) => e is OperationCanceledException))
			{
				LogHelper.LogWarn("report queue Task was canceled.");
			}
			else
			{
				LogHelper.LogWarn("report queue ThreadReport stoping ex ... " + ex.Message);
			}
		}
		QueueStoreTask = null;
	}

	private static string GetSaveQueueFileSuffix()
	{
		return ".rptq";
	}

	private static bool LoadItemsFromLocal(Queue<ReportEventItem> EvtQueue)
	{
		string text = FindOldestFileName();
		if (!FileManager.FileExists(text))
		{
			return false;
		}
		try
		{
			int LoadItemsNum = 0;
			int num = FileManager.LoadMessage(text, EvtQueue, out LoadItemsNum);
			TotalLoadBytesForItems += num;
			LogHelper.LogWarn($"report queue LoadItemsNum={LoadItemsNum} from path:{text} load bytes:{num}/{TotalLoadBytesForItems}");
		}
		catch (Exception ex)
		{
			LogHelper.LogError("report queue  ThreadReport getItemsFromLocal except:{0}", ex);
		}
		try
		{
			if (FileManager.FileExists(text))
			{
				FileManager.DeleteFile(text);
			}
		}
		catch (Exception ex2)
		{
			LogHelper.LogError("report queue  delete file:" + text + " fail ex:" + ex2.Message);
		}
		return true;
	}

	private static string FindNextAvaliWritableFilePate()
	{
		string saveQueueFilePrefix = GetSaveQueueFilePrefix();
		string saveQueueFileSuffix = GetSaveQueueFileSuffix();
		for (int i = 0; i < BakupQueueFileMaxCount; i++)
		{
			string text = Path.Combine(LocalStoreDir, $"{saveQueueFilePrefix}_{i:D2}{saveQueueFileSuffix}");
			bool num = FileManager.FileExists(text);
			long num2 = FileManager.FileSize(text);
			if (!num || num2 < MaxOneQueueFileSize)
			{
				return text;
			}
		}
		string text2 = FindOldestFileName();
		if (FileManager.FileExists(text2))
		{
			FileManager.DeleteFile(text2);
		}
		return text2;
	}

	private static string FindOldestFileName()
	{
		string saveQueueFilePrefix = GetSaveQueueFilePrefix();
		string saveQueueFileSuffix = GetSaveQueueFileSuffix();
		string path = saveQueueFilePrefix + "_00" + saveQueueFileSuffix;
		DateTime value = DateTime.Now;
		for (int i = 0; i < BakupQueueFileMaxCount; i++)
		{
			string text = $"{saveQueueFilePrefix}_{i:D2}{saveQueueFileSuffix}";
			string text2 = Path.Combine(LocalStoreDir, text);
			bool num = FileManager.FileExists(text2);
			DateTime outDateTime;
			bool timeStamp = FileManager.GetTimeStamp(text2, out outDateTime);
			if (num && timeStamp && outDateTime.CompareTo(value) < 0)
			{
				path = text;
				value = outDateTime;
			}
		}
		return Path.Combine(LocalStoreDir, path);
	}

	private static void SetUserId(string UserId)
	{
		if (!string.IsNullOrEmpty(UserId))
		{
			userid = UserId;
		}
	}

	private static string GetSaveQueueFilePrefix()
	{
		return "b1." + userid;
	}

	private static void SaveItemsToLocal(Queue<ReportEventItem> EvtQueue)
	{
		string text = "";
		if (EvtQueue == null || EvtQueue.Count == 0)
		{
			return;
		}
		try
		{
			int count = EvtQueue.Count;
			LogHelper.LogInfo($"report queue  event queue save to local num:{EvtQueue.Count}");
			if (!FileManager.DirExists(LocalStoreDir))
			{
				LogHelper.LogInfo("report queue create local store:" + LocalStoreDir + " dir for not exist");
				FileManager.CreateDirectory(LocalStoreDir);
			}
			text = FindNextAvaliWritableFilePate();
			int num = 0;
			num = FileManager.DumpMessage(text, EvtQueue);
			TotalSaveBytesForItems += num;
			LogHelper.LogWarn($"report queue  save item num:{count} to file:{text} write size:{num}/{TotalSaveBytesForItems}");
		}
		catch (Exception ex)
		{
			LogHelper.LogError("report queue  saveItemsToLocal except:{0} file:{1}", ex, text);
		}
	}

	private static bool ReportEventWithSyncHttpClient(string Url, ReportEventItem item)
	{
		HttpWebRequest httpWebRequest = null;
		HttpWebResponse httpWebResponse = null;
		try
		{
			httpWebRequest = WebRequest.Create(Url) as HttpWebRequest;
			httpWebRequest.Method = (item.Meth.ToUpper().StartsWith("GET") ? "GET" : "POST");
			httpWebRequest.KeepAlive = false;
			httpWebRequest.Timeout = 15000;
			if (item.Data != null && item.Data.Length > 0)
			{
				using Stream stream = httpWebRequest.GetRequestStream();
				stream.Write(item.Data.ToByteArray(), 0, item.Data.ToByteArray().Length);
			}
			httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
			return true;
		}
		catch (WebException ex)
		{
			LogHelper.LogError("report queue ThreadReport req except:" + ex.Message + ", Url:" + Url);
		}
		catch (Exception arg)
		{
			LogHelper.LogError($"report queue ThreadReport other except:{arg}, Url:{Url}");
		}
		finally
		{
			if (httpWebRequest != null)
			{
				httpWebRequest.Abort();
				httpWebRequest = null;
			}
			if (httpWebResponse != null)
			{
				httpWebResponse.Close();
				httpWebResponse = null;
			}
		}
		return false;
	}

	public static long FetchDeltaHttpBytes()
	{
		long num = TotalSentBytesForHttp - FetchedHttpBytes;
		FetchedHttpBytes += num;
		return num;
	}

	public static long FetchDeletaLoadBytes()
	{
		long num = TotalLoadBytesForItems - FetchedLoadBytes;
		FetchedLoadBytes += num;
		return num;
	}

	public static long FetchDeltaSaveBytes()
	{
		long num = TotalLoadBytesForItems - FetchedSaveBytes;
		FetchedSaveBytes += num;
		return num;
	}

	public static long FetchDeltaHttpReqs()
	{
		long num = TotalSentReqsForHttp - FetchSendHttpReqs;
		FetchSendHttpReqs += num;
		return num;
	}

	public static long FetchDeltaHttpFailReqs()
	{
		long num = TotalSentReqsForHttpFail - FetchSendHttpFailReqs;
		FetchSendHttpFailReqs += num;
		return num;
	}

	private static bool TryReportEventOne(ReportEventItem item, HttpPostAsyncProxy PostProxy)
	{
		if (DisableHttpReport)
		{
			return false;
		}
		string text = "?Ver=" + DateTime.Now.ToString("mmddHHMMSS");
		string text2 = GSSDKEnv.GetServiceUrl(item.Service, item.Api) + text;
		text2 += "&encoding=pb3";
		text2 = text2 + "&time=" + new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
		if (item.Compress.Length > 0 && item.Service == "Report")
		{
			text2 += $"&compress={item.Compress}";
		}
		TotalSentReqsForHttp++;
		TotalSentBytesForHttp += item.Data.Length;
		if (PostProxy != null && UseUnrealHttpPostProxy)
		{
			if (PostProxy(text2, HttpContentHeaders, item.Data.ToByteArray()))
			{
				return true;
			}
		}
		else
		{
			for (int i = 0; i < MaxReportHttpFailRetryTimes; i++)
			{
				if (ReportEventWithSyncHttpClient(text2, item))
				{
					return true;
				}
			}
		}
		LogHelper.LogError($"http post bytes:{item.Data.Length}/{TotalSentBytesForHttp} fail");
		return false;
	}

	private static void PrepareEventReport(ReportEventItemRaw itemRaw, Queue<ReportEventItem> queue)
	{
		if (itemRaw.meth.Length == 0)
		{
			itemRaw.meth = "POST";
			LogHelper.LogError("ThreadReport prepareEventReport meth error item:{0}", itemRaw.ToString());
		}
		bool flag = false;
		byte[] array = new byte[0];
		if (itemRaw.TrackReq != null)
		{
			itemRaw.TrackReq.Time = LocalTime.GetUnixTimeStamp();
			array = PbEncoding.Encode(itemRaw.TrackReq);
		}
		else if (itemRaw.MonitorReq != null)
		{
			array = PbEncoding.Encode(itemRaw.MonitorReq);
		}
		else if (itemRaw.EventReq != null)
		{
			array = PbEncoding.Encode(itemRaw.EventReq);
		}
		else if (itemRaw.UserReq != null)
		{
			array = PbEncoding.Encode(itemRaw.UserReq);
		}
		else
		{
			if (itemRaw.UpdateFilesReq == null)
			{
				LogHelper.LogError("report queue ThreadReport prepareEventReport itemRaw REQ all is null:{0}", itemRaw);
				return;
			}
			array = PbEncoding.Encode(itemRaw.UpdateFilesReq);
		}
		if (array.Length == 0)
		{
			LogHelper.LogError("report queue ThreadReport prepareEventReport got empty data:{0}", itemRaw);
			return;
		}
		if (flag)
		{
			array = GSSDKClient.PbEncryptSim(array);
		}
		string compress = "gzip";
		if (OSSReportUseGZip)
		{
			array = ZipUtils.Compress(array);
		}
		else
		{
			compress = "";
		}
		queue.Enqueue(new ReportEventItem
		{
			Service = itemRaw.service,
			Api = itemRaw.api,
			Meth = itemRaw.meth,
			Compress = compress,
			Data = ByteString.CopyFrom(array, 0, array.Length)
		});
	}

	private static void DoEventReportInWorkerThread(ReportEventWorkerParam worker_param)
	{
		LogHelper.LogInfo($"report queue ThreadReport report start in thread:{Thread.CurrentThread.Name} id:{Thread.CurrentThread.ManagedThreadId}");
		Queue<ReportEventItem> queue = new Queue<ReportEventItem>();
		DateTime now = DateTime.Now;
		DateTime now2 = DateTime.Now;
		ReportEventItemRaw result = null;
		LoadItemsFromLocal(queue);
		int result2 = 0;
		bool flag = true;
		for (; !worker_param.CancelToken.IsCancellationRequested; Thread.Sleep(200))
		{
			try
			{
				if (worker_param.EvtQueueRaw.TryDequeue(out result))
				{
					PrepareEventReport(result, queue);
				}
				while (queue.Count > 0 && !worker_param.CancelToken.IsCancellationRequested)
				{
					ReportEventItem reportEventItem = queue.Dequeue();
					if (reportEventItem.Meth != null && reportEventItem.Meth.Contains('?'))
					{
						int num = reportEventItem.Meth.IndexOf("?");
						if (!int.TryParse(reportEventItem.Meth.Substring(num + 1), out result2))
						{
							result2 = 0;
						}
						reportEventItem.Meth = reportEventItem.Meth.Substring(0, num);
					}
					else
					{
						result2 = 0;
					}
					flag = TryReportEventOne(reportEventItem, worker_param.PostProxy);
					if (!flag)
					{
						TotalSentReqsForHttpFail++;
						if (worker_param.EnableLocalStore && result2 < 30)
						{
							reportEventItem.Meth = reportEventItem.Meth + "?" + (result2 + 1);
							queue.Enqueue(reportEventItem);
						}
						Thread.Sleep(3000);
						break;
					}
					Thread.Sleep(50);
				}
				if (worker_param.CancelToken.IsCancellationRequested)
				{
					break;
				}
				if (worker_param.EnableLocalStore && queue.Count > 0 && DateTime.Now >= now.AddSeconds(SaveQueueIntervalSeconds))
				{
					now = DateTime.Now;
					SaveItemsToLocal(queue);
				}
				if (worker_param.EnableLocalStore && queue.Count == 0 && flag && DateTime.Now >= now2.AddSeconds(LoadQueueIntervalSeconds) && !LoadItemsFromLocal(queue))
				{
					now2 = DateTime.Now;
				}
				continue;
			}
			catch (Exception ex)
			{
				LogHelper.LogError($"report queue ThreadReport doEventReport except:{ex.Message} itemRaw:{result}");
				continue;
			}
		}
		try
		{
			LogHelper.LogWarn($"report queue ThreadReport cancel final rest raw queue raw num:{worker_param.EvtQueueRaw.Count} load:{TotalLoadBytesForItems} save:{TotalSaveBytesForItems} http send:{TotalSentBytesForHttp}");
			int num2 = 100;
			while (worker_param.EvtQueueRaw.TryDequeue(out result) && num2 > 0)
			{
				PrepareEventReport(result, queue);
				num2--;
			}
			LogHelper.LogWarn($"report queue ThreadReport save to final evt queue:{queue.Count} ...");
			SaveItemsToLocal(queue);
		}
		catch (Exception ex2)
		{
			LogHelper.LogError("report exception msg:" + ex2.Message);
		}
	}
}
