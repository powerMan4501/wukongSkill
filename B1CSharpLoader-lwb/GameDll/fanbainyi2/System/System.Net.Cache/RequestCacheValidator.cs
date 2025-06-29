using System.IO;

namespace System.Net.Cache;

internal abstract class RequestCacheValidator
{
	internal WebRequest _Request;

	internal WebResponse _Response;

	internal Stream _CacheStream;

	private RequestCachePolicy _Policy;

	private Uri _Uri;

	private string _CacheKey;

	private RequestCacheEntry _CacheEntry;

	private int _ResponseCount;

	private CacheValidationStatus _ValidationStatus;

	private CacheFreshnessStatus _CacheFreshnessStatus;

	private long _CacheStreamOffset;

	private long _CacheStreamLength;

	private bool _StrictCacheErrors;

	private TimeSpan _UnspecifiedMaxAge;

	internal bool StrictCacheErrors => _StrictCacheErrors;

	internal TimeSpan UnspecifiedMaxAge => _UnspecifiedMaxAge;

	protected internal Uri Uri => _Uri;

	protected internal WebRequest Request => _Request;

	protected internal WebResponse Response => _Response;

	protected internal RequestCachePolicy Policy => _Policy;

	protected internal int ResponseCount => _ResponseCount;

	protected internal CacheValidationStatus ValidationStatus => _ValidationStatus;

	protected internal CacheFreshnessStatus CacheFreshnessStatus => _CacheFreshnessStatus;

	protected internal RequestCacheEntry CacheEntry => _CacheEntry;

	protected internal Stream CacheStream
	{
		get
		{
			return _CacheStream;
		}
		set
		{
			_CacheStream = value;
		}
	}

	protected internal long CacheStreamOffset
	{
		get
		{
			return _CacheStreamOffset;
		}
		set
		{
			_CacheStreamOffset = value;
		}
	}

	protected internal long CacheStreamLength
	{
		get
		{
			return _CacheStreamLength;
		}
		set
		{
			_CacheStreamLength = value;
		}
	}

	protected internal string CacheKey => _CacheKey;

	internal abstract RequestCacheValidator CreateValidator();

	protected RequestCacheValidator(bool strictCacheErrors, TimeSpan unspecifiedMaxAge)
	{
		_StrictCacheErrors = strictCacheErrors;
		_UnspecifiedMaxAge = unspecifiedMaxAge;
		_ValidationStatus = CacheValidationStatus.DoNotUseCache;
		_CacheFreshnessStatus = CacheFreshnessStatus.Undefined;
	}

	protected internal abstract CacheValidationStatus ValidateRequest();

	protected internal abstract CacheFreshnessStatus ValidateFreshness();

	protected internal abstract CacheValidationStatus ValidateCache();

	protected internal abstract CacheValidationStatus ValidateResponse();

	protected internal abstract CacheValidationStatus RevalidateCache();

	protected internal abstract CacheValidationStatus UpdateCache();

	protected internal virtual void FailRequest(WebExceptionStatus webStatus)
	{
		if (Logging.On)
		{
			Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_failing_request_with_exception", webStatus.ToString()));
		}
		switch (webStatus)
		{
		case WebExceptionStatus.CacheEntryNotFound:
			throw ExceptionHelper.CacheEntryNotFoundException;
		case WebExceptionStatus.RequestProhibitedByCachePolicy:
			throw ExceptionHelper.RequestProhibitedByCachePolicyException;
		default:
			throw new WebException(NetRes.GetWebStatusString("net_requestaborted", webStatus), webStatus);
		}
	}

	internal void FetchRequest(Uri uri, WebRequest request)
	{
		_Request = request;
		_Policy = request.CachePolicy;
		_Response = null;
		_ResponseCount = 0;
		_ValidationStatus = CacheValidationStatus.DoNotUseCache;
		_CacheFreshnessStatus = CacheFreshnessStatus.Undefined;
		_CacheStream = null;
		_CacheStreamOffset = 0L;
		_CacheStreamLength = 0L;
		if (!uri.Equals(_Uri))
		{
			_CacheKey = uri.GetParts(UriComponents.AbsoluteUri, UriFormat.Unescaped);
		}
		_Uri = uri;
	}

	internal void FetchCacheEntry(RequestCacheEntry fetchEntry)
	{
		_CacheEntry = fetchEntry;
	}

	internal void FetchResponse(WebResponse fetchResponse)
	{
		_ResponseCount++;
		_Response = fetchResponse;
	}

	internal void SetFreshnessStatus(CacheFreshnessStatus status)
	{
		_CacheFreshnessStatus = status;
	}

	internal void SetValidationStatus(CacheValidationStatus status)
	{
		_ValidationStatus = status;
	}
}
