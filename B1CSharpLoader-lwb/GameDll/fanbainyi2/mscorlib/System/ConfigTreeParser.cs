using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace System;

internal class ConfigTreeParser : BaseConfigHandler
{
	private ConfigNode rootNode;

	private ConfigNode currentNode;

	private string fileName;

	private int attributeEntry;

	private string key;

	private string[] treeRootPath;

	private bool parsing;

	private int depth;

	private int pathDepth;

	private int searchDepth;

	private bool bNoSearchPath;

	private string lastProcessed;

	private bool lastProcessedEndElement;

	internal ConfigNode Parse(string fileName, string configPath)
	{
		return Parse(fileName, configPath, skipSecurityStuff: false);
	}

	[SecuritySafeCritical]
	internal ConfigNode Parse(string fileName, string configPath, bool skipSecurityStuff)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		this.fileName = fileName;
		if (configPath[0] == '/')
		{
			treeRootPath = configPath.Substring(1).Split('/');
			pathDepth = treeRootPath.Length - 1;
			bNoSearchPath = false;
		}
		else
		{
			treeRootPath = new string[1];
			treeRootPath[0] = configPath;
			bNoSearchPath = true;
		}
		if (!skipSecurityStuff)
		{
			new FileIOPermission(FileIOPermissionAccess.Read, Path.GetFullPathInternal(fileName)).Demand();
		}
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Assert();
		try
		{
			RunParser(fileName);
		}
		catch (FileNotFoundException)
		{
			throw;
		}
		catch (DirectoryNotFoundException)
		{
			throw;
		}
		catch (UnauthorizedAccessException)
		{
			throw;
		}
		catch (FileLoadException)
		{
			throw;
		}
		catch (Exception innerException)
		{
			string invalidSyntaxMessage = GetInvalidSyntaxMessage();
			throw new ApplicationException(invalidSyntaxMessage, innerException);
		}
		return rootNode;
	}

	public override void NotifyEvent(ConfigEvents nEvent)
	{
	}

	public override void BeginChildren(int size, ConfigNodeSubType subType, ConfigNodeType nType, int terminal, [MarshalAs(UnmanagedType.LPWStr)] string text, int textLength, int prefixLength)
	{
		if (!parsing && !bNoSearchPath && depth == searchDepth + 1 && string.Compare(text, treeRootPath[searchDepth], StringComparison.Ordinal) == 0)
		{
			searchDepth++;
		}
	}

	public override void EndChildren(int fEmpty, int size, ConfigNodeSubType subType, ConfigNodeType nType, int terminal, [MarshalAs(UnmanagedType.LPWStr)] string text, int textLength, int prefixLength)
	{
		lastProcessed = text;
		lastProcessedEndElement = true;
		if (parsing)
		{
			if (currentNode == rootNode)
			{
				parsing = false;
			}
			currentNode = currentNode.Parent;
		}
		else if (nType == ConfigNodeType.Element)
		{
			if (depth == searchDepth && string.Compare(text, treeRootPath[searchDepth - 1], StringComparison.Ordinal) == 0)
			{
				searchDepth--;
				depth--;
			}
			else
			{
				depth--;
			}
		}
	}

	public override void Error(int size, ConfigNodeSubType subType, ConfigNodeType nType, int terminal, [MarshalAs(UnmanagedType.LPWStr)] string text, int textLength, int prefixLength)
	{
	}

	public override void CreateNode(int size, ConfigNodeSubType subType, ConfigNodeType nType, int terminal, [MarshalAs(UnmanagedType.LPWStr)] string text, int textLength, int prefixLength)
	{
		switch (nType)
		{
		case ConfigNodeType.Element:
			lastProcessed = text;
			lastProcessedEndElement = false;
			if (parsing || (bNoSearchPath && string.Compare(text, treeRootPath[0], StringComparison.OrdinalIgnoreCase) == 0) || (depth == searchDepth && searchDepth == pathDepth && string.Compare(text, treeRootPath[pathDepth], StringComparison.OrdinalIgnoreCase) == 0))
			{
				parsing = true;
				ConfigNode configNode = currentNode;
				currentNode = new ConfigNode(text, configNode);
				if (rootNode == null)
				{
					rootNode = currentNode;
				}
				else
				{
					configNode.AddChild(currentNode);
				}
			}
			else
			{
				depth++;
			}
			break;
		case ConfigNodeType.PCData:
			if (currentNode != null)
			{
				currentNode.Value = text;
			}
			break;
		}
	}

	public override void CreateAttribute(int size, ConfigNodeSubType subType, ConfigNodeType nType, int terminal, [MarshalAs(UnmanagedType.LPWStr)] string text, int textLength, int prefixLength)
	{
		if (parsing)
		{
			switch (nType)
			{
			case ConfigNodeType.Attribute:
				attributeEntry = currentNode.AddAttribute(text, "");
				key = text;
				break;
			case ConfigNodeType.PCData:
				currentNode.ReplaceAttribute(attributeEntry, key, text);
				break;
			default:
			{
				string invalidSyntaxMessage = GetInvalidSyntaxMessage();
				throw new ApplicationException(invalidSyntaxMessage);
			}
			}
		}
	}

	private string GetInvalidSyntaxMessage()
	{
		string text = null;
		if (lastProcessed != null)
		{
			text = (lastProcessedEndElement ? "</" : "<") + lastProcessed + ">";
		}
		return Environment.GetResourceString("XML_Syntax_InvalidSyntaxInFile", fileName, text);
	}
}
