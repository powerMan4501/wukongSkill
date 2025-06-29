using System.Collections;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace System.Runtime.Remoting.Channels;

[Serializable]
[SecurityCritical]
[ComVisible(true)]
[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.Infrastructure)]
public class TransportHeaders : ITransportHeaders
{
	private ArrayList _headerList;

	public object this[object key]
	{
		[SecurityCritical]
		get
		{
			string strB = (string)key;
			foreach (DictionaryEntry header in _headerList)
			{
				if (string.Compare((string)header.Key, strB, StringComparison.OrdinalIgnoreCase) == 0)
				{
					return header.Value;
				}
			}
			return null;
		}
		[SecurityCritical]
		set
		{
			if (key == null)
			{
				return;
			}
			string strB = (string)key;
			for (int num = _headerList.Count - 1; num >= 0; num--)
			{
				string strA = (string)((DictionaryEntry)_headerList[num]).Key;
				if (string.Compare(strA, strB, StringComparison.OrdinalIgnoreCase) == 0)
				{
					_headerList.RemoveAt(num);
					break;
				}
			}
			if (value != null)
			{
				_headerList.Add(new DictionaryEntry(key, value));
			}
		}
	}

	public TransportHeaders()
	{
		_headerList = new ArrayList(6);
	}

	[SecurityCritical]
	public IEnumerator GetEnumerator()
	{
		return _headerList.GetEnumerator();
	}
}
