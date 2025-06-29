using System;
using System.Runtime.InteropServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.Function", "CoreUObject", UnrealModuleType.Engine)]
public class UFunction : UStruct
{
	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	public delegate void FuncInvokerNative(IntPtr obj, IntPtr stackPtr, IntPtr result);

	public delegate void FuncInvokerManaged(IntPtr buffer, IntPtr obj);

	public const string ReturnValuePropName = "ReturnValue";

	private CachedUObject<UFunction> superFunction;

	public EFunctionFlags FunctionFlags
	{
		get
		{
			return Native_UFunction.Get_FunctionFlags(base.Address);
		}
		set
		{
			Native_UFunction.Set_FunctionFlags(base.Address, value);
		}
	}

	public byte NumParms
	{
		get
		{
			return Native_UFunction.Get_NumParms(base.Address);
		}
		set
		{
			Native_UFunction.Set_NumParms(base.Address, value);
		}
	}

	public ushort ParmsSize
	{
		get
		{
			return Native_UFunction.Get_ParmsSize(base.Address);
		}
		set
		{
			Native_UFunction.Set_ParmsSize(base.Address, value);
		}
	}

	public ushort ReturnValueOffset
	{
		get
		{
			return Native_UFunction.Get_ReturnValueOffset(base.Address);
		}
		set
		{
			Native_UFunction.Set_ReturnValueOffset(base.Address, value);
		}
	}

	public ushort RPCId
	{
		get
		{
			return Native_UFunction.Get_RPCId(base.Address);
		}
		set
		{
			Native_UFunction.Set_RPCId(base.Address, value);
		}
	}

	public ushort RPCResponseId
	{
		get
		{
			return Native_UFunction.Get_RPCResponseId(base.Address);
		}
		set
		{
			Native_UFunction.Set_RPCResponseId(base.Address, value);
		}
	}

	public IntPtr FirstPropertyToInit
	{
		get
		{
			return Native_UFunction.Get_FirstPropertyToInit(base.Address);
		}
		set
		{
			Native_UFunction.Set_FirstPropertyToInit(base.Address, value);
		}
	}

	public IntPtr NativeFunc
	{
		get
		{
			return Native_UFunction.GetNativeFunc(base.Address);
		}
		set
		{
			Native_UFunction.SetNativeFunc(base.Address, value);
		}
	}

	public UFunction SuperFunction => superFunction.Update(Native_UFunction.GetSuperFunction(base.Address));

	public IntPtr ReturnProperty => Native_UFunction.GetReturnProperty(base.Address);

	public static IntPtr GetFunctionAddress(string path)
	{
		IntPtr intPtr = NativeReflection.FindObject(Classes.UFunction, IntPtr.Zero, path);
		_ = intPtr == IntPtr.Zero;
		return intPtr;
	}

	public static UFunction GetFunction(string path)
	{
		IntPtr functionAddress = GetFunctionAddress(path);
		if (functionAddress != IntPtr.Zero)
		{
			return GCHelper.Find<UFunction>(functionAddress);
		}
		return null;
	}

	public static IntPtr GetDelegateSignatureAddress<T>() where T : IDelegateBase
	{
		return GetDelegateSignatureAddress(typeof(T));
	}

	public static IntPtr GetDelegateSignatureAddress(Type type)
	{
		UUnrealTypePathAttribute pathAttribute = UnrealTypes.GetPathAttribute(type);
		if (pathAttribute != null)
		{
			if (pathAttribute.IsManagedType)
			{
				return ManagedUnrealTypes.GetDelegateSignatureAddress(type);
			}
			return GetFunctionAddress(pathAttribute.Path);
		}
		return IntPtr.Zero;
	}

	public static UDelegateFunction GetDelegateSignature<T>() where T : IDelegateBase
	{
		return GetDelegateSignature(typeof(T));
	}

	public static UDelegateFunction GetDelegateSignature(Type type)
	{
		IntPtr delegateSignatureAddress = GetDelegateSignatureAddress(type);
		if (delegateSignatureAddress != IntPtr.Zero)
		{
			return GCHelper.Find<UDelegateFunction>(delegateSignatureAddress);
		}
		return null;
	}

	public void InitializeDerivedMembers()
	{
		Native_UFunction.InitializeDerivedMembers(base.Address);
	}

	public UFunction GetSuperFunction()
	{
		return SuperFunction;
	}

	public FProperty GetReturnProperty()
	{
		return new FProperty(ReturnProperty);
	}

	public bool HasAnyFunctionFlags(EFunctionFlags flagsToCheck)
	{
		return Native_UFunction.HasAnyFunctionFlags(base.Address, flagsToCheck);
	}

	public bool HasAllFunctionFlags(EFunctionFlags flagsToCheck)
	{
		return Native_UFunction.HasAllFunctionFlags(base.Address, flagsToCheck);
	}

	public static EPropertyFlags GetDefaultIgnoredSignatureCompatibilityFlags()
	{
		return Native_UFunction.GetDefaultIgnoredSignatureCompatibilityFlags();
	}

	public bool IsSignatureCompatibleWith(UFunction otherFunction)
	{
		return Native_UFunction.IsSignatureCompatibleWith(base.Address, (otherFunction == null) ? IntPtr.Zero : otherFunction.Address);
	}

	public bool IsSignatureCompatibleWith(UFunction otherFunction, EFunctionFlags ignoreFlags)
	{
		return Native_UFunction.IsSignatureCompatibleWithFlags(base.Address, (otherFunction == null) ? IntPtr.Zero : otherFunction.Address, ignoreFlags);
	}

	internal FProperty GetFirstParam()
	{
		foreach (FProperty fField in GetFFields<FProperty>())
		{
			if (fField.HasAnyPropertyFlags(EPropertyFlags.Parm) && !fField.HasAnyPropertyFlags(EPropertyFlags.ReturnParm))
			{
				return fField;
			}
		}
		return null;
	}

	internal FProperty GetBlueprintReturnProperty()
	{
		UClass uClass = GetOwnerClass();
		if (!(uClass != null) || !uClass.IsA<UBlueprintGeneratedClass>())
		{
			return null;
		}
		if (GetReturnProperty() != null)
		{
			return null;
		}
		FProperty fProperty = null;
		foreach (FProperty fField in GetFFields<FProperty>())
		{
			if (fField.HasAnyPropertyFlags(EPropertyFlags.Parm) && fField.HasAnyPropertyFlags(EPropertyFlags.OutParm) && !fField.HasAnyPropertyFlags(EPropertyFlags.ReferenceParm))
			{
				if (fProperty != null)
				{
					return null;
				}
				fProperty = fField;
			}
		}
		return fProperty;
	}

	internal bool InternalIsSignatureCompatibleWith(UFunction otherFunction)
	{
		return InternalIsSignatureCompatibleWith(otherFunction, GetDefaultIgnoredSignatureCompatibilityFlags());
	}

	internal bool InternalIsSignatureCompatibleWith(UFunction otherFunction, EPropertyFlags ignoreFlags)
	{
		if (this == otherFunction)
		{
			return true;
		}
		TFFieldIterator<FProperty> tFFieldIterator = new TFFieldIterator<FProperty>(this);
		TFFieldIterator<FProperty> tFFieldIterator2 = new TFFieldIterator<FProperty>(otherFunction);
		while (tFFieldIterator.Current != null && tFFieldIterator.Current.PropertyFlags.HasFlag(EPropertyFlags.Parm))
		{
			if (tFFieldIterator2.Current != null && tFFieldIterator2.Current.PropertyFlags.HasFlag(EPropertyFlags.Parm))
			{
				FProperty current = tFFieldIterator.Current;
				FProperty current2 = tFFieldIterator2.Current;
				if (!ArePropertiesTheSame(current, current2, checkPropertiesNames: false))
				{
					return false;
				}
				if (((current.PropertyFlags ^ current2.PropertyFlags) & ~ignoreFlags) != ~EPropertyFlags.AllFlags)
				{
					return false;
				}
				tFFieldIterator.MoveNext();
				tFFieldIterator2.MoveNext();
				continue;
			}
			return false;
		}
		if (tFFieldIterator2.Current != null)
		{
			return !tFFieldIterator2.Current.PropertyFlags.HasFlag(EPropertyFlags.Parm);
		}
		return true;
	}

	private bool ArePropertiesTheSame(FProperty a, FProperty b, bool checkPropertiesNames)
	{
		if (a == b)
		{
			return true;
		}
		if (a == null || b == null)
		{
			return false;
		}
		if (checkPropertiesNames && a.GetFName() != b.GetFName())
		{
			return false;
		}
		if (a.GetSize() != b.GetSize())
		{
			return false;
		}
		if (a.GetOffset_ForGC() != b.GetOffset_ForGC())
		{
			return false;
		}
		if (!Native_FProperty.SameType(a.Address, b.Address))
		{
			return false;
		}
		return true;
	}

	public bool GetScriptName(out string name)
	{
		return GetScriptName(GetName(), out name);
	}

	public bool GetScriptName(string originalName, out string name)
	{
		string text = originalName;
		bool result = false;
		string metaData = this.GetMetaData(MDFunc.ScriptName);
		if (!string.IsNullOrEmpty(metaData))
		{
			text = metaData;
			result = true;
		}
		else
		{
			IntPtr intPtr = Native_UField.GetOwnerClass(base.Address);
			if (intPtr != IntPtr.Zero && (bool)Native_UClass.HasAnyClassFlags(intPtr, EClassFlags.Native))
			{
				while (text.StartsWith("K2_"))
				{
					text = text.Substring(3);
					result = true;
				}
			}
		}
		name = text;
		return result;
	}
}
