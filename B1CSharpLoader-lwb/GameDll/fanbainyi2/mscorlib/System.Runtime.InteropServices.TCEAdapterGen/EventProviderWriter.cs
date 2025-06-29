using System.Collections;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace System.Runtime.InteropServices.TCEAdapterGen;

internal class EventProviderWriter
{
	private const BindingFlags DefaultLookup = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;

	private readonly Type[] MonitorEnterParamTypes = new Type[2]
	{
		typeof(object),
		Type.GetType("System.Boolean&")
	};

	private ModuleBuilder m_OutputModule;

	private string m_strDestTypeName;

	private Type m_EventItfType;

	private Type m_SrcItfType;

	private Type m_SinkHelperType;

	public EventProviderWriter(ModuleBuilder OutputModule, string strDestTypeName, Type EventItfType, Type SrcItfType, Type SinkHelperType)
	{
		m_OutputModule = OutputModule;
		m_strDestTypeName = strDestTypeName;
		m_EventItfType = EventItfType;
		m_SrcItfType = SrcItfType;
		m_SinkHelperType = SinkHelperType;
	}

	public Type Perform()
	{
		TypeBuilder typeBuilder = m_OutputModule.DefineType(m_strDestTypeName, TypeAttributes.Sealed, typeof(object), new Type[2]
		{
			m_EventItfType,
			typeof(IDisposable)
		});
		FieldBuilder fbCPC = typeBuilder.DefineField("m_ConnectionPointContainer", typeof(IConnectionPointContainer), FieldAttributes.Private);
		FieldBuilder fieldBuilder = typeBuilder.DefineField("m_aEventSinkHelpers", typeof(ArrayList), FieldAttributes.Private);
		FieldBuilder fbEventCP = typeBuilder.DefineField("m_ConnectionPoint", typeof(IConnectionPoint), FieldAttributes.Private);
		MethodBuilder mbInitSrcItf = DefineInitSrcItfMethod(typeBuilder, m_SrcItfType, fieldBuilder, fbEventCP, fbCPC);
		MethodInfo[] nonPropertyMethods = TCEAdapterGenerator.GetNonPropertyMethods(m_SrcItfType);
		for (int i = 0; i < nonPropertyMethods.Length; i++)
		{
			if (m_SrcItfType == nonPropertyMethods[i].DeclaringType)
			{
				MethodBuilder methodBuilder = DefineAddEventMethod(typeBuilder, nonPropertyMethods[i], m_SinkHelperType, fieldBuilder, fbEventCP, mbInitSrcItf);
				MethodBuilder methodBuilder2 = DefineRemoveEventMethod(typeBuilder, nonPropertyMethods[i], m_SinkHelperType, fieldBuilder, fbEventCP);
			}
		}
		DefineConstructor(typeBuilder, fbCPC);
		MethodBuilder finalizeMethod = DefineFinalizeMethod(typeBuilder, m_SinkHelperType, fieldBuilder, fbEventCP);
		DefineDisposeMethod(typeBuilder, finalizeMethod);
		return typeBuilder.CreateType();
	}

	private MethodBuilder DefineAddEventMethod(TypeBuilder OutputTypeBuilder, MethodInfo SrcItfMethod, Type SinkHelperClass, FieldBuilder fbSinkHelperArray, FieldBuilder fbEventCP, MethodBuilder mbInitSrcItf)
	{
		FieldInfo field = SinkHelperClass.GetField("m_" + SrcItfMethod.Name + "Delegate");
		FieldInfo field2 = SinkHelperClass.GetField("m_dwCookie");
		ConstructorInfo constructor = SinkHelperClass.GetConstructor(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
		MethodInfo method = typeof(IConnectionPoint).GetMethod("Advise");
		Type[] array = new Type[1] { typeof(object) };
		MethodInfo method2 = typeof(ArrayList).GetMethod("Add", array, null);
		MethodInfo method3 = typeof(Monitor).GetMethod("Enter", MonitorEnterParamTypes, null);
		array[0] = typeof(object);
		MethodInfo method4 = typeof(Monitor).GetMethod("Exit", array, null);
		MethodBuilder methodBuilder = OutputTypeBuilder.DefineMethod(parameterTypes: new Type[1] { field.FieldType }, name: "add_" + SrcItfMethod.Name, attributes: MethodAttributes.Public | MethodAttributes.Virtual, returnType: null);
		ILGenerator iLGenerator = methodBuilder.GetILGenerator();
		Label label = iLGenerator.DefineLabel();
		LocalBuilder local = iLGenerator.DeclareLocal(SinkHelperClass);
		LocalBuilder local2 = iLGenerator.DeclareLocal(typeof(int));
		LocalBuilder local3 = iLGenerator.DeclareLocal(typeof(bool));
		iLGenerator.BeginExceptionBlock();
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldloca_S, local3);
		iLGenerator.Emit(OpCodes.Call, method3);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldfld, fbEventCP);
		iLGenerator.Emit(OpCodes.Brtrue, label);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Call, mbInitSrcItf);
		iLGenerator.MarkLabel(label);
		iLGenerator.Emit(OpCodes.Newobj, constructor);
		iLGenerator.Emit(OpCodes.Stloc, local);
		iLGenerator.Emit(OpCodes.Ldc_I4_0);
		iLGenerator.Emit(OpCodes.Stloc, local2);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldfld, fbEventCP);
		iLGenerator.Emit(OpCodes.Ldloc, local);
		iLGenerator.Emit(OpCodes.Castclass, typeof(object));
		iLGenerator.Emit(OpCodes.Ldloca, local2);
		iLGenerator.Emit(OpCodes.Callvirt, method);
		iLGenerator.Emit(OpCodes.Ldloc, local);
		iLGenerator.Emit(OpCodes.Ldloc, local2);
		iLGenerator.Emit(OpCodes.Stfld, field2);
		iLGenerator.Emit(OpCodes.Ldloc, local);
		iLGenerator.Emit(OpCodes.Ldarg, (short)1);
		iLGenerator.Emit(OpCodes.Stfld, field);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldfld, fbSinkHelperArray);
		iLGenerator.Emit(OpCodes.Ldloc, local);
		iLGenerator.Emit(OpCodes.Castclass, typeof(object));
		iLGenerator.Emit(OpCodes.Callvirt, method2);
		iLGenerator.Emit(OpCodes.Pop);
		iLGenerator.BeginFinallyBlock();
		Label label2 = iLGenerator.DefineLabel();
		iLGenerator.Emit(OpCodes.Ldloc, local3);
		iLGenerator.Emit(OpCodes.Brfalse_S, label2);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Call, method4);
		iLGenerator.MarkLabel(label2);
		iLGenerator.EndExceptionBlock();
		iLGenerator.Emit(OpCodes.Ret);
		return methodBuilder;
	}

	private MethodBuilder DefineRemoveEventMethod(TypeBuilder OutputTypeBuilder, MethodInfo SrcItfMethod, Type SinkHelperClass, FieldBuilder fbSinkHelperArray, FieldBuilder fbEventCP)
	{
		FieldInfo field = SinkHelperClass.GetField("m_" + SrcItfMethod.Name + "Delegate");
		FieldInfo field2 = SinkHelperClass.GetField("m_dwCookie");
		Type[] array = new Type[1] { typeof(int) };
		MethodInfo method = typeof(ArrayList).GetMethod("RemoveAt", array, null);
		PropertyInfo property = typeof(ArrayList).GetProperty("Item");
		MethodInfo getMethod = property.GetGetMethod();
		PropertyInfo property2 = typeof(ArrayList).GetProperty("Count");
		MethodInfo getMethod2 = property2.GetGetMethod();
		array[0] = typeof(Delegate);
		MethodInfo method2 = typeof(Delegate).GetMethod("Equals", array, null);
		MethodInfo method3 = typeof(Monitor).GetMethod("Enter", MonitorEnterParamTypes, null);
		array[0] = typeof(object);
		MethodInfo method4 = typeof(Monitor).GetMethod("Exit", array, null);
		MethodInfo method5 = typeof(IConnectionPoint).GetMethod("Unadvise");
		MethodInfo method6 = typeof(Marshal).GetMethod("ReleaseComObject");
		MethodBuilder methodBuilder = OutputTypeBuilder.DefineMethod(parameterTypes: new Type[1] { field.FieldType }, name: "remove_" + SrcItfMethod.Name, attributes: MethodAttributes.Public | MethodAttributes.Virtual, returnType: null);
		ILGenerator iLGenerator = methodBuilder.GetILGenerator();
		LocalBuilder local = iLGenerator.DeclareLocal(typeof(int));
		LocalBuilder local2 = iLGenerator.DeclareLocal(typeof(int));
		LocalBuilder local3 = iLGenerator.DeclareLocal(SinkHelperClass);
		LocalBuilder local4 = iLGenerator.DeclareLocal(typeof(bool));
		Label label = iLGenerator.DefineLabel();
		Label label2 = iLGenerator.DefineLabel();
		Label label3 = iLGenerator.DefineLabel();
		Label label4 = iLGenerator.DefineLabel();
		iLGenerator.BeginExceptionBlock();
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldloca_S, local4);
		iLGenerator.Emit(OpCodes.Call, method3);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldfld, fbSinkHelperArray);
		iLGenerator.Emit(OpCodes.Brfalse, label2);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldfld, fbSinkHelperArray);
		iLGenerator.Emit(OpCodes.Callvirt, getMethod2);
		iLGenerator.Emit(OpCodes.Stloc, local);
		iLGenerator.Emit(OpCodes.Ldc_I4, 0);
		iLGenerator.Emit(OpCodes.Stloc, local2);
		iLGenerator.Emit(OpCodes.Ldc_I4, 0);
		iLGenerator.Emit(OpCodes.Ldloc, local);
		iLGenerator.Emit(OpCodes.Bge, label2);
		iLGenerator.MarkLabel(label);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldfld, fbSinkHelperArray);
		iLGenerator.Emit(OpCodes.Ldloc, local2);
		iLGenerator.Emit(OpCodes.Callvirt, getMethod);
		iLGenerator.Emit(OpCodes.Castclass, SinkHelperClass);
		iLGenerator.Emit(OpCodes.Stloc, local3);
		iLGenerator.Emit(OpCodes.Ldloc, local3);
		iLGenerator.Emit(OpCodes.Ldfld, field);
		iLGenerator.Emit(OpCodes.Ldnull);
		iLGenerator.Emit(OpCodes.Beq, label3);
		iLGenerator.Emit(OpCodes.Ldloc, local3);
		iLGenerator.Emit(OpCodes.Ldfld, field);
		iLGenerator.Emit(OpCodes.Ldarg, (short)1);
		iLGenerator.Emit(OpCodes.Castclass, typeof(object));
		iLGenerator.Emit(OpCodes.Callvirt, method2);
		iLGenerator.Emit(OpCodes.Ldc_I4, 255);
		iLGenerator.Emit(OpCodes.And);
		iLGenerator.Emit(OpCodes.Ldc_I4, 0);
		iLGenerator.Emit(OpCodes.Beq, label3);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldfld, fbSinkHelperArray);
		iLGenerator.Emit(OpCodes.Ldloc, local2);
		iLGenerator.Emit(OpCodes.Callvirt, method);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldfld, fbEventCP);
		iLGenerator.Emit(OpCodes.Ldloc, local3);
		iLGenerator.Emit(OpCodes.Ldfld, field2);
		iLGenerator.Emit(OpCodes.Callvirt, method5);
		iLGenerator.Emit(OpCodes.Ldloc, local);
		iLGenerator.Emit(OpCodes.Ldc_I4, 1);
		iLGenerator.Emit(OpCodes.Bgt, label2);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldfld, fbEventCP);
		iLGenerator.Emit(OpCodes.Call, method6);
		iLGenerator.Emit(OpCodes.Pop);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldnull);
		iLGenerator.Emit(OpCodes.Stfld, fbEventCP);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldnull);
		iLGenerator.Emit(OpCodes.Stfld, fbSinkHelperArray);
		iLGenerator.Emit(OpCodes.Br, label2);
		iLGenerator.MarkLabel(label3);
		iLGenerator.Emit(OpCodes.Ldloc, local2);
		iLGenerator.Emit(OpCodes.Ldc_I4, 1);
		iLGenerator.Emit(OpCodes.Add);
		iLGenerator.Emit(OpCodes.Stloc, local2);
		iLGenerator.Emit(OpCodes.Ldloc, local2);
		iLGenerator.Emit(OpCodes.Ldloc, local);
		iLGenerator.Emit(OpCodes.Blt, label);
		iLGenerator.MarkLabel(label2);
		iLGenerator.BeginFinallyBlock();
		Label label5 = iLGenerator.DefineLabel();
		iLGenerator.Emit(OpCodes.Ldloc, local4);
		iLGenerator.Emit(OpCodes.Brfalse_S, label5);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Call, method4);
		iLGenerator.MarkLabel(label5);
		iLGenerator.EndExceptionBlock();
		iLGenerator.Emit(OpCodes.Ret);
		return methodBuilder;
	}

	private MethodBuilder DefineInitSrcItfMethod(TypeBuilder OutputTypeBuilder, Type SourceInterface, FieldBuilder fbSinkHelperArray, FieldBuilder fbEventCP, FieldBuilder fbCPC)
	{
		ConstructorInfo constructor = typeof(ArrayList).GetConstructor(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, new Type[0], null);
		byte[] array = new byte[16];
		Type[] types = new Type[1] { typeof(byte[]) };
		ConstructorInfo constructor2 = typeof(Guid).GetConstructor(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, types, null);
		MethodInfo method = typeof(IConnectionPointContainer).GetMethod("FindConnectionPoint");
		MethodBuilder methodBuilder = OutputTypeBuilder.DefineMethod("Init", MethodAttributes.Private, null, null);
		ILGenerator iLGenerator = methodBuilder.GetILGenerator();
		LocalBuilder local = iLGenerator.DeclareLocal(typeof(IConnectionPoint));
		LocalBuilder local2 = iLGenerator.DeclareLocal(typeof(Guid));
		LocalBuilder local3 = iLGenerator.DeclareLocal(typeof(byte[]));
		iLGenerator.Emit(OpCodes.Ldnull);
		iLGenerator.Emit(OpCodes.Stloc, local);
		array = SourceInterface.GUID.ToByteArray();
		iLGenerator.Emit(OpCodes.Ldc_I4, 16);
		iLGenerator.Emit(OpCodes.Newarr, typeof(byte));
		iLGenerator.Emit(OpCodes.Stloc, local3);
		for (int i = 0; i < 16; i++)
		{
			iLGenerator.Emit(OpCodes.Ldloc, local3);
			iLGenerator.Emit(OpCodes.Ldc_I4, i);
			iLGenerator.Emit(OpCodes.Ldc_I4, (int)array[i]);
			iLGenerator.Emit(OpCodes.Stelem_I1);
		}
		iLGenerator.Emit(OpCodes.Ldloca, local2);
		iLGenerator.Emit(OpCodes.Ldloc, local3);
		iLGenerator.Emit(OpCodes.Call, constructor2);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldfld, fbCPC);
		iLGenerator.Emit(OpCodes.Ldloca, local2);
		iLGenerator.Emit(OpCodes.Ldloca, local);
		iLGenerator.Emit(OpCodes.Callvirt, method);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldloc, local);
		iLGenerator.Emit(OpCodes.Castclass, typeof(IConnectionPoint));
		iLGenerator.Emit(OpCodes.Stfld, fbEventCP);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Newobj, constructor);
		iLGenerator.Emit(OpCodes.Stfld, fbSinkHelperArray);
		iLGenerator.Emit(OpCodes.Ret);
		return methodBuilder;
	}

	private void DefineConstructor(TypeBuilder OutputTypeBuilder, FieldBuilder fbCPC)
	{
		ConstructorInfo constructor = typeof(object).GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, new Type[0], null);
		MethodAttributes attributes = MethodAttributes.SpecialName | (constructor.Attributes & MethodAttributes.MemberAccessMask);
		MethodBuilder methodBuilder = OutputTypeBuilder.DefineMethod(".ctor", attributes, null, new Type[1] { typeof(object) });
		ILGenerator iLGenerator = methodBuilder.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Call, constructor);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldarg, (short)1);
		iLGenerator.Emit(OpCodes.Castclass, typeof(IConnectionPointContainer));
		iLGenerator.Emit(OpCodes.Stfld, fbCPC);
		iLGenerator.Emit(OpCodes.Ret);
	}

	private MethodBuilder DefineFinalizeMethod(TypeBuilder OutputTypeBuilder, Type SinkHelperClass, FieldBuilder fbSinkHelper, FieldBuilder fbEventCP)
	{
		FieldInfo field = SinkHelperClass.GetField("m_dwCookie");
		PropertyInfo property = typeof(ArrayList).GetProperty("Item");
		MethodInfo getMethod = property.GetGetMethod();
		PropertyInfo property2 = typeof(ArrayList).GetProperty("Count");
		MethodInfo getMethod2 = property2.GetGetMethod();
		MethodInfo method = typeof(IConnectionPoint).GetMethod("Unadvise");
		MethodInfo method2 = typeof(Marshal).GetMethod("ReleaseComObject");
		MethodInfo method3 = typeof(Monitor).GetMethod("Enter", MonitorEnterParamTypes, null);
		Type[] types = new Type[1] { typeof(object) };
		MethodInfo method4 = typeof(Monitor).GetMethod("Exit", types, null);
		MethodBuilder methodBuilder = OutputTypeBuilder.DefineMethod("Finalize", MethodAttributes.Public | MethodAttributes.Virtual, null, null);
		ILGenerator iLGenerator = methodBuilder.GetILGenerator();
		LocalBuilder local = iLGenerator.DeclareLocal(typeof(int));
		LocalBuilder local2 = iLGenerator.DeclareLocal(typeof(int));
		LocalBuilder local3 = iLGenerator.DeclareLocal(SinkHelperClass);
		LocalBuilder local4 = iLGenerator.DeclareLocal(typeof(bool));
		iLGenerator.BeginExceptionBlock();
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldloca_S, local4);
		iLGenerator.Emit(OpCodes.Call, method3);
		Label label = iLGenerator.DefineLabel();
		Label label2 = iLGenerator.DefineLabel();
		Label label3 = iLGenerator.DefineLabel();
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldfld, fbEventCP);
		iLGenerator.Emit(OpCodes.Brfalse, label3);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldfld, fbSinkHelper);
		iLGenerator.Emit(OpCodes.Callvirt, getMethod2);
		iLGenerator.Emit(OpCodes.Stloc, local);
		iLGenerator.Emit(OpCodes.Ldc_I4, 0);
		iLGenerator.Emit(OpCodes.Stloc, local2);
		iLGenerator.Emit(OpCodes.Ldc_I4, 0);
		iLGenerator.Emit(OpCodes.Ldloc, local);
		iLGenerator.Emit(OpCodes.Bge, label2);
		iLGenerator.MarkLabel(label);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldfld, fbSinkHelper);
		iLGenerator.Emit(OpCodes.Ldloc, local2);
		iLGenerator.Emit(OpCodes.Callvirt, getMethod);
		iLGenerator.Emit(OpCodes.Castclass, SinkHelperClass);
		iLGenerator.Emit(OpCodes.Stloc, local3);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldfld, fbEventCP);
		iLGenerator.Emit(OpCodes.Ldloc, local3);
		iLGenerator.Emit(OpCodes.Ldfld, field);
		iLGenerator.Emit(OpCodes.Callvirt, method);
		iLGenerator.Emit(OpCodes.Ldloc, local2);
		iLGenerator.Emit(OpCodes.Ldc_I4, 1);
		iLGenerator.Emit(OpCodes.Add);
		iLGenerator.Emit(OpCodes.Stloc, local2);
		iLGenerator.Emit(OpCodes.Ldloc, local2);
		iLGenerator.Emit(OpCodes.Ldloc, local);
		iLGenerator.Emit(OpCodes.Blt, label);
		iLGenerator.MarkLabel(label2);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Ldfld, fbEventCP);
		iLGenerator.Emit(OpCodes.Call, method2);
		iLGenerator.Emit(OpCodes.Pop);
		iLGenerator.MarkLabel(label3);
		iLGenerator.BeginCatchBlock(typeof(Exception));
		iLGenerator.Emit(OpCodes.Pop);
		iLGenerator.BeginFinallyBlock();
		Label label4 = iLGenerator.DefineLabel();
		iLGenerator.Emit(OpCodes.Ldloc, local4);
		iLGenerator.Emit(OpCodes.Brfalse_S, label4);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Call, method4);
		iLGenerator.MarkLabel(label4);
		iLGenerator.EndExceptionBlock();
		iLGenerator.Emit(OpCodes.Ret);
		return methodBuilder;
	}

	private void DefineDisposeMethod(TypeBuilder OutputTypeBuilder, MethodBuilder FinalizeMethod)
	{
		MethodInfo method = typeof(GC).GetMethod("SuppressFinalize");
		MethodBuilder methodBuilder = OutputTypeBuilder.DefineMethod("Dispose", MethodAttributes.Public | MethodAttributes.Virtual, null, null);
		ILGenerator iLGenerator = methodBuilder.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Callvirt, FinalizeMethod);
		iLGenerator.Emit(OpCodes.Ldarg, (short)0);
		iLGenerator.Emit(OpCodes.Call, method);
		iLGenerator.Emit(OpCodes.Ret);
	}
}
