namespace UnrealEngine.Runtime;

public static class MetadataExtensions
{
	public static bool HasMetaData<TEnum>(this UField field, TEnum key) where TEnum : struct
	{
		return field.HasMetaData(UMeta.GetKey(key));
	}

	public static string GetMetaData<TEnum>(this UField field, TEnum key) where TEnum : struct
	{
		return field.GetMetaData(UMeta.GetKey(key));
	}

	public static void SetMetaData<TEnum, T>(this UField field, TEnum key, T value) where TEnum : struct
	{
		string text = null;
		UClass uClass = value as UClass;
		field.SetMetaData(value: (!(uClass != null)) ? value.ToString() : uClass.GetPathName(), key: UMeta.GetKey(key));
	}

	public static bool GetBoolMetaData<TEnum>(this UField field, TEnum key) where TEnum : struct
	{
		return field.GetBoolMetaData(UMeta.GetKey(key));
	}

	public static int GetIntMetaData<TEnum>(this UField field, TEnum key) where TEnum : struct
	{
		return field.GetIntMetaData(UMeta.GetKey(key));
	}

	public static float GetFloatMetaData<TEnum>(this UField field, TEnum key) where TEnum : struct
	{
		return field.GetFloatMetaData(UMeta.GetKey(key));
	}

	public static UClass GetClassMetaData<TEnum>(this UField field, TEnum key) where TEnum : struct
	{
		return field.GetClassMetaData(UMeta.GetKey(key));
	}

	public static bool GetBoolMetaDataHierarchical<TEnum>(this UStruct unrealStruct, TEnum key) where TEnum : struct
	{
		return unrealStruct.GetBoolMetaDataHierarchical(new FName(UMeta.GetKey(key)));
	}

	public static bool GeStringMetaDataHierarchical<TEnum>(this UStruct unrealStruct, TEnum key) where TEnum : struct
	{
		return unrealStruct.GeStringMetaDataHierarchical(new FName(UMeta.GetKey(key)));
	}
}
