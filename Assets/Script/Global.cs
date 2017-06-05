using UnityEngine;
using System.Collections;

public class Global : SingletonMonoBehaviour<Global>
{

    /*---------------------------------------------------
     * 定数
     * --------------------------------------------------*/
    // シーン名
    public const string CnsSceneTraining = "Training";
    public const string CnsSceneChallenge = "Challenge";

    public const string CnsSceneTraQ1Spec = "TraQ1Spec";
    public const string CnsSceneTraQ1Question = "TraQ1Question";

    public const string CnsSceneChaQ1Spec = "ChaQ1Spec";
    public const string CnsSceneChaQ1Question = "ChaQ1Question";

    /*---------------------------------------------------
     * 変数
     * --------------------------------------------------*/
    public static string NextSceneName = "";    // 次に遷移するシーン名

    // シングルトン使用
    void Awake()
    {
        if (this != Instance){
            Destroy(this);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
