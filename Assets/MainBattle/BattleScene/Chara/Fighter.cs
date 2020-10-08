﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BattleScene;

namespace BattleScene.Chara
{
    

public class Fighter : Player
{
    TextManager textmanager;

    public Fighter(object usename) : base(usename){
        textmanager = GameObject.Find("battletext").GetComponent<TextManager>();
    }

    public override void Attack(Player defender,int turnNumber){
        int damage = calcDamage(defender);
        bool isParise = base.isParise();
        if(isParise == true){
            textmanager.battleLog(base.playername+"は麻痺した");
        }else{
            textmanager.battleLog(this.playername+"の攻撃 ➡ "+defender.playername+"に"+damage+"のダメージ");
            defender.damage(damage);
        }
        base.attackfinished = true;
    }
}

}