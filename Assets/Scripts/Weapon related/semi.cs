using UnityEngine;

[CreateAssetMenu(fileName = "Semi Gun", menuName = "Guns/Semi")]
public class semi : Gun
{

    public override void OnLeftMouseDown(Transform cameraPos)
    {
        Fire(cameraPos);
    }
}
