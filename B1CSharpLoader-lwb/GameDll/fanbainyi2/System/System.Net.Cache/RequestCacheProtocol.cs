using System.Globalization;
using System.IO;
using System.Threading;

namespace System.Net.Cache;

internal class RequestCacheProtocol
{
	private CacheValidationStatus _ProtocolStatus;

	private Exception _ProtocolException;

	private Stream _ResponseStream;

	private long _ResponseStreamLength;

	private RequestCacheValidator _Validator;

	private RequestCache _RequestCache;

	private bool _IsCacheFresh;

	private bool _CanTakeNewRequest;

	internal CacheValidationStatus ProtocolStatus => _ProtocolStatus;

	internal Exception ProtocolException => _ProtocolException;

	internal Stream ResponseStream => _ResponseStream;

	internal long ResponseStreamLength => _ResponseStreamLength;

	internal RequestCacheValidator Validator => _Validator;

	internal bool IsCacheFresh
	{
		get
		{
			if (_Validator != null)
			{
				return _Validator.CacheFreshnessStatus == CacheFreshnessStatus.Fresh;
			}
			return false;
		}
	}

	internal RequestCacheProtocol(RequestCache cache, RequestCacheValidator defaultValidator)
	{
		_RequestCache = cache;
		_Validator = defaultValidator;
		_CanTakeNewRequest = true;
	}

	internal CacheValidationStatus GetRetrieveStatus(Uri cacheUri, WebRequest request)
	{
		if (cacheUri == null)
		{
			throw new ArgumentNullException("cacheUri");
		}
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (!_CanTakeNewRequest || _ProtocolStatus == CacheValidationStatus.RetryResponseFromServer)
		{
			return CacheValidationStatus.Continue;
		}
		_CanTakeNewRequest = false;
		_ResponseStream = null;
		_ResponseStreamLength = 0L;
		_ProtocolStatus = CacheValidationStatus.Continue;
		_ProtocolException = null;
		if (Logging.On)
		{
			Logging.Enter(Logging.RequestCache, this, "GetRetrieveStatus", request);
		}
		try
		{
			if (request.CachePolicy == null || request.CachePolicy.Level == RequestCacheLevel.BypassCache)
			{
				_ProtocolStatus = CacheValidationStatus.DoNotUseCache;
				return _ProtocolStatus;
			}
			if (_RequestCache == null || _Validator == null)
			{
				_ProtocolStatus = CacheValidationStatus.DoNotUseCache;
				return _ProtocolStatus;
			}
			_Validator.FetchRequest(cacheUri, request);
			switch (_ProtocolStatus = ValidateRequest())
			{
			case CacheValidationStatus.Fail:
				_ProtocolException = new InvalidOperationException(SR.GetString("net_cache_validator_fail", "ValidateRequest"));
				break;
			default:
				_ProtocolStatus = CacheValidationStatus.Fail;
				_ProtocolException = new InvalidOperationException(SR.GetString("net_cache_validator_result", "ValidateRequest", _Validator.ValidationStatus.ToString()));
				if (Logging.On)
				{
					Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_unexpected_status", "ValidateRequest()", _Validator.ValidationStatus.ToString()));
				}
				break;
			case CacheValidationStatus.DoNotUseCache:
			case CacheValidationStatus.DoNotTakeFromCache:
			case CacheValidationStatus.Continue:
				break;
			}
			if (_ProtocolStatus != CacheValidationStatus.Continue)
			{
				return _ProtocolStatus;
			}
			CheckRetrieveBeforeSubmit();
		}
		catch (Exception protocolException)
		{
			Exception ex = (_ProtocolException = protocolException);
			_ProtocolStatus = CacheValidationStatus.Fail;
			if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
			{
				throw;
			}
			if (Logging.On)
			{
				Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_object_and_exception", "CacheProtocol#" + GetHashCode().ToString(NumberFormatInfo.InvariantInfo), (ex is WebException) ? ex.Message : ex.ToString()));
			}
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.RequestCache, this, "GetRetrieveStatus", "result = " + _ProtocolStatus);
			}
		}
		return _ProtocolStatus;
	}

	internal CacheValidationStatus GetRevalidateStatus(WebResponse response, Stream responseStream)
	{
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		if (_ProtocolStatus == CacheValidationStatus.DoNotUseCache)
		{
			return CacheValidationStatus.DoNotUseCache;
		}
		if (_ProtocolStatus == CacheValidationStatus.ReturnCachedResponse)
		{
			_ProtocolStatus = CacheValidationStatus.DoNotUseCache;
			return _ProtocolStatus;
		}
		try
		{
			if (Logging.On)
			{
				Logging.Enter(Logging.RequestCache, this, "GetRevalidateStatus", (_Validator == null) ? null : _Validator.Request);
			}
			_Validator.FetchResponse(response);
			if (_ProtocolStatus != CacheValidationStatus.Continue && _ProtocolStatus != CacheValidationStatus.RetryResponseFromServer)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_revalidation_not_needed", "GetRevalidateStatus()"));
				}
				return _ProtocolStatus;
			}
			CheckRetrieveOnResponse(responseStream);
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.RequestCache, this, "GetRevalidateStatus", "result = " + _ProtocolStatus);
			}
		}
		return _ProtocolStatus;
	}

	internal CacheValidationStatus GetUpdateStatus(WebResponse response, Stream responseStream)
	{
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		if (_ProtocolStatus == CacheValidationStatus.DoNotUseCache)
		{
			return CacheValidationStatus.DoNotUseCache;
		}
		try
		{
			if (Logging.On)
			{
				Logging.Enter(Logging.RequestCache, this, "GetUpdateStatus", null);
			}
			if (_Validator.Response == null)
			{
				_Validator.FetchResponse(response);
			}
			if (_ProtocolStatus == CacheValidationStatus.RemoveFromCache)
			{
				EnsureCacheRemoval(_Validator.CacheKey);
				return _ProtocolStatus;
			}
			if (_ProtocolStatus != CacheValidationStatus.DoNotTakeFromCache && _ProtocolStatus != CacheValidationStatus.ReturnCachedResponse && _ProtocolStatus != CacheValidationStatus.CombineCachedAndServerResponse)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_not_updated_based_on_cache_protocol_status", "GetUpdateStatus()", _ProtocolStatus.ToString()));
				}
				return _ProtocolStatus;
			}
			CheckUpdateOnResponse(responseStream);
		}
		catch (Exception protocolException)
		{
			Exception ex = (_ProtocolException = protocolException);
			_ProtocolStatus = CacheValidationStatus.Fail;
			if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
			{
				throw;
			}
			if (Logging.On)
			{
				Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_object_and_exception", "CacheProtocol#" + GetHashCode().ToString(NumberFormatInfo.InvariantInfo), (ex is WebException) ? ex.Message : ex.ToString()));
			}
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.RequestCache, this, "GetUpdateStatus", "result = " + _ProtocolStatus);
			}
		}
		return _ProtocolStatus;
	}

	internal void Reset()
	{
		_CanTakeNewRequest = true;
	}

	internal void Abort()
	{
		if (_CanTakeNewRequest)
		{
			return;
		}
		Stream responseStream = _ResponseStream;
		if (responseStream != null)
		{
			try
			{
				if (Logging.On)
				{
					Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_closing_cache_stream", "CacheProtocol#" + GetHashCode().ToString(NumberFormatInfo.InvariantInfo), "Abort()", responseStream.GetType().FullName, _Validator.CacheKey));
				}
				if (responseStream is ICloseEx closeEx)
				{
					closeEx.CloseEx(CloseExState.Abort | CloseExState.Silent);
				}
				else
				{
					responseStream.Close();
				}
			}
			catch (Exception ex)
			{
				if (NclUtilities.IsFatal(ex))
				{
					throw;
				}
				if (Logging.On)
				{
					Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_exception_ignored", "CacheProtocol#" + GetHashCode().ToString(NumberFormatInfo.InvariantInfo), "stream.Close()", ex.ToString()));
				}
			}
		}
		Reset();
	}

	private void CheckRetrieveBeforeSubmit()
	{
		try
		{
			while (true)
			{
				if (_Validator.CacheStream != null && _Validator.CacheStream != Stream.Null)
				{
					_Validator.CacheStream.Close();
					_Validator.CacheStream = Stream.Null;
				}
				RequestCacheEntry cacheEntry;
				if (_Validator.StrictCacheErrors)
				{
					_Validator.CacheStream = _RequestCache.Retrieve(_Validator.CacheKey, out cacheEntry);
				}
				else
				{
					_RequestCache.TryRetrieve(_Validator.CacheKey, out cacheEntry, out var readStream);
					_Validator.CacheStream = readStream;
				}
				if (cacheEntry == null)
				{
					cacheEntry = new RequestCacheEntry();
					cacheEntry.IsPrivateEntry = _RequestCache.IsPrivateCache;
					_Validator.FetchCacheEntry(cacheEntry);
				}
				if (_Validator.CacheStream == null)
				{
					_Validator.CacheStream = Stream.Null;
				}
				ValidateFreshness(cacheEntry);
				_ProtocolStatus = ValidateCache();
				switch (_ProtocolStatus)
				{
				case CacheValidationStatus.RetryResponseFromCache:
					break;
				case CacheValidationStatus.ReturnCachedResponse:
				{
					if (_Validator.CacheStream == null || _Validator.CacheStream == Stream.Null)
					{
						if (Logging.On)
						{
							Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_no_cache_entry", "ValidateCache()"));
						}
						_ProtocolStatus = CacheValidationStatus.Fail;
						_ProtocolException = new InvalidOperationException(SR.GetString("net_cache_no_stream", _Validator.CacheKey));
						return;
					}
					Stream stream = _Validator.CacheStream;
					_RequestCache.UnlockEntry(_Validator.CacheStream);
					if (_Validator.CacheStreamOffset != 0L || _Validator.CacheStreamLength != _Validator.CacheEntry.StreamSize)
					{
						stream = new RangeStream(stream, _Validator.CacheStreamOffset, _Validator.CacheStreamLength);
						if (Logging.On)
						{
							Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_returned_range_cache", "ValidateCache()", _Validator.CacheStreamOffset, _Validator.CacheStreamLength));
						}
					}
					_ResponseStream = stream;
					_ResponseStreamLength = _Validator.CacheStreamLength;
					return;
				}
				case CacheValidationStatus.Continue:
					_ResponseStream = _Validator.CacheStream;
					return;
				case CacheValidationStatus.Fail:
					_ProtocolException = new InvalidOperationException(SR.GetString("net_cache_validator_fail", "ValidateCache"));
					return;
				default:
					_ProtocolStatus = CacheValidationStatus.Fail;
					_ProtocolException = new InvalidOperationException(SR.GetString("net_cache_validator_result", "ValidateCache", _Validator.ValidationStatus.ToString()));
					if (Logging.On)
					{
						Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_unexpected_status", "ValidateCache()", _Validator.ValidationStatus.ToString()));
					}
					return;
				case CacheValidationStatus.DoNotUseCache:
				case CacheValidationStatus.DoNotTakeFromCache:
					return;
				}
			}
		}
		catch (Exception ex)
		{
			_ProtocolStatus = CacheValidationStatus.Fail;
			_ProtocolException = ex;
			if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
			{
				throw;
			}
			if (Logging.On)
			{
				Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_object_and_exception", "CacheProtocol#" + GetHashCode().ToString(NumberFormatInfo.InvariantInfo), (ex is WebException) ? ex.Message : ex.ToString()));
			}
		}
		finally
		{
			if (_ResponseStream == null && _Validator.CacheStream != null && _Validator.CacheStream != Stream.Null)
			{
				_Validator.CacheStream.Close();
				_Validator.CacheStream = Stream.Null;
			}
		}
	}

	private void CheckRetrieveOnResponse(Stream responseStream)
	{
		bool flag = true;
		try
		{
			switch (_ProtocolStatus = ValidateResponse())
			{
			case CacheValidationStatus.Continue:
				flag = false;
				break;
			case CacheValidationStatus.RetryResponseFromServer:
				flag = false;
				break;
			case CacheValidationStatus.Fail:
				_ProtocolStatus = CacheValidationStatus.Fail;
				_ProtocolException = new InvalidOperationException(SR.GetString("net_cache_validator_fail", "ValidateResponse"));
				break;
			default:
				_ProtocolStatus = CacheValidationStatus.Fail;
				_ProtocolException = new InvalidOperationException(SR.GetString("net_cache_validator_result", "ValidateResponse", _Validator.ValidationStatus.ToString()));
				if (Logging.On)
				{
					Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_unexpected_status", "ValidateResponse()", _Validator.ValidationStatus.ToString()));
				}
				break;
			case CacheValidationStatus.DoNotUseCache:
				break;
			}
		}
		catch (Exception ex)
		{
			flag = true;
			_ProtocolException = ex;
			_ProtocolStatus = CacheValidationStatus.Fail;
			if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
			{
				throw;
			}
			if (Logging.On)
			{
				Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_object_and_exception", "CacheProtocol#" + GetHashCode().ToString(NumberFormatInfo.InvariantInfo), (ex is WebException) ? ex.Message : ex.ToString()));
			}
		}
		finally
		{
			if (flag && _ResponseStream != null)
			{
				_ResponseStream.Close();
				_ResponseStream = null;
				_Validator.CacheStream = Stream.Null;
			}
		}
		if (_ProtocolStatus != CacheValidationStatus.Continue)
		{
			return;
		}
		try
		{
			switch (_ProtocolStatus = RevalidateCache())
			{
			case CacheValidationStatus.DoNotUseCache:
			case CacheValidationStatus.DoNotTakeFromCache:
			case CacheValidationStatus.RemoveFromCache:
				flag = true;
				break;
			case CacheValidationStatus.ReturnCachedResponse:
			{
				if (_Validator.CacheStream == null || _Validator.CacheStream == Stream.Null)
				{
					_ProtocolStatus = CacheValidationStatus.Fail;
					_ProtocolException = new InvalidOperationException(SR.GetString("net_cache_no_stream", _Validator.CacheKey));
					if (Logging.On)
					{
						Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_null_cached_stream", "RevalidateCache()"));
					}
					break;
				}
				Stream responseStream2 = _Validator.CacheStream;
				if (_Validator.CacheStreamOffset != 0L || _Validator.CacheStreamLength != _Validator.CacheEntry.StreamSize)
				{
					responseStream2 = new RangeStream(responseStream2, _Validator.CacheStreamOffset, _Validator.CacheStreamLength);
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_returned_range_cache", "RevalidateCache()", _Validator.CacheStreamOffset, _Validator.CacheStreamLength));
					}
				}
				_ResponseStream = responseStream2;
				_ResponseStreamLength = _Validator.CacheStreamLength;
				break;
			}
			case CacheValidationStatus.CombineCachedAndServerResponse:
				if (_Validator.CacheStream == null || _Validator.CacheStream == Stream.Null)
				{
					_ProtocolStatus = CacheValidationStatus.Fail;
					_ProtocolException = new InvalidOperationException(SR.GetString("net_cache_no_stream", _Validator.CacheKey));
					if (Logging.On)
					{
						Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_requested_combined_but_null_cached_stream", "RevalidateCache()"));
					}
				}
				else
				{
					Stream responseStream2 = ((responseStream == null) ? _Validator.CacheStream : new CombinedReadStream(_Validator.CacheStream, responseStream));
					_ResponseStream = responseStream2;
					_ResponseStreamLength = _Validator.CacheStreamLength;
				}
				break;
			case CacheValidationStatus.Fail:
				flag = true;
				_ProtocolException = new InvalidOperationException(SR.GetString("net_cache_validator_fail", "RevalidateCache"));
				break;
			default:
				flag = true;
				_ProtocolStatus = CacheValidationStatus.Fail;
				_ProtocolException = new InvalidOperationException(SR.GetString("net_cache_validator_result", "RevalidateCache", _Validator.ValidationStatus.ToString()));
				if (Logging.On)
				{
					Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_unexpected_status", "RevalidateCache()", _Validator.ValidationStatus.ToString()));
				}
				break;
			}
		}
		catch (Exception ex2)
		{
			flag = true;
			_ProtocolException = ex2;
			_ProtocolStatus = CacheValidationStatus.Fail;
			if (ex2 is ThreadAbortException || ex2 is StackOverflowException || ex2 is OutOfMemoryException)
			{
				throw;
			}
			if (Logging.On)
			{
				Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_object_and_exception", "CacheProtocol#" + GetHashCode().ToString(NumberFormatInfo.InvariantInfo), (ex2 is WebException) ? ex2.Message : ex2.ToString()));
			}
		}
		finally
		{
			if (flag && _ResponseStream != null)
			{
				_ResponseStream.Close();
				_ResponseStream = null;
				_Validator.CacheStream = Stream.Null;
			}
		}
	}

	private void CheckUpdateOnResponse(Stream responseStream)
	{
		if (_Validator.CacheEntry == null)
		{
			RequestCacheEntry requestCacheEntry = new RequestCacheEntry();
			requestCacheEntry.IsPrivateEntry = _RequestCache.IsPrivateCache;
			_Validator.FetchCacheEntry(requestCacheEntry);
		}
		string cacheKey = _Validator.CacheKey;
		bool flag = true;
		try
		{
			switch (_ProtocolStatus = UpdateCache())
			{
			case CacheValidationStatus.RemoveFromCache:
				EnsureCacheRemoval(cacheKey);
				flag = false;
				break;
			case CacheValidationStatus.UpdateResponseInformation:
				_ResponseStream = new MetadataUpdateStream(responseStream, _RequestCache, _Validator.CacheKey, _Validator.CacheEntry.ExpiresUtc, _Validator.CacheEntry.LastModifiedUtc, _Validator.CacheEntry.LastSynchronizedUtc, _Validator.CacheEntry.MaxStale, _Validator.CacheEntry.EntryMetadata, _Validator.CacheEntry.SystemMetadata, _Validator.StrictCacheErrors);
				flag = false;
				_ProtocolStatus = CacheValidationStatus.UpdateResponseInformation;
				break;
			case CacheValidationStatus.CacheResponse:
			{
				Stream writeStream;
				if (_Validator.StrictCacheErrors)
				{
					writeStream = _RequestCache.Store(_Validator.CacheKey, _Validator.CacheEntry.StreamSize, _Validator.CacheEntry.ExpiresUtc, _Validator.CacheEntry.LastModifiedUtc, _Validator.CacheEntry.MaxStale, _Validator.CacheEntry.EntryMetadata, _Validator.CacheEntry.SystemMetadata);
				}
				else
				{
					_RequestCache.TryStore(_Validator.CacheKey, _Validator.CacheEntry.StreamSize, _Validator.CacheEntry.ExpiresUtc, _Validator.CacheEntry.LastModifiedUtc, _Validator.CacheEntry.MaxStale, _Validator.CacheEntry.EntryMetadata, _Validator.CacheEntry.SystemMetadata, out writeStream);
				}
				if (writeStream == null)
				{
					_ProtocolStatus = CacheValidationStatus.DoNotUpdateCache;
					break;
				}
				_ResponseStream = new ForwardingReadStream(responseStream, writeStream, _Validator.CacheStreamOffset, _Validator.StrictCacheErrors);
				_ProtocolStatus = CacheValidationStatus.UpdateResponseInformation;
				break;
			}
			case CacheValidationStatus.Fail:
				_ProtocolException = new InvalidOperationException(SR.GetString("net_cache_validator_fail", "UpdateCache"));
				break;
			default:
				_ProtocolStatus = CacheValidationStatus.Fail;
				_ProtocolException = new InvalidOperationException(SR.GetString("net_cache_validator_result", "UpdateCache", _Validator.ValidationStatus.ToString()));
				if (Logging.On)
				{
					Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_unexpected_status", "UpdateCache()", _Validator.ValidationStatus.ToString()));
				}
				break;
			case CacheValidationStatus.DoNotUseCache:
			case CacheValidationStatus.DoNotUpdateCache:
				break;
			}
		}
		finally
		{
			if (flag)
			{
				_RequestCache.UnlockEntry(_Validator.CacheStream);
			}
		}
	}

	private CacheValidationStatus ValidateRequest()
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.RequestCache, "Request#" + _Validator.Request.GetHashCode().ToString(NumberFormatInfo.InvariantInfo) + ", Policy = " + _Validator.Request.CachePolicy.ToString() + ", Cache Uri = " + _Validator.Uri);
		}
		CacheValidationStatus cacheValidationStatus = _Validator.ValidateRequest();
		_Validator.SetValidationStatus(cacheValidationStatus);
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.RequestCache, "Selected cache Key = " + _Validator.CacheKey);
		}
		return cacheValidationStatus;
	}

	private void ValidateFreshness(RequestCacheEntry fetchEntry)
	{
		_Validator.FetchCacheEntry(fetchEntry);
		if (_Validator.CacheStream == null || _Validator.CacheStream == Stream.Null)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_entry_not_found_freshness_undefined", "ValidateFreshness()"));
			}
			_Validator.SetFreshnessStatus(CacheFreshnessStatus.Undefined);
			return;
		}
		if (Logging.On && Logging.IsVerbose(Logging.RequestCache))
		{
			Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_dumping_cache_context"));
			if (fetchEntry == null)
			{
				Logging.PrintInfo(Logging.RequestCache, "<null>");
			}
			else
			{
				string[] array = fetchEntry.ToString(Logging.IsVerbose(Logging.RequestCache)).Split(RequestCache.LineSplits);
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Length != 0)
					{
						Logging.PrintInfo(Logging.RequestCache, array[i]);
					}
				}
			}
		}
		CacheFreshnessStatus cacheFreshnessStatus = _Validator.ValidateFreshness();
		_Validator.SetFreshnessStatus(cacheFreshnessStatus);
		_IsCacheFresh = cacheFreshnessStatus == CacheFreshnessStatus.Fresh;
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_result", "ValidateFreshness()", cacheFreshnessStatus.ToString()));
		}
	}

	private CacheValidationStatus ValidateCache()
	{
		CacheValidationStatus cacheValidationStatus = _Validator.ValidateCache();
		_Validator.SetValidationStatus(cacheValidationStatus);
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_result", "ValidateCache()", cacheValidationStatus.ToString()));
		}
		return cacheValidationStatus;
	}

	private CacheValidationStatus RevalidateCache()
	{
		CacheValidationStatus cacheValidationStatus = _Validator.RevalidateCache();
		_Validator.SetValidationStatus(cacheValidationStatus);
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_result", "RevalidateCache()", cacheValidationStatus.ToString()));
		}
		return cacheValidationStatus;
	}

	private CacheValidationStatus ValidateResponse()
	{
		CacheValidationStatus cacheValidationStatus = _Validator.ValidateResponse();
		_Validator.SetValidationStatus(cacheValidationStatus);
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_result", "ValidateResponse()", cacheValidationStatus.ToString()));
		}
		return cacheValidationStatus;
	}

	private CacheValidationStatus UpdateCache()
	{
		CacheValidationStatus cacheValidationStatus = _Validator.UpdateCache();
		_Validator.SetValidationStatus(cacheValidationStatus);
		return cacheValidationStatus;
	}

	private void EnsureCacheRemoval(string retrieveKey)
	{
		_RequestCache.UnlockEntry(_Validator.CacheStream);
		if (_Validator.StrictCacheErrors)
		{
			_RequestCache.Remove(retrieveKey);
		}
		else
		{
			_RequestCache.TryRemove(retrieveKey);
		}
		if (retrieveKey != _Validator.CacheKey)
		{
			if (_Validator.StrictCacheErrors)
			{
				_RequestCache.Remove(_Validator.CacheKey);
			}
			else
			{
				_RequestCache.TryRemove(_Validator.CacheKey);
			}
		}
	}
}
