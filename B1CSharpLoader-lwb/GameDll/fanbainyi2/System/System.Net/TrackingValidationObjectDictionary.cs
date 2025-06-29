using System.Collections.Generic;
using System.Collections.Specialized;

namespace System.Net;

internal class TrackingValidationObjectDictionary : StringDictionary
{
	internal delegate object ValidateAndParseValue(object valueToValidate);

	private IDictionary<string, object> internalObjects;

	private readonly IDictionary<string, ValidateAndParseValue> validators;

	internal bool IsChanged { get; set; }

	public override string this[string key]
	{
		get
		{
			return base[key];
		}
		set
		{
			PersistValue(key, value, addValue: false);
		}
	}

	internal TrackingValidationObjectDictionary(IDictionary<string, ValidateAndParseValue> validators)
	{
		IsChanged = false;
		this.validators = validators;
	}

	private void PersistValue(string key, string value, bool addValue)
	{
		key = key.ToLowerInvariant();
		if (string.IsNullOrEmpty(value))
		{
			return;
		}
		if (validators != null && validators.ContainsKey(key))
		{
			object obj = validators[key](value);
			if (internalObjects == null)
			{
				internalObjects = new Dictionary<string, object>();
			}
			if (addValue)
			{
				internalObjects.Add(key, obj);
				base.Add(key, obj.ToString());
			}
			else
			{
				internalObjects[key] = obj;
				base[key] = obj.ToString();
			}
		}
		else if (addValue)
		{
			base.Add(key, value);
		}
		else
		{
			base[key] = value;
		}
		IsChanged = true;
	}

	internal object InternalGet(string key)
	{
		if (internalObjects != null && internalObjects.ContainsKey(key))
		{
			return internalObjects[key];
		}
		return base[key];
	}

	internal void InternalSet(string key, object value)
	{
		if (internalObjects == null)
		{
			internalObjects = new Dictionary<string, object>();
		}
		internalObjects[key] = value;
		base[key] = value.ToString();
		IsChanged = true;
	}

	public override void Add(string key, string value)
	{
		PersistValue(key, value, addValue: true);
	}

	public override void Clear()
	{
		if (internalObjects != null)
		{
			internalObjects.Clear();
		}
		base.Clear();
		IsChanged = true;
	}

	public override void Remove(string key)
	{
		if (internalObjects != null && internalObjects.ContainsKey(key))
		{
			internalObjects.Remove(key);
		}
		base.Remove(key);
		IsChanged = true;
	}
}
