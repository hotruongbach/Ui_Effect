using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalPushManager
{

    // Start is called before the first frame update
    public static void updateLastOpen()
    {
        AndroidJavaClass localPushManagerClass = new AndroidJavaClass("com.imosys.notification.local.LocalPushManager");
        localPushManagerClass.CallStatic("updateLastOpened");
    }

    public static void UpdatePushConfig(long pushTime, string pushText, long timeFromOpen, long pushInterval) {
        AndroidJavaClass localPushManagerClass = new AndroidJavaClass("com.imosys.notification.local.LocalPushManager");
        localPushManagerClass.CallStatic("updateConfig", pushTime, pushText, timeFromOpen, pushInterval);
    }
}
