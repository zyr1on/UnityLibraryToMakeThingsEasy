//ScreenBounds bounds = ScreenBounds.GetScreenBounds();
// bounds.min.x bounds.max.x bounds.min.y bounds.max.y
using UnityEngine;
public struct ScreenBounds {
    public Vector2 min { get; set; }
    public Vector2 max { get; set; }
    public ScreenBounds(Vector2 min, Vector2 max)
    {
        this.min = min;
        this.max = max;
    }
    public static ScreenBounds GetScreenBounds()
    {
        Vector3 bottomLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));
        Vector3 topRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, Camera.main.nearClipPlane));
        return new ScreenBounds(new Vector2(bottomLeft.x, bottomLeft.y), new Vector2(topRight.x, topRight.y));
    }
}
