using UnityEngine;
using UnityEngine.SceneManagement;//Unity�G���W���̃V�[���Ǘ��v���O�����𗘗p����

public class SceneLoader : MonoBehaviour //SceneLoader�Ƃ������O�ɂ��܂�
{
      float timer = 0;

    private void Update()
    {
        timer += Time.deltaTime;
    }
    public void EndingGame()
    {
        GetComponent<AudioSource>().Play();
        //3�b��Ƀ��\�b�h�����s����
        Invoke("Start_button", 3);
    }
    public void Start_button()//string_button�Ƃ������O�ɂ��܂�
    {
            SceneManager.LoadScene("baseballgame");//second���Ăяo���܂�
    }
}