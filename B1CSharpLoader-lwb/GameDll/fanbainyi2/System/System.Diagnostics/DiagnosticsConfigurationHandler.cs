using System.Collections;
using System.Configuration;
using System.Globalization;
using System.Reflection;
using System.Xml;

namespace System.Diagnostics;

[Obsolete("This class has been deprecated.  http://go.microsoft.com/fwlink/?linkid=14202")]
public class DiagnosticsConfigurationHandler : IConfigurationSectionHandler
{
	public virtual object Create(object parent, object configContext, XmlNode section)
	{
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		HandlerBase.CheckForUnrecognizedAttributes(section);
		Hashtable hashtable = (Hashtable)parent;
		Hashtable hashtable2 = ((hashtable != null) ? ((Hashtable)hashtable.Clone()) : new Hashtable());
		foreach (XmlNode childNode in section.ChildNodes)
		{
			if (HandlerBase.IsIgnorableAlsoCheckForNonElement(childNode))
			{
				continue;
			}
			switch (childNode.Name)
			{
			case "switches":
				if (flag)
				{
					throw new ConfigurationErrorsException(SR.GetString("ConfigSectionsUnique", "switches"));
				}
				flag = true;
				HandleSwitches(hashtable2, childNode, configContext);
				break;
			case "assert":
				if (flag2)
				{
					throw new ConfigurationErrorsException(SR.GetString("ConfigSectionsUnique", "assert"));
				}
				flag2 = true;
				HandleAssert(hashtable2, childNode, configContext);
				break;
			case "trace":
				if (flag3)
				{
					throw new ConfigurationErrorsException(SR.GetString("ConfigSectionsUnique", "trace"));
				}
				flag3 = true;
				HandleTrace(hashtable2, childNode, configContext);
				break;
			case "performanceCounters":
				if (flag4)
				{
					throw new ConfigurationErrorsException(SR.GetString("ConfigSectionsUnique", "performanceCounters"));
				}
				flag4 = true;
				HandleCounters((Hashtable)parent, hashtable2, childNode, configContext);
				break;
			default:
				HandlerBase.ThrowUnrecognizedElement(childNode);
				break;
			}
			HandlerBase.CheckForUnrecognizedAttributes(childNode);
		}
		return hashtable2;
	}

	private static void HandleSwitches(Hashtable config, XmlNode switchesNode, object context)
	{
		Hashtable hashtable = (Hashtable)new SwitchesDictionarySectionHandler().Create(config["switches"], context, switchesNode);
		IDictionaryEnumerator enumerator = hashtable.GetEnumerator();
		while (enumerator.MoveNext())
		{
			try
			{
				int.Parse((string)enumerator.Value, CultureInfo.InvariantCulture);
			}
			catch
			{
				throw new ConfigurationErrorsException(SR.GetString("Value_must_be_numeric", enumerator.Key));
			}
		}
		config["switches"] = hashtable;
	}

	private static void HandleAssert(Hashtable config, XmlNode assertNode, object context)
	{
		bool val = false;
		if (HandlerBase.GetAndRemoveBooleanAttribute(assertNode, "assertuienabled", ref val) != null)
		{
			config["assertuienabled"] = val;
		}
		string val2 = null;
		if (HandlerBase.GetAndRemoveStringAttribute(assertNode, "logfilename", ref val2) != null)
		{
			config["logfilename"] = val2;
		}
		HandlerBase.CheckForChildNodes(assertNode);
	}

	private static void HandleCounters(Hashtable parent, Hashtable config, XmlNode countersNode, object context)
	{
		int val = 0;
		if (HandlerBase.GetAndRemoveIntegerAttribute(countersNode, "filemappingsize", ref val) != null && parent == null)
		{
			config["filemappingsize"] = val;
		}
		HandlerBase.CheckForChildNodes(countersNode);
	}

	private static void HandleTrace(Hashtable config, XmlNode traceNode, object context)
	{
		bool flag = false;
		bool val = false;
		if (HandlerBase.GetAndRemoveBooleanAttribute(traceNode, "autoflush", ref val) != null)
		{
			config["autoflush"] = val;
		}
		int val2 = 0;
		if (HandlerBase.GetAndRemoveIntegerAttribute(traceNode, "indentsize", ref val2) != null)
		{
			config["indentsize"] = val2;
		}
		foreach (XmlNode childNode in traceNode.ChildNodes)
		{
			if (HandlerBase.IsIgnorableAlsoCheckForNonElement(childNode))
			{
				continue;
			}
			if (childNode.Name == "listeners")
			{
				if (flag)
				{
					throw new ConfigurationErrorsException(SR.GetString("ConfigSectionsUnique", "listeners"));
				}
				flag = true;
				HandleListeners(config, childNode, context);
			}
			else
			{
				HandlerBase.ThrowUnrecognizedElement(childNode);
			}
		}
	}

	private static void HandleListeners(Hashtable config, XmlNode listenersNode, object context)
	{
		HandlerBase.CheckForUnrecognizedAttributes(listenersNode);
		foreach (XmlNode childNode in listenersNode.ChildNodes)
		{
			if (HandlerBase.IsIgnorableAlsoCheckForNonElement(childNode))
			{
				continue;
			}
			string val = null;
			string val2 = null;
			string val3 = null;
			string name = childNode.Name;
			switch (name)
			{
			default:
				HandlerBase.ThrowUnrecognizedElement(childNode);
				break;
			case "add":
			case "remove":
			case "clear":
				break;
			}
			HandlerBase.GetAndRemoveStringAttribute(childNode, "name", ref val);
			HandlerBase.GetAndRemoveStringAttribute(childNode, "type", ref val2);
			HandlerBase.GetAndRemoveStringAttribute(childNode, "initializeData", ref val3);
			HandlerBase.CheckForUnrecognizedAttributes(childNode);
			HandlerBase.CheckForChildNodes(childNode);
			TraceListener traceListener = null;
			if (val2 != null)
			{
				Type type = Type.GetType(val2);
				if (type == null)
				{
					throw new ConfigurationErrorsException(SR.GetString("Could_not_find_type", val2));
				}
				if (!typeof(TraceListener).IsAssignableFrom(type))
				{
					throw new ConfigurationErrorsException(SR.GetString("Type_isnt_tracelistener", val2));
				}
				if (val3 == null)
				{
					ConstructorInfo constructor = type.GetConstructor(new Type[0]);
					if (constructor == null)
					{
						throw new ConfigurationErrorsException(SR.GetString("Could_not_get_constructor", val2));
					}
					traceListener = (TraceListener)SecurityUtils.ConstructorInfoInvoke(constructor, new object[0]);
				}
				else
				{
					ConstructorInfo constructor2 = type.GetConstructor(new Type[1] { typeof(string) });
					if (constructor2 == null)
					{
						throw new ConfigurationErrorsException(SR.GetString("Could_not_get_constructor", val2));
					}
					traceListener = (TraceListener)SecurityUtils.ConstructorInfoInvoke(constructor2, new object[1] { val3 });
				}
				if (val != null)
				{
					traceListener.Name = val;
				}
			}
			switch (name[0])
			{
			case 'a':
				if (traceListener == null)
				{
					throw new ConfigurationErrorsException(SR.GetString("Could_not_create_listener", val));
				}
				Trace.Listeners.Add(traceListener);
				break;
			case 'r':
				if (traceListener == null)
				{
					if (val == null)
					{
						throw new ConfigurationErrorsException(SR.GetString("Cannot_remove_with_null"));
					}
					Trace.Listeners.Remove(val);
				}
				else
				{
					Trace.Listeners.Remove(traceListener);
				}
				break;
			case 'c':
				Trace.Listeners.Clear();
				break;
			default:
				HandlerBase.ThrowUnrecognizedElement(childNode);
				break;
			}
		}
	}
}
