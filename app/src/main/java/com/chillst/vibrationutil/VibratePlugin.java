package com.chillst.vibrationutil;

import android.app.Activity;
import android.content.Context;
import android.os.Vibrator;

/**
 * Created by davidmsibley on 6/7/2016.
 */
public class VibratePlugin {

    public void vibrate(Activity activity, long duration) {
        Vibrator v = (Vibrator) activity.getSystemService(Context.VIBRATOR_SERVICE);
        v.vibrate(duration);
    }
}
