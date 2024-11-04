using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET.Client
{
	[FriendOf(typeof(UIGameStart))]
	public static partial class UIGameStartSystem
	{
		public static void RegisterUIEvent(this UIGameStart self)
		{
		self.ReloadUIEvent(); 
		}

		public static void ReloadUIEvent(this UIGameStart self)
		{
		 
		}

		public static void Focus(this UIGameStart self)
		{
		 
		}

		public static void UnFocus(this UIGameStart self)
		{
		 
		}

		public static void ShowWindow(this UIGameStart self, Entity contextData = null)
		{
		 
		}
	}
}
