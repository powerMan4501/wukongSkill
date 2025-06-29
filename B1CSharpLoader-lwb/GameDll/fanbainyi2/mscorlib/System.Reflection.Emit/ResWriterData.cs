using System.IO;
using System.Resources;

namespace System.Reflection.Emit;

internal class ResWriterData
{
	internal ResourceWriter m_resWriter;

	internal string m_strName;

	internal string m_strFileName;

	internal string m_strFullFileName;

	internal Stream m_memoryStream;

	internal ResWriterData m_nextResWriter;

	internal ResourceAttributes m_attribute;

	internal ResWriterData(ResourceWriter resWriter, Stream memoryStream, string strName, string strFileName, string strFullFileName, ResourceAttributes attribute)
	{
		m_resWriter = resWriter;
		m_memoryStream = memoryStream;
		m_strName = strName;
		m_strFileName = strFileName;
		m_strFullFileName = strFullFileName;
		m_nextResWriter = null;
		m_attribute = attribute;
	}
}
