using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using LitJson;

namespace b1.Util;

public static class CDNUtil
{
	public class FileInfoJson
	{
		public class FileInfo
		{
			public string FileName;

			public string RelativePath;

			public ulong FileSize;
		}

		public string LastUpdateTime = "";

		public List<FileInfo> FileList = new List<FileInfo>();
	}

	private static string GetCDNJsonContent(string Url)
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

	public static FileInfoJson GetCDNFileInfo(string Url = "http://gsbasecdn.gs.com/gs_cdn/build/upload/b1_build_size/develop_build_file_size_info.json")
	{
		string text = "";
		try
		{
			text = GetCDNJsonContent(Url);
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("GetCDNFileInfo Fail, Url:" + Url + ", ex:" + ex.ToString());
			return null;
		}
		try
		{
			return JsonMapper.ToObject<FileInfoJson>(text);
		}
		catch (Exception ex2)
		{
			BGW_LogUtil.LogError("Load JsonContent Fail, JsonUrl:" + Url + ", ex:" + ex2.ToString());
			return null;
		}
	}
}
