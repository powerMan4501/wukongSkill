using System;
using System.IO;
using System.Net;
using System.Text;

namespace b1;

public static class BGW_CDNGlobalConfig
{
	private static string _CDNGlobalConfigJson;

	public static string GlobalConfigJson
	{
		get
		{
			if (_CDNGlobalConfigJson == null)
			{
				ReloadCDNGlobalConfig();
			}
			return _CDNGlobalConfigJson;
		}
	}

	public static string GetJsonByUrl(string Url)
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Url);
			httpWebRequest.KeepAlive = false;
			httpWebRequest.Method = "GET";
			httpWebRequest.ContentType = "application/json; charset=UTF-8";
			httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip;
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Stream responseStream = httpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
			string result = streamReader.ReadToEnd();
			streamReader.Close();
			responseStream.Close();
			httpWebResponse?.Close();
			httpWebRequest?.Abort();
			return result;
		}
		catch (Exception arg)
		{
			BGW_LogUtil.LogError($"Request:{Url} Fail, Ex:{arg}");
			return "";
		}
	}

	private static void ReloadCDNGlobalConfig()
	{
		_CDNGlobalConfigJson = GetJsonByUrl(BGW_CDNUrlConfig.CDNConfigUrl);
	}
}
