using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public void toMap()
    {
        SceneManager.LoadScene("Map_Scene");  //Mapシーンへ遷移
    }

    public void toStage1()
    {
        SceneManager.LoadScene("Stage1_Scene");  //Stage1シーンへ遷移
    }

    public void toStage2()
    {
        SceneManager.LoadScene("Stage2_Scene");  //Stage2シーンへ遷移
    }

    public void toStage3()
    {
        SceneManager.LoadScene("Stage3_Scene");  //Stage3シーンへ遷移
    }

    public void toStage4()
    {
        SceneManager.LoadScene("Stage4_Scene");  //Stage4シーンへ遷移
    }

    public void toStage5()
    {
        SceneManager.LoadScene("Stage5_Scene");  //Stage5シーンへ遷移
    }

    public void toStage6()
    {
        SceneManager.LoadScene("Stage6_Scene");  //Stage6シーンへ遷移
    }

    public void toStage7()
    {
        SceneManager.LoadScene("Stage7_Scene");  //Stage7シーンへ遷移
    }

    public void toStage8()
    {
        SceneManager.LoadScene("Stage8_Scene");  //Stage8シーンへ遷移
    }

    public void toStage9()
    {
        SceneManager.LoadScene("Stage9_Scene");  //Stage9シーンへ遷移
    }

    public void toOption()
    {
        SceneManager.LoadScene("Option_Scene");  //Optionシーンへ遷移
    }

    public void toCredit()
    {
        SceneManager.LoadScene("Credit_Scene");  //Creditシーンへ遷移
    }

    public void toTitle()
    {
        SceneManager.LoadScene("Title_Scene");  //Titleシーンへ遷移
    }
}
