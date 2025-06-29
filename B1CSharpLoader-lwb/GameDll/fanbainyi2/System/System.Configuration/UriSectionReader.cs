using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Security.Permissions;
using System.Xml;

namespace System.Configuration;

internal class UriSectionReader
{
	private const string rootElementName = "configuration";

	private string configFilePath;

	private XmlReader reader;

	private UriSectionData sectionData;

	private UriSectionReader(string configFilePath, UriSectionData parentData)
	{
		this.configFilePath = configFilePath;
		sectionData = new UriSectionData();
		if (parentData == null)
		{
			return;
		}
		sectionData.IriParsing = parentData.IriParsing;
		sectionData.IdnScope = parentData.IdnScope;
		foreach (KeyValuePair<string, SchemeSettingInternal> schemeSetting in parentData.SchemeSettings)
		{
			sectionData.SchemeSettings.Add(schemeSetting.Key, schemeSetting.Value);
		}
	}

	public static UriSectionData Read(string configFilePath)
	{
		return Read(configFilePath, null);
	}

	public static UriSectionData Read(string configFilePath, UriSectionData parentData)
	{
		UriSectionReader uriSectionReader = new UriSectionReader(configFilePath, parentData);
		return uriSectionReader.GetSectionData();
	}

	private UriSectionData GetSectionData()
	{
		new FileIOPermission(FileIOPermissionAccess.Read, configFilePath).Assert();
		try
		{
			if (File.Exists(configFilePath))
			{
				using FileStream input = new FileStream(configFilePath, FileMode.Open, FileAccess.Read);
				XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
				xmlReaderSettings.IgnoreComments = true;
				xmlReaderSettings.IgnoreWhitespace = true;
				xmlReaderSettings.IgnoreProcessingInstructions = true;
				using (reader = XmlReader.Create(input, xmlReaderSettings))
				{
					if (ReadConfiguration())
					{
						return sectionData;
					}
				}
			}
		}
		catch (Exception)
		{
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
		return null;
	}

	private bool ReadConfiguration()
	{
		if (!ReadToUriSection())
		{
			return false;
		}
		while (reader.Read())
		{
			if (IsEndElement("uri"))
			{
				return true;
			}
			if (reader.NodeType != XmlNodeType.Element)
			{
				return false;
			}
			string name = reader.Name;
			if (AreEqual(name, "iriParsing"))
			{
				if (ReadIriParsing())
				{
					continue;
				}
			}
			else if (AreEqual(name, "idn"))
			{
				if (ReadIdnScope())
				{
					continue;
				}
			}
			else if (AreEqual(name, "schemeSettings") && ReadSchemeSettings())
			{
				continue;
			}
			return false;
		}
		return false;
	}

	private bool ReadIriParsing()
	{
		string attribute = reader.GetAttribute("enabled");
		if (bool.TryParse(attribute, out var result))
		{
			sectionData.IriParsing = result;
			return true;
		}
		return false;
	}

	private bool ReadIdnScope()
	{
		string attribute = reader.GetAttribute("enabled");
		try
		{
			sectionData.IdnScope = (UriIdnScope)Enum.Parse(typeof(UriIdnScope), attribute, ignoreCase: true);
			return true;
		}
		catch (ArgumentException)
		{
			return false;
		}
	}

	private bool ReadSchemeSettings()
	{
		while (reader.Read())
		{
			if (IsEndElement("schemeSettings"))
			{
				return true;
			}
			if (reader.NodeType != XmlNodeType.Element)
			{
				return false;
			}
			string name = reader.Name;
			if (AreEqual(name, "add"))
			{
				if (ReadAddSchemeSetting())
				{
					continue;
				}
			}
			else if (AreEqual(name, "remove"))
			{
				if (ReadRemoveSchemeSetting())
				{
					continue;
				}
			}
			else if (AreEqual(name, "clear"))
			{
				ClearSchemeSetting();
				continue;
			}
			return false;
		}
		return false;
	}

	private static bool AreEqual(string value1, string value2)
	{
		return string.Compare(value1, value2, StringComparison.OrdinalIgnoreCase) == 0;
	}

	private bool ReadAddSchemeSetting()
	{
		string attribute = reader.GetAttribute("name");
		string attribute2 = reader.GetAttribute("genericUriParserOptions");
		if (string.IsNullOrEmpty(attribute) || string.IsNullOrEmpty(attribute2))
		{
			return false;
		}
		try
		{
			GenericUriParserOptions options = (GenericUriParserOptions)Enum.Parse(typeof(GenericUriParserOptions), attribute2);
			SchemeSettingInternal schemeSettingInternal = new SchemeSettingInternal(attribute, options);
			sectionData.SchemeSettings[schemeSettingInternal.Name] = schemeSettingInternal;
			return true;
		}
		catch (ArgumentException)
		{
			return false;
		}
	}

	private bool ReadRemoveSchemeSetting()
	{
		string attribute = reader.GetAttribute("name");
		if (string.IsNullOrEmpty(attribute))
		{
			return false;
		}
		sectionData.SchemeSettings.Remove(attribute);
		return true;
	}

	private void ClearSchemeSetting()
	{
		sectionData.SchemeSettings.Clear();
	}

	private bool IsEndElement(string elementName)
	{
		if (reader.NodeType == XmlNodeType.EndElement)
		{
			return string.Compare(reader.Name, elementName, StringComparison.OrdinalIgnoreCase) == 0;
		}
		return false;
	}

	private bool ReadToUriSection()
	{
		if (!reader.ReadToFollowing("configuration"))
		{
			return false;
		}
		if (reader.Depth != 0)
		{
			return false;
		}
		do
		{
			if (!reader.ReadToFollowing("uri"))
			{
				return false;
			}
		}
		while (reader.Depth != 1);
		return true;
	}
}
