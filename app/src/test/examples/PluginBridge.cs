using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

namespace chillst.plugins {
	public class PluginBridge {
		public static void vibrate(long milliseconds) {
			#if UNITY_ANDROID
			if (Application.platform == RuntimePlatform.Android) {
				using (var javaUnityPlayer = new AndroidJavaClass ("com.unity3d.player.UnityPlayer")) {
					using (var currentActivity = javaUnityPlayer.GetStatic<AndroidJavaObject> ("currentActivity")) {
						using (var vibratePlugin = new AndroidJavaObject ("com.chillst.vibrationutil.VibratePlugin")) {
							vibratePlugin.Call ("vibrate", currentActivity, milliseconds);
						}
					}
				}
			}
			#endif
		}
	}
}
