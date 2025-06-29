using System.IO;
using System.Security;

namespace System.Reflection.Emit;

[Serializable]
internal class ModuleBuilderData
{
	internal string m_strModuleName;

	internal string m_strFileName;

	internal bool m_fGlobalBeenCreated;

	internal bool m_fHasGlobal;

	[NonSerialized]
	internal TypeBuilder m_globalTypeBuilder;

	[NonSerialized]
	internal ModuleBuilder m_module;

	private int m_tkFile;

	internal bool m_isSaved;

	[NonSerialized]
	internal ResWriterData m_embeddedRes;

	internal const string MULTI_BYTE_VALUE_CLASS = "$ArrayType$";

	internal string m_strResourceFileName;

	internal byte[] m_resourceBytes;

	internal int FileToken
	{
		get
		{
			return m_tkFile;
		}
		set
		{
			m_tkFile = value;
		}
	}

	[SecurityCritical]
	internal ModuleBuilderData(ModuleBuilder module, string strModuleName, string strFileName, int tkFile)
	{
		m_globalTypeBuilder = new TypeBuilder(module);
		m_module = module;
		m_tkFile = tkFile;
		InitNames(strModuleName, strFileName);
	}

	[SecurityCritical]
	private void InitNames(string strModuleName, string strFileName)
	{
		m_strModuleName = strModuleName;
		if (strFileName == null)
		{
			m_strFileName = strModuleName;
			return;
		}
		string extension = Path.GetExtension(strFileName);
		if (extension == null || extension == string.Empty)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NoModuleFileExtension", strFileName));
		}
		m_strFileName = strFileName;
	}

	[SecurityCritical]
	internal virtual void ModifyModuleName(string strModuleName)
	{
		InitNames(strModuleName, null);
	}
}
