using System.Globalization;
using System.Reflection;

namespace System.Net;

internal class WebRequestPrefixElement
{
	public string Prefix;

	internal IWebRequestCreate creator;

	internal Type creatorType;

	public IWebRequestCreate Creator
	{
		get
		{
			if (creator == null && creatorType != null)
			{
				lock (this)
				{
					if (creator == null)
					{
						creator = (IWebRequestCreate)Activator.CreateInstance(creatorType, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, new object[0], CultureInfo.InvariantCulture);
					}
				}
			}
			return creator;
		}
		set
		{
			creator = value;
		}
	}

	public WebRequestPrefixElement(string P, Type creatorType)
	{
		if (!typeof(IWebRequestCreate).IsAssignableFrom(creatorType))
		{
			throw new InvalidCastException(SR.GetString("net_invalid_cast", creatorType.AssemblyQualifiedName, "IWebRequestCreate"));
		}
		Prefix = P;
		this.creatorType = creatorType;
	}

	public WebRequestPrefixElement(string P, IWebRequestCreate C)
	{
		Prefix = P;
		Creator = C;
	}
}
