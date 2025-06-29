using System.Collections.Specialized;
using System.Globalization;
using System.IO;

namespace System.Net.Cache;

internal class FtpRequestCacheValidator : HttpRequestCacheValidator
{
	private DateTime m_LastModified;

	private bool m_HttpProxyMode;

	private bool HttpProxyMode => m_HttpProxyMode;

	internal new RequestCachePolicy Policy => ((RequestCacheValidator)this).Policy;

	private void ZeroPrivateVars()
	{
		m_LastModified = DateTime.MinValue;
		m_HttpProxyMode = false;
	}

	internal override RequestCacheValidator CreateValidator()
	{
		return new FtpRequestCacheValidator(base.StrictCacheErrors, base.UnspecifiedMaxAge);
	}

	internal FtpRequestCacheValidator(bool strictCacheErrors, TimeSpan unspecifiedMaxAge)
		: base(strictCacheErrors, unspecifiedMaxAge)
	{
	}

	protected internal override CacheValidationStatus ValidateRequest()
	{
		ZeroPrivateVars();
		if (base.Request is HttpWebRequest)
		{
			m_HttpProxyMode = true;
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_ftp_proxy_doesnt_support_partial"));
			}
			return base.ValidateRequest();
		}
		if (Policy.Level == RequestCacheLevel.BypassCache)
		{
			return CacheValidationStatus.DoNotUseCache;
		}
		string text = base.Request.Method.ToUpper(CultureInfo.InvariantCulture);
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_ftp_method", text));
		}
		switch (text)
		{
		case "RETR":
			base.RequestMethod = HttpMethod.Get;
			break;
		case "STOR":
			base.RequestMethod = HttpMethod.Put;
			break;
		case "APPE":
			base.RequestMethod = HttpMethod.Put;
			break;
		case "RENAME":
			base.RequestMethod = HttpMethod.Put;
			break;
		case "DELE":
			base.RequestMethod = HttpMethod.Delete;
			break;
		default:
			base.RequestMethod = HttpMethod.Other;
			break;
		}
		if ((base.RequestMethod != HttpMethod.Get || !((FtpWebRequest)base.Request).UseBinary) && Policy.Level == RequestCacheLevel.CacheOnly)
		{
			FailRequest(WebExceptionStatus.RequestProhibitedByCachePolicy);
		}
		if (text != "RETR")
		{
			return CacheValidationStatus.DoNotTakeFromCache;
		}
		if (!((FtpWebRequest)base.Request).UseBinary)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_ftp_supports_bin_only"));
			}
			return CacheValidationStatus.DoNotUseCache;
		}
		if (Policy.Level >= RequestCacheLevel.Reload)
		{
			return CacheValidationStatus.DoNotTakeFromCache;
		}
		return CacheValidationStatus.Continue;
	}

	protected internal override CacheFreshnessStatus ValidateFreshness()
	{
		if (HttpProxyMode)
		{
			if (base.CacheStream != Stream.Null)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_replacing_entry_with_HTTP_200"));
				}
				if (base.CacheEntry.EntryMetadata == null)
				{
					base.CacheEntry.EntryMetadata = new StringCollection();
				}
				base.CacheEntry.EntryMetadata.Clear();
				base.CacheEntry.EntryMetadata.Add("HTTP/1.1 200 OK");
			}
			return base.ValidateFreshness();
		}
		DateTime utcNow = DateTime.UtcNow;
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_now_time", utcNow.ToString("r", CultureInfo.InvariantCulture)));
		}
		if (base.CacheEntry.ExpiresUtc != DateTime.MinValue)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_max_age_absolute", base.CacheEntry.ExpiresUtc.ToString("r", CultureInfo.InvariantCulture)));
			}
			if (base.CacheEntry.ExpiresUtc < utcNow)
			{
				return CacheFreshnessStatus.Stale;
			}
			return CacheFreshnessStatus.Fresh;
		}
		TimeSpan timeSpan = TimeSpan.MaxValue;
		if (base.CacheEntry.LastSynchronizedUtc != DateTime.MinValue)
		{
			timeSpan = utcNow - base.CacheEntry.LastSynchronizedUtc;
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_age1", ((int)timeSpan.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo), base.CacheEntry.LastSynchronizedUtc.ToString("r", CultureInfo.InvariantCulture)));
			}
		}
		if (base.CacheEntry.LastModifiedUtc != DateTime.MinValue)
		{
			int num = (int)((utcNow - base.CacheEntry.LastModifiedUtc).TotalSeconds / 10.0);
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_no_max_age_use_10_percent", num.ToString(NumberFormatInfo.InvariantInfo), base.CacheEntry.LastModifiedUtc.ToString("r", CultureInfo.InvariantCulture)));
			}
			if (timeSpan.TotalSeconds < (double)num)
			{
				return CacheFreshnessStatus.Fresh;
			}
			return CacheFreshnessStatus.Stale;
		}
		if (Logging.On)
		{
			Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_no_max_age_use_default", ((int)base.UnspecifiedMaxAge.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo)));
		}
		if (base.UnspecifiedMaxAge >= timeSpan)
		{
			return CacheFreshnessStatus.Fresh;
		}
		return CacheFreshnessStatus.Stale;
	}

	protected internal override CacheValidationStatus ValidateCache()
	{
		if (HttpProxyMode)
		{
			return base.ValidateCache();
		}
		if (Policy.Level >= RequestCacheLevel.Reload)
		{
			if (Logging.On)
			{
				Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_validator_invalid_for_policy", Policy.ToString()));
			}
			return CacheValidationStatus.DoNotTakeFromCache;
		}
		if (base.CacheStream == Stream.Null || base.CacheEntry.IsPartialEntry)
		{
			if (Policy.Level == RequestCacheLevel.CacheOnly)
			{
				FailRequest(WebExceptionStatus.CacheEntryNotFound);
			}
			if (base.CacheStream == Stream.Null)
			{
				return CacheValidationStatus.DoNotTakeFromCache;
			}
		}
		base.CacheStreamOffset = 0L;
		base.CacheStreamLength = base.CacheEntry.StreamSize;
		if (Policy.Level == RequestCacheLevel.Revalidate || base.CacheEntry.IsPartialEntry)
		{
			return TryConditionalRequest();
		}
		long num = ((base.Request is FtpWebRequest) ? ((FtpWebRequest)base.Request).ContentOffset : 0);
		if (base.CacheFreshnessStatus == CacheFreshnessStatus.Fresh || Policy.Level == RequestCacheLevel.CacheOnly || Policy.Level == RequestCacheLevel.CacheIfAvailable)
		{
			if (num != 0L)
			{
				if (num >= base.CacheStreamLength)
				{
					if (Policy.Level == RequestCacheLevel.CacheOnly)
					{
						FailRequest(WebExceptionStatus.CacheEntryNotFound);
					}
					return CacheValidationStatus.DoNotTakeFromCache;
				}
				base.CacheStreamOffset = num;
			}
			return CacheValidationStatus.ReturnCachedResponse;
		}
		return CacheValidationStatus.DoNotTakeFromCache;
	}

	protected internal override CacheValidationStatus RevalidateCache()
	{
		if (HttpProxyMode)
		{
			return base.RevalidateCache();
		}
		if (Policy.Level >= RequestCacheLevel.Reload)
		{
			if (Logging.On)
			{
				Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_validator_invalid_for_policy", Policy.ToString()));
			}
			return CacheValidationStatus.DoNotTakeFromCache;
		}
		if (base.CacheStream == Stream.Null)
		{
			return CacheValidationStatus.DoNotTakeFromCache;
		}
		CacheValidationStatus cacheValidationStatus = CacheValidationStatus.DoNotTakeFromCache;
		if (!(base.Response is FtpWebResponse ftpWebResponse))
		{
			return CacheValidationStatus.DoNotTakeFromCache;
		}
		if (ftpWebResponse.StatusCode == FtpStatusCode.FileStatus)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_response_last_modified", ftpWebResponse.LastModified.ToUniversalTime().ToString("r", CultureInfo.InvariantCulture), ftpWebResponse.ContentLength));
			}
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_cache_last_modified", base.CacheEntry.LastModifiedUtc.ToString("r", CultureInfo.InvariantCulture), base.CacheEntry.StreamSize));
			}
			if (base.CacheStreamOffset != 0L && base.CacheEntry.IsPartialEntry)
			{
				if (Logging.On)
				{
					Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_partial_and_non_zero_content_offset", base.CacheStreamOffset.ToString(CultureInfo.InvariantCulture)));
				}
				cacheValidationStatus = CacheValidationStatus.DoNotTakeFromCache;
			}
			if (ftpWebResponse.LastModified.ToUniversalTime() == base.CacheEntry.LastModifiedUtc)
			{
				if (base.CacheEntry.IsPartialEntry)
				{
					if (ftpWebResponse.ContentLength > 0)
					{
						base.CacheStreamLength = ftpWebResponse.ContentLength;
					}
					else
					{
						base.CacheStreamLength = -1L;
					}
					return CacheValidationStatus.CombineCachedAndServerResponse;
				}
				if (ftpWebResponse.ContentLength == base.CacheEntry.StreamSize)
				{
					return CacheValidationStatus.ReturnCachedResponse;
				}
				return CacheValidationStatus.DoNotTakeFromCache;
			}
			return CacheValidationStatus.DoNotTakeFromCache;
		}
		return CacheValidationStatus.DoNotTakeFromCache;
	}

	protected internal override CacheValidationStatus ValidateResponse()
	{
		if (HttpProxyMode)
		{
			return base.ValidateResponse();
		}
		if (Policy.Level != RequestCacheLevel.Default && Policy.Level != RequestCacheLevel.Revalidate)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_response_valid_based_on_policy", Policy.ToString()));
			}
			return CacheValidationStatus.Continue;
		}
		if (!(base.Response is FtpWebResponse ftpWebResponse))
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_null_response_failure"));
			}
			return CacheValidationStatus.Continue;
		}
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_ftp_response_status", ((int)ftpWebResponse.StatusCode).ToString(CultureInfo.InvariantCulture), ftpWebResponse.StatusCode.ToString()));
		}
		if (base.ResponseCount > 1)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_resp_valid_based_on_retry", base.ResponseCount));
			}
			return CacheValidationStatus.Continue;
		}
		if (ftpWebResponse.StatusCode != FtpStatusCode.OpeningData && ftpWebResponse.StatusCode != FtpStatusCode.FileStatus)
		{
			return CacheValidationStatus.RetryResponseFromServer;
		}
		return CacheValidationStatus.Continue;
	}

	protected internal override CacheValidationStatus UpdateCache()
	{
		if (HttpProxyMode)
		{
			return base.UpdateCache();
		}
		base.CacheStreamOffset = 0L;
		if (base.RequestMethod == HttpMethod.Other)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_not_updated_based_on_policy", base.Request.Method));
			}
			return CacheValidationStatus.DoNotUpdateCache;
		}
		if (base.ValidationStatus == CacheValidationStatus.RemoveFromCache)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_removed_existing_invalid_entry"));
			}
			return CacheValidationStatus.RemoveFromCache;
		}
		if (Policy.Level == RequestCacheLevel.CacheOnly)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_not_updated_based_on_policy", Policy.ToString()));
			}
			return CacheValidationStatus.DoNotUpdateCache;
		}
		if (!(base.Response is FtpWebResponse ftpWebResponse))
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_not_updated_because_no_response"));
			}
			return CacheValidationStatus.DoNotUpdateCache;
		}
		if (base.RequestMethod == HttpMethod.Delete || base.RequestMethod == HttpMethod.Put)
		{
			if (base.RequestMethod == HttpMethod.Delete || ftpWebResponse.StatusCode == FtpStatusCode.OpeningData || ftpWebResponse.StatusCode == FtpStatusCode.DataAlreadyOpen || ftpWebResponse.StatusCode == FtpStatusCode.FileActionOK || ftpWebResponse.StatusCode == FtpStatusCode.ClosingData)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_removed_existing_based_on_method", base.Request.Method));
				}
				return CacheValidationStatus.RemoveFromCache;
			}
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_existing_not_removed_because_unexpected_response_status", (int)ftpWebResponse.StatusCode, ftpWebResponse.StatusCode.ToString()));
			}
			return CacheValidationStatus.DoNotUpdateCache;
		}
		if (Policy.Level == RequestCacheLevel.NoCacheNoStore)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_removed_existing_based_on_policy", Policy.ToString()));
			}
			return CacheValidationStatus.RemoveFromCache;
		}
		if (base.ValidationStatus == CacheValidationStatus.ReturnCachedResponse)
		{
			return UpdateCacheEntryOnRevalidate();
		}
		if (ftpWebResponse.StatusCode != FtpStatusCode.OpeningData && ftpWebResponse.StatusCode != FtpStatusCode.DataAlreadyOpen && ftpWebResponse.StatusCode != FtpStatusCode.ClosingData)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_not_updated_based_on_ftp_response_status", FtpStatusCode.OpeningData.ToString() + "|" + FtpStatusCode.DataAlreadyOpen.ToString() + "|" + FtpStatusCode.ClosingData, ftpWebResponse.StatusCode.ToString()));
			}
			return CacheValidationStatus.DoNotUpdateCache;
		}
		if (((FtpWebRequest)base.Request).ContentOffset != 0L)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_update_not_supported_for_ftp_restart", ((FtpWebRequest)base.Request).ContentOffset.ToString(CultureInfo.InvariantCulture)));
			}
			if (base.CacheEntry.LastModifiedUtc != DateTime.MinValue && ftpWebResponse.LastModified.ToUniversalTime() != base.CacheEntry.LastModifiedUtc)
			{
				if (Logging.On)
				{
					Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_removed_entry_because_ftp_restart_response_changed", base.CacheEntry.LastModifiedUtc.ToString("r", CultureInfo.InvariantCulture), ftpWebResponse.LastModified.ToUniversalTime().ToString("r", CultureInfo.InvariantCulture)));
				}
				return CacheValidationStatus.RemoveFromCache;
			}
			return CacheValidationStatus.DoNotUpdateCache;
		}
		return UpdateCacheEntryOnStore();
	}

	private CacheValidationStatus UpdateCacheEntryOnStore()
	{
		base.CacheEntry.EntryMetadata = null;
		base.CacheEntry.SystemMetadata = null;
		FtpWebResponse ftpWebResponse = base.Response as FtpWebResponse;
		if (ftpWebResponse.LastModified != DateTime.MinValue)
		{
			base.CacheEntry.LastModifiedUtc = ftpWebResponse.LastModified.ToUniversalTime();
		}
		base.ResponseEntityLength = base.Response.ContentLength;
		base.CacheEntry.StreamSize = base.ResponseEntityLength;
		base.CacheEntry.LastSynchronizedUtc = DateTime.UtcNow;
		return CacheValidationStatus.CacheResponse;
	}

	private CacheValidationStatus UpdateCacheEntryOnRevalidate()
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_last_synchronized", base.CacheEntry.LastSynchronizedUtc.ToString("r", CultureInfo.InvariantCulture)));
		}
		DateTime utcNow = DateTime.UtcNow;
		if (base.CacheEntry.LastSynchronizedUtc + TimeSpan.FromMinutes(1.0) >= utcNow)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_suppress_update_because_synched_last_minute"));
			}
			return CacheValidationStatus.DoNotUpdateCache;
		}
		base.CacheEntry.EntryMetadata = null;
		base.CacheEntry.SystemMetadata = null;
		base.CacheEntry.LastSynchronizedUtc = utcNow;
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_updating_last_synchronized", base.CacheEntry.LastSynchronizedUtc.ToString("r", CultureInfo.InvariantCulture)));
		}
		return CacheValidationStatus.UpdateResponseInformation;
	}

	private CacheValidationStatus TryConditionalRequest()
	{
		if (!(base.Request is FtpWebRequest { UseBinary: not false } ftpWebRequest))
		{
			return CacheValidationStatus.DoNotTakeFromCache;
		}
		if (ftpWebRequest.ContentOffset != 0L)
		{
			if (base.CacheEntry.IsPartialEntry || ftpWebRequest.ContentOffset >= base.CacheStreamLength)
			{
				return CacheValidationStatus.DoNotTakeFromCache;
			}
			base.CacheStreamOffset = ftpWebRequest.ContentOffset;
		}
		return CacheValidationStatus.Continue;
	}
}
