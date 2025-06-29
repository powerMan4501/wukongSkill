using System.Xml;

namespace System.Configuration;

public class NameValueSectionHandler : IConfigurationSectionHandler
{
	private const string defaultKeyAttribute = "key";

	private const string defaultValueAttribute = "value";

	protected virtual string KeyAttributeName => "key";

	protected virtual string ValueAttributeName => "value";

	public object Create(object parent, object context, XmlNode section)
	{
		return CreateStatic(parent, section, KeyAttributeName, ValueAttributeName);
	}

	internal static object CreateStatic(object parent, XmlNode section)
	{
		return CreateStatic(parent, section, "key", "value");
	}

	internal static object CreateStatic(object parent, XmlNode section, string keyAttriuteName, string valueAttributeName)
	{
		ReadOnlyNameValueCollection readOnlyNameValueCollection;
		if (parent == null)
		{
			readOnlyNameValueCollection = new ReadOnlyNameValueCollection(StringComparer.OrdinalIgnoreCase);
		}
		else
		{
			ReadOnlyNameValueCollection value = (ReadOnlyNameValueCollection)parent;
			readOnlyNameValueCollection = new ReadOnlyNameValueCollection(value);
		}
		HandlerBase.CheckForUnrecognizedAttributes(section);
		foreach (XmlNode childNode in section.ChildNodes)
		{
			if (!HandlerBase.IsIgnorableAlsoCheckForNonElement(childNode))
			{
				if (childNode.Name == "add")
				{
					string name = HandlerBase.RemoveRequiredAttribute(childNode, keyAttriuteName);
					string value2 = HandlerBase.RemoveRequiredAttribute(childNode, valueAttributeName, allowEmpty: true);
					HandlerBase.CheckForUnrecognizedAttributes(childNode);
					readOnlyNameValueCollection[name] = value2;
				}
				else if (childNode.Name == "remove")
				{
					string name2 = HandlerBase.RemoveRequiredAttribute(childNode, keyAttriuteName);
					HandlerBase.CheckForUnrecognizedAttributes(childNode);
					readOnlyNameValueCollection.Remove(name2);
				}
				else if (childNode.Name.Equals("clear"))
				{
					HandlerBase.CheckForUnrecognizedAttributes(childNode);
					readOnlyNameValueCollection.Clear();
				}
				else
				{
					HandlerBase.ThrowUnrecognizedElement(childNode);
				}
			}
		}
		readOnlyNameValueCollection.SetReadOnly();
		return readOnlyNameValueCollection;
	}
}
