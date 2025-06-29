using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using GSE.GSSdk;
using LitJson;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_AsyncTaskMgr")]
public class BGW_AsyncTaskMgr : GameInstanceSystemBaseUObj
{
	public delegate void HttpJsonResponseNotify(int ErrorCode, JsonData JsonResponse, string ErrorMsg);

	private float LowHzTickCountdown = 0.1f;

	private static bool HttpRequestCallbackListeners_IsValid;

	private static int HttpRequestCallbackListeners_Offset;

	private static FFieldAddress HttpRequestCallbackListeners_PropertyAddress;

	private TArrayReadWriteMarshaler<UGSSdkHttpRequestCallbackListener> HttpRequestCallbackListeners_Marshaler;

	public override bool bTickEnabled => true;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_AsyncTaskMgr:HttpRequestCallbackListeners")]
	public TArrayReadWrite<UGSSdkHttpRequestCallbackListener> HttpRequestCallbackListeners
	{
		get
		{
			CheckDestroyed();
			if (!HttpRequestCallbackListeners_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_AsyncTaskMgr:HttpRequestCallbackListeners");
				return null;
			}
			if (HttpRequestCallbackListeners_Marshaler == null)
			{
				HttpRequestCallbackListeners_Marshaler = new TArrayReadWriteMarshaler<UGSSdkHttpRequestCallbackListener>(1, HttpRequestCallbackListeners_PropertyAddress, CachedMarshalingDelegates<UGSSdkHttpRequestCallbackListener, UObjectMarshaler<UGSSdkHttpRequestCallbackListener>>.FromNative, CachedMarshalingDelegates<UGSSdkHttpRequestCallbackListener, UObjectMarshaler<UGSSdkHttpRequestCallbackListener>>.ToNative);
			}
			return HttpRequestCallbackListeners_Marshaler.FromNative(IntPtr.Add(base.Address, HttpRequestCallbackListeners_Offset));
		}
	}

	public static BGW_AsyncTaskMgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_AsyncTaskMgr>(WorldContext);
	}

	public bool HttpFetchJson(string RequestUrl, bool PostMethod = true, HttpJsonResponseNotify OnResponse = null, object PostObject = null, string[] Headers = null, int ReqTimeoutSecond = 30)
	{
		List<string> list = new List<string>();
		if (Headers != null)
		{
			list.AddRange(Headers);
		}
		list.Add("Content-Type:application/json");
		byte[] postData = null;
		if (PostObject != null)
		{
			postData = Encoding.UTF8.GetBytes(JsonMapper.ToJson(PostObject));
		}
		string method = (PostMethod ? "POST" : "GET");
		if (OnResponse == null)
		{
			return HttpRequestAsync(RequestUrl, method, list.ToArray(), postData, null, ReqTimeoutSecond);
		}
		return HttpRequestAsync(RequestUrl, method, list.ToArray(), postData, delegate(int HttpStatusCode, byte[] resultBody)
		{
			if (resultBody == null || resultBody.Length == 0)
			{
				if (HttpStatusCode != 200)
				{
					OnResponse(HttpStatusCode, null, $"HttpCode:{HttpStatusCode} and Response is empt");
				}
				else
				{
					OnResponse(4, null, "HTTP 200 But Response is empty");
				}
			}
			else
			{
				string text = "";
				try
				{
					text = Encoding.UTF8.GetString(resultBody);
				}
				catch (Exception ex)
				{
					BGW_LogUtil.LogError("http url:" + RequestUrl + " json return body parse utf8 exception:" + ex.Message);
					OnResponse(3, null, ex.Message);
					return;
				}
				if (HttpStatusCode == 200)
				{
					try
					{
						JsonData jsonResponse = JsonMapper.ToObject(text);
						OnResponse(0, jsonResponse, "success");
						return;
					}
					catch (Exception ex2)
					{
						BGW_LogUtil.LogError("http url:" + RequestUrl + " json parse return body '" + text + "' exception:" + ex2.Message);
						OnResponse(3, null, ex2.Message);
						return;
					}
				}
				OnResponse(HttpStatusCode, null, text);
			}
		}, ReqTimeoutSecond);
	}

	public static HttpResponseMessage NonGameThreadHttpRequestSync(out bool OutIsTimeout, string RequestUrl, string Method = "GET", string[] Headers = null, byte[] PostData = null, int ReqTimeoutSecond = 30)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		OutIsTimeout = false;
		HttpResponseMessage val = new HttpResponseMessage(HttpStatusCode.InternalServerError);
		Dictionary<string, string> OutResponse = new Dictionary<string, string>();
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		if (Headers != null)
		{
			foreach (string text in Headers)
			{
				if (text.Contains(":"))
				{
					string[] array = text.Split(':');
					if (array.Length == 2)
					{
						dictionary.Add(array[0].Trim(), array[1].Trim());
					}
				}
			}
		}
		if (!dictionary.ContainsKey("Content-Type"))
		{
			dictionary.Add("Content-Type", "application/octet-stream");
		}
		List<byte> postRawData = new List<byte>();
		if (PostData != null)
		{
			postRawData = PostData.ToList();
		}
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		try
		{
			int num = UGSE_SDKFuncLib.NonGameThreadStartHttpRawDataRequestWithBlockMode(RequestUrl, Method, dictionary, postRawData, ReqTimeoutSecond, out OutResponse);
			stopwatch.Stop();
			if (num == 0)
			{
				val.StatusCode = HttpStatusCode.OK;
				string value = "";
				string value2 = "";
				if (OutResponse.ContainsKey("status_code"))
				{
					int.Parse(OutResponse["status_code"]);
				}
				OutResponse.TryGetValue("content", out value);
				if (!string.IsNullOrEmpty(value))
				{
					val.Content = (HttpContent)new ByteArrayContent(Convert.FromBase64String(value));
				}
				else
				{
					val.Content = (HttpContent)new StringContent("");
				}
				OutResponse.TryGetValue("headers", out value2);
				if (!string.IsNullOrEmpty(value2))
				{
					string[] separator = new string[1] { "\n\n" };
					string[] array2 = value2.Split(separator, StringSplitOptions.RemoveEmptyEntries);
					for (int j = 0; j < Headers.Length; j++)
					{
						string[] array3 = array2[j].Split(new char[1] { ':' }, 2);
						if (array3.Length == 2)
						{
							if (StringParseHelper.SafeToLower(array3[0].Trim()).StartsWith("content"))
							{
								((HttpHeaders)val.Content.Headers).Add(array3[0], array3[1]);
							}
							else
							{
								((HttpHeaders)val.Headers).Add(array3[0], array3[1]);
							}
						}
					}
				}
				return val;
			}
			BGW_LogUtil.LogError($"NonGameThreadHttpRequestSync  http request fail url:{RequestUrl} method:{Method} timeout:{ReqTimeoutSecond} Code:{num}");
			if (num == -2)
			{
				OutIsTimeout = true;
				return null;
			}
			return null;
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("request exception " + ex.Message);
		}
		return null;
	}

	public bool HttpRequestAsync(string RequestUrl, string Method = "GET", string[] Headers = null, byte[] PostData = null, HttpResponseFinishNotify OnResponse = null, int ReqTimeoutSecond = 30)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		if (Headers != null)
		{
			foreach (string text in Headers)
			{
				if (text.Contains(":"))
				{
					string[] array = text.Split(':');
					if (array.Length == 2)
					{
						dictionary.Add(array[0].Trim(), array[1].Trim());
					}
				}
			}
		}
		if (!dictionary.ContainsKey("Content-Type"))
		{
			dictionary.Add("Content-Type", "application/octet-stream");
		}
		List<byte> list = new List<byte>();
		if (PostData != null && PostData.Length != 0)
		{
			list.AddRange(PostData);
		}
		if (OnResponse == null)
		{
			return UGSE_SDKFuncLib.StartHttpRawDataRequest(RequestUrl, Method, dictionary, list, null, ReqTimeoutSecond);
		}
		UGSSdkHttpRequestCallbackListener uGSSdkHttpRequestCallbackListener = UObject.NewObject<UGSSdkHttpRequestCallbackListener>(this);
		uGSSdkHttpRequestCallbackListener.SetupCallback(OnResponse, ReqTimeoutSecond);
		HttpRequestCallbackListeners.Add(uGSSdkHttpRequestCallbackListener);
		bool num = UGSE_SDKFuncLib.StartHttpRawDataRequest(RequestUrl, Method, dictionary, list, uGSSdkHttpRequestCallbackListener, ReqTimeoutSecond);
		if (!num)
		{
			BGW_LogUtil.LogError("http invalid request to start url:" + RequestUrl);
			uGSSdkHttpRequestCallbackListener.SafeHandleResponseCallback(-1, Encoding.UTF8.GetBytes("invalid http request"));
		}
		return num;
	}

	public bool HttpPostFileAsync(string url, string FilePath, string[] headers = null, HttpResponseFinishNotify OnResponse = null, int RequestTimeout = 0)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		if (headers != null)
		{
			foreach (string text in headers)
			{
				if (text.Contains(":"))
				{
					string[] array = text.Split(':');
					if (array.Length == 2)
					{
						dictionary.Add(array[0].Trim(), array[1].Trim());
					}
				}
			}
		}
		if (OnResponse == null)
		{
			return UGSE_SDKFuncLib.HttpPostFile(url, dictionary, FilePath, null);
		}
		UGSSdkHttpRequestCallbackListener uGSSdkHttpRequestCallbackListener = UObject.NewObject<UGSSdkHttpRequestCallbackListener>(this);
		uGSSdkHttpRequestCallbackListener.SetupCallback(OnResponse, RequestTimeout);
		HttpRequestCallbackListeners.Add(uGSSdkHttpRequestCallbackListener);
		bool num = UGSE_SDKFuncLib.HttpPostFile(url, dictionary, FilePath, uGSSdkHttpRequestCallbackListener);
		if (!num)
		{
			BGW_LogUtil.LogError("upload file:" + FilePath + " http invalid request to start url:" + url);
			uGSSdkHttpRequestCallbackListener.SafeHandleResponseCallback(-1, Encoding.UTF8.GetBytes("invalid http request"));
		}
		return num;
	}

	public bool HttpPostFileListAsync(string url, string[] FilePathList, string[] headers = null, HttpResponseFinishNotify OnResponse = null, int RequestTimeout = 0)
	{
		if (FilePathList.Length == 0)
		{
			BGW_LogUtil.LogError("HttpPostFileListAsync FilePathList is empty");
			return false;
		}
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		if (headers != null)
		{
			foreach (string text in headers)
			{
				if (text.Contains(":"))
				{
					string[] array = text.Split(':');
					if (array.Length == 2)
					{
						dictionary.Add(array[0].Trim(), array[1].Trim());
					}
				}
			}
		}
		if (OnResponse == null)
		{
			return UGSE_SDKFuncLib.HttpPostFileList(url, dictionary, FilePathList.ToList(), null);
		}
		UGSSdkHttpRequestCallbackListener uGSSdkHttpRequestCallbackListener = UObject.NewObject<UGSSdkHttpRequestCallbackListener>(this);
		uGSSdkHttpRequestCallbackListener.SetupCallback(OnResponse, RequestTimeout);
		HttpRequestCallbackListeners.Add(uGSSdkHttpRequestCallbackListener);
		bool num = UGSE_SDKFuncLib.HttpPostFileList(url, dictionary, FilePathList.ToList(), uGSSdkHttpRequestCallbackListener);
		if (!num)
		{
			BGW_LogUtil.LogError("http upload file list:" + string.Join(",", FilePathList) + " invalid request to start url:" + url);
			uGSSdkHttpRequestCallbackListener.SafeHandleResponseCallback(-1, Encoding.UTF8.GetBytes("invalid http request"));
		}
		return num;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		LowHzTickCountdown -= DeltaTime;
		if (!(LowHzTickCountdown <= 0f))
		{
			return;
		}
		LowHzTickCountdown = 0.1f;
		for (int num = HttpRequestCallbackListeners.Count - 1; num >= 0; num--)
		{
			UGSSdkHttpRequestCallbackListener uGSSdkHttpRequestCallbackListener = HttpRequestCallbackListeners[num];
			if (uGSSdkHttpRequestCallbackListener != null && !uGSSdkHttpRequestCallbackListener.IsDestroyed && uGSSdkHttpRequestCallbackListener.IsValidLowLevelFast())
			{
				uGSSdkHttpRequestCallbackListener.TimeoutCheck();
				if (uGSSdkHttpRequestCallbackListener.IsCallbackOver)
				{
					HttpRequestCallbackListeners.RemoveAt(num);
				}
			}
			else
			{
				HttpRequestCallbackListeners.RemoveAt(num);
			}
		}
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		HttpRequestCallbackListeners.Clear();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGW_AsyncTaskMgr");
		NativeReflection.GetPropertyRef(ref HttpRequestCallbackListeners_PropertyAddress, unrealStruct, "HttpRequestCallbackListeners");
		HttpRequestCallbackListeners_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HttpRequestCallbackListeners");
		HttpRequestCallbackListeners_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HttpRequestCallbackListeners", Classes.FArrayProperty);
	}

	static BGW_AsyncTaskMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_AsyncTaskMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_AsyncTaskMgr));
	}
}
