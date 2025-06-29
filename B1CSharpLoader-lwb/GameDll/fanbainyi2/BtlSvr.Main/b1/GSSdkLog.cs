using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using GSE.GSSdk;
using GSE.OnlineBase;
using Gssdk;
using LitJson;
using UnrealEngine.Runtime;

namespace b1;

public class GSSdkLog
{
	public delegate void OnFileUploadFinish(bool success, string FileIdOrErrMsg);

	public delegate void OnFileListUploadFinish(Dictionary<string, string> PathSuccDict);

	private class HttpUploadFileRet
	{
		public int code;

		public string msg;

		public string res_id;
	}

	private class HttpUplodaListState
	{
		public List<string> FilePathList;

		public int CurrentUploadIndex;

		public OnFileListUploadFinish OnFinish;

		public int RequestTimeoutSeconds;

		public Dictionary<string, string> PathSuccDict = new Dictionary<string, string>();
	}

	private b1.GSSdkAsyncLogger Logger = new b1.GSSdkAsyncLogger();

	private ReportLogEventSession Session;

	private static int CurrentSeqence;

	private UObject Context;

	private string UploadServiceUrl;

	[Conditional("DEBUG")]
	public void SetUploadServiceUrl(string Url)
	{
		UploadServiceUrl = Url;
	}

	public void Init(UObject Context)
	{
		if (!B1Global.GIsGameReleased)
		{
			this.Context = Context;
			string systemStartTime = FGlobals.SystemStartTime;
			string format = "yyyy.MM.dd-HH.mm.ss";
			uint gameStartTimestamp = (uint)(DateTime.ParseExact(systemStartTime, format, null) - new DateTime(1970, 1, 1)).TotalSeconds;
			string localIpv4ListStr = BGW_LocalDevEnvUtils.GetLocalIpv4ListStr();
			Session = new ReportLogEventSession
			{
				GameStartTimestamp = gameStartTimestamp,
				DeviceId = GSSDKEnv.UserInfo.DeviceInfo.DeviceId,
				DeviceInfo = $"PLATFORM:{GSSDKEnv.UserInfo.DeviceInfo.Platform},OSVer:{GSSDKEnv.UserInfo.DeviceInfo.OsVer},Editor:{FGlobals.IsEditor}",
				HostName = (Dns.GetHostName() ?? "UnKnow"),
				SessionUuid = BGW_GSSdkMgr.Get(Context).GameStartSessionUUID,
				Ip = localIpv4ListStr,
				UserSdkId = GSSDKEnv.UserInfo.AuthInfo.LoginChannelUid,
				UserRoleId = GSSDKEnv.UserInfo.AuthInfo.Roleid.ToString()
			};
			UploadServiceUrl = "http://gssdk.b1.gamesci.com.cn:9800/DevReportServerImpl/LogEventUpload";
			Logger.Start(Session);
		}
	}

	public void Stop()
	{
		Logger.Stop();
	}

	private void LogMessageInternal(string Tag, ReportLogEventLine Msg)
	{
		Logger.Log(Msg);
	}

	[Conditional("DEBUG")]
	public void Flush(OnProtobufResponse<ReportLogEventRes> OnRspCallback = null)
	{
		Logger.ReportCheck(Flush: true, OnRspCallback);
	}

	[Conditional("DEBUG")]
	public void Log(string Tag, string MsgStr, string[] AssociateFileList = null, Action<Dictionary<string, string>> OnUploadFileListFinished = null)
	{
		if (!Logger.Enabled)
		{
			return;
		}
		if (AssociateFileList == null || AssociateFileList.Length == 0)
		{
			LogMessage(Tag, MsgStr);
			return;
		}
		UploadFileList(AssociateFileList.ToList(), delegate(Dictionary<string, string> UpFileIdDict)
		{
			string associatFileList = string.Join(",", UpFileIdDict.Values.ToList());
			LogMessage(Tag, MsgStr, associatFileList);
			OnUploadFileListFinished?.Invoke(UpFileIdDict);
		}, 30);
	}

	[Conditional("DEBUG")]
	public void Log(string Tag, object MsgObj, string[] AssociateFileList = null, Action<Dictionary<string, string>> OnUploadFileListFinished = null)
	{
		if (!Logger.Enabled)
		{
			return;
		}
		if (AssociateFileList == null || AssociateFileList.Length == 0)
		{
			LogMessage(Tag, MsgObj);
			return;
		}
		UploadFileList(AssociateFileList.ToList(), delegate(Dictionary<string, string> UpFileIdDict)
		{
			string associatFileList = string.Join(",", UpFileIdDict.Values.ToList());
			LogMessage(Tag, MsgObj, associatFileList);
			OnUploadFileListFinished?.Invoke(UpFileIdDict);
		}, 30);
	}

	private void LogMessage(string Tag, string MsgStr, string AssociatFileList = "")
	{
		if (Logger.Enabled)
		{
			if (Tag.Length < 5)
			{
				BGW_LogUtil.LogError("GSSdkLog tag length must not be less than 5");
				return;
			}
			Interlocked.Increment(ref CurrentSeqence);
			LogMessageInternal(Tag, new ReportLogEventLine
			{
				Timestamp = LocalTime.GetUnixTimeStamp(),
				Tag = Tag,
				Sequence = (uint)CurrentSeqence,
				MsgStr = MsgStr,
				Frame = FGlobals.FrameNumber,
				AssociateFileUuid = AssociatFileList
			});
		}
	}

	private void LogMessage(string Tag, object MsgObj, string AssociatFileList = "")
	{
		string msgStr = JsonMapper.ToJson(MsgObj);
		LogMessage(Tag, msgStr, AssociatFileList);
	}

	private OnFileUploadFinish OnPathUploadListCallback(HttpUplodaListState state, int i)
	{
		return delegate(bool success, string FileIdOrErrMsg)
		{
			if (success)
			{
				state.PathSuccDict.Add(state.FilePathList[i], FileIdOrErrMsg);
			}
			else
			{
				BGW_LogUtil.LogError("upload file " + state.FilePathList[i] + " failed " + FileIdOrErrMsg);
			}
			state.CurrentUploadIndex++;
			if (state.CurrentUploadIndex >= state.FilePathList.Count)
			{
				state.OnFinish(state.PathSuccDict);
			}
			else
			{
				UploadFile(state.FilePathList[state.CurrentUploadIndex], OnPathUploadListCallback(state, state.CurrentUploadIndex), state.RequestTimeoutSeconds);
			}
		};
	}

	private void UploadFileList(List<string> FilePathList, OnFileListUploadFinish OnUploadFinish, int RequestTimeoutSeconds = 0)
	{
		HttpUplodaListState state = new HttpUplodaListState
		{
			FilePathList = FilePathList,
			OnFinish = OnUploadFinish,
			RequestTimeoutSeconds = RequestTimeoutSeconds
		};
		UploadFile(FilePathList[0], OnPathUploadListCallback(state, 0), RequestTimeoutSeconds);
	}

	private void UploadFile(string FilePath, OnFileUploadFinish OnUploadFinish, int RequestTimeoutSeconds = 0)
	{
		if (string.IsNullOrEmpty(UploadServiceUrl) || string.IsNullOrEmpty(FilePath))
		{
			OnUploadFinish(success: false, "invalid param");
		}
		else if (!BGW_AsyncTaskMgr.Get(Context).HttpPostFileAsync(UploadServiceUrl, FilePath, null, delegate(int HttpStatus, byte[] Response)
		{
			if ((HttpStatus == 0 || HttpStatus == 200) && Response.Length != 0)
			{
				string text = Encoding.UTF8.GetString(Response);
				try
				{
					HttpUploadFileRet httpUploadFileRet = JsonMapper.ToObject<HttpUploadFileRet>(text);
					if (httpUploadFileRet.code == 0 && httpUploadFileRet.res_id.Length > 0)
					{
						BGW_LogUtil.LogError($"UploadFiles succ code:{httpUploadFileRet.code} msg:{httpUploadFileRet.msg} res id:{httpUploadFileRet.res_id}");
						OnUploadFinish(success: true, httpUploadFileRet.res_id);
					}
					else
					{
						BGW_LogUtil.LogError($"UploadFiles fail code:{httpUploadFileRet.code} msg:{httpUploadFileRet.msg} res id:{httpUploadFileRet.res_id}");
						OnUploadFinish(success: false, httpUploadFileRet.msg);
					}
					return;
				}
				catch (Exception ex)
				{
					BGW_LogUtil.LogError("process server resp:" + text + " exception:" + ex.Message);
					OnUploadFinish(success: false, "exception:" + ex.Message);
					return;
				}
			}
			BGW_LogUtil.LogError($"UploadFiles http fail:{HttpStatus} response len:{Response.Length}");
			OnUploadFinish(success: false, "http fail");
		}, RequestTimeoutSeconds))
		{
			BGW_LogUtil.LogError("UploadFiles is invalid call");
		}
	}
}
