using System.Runtime.InteropServices;

namespace System.Configuration.Assemblies;

[Serializable]
[ComVisible(true)]
public enum AssemblyHashAlgorithm
{
	None = 0,
	MD5 = 32771,
	SHA1 = 32772,
	[ComVisible(false)]
	SHA256 = 32780,
	[ComVisible(false)]
	SHA384 = 32781,
	[ComVisible(false)]
	SHA512 = 32782
}
