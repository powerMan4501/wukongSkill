using System.Reflection;
using System.Reflection.Emit;

namespace System.Runtime.InteropServices.TCEAdapterGen;

internal class EventSinkHelperWriter
{
	public static readonly string GeneratedTypeNamePostfix = "_SinkHelper";

	private Type m_InputType;

	private Type m_EventItfType;

	private ModuleBuilder m_OutputModule;

	public EventSinkHelperWriter(ModuleBuilder OutputModule, Type InputType, Type EventItfType)
	{
		m_InputType = InputType;
		m_OutputModule = OutputModule;
		m_EventItfType = EventItfType;
	}

	public Type Perform()
	{
		Type[] aInterfaceTypes = new Type[1] { m_InputType };
		string text = null;
		string text2 = NameSpaceExtractor.ExtractNameSpace(m_EventItfType.FullName);
		if (text2 != "")
		{
			text = text2 + ".";
		}
		text = text + m_InputType.Name + GeneratedTypeNamePostfix;
		TypeBuilder typeBuilder = TCEAdapterGenerator.DefineUniqueType(text, TypeAttributes.Public | TypeAttributes.Sealed, null, aInterfaceTypes, m_OutputModule);
		TCEAdapterGenerator.SetHiddenAttribute(typeBuilder);
		TCEAdapterGenerator.SetClassInterfaceTypeToNone(typeBuilder);
		MethodInfo[] propertyMethods = TCEAdapterGenerator.GetPropertyMethods(m_InputType);
		MethodInfo[] array = propertyMethods;
		foreach (MethodInfo method in array)
		{
			DefineBlankMethod(typeBuilder, method);
		}
		MethodInfo[] nonPropertyMethods = TCEAdapterGenerator.GetNonPropertyMethods(m_InputType);
		FieldBuilder[] array2 = new FieldBuilder[nonPropertyMethods.Length];
		for (int j = 0; j < nonPropertyMethods.Length; j++)
		{
			if (m_InputType == nonPropertyMethods[j].DeclaringType)
			{
				MethodInfo method2 = m_EventItfType.GetMethod("add_" + nonPropertyMethods[j].Name);
				ParameterInfo[] parameters = method2.GetParameters();
				Type parameterType = parameters[0].ParameterType;
				array2[j] = typeBuilder.DefineField("m_" + nonPropertyMethods[j].Name + "Delegate", parameterType, FieldAttributes.Public);
				DefineEventMethod(typeBuilder, nonPropertyMethods[j], parameterType, array2[j]);
			}
		}
		FieldBuilder fbCookie = typeBuilder.DefineField("m_dwCookie", typeof(int), FieldAttributes.Public);
		DefineConstructor(typeBuilder, fbCookie, array2);
		return typeBuilder.CreateType();
	}

	private void DefineBlankMethod(TypeBuilder OutputTypeBuilder, MethodInfo Method)
	{
		ParameterInfo[] parameters = Method.GetParameters();
		Type[] array = new Type[parameters.Length];
		for (int i = 0; i < parameters.Length; i++)
		{
			array[i] = parameters[i].ParameterType;
		}
		MethodBuilder methodBuilder = OutputTypeBuilder.DefineMethod(Method.Name, Method.Attributes & ~MethodAttributes.Abstract, Method.CallingConvention, Method.ReturnType, array);
		ILGenerator iLGenerator = methodBuilder.GetILGenerator();
		AddReturn(Method.ReturnType, iLGenerator, methodBuilder);
		iLGenerator.Emit(OpCodes.Ret);
	}

	private void DefineEventMethod(TypeBuilder OutputTypeBuilder, MethodInfo Method, Type DelegateCls, FieldBuilder fbDelegate)
	{
		MethodInfo method = DelegateCls.GetMethod("Invoke");
		Type returnType = Method.ReturnType;
		ParameterInfo[] parameters = Method.GetParameters();
		Type[] array;
		if (parameters != null)
		{
			array = new Type[parameters.Length];
			for (int i = 0; i < parameters.Length; i++)
			{
				array[i] = parameters[i].ParameterType;
			}
		}
		else
		{
			array = null;
		}
		MethodAttributes attributes = MethodAttributes.Public | MethodAttributes.Virtual;
		MethodBuilder methodBuilder = OutputTypeBuilder.DefineMethod(Method.Name, attributes, CallingConventions.Standard, returnType, array);
		ILGenerator iLGenerator = methodBuilder.GetILGenerator();
		Label label = iLGenerator.DefineLabel();
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldfld, fbDelegate);
		iLGenerator.Emit(OpCodes.Brfalse, label);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldfld, fbDelegate);
		ParameterInfo[] parameters2 = Method.GetParameters();
		for (int j = 0; j < parameters2.Length; j++)
		{
			iLGenerator.Emit(OpCodes.Ldarg, (short)(j + 1));
		}
		iLGenerator.Emit(OpCodes.Callvirt, method);
		iLGenerator.Emit(OpCodes.Ret);
		iLGenerator.MarkLabel(label);
		AddReturn(returnType, iLGenerator, methodBuilder);
		iLGenerator.Emit(OpCodes.Ret);
	}

	private void AddReturn(Type ReturnType, ILGenerator il, MethodBuilder Meth)
	{
		if (ReturnType == typeof(void))
		{
			return;
		}
		if (ReturnType.IsPrimitive)
		{
			switch (Type.GetTypeCode(ReturnType))
			{
			case TypeCode.Boolean:
			case TypeCode.Char:
			case TypeCode.SByte:
			case TypeCode.Byte:
			case TypeCode.Int16:
			case TypeCode.UInt16:
			case TypeCode.Int32:
			case TypeCode.UInt32:
				il.Emit(OpCodes.Ldc_I4_0);
				return;
			case TypeCode.Int64:
			case TypeCode.UInt64:
				il.Emit(OpCodes.Ldc_I4_0);
				il.Emit(OpCodes.Conv_I8);
				return;
			case TypeCode.Single:
				il.Emit(OpCodes.Ldc_R4, 0);
				return;
			case TypeCode.Double:
				il.Emit(OpCodes.Ldc_R4, 0);
				il.Emit(OpCodes.Conv_R8);
				return;
			}
			if (ReturnType == typeof(IntPtr))
			{
				il.Emit(OpCodes.Ldc_I4_0);
			}
		}
		else if (ReturnType.IsValueType)
		{
			Meth.InitLocals = true;
			LocalBuilder local = il.DeclareLocal(ReturnType);
			il.Emit(OpCodes.Ldloc_S, local);
		}
		else
		{
			il.Emit(OpCodes.Ldnull);
		}
	}

	private void DefineConstructor(TypeBuilder OutputTypeBuilder, FieldBuilder fbCookie, FieldBuilder[] afbDelegates)
	{
		ConstructorInfo constructor = typeof(object).GetConstructor(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, new Type[0], null);
		MethodBuilder methodBuilder = OutputTypeBuilder.DefineMethod(".ctor", MethodAttributes.Assembly | MethodAttributes.SpecialName, CallingConventions.Standard, null, null);
		ILGenerator iLGenerator = methodBuilder.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Call, constructor);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldc_I4, 0);
		iLGenerator.Emit(OpCodes.Stfld, fbCookie);
		for (int i = 0; i < afbDelegates.Length; i++)
		{
			if (afbDelegates[i] != null)
			{
				iLGenerator.Emit(OpCodes.Ldarg, (short)0);
				iLGenerator.Emit(OpCodes.Ldnull);
				iLGenerator.Emit(OpCodes.Stfld, afbDelegates[i]);
			}
		}
		iLGenerator.Emit(OpCodes.Ret);
	}
}
