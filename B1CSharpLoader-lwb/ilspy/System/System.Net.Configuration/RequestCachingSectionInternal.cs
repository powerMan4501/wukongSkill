using System.Configuration;
using System.Net.Cache;
using System.Threading;
using Microsoft.Win32;

namespace System.Net.Configuration;

internal sealed class RequestCachingSectionInternal
{
	private static object classSyncObject;

	private RequestCache defaultCache;

	private HttpRequestCachePolicy defaultHttpCachePolicy;

	private RequestCachePolicy defaultFtpCachePolicy;

	private RequestCachePolicy defaultCachePolicy;

	private bool disableAllCaching;

	private HttpRequestCacheValidator httpRequestCacheValidator;

	private FtpRequestCacheValidator ftpRequestCacheValidator;

	private bool isPrivateCache;

	private TimeSpan unspecifiedMaximumAge;

	internal static object ClassSyncObject
	{
		get
		{
			if (classSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange(ref classSyncObject, value, null);
			}
			return classSyncObject;
		}
	}

	internal bool DisableAllCaching => disableAllCaching;

	internal RequestCache DefaultCache => defaultCache;

	internal RequestCachePolicy DefaultCachePolicy => defaultCachePolicy;

	internal bool IsPrivateCache => isPrivateCache;

	internal TimeSpan UnspecifiedMaximumAge => unspecifiedMaximumAge;

	internal HttpRequestCachePolicy DefaultHttpCachePolicy => defaultHttpCachePolicy;

	internal RequestCachePolicy DefaultFtpCachePolicy => defaultFtpCachePolicy;

	internal HttpRequestCacheValidator DefaultHttpValidator => httpRequestCacheValidator;

	internal FtpRequestCacheValidator DefaultFtpValidator => ftpRequestCacheValidator;

	private RequestCachingSectionInternal()
	{
	}

	internal RequestCachingSectionInternal(RequestCachingSection section)
	{
		if (!section.DisableAllCaching)
		{
			defaultCachePolicy = new RequestCachePolicy(section.DefaultPolicyLevel);
			isPrivateCache = section.IsPrivateCache;
			unspecifiedMaximumAge = section.UnspecifiedMaximumAge;
		}
		else
		{
			disableAllCaching = true;
		}
		httpRequestCacheValidator = new HttpRequestCacheValidator(strictCacheErrors: false, UnspecifiedMaximumAge);
		ftpRequestCacheValidator = new FtpRequestCacheValidator(strictCacheErrors: false, UnspecifiedMaximumAge);
		defaultCache = new WinInetCache(IsPrivateCache, canWrite: true, async: true);
		if (section.DisableAllCaching)
		{
			return;
		}
		HttpCachePolicyElement httpCachePolicyElement = section.DefaultHttpCachePolicy;
		if (httpCachePolicyElement.WasReadFromConfig)
		{
			if (httpCachePolicyElement.PolicyLevel == HttpRequestCacheLevel.Default)
			{
				defaultHttpCachePolicy = new HttpRequestCachePolicy((httpCachePolicyElement.MinimumFresh != TimeSpan.MinValue) ? HttpCacheAgeControl.MaxAgeAndMinFresh : HttpCacheAgeControl.MaxAgeAndMaxStale, httpCachePolicyElement.MaximumAge, (httpCachePolicyElement.MinimumFresh != TimeSpan.MinValue) ? httpCachePolicyElement.MinimumFresh : httpCachePolicyElement.MaximumStale);
			}
			else
			{
				defaultHttpCachePolicy = new HttpRequestCachePolicy(httpCachePolicyElement.PolicyLevel);
			}
		}
		FtpCachePolicyElement ftpCachePolicyElement = section.DefaultFtpCachePolicy;
		if (ftpCachePolicyElement.WasReadFromConfig)
		{
			defaultFtpCachePolicy = new RequestCachePolicy(ftpCachePolicyElement.PolicyLevel);
		}
	}

	internal static RequestCachingSectionInternal GetSection()
	{
		lock (ClassSyncObject)
		{
			if (!(System.Configuration.PrivilegedConfigurationManager.GetSection(ConfigurationStrings.RequestCachingSectionPath) is RequestCachingSection section))
			{
				return null;
			}
			try
			{
				return new RequestCachingSectionInternal(section);
			}
			catch (Exception ex)
			{
				if (NclUtilities.IsFatal(ex))
				{
					throw;
				}
				throw new ConfigurationErrorsException(SR.GetString("net_config_requestcaching"), ex);
			}
		}
	}
}
