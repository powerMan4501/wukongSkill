using System;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

public class PropertyAccessor<T>
{
	protected FProperty property;

	protected IPropertyAccessor<T> customAccessor;

	protected IPropertyDefaultValueAccessor<T> defaultValueAccessor;

	public PropertyAccessor(FProperty property)
	{
		this.property = property;
		customAccessor = property as IPropertyAccessor<T>;
		defaultValueAccessor = property as IPropertyDefaultValueAccessor<T>;
	}

	public T GetValue(UObject instance, int arrayIndex = 0)
	{
		return GetValuePtr(property.ContainerPtrToValuePtr((instance == null) ? IntPtr.Zero : instance.Address, arrayIndex));
	}

	public T GetValue(IntPtr instance, int arrayIndex = 0)
	{
		return GetValuePtr(property.ContainerPtrToValuePtr(instance, arrayIndex));
	}

	public T GetValueOrDefault(UObject instance, int arrayIndex = 0)
	{
		if (!(instance == null))
		{
			return GetValue(instance, arrayIndex);
		}
		return GetDefaultValue();
	}

	public T GetValueOrDefault(IntPtr instance, int arrayIndex = 0)
	{
		if (!(instance == IntPtr.Zero))
		{
			return GetValue(instance, arrayIndex);
		}
		return GetDefaultValue();
	}

	public virtual T GetValuePtr(IntPtr address)
	{
		if (customAccessor != null)
		{
			return customAccessor.GetValuePtr(address);
		}
		return Marshal.PtrToStructure<T>(address);
	}

	public void SetValue(UObject obj, T value, int arrayIndex = 0)
	{
		SetValuePtr(property.ContainerPtrToValuePtr(obj, arrayIndex), value);
	}

	public void SetValue(IntPtr instance, T value, int arrayIndex = 0)
	{
		SetValuePtr(property.ContainerPtrToValuePtr(instance, arrayIndex), value);
	}

	public virtual void SetValuePtr(IntPtr address, T value)
	{
		if (customAccessor != null)
		{
			customAccessor.SetValuePtr(address, value);
		}
		else
		{
			Marshal.StructureToPtr(value, address, fDeleteOld: false);
		}
	}

	public T GetDefaultValue()
	{
		if (defaultValueAccessor != null)
		{
			return defaultValueAccessor.GetDefaultValue();
		}
		return default(T);
	}
}
