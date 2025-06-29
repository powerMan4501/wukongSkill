using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeChecksumPragma : CodeDirective
{
	private string fileName;

	private byte[] checksumData;

	private Guid checksumAlgorithmId;

	public string FileName
	{
		get
		{
			if (fileName != null)
			{
				return fileName;
			}
			return string.Empty;
		}
		set
		{
			fileName = value;
		}
	}

	public Guid ChecksumAlgorithmId
	{
		get
		{
			return checksumAlgorithmId;
		}
		set
		{
			checksumAlgorithmId = value;
		}
	}

	public byte[] ChecksumData
	{
		get
		{
			return checksumData;
		}
		set
		{
			checksumData = value;
		}
	}

	public CodeChecksumPragma()
	{
	}

	public CodeChecksumPragma(string fileName, Guid checksumAlgorithmId, byte[] checksumData)
	{
		this.fileName = fileName;
		this.checksumAlgorithmId = checksumAlgorithmId;
		this.checksumData = checksumData;
	}
}
