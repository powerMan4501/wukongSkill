using System.Collections;
using System.Xml;

namespace System.Configuration;

public class DictionarySectionHandler : IConfigurationSectionHandler
{
	protected virtual string KeyAttributeName => "key";

	protected virtual string ValueAttributeName => "value";

	internal virtual bool ValueRequired => false;

	public virtual object Create(object parent, object context, XmlNode section)
	{
		Hashtable hashtable = ((parent != null) ? ((Hashtable)((Hashtable)parent).Clone()) : new Hashtable(StringComparer.OrdinalIgnoreCase));
		HandlerBase.CheckForUnrecognizedAttributes(section);
		foreach (XmlNode childNode in section.ChildNodes)
		{
			if (HandlerBase.IsIgnorableAlsoCheckForNonElement(childNode))
			{
				continue;
			}
			if (childNode.Name == "add")
			{
				HandlerBase.CheckForChildNodes(childNode);
				string key = HandlerBase.RemoveRequiredAttribute(childNode, KeyAttributeName);
				string text = ((!ValueRequired) ? HandlerBase.RemoveAttribute(childNode, ValueAttributeName) : HandlerBase.RemoveRequiredAttribute(childNode, ValueAttributeName));
				HandlerBase.CheckForUnrecognizedAttributes(childNode);
				if (text == null)
				{
					text = "";
				}
				hashtable[key] = text;
			}
			else if (childNode.Name == "remove")
			{
				HandlerBase.CheckForChildNodes(childNode);
				string key2 = HandlerBase.RemoveRequiredAttribute(childNode, KeyAttributeName);
				HandlerBase.CheckForUnrecognizedAttributes(childNode);
				hashtable.Remove(key2);
			}
			else if (childNode.Name.Equals("clear"))
			{
				HandlerBase.CheckForChildNodes(childNode);
				HandlerBase.CheckForUnrecognizedAttributes(childNode);
				hashtable.Clear();
			}
			else
			{
				HandlerBase.ThrowUnrecognizedElement(childNode);
			}
		}
		return hashtable;
	}
}
