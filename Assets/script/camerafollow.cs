using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform player;

    private Vector3 distance;

    void Start()
    {
        // فاصله اولیه دوربین تا پلیر را ذخیره می‌کند
        distance = transform.position - player.position;
    }

    void LateUpdate()
    {
        // دوربین همیشه با همان فاصله، دنبال پلیر حرکت می‌کند
        transform.position = player.position + distance;
    }
}
