using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankView;
    [System.Serializable]
    public class Tank
    {
        public TankTypes tankTypes;
        public Material color;
        public float movementSpeed;
        public float rotateSpeed;
        
    }

    public List<Tank> tankList;
    // Start is called before the first frame update
    void Start()
    {
        CreateTank();
    }

    private void CreateTank()
    {
        TankModel tankModel = new TankModel(tankList[0].movementSpeed, tankList[0].rotateSpeed, tankList[0].tankTypes, tankList[0].color);
        TankController tankController = new TankController(tankModel,tankView);
    }

}
