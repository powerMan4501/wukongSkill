using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.Text.RegularExpressions;

internal class RegexTypeCompiler : RegexCompiler
{
	private static int _typeCount = 0;

	private static LocalDataStoreSlot _moduleSlot = Thread.AllocateDataSlot();

	private AssemblyBuilder _assembly;

	private ModuleBuilder _module;

	private TypeBuilder _typebuilder;

	private MethodBuilder _methbuilder;

	internal RegexTypeCompiler(AssemblyName an, CustomAttributeBuilder[] attribs, string resourceFile)
	{
		new ReflectionPermission(PermissionState.Unrestricted).Assert();
		try
		{
			List<CustomAttributeBuilder> list = new List<CustomAttributeBuilder>();
			ConstructorInfo constructor = typeof(SecurityTransparentAttribute).GetConstructor(Type.EmptyTypes);
			CustomAttributeBuilder item = new CustomAttributeBuilder(constructor, new object[0]);
			list.Add(item);
			ConstructorInfo constructor2 = typeof(SecurityRulesAttribute).GetConstructor(new Type[1] { typeof(SecurityRuleSet) });
			CustomAttributeBuilder item2 = new CustomAttributeBuilder(constructor2, new object[1] { SecurityRuleSet.Level2 });
			list.Add(item2);
			_assembly = AppDomain.CurrentDomain.DefineDynamicAssembly(an, AssemblyBuilderAccess.RunAndSave, list);
			_module = _assembly.DefineDynamicModule(an.Name + ".dll");
			if (attribs != null)
			{
				for (int i = 0; i < attribs.Length; i++)
				{
					_assembly.SetCustomAttribute(attribs[i]);
				}
			}
			if (resourceFile != null)
			{
				_assembly.DefineUnmanagedResource(resourceFile);
			}
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
	}

	internal Type FactoryTypeFromCode(RegexCode code, RegexOptions options, string typeprefix)
	{
		_code = code;
		_codes = code._codes;
		_strings = code._strings;
		_fcPrefix = code._fcPrefix;
		_bmPrefix = code._bmPrefix;
		_anchors = code._anchors;
		_trackcount = code._trackcount;
		_options = options;
		string text = Interlocked.Increment(ref _typeCount).ToString(CultureInfo.InvariantCulture);
		string typename = typeprefix + "Runner" + text;
		string typename2 = typeprefix + "Factory" + text;
		DefineType(typename, ispublic: false, typeof(RegexRunner));
		DefineMethod("Go", null);
		GenerateGo();
		BakeMethod();
		DefineMethod("FindFirstChar", typeof(bool));
		GenerateFindFirstChar();
		BakeMethod();
		DefineMethod("InitTrackCount", null);
		GenerateInitTrackCount();
		BakeMethod();
		Type newtype = BakeType();
		DefineType(typename2, ispublic: false, typeof(RegexRunnerFactory));
		DefineMethod("CreateInstance", typeof(RegexRunner));
		GenerateCreateInstance(newtype);
		BakeMethod();
		return BakeType();
	}

	internal void GenerateRegexType(string pattern, RegexOptions opts, string name, bool ispublic, RegexCode code, RegexTree tree, Type factory, TimeSpan matchTimeout)
	{
		FieldInfo ft = RegexField("pattern");
		FieldInfo ft2 = RegexField("roptions");
		FieldInfo ft3 = RegexField("factory");
		FieldInfo field = RegexField("caps");
		FieldInfo field2 = RegexField("capnames");
		FieldInfo ft4 = RegexField("capslist");
		FieldInfo ft5 = RegexField("capsize");
		FieldInfo ft6 = RegexField("internalMatchTimeout");
		Type[] array = new Type[0];
		DefineType(name, ispublic, typeof(Regex));
		_methbuilder = null;
		MethodAttributes attributes = MethodAttributes.Public;
		ConstructorBuilder constructorBuilder = _typebuilder.DefineConstructor(attributes, CallingConventions.Standard, array);
		_ilg = constructorBuilder.GetILGenerator();
		Ldthis();
		_ilg.Emit(OpCodes.Call, typeof(Regex).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], new ParameterModifier[0]));
		Ldthis();
		Ldstr(pattern);
		Stfld(ft);
		Ldthis();
		Ldc((int)opts);
		Stfld(ft2);
		Ldthis();
		LdcI8(matchTimeout.Ticks);
		Call(typeof(TimeSpan).GetMethod("FromTicks", BindingFlags.Static | BindingFlags.Public));
		Stfld(ft6);
		Ldthis();
		Newobj(factory.GetConstructor(array));
		Stfld(ft3);
		if (code._caps != null)
		{
			GenerateCreateHashtable(field, code._caps);
		}
		if (tree._capnames != null)
		{
			GenerateCreateHashtable(field2, tree._capnames);
		}
		if (tree._capslist != null)
		{
			Ldthis();
			Ldc(tree._capslist.Length);
			_ilg.Emit(OpCodes.Newarr, typeof(string));
			Stfld(ft4);
			for (int i = 0; i < tree._capslist.Length; i++)
			{
				Ldthisfld(ft4);
				Ldc(i);
				Ldstr(tree._capslist[i]);
				_ilg.Emit(OpCodes.Stelem_Ref);
			}
		}
		Ldthis();
		Ldc(code._capsize);
		Stfld(ft5);
		Ldthis();
		Call(typeof(Regex).GetMethod("InitializeReferences", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic));
		Ret();
		_methbuilder = null;
		attributes = MethodAttributes.Public;
		ConstructorBuilder constructorBuilder2 = _typebuilder.DefineConstructor(attributes, CallingConventions.Standard, new Type[1] { typeof(TimeSpan) });
		_ilg = constructorBuilder2.GetILGenerator();
		Ldthis();
		_ilg.Emit(OpCodes.Call, constructorBuilder);
		_ilg.Emit(OpCodes.Ldarg_1);
		Call(typeof(Regex).GetMethod("ValidateMatchTimeout", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic));
		Ldthis();
		_ilg.Emit(OpCodes.Ldarg_1);
		Stfld(ft6);
		Ret();
		constructorBuilder = null;
		constructorBuilder2 = null;
		_typebuilder.CreateType();
		_ilg = null;
		_typebuilder = null;
	}

	internal void GenerateCreateHashtable(FieldInfo field, Hashtable ht)
	{
		MethodInfo method = typeof(Hashtable).GetMethod("Add", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		Ldthis();
		Newobj(typeof(Hashtable).GetConstructor(new Type[0]));
		Stfld(field);
		IDictionaryEnumerator enumerator = ht.GetEnumerator();
		while (enumerator.MoveNext())
		{
			Ldthisfld(field);
			if (enumerator.Key is int)
			{
				Ldc((int)enumerator.Key);
				_ilg.Emit(OpCodes.Box, typeof(int));
			}
			else
			{
				Ldstr((string)enumerator.Key);
			}
			Ldc((int)enumerator.Value);
			_ilg.Emit(OpCodes.Box, typeof(int));
			Callvirt(method);
		}
	}

	private FieldInfo RegexField(string fieldname)
	{
		return typeof(Regex).GetField(fieldname, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
	}

	internal void Save()
	{
		_assembly.Save(_assembly.GetName().Name + ".dll");
	}

	internal void GenerateCreateInstance(Type newtype)
	{
		Newobj(newtype.GetConstructor(new Type[0]));
		Ret();
	}

	internal void DefineType(string typename, bool ispublic, Type inheritfromclass)
	{
		if (ispublic)
		{
			_typebuilder = _module.DefineType(typename, TypeAttributes.Public, inheritfromclass);
		}
		else
		{
			_typebuilder = _module.DefineType(typename, TypeAttributes.NotPublic, inheritfromclass);
		}
	}

	internal void DefineMethod(string methname, Type returntype)
	{
		MethodAttributes attributes = MethodAttributes.Public | MethodAttributes.Virtual;
		_methbuilder = _typebuilder.DefineMethod(methname, attributes, returntype, null);
		_ilg = _methbuilder.GetILGenerator();
	}

	internal void BakeMethod()
	{
		_methbuilder = null;
	}

	internal Type BakeType()
	{
		Type result = _typebuilder.CreateType();
		_typebuilder = null;
		return result;
	}
}
