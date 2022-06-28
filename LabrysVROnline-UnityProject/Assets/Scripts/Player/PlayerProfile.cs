using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProfile : MonoBehaviour
{
    public static event Action NotifyLevelUp;
    public static event Action NorifyAchievement;

    private char id;
    private char playerName;
    private int level;
    private float xp;
    private float wallet;
    private Achievements[] achievements;
    private Equipment[] currentEquipments;

    public void EquipmentPurchased(){
        // Adiciona o equipamento da loja no profile do player
    }

    public void ReceiveXp(){
        // Recebe xp e faz cálculo para upar de nível
    }

    public Equipment[] GetEquipment(){
        return this.currentEquipments;
    }
}
