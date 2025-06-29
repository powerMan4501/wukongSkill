using System;
using System.Collections.Concurrent;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using GSE.GSSdk;
using Gssdk;
using LitJson;
using UnrealEngine.Runtime;

namespace b1;

internal class GSSdkAsyncLogger
{
	private readonly ConcurrentQueue<ReportLogEventLine> _messages = new ConcurrentQueue<ReportLogEventLine>();

	private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

	private ReportLogEventReq LogEventReq = new ReportLogEventReq();

	private Task _logTask;

	private int MaxBatchReportSize = 1048576;

	private int MaxBatchReportCount = 1000;

	private int CurBatchReportSize;

	private int MaxBatchReportWaitSeconds = 60;

	private DateTime LastReportTime = DateTime.Now;

	public bool Enabled => _logTask != null;

	public GSSdkAsyncLogger(int BatchReportSize = 1048576, int BatchReportWaitSeconds = 60)
	{
		MaxBatchReportSize = BatchReportSize;
		MaxBatchReportWaitSeconds = BatchReportWaitSeconds;
	}

	public void Start(ReportLogEventSession _Session)
	{
		if (_logTask != null)
		{
			return;
		}
		LogEventReq.Session = _Session;
		int MaxOnceReportCheckCount = MaxBatchReportCount / 10 + 10;
		_logTask = Task.Run(async delegate
		{
			while (!_cancellationTokenSource.IsCancellationRequested)
			{
				int i;
				for (i = 0; i < MaxOnceReportCheckCount; i++)
				{
					if (!_messages.TryDequeue(out var result))
					{
						break;
					}
					CurBatchReportSize += result.CalculateSize();
					LogEventReq.EventList.Add(result);
				}
				ReportCheck(Flush: false);
				if (i < MaxOnceReportCheckCount)
				{
					await Task.Delay(500);
				}
				else
				{
					await Task.Delay(1000);
				}
			}
			int num = 0;
			ReportLogEventLine result2;
			while (_messages.TryDequeue(out result2))
			{
				num++;
				CurBatchReportSize += result2.CalculateSize();
				LogEventReq.EventList.Add(result2);
			}
			ReportCheck(Flush: true);
		});
	}

	public void ReportCheck(bool Flush, OnProtobufResponse<ReportLogEventRes> OnRspCallback = null)
	{
		if (_logTask != null && (Flush || DateTime.Now - LastReportTime > TimeSpan.FromSeconds(MaxBatchReportWaitSeconds) || LogEventReq.EventList.Count > MaxBatchReportCount || CurBatchReportSize > MaxBatchReportSize))
		{
			LastReportTime = DateTime.Now;
			if (LogEventReq.EventList.Count > 0)
			{
				string path = Path.Combine(FPaths.ProjectSavedDir, "PostReqData.txt");
				string data = JsonMapper.ToJson(LogEventReq);
				UGSE_EngineFuncLib.SaveStringToFile(path, data);
				GSSDKRpc.DevReportLogEvent(LogEventReq, OnRspCallback);
				CurBatchReportSize = 0;
				LogEventReq.EventList.Clear();
			}
		}
	}

	public void Log(ReportLogEventLine message)
	{
		if (_logTask != null)
		{
			_messages.Enqueue(message);
		}
	}

	public void Stop()
	{
		try
		{
			if (_logTask != null)
			{
				_cancellationTokenSource.Cancel();
				_logTask.Wait(5000);
			}
		}
		catch (Exception arg)
		{
			BGW_LogUtil.LogError($"GSSdkAsyncLogger Stop Exception:{arg}");
		}
	}
}
