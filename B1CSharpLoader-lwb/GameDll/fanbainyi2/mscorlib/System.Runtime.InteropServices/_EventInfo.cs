using System.Reflection;

namespace System.Runtime.InteropServices;

[Guid("9DE59C64-D889-35A1-B897-587D74469E5B")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[CLSCompliant(false)]
[TypeLibImportClass(typeof(EventInfo))]
[ComVisible(true)]
public interface _EventInfo
{
	MemberTypes MemberType { get; }

	string Name { get; }

	Type DeclaringType { get; }

	Type ReflectedType { get; }

	EventAttributes Attributes { get; }

	Type EventHandlerType { get; }

	bool IsSpecialName { get; }

	bool IsMulticast { get; }

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

	MethodInfo GetAddMethod(bool nonPublic);

	MethodInfo GetRemoveMethod(bool nonPublic);

	MethodInfo GetRaiseMethod(bool nonPublic);

	MethodInfo GetAddMethod();

	MethodInfo GetRemoveMethod();

	MethodInfo GetRaiseMethod();

	void AddEventHandler(object target, Delegate handler);

	void RemoveEventHandler(object target, Delegate handler);
}
