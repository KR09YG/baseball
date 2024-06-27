using UnityEngine;
using UnityEngine.SceneManagement;//Unityエンジンのシーン管理プログラムを利用する

public class SceneLoader : MonoBehaviour //SceneLoaderという名前にします
{
      float timer = 0;

    private void Update()
    {
        timer += Time.deltaTime;
    }
    public void EndingGame()
    {
        GetComponent<AudioSource>().Play();
        //3秒後にメソッドを実行する
        Invoke("Start_button", 3);
    }
    public void Start_button()//string_buttonという名前にします
    {
            SceneManager.LoadScene("baseballgame");//secondを呼び出します
    }
}