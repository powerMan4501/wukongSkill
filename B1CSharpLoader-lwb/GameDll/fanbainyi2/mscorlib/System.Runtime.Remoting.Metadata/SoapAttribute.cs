using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata;

[ComVisible(true)]
public class SoapAttribute : Attribute
{
	protected string ProtXmlNamespace;

	private bool _bUseAttribute;

	private bool _bEmbedded;

	protected object ReflectInfo;

	public virtual string XmlNamespace
	{
		get
		{
			return ProtXmlNamespace;
		}
		set
		{
			ProtXmlNamespace = value;
		}
	}

	public virtual bool UseAttribute
	{
		get
		{
			return _bUseAttribute;
		}
		set
		{
			_bUseAttribute = value;
		}
	}

	public virtual bool Embedded
	{
		get
		{
			return _bEmbedded;
		}
		set
		{
			_bEmbedded = value;
		}
	}

	internal void SetReflectInfo(object info)
	{
		ReflectInfo = info;
	}
}
