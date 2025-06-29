using System.IO;
using System.Reflection;

namespace UnrealEngine.Runtime;

public interface IAssemblyLoadContext
{
	Assembly LoadFromAssemblyPath(string assemblyPath);

	Assembly LoadFromStream(Stream assembly, Stream assemblySymbols);

	void Unload();

	bool IsAlive();

	Assembly[] GetAssemblies();

	AssemblyContext GetOwner();
}
