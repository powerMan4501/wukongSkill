using System;
using System.Collections.Generic;
using System.Linq;

namespace b1;

public static class FCooperationDeviceInfo
{
	public static List<CooperationDeviceType> GetCooperationDevices(List<string> ProductStringList)
	{
		List<CooperationDeviceType> list = new List<CooperationDeviceType>();
		foreach (CooperationDeviceType item in Enum.GetValues(typeof(CooperationDeviceType)).Cast<CooperationDeviceType>())
		{
			if (LexToProductStringList(item).Intersect(ProductStringList).Any())
			{
				list.Add(item);
			}
		}
		return list;
	}

	private static List<string> LexToProductStringList(CooperationDeviceType Enum)
	{
		return Enum switch
		{
			CooperationDeviceType.Flydigi => new List<string> { "Controller (Flydigi APEX4 HSH Wireless)", "Controller (Flydigi APEX4 HSH)" }, 
			CooperationDeviceType.EightBitDo => new List<string> { "8BitDo Ultimate 2C Wired (WUKONG)" }, 
			CooperationDeviceType.EightBitDoWireless => new List<string> { "8BitDo Ultimate 2C Wireless (WUKONG)" }, 
			_ => new List<string>(), 
		};
	}
}
