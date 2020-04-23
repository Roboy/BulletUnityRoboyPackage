using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Roboy.BulletBridge
{
    public class BridgeUtilities : MonoBehaviour
    {
        Vector3 ConvertPosFromUnity2Bullet(Vector3 Input)
        {
            Vector3 Output = Vector3.zero;
            return Output;
        }

        Quaternion ConvertRotFromUnity2Bullet(Quaternion Input)
        {
            Quaternion Output = Quaternion.identity;
            return Output;
        }
        Vector3 ConvertPosFromBullet2Unity(Vector3 Input)
        {
            Vector3 Output = Vector3.zero;
            return Output;
        }

        Quaternion ConvertRotFromBullet2Unity(Quaternion Input)
        {
            Quaternion Output = Quaternion.identity;
            return Output;
        }
    }
}
