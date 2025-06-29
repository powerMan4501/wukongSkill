using System;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.SoftObjectProperty", "CoreUObject", UnrealModuleType.Engine)]
public class FSoftObjectProperty : FObjectPropertyBase, IPropertyAccessor<FSoftObjectPtr>
{
	private FSoftObjectPtr softObject;

	private PropertyAccessor<FSoftObjectPtr> accessor;

	public override EPropertyType PropertyType => EPropertyType.SoftObject;

	public PropertyAccessor<FSoftObjectPtr> Accessor
	{
		get
		{
			if (accessor != null)
			{
				return accessor;
			}
			return accessor = new PropertyAccessor<FSoftObjectPtr>(this);
		}
	}

	public FSoftObjectProperty()
	{
	}

	public FSoftObjectProperty(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}

	public FSoftObjectPtr GetValuePtr(IntPtr address)
	{
		softObject = new FSoftObjectPtr(Marshal.PtrToStructure<FSoftObjectPtrUnsafe>(address).ObjectPath);
		return softObject;
	}

	public void SetValuePtr(IntPtr address, FSoftObjectPtr value)
	{
		softObject = value;
		using FSoftObjectPtrUnsafe other = new FSoftObjectPtrUnsafe(softObject.ObjectPath);
		FSoftObjectPtrUnsafe structure = Marshal.PtrToStructure<FSoftObjectPtrUnsafe>(address);
		structure.Copy(other);
		Marshal.StructureToPtr(structure, address, fDeleteOld: false);
	}
}
