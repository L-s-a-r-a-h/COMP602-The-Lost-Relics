using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UIElements;

public class Test_data_Save
{
    private GameObject go;
    private DataPercistenceManager dpm;
   

    [SetUp]
    public void SetUp()
    {
       
        go = GameObject.Instantiate(new GameObject());
       // go.AddComponent<DataPercistenceManager>();
        dpm  = go.AddComponent<DataPercistenceManager>();



    }

    // [UnityTest]
    [Test]
    public void Test_DataPercistenceManager_Instantiates_Passes()
    {
        Assert.NotNull(dpm);
       
      //  yield return null;
       
    }

    [UnityTest]
    public IEnumerator Test_New_Game_Passes()
    {
        string startScene = "Tutorial";

        dpm.newGame();

        yield return new WaitForSeconds(0.1f);
        string getSceneName = dpm.getSceneName();
        Assert.AreEqual(startScene, getSceneName);
      
    }



    [Test]
    public void Test_Save_Scene_Name_Passes()
    {
        string nextSceneName = "hello";

        dpm.nextScene(nextSceneName);

        string savedSceneName = dpm.getSceneName();
        //Assert.Equals(nextSceneName, savedSceneName);
        Assert.AreEqual(nextSceneName, savedSceneName);
       
    }
  

    [TearDown]
    public void TearDown()
    {
        GameObject.Destroy(go);
    
    }

}
