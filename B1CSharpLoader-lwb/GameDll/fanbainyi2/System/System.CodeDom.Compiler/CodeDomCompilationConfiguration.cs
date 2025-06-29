using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Xml;

namespace System.CodeDom.Compiler;

internal class CodeDomCompilationConfiguration
{
	internal class SectionHandler
	{
		private SectionHandler()
		{
		}

		internal static object CreateStatic(object inheritedObject, XmlNode node)
		{
			CodeDomCompilationConfiguration codeDomCompilationConfiguration = (CodeDomCompilationConfiguration)inheritedObject;
			CodeDomCompilationConfiguration result = ((codeDomCompilationConfiguration != null) ? new CodeDomCompilationConfiguration(codeDomCompilationConfiguration) : new CodeDomCompilationConfiguration());
			HandlerBase.CheckForUnrecognizedAttributes(node);
			foreach (XmlNode childNode in node.ChildNodes)
			{
				if (!HandlerBase.IsIgnorableAlsoCheckForNonElement(childNode))
				{
					if (childNode.Name == "compilers")
					{
						ProcessCompilersElement(result, childNode);
					}
					else
					{
						HandlerBase.ThrowUnrecognizedElement(childNode);
					}
				}
			}
			return result;
		}

		private static IDictionary<string, string> GetProviderOptions(XmlNode compilerNode)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			foreach (XmlNode item in compilerNode)
			{
				if (item.Name != "providerOption")
				{
					HandlerBase.ThrowUnrecognizedElement(item);
				}
				string val = null;
				string val2 = null;
				HandlerBase.GetAndRemoveRequiredNonEmptyStringAttribute(item, "name", ref val);
				HandlerBase.GetAndRemoveRequiredNonEmptyStringAttribute(item, "value", ref val2);
				HandlerBase.CheckForUnrecognizedAttributes(item);
				HandlerBase.CheckForChildNodes(item);
				dictionary[val] = val2;
			}
			return dictionary;
		}

		private static void ProcessCompilersElement(CodeDomCompilationConfiguration result, XmlNode node)
		{
			HandlerBase.CheckForUnrecognizedAttributes(node);
			string filename = ConfigurationErrorsException.GetFilename(node);
			foreach (XmlNode childNode in node.ChildNodes)
			{
				int lineNumber = ConfigurationErrorsException.GetLineNumber(childNode);
				if (HandlerBase.IsIgnorableAlsoCheckForNonElement(childNode))
				{
					continue;
				}
				if (childNode.Name != "compiler")
				{
					HandlerBase.ThrowUnrecognizedElement(childNode);
				}
				string val = string.Empty;
				XmlNode andRemoveRequiredNonEmptyStringAttribute = HandlerBase.GetAndRemoveRequiredNonEmptyStringAttribute(childNode, "language", ref val);
				string val2 = string.Empty;
				HandlerBase.GetAndRemoveRequiredNonEmptyStringAttribute(childNode, "extension", ref val2);
				string val3 = null;
				HandlerBase.GetAndRemoveStringAttribute(childNode, "type", ref val3);
				CompilerParameters compilerParameters = new CompilerParameters();
				int val4 = 0;
				if (HandlerBase.GetAndRemoveNonNegativeIntegerAttribute(childNode, "warningLevel", ref val4) != null)
				{
					compilerParameters.WarningLevel = val4;
					compilerParameters.TreatWarningsAsErrors = val4 > 0;
				}
				string val5 = null;
				if (HandlerBase.GetAndRemoveStringAttribute(childNode, "compilerOptions", ref val5) != null)
				{
					compilerParameters.CompilerOptions = val5;
				}
				IDictionary<string, string> providerOptions = GetProviderOptions(childNode);
				HandlerBase.CheckForUnrecognizedAttributes(childNode);
				string[] array = val.Split(s_fieldSeparators);
				string[] array2 = val2.Split(s_fieldSeparators);
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = array[i].Trim();
				}
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = array2[j].Trim();
				}
				string[] array3 = array;
				foreach (string text in array3)
				{
					if (text.Length == 0)
					{
						throw new ConfigurationErrorsException(SR.GetString("Language_Names_Cannot_Be_Empty"));
					}
				}
				string[] array4 = array2;
				foreach (string text2 in array4)
				{
					if (text2.Length == 0 || text2[0] != '.')
					{
						throw new ConfigurationErrorsException(SR.GetString("Extension_Names_Cannot_Be_Empty_Or_Non_Period_Based"));
					}
				}
				CompilerInfo compilerInfo = null;
				if (val3 != null)
				{
					compilerInfo = new CompilerInfo(compilerParameters, val3);
				}
				else
				{
					compilerInfo = result.FindExistingCompilerInfo(array, array2);
					if (compilerInfo == null)
					{
						throw new ConfigurationErrorsException();
					}
				}
				compilerInfo.configFileName = filename;
				compilerInfo.configFileLineNumber = lineNumber;
				if (val3 != null)
				{
					compilerInfo._compilerLanguages = array;
					compilerInfo._compilerExtensions = array2;
					compilerInfo._providerOptions = providerOptions;
					result.AddCompilerInfo(compilerInfo);
					continue;
				}
				foreach (KeyValuePair<string, string> item in providerOptions)
				{
					compilerInfo._providerOptions[item.Key] = item.Value;
				}
			}
			result.RemoveUnmapped();
		}
	}

	internal const string sectionName = "system.codedom";

	private static readonly char[] s_fieldSeparators = new char[1] { ';' };

	internal Hashtable _compilerLanguages;

	internal Hashtable _compilerExtensions;

	internal ArrayList _allCompilerInfo;

	private static CodeDomCompilationConfiguration defaultInstance = new CodeDomCompilationConfiguration();

	internal static CodeDomCompilationConfiguration Default => defaultInstance;

	internal CodeDomCompilationConfiguration()
	{
		_compilerLanguages = new Hashtable(StringComparer.OrdinalIgnoreCase);
		_compilerExtensions = new Hashtable(StringComparer.OrdinalIgnoreCase);
		_allCompilerInfo = new ArrayList();
		CompilerParameters compilerParams = new CompilerParameters
		{
			WarningLevel = 4
		};
		string codeDomProviderTypeName = "Microsoft.CSharp.CSharpCodeProvider, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
		CompilerInfo compilerInfo = new CompilerInfo(compilerParams, codeDomProviderTypeName);
		compilerInfo._compilerLanguages = new string[3] { "c#", "cs", "csharp" };
		compilerInfo._compilerExtensions = new string[2] { ".cs", "cs" };
		compilerInfo._providerOptions = new Dictionary<string, string>();
		compilerInfo._providerOptions["CompilerVersion"] = "v4.0";
		AddCompilerInfo(compilerInfo);
		compilerParams = new CompilerParameters
		{
			WarningLevel = 4
		};
		codeDomProviderTypeName = "Microsoft.VisualBasic.VBCodeProvider, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
		compilerInfo = new CompilerInfo(compilerParams, codeDomProviderTypeName);
		compilerInfo._compilerLanguages = new string[4] { "vb", "vbs", "visualbasic", "vbscript" };
		compilerInfo._compilerExtensions = new string[2] { ".vb", "vb" };
		compilerInfo._providerOptions = new Dictionary<string, string>();
		compilerInfo._providerOptions["CompilerVersion"] = "v4.0";
		AddCompilerInfo(compilerInfo);
		compilerParams = new CompilerParameters
		{
			WarningLevel = 4
		};
		codeDomProviderTypeName = "Microsoft.JScript.JScriptCodeProvider, Microsoft.JScript, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
		AddCompilerInfo(new CompilerInfo(compilerParams, codeDomProviderTypeName)
		{
			_compilerLanguages = new string[3] { "js", "jscript", "javascript" },
			_compilerExtensions = new string[2] { ".js", "js" },
			_providerOptions = new Dictionary<string, string>()
		});
		compilerParams = new CompilerParameters
		{
			WarningLevel = 4
		};
		codeDomProviderTypeName = "Microsoft.VisualC.CppCodeProvider, CppCodeProvider, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
		AddCompilerInfo(new CompilerInfo(compilerParams, codeDomProviderTypeName)
		{
			_compilerLanguages = new string[3] { "c++", "mc", "cpp" },
			_compilerExtensions = new string[2] { ".h", "h" },
			_providerOptions = new Dictionary<string, string>()
		});
	}

	private CodeDomCompilationConfiguration(CodeDomCompilationConfiguration original)
	{
		if (original._compilerLanguages != null)
		{
			_compilerLanguages = (Hashtable)original._compilerLanguages.Clone();
		}
		if (original._compilerExtensions != null)
		{
			_compilerExtensions = (Hashtable)original._compilerExtensions.Clone();
		}
		if (original._allCompilerInfo != null)
		{
			_allCompilerInfo = (ArrayList)original._allCompilerInfo.Clone();
		}
	}

	private void AddCompilerInfo(CompilerInfo compilerInfo)
	{
		string[] compilerLanguages = compilerInfo._compilerLanguages;
		foreach (string key in compilerLanguages)
		{
			_compilerLanguages[key] = compilerInfo;
		}
		string[] compilerExtensions = compilerInfo._compilerExtensions;
		foreach (string key2 in compilerExtensions)
		{
			_compilerExtensions[key2] = compilerInfo;
		}
		_allCompilerInfo.Add(compilerInfo);
	}

	private void RemoveUnmapped()
	{
		for (int i = 0; i < _allCompilerInfo.Count; i++)
		{
			((CompilerInfo)_allCompilerInfo[i])._mapped = false;
		}
		foreach (CompilerInfo value in _compilerLanguages.Values)
		{
			value._mapped = true;
		}
		foreach (CompilerInfo value2 in _compilerExtensions.Values)
		{
			value2._mapped = true;
		}
		for (int num = _allCompilerInfo.Count - 1; num >= 0; num--)
		{
			if (!((CompilerInfo)_allCompilerInfo[num])._mapped)
			{
				_allCompilerInfo.RemoveAt(num);
			}
		}
	}

	private CompilerInfo FindExistingCompilerInfo(string[] languageList, string[] extensionList)
	{
		CompilerInfo result = null;
		foreach (CompilerInfo item in _allCompilerInfo)
		{
			if (item._compilerExtensions.Length != extensionList.Length || item._compilerLanguages.Length != languageList.Length)
			{
				continue;
			}
			bool flag = false;
			for (int i = 0; i < item._compilerExtensions.Length; i++)
			{
				if (item._compilerExtensions[i] != extensionList[i])
				{
					flag = true;
					break;
				}
			}
			for (int j = 0; j < item._compilerLanguages.Length; j++)
			{
				if (item._compilerLanguages[j] != languageList[j])
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				result = item;
				break;
			}
		}
		return result;
	}
}
