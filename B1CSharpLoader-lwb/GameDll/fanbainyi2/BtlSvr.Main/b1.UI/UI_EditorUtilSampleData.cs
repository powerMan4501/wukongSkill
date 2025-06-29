using System;
using UnrealEngine.Runtime;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.UI_EditorUtilSampleData")]
internal class UI_EditorUtilSampleData : UObject
{
	private static bool TextData_IsValid;

	private static int TextData_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UI_EditorUtilSampleData:TextData")]
	public string TextData
	{
		get
		{
			CheckDestroyed();
			if (!TextData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UI_EditorUtilSampleData:TextData");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, TextData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UI_EditorUtilSampleData:TextData");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, TextData_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.UI_EditorUtilSampleData");
		TextData_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TextData");
		TextData_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TextData", Classes.FStrProperty);
	}

	static UI_EditorUtilSampleData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.UI_EditorUtilSampleData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.UI_EditorUtilSampleData));
	}
}
