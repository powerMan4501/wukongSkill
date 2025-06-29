using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using b1;
using b1.GSFile;
using ICSharpCode.SharpZipLib.Zip;
using UnrealEngine.Runtime;

namespace ResUpdator;

public class GSEPatchUnzipper : IDisposable
{
	private string mPatchpath;

	private string mPatchmd5;

	private string mExtractPath;

	private object mLock = new object();

	private bool mHasError;

	private bool mIsDone;

	private double mProgress;

	private ManualResetEvent mEndingEvent = new ManualResetEvent(initialState: true);

	public static int checkingIdx { get; protected set; }

	public static double gsobbprocess { get; protected set; }

	public static long gsobbfilesize { get; protected set; }

	public void StartSync(string filepath, string filemd5, string extractpath)
	{
		mPatchpath = filepath;
		mPatchmd5 = filemd5;
		mExtractPath = extractpath;
		mIsDone = false;
		mProgress = 0.0;
		mEndingEvent.Reset();
		Proc(this);
	}

	public bool StartGsObbSync(string filepath, string filemd5, string extractpath)
	{
		mPatchpath = filepath;
		mPatchmd5 = filemd5;
		mExtractPath = extractpath;
		mIsDone = false;
		mProgress = 0.0;
		mEndingEvent.Reset();
		return GsObbProc(this);
	}

	public static bool GsObbProc(object state)
	{
		GSEPatchUnzipper gSEPatchUnzipper = (GSEPatchUnzipper)state;
		try
		{
			if (!CheckBigFileMD5(gSEPatchUnzipper.mPatchpath, gSEPatchUnzipper.mPatchmd5))
			{
				gSEPatchUnzipper.SetError();
				gSEPatchUnzipper.mEndingEvent.Set();
				BGW_LogUtil.LogError("CheckFileMD5 error " + gSEPatchUnzipper.mPatchpath);
				return false;
			}
			if (!UnzipFile(gSEPatchUnzipper.mPatchpath, gSEPatchUnzipper.mExtractPath))
			{
				throw new Exception("unzip error " + gSEPatchUnzipper.mPatchpath + " -> " + gSEPatchUnzipper.mExtractPath);
			}
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("patch error " + ex.ToString());
			gSEPatchUnzipper.SetError();
		}
		lock (gSEPatchUnzipper.mLock)
		{
			gSEPatchUnzipper.mIsDone = true;
		}
		gSEPatchUnzipper.mEndingEvent.Set();
		return true;
	}

	public void Start(string filepath, string filemd5, string extractpath)
	{
		mPatchpath = filepath;
		mPatchmd5 = filemd5;
		mExtractPath = extractpath;
		mIsDone = false;
		mProgress = 0.0;
		mEndingEvent.Reset();
		ThreadPool.QueueUserWorkItem(Proc, this);
	}

	public static void Proc(object state)
	{
		GSEPatchUnzipper gSEPatchUnzipper = (GSEPatchUnzipper)state;
		try
		{
			if (!CheckFileMD5(gSEPatchUnzipper.mPatchpath, gSEPatchUnzipper.mPatchmd5))
			{
				gSEPatchUnzipper.SetError();
				gSEPatchUnzipper.mEndingEvent.Set();
				BGW_LogUtil.LogError("CheckFileMD5 error " + gSEPatchUnzipper.mPatchpath);
				return;
			}
			if (!UnzipFile(gSEPatchUnzipper.mPatchpath, gSEPatchUnzipper.mExtractPath))
			{
				throw new Exception("unzip error " + gSEPatchUnzipper.mPatchpath + " -> " + gSEPatchUnzipper.mExtractPath);
			}
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("patch error " + ex.ToString());
			gSEPatchUnzipper.SetError();
		}
		lock (gSEPatchUnzipper.mLock)
		{
			gSEPatchUnzipper.mIsDone = true;
		}
		gSEPatchUnzipper.mEndingEvent.Set();
	}

	public void SetError()
	{
		lock (mLock)
		{
			mHasError = true;
		}
	}

	public bool HasError()
	{
		bool flag = false;
		lock (mLock)
		{
			return mHasError;
		}
	}

	public bool IsDone()
	{
		bool flag = false;
		lock (mLock)
		{
			return mIsDone;
		}
	}

	public static bool CheckFileMD5(string path, string md5str)
	{
		if (md5str.Equals("md5"))
		{
			return true;
		}
		try
		{
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] buffer = File.ReadAllBytes(path);
			byte[] array = mD5CryptoServiceProvider.ComputeHash(buffer);
			buffer = null;
			mD5CryptoServiceProvider.Clear();
			GC.Collect();
			string text = "";
			for (int i = 0; i < array.Length; i++)
			{
				text += array[i].ToString("X").PadLeft(2, '0');
			}
			text = StringParseHelper.SafeToLower(text);
			if (text.Equals(md5str))
			{
				return true;
			}
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError(ex.ToString());
			return false;
		}
		return false;
	}

	public static bool CheckBigFileMD5(string path, string md5str)
	{
		if (md5str.Equals("md5"))
		{
			return true;
		}
		try
		{
			int num = 2097152;
			byte[] array = new byte[num];
			MD5 mD = new MD5CryptoServiceProvider();
			mD.Initialize();
			FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
			long num2 = 0L;
			gsobbfilesize = fileStream.Length;
			while (num2 < fileStream.Length)
			{
				long num3 = num;
				if (num2 + num3 > fileStream.Length)
				{
					num3 = fileStream.Length - num2;
				}
				fileStream.Read(array, 0, Convert.ToInt32(num3));
				if (num2 + num3 < fileStream.Length)
				{
					mD.TransformBlock(array, 0, Convert.ToInt32(num3), array, 0);
				}
				else
				{
					mD.TransformFinalBlock(array, 0, Convert.ToInt32(num3));
				}
				num2 += num;
				gsobbprocess = (double)num2 * 1.0 / (double)fileStream.Length * 100.0;
			}
			fileStream.Close();
			byte[] hash = mD.Hash;
			string text = "";
			for (int i = 0; i < hash.Length; i++)
			{
				text += hash[i].ToString("X").PadLeft(2, '0');
			}
			mD.Clear();
			GC.Collect();
			text = StringParseHelper.SafeToLower(text);
			if (text.Equals(md5str))
			{
				return true;
			}
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError(ex.ToString());
			return false;
		}
		return false;
	}

	public static bool UnzipFile(string filepath, string destpath)
	{
		GSEFileUtil.EnsureFileWritable(destpath);
		using (ZipInputStream zipInputStream = new ZipInputStream(File.OpenRead(filepath)))
		{
			ZipEntry nextEntry;
			while ((nextEntry = zipInputStream.GetNextEntry()) != null)
			{
				string directoryName = Path.GetDirectoryName(nextEntry.Name);
				string fileName = Path.GetFileName(nextEntry.Name);
				if (directoryName.Length > 0)
				{
					Directory.CreateDirectory(GSEFileUtil.CombinePath(destpath, directoryName));
				}
				if (!(fileName != string.Empty))
				{
					continue;
				}
				using FileStream fileStream = File.Create(GSEFileUtil.CombinePath(destpath, nextEntry.Name));
				int num = 2048;
				byte[] array = new byte[2048];
				while (true)
				{
					num = zipInputStream.Read(array, 0, array.Length);
					if (num > 0)
					{
						fileStream.Write(array, 0, num);
						continue;
					}
					break;
				}
			}
		}
		return true;
	}

	public double GetProgress()
	{
		double num = 0.0;
		lock (mLock)
		{
			return mProgress;
		}
	}

	public void Dispose()
	{
		mEndingEvent.WaitOne();
	}
}
