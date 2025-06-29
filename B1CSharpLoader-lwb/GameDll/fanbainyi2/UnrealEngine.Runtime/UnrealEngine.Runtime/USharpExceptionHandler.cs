using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace UnrealEngine.Runtime;

public static class USharpExceptionHandler
{
	public delegate void ExceptionHandler(Exception e);

	private class FExceptionHandleInfo
	{
		public ExceptionHandler Handler;

		public bool IsRequireGameThreadExecution;

		public Exception CachedException;

		public void Invoke()
		{
			if (IsRequireGameThreadExecution && CachedException != null)
			{
				Handler(CachedException);
				CachedException = null;
			}
		}

		public void Invoke(Exception e)
		{
			Handler(e);
		}

		public override string ToString()
		{
			return $"Handler.Method: {Handler.Method.Name}, IsRequireGameThreadExecution: {IsRequireGameThreadExecution}";
		}
	}

	private static class AesHelper
	{
		public static string AesEncrypt(string str, string key)
		{
			if (string.IsNullOrEmpty(str))
			{
				return null;
			}
			byte[] bytes = Encoding.UTF8.GetBytes(str);
			return Convert.ToBase64String(new RijndaelManaged
			{
				Key = Encoding.UTF8.GetBytes(key),
				Mode = CipherMode.ECB,
				Padding = PaddingMode.PKCS7
			}.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length));
		}

		public static string AesDecrypt(string str, string key)
		{
			if (string.IsNullOrEmpty(str))
			{
				return null;
			}
			byte[] array = Convert.FromBase64String(str);
			byte[] bytes = new RijndaelManaged
			{
				Key = Encoding.UTF8.GetBytes(key),
				Mode = CipherMode.ECB,
				Padding = PaddingMode.PKCS7
			}.CreateDecryptor().TransformFinalBlock(array, 0, array.Length);
			return Encoding.UTF8.GetString(bytes);
		}
	}

	private static readonly object Locker;

	public static bool IsSentryInitFinish;

	private static readonly Dictionary<EUSharpExceptionType, List<FExceptionHandleInfo>> HandleInfos;

	private static readonly List<FExceptionHandleInfo> CachedGameThreadExecutionHandles;

	static USharpExceptionHandler()
	{
		Locker = new object();
		IsSentryInitFinish = false;
		HandleInfos = new Dictionary<EUSharpExceptionType, List<FExceptionHandleInfo>>();
		CachedGameThreadExecutionHandles = new List<FExceptionHandleInfo>();
		HandleInfos.Add(EUSharpExceptionType.InvokeFunction, new List<FExceptionHandleInfo>
		{
			new FExceptionHandleInfo
			{
				Handler = DefaultInvokeFunctionHandler
			}
		});
		HandleInfos.Add(EUSharpExceptionType.NativeReflectionInvokeFunction, new List<FExceptionHandleInfo>
		{
			new FExceptionHandleInfo
			{
				Handler = DefaultNativeReflectionInvokeFunctionHandler
			}
		});
	}

	public static void OnTick()
	{
		foreach (FExceptionHandleInfo cachedGameThreadExecutionHandle in CachedGameThreadExecutionHandles)
		{
			cachedGameThreadExecutionHandle.Invoke();
		}
		CachedGameThreadExecutionHandles.Clear();
	}

	public static void HandleException(Exception e, EUSharpExceptionType type)
	{
		if (!IsSentryInitFinish)
		{
			throw e;
		}
		lock (Locker)
		{
			CheckAndRemoveInvalidHandler(type);
			if (!HandleInfos.TryGetValue(type, out var value))
			{
				return;
			}
			foreach (FExceptionHandleInfo item in value)
			{
				if (FThreading.IsInGameThread() || !item.IsRequireGameThreadExecution)
				{
					item.Invoke(e);
					continue;
				}
				CachedGameThreadExecutionHandles.Add(item);
				item.CachedException = e;
			}
		}
	}

	public static void AddHandleFunc(ExceptionHandler handler, EUSharpExceptionType type, bool IsMustInGameThread)
	{
		_ = handler.Method.Name;
		_ = handler.Method.DeclaringType.FullName;
		if (HandleInfos.TryGetValue(type, out var value))
		{
			value.Add(new FExceptionHandleInfo
			{
				Handler = handler,
				IsRequireGameThreadExecution = IsMustInGameThread
			});
		}
	}

	public static void RemoveHandleFunc(ExceptionHandler handler, EUSharpExceptionType type)
	{
		_ = handler.Method.Name;
		_ = handler.Method.DeclaringType.FullName;
		if (HandleInfos.TryGetValue(type, out var value))
		{
			value.RemoveAll((FExceptionHandleInfo Info) => Info.Handler == handler);
		}
	}

	private static void CheckAndRemoveInvalidHandler(EUSharpExceptionType type)
	{
		if (FThreading.IsInGameThread() && HandleInfos.TryGetValue(type, out var value))
		{
			value.RemoveAll((FExceptionHandleInfo Info) => Info.Handler.Target is UObject { IsDestroyed: not false });
		}
	}

	private static void DefaultInvokeFunctionHandler(Exception e)
	{
		string message = $"InvokeFunction failed: {e}\r";
		FMessage.Log(ELogVerbosity.Error, message);
		OutputCSharpCallstack(e);
	}

	private static void DefaultNativeReflectionInvokeFunctionHandler(Exception e)
	{
		string message = $"NativeReflectionInvokeFunction failed: {e}\r";
		FMessage.Log(ELogVerbosity.Error, message);
		OutputCSharpCallstack(e);
	}

	private static void OutputCSharpCallstack(Exception e)
	{
		string text = " ------------ C# Callstack ------------ \r";
		StackFrame[] frames = new StackTrace(fNeedFileInfo: true).GetFrames();
		foreach (StackFrame stackFrame in frames)
		{
			text += $"   [Callstack] clr.dll!{stackFrame.GetMethod().DeclaringType?.FullName}::{stackFrame.GetMethod().Name}() [{stackFrame.GetFileName()}:{stackFrame.GetFileLineNumber()}] \r";
		}
		FMessage.Log(ELogVerbosity.Error, text);
	}
}
