using UnityEngine;

public class Toasty : MonoBehaviour
{
#if UNITY_ANDROID
    private AndroidJavaClass _jc;

    private void OnEnable()
    {
        _jc = new AndroidJavaClass("com.github.shiena.toastywrapper.ToastyWrapper");
    }

    private void OnDisable()
    {
        _jc?.Dispose();
    }

    public void Success(string message)
    {
        _jc?.CallStatic("success", message);
    }
#else
    public void Success(string message)
    {
    }
#endif
}
