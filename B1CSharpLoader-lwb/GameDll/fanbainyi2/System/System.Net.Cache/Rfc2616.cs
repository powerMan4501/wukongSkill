using System.Collections;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;

namespace System.Net.Cache;

internal class Rfc2616
{
	internal enum TriState
	{
		Unknown,
		Valid,
		Invalid
	}

	internal static class Common
	{
		public const string PartialContentDescription = "Partial Content";

		public const string OkDescription = "OK";

		public static CacheValidationStatus OnValidateRequest(HttpRequestCacheValidator ctx)
		{
			if (ctx.RequestMethod >= HttpMethod.Post && ctx.RequestMethod <= HttpMethod.Delete)
			{
				if (ctx.Policy.Level == HttpRequestCacheLevel.CacheOnly)
				{
					ctx.FailRequest(WebExceptionStatus.RequestProhibitedByCachePolicy);
				}
				return CacheValidationStatus.DoNotTakeFromCache;
			}
			if (ctx.RequestMethod < HttpMethod.Head || ctx.RequestMethod > HttpMethod.Get)
			{
				if (ctx.Policy.Level == HttpRequestCacheLevel.CacheOnly)
				{
					ctx.FailRequest(WebExceptionStatus.RequestProhibitedByCachePolicy);
				}
				return CacheValidationStatus.DoNotUseCache;
			}
			if (ctx.Request.Headers["If-Modified-Since"] != null || ctx.Request.Headers["If-None-Match"] != null || ctx.Request.Headers["If-Range"] != null || ctx.Request.Headers["If-Match"] != null || ctx.Request.Headers["If-Unmodified-Since"] != null)
			{
				if (Logging.On)
				{
					Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_request_contains_conditional_header"));
				}
				if (ctx.Policy.Level == HttpRequestCacheLevel.CacheOnly)
				{
					ctx.FailRequest(WebExceptionStatus.RequestProhibitedByCachePolicy);
				}
				return CacheValidationStatus.DoNotTakeFromCache;
			}
			return CacheValidationStatus.Continue;
		}

		public static CacheFreshnessStatus ComputeFreshness(HttpRequestCacheValidator ctx)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_now_time", DateTime.UtcNow.ToString("r", CultureInfo.InvariantCulture)));
			}
			DateTime utcNow = DateTime.UtcNow;
			TimeSpan timeSpan = TimeSpan.MaxValue;
			DateTime dateTime = ctx.CacheDate;
			if (dateTime != DateTime.MinValue)
			{
				timeSpan = utcNow - dateTime;
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_age1_date_header", ((int)timeSpan.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo), ctx.CacheDate.ToString("r", CultureInfo.InvariantCulture)));
				}
			}
			else if (ctx.CacheEntry.LastSynchronizedUtc != DateTime.MinValue)
			{
				timeSpan = utcNow - ctx.CacheEntry.LastSynchronizedUtc;
				if (ctx.CacheAge != TimeSpan.MinValue)
				{
					timeSpan += ctx.CacheAge;
				}
				if (Logging.On)
				{
					if (ctx.CacheAge != TimeSpan.MinValue)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_age1_last_synchronized_age_header", ((int)timeSpan.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo), ctx.CacheEntry.LastSynchronizedUtc.ToString("r", CultureInfo.InvariantCulture), ((int)ctx.CacheAge.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo)));
					}
					else
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_age1_last_synchronized", ((int)timeSpan.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo), ctx.CacheEntry.LastSynchronizedUtc.ToString("r", CultureInfo.InvariantCulture)));
					}
				}
			}
			if (ctx.CacheAge != TimeSpan.MinValue)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_age2", ((int)ctx.CacheAge.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo)));
				}
				if (ctx.CacheAge > timeSpan || timeSpan == TimeSpan.MaxValue)
				{
					timeSpan = ctx.CacheAge;
				}
			}
			ctx.CacheAge = ((timeSpan < TimeSpan.Zero) ? TimeSpan.Zero : timeSpan);
			if (ctx.CacheAge != TimeSpan.MinValue)
			{
				if (!ctx.CacheEntry.IsPrivateEntry && ctx.CacheCacheControl.SMaxAge != -1)
				{
					ctx.CacheMaxAge = TimeSpan.FromSeconds(ctx.CacheCacheControl.SMaxAge);
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_max_age_cache_s_max_age", ((int)ctx.CacheMaxAge.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo)));
					}
					if (ctx.CacheAge < ctx.CacheMaxAge)
					{
						return CacheFreshnessStatus.Fresh;
					}
					return CacheFreshnessStatus.Stale;
				}
				if (ctx.CacheCacheControl.MaxAge != -1)
				{
					ctx.CacheMaxAge = TimeSpan.FromSeconds(ctx.CacheCacheControl.MaxAge);
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_max_age_cache_max_age", ((int)ctx.CacheMaxAge.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo)));
					}
					if (ctx.CacheAge < ctx.CacheMaxAge)
					{
						return CacheFreshnessStatus.Fresh;
					}
					return CacheFreshnessStatus.Stale;
				}
			}
			if (dateTime == DateTime.MinValue)
			{
				dateTime = ctx.CacheEntry.LastSynchronizedUtc;
			}
			DateTime dateTime2 = ctx.CacheEntry.ExpiresUtc;
			if (ctx.CacheExpires != DateTime.MinValue && ctx.CacheExpires < dateTime2)
			{
				dateTime2 = ctx.CacheExpires;
			}
			if (dateTime2 != DateTime.MinValue && dateTime != DateTime.MinValue && ctx.CacheAge != TimeSpan.MinValue)
			{
				ctx.CacheMaxAge = dateTime2 - dateTime;
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_max_age_expires_date", ((int)(dateTime2 - dateTime).TotalSeconds).ToString(NumberFormatInfo.InvariantInfo), dateTime2.ToString("r", CultureInfo.InvariantCulture)));
				}
				if (ctx.CacheAge < ctx.CacheMaxAge)
				{
					return CacheFreshnessStatus.Fresh;
				}
				return CacheFreshnessStatus.Stale;
			}
			if (dateTime2 != DateTime.MinValue)
			{
				ctx.CacheMaxAge = dateTime2 - DateTime.UtcNow;
				if (Logging.On)
				{
					Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_max_age_absolute", dateTime2.ToString("r", CultureInfo.InvariantCulture)));
				}
				if (dateTime2 < DateTime.UtcNow)
				{
					return CacheFreshnessStatus.Fresh;
				}
				return CacheFreshnessStatus.Stale;
			}
			ctx.HeuristicExpiration = true;
			DateTime dateTime3 = ctx.CacheEntry.LastModifiedUtc;
			if (ctx.CacheLastModified > dateTime3)
			{
				dateTime3 = ctx.CacheLastModified;
			}
			ctx.CacheMaxAge = ctx.UnspecifiedMaxAge;
			if (dateTime3 != DateTime.MinValue)
			{
				int num = (int)((utcNow - dateTime3).TotalSeconds / 10.0);
				ctx.CacheMaxAge = TimeSpan.FromSeconds(num);
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_no_max_age_use_10_percent", num.ToString(NumberFormatInfo.InvariantInfo), dateTime3.ToString("r", CultureInfo.InvariantCulture)));
				}
				if (ctx.CacheAge.TotalSeconds < (double)num)
				{
					return CacheFreshnessStatus.Fresh;
				}
				return CacheFreshnessStatus.Stale;
			}
			ctx.CacheMaxAge = ctx.UnspecifiedMaxAge;
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_no_max_age_use_default", ((int)ctx.UnspecifiedMaxAge.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo)));
			}
			if (ctx.CacheMaxAge >= ctx.CacheAge)
			{
				return CacheFreshnessStatus.Fresh;
			}
			return CacheFreshnessStatus.Stale;
		}

		internal static TriState OnUpdateCache(HttpRequestCacheValidator ctx, HttpWebResponse resp)
		{
			if (ctx.RequestMethod != HttpMethod.Head && ctx.RequestMethod != HttpMethod.Get && ctx.RequestMethod != HttpMethod.Post)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_not_a_get_head_post"));
				}
				return TriState.Unknown;
			}
			if (ctx.CacheStream == Stream.Null || ctx.CacheStatusCode == (HttpStatusCode)0)
			{
				if (resp.StatusCode == HttpStatusCode.NotModified)
				{
					if (Logging.On)
					{
						Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_cannot_update_cache_if_304"));
					}
					return TriState.Unknown;
				}
				if (ctx.RequestMethod == HttpMethod.Head)
				{
					if (Logging.On)
					{
						Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_cannot_update_cache_with_head_resp"));
					}
					return TriState.Unknown;
				}
			}
			if (resp == null)
			{
				if (Logging.On)
				{
					Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_http_resp_is_null"));
				}
				return TriState.Unknown;
			}
			if (ctx.ResponseCacheControl.NoStore)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_resp_cache_control_is_no_store"));
				}
				return TriState.Unknown;
			}
			if (ctx.ResponseDate != DateTime.MinValue && ctx.CacheDate != DateTime.MinValue && ctx.ResponseDate < ctx.CacheDate)
			{
				if (Logging.On)
				{
					Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_resp_older_than_cache"));
				}
				return TriState.Unknown;
			}
			if (ctx.ResponseCacheControl.Public)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_resp_cache_control_is_public"));
				}
				return TriState.Valid;
			}
			TriState triState = TriState.Unknown;
			if (ctx.ResponseCacheControl.Private)
			{
				if (!ctx.CacheEntry.IsPrivateEntry)
				{
					if (ctx.ResponseCacheControl.PrivateHeaders == null)
					{
						if (Logging.On)
						{
							Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_resp_cache_control_is_private"));
						}
						return TriState.Unknown;
					}
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_resp_cache_control_is_private_plus_headers"));
					}
					for (int i = 0; i < ctx.ResponseCacheControl.PrivateHeaders.Length; i++)
					{
						ctx.CacheHeaders.Remove(ctx.ResponseCacheControl.PrivateHeaders[i]);
						triState = TriState.Valid;
					}
				}
				else
				{
					triState = TriState.Valid;
				}
			}
			if (ctx.ResponseCacheControl.NoCache)
			{
				if (ctx.ResponseLastModified == DateTime.MinValue && ctx.Response.Headers.ETag == null)
				{
					if (Logging.On)
					{
						Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_revalidation_required"));
					}
					return TriState.Unknown;
				}
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_needs_revalidation"));
				}
				return TriState.Valid;
			}
			if (ctx.ResponseCacheControl.SMaxAge != -1 || ctx.ResponseCacheControl.MaxAge != -1)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_resp_allows_caching", ctx.ResponseCacheControl.ToString()));
				}
				return TriState.Valid;
			}
			if (!ctx.CacheEntry.IsPrivateEntry && ctx.Request.Headers["Authorization"] != null)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_auth_header_and_no_s_max_age"));
				}
				return TriState.Unknown;
			}
			if (ctx.RequestMethod == HttpMethod.Post && resp.Headers.Expires == null)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_post_resp_without_cache_control_or_expires"));
				}
				return TriState.Unknown;
			}
			if (resp.StatusCode == HttpStatusCode.NotModified || resp.StatusCode == HttpStatusCode.OK || resp.StatusCode == HttpStatusCode.NonAuthoritativeInformation || resp.StatusCode == HttpStatusCode.PartialContent || resp.StatusCode == HttpStatusCode.MultipleChoices || resp.StatusCode == HttpStatusCode.MovedPermanently || resp.StatusCode == HttpStatusCode.Gone)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_valid_based_on_status_code", (int)resp.StatusCode));
				}
				return TriState.Valid;
			}
			if (triState != TriState.Valid && Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_resp_no_cache_control", (int)resp.StatusCode));
			}
			return triState;
		}

		public static bool ValidateCacheByClientPolicy(HttpRequestCacheValidator ctx)
		{
			if (ctx.Policy.Level == HttpRequestCacheLevel.Default)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_age", (ctx.CacheAge != TimeSpan.MinValue) ? ((int)ctx.CacheAge.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo) : SR.GetString("net_log_unknown"), (ctx.CacheMaxAge != TimeSpan.MinValue) ? ((int)ctx.CacheMaxAge.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo) : SR.GetString("net_log_unknown")));
				}
				if (ctx.Policy.MinFresh > TimeSpan.Zero)
				{
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_policy_min_fresh", ((int)ctx.Policy.MinFresh.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo)));
					}
					if (ctx.CacheAge + ctx.Policy.MinFresh >= ctx.CacheMaxAge)
					{
						return false;
					}
				}
				if (ctx.Policy.MaxAge != TimeSpan.MaxValue)
				{
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_policy_max_age", ((int)ctx.Policy.MaxAge.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo)));
					}
					if (ctx.CacheAge >= ctx.Policy.MaxAge)
					{
						return false;
					}
				}
				if (ctx.Policy.InternalCacheSyncDateUtc != DateTime.MinValue)
				{
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_policy_cache_sync_date", ctx.Policy.InternalCacheSyncDateUtc.ToString("r", CultureInfo.CurrentCulture), ctx.CacheEntry.LastSynchronizedUtc.ToString(CultureInfo.CurrentCulture)));
					}
					if (ctx.CacheEntry.LastSynchronizedUtc < ctx.Policy.InternalCacheSyncDateUtc)
					{
						return false;
					}
				}
				TimeSpan timeSpan = ctx.CacheMaxAge;
				if (ctx.Policy.MaxStale > TimeSpan.Zero)
				{
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_policy_max_stale", ((int)ctx.Policy.MaxStale.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo)));
					}
					if (timeSpan < TimeSpan.MaxValue - ctx.Policy.MaxStale)
					{
						timeSpan += ctx.Policy.MaxStale;
					}
					else
					{
						timeSpan = TimeSpan.MaxValue;
					}
					if (ctx.CacheAge >= timeSpan)
					{
						return false;
					}
					return true;
				}
			}
			return ctx.CacheFreshnessStatus == CacheFreshnessStatus.Fresh;
		}

		internal static TriState ValidateCacheBySpecialCases(HttpRequestCacheValidator ctx)
		{
			if (ctx.CacheCacheControl.NoCache)
			{
				if (ctx.CacheCacheControl.NoCacheHeaders == null)
				{
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_control_no_cache"));
					}
					return TriState.Invalid;
				}
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_control_no_cache_removing_some_headers"));
				}
				for (int i = 0; i < ctx.CacheCacheControl.NoCacheHeaders.Length; i++)
				{
					ctx.CacheHeaders.Remove(ctx.CacheCacheControl.NoCacheHeaders[i]);
				}
			}
			if ((ctx.CacheCacheControl.MustRevalidate || (!ctx.CacheEntry.IsPrivateEntry && ctx.CacheCacheControl.ProxyRevalidate)) && ctx.CacheFreshnessStatus != CacheFreshnessStatus.Fresh)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_control_must_revalidate"));
				}
				return TriState.Invalid;
			}
			if (ctx.Request.Headers["Authorization"] != null)
			{
				if (ctx.CacheFreshnessStatus != CacheFreshnessStatus.Fresh)
				{
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_cached_auth_header"));
					}
					return TriState.Invalid;
				}
				if (!ctx.CacheEntry.IsPrivateEntry && ctx.CacheCacheControl.SMaxAge == -1 && !ctx.CacheCacheControl.MustRevalidate && !ctx.CacheCacheControl.Public)
				{
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_cached_auth_header_no_control_directive"));
					}
					return TriState.Invalid;
				}
			}
			return TriState.Valid;
		}

		public static CacheValidationStatus ValidateCacheAfterResponse(HttpRequestCacheValidator ctx, HttpWebResponse resp)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_after_validation"));
			}
			if ((ctx.CacheStream == Stream.Null || ctx.CacheStatusCode == (HttpStatusCode)0) && resp.StatusCode == HttpStatusCode.NotModified)
			{
				if (Logging.On)
				{
					Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_resp_status_304"));
				}
				return CacheValidationStatus.DoNotTakeFromCache;
			}
			if (ctx.RequestMethod == HttpMethod.Head)
			{
				bool flag = false;
				if (ctx.ResponseEntityLength != -1 && ctx.ResponseEntityLength != ctx.CacheEntityLength)
				{
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_head_resp_has_different_content_length"));
					}
					flag = true;
				}
				if (resp.Headers["Content-MD5"] != ctx.CacheHeaders["Content-MD5"])
				{
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_head_resp_has_different_content_md5"));
					}
					flag = true;
				}
				if (resp.Headers.ETag != ctx.CacheHeaders.ETag)
				{
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_head_resp_has_different_etag"));
					}
					flag = true;
				}
				if (resp.StatusCode != HttpStatusCode.NotModified && resp.Headers.LastModified != ctx.CacheHeaders.LastModified)
				{
					if (Logging.On)
					{
						Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_304_head_resp_has_different_last_modified"));
					}
					flag = true;
				}
				if (flag)
				{
					if (Logging.On)
					{
						Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_existing_entry_has_to_be_discarded"));
					}
					return CacheValidationStatus.RemoveFromCache;
				}
			}
			if (resp.StatusCode == HttpStatusCode.PartialContent)
			{
				if (ctx.CacheHeaders.ETag != ctx.Response.Headers.ETag || (ctx.CacheHeaders.LastModified != ctx.Response.Headers.LastModified && (ctx.Response.Headers.LastModified != null || ctx.Response.Headers.ETag == null)))
				{
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_206_resp_non_matching_entry"));
					}
					if (Logging.On)
					{
						Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_existing_entry_should_be_discarded"));
					}
					return CacheValidationStatus.RemoveFromCache;
				}
				if (ctx.CacheEntry.StreamSize != ctx.ResponseRangeStart)
				{
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_206_resp_starting_position_not_adjusted"));
					}
					return CacheValidationStatus.DoNotTakeFromCache;
				}
				ReplaceOrUpdateCacheHeaders(ctx, resp);
				if (ctx.RequestRangeUser)
				{
					ctx.CacheStreamOffset = ctx.CacheEntry.StreamSize;
					ctx.CacheStreamLength = ctx.ResponseRangeEnd - ctx.ResponseRangeStart + 1;
					ctx.CacheEntityLength = ctx.ResponseEntityLength;
					ctx.CacheStatusCode = resp.StatusCode;
					ctx.CacheStatusDescription = resp.StatusDescription;
					ctx.CacheHttpVersion = resp.ProtocolVersion;
				}
				else
				{
					ctx.CacheStreamOffset = 0L;
					ctx.CacheStreamLength = ctx.ResponseEntityLength;
					ctx.CacheEntityLength = ctx.ResponseEntityLength;
					ctx.CacheStatusCode = HttpStatusCode.OK;
					ctx.CacheStatusDescription = "OK";
					ctx.CacheHttpVersion = resp.ProtocolVersion;
					ctx.CacheHeaders.Remove("Content-Range");
					if (ctx.CacheStreamLength == -1)
					{
						ctx.CacheHeaders.Remove("Content-Length");
					}
					else
					{
						ctx.CacheHeaders["Content-Length"] = ctx.CacheStreamLength.ToString(NumberFormatInfo.InvariantInfo);
					}
				}
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_combined_resp_requested"));
				}
				return CacheValidationStatus.CombineCachedAndServerResponse;
			}
			if (resp.StatusCode == HttpStatusCode.NotModified)
			{
				WebHeaderCollection headers = resp.Headers;
				string text = null;
				string text2 = null;
				if (ctx.CacheExpires != ctx.ResponseExpires || ctx.CacheLastModified != ctx.ResponseLastModified || ctx.CacheDate != ctx.ResponseDate || ctx.ResponseCacheControl.IsNotEmpty || ((text = headers["Content-Location"]) != null && text != ctx.CacheHeaders["Content-Location"]) || ((text2 = headers.ETag) != null && text2 != ctx.CacheHeaders.ETag))
				{
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_updating_headers_on_304"));
					}
					ReplaceOrUpdateCacheHeaders(ctx, resp);
					return CacheValidationStatus.ReturnCachedResponse;
				}
				int num = 0;
				if (text2 != null)
				{
					num++;
				}
				if (text != null)
				{
					num++;
				}
				if (ctx.ResponseAge != TimeSpan.MinValue)
				{
					num++;
				}
				if (ctx.ResponseLastModified != DateTime.MinValue)
				{
					num++;
				}
				if (ctx.ResponseExpires != DateTime.MinValue)
				{
					num++;
				}
				if (ctx.ResponseDate != DateTime.MinValue)
				{
					num++;
				}
				if (headers.Via != null)
				{
					num++;
				}
				if (headers["Connection"] != null)
				{
					num++;
				}
				if (headers["Keep-Alive"] != null)
				{
					num++;
				}
				if (headers.ProxyAuthenticate != null)
				{
					num++;
				}
				if (headers["Proxy-Authorization"] != null)
				{
					num++;
				}
				if (headers["TE"] != null)
				{
					num++;
				}
				if (headers["Transfer-Encoding"] != null)
				{
					num++;
				}
				if (headers["Trailer"] != null)
				{
					num++;
				}
				if (headers["Upgrade"] != null)
				{
					num++;
				}
				if (resp.Headers.Count <= num)
				{
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_suppressing_headers_update_on_304"));
					}
					ctx.CacheDontUpdateHeaders = true;
				}
				else
				{
					ReplaceOrUpdateCacheHeaders(ctx, resp);
				}
				return CacheValidationStatus.ReturnCachedResponse;
			}
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_status_code_not_304_206"));
			}
			return CacheValidationStatus.DoNotTakeFromCache;
		}

		public static CacheValidationStatus ValidateCacheOn5XXResponse(HttpRequestCacheValidator ctx)
		{
			if (ctx.CacheStream == Stream.Null || ctx.CacheStatusCode == (HttpStatusCode)0)
			{
				return CacheValidationStatus.DoNotTakeFromCache;
			}
			if (ctx.CacheEntityLength != ctx.CacheEntry.StreamSize || ctx.CacheStatusCode == HttpStatusCode.PartialContent)
			{
				return CacheValidationStatus.DoNotTakeFromCache;
			}
			if (ValidateCacheBySpecialCases(ctx) != TriState.Valid)
			{
				return CacheValidationStatus.DoNotTakeFromCache;
			}
			if (ctx.Policy.Level == HttpRequestCacheLevel.CacheOnly || ctx.Policy.Level == HttpRequestCacheLevel.CacheIfAvailable || ctx.Policy.Level == HttpRequestCacheLevel.CacheOrNextCacheOnly)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_sxx_resp_cache_only"));
				}
				return CacheValidationStatus.ReturnCachedResponse;
			}
			if ((ctx.Policy.Level == HttpRequestCacheLevel.Default || ctx.Policy.Level == HttpRequestCacheLevel.Revalidate) && ValidateCacheByClientPolicy(ctx))
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_sxx_resp_can_be_replaced"));
				}
				ctx.CacheHeaders.Add("Warning", "111 Revalidation failed");
				return CacheValidationStatus.ReturnCachedResponse;
			}
			return CacheValidationStatus.DoNotTakeFromCache;
		}

		internal static TriState ValidateCacheByVaryHeader(HttpRequestCacheValidator ctx)
		{
			string[] values = ctx.CacheHeaders.GetValues("Vary");
			if (values == null)
			{
				return TriState.Unknown;
			}
			ArrayList arrayList = new ArrayList();
			HttpRequestCacheValidator.ParseHeaderValues(values, HttpRequestCacheValidator.ParseValuesCallback, arrayList);
			if (arrayList.Count == 0)
			{
				if (Logging.On)
				{
					Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_vary_header_empty"));
				}
				return TriState.Invalid;
			}
			if (((string)arrayList[0])[0] == '*')
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_vary_header_contains_asterisks"));
				}
				return TriState.Invalid;
			}
			if (ctx.SystemMeta == null || ctx.SystemMeta.Count == 0)
			{
				if (Logging.On)
				{
					Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_no_headers_in_metadata"));
				}
				return TriState.Invalid;
			}
			for (int i = 0; i < arrayList.Count; i++)
			{
				string[] values2 = ctx.Request.Headers.GetValues((string)arrayList[i]);
				ArrayList arrayList2 = new ArrayList();
				if (values2 != null)
				{
					HttpRequestCacheValidator.ParseHeaderValues(values2, HttpRequestCacheValidator.ParseValuesCallback, arrayList2);
				}
				string[] values3 = ctx.SystemMeta.GetValues((string)arrayList[i]);
				ArrayList arrayList3 = new ArrayList();
				if (values3 != null)
				{
					HttpRequestCacheValidator.ParseHeaderValues(values3, HttpRequestCacheValidator.ParseValuesCallback, arrayList3);
				}
				if (arrayList2.Count != arrayList3.Count)
				{
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_vary_header_mismatched_count", (string)arrayList[i]));
					}
					return TriState.Invalid;
				}
				for (int j = 0; j < arrayList3.Count; j++)
				{
					if (!AsciiLettersNoCaseEqual((string)arrayList3[j], (string)arrayList2[j]))
					{
						if (Logging.On)
						{
							Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_vary_header_mismatched_field", (string)arrayList[i], (string)arrayList3[j], (string)arrayList2[j]));
						}
						return TriState.Invalid;
					}
				}
			}
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_vary_header_match"));
			}
			return TriState.Valid;
		}

		public static CacheValidationStatus TryConditionalRequest(HttpRequestCacheValidator ctx)
		{
			string ranges;
			switch (CheckForRangeRequest(ctx, out ranges))
			{
			case TriState.Invalid:
				return CacheValidationStatus.Continue;
			case TriState.Valid:
				if (ctx is FtpRequestCacheValidator)
				{
					return CacheValidationStatus.DoNotTakeFromCache;
				}
				if (TryConditionalRangeRequest(ctx))
				{
					ctx.RequestRangeCache = true;
					((HttpWebRequest)ctx.Request).AddRange((int)ctx.CacheEntry.StreamSize);
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_range", ctx.Request.Headers["Range"]));
					}
					return CacheValidationStatus.Continue;
				}
				return CacheValidationStatus.DoNotTakeFromCache;
			default:
				return ConstructConditionalRequest(ctx);
			}
		}

		public static CacheValidationStatus TryResponseFromCache(HttpRequestCacheValidator ctx)
		{
			string ranges;
			switch (CheckForRangeRequest(ctx, out ranges))
			{
			case TriState.Unknown:
				return CacheValidationStatus.ReturnCachedResponse;
			case TriState.Invalid:
			{
				long start = 0L;
				long end = 0L;
				long total = 0L;
				if (!GetBytesRange(ranges, ref start, ref end, ref total, isRequest: true))
				{
					if (Logging.On)
					{
						Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_range_invalid_format", ranges));
					}
					return CacheValidationStatus.DoNotTakeFromCache;
				}
				if (start >= ctx.CacheEntry.StreamSize || end > ctx.CacheEntry.StreamSize || (end == -1 && ctx.CacheEntityLength == -1) || (end == -1 && ctx.CacheEntityLength > ctx.CacheEntry.StreamSize) || (start == -1 && (end == -1 || ctx.CacheEntityLength == -1 || ctx.CacheEntityLength - end >= ctx.CacheEntry.StreamSize)))
				{
					if (Logging.On)
					{
						Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_range_not_in_cache", ranges));
					}
					return CacheValidationStatus.Continue;
				}
				if (start == -1)
				{
					start = ctx.CacheEntityLength - end;
				}
				if (end <= 0)
				{
					end = ctx.CacheEntry.StreamSize - 1;
				}
				ctx.CacheStreamOffset = start;
				ctx.CacheStreamLength = end - start + 1;
				Construct206PartialContent(ctx, (int)start);
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_range_in_cache", ctx.CacheHeaders["Content-Range"]));
				}
				return CacheValidationStatus.ReturnCachedResponse;
			}
			default:
				if (ctx.Policy.Level == HttpRequestCacheLevel.CacheOnly && ((object)ctx.Uri.Scheme == Uri.UriSchemeHttp || (object)ctx.Uri.Scheme == Uri.UriSchemeHttps))
				{
					ctx.CacheStreamOffset = 0L;
					ctx.CacheStreamLength = ctx.CacheEntry.StreamSize;
					Construct206PartialContent(ctx, 0);
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_partial_resp", ctx.CacheHeaders["Content-Range"]));
					}
					return CacheValidationStatus.ReturnCachedResponse;
				}
				if (ctx.CacheEntry.StreamSize >= int.MaxValue)
				{
					if (Logging.On)
					{
						Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_entry_size_too_big", ctx.CacheEntry.StreamSize));
					}
					return CacheValidationStatus.DoNotTakeFromCache;
				}
				if (TryConditionalRangeRequest(ctx))
				{
					ctx.RequestRangeCache = true;
					((HttpWebRequest)ctx.Request).AddRange((int)ctx.CacheEntry.StreamSize);
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_range", ctx.Request.Headers["Range"]));
					}
					return CacheValidationStatus.Continue;
				}
				return CacheValidationStatus.Continue;
			}
		}

		private static TriState CheckForRangeRequest(HttpRequestCacheValidator ctx, out string ranges)
		{
			if ((ranges = ctx.Request.Headers["Range"]) != null)
			{
				ctx.RequestRangeUser = true;
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_range_request_range", ctx.Request.Headers["Range"]));
				}
				return TriState.Invalid;
			}
			if (ctx.CacheStatusCode == HttpStatusCode.PartialContent && ctx.CacheEntityLength == ctx.CacheEntry.StreamSize)
			{
				ctx.CacheStatusCode = HttpStatusCode.OK;
				ctx.CacheStatusDescription = "OK";
				return TriState.Unknown;
			}
			if (ctx.CacheEntry.IsPartialEntry || (ctx.CacheEntityLength != -1 && ctx.CacheEntityLength != ctx.CacheEntry.StreamSize) || ctx.CacheStatusCode == HttpStatusCode.PartialContent)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_could_be_partial", ctx.CacheEntry.StreamSize, ctx.CacheEntityLength));
				}
				return TriState.Valid;
			}
			return TriState.Unknown;
		}

		public static CacheValidationStatus ConstructConditionalRequest(HttpRequestCacheValidator ctx)
		{
			CacheValidationStatus cacheValidationStatus = CacheValidationStatus.DoNotTakeFromCache;
			bool flag = false;
			string eTag = ctx.CacheHeaders.ETag;
			if (eTag != null)
			{
				cacheValidationStatus = CacheValidationStatus.Continue;
				ctx.Request.Headers["If-None-Match"] = eTag;
				ctx.RequestIfHeader1 = "If-None-Match";
				ctx.RequestValidator1 = eTag;
				flag = true;
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_condition_if_none_match", ctx.Request.Headers["If-None-Match"]));
				}
			}
			if (ctx.CacheEntry.LastModifiedUtc != DateTime.MinValue)
			{
				cacheValidationStatus = CacheValidationStatus.Continue;
				eTag = ctx.CacheEntry.LastModifiedUtc.ToString("r", CultureInfo.InvariantCulture);
				ctx.Request.Headers.ChangeInternal("If-Modified-Since", eTag);
				if (flag)
				{
					ctx.RequestIfHeader2 = "If-Modified-Since";
					ctx.RequestValidator2 = eTag;
				}
				else
				{
					ctx.RequestIfHeader1 = "If-Modified-Since";
					ctx.RequestValidator1 = eTag;
				}
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_condition_if_modified_since", ctx.Request.Headers["If-Modified-Since"]));
				}
			}
			if (Logging.On && cacheValidationStatus == CacheValidationStatus.DoNotTakeFromCache)
			{
				Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_cannot_construct_conditional_request"));
			}
			return cacheValidationStatus;
		}

		private static bool TryConditionalRangeRequest(HttpRequestCacheValidator ctx)
		{
			if (ctx.CacheEntry.StreamSize >= int.MaxValue)
			{
				if (Logging.On)
				{
					Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_entry_size_too_big", ctx.CacheEntry.StreamSize));
				}
				return false;
			}
			string eTag = ctx.CacheHeaders.ETag;
			if (eTag != null)
			{
				ctx.Request.Headers["If-Range"] = eTag;
				ctx.RequestIfHeader1 = "If-Range";
				ctx.RequestValidator1 = eTag;
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_condition_if_range", ctx.Request.Headers["If-Range"]));
				}
				return true;
			}
			if (ctx.CacheEntry.LastModifiedUtc != DateTime.MinValue)
			{
				eTag = ctx.CacheEntry.LastModifiedUtc.ToString("r", CultureInfo.InvariantCulture);
				if (ctx.CacheHttpVersion.Major == 1 && ctx.CacheHttpVersion.Minor == 0)
				{
					if (Logging.On)
					{
						Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_conditional_range_not_implemented_on_http_10"));
					}
					return false;
				}
				ctx.Request.Headers["If-Range"] = eTag;
				ctx.RequestIfHeader1 = "If-Range";
				ctx.RequestValidator1 = eTag;
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_condition_if_range", ctx.Request.Headers["If-Range"]));
				}
				return true;
			}
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_cannot_construct_conditional_range_request"));
			}
			return false;
		}

		public static void Construct206PartialContent(HttpRequestCacheValidator ctx, int rangeStart)
		{
			ctx.CacheStatusCode = HttpStatusCode.PartialContent;
			ctx.CacheStatusDescription = "Partial Content";
			if (ctx.CacheHttpVersion == null)
			{
				ctx.CacheHttpVersion = new Version(1, 1);
			}
			string value = "bytes " + rangeStart + "-" + (rangeStart + ctx.CacheStreamLength - 1) + "/" + ((ctx.CacheEntityLength <= 0) ? "*" : ctx.CacheEntityLength.ToString(NumberFormatInfo.InvariantInfo));
			ctx.CacheHeaders["Content-Range"] = value;
			ctx.CacheHeaders["Content-Length"] = ctx.CacheStreamLength.ToString(NumberFormatInfo.InvariantInfo);
			ctx.CacheEntry.IsPartialEntry = true;
		}

		public static void Construct200ok(HttpRequestCacheValidator ctx)
		{
			ctx.CacheStatusCode = HttpStatusCode.OK;
			ctx.CacheStatusDescription = "OK";
			if (ctx.CacheHttpVersion == null)
			{
				ctx.CacheHttpVersion = new Version(1, 1);
			}
			ctx.CacheHeaders.Remove("Content-Range");
			if (ctx.CacheEntityLength == -1)
			{
				ctx.CacheHeaders.Remove("Content-Length");
			}
			else
			{
				ctx.CacheHeaders["Content-Length"] = ctx.CacheEntityLength.ToString(NumberFormatInfo.InvariantInfo);
			}
			ctx.CacheEntry.IsPartialEntry = false;
		}

		public static void ConstructUnconditionalRefreshRequest(HttpRequestCacheValidator ctx)
		{
			WebHeaderCollection headers = ctx.Request.Headers;
			headers["Cache-Control"] = "max-age=0";
			headers["Pragma"] = "no-cache";
			if (ctx.RequestIfHeader1 != null)
			{
				headers.RemoveInternal(ctx.RequestIfHeader1);
				ctx.RequestIfHeader1 = null;
			}
			if (ctx.RequestIfHeader2 != null)
			{
				headers.RemoveInternal(ctx.RequestIfHeader2);
				ctx.RequestIfHeader2 = null;
			}
			if (ctx.RequestRangeCache)
			{
				headers.RemoveInternal("Range");
				ctx.RequestRangeCache = false;
			}
		}

		public static void ReplaceOrUpdateCacheHeaders(HttpRequestCacheValidator ctx, HttpWebResponse resp)
		{
			if (ctx.CacheHeaders == null || (resp.StatusCode != HttpStatusCode.NotModified && resp.StatusCode != HttpStatusCode.PartialContent))
			{
				ctx.CacheHeaders = new WebHeaderCollection();
			}
			string[] values = resp.Headers.GetValues("Vary");
			if (values != null)
			{
				ArrayList arrayList = new ArrayList();
				HttpRequestCacheValidator.ParseHeaderValues(values, HttpRequestCacheValidator.ParseValuesCallback, arrayList);
				if (arrayList.Count != 0 && ((string)arrayList[0])[0] != '*')
				{
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_saving_request_headers", resp.Headers["Vary"]));
					}
					if (ctx.SystemMeta == null)
					{
						ctx.SystemMeta = new NameValueCollection(arrayList.Count + 1, CaseInsensitiveAscii.StaticInstance);
					}
					for (int i = 0; i < arrayList.Count; i++)
					{
						string value = ctx.Request.Headers[(string)arrayList[i]];
						ctx.SystemMeta[(string)arrayList[i]] = value;
					}
				}
			}
			for (int j = 0; j < ctx.Response.Headers.Count; j++)
			{
				string key = ctx.Response.Headers.GetKey(j);
				if (!AsciiLettersNoCaseEqual(key, "Connection") && !AsciiLettersNoCaseEqual(key, "Keep-Alive") && !AsciiLettersNoCaseEqual(key, "Proxy-Authenticate") && !AsciiLettersNoCaseEqual(key, "Proxy-Authorization") && !AsciiLettersNoCaseEqual(key, "TE") && !AsciiLettersNoCaseEqual(key, "Transfer-Encoding") && !AsciiLettersNoCaseEqual(key, "Trailer") && !AsciiLettersNoCaseEqual(key, "Upgrade") && (resp.StatusCode != HttpStatusCode.NotModified || !AsciiLettersNoCaseEqual(key, "Content-Length")))
				{
					ctx.CacheHeaders.ChangeInternal(key, ctx.Response.Headers[j]);
				}
			}
		}

		private static bool AsciiLettersNoCaseEqual(string s1, string s2)
		{
			if (s1.Length != s2.Length)
			{
				return false;
			}
			for (int i = 0; i < s1.Length; i++)
			{
				if ((s1[i] | 0x20) != (s2[i] | 0x20))
				{
					return false;
				}
			}
			return true;
		}

		internal unsafe static bool UnsafeAsciiLettersNoCaseEqual(char* s1, int start, int length, string s2)
		{
			if (length - start < s2.Length)
			{
				return false;
			}
			for (int i = 0; i < s2.Length; i++)
			{
				if ((s1[start + i] | 0x20) != (s2[i] | 0x20))
				{
					return false;
				}
			}
			return true;
		}

		public static bool GetBytesRange(string ranges, ref long start, ref long end, ref long total, bool isRequest)
		{
			ranges = ranges.ToLower(CultureInfo.InvariantCulture);
			int i;
			for (i = 0; i < ranges.Length && ranges[i] == ' '; i++)
			{
			}
			i += 5;
			if (i >= ranges.Length || ranges[i - 5] != 'b' || ranges[i - 4] != 'y' || ranges[i - 3] != 't' || ranges[i - 2] != 'e' || ranges[i - 1] != 's')
			{
				if (Logging.On)
				{
					Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_only_byte_range_implemented"));
				}
				return false;
			}
			if (isRequest)
			{
				for (; i < ranges.Length && ranges[i] == ' '; i++)
				{
				}
				if (ranges[i] != '=')
				{
					return false;
				}
			}
			else if (ranges[i] != ' ')
			{
				return false;
			}
			char c = '\0';
			while (++i < ranges.Length && (c = ranges[i]) == ' ')
			{
			}
			start = -1L;
			if (c != '-')
			{
				if (i < ranges.Length && c >= '0' && c <= '9')
				{
					start = c - 48;
					while (++i < ranges.Length && (c = ranges[i]) >= '0' && c <= '9')
					{
						start = start * 10 + (c - 48);
					}
				}
				while (i < ranges.Length && c == ' ')
				{
					c = ranges[++i];
				}
				if (c != '-')
				{
					return false;
				}
			}
			while (i < ranges.Length && (c = ranges[++i]) == ' ')
			{
			}
			end = -1L;
			if (i < ranges.Length && c >= '0' && c <= '9')
			{
				end = c - 48;
				while (++i < ranges.Length && (c = ranges[i]) >= '0' && c <= '9')
				{
					end = end * 10 + (c - 48);
				}
			}
			if (isRequest)
			{
				while (i < ranges.Length)
				{
					if (ranges[i++] != ' ')
					{
						if (Logging.On)
						{
							Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_multiple_complex_range_not_implemented"));
						}
						return false;
					}
				}
			}
			else
			{
				for (; i < ranges.Length; i++)
				{
					if ((c = ranges[i]) != ' ')
					{
						break;
					}
				}
				if (c != '/')
				{
					return false;
				}
				while (++i < ranges.Length && (c = ranges[i]) == ' ')
				{
				}
				total = -1L;
				if (c != '*' && i < ranges.Length && c >= '0' && c <= '9')
				{
					total = c - 48;
					while (++i < ranges.Length && (c = ranges[i]) >= '0' && c <= '9')
					{
						total = total * 10 + (c - 48);
					}
				}
			}
			if (!isRequest && (start == -1 || end == -1))
			{
				return false;
			}
			return true;
		}
	}

	private Rfc2616()
	{
	}

	public static CacheValidationStatus OnValidateRequest(HttpRequestCacheValidator ctx)
	{
		CacheValidationStatus cacheValidationStatus = Common.OnValidateRequest(ctx);
		if (cacheValidationStatus == CacheValidationStatus.DoNotUseCache)
		{
			return cacheValidationStatus;
		}
		ctx.Request.Headers.RemoveInternal("Pragma");
		ctx.Request.Headers.RemoveInternal("Cache-Control");
		if (ctx.Policy.Level == HttpRequestCacheLevel.NoCacheNoStore)
		{
			ctx.Request.Headers.AddInternal("Cache-Control", "no-store");
			ctx.Request.Headers.AddInternal("Cache-Control", "no-cache");
			ctx.Request.Headers.AddInternal("Pragma", "no-cache");
			cacheValidationStatus = CacheValidationStatus.DoNotTakeFromCache;
		}
		else if (cacheValidationStatus == CacheValidationStatus.Continue)
		{
			if (ctx.Policy.Level == HttpRequestCacheLevel.Reload || ctx.Policy.Level == HttpRequestCacheLevel.NoCacheNoStore)
			{
				ctx.Request.Headers.AddInternal("Cache-Control", "no-cache");
				ctx.Request.Headers.AddInternal("Pragma", "no-cache");
				cacheValidationStatus = CacheValidationStatus.DoNotTakeFromCache;
			}
			else if (ctx.Policy.Level == HttpRequestCacheLevel.Refresh)
			{
				ctx.Request.Headers.AddInternal("Cache-Control", "max-age=0");
				ctx.Request.Headers.AddInternal("Pragma", "no-cache");
				cacheValidationStatus = CacheValidationStatus.DoNotTakeFromCache;
			}
			else if (ctx.Policy.Level == HttpRequestCacheLevel.Default)
			{
				if (ctx.Policy.MinFresh > TimeSpan.Zero)
				{
					ctx.Request.Headers.AddInternal("Cache-Control", "min-fresh=" + (int)ctx.Policy.MinFresh.TotalSeconds);
				}
				if (ctx.Policy.MaxAge != TimeSpan.MaxValue)
				{
					ctx.Request.Headers.AddInternal("Cache-Control", "max-age=" + (int)ctx.Policy.MaxAge.TotalSeconds);
				}
				if (ctx.Policy.MaxStale > TimeSpan.Zero)
				{
					ctx.Request.Headers.AddInternal("Cache-Control", "max-stale=" + (int)ctx.Policy.MaxStale.TotalSeconds);
				}
			}
			else if (ctx.Policy.Level == HttpRequestCacheLevel.CacheOnly || ctx.Policy.Level == HttpRequestCacheLevel.CacheOrNextCacheOnly)
			{
				ctx.Request.Headers.AddInternal("Cache-Control", "only-if-cached");
			}
		}
		return cacheValidationStatus;
	}

	public static CacheFreshnessStatus OnValidateFreshness(HttpRequestCacheValidator ctx)
	{
		CacheFreshnessStatus result = Common.ComputeFreshness(ctx);
		if (ctx.Uri.Query.Length != 0)
		{
			if (ctx.CacheHeaders.Expires == null && (ctx.CacheEntry.IsPrivateEntry ? (ctx.CacheCacheControl.MaxAge == -1) : (ctx.CacheCacheControl.SMaxAge == -1)))
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_uri_with_query_has_no_expiration"));
				}
				return CacheFreshnessStatus.Stale;
			}
			if (ctx.CacheHttpVersion.Major <= 1 && ctx.CacheHttpVersion.Minor < 1)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_uri_with_query_and_cached_resp_from_http_10"));
				}
				return CacheFreshnessStatus.Stale;
			}
		}
		return result;
	}

	public static CacheValidationStatus OnValidateCache(HttpRequestCacheValidator ctx)
	{
		if (Common.ValidateCacheByVaryHeader(ctx) == TriState.Invalid)
		{
			return CacheValidationStatus.DoNotTakeFromCache;
		}
		if (ctx.Policy.Level == HttpRequestCacheLevel.Revalidate)
		{
			return Common.TryConditionalRequest(ctx);
		}
		if (Common.ValidateCacheBySpecialCases(ctx) == TriState.Invalid)
		{
			if (ctx.Policy.Level == HttpRequestCacheLevel.CacheOnly)
			{
				return CacheValidationStatus.DoNotTakeFromCache;
			}
			return Common.TryConditionalRequest(ctx);
		}
		if (Common.ValidateCacheByClientPolicy(ctx) || ctx.Policy.Level == HttpRequestCacheLevel.CacheOnly || ctx.Policy.Level == HttpRequestCacheLevel.CacheIfAvailable || ctx.Policy.Level == HttpRequestCacheLevel.CacheOrNextCacheOnly)
		{
			CacheValidationStatus cacheValidationStatus = Common.TryResponseFromCache(ctx);
			if (cacheValidationStatus != CacheValidationStatus.ReturnCachedResponse)
			{
				if (ctx.Policy.Level == HttpRequestCacheLevel.CacheOnly)
				{
					return CacheValidationStatus.DoNotTakeFromCache;
				}
				return cacheValidationStatus;
			}
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_valid_as_fresh_or_because_policy", ctx.Policy.ToString()));
			}
			return CacheValidationStatus.ReturnCachedResponse;
		}
		return Common.TryConditionalRequest(ctx);
	}

	public static CacheValidationStatus OnValidateResponse(HttpRequestCacheValidator ctx)
	{
		if (ctx.ResponseCount > 1)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_accept_based_on_retry_count", ctx.ResponseCount));
			}
			return CacheValidationStatus.Continue;
		}
		if (ctx.RequestRangeUser)
		{
			return CacheValidationStatus.Continue;
		}
		if (ctx.CacheDate != DateTime.MinValue && ctx.ResponseDate != DateTime.MinValue && ctx.CacheDate > ctx.ResponseDate)
		{
			if (Logging.On)
			{
				Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_date_header_older_than_cache_entry"));
			}
			Common.ConstructUnconditionalRefreshRequest(ctx);
			return CacheValidationStatus.RetryResponseFromServer;
		}
		HttpWebResponse httpWebResponse = ctx.Response as HttpWebResponse;
		if (ctx.RequestRangeCache && httpWebResponse.StatusCode == HttpStatusCode.RequestedRangeNotSatisfiable)
		{
			if (Logging.On)
			{
				Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_server_didnt_satisfy_range", ctx.Request.Headers["Range"]));
			}
			Common.ConstructUnconditionalRefreshRequest(ctx);
			return CacheValidationStatus.RetryResponseFromServer;
		}
		if (httpWebResponse.StatusCode == HttpStatusCode.NotModified)
		{
			if (ctx.RequestIfHeader1 == null)
			{
				if (Logging.On)
				{
					Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_304_received_on_unconditional_request"));
				}
				Common.ConstructUnconditionalRefreshRequest(ctx);
				return CacheValidationStatus.RetryResponseFromServer;
			}
			if (ctx.RequestRangeCache)
			{
				if (Logging.On)
				{
					Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_304_received_on_unconditional_request_expected_200_206"));
				}
				Common.ConstructUnconditionalRefreshRequest(ctx);
				return CacheValidationStatus.RetryResponseFromServer;
			}
		}
		if (ctx.CacheHttpVersion.Major <= 1 && httpWebResponse.ProtocolVersion.Major <= 1 && ctx.CacheHttpVersion.Minor < 1 && httpWebResponse.ProtocolVersion.Minor < 1 && ctx.CacheLastModified > ctx.ResponseLastModified)
		{
			if (Logging.On)
			{
				Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_last_modified_header_older_than_cache_entry"));
			}
			Common.ConstructUnconditionalRefreshRequest(ctx);
			return CacheValidationStatus.RetryResponseFromServer;
		}
		if (ctx.Policy.Level == HttpRequestCacheLevel.Default && ctx.ResponseAge != TimeSpan.MinValue && (ctx.ResponseAge > ctx.Policy.MaxAge || (ctx.ResponseExpires != DateTime.MinValue && ctx.Policy.MinFresh > TimeSpan.Zero && ctx.ResponseExpires - DateTime.UtcNow < ctx.Policy.MinFresh) || (ctx.Policy.MaxStale > TimeSpan.Zero && DateTime.UtcNow - ctx.ResponseExpires > ctx.Policy.MaxStale)))
		{
			if (Logging.On)
			{
				Logging.PrintError(Logging.RequestCache, SR.GetString("net_log_cache_freshness_outside_policy_limits"));
			}
			Common.ConstructUnconditionalRefreshRequest(ctx);
			return CacheValidationStatus.RetryResponseFromServer;
		}
		if (ctx.RequestIfHeader1 != null)
		{
			ctx.Request.Headers.RemoveInternal(ctx.RequestIfHeader1);
			ctx.RequestIfHeader1 = null;
		}
		if (ctx.RequestIfHeader2 != null)
		{
			ctx.Request.Headers.RemoveInternal(ctx.RequestIfHeader2);
			ctx.RequestIfHeader2 = null;
		}
		if (ctx.RequestRangeCache)
		{
			ctx.Request.Headers.RemoveInternal("Range");
			ctx.RequestRangeCache = false;
		}
		return CacheValidationStatus.Continue;
	}

	public static CacheValidationStatus OnUpdateCache(HttpRequestCacheValidator ctx)
	{
		if (ctx.CacheStatusCode == HttpStatusCode.NotModified)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_need_to_remove_invalid_cache_entry_304"));
			}
			return CacheValidationStatus.RemoveFromCache;
		}
		HttpWebResponse httpWebResponse = ctx.Response as HttpWebResponse;
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_resp_status", httpWebResponse.StatusCode));
		}
		if (ctx.ValidationStatus == CacheValidationStatus.RemoveFromCache)
		{
			return CacheValidationStatus.RemoveFromCache;
		}
		CacheValidationStatus result = (((ctx.RequestMethod >= HttpMethod.Post && ctx.RequestMethod <= HttpMethod.Delete) || ctx.RequestMethod == HttpMethod.Other) ? CacheValidationStatus.RemoveFromCache : CacheValidationStatus.DoNotUpdateCache);
		if (Common.OnUpdateCache(ctx, httpWebResponse) != TriState.Valid)
		{
			return result;
		}
		CacheValidationStatus result2 = CacheValidationStatus.CacheResponse;
		ctx.CacheEntry.IsPartialEntry = false;
		if (httpWebResponse.StatusCode == HttpStatusCode.NotModified || ctx.RequestMethod == HttpMethod.Head)
		{
			result2 = CacheValidationStatus.UpdateResponseInformation;
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_resp_304_or_request_head"));
			}
			if (ctx.CacheDontUpdateHeaders)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_dont_update_cached_headers"));
				}
				ctx.CacheHeaders = null;
				ctx.CacheEntry.ExpiresUtc = ctx.ResponseExpires;
				ctx.CacheEntry.LastModifiedUtc = ctx.ResponseLastModified;
				if (ctx.Policy.Level == HttpRequestCacheLevel.Default)
				{
					ctx.CacheEntry.MaxStale = ctx.Policy.MaxStale;
				}
				else
				{
					ctx.CacheEntry.MaxStale = TimeSpan.MinValue;
				}
				ctx.CacheEntry.LastSynchronizedUtc = DateTime.UtcNow;
			}
			else if (Logging.On)
			{
				Logging.PrintInfo(Logging.RequestCache, SR.GetString("net_log_cache_update_cached_headers"));
			}
		}
		else if (httpWebResponse.StatusCode == HttpStatusCode.PartialContent)
		{
			if (ctx.CacheEntry.StreamSize != ctx.ResponseRangeStart && ctx.ResponseRangeStart != 0L)
			{
				if (Logging.On)
				{
					Logging.PrintWarning(Logging.RequestCache, SR.GetString("net_log_cache_partial_resp_not_combined_with_existing_entry", ctx.CacheEntry.StreamSize, ctx.ResponseRangeStart));
				}
				return result;
			}
			if (!ctx.RequestRangeUser)
			{
				ctx.CacheStreamOffset = 0L;
			}
			Common.ReplaceOrUpdateCacheHeaders(ctx, httpWebResponse);
			ctx.CacheHttpVersion = httpWebResponse.ProtocolVersion;
			ctx.CacheEntityLength = ctx.ResponseEntityLength;
			long cacheStreamLength = (ctx.CacheEntry.StreamSize = ctx.ResponseRangeEnd + 1);
			ctx.CacheStreamLength = cacheStreamLength;
			if (ctx.CacheEntityLength > 0 && ctx.CacheEntityLength == ctx.CacheEntry.StreamSize)
			{
				Common.Construct200ok(ctx);
			}
			else
			{
				Common.Construct206PartialContent(ctx, 0);
			}
		}
		else
		{
			Common.ReplaceOrUpdateCacheHeaders(ctx, httpWebResponse);
			ctx.CacheHttpVersion = httpWebResponse.ProtocolVersion;
			ctx.CacheStatusCode = httpWebResponse.StatusCode;
			ctx.CacheStatusDescription = httpWebResponse.StatusDescription;
			ctx.CacheEntry.StreamSize = httpWebResponse.ContentLength;
		}
		return result2;
	}
}
