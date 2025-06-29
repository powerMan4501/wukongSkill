using System.Configuration.Internal;
using System.IO;
using System.Xml;

namespace System.Configuration;

public class NameValueFileSectionHandler : IConfigurationSectionHandler
{
	public object Create(object parent, object configContext, XmlNode section)
	{
		object parent2 = parent;
		XmlNode xmlNode = section.Attributes.RemoveNamedItem("file");
		parent2 = NameValueSectionHandler.CreateStatic(parent2, section);
		if (xmlNode != null && xmlNode.Value.Length != 0)
		{
			string text = null;
			text = xmlNode.Value;
			if (!(xmlNode is IConfigErrorInfo { Filename: var filename }))
			{
				return null;
			}
			string directoryName = Path.GetDirectoryName(filename);
			string text2 = Path.Combine(directoryName, text);
			if (File.Exists(text2))
			{
				ConfigXmlDocument configXmlDocument = new ConfigXmlDocument();
				try
				{
					configXmlDocument.Load(text2);
				}
				catch (XmlException ex)
				{
					throw new ConfigurationErrorsException(ex.Message, ex, text2, ex.LineNumber);
				}
				if (section.Name != configXmlDocument.DocumentElement.Name)
				{
					throw new ConfigurationErrorsException(SR.GetString("Config_name_value_file_section_file_invalid_root", section.Name), configXmlDocument.DocumentElement);
				}
				parent2 = NameValueSectionHandler.CreateStatic(parent2, configXmlDocument.DocumentElement);
			}
		}
		return parent2;
	}
}
