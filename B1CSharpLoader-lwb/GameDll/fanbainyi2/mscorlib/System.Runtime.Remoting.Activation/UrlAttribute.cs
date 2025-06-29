using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Security;

namespace System.Runtime.Remoting.Activation;

[Serializable]
[SecurityCritical]
[ComVisible(true)]
public sealed class UrlAttribute : ContextAttribute
{
	private string url;

	private static string propertyName = "UrlAttribute";

	public string UrlValue
	{
		[SecurityCritical]
		get
		{
			return url;
		}
	}

	[SecurityCritical]
	public UrlAttribute(string callsiteURL)
		: base(propertyName)
	{
		if (callsiteURL == null)
		{
			throw new ArgumentNullException("callsiteURL");
		}
		url = callsiteURL;
	}

	[SecuritySafeCritical]
	public override bool Equals(object o)
	{
		if (o is IContextProperty && o is UrlAttribute)
		{
			return ((UrlAttribute)o).UrlValue.Equals(url);
		}
		return false;
	}

	[SecuritySafeCritical]
	public override int GetHashCode()
	{
		return url.GetHashCode();
	}

	[SecurityCritical]
	[ComVisible(true)]
	public override bool IsContextOK(Context ctx, IConstructionCallMessage msg)
	{
		return false;
	}

	[SecurityCritical]
	[ComVisible(true)]
	public override void GetPropertiesForNewContext(IConstructionCallMessage ctorMsg)
	{
	}
}
