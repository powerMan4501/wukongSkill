using System.Runtime.InteropServices;

namespace System.Configuration.Assemblies;

[Serializable]
[ComVisible(true)]
[Obsolete("The AssemblyHash class has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
public struct AssemblyHash : ICloneable
{
	private AssemblyHashAlgorithm _Algorithm;

	private byte[] _Value;

	[Obsolete("The AssemblyHash class has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
	public static readonly AssemblyHash Empty = new AssemblyHash(AssemblyHashAlgorithm.None, null);

	[Obsolete("The AssemblyHash class has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
	public AssemblyHashAlgorithm Algorithm
	{
		get
		{
			return _Algorithm;
		}
		set
		{
			_Algorithm = value;
		}
	}

	[Obsolete("The AssemblyHash class has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
	public AssemblyHash(byte[] value)
	{
		_Algorithm = AssemblyHashAlgorithm.SHA1;
		_Value = null;
		if (value != null)
		{
			int num = value.Length;
			_Value = new byte[num];
			Array.Copy(value, _Value, num);
		}
	}

	[Obsolete("The AssemblyHash class has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
	public AssemblyHash(AssemblyHashAlgorithm algorithm, byte[] value)
	{
		_Algorithm = algorithm;
		_Value = null;
		if (value != null)
		{
			int num = value.Length;
			_Value = new byte[num];
			Array.Copy(value, _Value, num);
		}
	}

	[Obsolete("The AssemblyHash class has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
	public byte[] GetValue()
	{
		return _Value;
	}

	[Obsolete("The AssemblyHash class has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
	public void SetValue(byte[] value)
	{
		_Value = value;
	}

	[Obsolete("The AssemblyHash class has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
	public object Clone()
	{
		return new AssemblyHash(_Algorithm, _Value);
	}
}
