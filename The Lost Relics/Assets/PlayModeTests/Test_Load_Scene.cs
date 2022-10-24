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
        DataPercistenceManager dataPercistenceObject = go.AddComponent<DataPercistenceManager>();
      
        string startScene = "Tutorial";

        dataPercistenceObject.newGame();

        yield return new WaitForSeconds(0.1f);

        string getSceneName = dataPercistenceObject.getSceneName();
        Assert.AreEqual(startScene, getSceneName);
        GameObject.Destroy(dataPercistenceObject.gameObject);

    }



    [Test]
    public void Test_Move_Scene_Passes()
    {
        GameObject go = GameObject.Instantiate(new GameObject());

        DataPercistenceManager dataPercistenceObject = go.AddComponent<DataPercistenceManager>();

        string nextSceneName = "hello";

        dataPercistenceObject.nextScene(nextSceneName);

        string savedSceneName = dataPercistenceObject.getSceneName();
        //Assert.Equals(nextSceneName, savedSceneName);
        Assert.AreEqual(nextSceneName, savedSceneName);
        GameObject.Destroy(dataPercistenceObject.gameObject);
    }




}
