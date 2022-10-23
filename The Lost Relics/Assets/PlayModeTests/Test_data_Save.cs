using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UIElements;

public class Test_data_Save
{

 
    [Test]
    public void Test_DataPercistenceManager_Instantiates_Passes()
    {
        GameObject go = GameObject.Instantiate(new GameObject());

        DataPercistenceManager dpm  = go.AddComponent<DataPercistenceManager>();
        Assert.NotNull(dpm);
        GameObject.Destroy(dpm.gameObject);


    }

    [UnityTest]
    public IEnumerator Test_New_Game_Passes()
    {
        GameObject go = GameObject.Instantiate(new GameObject());

        DataPercistenceManager dpm = go.AddComponent<DataPercistenceManager>();
        string startScene = "Tutorial";

        dpm.newGame();

        yield return new WaitForSeconds(0.1f);
        string getSceneName = dpm.getSceneName();
        Assert.AreEqual(startScene, getSceneName);
        GameObject.Destroy(dpm.gameObject);

    }



    [Test]
    public void Test_Save_Scene_Name_Passes()
    {
        GameObject go = GameObject.Instantiate(new GameObject());

        DataPercistenceManager dpm = go.AddComponent<DataPercistenceManager>();

        string nextSceneName = "hello";

        dpm.nextScene(nextSceneName);

        string savedSceneName = dpm.getSceneName();
        //Assert.Equals(nextSceneName, savedSceneName);
        Assert.AreEqual(nextSceneName, savedSceneName);
        GameObject.Destroy(dpm.gameObject);
    }




}
