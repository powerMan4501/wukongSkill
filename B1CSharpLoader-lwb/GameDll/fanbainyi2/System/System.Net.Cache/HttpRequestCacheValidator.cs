using System.Collections;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;

namespace System.Net.Cache;

internal class HttpRequestCacheValidator : RequestCacheValidator
{
	private struct RequestVars
	{
		internal HttpMethod Method;

		internal bool IsCacheRange;

		internal bool IsUserRange;

		internal string IfHeader1;

		internal string Validator1;

		internal string IfHeader2;

		internal string Validator2;
	}

	private struct Vars
	{
		internal DateTime Date;

		internal DateTime Expires;

		internal DateTime LastModified;

		internal long EntityLength;

		internal TimeSpan Age;

		internal TimeSpan MaxAge;

		internal ResponseCacheControl CacheControl;

		internal long RangeStart;

		internal long RangeEnd;

		internal void Initialize()
		{
			EntityLength = (RangeStart = (RangeEnd = -1L));
			Date = DateTime.MinValue;
			Expires = DateTime.MinValue;
			LastModified = DateTime.MinValue;
			Age = TimeSpan.MinValue;
			MaxAge = TimeSpan.MinValue;
		}
	}

	internal delegate void ParseCallback(string s, int start, int end, IList list);

	internal const string Warning_110 = "110 Response is stale";

	internal const string Warning_111 = "111 Revalidation failed";

	internal const string Warning_112 = "112 Disconnected operation";

	internal const string Warning_113 = "113 Heuristic expiration";

	private HttpRequestCachePolicy m_HttpPolicy;

	private HttpStatusCode m_StatusCode;

	private string m_StatusDescription;

	private Version m_HttpVersion;

	private WebHeaderCollection m_Headers;

	private NameValueCollection m_SystemMeta;

	private bool m_DontUpdateHeaders;

	private bool m_HeuristicExpiration;

	private Vars m_CacheVars;

	private Vars m_ResponseVars;

	private RequestVars m_RequestVars;

	private const long LO = 9007336695791648L;

	private const int LOI = 2097184;

	private const long _prox = 33777473954119792L;

	private const long _y_re = 28429462276997241L;

	private const long _vali = 29555336417443958L;

	private const long _date = 28429470870339684L;

	private const long _publ = 30399718399213680L;

	private const int _ic = 6488169;

	private const long _priv = 33214498230894704L;

	private const int _at = 7602273;

	private const long _no_c = 27866215975157870L;

	private const long _ache = 28429419330863201L;

	private const long _no_s = 32369815602528366L;

	private const long _tore = 28429462281322612L;

	private const long _must = 32651591227342957L;

	private const long __rev = 33214481051025453L;

	private const long _alid = 28147948649709665L;

	private const long _max_ = 12666889354412141L;

	private const int _ag = 6750305;

	private const long _s_ma = 27303540895318131L;

	private const long _xage = 28429415035764856L;

	private static readonly ParseCallback ParseWarningsCallback = ParseWarningsCallbackMethod;

	internal static readonly ParseCallback ParseValuesCallback = ParseValuesCallbackMethod;

	internal HttpStatusCode CacheStatusCode
	{
		get
		{
			return m_StatusCode;
		}
		set
		{
			m_StatusCode = value;
		}
	}

	internal string CacheStatusDescription
	{
		get
		{
			return m_StatusDescription;
		}
		set
		{
			m_StatusDescription = value;
		}
	}

	internal Version CacheHttpVersion
	{
		get
		{
			return m_HttpVersion;
		}
		set
		{
			m_HttpVersion = value;
		}
	}

	internal WebHeaderCollection CacheHeaders
	{
		get
		{
			return m_Headers;
		}
		set
		{
			m_Headers = value;
		}
	}

	internal new HttpRequestCachePolicy Policy
	{
		get
		{
			if (m_HttpPolicy != null)
			{
				return m_HttpPolicy;
			}
			m_HttpPolicy = base.Policy as HttpRequestCachePolicy;
			if (m_HttpPolicy != null)
			{
				return m_HttpPolicy;
			}
			m_HttpPolicy = new HttpRequestCachePolicy((HttpRequestCacheLevel)base.Policy.Level);
			return m_HttpPolicy;
		}
	}

	internal NameValueCollection SystemMeta
	{
		get
		{
			return m_SystemMeta;
		}
		set
		{
			m_SystemMeta = value;
		}
	}

	internal HttpMethod RequestMethod
	{
		get
		{
			return m_RequestVars.Method;
		}
		set
		{
			m_RequestVars.Method = value;
		}
	}

	internal bool RequestRangeCache
	{
		get
		{
			return m_RequestVars.IsCacheRange;
		}
		set
		{
			m_RequestVars.IsCacheRange = value;
		}
	}

	internal bool RequestRangeUser
	{
		get
		{
			return m_RequestVars.IsUserRange;
		}
		set
		{
			m_RequestVars.IsUserRange = value;
		}
	}

	internal string RequestIfHeader1
	{
		get
		{
			return m_RequestVars.IfHeader1;
		}
		set
		{
			m_RequestVars.IfHeader1 = value;
		}
	}

	internal string RequestValidator1
	{
		get
		{
			return m_RequestVars.Validator1;
		}
		set
		{
			m_RequestVars.Validator1 = value;
		}
	}

	internal string RequestIfHeader2
	{
		get
		{
			return m_RequestVars.IfHeader2;
		}
		set
		{
			m_RequestVars.IfHeader2 = value;
		}
	}

	internal string RequestValidator2
	{
		get
		{
			return m_RequestVars.Validator2;
		}
		set
		{
			m_RequestVars.Validator2 = value;
		}
	}

	internal bool CacheDontUpdateHeaders
	{
		get
		{
			return m_DontUpdateHeaders;
		}
		set
		{
			m_DontUpdateHeaders = value;
		}
	}

	internal DateTime CacheDate
	{
		get
		{
			return m_CacheVars.Date;
		}
		set
		{
			m_CacheVars.Date = value;
		}
	}

	internal DateTime CacheExpires
	{
		get
		{
			return m_CacheVars.Expires;
		}
		set
		{
			m_CacheVars.Expires = value;
		}
	}

	internal DateTime CacheLastModified
	{
		get
		{
			return m_CacheVars.LastModified;
		}
		set
		{
			m_CacheVars.LastModified = value;
		}
	}

	internal long CacheEntityLength
	{
		get
		{
			return m_CacheVars.EntityLength;
		}
		set
		{
			m_CacheVars.EntityLength = value;
		}
	}

	internal TimeSpan CacheAge
	{
		get
		{
			return m_CacheVars.Age;
		}
		set
		{
			m_CacheVars.Age = value;
		}
	}

	internal TimeSpan CacheMaxAge
	{
		get
		{
			return m_CacheVars.MaxAge;
		}
		set
		{
			m_CacheVars.MaxAge = value;
		}
	}

	internal bool HeuristicExpiration
	{
		get
		{
			return m_HeuristicExpiration;
		}
		set
		{
			m_HeuristicExpiration = value;
		}
	}

	internal ResponseCacheControl CacheCacheControl
	{
		get
		{
			return m_CacheVars.CacheControl;
		}
		set
		{
			m_CacheVars.CacheControl = value;
		}
	}

	internal DateTime ResponseDate
	{
		get
		{
			return m_ResponseVars.Date;
		}
		set
		{
			m_ResponseVars.Date = value;
		}
	}

	internal DateTime ResponseExpires
	{
		get
		{
			return m_ResponseVars.Expires;
		}
		set
		{
			m_ResponseVars.Expires = value;
		}
	}

	internal DateTime ResponseLastModified
	{
		get
		{
			return m_ResponseVars.LastModified;
		}
		set
		{
			m_ResponseVars.LastModified = value;
		}
	}

	internal long ResponseEntityLength
	{
		get
		{
			return m_ResponseVars.EntityLength;
		}
		set
		{
			m_ResponseVars.EntityLength = value;
		}
	}

	internal long ResponseRangeStart
	{
		get
		{
			return m_ResponseVars.RangeStart;
		}
		set
		{
			m_ResponseVars.RangeStart = value;
		}
	}

	internal long ResponseRangeEnd
	{
		get
		{
			return m_ResponseVars.RangeEnd;
		}
		set
		{
			m_ResponseVars.RangeEnd = value;
		}
	}

	internal TimeSpan ResponseAge
	{
		get
		{
			return m_ResponseVars.Age;
		}
		set
		{
			m_ResponseVars.Age = value;
		}
	}

	internal ResponseCacheControl ResponseCacheControl
	{
		get
		{
			return m_ResponseVars.CacheControl;
		}
		set
		{
			m_ResponseVars.CacheControl = value;
		}
	}

	private void ZeroPrivateVars()
	{
		m_RequestVars = default(RequestVars);
		m_HttpPolicy = null;
		m_StatusCode = (HttpStatusCode)0;
		m_StatusDescription = null;
		m_HttpVersion = null;
		m_Headers = null;
		m_SystemMeta = null;
		m_DontUpdateHeaders = false;
		m_HeuristicExpiration = false;
		m_CacheVars = default(Vars);
		m_CacheVars.Initialize();
		m_ResponseVars = default(Vars);
		m_ResponseVars.Initialize();
	}

	internal override RequestCacheValidator CreateValidator()
	{
		return new HttpRequestCacheValidator(base.StrictCacheErrors, base.UnspecifiedMaxAge);
	}

	internal HttpRequestCacheValidator(bool strictCacheErrors, TimeSpan unspecifiedMaxAge)
		: base(strictCacheErrors, unspecifiedMaxAge)
	{
	}

	protected internal override CacheValidationStatus ValidateRequest()
	{
		ZeroPrivateVars();
		string text = base.Request.Method.ToUpper(CultureInfo.InvariantCulture);
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_request_method", text));
		}
		switch (text)
		{
		case "GET":
			RequestMethod = HttpMethod.Get;
			break;
		case "POST":
			RequestMethod = HttpMethod.Post;
			break;
		case "HEAD":
			RequestMethod = HttpMethod.Head;
			break;
		case "PUT":
			RequestMethod = HttpMethod.Put;
			break;
		case "DELETE":
			RequestMethod = HttpMethod.Delete;
			break;
		case "OPTIONS":
			RequestMethod = HttpMethod.Options;
			break;
		case "TRACE":
			RequestMethod = HttpMethod.Trace;
			break;
		case "CONNECT":
			RequestMethod = HttpMethod.Connect;
			break;
		default:
			RequestMethod = HttpMethod.Other;
			break;
		}
		return Rfc2616.OnValidateRequest(this);
	}

	protected internal override CacheFreshnessStatus ValidateFreshness()
	{
		string text = ParseStatusLine();
		if (Logging.On)
		{
			if (CacheStatusCode == (HttpStatusCode)0)
			{
				Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_http_status_parse_failure", (text == null) ? "null" : text));
			}
			else
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_http_status_line", (CacheHttpVersion != null) ? CacheHttpVersion.ToString() : "null", (int)CacheStatusCode, CacheStatusDescription));
			}
		}
		CreateCacheHeaders(CacheStatusCode != (HttpStatusCode)0);
		CreateSystemMeta();
		FetchHeaderValues(forCache: true);
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_cache_control", CacheCacheControl.ToString()));
		}
		return Rfc2616.OnValidateFreshness(this);
	}

	protected internal override CacheValidationStatus ValidateCache()
	{
		if (Policy.Level != HttpRequestCacheLevel.Revalidate && base.Policy.Level >= RequestCacheLevel.Reload)
		{
			if (Logging.On)
			{
				Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_validator_invalid_for_policy", Policy.ToString()));
			}
			return CacheValidationStatus.DoNotTakeFromCache;
		}
		if (base.CacheStream == Stream.Null || CacheStatusCode == (HttpStatusCode)0 || CacheStatusCode == HttpStatusCode.NotModified)
		{
			if (Policy.Level == HttpRequestCacheLevel.CacheOnly)
			{
				FailRequest(WebExceptionStatus.CacheEntryNotFound);
			}
			return CacheValidationStatus.DoNotTakeFromCache;
		}
		if (RequestMethod == HttpMethod.Head)
		{
			base.CacheStream.Close();
			base.CacheStream = new SyncMemoryStream(new byte[0]);
		}
		CacheValidationStatus cacheValidationStatus = CacheValidationStatus.DoNotTakeFromCache;
		RemoveWarnings_1xx();
		base.CacheStreamOffset = 0L;
		base.CacheStreamLength = base.CacheEntry.StreamSize;
		cacheValidationStatus = Rfc2616.OnValidateCache(this);
		if (cacheValidationStatus != CacheValidationStatus.ReturnCachedResponse && Policy.Level == HttpRequestCacheLevel.CacheOnly)
		{
			FailRequest(WebExceptionStatus.CacheEntryNotFound);
		}
		if (cacheValidationStatus == CacheValidationStatus.ReturnCachedResponse)
		{
			if (base.CacheFreshnessStatus == CacheFreshnessStatus.Stale)
			{
				CacheHeaders.Add("Warning", "110 Response is stale");
			}
			if (base.Policy.Level == RequestCacheLevel.CacheOnly)
			{
				CacheHeaders.Add("Warning", "112 Disconnected operation");
			}
			if (HeuristicExpiration && (int)CacheAge.TotalSeconds >= 86400)
			{
				CacheHeaders.Add("Warning", "113 Heuristic expiration");
			}
		}
		switch (cacheValidationStatus)
		{
		case CacheValidationStatus.DoNotTakeFromCache:
			CacheStatusCode = (HttpStatusCode)0;
			break;
		case CacheValidationStatus.ReturnCachedResponse:
			CacheHeaders["Age"] = ((int)CacheAge.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo);
			break;
		}
		return cacheValidationStatus;
	}

	protected internal override CacheValidationStatus RevalidateCache()
	{
		if (Policy.Level != HttpRequestCacheLevel.Revalidate && base.Policy.Level >= RequestCacheLevel.Reload)
		{
			if (Logging.On)
			{
				Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_validator_invalid_for_policy", Policy.ToString()));
			}
			return CacheValidationStatus.DoNotTakeFromCache;
		}
		if (base.CacheStream == Stream.Null || CacheStatusCode == (HttpStatusCode)0 || CacheStatusCode == HttpStatusCode.NotModified)
		{
			return CacheValidationStatus.DoNotTakeFromCache;
		}
		CacheValidationStatus cacheValidationStatus = CacheValidationStatus.DoNotTakeFromCache;
		if (!(base.Response is HttpWebResponse httpWebResponse))
		{
			return CacheValidationStatus.DoNotTakeFromCache;
		}
		if (httpWebResponse.StatusCode >= HttpStatusCode.InternalServerError)
		{
			if (Rfc2616.Common.ValidateCacheOn5XXResponse(this) == CacheValidationStatus.ReturnCachedResponse)
			{
				if (base.CacheFreshnessStatus == CacheFreshnessStatus.Stale)
				{
					CacheHeaders.Add("Warning", "110 Response is stale");
				}
				if (HeuristicExpiration && (int)CacheAge.TotalSeconds >= 86400)
				{
					CacheHeaders.Add("Warning", "113 Heuristic expiration");
				}
			}
		}
		else if (base.ResponseCount > 1)
		{
			cacheValidationStatus = CacheValidationStatus.DoNotTakeFromCache;
		}
		else
		{
			CacheAge = TimeSpan.Zero;
			cacheValidationStatus = Rfc2616.Common.ValidateCacheAfterResponse(this, httpWebResponse);
		}
		if (cacheValidationStatus == CacheValidationStatus.ReturnCachedResponse)
		{
			CacheHeaders["Age"] = ((int)CacheAge.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo);
		}
		return cacheValidationStatus;
	}

	protected internal override CacheValidationStatus ValidateResponse()
	{
		if (Policy.Level != HttpRequestCacheLevel.CacheOrNextCacheOnly && Policy.Level != HttpRequestCacheLevel.Default && Policy.Level != HttpRequestCacheLevel.Revalidate)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_response_valid_based_on_policy", Policy.ToString()));
			}
			return CacheValidationStatus.Continue;
		}
		if (!(base.Response is HttpWebResponse httpWebResponse))
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_null_response_failure"));
			}
			return CacheValidationStatus.Continue;
		}
		FetchHeaderValues(forCache: false);
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.RequestCache, "StatusCode=" + ((int)httpWebResponse.StatusCode).ToString(CultureInfo.InvariantCulture) + " " + httpWebResponse.StatusCode.ToString() + ((httpWebResponse.StatusCode == HttpStatusCode.PartialContent) ? (", Content-Range: " + httpWebResponse.Headers["Content-Range"]) : string.Empty));
		}
		return Rfc2616.OnValidateResponse(this);
	}

	protected internal override CacheValidationStatus UpdateCache()
	{
		if (Policy.Level == HttpRequestCacheLevel.NoCacheNoStore)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_removed_existing_based_on_policy", Policy.ToString()));
			}
			return CacheValidationStatus.RemoveFromCache;
		}
		if (Policy.Level == HttpRequestCacheLevel.CacheOnly)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_not_updated_based_on_policy", Policy.ToString()));
			}
			return CacheValidationStatus.DoNotUpdateCache;
		}
		if (CacheHeaders == null)
		{
			CacheHeaders = new WebHeaderCollection();
		}
		if (SystemMeta == null)
		{
			SystemMeta = new NameValueCollection(1, CaseInsensitiveAscii.StaticInstance);
		}
		if (ResponseCacheControl == null)
		{
			FetchHeaderValues(forCache: false);
		}
		CacheValidationStatus cacheValidationStatus = Rfc2616.OnUpdateCache(this);
		if (cacheValidationStatus == CacheValidationStatus.UpdateResponseInformation || cacheValidationStatus == CacheValidationStatus.CacheResponse)
		{
			FinallyUpdateCacheEntry();
		}
		return cacheValidationStatus;
	}

	private void FinallyUpdateCacheEntry()
	{
		base.CacheEntry.EntryMetadata = null;
		base.CacheEntry.SystemMetadata = null;
		if (CacheHeaders == null)
		{
			return;
		}
		base.CacheEntry.EntryMetadata = new StringCollection();
		base.CacheEntry.SystemMetadata = new StringCollection();
		if (CacheHttpVersion == null)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_invalid_http_version"));
			}
			CacheHttpVersion = new Version(1, 0);
		}
		StringBuilder stringBuilder = new StringBuilder(CacheStatusDescription.Length + 20);
		stringBuilder.Append("HTTP/");
		stringBuilder.Append(CacheHttpVersion.ToString(2));
		stringBuilder.Append(' ');
		stringBuilder.Append(((int)CacheStatusCode).ToString(NumberFormatInfo.InvariantInfo));
		stringBuilder.Append(' ');
		stringBuilder.Append(CacheStatusDescription);
		base.CacheEntry.EntryMetadata.Add(stringBuilder.ToString());
		UpdateStringCollection(base.CacheEntry.EntryMetadata, CacheHeaders, winInetCompat: false);
		if (SystemMeta != null)
		{
			UpdateStringCollection(base.CacheEntry.SystemMetadata, SystemMeta, winInetCompat: true);
		}
		if (ResponseExpires != DateTime.MinValue)
		{
			base.CacheEntry.ExpiresUtc = ResponseExpires;
		}
		if (ResponseLastModified != DateTime.MinValue)
		{
			base.CacheEntry.LastModifiedUtc = ResponseLastModified;
		}
		if (Policy.Level == HttpRequestCacheLevel.Default)
		{
			base.CacheEntry.MaxStale = Policy.MaxStale;
		}
		base.CacheEntry.LastSynchronizedUtc = DateTime.UtcNow;
	}

	private static void UpdateStringCollection(StringCollection result, NameValueCollection cc, bool winInetCompat)
	{
		for (int i = 0; i < cc.Count; i++)
		{
			StringBuilder stringBuilder = new StringBuilder(40);
			string key = cc.GetKey(i);
			stringBuilder.Append(key).Append(':');
			string[] values = cc.GetValues(i);
			if (values.Length != 0)
			{
				if (winInetCompat)
				{
					stringBuilder.Append(values[0]);
				}
				else
				{
					stringBuilder.Append(' ').Append(values[0]);
				}
			}
			for (int j = 1; j < values.Length; j++)
			{
				stringBuilder.Append(key).Append(", ").Append(values[j]);
			}
			result.Add(stringBuilder.ToString());
		}
		result.Add(string.Empty);
	}

	private string ParseStatusLine()
	{
		CacheStatusCode = (HttpStatusCode)0;
		if (base.CacheEntry.EntryMetadata == null || base.CacheEntry.EntryMetadata.Count == 0)
		{
			return null;
		}
		string text = base.CacheEntry.EntryMetadata[0];
		if (text == null)
		{
			return null;
		}
		int i = 0;
		char c = '\0';
		while (++i < text.Length && (c = text[i]) != '/')
		{
		}
		if (i == text.Length)
		{
			return text;
		}
		int num = -1;
		int num2 = -1;
		int num3 = -1;
		while (++i < text.Length && (c = text[i]) >= '0' && c <= '9')
		{
			num = ((num >= 0) ? (num * 10) : 0) + (c - 48);
		}
		if (num < 0 || c != '.')
		{
			return text;
		}
		while (++i < text.Length && (c = text[i]) >= '0' && c <= '9')
		{
			num2 = ((num2 >= 0) ? (num2 * 10) : 0) + (c - 48);
		}
		if (num2 < 0 || (c != ' ' && c != '\t'))
		{
			return text;
		}
		while (++i < text.Length && ((c = text[i]) == ' ' || c == '\t'))
		{
		}
		if (i >= text.Length)
		{
			return text;
		}
		while (c >= '0' && c <= '9')
		{
			num3 = ((num3 >= 0) ? (num3 * 10) : 0) + (c - 48);
			if (++i == text.Length)
			{
				break;
			}
			c = text[i];
		}
		if (num3 < 0 || (i <= text.Length && c != ' ' && c != '\t'))
		{
			return text;
		}
		for (; i < text.Length && (text[i] == ' ' || text[i] == '\t'); i++)
		{
		}
		CacheStatusDescription = text.Substring(i);
		CacheHttpVersion = new Version(num, num2);
		CacheStatusCode = (HttpStatusCode)num3;
		return text;
	}

	private void CreateCacheHeaders(bool ignoreFirstString)
	{
		if (CacheHeaders == null)
		{
			CacheHeaders = new WebHeaderCollection();
		}
		if (base.CacheEntry.EntryMetadata == null || base.CacheEntry.EntryMetadata.Count == 0)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_no_http_response_header"));
			}
			return;
		}
		string text = ParseNameValues(CacheHeaders, base.CacheEntry.EntryMetadata, ignoreFirstString ? 1 : 0);
		if (text != null)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_http_header_parse_error", text));
			}
			CacheHeaders.Clear();
		}
	}

	private void CreateSystemMeta()
	{
		if (SystemMeta == null)
		{
			SystemMeta = new NameValueCollection((base.CacheEntry.EntryMetadata == null || base.CacheEntry.EntryMetadata.Count == 0) ? 2 : base.CacheEntry.EntryMetadata.Count, CaseInsensitiveAscii.StaticInstance);
		}
		if (base.CacheEntry.EntryMetadata != null && base.CacheEntry.EntryMetadata.Count != 0)
		{
			string text = ParseNameValues(SystemMeta, base.CacheEntry.SystemMetadata, 0);
			if (text != null && Logging.On)
			{
				Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_metadata_name_value_parse_error", text));
			}
		}
	}

	private string ParseNameValues(NameValueCollection cc, StringCollection sc, int start)
	{
		WebHeaderCollection webHeaderCollection = cc as WebHeaderCollection;
		string text = null;
		if (sc != null)
		{
			for (int i = start; i < sc.Count; i++)
			{
				string text2 = sc[i];
				if (text2 == null || text2.Length == 0)
				{
					return null;
				}
				if (text2[0] == ' ' || text2[0] == '\t')
				{
					if (text == null)
					{
						return text2;
					}
					if (webHeaderCollection != null)
					{
						webHeaderCollection.AddInternal(text, text2);
					}
					else
					{
						cc.Add(text, text2);
					}
				}
				int num = text2.IndexOf(':');
				if (num < 0)
				{
					return text2;
				}
				text = text2.Substring(0, num);
				while (++num < text2.Length && (text2[num] == ' ' || text2[num] == '\t'))
				{
				}
				try
				{
					if (webHeaderCollection != null)
					{
						webHeaderCollection.AddInternal(text, text2.Substring(num));
					}
					else
					{
						cc.Add(text, text2.Substring(num));
					}
				}
				catch (Exception ex)
				{
					if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
					{
						throw;
					}
					return text2;
				}
			}
		}
		return null;
	}

	private void FetchHeaderValues(bool forCache)
	{
		WebHeaderCollection webHeaderCollection = (forCache ? CacheHeaders : base.Response.Headers);
		FetchCacheControl(webHeaderCollection.CacheControl, forCache);
		string date = webHeaderCollection.Date;
		DateTime dtOut = DateTime.MinValue;
		if (date != null && HttpDateParse.ParseHttpDate(date, out dtOut))
		{
			dtOut = dtOut.ToUniversalTime();
		}
		if (forCache)
		{
			CacheDate = dtOut;
		}
		else
		{
			ResponseDate = dtOut;
		}
		date = webHeaderCollection.Expires;
		dtOut = DateTime.MinValue;
		if (date != null && HttpDateParse.ParseHttpDate(date, out dtOut))
		{
			dtOut = dtOut.ToUniversalTime();
		}
		if (forCache)
		{
			CacheExpires = dtOut;
		}
		else
		{
			ResponseExpires = dtOut;
		}
		date = webHeaderCollection.LastModified;
		dtOut = DateTime.MinValue;
		if (date != null && HttpDateParse.ParseHttpDate(date, out dtOut))
		{
			dtOut = dtOut.ToUniversalTime();
		}
		if (forCache)
		{
			CacheLastModified = dtOut;
		}
		else
		{
			ResponseLastModified = dtOut;
		}
		long total = -1L;
		long start = -1L;
		long end = -1L;
		HttpWebResponse httpWebResponse = base.Response as HttpWebResponse;
		if ((forCache ? CacheStatusCode : httpWebResponse.StatusCode) != HttpStatusCode.PartialContent)
		{
			date = webHeaderCollection.ContentLength;
			if (date != null && date.Length != 0)
			{
				int num = 0;
				char c = date[0];
				while (num < date.Length && c == ' ')
				{
					c = date[++num];
				}
				if (num != date.Length && c >= '0' && c <= '9')
				{
					total = c - 48;
					while (++num < date.Length && (c = date[num]) >= '0' && c <= '9')
					{
						total = total * 10 + (c - 48);
					}
				}
			}
		}
		else
		{
			date = webHeaderCollection["Content-Range"];
			if (date == null || !Rfc2616.Common.GetBytesRange(date, ref start, ref end, ref total, isRequest: false))
			{
				if (Logging.On)
				{
					Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_content_range_error", (date == null) ? "<null>" : date));
				}
				start = (end = (total = -1L));
			}
			else if (forCache && total == base.CacheEntry.StreamSize)
			{
				start = -1L;
				end = -1L;
				CacheStatusCode = HttpStatusCode.OK;
				CacheStatusDescription = "OK";
			}
		}
		if (forCache)
		{
			CacheEntityLength = total;
			ResponseRangeStart = start;
			ResponseRangeEnd = end;
		}
		else
		{
			ResponseEntityLength = total;
			ResponseRangeStart = start;
			ResponseRangeEnd = end;
		}
		TimeSpan timeSpan = TimeSpan.MinValue;
		date = webHeaderCollection["Age"];
		if (date != null)
		{
			int num2 = 0;
			int num3 = 0;
			while (num2 < date.Length && date[num2++] == ' ')
			{
			}
			while (num2 < date.Length && date[num2] >= '0' && date[num2] <= '9')
			{
				num3 = num3 * 10 + (date[num2++] - 48);
			}
			timeSpan = TimeSpan.FromSeconds(num3);
		}
		if (forCache)
		{
			CacheAge = timeSpan;
		}
		else
		{
			ResponseAge = timeSpan;
		}
	}

	private unsafe void FetchCacheControl(string s, bool forCache)
	{
		ResponseCacheControl responseCacheControl = new ResponseCacheControl();
		if (forCache)
		{
			CacheCacheControl = responseCacheControl;
		}
		else
		{
			ResponseCacheControl = responseCacheControl;
		}
		if (s == null || s.Length == 0)
		{
			return;
		}
		fixed (char* ptr = s)
		{
			int length = s.Length;
			for (int i = 0; i < length - 4; i++)
			{
				if (ptr[i] < ' ' || ptr[i] >= '\u007f')
				{
					if (Logging.On)
					{
						Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_cache_control_error", s));
					}
					return;
				}
				if (ptr[i] == ' ' || ptr[i] == ',')
				{
					continue;
				}
				if (IntPtr.Size == 4)
				{
					long* ptr2 = (long*)(ptr + i);
					switch (*ptr2 | 0x20002000200020L)
					{
					case 33777473954119792L:
						if (i + 16 <= length && (ptr2[1] | 0x20002000200020L) == 28429462276997241L && (ptr2[2] | 0x20002000200020L) == 29555336417443958L && (ptr2[3] | 0x20002000200020L) == 28429470870339684L)
						{
							responseCacheControl.ProxyRevalidate = true;
							i += 15;
						}
						break;
					case 30399718399213680L:
						if (i + 6 > length)
						{
							return;
						}
						if ((((int*)ptr2)[2] | 0x200020) == 6488169)
						{
							responseCacheControl.Public = true;
							i += 5;
						}
						break;
					case 33214498230894704L:
					{
						if (i + 7 > length)
						{
							return;
						}
						if ((((int*)ptr2)[2] | 0x200020) != 7602273 || (ptr[i + 6] | 0x20) != 101)
						{
							break;
						}
						responseCacheControl.Private = true;
						for (i += 6; i < length && ptr[i] == ' '; i++)
						{
						}
						if (i >= length || ptr[i] != '=')
						{
							i--;
							break;
						}
						while (i < length && ptr[++i] == ' ')
						{
						}
						if (i >= length || ptr[i] != '"')
						{
							i--;
							break;
						}
						ArrayList arrayList2 = new ArrayList();
						i++;
						while (i < length && ptr[i] != '"')
						{
							for (; i < length && ptr[i] == ' '; i++)
							{
							}
							int num2 = i;
							for (; i < length && ptr[i] != ' ' && ptr[i] != ',' && ptr[i] != '"'; i++)
							{
							}
							if (num2 != i)
							{
								arrayList2.Add(s.Substring(num2, i - num2));
							}
							for (; i < length && ptr[i] != ',' && ptr[i] != '"'; i++)
							{
							}
						}
						if (arrayList2.Count != 0)
						{
							responseCacheControl.PrivateHeaders = (string[])arrayList2.ToArray(typeof(string));
						}
						break;
					}
					case 27866215975157870L:
					{
						if (i + 8 > length)
						{
							return;
						}
						if ((ptr2[1] | 0x200020) != 28429419330863201L)
						{
							break;
						}
						responseCacheControl.NoCache = true;
						for (i += 7; i < length && ptr[i] == ' '; i++)
						{
						}
						if (i >= length || ptr[i] != '=')
						{
							i--;
							break;
						}
						while (i < length && ptr[++i] == ' ')
						{
						}
						if (i >= length || ptr[i] != '"')
						{
							i--;
							break;
						}
						ArrayList arrayList = new ArrayList();
						i++;
						while (i < length && ptr[i] != '"')
						{
							for (; i < length && ptr[i] == ' '; i++)
							{
							}
							int num = i;
							for (; i < length && ptr[i] != ' ' && ptr[i] != ',' && ptr[i] != '"'; i++)
							{
							}
							if (num != i)
							{
								arrayList.Add(s.Substring(num, i - num));
							}
							for (; i < length && ptr[i] != ',' && ptr[i] != '"'; i++)
							{
							}
						}
						if (arrayList.Count != 0)
						{
							responseCacheControl.NoCacheHeaders = (string[])arrayList.ToArray(typeof(string));
						}
						break;
					}
					case 32369815602528366L:
						if (i + 8 > length)
						{
							return;
						}
						if ((ptr2[1] | 0x200020) == 28429462281322612L)
						{
							responseCacheControl.NoStore = true;
							i += 7;
						}
						break;
					case 32651591227342957L:
						if (i + 15 <= length && (ptr2[1] | 0x20002000200020L) == 33214481051025453L && (ptr2[2] | 0x20002000200020L) == 28147948649709665L && (*(int*)(ptr2 + 3) | 0x200020) == 7602273 && (ptr[i + 14] | 0x20) == 101)
						{
							responseCacheControl.MustRevalidate = true;
							i += 14;
						}
						break;
					case 12666889354412141L:
						if (i + 7 > length)
						{
							return;
						}
						if ((((int*)ptr2)[2] | 0x200020) == 6750305 && (ptr[i + 6] | 0x20) == 101)
						{
							for (i += 7; i < length && ptr[i] == ' '; i++)
							{
							}
							if (i == length || ptr[i++] != '=')
							{
								return;
							}
							for (; i < length && ptr[i] == ' '; i++)
							{
							}
							if (i == length)
							{
								return;
							}
							responseCacheControl.MaxAge = 0;
							while (i < length && ptr[i] >= '0' && ptr[i] <= '9')
							{
								responseCacheControl.MaxAge = responseCacheControl.MaxAge * 10 + (ptr[i++] - 48);
							}
							i--;
						}
						break;
					case 27303540895318131L:
						if (i + 8 > length)
						{
							return;
						}
						if ((ptr2[1] | 0x200020) == 28429415035764856L)
						{
							for (i += 8; i < length && ptr[i] == ' '; i++)
							{
							}
							if (i == length || ptr[i++] != '=')
							{
								return;
							}
							for (; i < length && ptr[i] == ' '; i++)
							{
							}
							if (i == length)
							{
								return;
							}
							responseCacheControl.SMaxAge = 0;
							while (i < length && ptr[i] >= '0' && ptr[i] <= '9')
							{
								responseCacheControl.SMaxAge = responseCacheControl.SMaxAge * 10 + (ptr[i++] - 48);
							}
							i--;
						}
						break;
					}
				}
				else if (Rfc2616.Common.UnsafeAsciiLettersNoCaseEqual(ptr, i, length, "proxy-revalidate"))
				{
					responseCacheControl.ProxyRevalidate = true;
					i += 15;
				}
				else if (Rfc2616.Common.UnsafeAsciiLettersNoCaseEqual(ptr, i, length, "public"))
				{
					responseCacheControl.Public = true;
					i += 5;
				}
				else if (Rfc2616.Common.UnsafeAsciiLettersNoCaseEqual(ptr, i, length, "private"))
				{
					responseCacheControl.Private = true;
					for (i += 6; i < length && ptr[i] == ' '; i++)
					{
					}
					if (i >= length || ptr[i] != '=')
					{
						i--;
						break;
					}
					while (i < length && ptr[++i] == ' ')
					{
					}
					if (i >= length || ptr[i] != '"')
					{
						i--;
						break;
					}
					ArrayList arrayList3 = new ArrayList();
					i++;
					while (i < length && ptr[i] != '"')
					{
						for (; i < length && ptr[i] == ' '; i++)
						{
						}
						int num3 = i;
						for (; i < length && ptr[i] != ' ' && ptr[i] != ',' && ptr[i] != '"'; i++)
						{
						}
						if (num3 != i)
						{
							arrayList3.Add(s.Substring(num3, i - num3));
						}
						for (; i < length && ptr[i] != ',' && ptr[i] != '"'; i++)
						{
						}
					}
					if (arrayList3.Count != 0)
					{
						responseCacheControl.PrivateHeaders = (string[])arrayList3.ToArray(typeof(string));
					}
				}
				else if (Rfc2616.Common.UnsafeAsciiLettersNoCaseEqual(ptr, i, length, "no-cache"))
				{
					responseCacheControl.NoCache = true;
					for (i += 7; i < length && ptr[i] == ' '; i++)
					{
					}
					if (i >= length || ptr[i] != '=')
					{
						i--;
						break;
					}
					while (i < length && ptr[++i] == ' ')
					{
					}
					if (i >= length || ptr[i] != '"')
					{
						i--;
						break;
					}
					ArrayList arrayList4 = new ArrayList();
					i++;
					while (i < length && ptr[i] != '"')
					{
						for (; i < length && ptr[i] == ' '; i++)
						{
						}
						int num4 = i;
						for (; i < length && ptr[i] != ' ' && ptr[i] != ',' && ptr[i] != '"'; i++)
						{
						}
						if (num4 != i)
						{
							arrayList4.Add(s.Substring(num4, i - num4));
						}
						for (; i < length && ptr[i] != ',' && ptr[i] != '"'; i++)
						{
						}
					}
					if (arrayList4.Count != 0)
					{
						responseCacheControl.NoCacheHeaders = (string[])arrayList4.ToArray(typeof(string));
					}
				}
				else if (Rfc2616.Common.UnsafeAsciiLettersNoCaseEqual(ptr, i, length, "no-store"))
				{
					responseCacheControl.NoStore = true;
					i += 7;
				}
				else if (Rfc2616.Common.UnsafeAsciiLettersNoCaseEqual(ptr, i, length, "must-revalidate"))
				{
					responseCacheControl.MustRevalidate = true;
					i += 14;
				}
				else if (Rfc2616.Common.UnsafeAsciiLettersNoCaseEqual(ptr, i, length, "max-age"))
				{
					for (i += 7; i < length && ptr[i] == ' '; i++)
					{
					}
					if (i == length || ptr[i++] != '=')
					{
						return;
					}
					for (; i < length && ptr[i] == ' '; i++)
					{
					}
					if (i == length)
					{
						return;
					}
					responseCacheControl.MaxAge = 0;
					while (i < length && ptr[i] >= '0' && ptr[i] <= '9')
					{
						responseCacheControl.MaxAge = responseCacheControl.MaxAge * 10 + (ptr[i++] - 48);
					}
					i--;
				}
				else if (Rfc2616.Common.UnsafeAsciiLettersNoCaseEqual(ptr, i, length, "smax-age"))
				{
					for (i += 8; i < length && ptr[i] == ' '; i++)
					{
					}
					if (i == length || ptr[i++] != '=')
					{
						return;
					}
					for (; i < length && ptr[i] == ' '; i++)
					{
					}
					if (i == length)
					{
						return;
					}
					responseCacheControl.SMaxAge = 0;
					while (i < length && ptr[i] >= '0' && ptr[i] <= '9')
					{
						responseCacheControl.SMaxAge = responseCacheControl.SMaxAge * 10 + (ptr[i++] - 48);
					}
					i--;
				}
			}
		}
	}

	private void RemoveWarnings_1xx()
	{
		string[] values = CacheHeaders.GetValues("Warning");
		if (values != null)
		{
			ArrayList arrayList = new ArrayList();
			ParseHeaderValues(values, ParseWarningsCallback, arrayList);
			CacheHeaders.Remove("Warning");
			for (int i = 0; i < arrayList.Count; i++)
			{
				CacheHeaders.Add("Warning", (string)arrayList[i]);
			}
		}
	}

	private static void ParseWarningsCallbackMethod(string s, int start, int end, IList list)
	{
		if (end >= start && s[start] != '1')
		{
			ParseValuesCallbackMethod(s, start, end, list);
		}
	}

	private static void ParseValuesCallbackMethod(string s, int start, int end, IList list)
	{
		while (end >= start && s[end] == ' ')
		{
			end--;
		}
		if (end >= start)
		{
			list.Add(s.Substring(start, end - start + 1));
		}
	}

	internal static void ParseHeaderValues(string[] values, ParseCallback calback, IList list)
	{
		if (values == null)
		{
			return;
		}
		foreach (string text in values)
		{
			int num = 0;
			int j = 0;
			while (num < text.Length)
			{
				for (; j < text.Length && text[j] == ' '; j++)
				{
				}
				if (j == text.Length)
				{
					break;
				}
				num = j;
				while (true)
				{
					if (num < text.Length && text[num] != ',' && text[num] != '"')
					{
						num++;
						continue;
					}
					if (num == text.Length)
					{
						break;
					}
					if (text[num] == '"')
					{
						while (++num < text.Length && text[num] != '"')
						{
						}
						if (num != text.Length)
						{
							continue;
						}
						goto IL_00a6;
					}
					goto IL_00b4;
				}
				calback(text, j, num - 1, list);
				break;
				IL_00b4:
				calback(text, j, num - 1, list);
				while (++num < text.Length && text[num] == ' ')
				{
				}
				if (num >= text.Length)
				{
					break;
				}
				j = num;
				continue;
				IL_00a6:
				calback(text, j, num - 1, list);
				break;
			}
		}
	}
}
