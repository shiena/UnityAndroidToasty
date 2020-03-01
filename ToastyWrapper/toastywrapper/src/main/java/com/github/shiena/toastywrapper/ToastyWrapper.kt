package com.github.shiena.toastywrapper

import com.unity3d.player.UnityPlayer
import es.dmoral.toasty.Toasty

@Suppress("unused")
object ToastyWrapper {
    @JvmStatic
    fun success(message: String) {
        val msg = (if (BuildConfig.DEBUG) "IN DEBUG: " else "") + message
        Toasty.success(UnityPlayer.currentActivity, msg).show()
    }
}