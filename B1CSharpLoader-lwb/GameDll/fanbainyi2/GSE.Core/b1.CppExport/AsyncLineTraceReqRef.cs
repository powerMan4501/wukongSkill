using System;
using System.Collections;
using System.Collections.Generic;

namespace b1.CppExport;

public class AsyncLineTraceReqRef : IDisposable, IEnumerable
{
	private IntPtr Ptr;

	public int this[int Index] => GetReqID(Index);

	public AsyncLineTraceReqRef()
	{
		Ptr = AsyncLineTraceReqLib.AsyncLineTraceReqArrayRef_Allocate();
	}

	public AsyncLineTraceReqRef(IntPtr InPtr)
	{
		Ptr = InPtr;
	}

	~AsyncLineTraceReqRef()
	{
		Dispose();
	}

	public void AddReq(FAsyncLineTraceReq Req)
	{
		if (Ptr != IntPtr.Zero)
		{
			AsyncLineTraceReqLib.AsyncLineTraceReqArrayRef_AddReq(Ptr, Req);
		}
	}

	public void Dispose()
	{
		if (Ptr != IntPtr.Zero)
		{
			AsyncLineTraceReqLib.AsyncLineTraceReqArrayRef_Destroy(Ptr);
			Ptr = IntPtr.Zero;
		}
	}

	public IntPtr GetPtr()
	{
		return Ptr;
	}

	public IEnumerator GetEnumerator()
	{
		int TagNum = GetReqNum();
		for (int Index = 0; Index < TagNum; Index++)
		{
			yield return GetReqID(Index);
		}
	}

	public int GetReqNum()
	{
		return AsyncLineTraceReqLib.AsyncLineTraceReqArrayRef_GetReqNum(Ptr);
	}

	public int GetReqID(int Index)
	{
		return AsyncLineTraceReqLib.AsyncLineTraceReqArrayRef_GetReqID(Ptr, Index);
	}

	public List<int> GetAllReqID()
	{
		List<int> list = new List<int>();
		IEnumerator enumerator = GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				int item = (int)enumerator.Current;
				list.Add(item);
			}
			return list;
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
	}
}
