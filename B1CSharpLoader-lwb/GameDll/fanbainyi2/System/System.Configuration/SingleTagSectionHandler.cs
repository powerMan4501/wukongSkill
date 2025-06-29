using System.Collections;
using System.Xml;

namespace System.Configuration;

public class SingleTagSectionHandler : IConfigurationSectionHandler
{
	public virtual object Create(object parent, object context, XmlNode section)
	{
		Hashtable hashtable = ((parent != null) ? new Hashtable((IDictionary)parent) : new Hashtable());
		HandlerBase.CheckForChildNodes(section);
		foreach (XmlAttribute attribute in section.Attributes)
		{
			hashtable[attribute.Name] = attribute.Value;
		}
		return hashtable;
	}
}
