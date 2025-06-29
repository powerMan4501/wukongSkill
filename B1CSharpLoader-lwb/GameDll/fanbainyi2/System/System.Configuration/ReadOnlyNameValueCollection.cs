using System.Collections;
using System.Collections.Specialized;

namespace System.Configuration;

internal class ReadOnlyNameValueCollection : NameValueCollection
{
	internal ReadOnlyNameValueCollection(IEqualityComparer equalityComparer)
		: base(equalityComparer)
	{
	}

	internal ReadOnlyNameValueCollection(ReadOnlyNameValueCollection value)
		: base(value)
	{
	}

	internal void SetReadOnly()
	{
		base.IsReadOnly = true;
	}
}
