using UnityEngine;

public static class Utils
{
    /// <summary>
    ///  각도를 기준으로 원의 둘레 위치를 구하는 메소드
    /// </summary>
    /// <param name="radians"></param>
    /// <param name="angle"></param>
    public static Vector3 GetPositionFromAngle(float radians, float angle)
    {
        Vector3 position = Vector3.zero;
        angle = DegreeToRadius(angle);

        position.x = Mathf.Cos(angle) * radians;
        position.y = Mathf.Sin(angle) * radians;

        return position;
    }

    /// <summary>
    /// Degree 값을 Radian 값으로 변환
    /// 1도는 "PI/180" radian
    /// angle도는 "PI/180 * angle" radian
    /// </summary>
    /// <param name="angle"></param>
    public static float DegreeToRadius(float angle)
    {
        return Mathf.PI * angle / 180.0f;
    }
}
