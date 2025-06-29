using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.ObjectPropertyBase", "CoreUObject", UnrealModuleType.Engine)]
public class FObjectPropertyBase : FProperty
{
	private CachedUObject<UClass> propertyClass;

	public UClass PropertyClass
	{
		get
		{
			return propertyClass.Update(Native_FObjectPropertyBase.Get_PropertyClass(base.Address));
		}
		set
		{
			Native_FObjectPropertyBase.Set_PropertyClass(base.Address, propertyClass.Set(value));
		}
	}

	public FObjectPropertyBase()
	{
	}

	public FObjectPropertyBase(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}

	public string GetCPPTypeCustom(string extendedTypeText, uint cppExportFlags, string innerNativeTypeName)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(extendedTypeText);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(innerNativeTypeName);
		using FStringUnsafe fStringUnsafe3 = new FStringUnsafe();
		Native_FObjectPropertyBase.GetCPPTypeCustom(base.Address, ref fStringUnsafe.Array, cppExportFlags, ref fStringUnsafe2.Array, ref fStringUnsafe3.Array);
		return fStringUnsafe3.Value;
	}

	public static bool ParseObjectPropertyValue(FProperty property, UObject ownerObject, UClass requiredMetaClass, uint portFlags, string buffer, out UObject resolvedValue)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(buffer);
		IntPtr out_ResolvedValue = IntPtr.Zero;
		bool result = Native_FObjectPropertyBase.ParseObjectPropertyValue((property == null) ? IntPtr.Zero : property.Address, (ownerObject == null) ? IntPtr.Zero : ownerObject.Address, (requiredMetaClass == null) ? IntPtr.Zero : requiredMetaClass.Address, portFlags, ref fStringUnsafe.Array, ref out_ResolvedValue);
		resolvedValue = GCHelper.Find<UObject>(out_ResolvedValue);
		return result;
	}

	public static UObject FindImportedObject(FProperty property, UObject ownerObject, UObject objectClass, UClass requiredMetaClass, string text, uint portFlags)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(text);
		return GCHelper.Find<UObject>(Native_FObjectPropertyBase.FindImportedObject((property == null) ? IntPtr.Zero : property.Address, (ownerObject == null) ? IntPtr.Zero : ownerObject.Address, (objectClass == null) ? IntPtr.Zero : objectClass.Address, (requiredMetaClass == null) ? IntPtr.Zero : requiredMetaClass.Address, ref fStringUnsafe.Array, portFlags));
	}

	public static string GetExportPath(UObject Object, UObject parent, UObject exportRootScope, uint portFlags)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FObjectPropertyBase.GetExportPath((Object == null) ? IntPtr.Zero : Object.Address, (parent == null) ? IntPtr.Zero : parent.Address, (exportRootScope == null) ? IntPtr.Zero : exportRootScope.Address, portFlags, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public UObject GetObjectPropertyValue(IntPtr propertyValueAddress)
	{
		return GCHelper.Find<UObject>(Native_FObjectPropertyBase.GetObjectPropertyValue(base.Address, propertyValueAddress));
	}

	public UObject GetObjectPropertyValue_InContainer(IntPtr propertyValueAddress, int arrayIndex)
	{
		return GCHelper.Find<UObject>(Native_FObjectPropertyBase.GetObjectPropertyValue_InContainer(base.Address, propertyValueAddress, arrayIndex));
	}

	public void SetObjectPropertyValue(IntPtr propertyValueAddress, UObject value)
	{
		Native_FObjectPropertyBase.SetObjectPropertyValue(base.Address, propertyValueAddress, (value == null) ? IntPtr.Zero : value.Address);
	}

	public void SetObjectPropertyValue_InContainer(IntPtr propertyValueAddress, UObject value, int arrayIndex)
	{
		Native_FObjectPropertyBase.SetObjectPropertyValue_InContainer(base.Address, propertyValueAddress, (value == null) ? IntPtr.Zero : value.Address, arrayIndex);
	}

	public void SetPropertyClass(UClass newPropertyClass)
	{
		Native_FObjectPropertyBase.SetPropertyClass(base.Address, (newPropertyClass == null) ? IntPtr.Zero : newPropertyClass.Address);
	}
}
