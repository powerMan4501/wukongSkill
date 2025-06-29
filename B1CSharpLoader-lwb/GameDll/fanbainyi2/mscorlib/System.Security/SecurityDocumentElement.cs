namespace System.Security;

[Serializable]
internal sealed class SecurityDocumentElement : ISecurityElementFactory
{
	private int m_position;

	private SecurityDocument m_document;

	internal SecurityDocumentElement(SecurityDocument document, int position)
	{
		m_document = document;
		m_position = position;
	}

	SecurityElement ISecurityElementFactory.CreateSecurityElement()
	{
		return m_document.GetElement(m_position, bCreate: true);
	}

	object ISecurityElementFactory.Copy()
	{
		return new SecurityDocumentElement(m_document, m_position);
	}

	string ISecurityElementFactory.GetTag()
	{
		return m_document.GetTagForElement(m_position);
	}

	string ISecurityElementFactory.Attribute(string attributeName)
	{
		return m_document.GetAttributeForElement(m_position, attributeName);
	}
}
