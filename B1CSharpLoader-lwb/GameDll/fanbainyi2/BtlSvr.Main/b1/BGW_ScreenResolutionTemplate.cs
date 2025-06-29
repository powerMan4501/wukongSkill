using System.Collections.Generic;
using System.Runtime.InteropServices;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGW_ScreenResolutionTemplate : BGW_GameSettingTemplateBase
{
	public struct DEVMODEW
	{
		private const int CCHDEVICENAME = 32;

		private const int CCHFORMNAME = 32;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string dmDeviceName;

		public short dmSpecVersion;

		public short dmDriverVersion;

		public short dmSize;

		public short dmDriverExtra;

		public int dmFields;

		public short dmOrientation;

		public short dmPaperSize;

		public short dmPaperLength;

		public short dmPaperWidth;

		public short dmScale;

		public short dmCopies;

		public short dmDefaultSource;

		public short dmPrintQuality;

		public short dmColor;

		public short dmDuplex;

		public short dmYResolution;

		public short dmTTOption;

		public short dmCollate;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string dmFormName;

		public short dmLogPixels;

		public int dmBitsPerPel;

		public int dmPelsWidth;

		public int dmPelsHeight;

		public int dmDisplayFlags;

		public int dmDisplayFrequency;
	}

	[DllImport("user32.dll")]
	public static extern bool EnumDisplaySettings(string deviceName, int modeNum, ref DEVMODEW devMode);

	public override int GetDefaultValueAndApplySetting(UObject WorldContext, Dictionary<UISettingConfigType, int> SettingRecommendDict, UISettingConfigType SettingType)
	{
		DEVMODEW devMode = default(DEVMODEW);
		devMode.dmSize = (short)Marshal.SizeOf(devMode);
		if (EnumDisplaySettings(null, -1, ref devMode))
		{
			int dmPelsWidth = devMode.dmPelsWidth;
			int dmPelsHeight = devMode.dmPelsHeight;
			if (FPlatformProperties.GetPlatform() == EPlatform.Windows)
			{
				foreach (FIntPoint item in UGSE_SystemSettingsFuncLib.GetAvailableResolutionsByMonitorID(BGW_SettingFuncUtil.GetMainMonitorID()))
				{
					if (item.X == dmPelsWidth && item.Y == dmPelsHeight)
					{
						BGW_SettingFuncUtil.SetScreenResolution(WorldContext, item, SettingRecommendDict);
					}
				}
			}
		}
		return 0;
	}

	public override void ApplySettingStartGame(UObject WorldContext, int NewValue, Dictionary<UISettingConfigType, GsCvarData> ConsoleVariableDict)
	{
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		if (gameUserSettings != null)
		{
			BGW_SettingFuncUtil.LastManualScreenResolution = gameUserSettings.GetScreenResolution();
		}
	}
}
