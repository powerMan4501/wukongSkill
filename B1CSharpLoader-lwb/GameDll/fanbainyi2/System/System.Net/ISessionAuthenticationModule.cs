namespace System.Net;

internal interface ISessionAuthenticationModule : IAuthenticationModule
{
	bool CanUseDefaultCredentials { get; }

	bool Update(string challenge, WebRequest webRequest);

	void ClearSession(WebRequest webRequest);
}
