using System.Collections;
using System.Collections.Generic;

namespace System;

internal class ConfigNode
{
	private string m_name;

	private string m_value;

	private ConfigNode m_parent;

	private List<ConfigNode> m_children = new List<ConfigNode>(5);

	private List<DictionaryEntry> m_attributes = new List<DictionaryEntry>(5);

	internal string Name => m_name;

	internal string Value
	{
		get
		{
			return m_value;
		}
		set
		{
			m_value = value;
		}
	}

	internal ConfigNode Parent => m_parent;

	internal List<ConfigNode> Children => m_children;

	internal List<DictionaryEntry> Attributes => m_attributes;

	internal ConfigNode(string name, ConfigNode parent)
	{
		m_name = name;
		m_parent = parent;
	}

	internal void AddChild(ConfigNode child)
	{
		child.m_parent = this;
		m_children.Add(child);
	}

	internal int AddAttribute(string key, string value)
	{
		m_attributes.Add(new DictionaryEntry(key, value));
		return m_attributes.Count - 1;
	}

	internal void ReplaceAttribute(int index, string key, string value)
	{
		m_attributes[index] = new DictionaryEntry(key, value);
	}
}
