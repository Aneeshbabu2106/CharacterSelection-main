using UnityEngine;
public class TankModel 
{
    private TankController tankController;

    public float moveSpeed;
    public float rotateSpeed;
    public TankTypes tankTypes;
    public Material color;

    public TankModel(float _moveSpeed,float _rotateSpeed, TankTypes _tankType, Material _color)
    {
        moveSpeed = _moveSpeed;
        rotateSpeed = _rotateSpeed;
        tankTypes = _tankType;
        color = _color;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
