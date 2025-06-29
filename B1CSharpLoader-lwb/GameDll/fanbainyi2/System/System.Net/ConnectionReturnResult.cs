using System.Collections.Generic;
using System.Threading;

namespace System.Net;

internal class ConnectionReturnResult
{
	private struct RequestContext
	{
		internal HttpWebRequest Request;

		internal object CoreResponse;

		internal RequestContext(HttpWebRequest request, object coreResponse)
		{
			Request = request;
			CoreResponse = coreResponse;
		}
	}

	private static readonly WaitCallback s_InvokeConnectionCallback = InvokeConnectionCallback;

	private List<RequestContext> m_Context;

	internal bool IsNotEmpty => m_Context.Count != 0;

	internal ConnectionReturnResult()
	{
		m_Context = new List<RequestContext>(5);
	}

	internal ConnectionReturnResult(int capacity)
	{
		m_Context = new List<RequestContext>(capacity);
	}

	internal static void Add(ref ConnectionReturnResult returnResult, HttpWebRequest request, CoreResponseData coreResponseData)
	{
		if (coreResponseData == null)
		{
			throw new InternalException();
		}
		if (returnResult == null)
		{
			returnResult = new ConnectionReturnResult();
		}
		returnResult.m_Context.Add(new RequestContext(request, coreResponseData));
	}

	internal static void AddExceptionRange(ref ConnectionReturnResult returnResult, HttpWebRequest[] requests, Exception exception)
	{
		AddExceptionRange(ref returnResult, requests, 0, exception, exception);
	}

	internal static void AddExceptionRange(ref ConnectionReturnResult returnResult, HttpWebRequest[] requests, int abortedPipelinedRequestIndex, Exception exception, Exception firstRequestException)
	{
		if (exception == null)
		{
			throw new InternalException();
		}
		if (returnResult == null)
		{
			returnResult = new ConnectionReturnResult(requests.Length);
		}
		for (int i = 0; i < requests.Length; i++)
		{
			if (i == abortedPipelinedRequestIndex)
			{
				returnResult.m_Context.Add(new RequestContext(requests[i], firstRequestException));
			}
			else
			{
				returnResult.m_Context.Add(new RequestContext(requests[i], exception));
			}
		}
	}

	internal static void SetResponses(ConnectionReturnResult returnResult)
	{
		if (returnResult == null)
		{
			return;
		}
		for (int i = 0; i < returnResult.m_Context.Count; i++)
		{
			try
			{
				HttpWebRequest request = returnResult.m_Context[i].Request;
				request.SetAndOrProcessResponse(returnResult.m_Context[i].CoreResponse);
			}
			catch (Exception)
			{
				returnResult.m_Context.RemoveRange(0, i + 1);
				if (returnResult.m_Context.Count > 0)
				{
					ThreadPool.UnsafeQueueUserWorkItem(s_InvokeConnectionCallback, returnResult);
				}
				throw;
			}
		}
		returnResult.m_Context.Clear();
	}

	private static void InvokeConnectionCallback(object objectReturnResult)
	{
		ConnectionReturnResult responses = (ConnectionReturnResult)objectReturnResult;
		SetResponses(responses);
	}
}
