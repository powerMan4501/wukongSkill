using System.Collections;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels;

[ComVisible(true)]
public class SinkProviderData
{
	private string _name;

	private Hashtable _properties = new Hashtable(StringComparer.InvariantCultureIgnoreCase);

	private ArrayList _children = new ArrayList();

	public string Name => _name;

	public IDictionary Properties => _properties;

	public IList Children => _children;

	public SinkProviderData(string name)
	{
		_name = name;
	}
}
