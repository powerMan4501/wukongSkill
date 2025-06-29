using System;
using System.IO;
using System.Reflection;
using System.Text;
using b1.GSFile;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUFuncLibDeviceInfoCS")]
public class BGUFuncLibDeviceInfoCS : UBlueprintFunctionLibrary
{
	public static B1DeviceInfo _DeviceInfo;

	private static readonly string sLocalDeviceFilePath;

	public static B1DeviceInfo DeviceInfo
	{
		get
		{
			if (_DeviceInfo == null)
			{
				LazyInitDeviceInfo();
			}
			return _DeviceInfo;
		}
	}

	private static void LazyInitDeviceInfo()
	{
		_DeviceInfo = new B1DeviceInfo();
		bool flag = false;
		foreach (EPlatformType value in Enum.GetValues(typeof(EPlatformType)))
		{
			if (UGameplayStatics.GetPlatformName() == value.ToString())
			{
				flag = true;
				_DeviceInfo.PlatformName = value;
			}
		}
		if (!flag)
		{
			_DeviceInfo.PlatformName = EPlatformType.Unknown;
		}
		UGSE_EngineFuncLib.GetDeviceInfo(out var Cpu, out var Gpu, out var MemSize);
		_DeviceInfo.CPU = Cpu;
		_DeviceInfo.GPU = Gpu;
		_DeviceInfo.MemeryMB = MemSize;
		_DeviceInfo.DefaultLanguage = UGSE_EngineFuncLib.GetDefaultLanguageCS();
		WriteDeviceInfoToLocalFile();
	}

	public static B1DeviceInfo GetDeviceInfo()
	{
		return DeviceInfo;
	}

	public static void WriteDeviceInfoToLocalFile()
	{
		if (_DeviceInfo != null)
		{
			StringBuilder stringBuilder = new StringBuilder();
			FieldInfo[] fields = typeof(B1DeviceInfo).GetFields();
			foreach (FieldInfo fieldInfo in fields)
			{
				stringBuilder.AppendLine(fieldInfo.Name + ":" + fieldInfo.GetValue(_DeviceInfo).ToString());
			}
			File.WriteAllText(sLocalDeviceFilePath, stringBuilder.ToString());
		}
	}

	private static void ReadDeviceInfoFromLoaclFile()
	{
		_DeviceInfo = new B1DeviceInfo();
	}

	static BGUFuncLibDeviceInfoCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUFuncLibDeviceInfoCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUFuncLibDeviceInfoCS));
		_DeviceInfo = null;
		sLocalDeviceFilePath = Path.Combine(GSEFileUtil.ProjectPersistentDownloadDir, "DeviceInfoFile.txt");
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUFuncLibDeviceInfoCS");
	}
}
