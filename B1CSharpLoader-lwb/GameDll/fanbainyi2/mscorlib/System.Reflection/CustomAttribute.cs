using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Reflection;

internal static class CustomAttribute
{
	private static RuntimeType Type_RuntimeType = (RuntimeType)typeof(RuntimeType);

	private static RuntimeType Type_Type = (RuntimeType)typeof(Type);

	[SecurityCritical]
	internal static bool IsDefined(RuntimeType type, RuntimeType caType, bool inherit)
	{
		if (type.GetElementType() != null)
		{
			return false;
		}
		if (PseudoCustomAttribute.IsDefined(type, caType))
		{
			return true;
		}
		if (IsCustomAttributeDefined(type.GetRuntimeModule(), type.MetadataToken, caType))
		{
			return true;
		}
		if (!inherit)
		{
			return false;
		}
		type = type.BaseType as RuntimeType;
		while (type != null)
		{
			if (IsCustomAttributeDefined(type.GetRuntimeModule(), type.MetadataToken, caType, 0, inherit))
			{
				return true;
			}
			type = type.BaseType as RuntimeType;
		}
		return false;
	}

	[SecuritySafeCritical]
	internal static bool IsDefined(RuntimeMethodInfo method, RuntimeType caType, bool inherit)
	{
		if (PseudoCustomAttribute.IsDefined(method, caType))
		{
			return true;
		}
		if (IsCustomAttributeDefined(method.GetRuntimeModule(), method.MetadataToken, caType))
		{
			return true;
		}
		if (!inherit)
		{
			return false;
		}
		method = method.GetParentDefinition();
		while (method != null)
		{
			if (IsCustomAttributeDefined(method.GetRuntimeModule(), method.MetadataToken, caType, 0, inherit))
			{
				return true;
			}
			method = method.GetParentDefinition();
		}
		return false;
	}

	[SecurityCritical]
	internal static bool IsDefined(RuntimeConstructorInfo ctor, RuntimeType caType)
	{
		if (PseudoCustomAttribute.IsDefined(ctor, caType))
		{
			return true;
		}
		return IsCustomAttributeDefined(ctor.GetRuntimeModule(), ctor.MetadataToken, caType);
	}

	[SecurityCritical]
	internal static bool IsDefined(RuntimePropertyInfo property, RuntimeType caType)
	{
		if (PseudoCustomAttribute.IsDefined(property, caType))
		{
			return true;
		}
		return IsCustomAttributeDefined(property.GetRuntimeModule(), property.MetadataToken, caType);
	}

	[SecurityCritical]
	internal static bool IsDefined(RuntimeEventInfo e, RuntimeType caType)
	{
		if (PseudoCustomAttribute.IsDefined(e, caType))
		{
			return true;
		}
		return IsCustomAttributeDefined(e.GetRuntimeModule(), e.MetadataToken, caType);
	}

	[SecurityCritical]
	internal static bool IsDefined(RuntimeFieldInfo field, RuntimeType caType)
	{
		if (PseudoCustomAttribute.IsDefined(field, caType))
		{
			return true;
		}
		return IsCustomAttributeDefined(field.GetRuntimeModule(), field.MetadataToken, caType);
	}

	[SecurityCritical]
	internal static bool IsDefined(RuntimeParameterInfo parameter, RuntimeType caType)
	{
		if (PseudoCustomAttribute.IsDefined(parameter, caType))
		{
			return true;
		}
		return IsCustomAttributeDefined(parameter.GetRuntimeModule(), parameter.MetadataToken, caType);
	}

	[SecuritySafeCritical]
	internal static bool IsDefined(RuntimeAssembly assembly, RuntimeType caType)
	{
		if (PseudoCustomAttribute.IsDefined(assembly, caType))
		{
			return true;
		}
		return IsCustomAttributeDefined(assembly.ManifestModule as RuntimeModule, RuntimeAssembly.GetToken(assembly.GetNativeHandle()), caType);
	}

	[SecurityCritical]
	internal static bool IsDefined(RuntimeModule module, RuntimeType caType)
	{
		if (PseudoCustomAttribute.IsDefined(module, caType))
		{
			return true;
		}
		return IsCustomAttributeDefined(module, module.MetadataToken, caType);
	}

	[SecurityCritical]
	internal static object[] GetCustomAttributes(RuntimeType type, RuntimeType caType, bool inherit)
	{
		if (type.GetElementType() != null)
		{
			if (!caType.IsValueType)
			{
				return CreateAttributeArrayHelper(caType, 0);
			}
			return EmptyArray<object>.Value;
		}
		if (type.IsGenericType && !type.IsGenericTypeDefinition)
		{
			type = type.GetGenericTypeDefinition() as RuntimeType;
		}
		int count = 0;
		Attribute[] customAttributes = PseudoCustomAttribute.GetCustomAttributes(type, caType, includeSecCa: true, out count);
		if (!inherit || (caType.IsSealed && !GetAttributeUsage(caType).Inherited))
		{
			object[] customAttributes2 = GetCustomAttributes(type.GetRuntimeModule(), type.MetadataToken, count, caType, !AllowCriticalCustomAttributes(type));
			if (count > 0)
			{
				Array.Copy(customAttributes, 0, customAttributes2, customAttributes2.Length - count, count);
			}
			return customAttributes2;
		}
		List<object> list = new List<object>();
		bool mustBeInheritable = false;
		Type elementType = ((caType == null || caType.IsValueType || caType.ContainsGenericParameters) ? typeof(object) : caType);
		while (count > 0)
		{
			list.Add(customAttributes[--count]);
		}
		while (type != (RuntimeType)typeof(object) && type != null)
		{
			object[] customAttributes3 = GetCustomAttributes(type.GetRuntimeModule(), type.MetadataToken, 0, caType, mustBeInheritable, list, !AllowCriticalCustomAttributes(type));
			mustBeInheritable = true;
			for (int i = 0; i < customAttributes3.Length; i++)
			{
				list.Add(customAttributes3[i]);
			}
			type = type.BaseType as RuntimeType;
		}
		object[] array = CreateAttributeArrayHelper(elementType, list.Count);
		Array.Copy(list.ToArray(), 0, array, 0, list.Count);
		return array;
	}

	private static bool AllowCriticalCustomAttributes(RuntimeType type)
	{
		if (type.IsGenericParameter)
		{
			MethodBase declaringMethod = type.DeclaringMethod;
			if (declaringMethod != null)
			{
				return AllowCriticalCustomAttributes(declaringMethod);
			}
			type = type.DeclaringType as RuntimeType;
		}
		if (type.IsSecurityTransparent)
		{
			return SpecialAllowCriticalAttributes(type);
		}
		return true;
	}

	private static bool SpecialAllowCriticalAttributes(RuntimeType type)
	{
		if (type != null && type.Assembly.IsFullyTrusted)
		{
			return RuntimeTypeHandle.IsEquivalentType(type);
		}
		return false;
	}

	private static bool AllowCriticalCustomAttributes(MethodBase method)
	{
		if (method.IsSecurityTransparent)
		{
			return SpecialAllowCriticalAttributes((RuntimeType)method.DeclaringType);
		}
		return true;
	}

	private static bool AllowCriticalCustomAttributes(RuntimeFieldInfo field)
	{
		if (field.IsSecurityTransparent)
		{
			return SpecialAllowCriticalAttributes((RuntimeType)field.DeclaringType);
		}
		return true;
	}

	private static bool AllowCriticalCustomAttributes(RuntimeParameterInfo parameter)
	{
		return AllowCriticalCustomAttributes(parameter.DefiningMethod);
	}

	[SecurityCritical]
	internal static object[] GetCustomAttributes(RuntimeMethodInfo method, RuntimeType caType, bool inherit)
	{
		if (method.IsGenericMethod && !method.IsGenericMethodDefinition)
		{
			method = method.GetGenericMethodDefinition() as RuntimeMethodInfo;
		}
		int count = 0;
		Attribute[] customAttributes = PseudoCustomAttribute.GetCustomAttributes(method, caType, includeSecCa: true, out count);
		if (!inherit || (caType.IsSealed && !GetAttributeUsage(caType).Inherited))
		{
			object[] customAttributes2 = GetCustomAttributes(method.GetRuntimeModule(), method.MetadataToken, count, caType, !AllowCriticalCustomAttributes(method));
			if (count > 0)
			{
				Array.Copy(customAttributes, 0, customAttributes2, customAttributes2.Length - count, count);
			}
			return customAttributes2;
		}
		List<object> list = new List<object>();
		bool mustBeInheritable = false;
		Type elementType = ((caType == null || caType.IsValueType || caType.ContainsGenericParameters) ? typeof(object) : caType);
		while (count > 0)
		{
			list.Add(customAttributes[--count]);
		}
		while (method != null)
		{
			object[] customAttributes3 = GetCustomAttributes(method.GetRuntimeModule(), method.MetadataToken, 0, caType, mustBeInheritable, list, !AllowCriticalCustomAttributes(method));
			mustBeInheritable = true;
			for (int i = 0; i < customAttributes3.Length; i++)
			{
				list.Add(customAttributes3[i]);
			}
			method = method.GetParentDefinition();
		}
		object[] array = CreateAttributeArrayHelper(elementType, list.Count);
		Array.Copy(list.ToArray(), 0, array, 0, list.Count);
		return array;
	}

	[SecuritySafeCritical]
	internal static object[] GetCustomAttributes(RuntimeConstructorInfo ctor, RuntimeType caType)
	{
		int count = 0;
		Attribute[] customAttributes = PseudoCustomAttribute.GetCustomAttributes(ctor, caType, includeSecCa: true, out count);
		object[] customAttributes2 = GetCustomAttributes(ctor.GetRuntimeModule(), ctor.MetadataToken, count, caType, !AllowCriticalCustomAttributes(ctor));
		if (count > 0)
		{
			Array.Copy(customAttributes, 0, customAttributes2, customAttributes2.Length - count, count);
		}
		return customAttributes2;
	}

	[SecuritySafeCritical]
	internal static object[] GetCustomAttributes(RuntimePropertyInfo property, RuntimeType caType)
	{
		int count = 0;
		Attribute[] customAttributes = PseudoCustomAttribute.GetCustomAttributes(property, caType, out count);
		bool isDecoratedTargetSecurityTransparent = property.GetRuntimeModule().GetRuntimeAssembly().IsAllSecurityTransparent();
		object[] customAttributes2 = GetCustomAttributes(property.GetRuntimeModule(), property.MetadataToken, count, caType, isDecoratedTargetSecurityTransparent);
		if (count > 0)
		{
			Array.Copy(customAttributes, 0, customAttributes2, customAttributes2.Length - count, count);
		}
		return customAttributes2;
	}

	[SecuritySafeCritical]
	internal static object[] GetCustomAttributes(RuntimeEventInfo e, RuntimeType caType)
	{
		int count = 0;
		Attribute[] customAttributes = PseudoCustomAttribute.GetCustomAttributes(e, caType, out count);
		bool isDecoratedTargetSecurityTransparent = e.GetRuntimeModule().GetRuntimeAssembly().IsAllSecurityTransparent();
		object[] customAttributes2 = GetCustomAttributes(e.GetRuntimeModule(), e.MetadataToken, count, caType, isDecoratedTargetSecurityTransparent);
		if (count > 0)
		{
			Array.Copy(customAttributes, 0, customAttributes2, customAttributes2.Length - count, count);
		}
		return customAttributes2;
	}

	[SecuritySafeCritical]
	internal static object[] GetCustomAttributes(RuntimeFieldInfo field, RuntimeType caType)
	{
		int count = 0;
		Attribute[] customAttributes = PseudoCustomAttribute.GetCustomAttributes(field, caType, out count);
		object[] customAttributes2 = GetCustomAttributes(field.GetRuntimeModule(), field.MetadataToken, count, caType, !AllowCriticalCustomAttributes(field));
		if (count > 0)
		{
			Array.Copy(customAttributes, 0, customAttributes2, customAttributes2.Length - count, count);
		}
		return customAttributes2;
	}

	[SecuritySafeCritical]
	internal static object[] GetCustomAttributes(RuntimeParameterInfo parameter, RuntimeType caType)
	{
		int count = 0;
		Attribute[] customAttributes = PseudoCustomAttribute.GetCustomAttributes(parameter, caType, out count);
		object[] customAttributes2 = GetCustomAttributes(parameter.GetRuntimeModule(), parameter.MetadataToken, count, caType, !AllowCriticalCustomAttributes(parameter));
		if (count > 0)
		{
			Array.Copy(customAttributes, 0, customAttributes2, customAttributes2.Length - count, count);
		}
		return customAttributes2;
	}

	[SecuritySafeCritical]
	internal static object[] GetCustomAttributes(RuntimeAssembly assembly, RuntimeType caType)
	{
		int count = 0;
		Attribute[] customAttributes = PseudoCustomAttribute.GetCustomAttributes(assembly, caType, includeSecCa: true, out count);
		int token = RuntimeAssembly.GetToken(assembly.GetNativeHandle());
		bool isDecoratedTargetSecurityTransparent = assembly.IsAllSecurityTransparent();
		object[] customAttributes2 = GetCustomAttributes(assembly.ManifestModule as RuntimeModule, token, count, caType, isDecoratedTargetSecurityTransparent);
		if (count > 0)
		{
			Array.Copy(customAttributes, 0, customAttributes2, customAttributes2.Length - count, count);
		}
		return customAttributes2;
	}

	[SecuritySafeCritical]
	internal static object[] GetCustomAttributes(RuntimeModule module, RuntimeType caType)
	{
		int count = 0;
		Attribute[] customAttributes = PseudoCustomAttribute.GetCustomAttributes(module, caType, out count);
		bool isDecoratedTargetSecurityTransparent = module.GetRuntimeAssembly().IsAllSecurityTransparent();
		object[] customAttributes2 = GetCustomAttributes(module, module.MetadataToken, count, caType, isDecoratedTargetSecurityTransparent);
		if (count > 0)
		{
			Array.Copy(customAttributes, 0, customAttributes2, customAttributes2.Length - count, count);
		}
		return customAttributes2;
	}

	[SecuritySafeCritical]
	internal static bool IsAttributeDefined(RuntimeModule decoratedModule, int decoratedMetadataToken, int attributeCtorToken)
	{
		return IsCustomAttributeDefined(decoratedModule, decoratedMetadataToken, null, attributeCtorToken, mustBeInheritable: false);
	}

	[SecurityCritical]
	private static bool IsCustomAttributeDefined(RuntimeModule decoratedModule, int decoratedMetadataToken, RuntimeType attributeFilterType)
	{
		return IsCustomAttributeDefined(decoratedModule, decoratedMetadataToken, attributeFilterType, 0, mustBeInheritable: false);
	}

	[SecurityCritical]
	private static bool IsCustomAttributeDefined(RuntimeModule decoratedModule, int decoratedMetadataToken, RuntimeType attributeFilterType, int attributeCtorToken, bool mustBeInheritable)
	{
		if (decoratedModule.Assembly.ReflectionOnly)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Arg_ReflectionOnlyCA"));
		}
		CustomAttributeRecord[] customAttributeRecords = CustomAttributeData.GetCustomAttributeRecords(decoratedModule, decoratedMetadataToken);
		if (attributeFilterType != null)
		{
			MetadataImport metadataImport = decoratedModule.MetadataImport;
			Assembly lastAptcaOkAssembly = null;
			foreach (CustomAttributeRecord caRecord in customAttributeRecords)
			{
				if (FilterCustomAttributeRecord(caRecord, metadataImport, ref lastAptcaOkAssembly, decoratedModule, decoratedMetadataToken, attributeFilterType, mustBeInheritable, null, null, out var _, out var _, out var _, out var _))
				{
					return true;
				}
			}
		}
		else
		{
			for (int j = 0; j < customAttributeRecords.Length; j++)
			{
				CustomAttributeRecord customAttributeRecord = customAttributeRecords[j];
				if ((int)customAttributeRecord.tkCtor == attributeCtorToken)
				{
					return true;
				}
			}
		}
		return false;
	}

	[SecurityCritical]
	private static object[] GetCustomAttributes(RuntimeModule decoratedModule, int decoratedMetadataToken, int pcaCount, RuntimeType attributeFilterType, bool isDecoratedTargetSecurityTransparent)
	{
		return GetCustomAttributes(decoratedModule, decoratedMetadataToken, pcaCount, attributeFilterType, mustBeInheritable: false, null, isDecoratedTargetSecurityTransparent);
	}

	[SecurityCritical]
	private unsafe static object[] GetCustomAttributes(RuntimeModule decoratedModule, int decoratedMetadataToken, int pcaCount, RuntimeType attributeFilterType, bool mustBeInheritable, IList derivedAttributes, bool isDecoratedTargetSecurityTransparent)
	{
		if (decoratedModule.Assembly.ReflectionOnly)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Arg_ReflectionOnlyCA"));
		}
		MetadataImport metadataImport = decoratedModule.MetadataImport;
		CustomAttributeRecord[] customAttributeRecords = CustomAttributeData.GetCustomAttributeRecords(decoratedModule, decoratedMetadataToken);
		Type elementType = ((attributeFilterType == null || attributeFilterType.IsValueType || attributeFilterType.ContainsGenericParameters) ? typeof(object) : attributeFilterType);
		if (attributeFilterType == null && customAttributeRecords.Length == 0)
		{
			return CreateAttributeArrayHelper(elementType, 0);
		}
		object[] array = CreateAttributeArrayHelper(elementType, customAttributeRecords.Length);
		int num = 0;
		SecurityContextFrame securityContextFrame = default(SecurityContextFrame);
		securityContextFrame.Push(decoratedModule.GetRuntimeAssembly());
		Assembly lastAptcaOkAssembly = null;
		for (int i = 0; i < customAttributeRecords.Length; i++)
		{
			object obj = null;
			CustomAttributeRecord caRecord = customAttributeRecords[i];
			IRuntimeMethodInfo ctor = null;
			RuntimeType attributeType = null;
			int namedArgs = 0;
			IntPtr blob = caRecord.blob.Signature;
			IntPtr intPtr = (IntPtr)((byte*)(void*)blob + caRecord.blob.Length);
			int num2 = (int)((byte*)(void*)intPtr - (byte*)(void*)blob);
			if (!FilterCustomAttributeRecord(caRecord, metadataImport, ref lastAptcaOkAssembly, decoratedModule, decoratedMetadataToken, attributeFilterType, mustBeInheritable, array, derivedAttributes, out attributeType, out ctor, out var ctorHasParameters, out var isVarArg))
			{
				continue;
			}
			if (ctor != null)
			{
				RuntimeMethodHandle.CheckLinktimeDemands(ctor, decoratedModule, isDecoratedTargetSecurityTransparent);
			}
			RuntimeConstructorInfo.CheckCanCreateInstance(attributeType, isVarArg);
			if (ctorHasParameters)
			{
				obj = CreateCaObject(decoratedModule, ctor, ref blob, intPtr, out namedArgs);
			}
			else
			{
				obj = RuntimeTypeHandle.CreateCaInstance(attributeType, ctor);
				if (num2 == 0)
				{
					namedArgs = 0;
				}
				else
				{
					if (Marshal.ReadInt16(blob) != 1)
					{
						throw new CustomAttributeFormatException();
					}
					blob = (IntPtr)((byte*)(void*)blob + 2);
					namedArgs = Marshal.ReadInt16(blob);
					blob = (IntPtr)((byte*)(void*)blob + 2);
				}
			}
			for (int j = 0; j < namedArgs; j++)
			{
				IntPtr signature = caRecord.blob.Signature;
				GetPropertyOrFieldData(decoratedModule, ref blob, intPtr, out var name, out var isProperty, out var type, out var value);
				try
				{
					if (isProperty)
					{
						if (type == null && value != null)
						{
							type = (RuntimeType)value.GetType();
							if (type == Type_RuntimeType)
							{
								type = Type_Type;
							}
						}
						RuntimePropertyInfo runtimePropertyInfo = null;
						runtimePropertyInfo = ((!(type == null)) ? (attributeType.GetProperty(name, type, Type.EmptyTypes) as RuntimePropertyInfo) : (attributeType.GetProperty(name) as RuntimePropertyInfo));
						if (runtimePropertyInfo == null)
						{
							throw new CustomAttributeFormatException(string.Format(CultureInfo.CurrentUICulture, Environment.GetResourceString(isProperty ? "RFLCT.InvalidPropFail" : "RFLCT.InvalidFieldFail"), name));
						}
						RuntimeMethodInfo runtimeMethodInfo = runtimePropertyInfo.GetSetMethod(nonPublic: true) as RuntimeMethodInfo;
						if (runtimeMethodInfo.IsPublic)
						{
							RuntimeMethodHandle.CheckLinktimeDemands(runtimeMethodInfo, decoratedModule, isDecoratedTargetSecurityTransparent);
							runtimeMethodInfo.UnsafeInvoke(obj, BindingFlags.Default, null, new object[1] { value }, null);
						}
					}
					else
					{
						RtFieldInfo rtFieldInfo = attributeType.GetField(name) as RtFieldInfo;
						if (isDecoratedTargetSecurityTransparent)
						{
							RuntimeFieldHandle.CheckAttributeAccess(rtFieldInfo.FieldHandle, decoratedModule.GetNativeHandle());
						}
						rtFieldInfo.CheckConsistency(obj);
						rtFieldInfo.UnsafeSetValue(obj, value, BindingFlags.Default, Type.DefaultBinder, null);
					}
				}
				catch (Exception inner)
				{
					throw new CustomAttributeFormatException(string.Format(CultureInfo.CurrentUICulture, Environment.GetResourceString(isProperty ? "RFLCT.InvalidPropFail" : "RFLCT.InvalidFieldFail"), name), inner);
				}
			}
			if (!blob.Equals(intPtr))
			{
				throw new CustomAttributeFormatException();
			}
			array[num++] = obj;
		}
		securityContextFrame.Pop();
		if (num == customAttributeRecords.Length && pcaCount == 0)
		{
			return array;
		}
		object[] array2 = CreateAttributeArrayHelper(elementType, num + pcaCount);
		Array.Copy(array, 0, array2, 0, num);
		return array2;
	}

	[SecurityCritical]
	private unsafe static bool FilterCustomAttributeRecord(CustomAttributeRecord caRecord, MetadataImport scope, ref Assembly lastAptcaOkAssembly, RuntimeModule decoratedModule, MetadataToken decoratedToken, RuntimeType attributeFilterType, bool mustBeInheritable, object[] attributes, IList derivedAttributes, out RuntimeType attributeType, out IRuntimeMethodInfo ctor, out bool ctorHasParameters, out bool isVarArg)
	{
		ctor = null;
		attributeType = null;
		ctorHasParameters = false;
		isVarArg = false;
		IntPtr signature = caRecord.blob.Signature;
		IntPtr intPtr = (IntPtr)((byte*)(void*)signature + caRecord.blob.Length);
		attributeType = decoratedModule.ResolveType(scope.GetParentToken(caRecord.tkCtor), null, null) as RuntimeType;
		if (!attributeFilterType.IsAssignableFrom(attributeType))
		{
			return false;
		}
		if (!AttributeUsageCheck(attributeType, mustBeInheritable, attributes, derivedAttributes))
		{
			return false;
		}
		if ((attributeType.Attributes & TypeAttributes.WindowsRuntime) == TypeAttributes.WindowsRuntime)
		{
			return false;
		}
		RuntimeAssembly runtimeAssembly = (RuntimeAssembly)attributeType.Assembly;
		RuntimeAssembly runtimeAssembly2 = (RuntimeAssembly)decoratedModule.Assembly;
		if (runtimeAssembly != lastAptcaOkAssembly && !RuntimeAssembly.AptcaCheck(runtimeAssembly, runtimeAssembly2))
		{
			return false;
		}
		lastAptcaOkAssembly = runtimeAssembly2;
		ConstArray methodSignature = scope.GetMethodSignature(caRecord.tkCtor);
		isVarArg = (methodSignature[0] & 5) != 0;
		ctorHasParameters = methodSignature[1] != 0;
		if (ctorHasParameters)
		{
			ctor = ModuleHandle.ResolveMethodHandleInternal(decoratedModule.GetNativeHandle(), caRecord.tkCtor);
		}
		else
		{
			ctor = attributeType.GetTypeHandleInternal().GetDefaultConstructor();
			if (ctor == null && !attributeType.IsValueType)
			{
				throw new MissingMethodException(".ctor");
			}
		}
		MetadataToken metadataToken = default(MetadataToken);
		if (decoratedToken.IsParamDef)
		{
			metadataToken = new MetadataToken(scope.GetParentToken(decoratedToken));
			metadataToken = new MetadataToken(scope.GetParentToken(metadataToken));
		}
		else if (decoratedToken.IsMethodDef || decoratedToken.IsProperty || decoratedToken.IsEvent || decoratedToken.IsFieldDef)
		{
			metadataToken = new MetadataToken(scope.GetParentToken(decoratedToken));
		}
		else if (decoratedToken.IsTypeDef)
		{
			metadataToken = decoratedToken;
		}
		else if (decoratedToken.IsGenericPar)
		{
			metadataToken = new MetadataToken(scope.GetParentToken(decoratedToken));
			if (metadataToken.IsMethodDef)
			{
				metadataToken = new MetadataToken(scope.GetParentToken(metadataToken));
			}
		}
		RuntimeTypeHandle sourceTypeHandle = (metadataToken.IsTypeDef ? decoratedModule.ModuleHandle.ResolveTypeHandle(metadataToken) : default(RuntimeTypeHandle));
		return RuntimeMethodHandle.IsCAVisibleFromDecoratedType(attributeType.TypeHandle, ctor, sourceTypeHandle, decoratedModule);
	}

	[SecurityCritical]
	private static bool AttributeUsageCheck(RuntimeType attributeType, bool mustBeInheritable, object[] attributes, IList derivedAttributes)
	{
		AttributeUsageAttribute attributeUsageAttribute = null;
		if (mustBeInheritable)
		{
			attributeUsageAttribute = GetAttributeUsage(attributeType);
			if (!attributeUsageAttribute.Inherited)
			{
				return false;
			}
		}
		if (derivedAttributes == null)
		{
			return true;
		}
		for (int i = 0; i < derivedAttributes.Count; i++)
		{
			if (derivedAttributes[i].GetType() == attributeType)
			{
				if (attributeUsageAttribute == null)
				{
					attributeUsageAttribute = GetAttributeUsage(attributeType);
				}
				return attributeUsageAttribute.AllowMultiple;
			}
		}
		return true;
	}

	[SecurityCritical]
	internal static AttributeUsageAttribute GetAttributeUsage(RuntimeType decoratedAttribute)
	{
		RuntimeModule runtimeModule = decoratedAttribute.GetRuntimeModule();
		MetadataImport metadataImport = runtimeModule.MetadataImport;
		CustomAttributeRecord[] customAttributeRecords = CustomAttributeData.GetCustomAttributeRecords(runtimeModule, decoratedAttribute.MetadataToken);
		AttributeUsageAttribute attributeUsageAttribute = null;
		for (int i = 0; i < customAttributeRecords.Length; i++)
		{
			CustomAttributeRecord customAttributeRecord = customAttributeRecords[i];
			RuntimeType runtimeType = runtimeModule.ResolveType(metadataImport.GetParentToken(customAttributeRecord.tkCtor), null, null) as RuntimeType;
			if (!(runtimeType != (RuntimeType)typeof(AttributeUsageAttribute)))
			{
				if (attributeUsageAttribute != null)
				{
					throw new FormatException(string.Format(CultureInfo.CurrentUICulture, Environment.GetResourceString("Format_AttributeUsage"), runtimeType));
				}
				ParseAttributeUsageAttribute(customAttributeRecord.blob, out var targets, out var inherited, out var allowMultiple);
				attributeUsageAttribute = new AttributeUsageAttribute(targets, allowMultiple, inherited);
			}
		}
		if (attributeUsageAttribute == null)
		{
			return AttributeUsageAttribute.Default;
		}
		return attributeUsageAttribute;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void _ParseAttributeUsageAttribute(IntPtr pCa, int cCa, out int targets, out bool inherited, out bool allowMultiple);

	[SecurityCritical]
	private static void ParseAttributeUsageAttribute(ConstArray ca, out AttributeTargets targets, out bool inherited, out bool allowMultiple)
	{
		_ParseAttributeUsageAttribute(ca.Signature, ca.Length, out var targets2, out inherited, out allowMultiple);
		targets = (AttributeTargets)targets2;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private unsafe static extern object _CreateCaObject(RuntimeModule pModule, IRuntimeMethodInfo pCtor, byte** ppBlob, byte* pEndBlob, int* pcNamedArgs);

	[SecurityCritical]
	private unsafe static object CreateCaObject(RuntimeModule module, IRuntimeMethodInfo ctor, ref IntPtr blob, IntPtr blobEnd, out int namedArgs)
	{
		byte* ptr = (byte*)(void*)blob;
		byte* pEndBlob = (byte*)(void*)blobEnd;
		int num = default(int);
		object result = _CreateCaObject(module, ctor, &ptr, pEndBlob, &num);
		blob = (IntPtr)ptr;
		namedArgs = num;
		return result;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private unsafe static extern void _GetPropertyOrFieldData(RuntimeModule pModule, byte** ppBlobStart, byte* pBlobEnd, out string name, out bool bIsProperty, out RuntimeType type, out object value);

	[SecurityCritical]
	private unsafe static void GetPropertyOrFieldData(RuntimeModule module, ref IntPtr blobStart, IntPtr blobEnd, out string name, out bool isProperty, out RuntimeType type, out object value)
	{
		byte* ptr = (byte*)(void*)blobStart;
		_GetPropertyOrFieldData(module.GetNativeHandle(), &ptr, (byte*)(void*)blobEnd, out name, out isProperty, out type, out value);
		blobStart = (IntPtr)ptr;
	}

	[SecuritySafeCritical]
	private static object[] CreateAttributeArrayHelper(Type elementType, int elementCount)
	{
		return (object[])Array.UnsafeCreateInstance(elementType, elementCount);
	}
}
