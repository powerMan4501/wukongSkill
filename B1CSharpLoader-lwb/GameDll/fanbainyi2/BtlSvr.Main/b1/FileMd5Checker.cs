using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using LitJson;
using UnrealEngine.Runtime;

namespace b1;

public static class FileMd5Checker
{
	public class FileMD5InfoIterator
	{
		public class FileMd5InfoJson
		{
			public class FileMd5Info
			{
				public string FileName;

				public string Md5;
			}

			public List<FileMd5Info> FileList = new List<FileMd5Info>();
		}

		private string RootPath;

		public List<Tuple<string, string, string>> InvalidFileList = new List<Tuple<string, string, string>>();

		public List<Tuple<string, string>> RemoteFileList = new List<Tuple<string, string>>();

		public FileMD5InfoIterator(string rootPath)
		{
			RootPath = rootPath;
		}

		public static string GetFileMD5(string filepath)
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

		public void LoadRemoteJsonInfo(string FileMd5JsonStr)
		{
			RemoteFileList.Clear();
			foreach (FileMd5InfoJson.FileMd5Info file in JsonMapper.ToObject<FileMd5InfoJson>(FileMd5JsonStr).FileList)
			{
				RemoteFileList.Add(new Tuple<string, string>(file.FileName, file.Md5));
			}
		}

		public List<Tuple<string, string, string>> CheckFileMd5()
		{
			InvalidFileList.Clear();
			foreach (Tuple<string, string> remoteFile in RemoteFileList)
			{
				string item = remoteFile.Item1;
				string item2 = remoteFile.Item2;
				string text = Path.Combine(RootPath, item);
				if (File.Exists(text))
				{
					string fileMD = GetFileMD5(text);
					if (fileMD != item2)
					{
						InvalidFileList.Add(new Tuple<string, string, string>(item, fileMD, item2));
					}
				}
				else
				{
					InvalidFileList.Add(new Tuple<string, string, string>(text, "file null", item2));
				}
			}
			return InvalidFileList;
		}
	}

	public static void OnDownloadRemoteJson(string FileMd5Json)
	{
		BGW_LogUtil.LogError("FileJson:" + FileMd5Json);
		FileMD5InfoIterator fileMD5InfoIterator = new FileMD5InfoIterator(FPaths.ProjectDir);
		fileMD5InfoIterator.LoadRemoteJsonInfo(FileMd5Json);
		List<Tuple<string, string, string>> list = fileMD5InfoIterator.CheckFileMd5();
		if (list.Count <= 0)
		{
			return;
		}
		string text = "";
		foreach (Tuple<string, string, string> item in list)
		{
			text = text + "FileName:" + item.Item1 + ", LocalMD5:" + item.Item2 + ", RemoteMD5:" + item.Item3 + "\n";
		}
		FMessage.OpenDialog(text, "检测到本地Build文件MD5与P4不一致！");
	}

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

	public static void CheckFileMd5(UObject WorldContext)
	{
		string buildBranch = BGW_LocalDevEnvUtils.GetBuildBranch();
		BGW_AsyncTaskMgr bGW_AsyncTaskMgr = BGW_AsyncTaskMgr.Get(WorldContext);
		string requestUrl = "http://gsbasecdn.gs.com/gs_cdn/build/upload/TempVersionBuild_" + buildBranch + "/FileMD5Check.json";
		bGW_AsyncTaskMgr.HttpFetchJson(requestUrl, PostMethod: false, delegate(int ErrorCode, JsonData JsonResponse, string ErrorMsg)
		{
			if (ErrorCode == 0)
			{
				OnDownloadRemoteJson(JsonResponse.ToJson());
			}
			else
			{
				BGW_LogUtil.LogError($"http fetch version md5 file check fail {ErrorCode} {ErrorMsg}");
			}
		});
	}
}
