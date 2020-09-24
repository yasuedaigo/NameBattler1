﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace InputFieldManager
{

public class InputFieldManager:MonoBehaviour
{
    InputField inputField;
    string charaname;
    bool nameOk;

    // Start is called before the first frame update
    void Start()
    {
        inputField = GameObject.Find("InputField").GetComponent<InputField>();
        nameOk = false;
        
    }

    public void NameEnter()
    {
        //InputFieldからテキスト情報を取得する
        charaname = inputField.text;
        if(charaname == null || charaname == ""){
            nameOk = false;
        }else{
            nameOk = true;
        }
        Debug.Log("inputfieldのメソッド charaname="+charaname);
        Debug.Log("inputfieldのメソッド nameOk="+nameOk);
    }

    public string GetName(){
        return charaname;
    }

    public bool NameCheck(){
        if(nameOk == true){
           return true;
        }else{
            return false;
        }
    }
    
}

}