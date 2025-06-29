using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using GSE.GSSdk;
using GSE.OnlineBase;
using LitJson;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_GSUploadFilesMgr")]
public class BGW_GSUploadFilesMgr : GameInstanceSystemBaseUObj
{
	private class BugReportCreate
	{
		public string reporter = "qiye weixin id";

		public string dump_stack = "";

		public string region = "sz/hz";

		public string device_info = "";

		public string context_info = "";

		public string share_path = "";

		public string custom_text = "";

		public string desc_text = "";
	}

	private bool IsUploadFiles;

	private int TaskID;

	private UObject WorldContext;

	private static string ReportBugUrl;

	private static string TapdBugReportUrl;

	private bool IsNeedListenUploadState;

	private Action CacheOnEndUploadAction;

	private float CurrentUploadTime;

	private readonly float UploadTimeOutTime = 360f;

	public override bool bTickEnabled => true;

	private bool IsEnabled
	{
		get
		{
			if (!B1Global.GIsGameReleasedReally_Just4DevSimulation)
			{
				return true;
			}
			if (BGW_GSSdkMgr.Get(this).GetUserJsonConfigKeyValue("F1Enable", "false") == "true")
			{
				return true;
			}
			BGW_LogUtil.LogError("error action for f1 in current time");
			return false;
		}
	}

	public static BGW_GSUploadFilesMgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_GSUploadFilesMgr>(WorldContext);
	}

	public void TapdBugReport(string BugDesc, string BugFileDestPath, string BugTags = "")
	{
		string reqJsonText = JsonMapper.ToJson(new BugReportCreate
		{
			reporter = GSSDKEnv.UserInfo.AuthInfo.LoginChannelUid,
			desc_text = BugDesc,
			context_info = "",
			share_path = BugFileDestPath,
			custom_text = "Tags=" + BugTags,
			region = "hz/sz"
		});
		TapdReportHttpAsync(reqJsonText);
	}

	private void TapdReportHttpAsync(string ReqJsonText)
	{
		if (IsEnabled)
		{
			string text = BGW_GSSdkMgr.Get(this).GetUserJsonConfigKeyValue("F1BugReportUrl");
			if (string.IsNullOrEmpty(text))
			{
				text = ReportBugUrl;
			}
			if (!BGW_AsyncTaskMgr.Get(this).HttpRequestAsync(text, "POST", new string[1] { "Content-Type:application/json" }, Encoding.UTF8.GetBytes(ReqJsonText), OnTapdBugReportFinish))
			{
				BGW_LogUtil.LogError("tapd bug report http fail");
			}
		}
	}

	private void TapdBugReportWithCSharp(string ReqJsonText)
	{
		HttpWebRequest httpWebRequest = null;
		HttpWebResponse httpWebResponse = null;
		try
		{
			httpWebRequest = WebRequest.Create(ReportBugUrl) as HttpWebRequest;
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/json";
			byte[] bytes = Encoding.UTF8.GetBytes(ReqJsonText);
			httpWebRequest.GetRequestStream().Write(bytes, 0, bytes.Length);
			httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
			if (httpWebResponse.StatusCode == HttpStatusCode.OK)
			{
				Stream responseStream = httpWebResponse.GetResponseStream();
				byte[] array = new byte[8192];
				int num = 0;
				while (responseStream.CanRead)
				{
					int num2 = responseStream.Read(array, num, array.Length - num);
					if (num2 == 0)
					{
						break;
					}
					if (num2 > 0)
					{
						num += num2;
						if (num >= array.Length * 90 / 100)
						{
							byte[] array2 = new byte[array.Length * 2];
							array.CopyTo(array2, 0);
							array = array2;
						}
					}
				}
				Encoding.UTF8.GetString(array, 0, num);
			}
			else
			{
				LogHelper.LogError("report bug fail");
			}
		}
		catch (Exception ex)
		{
			LogHelper.LogError("report bug exception:" + ex.Message);
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
	}

	public void BugReportUploadFiles(List<string> UploadFiles, string ServerDir, Action OnStartUploadAction = null, Action OnEndUploadAction = null)
	{
		if (IsEnabled)
		{
			string text = BGW_GSSdkMgr.Get(this).GetUserJsonConfigKeyValue("F1BugReportUploadFileUrl");
			if (string.IsNullOrEmpty(text))
			{
				text = TapdBugReportUrl;
			}
			string text2 = WebUtility.UrlEncode(ServerDir);
			string url = text + text2;
			if (BGW_AsyncTaskMgr.Get(this).HttpPostFileListAsync(url, UploadFiles.ToArray(), null, OnTapdBugReportUploadFileFinish, 300))
			{
				IsUploadFiles = true;
				OnTriggerStartListenUploadAction(OnStartUploadAction, OnEndUploadAction);
			}
			else
			{
				BGW_LogUtil.LogError("tapd bug report upload files http fail");
			}
		}
	}

	private void OnTapdBugReportUploadFileFinish(int HttpStatusCode, byte[] ResponseContent)
	{
		_ = ResponseContent?.LongLength;
		if (IsUploadFiles)
		{
			_ = FGlobals.IsEditor;
			IsUploadFiles = false;
			OnTriggerEndUploadAction();
		}
	}

	private void OnTapdBugReportFinish(int HttpStatusCode, byte[] ResponseContent)
	{
		_ = ResponseContent?.LongLength;
	}

	public void StartUploadFiles(string WorkingDir, string DstFileDir, Action OnStartUploadAction = null, Action OnEndUploadAction = null)
	{
		if (!IsEnabled)
		{
			return;
		}
		OnTriggerEndUploadAction();
		DirectoryInfo directoryInfo = new DirectoryInfo(WorkingDir);
		bool flag = Compress(directoryInfo);
		List<string> list = new List<string>();
		FileInfo[] files = directoryInfo.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			if (flag)
			{
				if (fileInfo.Extension == ".gz")
				{
					list.Add(fileInfo.FullName);
				}
			}
			else
			{
				list.Add(fileInfo.FullName);
			}
		}
		BugReportUploadFiles(list, DstFileDir, OnStartUploadAction, OnEndUploadAction);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (IsNeedListenUploadState)
		{
			CurrentUploadTime += DeltaTime;
			if (CurrentUploadTime >= UploadTimeOutTime)
			{
				OnTriggerEndUploadAction();
			}
		}
	}

	public bool Compress(DirectoryInfo DirectorySelected)
	{
		bool flag = false;
		try
		{
			FileInfo[] files = DirectorySelected.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				using FileStream fileStream = File.Open(fileInfo.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				if ((File.GetAttributes(fileInfo.FullName) & FileAttributes.Hidden) == FileAttributes.Hidden || !(fileInfo.Extension != ".gz"))
				{
					continue;
				}
				using FileStream stream = File.Create(fileInfo.FullName + ".gz");
				using GZipStream destination = new GZipStream(stream, CompressionMode.Compress);
				fileStream.CopyTo(destination);
			}
			flag = true;
		}
		catch (Exception arg)
		{
			BGW_LogUtil.LogError($"[BGW_GSUploadFilesMgr] GZipStream Compress Failed! {arg}");
			flag = false;
		}
		if (!flag)
		{
			try
			{
				FileInfo[] files = DirectorySelected.GetFiles("*.gz");
				for (int i = 0; i < files.Length; i++)
				{
					files[i].Delete();
				}
			}
			catch (Exception arg2)
			{
				BGW_LogUtil.LogError($"[BGW_GSUploadFilesMgr] Delete Compress File Failed! {arg2}");
			}
		}
		return flag;
	}

	private void OnTriggerStartListenUploadAction(Action OnStartUploadAction = null, Action OnEndUploadAction = null)
	{
		if (OnStartUploadAction != null)
		{
			OnStartUploadAction?.Invoke();
			IsNeedListenUploadState = true;
			CacheOnEndUploadAction = OnEndUploadAction;
			CurrentUploadTime = 0f;
		}
	}

	private void OnTriggerEndUploadAction()
	{
		if (IsNeedListenUploadState)
		{
			IsNeedListenUploadState = false;
			CacheOnEndUploadAction?.Invoke();
			CacheOnEndUploadAction = null;
			CurrentUploadTime = 0f;
		}
	}

	static BGW_GSUploadFilesMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_GSUploadFilesMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_GSUploadFilesMgr));
		ReportBugUrl = "http://bugs.gs.com:1888/br/create";
		TapdBugReportUrl = "http://bugs.gs.com:8207/proxy_upload_files/?dst_path=";
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_GSUploadFilesMgr");
	}
}
