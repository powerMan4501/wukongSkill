namespace System.Net.Cache;

internal enum CacheValidationStatus
{
	DoNotUseCache,
	Fail,
	DoNotTakeFromCache,
	RetryResponseFromCache,
	RetryResponseFromServer,
	ReturnCachedResponse,
	CombineCachedAndServerResponse,
	CacheResponse,
	UpdateResponseInformation,
	RemoveFromCache,
	DoNotUpdateCache,
	Continue
}
