using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Security.Permissions;

namespace System.CodeDom.Compiler;

[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
public sealed class CompilerInfo
{
	internal string _codeDomProviderTypeName;

	internal CompilerParameters _compilerParams;

	internal string[] _compilerLanguages;

	internal string[] _compilerExtensions;

	internal string configFileName;

	internal IDictionary<string, string> _providerOptions;

	internal int configFileLineNumber;

	internal bool _mapped;

	private Type type;

	public Type CodeDomProviderType
	{
		get
		{
			if (type == null)
			{
				lock (this)
				{
					if (type == null)
					{
						type = Type.GetType(_codeDomProviderTypeName);
						if (type == null)
						{
							if (configFileName == null)
							{
								throw new ConfigurationErrorsException(SR.GetString("Unable_To_Locate_Type", _codeDomProviderTypeName, string.Empty, 0));
							}
							throw new ConfigurationErrorsException(SR.GetString("Unable_To_Locate_Type", _codeDomProviderTypeName), configFileName, configFileLineNumber);
						}
					}
				}
			}
			return type;
		}
	}

	public bool IsCodeDomProviderTypeValid
	{
		get
		{
			Type type = Type.GetType(_codeDomProviderTypeName);
			return type != null;
		}
	}

	internal CompilerParameters CompilerParams => _compilerParams;

	internal IDictionary<string, string> ProviderOptions => _providerOptions;

	private CompilerInfo()
	{
	}

	public string[] GetLanguages()
	{
		return CloneCompilerLanguages();
	}

	public string[] GetExtensions()
	{
		return CloneCompilerExtensions();
	}

	public CodeDomProvider CreateProvider()
	{
		if (_providerOptions.Count > 0)
		{
			ConstructorInfo constructor = CodeDomProviderType.GetConstructor(new Type[1] { typeof(IDictionary<string, string>) });
			if (constructor != null)
			{
				return (CodeDomProvider)constructor.Invoke(new object[1] { _providerOptions });
			}
		}
		return (CodeDomProvider)Activator.CreateInstance(CodeDomProviderType);
	}

	public CodeDomProvider CreateProvider(IDictionary<string, string> providerOptions)
	{
		if (providerOptions == null)
		{
			throw new ArgumentNullException("providerOptions");
		}
		ConstructorInfo constructor = CodeDomProviderType.GetConstructor(new Type[1] { typeof(IDictionary<string, string>) });
		if (constructor != null)
		{
			return (CodeDomProvider)constructor.Invoke(new object[1] { providerOptions });
		}
		throw new InvalidOperationException(SR.GetString("Provider_does_not_support_options", CodeDomProviderType.ToString()));
	}

	public CompilerParameters CreateDefaultCompilerParameters()
	{
		return CloneCompilerParameters();
	}

	internal CompilerInfo(CompilerParameters compilerParams, string codeDomProviderTypeName, string[] compilerLanguages, string[] compilerExtensions)
	{
		_compilerLanguages = compilerLanguages;
		_compilerExtensions = compilerExtensions;
		_codeDomProviderTypeName = codeDomProviderTypeName;
		if (compilerParams == null)
		{
			compilerParams = new CompilerParameters();
		}
		_compilerParams = compilerParams;
	}

	internal CompilerInfo(CompilerParameters compilerParams, string codeDomProviderTypeName)
	{
		_codeDomProviderTypeName = codeDomProviderTypeName;
		if (compilerParams == null)
		{
			compilerParams = new CompilerParameters();
		}
		_compilerParams = compilerParams;
	}

	public override int GetHashCode()
	{
		return _codeDomProviderTypeName.GetHashCode();
	}

	public override bool Equals(object o)
	{
		CompilerInfo compilerInfo = o as CompilerInfo;
		if (o == null)
		{
			return false;
		}
		if (CodeDomProviderType == compilerInfo.CodeDomProviderType && CompilerParams.WarningLevel == compilerInfo.CompilerParams.WarningLevel && CompilerParams.IncludeDebugInformation == compilerInfo.CompilerParams.IncludeDebugInformation)
		{
			return CompilerParams.CompilerOptions == compilerInfo.CompilerParams.CompilerOptions;
		}
		return false;
	}

	private CompilerParameters CloneCompilerParameters()
	{
		CompilerParameters compilerParameters = new CompilerParameters();
		compilerParameters.IncludeDebugInformation = _compilerParams.IncludeDebugInformation;
		compilerParameters.TreatWarningsAsErrors = _compilerParams.TreatWarningsAsErrors;
		compilerParameters.WarningLevel = _compilerParams.WarningLevel;
		compilerParameters.CompilerOptions = _compilerParams.CompilerOptions;
		return compilerParameters;
	}

	private string[] CloneCompilerLanguages()
	{
		string[] array = new string[_compilerLanguages.Length];
		Array.Copy(_compilerLanguages, array, _compilerLanguages.Length);
		return array;
	}

	private string[] CloneCompilerExtensions()
	{
		string[] array = new string[_compilerExtensions.Length];
		Array.Copy(_compilerExtensions, array, _compilerExtensions.Length);
		return array;
	}
}
