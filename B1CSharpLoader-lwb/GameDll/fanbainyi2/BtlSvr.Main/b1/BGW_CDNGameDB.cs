using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using b1.GSFile;
using UnrealEngine.Runtime;

namespace b1;

public static class BGW_CDNGameDB
{
	public class FileInfoJson
	{
		public class FileInfo
		{
			public string FileName;

			public string RelativePath;

			public string FileMd5;
		}

		public string LastUpdateTime = "";

		public string LastUpdateVersion = "";

		public List<FileInfo> FileList = new List<FileInfo>();
	}

	public enum CDNRequestResult
	{
		Success,
		NotFound,
		ConnectFailure,
		Unknow
	}

	public static string CDNGameDBLocalPath => Path.Combine(GSEFileUtil.ProjectPersistentDownloadDir, "CDNPBTable");

	public static string GetJson(string Url)
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

	private static string GetFileMD5(string filepath)
	{
		if (!File.Exists(filepath))
		{
			return "";
		}
		try
		{
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] buffer = File.ReadAllBytes(filepath);
			byte[] array = mD5CryptoServiceProvider.ComputeHash(buffer);
			buffer = null;
			mD5CryptoServiceProvider.Clear();
			string text = "";
			for (int i = 0; i < array.Length; i++)
			{
				text += array[i].ToString("X").PadLeft(2, '0');
			}
			return StringParseHelper.SafeToLower(text);
		}
		catch (Exception)
		{
			return "";
		}
	}

	public static CDNRequestResult CheckCDNProtoEncryptTokenFile()
	{
		string cDNProtoCryptTokenUrl = BGW_CDNUrlConfig.CDNProtoCryptTokenUrl;
		try
		{
			HttpWebRequest obj = (HttpWebRequest)WebRequest.Create(cDNProtoCryptTokenUrl);
			obj.Method = "HEAD";
			obj.Timeout = 10000;
			using HttpWebResponse httpWebResponse = (HttpWebResponse)obj.GetResponse();
			if (httpWebResponse.StatusCode == HttpStatusCode.OK)
			{
				return CDNRequestResult.Success;
			}
			BGW_LogUtil.LogError("发生错误，HTTP 状态码: " + httpWebResponse.StatusCode);
			return CDNRequestResult.Unknow;
		}
		catch (WebException ex)
		{
			if (ex.Response is HttpWebResponse { StatusCode: HttpStatusCode.NotFound })
			{
				return CDNRequestResult.NotFound;
			}
			BGW_LogUtil.LogError("发生异常：" + ex.Message);
			return CDNRequestResult.ConnectFailure;
		}
		catch (Exception ex2)
		{
			BGW_LogUtil.LogError("发生异常：" + ex2.Message);
			return CDNRequestResult.Unknow;
		}
	}
}
