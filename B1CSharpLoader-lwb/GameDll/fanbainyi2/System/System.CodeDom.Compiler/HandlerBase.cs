using System.Configuration;
using System.Globalization;
using System.Xml;

namespace System.CodeDom.Compiler;

internal static class HandlerBase
{
	private static XmlNode GetAndRemoveAttribute(XmlNode node, string attrib, bool fRequired)
	{
		XmlNode xmlNode = node.Attributes.RemoveNamedItem(attrib);
		if (fRequired && xmlNode == null)
		{
			throw new ConfigurationErrorsException(SR.GetString("Config_missing_required_attribute", attrib, node.Name), node);
		}
		return xmlNode;
	}

	private static XmlNode GetAndRemoveStringAttributeInternal(XmlNode node, string attrib, bool fRequired, ref string val)
	{
		XmlNode andRemoveAttribute = GetAndRemoveAttribute(node, attrib, fRequired);
		if (andRemoveAttribute != null)
		{
			val = andRemoveAttribute.Value;
		}
		return andRemoveAttribute;
	}

	internal static XmlNode GetAndRemoveStringAttribute(XmlNode node, string attrib, ref string val)
	{
		return GetAndRemoveStringAttributeInternal(node, attrib, fRequired: false, ref val);
	}

	internal static XmlNode GetAndRemoveRequiredNonEmptyStringAttribute(XmlNode node, string attrib, ref string val)
	{
		return GetAndRemoveNonEmptyStringAttributeInternal(node, attrib, fRequired: true, ref val);
	}

	private static XmlNode GetAndRemoveNonEmptyStringAttributeInternal(XmlNode node, string attrib, bool fRequired, ref string val)
	{
		XmlNode andRemoveStringAttributeInternal = GetAndRemoveStringAttributeInternal(node, attrib, fRequired, ref val);
		if (andRemoveStringAttributeInternal != null && val.Length == 0)
		{
			throw new ConfigurationErrorsException(SR.GetString("Empty_attribute", attrib), andRemoveStringAttributeInternal);
		}
		return andRemoveStringAttributeInternal;
	}

	private static XmlNode GetAndRemoveIntegerAttributeInternal(XmlNode node, string attrib, bool fRequired, ref int val)
	{
		XmlNode andRemoveAttribute = GetAndRemoveAttribute(node, attrib, fRequired);
		if (andRemoveAttribute != null)
		{
			if (andRemoveAttribute.Value.Trim() != andRemoveAttribute.Value)
			{
				throw new ConfigurationErrorsException(SR.GetString("Config_invalid_integer_attribute", andRemoveAttribute.Name), andRemoveAttribute);
			}
			try
			{
				val = int.Parse(andRemoveAttribute.Value, CultureInfo.InvariantCulture);
			}
			catch (Exception inner)
			{
				throw new ConfigurationErrorsException(SR.GetString("Config_invalid_integer_attribute", andRemoveAttribute.Name), inner, andRemoveAttribute);
			}
		}
		return andRemoveAttribute;
	}

	private static XmlNode GetAndRemoveNonNegativeAttributeInternal(XmlNode node, string attrib, bool fRequired, ref int val)
	{
		XmlNode andRemoveIntegerAttributeInternal = GetAndRemoveIntegerAttributeInternal(node, attrib, fRequired, ref val);
		if (andRemoveIntegerAttributeInternal != null && val < 0)
		{
			throw new ConfigurationErrorsException(SR.GetString("Invalid_nonnegative_integer_attribute", attrib), andRemoveIntegerAttributeInternal);
		}
		return andRemoveIntegerAttributeInternal;
	}

	internal static XmlNode GetAndRemoveNonNegativeIntegerAttribute(XmlNode node, string attrib, ref int val)
	{
		return GetAndRemoveNonNegativeAttributeInternal(node, attrib, fRequired: false, ref val);
	}

	internal static void CheckForUnrecognizedAttributes(XmlNode node)
	{
		if (node.Attributes.Count != 0)
		{
			throw new ConfigurationErrorsException(SR.GetString("Config_base_unrecognized_attribute", node.Attributes[0].Name), node.Attributes[0]);
		}
	}

	internal static void CheckForNonElement(XmlNode node)
	{
		if (node.NodeType != XmlNodeType.Element)
		{
			throw new ConfigurationErrorsException(SR.GetString("Config_base_elements_only"), node);
		}
	}

	internal static bool IsIgnorableAlsoCheckForNonElement(XmlNode node)
	{
		if (node.NodeType == XmlNodeType.Comment || node.NodeType == XmlNodeType.Whitespace)
		{
			return true;
		}
		CheckForNonElement(node);
		return false;
	}

	internal static void CheckForChildNodes(XmlNode node)
	{
		if (node.HasChildNodes)
		{
			throw new ConfigurationErrorsException(SR.GetString("Config_base_no_child_nodes"), node.FirstChild);
		}
	}

	internal static void ThrowUnrecognizedElement(XmlNode node)
	{
		throw new ConfigurationErrorsException(SR.GetString("Config_base_unrecognized_element"), node);
	}
}
