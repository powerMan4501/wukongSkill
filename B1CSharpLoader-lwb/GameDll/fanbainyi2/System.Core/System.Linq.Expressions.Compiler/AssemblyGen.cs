using System.Dynamic.Utils;
using System.Reflection;
using System.Reflection.Emit;
using System.Security;
using System.Text;
using System.Threading;

namespace System.Linq.Expressions.Compiler;

internal sealed class AssemblyGen
{
	private static AssemblyGen _assembly;

	private readonly AssemblyBuilder _myAssembly;

	private readonly ModuleBuilder _myModule;

	private int _index;

	private static AssemblyGen Assembly
	{
		get
		{
			if (_assembly == null)
			{
				Interlocked.CompareExchange(ref _assembly, new AssemblyGen(), null);
			}
			return _assembly;
		}
	}

	private AssemblyGen()
	{
		AssemblyName assemblyName = new AssemblyName("Snippets");
		CustomAttributeBuilder[] assemblyAttributes = new CustomAttributeBuilder[1]
		{
			new CustomAttributeBuilder(typeof(SecurityTransparentAttribute).GetConstructor(Type.EmptyTypes), new object[0])
		};
		_myAssembly = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run, assemblyAttributes);
		_myModule = _myAssembly.DefineDynamicModule(assemblyName.Name, emitSymbolInfo: false);
		_myAssembly.DefineVersionInfoResource();
	}

	private TypeBuilder DefineType(string name, Type parent, TypeAttributes attr)
	{
		ContractUtils.RequiresNotNull(name, "name");
		ContractUtils.RequiresNotNull(parent, "parent");
		StringBuilder stringBuilder = new StringBuilder(name);
		int value = Interlocked.Increment(ref _index);
		stringBuilder.Append("$");
		stringBuilder.Append(value);
		stringBuilder.Replace('+', '_').Replace('[', '_').Replace(']', '_')
			.Replace('*', '_')
			.Replace('&', '_')
			.Replace(',', '_')
			.Replace('\\', '_');
		name = stringBuilder.ToString();
		return _myModule.DefineType(name, attr, parent);
	}

	internal static TypeBuilder DefineDelegateType(string name)
	{
		return Assembly.DefineType(name, typeof(MulticastDelegate), TypeAttributes.Public | TypeAttributes.Sealed | TypeAttributes.AutoClass);
	}
}
