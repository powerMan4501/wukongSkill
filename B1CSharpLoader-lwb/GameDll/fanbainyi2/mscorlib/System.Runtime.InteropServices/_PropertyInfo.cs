using System.Globalization;
using System.Reflection;

namespace System.Runtime.InteropServices;

[Guid("F59ED4E4-E68F-3218-BD77-061AA82824BF")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[CLSCompliant(false)]
[TypeLibImportClass(typeof(PropertyInfo))]
[ComVisible(true)]
public interface _PropertyInfo
{
	MemberTypes MemberType { get; }

	string Name { get; }

	Type DeclaringType { get; }

	Type ReflectedType { get; }

	Type PropertyType { get; }

	PropertyAttributes Attributes { get; }

	bool CanRead { get; }

	bool CanWrite { get; }

	bool IsSpecialName { get; }

	void GetTypeInfoCount(out uint pcTInfo);

	void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);

	void GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);

	void Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);

	new string ToString();

	new bool Equals(object other);

	new int GetHashCode();

	new Type GetType();

	object[] GetCustomAttributes(Type attributeType, bool inherit);

	object[] GetCustomAttributes(bool inherit);

	bool IsDefined(Type attributeType, bool inherit);

	object GetValue(object obj, object[] index);

	object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	void SetValue(object obj, object value, object[] index);

	void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	MethodInfo[] GetAccessors(bool nonPublic);

	MethodInfo GetGetMethod(bool nonPublic);

	MethodInfo GetSetMethod(bool nonPublic);

	ParameterInfo[] GetIndexParameters();

	MethodInfo[] GetAccessors();

	MethodInfo GetGetMethod();

	MethodInfo GetSetMethod();
}
