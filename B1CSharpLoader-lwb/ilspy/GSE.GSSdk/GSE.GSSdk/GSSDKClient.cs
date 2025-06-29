using System;
using System.Text;
using Google.Protobuf;
using GSE.OnlineBase;
using LitJson;

namespace GSE.GSSdk;

public class GSSDKClient
{
	private HttpRequestDelegate HttpPostProxy;

	private string UrlVerQuery = "?Ver=" + DateTime.Now.ToString("mmddHHMMSS");

	private static string[] JsonHeaders = new string[1] { "Content-Type: application/json" };

	private bool useEnctypt = true;

	public GSSDKClient(HttpRequestDelegate post_delegate = null)
	{
		HttpPostProxy = post_delegate;
	}

	public int CallJsonService<ReqT, RepT>(string Service, string Method, ReqT JsonReq, OnJsonResponse<RepT> onResponse, int reqTimeoutSecond = 10)
	{
		string s = JsonMapper.ToJson(JsonReq);
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		return CallService(Service, Method, bytes, bIsPb: false, OnRep, reqTimeoutSecond);
		void OnRep(int code, string msg, byte[] data)
		{
			if (Service != "Report")
			{
				GSSDKReport.MonitorAdd(MonEvtCatogray.GSSDK, "ErrCode", 1L, "service={0},method={1},code={2}", Service, Method, code);
			}
			if (code == 200 || code == 0)
			{
				RepT retObj = default(RepT);
				if (data != null && data.Length != 0)
				{
					retObj = JsonMapper.ToObject<RepT>(new JsonReader(Encoding.UTF8.GetString(data)));
				}
				onResponse(code, msg, retObj);
			}
			else
			{
				onResponse(code, msg, default(RepT));
			}
		}
	}

	public int CallJsonVoidService<ReqT>(string Service, string Method, ReqT JsonReq, int reqTimeoutSecond = 10)
	{
		string s = JsonMapper.ToJson(JsonReq);
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		return CallService(Service, Method, bytes, bIsPb: false, null, reqTimeoutSecond);
	}

	public int CallProtobufService<ReqT, RspT>(string Service, string Method, ReqT oReq, OnProtobufResponse<RspT> onResponse = null, int reqTimeoutSecond = 10) where ReqT : IMessage, new() where RspT : IMessage, new()
	{
		byte[] bytesReq = PbEncoding.Encode(oReq);
		if (onResponse == null)
		{
			return CallService(Service, Method, bytesReq, bIsPb: true, null, reqTimeoutSecond);
		}
		OnBytesResponse onResponse2 = delegate(int code, string errorMsg, byte[] data)
		{
			if (code == 0 && data != null && data.Length != 0)
			{
				RspT retObj = PbEncoding.Decode<RspT>(data);
				onResponse(0, errorMsg, retObj);
			}
			else
			{
				onResponse(code, errorMsg, default(RspT));
			}
		};
		return CallService(Service, Method, bytesReq, bIsPb: true, onResponse2, reqTimeoutSecond);
	}

	public int CallProtobufVoidService<ReqT>(string Service, string Method, ReqT oReq, int reqTimeoutSecond = 10) where ReqT : IMessage, new()
	{
		byte[] bytesReq = PbEncoding.Encode(oReq);
		return CallService(Service, Method, bytesReq, bIsPb: true, null, reqTimeoutSecond);
	}

	public int CallService(string Service, string Method, byte[] BytesReq, bool bIsPb = false, OnBytesResponse onResponse = null, int reqTimeoutSecond = 10)
	{
		string text = GSSDKEnv.GetServiceUrl(Service, Method) + UrlVerQuery;
		string[] headers = JsonHeaders;
		if (bIsPb)
		{
			headers = null;
			text += "&encoding=pb3";
		}
		HttpResponseFinishNotify onRspNotify = null;
		if (onResponse != null)
		{
			onRspNotify = delegate(int code, byte[] data)
			{
				if (Service != "Report")
				{
					GSSDKReport.MonitorAdd(MonEvtCatogray.GSSDK, "ErrCode", 1L, "service={0},method={1},code={2}", Service, Method, code);
				}
				if (code == 200 || code == 0)
				{
					onResponse(0, "SUCESS", data);
				}
				else
				{
					onResponse(code, (data != null && data.Length != 0) ? Encoding.UTF8.GetString(data) : "null", null);
					LogHelper.LogWarn($"gssdk service={Service} method return code:{code} will switch to next host");
					GSSDKEnv.SwitchNextEnvSdkHost();
				}
			};
		}
		if (useEnctypt && Service == "Report")
		{
			text += $"&encrypt={1}";
			return (!HttpPostProxy(text, "POST", headers, PbEncryptSim(BytesReq), onRspNotify, reqTimeoutSecond)) ? 1 : 0;
		}
		return (!HttpPostProxy(text, "POST", headers, BytesReq, onRspNotify, reqTimeoutSecond)) ? 1 : 0;
	}

	public static byte[] PbEncryptSim(byte[] src)
	{
		string s = "gamesci";
		byte[] bytes = Encoding.Default.GetBytes(s);
		int num = src.Length;
		int num2 = bytes.Length;
		byte[] array = new byte[num];
		for (int i = 0; i <= num / num2; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				if (i * num2 + j < num)
				{
					array[i * num2 + j] = (byte)(src[i * num2 + j] ^ bytes[j]);
				}
			}
		}
		return array;
	}
}
